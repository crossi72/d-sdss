Public Class frmParameters

#Region " Event management "

	Private Sub btnSetPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetPath.Click
		Me.OpenFileDialog.ShowDialog()

		If Me.OpenFileDialog.FileName <> "" Then
			Me.txtParKernelPath.Text = Me.OpenFileDialog.FileName
		End If
	End Sub

	Private Sub frmParameters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Me.LoadData()
	End Sub

	Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
		Dim sInfo As New ProcessStartInfo(e.Link.LinkData.ToString())
		Process.Start(sInfo)
	End Sub

	Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
		Me.SaveData()

		Me.Close()
	End Sub

	Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
		Me.Close()
	End Sub

	Private Sub NudparLocations_ValueChanged(sender As Object, e As EventArgs) Handles nudparLocations.ValueChanged
		If Me.IsHandleCreated Then
			Me.SetLocationsVisibility()
		End If
	End Sub

#End Region

#Region " Private methods "

	Private Sub LoadData()
		Dim i As Integer
		Dim tpa As TabPage

		Me.TAParameters.Fill(Me.DSParameters.parameters)

		Try
			Me.txtParKernelPath.Text = CStr(Me.DSParameters.Tables(0).Rows(0).Item("parKernelPath"))
			Me.nudparLocations.Value = CInt(Me.DSParameters.Tables(0).Rows(0).Item("parLocations"))
			Me.nudparDimensions.Value = CInt(Me.DSParameters.Tables(0).Rows(0).Item("parDimensions"))
		Catch ex As Exception

		End Try

		Me.TALocations.Fill(Me.DSLocations.locations)

		Try
			'get controls container
			tpa = DirectCast(Me.Controls.Item("TabControl1"), TabControl).TabPages(1)

			For i = 1 To 15
				DirectCast(tpa.Controls.Item("txtLocation" & i), TextBox).Text = CStr(Me.DSLocations.Tables(0).Rows(i - 1).Item("locName"))
				DirectCast(tpa.Controls.Item("nudLatitude" & i), NumericUpDown).Value = CDec(Me.DSLocations.Tables(0).Rows(i - 1).Item("locLatitude"))
				DirectCast(tpa.Controls.Item("nudLongitude" & i), NumericUpDown).Value = CDec(Me.DSLocations.Tables(0).Rows(i - 1).Item("locLongitude"))
			Next
		Catch ex As Exception

		End Try
	End Sub

	''' <summary>
	''' Save data to database
	''' </summary>
	Private Sub SaveData()
		Dim i As Integer
		Dim tpa As TabPage
		Dim sqlQuery As New Text.StringBuilder

		'set new value for parameters in db
		sqlQuery.Length = 0

		sqlQuery.AppendLine("UPDATE parameters")
		sqlQuery.AppendLine("SET parKernelPath = '" & Me.txtParKernelPath.Text & "'")
		sqlQuery.AppendLine(", parLocations = " & Me.nudparLocations.Value)
		sqlQuery.Append(", parDimensions = " & Me.nudparDimensions.Value)

		Utility.ExecuteSQL(sqlQuery.ToString, Me.TAParameters.Connection)

		'set new value for locations in db

		Try
			'get controls container
			tpa = DirectCast(Me.Controls.Item("TabControl1"), TabControl).TabPages(1)

			'set visibility for each control
			For i = 1 To 15
				If Me.nudparLocations.Value < i Then
					'don't save data for unused locations
				Else
					sqlQuery.Length = 0

					sqlQuery.AppendLine("UPDATE locations")
					sqlQuery.AppendLine("SET locName = '" & tpa.Controls.Item("txtLocation" & i).Text & "'")
					sqlQuery.AppendLine(", locLatitude = '" & tpa.Controls.Item("nudLatitude" & i).Text & "'")
					sqlQuery.AppendLine(", locLongitude = '" & tpa.Controls.Item("nudLongitude" & i).Text & "'")
					sqlQuery.Append("WHERE locID = " & i)

					Utility.ExecuteSQL(sqlQuery.ToString, Me.TAParameters.Connection)
				End If
			Next
		Catch ex As Exception

		End Try
	End Sub

	''' <summary>
	''' Hide or show location controls according to Locations value
	''' </summary>
	Private Sub SetLocationsVisibility()
		Dim i As Integer
		Dim tpa As TabPage

		Try
			'get controls container
			tpa = DirectCast(Me.Controls.Item("TabControl1"), TabControl).TabPages(1)

			'set visibility for each control
			For i = 1 To 15
				If Me.nudparLocations.Value < i Then
					tpa.Controls.Item("txtLocation" & i).Visible = False
					tpa.Controls.Item("lblLocation" & i).Visible = False
					tpa.Controls.Item("nudLatitude" & i).Visible = False
					tpa.Controls.Item("nudLongitude" & i).Visible = False
				Else
					tpa.Controls.Item("txtLocation" & i).Visible = True
					tpa.Controls.Item("lblLocation" & i).Visible = True
					tpa.Controls.Item("nudLatitude" & i).Visible = True
					tpa.Controls.Item("nudLongitude" & i).Visible = True
				End If
			Next
		Catch ex As Exception

		End Try
	End Sub

#End Region

End Class