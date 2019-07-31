<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParameters
	Inherits System.Windows.Forms.Form

	'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
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
		CType(Me.ParametersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudparLocations, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudparDimensions, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DSParameters, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		Me.OpenFileDialog1.Filter = "Executable files (*.exe)|*.exe|All files|*.*"
		'
		'txtParKernelPath
		'
		Me.txtParKernelPath.Location = New System.Drawing.Point(12, 57)
		Me.txtParKernelPath.Name = "txtParKernelPath"
		Me.txtParKernelPath.Size = New System.Drawing.Size(420, 20)
		Me.txtParKernelPath.TabIndex = 0
		'
		'lblParKernelPath
		'
		Me.lblParKernelPath.AutoSize = True
		Me.lblParKernelPath.Location = New System.Drawing.Point(12, 41)
		Me.lblParKernelPath.Name = "lblParKernelPath"
		Me.lblParKernelPath.Size = New System.Drawing.Size(166, 13)
		Me.lblParKernelPath.TabIndex = 1
		Me.lblParKernelPath.Text = "Wolfram Mathematica kernel path"
		'
		'btnSetPath
		'
		Me.btnSetPath.Location = New System.Drawing.Point(438, 57)
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
		Me.Label2.Location = New System.Drawing.Point(12, 101)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(273, 13)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Wolfram Mathematica Player is freely donwloadable here"
		'
		'LinkLabel1
		'
		Me.LinkLabel1.AutoSize = True
		Me.LinkLabel1.Location = New System.Drawing.Point(12, 117)
		Me.LinkLabel1.Name = "LinkLabel1"
		Me.LinkLabel1.Size = New System.Drawing.Size(271, 13)
		Me.LinkLabel1.TabIndex = 2
		Me.LinkLabel1.TabStop = True
		Me.LinkLabel1.Text = "http://www.wolfram.com/products/player/download.cgi"
		'
		'btnConfirm
		'
		Me.btnConfirm.Location = New System.Drawing.Point(280, 249)
		Me.btnConfirm.Name = "btnConfirm"
		Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
		Me.btnConfirm.TabIndex = 6
		Me.btnConfirm.Text = "Confirm"
		Me.btnConfirm.UseVisualStyleBackColor = True
		'
		'btnCancel
		'
		Me.btnCancel.Location = New System.Drawing.Point(199, 249)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 5
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'nudparLocations
		'
		Me.nudparLocations.Location = New System.Drawing.Point(12, 190)
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
		Me.lblparLocations.Location = New System.Drawing.Point(9, 174)
		Me.lblparLocations.Name = "lblparLocations"
		Me.lblparLocations.Size = New System.Drawing.Size(53, 13)
		Me.lblparLocations.TabIndex = 1
		Me.lblparLocations.Text = "Locations"
		'
		'lblparSizes
		'
		Me.lblparSizes.AutoSize = True
		Me.lblparSizes.Location = New System.Drawing.Point(78, 174)
		Me.lblparSizes.Name = "lblparSizes"
		Me.lblparSizes.Size = New System.Drawing.Size(32, 13)
		Me.lblparSizes.TabIndex = 1
		Me.lblparSizes.Text = "Sizes"
		'
		'nudparDimensions
		'
		Me.nudparDimensions.Location = New System.Drawing.Point(81, 190)
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
		'frmParameters
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(566, 451)
		Me.Controls.Add(Me.nudparDimensions)
		Me.Controls.Add(Me.nudparLocations)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnConfirm)
		Me.Controls.Add(Me.LinkLabel1)
		Me.Controls.Add(Me.btnSetPath)
		Me.Controls.Add(Me.lblparSizes)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.lblparLocations)
		Me.Controls.Add(Me.lblParKernelPath)
		Me.Controls.Add(Me.txtParKernelPath)
		Me.Name = "frmParameters"
		Me.Text = "parameters setting"
		CType(Me.ParametersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudparLocations, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudparDimensions, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DSParameters, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

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
End Class
