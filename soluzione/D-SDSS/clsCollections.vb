#Region " DSSNumericUpDown "

Public Class nudCollection
	Inherits CollectionBase

#Region " Variabili "

	Dim nameList As New ArrayList

#End Region

#Region " Proprietà "

	Default Public Property Item(ByVal index As Integer) As DSSNumericUpDown
		Get
			Return CType(List(index), DSSNumericUpDown)
		End Get
		Set(ByVal Value As DSSNumericUpDown)
			List(index) = Value
		End Set
	End Property

	Default Public Property Item(ByVal name As String) As DSSNumericUpDown
		Get
			name = name.ToLower
			Return CType(List(nameList.IndexOf(name)), DSSNumericUpDown)
		End Get
		Set(ByVal Value As DSSNumericUpDown)
			List(nameList.IndexOf(name.ToLower)) = Value
		End Set
	End Property

#End Region

#Region " Metodi "

	Public Function Add(ByVal value As DSSNumericUpDown) As Integer
		nameList.Add(value.Name.ToLower)
		Return List.Add(value)
	End Function

	Public Function IndexOf(ByVal value As DSSNumericUpDown) As Integer
		Return List.IndexOf(value)
	End Function

	Public Sub Insert(ByVal index As Integer, ByVal value As DSSNumericUpDown)
		Me.Insert(index, value.Name.ToLower, value)
	End Sub

	Public Sub Insert(ByVal index As Integer, ByVal name As String, ByVal value As DSSNumericUpDown)
		nameList.Insert(index, name.ToLower)
		List.Insert(index, value)
	End Sub

	Public Sub Remove(ByVal value As DSSNumericUpDown)
		List.Remove(value)
		value = Nothing
		GC.Collect()
	End Sub

	Public Function Contains(ByVal value As DSSNumericUpDown) As Boolean
		' If value is not of type DSSNumericUpDown, this will return false.
		Return List.Contains(value)
	End Function

	Public Function Contains(ByVal value As String) As Boolean
		' If value is not of type String, this will return false.
		Return nameList.Contains(value.ToLower)
	End Function

	Protected Overrides Sub OnInsert(ByVal index As Integer, ByVal value As [Object])
		If value IsNot Nothing AndAlso Not TypeOf value Is DSSNumericUpDown Then
			Throw New ArgumentException("L'oggetto deve essere di tipo DSSNumericUpDown.", "value")
		End If
	End Sub

	Protected Overrides Sub OnRemove(ByVal index As Integer, ByVal value As [Object])
		If value IsNot Nothing AndAlso Not TypeOf value Is DSSNumericUpDown Then
			Throw New ArgumentException("L'oggetto deve essere di tipo DSSNumericUpDown.", "value")
		End If
	End Sub

	Protected Overrides Sub OnSet(ByVal index As Integer, ByVal oldValue As [Object], ByVal newValue As [Object])
		If newValue IsNot Nothing AndAlso Not TypeOf newValue Is DSSNumericUpDown Then
			Throw New ArgumentException("L'oggetto deve essere di tipo DSSNumericUpDown.", "newValue")
		End If
	End Sub

	Protected Overrides Sub OnValidate(ByVal value As [Object])
		If value IsNot Nothing AndAlso Not TypeOf value Is DSSNumericUpDown Then
			Throw New ArgumentException("L'oggetto deve essere di tipo DSSNumericUpDown.")
		End If
	End Sub

#End Region

End Class

#End Region

#Region " DSSPanel "

Public Class pnlCollection
	Inherits CollectionBase

#Region " Variabili "

	Dim nameList As New ArrayList

#End Region

#Region " Proprietà "

	Default Public Property Item(ByVal index As Integer) As DSSPanel
		Get
			Return CType(List(index), DSSPanel)
		End Get
		Set(ByVal Value As DSSPanel)
			List(index) = Value
		End Set
	End Property

	Default Public Property Item(ByVal name As String) As DSSPanel
		Get
			name = name.ToLower
			Return CType(List(nameList.IndexOf(name)), DSSPanel)
		End Get
		Set(ByVal Value As DSSPanel)
			List(nameList.IndexOf(name.ToLower)) = Value
		End Set
	End Property

#End Region

#Region " Metodi "

	Public Function Add(ByVal value As DSSPanel) As Integer
		nameList.Add(value.Name.ToLower)
		Return List.Add(value)
	End Function

	Public Function IndexOf(ByVal value As DSSPanel) As Integer
		Return List.IndexOf(value)
	End Function

	Public Sub Insert(ByVal index As Integer, ByVal value As DSSPanel)
		Me.Insert(index, value.Name.ToLower, value)
	End Sub

	Public Sub Insert(ByVal index As Integer, ByVal name As String, ByVal value As DSSPanel)
		nameList.Insert(index, name.ToLower)
		List.Insert(index, value)
	End Sub

	Public Sub Remove(ByVal value As DSSPanel)
		List.Remove(value)
		value = Nothing
		GC.Collect()
	End Sub

	Public Function Contains(ByVal value As DSSPanel) As Boolean
		' If value is not of type DSSNumericUpDown, this will return false.
		Return List.Contains(value)
	End Function

	Public Function Contains(ByVal value As String) As Boolean
		' If value is not of type String, this will return false.
		Return nameList.Contains(value.ToLower)
	End Function

	Protected Overrides Sub OnInsert(ByVal index As Integer, ByVal value As [Object])
		If value IsNot Nothing AndAlso Not TypeOf value Is DSSPanel Then
			Throw New ArgumentException("L'oggetto deve essere di tipo DSSPanel.", "value")
		End If
	End Sub

	Protected Overrides Sub OnRemove(ByVal index As Integer, ByVal value As [Object])
		If value IsNot Nothing AndAlso Not TypeOf value Is DSSPanel Then
			Throw New ArgumentException("L'oggetto deve essere di tipo DSSPanel.", "value")
		End If
	End Sub

	Protected Overrides Sub OnSet(ByVal index As Integer, ByVal oldValue As [Object], ByVal newValue As [Object])
		If newValue IsNot Nothing AndAlso Not TypeOf newValue Is DSSPanel Then
			Throw New ArgumentException("L'oggetto deve essere di tipo DSSPanel.", "newValue")
		End If
	End Sub

	Protected Overrides Sub OnValidate(ByVal value As [Object])
		If value IsNot Nothing AndAlso Not TypeOf value Is DSSPanel Then
			Throw New ArgumentException("L'oggetto deve essere di tipo DSSPanel.")
		End If
	End Sub

#End Region

End Class

#End Region

#Region " DSSLabel "

Public Class lblCollection
	Inherits CollectionBase

#Region " Variabili "

	Dim nameList As New ArrayList

#End Region

#Region " Proprietà "

	Default Public Property Item(ByVal index As Integer) As DSSLabel
		Get
			Return CType(List(index), DSSLabel)
		End Get
		Set(ByVal Value As DSSLabel)
			List(index) = Value
		End Set
	End Property

	Default Public Property Item(ByVal name As String) As DSSLabel
		Get
			name = name.ToLower
			Return CType(List(nameList.IndexOf(name)), DSSLabel)
		End Get
		Set(ByVal Value As DSSLabel)
			List(nameList.IndexOf(name.ToLower)) = Value
		End Set
	End Property

#End Region

#Region " Metodi "

	Public Function Add(ByVal value As DSSLabel) As Integer
		nameList.Add(value.Name.ToLower)
		Return List.Add(value)
	End Function

	Public Function IndexOf(ByVal value As DSSLabel) As Integer
		Return List.IndexOf(value)
	End Function

	Public Sub Insert(ByVal index As Integer, ByVal value As DSSLabel)
		Me.Insert(index, value.Name.ToLower, value)
	End Sub

	Public Sub Insert(ByVal index As Integer, ByVal name As String, ByVal value As DSSLabel)
		nameList.Insert(index, name.ToLower)
		List.Insert(index, value)
	End Sub

	Public Sub Remove(ByVal value As DSSLabel)
		List.Remove(value)
		value = Nothing
		GC.Collect()
	End Sub

	Public Function Contains(ByVal value As DSSLabel) As Boolean
		' If value is not of type DSSNumericUpDown, this will return false.
		Return List.Contains(value)
	End Function

	Public Function Contains(ByVal value As String) As Boolean
		' If value is not of type String, this will return false.
		Return nameList.Contains(value.ToLower)
	End Function

	Protected Overrides Sub OnInsert(ByVal index As Integer, ByVal value As [Object])
		If value IsNot Nothing AndAlso Not TypeOf value Is DSSLabel Then
			Throw New ArgumentException("L'oggetto deve essere di tipo DSSLabel.", "value")
		End If
	End Sub

	Protected Overrides Sub OnRemove(ByVal index As Integer, ByVal value As [Object])
		If value IsNot Nothing AndAlso Not TypeOf value Is DSSLabel Then
			Throw New ArgumentException("L'oggetto deve essere di tipo DSSLabel.", "value")
		End If
	End Sub

	Protected Overrides Sub OnSet(ByVal index As Integer, ByVal oldValue As [Object], ByVal newValue As [Object])
		If newValue IsNot Nothing AndAlso Not TypeOf newValue Is DSSLabel Then
			Throw New ArgumentException("L'oggetto deve essere di tipo DSSLabel.", "newValue")
		End If
	End Sub

	Protected Overrides Sub OnValidate(ByVal value As [Object])
		If value IsNot Nothing AndAlso Not TypeOf value Is DSSLabel Then
			Throw New ArgumentException("L'oggetto deve essere di tipo DSSLabel.")
		End If
	End Sub

#End Region

End Class

#End Region

