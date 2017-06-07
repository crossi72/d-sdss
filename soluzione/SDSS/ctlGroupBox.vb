Public Class DSSGroupBox

#Region " Variables "

	Private pnlCollection As New pnlCollection
	Private myDrawOnMap As Boolean = True

#End Region

#Region " Events "

	Public Event DSSInit(sender As Object, e As EventArgs)

#End Region

#Region " Properties "

	Public Property DSSDrawOnMap() As Boolean
		Get
			Return Me.myDrawOnMap
		End Get
		Set(ByVal value As Boolean)
			Me.myDrawOnMap = value
		End Set
	End Property

	Public Property DSSpnlCollection() As pnlCollection
		Get
			Return Me.pnlCollection
		End Get
		Set(ByVal value As pnlCollection)
			Me.pnlCollection = value
		End Set
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

#Region " New "

	Public Sub New()

		' Chiamata richiesta da Progettazione Windows Form.
		InitializeComponent()

		' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
		'Me.firstIteration = True
		Me.Visible = False
	End Sub

#End Region

End Class
