Public Class DSSPanel

#Region " Variables "

	Private nudCollection As New nudCollection
	Private lblCollection As New lblCollection

#End Region

#Region " Events "

	Public Event DSSInit(sender As Object, e As EventArgs)

#End Region

#Region " Properties "

	''' <summary>
	''' Collection of inner DSS NumericUpDown
	''' </summary>
	''' <returns></returns>
	Public Property DSSnudCollection() As nudCollection
		Get
			Return Me.nudCollection
		End Get
		Set(ByVal value As nudCollection)
			Me.nudCollection = value
		End Set
	End Property

	''' <summary>
	''' Collection of inner DSS label
	''' </summary>
	''' <returns></returns>
	Public Property DSSlblCollection() As lblCollection
		Get
			Return Me.lblCollection
		End Get
		Set(ByVal value As lblCollection)
			Me.lblCollection = value
		End Set
	End Property

	''' <summary>
	''' Contains average value calculated on inner DSS controls
	''' </summary>
	''' <returns></returns>
	Public ReadOnly Property DSSAverageValue() As Double
		Get
			Dim tmpNumericUpDown As DSSNumericUpDown
			Dim tmpLabel As DSSLabel
			Dim avgValue, numValues As Double

			For Each tmpNumericUpDown In Me.DSSnudCollection
				avgValue += tmpNumericUpDown.Value
				numValues += 1
			Next
			For Each tmpLabel In Me.DSSlblCollection
				avgValue += tmpLabel.DSSValue
				numValues += 1
			Next
			avgValue /= numValues

			Return avgValue
		End Get
	End Property

	''' <summary>
	''' Toggle control visibility, if control become visible raises DSSInit event
	''' </summary>
	''' <returns></returns>
	<System.ComponentModel.Category("RuntimeDisplay"), System.ComponentModel.Description("Toggle control visibility, if control become visible raises DSSInit event")>
	<System.ComponentModel.DefaultValue(True)>
	Public Property DSSVisible() As Boolean
		Get
			Return Me.Visible
		End Get
		Set(ByVal value As Boolean)
			value = True
			Me.Visible = value
			'when control become visible raises DSSInit event (will cause map update)
			'debug
			If value Then
				RaiseEvent DSSInit(Me, New System.EventArgs)
			End If
		End Set
	End Property

#End Region

End Class
