Public Class DSSLabel
	Inherits System.Windows.Forms.Label

#Region " Variables "

	Private myElementName As String
	Private myElementColor As System.Windows.Media.Color
	Private myLocation As Integer
	Private myOffset As Double

#End Region

#Region " Properties "

	Public Property DSSOffset() As Double
		Get
			Return Me.myOffset
		End Get
		Set(ByVal value As Double)
			Me.myOffset = value
		End Set
	End Property

	Public Property DSSLocation() As Integer
		Get
			Return Me.myLocation
		End Get
		Set(ByVal value As Integer)
			Me.myLocation = value
		End Set
	End Property

	Public Property DSSElementName() As String
		Get
			Return Me.myElementName
		End Get
		Set(ByVal value As String)
			Me.myElementName = value
		End Set
	End Property


	Public Property DSSElementColor() As System.Windows.Media.Color
		Get
			Return Me.myElementColor
		End Get
		Set(ByVal value As System.Windows.Media.Color)
			Me.myElementColor = value
		End Set
	End Property

#End Region

End Class
