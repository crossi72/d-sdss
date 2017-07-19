Public Class DSSGroupBox

#Region " Variables "

	Private pnlCollection As New pnlCollection
	Private myDrawOnMap As Boolean = True

#End Region

#Region " Events "

	Public Event DSSInit(sender As Object, e As EventArgs)

#End Region

#Region " Properties "

	''' <summary>
	''' Define if control triggers map redraw on DSSInit
	''' </summary>
	''' <returns></returns>
	<System.ComponentModel.Category("RuntimeDisplay"), System.ComponentModel.Description("Define if control triggers map redraw on DSSInit")>
	<System.ComponentModel.DefaultValue(True)>
	Public Property DSSDrawOnMap() As Boolean
		Get
			Return Me.myDrawOnMap
		End Get
		Set(ByVal value As Boolean)
			Me.myDrawOnMap = value
		End Set
	End Property

	''' <summary>
	''' Collection of inner DSS Panels
	''' </summary>
	''' <returns></returns>

	Public Property DSSpnlCollection() As pnlCollection
		Get
			Return Me.pnlCollection
		End Get
		Set(ByVal value As pnlCollection)
			Me.pnlCollection = value
		End Set
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
			Me.Visible = value
			'when control become visible raises DSSInit event (will cause map update)
			If value Then
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
