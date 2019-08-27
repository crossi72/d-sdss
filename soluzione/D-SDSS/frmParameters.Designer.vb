<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmParameters
	Inherits System.Windows.Forms.Form

	'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Richiesto da Progettazione Windows Form
	Private components As System.ComponentModel.IContainer

	'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
	'Può essere modificata in Progettazione Windows Form.  
	'Non modificarla nell'editor del codice.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.txtParKernelPath = New System.Windows.Forms.TextBox()
		Me.lblParKernelPath = New System.Windows.Forms.Label()
		Me.btnSetPath = New System.Windows.Forms.Button()
		Me.ParametersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.TAParameters = New DSDSS.DSParametersTableAdapters.parametersTableAdapter()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
		Me.btnConfirm = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.nudparLocations = New System.Windows.Forms.NumericUpDown()
		Me.lblparLocations = New System.Windows.Forms.Label()
		Me.lblparSizes = New System.Windows.Forms.Label()
		Me.nudparDimensions = New System.Windows.Forms.NumericUpDown()
		Me.DSParameters = New DSDSS.DSParameters()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.tpaGeneric = New System.Windows.Forms.TabPage()
		Me.tpaLocationNames = New System.Windows.Forms.TabPage()
		Me.txtLocation1 = New System.Windows.Forms.TextBox()
		Me.lbllocation1 = New System.Windows.Forms.Label()
		Me.lbllocation4 = New System.Windows.Forms.Label()
		Me.txtLocation4 = New System.Windows.Forms.TextBox()
		Me.lbllocation3 = New System.Windows.Forms.Label()
		Me.txtLocation3 = New System.Windows.Forms.TextBox()
		Me.lbllocation2 = New System.Windows.Forms.Label()
		Me.txtLocation2 = New System.Windows.Forms.TextBox()
		Me.lbllocation5 = New System.Windows.Forms.Label()
		Me.txtLocation5 = New System.Windows.Forms.TextBox()
		Me.lbllocation10 = New System.Windows.Forms.Label()
		Me.txtLocation10 = New System.Windows.Forms.TextBox()
		Me.lbllocation7 = New System.Windows.Forms.Label()
		Me.txtLocation7 = New System.Windows.Forms.TextBox()
		Me.lbllocation8 = New System.Windows.Forms.Label()
		Me.txtLocation8 = New System.Windows.Forms.TextBox()
		Me.lbllocation9 = New System.Windows.Forms.Label()
		Me.txtLocation9 = New System.Windows.Forms.TextBox()
		Me.lbllocation6 = New System.Windows.Forms.Label()
		Me.txtLocation6 = New System.Windows.Forms.TextBox()
		Me.lbllocation15 = New System.Windows.Forms.Label()
		Me.txtLocation15 = New System.Windows.Forms.TextBox()
		Me.lbllocation12 = New System.Windows.Forms.Label()
		Me.txtLocation12 = New System.Windows.Forms.TextBox()
		Me.lbllocation13 = New System.Windows.Forms.Label()
		Me.txtLocation13 = New System.Windows.Forms.TextBox()
		Me.lbllocation14 = New System.Windows.Forms.Label()
		Me.txtLocation14 = New System.Windows.Forms.TextBox()
		Me.lbllocation11 = New System.Windows.Forms.Label()
		Me.txtLocation11 = New System.Windows.Forms.TextBox()
		Me.TALocations = New DSDSS.DSLocationsTableAdapters.locationsTableAdapter()
		Me.DSLocations = New DSDSS.DSLocations()
		CType(Me.ParametersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudparLocations, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudparDimensions, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DSParameters, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabControl1.SuspendLayout()
		Me.tpaGeneric.SuspendLayout()
		Me.tpaLocationNames.SuspendLayout()
		CType(Me.DSLocations, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		Me.OpenFileDialog1.Filter = "Executable files (*.exe)|*.exe|All files|*.*"
		'
		'txtParKernelPath
		'
		Me.txtParKernelPath.Location = New System.Drawing.Point(24, 43)
		Me.txtParKernelPath.Name = "txtParKernelPath"
		Me.txtParKernelPath.Size = New System.Drawing.Size(420, 20)
		Me.txtParKernelPath.TabIndex = 0
		'
		'lblParKernelPath
		'
		Me.lblParKernelPath.AutoSize = True
		Me.lblParKernelPath.Location = New System.Drawing.Point(24, 27)
		Me.lblParKernelPath.Name = "lblParKernelPath"
		Me.lblParKernelPath.Size = New System.Drawing.Size(166, 13)
		Me.lblParKernelPath.TabIndex = 1
		Me.lblParKernelPath.Text = "Wolfram Mathematica kernel path"
		'
		'btnSetPath
		'
		Me.btnSetPath.Location = New System.Drawing.Point(450, 43)
		Me.btnSetPath.Name = "btnSetPath"
		Me.btnSetPath.Size = New System.Drawing.Size(24, 20)
		Me.btnSetPath.TabIndex = 1
		Me.btnSetPath.Text = "..."
		Me.btnSetPath.UseVisualStyleBackColor = True
		'
		'TAParameters
		'
		Me.TAParameters.ClearBeforeFill = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(24, 87)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(273, 13)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Wolfram Mathematica Player is freely donwloadable here"
		'
		'LinkLabel1
		'
		Me.LinkLabel1.AutoSize = True
		Me.LinkLabel1.Location = New System.Drawing.Point(24, 103)
		Me.LinkLabel1.Name = "LinkLabel1"
		Me.LinkLabel1.Size = New System.Drawing.Size(271, 13)
		Me.LinkLabel1.TabIndex = 2
		Me.LinkLabel1.TabStop = True
		Me.LinkLabel1.Text = "http://www.wolfram.com/products/player/download.cgi"
		'
		'btnConfirm
		'
		Me.btnConfirm.Location = New System.Drawing.Point(259, 389)
		Me.btnConfirm.Name = "btnConfirm"
		Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
		Me.btnConfirm.TabIndex = 6
		Me.btnConfirm.Text = "Confirm"
		Me.btnConfirm.UseVisualStyleBackColor = True
		'
		'btnCancel
		'
		Me.btnCancel.Location = New System.Drawing.Point(178, 389)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 5
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'nudparLocations
		'
		Me.nudparLocations.Location = New System.Drawing.Point(24, 176)
		Me.nudparLocations.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
		Me.nudparLocations.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudparLocations.Name = "nudparLocations"
		Me.nudparLocations.Size = New System.Drawing.Size(50, 20)
		Me.nudparLocations.TabIndex = 3
		Me.nudparLocations.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudparLocations.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'lblparLocations
		'
		Me.lblparLocations.AutoSize = True
		Me.lblparLocations.Location = New System.Drawing.Point(21, 160)
		Me.lblparLocations.Name = "lblparLocations"
		Me.lblparLocations.Size = New System.Drawing.Size(53, 13)
		Me.lblparLocations.TabIndex = 1
		Me.lblparLocations.Text = "Locations"
		'
		'lblparSizes
		'
		Me.lblparSizes.AutoSize = True
		Me.lblparSizes.Location = New System.Drawing.Point(90, 160)
		Me.lblparSizes.Name = "lblparSizes"
		Me.lblparSizes.Size = New System.Drawing.Size(32, 13)
		Me.lblparSizes.TabIndex = 1
		Me.lblparSizes.Text = "Sizes"
		'
		'nudparDimensions
		'
		Me.nudparDimensions.Location = New System.Drawing.Point(93, 176)
		Me.nudparDimensions.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
		Me.nudparDimensions.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudparDimensions.Name = "nudparDimensions"
		Me.nudparDimensions.Size = New System.Drawing.Size(50, 20)
		Me.nudparDimensions.TabIndex = 4
		Me.nudparDimensions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudparDimensions.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'DSParameters
		'
		Me.DSParameters.DataSetName = "DSParameters"
		Me.DSParameters.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.tpaGeneric)
		Me.TabControl1.Controls.Add(Me.tpaLocationNames)
		Me.TabControl1.Location = New System.Drawing.Point(0, 0)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(566, 362)
		Me.TabControl1.TabIndex = 7
		'
		'tpaGeneric
		'
		Me.tpaGeneric.Controls.Add(Me.txtParKernelPath)
		Me.tpaGeneric.Controls.Add(Me.nudparDimensions)
		Me.tpaGeneric.Controls.Add(Me.lblParKernelPath)
		Me.tpaGeneric.Controls.Add(Me.nudparLocations)
		Me.tpaGeneric.Controls.Add(Me.lblparLocations)
		Me.tpaGeneric.Controls.Add(Me.Label2)
		Me.tpaGeneric.Controls.Add(Me.lblparSizes)
		Me.tpaGeneric.Controls.Add(Me.LinkLabel1)
		Me.tpaGeneric.Controls.Add(Me.btnSetPath)
		Me.tpaGeneric.Location = New System.Drawing.Point(4, 22)
		Me.tpaGeneric.Name = "tpaGeneric"
		Me.tpaGeneric.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaGeneric.Size = New System.Drawing.Size(558, 336)
		Me.tpaGeneric.TabIndex = 0
		Me.tpaGeneric.Text = "Basic parameters"
		Me.tpaGeneric.UseVisualStyleBackColor = True
		'
		'tpaLocationNames
		'
		Me.tpaLocationNames.Controls.Add(Me.lbllocation15)
		Me.tpaLocationNames.Controls.Add(Me.txtLocation15)
		Me.tpaLocationNames.Controls.Add(Me.lbllocation12)
		Me.tpaLocationNames.Controls.Add(Me.txtLocation12)
		Me.tpaLocationNames.Controls.Add(Me.lbllocation13)
		Me.tpaLocationNames.Controls.Add(Me.txtLocation13)
		Me.tpaLocationNames.Controls.Add(Me.lbllocation14)
		Me.tpaLocationNames.Controls.Add(Me.txtLocation14)
		Me.tpaLocationNames.Controls.Add(Me.lbllocation11)
		Me.tpaLocationNames.Controls.Add(Me.txtLocation11)
		Me.tpaLocationNames.Controls.Add(Me.lbllocation10)
		Me.tpaLocationNames.Controls.Add(Me.txtLocation10)
		Me.tpaLocationNames.Controls.Add(Me.lbllocation7)
		Me.tpaLocationNames.Controls.Add(Me.txtLocation7)
		Me.tpaLocationNames.Controls.Add(Me.lbllocation8)
		Me.tpaLocationNames.Controls.Add(Me.txtLocation8)
		Me.tpaLocationNames.Controls.Add(Me.lbllocation9)
		Me.tpaLocationNames.Controls.Add(Me.txtLocation9)
		Me.tpaLocationNames.Controls.Add(Me.lbllocation6)
		Me.tpaLocationNames.Controls.Add(Me.txtLocation6)
		Me.tpaLocationNames.Controls.Add(Me.lbllocation5)
		Me.tpaLocationNames.Controls.Add(Me.txtLocation5)
		Me.tpaLocationNames.Controls.Add(Me.lbllocation2)
		Me.tpaLocationNames.Controls.Add(Me.txtLocation2)
		Me.tpaLocationNames.Controls.Add(Me.lbllocation3)
		Me.tpaLocationNames.Controls.Add(Me.txtLocation3)
		Me.tpaLocationNames.Controls.Add(Me.lbllocation4)
		Me.tpaLocationNames.Controls.Add(Me.txtLocation4)
		Me.tpaLocationNames.Controls.Add(Me.lbllocation1)
		Me.tpaLocationNames.Controls.Add(Me.txtLocation1)
		Me.tpaLocationNames.Location = New System.Drawing.Point(4, 22)
		Me.tpaLocationNames.Name = "tpaLocationNames"
		Me.tpaLocationNames.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaLocationNames.Size = New System.Drawing.Size(558, 336)
		Me.tpaLocationNames.TabIndex = 1
		Me.tpaLocationNames.Text = "Location names"
		Me.tpaLocationNames.UseVisualStyleBackColor = True
		'
		'txtLocation1
		'
		Me.txtLocation1.Location = New System.Drawing.Point(103, 29)
		Me.txtLocation1.Name = "txtLocation1"
		Me.txtLocation1.Size = New System.Drawing.Size(146, 20)
		Me.txtLocation1.TabIndex = 0
		'
		'lbllocation1
		'
		Me.lbllocation1.AutoSize = True
		Me.lbllocation1.Location = New System.Drawing.Point(12, 29)
		Me.lbllocation1.Name = "lbllocation1"
		Me.lbllocation1.Size = New System.Drawing.Size(57, 13)
		Me.lbllocation1.TabIndex = 1
		Me.lbllocation1.Text = "Location 1"
		'
		'lbllocation4
		'
		Me.lbllocation4.AutoSize = True
		Me.lbllocation4.Location = New System.Drawing.Point(12, 107)
		Me.lbllocation4.Name = "lbllocation4"
		Me.lbllocation4.Size = New System.Drawing.Size(57, 13)
		Me.lbllocation4.TabIndex = 3
		Me.lbllocation4.Text = "Location 4"
		'
		'txtLocation4
		'
		Me.txtLocation4.Location = New System.Drawing.Point(103, 107)
		Me.txtLocation4.Name = "txtLocation4"
		Me.txtLocation4.Size = New System.Drawing.Size(146, 20)
		Me.txtLocation4.TabIndex = 3
		'
		'lbllocation3
		'
		Me.lbllocation3.AutoSize = True
		Me.lbllocation3.Location = New System.Drawing.Point(12, 81)
		Me.lbllocation3.Name = "lbllocation3"
		Me.lbllocation3.Size = New System.Drawing.Size(57, 13)
		Me.lbllocation3.TabIndex = 5
		Me.lbllocation3.Text = "Location 3"
		'
		'txtLocation3
		'
		Me.txtLocation3.Location = New System.Drawing.Point(103, 81)
		Me.txtLocation3.Name = "txtLocation3"
		Me.txtLocation3.Size = New System.Drawing.Size(146, 20)
		Me.txtLocation3.TabIndex = 2
		'
		'lbllocation2
		'
		Me.lbllocation2.AutoSize = True
		Me.lbllocation2.Location = New System.Drawing.Point(12, 55)
		Me.lbllocation2.Name = "lbllocation2"
		Me.lbllocation2.Size = New System.Drawing.Size(57, 13)
		Me.lbllocation2.TabIndex = 7
		Me.lbllocation2.Text = "Location 2"
		'
		'txtLocation2
		'
		Me.txtLocation2.Location = New System.Drawing.Point(103, 55)
		Me.txtLocation2.Name = "txtLocation2"
		Me.txtLocation2.Size = New System.Drawing.Size(146, 20)
		Me.txtLocation2.TabIndex = 1
		'
		'lbllocation5
		'
		Me.lbllocation5.AutoSize = True
		Me.lbllocation5.Location = New System.Drawing.Point(12, 133)
		Me.lbllocation5.Name = "lbllocation5"
		Me.lbllocation5.Size = New System.Drawing.Size(57, 13)
		Me.lbllocation5.TabIndex = 9
		Me.lbllocation5.Text = "Location 5"
		'
		'txtLocation5
		'
		Me.txtLocation5.Location = New System.Drawing.Point(103, 133)
		Me.txtLocation5.Name = "txtLocation5"
		Me.txtLocation5.Size = New System.Drawing.Size(146, 20)
		Me.txtLocation5.TabIndex = 4
		'
		'lbllocation10
		'
		Me.lbllocation10.AutoSize = True
		Me.lbllocation10.Location = New System.Drawing.Point(12, 263)
		Me.lbllocation10.Name = "lbllocation10"
		Me.lbllocation10.Size = New System.Drawing.Size(63, 13)
		Me.lbllocation10.TabIndex = 19
		Me.lbllocation10.Text = "Location 10"
		'
		'txtLocation10
		'
		Me.txtLocation10.Location = New System.Drawing.Point(103, 263)
		Me.txtLocation10.Name = "txtLocation10"
		Me.txtLocation10.Size = New System.Drawing.Size(146, 20)
		Me.txtLocation10.TabIndex = 9
		'
		'lbllocation7
		'
		Me.lbllocation7.AutoSize = True
		Me.lbllocation7.Location = New System.Drawing.Point(12, 185)
		Me.lbllocation7.Name = "lbllocation7"
		Me.lbllocation7.Size = New System.Drawing.Size(57, 13)
		Me.lbllocation7.TabIndex = 17
		Me.lbllocation7.Text = "Location 7"
		'
		'txtLocation7
		'
		Me.txtLocation7.Location = New System.Drawing.Point(103, 185)
		Me.txtLocation7.Name = "txtLocation7"
		Me.txtLocation7.Size = New System.Drawing.Size(146, 20)
		Me.txtLocation7.TabIndex = 6
		'
		'lbllocation8
		'
		Me.lbllocation8.AutoSize = True
		Me.lbllocation8.Location = New System.Drawing.Point(12, 211)
		Me.lbllocation8.Name = "lbllocation8"
		Me.lbllocation8.Size = New System.Drawing.Size(57, 13)
		Me.lbllocation8.TabIndex = 15
		Me.lbllocation8.Text = "Location 8"
		'
		'txtLocation8
		'
		Me.txtLocation8.Location = New System.Drawing.Point(103, 211)
		Me.txtLocation8.Name = "txtLocation8"
		Me.txtLocation8.Size = New System.Drawing.Size(146, 20)
		Me.txtLocation8.TabIndex = 7
		'
		'lbllocation9
		'
		Me.lbllocation9.AutoSize = True
		Me.lbllocation9.Location = New System.Drawing.Point(12, 237)
		Me.lbllocation9.Name = "lbllocation9"
		Me.lbllocation9.Size = New System.Drawing.Size(57, 13)
		Me.lbllocation9.TabIndex = 13
		Me.lbllocation9.Text = "Location 9"
		'
		'txtLocation9
		'
		Me.txtLocation9.Location = New System.Drawing.Point(103, 237)
		Me.txtLocation9.Name = "txtLocation9"
		Me.txtLocation9.Size = New System.Drawing.Size(146, 20)
		Me.txtLocation9.TabIndex = 8
		'
		'lbllocation6
		'
		Me.lbllocation6.AutoSize = True
		Me.lbllocation6.Location = New System.Drawing.Point(12, 159)
		Me.lbllocation6.Name = "lbllocation6"
		Me.lbllocation6.Size = New System.Drawing.Size(57, 13)
		Me.lbllocation6.TabIndex = 11
		Me.lbllocation6.Text = "Location 6"
		'
		'txtLocation6
		'
		Me.txtLocation6.Location = New System.Drawing.Point(103, 159)
		Me.txtLocation6.Name = "txtLocation6"
		Me.txtLocation6.Size = New System.Drawing.Size(146, 20)
		Me.txtLocation6.TabIndex = 5
		'
		'lbllocation15
		'
		Me.lbllocation15.AutoSize = True
		Me.lbllocation15.Location = New System.Drawing.Point(277, 133)
		Me.lbllocation15.Name = "lbllocation15"
		Me.lbllocation15.Size = New System.Drawing.Size(63, 13)
		Me.lbllocation15.TabIndex = 29
		Me.lbllocation15.Text = "Location 15"
		'
		'txtLocation15
		'
		Me.txtLocation15.Location = New System.Drawing.Point(368, 133)
		Me.txtLocation15.Name = "txtLocation15"
		Me.txtLocation15.Size = New System.Drawing.Size(146, 20)
		Me.txtLocation15.TabIndex = 14
		'
		'lbllocation12
		'
		Me.lbllocation12.AutoSize = True
		Me.lbllocation12.Location = New System.Drawing.Point(277, 55)
		Me.lbllocation12.Name = "lbllocation12"
		Me.lbllocation12.Size = New System.Drawing.Size(63, 13)
		Me.lbllocation12.TabIndex = 27
		Me.lbllocation12.Text = "Location 12"
		'
		'txtLocation12
		'
		Me.txtLocation12.Location = New System.Drawing.Point(368, 55)
		Me.txtLocation12.Name = "txtLocation12"
		Me.txtLocation12.Size = New System.Drawing.Size(146, 20)
		Me.txtLocation12.TabIndex = 11
		'
		'lbllocation13
		'
		Me.lbllocation13.AutoSize = True
		Me.lbllocation13.Location = New System.Drawing.Point(277, 81)
		Me.lbllocation13.Name = "lbllocation13"
		Me.lbllocation13.Size = New System.Drawing.Size(63, 13)
		Me.lbllocation13.TabIndex = 25
		Me.lbllocation13.Text = "Location 13"
		'
		'txtLocation13
		'
		Me.txtLocation13.Location = New System.Drawing.Point(368, 81)
		Me.txtLocation13.Name = "txtLocation13"
		Me.txtLocation13.Size = New System.Drawing.Size(146, 20)
		Me.txtLocation13.TabIndex = 12
		'
		'lbllocation14
		'
		Me.lbllocation14.AutoSize = True
		Me.lbllocation14.Location = New System.Drawing.Point(277, 107)
		Me.lbllocation14.Name = "lbllocation14"
		Me.lbllocation14.Size = New System.Drawing.Size(63, 13)
		Me.lbllocation14.TabIndex = 23
		Me.lbllocation14.Text = "Location 14"
		'
		'txtLocation14
		'
		Me.txtLocation14.Location = New System.Drawing.Point(368, 107)
		Me.txtLocation14.Name = "txtLocation14"
		Me.txtLocation14.Size = New System.Drawing.Size(146, 20)
		Me.txtLocation14.TabIndex = 13
		'
		'lbllocation11
		'
		Me.lbllocation11.AutoSize = True
		Me.lbllocation11.Location = New System.Drawing.Point(277, 29)
		Me.lbllocation11.Name = "lbllocation11"
		Me.lbllocation11.Size = New System.Drawing.Size(63, 13)
		Me.lbllocation11.TabIndex = 21
		Me.lbllocation11.Text = "Location 11"
		'
		'txtLocation11
		'
		Me.txtLocation11.Location = New System.Drawing.Point(368, 29)
		Me.txtLocation11.Name = "txtLocation11"
		Me.txtLocation11.Size = New System.Drawing.Size(146, 20)
		Me.txtLocation11.TabIndex = 10
		'
		'TALocations
		'
		Me.TALocations.ClearBeforeFill = True
		'
		'DSLocations
		'
		Me.DSLocations.DataSetName = "DSLocations"
		Me.DSLocations.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'frmParameters
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(566, 451)
		Me.Controls.Add(Me.TabControl1)
		Me.Controls.Add(Me.btnConfirm)
		Me.Controls.Add(Me.btnCancel)
		Me.Name = "frmParameters"
		Me.Text = "parameters setting"
		CType(Me.ParametersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudparLocations, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudparDimensions, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DSParameters, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabControl1.ResumeLayout(False)
		Me.tpaGeneric.ResumeLayout(False)
		Me.tpaGeneric.PerformLayout()
		Me.tpaLocationNames.ResumeLayout(False)
		Me.tpaLocationNames.PerformLayout()
		CType(Me.DSLocations, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
	Friend WithEvents txtParKernelPath As System.Windows.Forms.TextBox
	Friend WithEvents lblParKernelPath As System.Windows.Forms.Label
	Friend WithEvents btnSetPath As System.Windows.Forms.Button
	Friend WithEvents ParametersBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents TAParameters As DSParametersTableAdapters.parametersTableAdapter
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
	Friend WithEvents btnConfirm As System.Windows.Forms.Button
	Friend WithEvents btnCancel As System.Windows.Forms.Button
	Friend WithEvents nudparLocations As NumericUpDown
	Friend WithEvents lblparLocations As Label
	Friend WithEvents lblparSizes As Label
	Friend WithEvents nudparDimensions As NumericUpDown
	Friend WithEvents DSParameters As DSParameters
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents tpaGeneric As TabPage
	Friend WithEvents tpaLocationNames As TabPage
	Friend WithEvents lbllocation15 As Label
	Friend WithEvents txtLocation15 As TextBox
	Friend WithEvents lbllocation12 As Label
	Friend WithEvents txtLocation12 As TextBox
	Friend WithEvents lbllocation13 As Label
	Friend WithEvents txtLocation13 As TextBox
	Friend WithEvents lbllocation14 As Label
	Friend WithEvents txtLocation14 As TextBox
	Friend WithEvents lbllocation11 As Label
	Friend WithEvents txtLocation11 As TextBox
	Friend WithEvents lbllocation10 As Label
	Friend WithEvents txtLocation10 As TextBox
	Friend WithEvents lbllocation7 As Label
	Friend WithEvents txtLocation7 As TextBox
	Friend WithEvents lbllocation8 As Label
	Friend WithEvents txtLocation8 As TextBox
	Friend WithEvents lbllocation9 As Label
	Friend WithEvents txtLocation9 As TextBox
	Friend WithEvents lbllocation6 As Label
	Friend WithEvents txtLocation6 As TextBox
	Friend WithEvents lbllocation5 As Label
	Friend WithEvents txtLocation5 As TextBox
	Friend WithEvents lbllocation2 As Label
	Friend WithEvents txtLocation2 As TextBox
	Friend WithEvents lbllocation3 As Label
	Friend WithEvents txtLocation3 As TextBox
	Friend WithEvents lbllocation4 As Label
	Friend WithEvents txtLocation4 As TextBox
	Friend WithEvents lbllocation1 As Label
	Friend WithEvents txtLocation1 As TextBox
	Friend WithEvents TALocations As DSLocationsTableAdapters.locationsTableAdapter
	Friend WithEvents DSLocations As DSLocations
End Class
