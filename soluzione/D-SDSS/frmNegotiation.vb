Imports mapControl
Imports System.Windows.Media

Public Class frmNegotiation

#Region " Variables and constants "

	Private Const _barWidth As Double = 0.4
	Private Const _columnMaxHeight As Double = 2.5

	Private Enum WriteToGUIType
		input = 0
		output = 1
	End Enum

	Private ReadOnly myMap As mapControl.mapControl

	Private _nudCollection As New nudCollection
	Private _lblCollection As New lblCollection

	Private _MathWrapper As MW.MathWrapper

	Private _groupBoxesID As Integer
	Private _groupBoxes(5) As DSSGroupBox

	'mathematica algorithm variables
	'current costs
	Private _indcc(14, 1), _agrcc(14, 1), _lancc(14, 1), _des(14), _gro(14) As Double
	'current water quality indicators
	Private _lbqi(14, 1), _lsqi(14, 1), _lmqi(14, 1), _bod(14), _tds(14), _tss(14) As Double
	'current population
	Private _pop20(14, 1) As Integer
	'industrial districts
	Private _inddis(14, 1), _inddiscur(14, 1), _inddispln(14, 1) As Integer
	'misc
	Private _gwsp, _agruf, _agrufro, _induf, _indufro, _lanuf, _lanufro, _tpbx, _tpsx, _tpmz, _envw, _ecow, _socw, _totpla, _sbqi, _ssqi, _smqi, _agrw, _indw, _lanw As Double
	'output
	Private _outind(14), _outagr(14, 1), _outlan(14, 1), _outeco(14, 1), _outsoc(14, 1), _outenv(14, 1) As Double

	Private _outecomean1, _outecomean2, _outecogini1, _outecogini2, _outsocmean1, _outsocmean2, _outsocgini1, _outsocgini2, _outenvmean1, _outenvmean2, _outenvgini1, _outenvgini2 As Double

	Private _usedLocations, _usedDimensions As Integer

	Private _salt As Boolean

#End Region

#Region " Constructor "

	Public Sub New()
		' Chiamata richiesta da Progettazione Windows Form.
		InitializeComponent()

		' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
		Me.SqlConnection.ConnectionString = My.Settings.DSDSSConnectionString

		Me.daLocations.Fill(Me.DSLocations)

		Me.myMap = DirectCast(Me.ElementHost1.Child, mapControl.mapControl)

		If Me.Init() Then
			'init groupBoxes array
			Me._groupBoxes(0) = Me.grbWaterCosts
			Me._groupBoxes(1) = Me.grbWaterQuality
			Me._groupBoxes(2) = Me.grbPopulation
			Me._groupBoxes(3) = Me.grbIndustrialDistricts
			Me._groupBoxes(4) = Me.grbMisc
			Me._groupBoxes(5) = Me.grbOuput

			Me._groupBoxesID = 0
			Me.ShowBox()

			'Adapt GUI to used location
			Me.SetLocations()
		Else
			End
		End If
	End Sub

#End Region

#Region " Private methods "

	''' <summary>
	''' Open the settings forms and set local options
	''' </summary>
	Private Sub SetParameters()
		Dim frmParameters As New frmParameters()

		frmParameters.ShowDialog()

		'Adapt GUI to used location
		Me.SetLocations()

		frmParameters.Dispose()
	End Sub

	Private Sub RefreshMap(sender As Object, e As EventArgs)
		If Me.IsHandleCreated Then
			Dim tmpNumericUpDown As DSSNumericUpDown
			Dim tmpLabel As DSSLabel
			Dim tmpGroupBox As DSSGroupBox
			Dim tmpPanel As DSSPanel
			Dim avgValue As Double

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
			normalizedValue = value / avgValue * _columnMaxHeight - _columnMaxHeight

			Me.myMap.AddLine("line_" & elementName, Colors.Black, locLatitude, locLongitude - offset, locLatitude, locLongitude + offset + _barWidth)
			Me.myMap.AddBar("bar_" & elementName, elementColor, locLatitude, locLongitude + offset, _barWidth, normalizedValue)
		End If

	End Sub

	''' <summary>
	''' execute computation using Wolfram Mathematica kernel
	''' </summary>
	''' <remarks></remarks>
	Private Sub Calculate()
		Dim i, j As Integer
		Dim tmpString As New System.Text.StringBuilder

		Me.ReadValuesFromGUI()

		'(*current population*)
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				Me._MathWrapper.WaitAndDiscardAnswer("pop20[" & i + 1 & "][" & j + 1 & "]=" & NumberAsString(Me._pop20(i, j)))
			Next
		Next

		Me._MathWrapper.WaitAndDiscardAnswer("totpop20 = Sum[pop20[i][j], {i, 1, 13}, {j, 1, 2}]")

		'(*current costs*)
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				Me._MathWrapper.WaitAndDiscardAnswer("agrcc[" & i + 1 & "][" & j + 1 & "]=" & NumberAsString(Me._agrcc(i, j)))
				Me._MathWrapper.WaitAndDiscardAnswer("indcc[" & i + 1 & "][" & j + 1 & "]=" & NumberAsString(Me._indcc(i, j)))
				Me._MathWrapper.WaitAndDiscardAnswer("lancc[" & i + 1 & "][" & j + 1 & "]=" & NumberAsString(Me._lancc(i, j)))
			Next
		Next

		'(*3 current water quality indicators: BOD=b, TDS=s, TSS=m*)
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				Me._MathWrapper.WaitAndDiscardAnswer("lbqi[" & i + 1 & "][" & j + 1 & "]=" & NumberAsString(Me._lbqi(i, j)))
				Me._MathWrapper.WaitAndDiscardAnswer("lsqi[" & i + 1 & "][" & j + 1 & "]=" & NumberAsString(Me._lsqi(i, j)))
				Me._MathWrapper.WaitAndDiscardAnswer("lmqi[" & i + 1 & "][" & j + 1 & "]=" & NumberAsString(Me._lmqi(i, j)))
			Next
		Next

		Me._MathWrapper.WaitAndDiscardAnswer("gwsp=" & NumberAsString(Me._gwsp))
		Me._MathWrapper.WaitAndDiscardAnswer("agrUF=" & NumberAsString(Me._agruf))
		Me._MathWrapper.WaitAndDiscardAnswer("agrUFRO=" & NumberAsString(Me._agrufro))
		Me._MathWrapper.WaitAndDiscardAnswer("indUF=" & NumberAsString(Me._induf))
		Me._MathWrapper.WaitAndDiscardAnswer("indUFRO=" & NumberAsString(Me._indufro))
		Me._MathWrapper.WaitAndDiscardAnswer("lanUF=" & NumberAsString(Me._lanuf))
		Me._MathWrapper.WaitAndDiscardAnswer("lanUFRO=" & NumberAsString(Me._lanufro))
		Me._MathWrapper.WaitAndDiscardAnswer("ssqi=" & NumberAsString(Me._ssqi))
		Me._MathWrapper.WaitAndDiscardAnswer("totpla=" & NumberAsString(Me._totpla))
		Me._MathWrapper.WaitAndDiscardAnswer("agrw=" & NumberAsString(Me._agrw / 100))
		Me._MathWrapper.WaitAndDiscardAnswer("indw=" & NumberAsString(Me._indw / 100))
		Me._MathWrapper.WaitAndDiscardAnswer("lanw=" & NumberAsString(Me._lanw / 100))

		'(*potential costs*)
		For i = 0 To Me._usedLocations - 1
			Me._MathWrapper.WaitAndDiscardAnswer("agrpc[" & i + 1 & "][1]=If[lsqi[" & i + 1 & "][1]>ssqi,agrUFRO,agrUF]")
			Me._MathWrapper.WaitAndDiscardAnswer("agrpc[" & i + 1 & "][2]=agrpc[" & i + 1 & "][1]")
		Next

		For i = 0 To Me._usedLocations - 1
			Me._MathWrapper.WaitAndDiscardAnswer("indpc[" & i + 1 & "][1]=If[lsqi[" & i + 1 & "][1]>ssqi,indUFRO,indUF]")
			Me._MathWrapper.WaitAndDiscardAnswer("indpc[" & i + 1 & "][2]=indpc[" & i + 1 & "][1]")
		Next

		For i = 0 To Me._usedLocations - 1
			Me._MathWrapper.WaitAndDiscardAnswer("lanpc[" & i + 1 & "][1]=If[lsqi[" & i + 1 & "][1]>ssqi,lanUFRO,lanUF]")
			Me._MathWrapper.WaitAndDiscardAnswer("lanpc[" & i + 1 & "][2]=lanpc[" & i + 1 & "][1]")

			'industrial districts are calculated as current + planned
			Me._inddis(i, 0) = 0
			Me._inddis(i, 1) = Me._inddiscur(i, 1) + Me._inddispln(i, 1)
			Me._MathWrapper.WaitAndDiscardAnswer("inddis[" & i + 1 & "][1]=0")
			Me._MathWrapper.WaitAndDiscardAnswer("inddis[" & i + 1 & "][2]=" & NumberAsString(Me._inddis(i, 1)))
		Next

		Me._MathWrapper.WaitAndDiscardAnswer("ecow=1-socw-envw")

		Me._MathWrapper.WaitAndDiscardAnswer("agrobj=((agrcc[i][j]+gwsp)/agrpc[i][j])(1-((agrcc[i][j]+gwsp-agrpc[i][j])/(agrcc[i][j]+gwsp))*x[i][j])")
		Me._MathWrapper.WaitAndDiscardAnswer("indobj=inddis[i][j]((indcc[i][j])/indpc[i][j])(1-((indcc[i][j]-indpc[i][j])/(indcc[i][j]))*y[i][j])")
		Me._MathWrapper.WaitAndDiscardAnswer("lanobj=((lancc[i][j]+gwsp)/lanpc[i][j])(1-((lancc[i][j]+gwsp-lanpc[i][j])/(lancc[i][j]+gwsp))*z[i][j])")

		'(*scenario 2020*)
		Me._MathWrapper.WaitAndDiscardAnswer("ecoobj20=Sum[(pop20[i][j]/totpop20)(agrw*agrobj+indw*indobj+lanw*lanobj),{i,1,13},{j,1,2}]")
		'if TSS has to be considered
		Me._MathWrapper.WaitAndDiscardAnswer("socobj20=Sum[(pop20[i][j]/totpop20)*(((lmqi[i][j]*(1-tpmz*z[i][j]))/smqi)),{i,1,13},{j,1,2}]")
		'if TSS has not to be considered
		Me._MathWrapper.WaitAndDiscardAnswer("socobj20=0")
		Me._MathWrapper.WaitAndDiscardAnswer("envobj20=Sum[(pop20[i][j]/totpop20)*(((lbqi[i][j]*(1-tpbx*x[i][j]))/sbqi)),{i,1,13},{j,1,2}]")

		Me._MathWrapper.WaitAndDiscardAnswer("totobj20=ecow*ecoobj20+socw*socobj20+envw*envobj20")

		'assign values to variables to calculate numeric solution
		Me._MathWrapper.WaitAndDiscardAnswer("envw=" & NumberAsString(Me._envw / 100))
		Me._MathWrapper.WaitAndDiscardAnswer("socw=" & NumberAsString(Me._socw / 100))
		Me._MathWrapper.WaitAndDiscardAnswer("sbqi=" & NumberAsString(Me._sbqi))
		Me._MathWrapper.WaitAndDiscardAnswer("smqi=" & NumberAsString(Me._smqi))
		Me._MathWrapper.WaitAndDiscardAnswer("tpbx=" & NumberAsString(Me._tpbx / 100))
		Me._MathWrapper.WaitAndDiscardAnswer("tpmz=" & NumberAsString(Me._tpmz / 100))

		'create the expression to pass to Wolfram Mathematica
		tmpString.Length = 0
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				tmpString.Append("x[" & i + 1 & "][" & j + 1 & "] -> x" & i + 1 & j + 1 & ", ")
			Next
		Next
		tmpString.Length -= ", ".Length

		Me._MathWrapper.WaitAndDiscardAnswer("totobj20r = totobj20 /. {" & tmpString.ToString & "}")

		'create the expression to pass to Wolfram Mathematica
		tmpString.Length = 0
		'pattern: xij + xi+1j+1 + ...
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				tmpString.Append("x" & i + 1 & j + 1 & " + ")
			Next
		Next
		'pattern: yi2 + yi+12 + ...
		For i = 0 To Me._usedLocations - 1
			tmpString.Append("y" & i + 1 & "2 + ")
		Next
		'pattern: zij + zi+1j+1 + ...
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				tmpString.Append("z" & i + 1 & j + 1 & " + ")
			Next
		Next

		tmpString.Length -= " + ".Length

		tmpString.Append(") <= totpla, ")

		'pattern: xij <= 1
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				tmpString.Append("x" & i + 1 & j + 1 & " <= 1, ")
			Next
		Next
		'pattern: yi2 <= 1
		For i = 0 To Me._usedLocations - 1
			tmpString.Append("y" & i + 1 & "2 <= 1, ")
		Next
		'pattern: zij <= 1
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				tmpString.Append("z" & i + 1 & j + 1 & " <= 1, ")
			Next
		Next

		'pattern: xij >= 0
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				tmpString.Append("x" & i + 1 & j + 1 & " >= 0, ")
			Next
		Next
		'pattern: yi2 >= 0
		For i = 0 To Me._usedLocations - 1
			tmpString.Append("y" & i + 1 & "2 >= 0, ")
		Next
		'pattern: zij >= 0
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				tmpString.Append("z" & i + 1 & j + 1 & " >= 0, ")
			Next
		Next

		tmpString.Append("Element[{")

		'pattern: xij,
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				tmpString.Append("x" & i + 1 & j + 1 & ", ")
			Next
		Next
		'pattern: yi2,
		For i = 0 To Me._usedLocations - 1
			tmpString.Append("y" & i + 1 & "2, ")
		Next
		'pattern: zij,
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				tmpString.Append("z" & i + 1 & j + 1 & ", ")
			Next
		Next

		tmpString.Length -= ", ".Length
		tmpString.Append("}, Integers]}, {")

		'pattern: xij,
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				tmpString.Append("x" & i + 1 & j + 1 & ", ")
			Next
		Next
		'pattern: yi2,
		For i = 0 To Me._usedLocations - 1
			tmpString.Append("y" & i + 1 & "2, ")
		Next
		'pattern: zij,
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				tmpString.Append("z" & i + 1 & j + 1 & ", ")
			Next
		Next

		tmpString.Length -= ", ".Length

		Me._MathWrapper.WaitAndDiscardAnswer("m = NMinimize[{totobj20r*100, (" & tmpString.ToString & "}]")

		Me._MathWrapper.WaitAndDiscardAnswer("mobj = m[[1]]")
		Me._MathWrapper.WaitAndDiscardAnswer("marg = m[[2]]")

		'create the expression to pass to Wolfram Mathematica
		tmpString.Length = 0
		'pattern: xij -> 0
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				tmpString.Append("x" & i + 1 & j + 1 & " -> 0, ")
			Next
		Next
		'pattern: yi2 >= 0
		For i = 0 To Me._usedLocations - 1
			tmpString.Append("y" & i + 1 & "2 -> 0, ")
		Next
		'pattern: zij >= 0
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				tmpString.Append("z" & i + 1 & j + 1 & " -> 0, ")
			Next
		Next

		tmpString.Length -= ", ".Length

		Me._MathWrapper.WaitAndDiscardAnswer("totobj20rWEL = totobj20r*100 /. {" & tmpString.ToString & ", sbqi -> 20, smqi -> 20, tpbx -> 0.35, tpmz -> 0.30}")
		Me._MathWrapper.WaitAndDiscardAnswer("totobj20rSUS = totobj20r*100 /. {" & tmpString.ToString & ", socw -> 0.33, envw -> 0.33, tpbx -> 0.35, tpmz -> 0.30}")
		Me._MathWrapper.WaitAndDiscardAnswer("totobj20rEFF = totobj20r*100 /. {" & tmpString.ToString & ", sbqi -> 20, smqi -> 20, socw -> 0.33, envw -> 0.33}")

		'create the expression to pass to Wolfram Mathematica
		tmpString.Length = 0
		'pattern: agrw*((agrcc[i][1]+gwsp)/agrpc[i][1])(1-((agrcc[i][1]+gwsp-agrpc[i][1])/(agrcc[i][1]+gwsp))*xi1)+
		'indw*inddis[i][1]((indcc[1][1])/indpc[i][1])(1-((indcc[i][1]-indpc[i][1])/(indcc[i][1]))*yi1)+
		'lanw*((lancc[i][1]+gwsp)/lanpc[i][1])(1-((lancc[i][1]+gwsp-lanpc[i][1])/(lancc[i][1]+gwsp))*zi1),
		For i = 0 To Me._usedLocations - 1
			tmpString.Append("agrw*((agrcc[" & i + 1 & "][1]+gwsp)/agrpc[" & i + 1 & "][1])(1-((agrcc[" & i + 1 & "][1]+gwsp-agrpc[" & i + 1 & "][1])/(agrcc[" & i + 1 & "][1]+gwsp))*x" & i + 1 & "1)+")
			tmpString.Append("indw*inddis[" & i + 1 & "][1]((indcc[" & i + 1 & "][1])/indpc[" & i + 1 & "][1])(1-((indcc[" & i + 1 & "][1]-indpc[" & i + 1 & "][1])/(indcc[" & i + 1 & "][1]))*y" & i + 1 & "1)+")
			tmpString.Append("lanw*((lancc[" & i + 1 & "][1]+gwsp)/lanpc[" & i + 1 & "][1])(1-((lancc[" & i + 1 & "][1]+gwsp-lanpc[" & i + 1 & "][1])/(lancc[" & i + 1 & "][1]+gwsp))*z" & i + 1 & "1),")
		Next

		tmpString.Length -= ",".Length

		Me._MathWrapper.WaitAndDiscardAnswer("ecolis1={List[" & tmpString.ToString & "]/. marg}")

		'create the expression to pass to Wolfram Mathematica
		tmpString.Length = 0
		'pattern: agrw*((agrcc[i][2]+gwsp)/agrpc[i][2])(1-((agrcc[i][2]+gwsp-agrpc[i][2])/(agrcc[i][2]+gwsp))*xi2)+
		'indw*inddis[i][2]((indcc[1][2])/indpc[i][2])(1-((indcc[i][2]-indpc[i][2])/(indcc[i][2]))*yi2)+
		'lanw*((lancc[i][2]+gwsp)/lanpc[i][2])(1-((lancc[i][2]+gwsp-lanpc[i][2])/(lancc[i][2]+gwsp))*zi2),
		For i = 0 To Me._usedLocations - 1
			tmpString.Append("agrw*((agrcc[" & i + 1 & "][2]+gwsp)/agrpc[" & i + 1 & "][2])(1-((agrcc[" & i + 1 & "][2]+gwsp-agrpc[" & i + 1 & "][2])/(agrcc[" & i + 1 & "][2]+gwsp))*x" & i + 1 & "2)+")
			tmpString.Append("indw*inddis[" & i + 1 & "][2]((indcc[" & i + 1 & "][2])/indpc[" & i + 1 & "][2])(1-((indcc[" & i + 1 & "][2]-indpc[" & i + 1 & "][2])/(indcc[" & i + 1 & "][2]))*y" & i + 1 & "2)+")
			tmpString.Append("lanw*((lancc[" & i + 1 & "][2]+gwsp)/lanpc[" & i + 1 & "][2])(1-((lancc[" & i + 1 & "][2]+gwsp-lanpc[" & i + 1 & "][2])/(lancc[" & i + 1 & "][2]+gwsp))*z" & i + 1 & "2),")
		Next

		tmpString.Length -= ",".Length

		Me._MathWrapper.WaitAndDiscardAnswer("ecolis2={List[" & tmpString.ToString & "]/.marg}")

		'create the expression to pass to Wolfram Mathematica
		tmpString.Length = 0
		'pattern: lmqi[i][1]((1-tpmz*zi1)/smqi),
		For i = 0 To Me._usedLocations - 1
			tmpString.Append("lmqi[" & i + 1 & "][1]((1-tpmz*z" & i + 1 & "1)/smqi),")
		Next

		tmpString.Length -= ",".Length

		Me._MathWrapper.WaitAndDiscardAnswer("soclis1={List[" & tmpString.ToString & "] /.marg}")

		'create the expression to pass to Wolfram Mathematica
		tmpString.Length = 0
		'pattern: lmqi[i][2]((1-tpmz*zi2)/smqi),
		For i = 0 To Me._usedLocations - 1
			tmpString.Append("lmqi[" & i + 1 & "][2]((1-tpmz*z" & i + 1 & "2)/smqi),")
		Next

		tmpString.Length -= ",".Length

		Me._MathWrapper.WaitAndDiscardAnswer("soclis2={List[" & tmpString.ToString & "] /. marg}")

		'create the expression to pass to Wolfram Mathematica
		tmpString.Length = 0
		'pattern: lbqi[i][1]((1-tpmz*zi1)/smqi),
		For i = 0 To Me._usedLocations - 1
			tmpString.Append("lbqi[" & i + 1 & "][1]((1-tpmz*z" & i + 1 & "1)/smqi),")
		Next

		tmpString.Length -= ",".Length

		Me._MathWrapper.WaitAndDiscardAnswer("envlis1={List[" & tmpString.ToString & "] /.marg}")

		'create the expression to pass to Wolfram Mathematica
		tmpString.Length = 0
		'pattern: lbqi[1][2]((1-tpmz*z12)/smqi),
		For i = 0 To Me._usedLocations - 1
			tmpString.Append("lbqi[" & i + 1 & "][2]((1-tpmz*z" & i + 1 & "2)/smqi),")
		Next

		tmpString.Length -= ",".Length

		Me._MathWrapper.WaitAndDiscardAnswer("envlis2={List[" & tmpString.ToString & "] /.marg}")

		For i = 0 To Me._usedLocations - 1
			Me._MathWrapper.WaitAndDiscardAnswer("eco" & i + 1 & "1=ecolis1[[1," & i + 1 & "]]")
		Next

		Me._MathWrapper.WaitAndDiscardAnswer("ecomea1=(eco11+eco21+eco31+eco41+eco51+eco61+eco71+eco81+eco91+eco101+eco111+eco121+eco131)/13")
		Me._MathWrapper.WaitAndDiscardAnswer("ecogin1=N[(1/2*1/13^2*(1/ecomea1))(Abs[eco11-eco11]+Abs[eco11-eco21]+Abs[eco11-eco31]+Abs[eco11-eco41]+Abs[eco11-eco51]+Abs[eco11-eco61]+Abs[eco11-eco71]+Abs[eco11-eco81]+Abs[eco11-eco91]+Abs[eco11-eco101]+Abs[eco11-eco111]+Abs[eco11-eco121]+Abs[eco11-eco131]+Abs[eco21-eco11]+Abs[eco21-eco21]+Abs[eco21-eco31]+Abs[eco21-eco41]+Abs[eco21-eco51]+Abs[eco21-eco61]+Abs[eco21-eco71]+Abs[eco21-eco81]+Abs[eco21-eco91]+Abs[eco21-eco101]+Abs[eco21-eco111]+Abs[eco21-eco121]+Abs[eco21-eco131]+Abs[eco31-eco11]+Abs[eco31-eco21]+Abs[eco31-eco31]+Abs[eco31-eco41]+Abs[eco31-eco51]+Abs[eco31-eco61]+Abs[eco31-eco71]+Abs[eco31-eco81]+Abs[eco31-eco91]+Abs[eco31-eco101]+Abs[eco31-eco111]+Abs[eco31-eco121]+Abs[eco31-eco131]+Abs[eco41-eco11]+Abs[eco41-eco21]+Abs[eco41-eco31]+Abs[eco41-eco41]+Abs[eco41-eco51]+Abs[eco41-eco61]+Abs[eco41-eco71]+Abs[eco41-eco81]+Abs[eco41-eco91]+Abs[eco41-eco101]+Abs[eco41-eco111]+Abs[eco41-eco121]+Abs[eco41-eco131]+Abs[eco51-eco11]+Abs[eco51-eco21]+Abs[eco51-eco31]+Abs[eco51-eco41]+Abs[eco51-eco51]+Abs[eco51-eco61]+Abs[eco51-eco71]+Abs[eco51-eco81]+Abs[eco51-eco91]+Abs[eco51-eco101]+Abs[eco51-eco111]+Abs[eco51-eco121]+Abs[eco51-eco131]+Abs[eco61-eco11]+Abs[eco61-eco21]+Abs[eco61-eco31]+Abs[eco61-eco41]+Abs[eco61-eco51]+Abs[eco61-eco61]+Abs[eco61-eco71]+Abs[eco61-eco81]+Abs[eco61-eco91]+Abs[eco61-eco101]+Abs[eco61-eco111]+Abs[eco61-eco121]+Abs[eco61-eco131]+Abs[eco71-eco11]+Abs[eco71-eco21]+Abs[eco71-eco31]+Abs[eco71-eco41]+Abs[eco71-eco51]+Abs[eco71-eco61]+Abs[eco71-eco71]+Abs[eco71-eco81]+Abs[eco71-eco91]+Abs[eco71-eco101]+Abs[eco71-eco111]+Abs[eco71-eco121]+Abs[eco71-eco131]+Abs[eco81-eco11]+Abs[eco81-eco21]+Abs[eco81-eco31]+Abs[eco81-eco41]+Abs[eco81-eco51]+Abs[eco81-eco61]+Abs[eco81-eco71]+Abs[eco81-eco81]+Abs[eco81-eco91]+Abs[eco81-eco101]+Abs[eco81-eco111]+Abs[eco81-eco121]+Abs[eco81-eco131]+Abs[eco91-eco11]+Abs[eco91-eco21]+Abs[eco91-eco31]+Abs[eco91-eco41]+Abs[eco91-eco51]+Abs[eco91-eco61]+Abs[eco91-eco71]+Abs[eco91-eco81]+Abs[eco91-eco91]+Abs[eco91-eco101]+Abs[eco91-eco111]+Abs[eco91-eco121]+Abs[eco91-eco131]+Abs[eco101-eco11]+Abs[eco101-eco21]+Abs[eco101-eco31]+Abs[eco101-eco41]+Abs[eco101-eco51]+Abs[eco101-eco61]+Abs[eco101-eco71]+Abs[eco101-eco81]+Abs[eco101-eco91]+Abs[eco101-eco101]+Abs[eco101-eco111]+Abs[eco101-eco121]+Abs[eco101-eco131]+Abs[eco111-eco11]+Abs[eco111-eco21]+Abs[eco111-eco31]+Abs[eco111-eco41]+Abs[eco111-eco51]+Abs[eco111-eco61]+Abs[eco111-eco71]+Abs[eco111-eco81]+Abs[eco111-eco91]+Abs[eco111-eco101]+Abs[eco111-eco111]+Abs[eco111-eco121]+Abs[eco111-eco131]+Abs[eco121-eco11]+Abs[eco121-eco21]+Abs[eco121-eco31]+Abs[eco121-eco41]+Abs[eco121-eco51]+Abs[eco121-eco61]+Abs[eco121-eco71]+Abs[eco121-eco81]+Abs[eco121-eco91]+Abs[eco121-eco101]+Abs[eco121-eco111]+Abs[eco121-eco121]+Abs[eco121-eco131]+Abs[eco131-eco11]+Abs[eco131-eco21]+Abs[eco131-eco31]+Abs[eco131-eco41]+Abs[eco131-eco51]+Abs[eco131-eco61]+Abs[eco131-eco71]+Abs[eco131-eco81]+Abs[eco131-eco91]+Abs[eco131-eco101]+Abs[eco131-eco111]+Abs[eco131-eco121]+Abs[eco131-eco131])]")

		For i = 0 To Me._usedLocations - 1
			Me._MathWrapper.WaitAndDiscardAnswer("eco" & i + 1 & "2=ecolis2[[1," & i + 1 & "]]")
		Next

		Me._MathWrapper.WaitAndDiscardAnswer("ecomea2=(eco12+eco22+eco32+eco42+eco52+eco62+eco72+eco82+eco92+eco102+eco112+eco122+eco132)/13")
		Me._MathWrapper.WaitAndDiscardAnswer("ecogin2=N[(1/2*1/13^2*(1/ecomea2))(Abs[eco12-eco12]+Abs[eco12-eco22]+Abs[eco12-eco32]+Abs[eco12-eco42]+Abs[eco12-eco52]+Abs[eco12-eco62]+Abs[eco12-eco72]+Abs[eco12-eco82]+Abs[eco12-eco92]+Abs[eco12-eco102]+Abs[eco12-eco112]+Abs[eco12-eco122]+Abs[eco12-eco132]+Abs[eco22-eco12]+Abs[eco22-eco22]+Abs[eco22-eco32]+Abs[eco22-eco42]+Abs[eco22-eco52]+Abs[eco22-eco62]+Abs[eco22-eco72]+Abs[eco22-eco82]+Abs[eco22-eco92]+Abs[eco22-eco102]+Abs[eco22-eco112]+Abs[eco22-eco122]+Abs[eco22-eco132]+Abs[eco32-eco12]+Abs[eco32-eco22]+Abs[eco32-eco32]+Abs[eco32-eco42]+Abs[eco32-eco52]+Abs[eco32-eco62]+Abs[eco32-eco72]+Abs[eco32-eco82]+Abs[eco32-eco92]+Abs[eco32-eco102]+Abs[eco32-eco112]+Abs[eco32-eco122]+Abs[eco32-eco132]+Abs[eco42-eco12]+Abs[eco42-eco22]+Abs[eco42-eco32]+Abs[eco42-eco42]+Abs[eco42-eco52]+Abs[eco42-eco62]+Abs[eco42-eco72]+Abs[eco42-eco82]+Abs[eco42-eco92]+Abs[eco42-eco102]+Abs[eco42-eco112]+Abs[eco42-eco122]+Abs[eco42-eco132]+Abs[eco52-eco12]+Abs[eco52-eco22]+Abs[eco52-eco32]+Abs[eco52-eco42]+Abs[eco52-eco52]+Abs[eco52-eco62]+Abs[eco52-eco72]+Abs[eco52-eco82]+Abs[eco52-eco92]+Abs[eco52-eco102]+Abs[eco52-eco112]+Abs[eco52-eco122]+Abs[eco52-eco132]+Abs[eco62-eco12]+Abs[eco62-eco22]+Abs[eco62-eco32]+Abs[eco62-eco42]+Abs[eco62-eco52]+Abs[eco62-eco62]+Abs[eco62-eco72]+Abs[eco62-eco82]+Abs[eco62-eco92]+Abs[eco62-eco102]+Abs[eco62-eco112]+Abs[eco62-eco122]+Abs[eco62-eco132]+Abs[eco72-eco12]+Abs[eco72-eco22]+Abs[eco72-eco32]+Abs[eco72-eco42]+Abs[eco72-eco52]+Abs[eco72-eco62]+Abs[eco72-eco72]+Abs[eco72-eco82]+Abs[eco72-eco92]+Abs[eco72-eco102]+Abs[eco72-eco112]+Abs[eco72-eco122]+Abs[eco72-eco132]+Abs[eco82-eco12]+Abs[eco82-eco22]+Abs[eco82-eco32]+Abs[eco82-eco42]+Abs[eco82-eco52]+Abs[eco82-eco62]+Abs[eco82-eco72]+Abs[eco82-eco82]+Abs[eco82-eco92]+Abs[eco82-eco102]+Abs[eco82-eco112]+Abs[eco82-eco122]+Abs[eco82-eco132]+Abs[eco92-eco12]+Abs[eco92-eco22]+Abs[eco92-eco32]+Abs[eco92-eco42]+Abs[eco92-eco52]+Abs[eco92-eco62]+Abs[eco92-eco72]+Abs[eco92-eco82]+Abs[eco92-eco92]+Abs[eco92-eco102]+Abs[eco92-eco112]+Abs[eco92-eco122]+Abs[eco92-eco132]+Abs[eco102-eco12]+Abs[eco102-eco22]+Abs[eco102-eco32]+Abs[eco102-eco42]+Abs[eco102-eco52]+Abs[eco102-eco62]+Abs[eco102-eco72]+Abs[eco102-eco82]+Abs[eco102-eco92]+Abs[eco102-eco102]+Abs[eco102-eco112]+Abs[eco102-eco122]+Abs[eco102-eco132]+Abs[eco112-eco12]+Abs[eco112-eco22]+Abs[eco112-eco32]+Abs[eco112-eco42]+Abs[eco112-eco52]+Abs[eco112-eco62]+Abs[eco112-eco72]+Abs[eco112-eco82]+Abs[eco112-eco92]+Abs[eco112-eco102]+Abs[eco112-eco112]+Abs[eco112-eco122]+Abs[eco112-eco132]+Abs[eco122-eco12]+Abs[eco122-eco22]+Abs[eco122-eco32]+Abs[eco122-eco42]+Abs[eco122-eco52]+Abs[eco122-eco62]+Abs[eco122-eco72]+Abs[eco122-eco82]+Abs[eco122-eco92]+Abs[eco122-eco102]+Abs[eco122-eco112]+Abs[eco122-eco122]+Abs[eco122-eco132]+Abs[eco132-eco12]+Abs[eco132-eco22]+Abs[eco132-eco32]+Abs[eco132-eco42]+Abs[eco132-eco52]+Abs[eco132-eco62]+Abs[eco132-eco72]+Abs[eco132-eco82]+Abs[eco132-eco92]+Abs[eco132-eco102]+Abs[eco132-eco112]+Abs[eco132-eco122]+Abs[eco132-eco132])]")

		For i = 0 To Me._usedLocations - 1
			Me._MathWrapper.WaitAndDiscardAnswer("soc" & i + 1 & "1=soclis1[[1," & i + 1 & "]]")
		Next

		Me._MathWrapper.WaitAndDiscardAnswer("socmea1=(soc11+soc21+soc31+soc41+soc51+soc61+soc71+soc81+soc91+soc101+soc111+soc121+soc131)/13")
		Me._MathWrapper.WaitAndDiscardAnswer("socgin1=N[(1/2*1/13^2*(1/socmea1))(Abs[soc11-soc11]+Abs[soc11-soc21]+Abs[soc11-soc31]+Abs[soc11-soc41]+Abs[soc11-soc51]+Abs[soc11-soc61]+Abs[soc11-soc71]+Abs[soc11-soc81]+Abs[soc11-soc91]+Abs[soc11-soc101]+Abs[soc11-soc111]+Abs[soc11-soc121]+Abs[soc11-soc131]+Abs[soc21-soc11]+Abs[soc21-soc21]+Abs[soc21-soc31]+Abs[soc21-soc41]+Abs[soc21-soc51]+Abs[soc21-soc61]+Abs[soc21-soc71]+Abs[soc21-soc81]+Abs[soc21-soc91]+Abs[soc21-soc101]+Abs[soc21-soc111]+Abs[soc21-soc121]+Abs[soc21-soc131]+Abs[soc31-soc11]+Abs[soc31-soc21]+Abs[soc31-soc31]+Abs[soc31-soc41]+Abs[soc31-soc51]+Abs[soc31-soc61]+Abs[soc31-soc71]+Abs[soc31-soc81]+Abs[soc31-soc91]+Abs[soc31-soc101]+Abs[soc31-soc111]+Abs[soc31-soc121]+Abs[soc31-soc131]+Abs[soc41-soc11]+Abs[soc41-soc21]+Abs[soc41-soc31]+Abs[soc41-soc41]+Abs[soc41-soc51]+Abs[soc41-soc61]+Abs[soc41-soc71]+Abs[soc41-soc81]+Abs[soc41-soc91]+Abs[soc41-soc101]+Abs[soc41-soc111]+Abs[soc41-soc121]+Abs[soc41-soc131]+Abs[soc51-soc11]+Abs[soc51-soc21]+Abs[soc51-soc31]+Abs[soc51-soc41]+Abs[soc51-soc51]+Abs[soc51-soc61]+Abs[soc51-soc71]+Abs[soc51-soc81]+Abs[soc51-soc91]+Abs[soc51-soc101]+Abs[soc51-soc111]+Abs[soc51-soc121]+Abs[soc51-soc131]+Abs[soc61-soc11]+Abs[soc61-soc21]+Abs[soc61-soc31]+Abs[soc61-soc41]+Abs[soc61-soc51]+Abs[soc61-soc61]+Abs[soc61-soc71]+Abs[soc61-soc81]+Abs[soc61-soc91]+Abs[soc61-soc101]+Abs[soc61-soc111]+Abs[soc61-soc121]+Abs[soc61-soc131]+Abs[soc71-soc11]+Abs[soc71-soc21]+Abs[soc71-soc31]+Abs[soc71-soc41]+Abs[soc71-soc51]+Abs[soc71-soc61]+Abs[soc71-soc71]+Abs[soc71-soc81]+Abs[soc71-soc91]+Abs[soc71-soc101]+Abs[soc71-soc111]+Abs[soc71-soc121]+Abs[soc71-soc131]+Abs[soc81-soc11]+Abs[soc81-soc21]+Abs[soc81-soc31]+Abs[soc81-soc41]+Abs[soc81-soc51]+Abs[soc81-soc61]+Abs[soc81-soc71]+Abs[soc81-soc81]+Abs[soc81-soc91]+Abs[soc81-soc101]+Abs[soc81-soc111]+Abs[soc81-soc121]+Abs[soc81-soc131]+Abs[soc91-soc11]+Abs[soc91-soc21]+Abs[soc91-soc31]+Abs[soc91-soc41]+Abs[soc91-soc51]+Abs[soc91-soc61]+Abs[soc91-soc71]+Abs[soc91-soc81]+Abs[soc91-soc91]+Abs[soc91-soc101]+Abs[soc91-soc111]+Abs[soc91-soc121]+Abs[soc91-soc131]+Abs[soc101-soc11]+Abs[soc101-soc21]+Abs[soc101-soc31]+Abs[soc101-soc41]+Abs[soc101-soc51]+Abs[soc101-soc61]+Abs[soc101-soc71]+Abs[soc101-soc81]+Abs[soc101-soc91]+Abs[soc101-soc101]+Abs[soc101-soc111]+Abs[soc101-soc121]+Abs[soc101-soc131]+Abs[soc111-soc11]+Abs[soc111-soc21]+Abs[soc111-soc31]+Abs[soc111-soc41]+Abs[soc111-soc51]+Abs[soc111-soc61]+Abs[soc111-soc71]+Abs[soc111-soc81]+Abs[soc111-soc91]+Abs[soc111-soc101]+Abs[soc111-soc111]+Abs[soc111-soc121]+Abs[soc111-soc131]+Abs[soc121-soc11]+Abs[soc121-soc21]+Abs[soc121-soc31]+Abs[soc121-soc41]+Abs[soc121-soc51]+Abs[soc121-soc61]+Abs[soc121-soc71]+Abs[soc121-soc81]+Abs[soc121-soc91]+Abs[soc121-soc101]+Abs[soc121-soc111]+Abs[soc121-soc121]+Abs[soc121-soc131]+Abs[soc131-soc11]+Abs[soc131-soc21]+Abs[soc131-soc31]+Abs[soc131-soc41]+Abs[soc131-soc51]+Abs[soc131-soc61]+Abs[soc131-soc71]+Abs[soc131-soc81]+Abs[soc131-soc91]+Abs[soc131-soc101]+Abs[soc131-soc111]+Abs[soc131-soc121]+Abs[soc131-soc131])]")

		For i = 0 To Me._usedLocations - 1
			Me._MathWrapper.WaitAndDiscardAnswer("soc" & i + 1 & "2=soclis2[[1," & i + 1 & "]]")
		Next

		Me._MathWrapper.WaitAndDiscardAnswer("socmea2=(soc12+soc22+soc32+soc42+soc52+soc62+soc72+soc82+soc92+soc102+soc112+soc122+soc132)/13")
		Me._MathWrapper.WaitAndDiscardAnswer("socgin2=N[(1/2*1/13^2*(1/socmea2))(Abs[soc12-soc12]+Abs[soc12-soc22]+Abs[soc12-soc32]+Abs[soc12-soc42]+Abs[soc12-soc52]+Abs[soc12-soc62]+Abs[soc12-soc72]+Abs[soc12-soc82]+Abs[soc12-soc92]+Abs[soc12-soc102]+Abs[soc12-soc112]+Abs[soc12-soc122]+Abs[soc12-soc132]+Abs[soc22-soc12]+Abs[soc22-soc22]+Abs[soc22-soc32]+Abs[soc22-soc42]+Abs[soc22-soc52]+Abs[soc22-soc62]+Abs[soc22-soc72]+Abs[soc22-soc82]+Abs[soc22-soc92]+Abs[soc22-soc102]+Abs[soc22-soc112]+Abs[soc22-soc122]+Abs[soc22-soc132]+Abs[soc32-soc12]+Abs[soc32-soc22]+Abs[soc32-soc32]+Abs[soc32-soc42]+Abs[soc32-soc52]+Abs[soc32-soc62]+Abs[soc32-soc72]+Abs[soc32-soc82]+Abs[soc32-soc92]+Abs[soc32-soc102]+Abs[soc32-soc112]+Abs[soc32-soc122]+Abs[soc32-soc132]+Abs[soc42-soc12]+Abs[soc42-soc22]+Abs[soc42-soc32]+Abs[soc42-soc42]+Abs[soc42-soc52]+Abs[soc42-soc62]+Abs[soc42-soc72]+Abs[soc42-soc82]+Abs[soc42-soc92]+Abs[soc42-soc102]+Abs[soc42-soc112]+Abs[soc42-soc122]+Abs[soc42-soc132]+Abs[soc52-soc12]+Abs[soc52-soc22]+Abs[soc52-soc32]+Abs[soc52-soc42]+Abs[soc52-soc52]+Abs[soc52-soc62]+Abs[soc52-soc72]+Abs[soc52-soc82]+Abs[soc52-soc92]+Abs[soc52-soc102]+Abs[soc52-soc112]+Abs[soc52-soc122]+Abs[soc52-soc132]+Abs[soc62-soc12]+Abs[soc62-soc22]+Abs[soc62-soc32]+Abs[soc62-soc42]+Abs[soc62-soc52]+Abs[soc62-soc62]+Abs[soc62-soc72]+Abs[soc62-soc82]+Abs[soc62-soc92]+Abs[soc62-soc102]+Abs[soc62-soc112]+Abs[soc62-soc122]+Abs[soc62-soc132]+Abs[soc72-soc12]+Abs[soc72-soc22]+Abs[soc72-soc32]+Abs[soc72-soc42]+Abs[soc72-soc52]+Abs[soc72-soc62]+Abs[soc72-soc72]+Abs[soc72-soc82]+Abs[soc72-soc92]+Abs[soc72-soc102]+Abs[soc72-soc112]+Abs[soc72-soc122]+Abs[soc72-soc132]+Abs[soc82-soc12]+Abs[soc82-soc22]+Abs[soc82-soc32]+Abs[soc82-soc42]+Abs[soc82-soc52]+Abs[soc82-soc62]+Abs[soc82-soc72]+Abs[soc82-soc82]+Abs[soc82-soc92]+Abs[soc82-soc102]+Abs[soc82-soc112]+Abs[soc82-soc122]+Abs[soc82-soc132]+Abs[soc92-soc12]+Abs[soc92-soc22]+Abs[soc92-soc32]+Abs[soc92-soc42]+Abs[soc92-soc52]+Abs[soc92-soc62]+Abs[soc92-soc72]+Abs[soc92-soc82]+Abs[soc92-soc92]+Abs[soc92-soc102]+Abs[soc92-soc112]+Abs[soc92-soc122]+Abs[soc92-soc132]+Abs[soc102-soc12]+Abs[soc102-soc22]+Abs[soc102-soc32]+Abs[soc102-soc42]+Abs[soc102-soc52]+Abs[soc102-soc62]+Abs[soc102-soc72]+Abs[soc102-soc82]+Abs[soc102-soc92]+Abs[soc102-soc102]+Abs[soc102-soc112]+Abs[soc102-soc122]+Abs[soc102-soc132]+Abs[soc112-soc12]+Abs[soc112-soc22]+Abs[soc112-soc32]+Abs[soc112-soc42]+Abs[soc112-soc52]+Abs[soc112-soc62]+Abs[soc112-soc72]+Abs[soc112-soc82]+Abs[soc112-soc92]+Abs[soc112-soc102]+Abs[soc112-soc112]+Abs[soc112-soc122]+Abs[soc112-soc132]+Abs[soc122-soc12]+Abs[soc122-soc22]+Abs[soc122-soc32]+Abs[soc122-soc42]+Abs[soc122-soc52]+Abs[soc122-soc62]+Abs[soc122-soc72]+Abs[soc122-soc82]+Abs[soc122-soc92]+Abs[soc122-soc102]+Abs[soc122-soc112]+Abs[soc122-soc122]+Abs[soc122-soc132]+Abs[soc132-soc12]+Abs[soc132-soc22]+Abs[soc132-soc32]+Abs[soc132-soc42]+Abs[soc132-soc52]+Abs[soc132-soc62]+Abs[soc132-soc72]+Abs[soc132-soc82]+Abs[soc132-soc92]+Abs[soc132-soc102]+Abs[soc132-soc112]+Abs[soc132-soc122]+Abs[soc132-soc132])]")

		For i = 0 To Me._usedLocations - 1
			Me._MathWrapper.WaitAndDiscardAnswer("env" & i + 1 & "1=envlis1[[1," & i + 1 & "]]")
		Next

		Me._MathWrapper.WaitAndDiscardAnswer("envmea1=(env11+env21+env31+env41+env51+env61+env71+env81+env91+env101+env111+env121+env131)/13")
		Me._MathWrapper.WaitAndDiscardAnswer("envgin1=N[(1/2*1/13^2*(1/envmea1))(Abs[env11-env11]+Abs[env11-env21]+Abs[env11-env31]+Abs[env11-env41]+Abs[env11-env51]+Abs[env11-env61]+Abs[env11-env71]+Abs[env11-env81]+Abs[env11-env91]+Abs[env11-env101]+Abs[env11-env111]+Abs[env11-env121]+Abs[env11-env131]+Abs[env21-env11]+Abs[env21-env21]+Abs[env21-env31]+Abs[env21-env41]+Abs[env21-env51]+Abs[env21-env61]+Abs[env21-env71]+Abs[env21-env81]+Abs[env21-env91]+Abs[env21-env101]+Abs[env21-env111]+Abs[env21-env121]+Abs[env21-env131]+Abs[env31-env11]+Abs[env31-env21]+Abs[env31-env31]+Abs[env31-env41]+Abs[env31-env51]+Abs[env31-env61]+Abs[env31-env71]+Abs[env31-env81]+Abs[env31-env91]+Abs[env31-env101]+Abs[env31-env111]+Abs[env31-env121]+Abs[env31-env131]+Abs[env41-env11]+Abs[env41-env21]+Abs[env41-env31]+Abs[env41-env41]+Abs[env41-env51]+Abs[env41-env61]+Abs[env41-env71]+Abs[env41-env81]+Abs[env41-env91]+Abs[env41-env101]+Abs[env41-env111]+Abs[env41-env121]+Abs[env41-env131]+Abs[env51-env11]+Abs[env51-env21]+Abs[env51-env31]+Abs[env51-env41]+Abs[env51-env51]+Abs[env51-env61]+Abs[env51-env71]+Abs[env51-env81]+Abs[env51-env91]+Abs[env51-env101]+Abs[env51-env111]+Abs[env51-env121]+Abs[env51-env131]+Abs[env61-env11]+Abs[env61-env21]+Abs[env61-env31]+Abs[env61-env41]+Abs[env61-env51]+Abs[env61-env61]+Abs[env61-env71]+Abs[env61-env81]+Abs[env61-env91]+Abs[env61-env101]+Abs[env61-env111]+Abs[env61-env121]+Abs[env61-env131]+Abs[env71-env11]+Abs[env71-env21]+Abs[env71-env31]+Abs[env71-env41]+Abs[env71-env51]+Abs[env71-env61]+Abs[env71-env71]+Abs[env71-env81]+Abs[env71-env91]+Abs[env71-env101]+Abs[env71-env111]+Abs[env71-env121]+Abs[env71-env131]+Abs[env81-env11]+Abs[env81-env21]+Abs[env81-env31]+Abs[env81-env41]+Abs[env81-env51]+Abs[env81-env61]+Abs[env81-env71]+Abs[env81-env81]+Abs[env81-env91]+Abs[env81-env101]+Abs[env81-env111]+Abs[env81-env121]+Abs[env81-env131]+Abs[env91-env11]+Abs[env91-env21]+Abs[env91-env31]+Abs[env91-env41]+Abs[env91-env51]+Abs[env91-env61]+Abs[env91-env71]+Abs[env91-env81]+Abs[env91-env91]+Abs[env91-env101]+Abs[env91-env111]+Abs[env91-env121]+Abs[env91-env131]+Abs[env101-env11]+Abs[env101-env21]+Abs[env101-env31]+Abs[env101-env41]+Abs[env101-env51]+Abs[env101-env61]+Abs[env101-env71]+Abs[env101-env81]+Abs[env101-env91]+Abs[env101-env101]+Abs[env101-env111]+Abs[env101-env121]+Abs[env101-env131]+Abs[env111-env11]+Abs[env111-env21]+Abs[env111-env31]+Abs[env111-env41]+Abs[env111-env51]+Abs[env111-env61]+Abs[env111-env71]+Abs[env111-env81]+Abs[env111-env91]+Abs[env111-env101]+Abs[env111-env111]+Abs[env111-env121]+Abs[env111-env131]+Abs[env121-env11]+Abs[env121-env21]+Abs[env121-env31]+Abs[env121-env41]+Abs[env121-env51]+Abs[env121-env61]+Abs[env121-env71]+Abs[env121-env81]+Abs[env121-env91]+Abs[env121-env101]+Abs[env121-env111]+Abs[env121-env121]+Abs[env121-env131]+Abs[env131-env11]+Abs[env131-env21]+Abs[env131-env31]+Abs[env131-env41]+Abs[env131-env51]+Abs[env131-env61]+Abs[env131-env71]+Abs[env131-env81]+Abs[env131-env91]+Abs[env131-env101]+Abs[env131-env111]+Abs[env131-env121]+Abs[env131-env131])]")

		For i = 0 To Me._usedLocations - 1
			Me._MathWrapper.WaitAndDiscardAnswer("env" & i + 1 & "2=envlis2[[1," & i + 1 & "]]")
		Next

		Me._MathWrapper.WaitAndDiscardAnswer("envmea2=(env12+env22+env32+env42+env52+env62+env72+env82+env92+env102+env112+env122+env132)/13")
		Me._MathWrapper.WaitAndDiscardAnswer("envgin2=N[(1/2*1/13^2*(1/envmea2))(Abs[env12-env12]+Abs[env12-env22]+Abs[env12-env32]+Abs[env12-env42]+Abs[env12-env52]+Abs[env12-env62]+Abs[env12-env72]+Abs[env12-env82]+Abs[env12-env92]+Abs[env12-env102]+Abs[env12-env112]+Abs[env12-env122]+Abs[env12-env132]+Abs[env22-env12]+Abs[env22-env22]+Abs[env22-env32]+Abs[env22-env42]+Abs[env22-env52]+Abs[env22-env62]+Abs[env22-env72]+Abs[env22-env82]+Abs[env22-env92]+Abs[env22-env102]+Abs[env22-env112]+Abs[env22-env122]+Abs[env22-env132]+Abs[env32-env12]+Abs[env32-env22]+Abs[env32-env32]+Abs[env32-env42]+Abs[env32-env52]+Abs[env32-env62]+Abs[env32-env72]+Abs[env32-env82]+Abs[env32-env92]+Abs[env32-env102]+Abs[env32-env112]+Abs[env32-env122]+Abs[env32-env132]+Abs[env42-env12]+Abs[env42-env22]+Abs[env42-env32]+Abs[env42-env42]+Abs[env42-env52]+Abs[env42-env62]+Abs[env42-env72]+Abs[env42-env82]+Abs[env42-env92]+Abs[env42-env102]+Abs[env42-env112]+Abs[env42-env122]+Abs[env42-env132]+Abs[env52-env12]+Abs[env52-env22]+Abs[env52-env32]+Abs[env52-env42]+Abs[env52-env52]+Abs[env52-env62]+Abs[env52-env72]+Abs[env52-env82]+Abs[env52-env92]+Abs[env52-env102]+Abs[env52-env112]+Abs[env52-env122]+Abs[env52-env132]+Abs[env62-env12]+Abs[env62-env22]+Abs[env62-env32]+Abs[env62-env42]+Abs[env62-env52]+Abs[env62-env62]+Abs[env62-env72]+Abs[env62-env82]+Abs[env62-env92]+Abs[env62-env102]+Abs[env62-env112]+Abs[env62-env122]+Abs[env62-env132]+Abs[env72-env12]+Abs[env72-env22]+Abs[env72-env32]+Abs[env72-env42]+Abs[env72-env52]+Abs[env72-env62]+Abs[env72-env72]+Abs[env72-env82]+Abs[env72-env92]+Abs[env72-env102]+Abs[env72-env112]+Abs[env72-env122]+Abs[env72-env132]+Abs[env82-env12]+Abs[env82-env22]+Abs[env82-env32]+Abs[env82-env42]+Abs[env82-env52]+Abs[env82-env62]+Abs[env82-env72]+Abs[env82-env82]+Abs[env82-env92]+Abs[env82-env102]+Abs[env82-env112]+Abs[env82-env122]+Abs[env82-env132]+Abs[env92-env12]+Abs[env92-env22]+Abs[env92-env32]+Abs[env92-env42]+Abs[env92-env52]+Abs[env92-env62]+Abs[env92-env72]+Abs[env92-env82]+Abs[env92-env92]+Abs[env92-env102]+Abs[env92-env112]+Abs[env92-env122]+Abs[env92-env132]+Abs[env102-env12]+Abs[env102-env22]+Abs[env102-env32]+Abs[env102-env42]+Abs[env102-env52]+Abs[env102-env62]+Abs[env102-env72]+Abs[env102-env82]+Abs[env102-env92]+Abs[env102-env102]+Abs[env102-env112]+Abs[env102-env122]+Abs[env102-env132]+Abs[env112-env12]+Abs[env112-env22]+Abs[env112-env32]+Abs[env112-env42]+Abs[env112-env52]+Abs[env112-env62]+Abs[env112-env72]+Abs[env112-env82]+Abs[env112-env92]+Abs[env112-env102]+Abs[env112-env112]+Abs[env112-env122]+Abs[env112-env132]+Abs[env122-env12]+Abs[env122-env22]+Abs[env122-env32]+Abs[env122-env42]+Abs[env122-env52]+Abs[env122-env62]+Abs[env122-env72]+Abs[env122-env82]+Abs[env122-env92]+Abs[env122-env102]+Abs[env122-env112]+Abs[env122-env122]+Abs[env122-env132]+Abs[env132-env12]+Abs[env132-env22]+Abs[env132-env32]+Abs[env132-env42]+Abs[env132-env52]+Abs[env132-env62]+Abs[env132-env72]+Abs[env132-env82]+Abs[env132-env92]+Abs[env132-env102]+Abs[env132-env112]+Abs[env132-env122]+Abs[env132-env132])]")

		Me._MathWrapper.WaitAndDiscardAnswer("mobj = m[[{1}]]")
		Me._MathWrapper.WaitAndDiscardAnswer("marg = m[[{2}]]")

		'x 26 output for agriculture
		Dim cursor As Integer

		cursor = 1
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				Me._outagr(i, j) = Me._MathWrapper.WaitAndEvaluateAsDouble("x" & (i + 1).ToString & (j + 1).ToString & "/.marg[[1," & cursor & "]]")
				cursor += 1
			Next
		Next

		'y 13 output for industries
		For i = 0 To Me._usedLocations - 1
			Me._outind(i) = Me._MathWrapper.WaitAndEvaluateAsDouble("y" & (i + 1).ToString & "2/.marg[[1," & cursor & "]]")
			cursor += 1
		Next

		'z 26 output for landscape
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				Me._outlan(i, j) = Me._MathWrapper.WaitAndEvaluateAsDouble("z" & (i + 1).ToString & (j + 1).ToString & "/.marg[[1," & cursor & "]]")
				cursor += 1
			Next
		Next

		'output for economy
		For i = 0 To Me._usedLocations - 1
			'For j = 0  Me._usedDimensions -1
			Me._outeco(i, 0) = Math.Round(Me._MathWrapper.WaitAndEvaluateAsDouble("ecolis1[[1," & (i + 1).ToString & "]]") * 100, 0, MidpointRounding.AwayFromZero)
			cursor += 1
			'Next
			Me._outeco(i, 1) = Math.Round(Me._MathWrapper.WaitAndEvaluateAsDouble("ecolis2[[1," & (i + 1).ToString & "]]") * 100, 0, MidpointRounding.AwayFromZero)
		Next
		Me._outecomean1 = Math.Round(Me._MathWrapper.WaitAndEvaluateAsDouble("ecomea1") * 100, 0, MidpointRounding.AwayFromZero)
		Me._outecomean2 = Math.Round(Me._MathWrapper.WaitAndEvaluateAsDouble("ecomea2") * 100, 0, MidpointRounding.AwayFromZero)
		Me._outecogini1 = Me._MathWrapper.WaitAndEvaluateAsDouble("ecogin1")
		Me._outecogini2 = Me._MathWrapper.WaitAndEvaluateAsDouble("ecogin2")

		'output for social
		For i = 0 To Me._usedLocations - 1
			'For j = 0  Me._usedDimensions -1
			Me._outsoc(i, 0) = Math.Round(Me._MathWrapper.WaitAndEvaluateAsDouble("soclis1[[1," & (i + 1).ToString & "]]") * 100, 0, MidpointRounding.AwayFromZero)
			cursor += 1
			'Next
			Me._outsoc(i, 1) = Math.Round(Me._MathWrapper.WaitAndEvaluateAsDouble("soclis2[[1," & (i + 1).ToString & "]]") * 100, 0, MidpointRounding.AwayFromZero)
		Next
		Me._outsocmean1 = Math.Round(Me._MathWrapper.WaitAndEvaluateAsDouble("socmea1") * 100, 0, MidpointRounding.AwayFromZero)
		Me._outsocmean2 = Math.Round(Me._MathWrapper.WaitAndEvaluateAsDouble("socmea2") * 100, 0, MidpointRounding.AwayFromZero)
		Me._outsocgini1 = Me._MathWrapper.WaitAndEvaluateAsDouble("socgin1")
		Me._outsocgini2 = Me._MathWrapper.WaitAndEvaluateAsDouble("socgin2")

		'output for environment
		For i = 0 To Me._usedLocations - 1
			'For j = 0  Me._usedDimensions -1
			Me._outenv(i, 0) = Math.Round(Me._MathWrapper.WaitAndEvaluateAsDouble("envlis1[[1," & (i + 1).ToString & "]]") * 100, 0, MidpointRounding.AwayFromZero)
			cursor += 1
			'Next
			Me._outenv(i, 1) = Math.Round(Me._MathWrapper.WaitAndEvaluateAsDouble("envlis2[[1," & (i + 1).ToString & "]]") * 100, 0, MidpointRounding.AwayFromZero)
		Next
		Me._outenvmean1 = Math.Round(Me._MathWrapper.WaitAndEvaluateAsDouble("envmea1") * 100, 0, MidpointRounding.AwayFromZero)
		Me._outenvmean2 = Math.Round(Me._MathWrapper.WaitAndEvaluateAsDouble("envmea2") * 100, 0, MidpointRounding.AwayFromZero)
		Me._outenvgini1 = Me._MathWrapper.WaitAndEvaluateAsDouble("envgin1")
		Me._outenvgini2 = Me._MathWrapper.WaitAndEvaluateAsDouble("envgin2")

		'free varibles used for graph plotting

		Me._MathWrapper.WaitAndDiscardAnswer("sbqi=.")
		Me._MathWrapper.WaitAndDiscardAnswer("ssqi=.")
		Me._MathWrapper.WaitAndDiscardAnswer("smqi=.")
		Me._MathWrapper.WaitAndDiscardAnswer("tpbx=.")
		Me._MathWrapper.WaitAndDiscardAnswer("tpsx=.")
		Me._MathWrapper.WaitAndDiscardAnswer("tpsz=.")
		Me._MathWrapper.WaitAndDiscardAnswer("tpmz=.")
		Me._MathWrapper.WaitAndDiscardAnswer("ecow=.")
		Me._MathWrapper.WaitAndDiscardAnswer("socw=.")
		Me._MathWrapper.WaitAndDiscardAnswer("envw=.")
		Me._MathWrapper.WaitAndDiscardAnswer("agrw=.")
		Me._MathWrapper.WaitAndDiscardAnswer("indw=.")
		Me._MathWrapper.WaitAndDiscardAnswer("lanw=.")
		Me._MathWrapper.WaitAndDiscardAnswer("gwsp=.")
		Me._MathWrapper.WaitAndDiscardAnswer("totpla=.")

		'defining graph parameters
		Me._MathWrapper.WaitAndDiscardAnswer("ssqi = 1000")
		Me._MathWrapper.WaitAndDiscardAnswer("ecow = 1 - socw - envw")
		Me._MathWrapper.WaitAndDiscardAnswer("agrw = 0.33")
		Me._MathWrapper.WaitAndDiscardAnswer("indw = 0.33")
		Me._MathWrapper.WaitAndDiscardAnswer("lanw = 0.33")
		Me._MathWrapper.WaitAndDiscardAnswer("gwsp = 1.518")
		Me._MathWrapper.WaitAndDiscardAnswer("totpla = 20")
		Me._MathWrapper.WaitAndDiscardAnswer("totobj20rWEL =.")
		Me._MathWrapper.WaitAndDiscardAnswer("totobj20rSUS =.")
		Me._MathWrapper.WaitAndDiscardAnswer("totobj20rEFF =.")

		'adapt matrix syntax to minimize solution
		Me._MathWrapper.WaitAndDiscardAnswer("totobj20 = totobj20 /. {x[1][1] -> x11, x[1][2] -> x12, x[2][1] -> x21, x[2][2] -> x22, x[3][1] -> x31, x[3][2] -> x32, x[4][1] -> x41, x[4][2] -> x42, x[5][1] -> x51, x[5][2] -> x52, x[6][1] -> x61, x[6][2] -> x62, x[7][1] -> x71, x[7][2] -> x72, x[8][1] -> x81, x[8][2] -> x82, x[9][1] -> x91, x[9][2] -> x92, x[10][1] -> x101, x[10][2] -> x102, x[11][1] -> x111, x[11][2] -> x112, x[12][1] -> x121, x[12][2] -> x122, x[13][1] -> x131, x[13][2] -> x132, y[1][1] -> y11, y[1][2] -> y12, y[2][1] -> y21, y[2][2] -> y22, y[3][1] -> y31, y[3][2] -> y32, y[4][1] -> y41, y[4][2] -> y42, y[5][1] -> y51, y[5][2] -> y52, y[6][1] -> y61, y[6][2] -> y62, y[7][1] -> y71, y[7][2] -> y72, y[8][1] -> y81, y[8][2] -> y82, y[9][1] -> y91, y[9][2] -> y92, y[10][1] -> y101, y[10][2] -> y102, y[11][1] -> y111, y[11][2] -> y112, y[12][1] -> y121, y[12][2] -> y122, y[13][1] -> y131, y[13][2] -> y132, z[1][1] -> z11, z[1][2] -> z12, z[2][1] -> z21, z[2][2] -> z22, z[3][1] -> z31, z[3][2] -> z32, z[4][1] -> z41, z[4][2] -> z42, z[5][1] -> z51, z[5][2] -> z52, z[6][1] -> z61, z[6][2] -> z62, z[7][1] -> z71, z[7][2] -> z72, z[8][1] -> z81, z[8][2] -> z82, z[9][1] -> z91, z[9][2] -> z92, z[10][1] -> z101, z[10][2] -> z102, z[11][1] -> z111, z[11][2] -> z112, z[12][1] -> z121, z[12][2] -> z122, z[13][1] -> z131, z[13][2] -> z132}")

		Me._MathWrapper.WaitAndDiscardAnswer("totobj20rWEL = totobj20*100 /. marg")
		Me._MathWrapper.WaitAndDiscardAnswer("totobj20rWEL = totobj20rWEL /. {sbqi -> 20, smqi -> 20, tpbx -> 0.35, tpmz -> 0.30}")
		Me._MathWrapper.WaitAndDiscardAnswer("totobj20rSUS = totobj20*100 /. marg")
		Me._MathWrapper.WaitAndDiscardAnswer("totobj20rSUS = totobj20rSUS /. {socw -> 0.33, envw -> 0.33, tpbx -> 0.35, tpmz -> 0.30}")
		Me._MathWrapper.WaitAndDiscardAnswer("totobj20rEFF = totobj20*100 /. marg")
		Me._MathWrapper.WaitAndDiscardAnswer("totobj20rEFF = totobj20rEFF /. {sbqi -> 20, smqi -> 20, socw -> 0.33, envw -> 0.33}")

		Me._MathWrapper.WaitAndDiscardAnswer("mobj = m[[1]]")
		Me._MathWrapper.WaitAndDiscardAnswer("ranup = mobj * 1.1")
		Me._MathWrapper.WaitAndDiscardAnswer("rando = mobj * 0.9")

		Me.pboGraphWeights.Image = Me._MathWrapper.WaitAndEvaluateAsImage("ContourPlot[totobj20rWEL, {socw, 0, 1}, {envw, 0, 1}, PlotRange -> {ranup, rando}, ContourLabels -> All, FrameLabel -> {""socw %"", ""envw %""}]", Me.pboGraphWeights)
		Me.pboGraphStandards.Image = Me._MathWrapper.WaitAndEvaluateAsImage("ContourPlot[totobj20rSUS, {smqi, 0, 40}, {sbqi, 0, 40}, PlotRange -> {ranup, rando}, ContourLabels -> All, FrameLabel -> {""TSS mg/l"", ""BOD mg/l""}]", Me.pboGraphStandards)
		Me.pboGraphEfficiencies.Image = Me._MathWrapper.WaitAndEvaluateAsImage("ContourPlot[totobj20rEFF, {tpbx, 0, 1}, {tpmz, 0, 1}, PlotRange -> {ranup, rando}, ContourLabels -> All, FrameLabel -> {""TSS % cut"", ""BOD % cut""}]", Me.pboGraphEfficiencies)

		Me.WriteValuesToDB()
	End Sub

	''' <summary>
	''' resets data to defaults
	''' </summary>
	''' <remarks></remarks>
	Private Sub Reset(skipRequest As Boolean)
		Dim i, j As Integer

		If skipRequest OrElse MessageBox.Show("Are you sure you want to reset data to default values?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
			For i = 0 To Me._usedLocations - 1
				Me._bod(i) = 0
				Me._tds(i) = 0
				Me._tss(i) = 0
				Me._des(i) = 0
				Me._gro(i) = 0
			Next

			For i = 0 To Me._usedLocations - 1
				For j = 0 To Me._usedDimensions - 1
					Me._indcc(i, j) = 0
					Me._agrcc(i, j) = 0
					Me._lancc(i, j) = 0
					Me._lbqi(i, j) = 0
					Me._lsqi(i, j) = 0
					Me._lmqi(i, j) = 0
					Me._pop20(i, j) = 0
					Me._inddis(i, j) = 0
					Me._inddiscur(i, j) = 0
					Me._inddispln(i, j) = 0
				Next
			Next

			Me._gwsp = 0
			Me._agruf = 0
			Me._agrufro = 0
			Me._induf = 0
			Me._indufro = 0
			Me._lanuf = 0
			Me._lanufro = 0
			Me._tpbx = 0
			Me._tpsx = 0
			Me._tpmz = 0
			Me._envw = 0
			Me._socw = 0
			Me._totpla = 0
			Me._sbqi = 0
			Me._ssqi = 0
			Me._smqi = 0
			Me._agrw = 0
			Me._indw = 0
			Me._lanw = 0
			Me._salt = True

			Me.WriteValuesToGUI(WriteToGUIType.input)

			Me.RefreshMap(Me._groupBoxes(0), New System.EventArgs)
		End If
	End Sub

	''' <summary>
	''' change text on btnNext
	''' </summary>
	''' <remarks></remarks>
	Private Sub SetNextText()
		If Me._groupBoxesID = Me._groupBoxes.Length - 2 Then
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
		If Me._groupBoxesID = 0 Then
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
		Me._groupBoxesID -= 1

		Me.SetPrevText()
		Me.ShowButtons()
		Me.ShowBox()
	End Sub

	''' <summary>
	''' show next input/output panel
	''' </summary>
	''' <remarks></remarks>
	Private Sub NextStep()
		Me._groupBoxesID += 1

		Me.SetPrevText()
		Me.ShowButtons()

		If Me._groupBoxesID = Me._groupBoxes.Length - 1 Then
			'end of input phase
			Me.Enabled = False
			Me.Cursor = Cursors.WaitCursor
			Me.Calculate()
			Me.WriteValuesToGUI(WriteToGUIType.output)
			Me.Enabled = True
			Me.Cursor = Cursors.Default
		End If

		If Me._groupBoxesID = Me._groupBoxes.Length Then
			Me.Close()
		Else
			Me.ShowBox()
			If Me._groupBoxesID = Me._groupBoxes.Length Then
				Me.Close()
			End If
		End If
	End Sub

	''' <summary>
	''' shows or hides btnPrev and btnNext depending on current box shown
	''' </summary>
	''' <remarks></remarks>
	Private Sub ShowButtons()
		If Me._groupBoxesID < Me._groupBoxes.Length - 1 Then
			Me.btnPrev.Visible = True
			Me.btnNext.Visible = True
		Else
			'Me.btnPrev.Visible = False
			Me.btnNext.Visible = False
		End If

		If Me._groupBoxesID = Me._groupBoxes.Length - 1 Then
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

		If Me._groupBoxesID > 0 Then
			Me.btnLoadData.Visible = False
			Me.btnSettings.Visible = False
		Else
			Me.btnLoadData.Visible = True
			Me.btnSettings.Visible = True
		End If

		For i = 0 To Me._groupBoxes.Length - 1
			Me._groupBoxes(i).Visible = False
		Next

		Me._groupBoxes(Me._groupBoxesID).DSSVisible = True

		Try
			Me.SplitContainer.SplitterDistance = Me._groupBoxes(Me._groupBoxesID).Width
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

			For i = 0 To Me._usedLocations - 1
				Me._bod(i) = Utility.NullToDouble(tmpDataRowView.Item("bod" & i + 1))
				Me._tds(i) = Utility.NullToDouble(tmpDataRowView.Item("tds" & i + 1))
				Me._tss(i) = Utility.NullToDouble(tmpDataRowView.Item("tss" & i + 1))
				Me._des(i) = Utility.NullToDouble(tmpDataRowView.Item("indcc" & i + 1 & "_1"))
				Me._gro(i) = Utility.NullToDouble(tmpDataRowView.Item("agrcc" & i + 1 & "_1"))
			Next

			For i = 0 To Me._usedLocations - 1
				For j = 0 To Me._usedDimensions - 1
					Me._indcc(i, j) = Utility.NullToDouble(tmpDataRowView.Item("indcc" & i + 1 & "_" & j + 1))
					Me._agrcc(i, j) = Utility.NullToDouble(tmpDataRowView.Item("agrcc" & i + 1 & "_" & j + 1))
					Me._lancc(i, j) = Utility.NullToDouble(tmpDataRowView.Item("lancc" & i + 1 & "_" & j + 1))
					Me._lbqi(i, j) = Utility.NullToDouble(tmpDataRowView.Item("lbqi" & i + 1 & "_" & j + 1))
					Me._lsqi(i, j) = Utility.NullToDouble(tmpDataRowView.Item("lsqi" & i + 1 & "_" & j + 1))
					Me._lmqi(i, j) = Utility.NullToDouble(tmpDataRowView.Item("lmqi" & i + 1 & "_" & j + 1))
					Me._pop20(i, j) = Utility.NullToInteger(tmpDataRowView.Item("pop20_" & i + 1 & "_" & j + 1))
					Me._inddis(i, j) = Utility.NullToInteger(tmpDataRowView.Item("inddis" & i + 1 & "_" & j + 1))
					Me._inddiscur(i, j) = Utility.NullToInteger(tmpDataRowView.Item("inddiscur" & i + 1 & "_" & j + 1))
					Me._inddispln(i, j) = Utility.NullToInteger(tmpDataRowView.Item("inddispln" & i + 1 & "_" & j + 1))
				Next
			Next

			Me._gwsp = Utility.NullToDouble(tmpDataRowView.Item("gwsp"))
			Me._agruf = Utility.NullToDouble(tmpDataRowView.Item("agruf"))
			Me._agrufro = Utility.NullToDouble(tmpDataRowView.Item("agrufro"))
			Me._induf = Utility.NullToDouble(tmpDataRowView.Item("induf"))
			Me._indufro = Utility.NullToDouble(tmpDataRowView.Item("indufro"))
			Me._lanuf = Utility.NullToDouble(tmpDataRowView.Item("lanuf"))
			Me._lanufro = Utility.NullToDouble(tmpDataRowView.Item("lanufro"))
			Me._tpbx = Utility.NullToDouble(tmpDataRowView.Item("tpbx"))
			Me._tpsx = Utility.NullToDouble(tmpDataRowView.Item("tpsx"))
			Me._tpmz = Utility.NullToDouble(tmpDataRowView.Item("tpmz"))
			Me._envw = Utility.NullToDouble(tmpDataRowView.Item("envw"))
			Me._ecow = Utility.NullToDouble(tmpDataRowView.Item("ecow"))
			Me._socw = Utility.NullToDouble(tmpDataRowView.Item("socw"))
			Me._totpla = Utility.NullToDouble(tmpDataRowView.Item("totpla"))
			Me._sbqi = Utility.NullToDouble(tmpDataRowView.Item("sbqi"))
			Me._ssqi = Utility.NullToDouble(tmpDataRowView.Item("ssqi"))
			Me._smqi = Utility.NullToDouble(tmpDataRowView.Item("smqi"))
			Me._agrw = Utility.NullToDouble(tmpDataRowView.Item("agrw"))
			Me._indw = Utility.NullToDouble(tmpDataRowView.Item("indw"))
			Me._lanw = Utility.NullToDouble(tmpDataRowView.Item("lanw"))
			Me._salt = Utility.NullToBoolean(tmpDataRowView.Item("salt"))
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

				For i = 0 To Me._usedLocations - 1
					newRow("bod" & i + 1) = Me._bod(i)
					newRow("tds" & i + 1) = Me._tds(i)
					newRow("tss" & i + 1) = Me._tss(i)
				Next

				For i = 0 To Me._usedLocations - 1
					For j = 0 To Me._usedDimensions - 1
						newRow("indcc" & i + 1 & "_" & j + 1) = Me._indcc(i, j)
						newRow("agrcc" & i + 1 & "_" & j + 1) = Me._agrcc(i, j)
						newRow("lancc" & i + 1 & "_" & j + 1) = Me._lancc(i, j)
						newRow("lbqi" & i + 1 & "_" & j + 1) = Me._lbqi(i, j)
						newRow("lsqi" & i + 1 & "_" & j + 1) = Me._lsqi(i, j)
						newRow("lmqi" & i + 1 & "_" & j + 1) = Me._lmqi(i, j)
						newRow("pop20_" & i + 1 & "_" & j + 1) = Me._pop20(i, j)
						newRow("inddis" & i + 1 & "_" & j + 1) = Me._inddis(i, j)
						newRow("inddiscur" & i + 1 & "_" & j + 1) = Me._inddiscur(i, j)
						newRow("inddispln" & i + 1 & "_" & j + 1) = Me._inddispln(i, j)
					Next
				Next

				newRow("gwsp") = Me._gwsp
				newRow("agruf") = Me._agruf
				newRow("agrufro") = Me._agrufro
				newRow("induf") = Me._induf
				newRow("indufro") = Me._indufro
				newRow("lanuf") = Me._lanuf
				newRow("lanufro") = Me._lanufro
				newRow("tpbx") = Me._tpbx
				newRow("tpsx") = Me._tpsx
				newRow("tpmz") = Me._tpmz
				newRow("envw") = Me._envw
				newRow("ecow") = Me._ecow
				newRow("socw") = Me._socw
				newRow("totpla") = Me._totpla
				newRow("sbqi") = Me._sbqi
				newRow("ssqi") = Me._ssqi
				newRow("smqi") = Me._smqi
				newRow("agrw") = Me._agrw
				newRow("indw") = Me._indw
				newRow("lanw") = Me._lanw
				newRow("salt") = Me._salt

				newRow("DataCreazione") = Now
				newRow("UtenteCreazione") = 1
				newRow("DataAggiornamento") = Now
				newRow("UtenteAggiornamento") = 1
				newRow("Annullato") = 0
				newRow.EndEdit()

				Me.DSData.Tables("data").Rows.Add(newRow)

				Me.daData.Update(Me.DSData, "data")
			Catch ex As Exception

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
				For i = 0 To Me._usedLocations - 1
					Me._nudCollection("nudInddiscur" & i + 1 & "_2").Value = CDec(Me._inddiscur(i, 1))
					Me._nudCollection("nudInddispln" & i + 1 & "_2").Value = CDec(Me._inddispln(i, 1))
					Me._nudCollection("nudBOD" & i + 1).Value = CDec(Me._bod(i))
					Me._nudCollection("nudTDS" & i + 1).Value = CDec(Me._tds(i))
					Me._nudCollection("nudTSS" & i + 1).Value = CDec(Me._tss(i))
					Me._nudCollection("nudDes" & i + 1).Value = CDec(Me._des(i))
					Me._nudCollection("nudGro" & i + 1).Value = CDec(Me._gro(i))
				Next

				For i = 0 To Me._usedLocations - 1
					For j = 0 To Me._usedDimensions - 1
						Me._nudCollection("nudPop20_" & i + 1 & "_" & j + 1).Value = CDec(Me._pop20(i, j))
					Next
				Next

				Me.nudgwsp.Value = CDec(Me._gwsp)
				Me.nudAgrUF.Value = CDec(Me._agruf)
				Me.nudAgrUFRO.Value = CDec(Me._agrufro)
				Me.nudIndUF.Value = CDec(Me._induf)
				Me.nudIndUFRO.Value = CDec(Me._indufro)
				Me.nudLanUF.Value = CDec(Me._lanuf)
				Me.nudLanUFRO.Value = CDec(Me._lanufro)
				Me.nudTpbx.Value = CDec(Me._tpbx)
				Me.nudTpsx.Value = CDec(Me._tpsx)
				Me.nudTpmz.Value = CDec(Me._tpmz)
				Me.nudEnvw.Value = CDec(Me._envw)
				Me.nudEcow.Value = CDec(Me._ecow)
				Me.nudSocw.Value = CDec(Me._socw)
				Me.nudTotpla.Value = CDec(Me._totpla)
				Me.nudsbqi.Value = CDec(Me._sbqi)
				Me.nudssqi.Value = CDec(Me._ssqi)
				Me.nudsmqi.Value = CDec(Me._smqi)
				Me.nudAgrw.Value = CDec(Me._agrw)
				Me.nudIndw.Value = CDec(Me._indw)
				Me.nudLanw.Value = CDec(Me._lanw)
				Me.chkSalt.Checked = Me._salt
			Case WriteToGUIType.output
				'Agriculture
				For i = 0 To Me._usedLocations - 1
					For j = 0 To Me._usedDimensions - 1
						Me._lblCollection("lblAgr" & i + 1 & "_" & j + 1).Text = Me._outagr(i, j).ToString
					Next
				Next

				'Industry
				For i = 0 To Me._usedLocations - 1
					Me._lblCollection("lblInd" & i + 1 & "_2").Text = Me._outind(i).ToString
				Next

				'Landscape
				For i = 0 To Me._usedLocations - 1
					For j = 0 To Me._usedDimensions - 1
						Me._lblCollection("lblLan" & i + 1 & "_" & j + 1).Text = Me._outlan(i, j).ToString
					Next
				Next

				'economics
				For i = 0 To Me._usedLocations - 1
					For j = 0 To Me._usedDimensions - 1
						Me._lblCollection("lblEco" & i + 1 & "_" & j + 1).Text = Me._outeco(i, j).ToString
					Next
				Next
				Me.lblEcoMean1.Text = Me._outecomean1.ToString
				Me.lblEcoMean2.Text = Me._outecomean2.ToString
				Me.lblEcoGini1.Text = Me._outecogini1.ToString
				Me.lblEcoGini2.Text = Me._outecogini2.ToString

				'Social
				For i = 0 To Me._usedLocations - 1
					For j = 0 To Me._usedDimensions - 1
						Me._lblCollection("lblSoc" & i + 1 & "_" & j + 1).Text = Me._outsoc(i, j).ToString
					Next
				Next
				Me.lblSocMean1.Text = Me._outsocmean1.ToString
				Me.lblSocMean2.Text = Me._outsocmean2.ToString
				Me.lblSocGini1.Text = Me._outsocgini1.ToString
				Me.lblSocGini2.Text = Me._outsocgini2.ToString

				'Environment
				For i = 0 To Me._usedLocations - 1
					For j = 0 To Me._usedDimensions - 1
						Me._lblCollection("lblEnv" & i + 1 & "_" & j + 1).Text = Me._outenv(i, j).ToString
					Next
				Next
				Me.lblEnvMean1.Text = Me._outenvmean1.ToString
				Me.lblEnvMean2.Text = Me._outenvmean2.ToString
				Me.lblEnvGini1.Text = Me._outenvgini1.ToString
				Me.lblEnvGini2.Text = Me._outenvgini2.ToString

		End Select
	End Sub

	''' <summary>
	''' read values from user interface to global variables
	''' </summary>
	''' <remarks></remarks>
	Private Sub ReadValuesFromGUI()
		Dim i, j As Integer

		For i = 0 To Me._usedLocations - 1
			Me._des(i) = Me._nudCollection("nudDes" & i + 1).Value
			Me._gro(i) = Me._nudCollection("nudGro" & i + 1).Value
			Me._inddiscur(i, 0) = Me._inddiscur(i, 0)
			Me._inddispln(i, 0) = Me._inddispln(i, 0)
			Me._inddiscur(i, 1) = CInt(Me._nudCollection("nudInddiscur" & i + 1 & "_2").Value)
			Me._inddispln(i, 1) = CInt(Me._nudCollection("nudInddispln" & i + 1 & "_2").Value)
			Me._bod(i) = Me._nudCollection("nudBod" & i + 1).Value
			Me._tds(i) = Me._nudCollection("nudTds" & i + 1).Value
			Me._tss(i) = Me._nudCollection("nudTss" & i + 1).Value
		Next

		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				Me._pop20(i, j) = CInt(Me._nudCollection("nudPop20_" & i + 1 & "_" & j + 1).Value)
				Me._indcc(i, j) = Me._des(i)
				Me._lancc(i, j) = Me._gro(i)
				Me._agrcc(i, j) = Me._gro(i)
				Me._lbqi(i, j) = Me._bod(i)
				Me._lsqi(i, j) = Me._tds(i)
				Me._lmqi(i, j) = Me._tss(i)
			Next
		Next

		Me._gwsp = Me.nudgwsp.Value
		Me._agruf = Me.nudAgrUF.Value
		Me._agrufro = Me.nudAgrUFRO.Value
		Me._induf = Me.nudIndUF.Value
		Me._indufro = Me.nudIndUFRO.Value
		Me._lanuf = Me.nudLanUF.Value
		Me._lanufro = Me.nudLanUFRO.Value
		Me._tpbx = Me.nudTpbx.Value
		Me._tpsx = Me.nudTpsx.Value
		Me._tpmz = Me.nudTpmz.Value
		Me._envw = Me.nudEnvw.Value
		Me._ecow = Me.nudEcow.Value
		Me._socw = Me.nudSocw.Value
		Me._totpla = Me.nudTotpla.Value
		Me._sbqi = Me.nudsbqi.Value
		Me._ssqi = Me.nudssqi.Value
		Me._smqi = Me.nudsmqi.Value
		Me._agrw = Me.nudAgrw.Value
		Me._indw = Me.nudIndw.Value
		Me._lanw = Me.nudLanw.Value
		Me._salt = Me.chkSalt.Checked
	End Sub

	''' <summary>
	''' read last record from DB
	''' </summary>
	''' <remarks></remarks>
	Private Function Init() As Boolean
		Dim kernelPath As String
		Dim result As Boolean

		kernelPath = ""

		Try
			Me.TAParameters.Fill(Me.dsParameters.parameters)
			'read parameters
			kernelPath = Me.dsParameters.parameters.Rows(0).Item("parKernelPath").ToString
			Me._usedLocations = CInt(Me.dsParameters.parameters.Rows(0).Item("parLocations"))
			Me._usedDimensions = CInt(Me.dsParameters.parameters.Rows(0).Item("parDimensions"))
		Catch ex As Exception
			MessageBox.Show("Error reading parameters form database", "CRITICAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try

		Me.AddEventHandler(Me)

		Me.SetLocations()

		If kernelPath = "" OrElse Not System.IO.File.Exists(kernelPath) Then
			'kernel path not present or wrong path is present in db
			MessageBox.Show("Wolfram Mathematica executable kernel path is missing or wrong" & ControlChars.CrLf & "please set correct path", "CRITICAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

			Dim myfrmParameters As New frmParameters

			myfrmParameters.ShowDialog()
			End
		Else
			'start Mathematica kernel
			Me._MathWrapper = New MW.MathWrapper(kernelPath)
			If Me._MathWrapper.KernelReady Then
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

	''' <summary>
	''' Read locations data from DB and set GUI controls accordingly
	''' </summary>
	Private Sub SetLocations()
		Me.SetLocations(Me)
		Me.AdaptGUIToUsedDimensions()
	End Sub

	Private Sub AdaptGUIToUsedDimensions()
		Dim usedDimensions As Integer

		'if there is only one dimension, hide the unnecessary controls
		usedDimensions = CInt(Me.dsParameters.Tables("parameters").Rows(0).Item("parDimensions"))

		If usedDimensions = 1 Then
			Me.pnlPop20_2.Visible = False
			Me.lblTot20_2.Visible = False
			Me.lblTot20_1.Visible = False
		End If
	End Sub

	''' <summary>
	''' Hide unused controls
	''' </summary>
	''' <param name="container"></param>
	Private Sub SetLocations(container As Control)
		Dim usedLocations As Integer
		Dim tmpLocations As DataTable
		Dim tmpLabel As DSSLabel
		Dim tmpNumericUpDown As DSSNumericUpDown

		For Each control As Control In container.Controls
			'iterate through controls to find DSSNumericUpDown and DSSLabel
			If control.HasChildren AndAlso control.GetType.Name <> "DSSNumericUpDown" Then
				Me.SetLocations(control)
			Else
				'if control is a DSScontrol, set the location parameters
				tmpLocations = Me.DSLocations.Tables("locations")
				usedLocations = CInt(Me.dsParameters.Tables("parameters").Rows(0).Item("parLocations"))

				If control.GetType.Name = "DSSLabel" Then
					tmpLabel = DirectCast(control, DSSLabel)

					tmpLocations.DefaultView.RowFilter = "locID = " & tmpLabel.DSSLocation.ToString

					If tmpLocations.DefaultView.Count > 0 Then
						Me.SetLocation(tmpLabel, tmpLocations.DefaultView(0))
					End If

					If tmpLabel.DSSLocation > usedLocations Then
						tmpLabel.Visible = False
					End If
				ElseIf control.GetType.Name = "DSSNumericUpDown" Then
					tmpNumericUpDown = DirectCast(control, DSSNumericUpDown)

					tmpLocations.DefaultView.RowFilter = "locID = " & tmpNumericUpDown.DSSLocation.ToString

					If tmpLocations.DefaultView.Count > 0 Then
						Me.SetLocation(tmpNumericUpDown, tmpLocations.DefaultView(0))
					End If

					If tmpNumericUpDown.DSSLocation > usedLocations Then
						tmpNumericUpDown.Visible = False
					End If
				End If
			End If
		Next
	End Sub

	''' <summary>
	''' Set location data for a DSSLabel control
	''' </summary>
	''' <param name="control">control to set</param>
	''' <param name="location">location data</param>
	Private Sub SetLocation(control As DSSLabel, location As DataRowView)
		control.Text = location.Item("locName").ToString
		control.DSSElementName = location.Item("locName").ToString
	End Sub

	''' <summary>
	''' Set location data for a DSSLabel control
	''' </summary>
	''' <param name="control">control to set</param>
	''' <param name="location">location data</param>

	Private Sub SetLocation(control As DSSNumericUpDown, location As DataRowView)
	End Sub

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
					Me._nudCollection.Add(tmpNumericUpDown)
					Try
						DirectCast(tmpNumericUpDown.Parent, DSSPanel).DSSnudCollection.Add(tmpNumericUpDown)
					Catch ex As Exception

					End Try
				Case GetType(DSSLabel)
					tmpLabel = DirectCast(ctl, DSSLabel)
					Me._lblCollection.Add(tmpLabel)
					Try
						DirectCast(tmpLabel.Parent, DSSPanel).DSSlblCollection.Add(tmpLabel)
					Catch ex As Exception
					End Try
			End Select
		End If
	End Sub

#End Region

#Region " Event management "

	Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
		Me.SetParameters()
	End Sub

	Private Sub frmNegotiation_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
		Me.RefreshMap(Me._groupBoxes(0), New System.EventArgs)
	End Sub

	Private Sub frmNegotiation_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		'close Mathematica kernel
		Me._MathWrapper.KernelStop()
	End Sub

	Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
		Me.NextStep()
	End Sub

	Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
		If Me._groupBoxesID = 0 Then
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

		frmScenario.Dispose()
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