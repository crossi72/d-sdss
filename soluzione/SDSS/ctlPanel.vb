Public Class DSSPanel

#Region " Variables "

	Private nudCollection As New nudCollection
	Private lblCollection As New lblCollection

#End Region

#Region " Events "

	Public Event DSSInit(sender As Object, e As EventArgs)

#End Region

#Region " Properties "

	Public Property DSSnudCollection() As nudCollection
		Get
			Return Me.nudCollection
		End Get
		Set(ByVal value As nudCollection)
			Me.nudCollection = value
		End Set
	End Property

	Public Property DSSlblCollection() As lblCollection
		Get
			Return Me.lblCollection
		End Get
		Set(ByVal value As lblCollection)
			Me.lblCollection = value
		End Set
	End Property

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

	Public Property DSSVisible() As Boolean
		Get
			Return Me.Visible
		End Get
		Set(ByVal value As Boolean)
			Me.Visible = value
			'If value AndAlso Me.firstIteration Then
			If value Then
				'Me.firstIteration = False
				RaiseEvent DSSInit(Me, New System.EventArgs)
			End If
		End Set
	End Property

#End Region

End Class
