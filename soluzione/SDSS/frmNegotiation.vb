Imports mapControl
Imports System.Windows.Media

Public Class frmNegotiation

#Region " Variables and constants "

	Private Const barWidth As Double = 0.4
	Private Const columnMaxHeight As Double = 2.5

	Private Enum WriteToGUIType
		input = 0
		output = 1
	End Enum

	Private myMap As mapControl.mapControl

	Private nudCollection As New nudCollection
	Private lblCollection As New lblCollection

	Private dummy As Double

	Private myMathWrapper As MW.MathWrapper

	Private groupBoxesID As Integer
	Private groupBoxes(5) As DSSGroupBox

	Private regions() As String = {"Al - Baha", "Al - Gassem", "Al - Jouf", "Aseer", "Eastern Area", "Hail", "Jizan", "Madina", "Mecca", "Najran", "North Border", "Riyadh", "Tabouk"}
	Private sizes() As String = {"small", "medium"}

	'mathematica algorithm variables
	'current costs
	Private indcc(12, 1), agrcc(12, 1), lancc(12, 1), des(12), gro(12) As Double
	'current water quality indicators
	Private lbqi(12, 1), lsqi(12, 1), lmqi(12, 1), bod(12), tds(12), tss(12) As Double
	'current population
	Private pop20(12, 1) As Integer
	'industrial districts
	Private inddis(12, 1), inddiscur(12, 1), inddispln(12, 1) As Integer
	'misc
	Private gwsp, agruf, agrufro, induf, indufro, lanuf, lanufro, tpbx, tpsx, tpmz, envw, ecow, socw, totpla, sbqi, ssqi, smqi As Double
	'output
	Private outind(12), outagr(12, 1), outlan(12, 1), outeco(12, 1), outsoc(12, 1), outenv(12, 1) As Double

#End Region

#Region " New "

	Public Sub New()
		' Chiamata richiesta da Progettazione Windows Form.
		InitializeComponent()

		' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
		Me.SqlConnection.ConnectionString = My.Settings.SDSSConnectionString

		Me.daLocations.Fill(Me.DSLocations)

		Me.myMap = DirectCast(Me.ElementHost1.Child, mapControl.mapControl)

		If Me.Init() Then
			'init groupBoxes array
			Me.groupBoxes(0) = Me.grbWaterCosts
			Me.groupBoxes(1) = Me.grbWaterQuality
			Me.groupBoxes(2) = Me.grbPopulation
			Me.groupBoxes(3) = Me.grbIndustrialDistricts
			Me.groupBoxes(4) = Me.grbMisc
			Me.groupBoxes(5) = Me.grbOuput

			Me.groupBoxesID = 0
			Me.ShowBox()
		Else
			End
		End If
	End Sub

#End Region

#Region " Private methods "

	Private Sub RefreshMap(sender As Object, e As EventArgs)
		If Me.IsHandleCreated Then
			Dim tmpNumericUpDown As DSSNumericUpDown
			Dim tmpLabel As DSSLabel
			Dim tmpGroupBox As DSSGroupBox
			Dim tmpPanel As DSSPanel
			Dim avgValue As Double

			tmpNumericUpDown = Nothing
			tmpPanel = Nothing
			tmpGroupBox = Nothing

			Select Case sender.GetType
				Case GetType(DSSGroupBox)
					tmpGroupBox = DirectCast(sender, DSSGroupBox)
				Case GetType(DSSPanel)
					tmpPanel = DirectCast(sender, DSSPanel)
					tmpGroupBox = DirectCast(tmpPanel.Parent, DSSGroupBox)
				Case GetType(DSSNumericUpDown)
					tmpNumericUpDown = DirectCast(sender, DSSNumericUpDown)
					tmpPanel = DirectCast(tmpNumericUpDown.Parent, DSSPanel)
					tmpGroupBox = DirectCast(tmpPanel.Parent, DSSGroupBox)
			End Select

			If tmpGroupBox.DSSDrawOnMap Then
				Me.myMap.ClearMap()

				For Each tmpPanel In tmpGroupBox.DSSpnlCollection
					avgValue = tmpPanel.DSSAverageValue

					For Each tmpNumericUpDown In tmpPanel.DSSnudCollection
						Me.DrawOnMap(tmpNumericUpDown.DSSLocation, tmpNumericUpDown.Value, avgValue, tmpNumericUpDown.DSSElementName, tmpNumericUpDown.DSSOffset, tmpNumericUpDown.DSSElementColor)
					Next
					For Each tmpLabel In tmpPanel.DSSlblCollection
						Me.DrawOnMap(tmpLabel.DSSLocation, tmpLabel.DSSValue, avgValue, tmpLabel.DSSElementName, tmpLabel.DSSOffset, tmpLabel.DSSElementColor)
					Next
				Next
			End If
		End If
	End Sub

	''' <summary>
	''' Plots graphical data on map
	''' </summary>
	''' <param name="DSSLocation">ID of the target location</param>
	''' <param name="value">value to rapresent</param>
	''' <param name="avgValue">medium value for the location</param>
	''' <param name="elementName">name of graphical element (must be unique)</param>
	''' <param name="offset">horizontal offset of the data bar</param>
	''' <param name="elementColor">bar color</param>
	Private Sub DrawOnMap(DSSLocation As Integer, value As Double, avgValue As Double, elementName As String, offset As Double, elementColor As Color)
		Dim tmpDataRowView As DataRowView
		Dim normalizedValue, locLatitude, locLongitude As Double

		If DSSLocation <> 0 Then
			Me.DSLocations.locations.DefaultView.RowFilter = "locID = " & DSSLocation

			tmpDataRowView = Me.DSLocations.locations.DefaultView(0)

			locLatitude = Utility.NullToDouble(tmpDataRowView("locLatitude"))
			locLongitude = Utility.NullToDouble(tmpDataRowView("locLongitude"))
			normalizedValue = value / avgValue * columnMaxHeight - columnMaxHeight

			Me.myMap.AddLine("line_" & elementName, Colors.Black, locLatitude, locLongitude - offset, locLatitude, locLongitude + offset + barWidth)
			Me.myMap.AddBar("bar_" & elementName, elementColor, locLatitude, locLongitude + offset, barWidth, normalizedValue)
		End If

	End Sub

	''' <summary>
	''' execute computation using Wolfram Mathematica kernel
	''' </summary>
	''' <remarks></remarks>
	Private Sub Calculate()
		Dim i, j As Integer

		Me.ReadValuesFromGUI()

		'(*current population*)
		For i = 0 To 12
			For j = 0 To 1
				Me.myMathWrapper.WaitAndDiscardAnswer("pop20[" & i + 1 & "][" & j + 1 & "]=" & NumberAsString(Me.pop20(i, j)))
			Next
		Next

		Me.myMathWrapper.WaitAndDiscardAnswer("totpop20 = Sum[pop20[i][j], {i, 1, 13}, {j, 1, 2}]")

		'(*current costs*)
		For i = 0 To 12
			For j = 0 To 1
				Me.myMathWrapper.WaitAndDiscardAnswer("agrcc[" & i + 1 & "][" & j + 1 & "]=" & NumberAsString(Me.agrcc(i, j)))
				Me.myMathWrapper.WaitAndDiscardAnswer("indcc[" & i + 1 & "][" & j + 1 & "]=" & NumberAsString(Me.indcc(i, j)))
				Me.myMathWrapper.WaitAndDiscardAnswer("lancc[" & i + 1 & "][" & j + 1 & "]=" & NumberAsString(Me.lancc(i, j)))
			Next
		Next

		'(*3 current water quality indicators: BOD=b, TDS=s, TSS=m*)
		For i = 0 To 12
			For j = 0 To 1
				Me.myMathWrapper.WaitAndDiscardAnswer("lbqi[" & i + 1 & "][" & j + 1 & "]=" & NumberAsString(Me.lbqi(i, j)))
				Me.myMathWrapper.WaitAndDiscardAnswer("lsqi[" & i + 1 & "][" & j + 1 & "]=" & NumberAsString(Me.lsqi(i, j)))
				Me.myMathWrapper.WaitAndDiscardAnswer("lmqi[" & i + 1 & "][" & j + 1 & "]=" & NumberAsString(Me.lmqi(i, j)))
			Next
		Next

		Me.myMathWrapper.WaitAndDiscardAnswer("gwsp=" & NumberAsString(Me.gwsp))
		Me.myMathWrapper.WaitAndDiscardAnswer("agrUF=" & NumberAsString(Me.agruf))
		Me.myMathWrapper.WaitAndDiscardAnswer("agrUFRO=" & NumberAsString(Me.agrufro))
		Me.myMathWrapper.WaitAndDiscardAnswer("indUF=" & NumberAsString(Me.induf))
		Me.myMathWrapper.WaitAndDiscardAnswer("indUFRO=" & NumberAsString(Me.indufro))
		Me.myMathWrapper.WaitAndDiscardAnswer("lanUF=" & NumberAsString(Me.lanuf))
		Me.myMathWrapper.WaitAndDiscardAnswer("lanUFRO=" & NumberAsString(Me.lanufro))
		Me.myMathWrapper.WaitAndDiscardAnswer("ssqi=" & NumberAsString(Me.ssqi))
		Me.myMathWrapper.WaitAndDiscardAnswer("totpla=" & NumberAsString(Me.totpla))
		Me.myMathWrapper.WaitAndDiscardAnswer("agrw=0.33")
		Me.myMathWrapper.WaitAndDiscardAnswer("indw=0.33")
		Me.myMathWrapper.WaitAndDiscardAnswer("lanw=0.33")

		'(*potential costs*)
		For i = 0 To 12
			Me.myMathWrapper.WaitAndDiscardAnswer("agrpc[" & i + 1 & "][1]=If[lsqi[" & i + 1 & "][1]>ssqi,agrUFRO,agrUF]")
			Me.myMathWrapper.WaitAndDiscardAnswer("agrpc[" & i + 1 & "][2]=agrpc[" & i + 1 & "][1]")
		Next

		For i = 0 To 12
			Me.myMathWrapper.WaitAndDiscardAnswer("indpc[" & i + 1 & "][1]=If[lsqi[" & i + 1 & "][1]>ssqi,indUFRO,indUF]")
			Me.myMathWrapper.WaitAndDiscardAnswer("indpc[" & i + 1 & "][2]=indpc[" & i + 1 & "][1]")
		Next

		For i = 0 To 12
			Me.myMathWrapper.WaitAndDiscardAnswer("lanpc[" & i + 1 & "][1]=If[lsqi[" & i + 1 & "][1]>ssqi,lanUFRO,lanUF]")
			Me.myMathWrapper.WaitAndDiscardAnswer("lanpc[" & i + 1 & "][2]=lanpc[" & i + 1 & "][1]")

			'industrial districts are calculated as current + planned
			Me.inddis(i, 0) = 0
			Me.inddis(i, 1) = Me.inddiscur(i, 1) + Me.inddispln(i, 1)
			Me.myMathWrapper.WaitAndDiscardAnswer("inddis[" & i + 1 & "][1]=0")
			Me.myMathWrapper.WaitAndDiscardAnswer("inddis[" & i + 1 & "][2]=" & NumberAsString(Me.inddis(i, 1)))
		Next

		Me.myMathWrapper.WaitAndDiscardAnswer("ecow=1-socw-envw")

		Me.myMathWrapper.WaitAndDiscardAnswer("agrobj=((agrcc[i][j]+gwsp)/agrpc[i][j])(1-((agrcc[i][j]+gwsp-agrpc[i][j])/(agrcc[i][j]+gwsp))*x[i][j])")
		Me.myMathWrapper.WaitAndDiscardAnswer("indobj=inddis[i][j]((indcc[i][j])/indpc[i][j])(1-((indcc[i][j]-indpc[i][j])/(indcc[i][j]))*y[i][j])")
		Me.myMathWrapper.WaitAndDiscardAnswer("lanobj=((lancc[i][j]+gwsp)/lanpc[i][j])(1-((lancc[i][j]+gwsp-lanpc[i][j])/(lancc[i][j]+gwsp))*z[i][j])")

		'(*scenario 2020*)
		Me.myMathWrapper.WaitAndDiscardAnswer("ecoobj20=Sum[(pop20[i][j]/totpop20)(agrw*agrobj+indw*indobj+lanw*lanobj),{i,1,13},{j,1,2}]")
		Me.myMathWrapper.WaitAndDiscardAnswer("socobj20=Sum[(pop20[i][j]/totpop20)*(((lmqi[i][j]*(1-tpmz*z[i][j]))/smqi)),{i,1,13},{j,1,2}]")
		Me.myMathWrapper.WaitAndDiscardAnswer("envobj20=Sum[(pop20[i][j]/totpop20)*(((lbqi[i][j]*(1-tpbx*x[i][j]))/sbqi)),{i,1,13},{j,1,2}]")

		Me.myMathWrapper.WaitAndDiscardAnswer("totobj20=ecow*ecoobj20+socw*socobj20+envw*envobj20")

		'assign values to variables to calculate numeric solution
		Me.myMathWrapper.WaitAndDiscardAnswer("envw=" & NumberAsString(Me.envw / 100))
		Me.myMathWrapper.WaitAndDiscardAnswer("socw=" & NumberAsString(Me.socw / 100))
		Me.myMathWrapper.WaitAndDiscardAnswer("sbqi=" & NumberAsString(Me.sbqi))
		Me.myMathWrapper.WaitAndDiscardAnswer("smqi=" & NumberAsString(Me.smqi))
		Me.myMathWrapper.WaitAndDiscardAnswer("tpbx=" & NumberAsString(Me.tpbx / 100))
		Me.myMathWrapper.WaitAndDiscardAnswer("tpmz=" & NumberAsString(Me.tpmz / 100))

		Me.myMathWrapper.WaitAndDiscardAnswer("totobj20r = totobj20 /. {x[1][1] -> x11, x[1][2] -> x12, x[2][1] -> x21, x[2][2] -> x22, x[3][1] -> x31, x[3][2] -> x32, x[4][1] -> x41, x[4][2] -> x42, x[5][1] -> x51, x[5][2] -> x52, x[6][1] -> x61, x[6][2] -> x62, x[7][1] -> x71, x[7][2] -> x72, x[8][1] -> x81, x[8][2] -> x82, x[9][1] -> x91, x[9][2] -> x92, x[10][1] -> x101, x[10][2] -> x102, x[11][1] -> x111, x[11][2] -> x112, x[12][1] -> x121, x[12][2] -> x122, x[13][1] -> x131, x[13][2] -> x132, y[1][1] -> y11, y[1][2] -> y12, y[2][1] -> y21, y[2][2] -> y22, y[3][1] -> y31, y[3][2] -> y32, y[4][1] -> y41, y[4][2] -> y42, y[5][1] -> y51, y[5][2] -> y52, y[6][1] -> y61, y[6][2] -> y62, y[7][1] -> y71, y[7][2] -> y72, y[8][1] -> y81, y[8][2] -> y82, y[9][1] -> y91, y[9][2] -> y92, y[10][1] -> y101, y[10][2] -> y102, y[11][1] -> y111, y[11][2] -> y112, y[12][1] -> y121, y[12][2] -> y122, y[13][1] -> y131, y[13][2] -> y132, z[1][1] -> z11, z[1][2] -> z12, z[2][1] -> z21, z[2][2] -> z22, z[3][1] -> z31, z[3][2] -> z32, z[4][1] -> z41, z[4][2] -> z42, z[5][1] -> z51, z[5][2] -> z52, z[6][1] -> z61, z[6][2] -> z62, z[7][1] -> z71, z[7][2] -> z72, z[8][1] -> z81, z[8][2] -> z82, z[9][1] -> z91, z[9][2] -> z92, z[10][1] -> z101, z[10][2] -> z102, z[11][1] -> z111, z[11][2] -> z112, z[12][1] -> z121, z[12][2] -> z122, z[13][1] -> z131, z[13][2] -> z132}")

		Me.myMathWrapper.WaitAndDiscardAnswer("m = NMinimize[{totobj20r*100, (x11 + x12 + x21 + x22 + x31 + x32 + x41 + x42 + x51 + x52 + x61 + x62 + x71 + x72 + x81 + x82 + x91 + x92 + x101 + x102 + x111 + x112 + x121 + x122 + x131 + x132 + y22 + y32 + y42 + y52 + y62 + y72 + y82 + y92 + y102 + y112 + y122 + y132 + z11 + z12 + z21 + z22 + z31 + z32 + z41 + z42 + z51 + z52 + z61 + z62 + z71 + z72 + z81 + z82 + z91 + z92 + z101 + z102 + z111 + z112 + z121 + z122 + z131 + z132) <= totpla, x11 <= 1, x12 <= 1, x21 <= 1, x22 <= 1, x31 <= 1, x32 <= 1, x41 <= 1, x42 <= 1, x51 <= 1, x52 <= 1, x61 <= 1, x62 <= 1, x71 <= 1, x72 <= 1, x81 <= 1, x82 <= 1, x91 <= 1, x92 <= 1, x101 <= 1, x102 <= 1, x111 <= 1, x112 <= 1, x121 <= 1, x122 <= 1, x131 <= 1, x132 <= 1, y12 <= 1, y22 <= 1, y32 <= 1, y42 <= 1, y52 <= 1, y62 <= 1, y72 <= 1, y82 <= 1, y92 <= 1, y102 <= 1, y112 <= 1, y122 <= 1, y132 <= 1, z11 <= 1, z12 <= 1, z21 <= 1, z22 <= 1, z31 <= 1, z32 <= 1, z41 <= 1, z42 <= 1, z51 <= 1, z52 <= 1, z61 <= 1, z62 <= 1, z71 <= 1, z72 <= 1, z81 <= 1, z82 <= 1, z91 <= 1, z92 <= 1, z101 <= 1, z102 <= 1, z111 <= 1, z112 <= 1, z121 <= 1, z122 <= 1, z131 <= 1, z132 <= 1, x11 >= 0, x12 >= 0, x21 >= 0, x22 >= 0, x31 >= 0, x32 >= 0, x41 >= 0, x42 >= 0, x51 >= 0, x52 >= 0, x61 >= 0, x62 >= 0, x71 >= 0, x72 >= 0, x81 >= 0, x82 >= 0, x91 >= 0, x92 >= 0, x101 >= 0, x102 >= 0, x111 >= 0, x112 >= 0, x121 >= 0, x122 >= 0, x131 >= 0, x132 >= 0, y12 >= 0, y22 >= 0, y32 >= 0, y42 >= 0, y52 >= 0, y62 >= 0, y72 >= 0, y82 >= 0, y92 >= 0, y102 >= 0, y112 >= 0, y122 >= 0, y132 >= 0, z11 >= 0, z12 >= 0, z21 >= 0, z22 >= 0, z31 >= 0, z32 >= 0, z41 >= 0, z42 >= 0, z51 >= 0, z52 >= 0, z61 >= 0, z62 >= 0, z71 >= 0, z72 >= 0, z81 >= 0, z82 >= 0, z91 >= 0, z92 >= 0, z101 >= 0, z102 >= 0, z111 >= 0, z112 >= 0, z121 >= 0, z122 >= 0, z131 >= 0, z132 >= 0, Element[{x11, x12, x21, x22, x31, x32, x41, x42, x51, x52, x61, x62, x71, x72, x81, x82, x91, x92, x101, x102, x111, x112, x121, x122, x131, x132, y12, y22, y32, y42, y52, y62, y72, y82, y92, y102, y112, y122, y132, z11, z12, z21, z22, z31, z32, z41, z42, z51, z52, z61, z62, z71, z72, z81, z82, z91, z92, z101, z102, z111, z112, z121, z122, z131, z132}, Integers]}, {x11, x12, x21, x22, x31, x32, x41, x42, x51, x52, x61, x62, x71, x72, x81, x82, x91, x92, x101, x102, x111, x112, x121, x122, x131, x132, y12, y22, y32, y42, y52, y62, y72, y82, y92, y102, y112, y122, y132, z11, z12, z21, z22, z31, z32, z41, z42, z51, z52, z61, z62, z71, z72, z81, z82, z91, z92, z101, z102, z111, z112, z121, z122, z131, z132}]")

		Me.myMathWrapper.WaitAndDiscardAnswer("mobj = m[[1]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("marg = m[[2]]")

		Me.myMathWrapper.WaitAndDiscardAnswer("sbqi=.")
		Me.myMathWrapper.WaitAndDiscardAnswer("smqi=.")
		Me.myMathWrapper.WaitAndDiscardAnswer("tpbx=.")
		Me.myMathWrapper.WaitAndDiscardAnswer("tpmz=.")
		Me.myMathWrapper.WaitAndDiscardAnswer("socw=.")
		Me.myMathWrapper.WaitAndDiscardAnswer("envw=.")

		Me.myMathWrapper.WaitAndDiscardAnswer("totobj20rWEL = totobj20r*100 /. {x11 -> 0, x12 -> 0, x21 -> 0, x22 -> 0, x31 -> 0, x32 -> 0, x41 -> 1, x42 -> 1, x51 -> 0, x52 -> 1, x61 -> 0, x62 -> 1, x71 -> 1, x72 -> 0, x81 -> 0, x82 -> 1, x91 -> 0, x92 -> 1, x101 -> 0, x102 -> 0, x111 -> 0, x112 -> 0, x121 -> 1, x122 -> 0, x131 -> 0, x132 -> 0, y12 -> 0, y22 -> 0, y32 -> 0, y42 -> 1, y52 -> 1, y62 -> 0, y72 -> 0, y82 -> 0, y92 -> 0, y102 -> 0, y112 -> 0, y122 -> 1, y132 -> 1, z11 -> 0, z12 -> 0, z21 -> 0, z22 -> 0, z31 -> 0, z32 -> 0, z41 -> 1, z42 -> 1, z51 -> 0, z52 -> 1, z61 -> 0, z62 -> 1, z71 -> 1, z72 -> 0, z81 -> 0, z82 -> 1, z91 -> 0, z92 -> 1, z101 -> 0, z102 -> 0, z111 -> 0, z112 -> 0, z121 -> 1, z122 -> 0, z131 -> 0, z132 -> 0, sbqi -> 20, smqi -> 20, tpbx -> 0.35, tpmz -> 0.30}")
		Me.myMathWrapper.WaitAndDiscardAnswer("totobj20rSUS = totobj20r*100 /. {x11 -> 0, x12 -> 0, x21 -> 0, x22 -> 0, x31 -> 0, x32 -> 0, x41 -> 1, x42 -> 1, x51 -> 0, x52 -> 1, x61 -> 0, x62 -> 1, x71 -> 1, x72 -> 0, x81 -> 0, x82 -> 1, x91 -> 0, x92 -> 1, x101 -> 0, x102 -> 0, x111 -> 0, x112 -> 0, x121 -> 1, x122 -> 0, x131 -> 0, x132 -> 0, y12 -> 0, y22 -> 0, y32 -> 0, y42 -> 1, y52 -> 1, y62 -> 0, y72 -> 0, y82 -> 0, y92 -> 0, y102 -> 0, y112 -> 0, y122 -> 1, y132 -> 1, z11 -> 0, z12 -> 0, z21 -> 0, z22 -> 0, z31 -> 0, z32 -> 0, z41 -> 1, z42 -> 1, z51 -> 0, z52 -> 1, z61 -> 0, z62 -> 1, z71 -> 1, z72 -> 0, z81 -> 0, z82 -> 1, z91 -> 0, z92 -> 1, z101 -> 0, z102 -> 0, z111 -> 0, z112 -> 0, z121 -> 1, z122 -> 0, z131 -> 0, z132 -> 0, socw -> 0.33, envw -> 0.33, tpbx -> 0.35, tpmz -> 0.30}")
		Me.myMathWrapper.WaitAndDiscardAnswer("totobj20rEFF = totobj20r*100 /. {x11 -> 0, x12 -> 0, x21 -> 0, x22 -> 0, x31 -> 0, x32 -> 0, x41 -> 1, x42 -> 1, x51 -> 0, x52 -> 1, x61 -> 0, x62 -> 1, x71 -> 1, x72 -> 0, x81 -> 0, x82 -> 1, x91 -> 0, x92 -> 1, x101 -> 0, x102 -> 0, x111 -> 0, x112 -> 0, x121 -> 1, x122 -> 0, x131 -> 0, x132 -> 0, y12 -> 0, y22 -> 0, y32 -> 0, y42 -> 1, y52 -> 1, y62 -> 0, y72 -> 0, y82 -> 0, y92 -> 0, y102 -> 0, y112 -> 0, y122 -> 1, y132 -> 1, z11 -> 0, z12 -> 0, z21 -> 0, z22 -> 0, z31 -> 0, z32 -> 0, z41 -> 1, z42 -> 1, z51 -> 0, z52 -> 1, z61 -> 0, z62 -> 1, z71 -> 1, z72 -> 0, z81 -> 0, z82 -> 1, z91 -> 0, z92 -> 1, z101 -> 0, z102 -> 0, z111 -> 0, z112 -> 0, z121 -> 1, z122 -> 0, z131 -> 0, z132 -> 0, sbqi -> 20, smqi -> 20, socw -> 0.33, envw -> 0.33}")

		Me.myMathWrapper.WaitAndDiscardAnswer("ecolis1=List[agrw*((agrcc[1][1]+gwsp)/agrpc[1][1])(1-((agrcc[1][1]+gwsp-agrpc[1][1])/(agrcc[1][1]+gwsp))*x11)+indw*inddis[1][1]((indcc[1][1])/indpc[1][1])(1-((indcc[1][1]-indpc[1][1])/(indcc[1][1]))*y11)+lanw*((lancc[1][1]+gwsp)/lanpc[1][1])(1-((lancc[1][1]+gwsp-lanpc[1][1])/(lancc[1][1]+gwsp))*z11),agrw*((agrcc[2][1]+gwsp)/agrpc[2][1])(1-((agrcc[2][1]+gwsp-agrpc[2][1])/(agrcc[2][1]+gwsp))*x21)+indw*inddis[2][1]((indcc[2][1])/indpc[2][1])(1-((indcc[2][1]-indpc[2][1])/(indcc[2][1]))*y21)+lanw*((lancc[2][1]+gwsp)/lanpc[2][1])(1-((lancc[2][1]+gwsp-lanpc[2][1])/(lancc[2][1]+gwsp))*z21),agrw*((agrcc[3][1]+gwsp)/agrpc[3][1])(1-((agrcc[3][1]+gwsp-agrpc[3][1])/(agrcc[3][1]+gwsp))*x31)+indw*inddis[3][1]((indcc[3][1])/indpc[3][1])(1-((indcc[3][1]-indpc[3][1])/(indcc[3][1]))*y31)+lanw*((lancc[3][1]+gwsp)/lanpc[3][1])(1-((lancc[3][1]+gwsp-lanpc[3][1])/(lancc[3][1]+gwsp))*z31),agrw*((agrcc[4][1]+gwsp)/agrpc[4][1])(1-((agrcc[4][1]+gwsp-agrpc[4][1])/(agrcc[4][1]+gwsp))*x41)+indw*inddis[4][1]((indcc[4][1])/indpc[4][1])(1-((indcc[4][1]-indpc[4][1])/(indcc[4][1]))*y41)+lanw*((lancc[4][1]+gwsp)/lanpc[4][1])(1-((lancc[4][1]+gwsp-lanpc[4][1])/(lancc[4][1]+gwsp))*z41),agrw*((agrcc[5][1]+gwsp)/agrpc[5][1])(1-((agrcc[5][1]+gwsp-agrpc[5][1])/(agrcc[5][1]+gwsp))*x51)+indw*inddis[5][1]((indcc[5][1])/indpc[5][1])(1-((indcc[5][1]-indpc[5][1])/(indcc[5][1]))*y51)+lanw*((lancc[5][1]+gwsp)/lanpc[5][1])(1-((lancc[5][1]+gwsp-lanpc[5][1])/(lancc[5][1]+gwsp))*z51),agrw*((agrcc[6][1]+gwsp)/agrpc[6][1])(1-((agrcc[6][1]+gwsp-agrpc[6][1])/(agrcc[6][1]+gwsp))*x61)+indw*inddis[6][1]((indcc[6][1])/indpc[6][1])(1-((indcc[6][1]-indpc[6][1])/(indcc[6][1]))*y61)+lanw*((lancc[6][1]+gwsp)/lanpc[6][1])(1-((lancc[6][1]+gwsp-lanpc[6][1])/(lancc[6][1]+gwsp))*z61),agrw*((agrcc[7][1]+gwsp)/agrpc[7][1])(1-((agrcc[7][1]+gwsp-agrpc[7][1])/(agrcc[7][1]+gwsp))*x71)+indw*inddis[7][1]((indcc[7][1])/indpc[7][1])(1-((indcc[7][1]-indpc[7][1])/(indcc[7][1]))*y71)+lanw*((lancc[7][1]+gwsp)/lanpc[7][1])(1-((lancc[7][1]+gwsp-lanpc[7][1])/(lancc[7][1]+gwsp))*z71),agrw*((agrcc[8][1]+gwsp)/agrpc[8][1])(1-((agrcc[8][1]+gwsp-agrpc[8][1])/(agrcc[8][1]+gwsp))*x81)+indw*inddis[8][1]((indcc[8][1])/indpc[8][1])(1-((indcc[8][1]-indpc[8][1])/(indcc[8][1]))*y81)+lanw*((lancc[8][1]+gwsp)/lanpc[8][1])(1-((lancc[8][1]+gwsp-lanpc[8][1])/(lancc[8][1]+gwsp))*z81),agrw*((agrcc[9][1]+gwsp)/agrpc[9][1])(1-((agrcc[9][1]+gwsp-agrpc[9][1])/(agrcc[9][1]+gwsp))*x91)+indw*inddis[9][1]((indcc[9][1])/indpc[9][1])(1-((indcc[9][1]-indpc[9][1])/(indcc[9][1]))*y91)+lanw*((lancc[9][1]+gwsp)/lanpc[9][1])(1-((lancc[9][1]+gwsp-lanpc[9][1])/(lancc[9][1]+gwsp))*z91),agrw*((agrcc[10][1]+gwsp)/agrpc[10][1])(1-((agrcc[10][1]+gwsp-agrpc[10][1])/(agrcc[10][1]+gwsp))*x101)+indw*inddis[10][1]((indcc[10][1])/indpc[10][1])(1-((indcc[10][1]-indpc[10][1])/(indcc[10][1]))*y101)+lanw*((lancc[10][1]+gwsp)/lanpc[10][1])(1-((lancc[10][1]+gwsp-lanpc[10][1])/(lancc[10][1]+gwsp))*z101),agrw*((agrcc[11][1]+gwsp)/agrpc[11][1])(1-((agrcc[11][1]+gwsp-agrpc[11][1])/(agrcc[11][1]+gwsp))*x111)+indw*inddis[11][1]((indcc[11][1])/indpc[11][1])(1-((indcc[11][1]-indpc[11][1])/(indcc[11][1]))*y111)+lanw*((lancc[11][1]+gwsp)/lanpc[11][1])(1-((lancc[11][1]+gwsp-lanpc[11][1])/(lancc[11][1]+gwsp))*z111),agrw*((agrcc[12][1]+gwsp)/agrpc[12][1])(1-((agrcc[12][1]+gwsp-agrpc[12][1])/(agrcc[12][1]+gwsp))*x121)+indw*inddis[12][1]((indcc[12][1])/indpc[12][1])(1-((indcc[12][1]-indpc[12][1])/(indcc[12][1]))*y121)+lanw*((lancc[12][1]+gwsp)/lanpc[12][1])(1-((lancc[12][1]+gwsp-lanpc[12][1])/(lancc[12][1]+gwsp))*z121),agrw*((agrcc[13][1]+gwsp)/agrpc[13][1])(1-((agrcc[13][1]+gwsp-agrpc[13][1])/(agrcc[13][1]+gwsp))*x131)+indw*inddis[13][1]((indcc[13][1])/indpc[13][1])(1-((indcc[13][1]-indpc[13][1])/(indcc[13][1]))*y131)+lanw*((lancc[13][1]+gwsp)/lanpc[13][1])(1-((lancc[13][1]+gwsp-lanpc[13][1])/(lancc[13][1]+gwsp))*z131)]/. marg")

		Me.myMathWrapper.WaitAndDiscardAnswer("ecolis2=List[agrw*((agrcc[1][2]+gwsp)/agrpc[1][2])(1-((agrcc[1][2]+gwsp-agrpc[1][2])/(agrcc[1][2]+gwsp))*x12)+indw*inddis[1][2]((indcc[1][2])/indpc[1][2])(1-((indcc[1][2]-indpc[1][2])/(indcc[1][2]))*y12)+lanw*((lancc[1][2]+gwsp)/lanpc[1][2])(1-((lancc[1][2]+gwsp-lanpc[1][2])/(lancc[1][2]+gwsp))*z12),agrw*((agrcc[2][2]+gwsp)/agrpc[2][2])(1-((agrcc[2][2]+gwsp-agrpc[2][2])/(agrcc[2][2]+gwsp))*x22)+indw*inddis[2][2]((indcc[2][2])/indpc[2][2])(1-((indcc[2][2]-indpc[2][2])/(indcc[2][2]))*y22)+lanw*((lancc[2][2]+gwsp)/lanpc[2][2])(1-((lancc[2][2]+gwsp-lanpc[2][2])/(lancc[2][2]+gwsp))*z22),agrw*((agrcc[3][2]+gwsp)/agrpc[3][2])(1-((agrcc[3][2]+gwsp-agrpc[3][2])/(agrcc[3][2]+gwsp))*x32)+indw*inddis[3][2]((indcc[3][2])/indpc[3][2])(1-((indcc[3][2]-indpc[3][2])/(indcc[3][2]))*y32)+lanw*((lancc[3][2]+gwsp)/lanpc[3][2])(1-((lancc[3][2]+gwsp-lanpc[3][2])/(lancc[3][2]+gwsp))*z32),agrw*((agrcc[4][2]+gwsp)/agrpc[4][2])(1-((agrcc[4][2]+gwsp-agrpc[4][2])/(agrcc[4][2]+gwsp))*x42)+indw*inddis[4][2]((indcc[4][2])/indpc[4][2])(1-((indcc[4][2]-indpc[4][2])/(indcc[4][2]))*y42)+lanw*((lancc[4][2]+gwsp)/lanpc[4][2])(1-((lancc[4][2]+gwsp-lanpc[4][2])/(lancc[4][2]+gwsp))*z42),agrw*((agrcc[5][2]+gwsp)/agrpc[5][2])(1-((agrcc[5][2]+gwsp-agrpc[5][2])/(agrcc[5][2]+gwsp))*x52)+indw*inddis[5][2]((indcc[5][2])/indpc[5][2])(1-((indcc[5][2]-indpc[5][2])/(indcc[5][2]))*y52)+lanw*((lancc[5][2]+gwsp)/lanpc[5][2])(1-((lancc[5][2]+gwsp-lanpc[5][2])/(lancc[5][2]+gwsp))*z52),agrw*((agrcc[6][2]+gwsp)/agrpc[6][2])(1-((agrcc[6][2]+gwsp-agrpc[6][2])/(agrcc[6][2]+gwsp))*x62)+indw*inddis[6][2]((indcc[6][2])/indpc[6][2])(1-((indcc[6][2]-indpc[6][2])/(indcc[6][2]))*y62)+lanw*((lancc[6][2]+gwsp)/lanpc[6][2])(1-((lancc[6][2]+gwsp-lanpc[6][2])/(lancc[6][2]+gwsp))*z62),agrw*((agrcc[7][2]+gwsp)/agrpc[7][2])(1-((agrcc[7][2]+gwsp-agrpc[7][2])/(agrcc[7][2]+gwsp))*x72)+indw*inddis[7][2]((indcc[7][2])/indpc[7][2])(1-((indcc[7][2]-indpc[7][2])/(indcc[7][2]))*y72)+lanw*((lancc[7][2]+gwsp)/lanpc[7][2])(1-((lancc[7][2]+gwsp-lanpc[7][2])/(lancc[7][2]+gwsp))*z72),agrw*((agrcc[8][2]+gwsp)/agrpc[8][2])(1-((agrcc[8][2]+gwsp-agrpc[8][2])/(agrcc[8][2]+gwsp))*x82)+indw*inddis[8][2]((indcc[8][2])/indpc[8][2])(1-((indcc[8][2]-indpc[8][2])/(indcc[8][2]))*y82)+lanw*((lancc[8][2]+gwsp)/lanpc[8][2])(1-((lancc[8][2]+gwsp-lanpc[8][2])/(lancc[8][2]+gwsp))*z82),agrw*((agrcc[9][2]+gwsp)/agrpc[9][2])(1-((agrcc[9][2]+gwsp-agrpc[9][2])/(agrcc[9][2]+gwsp))*x92)+indw*inddis[9][2]((indcc[9][2])/indpc[9][2])(1-((indcc[9][2]-indpc[9][2])/(indcc[9][2]))*y92)+lanw*((lancc[9][2]+gwsp)/lanpc[9][2])(1-((lancc[9][2]+gwsp-lanpc[9][2])/(lancc[9][2]+gwsp))*z92),agrw*((agrcc[10][2]+gwsp)/agrpc[10][2])(1-((agrcc[10][2]+gwsp-agrpc[10][2])/(agrcc[10][2]+gwsp))*x102)+indw*inddis[10][2]((indcc[10][2])/indpc[10][2])(1-((indcc[10][2]-indpc[10][2])/(indcc[10][2]))*y102)+lanw*((lancc[10][2]+gwsp)/lanpc[10][2])(1-((lancc[10][2]+gwsp-lanpc[10][2])/(lancc[10][2]+gwsp))*z102),agrw*((agrcc[11][2]+gwsp)/agrpc[11][2])(1-((agrcc[11][2]+gwsp-agrpc[11][2])/(agrcc[11][2]+gwsp))*x112)+indw*inddis[11][2]((indcc[11][2])/indpc[11][2])(1-((indcc[11][2]-indpc[11][2])/(indcc[11][2]))*y112)+lanw*((lancc[11][2]+gwsp)/lanpc[11][2])(1-((lancc[11][2]+gwsp-lanpc[11][2])/(lancc[11][2]+gwsp))*z112),agrw*((agrcc[12][2]+gwsp)/agrpc[12][2])(1-((agrcc[12][2]+gwsp-agrpc[12][2])/(agrcc[12][2]+gwsp))*x122)+indw*inddis[12][2]((indcc[12][2])/indpc[12][2])(1-((indcc[12][2]-indpc[12][2])/(indcc[12][2]))*y122)+lanw*((lancc[12][2]+gwsp)/lanpc[12][2])(1-((lancc[12][2]+gwsp-lanpc[12][2])/(lancc[12][2]+gwsp))*z122),agrw*((agrcc[13][2]+gwsp)/agrpc[13][2])(1-((agrcc[13][2]+gwsp-agrpc[13][2])/(agrcc[13][2]+gwsp))*x132)+indw*inddis[13][2]((indcc[13][2])/indpc[13][2])(1-((indcc[13][2]-indpc[13][2])/(indcc[13][2]))*y132)+lanw*((lancc[13][2]+gwsp)/lanpc[13][2])(1-((lancc[13][2]+gwsp-lanpc[13][2])/(lancc[13][2]+gwsp))*z132)]/.marg")

		Me.myMathWrapper.WaitAndDiscardAnswer("soclis1=List[lmqi[1][1]((1-tpmz*z11)/smqi),lmqi[2][1]((1-tpmz*z21)/smqi),lmqi[3][1]((1-tpmz*z31)/smqi),lmqi[4][1]((1-tpmz*z41)/smqi),lmqi[5][1]((1-tpmz*z51)/smqi),lmqi[6][1]((1-tpmz*z61)/smqi),lmqi[7][1]((1-tpmz*z71)/smqi),lmqi[8][1]((1-tpmz*z81)/smqi),lmqi[9][1]((1-tpmz*z91)/smqi),lmqi[10][1]((1-tpmz*z101)/smqi),lmqi[11][1]((1-tpmz*z111)/smqi),lmqi[12][1]((1-tpmz*z121)/smqi),lmqi[13][1]((1-tpmz*z131)/smqi)] /.marg")

		Me.myMathWrapper.WaitAndDiscardAnswer("soclis2=List[lmqi[1][2]((1-tpmz*z12)/smqi),lmqi[2][2]((1-tpmz*z22)/smqi),lmqi[3][2]((1-tpmz*z32)/smqi),lmqi[4][2]((1-tpmz*z42)/smqi),lmqi[5][2]((1-tpmz*z52)/smqi),lmqi[6][2]((1-tpmz*z62)/smqi),lmqi[7][2]((1-tpmz*z72)/smqi),lmqi[8][2]((1-tpmz*z82)/smqi),lmqi[9][2]((1-tpmz*z92)/smqi),lmqi[10][2]((1-tpmz*z102)/smqi),lmqi[11][2]((1-tpmz*z112)/smqi),lmqi[12][2]((1-tpmz*z122)/smqi),lmqi[13][2]((1-tpmz*z132)/smqi)] /. marg")

		Me.myMathWrapper.WaitAndDiscardAnswer("envlis1=List[lbqi[1][1]((1-tpmz*z11)/smqi),lbqi[2][1]((1-tpmz*z21)/smqi),lbqi[3][1]((1-tpmz*z31)/smqi),lbqi[4][1]((1-tpmz*z41)/smqi),lbqi[5][1]((1-tpmz*z51)/smqi),lbqi[6][1]((1-tpmz*z61)/smqi),lbqi[7][1]((1-tpmz*z71)/smqi),lbqi[8][1]((1-tpmz*z81)/smqi),lbqi[9][1]((1-tpmz*z91)/smqi),lbqi[10][1]((1-tpmz*z101)/smqi),lbqi[11][1]((1-tpmz*z111)/smqi),lbqi[12][1]((1-tpmz*z121)/smqi),lbqi[13][1]((1-tpmz*z131)/smqi)] /.marg")

		Me.myMathWrapper.WaitAndDiscardAnswer("envlis2=List[lbqi[1][2]((1-tpmz*z12)/smqi),lbqi[2][2]((1-tpmz*z22)/smqi),lbqi[3][2]((1-tpmz*z32)/smqi),lbqi[4][2]((1-tpmz*z42)/smqi),lbqi[5][2]((1-tpmz*z52)/smqi),lbqi[6][2]((1-tpmz*z62)/smqi),lbqi[7][2]((1-tpmz*z72)/smqi),lbqi[8][2]((1-tpmz*z82)/smqi),lbqi[9][2]((1-tpmz*z92)/smqi),lbqi[10][2]((1-tpmz*z102)/smqi),lbqi[11][2]((1-tpmz*z112)/smqi),lbqi[12][2]((1-tpmz*z122)/smqi),lbqi[13][2]((1-tpmz*z132)/smqi)] /.marg")

		For i = 0 To 12
			Me.myMathWrapper.WaitAndDiscardAnswer("eco" & i + 1 & "1=ecolis1[[1," & i + 1 & "]]")
		Next

		Me.myMathWrapper.WaitAndDiscardAnswer("ecomea1=(eco11+eco21+eco31+eco41+eco51+eco61+eco71+eco81+eco91+eco101+eco111+eco121+eco131)/13")

		Me.myMathWrapper.WaitAndDiscardAnswer("ecogin1=N[(1/2*1/13^2*(1/ecomea1))(Abs[eco11-eco11]+Abs[eco11-eco21]+Abs[eco11-eco31]+Abs[eco11-eco41]+Abs[eco11-eco51]+Abs[eco11-eco61]+Abs[eco11-eco71]+Abs[eco11-eco81]+Abs[eco11-eco91]+Abs[eco11-eco101]+Abs[eco11-eco111]+Abs[eco11-eco121]+Abs[eco11-eco131]+Abs[eco21-eco11]+Abs[eco21-eco21]+Abs[eco21-eco31]+Abs[eco21-eco41]+Abs[eco21-eco51]+Abs[eco21-eco61]+Abs[eco21-eco71]+Abs[eco21-eco81]+Abs[eco21-eco91]+Abs[eco21-eco101]+Abs[eco21-eco111]+Abs[eco21-eco121]+Abs[eco21-eco131]+Abs[eco31-eco11]+Abs[eco31-eco21]+Abs[eco31-eco31]+Abs[eco31-eco41]+Abs[eco31-eco51]+Abs[eco31-eco61]+Abs[eco31-eco71]+Abs[eco31-eco81]+Abs[eco31-eco91]+Abs[eco31-eco101]+Abs[eco31-eco111]+Abs[eco31-eco121]+Abs[eco31-eco131]+Abs[eco41-eco11]+Abs[eco41-eco21]+Abs[eco41-eco31]+Abs[eco41-eco41]+Abs[eco41-eco51]+Abs[eco41-eco61]+Abs[eco41-eco71]+Abs[eco41-eco81]+Abs[eco41-eco91]+Abs[eco41-eco101]+Abs[eco41-eco111]+Abs[eco41-eco121]+Abs[eco41-eco131]+Abs[eco51-eco11]+Abs[eco51-eco21]+Abs[eco51-eco31]+Abs[eco51-eco41]+Abs[eco51-eco51]+Abs[eco51-eco61]+Abs[eco51-eco71]+Abs[eco51-eco81]+Abs[eco51-eco91]+Abs[eco51-eco101]+Abs[eco51-eco111]+Abs[eco51-eco121]+Abs[eco51-eco131]+Abs[eco61-eco11]+Abs[eco61-eco21]+Abs[eco61-eco31]+Abs[eco61-eco41]+Abs[eco61-eco51]+Abs[eco61-eco61]+Abs[eco61-eco71]+Abs[eco61-eco81]+Abs[eco61-eco91]+Abs[eco61-eco101]+Abs[eco61-eco111]+Abs[eco61-eco121]+Abs[eco61-eco131]+Abs[eco71-eco11]+Abs[eco71-eco21]+Abs[eco71-eco31]+Abs[eco71-eco41]+Abs[eco71-eco51]+Abs[eco71-eco61]+Abs[eco71-eco71]+Abs[eco71-eco81]+Abs[eco71-eco91]+Abs[eco71-eco101]+Abs[eco71-eco111]+Abs[eco71-eco121]+Abs[eco71-eco131]+Abs[eco81-eco11]+Abs[eco81-eco21]+Abs[eco81-eco31]+Abs[eco81-eco41]+Abs[eco81-eco51]+Abs[eco81-eco61]+Abs[eco81-eco71]+Abs[eco81-eco81]+Abs[eco81-eco91]+Abs[eco81-eco101]+Abs[eco81-eco111]+Abs[eco81-eco121]+Abs[eco81-eco131]+Abs[eco91-eco11]+Abs[eco91-eco21]+Abs[eco91-eco31]+Abs[eco91-eco41]+Abs[eco91-eco51]+Abs[eco91-eco61]+Abs[eco91-eco71]+Abs[eco91-eco81]+Abs[eco91-eco91]+Abs[eco91-eco101]+Abs[eco91-eco111]+Abs[eco91-eco121]+Abs[eco91-eco131]+Abs[eco101-eco11]+Abs[eco101-eco21]+Abs[eco101-eco31]+Abs[eco101-eco41]+Abs[eco101-eco51]+Abs[eco101-eco61]+Abs[eco101-eco71]+Abs[eco101-eco81]+Abs[eco101-eco91]+Abs[eco101-eco101]+Abs[eco101-eco111]+Abs[eco101-eco121]+Abs[eco101-eco131]+Abs[eco111-eco11]+Abs[eco111-eco21]+Abs[eco111-eco31]+Abs[eco111-eco41]+Abs[eco111-eco51]+Abs[eco111-eco61]+Abs[eco111-eco71]+Abs[eco111-eco81]+Abs[eco111-eco91]+Abs[eco111-eco101]+Abs[eco111-eco111]+Abs[eco111-eco121]+Abs[eco111-eco131]+Abs[eco121-eco11]+Abs[eco121-eco21]+Abs[eco121-eco31]+Abs[eco121-eco41]+Abs[eco121-eco51]+Abs[eco121-eco61]+Abs[eco121-eco71]+Abs[eco121-eco81]+Abs[eco121-eco91]+Abs[eco121-eco101]+Abs[eco121-eco111]+Abs[eco121-eco121]+Abs[eco121-eco131]+Abs[eco131-eco11]+Abs[eco131-eco21]+Abs[eco131-eco31]+Abs[eco131-eco41]+Abs[eco131-eco51]+Abs[eco131-eco61]+Abs[eco131-eco71]+Abs[eco131-eco81]+Abs[eco131-eco91]+Abs[eco131-eco101]+Abs[eco131-eco111]+Abs[eco131-eco121]+Abs[eco131-eco131])]")

		For i = 0 To 12
			Me.myMathWrapper.WaitAndDiscardAnswer("eco" & i + 1 & "2=ecolis2[[1," & i + 1 & "]]")
		Next

		Me.myMathWrapper.WaitAndDiscardAnswer("ecomea2=(eco12+eco22+eco32+eco42+eco52+eco62+eco72+eco82+eco92+eco102+eco112+eco122+eco132)/13")
		Me.myMathWrapper.WaitAndDiscardAnswer("ecogin2=N[(1/2*1/13^2*(1/ecomea2))(Abs[eco12-eco12]+Abs[eco12-eco22]+Abs[eco12-eco32]+Abs[eco12-eco42]+Abs[eco12-eco52]+Abs[eco12-eco62]+Abs[eco12-eco72]+Abs[eco12-eco82]+Abs[eco12-eco92]+Abs[eco12-eco102]+Abs[eco12-eco112]+Abs[eco12-eco122]+Abs[eco12-eco132]+Abs[eco22-eco12]+Abs[eco22-eco22]+Abs[eco22-eco32]+Abs[eco22-eco42]+Abs[eco22-eco52]+Abs[eco22-eco62]+Abs[eco22-eco72]+Abs[eco22-eco82]+Abs[eco22-eco92]+Abs[eco22-eco102]+Abs[eco22-eco112]+Abs[eco22-eco122]+Abs[eco22-eco132]+Abs[eco32-eco12]+Abs[eco32-eco22]+Abs[eco32-eco32]+Abs[eco32-eco42]+Abs[eco32-eco52]+Abs[eco32-eco62]+Abs[eco32-eco72]+Abs[eco32-eco82]+Abs[eco32-eco92]+Abs[eco32-eco102]+Abs[eco32-eco112]+Abs[eco32-eco122]+Abs[eco32-eco132]+Abs[eco42-eco12]+Abs[eco42-eco22]+Abs[eco42-eco32]+Abs[eco42-eco42]+Abs[eco42-eco52]+Abs[eco42-eco62]+Abs[eco42-eco72]+Abs[eco42-eco82]+Abs[eco42-eco92]+Abs[eco42-eco102]+Abs[eco42-eco112]+Abs[eco42-eco122]+Abs[eco42-eco132]+Abs[eco52-eco12]+Abs[eco52-eco22]+Abs[eco52-eco32]+Abs[eco52-eco42]+Abs[eco52-eco52]+Abs[eco52-eco62]+Abs[eco52-eco72]+Abs[eco52-eco82]+Abs[eco52-eco92]+Abs[eco52-eco102]+Abs[eco52-eco112]+Abs[eco52-eco122]+Abs[eco52-eco132]+Abs[eco62-eco12]+Abs[eco62-eco22]+Abs[eco62-eco32]+Abs[eco62-eco42]+Abs[eco62-eco52]+Abs[eco62-eco62]+Abs[eco62-eco72]+Abs[eco62-eco82]+Abs[eco62-eco92]+Abs[eco62-eco102]+Abs[eco62-eco112]+Abs[eco62-eco122]+Abs[eco62-eco132]+Abs[eco72-eco12]+Abs[eco72-eco22]+Abs[eco72-eco32]+Abs[eco72-eco42]+Abs[eco72-eco52]+Abs[eco72-eco62]+Abs[eco72-eco72]+Abs[eco72-eco82]+Abs[eco72-eco92]+Abs[eco72-eco102]+Abs[eco72-eco112]+Abs[eco72-eco122]+Abs[eco72-eco132]+Abs[eco82-eco12]+Abs[eco82-eco22]+Abs[eco82-eco32]+Abs[eco82-eco42]+Abs[eco82-eco52]+Abs[eco82-eco62]+Abs[eco82-eco72]+Abs[eco82-eco82]+Abs[eco82-eco92]+Abs[eco82-eco102]+Abs[eco82-eco112]+Abs[eco82-eco122]+Abs[eco82-eco132]+Abs[eco92-eco12]+Abs[eco92-eco22]+Abs[eco92-eco32]+Abs[eco92-eco42]+Abs[eco92-eco52]+Abs[eco92-eco62]+Abs[eco92-eco72]+Abs[eco92-eco82]+Abs[eco92-eco92]+Abs[eco92-eco102]+Abs[eco92-eco112]+Abs[eco92-eco122]+Abs[eco92-eco132]+Abs[eco102-eco12]+Abs[eco102-eco22]+Abs[eco102-eco32]+Abs[eco102-eco42]+Abs[eco102-eco52]+Abs[eco102-eco62]+Abs[eco102-eco72]+Abs[eco102-eco82]+Abs[eco102-eco92]+Abs[eco102-eco102]+Abs[eco102-eco112]+Abs[eco102-eco122]+Abs[eco102-eco132]+Abs[eco112-eco12]+Abs[eco112-eco22]+Abs[eco112-eco32]+Abs[eco112-eco42]+Abs[eco112-eco52]+Abs[eco112-eco62]+Abs[eco112-eco72]+Abs[eco112-eco82]+Abs[eco112-eco92]+Abs[eco112-eco102]+Abs[eco112-eco112]+Abs[eco112-eco122]+Abs[eco112-eco132]+Abs[eco122-eco12]+Abs[eco122-eco22]+Abs[eco122-eco32]+Abs[eco122-eco42]+Abs[eco122-eco52]+Abs[eco122-eco62]+Abs[eco122-eco72]+Abs[eco122-eco82]+Abs[eco122-eco92]+Abs[eco122-eco102]+Abs[eco122-eco112]+Abs[eco122-eco122]+Abs[eco122-eco132]+Abs[eco132-eco12]+Abs[eco132-eco22]+Abs[eco132-eco32]+Abs[eco132-eco42]+Abs[eco132-eco52]+Abs[eco132-eco62]+Abs[eco132-eco72]+Abs[eco132-eco82]+Abs[eco132-eco92]+Abs[eco132-eco102]+Abs[eco132-eco112]+Abs[eco132-eco122]+Abs[eco132-eco132])]")

		For i = 0 To 12
			Me.myMathWrapper.WaitAndDiscardAnswer("soc" & i + 1 & "1=soclis1[[1," & i + 1 & "]]")
		Next

		Me.myMathWrapper.WaitAndDiscardAnswer("socmea1=(soc11+soc21+soc31+soc41+soc51+soc61+soc71+soc81+soc91+soc101+soc111+soc121+soc131)/13")
		Me.myMathWrapper.WaitAndDiscardAnswer("socgin1=N[(1/2*1/13^2*(1/socmea1))(Abs[soc11-soc11]+Abs[soc11-soc21]+Abs[soc11-soc31]+Abs[soc11-soc41]+Abs[soc11-soc51]+Abs[soc11-soc61]+Abs[soc11-soc71]+Abs[soc11-soc81]+Abs[soc11-soc91]+Abs[soc11-soc101]+Abs[soc11-soc111]+Abs[soc11-soc121]+Abs[soc11-soc131]+Abs[soc21-soc11]+Abs[soc21-soc21]+Abs[soc21-soc31]+Abs[soc21-soc41]+Abs[soc21-soc51]+Abs[soc21-soc61]+Abs[soc21-soc71]+Abs[soc21-soc81]+Abs[soc21-soc91]+Abs[soc21-soc101]+Abs[soc21-soc111]+Abs[soc21-soc121]+Abs[soc21-soc131]+Abs[soc31-soc11]+Abs[soc31-soc21]+Abs[soc31-soc31]+Abs[soc31-soc41]+Abs[soc31-soc51]+Abs[soc31-soc61]+Abs[soc31-soc71]+Abs[soc31-soc81]+Abs[soc31-soc91]+Abs[soc31-soc101]+Abs[soc31-soc111]+Abs[soc31-soc121]+Abs[soc31-soc131]+Abs[soc41-soc11]+Abs[soc41-soc21]+Abs[soc41-soc31]+Abs[soc41-soc41]+Abs[soc41-soc51]+Abs[soc41-soc61]+Abs[soc41-soc71]+Abs[soc41-soc81]+Abs[soc41-soc91]+Abs[soc41-soc101]+Abs[soc41-soc111]+Abs[soc41-soc121]+Abs[soc41-soc131]+Abs[soc51-soc11]+Abs[soc51-soc21]+Abs[soc51-soc31]+Abs[soc51-soc41]+Abs[soc51-soc51]+Abs[soc51-soc61]+Abs[soc51-soc71]+Abs[soc51-soc81]+Abs[soc51-soc91]+Abs[soc51-soc101]+Abs[soc51-soc111]+Abs[soc51-soc121]+Abs[soc51-soc131]+Abs[soc61-soc11]+Abs[soc61-soc21]+Abs[soc61-soc31]+Abs[soc61-soc41]+Abs[soc61-soc51]+Abs[soc61-soc61]+Abs[soc61-soc71]+Abs[soc61-soc81]+Abs[soc61-soc91]+Abs[soc61-soc101]+Abs[soc61-soc111]+Abs[soc61-soc121]+Abs[soc61-soc131]+Abs[soc71-soc11]+Abs[soc71-soc21]+Abs[soc71-soc31]+Abs[soc71-soc41]+Abs[soc71-soc51]+Abs[soc71-soc61]+Abs[soc71-soc71]+Abs[soc71-soc81]+Abs[soc71-soc91]+Abs[soc71-soc101]+Abs[soc71-soc111]+Abs[soc71-soc121]+Abs[soc71-soc131]+Abs[soc81-soc11]+Abs[soc81-soc21]+Abs[soc81-soc31]+Abs[soc81-soc41]+Abs[soc81-soc51]+Abs[soc81-soc61]+Abs[soc81-soc71]+Abs[soc81-soc81]+Abs[soc81-soc91]+Abs[soc81-soc101]+Abs[soc81-soc111]+Abs[soc81-soc121]+Abs[soc81-soc131]+Abs[soc91-soc11]+Abs[soc91-soc21]+Abs[soc91-soc31]+Abs[soc91-soc41]+Abs[soc91-soc51]+Abs[soc91-soc61]+Abs[soc91-soc71]+Abs[soc91-soc81]+Abs[soc91-soc91]+Abs[soc91-soc101]+Abs[soc91-soc111]+Abs[soc91-soc121]+Abs[soc91-soc131]+Abs[soc101-soc11]+Abs[soc101-soc21]+Abs[soc101-soc31]+Abs[soc101-soc41]+Abs[soc101-soc51]+Abs[soc101-soc61]+Abs[soc101-soc71]+Abs[soc101-soc81]+Abs[soc101-soc91]+Abs[soc101-soc101]+Abs[soc101-soc111]+Abs[soc101-soc121]+Abs[soc101-soc131]+Abs[soc111-soc11]+Abs[soc111-soc21]+Abs[soc111-soc31]+Abs[soc111-soc41]+Abs[soc111-soc51]+Abs[soc111-soc61]+Abs[soc111-soc71]+Abs[soc111-soc81]+Abs[soc111-soc91]+Abs[soc111-soc101]+Abs[soc111-soc111]+Abs[soc111-soc121]+Abs[soc111-soc131]+Abs[soc121-soc11]+Abs[soc121-soc21]+Abs[soc121-soc31]+Abs[soc121-soc41]+Abs[soc121-soc51]+Abs[soc121-soc61]+Abs[soc121-soc71]+Abs[soc121-soc81]+Abs[soc121-soc91]+Abs[soc121-soc101]+Abs[soc121-soc111]+Abs[soc121-soc121]+Abs[soc121-soc131]+Abs[soc131-soc11]+Abs[soc131-soc21]+Abs[soc131-soc31]+Abs[soc131-soc41]+Abs[soc131-soc51]+Abs[soc131-soc61]+Abs[soc131-soc71]+Abs[soc131-soc81]+Abs[soc131-soc91]+Abs[soc131-soc101]+Abs[soc131-soc111]+Abs[soc131-soc121]+Abs[soc131-soc131])]")

		For i = 0 To 12
			Me.myMathWrapper.WaitAndDiscardAnswer("soc" & i + 1 & "2=soclis2[[1," & i + 1 & "]]")
		Next

		Me.myMathWrapper.WaitAndDiscardAnswer("socmea2=(soc12+soc22+soc32+soc42+soc52+soc62+soc72+soc82+soc92+soc102+soc112+soc122+soc132)/13")
		Me.myMathWrapper.WaitAndDiscardAnswer("socgin2=N[(1/2*1/13^2*(1/socmea2))(Abs[soc12-soc12]+Abs[soc12-soc22]+Abs[soc12-soc32]+Abs[soc12-soc42]+Abs[soc12-soc52]+Abs[soc12-soc62]+Abs[soc12-soc72]+Abs[soc12-soc82]+Abs[soc12-soc92]+Abs[soc12-soc102]+Abs[soc12-soc112]+Abs[soc12-soc122]+Abs[soc12-soc132]+Abs[soc22-soc12]+Abs[soc22-soc22]+Abs[soc22-soc32]+Abs[soc22-soc42]+Abs[soc22-soc52]+Abs[soc22-soc62]+Abs[soc22-soc72]+Abs[soc22-soc82]+Abs[soc22-soc92]+Abs[soc22-soc102]+Abs[soc22-soc112]+Abs[soc22-soc122]+Abs[soc22-soc132]+Abs[soc32-soc12]+Abs[soc32-soc22]+Abs[soc32-soc32]+Abs[soc32-soc42]+Abs[soc32-soc52]+Abs[soc32-soc62]+Abs[soc32-soc72]+Abs[soc32-soc82]+Abs[soc32-soc92]+Abs[soc32-soc102]+Abs[soc32-soc112]+Abs[soc32-soc122]+Abs[soc32-soc132]+Abs[soc42-soc12]+Abs[soc42-soc22]+Abs[soc42-soc32]+Abs[soc42-soc42]+Abs[soc42-soc52]+Abs[soc42-soc62]+Abs[soc42-soc72]+Abs[soc42-soc82]+Abs[soc42-soc92]+Abs[soc42-soc102]+Abs[soc42-soc112]+Abs[soc42-soc122]+Abs[soc42-soc132]+Abs[soc52-soc12]+Abs[soc52-soc22]+Abs[soc52-soc32]+Abs[soc52-soc42]+Abs[soc52-soc52]+Abs[soc52-soc62]+Abs[soc52-soc72]+Abs[soc52-soc82]+Abs[soc52-soc92]+Abs[soc52-soc102]+Abs[soc52-soc112]+Abs[soc52-soc122]+Abs[soc52-soc132]+Abs[soc62-soc12]+Abs[soc62-soc22]+Abs[soc62-soc32]+Abs[soc62-soc42]+Abs[soc62-soc52]+Abs[soc62-soc62]+Abs[soc62-soc72]+Abs[soc62-soc82]+Abs[soc62-soc92]+Abs[soc62-soc102]+Abs[soc62-soc112]+Abs[soc62-soc122]+Abs[soc62-soc132]+Abs[soc72-soc12]+Abs[soc72-soc22]+Abs[soc72-soc32]+Abs[soc72-soc42]+Abs[soc72-soc52]+Abs[soc72-soc62]+Abs[soc72-soc72]+Abs[soc72-soc82]+Abs[soc72-soc92]+Abs[soc72-soc102]+Abs[soc72-soc112]+Abs[soc72-soc122]+Abs[soc72-soc132]+Abs[soc82-soc12]+Abs[soc82-soc22]+Abs[soc82-soc32]+Abs[soc82-soc42]+Abs[soc82-soc52]+Abs[soc82-soc62]+Abs[soc82-soc72]+Abs[soc82-soc82]+Abs[soc82-soc92]+Abs[soc82-soc102]+Abs[soc82-soc112]+Abs[soc82-soc122]+Abs[soc82-soc132]+Abs[soc92-soc12]+Abs[soc92-soc22]+Abs[soc92-soc32]+Abs[soc92-soc42]+Abs[soc92-soc52]+Abs[soc92-soc62]+Abs[soc92-soc72]+Abs[soc92-soc82]+Abs[soc92-soc92]+Abs[soc92-soc102]+Abs[soc92-soc112]+Abs[soc92-soc122]+Abs[soc92-soc132]+Abs[soc102-soc12]+Abs[soc102-soc22]+Abs[soc102-soc32]+Abs[soc102-soc42]+Abs[soc102-soc52]+Abs[soc102-soc62]+Abs[soc102-soc72]+Abs[soc102-soc82]+Abs[soc102-soc92]+Abs[soc102-soc102]+Abs[soc102-soc112]+Abs[soc102-soc122]+Abs[soc102-soc132]+Abs[soc112-soc12]+Abs[soc112-soc22]+Abs[soc112-soc32]+Abs[soc112-soc42]+Abs[soc112-soc52]+Abs[soc112-soc62]+Abs[soc112-soc72]+Abs[soc112-soc82]+Abs[soc112-soc92]+Abs[soc112-soc102]+Abs[soc112-soc112]+Abs[soc112-soc122]+Abs[soc112-soc132]+Abs[soc122-soc12]+Abs[soc122-soc22]+Abs[soc122-soc32]+Abs[soc122-soc42]+Abs[soc122-soc52]+Abs[soc122-soc62]+Abs[soc122-soc72]+Abs[soc122-soc82]+Abs[soc122-soc92]+Abs[soc122-soc102]+Abs[soc122-soc112]+Abs[soc122-soc122]+Abs[soc122-soc132]+Abs[soc132-soc12]+Abs[soc132-soc22]+Abs[soc132-soc32]+Abs[soc132-soc42]+Abs[soc132-soc52]+Abs[soc132-soc62]+Abs[soc132-soc72]+Abs[soc132-soc82]+Abs[soc132-soc92]+Abs[soc132-soc102]+Abs[soc132-soc112]+Abs[soc132-soc122]+Abs[soc132-soc132])]")

		For i = 0 To 12
			Me.myMathWrapper.WaitAndDiscardAnswer("env" & i + 1 & "1=envlis1[[1," & i + 1 & "]]")
		Next

		Me.myMathWrapper.WaitAndDiscardAnswer("envmea1=(env11+env21+env31+env41+env51+env61+env71+env81+env91+env101+env111+env121+env131)/13")
		Me.myMathWrapper.WaitAndDiscardAnswer("envgin1=N[(1/2*1/13^2*(1/envmea1))(Abs[env11-env11]+Abs[env11-env21]+Abs[env11-env31]+Abs[env11-env41]+Abs[env11-env51]+Abs[env11-env61]+Abs[env11-env71]+Abs[env11-env81]+Abs[env11-env91]+Abs[env11-env101]+Abs[env11-env111]+Abs[env11-env121]+Abs[env11-env131]+Abs[env21-env11]+Abs[env21-env21]+Abs[env21-env31]+Abs[env21-env41]+Abs[env21-env51]+Abs[env21-env61]+Abs[env21-env71]+Abs[env21-env81]+Abs[env21-env91]+Abs[env21-env101]+Abs[env21-env111]+Abs[env21-env121]+Abs[env21-env131]+Abs[env31-env11]+Abs[env31-env21]+Abs[env31-env31]+Abs[env31-env41]+Abs[env31-env51]+Abs[env31-env61]+Abs[env31-env71]+Abs[env31-env81]+Abs[env31-env91]+Abs[env31-env101]+Abs[env31-env111]+Abs[env31-env121]+Abs[env31-env131]+Abs[env41-env11]+Abs[env41-env21]+Abs[env41-env31]+Abs[env41-env41]+Abs[env41-env51]+Abs[env41-env61]+Abs[env41-env71]+Abs[env41-env81]+Abs[env41-env91]+Abs[env41-env101]+Abs[env41-env111]+Abs[env41-env121]+Abs[env41-env131]+Abs[env51-env11]+Abs[env51-env21]+Abs[env51-env31]+Abs[env51-env41]+Abs[env51-env51]+Abs[env51-env61]+Abs[env51-env71]+Abs[env51-env81]+Abs[env51-env91]+Abs[env51-env101]+Abs[env51-env111]+Abs[env51-env121]+Abs[env51-env131]+Abs[env61-env11]+Abs[env61-env21]+Abs[env61-env31]+Abs[env61-env41]+Abs[env61-env51]+Abs[env61-env61]+Abs[env61-env71]+Abs[env61-env81]+Abs[env61-env91]+Abs[env61-env101]+Abs[env61-env111]+Abs[env61-env121]+Abs[env61-env131]+Abs[env71-env11]+Abs[env71-env21]+Abs[env71-env31]+Abs[env71-env41]+Abs[env71-env51]+Abs[env71-env61]+Abs[env71-env71]+Abs[env71-env81]+Abs[env71-env91]+Abs[env71-env101]+Abs[env71-env111]+Abs[env71-env121]+Abs[env71-env131]+Abs[env81-env11]+Abs[env81-env21]+Abs[env81-env31]+Abs[env81-env41]+Abs[env81-env51]+Abs[env81-env61]+Abs[env81-env71]+Abs[env81-env81]+Abs[env81-env91]+Abs[env81-env101]+Abs[env81-env111]+Abs[env81-env121]+Abs[env81-env131]+Abs[env91-env11]+Abs[env91-env21]+Abs[env91-env31]+Abs[env91-env41]+Abs[env91-env51]+Abs[env91-env61]+Abs[env91-env71]+Abs[env91-env81]+Abs[env91-env91]+Abs[env91-env101]+Abs[env91-env111]+Abs[env91-env121]+Abs[env91-env131]+Abs[env101-env11]+Abs[env101-env21]+Abs[env101-env31]+Abs[env101-env41]+Abs[env101-env51]+Abs[env101-env61]+Abs[env101-env71]+Abs[env101-env81]+Abs[env101-env91]+Abs[env101-env101]+Abs[env101-env111]+Abs[env101-env121]+Abs[env101-env131]+Abs[env111-env11]+Abs[env111-env21]+Abs[env111-env31]+Abs[env111-env41]+Abs[env111-env51]+Abs[env111-env61]+Abs[env111-env71]+Abs[env111-env81]+Abs[env111-env91]+Abs[env111-env101]+Abs[env111-env111]+Abs[env111-env121]+Abs[env111-env131]+Abs[env121-env11]+Abs[env121-env21]+Abs[env121-env31]+Abs[env121-env41]+Abs[env121-env51]+Abs[env121-env61]+Abs[env121-env71]+Abs[env121-env81]+Abs[env121-env91]+Abs[env121-env101]+Abs[env121-env111]+Abs[env121-env121]+Abs[env121-env131]+Abs[env131-env11]+Abs[env131-env21]+Abs[env131-env31]+Abs[env131-env41]+Abs[env131-env51]+Abs[env131-env61]+Abs[env131-env71]+Abs[env131-env81]+Abs[env131-env91]+Abs[env131-env101]+Abs[env131-env111]+Abs[env131-env121]+Abs[env131-env131])]")

		For i = 0 To 12
			Me.myMathWrapper.WaitAndDiscardAnswer("env" & i + 1 & "2=envlis2[[1," & i + 1 & "]]")
		Next

		Me.myMathWrapper.WaitAndDiscardAnswer("envmea2=(env12+env22+env32+env42+env52+env62+env72+env82+env92+env102+env112+env122+env132)/13")
		Me.myMathWrapper.WaitAndDiscardAnswer("envgin2=N[(1/2*1/13^2*(1/envmea2))(Abs[env12-env12]+Abs[env12-env22]+Abs[env12-env32]+Abs[env12-env42]+Abs[env12-env52]+Abs[env12-env62]+Abs[env12-env72]+Abs[env12-env82]+Abs[env12-env92]+Abs[env12-env102]+Abs[env12-env112]+Abs[env12-env122]+Abs[env12-env132]+Abs[env22-env12]+Abs[env22-env22]+Abs[env22-env32]+Abs[env22-env42]+Abs[env22-env52]+Abs[env22-env62]+Abs[env22-env72]+Abs[env22-env82]+Abs[env22-env92]+Abs[env22-env102]+Abs[env22-env112]+Abs[env22-env122]+Abs[env22-env132]+Abs[env32-env12]+Abs[env32-env22]+Abs[env32-env32]+Abs[env32-env42]+Abs[env32-env52]+Abs[env32-env62]+Abs[env32-env72]+Abs[env32-env82]+Abs[env32-env92]+Abs[env32-env102]+Abs[env32-env112]+Abs[env32-env122]+Abs[env32-env132]+Abs[env42-env12]+Abs[env42-env22]+Abs[env42-env32]+Abs[env42-env42]+Abs[env42-env52]+Abs[env42-env62]+Abs[env42-env72]+Abs[env42-env82]+Abs[env42-env92]+Abs[env42-env102]+Abs[env42-env112]+Abs[env42-env122]+Abs[env42-env132]+Abs[env52-env12]+Abs[env52-env22]+Abs[env52-env32]+Abs[env52-env42]+Abs[env52-env52]+Abs[env52-env62]+Abs[env52-env72]+Abs[env52-env82]+Abs[env52-env92]+Abs[env52-env102]+Abs[env52-env112]+Abs[env52-env122]+Abs[env52-env132]+Abs[env62-env12]+Abs[env62-env22]+Abs[env62-env32]+Abs[env62-env42]+Abs[env62-env52]+Abs[env62-env62]+Abs[env62-env72]+Abs[env62-env82]+Abs[env62-env92]+Abs[env62-env102]+Abs[env62-env112]+Abs[env62-env122]+Abs[env62-env132]+Abs[env72-env12]+Abs[env72-env22]+Abs[env72-env32]+Abs[env72-env42]+Abs[env72-env52]+Abs[env72-env62]+Abs[env72-env72]+Abs[env72-env82]+Abs[env72-env92]+Abs[env72-env102]+Abs[env72-env112]+Abs[env72-env122]+Abs[env72-env132]+Abs[env82-env12]+Abs[env82-env22]+Abs[env82-env32]+Abs[env82-env42]+Abs[env82-env52]+Abs[env82-env62]+Abs[env82-env72]+Abs[env82-env82]+Abs[env82-env92]+Abs[env82-env102]+Abs[env82-env112]+Abs[env82-env122]+Abs[env82-env132]+Abs[env92-env12]+Abs[env92-env22]+Abs[env92-env32]+Abs[env92-env42]+Abs[env92-env52]+Abs[env92-env62]+Abs[env92-env72]+Abs[env92-env82]+Abs[env92-env92]+Abs[env92-env102]+Abs[env92-env112]+Abs[env92-env122]+Abs[env92-env132]+Abs[env102-env12]+Abs[env102-env22]+Abs[env102-env32]+Abs[env102-env42]+Abs[env102-env52]+Abs[env102-env62]+Abs[env102-env72]+Abs[env102-env82]+Abs[env102-env92]+Abs[env102-env102]+Abs[env102-env112]+Abs[env102-env122]+Abs[env102-env132]+Abs[env112-env12]+Abs[env112-env22]+Abs[env112-env32]+Abs[env112-env42]+Abs[env112-env52]+Abs[env112-env62]+Abs[env112-env72]+Abs[env112-env82]+Abs[env112-env92]+Abs[env112-env102]+Abs[env112-env112]+Abs[env112-env122]+Abs[env112-env132]+Abs[env122-env12]+Abs[env122-env22]+Abs[env122-env32]+Abs[env122-env42]+Abs[env122-env52]+Abs[env122-env62]+Abs[env122-env72]+Abs[env122-env82]+Abs[env122-env92]+Abs[env122-env102]+Abs[env122-env112]+Abs[env122-env122]+Abs[env122-env132]+Abs[env132-env12]+Abs[env132-env22]+Abs[env132-env32]+Abs[env132-env42]+Abs[env132-env52]+Abs[env132-env62]+Abs[env132-env72]+Abs[env132-env82]+Abs[env132-env92]+Abs[env132-env102]+Abs[env132-env112]+Abs[env132-env122]+Abs[env132-env132])]")

		Me.myMathWrapper.WaitAndDiscardAnswer("mobj = m[[{1}]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("marg = m[[{2}]]")

		'x 26 output for agriculture
		Dim cursor As Integer

		cursor = 1
		For i = 0 To 12
			For j = 0 To 1
				Me.outagr(i, j) = Me.myMathWrapper.WaitAndEvaluateAsDouble("x" & (i + 1).ToString & (j + 1).ToString & "/.marg[[1," & cursor & "]]")
				cursor += 1
			Next
		Next

		'y 13 output for industries
		For i = 0 To 12
			Me.outind(i) = Me.myMathWrapper.WaitAndEvaluateAsDouble("y" & (i + 1).ToString & "2/.marg[[1," & cursor & "]]")
			cursor += 1
		Next

		'z 26 output for landscape
		For i = 0 To 12
			For j = 0 To 1
				Me.outlan(i, j) = Me.myMathWrapper.WaitAndEvaluateAsDouble("z" & (i + 1).ToString & (j + 1).ToString & "/.marg[[1," & cursor & "]]")
				cursor += 1
			Next
		Next

		'free varibles used for graph plotting

		Me.myMathWrapper.WaitAndDiscardAnswer("sbqi=.")
		Me.myMathWrapper.WaitAndDiscardAnswer("ssqi=.")
		Me.myMathWrapper.WaitAndDiscardAnswer("smqi=.")
		Me.myMathWrapper.WaitAndDiscardAnswer("tpbx=.")
		Me.myMathWrapper.WaitAndDiscardAnswer("tpsx=.")
		Me.myMathWrapper.WaitAndDiscardAnswer("tpsz=.")
		Me.myMathWrapper.WaitAndDiscardAnswer("tpmz=.")
		Me.myMathWrapper.WaitAndDiscardAnswer("ecow=.")
		Me.myMathWrapper.WaitAndDiscardAnswer("socw=.")
		Me.myMathWrapper.WaitAndDiscardAnswer("envw=.")
		Me.myMathWrapper.WaitAndDiscardAnswer("agrw=.")
		Me.myMathWrapper.WaitAndDiscardAnswer("indw=.")
		Me.myMathWrapper.WaitAndDiscardAnswer("lanw=.")
		Me.myMathWrapper.WaitAndDiscardAnswer("gwsp=.")
		Me.myMathWrapper.WaitAndDiscardAnswer("totpla=.")
		Me.myMathWrapper.WaitAndDiscardAnswer("tpbx=.")
		Me.myMathWrapper.WaitAndDiscardAnswer("tpmz =.")

		'defining graph parameters
		Me.myMathWrapper.WaitAndDiscardAnswer("ssqi = 1000")
		Me.myMathWrapper.WaitAndDiscardAnswer("ecow = 1 - socw - envw")
		Me.myMathWrapper.WaitAndDiscardAnswer("agrw = 0.33")
		Me.myMathWrapper.WaitAndDiscardAnswer("indw = 0.33")
		Me.myMathWrapper.WaitAndDiscardAnswer("lanw = 0.33")
		Me.myMathWrapper.WaitAndDiscardAnswer("gwsp = 1.518")
		Me.myMathWrapper.WaitAndDiscardAnswer("totpla = 20")
		Me.myMathWrapper.WaitAndDiscardAnswer("totobj20rWEL =.")
		Me.myMathWrapper.WaitAndDiscardAnswer("totobj20rSUS =.")
		Me.myMathWrapper.WaitAndDiscardAnswer("totobj20rEFF =.")

		'adapt matrix syntax to minimize solution
		Me.myMathWrapper.WaitAndDiscardAnswer("totobj20 = totobj20 /. {x[1][1] -> x11, x[1][2] -> x12, x[2][1] -> x21, x[2][2] -> x22, x[3][1] -> x31, x[3][2] -> x32, x[4][1] -> x41, x[4][2] -> x42, x[5][1] -> x51, x[5][2] -> x52, x[6][1] -> x61, x[6][2] -> x62, x[7][1] -> x71, x[7][2] -> x72, x[8][1] -> x81, x[8][2] -> x82, x[9][1] -> x91, x[9][2] -> x92, x[10][1] -> x101, x[10][2] -> x102, x[11][1] -> x111, x[11][2] -> x112, x[12][1] -> x121, x[12][2] -> x122, x[13][1] -> x131, x[13][2] -> x132, y[1][1] -> y11, y[1][2] -> y12, y[2][1] -> y21, y[2][2] -> y22, y[3][1] -> y31, y[3][2] -> y32, y[4][1] -> y41, y[4][2] -> y42, y[5][1] -> y51, y[5][2] -> y52, y[6][1] -> y61, y[6][2] -> y62, y[7][1] -> y71, y[7][2] -> y72, y[8][1] -> y81, y[8][2] -> y82, y[9][1] -> y91, y[9][2] -> y92, y[10][1] -> y101, y[10][2] -> y102, y[11][1] -> y111, y[11][2] -> y112, y[12][1] -> y121, y[12][2] -> y122, y[13][1] -> y131, y[13][2] -> y132, z[1][1] -> z11, z[1][2] -> z12, z[2][1] -> z21, z[2][2] -> z22, z[3][1] -> z31, z[3][2] -> z32, z[4][1] -> z41, z[4][2] -> z42, z[5][1] -> z51, z[5][2] -> z52, z[6][1] -> z61, z[6][2] -> z62, z[7][1] -> z71, z[7][2] -> z72, z[8][1] -> z81, z[8][2] -> z82, z[9][1] -> z91, z[9][2] -> z92, z[10][1] -> z101, z[10][2] -> z102, z[11][1] -> z111, z[11][2] -> z112, z[12][1] -> z121, z[12][2] -> z122, z[13][1] -> z131, z[13][2] -> z132}")

		Me.myMathWrapper.WaitAndDiscardAnswer("totobj20rWEL = totobj20*100 /. marg")
		Me.myMathWrapper.WaitAndDiscardAnswer("totobj20rWEL = totobj20rWEL /. {sbqi -> 20, smqi -> 20, tpbx -> 0.35, tpmz -> 0.30}")
		Me.myMathWrapper.WaitAndDiscardAnswer("totobj20rSUS = totobj20*100 /. marg")
		Me.myMathWrapper.WaitAndDiscardAnswer("totobj20rSUS = totobj20rSUS /. {socw -> 0.33, envw -> 0.33, tpbx -> 0.35, tpmz -> 0.30}")
		Me.myMathWrapper.WaitAndDiscardAnswer("totobj20rEFF = totobj20*100 /. marg")
		Me.myMathWrapper.WaitAndDiscardAnswer("totobj20rEFF = totobj20rEFF /. {sbqi -> 20, smqi -> 20, socw -> 0.33, envw -> 0.33}")

		Me.myMathWrapper.WaitAndDiscardAnswer("mobj = m[[1]]")
		Me.myMathWrapper.WaitAndDiscardAnswer("ranup = mobj * 1.1")
		Me.myMathWrapper.WaitAndDiscardAnswer("rando = mobj * 0.9")

		Me.pboGraphWeights.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[totobj20rWEL, {socw, 0, 1}, {envw, 0, 1}, PlotRange -> {ranup, rando}, ContourLabels -> All, FrameLabel -> {""socw %"", ""envw %""}]", Me.pboGraphWeights)
		Me.pboGraphStandards.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[totobj20rSUS, {smqi, 0, 40}, {sbqi, 0, 40}, PlotRange -> {ranup, rando}, ContourLabels -> All, FrameLabel -> {""TSS mg/l"", ""BOD mg/l""}]", Me.pboGraphStandards)
		Me.pboGraphEfficiencies.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("ContourPlot[totobj20rEFF, {tpbx, 0, 1}, {tpmz, 0, 1}, PlotRange -> {ranup, rando}, ContourLabels -> All, FrameLabel -> {""TSS % cut"", ""BOD % cut""}]", Me.pboGraphEfficiencies)

		Me.WriteValuesToDB()
	End Sub

	''' <summary>
	''' resets data to defaults
	''' </summary>
	''' <remarks></remarks>
	Private Sub Reset(skipRequest As Boolean)
		Dim i, j As Integer

		If skipRequest OrElse MessageBox.Show("Are you sure you want to reset data to default values?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
			For i = 0 To 12
				Me.bod(i) = 0
				Me.tds(i) = 0
				Me.tss(i) = 0
				Me.des(i) = 0
				Me.gro(i) = 0
			Next

			For i = 0 To 12
				For j = 0 To 1
					Me.indcc(i, j) = 0
					Me.agrcc(i, j) = 0
					Me.lancc(i, j) = 0
					Me.lbqi(i, j) = 0
					Me.lsqi(i, j) = 0
					Me.lmqi(i, j) = 0
					Me.pop20(i, j) = 0
					Me.inddis(i, j) = 0
					Me.inddiscur(i, j) = 0
					Me.inddispln(i, j) = 0
				Next
			Next

			Me.gwsp = 0
			Me.agruf = 0
			Me.agrufro = 0
			Me.induf = 0
			Me.indufro = 0
			Me.lanuf = 0
			Me.lanufro = 0
			Me.tpbx = 0
			Me.tpsx = 0
			Me.tpmz = 0
			Me.envw = 0
			Me.socw = 0
			Me.totpla = 0
			Me.sbqi = 0
			Me.ssqi = 0
			Me.smqi = 0

			Me.WriteValuesToGUI(WriteToGUIType.input)

			Me.RefreshMap(Me.groupBoxes(0), New System.EventArgs)
		End If
	End Sub

	''' <summary>
	''' change text on btnNext
	''' </summary>
	''' <remarks></remarks>
	Private Sub SetNextText()
		If Me.groupBoxesID = Me.groupBoxes.Length - 2 Then
			Me.btnNext.Text = "Calculate"
		Else
			Me.btnNext.Text = "Next"
		End If
	End Sub

	''' <summary>
	''' change text on btnPrev
	''' </summary>
	''' <remarks></remarks>
	Private Sub SetPrevText()
		If Me.groupBoxesID = 0 Then
			Me.btnPrev.Text = "Reset"
		Else
			Me.btnPrev.Text = "Previous"
		End If
	End Sub

	''' <summary>
	''' show previous input/output panel
	''' </summary>
	''' <remarks></remarks>
	Private Sub PreviousStep()
		Me.groupBoxesID -= 1

		Me.SetPrevText()
		Me.ShowButtons()
		Me.ShowBox()
	End Sub

	''' <summary>
	''' show next input/output panel
	''' </summary>
	''' <remarks></remarks>
	Private Sub NextStep()
		Me.groupBoxesID += 1

		Me.SetPrevText()
		Me.ShowButtons()

		If Me.groupBoxesID = Me.groupBoxes.Length - 1 Then
			'end of input phase
			Me.Enabled = False
			Me.Cursor = Cursors.WaitCursor
			Me.Calculate()
			Me.WriteValuesToGUI(WriteToGUIType.output)
			Me.Enabled = True
			Me.Cursor = Cursors.Default
		End If

		If Me.groupBoxesID = Me.groupBoxes.Length Then
			Me.Close()
		Else
			Me.ShowBox()
			If Me.groupBoxesID = Me.groupBoxes.Length Then
				Me.Close()
			End If
		End If
	End Sub

	''' <summary>
	''' shows or hides btnPrev and btnNext depending on current box shown
	''' </summary>
	''' <remarks></remarks>
	Private Sub ShowButtons()
		If Me.groupBoxesID < Me.groupBoxes.Length - 1 Then
			Me.btnPrev.Visible = True
			Me.btnNext.Visible = True
		Else
			'Me.btnPrev.Visible = False
			Me.btnNext.Visible = False
		End If

		If Me.groupBoxesID = Me.groupBoxes.Length - 1 Then
			'end of input phase
			Me.Enabled = False
			Me.Cursor = Cursors.WaitCursor
			Me.Enabled = True
			Me.Cursor = Cursors.Default
		End If
	End Sub

	''' <summary>
	''' shows current groupBox
	''' </summary>
	''' <remarks></remarks>
	Private Sub ShowBox()
		Dim i As Integer

		Me.SetPrevText()
		Me.SetNextText()

		If Me.groupBoxesID > 0 Then
			Me.btnLoadData.Visible = False
		Else
			Me.btnLoadData.Visible = True
		End If

		For i = 0 To Me.groupBoxes.Length - 1
			Me.groupBoxes(i).Visible = False
		Next

		Me.groupBoxes(Me.groupBoxesID).DSSVisible = True

		Try
			Me.SplitContainer.SplitterDistance = Me.groupBoxes(Me.groupBoxesID).Width
		Catch ex As Exception
		End Try
	End Sub

	''' <summary>
	''' reads data from DB to local variables and to users controls
	''' </summary>
	''' <remarks></remarks>
	Private Sub ReadValuesFromDB()
		Me.ReadValuesFromDB(0)
	End Sub

	''' <summary>
	''' reads data from DB to local variables and to users controls
	''' </summary>
	''' <remarks></remarks>
	Private Sub ReadValuesFromDB(ID As Integer)
		Dim i, j As Integer
		'read data from DB
		Me.daData.Fill(Me.DSData)

		Dim tmpDataRowView As DataRowView

		If ID > 0 Then
			Me.DSData.data.DefaultView.RowFilter = "datID = " & ID
		End If

		If Me.DSData.data.DefaultView.Count > 0 Then
			Me.DSData.data.DefaultView.Sort = " datID ASC "
			tmpDataRowView = Me.DSData.data.DefaultView.Item(Me.DSData.data.DefaultView.Count - 1)

			For i = 0 To 12
				Me.bod(i) = Utility.NullToDouble(tmpDataRowView.Item("bod" & i + 1))
				Me.tds(i) = Utility.NullToDouble(tmpDataRowView.Item("tds" & i + 1))
				Me.tss(i) = Utility.NullToDouble(tmpDataRowView.Item("tss" & i + 1))
				Me.des(i) = Utility.NullToDouble(tmpDataRowView.Item("indcc" & i + 1 & "_1"))
				Me.gro(i) = Utility.NullToDouble(tmpDataRowView.Item("agrcc" & i + 1 & "_1"))
			Next

			For i = 0 To 12
				For j = 0 To 1
					Me.indcc(i, j) = Utility.NullToDouble(tmpDataRowView.Item("indcc" & i + 1 & "_" & j + 1))
					Me.agrcc(i, j) = Utility.NullToDouble(tmpDataRowView.Item("agrcc" & i + 1 & "_" & j + 1))
					Me.lancc(i, j) = Utility.NullToDouble(tmpDataRowView.Item("lancc" & i + 1 & "_" & j + 1))
					Me.lbqi(i, j) = Utility.NullToDouble(tmpDataRowView.Item("lbqi" & i + 1 & "_" & j + 1))
					Me.lsqi(i, j) = Utility.NullToDouble(tmpDataRowView.Item("lsqi" & i + 1 & "_" & j + 1))
					Me.lmqi(i, j) = Utility.NullToDouble(tmpDataRowView.Item("lmqi" & i + 1 & "_" & j + 1))
					Me.pop20(i, j) = Utility.NullToInteger(tmpDataRowView.Item("pop20_" & i + 1 & "_" & j + 1))
					Me.inddis(i, j) = Utility.NullToInteger(tmpDataRowView.Item("inddis" & i + 1 & "_" & j + 1))
					Me.inddiscur(i, j) = Utility.NullToInteger(tmpDataRowView.Item("inddiscur" & i + 1 & "_" & j + 1))
					Me.inddispln(i, j) = Utility.NullToInteger(tmpDataRowView.Item("inddispln" & i + 1 & "_" & j + 1))
				Next
			Next

			Me.gwsp = Utility.NullToDouble(tmpDataRowView.Item("gwsp"))
			Me.agruf = Utility.NullToDouble(tmpDataRowView.Item("agruf"))
			Me.agrufro = Utility.NullToDouble(tmpDataRowView.Item("agrufro"))
			Me.induf = Utility.NullToDouble(tmpDataRowView.Item("induf"))
			Me.indufro = Utility.NullToDouble(tmpDataRowView.Item("indufro"))
			Me.lanuf = Utility.NullToDouble(tmpDataRowView.Item("lanuf"))
			Me.lanufro = Utility.NullToDouble(tmpDataRowView.Item("lanufro"))
			Me.tpbx = Utility.NullToDouble(tmpDataRowView.Item("tpbx"))
			Me.tpsx = Utility.NullToDouble(tmpDataRowView.Item("tpsx"))
			Me.tpmz = Utility.NullToDouble(tmpDataRowView.Item("tpmz"))
			Me.envw = Utility.NullToDouble(tmpDataRowView.Item("envw"))
			Me.ecow = Utility.NullToDouble(tmpDataRowView.Item("ecow"))
			Me.socw = Utility.NullToDouble(tmpDataRowView.Item("socw"))
			Me.totpla = Utility.NullToDouble(tmpDataRowView.Item("totpla"))
			Me.sbqi = Utility.NullToDouble(tmpDataRowView.Item("sbqi"))
			Me.ssqi = Utility.NullToDouble(tmpDataRowView.Item("ssqi"))
			Me.smqi = Utility.NullToDouble(tmpDataRowView.Item("smqi"))
		Else
			'no data in DB
			Me.Reset(True)
		End If

		Me.WriteValuesToGUI(WriteToGUIType.input)
	End Sub

	''' <summary>
	''' writes data into DB
	''' </summary>
	''' <remarks></remarks>
	Private Sub WriteValuesToDB()
		Dim newRow As DataRow
		Dim i, j As Integer

		If MessageBox.Show("Do you want to save the current scenario?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
			Try
				newRow = Me.DSData.Tables("data").NewRow

				For i = 0 To 12
					newRow("bod" & i + 1) = Me.bod(i)
					newRow("tds" & i + 1) = Me.tds(i)
					newRow("tss" & i + 1) = Me.tss(i)
				Next

				For i = 0 To 12
					For j = 0 To 1
						newRow("indcc" & i + 1 & "_" & j + 1) = Me.indcc(i, j)
						newRow("agrcc" & i + 1 & "_" & j + 1) = Me.agrcc(i, j)
						newRow("lancc" & i + 1 & "_" & j + 1) = Me.lancc(i, j)
						newRow("lbqi" & i + 1 & "_" & j + 1) = Me.lbqi(i, j)
						newRow("lsqi" & i + 1 & "_" & j + 1) = Me.lsqi(i, j)
						newRow("lmqi" & i + 1 & "_" & j + 1) = Me.lmqi(i, j)
						newRow("pop20_" & i + 1 & "_" & j + 1) = Me.pop20(i, j)
						newRow("inddis" & i + 1 & "_" & j + 1) = Me.inddis(i, j)
						newRow("inddiscur" & i + 1 & "_" & j + 1) = Me.inddiscur(i, j)
						newRow("inddispln" & i + 1 & "_" & j + 1) = Me.inddispln(i, j)
					Next
				Next

				newRow("gwsp") = Me.gwsp
				newRow("agruf") = Me.agruf
				newRow("agrufro") = Me.agrufro
				newRow("induf") = Me.induf
				newRow("indufro") = Me.indufro
				newRow("lanuf") = Me.lanuf
				newRow("lanufro") = Me.lanufro
				newRow("tpbx") = Me.tpbx
				newRow("tpsx") = Me.tpsx
				newRow("tpmz") = Me.tpmz
				newRow("envw") = Me.envw
				newRow("ecow") = Me.ecow
				newRow("socw") = Me.socw
				newRow("totpla") = Me.totpla
				newRow("sbqi") = Me.sbqi
				newRow("ssqi") = Me.ssqi
				newRow("smqi") = Me.smqi

				newRow("DataCreazione") = Now
				newRow("UtenteCreazione") = 1
				newRow("DataAggiornamento") = Now
				newRow("UtenteAggiornamento") = 1
				newRow("Annullato") = 0
				newRow.EndEdit()

				Me.DSData.Tables("data").Rows.Add(newRow)

				Me.daData.Update(Me.DSData, "data")
			Catch ex As Exception
				Dim a As Integer
				a = 1
			End Try
		End If
	End Sub

	''' <summary>
	''' write results tu GUI
	''' </summary>
	''' <remarks></remarks>
	Private Sub WriteValuesToGUI(type As WriteToGUIType)
		Dim i, j As Integer

		Select Case type
			Case WriteToGUIType.input
				For i = 0 To 12
					Me.nudCollection("nudInddiscur" & i + 1 & "_2").Value = CType(Me.inddiscur(i, 1), Decimal)
					Me.nudCollection("nudInddispln" & i + 1 & "_2").Value = CType(Me.inddispln(i, 1), Decimal)
					Me.nudCollection("nudBOD" & i + 1).Value = CType(Me.bod(i), Decimal)
					Me.nudCollection("nudTDS" & i + 1).Value = CType(Me.tds(i), Decimal)
					Me.nudCollection("nudTSS" & i + 1).Value = CType(Me.tss(i), Decimal)
					Me.nudCollection("nudDes" & i + 1).Value = CType(Me.des(i), Decimal)
					Me.nudCollection("nudGro" & i + 1).Value = CType(Me.gro(i), Decimal)
				Next

				For i = 0 To 12
					For j = 0 To 1
						Me.nudCollection("nudPop20_" & i + 1 & "_" & j + 1).Value = CType(Me.pop20(i, j), Decimal)
					Next
				Next

				Me.nudgwsp.Value = CType(Me.gwsp, Decimal)
				Me.nudAgrUF.Value = CType(Me.agruf, Decimal)
				Me.nudAgrUFRO.Value = CType(Me.agrufro, Decimal)
				Me.nudIndUF.Value = CType(Me.induf, Decimal)
				Me.nudIndUFRO.Value = CType(Me.indufro, Decimal)
				Me.nudLanUF.Value = CType(Me.lanuf, Decimal)
				Me.nudLanUFRO.Value = CType(Me.lanufro, Decimal)
				Me.nudTpbx.Value = CType(Me.tpbx, Decimal)
				Me.nudTpsx.Value = CType(Me.tpsx, Decimal)
				Me.nudTpmz.Value = CType(Me.tpmz, Decimal)
				Me.nudEnvw.Value = CType(Me.envw, Decimal)
				Me.nudEcow.Value = CType(Me.ecow, Decimal)
				Me.nudSocw.Value = CType(Me.socw, Decimal)
				Me.nudTotpla.Value = CType(Me.totpla, Decimal)
				Me.nudsbqi.Value = CType(Me.sbqi, Decimal)
				Me.nudssqi.Value = CType(Me.ssqi, Decimal)
				Me.nudsmqi.Value = CType(Me.smqi, Decimal)
			Case WriteToGUIType.output
				'Agriculture
				For i = 0 To 12
					For j = 0 To 1
						Me.lblCollection("lblAgr" & i + 1 & "_" & j + 1).Text = Me.outagr(i, j).ToString
					Next
				Next

				'Industry
				For i = 0 To 12
					Me.lblCollection("lblInd" & i + 1 & "_2").Text = Me.outind(i).ToString
				Next

				'Landscape
				For i = 0 To 12
					For j = 0 To 1
						Me.lblCollection("lblLan" & i + 1 & "_" & j + 1).Text = Me.outlan(i, j).ToString
					Next
				Next

				'economics
				For i = 0 To 12
					For j = 0 To 1
						Me.lblCollection("lblEco" & i + 1 & "_" & j + 1).Text = Me.outeco(i, j).ToString
					Next
				Next

				'Social
				For i = 0 To 12
					For j = 0 To 1
						Me.lblCollection("lblSoc" & i + 1 & "_" & j + 1).Text = Me.outsoc(i, j).ToString
					Next
				Next

				'Environment
				For i = 0 To 12
					For j = 0 To 1
						Me.lblCollection("lblEnv" & i + 1 & "_" & j + 1).Text = Me.outenv(i, j).ToString
					Next
				Next
		End Select
	End Sub

	''' <summary>
	''' read values from user interface to global variables
	''' </summary>
	''' <remarks></remarks>
	Private Sub ReadValuesFromGUI()
		Dim i, j As Integer

		For i = 0 To 12
			Me.des(i) = Me.nudCollection("nudDes" & i + 1).Value
			Me.gro(i) = Me.nudCollection("nudGro" & i + 1).Value
			Me.inddiscur(i, 0) = Me.inddiscur(i, 0)
			Me.inddispln(i, 0) = Me.inddispln(i, 0)
			Me.inddiscur(i, 1) = CType(Me.nudCollection("nudInddiscur" & i + 1 & "_2").Value, Integer)
			Me.inddispln(i, 1) = CType(Me.nudCollection("nudInddispln" & i + 1 & "_2").Value, Integer)
			Me.bod(i) = Me.nudCollection("nudBod" & i + 1).Value
			Me.tds(i) = Me.nudCollection("nudTds" & i + 1).Value
			Me.tss(i) = Me.nudCollection("nudTss" & i + 1).Value
		Next

		For i = 0 To 12
			For j = 0 To 1
				Me.pop20(i, j) = CType(Me.nudCollection("nudPop20_" & i + 1 & "_" & j + 1).Value, Integer)
				Me.indcc(i, j) = Me.des(i)
				Me.lancc(i, j) = Me.gro(i)
				Me.agrcc(i, j) = Me.gro(i)
				Me.lbqi(i, j) = Me.bod(i)
				Me.lsqi(i, j) = Me.tds(i)
				Me.lmqi(i, j) = Me.tss(i)
			Next
		Next

		Me.gwsp = Me.nudgwsp.Value
		Me.agruf = Me.nudAgrUF.Value
		Me.agrufro = Me.nudAgrUFRO.Value
		Me.induf = Me.nudIndUF.Value
		Me.indufro = Me.nudIndUFRO.Value
		Me.lanuf = Me.nudLanUF.Value
		Me.lanufro = Me.nudLanUFRO.Value
		Me.tpbx = Me.nudTpbx.Value
		Me.tpsx = Me.nudTpsx.Value
		Me.tpmz = Me.nudTpmz.Value
		Me.envw = Me.nudEnvw.Value
		Me.ecow = Me.nudEcow.Value
		Me.socw = Me.nudSocw.Value
		Me.totpla = Me.nudTotpla.Value
		Me.sbqi = Me.nudsbqi.Value
		Me.ssqi = Me.nudssqi.Value
		Me.smqi = Me.nudsmqi.Value
	End Sub

	''' <summary>
	''' read last record from DB
	''' </summary>
	''' <remarks></remarks>
	Private Function Init() As Boolean
		Dim kernelPath As String
		Dim result As Boolean

		result = False
		kernelPath = ""

		Try
			Me.TAParameters.Fill(Me.dsParameters._parameters)
			'read parameters
			kernelPath = Me.dsParameters._parameters.Rows(0).Item("parKernelPath").ToString
		Catch ex As Exception
			MessageBox.Show("Error reading parameters form database", "CRITICAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try

		Me.AddEventHandler(Me)

		If kernelPath = "" OrElse Not System.IO.File.Exists(kernelPath) Then
			'kernel path not present or wrong path is present in db
			MessageBox.Show("Wolfram Mathematica executable kernel path is missing or wrong" & ControlChars.CrLf & "please set correct path", "CRITICAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

			Dim myfrmParameters As New frmParameters

			myfrmParameters.ShowDialog()
			End
		Else
			'start Mathematica kernel
			Me.myMathWrapper = New MW.MathWrapper(kernelPath)
			If Me.myMathWrapper.KernelReady Then
				result = True
			Else
				Exit Function
			End If

			Try
				Me.ReadValuesFromDB()
			Catch ex As Exception
				MessageBox.Show("Error reading data form database", "CRITICAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		End If

		Return result
	End Function

	Private Sub AddEventHandler(ctl As Control)
		Dim children As Control
		Dim tmpNumericUpDown As DSSNumericUpDown
		Dim tmpLabel As DSSLabel
		Dim tmpGroupBox As DSSGroupBox
		Dim tmpPanel As DSSPanel

		If ctl.HasChildren AndAlso Not TypeOf (ctl) Is DSSNumericUpDown Then
			Select Case ctl.GetType
				Case GetType(DSSGroupBox)
					tmpGroupBox = DirectCast(ctl, DSSGroupBox)
					AddHandler tmpGroupBox.DSSInit, AddressOf Me.RefreshMap
				Case GetType(DSSPanel)
					tmpPanel = DirectCast(ctl, DSSPanel)
					DirectCast(tmpPanel.Parent, DSSGroupBox).DSSpnlCollection.Add(tmpPanel)
			End Select
			For Each children In ctl.Controls
				Me.AddEventHandler(children)
			Next
		Else
			Select Case ctl.GetType
				Case GetType(DSSNumericUpDown)
					tmpNumericUpDown = DirectCast(ctl, DSSNumericUpDown)
					AddHandler tmpNumericUpDown.ValueChanged, AddressOf Me.RefreshMap
					Me.nudCollection.Add(tmpNumericUpDown)
					Try
						DirectCast(tmpNumericUpDown.Parent, DSSPanel).DSSnudCollection.Add(tmpNumericUpDown)
					Catch ex As Exception

					End Try
				Case GetType(DSSLabel)
					tmpLabel = DirectCast(ctl, DSSLabel)
					Me.lblCollection.Add(tmpLabel)
					Try
						DirectCast(tmpLabel.Parent, DSSPanel).DSSlblCollection.Add(tmpLabel)
					Catch ex As Exception
					End Try
			End Select
		End If
	End Sub

#End Region

#Region " Event management "

	Private Sub frmNegotiation_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
		Me.RefreshMap(Me.groupBoxes(0), New System.EventArgs)
	End Sub

	Private Sub frmNegotiation_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		'close Mathematica kernel
		Me.myMathWrapper.KernelStop()
	End Sub

	Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
		Me.NextStep()
	End Sub

	Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
		If Me.groupBoxesID = 0 Then
			Me.Reset(False)
		Else
			Me.PreviousStep()
		End If
	End Sub

	Private Sub btnLoadData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadData.Click
		Dim frmScenario As New frmScenarioSelection

		If frmScenario.ShowDialog() = Windows.Forms.DialogResult.OK Then
			Me.ReadValuesFromDB(frmScenario.ScenarioID)
		End If
	End Sub

	Private Sub tpauses_visiblechanged(sender As Object, e As EventArgs) Handles tpaUses.VisibleChanged
		If Me.tpaUses.Visible Then
			Me.gboOutputUses.DSSVisible = True
		End If
	End Sub

	Private Sub tpaImpacts_visiblechanged(sender As Object, e As EventArgs) Handles tpaImpacts.VisibleChanged
		If Me.tpaImpacts.Visible Then
			Me.gboOutputImpacts.DSSVisible = True
		End If
	End Sub

#End Region

End Class