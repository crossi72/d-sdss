Module Utility

	''' <summary>
	''' convert an Object to a Integer, if Object is nothing returns 0
	''' </summary>
	''' <param name="var">Object to convert</param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function NullToInteger(ByVal var As Object) As Integer
		Dim ret As Integer

		If var Is Nothing OrElse IsDBNull(var) Then
			ret = 0
		Else
			ret = CType(var, Integer)
		End If

		Return ret
	End Function

	''' <summary>
	''' convert an Object to a Double, if Object is nothing returns 0
	''' </summary>
	''' <param name="var">Object to convert</param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function NullToDouble(ByVal var As Object) As Double
		Dim ret As Double

		If var Is Nothing OrElse IsDBNull(var) Then
			ret = 0
		Else
			ret = CType(var, Double)
		End If

		Return ret
	End Function

	''' <summary>
	''' convert a double to corresponding string
	''' </summary>
	''' <param name="value"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function NumberAsString(ByVal value As Double) As String
		Return value.ToString.Replace(","c, "."c)
	End Function

	''' <summary>
	''' Execute a SQL command
	''' </summary>
	''' <param name="sqlString">SQL command</param>
	''' <param name="sqlConnection">SQL Server connection</param>
	''' <returns>number of record affected, -1 in case of error</returns>
	''' <remarks></remarks>
	Public Function ExecuteSQL(ByVal sqlString As String, ByVal sqlConnection As System.Data.SqlClient.SqlConnection) As Integer
		Dim cmd As System.Data.SqlClient.SqlCommand
		Dim ret As Integer = -1
		Dim connectionAlreadyOpen As Boolean = False

		Try
			Try
				If sqlConnection.State = ConnectionState.Closed Then
					sqlConnection.Open()
				Else
					connectionAlreadyOpen = True
				End If
			Catch ex1 As Exception
			End Try

			sqlString = "SET DATEFORMAT dmy;" & sqlString
			Try
				cmd = New SqlClient.SqlCommand(sqlString, sqlConnection)
				ret = cmd.ExecuteNonQuery()
			Catch ex2 As Exception
				ret = -1
			End Try
		Catch ex As Exception
			ret = -1
		Finally
			If Not connectionAlreadyOpen Then
				sqlConnection.Close()
			End If
		End Try

		Return ret
	End Function

End Module
