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
	Private _mathematicaMethod As String

	Private _salt As Boolean

#End Region

#Region " Constructor "

	Public Sub New()
		' Chiamata richiesta da Progettazione Windows Form.
		InitializeComponent()

		' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
		Me.SqlConnection.ConnectionString = My.Settings.DSDSSConnectionString

		Me.DALocations.Fill(Me.DSLocations)

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

			'set default optimization method
			Me.cboMatemathicaMethod.SelectedIndex = 0
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

		Me._MathWrapper.WaitAndDiscardAnswer("totpop20 = Sum[pop20[i][j], {i, 1, " & Me._usedLocations & "}, {j, 1, " & Me._usedDimensions & "}]")

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
		If Me._salt Then
			'salt have to be considered
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
			Next
		Else
			'salt have to be ignored
			For i = 0 To Me._usedLocations - 1
				Me._MathWrapper.WaitAndDiscardAnswer("agrpc[" & i + 1 & "][1]=3.5")
				Me._MathWrapper.WaitAndDiscardAnswer("agrpc[" & i + 1 & "][2]=3.5")
			Next

			For i = 0 To Me._usedLocations - 1
				Me._MathWrapper.WaitAndDiscardAnswer("indpc[" & i + 1 & "][1]=1.75")
				Me._MathWrapper.WaitAndDiscardAnswer("indpc[" & i + 1 & "][2]=1.75")
			Next

			For i = 0 To Me._usedLocations - 1
				Me._MathWrapper.WaitAndDiscardAnswer("lanpc[" & i + 1 & "][1]=3.5")
				Me._MathWrapper.WaitAndDiscardAnswer("lanpc[" & i + 1 & "][2]=3.5")
			Next
		End If

		For i = 0 To Me._usedLocations - 1
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
		Me._MathWrapper.WaitAndDiscardAnswer("ecoobj20=Sum[(pop20[i][j]/totpop20)(agrw*agrobj+indw*indobj+lanw*lanobj),{i,1," & Me._usedLocations & "},{j,1," & Me._usedDimensions & "}]")
		'if TSS has to be considered
		Me._MathWrapper.WaitAndDiscardAnswer("socobj20=Sum[(pop20[i][j]/totpop20)*(((lmqi[i][j]*(1-tpmz*z[i][j]))/smqi)),{i,1," & Me._usedLocations & "},{j,1,"& Me._usedDimensions &"}]")
		'if TSS has not to be considered
		Me._MathWrapper.WaitAndDiscardAnswer("socobj20=0")
		Me._MathWrapper.WaitAndDiscardAnswer("envobj20=Sum[(pop20[i][j]/totpop20)*(((lbqi[i][j]*(1-tpbx*x[i][j]))/sbqi)),{i,1," & Me._usedLocations & "},{j,1," & Me._usedDimensions & "}]")

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
		'pattern: x[i][j] -> xi1j,
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				tmpString.Append("x[" & i + 1 & "][" & j + 1 & "] -> x" & i + 1 & j + 1 & ", ")
			Next
		Next
		'pattern: y[i][j] -> xi1j,
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				tmpString.Append("y[" & i + 1 & "][" & j + 1 & "] -> y" & i + 1 & j + 1 & ", ")
			Next
		Next
		'pattern: z[i][j] -> zi1j,
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				tmpString.Append("z[" & i + 1 & "][" & j + 1 & "] -> z" & i + 1 & j + 1 & ", ")
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

		Me._MathWrapper.WaitAndDiscardAnswer("m = NMinimize[{totobj20r*100, (" & tmpString.ToString & "}, Method -> " & Me._mathematicaMethod & "]")

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

		'create the expression to pass to Wolfram Mathematica
		tmpString.Length = 0
		'pattern: ecoi1+
		For i = 0 To Me._usedLocations - 1
			tmpString.Append("eco" & i + 1 & "1+")
		Next

		tmpString.Length -= "+".Length

		Me._MathWrapper.WaitAndDiscardAnswer("ecomea1=(" & tmpString.ToString & ")/" & Me._usedLocations)

		'create the expression to pass to Wolfram Mathematica
		tmpString.Length = 0
		'pattern: Abs[eco11-eco11]+
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedLocations - 1
				tmpString.Append("Abs[eco" & i + 1 & "1-eco" & j + 1 & "1]+")
			Next
		Next

		tmpString.Length -= "+".Length

		Me._MathWrapper.WaitAndDiscardAnswer("ecogin1=N[(1/2*1/" & Me._usedLocations & "^2*(1/ecomea1))(" & tmpString.ToString & ")]")

		For i = 0 To Me._usedLocations - 1
			Me._MathWrapper.WaitAndDiscardAnswer("eco" & i + 1 & "2=ecolis2[[1," & i + 1 & "]]")
		Next

		'create the expression to pass to Wolfram Mathematica
		tmpString.Length = 0
		'pattern: ecoi2+
		For i = 0 To Me._usedLocations - 1
			tmpString.Append("eco" & i + 1 & "2+")
		Next

		tmpString.Length -= "+".Length

		Me._MathWrapper.WaitAndDiscardAnswer("ecomea2=(" & tmpString.ToString & ")/" & Me._usedLocations)

		'create the expression to pass to Wolfram Mathematica
		tmpString.Length = 0
		'pattern: Abs[eco12-eco12]+
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedLocations - 1
				tmpString.Append("Abs[eco" & i + 1 & "2-eco" & j + 1 & "2]+")
			Next
		Next

		tmpString.Length -= "+".Length

		Me._MathWrapper.WaitAndDiscardAnswer("ecogin2=N[(1/2*1/" & Me._usedLocations & "^2*(1/ecomea2))(" & tmpString.ToString & ")]")

		For i = 0 To Me._usedLocations - 1
			Me._MathWrapper.WaitAndDiscardAnswer("soc" & i + 1 & "1=soclis1[[1," & i + 1 & "]]")
		Next

		'create the expression to pass to Wolfram Mathematica
		tmpString.Length = 0
		'pattern: soci1+
		For i = 0 To Me._usedLocations - 1
			tmpString.Append("soc" & i + 1 & "1+")
		Next

		tmpString.Length -= "+".Length

		Me._MathWrapper.WaitAndDiscardAnswer("socmea1=(" & tmpString.ToString & ")/" & Me._usedLocations)

		'create the expression to pass to Wolfram Mathematica
		tmpString.Length = 0
		'pattern: Abs[soc11-soc11]+
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedLocations - 1
				tmpString.Append("Abs[soc" & i + 1 & "1-soc" & j + 1 & "1]+")
			Next
		Next

		tmpString.Length -= "+".Length

		Me._MathWrapper.WaitAndDiscardAnswer("socgin1=N[(1/2*1/" & Me._usedLocations & "^2*(1/socmea1))(" & tmpString.ToString & ")]")

		For i = 0 To Me._usedLocations - 1
			Me._MathWrapper.WaitAndDiscardAnswer("soc" & i + 1 & "2=soclis2[[1," & i + 1 & "]]")
		Next

		'create the expression to pass to Wolfram Mathematica
		tmpString.Length = 0
		'pattern: soci2+
		For i = 0 To Me._usedLocations - 1
			tmpString.Append("soc" & i + 1 & "2+")
		Next

		tmpString.Length -= "+".Length

		Me._MathWrapper.WaitAndDiscardAnswer("socmea2=(" & tmpString.ToString & ")/" & Me._usedLocations)

		'create the expression to pass to Wolfram Mathematica
		tmpString.Length = 0
		'pattern: Abs[soci2-soci2]+
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedLocations - 1
				tmpString.Append("Abs[soc" & i + 1 & "2-soc" & j + 1 & "2]+")
			Next
		Next

		tmpString.Length -= "+".Length

		Me._MathWrapper.WaitAndDiscardAnswer("socgin2=N[(1/2*1/13^2*(1/socmea2))(" & tmpString.ToString & ")]")

		For i = 0 To Me._usedLocations - 1
			Me._MathWrapper.WaitAndDiscardAnswer("env" & i + 1 & "1=envlis1[[1," & i + 1 & "]]")
		Next

		'create the expression to pass to Wolfram Mathematica
		tmpString.Length = 0
		'pattern: envi1+
		For i = 0 To Me._usedLocations - 1
			tmpString.Append("env" & i + 1 & "1+")
		Next

		tmpString.Length -= "+".Length

		Me._MathWrapper.WaitAndDiscardAnswer("envmea1=(" & tmpString.ToString & ")/" & Me._usedLocations)

		'create the expression to pass to Wolfram Mathematica
		tmpString.Length = 0
		'pattern: Abs[envi1-envi1]+
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedLocations - 1
				tmpString.Append("Abs[env" & i + 1 & "1-env" & j + 1 & "1]+")
			Next
		Next

		tmpString.Length -= "+".Length

		Me._MathWrapper.WaitAndDiscardAnswer("envgin1=N[(1/2*1/13^2*(1/envmea1))(" & tmpString.ToString & ")]")

		For i = 0 To Me._usedLocations - 1
			Me._MathWrapper.WaitAndDiscardAnswer("env" & i + 1 & "2=envlis2[[1," & i + 1 & "]]")
		Next

		'create the expression to pass to Wolfram Mathematica
		tmpString.Length = 0
		'pattern: envi2+
		For i = 0 To Me._usedLocations - 1
			tmpString.Append("env" & i + 1 & "2+")
		Next

		tmpString.Length -= "+".Length

		Me._MathWrapper.WaitAndDiscardAnswer("envmea2=(" & tmpString.ToString & ")/" & Me._usedLocations)

		'create the expression to pass to Wolfram Mathematica
		tmpString.Length = 0
		'pattern: Abs[envi2-envi2]+
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedLocations - 1
				tmpString.Append("Abs[env" & i + 1 & "2-env" & j + 1 & "2]+")
			Next
		Next

		tmpString.Length -= "+".Length

		Me._MathWrapper.WaitAndDiscardAnswer("envgin2=N[(1/2*1/13^2*(1/envmea2))(" & tmpString.ToString & ")]")

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

		'create the expression to pass to Wolfram Mathematica
		tmpString.Length = 0
		'pattern: x[i][j] -> xij,
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				tmpString.Append("x[" & i + 1 & "][" & j + 1 & "] -> x" & i + 1 & j + 1 & ", ")
			Next
		Next
		'pattern: y[i][j] -> yij,
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				tmpString.Append("y[" & i + 1 & "][" & j + 1 & "] -> y" & i + 1 & j + 1 & ", ")
			Next
		Next
		'pattern: z[i][j] -> zij,
		For i = 0 To Me._usedLocations - 1
			For j = 0 To Me._usedDimensions - 1
				tmpString.Append("z[" & i + 1 & "][" & j + 1 & "] -> z" & i + 1 & j + 1 & ", ")
			Next
		Next
		tmpString.Length -= ", ".Length

		Me._MathWrapper.WaitAndDiscardAnswer("totobj20 = totobj20 /. {" & tmpString.ToString & "}")

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
		Me.TAData.Fill(Me.DSData.data)

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

				Me.TAData.Update(Me.DSData)
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

		Select Case Me.cboMatemathicaMethod.SelectedIndex
			Case 0
				Me._mathematicaMethod = "Automatic"
			Case 1
				Me._mathematicaMethod = "DifferentialEvolution"
			Case 2
				Me._mathematicaMethod = "NelderMead"
			Case 3
				Me._mathematicaMethod = "RandomSearch"
			Case 4
				Me._mathematicaMethod = "SimulatedAnnealing"
			Case Else
				Me._mathematicaMethod = "Automatic"
		End Select

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
			Me.TAParameters.Fill(Me.DSParameters.parameters)
			'read parameters
			kernelPath = Me.DSParameters.parameters.Rows(0).Item("parKernelPath").ToString
			Me._usedLocations = CInt(Me.DSParameters.parameters.Rows(0).Item("parLocations"))
			Me._usedDimensions = CInt(Me.DSParameters.parameters.Rows(0).Item("parDimensions"))
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
		'refresh table data
		Me.TAParameters.Fill(Me.DSParameters.parameters)
		Me.DALocations.Fill(Me.DSLocations)

		Me.SetLocations(Me)
		Me.AdaptGUIToUsedDimensions()
		Me.SetMapCenter()
	End Sub

	Private Sub SetMapCenter()
		Dim latitude, longitude As Double

		latitude = CInt(Me.DSParameters.Tables("parameters").Rows(0).Item("parMapLatitude"))
		longitude = CInt(Me.DSParameters.Tables("parameters").Rows(0).Item("parMapLongitude"))

		Me.mapControl.SetMapCenter(latitude, longitude)
	End Sub

	Private Sub AdaptGUIToUsedDimensions()
		Dim usedDimensions As Integer

		'if there is only one dimension, hide the unnecessary controls
		usedDimensions = CInt(Me.DSParameters.Tables("parameters").Rows(0).Item("parDimensions"))

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
				usedLocations = CInt(Me.DSParameters.Tables("parameters").Rows(0).Item("parLocations"))

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