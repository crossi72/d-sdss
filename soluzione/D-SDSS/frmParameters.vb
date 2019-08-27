Public Class frmParameters

#Region " Event management "

	Private Sub btnSetPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetPath.Click
		Me.OpenFileDialog1.ShowDialog()

		If Me.OpenFileDialog1.FileName <> "" Then
			Me.txtParKernelPath.Text = Me.OpenFileDialog1.FileName
		End If
	End Sub

	Private Sub frmParameters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Me.TAParameters.Fill(Me.DSParameters.parameters)

		Try
			Me.txtParKernelPath.Text = CStr(Me.DSParameters.Tables(0).Rows(0).Item("parKernelPath"))
			Me.nudparLocations.Value = CInt(Me.DSParameters.Tables(0).Rows(0).Item("parLocations"))
			Me.nudparDimensions.Value = CInt(Me.DSParameters.Tables(0).Rows(0).Item("parDimensions"))
		Catch ex As Exception

		End Try
	End Sub

	Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
		Dim sInfo As New ProcessStartInfo(e.Link.LinkData.ToString())
		Process.Start(sInfo)
	End Sub

	Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
		Dim sqlQuery As String

		'set new value in db
		sqlQuery = "UPDATE parameters" & ControlChars.CrLf
		sqlQuery &= "SET parKernelPath = '" & Me.OpenFileDialog1.FileName & "'" & ControlChars.CrLf
		sqlQuery &= ", parLocations = " & Me.nudparLocations.Value & ControlChars.CrLf
		sqlQuery &= ", parDimensions = " & Me.nudparDimensions.Value

		Utility.ExecuteSQL(sqlQuery, Me.TAParameters.Connection)

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
				Else
					tpa.Controls.Item("txtLocation" & i).Visible = True
					tpa.Controls.Item("lblLocation" & i).Visible = True
				End If
			Next
		Catch ex As Exception

		End Try
	End Sub

#End Region

End Class