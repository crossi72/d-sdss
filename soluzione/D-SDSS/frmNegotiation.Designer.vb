<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNegotiation
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
	'<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.SqlConnection = New System.Data.SqlClient.SqlConnection()
		Me.btnNext = New System.Windows.Forms.Button()
		Me.btnPrev = New System.Windows.Forms.Button()
		Me.btnLoadData = New System.Windows.Forms.Button()
		Me.DSParameters = New DSDSS.DSParameters()
		Me.TAParameters = New DSDSS.DSParametersTableAdapters.parametersTableAdapter()
		Me.DALocations = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
		Me.DSLocations = New DSDSS.DSLocations()
		Me.pnlMain = New System.Windows.Forms.Panel()
		Me.SplitContainer = New System.Windows.Forms.SplitContainer()
		Me.grbMisc = New DSDSS.DSSGroupBox()
		Me.DssPanel1 = New DSDSS.DSSPanel()
		Me.Agr = New System.Windows.Forms.Label()
		Me.Lan = New System.Windows.Forms.Label()
		Me.Ind = New System.Windows.Forms.Label()
		Me.nudAgrw = New DSDSS.DSSNumericUpDown()
		Me.nudLanw = New DSDSS.DSSNumericUpDown()
		Me.nudIndw = New DSDSS.DSSNumericUpDown()
		Me.chkSalt = New System.Windows.Forms.CheckBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.lblBOD = New DSDSS.DSSLabel()
		Me.Label92 = New System.Windows.Forms.Label()
		Me.Label28 = New System.Windows.Forms.Label()
		Me.Label30 = New System.Windows.Forms.Label()
		Me.Label64 = New System.Windows.Forms.Label()
		Me.Label70 = New System.Windows.Forms.Label()
		Me.Label116 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label26 = New System.Windows.Forms.Label()
		Me.nudTpsx = New DSDSS.DSSNumericUpDown()
		Me.Label68 = New System.Windows.Forms.Label()
		Me.nudTpmz = New DSDSS.DSSNumericUpDown()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.nudAgrUFRO = New DSDSS.DSSNumericUpDown()
		Me.Label29 = New System.Windows.Forms.Label()
		Me.nudEnvw = New DSDSS.DSSNumericUpDown()
		Me.lblTDS = New DSDSS.DSSLabel()
		Me.nudgwsp = New DSDSS.DSSNumericUpDown()
		Me.nudTotpla = New DSDSS.DSSNumericUpDown()
		Me.nudIndUFRO = New DSDSS.DSSNumericUpDown()
		Me.nudSocw = New DSDSS.DSSNumericUpDown()
		Me.nudTpbx = New DSDSS.DSSNumericUpDown()
		Me.nudEcow = New DSDSS.DSSNumericUpDown()
		Me.nudsmqi = New DSDSS.DSSNumericUpDown()
		Me.nudLanUFRO = New DSDSS.DSSNumericUpDown()
		Me.nudsbqi = New DSDSS.DSSNumericUpDown()
		Me.nudLanUF = New DSDSS.DSSNumericUpDown()
		Me.nudssqi = New DSDSS.DSSNumericUpDown()
		Me.nudAgrUF = New DSDSS.DSSNumericUpDown()
		Me.nudIndUF = New DSDSS.DSSNumericUpDown()
		Me.Label25 = New System.Windows.Forms.Label()
		Me.Label119 = New System.Windows.Forms.Label()
		Me.Label34 = New System.Windows.Forms.Label()
		Me.Label27 = New System.Windows.Forms.Label()
		Me.Label23 = New System.Windows.Forms.Label()
		Me.Label118 = New System.Windows.Forms.Label()
		Me.Label78 = New System.Windows.Forms.Label()
		Me.Label117 = New System.Windows.Forms.Label()
		Me.Label91 = New System.Windows.Forms.Label()
		Me.grbWaterCosts = New DSDSS.DSSGroupBox()
		Me.lblWCLocation15 = New DSDSS.DSSLabel()
		Me.lblWCLocation14 = New DSDSS.DSSLabel()
		Me.lblWCLocation12 = New DSDSS.DSSLabel()
		Me.lblWCLocation11 = New DSDSS.DSSLabel()
		Me.lblWCLocation10 = New DSDSS.DSSLabel()
		Me.lblWCLocation9 = New DSDSS.DSSLabel()
		Me.lblWCLocation8 = New DSDSS.DSSLabel()
		Me.lblWCLocation7 = New DSDSS.DSSLabel()
		Me.lblWCLocation6 = New DSDSS.DSSLabel()
		Me.lblWCLocation5 = New DSDSS.DSSLabel()
		Me.lblWCLocation4 = New DSDSS.DSSLabel()
		Me.lblWCLocation3 = New DSDSS.DSSLabel()
		Me.lblWCLocation2 = New DSDSS.DSSLabel()
		Me.lblWCLocation1 = New DSDSS.DSSLabel()
		Me.lblWCLocation13 = New DSDSS.DSSLabel()
		Me.pnlGro = New DSDSS.DSSPanel()
		Me.nudGro14 = New DSDSS.DSSNumericUpDown()
		Me.nudGro15 = New DSDSS.DSSNumericUpDown()
		Me.Label121 = New System.Windows.Forms.Label()
		Me.nudGro3 = New DSDSS.DSSNumericUpDown()
		Me.nudGro7 = New DSDSS.DSSNumericUpDown()
		Me.nudGro2 = New DSDSS.DSSNumericUpDown()
		Me.nudGro12 = New DSDSS.DSSNumericUpDown()
		Me.nudGro10 = New DSDSS.DSSNumericUpDown()
		Me.nudGro13 = New DSDSS.DSSNumericUpDown()
		Me.nudGro6 = New DSDSS.DSSNumericUpDown()
		Me.nudGro8 = New DSDSS.DSSNumericUpDown()
		Me.nudGro1 = New DSDSS.DSSNumericUpDown()
		Me.nudGro4 = New DSDSS.DSSNumericUpDown()
		Me.nudGro9 = New DSDSS.DSSNumericUpDown()
		Me.nudGro11 = New DSDSS.DSSNumericUpDown()
		Me.nudGro5 = New DSDSS.DSSNumericUpDown()
		Me.pnlDes = New DSDSS.DSSPanel()
		Me.nudDes14 = New DSDSS.DSSNumericUpDown()
		Me.nudDes15 = New DSDSS.DSSNumericUpDown()
		Me.Label120 = New System.Windows.Forms.Label()
		Me.nudDes3 = New DSDSS.DSSNumericUpDown()
		Me.nudDes7 = New DSDSS.DSSNumericUpDown()
		Me.nudDes2 = New DSDSS.DSSNumericUpDown()
		Me.nudDes6 = New DSDSS.DSSNumericUpDown()
		Me.nudDes12 = New DSDSS.DSSNumericUpDown()
		Me.nudDes1 = New DSDSS.DSSNumericUpDown()
		Me.nudDes9 = New DSDSS.DSSNumericUpDown()
		Me.nudDes13 = New DSDSS.DSSNumericUpDown()
		Me.nudDes10 = New DSDSS.DSSNumericUpDown()
		Me.nudDes11 = New DSDSS.DSSNumericUpDown()
		Me.nudDes8 = New DSDSS.DSSNumericUpDown()
		Me.nudDes5 = New DSDSS.DSSNumericUpDown()
		Me.nudDes4 = New DSDSS.DSSNumericUpDown()
		Me.grbOuput = New DSDSS.DSSGroupBox()
		Me.tcoOutput = New System.Windows.Forms.TabControl()
		Me.tpaUses = New System.Windows.Forms.TabPage()
		Me.gboOutputUses = New DSDSS.DSSGroupBox()
		Me.lblUSLocation15 = New DSDSS.DSSLabel()
		Me.lblUSLocation14 = New DSDSS.DSSLabel()
		Me.lblUSLocation12 = New DSDSS.DSSLabel()
		Me.lblUSLocation1 = New DSDSS.DSSLabel()
		Me.lblUSLocation11 = New DSDSS.DSSLabel()
		Me.lblUSLocation5 = New DSDSS.DSSLabel()
		Me.lblUSLocation6 = New DSDSS.DSSLabel()
		Me.lblUSLocation10 = New DSDSS.DSSLabel()
		Me.lblUSLocation4 = New DSDSS.DSSLabel()
		Me.lblUSLocation13 = New DSDSS.DSSLabel()
		Me.lblUSLocation7 = New DSDSS.DSSLabel()
		Me.lblUSLocation9 = New DSDSS.DSSLabel()
		Me.lblUSLocation3 = New DSDSS.DSSLabel()
		Me.lblUSLocation2 = New DSDSS.DSSLabel()
		Me.lblUSLocation8 = New DSDSS.DSSLabel()
		Me.pnlOutAgrSmall = New DSDSS.DSSPanel()
		Me.lblAgr15_1 = New DSDSS.DSSLabel()
		Me.lblAgr14_1 = New DSDSS.DSSLabel()
		Me.lblAgr1_1 = New DSDSS.DSSLabel()
		Me.lblAgr5_1 = New DSDSS.DSSLabel()
		Me.lblAgr4_1 = New DSDSS.DSSLabel()
		Me.lblAgr8_1 = New DSDSS.DSSLabel()
		Me.lblAgr11_1 = New DSDSS.DSSLabel()
		Me.lblAgr2_1 = New DSDSS.DSSLabel()
		Me.lblAgr6_1 = New DSDSS.DSSLabel()
		Me.lblAgr9_1 = New DSDSS.DSSLabel()
		Me.lblAgr12_1 = New DSDSS.DSSLabel()
		Me.lblAgr3_1 = New DSDSS.DSSLabel()
		Me.lblAgr7_1 = New DSDSS.DSSLabel()
		Me.lblAgr10_1 = New DSDSS.DSSLabel()
		Me.lblAgr13_1 = New DSDSS.DSSLabel()
		Me.Label94 = New System.Windows.Forms.Label()
		Me.pnlOutIndLarge = New DSDSS.DSSPanel()
		Me.lblInd15_2 = New DSDSS.DSSLabel()
		Me.lblInd14_2 = New DSDSS.DSSLabel()
		Me.lblInd1_2 = New DSDSS.DSSLabel()
		Me.lblInd5_2 = New DSDSS.DSSLabel()
		Me.lblInd4_2 = New DSDSS.DSSLabel()
		Me.lblInd8_2 = New DSDSS.DSSLabel()
		Me.lblInd11_2 = New DSDSS.DSSLabel()
		Me.lblInd2_2 = New DSDSS.DSSLabel()
		Me.lblInd6_2 = New DSDSS.DSSLabel()
		Me.lblInd9_2 = New DSDSS.DSSLabel()
		Me.lblInd13_2 = New DSDSS.DSSLabel()
		Me.lblInd12_2 = New DSDSS.DSSLabel()
		Me.lblInd3_2 = New DSDSS.DSSLabel()
		Me.lblInd10_2 = New DSDSS.DSSLabel()
		Me.lblInd7_2 = New DSDSS.DSSLabel()
		Me.Label93 = New System.Windows.Forms.Label()
		Me.Label87 = New System.Windows.Forms.Label()
		Me.pnlOutLanSmall = New DSDSS.DSSPanel()
		Me.lblLan14_1 = New DSDSS.DSSLabel()
		Me.lblLan15_1 = New DSDSS.DSSLabel()
		Me.lblLan1_1 = New DSDSS.DSSLabel()
		Me.lblLan5_1 = New DSDSS.DSSLabel()
		Me.lblLan4_1 = New DSDSS.DSSLabel()
		Me.lblLan8_1 = New DSDSS.DSSLabel()
		Me.lblLan11_1 = New DSDSS.DSSLabel()
		Me.lblLan2_1 = New DSDSS.DSSLabel()
		Me.lblLan6_1 = New DSDSS.DSSLabel()
		Me.lblLan9_1 = New DSDSS.DSSLabel()
		Me.lblLan12_1 = New DSDSS.DSSLabel()
		Me.lblLan3_1 = New DSDSS.DSSLabel()
		Me.lblLan7_1 = New DSDSS.DSSLabel()
		Me.lblLan10_1 = New DSDSS.DSSLabel()
		Me.lblLan13_1 = New DSDSS.DSSLabel()
		Me.Label89 = New System.Windows.Forms.Label()
		Me.pnlOutLanLarge = New DSDSS.DSSPanel()
		Me.lblLan15_2 = New DSDSS.DSSLabel()
		Me.lblLan14_2 = New DSDSS.DSSLabel()
		Me.lblLan1_2 = New DSDSS.DSSLabel()
		Me.lblLan5_2 = New DSDSS.DSSLabel()
		Me.lblLan4_2 = New DSDSS.DSSLabel()
		Me.lblLan8_2 = New DSDSS.DSSLabel()
		Me.lblLan11_2 = New DSDSS.DSSLabel()
		Me.lblLan2_2 = New DSDSS.DSSLabel()
		Me.lblLan6_2 = New DSDSS.DSSLabel()
		Me.lblLan13_2 = New DSDSS.DSSLabel()
		Me.lblLan9_2 = New DSDSS.DSSLabel()
		Me.lblLan10_2 = New DSDSS.DSSLabel()
		Me.lblLan12_2 = New DSDSS.DSSLabel()
		Me.lblLan7_2 = New DSDSS.DSSLabel()
		Me.lblLan3_2 = New DSDSS.DSSLabel()
		Me.Label90 = New System.Windows.Forms.Label()
		Me.pnlOutAgrLarge = New DSDSS.DSSPanel()
		Me.lblAgr14_2 = New DSDSS.DSSLabel()
		Me.lblAgr15_2 = New DSDSS.DSSLabel()
		Me.lblAgr1_2 = New DSDSS.DSSLabel()
		Me.lblAgr5_2 = New DSDSS.DSSLabel()
		Me.lblAgr4_2 = New DSDSS.DSSLabel()
		Me.lblAgr8_2 = New DSDSS.DSSLabel()
		Me.lblAgr11_2 = New DSDSS.DSSLabel()
		Me.lblAgr2_2 = New DSDSS.DSSLabel()
		Me.lblAgr6_2 = New DSDSS.DSSLabel()
		Me.lblAgr9_2 = New DSDSS.DSSLabel()
		Me.lblAgr12_2 = New DSDSS.DSSLabel()
		Me.lblAgr13_2 = New DSDSS.DSSLabel()
		Me.lblAgr3_2 = New DSDSS.DSSLabel()
		Me.lblAgr7_2 = New DSDSS.DSSLabel()
		Me.lblAgr10_2 = New DSDSS.DSSLabel()
		Me.Label135 = New System.Windows.Forms.Label()
		Me.Label133 = New System.Windows.Forms.Label()
		Me.tpaImpacts = New System.Windows.Forms.TabPage()
		Me.gboOutputImpacts = New DSDSS.DSSGroupBox()
		Me.lblIMLocation15 = New DSDSS.DSSLabel()
		Me.lblIMLocation14 = New DSDSS.DSSLabel()
		Me.lblIMLocation12 = New DSDSS.DSSLabel()
		Me.lblIMLocation1 = New DSDSS.DSSLabel()
		Me.lblIMLocation11 = New DSDSS.DSSLabel()
		Me.lblIMLocation5 = New DSDSS.DSSLabel()
		Me.lblIMLocation6 = New DSDSS.DSSLabel()
		Me.lblIMLocation10 = New DSDSS.DSSLabel()
		Me.lblIMLocation4 = New DSDSS.DSSLabel()
		Me.lblIMLocation13 = New DSDSS.DSSLabel()
		Me.lblIMLocation7 = New DSDSS.DSSLabel()
		Me.lblIMLocation9 = New DSDSS.DSSLabel()
		Me.lblIMLocation3 = New DSDSS.DSSLabel()
		Me.lblIMLocation2 = New DSDSS.DSSLabel()
		Me.lblIMLocation8 = New DSDSS.DSSLabel()
		Me.lblEnvGini2 = New DSDSS.DSSLabel()
		Me.lblEnvMean2 = New DSDSS.DSSLabel()
		Me.lblSocGini2 = New DSDSS.DSSLabel()
		Me.lblSocMean2 = New DSDSS.DSSLabel()
		Me.lblEcoGini2 = New DSDSS.DSSLabel()
		Me.lblEcoMean2 = New DSDSS.DSSLabel()
		Me.lblEnvGini1 = New DSDSS.DSSLabel()
		Me.lblEnvMean1 = New DSDSS.DSSLabel()
		Me.lblSocGini1 = New DSDSS.DSSLabel()
		Me.lblSocMean1 = New DSDSS.DSSLabel()
		Me.lblEcoGini1 = New DSDSS.DSSLabel()
		Me.lblEcoMean1 = New DSDSS.DSSLabel()
		Me.Label101 = New System.Windows.Forms.Label()
		Me.Label100 = New System.Windows.Forms.Label()
		Me.pnlOutSocSmall = New DSDSS.DSSPanel()
		Me.lblSoc14_1 = New DSDSS.DSSLabel()
		Me.lblSoc15_1 = New DSDSS.DSSLabel()
		Me.lblSoc1_1 = New DSDSS.DSSLabel()
		Me.lblSoc5_1 = New DSDSS.DSSLabel()
		Me.lblSoc4_1 = New DSDSS.DSSLabel()
		Me.lblSoc8_1 = New DSDSS.DSSLabel()
		Me.lblSoc11_1 = New DSDSS.DSSLabel()
		Me.lblSoc2_1 = New DSDSS.DSSLabel()
		Me.lblSoc6_1 = New DSDSS.DSSLabel()
		Me.lblSoc9_1 = New DSDSS.DSSLabel()
		Me.lblSoc12_1 = New DSDSS.DSSLabel()
		Me.lblSoc3_1 = New DSDSS.DSSLabel()
		Me.lblSoc7_1 = New DSDSS.DSSLabel()
		Me.lblSoc10_1 = New DSDSS.DSSLabel()
		Me.lblSoc13_1 = New DSDSS.DSSLabel()
		Me.DssPanel7 = New DSDSS.DSSPanel()
		Me.pnlOutEnvLarge = New DSDSS.DSSPanel()
		Me.lblEnv14_2 = New DSDSS.DSSLabel()
		Me.lblEnv15_2 = New DSDSS.DSSLabel()
		Me.lblEnv1_2 = New DSDSS.DSSLabel()
		Me.lblEnv5_2 = New DSDSS.DSSLabel()
		Me.lblEnv4_2 = New DSDSS.DSSLabel()
		Me.lblEnv8_2 = New DSDSS.DSSLabel()
		Me.lblEnv11_2 = New DSDSS.DSSLabel()
		Me.lblEnv2_2 = New DSDSS.DSSLabel()
		Me.lblEnv6_2 = New DSDSS.DSSLabel()
		Me.lblEnv9_2 = New DSDSS.DSSLabel()
		Me.lblEnv12_2 = New DSDSS.DSSLabel()
		Me.lblEnv13_2 = New DSDSS.DSSLabel()
		Me.lblEnv3_2 = New DSDSS.DSSLabel()
		Me.lblEnv7_2 = New DSDSS.DSSLabel()
		Me.lblEnv10_2 = New DSDSS.DSSLabel()
		Me.pnlOutEnvSmall = New DSDSS.DSSPanel()
		Me.lblEnv14_1 = New DSDSS.DSSLabel()
		Me.lblEnv15_1 = New DSDSS.DSSLabel()
		Me.lblEnv1_1 = New DSDSS.DSSLabel()
		Me.lblEnv5_1 = New DSDSS.DSSLabel()
		Me.lblEnv4_1 = New DSDSS.DSSLabel()
		Me.lblEnv8_1 = New DSDSS.DSSLabel()
		Me.lblEnv11_1 = New DSDSS.DSSLabel()
		Me.lblEnv2_1 = New DSDSS.DSSLabel()
		Me.lblEnv6_1 = New DSDSS.DSSLabel()
		Me.lblEnv9_1 = New DSDSS.DSSLabel()
		Me.lblEnv12_1 = New DSDSS.DSSLabel()
		Me.lblEnv13_1 = New DSDSS.DSSLabel()
		Me.lblEnv3_1 = New DSDSS.DSSLabel()
		Me.lblEnv10_1 = New DSDSS.DSSLabel()
		Me.lblEnv7_1 = New DSDSS.DSSLabel()
		Me.pnlOutEcoLarge = New DSDSS.DSSPanel()
		Me.lblEco14_2 = New DSDSS.DSSLabel()
		Me.lblEco15_2 = New DSDSS.DSSLabel()
		Me.lblEco1_2 = New DSDSS.DSSLabel()
		Me.lblEco5_2 = New DSDSS.DSSLabel()
		Me.lblEco4_2 = New DSDSS.DSSLabel()
		Me.lblEco8_2 = New DSDSS.DSSLabel()
		Me.lblEco11_2 = New DSDSS.DSSLabel()
		Me.lblEco2_2 = New DSDSS.DSSLabel()
		Me.lblEco6_2 = New DSDSS.DSSLabel()
		Me.lblEco9_2 = New DSDSS.DSSLabel()
		Me.lblEco12_2 = New DSDSS.DSSLabel()
		Me.lblEco13_2 = New DSDSS.DSSLabel()
		Me.lblEco3_2 = New DSDSS.DSSLabel()
		Me.lblEco10_2 = New DSDSS.DSSLabel()
		Me.lblEco7_2 = New DSDSS.DSSLabel()
		Me.pnlOutSocLarge = New DSDSS.DSSPanel()
		Me.lblSoc14_2 = New DSDSS.DSSLabel()
		Me.lblSoc15_2 = New DSDSS.DSSLabel()
		Me.lblSoc1_2 = New DSDSS.DSSLabel()
		Me.lblSoc5_2 = New DSDSS.DSSLabel()
		Me.lblSoc4_2 = New DSDSS.DSSLabel()
		Me.lblSoc8_2 = New DSDSS.DSSLabel()
		Me.lblSoc11_2 = New DSDSS.DSSLabel()
		Me.lblSoc2_2 = New DSDSS.DSSLabel()
		Me.lblSoc6_2 = New DSDSS.DSSLabel()
		Me.lblSoc9_2 = New DSDSS.DSSLabel()
		Me.lblSoc12_2 = New DSDSS.DSSLabel()
		Me.lblSoc13_2 = New DSDSS.DSSLabel()
		Me.lblSoc3_2 = New DSDSS.DSSLabel()
		Me.lblSoc7_2 = New DSDSS.DSSLabel()
		Me.lblSoc10_2 = New DSDSS.DSSLabel()
		Me.pnlOutEcoSmall = New DSDSS.DSSPanel()
		Me.lblEco14_1 = New DSDSS.DSSLabel()
		Me.lblEco15_1 = New DSDSS.DSSLabel()
		Me.lblEco1_1 = New DSDSS.DSSLabel()
		Me.lblEco5_1 = New DSDSS.DSSLabel()
		Me.lblEco4_1 = New DSDSS.DSSLabel()
		Me.lblEco8_1 = New DSDSS.DSSLabel()
		Me.lblEco11_1 = New DSDSS.DSSLabel()
		Me.lblEco2_1 = New DSDSS.DSSLabel()
		Me.lblEco6_1 = New DSDSS.DSSLabel()
		Me.lblEco9_1 = New DSDSS.DSSLabel()
		Me.lblEco12_1 = New DSDSS.DSSLabel()
		Me.lblEco3_1 = New DSDSS.DSSLabel()
		Me.lblEco7_1 = New DSDSS.DSSLabel()
		Me.lblEco10_1 = New DSDSS.DSSLabel()
		Me.lblEco13_1 = New DSDSS.DSSLabel()
		Me.Label180 = New System.Windows.Forms.Label()
		Me.Label98 = New System.Windows.Forms.Label()
		Me.Label179 = New System.Windows.Forms.Label()
		Me.Label99 = New System.Windows.Forms.Label()
		Me.Label95 = New System.Windows.Forms.Label()
		Me.Label178 = New System.Windows.Forms.Label()
		Me.Label97 = New System.Windows.Forms.Label()
		Me.Label96 = New System.Windows.Forms.Label()
		Me.tpaWeights = New System.Windows.Forms.TabPage()
		Me.pboGraphWeights = New System.Windows.Forms.PictureBox()
		Me.tpaStandards = New System.Windows.Forms.TabPage()
		Me.pboGraphStandards = New System.Windows.Forms.PictureBox()
		Me.tpaEfficencies = New System.Windows.Forms.TabPage()
		Me.pboGraphEfficiencies = New System.Windows.Forms.PictureBox()
		Me.grbPopulation = New DSDSS.DSSGroupBox()
		Me.lblTPLocation15 = New DSDSS.DSSLabel()
		Me.pnlPop20_2 = New DSDSS.DSSPanel()
		Me.nudPop20_14_2 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_15_2 = New DSDSS.DSSNumericUpDown()
		Me.lblTot20_2 = New System.Windows.Forms.Label()
		Me.nudPop20_3_2 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_7_2 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_2_2 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_12_2 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_10_2 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_13_2 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_6_2 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_8_2 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_1_2 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_4_2 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_9_2 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_11_2 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_5_2 = New DSDSS.DSSNumericUpDown()
		Me.lblTPLocation14 = New DSDSS.DSSLabel()
		Me.pnlPop20_1 = New DSDSS.DSSPanel()
		Me.nudPop20_14_1 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_15_1 = New DSDSS.DSSNumericUpDown()
		Me.lblTot20_1 = New System.Windows.Forms.Label()
		Me.nudPop20_3_1 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_7_1 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_2_1 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_6_1 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_12_1 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_1_1 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_9_1 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_13_1 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_10_1 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_11_1 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_8_1 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_5_1 = New DSDSS.DSSNumericUpDown()
		Me.nudPop20_4_1 = New DSDSS.DSSNumericUpDown()
		Me.lblTPLocation12 = New DSDSS.DSSLabel()
		Me.Label69 = New System.Windows.Forms.Label()
		Me.lblTPLocation11 = New DSDSS.DSSLabel()
		Me.lblTPLocation1 = New DSDSS.DSSLabel()
		Me.lblTPLocation10 = New DSDSS.DSSLabel()
		Me.lblTPLocation13 = New DSDSS.DSSLabel()
		Me.lblTPLocation9 = New DSDSS.DSSLabel()
		Me.lblTPLocation2 = New DSDSS.DSSLabel()
		Me.lblTPLocation8 = New DSDSS.DSSLabel()
		Me.lblTPLocation3 = New DSDSS.DSSLabel()
		Me.lblTPLocation7 = New DSDSS.DSSLabel()
		Me.lblTPLocation4 = New DSDSS.DSSLabel()
		Me.lblTPLocation6 = New DSDSS.DSSLabel()
		Me.lblTPLocation5 = New DSDSS.DSSLabel()
		Me.grbIndustrialDistricts = New DSDSS.DSSGroupBox()
		Me.lblIDLocation15 = New DSDSS.DSSLabel()
		Me.pnlInddispln = New DSDSS.DSSPanel()
		Me.nudInddispln14_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddispln15_2 = New DSDSS.DSSNumericUpDown()
		Me.Label86 = New System.Windows.Forms.Label()
		Me.nudInddispln3_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddispln7_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddispln2_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddispln12_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddispln10_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddispln13_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddispln6_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddispln8_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddispln1_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddispln4_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddispln9_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddispln11_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddispln5_2 = New DSDSS.DSSNumericUpDown()
		Me.lblIDLocation14 = New DSDSS.DSSLabel()
		Me.pnlInddiscur = New DSDSS.DSSPanel()
		Me.nudInddiscur14_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddiscur15_2 = New DSDSS.DSSNumericUpDown()
		Me.Label88 = New System.Windows.Forms.Label()
		Me.nudInddiscur3_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddiscur7_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddiscur2_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddiscur6_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddiscur12_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddiscur1_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddiscur9_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddiscur13_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddiscur10_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddiscur11_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddiscur8_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddiscur5_2 = New DSDSS.DSSNumericUpDown()
		Me.nudInddiscur4_2 = New DSDSS.DSSNumericUpDown()
		Me.lblIDLocation12 = New DSDSS.DSSLabel()
		Me.lblIDLocation1 = New DSDSS.DSSLabel()
		Me.lblIDLocation11 = New DSDSS.DSSLabel()
		Me.lblIDLocation5 = New DSDSS.DSSLabel()
		Me.lblIDLocation6 = New DSDSS.DSSLabel()
		Me.lblIDLocation10 = New DSDSS.DSSLabel()
		Me.lblIDLocation4 = New DSDSS.DSSLabel()
		Me.lblIDLocation13 = New DSDSS.DSSLabel()
		Me.lblIDLocation7 = New DSDSS.DSSLabel()
		Me.lblIDLocation9 = New DSDSS.DSSLabel()
		Me.lblIDLocation3 = New DSDSS.DSSLabel()
		Me.lblIDLocation2 = New DSDSS.DSSLabel()
		Me.lblIDLocation8 = New DSDSS.DSSLabel()
		Me.grbWaterQuality = New DSDSS.DSSGroupBox()
		Me.lblWQLocation15 = New DSDSS.DSSLabel()
		Me.lblWQLocation14 = New DSDSS.DSSLabel()
		Me.lblWQLocation12 = New DSDSS.DSSLabel()
		Me.lblWQLocation1 = New DSDSS.DSSLabel()
		Me.lblWQLocation11 = New DSDSS.DSSLabel()
		Me.lblWQLocation5 = New DSDSS.DSSLabel()
		Me.lblWQLocation6 = New DSDSS.DSSLabel()
		Me.lblWQLocation10 = New DSDSS.DSSLabel()
		Me.lblWQLocation4 = New DSDSS.DSSLabel()
		Me.lblWQLocation13 = New DSDSS.DSSLabel()
		Me.lblWQLocation7 = New DSDSS.DSSLabel()
		Me.lblWQLocation9 = New DSDSS.DSSLabel()
		Me.lblWQLocation3 = New DSDSS.DSSLabel()
		Me.lblWQLocation2 = New DSDSS.DSSLabel()
		Me.lblWQLocation8 = New DSDSS.DSSLabel()
		Me.pnlTSS = New DSDSS.DSSPanel()
		Me.nudTSS14 = New DSDSS.DSSNumericUpDown()
		Me.nudTSS15 = New DSDSS.DSSNumericUpDown()
		Me.Label21 = New System.Windows.Forms.Label()
		Me.nudTSS3 = New DSDSS.DSSNumericUpDown()
		Me.nudTSS2 = New DSDSS.DSSNumericUpDown()
		Me.nudTSS7 = New DSDSS.DSSNumericUpDown()
		Me.nudTSS10 = New DSDSS.DSSNumericUpDown()
		Me.nudTSS12 = New DSDSS.DSSNumericUpDown()
		Me.nudTSS6 = New DSDSS.DSSNumericUpDown()
		Me.nudTSS13 = New DSDSS.DSSNumericUpDown()
		Me.nudTSS1 = New DSDSS.DSSNumericUpDown()
		Me.nudTSS8 = New DSDSS.DSSNumericUpDown()
		Me.nudTSS9 = New DSDSS.DSSNumericUpDown()
		Me.nudTSS4 = New DSDSS.DSSNumericUpDown()
		Me.nudTSS5 = New DSDSS.DSSNumericUpDown()
		Me.nudTSS11 = New DSDSS.DSSNumericUpDown()
		Me.pnlTDS = New DSDSS.DSSPanel()
		Me.nudTDS14 = New DSDSS.DSSNumericUpDown()
		Me.nudTDS15 = New DSDSS.DSSNumericUpDown()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.nudTDS3 = New DSDSS.DSSNumericUpDown()
		Me.nudTDS2 = New DSDSS.DSSNumericUpDown()
		Me.nudTDS7 = New DSDSS.DSSNumericUpDown()
		Me.nudTDS10 = New DSDSS.DSSNumericUpDown()
		Me.nudTDS6 = New DSDSS.DSSNumericUpDown()
		Me.nudTDS12 = New DSDSS.DSSNumericUpDown()
		Me.nudTDS1 = New DSDSS.DSSNumericUpDown()
		Me.nudTDS9 = New DSDSS.DSSNumericUpDown()
		Me.nudTDS13 = New DSDSS.DSSNumericUpDown()
		Me.nudTDS5 = New DSDSS.DSSNumericUpDown()
		Me.nudTDS11 = New DSDSS.DSSNumericUpDown()
		Me.nudTDS8 = New DSDSS.DSSNumericUpDown()
		Me.nudTDS4 = New DSDSS.DSSNumericUpDown()
		Me.pnlBOD = New DSDSS.DSSPanel()
		Me.nudBOD14 = New DSDSS.DSSNumericUpDown()
		Me.nudBOD15 = New DSDSS.DSSNumericUpDown()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.nudBOD3 = New DSDSS.DSSNumericUpDown()
		Me.nudBOD2 = New DSDSS.DSSNumericUpDown()
		Me.nudBOD7 = New DSDSS.DSSNumericUpDown()
		Me.nudBOD6 = New DSDSS.DSSNumericUpDown()
		Me.nudBOD1 = New DSDSS.DSSNumericUpDown()
		Me.nudBOD9 = New DSDSS.DSSNumericUpDown()
		Me.nudBOD12 = New DSDSS.DSSNumericUpDown()
		Me.nudBOD10 = New DSDSS.DSSNumericUpDown()
		Me.nudBOD11 = New DSDSS.DSSNumericUpDown()
		Me.nudBOD5 = New DSDSS.DSSNumericUpDown()
		Me.nudBOD13 = New DSDSS.DSSNumericUpDown()
		Me.nudBOD4 = New DSDSS.DSSNumericUpDown()
		Me.nudBOD8 = New DSDSS.DSSNumericUpDown()
		Me.ElementHost1 = New System.Windows.Forms.Integration.ElementHost()
		Me.mapControl = New mapControl.mapControl()
		Me.btnSettings = New System.Windows.Forms.Button()
		Me.DSData = New DSDSS.DSData()
		Me.TAData = New DSDSS.DSDataTableAdapters.dataTableAdapter()
		Me.cboMatemathicaMethod = New System.Windows.Forms.ComboBox()
		Me.Label1 = New System.Windows.Forms.Label()
		CType(Me.DSParameters, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.DSLocations, System.ComponentModel.ISupportInitialize).BeginInit
		Me.pnlMain.SuspendLayout
		CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit
		Me.SplitContainer.Panel1.SuspendLayout
		Me.SplitContainer.Panel2.SuspendLayout
		Me.SplitContainer.SuspendLayout
		Me.grbMisc.SuspendLayout
		Me.DssPanel1.SuspendLayout
		CType(Me.nudAgrw, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudLanw, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudIndw, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTpsx, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTpmz, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudAgrUFRO, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudEnvw, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudgwsp, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTotpla, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudIndUFRO, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudSocw, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTpbx, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudEcow, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudsmqi, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudLanUFRO, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudsbqi, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudLanUF, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudssqi, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudAgrUF, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudIndUF, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grbWaterCosts.SuspendLayout
		Me.pnlGro.SuspendLayout
		CType(Me.nudGro14, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudGro15, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudGro3, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudGro7, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudGro2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudGro12, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudGro10, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudGro13, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudGro6, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudGro8, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudGro1, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudGro4, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudGro9, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudGro11, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudGro5, System.ComponentModel.ISupportInitialize).BeginInit
		Me.pnlDes.SuspendLayout
		CType(Me.nudDes14, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudDes15, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudDes3, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudDes7, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudDes2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudDes6, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudDes12, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudDes1, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudDes9, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudDes13, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudDes10, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudDes11, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudDes8, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudDes5, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudDes4, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grbOuput.SuspendLayout
		Me.tcoOutput.SuspendLayout
		Me.tpaUses.SuspendLayout
		Me.gboOutputUses.SuspendLayout
		Me.pnlOutAgrSmall.SuspendLayout
		Me.pnlOutIndLarge.SuspendLayout
		Me.pnlOutLanSmall.SuspendLayout
		Me.pnlOutLanLarge.SuspendLayout
		Me.pnlOutAgrLarge.SuspendLayout
		Me.tpaImpacts.SuspendLayout
		Me.gboOutputImpacts.SuspendLayout
		Me.pnlOutSocSmall.SuspendLayout
		Me.pnlOutEnvLarge.SuspendLayout
		Me.pnlOutEnvSmall.SuspendLayout
		Me.pnlOutEcoLarge.SuspendLayout
		Me.pnlOutSocLarge.SuspendLayout
		Me.pnlOutEcoSmall.SuspendLayout
		Me.tpaWeights.SuspendLayout
		CType(Me.pboGraphWeights, System.ComponentModel.ISupportInitialize).BeginInit
		Me.tpaStandards.SuspendLayout
		CType(Me.pboGraphStandards, System.ComponentModel.ISupportInitialize).BeginInit
		Me.tpaEfficencies.SuspendLayout
		CType(Me.pboGraphEfficiencies, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grbPopulation.SuspendLayout
		Me.pnlPop20_2.SuspendLayout
		CType(Me.nudPop20_14_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_15_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_3_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_7_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_2_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_12_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_10_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_13_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_6_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_8_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_1_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_4_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_9_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_11_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_5_2, System.ComponentModel.ISupportInitialize).BeginInit
		Me.pnlPop20_1.SuspendLayout
		CType(Me.nudPop20_14_1, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_15_1, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_3_1, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_7_1, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_2_1, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_6_1, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_12_1, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_1_1, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_9_1, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_13_1, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_10_1, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_11_1, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_8_1, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_5_1, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPop20_4_1, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grbIndustrialDistricts.SuspendLayout
		Me.pnlInddispln.SuspendLayout
		CType(Me.nudInddispln14_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddispln15_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddispln3_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddispln7_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddispln2_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddispln12_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddispln10_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddispln13_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddispln6_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddispln8_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddispln1_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddispln4_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddispln9_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddispln11_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddispln5_2, System.ComponentModel.ISupportInitialize).BeginInit
		Me.pnlInddiscur.SuspendLayout
		CType(Me.nudInddiscur14_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddiscur15_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddiscur3_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddiscur7_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddiscur2_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddiscur6_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddiscur12_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddiscur1_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddiscur9_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddiscur13_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddiscur10_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddiscur11_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddiscur8_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddiscur5_2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudInddiscur4_2, System.ComponentModel.ISupportInitialize).BeginInit
		Me.grbWaterQuality.SuspendLayout
		Me.pnlTSS.SuspendLayout
		CType(Me.nudTSS14, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTSS15, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTSS3, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTSS2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTSS7, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTSS10, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTSS12, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTSS6, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTSS13, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTSS1, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTSS8, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTSS9, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTSS4, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTSS5, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTSS11, System.ComponentModel.ISupportInitialize).BeginInit
		Me.pnlTDS.SuspendLayout
		CType(Me.nudTDS14, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTDS15, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTDS3, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTDS2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTDS7, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTDS10, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTDS6, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTDS12, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTDS1, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTDS9, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTDS13, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTDS5, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTDS11, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTDS8, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudTDS4, System.ComponentModel.ISupportInitialize).BeginInit
		Me.pnlBOD.SuspendLayout
		CType(Me.nudBOD14, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudBOD15, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudBOD3, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudBOD2, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudBOD7, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudBOD6, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudBOD1, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudBOD9, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudBOD12, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudBOD10, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudBOD11, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudBOD5, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudBOD13, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudBOD4, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudBOD8, System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.DSData, System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'SqlConnection
		'
		Me.SqlConnection.ConnectionString = "Data Source=economia11-181\sqlexpress;Initial Catalog=D-SDSS;Persist Security Inf" &
	"o=True;User ID=SDSS;Password=SDSS"
		Me.SqlConnection.FireInfoMessageEventOnUserErrors = False
		'
		'btnNext
		'
		Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnNext.Location = New System.Drawing.Point(441, 522)
		Me.btnNext.Name = "btnNext"
		Me.btnNext.Size = New System.Drawing.Size(90, 36)
		Me.btnNext.TabIndex = 103
		Me.btnNext.Text = "Next"
		Me.btnNext.UseVisualStyleBackColor = True
		'
		'btnPrev
		'
		Me.btnPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnPrev.Location = New System.Drawing.Point(342, 522)
		Me.btnPrev.Name = "btnPrev"
		Me.btnPrev.Size = New System.Drawing.Size(90, 36)
		Me.btnPrev.TabIndex = 102
		Me.btnPrev.Text = "Previous"
		Me.btnPrev.UseVisualStyleBackColor = True
		'
		'btnLoadData
		'
		Me.btnLoadData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnLoadData.Location = New System.Drawing.Point(12, 522)
		Me.btnLoadData.Name = "btnLoadData"
		Me.btnLoadData.Size = New System.Drawing.Size(90, 36)
		Me.btnLoadData.TabIndex = 100
		Me.btnLoadData.Text = "Load data"
		Me.btnLoadData.UseVisualStyleBackColor = True
		'
		'DSParameters
		'
		Me.DSParameters.DataSetName = "parameters"
		Me.DSParameters.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'TAParameters
		'
		Me.TAParameters.ClearBeforeFill = True
		'
		'DALocations
		'
		Me.DALocations.SelectCommand = Me.SqlCommand2
		Me.DALocations.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "locations", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("locID", "locID"), New System.Data.Common.DataColumnMapping("locName", "locName"), New System.Data.Common.DataColumnMapping("locLatitude", "locLatitude"), New System.Data.Common.DataColumnMapping("locLongitude", "locLongitude")})})
		'
		'SqlCommand2
		'
		Me.SqlCommand2.CommandText = "SELECT        locID, locName, locLatitude, locLongitude" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            location" &
	"s"
		Me.SqlCommand2.Connection = Me.SqlConnection
		'
		'DSLocations
		'
		Me.DSLocations.DataSetName = "DSLocations"
		Me.DSLocations.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'pnlMain
		'
		Me.pnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlMain.Controls.Add(Me.SplitContainer)
		Me.pnlMain.Location = New System.Drawing.Point(0, 0)
		Me.pnlMain.Name = "pnlMain"
		Me.pnlMain.Size = New System.Drawing.Size(940, 516)
		Me.pnlMain.TabIndex = 30
		'
		'SplitContainer
		'
		Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer.Name = "SplitContainer"
		'
		'SplitContainer.Panel1
		'
		Me.SplitContainer.Panel1.Controls.Add(Me.grbMisc)
		Me.SplitContainer.Panel1.Controls.Add(Me.grbWaterCosts)
		Me.SplitContainer.Panel1.Controls.Add(Me.grbOuput)
		Me.SplitContainer.Panel1.Controls.Add(Me.grbPopulation)
		Me.SplitContainer.Panel1.Controls.Add(Me.grbIndustrialDistricts)
		Me.SplitContainer.Panel1.Controls.Add(Me.grbWaterQuality)
		'
		'SplitContainer.Panel2
		'
		Me.SplitContainer.Panel2.Controls.Add(Me.ElementHost1)
		Me.SplitContainer.Size = New System.Drawing.Size(940, 516)
		Me.SplitContainer.SplitterDistance = 746
		Me.SplitContainer.SplitterWidth = 2
		Me.SplitContainer.TabIndex = 0
		Me.SplitContainer.TabStop = False
		'
		'grbMisc
		'
		Me.grbMisc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.grbMisc.Controls.Add(Me.DssPanel1)
		Me.grbMisc.Controls.Add(Me.Label25)
		Me.grbMisc.Controls.Add(Me.Label119)
		Me.grbMisc.Controls.Add(Me.Label34)
		Me.grbMisc.Controls.Add(Me.Label27)
		Me.grbMisc.Controls.Add(Me.Label23)
		Me.grbMisc.Controls.Add(Me.Label118)
		Me.grbMisc.Controls.Add(Me.Label78)
		Me.grbMisc.Controls.Add(Me.Label117)
		Me.grbMisc.Controls.Add(Me.Label91)
		Me.grbMisc.ForeColor = System.Drawing.Color.Black
		Me.grbMisc.Location = New System.Drawing.Point(0, 0)
		Me.grbMisc.Name = "grbMisc"
		Me.grbMisc.Size = New System.Drawing.Size(759, 516)
		Me.grbMisc.TabIndex = 13
		Me.grbMisc.TabStop = False
		Me.grbMisc.Text = "Costs, efficiencies, standards, preferences and constraints"
		Me.grbMisc.Visible = False
		'
		'DssPanel1
		'
		Me.DssPanel1.Controls.Add(Me.Label1)
		Me.DssPanel1.Controls.Add(Me.cboMatemathicaMethod)
		Me.DssPanel1.Controls.Add(Me.Agr)
		Me.DssPanel1.Controls.Add(Me.Lan)
		Me.DssPanel1.Controls.Add(Me.Ind)
		Me.DssPanel1.Controls.Add(Me.nudAgrw)
		Me.DssPanel1.Controls.Add(Me.nudLanw)
		Me.DssPanel1.Controls.Add(Me.nudIndw)
		Me.DssPanel1.Controls.Add(Me.chkSalt)
		Me.DssPanel1.Controls.Add(Me.Label10)
		Me.DssPanel1.Controls.Add(Me.Label13)
		Me.DssPanel1.Controls.Add(Me.lblBOD)
		Me.DssPanel1.Controls.Add(Me.Label92)
		Me.DssPanel1.Controls.Add(Me.Label28)
		Me.DssPanel1.Controls.Add(Me.Label30)
		Me.DssPanel1.Controls.Add(Me.Label64)
		Me.DssPanel1.Controls.Add(Me.Label70)
		Me.DssPanel1.Controls.Add(Me.Label116)
		Me.DssPanel1.Controls.Add(Me.Label12)
		Me.DssPanel1.Controls.Add(Me.Label26)
		Me.DssPanel1.Controls.Add(Me.nudTpsx)
		Me.DssPanel1.Controls.Add(Me.Label68)
		Me.DssPanel1.Controls.Add(Me.nudTpmz)
		Me.DssPanel1.Controls.Add(Me.Label24)
		Me.DssPanel1.Controls.Add(Me.nudAgrUFRO)
		Me.DssPanel1.Controls.Add(Me.Label29)
		Me.DssPanel1.Controls.Add(Me.nudEnvw)
		Me.DssPanel1.Controls.Add(Me.lblTDS)
		Me.DssPanel1.Controls.Add(Me.nudgwsp)
		Me.DssPanel1.Controls.Add(Me.nudTotpla)
		Me.DssPanel1.Controls.Add(Me.nudIndUFRO)
		Me.DssPanel1.Controls.Add(Me.nudSocw)
		Me.DssPanel1.Controls.Add(Me.nudTpbx)
		Me.DssPanel1.Controls.Add(Me.nudEcow)
		Me.DssPanel1.Controls.Add(Me.nudsmqi)
		Me.DssPanel1.Controls.Add(Me.nudLanUFRO)
		Me.DssPanel1.Controls.Add(Me.nudsbqi)
		Me.DssPanel1.Controls.Add(Me.nudLanUF)
		Me.DssPanel1.Controls.Add(Me.nudssqi)
		Me.DssPanel1.Controls.Add(Me.nudAgrUF)
		Me.DssPanel1.Controls.Add(Me.nudIndUF)
		Me.DssPanel1.Location = New System.Drawing.Point(178, 16)
		Me.DssPanel1.Name = "DssPanel1"
		Me.DssPanel1.Size = New System.Drawing.Size(581, 475)
		Me.DssPanel1.TabIndex = 193
		'
		'Agr
		'
		Me.Agr.Location = New System.Drawing.Point(291, 130)
		Me.Agr.Name = "Agr"
		Me.Agr.Size = New System.Drawing.Size(90, 13)
		Me.Agr.TabIndex = 197
		Me.Agr.Text = "Agr"
		Me.Agr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Lan
		'
		Me.Lan.Location = New System.Drawing.Point(485, 130)
		Me.Lan.Name = "Lan"
		Me.Lan.Size = New System.Drawing.Size(90, 13)
		Me.Lan.TabIndex = 198
		Me.Lan.Text = "Lan"
		Me.Lan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Ind
		'
		Me.Ind.Location = New System.Drawing.Point(387, 130)
		Me.Ind.Name = "Ind"
		Me.Ind.Size = New System.Drawing.Size(90, 13)
		Me.Ind.TabIndex = 199
		Me.Ind.Text = "Ind"
		Me.Ind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'nudAgrw
		'
		Me.nudAgrw.DecimalPlaces = 2
		Me.nudAgrw.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
		Me.nudAgrw.DSSElementName = "inddiscur6_1"
		Me.nudAgrw.DSSLocation = 0
		Me.nudAgrw.DSSOffset = -0.2R
		Me.nudAgrw.Location = New System.Drawing.Point(291, 150)
		Me.nudAgrw.Name = "nudAgrw"
		Me.nudAgrw.Size = New System.Drawing.Size(90, 20)
		Me.nudAgrw.TabIndex = 194
		Me.nudAgrw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudAgrw.Value = New Decimal(New Integer() {6, 0, 0, 0})
		'
		'nudLanw
		'
		Me.nudLanw.DecimalPlaces = 2
		Me.nudLanw.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
		Me.nudLanw.DSSElementName = "inddiscur7_1"
		Me.nudLanw.DSSLocation = 0
		Me.nudLanw.DSSOffset = -0.2R
		Me.nudLanw.Location = New System.Drawing.Point(485, 150)
		Me.nudLanw.Name = "nudLanw"
		Me.nudLanw.Size = New System.Drawing.Size(90, 20)
		Me.nudLanw.TabIndex = 196
		Me.nudLanw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudLanw.Value = New Decimal(New Integer() {10, 0, 0, 0})
		'
		'nudIndw
		'
		Me.nudIndw.DecimalPlaces = 2
		Me.nudIndw.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
		Me.nudIndw.DSSElementName = "inddiscur5_1"
		Me.nudIndw.DSSLocation = 0
		Me.nudIndw.DSSOffset = -0.2R
		Me.nudIndw.Location = New System.Drawing.Point(387, 150)
		Me.nudIndw.Name = "nudIndw"
		Me.nudIndw.Size = New System.Drawing.Size(90, 20)
		Me.nudIndw.TabIndex = 195
		Me.nudIndw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudIndw.Value = New Decimal(New Integer() {12, 0, 0, 0})
		'
		'chkSalt
		'
		Me.chkSalt.AutoSize = True
		Me.chkSalt.Location = New System.Drawing.Point(2, 385)
		Me.chkSalt.Name = "chkSalt"
		Me.chkSalt.Size = New System.Drawing.Size(59, 17)
		Me.chkSalt.TabIndex = 193
		Me.chkSalt.Text = "Salinity"
		Me.chkSalt.UseVisualStyleBackColor = True
		'
		'Label10
		'
		Me.Label10.Location = New System.Drawing.Point(2, 9)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(90, 13)
		Me.Label10.TabIndex = 179
		Me.Label10.Text = "Cost UF"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label13
		'
		Me.Label13.Location = New System.Drawing.Point(487, 9)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(90, 13)
		Me.Label13.TabIndex = 192
		Me.Label13.Text = "N"
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblBOD
		'
		Me.lblBOD.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblBOD.DSSElementName = Nothing
		Me.lblBOD.DSSLocation = 0
		Me.lblBOD.DSSOffset = 0R
		Me.lblBOD.Location = New System.Drawing.Point(195, 9)
		Me.lblBOD.Name = "lblBOD"
		Me.lblBOD.Size = New System.Drawing.Size(90, 13)
		Me.lblBOD.TabIndex = 179
		Me.lblBOD.Text = "BOD"
		Me.lblBOD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label92
		'
		Me.Label92.Location = New System.Drawing.Point(389, 26)
		Me.Label92.Name = "Label92"
		Me.Label92.Size = New System.Drawing.Size(90, 13)
		Me.Label92.TabIndex = 191
		Me.Label92.Text = "Efficiency (%)"
		Me.Label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label28
		'
		Me.Label28.Location = New System.Drawing.Point(2, 130)
		Me.Label28.Name = "Label28"
		Me.Label28.Size = New System.Drawing.Size(90, 13)
		Me.Label28.TabIndex = 179
		Me.Label28.Text = "Env"
		Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label30
		'
		Me.Label30.Location = New System.Drawing.Point(196, 130)
		Me.Label30.Name = "Label30"
		Me.Label30.Size = New System.Drawing.Size(90, 13)
		Me.Label30.TabIndex = 191
		Me.Label30.Text = "Soc"
		Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label64
		'
		Me.Label64.Location = New System.Drawing.Point(195, 26)
		Me.Label64.Name = "Label64"
		Me.Label64.Size = New System.Drawing.Size(90, 13)
		Me.Label64.TabIndex = 179
		Me.Label64.Text = "Efficiency (%)"
		Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label70
		'
		Me.Label70.Location = New System.Drawing.Point(389, 9)
		Me.Label70.Name = "Label70"
		Me.Label70.Size = New System.Drawing.Size(90, 13)
		Me.Label70.TabIndex = 191
		Me.Label70.Text = "TSS"
		Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label116
		'
		Me.Label116.Location = New System.Drawing.Point(2, 260)
		Me.Label116.Name = "Label116"
		Me.Label116.Size = New System.Drawing.Size(90, 33)
		Me.Label116.TabIndex = 179
		Me.Label116.Text = "Standard" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(mg/l)"
		Me.Label116.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label12
		'
		Me.Label12.Location = New System.Drawing.Point(2, 26)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(90, 13)
		Me.Label12.TabIndex = 179
		Me.Label12.Text = "(RSA/CM)"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label26
		'
		Me.Label26.Location = New System.Drawing.Point(98, 26)
		Me.Label26.Name = "Label26"
		Me.Label26.Size = New System.Drawing.Size(90, 13)
		Me.Label26.TabIndex = 191
		Me.Label26.Text = "(RSA/CM)"
		Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'nudTpsx
		'
		Me.nudTpsx.DecimalPlaces = 2
		Me.nudTpsx.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
		Me.nudTpsx.DSSElementName = "inddiscur2_1"
		Me.nudTpsx.DSSLocation = 0
		Me.nudTpsx.DSSOffset = -0.2R
		Me.nudTpsx.Location = New System.Drawing.Point(291, 43)
		Me.nudTpsx.Name = "nudTpsx"
		Me.nudTpsx.Size = New System.Drawing.Size(90, 20)
		Me.nudTpsx.TabIndex = 7
		Me.nudTpsx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTpsx.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'Label68
		'
		Me.Label68.Location = New System.Drawing.Point(291, 26)
		Me.Label68.Name = "Label68"
		Me.Label68.Size = New System.Drawing.Size(90, 13)
		Me.Label68.TabIndex = 191
		Me.Label68.Text = "Efficiency (%)"
		Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'nudTpmz
		'
		Me.nudTpmz.DecimalPlaces = 2
		Me.nudTpmz.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
		Me.nudTpmz.DSSElementName = "inddiscur2_1"
		Me.nudTpmz.DSSLocation = 0
		Me.nudTpmz.DSSOffset = -0.2R
		Me.nudTpmz.Location = New System.Drawing.Point(389, 89)
		Me.nudTpmz.Name = "nudTpmz"
		Me.nudTpmz.Size = New System.Drawing.Size(90, 20)
		Me.nudTpmz.TabIndex = 8
		Me.nudTpmz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTpmz.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'Label24
		'
		Me.Label24.Location = New System.Drawing.Point(98, 9)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(90, 13)
		Me.Label24.TabIndex = 191
		Me.Label24.Text = "Cost UF RO"
		Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'nudAgrUFRO
		'
		Me.nudAgrUFRO.DecimalPlaces = 2
		Me.nudAgrUFRO.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
		Me.nudAgrUFRO.DSSElementName = "inddiscur2_1"
		Me.nudAgrUFRO.DSSLocation = 0
		Me.nudAgrUFRO.DSSOffset = -0.2R
		Me.nudAgrUFRO.Location = New System.Drawing.Point(98, 43)
		Me.nudAgrUFRO.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudAgrUFRO.Name = "nudAgrUFRO"
		Me.nudAgrUFRO.Size = New System.Drawing.Size(90, 20)
		Me.nudAgrUFRO.TabIndex = 3
		Me.nudAgrUFRO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudAgrUFRO.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'Label29
		'
		Me.Label29.Location = New System.Drawing.Point(98, 130)
		Me.Label29.Name = "Label29"
		Me.Label29.Size = New System.Drawing.Size(90, 13)
		Me.Label29.TabIndex = 191
		Me.Label29.Text = "Eco"
		Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'nudEnvw
		'
		Me.nudEnvw.DecimalPlaces = 2
		Me.nudEnvw.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
		Me.nudEnvw.DSSElementName = "inddiscur6_1"
		Me.nudEnvw.DSSLocation = 0
		Me.nudEnvw.DSSOffset = -0.2R
		Me.nudEnvw.Location = New System.Drawing.Point(2, 150)
		Me.nudEnvw.Name = "nudEnvw"
		Me.nudEnvw.Size = New System.Drawing.Size(90, 20)
		Me.nudEnvw.TabIndex = 9
		Me.nudEnvw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudEnvw.Value = New Decimal(New Integer() {6, 0, 0, 0})
		'
		'lblTDS
		'
		Me.lblTDS.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblTDS.DSSElementName = Nothing
		Me.lblTDS.DSSLocation = 0
		Me.lblTDS.DSSOffset = 0R
		Me.lblTDS.Location = New System.Drawing.Point(291, 9)
		Me.lblTDS.Name = "lblTDS"
		Me.lblTDS.Size = New System.Drawing.Size(90, 13)
		Me.lblTDS.TabIndex = 191
		Me.lblTDS.Text = "TDS"
		Me.lblTDS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'nudgwsp
		'
		Me.nudgwsp.DecimalPlaces = 2
		Me.nudgwsp.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
		Me.nudgwsp.DSSElementName = "inddiscur6_1"
		Me.nudgwsp.DSSLocation = 0
		Me.nudgwsp.DSSOffset = -0.2R
		Me.nudgwsp.Location = New System.Drawing.Point(2, 234)
		Me.nudgwsp.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudgwsp.Name = "nudgwsp"
		Me.nudgwsp.Size = New System.Drawing.Size(90, 20)
		Me.nudgwsp.TabIndex = 13
		Me.nudgwsp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudgwsp.Value = New Decimal(New Integer() {6, 0, 0, 0})
		'
		'nudTotpla
		'
		Me.nudTotpla.DecimalPlaces = 2
		Me.nudTotpla.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
		Me.nudTotpla.DSSElementName = "inddiscur7_1"
		Me.nudTotpla.DSSLocation = 0
		Me.nudTotpla.DSSOffset = -0.2R
		Me.nudTotpla.Location = New System.Drawing.Point(486, 191)
		Me.nudTotpla.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudTotpla.Name = "nudTotpla"
		Me.nudTotpla.Size = New System.Drawing.Size(90, 20)
		Me.nudTotpla.TabIndex = 12
		Me.nudTotpla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTotpla.Value = New Decimal(New Integer() {10, 0, 0, 0})
		'
		'nudIndUFRO
		'
		Me.nudIndUFRO.DecimalPlaces = 2
		Me.nudIndUFRO.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
		Me.nudIndUFRO.DSSElementName = "inddiscur2_1"
		Me.nudIndUFRO.DSSLocation = 0
		Me.nudIndUFRO.DSSOffset = -0.2R
		Me.nudIndUFRO.Location = New System.Drawing.Point(98, 66)
		Me.nudIndUFRO.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudIndUFRO.Name = "nudIndUFRO"
		Me.nudIndUFRO.Size = New System.Drawing.Size(90, 20)
		Me.nudIndUFRO.TabIndex = 4
		Me.nudIndUFRO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudIndUFRO.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'nudSocw
		'
		Me.nudSocw.DecimalPlaces = 2
		Me.nudSocw.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
		Me.nudSocw.DSSElementName = "inddiscur7_1"
		Me.nudSocw.DSSLocation = 0
		Me.nudSocw.DSSOffset = -0.2R
		Me.nudSocw.Location = New System.Drawing.Point(196, 150)
		Me.nudSocw.Name = "nudSocw"
		Me.nudSocw.Size = New System.Drawing.Size(90, 20)
		Me.nudSocw.TabIndex = 11
		Me.nudSocw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudSocw.Value = New Decimal(New Integer() {10, 0, 0, 0})
		'
		'nudTpbx
		'
		Me.nudTpbx.DecimalPlaces = 2
		Me.nudTpbx.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
		Me.nudTpbx.DSSElementName = "inddiscur1_1"
		Me.nudTpbx.DSSLocation = 0
		Me.nudTpbx.DSSOffset = -0.2R
		Me.nudTpbx.Location = New System.Drawing.Point(195, 43)
		Me.nudTpbx.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudTpbx.Name = "nudTpbx"
		Me.nudTpbx.Size = New System.Drawing.Size(90, 20)
		Me.nudTpbx.TabIndex = 6
		Me.nudTpbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTpbx.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'nudEcow
		'
		Me.nudEcow.DecimalPlaces = 2
		Me.nudEcow.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
		Me.nudEcow.DSSElementName = "inddiscur5_1"
		Me.nudEcow.DSSLocation = 0
		Me.nudEcow.DSSOffset = -0.2R
		Me.nudEcow.Location = New System.Drawing.Point(98, 150)
		Me.nudEcow.Name = "nudEcow"
		Me.nudEcow.Size = New System.Drawing.Size(90, 20)
		Me.nudEcow.TabIndex = 10
		Me.nudEcow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudEcow.Value = New Decimal(New Integer() {12, 0, 0, 0})
		'
		'nudsmqi
		'
		Me.nudsmqi.DecimalPlaces = 2
		Me.nudsmqi.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
		Me.nudsmqi.DSSElementName = "inddiscur1_1"
		Me.nudsmqi.DSSLocation = 0
		Me.nudsmqi.DSSOffset = -0.2R
		Me.nudsmqi.Location = New System.Drawing.Point(2, 343)
		Me.nudsmqi.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudsmqi.Name = "nudsmqi"
		Me.nudsmqi.Size = New System.Drawing.Size(90, 20)
		Me.nudsmqi.TabIndex = 16
		Me.nudsmqi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudsmqi.Value = New Decimal(New Integer() {20, 0, 0, 0})
		'
		'nudLanUFRO
		'
		Me.nudLanUFRO.DecimalPlaces = 2
		Me.nudLanUFRO.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
		Me.nudLanUFRO.DSSElementName = "inddiscur2_1"
		Me.nudLanUFRO.DSSLocation = 0
		Me.nudLanUFRO.DSSOffset = -0.2R
		Me.nudLanUFRO.Location = New System.Drawing.Point(98, 89)
		Me.nudLanUFRO.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudLanUFRO.Name = "nudLanUFRO"
		Me.nudLanUFRO.Size = New System.Drawing.Size(90, 20)
		Me.nudLanUFRO.TabIndex = 5
		Me.nudLanUFRO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudLanUFRO.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'nudsbqi
		'
		Me.nudsbqi.DecimalPlaces = 2
		Me.nudsbqi.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
		Me.nudsbqi.DSSElementName = "inddiscur1_1"
		Me.nudsbqi.DSSLocation = 0
		Me.nudsbqi.DSSOffset = -0.2R
		Me.nudsbqi.Location = New System.Drawing.Point(2, 297)
		Me.nudsbqi.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudsbqi.Name = "nudsbqi"
		Me.nudsbqi.Size = New System.Drawing.Size(90, 20)
		Me.nudsbqi.TabIndex = 14
		Me.nudsbqi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudsbqi.Value = New Decimal(New Integer() {20, 0, 0, 0})
		'
		'nudLanUF
		'
		Me.nudLanUF.DecimalPlaces = 2
		Me.nudLanUF.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
		Me.nudLanUF.DSSElementName = "inddiscur1_1"
		Me.nudLanUF.DSSLocation = 0
		Me.nudLanUF.DSSOffset = -0.2R
		Me.nudLanUF.Location = New System.Drawing.Point(2, 89)
		Me.nudLanUF.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudLanUF.Name = "nudLanUF"
		Me.nudLanUF.Size = New System.Drawing.Size(90, 20)
		Me.nudLanUF.TabIndex = 2
		Me.nudLanUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudLanUF.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'nudssqi
		'
		Me.nudssqi.DecimalPlaces = 2
		Me.nudssqi.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
		Me.nudssqi.DSSElementName = "inddiscur1_1"
		Me.nudssqi.DSSLocation = 0
		Me.nudssqi.DSSOffset = -0.2R
		Me.nudssqi.Location = New System.Drawing.Point(2, 320)
		Me.nudssqi.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
		Me.nudssqi.Name = "nudssqi"
		Me.nudssqi.Size = New System.Drawing.Size(90, 20)
		Me.nudssqi.TabIndex = 15
		Me.nudssqi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudssqi.Value = New Decimal(New Integer() {1000, 0, 0, 0})
		'
		'nudAgrUF
		'
		Me.nudAgrUF.DecimalPlaces = 2
		Me.nudAgrUF.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
		Me.nudAgrUF.DSSElementName = "inddiscur1_1"
		Me.nudAgrUF.DSSLocation = 0
		Me.nudAgrUF.DSSOffset = -0.2R
		Me.nudAgrUF.Location = New System.Drawing.Point(2, 43)
		Me.nudAgrUF.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudAgrUF.Name = "nudAgrUF"
		Me.nudAgrUF.Size = New System.Drawing.Size(90, 20)
		Me.nudAgrUF.TabIndex = 0
		Me.nudAgrUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudAgrUF.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'nudIndUF
		'
		Me.nudIndUF.DecimalPlaces = 2
		Me.nudIndUF.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
		Me.nudIndUF.DSSElementName = "inddiscur1_1"
		Me.nudIndUF.DSSLocation = 0
		Me.nudIndUF.DSSOffset = -0.2R
		Me.nudIndUF.Location = New System.Drawing.Point(2, 66)
		Me.nudIndUF.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudIndUF.Name = "nudIndUF"
		Me.nudIndUF.Size = New System.Drawing.Size(90, 20)
		Me.nudIndUF.TabIndex = 1
		Me.nudIndUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudIndUF.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'Label25
		'
		Me.Label25.Location = New System.Drawing.Point(18, 174)
		Me.Label25.Name = "Label25"
		Me.Label25.Size = New System.Drawing.Size(154, 20)
		Me.Label25.TabIndex = 169
		Me.Label25.Text = "Weights attached to issues (%)"
		'
		'Label119
		'
		Me.Label119.Location = New System.Drawing.Point(18, 359)
		Me.Label119.Name = "Label119"
		Me.Label119.Size = New System.Drawing.Size(154, 20)
		Me.Label119.TabIndex = 171
		Me.Label119.Text = "Max TSS content for Lan"
		'
		'Label34
		'
		Me.Label34.Location = New System.Drawing.Point(18, 105)
		Me.Label34.Name = "Label34"
		Me.Label34.Size = New System.Drawing.Size(154, 20)
		Me.Label34.TabIndex = 171
		Me.Label34.Text = "Dedicated III treatment for Lan"
		'
		'Label27
		'
		Me.Label27.Location = New System.Drawing.Point(18, 250)
		Me.Label27.Name = "Label27"
		Me.Label27.Size = New System.Drawing.Size(154, 20)
		Me.Label27.TabIndex = 173
		Me.Label27.Text = "Groundwater shadow price"
		'
		'Label23
		'
		Me.Label23.Location = New System.Drawing.Point(18, 207)
		Me.Label23.Name = "Label23"
		Me.Label23.Size = New System.Drawing.Size(154, 20)
		Me.Label23.TabIndex = 173
		Me.Label23.Text = "Maximum number of WWTPs"
		'
		'Label118
		'
		Me.Label118.Location = New System.Drawing.Point(18, 336)
		Me.Label118.Name = "Label118"
		Me.Label118.Size = New System.Drawing.Size(154, 20)
		Me.Label118.TabIndex = 174
		Me.Label118.Text = "Max TDS content for Agr&&Lan"
		'
		'Label78
		'
		Me.Label78.Location = New System.Drawing.Point(18, 82)
		Me.Label78.Name = "Label78"
		Me.Label78.Size = New System.Drawing.Size(154, 20)
		Me.Label78.TabIndex = 174
		Me.Label78.Text = "Dedicated III treatment for Ind"
		'
		'Label117
		'
		Me.Label117.Location = New System.Drawing.Point(18, 313)
		Me.Label117.Name = "Label117"
		Me.Label117.Size = New System.Drawing.Size(154, 20)
		Me.Label117.TabIndex = 177
		Me.Label117.Text = "Max BOD content for Agr"
		'
		'Label91
		'
		Me.Label91.Location = New System.Drawing.Point(18, 59)
		Me.Label91.Name = "Label91"
		Me.Label91.Size = New System.Drawing.Size(154, 20)
		Me.Label91.TabIndex = 177
		Me.Label91.Text = "Dedicated III treatment for Agr"
		'
		'grbWaterCosts
		'
		Me.grbWaterCosts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.grbWaterCosts.Controls.Add(Me.lblWCLocation15)
		Me.grbWaterCosts.Controls.Add(Me.lblWCLocation14)
		Me.grbWaterCosts.Controls.Add(Me.lblWCLocation12)
		Me.grbWaterCosts.Controls.Add(Me.lblWCLocation11)
		Me.grbWaterCosts.Controls.Add(Me.lblWCLocation10)
		Me.grbWaterCosts.Controls.Add(Me.lblWCLocation9)
		Me.grbWaterCosts.Controls.Add(Me.lblWCLocation8)
		Me.grbWaterCosts.Controls.Add(Me.lblWCLocation7)
		Me.grbWaterCosts.Controls.Add(Me.lblWCLocation6)
		Me.grbWaterCosts.Controls.Add(Me.lblWCLocation5)
		Me.grbWaterCosts.Controls.Add(Me.lblWCLocation4)
		Me.grbWaterCosts.Controls.Add(Me.lblWCLocation3)
		Me.grbWaterCosts.Controls.Add(Me.lblWCLocation2)
		Me.grbWaterCosts.Controls.Add(Me.lblWCLocation1)
		Me.grbWaterCosts.Controls.Add(Me.lblWCLocation13)
		Me.grbWaterCosts.Controls.Add(Me.pnlGro)
		Me.grbWaterCosts.Controls.Add(Me.pnlDes)
		Me.grbWaterCosts.ForeColor = System.Drawing.Color.Black
		Me.grbWaterCosts.Location = New System.Drawing.Point(0, 0)
		Me.grbWaterCosts.Name = "grbWaterCosts"
		Me.grbWaterCosts.Size = New System.Drawing.Size(349, 516)
		Me.grbWaterCosts.TabIndex = 24
		Me.grbWaterCosts.TabStop = False
		Me.grbWaterCosts.Text = "Water costs"
		Me.grbWaterCosts.Visible = False
		'
		'lblWCLocation15
		'
		Me.lblWCLocation15.AutoSize = True
		Me.lblWCLocation15.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWCLocation15.DSSElementName = "locName"
		Me.lblWCLocation15.DSSLocation = 15
		Me.lblWCLocation15.DSSOffset = 0R
		Me.lblWCLocation15.Location = New System.Drawing.Point(26, 364)
		Me.lblWCLocation15.Name = "lblWCLocation15"
		Me.lblWCLocation15.Size = New System.Drawing.Size(56, 13)
		Me.lblWCLocation15.TabIndex = 130
		Me.lblWCLocation15.Text = "location15"
		'
		'lblWCLocation14
		'
		Me.lblWCLocation14.AutoSize = True
		Me.lblWCLocation14.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWCLocation14.DSSElementName = "locName"
		Me.lblWCLocation14.DSSLocation = 14
		Me.lblWCLocation14.DSSOffset = 0R
		Me.lblWCLocation14.Location = New System.Drawing.Point(26, 341)
		Me.lblWCLocation14.Name = "lblWCLocation14"
		Me.lblWCLocation14.Size = New System.Drawing.Size(56, 13)
		Me.lblWCLocation14.TabIndex = 129
		Me.lblWCLocation14.Text = "location14"
		'
		'lblWCLocation12
		'
		Me.lblWCLocation12.AutoSize = True
		Me.lblWCLocation12.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWCLocation12.DSSElementName = "locName"
		Me.lblWCLocation12.DSSLocation = 12
		Me.lblWCLocation12.DSSOffset = 0R
		Me.lblWCLocation12.Location = New System.Drawing.Point(26, 295)
		Me.lblWCLocation12.Name = "lblWCLocation12"
		Me.lblWCLocation12.Size = New System.Drawing.Size(56, 13)
		Me.lblWCLocation12.TabIndex = 127
		Me.lblWCLocation12.Text = "location12"
		'
		'lblWCLocation11
		'
		Me.lblWCLocation11.AutoSize = True
		Me.lblWCLocation11.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWCLocation11.DSSElementName = "locName"
		Me.lblWCLocation11.DSSLocation = 11
		Me.lblWCLocation11.DSSOffset = 0R
		Me.lblWCLocation11.Location = New System.Drawing.Point(26, 272)
		Me.lblWCLocation11.Name = "lblWCLocation11"
		Me.lblWCLocation11.Size = New System.Drawing.Size(56, 13)
		Me.lblWCLocation11.TabIndex = 126
		Me.lblWCLocation11.Text = "location11"
		'
		'lblWCLocation10
		'
		Me.lblWCLocation10.AutoSize = True
		Me.lblWCLocation10.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWCLocation10.DSSElementName = "locName"
		Me.lblWCLocation10.DSSLocation = 10
		Me.lblWCLocation10.DSSOffset = 0R
		Me.lblWCLocation10.Location = New System.Drawing.Point(26, 249)
		Me.lblWCLocation10.Name = "lblWCLocation10"
		Me.lblWCLocation10.Size = New System.Drawing.Size(56, 13)
		Me.lblWCLocation10.TabIndex = 125
		Me.lblWCLocation10.Text = "location10"
		'
		'lblWCLocation9
		'
		Me.lblWCLocation9.AutoSize = True
		Me.lblWCLocation9.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWCLocation9.DSSElementName = "locName"
		Me.lblWCLocation9.DSSLocation = 9
		Me.lblWCLocation9.DSSOffset = 0R
		Me.lblWCLocation9.Location = New System.Drawing.Point(26, 226)
		Me.lblWCLocation9.Name = "lblWCLocation9"
		Me.lblWCLocation9.Size = New System.Drawing.Size(50, 13)
		Me.lblWCLocation9.TabIndex = 124
		Me.lblWCLocation9.Text = "location9"
		'
		'lblWCLocation8
		'
		Me.lblWCLocation8.AutoSize = True
		Me.lblWCLocation8.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWCLocation8.DSSElementName = "locName"
		Me.lblWCLocation8.DSSLocation = 8
		Me.lblWCLocation8.DSSOffset = 0R
		Me.lblWCLocation8.Location = New System.Drawing.Point(26, 203)
		Me.lblWCLocation8.Name = "lblWCLocation8"
		Me.lblWCLocation8.Size = New System.Drawing.Size(50, 13)
		Me.lblWCLocation8.TabIndex = 123
		Me.lblWCLocation8.Text = "location8"
		'
		'lblWCLocation7
		'
		Me.lblWCLocation7.AutoSize = True
		Me.lblWCLocation7.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWCLocation7.DSSElementName = "locName"
		Me.lblWCLocation7.DSSLocation = 7
		Me.lblWCLocation7.DSSOffset = 0R
		Me.lblWCLocation7.Location = New System.Drawing.Point(26, 180)
		Me.lblWCLocation7.Name = "lblWCLocation7"
		Me.lblWCLocation7.Size = New System.Drawing.Size(50, 13)
		Me.lblWCLocation7.TabIndex = 122
		Me.lblWCLocation7.Text = "location7"
		'
		'lblWCLocation6
		'
		Me.lblWCLocation6.AutoSize = True
		Me.lblWCLocation6.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWCLocation6.DSSElementName = "locName"
		Me.lblWCLocation6.DSSLocation = 6
		Me.lblWCLocation6.DSSOffset = 0R
		Me.lblWCLocation6.Location = New System.Drawing.Point(26, 157)
		Me.lblWCLocation6.Name = "lblWCLocation6"
		Me.lblWCLocation6.Size = New System.Drawing.Size(50, 13)
		Me.lblWCLocation6.TabIndex = 121
		Me.lblWCLocation6.Text = "location6"
		'
		'lblWCLocation5
		'
		Me.lblWCLocation5.AutoSize = True
		Me.lblWCLocation5.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWCLocation5.DSSElementName = "locName"
		Me.lblWCLocation5.DSSLocation = 5
		Me.lblWCLocation5.DSSOffset = 0R
		Me.lblWCLocation5.Location = New System.Drawing.Point(26, 134)
		Me.lblWCLocation5.Name = "lblWCLocation5"
		Me.lblWCLocation5.Size = New System.Drawing.Size(50, 13)
		Me.lblWCLocation5.TabIndex = 120
		Me.lblWCLocation5.Text = "location5"
		'
		'lblWCLocation4
		'
		Me.lblWCLocation4.AutoSize = True
		Me.lblWCLocation4.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWCLocation4.DSSElementName = "locName"
		Me.lblWCLocation4.DSSLocation = 4
		Me.lblWCLocation4.DSSOffset = 0R
		Me.lblWCLocation4.Location = New System.Drawing.Point(26, 111)
		Me.lblWCLocation4.Name = "lblWCLocation4"
		Me.lblWCLocation4.Size = New System.Drawing.Size(50, 13)
		Me.lblWCLocation4.TabIndex = 119
		Me.lblWCLocation4.Text = "location4"
		'
		'lblWCLocation3
		'
		Me.lblWCLocation3.AutoSize = True
		Me.lblWCLocation3.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWCLocation3.DSSElementName = "locName"
		Me.lblWCLocation3.DSSLocation = 3
		Me.lblWCLocation3.DSSOffset = 0R
		Me.lblWCLocation3.Location = New System.Drawing.Point(26, 88)
		Me.lblWCLocation3.Name = "lblWCLocation3"
		Me.lblWCLocation3.Size = New System.Drawing.Size(50, 13)
		Me.lblWCLocation3.TabIndex = 118
		Me.lblWCLocation3.Text = "location3"
		'
		'lblWCLocation2
		'
		Me.lblWCLocation2.AutoSize = True
		Me.lblWCLocation2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWCLocation2.DSSElementName = "locName"
		Me.lblWCLocation2.DSSLocation = 2
		Me.lblWCLocation2.DSSOffset = 0R
		Me.lblWCLocation2.Location = New System.Drawing.Point(26, 65)
		Me.lblWCLocation2.Name = "lblWCLocation2"
		Me.lblWCLocation2.Size = New System.Drawing.Size(50, 13)
		Me.lblWCLocation2.TabIndex = 117
		Me.lblWCLocation2.Text = "location2"
		'
		'lblWCLocation1
		'
		Me.lblWCLocation1.AutoSize = True
		Me.lblWCLocation1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWCLocation1.DSSElementName = "locName"
		Me.lblWCLocation1.DSSLocation = 1
		Me.lblWCLocation1.DSSOffset = 0R
		Me.lblWCLocation1.Location = New System.Drawing.Point(26, 42)
		Me.lblWCLocation1.Name = "lblWCLocation1"
		Me.lblWCLocation1.Size = New System.Drawing.Size(50, 13)
		Me.lblWCLocation1.TabIndex = 116
		Me.lblWCLocation1.Text = "location1"
		'
		'lblWCLocation13
		'
		Me.lblWCLocation13.AutoSize = True
		Me.lblWCLocation13.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWCLocation13.DSSElementName = "locNAme"
		Me.lblWCLocation13.DSSLocation = 13
		Me.lblWCLocation13.DSSOffset = 0R
		Me.lblWCLocation13.Location = New System.Drawing.Point(26, 318)
		Me.lblWCLocation13.Name = "lblWCLocation13"
		Me.lblWCLocation13.Size = New System.Drawing.Size(56, 13)
		Me.lblWCLocation13.TabIndex = 115
		Me.lblWCLocation13.Text = "location13"
		'
		'pnlGro
		'
		Me.pnlGro.Controls.Add(Me.nudGro14)
		Me.pnlGro.Controls.Add(Me.nudGro15)
		Me.pnlGro.Controls.Add(Me.Label121)
		Me.pnlGro.Controls.Add(Me.nudGro3)
		Me.pnlGro.Controls.Add(Me.nudGro7)
		Me.pnlGro.Controls.Add(Me.nudGro2)
		Me.pnlGro.Controls.Add(Me.nudGro12)
		Me.pnlGro.Controls.Add(Me.nudGro10)
		Me.pnlGro.Controls.Add(Me.nudGro13)
		Me.pnlGro.Controls.Add(Me.nudGro6)
		Me.pnlGro.Controls.Add(Me.nudGro8)
		Me.pnlGro.Controls.Add(Me.nudGro1)
		Me.pnlGro.Controls.Add(Me.nudGro4)
		Me.pnlGro.Controls.Add(Me.nudGro9)
		Me.pnlGro.Controls.Add(Me.nudGro11)
		Me.pnlGro.Controls.Add(Me.nudGro5)
		Me.pnlGro.Location = New System.Drawing.Point(238, 12)
		Me.pnlGro.Name = "pnlGro"
		Me.pnlGro.Size = New System.Drawing.Size(90, 390)
		Me.pnlGro.TabIndex = 114
		'
		'nudGro14
		'
		Me.nudGro14.DecimalPlaces = 2
		Me.nudGro14.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(160, Byte), CType(0, Byte))
		Me.nudGro14.DSSElementName = "agrcc14_1"
		Me.nudGro14.DSSLocation = 14
		Me.nudGro14.DSSOffset = 0.2R
		Me.nudGro14.Location = New System.Drawing.Point(0, 327)
		Me.nudGro14.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudGro14.Name = "nudGro14"
		Me.nudGro14.Size = New System.Drawing.Size(90, 20)
		Me.nudGro14.TabIndex = 113
		Me.nudGro14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudGro14.Value = New Decimal(New Integer() {3, 0, 0, 65536})
		'
		'nudGro15
		'
		Me.nudGro15.DecimalPlaces = 2
		Me.nudGro15.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(160, Byte), CType(0, Byte))
		Me.nudGro15.DSSElementName = "agrcc15_1"
		Me.nudGro15.DSSLocation = 15
		Me.nudGro15.DSSOffset = 0.2R
		Me.nudGro15.Location = New System.Drawing.Point(0, 350)
		Me.nudGro15.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudGro15.Name = "nudGro15"
		Me.nudGro15.Size = New System.Drawing.Size(90, 20)
		Me.nudGro15.TabIndex = 114
		Me.nudGro15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudGro15.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'Label121
		'
		Me.Label121.Location = New System.Drawing.Point(0, 7)
		Me.Label121.Name = "Label121"
		Me.Label121.Size = New System.Drawing.Size(90, 13)
		Me.Label121.TabIndex = 4
		Me.Label121.Text = "Gro"
		Me.Label121.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'nudGro3
		'
		Me.nudGro3.DecimalPlaces = 2
		Me.nudGro3.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(160, Byte), CType(0, Byte))
		Me.nudGro3.DSSElementName = "agrcc3_1"
		Me.nudGro3.DSSLocation = 3
		Me.nudGro3.DSSOffset = 0.2R
		Me.nudGro3.Location = New System.Drawing.Point(0, 73)
		Me.nudGro3.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudGro3.Name = "nudGro3"
		Me.nudGro3.Size = New System.Drawing.Size(90, 20)
		Me.nudGro3.TabIndex = 102
		Me.nudGro3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudGro3.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudGro7
		'
		Me.nudGro7.DecimalPlaces = 2
		Me.nudGro7.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(160, Byte), CType(0, Byte))
		Me.nudGro7.DSSElementName = "agrcc7_1"
		Me.nudGro7.DSSLocation = 7
		Me.nudGro7.DSSOffset = 0.2R
		Me.nudGro7.Location = New System.Drawing.Point(0, 165)
		Me.nudGro7.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudGro7.Name = "nudGro7"
		Me.nudGro7.Size = New System.Drawing.Size(90, 20)
		Me.nudGro7.TabIndex = 106
		Me.nudGro7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudGro7.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudGro2
		'
		Me.nudGro2.DecimalPlaces = 2
		Me.nudGro2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(160, Byte), CType(0, Byte))
		Me.nudGro2.DSSElementName = "agrcc2_1"
		Me.nudGro2.DSSLocation = 2
		Me.nudGro2.DSSOffset = 0.2R
		Me.nudGro2.Location = New System.Drawing.Point(0, 50)
		Me.nudGro2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudGro2.Name = "nudGro2"
		Me.nudGro2.Size = New System.Drawing.Size(90, 20)
		Me.nudGro2.TabIndex = 101
		Me.nudGro2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudGro2.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudGro12
		'
		Me.nudGro12.DecimalPlaces = 2
		Me.nudGro12.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(160, Byte), CType(0, Byte))
		Me.nudGro12.DSSElementName = "agrcc12_1"
		Me.nudGro12.DSSLocation = 12
		Me.nudGro12.DSSOffset = 0.2R
		Me.nudGro12.Location = New System.Drawing.Point(0, 280)
		Me.nudGro12.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudGro12.Name = "nudGro12"
		Me.nudGro12.Size = New System.Drawing.Size(90, 20)
		Me.nudGro12.TabIndex = 111
		Me.nudGro12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudGro12.Value = New Decimal(New Integer() {3, 0, 0, 65536})
		'
		'nudGro10
		'
		Me.nudGro10.DecimalPlaces = 2
		Me.nudGro10.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(160, Byte), CType(0, Byte))
		Me.nudGro10.DSSElementName = "agrcc10_1"
		Me.nudGro10.DSSLocation = 10
		Me.nudGro10.DSSOffset = 0.2R
		Me.nudGro10.Location = New System.Drawing.Point(0, 234)
		Me.nudGro10.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudGro10.Name = "nudGro10"
		Me.nudGro10.Size = New System.Drawing.Size(90, 20)
		Me.nudGro10.TabIndex = 109
		Me.nudGro10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudGro10.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'nudGro13
		'
		Me.nudGro13.DecimalPlaces = 2
		Me.nudGro13.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(160, Byte), CType(0, Byte))
		Me.nudGro13.DSSElementName = "agrcc13_1"
		Me.nudGro13.DSSLocation = 13
		Me.nudGro13.DSSOffset = 0.2R
		Me.nudGro13.Location = New System.Drawing.Point(0, 303)
		Me.nudGro13.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudGro13.Name = "nudGro13"
		Me.nudGro13.Size = New System.Drawing.Size(90, 20)
		Me.nudGro13.TabIndex = 112
		Me.nudGro13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudGro13.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'nudGro6
		'
		Me.nudGro6.DecimalPlaces = 2
		Me.nudGro6.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(160, Byte), CType(0, Byte))
		Me.nudGro6.DSSElementName = "agrcc6_1"
		Me.nudGro6.DSSLocation = 6
		Me.nudGro6.DSSOffset = 0.2R
		Me.nudGro6.Location = New System.Drawing.Point(0, 142)
		Me.nudGro6.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudGro6.Name = "nudGro6"
		Me.nudGro6.Size = New System.Drawing.Size(90, 20)
		Me.nudGro6.TabIndex = 105
		Me.nudGro6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudGro6.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudGro8
		'
		Me.nudGro8.DecimalPlaces = 2
		Me.nudGro8.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(160, Byte), CType(0, Byte))
		Me.nudGro8.DSSElementName = "agrcc8_1"
		Me.nudGro8.DSSLocation = 8
		Me.nudGro8.DSSOffset = 0.2R
		Me.nudGro8.Location = New System.Drawing.Point(0, 188)
		Me.nudGro8.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudGro8.Name = "nudGro8"
		Me.nudGro8.Size = New System.Drawing.Size(90, 20)
		Me.nudGro8.TabIndex = 107
		Me.nudGro8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudGro8.Value = New Decimal(New Integer() {6, 0, 0, 65536})
		'
		'nudGro1
		'
		Me.nudGro1.DecimalPlaces = 2
		Me.nudGro1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(160, Byte), CType(0, Byte))
		Me.nudGro1.DSSElementName = "agrcc1_1"
		Me.nudGro1.DSSLocation = 1
		Me.nudGro1.DSSOffset = 0.2R
		Me.nudGro1.Location = New System.Drawing.Point(0, 27)
		Me.nudGro1.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudGro1.Name = "nudGro1"
		Me.nudGro1.Size = New System.Drawing.Size(90, 20)
		Me.nudGro1.TabIndex = 100
		Me.nudGro1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudGro1.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudGro4
		'
		Me.nudGro4.DecimalPlaces = 2
		Me.nudGro4.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(160, Byte), CType(0, Byte))
		Me.nudGro4.DSSElementName = "agrcc4_1"
		Me.nudGro4.DSSLocation = 4
		Me.nudGro4.DSSOffset = 0.2R
		Me.nudGro4.Location = New System.Drawing.Point(0, 96)
		Me.nudGro4.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudGro4.Name = "nudGro4"
		Me.nudGro4.Size = New System.Drawing.Size(90, 20)
		Me.nudGro4.TabIndex = 103
		Me.nudGro4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudGro4.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudGro9
		'
		Me.nudGro9.DecimalPlaces = 2
		Me.nudGro9.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(160, Byte), CType(0, Byte))
		Me.nudGro9.DSSElementName = "agrcc9_1"
		Me.nudGro9.DSSLocation = 9
		Me.nudGro9.DSSOffset = 0.2R
		Me.nudGro9.Location = New System.Drawing.Point(0, 211)
		Me.nudGro9.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudGro9.Name = "nudGro9"
		Me.nudGro9.Size = New System.Drawing.Size(90, 20)
		Me.nudGro9.TabIndex = 108
		Me.nudGro9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudGro9.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'nudGro11
		'
		Me.nudGro11.DecimalPlaces = 2
		Me.nudGro11.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(160, Byte), CType(0, Byte))
		Me.nudGro11.DSSElementName = "agrcc11_1"
		Me.nudGro11.DSSLocation = 11
		Me.nudGro11.DSSOffset = 0.2R
		Me.nudGro11.Location = New System.Drawing.Point(0, 257)
		Me.nudGro11.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudGro11.Name = "nudGro11"
		Me.nudGro11.Size = New System.Drawing.Size(90, 20)
		Me.nudGro11.TabIndex = 110
		Me.nudGro11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudGro11.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudGro5
		'
		Me.nudGro5.DecimalPlaces = 2
		Me.nudGro5.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(160, Byte), CType(0, Byte))
		Me.nudGro5.DSSElementName = "agrcc5_1"
		Me.nudGro5.DSSLocation = 5
		Me.nudGro5.DSSOffset = 0.2R
		Me.nudGro5.Location = New System.Drawing.Point(0, 119)
		Me.nudGro5.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudGro5.Name = "nudGro5"
		Me.nudGro5.Size = New System.Drawing.Size(90, 20)
		Me.nudGro5.TabIndex = 104
		Me.nudGro5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudGro5.Value = New Decimal(New Integer() {8, 0, 0, 65536})
		'
		'pnlDes
		'
		Me.pnlDes.Controls.Add(Me.nudDes14)
		Me.pnlDes.Controls.Add(Me.nudDes15)
		Me.pnlDes.Controls.Add(Me.Label120)
		Me.pnlDes.Controls.Add(Me.nudDes3)
		Me.pnlDes.Controls.Add(Me.nudDes7)
		Me.pnlDes.Controls.Add(Me.nudDes2)
		Me.pnlDes.Controls.Add(Me.nudDes6)
		Me.pnlDes.Controls.Add(Me.nudDes12)
		Me.pnlDes.Controls.Add(Me.nudDes1)
		Me.pnlDes.Controls.Add(Me.nudDes9)
		Me.pnlDes.Controls.Add(Me.nudDes13)
		Me.pnlDes.Controls.Add(Me.nudDes10)
		Me.pnlDes.Controls.Add(Me.nudDes11)
		Me.pnlDes.Controls.Add(Me.nudDes8)
		Me.pnlDes.Controls.Add(Me.nudDes5)
		Me.pnlDes.Controls.Add(Me.nudDes4)
		Me.pnlDes.Location = New System.Drawing.Point(133, 12)
		Me.pnlDes.Name = "pnlDes"
		Me.pnlDes.Size = New System.Drawing.Size(90, 390)
		Me.pnlDes.TabIndex = 113
		'
		'nudDes14
		'
		Me.nudDes14.DecimalPlaces = 2
		Me.nudDes14.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(197, Byte), CType(124, Byte), CType(0, Byte))
		Me.nudDes14.DSSElementName = "indCC14_1"
		Me.nudDes14.DSSLocation = 14
		Me.nudDes14.DSSOffset = -0.2R
		Me.nudDes14.Location = New System.Drawing.Point(0, 327)
		Me.nudDes14.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudDes14.Name = "nudDes14"
		Me.nudDes14.Size = New System.Drawing.Size(90, 20)
		Me.nudDes14.TabIndex = 14
		Me.nudDes14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudDes14.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudDes15
		'
		Me.nudDes15.DecimalPlaces = 2
		Me.nudDes15.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(197, Byte), CType(124, Byte), CType(0, Byte))
		Me.nudDes15.DSSElementName = "indCC15_1"
		Me.nudDes15.DSSLocation = 15
		Me.nudDes15.DSSOffset = -0.2R
		Me.nudDes15.Location = New System.Drawing.Point(0, 350)
		Me.nudDes15.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudDes15.Name = "nudDes15"
		Me.nudDes15.Size = New System.Drawing.Size(90, 20)
		Me.nudDes15.TabIndex = 15
		Me.nudDes15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudDes15.Value = New Decimal(New Integer() {1054794521, 0, 0, 589824})
		'
		'Label120
		'
		Me.Label120.Location = New System.Drawing.Point(0, 4)
		Me.Label120.Name = "Label120"
		Me.Label120.Size = New System.Drawing.Size(90, 13)
		Me.Label120.TabIndex = 4
		Me.Label120.Text = "Des"
		Me.Label120.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'nudDes3
		'
		Me.nudDes3.DecimalPlaces = 2
		Me.nudDes3.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(197, Byte), CType(124, Byte), CType(0, Byte))
		Me.nudDes3.DSSElementName = "indCC3_1"
		Me.nudDes3.DSSLocation = 3
		Me.nudDes3.DSSOffset = -0.2R
		Me.nudDes3.Location = New System.Drawing.Point(0, 73)
		Me.nudDes3.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudDes3.Name = "nudDes3"
		Me.nudDes3.Size = New System.Drawing.Size(90, 20)
		Me.nudDes3.TabIndex = 2
		Me.nudDes3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudDes3.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'nudDes7
		'
		Me.nudDes7.DecimalPlaces = 2
		Me.nudDes7.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(197, Byte), CType(124, Byte), CType(0, Byte))
		Me.nudDes7.DSSElementName = "indCC7_1"
		Me.nudDes7.DSSLocation = 7
		Me.nudDes7.DSSOffset = -0.2R
		Me.nudDes7.Location = New System.Drawing.Point(0, 165)
		Me.nudDes7.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudDes7.Name = "nudDes7"
		Me.nudDes7.Size = New System.Drawing.Size(90, 20)
		Me.nudDes7.TabIndex = 6
		Me.nudDes7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudDes7.Value = New Decimal(New Integer() {10, 0, 0, 0})
		'
		'nudDes2
		'
		Me.nudDes2.DecimalPlaces = 2
		Me.nudDes2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(197, Byte), CType(124, Byte), CType(0, Byte))
		Me.nudDes2.DSSElementName = "indCC2_1"
		Me.nudDes2.DSSLocation = 2
		Me.nudDes2.DSSOffset = -0.2R
		Me.nudDes2.Location = New System.Drawing.Point(0, 50)
		Me.nudDes2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudDes2.Name = "nudDes2"
		Me.nudDes2.Size = New System.Drawing.Size(90, 20)
		Me.nudDes2.TabIndex = 1
		Me.nudDes2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudDes2.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'nudDes6
		'
		Me.nudDes6.DecimalPlaces = 2
		Me.nudDes6.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(197, Byte), CType(124, Byte), CType(0, Byte))
		Me.nudDes6.DSSElementName = "indCC6_1"
		Me.nudDes6.DSSLocation = 6
		Me.nudDes6.DSSOffset = -0.2R
		Me.nudDes6.Location = New System.Drawing.Point(0, 142)
		Me.nudDes6.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudDes6.Name = "nudDes6"
		Me.nudDes6.Size = New System.Drawing.Size(90, 20)
		Me.nudDes6.TabIndex = 5
		Me.nudDes6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudDes6.Value = New Decimal(New Integer() {6, 0, 0, 0})
		'
		'nudDes12
		'
		Me.nudDes12.DecimalPlaces = 2
		Me.nudDes12.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(197, Byte), CType(124, Byte), CType(0, Byte))
		Me.nudDes12.DSSElementName = "indCC12_1"
		Me.nudDes12.DSSLocation = 12
		Me.nudDes12.DSSOffset = -0.2R
		Me.nudDes12.Location = New System.Drawing.Point(0, 280)
		Me.nudDes12.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudDes12.Name = "nudDes12"
		Me.nudDes12.Size = New System.Drawing.Size(90, 20)
		Me.nudDes12.TabIndex = 11
		Me.nudDes12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudDes12.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudDes1
		'
		Me.nudDes1.DecimalPlaces = 2
		Me.nudDes1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(197, Byte), CType(124, Byte), CType(0, Byte))
		Me.nudDes1.DSSElementName = "indCC1_1"
		Me.nudDes1.DSSLocation = 1
		Me.nudDes1.DSSOffset = -0.2R
		Me.nudDes1.Location = New System.Drawing.Point(0, 27)
		Me.nudDes1.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudDes1.Name = "nudDes1"
		Me.nudDes1.Size = New System.Drawing.Size(90, 20)
		Me.nudDes1.TabIndex = 0
		Me.nudDes1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudDes1.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'nudDes9
		'
		Me.nudDes9.DecimalPlaces = 2
		Me.nudDes9.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(197, Byte), CType(124, Byte), CType(0, Byte))
		Me.nudDes9.DSSElementName = "indCC9_1"
		Me.nudDes9.DSSLocation = 9
		Me.nudDes9.DSSOffset = -0.2R
		Me.nudDes9.Location = New System.Drawing.Point(0, 211)
		Me.nudDes9.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudDes9.Name = "nudDes9"
		Me.nudDes9.Size = New System.Drawing.Size(90, 20)
		Me.nudDes9.TabIndex = 8
		Me.nudDes9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudDes9.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudDes13
		'
		Me.nudDes13.DecimalPlaces = 2
		Me.nudDes13.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(197, Byte), CType(124, Byte), CType(0, Byte))
		Me.nudDes13.DSSElementName = "indCC13_1"
		Me.nudDes13.DSSLocation = 13
		Me.nudDes13.DSSOffset = -0.2R
		Me.nudDes13.Location = New System.Drawing.Point(0, 303)
		Me.nudDes13.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudDes13.Name = "nudDes13"
		Me.nudDes13.Size = New System.Drawing.Size(90, 20)
		Me.nudDes13.TabIndex = 12
		Me.nudDes13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudDes13.Value = New Decimal(New Integer() {1054794521, 0, 0, 589824})
		'
		'nudDes10
		'
		Me.nudDes10.DecimalPlaces = 2
		Me.nudDes10.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(197, Byte), CType(124, Byte), CType(0, Byte))
		Me.nudDes10.DSSElementName = "indCC10_1"
		Me.nudDes10.DSSLocation = 10
		Me.nudDes10.DSSOffset = -0.2R
		Me.nudDes10.Location = New System.Drawing.Point(0, 234)
		Me.nudDes10.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudDes10.Name = "nudDes10"
		Me.nudDes10.Size = New System.Drawing.Size(90, 20)
		Me.nudDes10.TabIndex = 9
		Me.nudDes10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudDes10.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudDes11
		'
		Me.nudDes11.DecimalPlaces = 2
		Me.nudDes11.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(197, Byte), CType(124, Byte), CType(0, Byte))
		Me.nudDes11.DSSElementName = "indCC11_1"
		Me.nudDes11.DSSLocation = 11
		Me.nudDes11.DSSOffset = -0.2R
		Me.nudDes11.Location = New System.Drawing.Point(0, 257)
		Me.nudDes11.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudDes11.Name = "nudDes11"
		Me.nudDes11.Size = New System.Drawing.Size(90, 20)
		Me.nudDes11.TabIndex = 10
		Me.nudDes11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudDes11.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudDes8
		'
		Me.nudDes8.DecimalPlaces = 2
		Me.nudDes8.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(197, Byte), CType(124, Byte), CType(0, Byte))
		Me.nudDes8.DSSElementName = "indCC8_1"
		Me.nudDes8.DSSLocation = 8
		Me.nudDes8.DSSOffset = -0.2R
		Me.nudDes8.Location = New System.Drawing.Point(0, 188)
		Me.nudDes8.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudDes8.Name = "nudDes8"
		Me.nudDes8.Size = New System.Drawing.Size(90, 20)
		Me.nudDes8.TabIndex = 7
		Me.nudDes8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudDes8.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'nudDes5
		'
		Me.nudDes5.DecimalPlaces = 2
		Me.nudDes5.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(197, Byte), CType(124, Byte), CType(0, Byte))
		Me.nudDes5.DSSElementName = "indCC5_1"
		Me.nudDes5.DSSLocation = 5
		Me.nudDes5.DSSOffset = -0.2R
		Me.nudDes5.Location = New System.Drawing.Point(0, 119)
		Me.nudDes5.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudDes5.Name = "nudDes5"
		Me.nudDes5.Size = New System.Drawing.Size(90, 20)
		Me.nudDes5.TabIndex = 4
		Me.nudDes5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudDes5.Value = New Decimal(New Integer() {12, 0, 0, 0})
		'
		'nudDes4
		'
		Me.nudDes4.DecimalPlaces = 2
		Me.nudDes4.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(197, Byte), CType(124, Byte), CType(0, Byte))
		Me.nudDes4.DSSElementName = "indCC4_1"
		Me.nudDes4.DSSLocation = 4
		Me.nudDes4.DSSOffset = -0.2R
		Me.nudDes4.Location = New System.Drawing.Point(0, 96)
		Me.nudDes4.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudDes4.Name = "nudDes4"
		Me.nudDes4.Size = New System.Drawing.Size(90, 20)
		Me.nudDes4.TabIndex = 3
		Me.nudDes4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudDes4.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'grbOuput
		'
		Me.grbOuput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.grbOuput.Controls.Add(Me.tcoOutput)
		Me.grbOuput.DSSDrawOnMap = False
		Me.grbOuput.ForeColor = System.Drawing.Color.Black
		Me.grbOuput.Location = New System.Drawing.Point(0, 0)
		Me.grbOuput.Name = "grbOuput"
		Me.grbOuput.Size = New System.Drawing.Size(479, 516)
		Me.grbOuput.TabIndex = 26
		Me.grbOuput.TabStop = False
		Me.grbOuput.Text = "Summary"
		Me.grbOuput.Visible = False
		'
		'tcoOutput
		'
		Me.tcoOutput.Controls.Add(Me.tpaUses)
		Me.tcoOutput.Controls.Add(Me.tpaImpacts)
		Me.tcoOutput.Controls.Add(Me.tpaWeights)
		Me.tcoOutput.Controls.Add(Me.tpaStandards)
		Me.tcoOutput.Controls.Add(Me.tpaEfficencies)
		Me.tcoOutput.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tcoOutput.Location = New System.Drawing.Point(3, 16)
		Me.tcoOutput.Name = "tcoOutput"
		Me.tcoOutput.SelectedIndex = 0
		Me.tcoOutput.Size = New System.Drawing.Size(473, 497)
		Me.tcoOutput.TabIndex = 0
		'
		'tpaUses
		'
		Me.tpaUses.Controls.Add(Me.gboOutputUses)
		Me.tpaUses.Location = New System.Drawing.Point(4, 22)
		Me.tpaUses.Name = "tpaUses"
		Me.tpaUses.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaUses.Size = New System.Drawing.Size(465, 471)
		Me.tpaUses.TabIndex = 0
		Me.tpaUses.Text = "Uses"
		Me.tpaUses.UseVisualStyleBackColor = True
		'
		'gboOutputUses
		'
		Me.gboOutputUses.Controls.Add(Me.lblUSLocation15)
		Me.gboOutputUses.Controls.Add(Me.lblUSLocation14)
		Me.gboOutputUses.Controls.Add(Me.lblUSLocation12)
		Me.gboOutputUses.Controls.Add(Me.lblUSLocation1)
		Me.gboOutputUses.Controls.Add(Me.lblUSLocation11)
		Me.gboOutputUses.Controls.Add(Me.lblUSLocation5)
		Me.gboOutputUses.Controls.Add(Me.lblUSLocation6)
		Me.gboOutputUses.Controls.Add(Me.lblUSLocation10)
		Me.gboOutputUses.Controls.Add(Me.lblUSLocation4)
		Me.gboOutputUses.Controls.Add(Me.lblUSLocation13)
		Me.gboOutputUses.Controls.Add(Me.lblUSLocation7)
		Me.gboOutputUses.Controls.Add(Me.lblUSLocation9)
		Me.gboOutputUses.Controls.Add(Me.lblUSLocation3)
		Me.gboOutputUses.Controls.Add(Me.lblUSLocation2)
		Me.gboOutputUses.Controls.Add(Me.lblUSLocation8)
		Me.gboOutputUses.Controls.Add(Me.pnlOutAgrSmall)
		Me.gboOutputUses.Controls.Add(Me.Label94)
		Me.gboOutputUses.Controls.Add(Me.pnlOutIndLarge)
		Me.gboOutputUses.Controls.Add(Me.Label93)
		Me.gboOutputUses.Controls.Add(Me.Label87)
		Me.gboOutputUses.Controls.Add(Me.pnlOutLanSmall)
		Me.gboOutputUses.Controls.Add(Me.Label89)
		Me.gboOutputUses.Controls.Add(Me.pnlOutLanLarge)
		Me.gboOutputUses.Controls.Add(Me.Label90)
		Me.gboOutputUses.Controls.Add(Me.pnlOutAgrLarge)
		Me.gboOutputUses.Controls.Add(Me.Label135)
		Me.gboOutputUses.Controls.Add(Me.Label133)
		Me.gboOutputUses.Location = New System.Drawing.Point(15, 15)
		Me.gboOutputUses.Name = "gboOutputUses"
		Me.gboOutputUses.Size = New System.Drawing.Size(451, 406)
		Me.gboOutputUses.TabIndex = 112
		Me.gboOutputUses.TabStop = False
		Me.gboOutputUses.Visible = False
		'
		'lblUSLocation15
		'
		Me.lblUSLocation15.AutoSize = True
		Me.lblUSLocation15.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblUSLocation15.DSSElementName = "locName"
		Me.lblUSLocation15.DSSLocation = 15
		Me.lblUSLocation15.DSSOffset = 0R
		Me.lblUSLocation15.Location = New System.Drawing.Point(18, 379)
		Me.lblUSLocation15.Name = "lblUSLocation15"
		Me.lblUSLocation15.Size = New System.Drawing.Size(56, 13)
		Me.lblUSLocation15.TabIndex = 190
		Me.lblUSLocation15.Text = "location15"
		'
		'lblUSLocation14
		'
		Me.lblUSLocation14.AutoSize = True
		Me.lblUSLocation14.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblUSLocation14.DSSElementName = "locName"
		Me.lblUSLocation14.DSSLocation = 14
		Me.lblUSLocation14.DSSOffset = 0R
		Me.lblUSLocation14.Location = New System.Drawing.Point(18, 356)
		Me.lblUSLocation14.Name = "lblUSLocation14"
		Me.lblUSLocation14.Size = New System.Drawing.Size(56, 13)
		Me.lblUSLocation14.TabIndex = 189
		Me.lblUSLocation14.Text = "location14"
		'
		'lblUSLocation12
		'
		Me.lblUSLocation12.AutoSize = True
		Me.lblUSLocation12.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblUSLocation12.DSSElementName = "locName"
		Me.lblUSLocation12.DSSLocation = 12
		Me.lblUSLocation12.DSSOffset = 0R
		Me.lblUSLocation12.Location = New System.Drawing.Point(18, 310)
		Me.lblUSLocation12.Name = "lblUSLocation12"
		Me.lblUSLocation12.Size = New System.Drawing.Size(56, 13)
		Me.lblUSLocation12.TabIndex = 188
		Me.lblUSLocation12.Text = "location12"
		'
		'lblUSLocation1
		'
		Me.lblUSLocation1.AutoSize = True
		Me.lblUSLocation1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblUSLocation1.DSSElementName = "locName"
		Me.lblUSLocation1.DSSLocation = 1
		Me.lblUSLocation1.DSSOffset = 0R
		Me.lblUSLocation1.Location = New System.Drawing.Point(18, 57)
		Me.lblUSLocation1.Name = "lblUSLocation1"
		Me.lblUSLocation1.Size = New System.Drawing.Size(50, 13)
		Me.lblUSLocation1.TabIndex = 177
		Me.lblUSLocation1.Text = "location1"
		'
		'lblUSLocation11
		'
		Me.lblUSLocation11.AutoSize = True
		Me.lblUSLocation11.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblUSLocation11.DSSElementName = "locName"
		Me.lblUSLocation11.DSSLocation = 11
		Me.lblUSLocation11.DSSOffset = 0R
		Me.lblUSLocation11.Location = New System.Drawing.Point(18, 287)
		Me.lblUSLocation11.Name = "lblUSLocation11"
		Me.lblUSLocation11.Size = New System.Drawing.Size(56, 13)
		Me.lblUSLocation11.TabIndex = 187
		Me.lblUSLocation11.Text = "location11"
		'
		'lblUSLocation5
		'
		Me.lblUSLocation5.AccessibleDescription = ""
		Me.lblUSLocation5.AutoSize = True
		Me.lblUSLocation5.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblUSLocation5.DSSElementName = "locName"
		Me.lblUSLocation5.DSSLocation = 5
		Me.lblUSLocation5.DSSOffset = 0R
		Me.lblUSLocation5.Location = New System.Drawing.Point(18, 149)
		Me.lblUSLocation5.Name = "lblUSLocation5"
		Me.lblUSLocation5.Size = New System.Drawing.Size(50, 13)
		Me.lblUSLocation5.TabIndex = 181
		Me.lblUSLocation5.Text = "location5"
		'
		'lblUSLocation6
		'
		Me.lblUSLocation6.AutoSize = True
		Me.lblUSLocation6.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblUSLocation6.DSSElementName = "locName"
		Me.lblUSLocation6.DSSLocation = 6
		Me.lblUSLocation6.DSSOffset = 0R
		Me.lblUSLocation6.Location = New System.Drawing.Point(18, 172)
		Me.lblUSLocation6.Name = "lblUSLocation6"
		Me.lblUSLocation6.Size = New System.Drawing.Size(50, 13)
		Me.lblUSLocation6.TabIndex = 182
		Me.lblUSLocation6.Text = "location6"
		'
		'lblUSLocation10
		'
		Me.lblUSLocation10.AutoSize = True
		Me.lblUSLocation10.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblUSLocation10.DSSElementName = "locName"
		Me.lblUSLocation10.DSSLocation = 10
		Me.lblUSLocation10.DSSOffset = 0R
		Me.lblUSLocation10.Location = New System.Drawing.Point(18, 264)
		Me.lblUSLocation10.Name = "lblUSLocation10"
		Me.lblUSLocation10.Size = New System.Drawing.Size(56, 13)
		Me.lblUSLocation10.TabIndex = 186
		Me.lblUSLocation10.Text = "location10"
		'
		'lblUSLocation4
		'
		Me.lblUSLocation4.AutoSize = True
		Me.lblUSLocation4.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblUSLocation4.DSSElementName = "locName"
		Me.lblUSLocation4.DSSLocation = 4
		Me.lblUSLocation4.DSSOffset = 0R
		Me.lblUSLocation4.Location = New System.Drawing.Point(18, 126)
		Me.lblUSLocation4.Name = "lblUSLocation4"
		Me.lblUSLocation4.Size = New System.Drawing.Size(50, 13)
		Me.lblUSLocation4.TabIndex = 180
		Me.lblUSLocation4.Text = "location4"
		'
		'lblUSLocation13
		'
		Me.lblUSLocation13.AutoSize = True
		Me.lblUSLocation13.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblUSLocation13.DSSElementName = "locNAme"
		Me.lblUSLocation13.DSSLocation = 13
		Me.lblUSLocation13.DSSOffset = 0R
		Me.lblUSLocation13.Location = New System.Drawing.Point(18, 333)
		Me.lblUSLocation13.Name = "lblUSLocation13"
		Me.lblUSLocation13.Size = New System.Drawing.Size(56, 13)
		Me.lblUSLocation13.TabIndex = 176
		Me.lblUSLocation13.Text = "location13"
		'
		'lblUSLocation7
		'
		Me.lblUSLocation7.AutoSize = True
		Me.lblUSLocation7.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblUSLocation7.DSSElementName = "locName"
		Me.lblUSLocation7.DSSLocation = 7
		Me.lblUSLocation7.DSSOffset = 0R
		Me.lblUSLocation7.Location = New System.Drawing.Point(18, 195)
		Me.lblUSLocation7.Name = "lblUSLocation7"
		Me.lblUSLocation7.Size = New System.Drawing.Size(50, 13)
		Me.lblUSLocation7.TabIndex = 183
		Me.lblUSLocation7.Text = "location7"
		'
		'lblUSLocation9
		'
		Me.lblUSLocation9.AutoSize = True
		Me.lblUSLocation9.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblUSLocation9.DSSElementName = "locName"
		Me.lblUSLocation9.DSSLocation = 9
		Me.lblUSLocation9.DSSOffset = 0R
		Me.lblUSLocation9.Location = New System.Drawing.Point(18, 241)
		Me.lblUSLocation9.Name = "lblUSLocation9"
		Me.lblUSLocation9.Size = New System.Drawing.Size(50, 13)
		Me.lblUSLocation9.TabIndex = 185
		Me.lblUSLocation9.Text = "location9"
		'
		'lblUSLocation3
		'
		Me.lblUSLocation3.AutoSize = True
		Me.lblUSLocation3.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblUSLocation3.DSSElementName = "locName"
		Me.lblUSLocation3.DSSLocation = 3
		Me.lblUSLocation3.DSSOffset = 0R
		Me.lblUSLocation3.Location = New System.Drawing.Point(18, 103)
		Me.lblUSLocation3.Name = "lblUSLocation3"
		Me.lblUSLocation3.Size = New System.Drawing.Size(50, 13)
		Me.lblUSLocation3.TabIndex = 179
		Me.lblUSLocation3.Text = "location3"
		'
		'lblUSLocation2
		'
		Me.lblUSLocation2.AutoSize = True
		Me.lblUSLocation2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblUSLocation2.DSSElementName = "locName"
		Me.lblUSLocation2.DSSLocation = 2
		Me.lblUSLocation2.DSSOffset = 0R
		Me.lblUSLocation2.Location = New System.Drawing.Point(18, 80)
		Me.lblUSLocation2.Name = "lblUSLocation2"
		Me.lblUSLocation2.Size = New System.Drawing.Size(50, 13)
		Me.lblUSLocation2.TabIndex = 178
		Me.lblUSLocation2.Text = "location2"
		'
		'lblUSLocation8
		'
		Me.lblUSLocation8.AutoSize = True
		Me.lblUSLocation8.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblUSLocation8.DSSElementName = "locName"
		Me.lblUSLocation8.DSSLocation = 8
		Me.lblUSLocation8.DSSOffset = 0R
		Me.lblUSLocation8.Location = New System.Drawing.Point(18, 218)
		Me.lblUSLocation8.Name = "lblUSLocation8"
		Me.lblUSLocation8.Size = New System.Drawing.Size(50, 13)
		Me.lblUSLocation8.TabIndex = 184
		Me.lblUSLocation8.Text = "location8"
		'
		'pnlOutAgrSmall
		'
		Me.pnlOutAgrSmall.Controls.Add(Me.lblAgr15_1)
		Me.pnlOutAgrSmall.Controls.Add(Me.lblAgr14_1)
		Me.pnlOutAgrSmall.Controls.Add(Me.lblAgr1_1)
		Me.pnlOutAgrSmall.Controls.Add(Me.lblAgr5_1)
		Me.pnlOutAgrSmall.Controls.Add(Me.lblAgr4_1)
		Me.pnlOutAgrSmall.Controls.Add(Me.lblAgr8_1)
		Me.pnlOutAgrSmall.Controls.Add(Me.lblAgr11_1)
		Me.pnlOutAgrSmall.Controls.Add(Me.lblAgr2_1)
		Me.pnlOutAgrSmall.Controls.Add(Me.lblAgr6_1)
		Me.pnlOutAgrSmall.Controls.Add(Me.lblAgr9_1)
		Me.pnlOutAgrSmall.Controls.Add(Me.lblAgr12_1)
		Me.pnlOutAgrSmall.Controls.Add(Me.lblAgr3_1)
		Me.pnlOutAgrSmall.Controls.Add(Me.lblAgr7_1)
		Me.pnlOutAgrSmall.Controls.Add(Me.lblAgr10_1)
		Me.pnlOutAgrSmall.Controls.Add(Me.lblAgr13_1)
		Me.pnlOutAgrSmall.Location = New System.Drawing.Point(94, 55)
		Me.pnlOutAgrSmall.Name = "pnlOutAgrSmall"
		Me.pnlOutAgrSmall.Size = New System.Drawing.Size(49, 345)
		Me.pnlOutAgrSmall.TabIndex = 108
		'
		'lblAgr15_1
		'
		Me.lblAgr15_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblAgr15_1.DSSElementName = "OutAgr15_1"
		Me.lblAgr15_1.DSSLocation = 15
		Me.lblAgr15_1.DSSOffset = -0.8R
		Me.lblAgr15_1.Location = New System.Drawing.Point(3, 317)
		Me.lblAgr15_1.Name = "lblAgr15_1"
		Me.lblAgr15_1.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr15_1.TabIndex = 65
		Me.lblAgr15_1.Text = "-"
		Me.lblAgr15_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr14_1
		'
		Me.lblAgr14_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblAgr14_1.DSSElementName = "OutAgr14_1"
		Me.lblAgr14_1.DSSLocation = 14
		Me.lblAgr14_1.DSSOffset = -0.8R
		Me.lblAgr14_1.Location = New System.Drawing.Point(3, 297)
		Me.lblAgr14_1.Name = "lblAgr14_1"
		Me.lblAgr14_1.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr14_1.TabIndex = 64
		Me.lblAgr14_1.Text = "-"
		Me.lblAgr14_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr1_1
		'
		Me.lblAgr1_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblAgr1_1.DSSElementName = "OutAgr1_1"
		Me.lblAgr1_1.DSSLocation = 1
		Me.lblAgr1_1.DSSOffset = -0.8R
		Me.lblAgr1_1.Location = New System.Drawing.Point(3, 1)
		Me.lblAgr1_1.Name = "lblAgr1_1"
		Me.lblAgr1_1.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr1_1.TabIndex = 63
		Me.lblAgr1_1.Text = "-"
		Me.lblAgr1_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr5_1
		'
		Me.lblAgr5_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblAgr5_1.DSSElementName = "OutAgr5_1"
		Me.lblAgr5_1.DSSLocation = 5
		Me.lblAgr5_1.DSSOffset = -0.8R
		Me.lblAgr5_1.Location = New System.Drawing.Point(3, 93)
		Me.lblAgr5_1.Name = "lblAgr5_1"
		Me.lblAgr5_1.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr5_1.TabIndex = 63
		Me.lblAgr5_1.Text = "-"
		Me.lblAgr5_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr4_1
		'
		Me.lblAgr4_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblAgr4_1.DSSElementName = "OutAgr4_1"
		Me.lblAgr4_1.DSSLocation = 4
		Me.lblAgr4_1.DSSOffset = -0.8R
		Me.lblAgr4_1.Location = New System.Drawing.Point(3, 70)
		Me.lblAgr4_1.Name = "lblAgr4_1"
		Me.lblAgr4_1.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr4_1.TabIndex = 63
		Me.lblAgr4_1.Text = "-"
		Me.lblAgr4_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr8_1
		'
		Me.lblAgr8_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblAgr8_1.DSSElementName = "OutAgr8_1"
		Me.lblAgr8_1.DSSLocation = 8
		Me.lblAgr8_1.DSSOffset = -0.8R
		Me.lblAgr8_1.Location = New System.Drawing.Point(3, 162)
		Me.lblAgr8_1.Name = "lblAgr8_1"
		Me.lblAgr8_1.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr8_1.TabIndex = 63
		Me.lblAgr8_1.Text = "-"
		Me.lblAgr8_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr11_1
		'
		Me.lblAgr11_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblAgr11_1.DSSElementName = "OutAgr11_1"
		Me.lblAgr11_1.DSSLocation = 11
		Me.lblAgr11_1.DSSOffset = -0.8R
		Me.lblAgr11_1.Location = New System.Drawing.Point(3, 231)
		Me.lblAgr11_1.Name = "lblAgr11_1"
		Me.lblAgr11_1.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr11_1.TabIndex = 63
		Me.lblAgr11_1.Text = "-"
		Me.lblAgr11_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr2_1
		'
		Me.lblAgr2_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblAgr2_1.DSSElementName = "OutAgr2_1"
		Me.lblAgr2_1.DSSLocation = 2
		Me.lblAgr2_1.DSSOffset = -0.8R
		Me.lblAgr2_1.Location = New System.Drawing.Point(3, 24)
		Me.lblAgr2_1.Name = "lblAgr2_1"
		Me.lblAgr2_1.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr2_1.TabIndex = 63
		Me.lblAgr2_1.Text = "-"
		Me.lblAgr2_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr6_1
		'
		Me.lblAgr6_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblAgr6_1.DSSElementName = "OutAgr6_1"
		Me.lblAgr6_1.DSSLocation = 6
		Me.lblAgr6_1.DSSOffset = -0.8R
		Me.lblAgr6_1.Location = New System.Drawing.Point(3, 116)
		Me.lblAgr6_1.Name = "lblAgr6_1"
		Me.lblAgr6_1.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr6_1.TabIndex = 63
		Me.lblAgr6_1.Text = "-"
		Me.lblAgr6_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr9_1
		'
		Me.lblAgr9_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblAgr9_1.DSSElementName = "OutAgr9_1"
		Me.lblAgr9_1.DSSLocation = 9
		Me.lblAgr9_1.DSSOffset = -0.8R
		Me.lblAgr9_1.Location = New System.Drawing.Point(3, 185)
		Me.lblAgr9_1.Name = "lblAgr9_1"
		Me.lblAgr9_1.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr9_1.TabIndex = 63
		Me.lblAgr9_1.Text = "-"
		Me.lblAgr9_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr12_1
		'
		Me.lblAgr12_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblAgr12_1.DSSElementName = "OutAgr12_1"
		Me.lblAgr12_1.DSSLocation = 12
		Me.lblAgr12_1.DSSOffset = -0.8R
		Me.lblAgr12_1.Location = New System.Drawing.Point(3, 254)
		Me.lblAgr12_1.Name = "lblAgr12_1"
		Me.lblAgr12_1.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr12_1.TabIndex = 63
		Me.lblAgr12_1.Text = "-"
		Me.lblAgr12_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr3_1
		'
		Me.lblAgr3_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblAgr3_1.DSSElementName = "OutAgr3_1"
		Me.lblAgr3_1.DSSLocation = 3
		Me.lblAgr3_1.DSSOffset = -0.8R
		Me.lblAgr3_1.Location = New System.Drawing.Point(3, 47)
		Me.lblAgr3_1.Name = "lblAgr3_1"
		Me.lblAgr3_1.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr3_1.TabIndex = 63
		Me.lblAgr3_1.Text = "-"
		Me.lblAgr3_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr7_1
		'
		Me.lblAgr7_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblAgr7_1.DSSElementName = "OutAgr7_1"
		Me.lblAgr7_1.DSSLocation = 7
		Me.lblAgr7_1.DSSOffset = -0.8R
		Me.lblAgr7_1.Location = New System.Drawing.Point(3, 139)
		Me.lblAgr7_1.Name = "lblAgr7_1"
		Me.lblAgr7_1.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr7_1.TabIndex = 63
		Me.lblAgr7_1.Text = "-"
		Me.lblAgr7_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr10_1
		'
		Me.lblAgr10_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblAgr10_1.DSSElementName = "OutAgr10_1"
		Me.lblAgr10_1.DSSLocation = 10
		Me.lblAgr10_1.DSSOffset = -0.8R
		Me.lblAgr10_1.Location = New System.Drawing.Point(3, 208)
		Me.lblAgr10_1.Name = "lblAgr10_1"
		Me.lblAgr10_1.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr10_1.TabIndex = 63
		Me.lblAgr10_1.Text = "-"
		Me.lblAgr10_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr13_1
		'
		Me.lblAgr13_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblAgr13_1.DSSElementName = "OutAgr13_1"
		Me.lblAgr13_1.DSSLocation = 13
		Me.lblAgr13_1.DSSOffset = -0.8R
		Me.lblAgr13_1.Location = New System.Drawing.Point(3, 277)
		Me.lblAgr13_1.Name = "lblAgr13_1"
		Me.lblAgr13_1.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr13_1.TabIndex = 63
		Me.lblAgr13_1.Text = "-"
		Me.lblAgr13_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Label94
		'
		Me.Label94.Location = New System.Drawing.Point(250, 7)
		Me.Label94.Name = "Label94"
		Me.Label94.Size = New System.Drawing.Size(97, 20)
		Me.Label94.TabIndex = 107
		Me.Label94.Text = "Medium"
		Me.Label94.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'pnlOutIndLarge
		'
		Me.pnlOutIndLarge.Controls.Add(Me.lblInd15_2)
		Me.pnlOutIndLarge.Controls.Add(Me.lblInd14_2)
		Me.pnlOutIndLarge.Controls.Add(Me.lblInd1_2)
		Me.pnlOutIndLarge.Controls.Add(Me.lblInd5_2)
		Me.pnlOutIndLarge.Controls.Add(Me.lblInd4_2)
		Me.pnlOutIndLarge.Controls.Add(Me.lblInd8_2)
		Me.pnlOutIndLarge.Controls.Add(Me.lblInd11_2)
		Me.pnlOutIndLarge.Controls.Add(Me.lblInd2_2)
		Me.pnlOutIndLarge.Controls.Add(Me.lblInd6_2)
		Me.pnlOutIndLarge.Controls.Add(Me.lblInd9_2)
		Me.pnlOutIndLarge.Controls.Add(Me.lblInd13_2)
		Me.pnlOutIndLarge.Controls.Add(Me.lblInd12_2)
		Me.pnlOutIndLarge.Controls.Add(Me.lblInd3_2)
		Me.pnlOutIndLarge.Controls.Add(Me.lblInd10_2)
		Me.pnlOutIndLarge.Controls.Add(Me.lblInd7_2)
		Me.pnlOutIndLarge.Location = New System.Drawing.Point(285, 55)
		Me.pnlOutIndLarge.Name = "pnlOutIndLarge"
		Me.pnlOutIndLarge.Size = New System.Drawing.Size(49, 345)
		Me.pnlOutIndLarge.TabIndex = 111
		'
		'lblInd15_2
		'
		Me.lblInd15_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd15_2.DSSElementName = "OutInd15_2"
		Me.lblInd15_2.DSSLocation = 15
		Me.lblInd15_2.DSSOffset = 0.4R
		Me.lblInd15_2.Location = New System.Drawing.Point(3, 317)
		Me.lblInd15_2.Name = "lblInd15_2"
		Me.lblInd15_2.Size = New System.Drawing.Size(34, 20)
		Me.lblInd15_2.TabIndex = 105
		Me.lblInd15_2.Text = "-"
		Me.lblInd15_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd14_2
		'
		Me.lblInd14_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd14_2.DSSElementName = "OutInd14_2"
		Me.lblInd14_2.DSSLocation = 14
		Me.lblInd14_2.DSSOffset = 0.4R
		Me.lblInd14_2.Location = New System.Drawing.Point(3, 294)
		Me.lblInd14_2.Name = "lblInd14_2"
		Me.lblInd14_2.Size = New System.Drawing.Size(34, 20)
		Me.lblInd14_2.TabIndex = 106
		Me.lblInd14_2.Text = "-"
		Me.lblInd14_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd1_2
		'
		Me.lblInd1_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd1_2.DSSElementName = "OutInd1_2"
		Me.lblInd1_2.DSSLocation = 1
		Me.lblInd1_2.DSSOffset = 0.4R
		Me.lblInd1_2.Location = New System.Drawing.Point(3, 1)
		Me.lblInd1_2.Name = "lblInd1_2"
		Me.lblInd1_2.Size = New System.Drawing.Size(34, 20)
		Me.lblInd1_2.TabIndex = 82
		Me.lblInd1_2.Text = "-"
		Me.lblInd1_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd5_2
		'
		Me.lblInd5_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd5_2.DSSElementName = "OutInd5_2"
		Me.lblInd5_2.DSSLocation = 5
		Me.lblInd5_2.DSSOffset = 0.4R
		Me.lblInd5_2.Location = New System.Drawing.Point(3, 93)
		Me.lblInd5_2.Name = "lblInd5_2"
		Me.lblInd5_2.Size = New System.Drawing.Size(34, 20)
		Me.lblInd5_2.TabIndex = 79
		Me.lblInd5_2.Text = "-"
		Me.lblInd5_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd4_2
		'
		Me.lblInd4_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd4_2.DSSElementName = "OutInd4_2"
		Me.lblInd4_2.DSSLocation = 4
		Me.lblInd4_2.DSSOffset = 0.4R
		Me.lblInd4_2.Location = New System.Drawing.Point(3, 70)
		Me.lblInd4_2.Name = "lblInd4_2"
		Me.lblInd4_2.Size = New System.Drawing.Size(34, 20)
		Me.lblInd4_2.TabIndex = 76
		Me.lblInd4_2.Text = "-"
		Me.lblInd4_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd8_2
		'
		Me.lblInd8_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd8_2.DSSElementName = "OutInd8_2"
		Me.lblInd8_2.DSSLocation = 8
		Me.lblInd8_2.DSSOffset = 0.4R
		Me.lblInd8_2.Location = New System.Drawing.Point(3, 162)
		Me.lblInd8_2.Name = "lblInd8_2"
		Me.lblInd8_2.Size = New System.Drawing.Size(34, 20)
		Me.lblInd8_2.TabIndex = 74
		Me.lblInd8_2.Text = "-"
		Me.lblInd8_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd11_2
		'
		Me.lblInd11_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd11_2.DSSElementName = "OutInd11_2"
		Me.lblInd11_2.DSSLocation = 11
		Me.lblInd11_2.DSSOffset = 0.4R
		Me.lblInd11_2.Location = New System.Drawing.Point(3, 231)
		Me.lblInd11_2.Name = "lblInd11_2"
		Me.lblInd11_2.Size = New System.Drawing.Size(34, 20)
		Me.lblInd11_2.TabIndex = 71
		Me.lblInd11_2.Text = "-"
		Me.lblInd11_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd2_2
		'
		Me.lblInd2_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd2_2.DSSElementName = "OutInd2_2"
		Me.lblInd2_2.DSSLocation = 2
		Me.lblInd2_2.DSSOffset = 0.4R
		Me.lblInd2_2.Location = New System.Drawing.Point(3, 24)
		Me.lblInd2_2.Name = "lblInd2_2"
		Me.lblInd2_2.Size = New System.Drawing.Size(34, 20)
		Me.lblInd2_2.TabIndex = 68
		Me.lblInd2_2.Text = "-"
		Me.lblInd2_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd6_2
		'
		Me.lblInd6_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd6_2.DSSElementName = "OutInd6_2"
		Me.lblInd6_2.DSSLocation = 6
		Me.lblInd6_2.DSSOffset = 0.4R
		Me.lblInd6_2.Location = New System.Drawing.Point(3, 116)
		Me.lblInd6_2.Name = "lblInd6_2"
		Me.lblInd6_2.Size = New System.Drawing.Size(34, 20)
		Me.lblInd6_2.TabIndex = 104
		Me.lblInd6_2.Text = "-"
		Me.lblInd6_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd9_2
		'
		Me.lblInd9_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd9_2.DSSElementName = "OutInd9_2"
		Me.lblInd9_2.DSSLocation = 9
		Me.lblInd9_2.DSSOffset = 0.4R
		Me.lblInd9_2.Location = New System.Drawing.Point(3, 185)
		Me.lblInd9_2.Name = "lblInd9_2"
		Me.lblInd9_2.Size = New System.Drawing.Size(34, 20)
		Me.lblInd9_2.TabIndex = 102
		Me.lblInd9_2.Text = "-"
		Me.lblInd9_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd13_2
		'
		Me.lblInd13_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd13_2.DSSElementName = "OutInd13_2"
		Me.lblInd13_2.DSSLocation = 13
		Me.lblInd13_2.DSSOffset = 0.4R
		Me.lblInd13_2.Location = New System.Drawing.Point(3, 277)
		Me.lblInd13_2.Name = "lblInd13_2"
		Me.lblInd13_2.Size = New System.Drawing.Size(34, 20)
		Me.lblInd13_2.TabIndex = 87
		Me.lblInd13_2.Text = "-"
		Me.lblInd13_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd12_2
		'
		Me.lblInd12_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd12_2.DSSElementName = "OutInd12_2"
		Me.lblInd12_2.DSSLocation = 12
		Me.lblInd12_2.DSSOffset = 0.4R
		Me.lblInd12_2.Location = New System.Drawing.Point(3, 254)
		Me.lblInd12_2.Name = "lblInd12_2"
		Me.lblInd12_2.Size = New System.Drawing.Size(34, 20)
		Me.lblInd12_2.TabIndex = 99
		Me.lblInd12_2.Text = "-"
		Me.lblInd12_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd3_2
		'
		Me.lblInd3_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd3_2.DSSElementName = "OutInd3_2"
		Me.lblInd3_2.DSSLocation = 3
		Me.lblInd3_2.DSSOffset = 0.4R
		Me.lblInd3_2.Location = New System.Drawing.Point(3, 47)
		Me.lblInd3_2.Name = "lblInd3_2"
		Me.lblInd3_2.Size = New System.Drawing.Size(34, 20)
		Me.lblInd3_2.TabIndex = 96
		Me.lblInd3_2.Text = "-"
		Me.lblInd3_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd10_2
		'
		Me.lblInd10_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd10_2.DSSElementName = "OutInd10_2"
		Me.lblInd10_2.DSSLocation = 10
		Me.lblInd10_2.DSSOffset = 0.4R
		Me.lblInd10_2.Location = New System.Drawing.Point(3, 208)
		Me.lblInd10_2.Name = "lblInd10_2"
		Me.lblInd10_2.Size = New System.Drawing.Size(34, 20)
		Me.lblInd10_2.TabIndex = 90
		Me.lblInd10_2.Text = "-"
		Me.lblInd10_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd7_2
		'
		Me.lblInd7_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd7_2.DSSElementName = "OutInd7_2"
		Me.lblInd7_2.DSSLocation = 7
		Me.lblInd7_2.DSSOffset = 0.4R
		Me.lblInd7_2.Location = New System.Drawing.Point(3, 139)
		Me.lblInd7_2.Name = "lblInd7_2"
		Me.lblInd7_2.Size = New System.Drawing.Size(34, 20)
		Me.lblInd7_2.TabIndex = 93
		Me.lblInd7_2.Text = "-"
		Me.lblInd7_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Label93
		'
		Me.Label93.Location = New System.Drawing.Point(113, 11)
		Me.Label93.Name = "Label93"
		Me.Label93.Size = New System.Drawing.Size(97, 20)
		Me.Label93.TabIndex = 106
		Me.Label93.Text = "Small"
		Me.Label93.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label87
		'
		Me.Label87.Location = New System.Drawing.Point(350, 31)
		Me.Label87.Name = "Label87"
		Me.Label87.Size = New System.Drawing.Size(34, 20)
		Me.Label87.TabIndex = 66
		Me.Label87.Text = "lan"
		Me.Label87.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'pnlOutLanSmall
		'
		Me.pnlOutLanSmall.Controls.Add(Me.lblLan14_1)
		Me.pnlOutLanSmall.Controls.Add(Me.lblLan15_1)
		Me.pnlOutLanSmall.Controls.Add(Me.lblLan1_1)
		Me.pnlOutLanSmall.Controls.Add(Me.lblLan5_1)
		Me.pnlOutLanSmall.Controls.Add(Me.lblLan4_1)
		Me.pnlOutLanSmall.Controls.Add(Me.lblLan8_1)
		Me.pnlOutLanSmall.Controls.Add(Me.lblLan11_1)
		Me.pnlOutLanSmall.Controls.Add(Me.lblLan2_1)
		Me.pnlOutLanSmall.Controls.Add(Me.lblLan6_1)
		Me.pnlOutLanSmall.Controls.Add(Me.lblLan9_1)
		Me.pnlOutLanSmall.Controls.Add(Me.lblLan12_1)
		Me.pnlOutLanSmall.Controls.Add(Me.lblLan3_1)
		Me.pnlOutLanSmall.Controls.Add(Me.lblLan7_1)
		Me.pnlOutLanSmall.Controls.Add(Me.lblLan10_1)
		Me.pnlOutLanSmall.Controls.Add(Me.lblLan13_1)
		Me.pnlOutLanSmall.Location = New System.Drawing.Point(153, 55)
		Me.pnlOutLanSmall.Name = "pnlOutLanSmall"
		Me.pnlOutLanSmall.Size = New System.Drawing.Size(49, 345)
		Me.pnlOutLanSmall.TabIndex = 109
		'
		'lblLan14_1
		'
		Me.lblLan14_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblLan14_1.DSSElementName = "OutLan14_1"
		Me.lblLan14_1.DSSLocation = 14
		Me.lblLan14_1.DSSOffset = -0.4R
		Me.lblLan14_1.Location = New System.Drawing.Point(3, 297)
		Me.lblLan14_1.Name = "lblLan14_1"
		Me.lblLan14_1.Size = New System.Drawing.Size(34, 20)
		Me.lblLan14_1.TabIndex = 64
		Me.lblLan14_1.Text = "-"
		Me.lblLan14_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan15_1
		'
		Me.lblLan15_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblLan15_1.DSSElementName = "OutLan15_1"
		Me.lblLan15_1.DSSLocation = 15
		Me.lblLan15_1.DSSOffset = -0.4R
		Me.lblLan15_1.Location = New System.Drawing.Point(3, 320)
		Me.lblLan15_1.Name = "lblLan15_1"
		Me.lblLan15_1.Size = New System.Drawing.Size(34, 20)
		Me.lblLan15_1.TabIndex = 65
		Me.lblLan15_1.Text = "-"
		Me.lblLan15_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan1_1
		'
		Me.lblLan1_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblLan1_1.DSSElementName = "OutLan1_1"
		Me.lblLan1_1.DSSLocation = 1
		Me.lblLan1_1.DSSOffset = -0.4R
		Me.lblLan1_1.Location = New System.Drawing.Point(3, 2)
		Me.lblLan1_1.Name = "lblLan1_1"
		Me.lblLan1_1.Size = New System.Drawing.Size(34, 20)
		Me.lblLan1_1.TabIndex = 63
		Me.lblLan1_1.Text = "-"
		Me.lblLan1_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan5_1
		'
		Me.lblLan5_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblLan5_1.DSSElementName = "OutLan5_1"
		Me.lblLan5_1.DSSLocation = 5
		Me.lblLan5_1.DSSOffset = -0.4R
		Me.lblLan5_1.Location = New System.Drawing.Point(3, 94)
		Me.lblLan5_1.Name = "lblLan5_1"
		Me.lblLan5_1.Size = New System.Drawing.Size(34, 20)
		Me.lblLan5_1.TabIndex = 63
		Me.lblLan5_1.Text = "-"
		Me.lblLan5_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan4_1
		'
		Me.lblLan4_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblLan4_1.DSSElementName = "OutLan4_1"
		Me.lblLan4_1.DSSLocation = 4
		Me.lblLan4_1.DSSOffset = -0.4R
		Me.lblLan4_1.Location = New System.Drawing.Point(3, 71)
		Me.lblLan4_1.Name = "lblLan4_1"
		Me.lblLan4_1.Size = New System.Drawing.Size(34, 20)
		Me.lblLan4_1.TabIndex = 63
		Me.lblLan4_1.Text = "-"
		Me.lblLan4_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan8_1
		'
		Me.lblLan8_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblLan8_1.DSSElementName = "OutLan8_1"
		Me.lblLan8_1.DSSLocation = 8
		Me.lblLan8_1.DSSOffset = -0.4R
		Me.lblLan8_1.Location = New System.Drawing.Point(3, 163)
		Me.lblLan8_1.Name = "lblLan8_1"
		Me.lblLan8_1.Size = New System.Drawing.Size(34, 20)
		Me.lblLan8_1.TabIndex = 63
		Me.lblLan8_1.Text = "-"
		Me.lblLan8_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan11_1
		'
		Me.lblLan11_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblLan11_1.DSSElementName = "OutLan11_1"
		Me.lblLan11_1.DSSLocation = 11
		Me.lblLan11_1.DSSOffset = -0.4R
		Me.lblLan11_1.Location = New System.Drawing.Point(3, 232)
		Me.lblLan11_1.Name = "lblLan11_1"
		Me.lblLan11_1.Size = New System.Drawing.Size(34, 20)
		Me.lblLan11_1.TabIndex = 63
		Me.lblLan11_1.Text = "-"
		Me.lblLan11_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan2_1
		'
		Me.lblLan2_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblLan2_1.DSSElementName = "OutLan2_1"
		Me.lblLan2_1.DSSLocation = 2
		Me.lblLan2_1.DSSOffset = -0.4R
		Me.lblLan2_1.Location = New System.Drawing.Point(3, 25)
		Me.lblLan2_1.Name = "lblLan2_1"
		Me.lblLan2_1.Size = New System.Drawing.Size(34, 20)
		Me.lblLan2_1.TabIndex = 63
		Me.lblLan2_1.Text = "-"
		Me.lblLan2_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan6_1
		'
		Me.lblLan6_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblLan6_1.DSSElementName = "OutLan6_1"
		Me.lblLan6_1.DSSLocation = 6
		Me.lblLan6_1.DSSOffset = -0.4R
		Me.lblLan6_1.Location = New System.Drawing.Point(3, 117)
		Me.lblLan6_1.Name = "lblLan6_1"
		Me.lblLan6_1.Size = New System.Drawing.Size(34, 20)
		Me.lblLan6_1.TabIndex = 63
		Me.lblLan6_1.Text = "-"
		Me.lblLan6_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan9_1
		'
		Me.lblLan9_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblLan9_1.DSSElementName = "OutLan9_1"
		Me.lblLan9_1.DSSLocation = 9
		Me.lblLan9_1.DSSOffset = -0.4R
		Me.lblLan9_1.Location = New System.Drawing.Point(3, 186)
		Me.lblLan9_1.Name = "lblLan9_1"
		Me.lblLan9_1.Size = New System.Drawing.Size(34, 20)
		Me.lblLan9_1.TabIndex = 63
		Me.lblLan9_1.Text = "-"
		Me.lblLan9_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan12_1
		'
		Me.lblLan12_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblLan12_1.DSSElementName = "OutLan12_1"
		Me.lblLan12_1.DSSLocation = 12
		Me.lblLan12_1.DSSOffset = -0.4R
		Me.lblLan12_1.Location = New System.Drawing.Point(3, 255)
		Me.lblLan12_1.Name = "lblLan12_1"
		Me.lblLan12_1.Size = New System.Drawing.Size(34, 20)
		Me.lblLan12_1.TabIndex = 63
		Me.lblLan12_1.Text = "-"
		Me.lblLan12_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan3_1
		'
		Me.lblLan3_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblLan3_1.DSSElementName = "OutLan3_1"
		Me.lblLan3_1.DSSLocation = 3
		Me.lblLan3_1.DSSOffset = -0.4R
		Me.lblLan3_1.Location = New System.Drawing.Point(3, 48)
		Me.lblLan3_1.Name = "lblLan3_1"
		Me.lblLan3_1.Size = New System.Drawing.Size(34, 20)
		Me.lblLan3_1.TabIndex = 63
		Me.lblLan3_1.Text = "-"
		Me.lblLan3_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan7_1
		'
		Me.lblLan7_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblLan7_1.DSSElementName = "OutLan7_1"
		Me.lblLan7_1.DSSLocation = 7
		Me.lblLan7_1.DSSOffset = -0.4R
		Me.lblLan7_1.Location = New System.Drawing.Point(3, 140)
		Me.lblLan7_1.Name = "lblLan7_1"
		Me.lblLan7_1.Size = New System.Drawing.Size(34, 20)
		Me.lblLan7_1.TabIndex = 63
		Me.lblLan7_1.Text = "-"
		Me.lblLan7_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan10_1
		'
		Me.lblLan10_1.AccessibleDescription = ""
		Me.lblLan10_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblLan10_1.DSSElementName = "OutLan10_1"
		Me.lblLan10_1.DSSLocation = 10
		Me.lblLan10_1.DSSOffset = -0.4R
		Me.lblLan10_1.Location = New System.Drawing.Point(3, 209)
		Me.lblLan10_1.Name = "lblLan10_1"
		Me.lblLan10_1.Size = New System.Drawing.Size(34, 20)
		Me.lblLan10_1.TabIndex = 63
		Me.lblLan10_1.Text = "-"
		Me.lblLan10_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan13_1
		'
		Me.lblLan13_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblLan13_1.DSSElementName = "OutLan13_1"
		Me.lblLan13_1.DSSLocation = 13
		Me.lblLan13_1.DSSOffset = -0.4R
		Me.lblLan13_1.Location = New System.Drawing.Point(3, 278)
		Me.lblLan13_1.Name = "lblLan13_1"
		Me.lblLan13_1.Size = New System.Drawing.Size(34, 20)
		Me.lblLan13_1.TabIndex = 63
		Me.lblLan13_1.Text = "-"
		Me.lblLan13_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Label89
		'
		Me.Label89.Location = New System.Drawing.Point(286, 31)
		Me.Label89.Name = "Label89"
		Me.Label89.Size = New System.Drawing.Size(34, 20)
		Me.Label89.TabIndex = 65
		Me.Label89.Text = "ind"
		Me.Label89.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'pnlOutLanLarge
		'
		Me.pnlOutLanLarge.Controls.Add(Me.lblLan15_2)
		Me.pnlOutLanLarge.Controls.Add(Me.lblLan14_2)
		Me.pnlOutLanLarge.Controls.Add(Me.lblLan1_2)
		Me.pnlOutLanLarge.Controls.Add(Me.lblLan5_2)
		Me.pnlOutLanLarge.Controls.Add(Me.lblLan4_2)
		Me.pnlOutLanLarge.Controls.Add(Me.lblLan8_2)
		Me.pnlOutLanLarge.Controls.Add(Me.lblLan11_2)
		Me.pnlOutLanLarge.Controls.Add(Me.lblLan2_2)
		Me.pnlOutLanLarge.Controls.Add(Me.lblLan6_2)
		Me.pnlOutLanLarge.Controls.Add(Me.lblLan13_2)
		Me.pnlOutLanLarge.Controls.Add(Me.lblLan9_2)
		Me.pnlOutLanLarge.Controls.Add(Me.lblLan10_2)
		Me.pnlOutLanLarge.Controls.Add(Me.lblLan12_2)
		Me.pnlOutLanLarge.Controls.Add(Me.lblLan7_2)
		Me.pnlOutLanLarge.Controls.Add(Me.lblLan3_2)
		Me.pnlOutLanLarge.Location = New System.Drawing.Point(347, 56)
		Me.pnlOutLanLarge.Name = "pnlOutLanLarge"
		Me.pnlOutLanLarge.Size = New System.Drawing.Size(49, 345)
		Me.pnlOutLanLarge.TabIndex = 111
		'
		'lblLan15_2
		'
		Me.lblLan15_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(85, Byte), CType(107, Byte), CType(47, Byte))
		Me.lblLan15_2.DSSElementName = "OutLan15_2"
		Me.lblLan15_2.DSSLocation = 15
		Me.lblLan15_2.DSSOffset = 0.8R
		Me.lblLan15_2.Location = New System.Drawing.Point(3, 319)
		Me.lblLan15_2.Name = "lblLan15_2"
		Me.lblLan15_2.Size = New System.Drawing.Size(34, 20)
		Me.lblLan15_2.TabIndex = 107
		Me.lblLan15_2.Text = "-"
		Me.lblLan15_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan14_2
		'
		Me.lblLan14_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(85, Byte), CType(107, Byte), CType(47, Byte))
		Me.lblLan14_2.DSSElementName = "OutLan14_2"
		Me.lblLan14_2.DSSLocation = 14
		Me.lblLan14_2.DSSOffset = 0.8R
		Me.lblLan14_2.Location = New System.Drawing.Point(3, 296)
		Me.lblLan14_2.Name = "lblLan14_2"
		Me.lblLan14_2.Size = New System.Drawing.Size(34, 20)
		Me.lblLan14_2.TabIndex = 106
		Me.lblLan14_2.Text = "-"
		Me.lblLan14_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan1_2
		'
		Me.lblLan1_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(85, Byte), CType(107, Byte), CType(47, Byte))
		Me.lblLan1_2.DSSElementName = "OutLan1_2"
		Me.lblLan1_2.DSSLocation = 1
		Me.lblLan1_2.DSSOffset = 0.8R
		Me.lblLan1_2.Location = New System.Drawing.Point(3, 0)
		Me.lblLan1_2.Name = "lblLan1_2"
		Me.lblLan1_2.Size = New System.Drawing.Size(34, 20)
		Me.lblLan1_2.TabIndex = 81
		Me.lblLan1_2.Text = "-"
		Me.lblLan1_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan5_2
		'
		Me.lblLan5_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(85, Byte), CType(107, Byte), CType(47, Byte))
		Me.lblLan5_2.DSSElementName = "OutLan5_2"
		Me.lblLan5_2.DSSLocation = 5
		Me.lblLan5_2.DSSOffset = 0.8R
		Me.lblLan5_2.Location = New System.Drawing.Point(3, 92)
		Me.lblLan5_2.Name = "lblLan5_2"
		Me.lblLan5_2.Size = New System.Drawing.Size(34, 20)
		Me.lblLan5_2.TabIndex = 78
		Me.lblLan5_2.Text = "-"
		Me.lblLan5_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan4_2
		'
		Me.lblLan4_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(85, Byte), CType(107, Byte), CType(47, Byte))
		Me.lblLan4_2.DSSElementName = "OutLan4_2"
		Me.lblLan4_2.DSSLocation = 4
		Me.lblLan4_2.DSSOffset = 0.8R
		Me.lblLan4_2.Location = New System.Drawing.Point(3, 69)
		Me.lblLan4_2.Name = "lblLan4_2"
		Me.lblLan4_2.Size = New System.Drawing.Size(34, 20)
		Me.lblLan4_2.TabIndex = 84
		Me.lblLan4_2.Text = "-"
		Me.lblLan4_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan8_2
		'
		Me.lblLan8_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(85, Byte), CType(107, Byte), CType(47, Byte))
		Me.lblLan8_2.DSSElementName = "OutLan8_2"
		Me.lblLan8_2.DSSLocation = 8
		Me.lblLan8_2.DSSOffset = 0.8R
		Me.lblLan8_2.Location = New System.Drawing.Point(3, 161)
		Me.lblLan8_2.Name = "lblLan8_2"
		Me.lblLan8_2.Size = New System.Drawing.Size(34, 20)
		Me.lblLan8_2.TabIndex = 73
		Me.lblLan8_2.Text = "-"
		Me.lblLan8_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan11_2
		'
		Me.lblLan11_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(85, Byte), CType(107, Byte), CType(47, Byte))
		Me.lblLan11_2.DSSElementName = "OutLan11_2"
		Me.lblLan11_2.DSSLocation = 11
		Me.lblLan11_2.DSSOffset = 0.8R
		Me.lblLan11_2.Location = New System.Drawing.Point(3, 230)
		Me.lblLan11_2.Name = "lblLan11_2"
		Me.lblLan11_2.Size = New System.Drawing.Size(34, 20)
		Me.lblLan11_2.TabIndex = 70
		Me.lblLan11_2.Text = "-"
		Me.lblLan11_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan2_2
		'
		Me.lblLan2_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(85, Byte), CType(107, Byte), CType(47, Byte))
		Me.lblLan2_2.DSSElementName = "OutLan2_2"
		Me.lblLan2_2.DSSLocation = 2
		Me.lblLan2_2.DSSOffset = 0.8R
		Me.lblLan2_2.Location = New System.Drawing.Point(3, 23)
		Me.lblLan2_2.Name = "lblLan2_2"
		Me.lblLan2_2.Size = New System.Drawing.Size(34, 20)
		Me.lblLan2_2.TabIndex = 83
		Me.lblLan2_2.Text = "-"
		Me.lblLan2_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan6_2
		'
		Me.lblLan6_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(85, Byte), CType(107, Byte), CType(47, Byte))
		Me.lblLan6_2.DSSElementName = "OutLan6_2"
		Me.lblLan6_2.DSSLocation = 6
		Me.lblLan6_2.DSSOffset = 0.8R
		Me.lblLan6_2.Location = New System.Drawing.Point(3, 115)
		Me.lblLan6_2.Name = "lblLan6_2"
		Me.lblLan6_2.Size = New System.Drawing.Size(34, 20)
		Me.lblLan6_2.TabIndex = 86
		Me.lblLan6_2.Text = "-"
		Me.lblLan6_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan13_2
		'
		Me.lblLan13_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(85, Byte), CType(107, Byte), CType(47, Byte))
		Me.lblLan13_2.DSSElementName = "OutLan13_2"
		Me.lblLan13_2.DSSLocation = 13
		Me.lblLan13_2.DSSOffset = 0.8R
		Me.lblLan13_2.Location = New System.Drawing.Point(3, 276)
		Me.lblLan13_2.Name = "lblLan13_2"
		Me.lblLan13_2.Size = New System.Drawing.Size(34, 20)
		Me.lblLan13_2.TabIndex = 105
		Me.lblLan13_2.Text = "-"
		Me.lblLan13_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan9_2
		'
		Me.lblLan9_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(85, Byte), CType(107, Byte), CType(47, Byte))
		Me.lblLan9_2.DSSElementName = "OutLan9_2"
		Me.lblLan9_2.DSSLocation = 9
		Me.lblLan9_2.DSSOffset = 0.8R
		Me.lblLan9_2.Location = New System.Drawing.Point(3, 184)
		Me.lblLan9_2.Name = "lblLan9_2"
		Me.lblLan9_2.Size = New System.Drawing.Size(34, 20)
		Me.lblLan9_2.TabIndex = 101
		Me.lblLan9_2.Text = "-"
		Me.lblLan9_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan10_2
		'
		Me.lblLan10_2.AccessibleDescription = ""
		Me.lblLan10_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(85, Byte), CType(107, Byte), CType(47, Byte))
		Me.lblLan10_2.DSSElementName = "OutLan10_2"
		Me.lblLan10_2.DSSLocation = 10
		Me.lblLan10_2.DSSOffset = 0.8R
		Me.lblLan10_2.Location = New System.Drawing.Point(3, 207)
		Me.lblLan10_2.Name = "lblLan10_2"
		Me.lblLan10_2.Size = New System.Drawing.Size(34, 20)
		Me.lblLan10_2.TabIndex = 89
		Me.lblLan10_2.Text = "-"
		Me.lblLan10_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan12_2
		'
		Me.lblLan12_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(85, Byte), CType(107, Byte), CType(47, Byte))
		Me.lblLan12_2.DSSElementName = "OutLan12_2"
		Me.lblLan12_2.DSSLocation = 12
		Me.lblLan12_2.DSSOffset = 0.8R
		Me.lblLan12_2.Location = New System.Drawing.Point(3, 253)
		Me.lblLan12_2.Name = "lblLan12_2"
		Me.lblLan12_2.Size = New System.Drawing.Size(34, 20)
		Me.lblLan12_2.TabIndex = 98
		Me.lblLan12_2.Text = "-"
		Me.lblLan12_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan7_2
		'
		Me.lblLan7_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(85, Byte), CType(107, Byte), CType(47, Byte))
		Me.lblLan7_2.DSSElementName = "OutLan7_2"
		Me.lblLan7_2.DSSLocation = 7
		Me.lblLan7_2.DSSOffset = 0.8R
		Me.lblLan7_2.Location = New System.Drawing.Point(3, 138)
		Me.lblLan7_2.Name = "lblLan7_2"
		Me.lblLan7_2.Size = New System.Drawing.Size(34, 20)
		Me.lblLan7_2.TabIndex = 92
		Me.lblLan7_2.Text = "-"
		Me.lblLan7_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan3_2
		'
		Me.lblLan3_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(85, Byte), CType(107, Byte), CType(47, Byte))
		Me.lblLan3_2.DSSElementName = "OutLan3_2"
		Me.lblLan3_2.DSSLocation = 3
		Me.lblLan3_2.DSSOffset = 0.8R
		Me.lblLan3_2.Location = New System.Drawing.Point(3, 46)
		Me.lblLan3_2.Name = "lblLan3_2"
		Me.lblLan3_2.Size = New System.Drawing.Size(34, 20)
		Me.lblLan3_2.TabIndex = 95
		Me.lblLan3_2.Text = "-"
		Me.lblLan3_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Label90
		'
		Me.Label90.Location = New System.Drawing.Point(231, 31)
		Me.Label90.Name = "Label90"
		Me.Label90.Size = New System.Drawing.Size(34, 20)
		Me.Label90.TabIndex = 64
		Me.Label90.Text = "agr"
		Me.Label90.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'pnlOutAgrLarge
		'
		Me.pnlOutAgrLarge.Controls.Add(Me.lblAgr14_2)
		Me.pnlOutAgrLarge.Controls.Add(Me.lblAgr15_2)
		Me.pnlOutAgrLarge.Controls.Add(Me.lblAgr1_2)
		Me.pnlOutAgrLarge.Controls.Add(Me.lblAgr5_2)
		Me.pnlOutAgrLarge.Controls.Add(Me.lblAgr4_2)
		Me.pnlOutAgrLarge.Controls.Add(Me.lblAgr8_2)
		Me.pnlOutAgrLarge.Controls.Add(Me.lblAgr11_2)
		Me.pnlOutAgrLarge.Controls.Add(Me.lblAgr2_2)
		Me.pnlOutAgrLarge.Controls.Add(Me.lblAgr6_2)
		Me.pnlOutAgrLarge.Controls.Add(Me.lblAgr9_2)
		Me.pnlOutAgrLarge.Controls.Add(Me.lblAgr12_2)
		Me.pnlOutAgrLarge.Controls.Add(Me.lblAgr13_2)
		Me.pnlOutAgrLarge.Controls.Add(Me.lblAgr3_2)
		Me.pnlOutAgrLarge.Controls.Add(Me.lblAgr7_2)
		Me.pnlOutAgrLarge.Controls.Add(Me.lblAgr10_2)
		Me.pnlOutAgrLarge.Location = New System.Drawing.Point(223, 57)
		Me.pnlOutAgrLarge.Name = "pnlOutAgrLarge"
		Me.pnlOutAgrLarge.Size = New System.Drawing.Size(49, 345)
		Me.pnlOutAgrLarge.TabIndex = 110
		'
		'lblAgr14_2
		'
		Me.lblAgr14_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(139, Byte), CType(69, Byte), CType(19, Byte))
		Me.lblAgr14_2.DSSElementName = "OutAgr14_2"
		Me.lblAgr14_2.DSSLocation = 14
		Me.lblAgr14_2.DSSOffset = 0R
		Me.lblAgr14_2.Location = New System.Drawing.Point(3, 295)
		Me.lblAgr14_2.Name = "lblAgr14_2"
		Me.lblAgr14_2.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr14_2.TabIndex = 105
		Me.lblAgr14_2.Text = "-"
		Me.lblAgr14_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr15_2
		'
		Me.lblAgr15_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(139, Byte), CType(69, Byte), CType(19, Byte))
		Me.lblAgr15_2.DSSElementName = "OutAgr15_2"
		Me.lblAgr15_2.DSSLocation = 15
		Me.lblAgr15_2.DSSOffset = 0R
		Me.lblAgr15_2.Location = New System.Drawing.Point(3, 318)
		Me.lblAgr15_2.Name = "lblAgr15_2"
		Me.lblAgr15_2.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr15_2.TabIndex = 104
		Me.lblAgr15_2.Text = "-"
		Me.lblAgr15_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr1_2
		'
		Me.lblAgr1_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(139, Byte), CType(69, Byte), CType(19, Byte))
		Me.lblAgr1_2.DSSElementName = "OutAgr1_2"
		Me.lblAgr1_2.DSSLocation = 1
		Me.lblAgr1_2.DSSOffset = 0R
		Me.lblAgr1_2.Location = New System.Drawing.Point(3, 0)
		Me.lblAgr1_2.Name = "lblAgr1_2"
		Me.lblAgr1_2.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr1_2.TabIndex = 67
		Me.lblAgr1_2.Text = "-"
		Me.lblAgr1_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr5_2
		'
		Me.lblAgr5_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(139, Byte), CType(69, Byte), CType(19, Byte))
		Me.lblAgr5_2.DSSElementName = "OutAgr5_2"
		Me.lblAgr5_2.DSSLocation = 5
		Me.lblAgr5_2.DSSOffset = 0R
		Me.lblAgr5_2.Location = New System.Drawing.Point(3, 92)
		Me.lblAgr5_2.Name = "lblAgr5_2"
		Me.lblAgr5_2.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr5_2.TabIndex = 80
		Me.lblAgr5_2.Text = "-"
		Me.lblAgr5_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr4_2
		'
		Me.lblAgr4_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(139, Byte), CType(69, Byte), CType(19, Byte))
		Me.lblAgr4_2.DSSElementName = "OutAgr4_2"
		Me.lblAgr4_2.DSSLocation = 4
		Me.lblAgr4_2.DSSOffset = 0R
		Me.lblAgr4_2.Location = New System.Drawing.Point(3, 69)
		Me.lblAgr4_2.Name = "lblAgr4_2"
		Me.lblAgr4_2.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr4_2.TabIndex = 77
		Me.lblAgr4_2.Text = "-"
		Me.lblAgr4_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr8_2
		'
		Me.lblAgr8_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(139, Byte), CType(69, Byte), CType(19, Byte))
		Me.lblAgr8_2.DSSElementName = "OutAgr8_2"
		Me.lblAgr8_2.DSSLocation = 8
		Me.lblAgr8_2.DSSOffset = 0R
		Me.lblAgr8_2.Location = New System.Drawing.Point(3, 161)
		Me.lblAgr8_2.Name = "lblAgr8_2"
		Me.lblAgr8_2.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr8_2.TabIndex = 75
		Me.lblAgr8_2.Text = "-"
		Me.lblAgr8_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr11_2
		'
		Me.lblAgr11_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(139, Byte), CType(69, Byte), CType(19, Byte))
		Me.lblAgr11_2.DSSElementName = "OutAgr11_2"
		Me.lblAgr11_2.DSSLocation = 11
		Me.lblAgr11_2.DSSOffset = 0R
		Me.lblAgr11_2.Location = New System.Drawing.Point(3, 230)
		Me.lblAgr11_2.Name = "lblAgr11_2"
		Me.lblAgr11_2.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr11_2.TabIndex = 72
		Me.lblAgr11_2.Text = "-"
		Me.lblAgr11_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr2_2
		'
		Me.lblAgr2_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(139, Byte), CType(69, Byte), CType(19, Byte))
		Me.lblAgr2_2.DSSElementName = "OutAgr2_2"
		Me.lblAgr2_2.DSSLocation = 2
		Me.lblAgr2_2.DSSOffset = 0R
		Me.lblAgr2_2.Location = New System.Drawing.Point(3, 23)
		Me.lblAgr2_2.Name = "lblAgr2_2"
		Me.lblAgr2_2.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr2_2.TabIndex = 69
		Me.lblAgr2_2.Text = "-"
		Me.lblAgr2_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr6_2
		'
		Me.lblAgr6_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(139, Byte), CType(69, Byte), CType(19, Byte))
		Me.lblAgr6_2.DSSElementName = "OutAgr6_2"
		Me.lblAgr6_2.DSSLocation = 6
		Me.lblAgr6_2.DSSOffset = 0R
		Me.lblAgr6_2.Location = New System.Drawing.Point(3, 115)
		Me.lblAgr6_2.Name = "lblAgr6_2"
		Me.lblAgr6_2.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr6_2.TabIndex = 85
		Me.lblAgr6_2.Text = "-"
		Me.lblAgr6_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr9_2
		'
		Me.lblAgr9_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(139, Byte), CType(69, Byte), CType(19, Byte))
		Me.lblAgr9_2.DSSElementName = "OutAgr9_2"
		Me.lblAgr9_2.DSSLocation = 9
		Me.lblAgr9_2.DSSOffset = 0R
		Me.lblAgr9_2.Location = New System.Drawing.Point(3, 184)
		Me.lblAgr9_2.Name = "lblAgr9_2"
		Me.lblAgr9_2.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr9_2.TabIndex = 103
		Me.lblAgr9_2.Text = "-"
		Me.lblAgr9_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr12_2
		'
		Me.lblAgr12_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(139, Byte), CType(69, Byte), CType(19, Byte))
		Me.lblAgr12_2.DSSElementName = "OutAgr12_2"
		Me.lblAgr12_2.DSSLocation = 12
		Me.lblAgr12_2.DSSOffset = 0R
		Me.lblAgr12_2.Location = New System.Drawing.Point(3, 253)
		Me.lblAgr12_2.Name = "lblAgr12_2"
		Me.lblAgr12_2.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr12_2.TabIndex = 100
		Me.lblAgr12_2.Text = "-"
		Me.lblAgr12_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr13_2
		'
		Me.lblAgr13_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(139, Byte), CType(69, Byte), CType(19, Byte))
		Me.lblAgr13_2.DSSElementName = "OutAgr13_2"
		Me.lblAgr13_2.DSSLocation = 13
		Me.lblAgr13_2.DSSOffset = 0R
		Me.lblAgr13_2.Location = New System.Drawing.Point(3, 276)
		Me.lblAgr13_2.Name = "lblAgr13_2"
		Me.lblAgr13_2.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr13_2.TabIndex = 88
		Me.lblAgr13_2.Text = "-"
		Me.lblAgr13_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr3_2
		'
		Me.lblAgr3_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(139, Byte), CType(69, Byte), CType(19, Byte))
		Me.lblAgr3_2.DSSElementName = "OutAgr3_2"
		Me.lblAgr3_2.DSSLocation = 3
		Me.lblAgr3_2.DSSOffset = 0R
		Me.lblAgr3_2.Location = New System.Drawing.Point(3, 46)
		Me.lblAgr3_2.Name = "lblAgr3_2"
		Me.lblAgr3_2.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr3_2.TabIndex = 97
		Me.lblAgr3_2.Text = "-"
		Me.lblAgr3_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr7_2
		'
		Me.lblAgr7_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(139, Byte), CType(69, Byte), CType(19, Byte))
		Me.lblAgr7_2.DSSElementName = "OutAgr7_2"
		Me.lblAgr7_2.DSSLocation = 7
		Me.lblAgr7_2.DSSOffset = 0R
		Me.lblAgr7_2.Location = New System.Drawing.Point(3, 138)
		Me.lblAgr7_2.Name = "lblAgr7_2"
		Me.lblAgr7_2.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr7_2.TabIndex = 94
		Me.lblAgr7_2.Text = "-"
		Me.lblAgr7_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr10_2
		'
		Me.lblAgr10_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(139, Byte), CType(69, Byte), CType(19, Byte))
		Me.lblAgr10_2.DSSElementName = "OutAgr10_2"
		Me.lblAgr10_2.DSSLocation = 10
		Me.lblAgr10_2.DSSOffset = 0R
		Me.lblAgr10_2.Location = New System.Drawing.Point(3, 207)
		Me.lblAgr10_2.Name = "lblAgr10_2"
		Me.lblAgr10_2.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr10_2.TabIndex = 91
		Me.lblAgr10_2.Text = "-"
		Me.lblAgr10_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Label135
		'
		Me.Label135.Location = New System.Drawing.Point(160, 31)
		Me.Label135.Name = "Label135"
		Me.Label135.Size = New System.Drawing.Size(34, 20)
		Me.Label135.TabIndex = 62
		Me.Label135.Text = "lan"
		Me.Label135.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label133
		'
		Me.Label133.Location = New System.Drawing.Point(97, 31)
		Me.Label133.Name = "Label133"
		Me.Label133.Size = New System.Drawing.Size(34, 20)
		Me.Label133.TabIndex = 62
		Me.Label133.Text = "agr"
		Me.Label133.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'tpaImpacts
		'
		Me.tpaImpacts.Controls.Add(Me.gboOutputImpacts)
		Me.tpaImpacts.Location = New System.Drawing.Point(4, 22)
		Me.tpaImpacts.Name = "tpaImpacts"
		Me.tpaImpacts.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaImpacts.Size = New System.Drawing.Size(465, 471)
		Me.tpaImpacts.TabIndex = 2
		Me.tpaImpacts.Text = "Impacts"
		Me.tpaImpacts.UseVisualStyleBackColor = True
		'
		'gboOutputImpacts
		'
		Me.gboOutputImpacts.Controls.Add(Me.lblIMLocation15)
		Me.gboOutputImpacts.Controls.Add(Me.lblIMLocation14)
		Me.gboOutputImpacts.Controls.Add(Me.lblIMLocation12)
		Me.gboOutputImpacts.Controls.Add(Me.lblIMLocation1)
		Me.gboOutputImpacts.Controls.Add(Me.lblIMLocation11)
		Me.gboOutputImpacts.Controls.Add(Me.lblIMLocation5)
		Me.gboOutputImpacts.Controls.Add(Me.lblIMLocation6)
		Me.gboOutputImpacts.Controls.Add(Me.lblIMLocation10)
		Me.gboOutputImpacts.Controls.Add(Me.lblIMLocation4)
		Me.gboOutputImpacts.Controls.Add(Me.lblIMLocation13)
		Me.gboOutputImpacts.Controls.Add(Me.lblIMLocation7)
		Me.gboOutputImpacts.Controls.Add(Me.lblIMLocation9)
		Me.gboOutputImpacts.Controls.Add(Me.lblIMLocation3)
		Me.gboOutputImpacts.Controls.Add(Me.lblIMLocation2)
		Me.gboOutputImpacts.Controls.Add(Me.lblIMLocation8)
		Me.gboOutputImpacts.Controls.Add(Me.lblEnvGini2)
		Me.gboOutputImpacts.Controls.Add(Me.lblEnvMean2)
		Me.gboOutputImpacts.Controls.Add(Me.lblSocGini2)
		Me.gboOutputImpacts.Controls.Add(Me.lblSocMean2)
		Me.gboOutputImpacts.Controls.Add(Me.lblEcoGini2)
		Me.gboOutputImpacts.Controls.Add(Me.lblEcoMean2)
		Me.gboOutputImpacts.Controls.Add(Me.lblEnvGini1)
		Me.gboOutputImpacts.Controls.Add(Me.lblEnvMean1)
		Me.gboOutputImpacts.Controls.Add(Me.lblSocGini1)
		Me.gboOutputImpacts.Controls.Add(Me.lblSocMean1)
		Me.gboOutputImpacts.Controls.Add(Me.lblEcoGini1)
		Me.gboOutputImpacts.Controls.Add(Me.lblEcoMean1)
		Me.gboOutputImpacts.Controls.Add(Me.Label101)
		Me.gboOutputImpacts.Controls.Add(Me.Label100)
		Me.gboOutputImpacts.Controls.Add(Me.pnlOutSocSmall)
		Me.gboOutputImpacts.Controls.Add(Me.DssPanel7)
		Me.gboOutputImpacts.Controls.Add(Me.pnlOutEnvLarge)
		Me.gboOutputImpacts.Controls.Add(Me.pnlOutEnvSmall)
		Me.gboOutputImpacts.Controls.Add(Me.pnlOutEcoLarge)
		Me.gboOutputImpacts.Controls.Add(Me.pnlOutSocLarge)
		Me.gboOutputImpacts.Controls.Add(Me.pnlOutEcoSmall)
		Me.gboOutputImpacts.Controls.Add(Me.Label180)
		Me.gboOutputImpacts.Controls.Add(Me.Label98)
		Me.gboOutputImpacts.Controls.Add(Me.Label179)
		Me.gboOutputImpacts.Controls.Add(Me.Label99)
		Me.gboOutputImpacts.Controls.Add(Me.Label95)
		Me.gboOutputImpacts.Controls.Add(Me.Label178)
		Me.gboOutputImpacts.Controls.Add(Me.Label97)
		Me.gboOutputImpacts.Controls.Add(Me.Label96)
		Me.gboOutputImpacts.DSSVisible = False
		Me.gboOutputImpacts.Location = New System.Drawing.Point(15, 11)
		Me.gboOutputImpacts.Name = "gboOutputImpacts"
		Me.gboOutputImpacts.Size = New System.Drawing.Size(422, 446)
		Me.gboOutputImpacts.TabIndex = 195
		Me.gboOutputImpacts.TabStop = False
		Me.gboOutputImpacts.Visible = False
		'
		'lblIMLocation15
		'
		Me.lblIMLocation15.AutoSize = True
		Me.lblIMLocation15.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIMLocation15.DSSElementName = "locName"
		Me.lblIMLocation15.DSSLocation = 15
		Me.lblIMLocation15.DSSOffset = 0R
		Me.lblIMLocation15.Location = New System.Drawing.Point(10, 384)
		Me.lblIMLocation15.Name = "lblIMLocation15"
		Me.lblIMLocation15.Size = New System.Drawing.Size(56, 13)
		Me.lblIMLocation15.TabIndex = 221
		Me.lblIMLocation15.Text = "location15"
		'
		'lblIMLocation14
		'
		Me.lblIMLocation14.AutoSize = True
		Me.lblIMLocation14.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIMLocation14.DSSElementName = "locName"
		Me.lblIMLocation14.DSSLocation = 14
		Me.lblIMLocation14.DSSOffset = 0R
		Me.lblIMLocation14.Location = New System.Drawing.Point(10, 361)
		Me.lblIMLocation14.Name = "lblIMLocation14"
		Me.lblIMLocation14.Size = New System.Drawing.Size(56, 13)
		Me.lblIMLocation14.TabIndex = 220
		Me.lblIMLocation14.Text = "location14"
		'
		'lblIMLocation12
		'
		Me.lblIMLocation12.AutoSize = True
		Me.lblIMLocation12.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIMLocation12.DSSElementName = "locName"
		Me.lblIMLocation12.DSSLocation = 12
		Me.lblIMLocation12.DSSOffset = 0R
		Me.lblIMLocation12.Location = New System.Drawing.Point(10, 315)
		Me.lblIMLocation12.Name = "lblIMLocation12"
		Me.lblIMLocation12.Size = New System.Drawing.Size(56, 13)
		Me.lblIMLocation12.TabIndex = 219
		Me.lblIMLocation12.Text = "location12"
		'
		'lblIMLocation1
		'
		Me.lblIMLocation1.AutoSize = True
		Me.lblIMLocation1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIMLocation1.DSSElementName = "locName"
		Me.lblIMLocation1.DSSLocation = 1
		Me.lblIMLocation1.DSSOffset = 0R
		Me.lblIMLocation1.Location = New System.Drawing.Point(10, 62)
		Me.lblIMLocation1.Name = "lblIMLocation1"
		Me.lblIMLocation1.Size = New System.Drawing.Size(50, 13)
		Me.lblIMLocation1.TabIndex = 208
		Me.lblIMLocation1.Text = "location1"
		'
		'lblIMLocation11
		'
		Me.lblIMLocation11.AutoSize = True
		Me.lblIMLocation11.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIMLocation11.DSSElementName = "locName"
		Me.lblIMLocation11.DSSLocation = 11
		Me.lblIMLocation11.DSSOffset = 0R
		Me.lblIMLocation11.Location = New System.Drawing.Point(10, 292)
		Me.lblIMLocation11.Name = "lblIMLocation11"
		Me.lblIMLocation11.Size = New System.Drawing.Size(56, 13)
		Me.lblIMLocation11.TabIndex = 218
		Me.lblIMLocation11.Text = "location11"
		'
		'lblIMLocation5
		'
		Me.lblIMLocation5.AccessibleDescription = ""
		Me.lblIMLocation5.AutoSize = True
		Me.lblIMLocation5.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIMLocation5.DSSElementName = "locName"
		Me.lblIMLocation5.DSSLocation = 5
		Me.lblIMLocation5.DSSOffset = 0R
		Me.lblIMLocation5.Location = New System.Drawing.Point(10, 154)
		Me.lblIMLocation5.Name = "lblIMLocation5"
		Me.lblIMLocation5.Size = New System.Drawing.Size(50, 13)
		Me.lblIMLocation5.TabIndex = 212
		Me.lblIMLocation5.Text = "location5"
		'
		'lblIMLocation6
		'
		Me.lblIMLocation6.AutoSize = True
		Me.lblIMLocation6.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIMLocation6.DSSElementName = "locName"
		Me.lblIMLocation6.DSSLocation = 6
		Me.lblIMLocation6.DSSOffset = 0R
		Me.lblIMLocation6.Location = New System.Drawing.Point(10, 177)
		Me.lblIMLocation6.Name = "lblIMLocation6"
		Me.lblIMLocation6.Size = New System.Drawing.Size(50, 13)
		Me.lblIMLocation6.TabIndex = 213
		Me.lblIMLocation6.Text = "location6"
		'
		'lblIMLocation10
		'
		Me.lblIMLocation10.AutoSize = True
		Me.lblIMLocation10.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIMLocation10.DSSElementName = "locName"
		Me.lblIMLocation10.DSSLocation = 10
		Me.lblIMLocation10.DSSOffset = 0R
		Me.lblIMLocation10.Location = New System.Drawing.Point(10, 269)
		Me.lblIMLocation10.Name = "lblIMLocation10"
		Me.lblIMLocation10.Size = New System.Drawing.Size(56, 13)
		Me.lblIMLocation10.TabIndex = 217
		Me.lblIMLocation10.Text = "location10"
		'
		'lblIMLocation4
		'
		Me.lblIMLocation4.AutoSize = True
		Me.lblIMLocation4.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIMLocation4.DSSElementName = "locName"
		Me.lblIMLocation4.DSSLocation = 4
		Me.lblIMLocation4.DSSOffset = 0R
		Me.lblIMLocation4.Location = New System.Drawing.Point(10, 131)
		Me.lblIMLocation4.Name = "lblIMLocation4"
		Me.lblIMLocation4.Size = New System.Drawing.Size(50, 13)
		Me.lblIMLocation4.TabIndex = 211
		Me.lblIMLocation4.Text = "location4"
		'
		'lblIMLocation13
		'
		Me.lblIMLocation13.AutoSize = True
		Me.lblIMLocation13.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIMLocation13.DSSElementName = "locNAme"
		Me.lblIMLocation13.DSSLocation = 13
		Me.lblIMLocation13.DSSOffset = 0R
		Me.lblIMLocation13.Location = New System.Drawing.Point(10, 338)
		Me.lblIMLocation13.Name = "lblIMLocation13"
		Me.lblIMLocation13.Size = New System.Drawing.Size(56, 13)
		Me.lblIMLocation13.TabIndex = 207
		Me.lblIMLocation13.Text = "location13"
		'
		'lblIMLocation7
		'
		Me.lblIMLocation7.AutoSize = True
		Me.lblIMLocation7.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIMLocation7.DSSElementName = "locName"
		Me.lblIMLocation7.DSSLocation = 7
		Me.lblIMLocation7.DSSOffset = 0R
		Me.lblIMLocation7.Location = New System.Drawing.Point(10, 200)
		Me.lblIMLocation7.Name = "lblIMLocation7"
		Me.lblIMLocation7.Size = New System.Drawing.Size(50, 13)
		Me.lblIMLocation7.TabIndex = 214
		Me.lblIMLocation7.Text = "location7"
		'
		'lblIMLocation9
		'
		Me.lblIMLocation9.AutoSize = True
		Me.lblIMLocation9.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIMLocation9.DSSElementName = "locName"
		Me.lblIMLocation9.DSSLocation = 9
		Me.lblIMLocation9.DSSOffset = 0R
		Me.lblIMLocation9.Location = New System.Drawing.Point(10, 246)
		Me.lblIMLocation9.Name = "lblIMLocation9"
		Me.lblIMLocation9.Size = New System.Drawing.Size(50, 13)
		Me.lblIMLocation9.TabIndex = 216
		Me.lblIMLocation9.Text = "location9"
		'
		'lblIMLocation3
		'
		Me.lblIMLocation3.AutoSize = True
		Me.lblIMLocation3.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIMLocation3.DSSElementName = "locName"
		Me.lblIMLocation3.DSSLocation = 3
		Me.lblIMLocation3.DSSOffset = 0R
		Me.lblIMLocation3.Location = New System.Drawing.Point(10, 108)
		Me.lblIMLocation3.Name = "lblIMLocation3"
		Me.lblIMLocation3.Size = New System.Drawing.Size(50, 13)
		Me.lblIMLocation3.TabIndex = 210
		Me.lblIMLocation3.Text = "location3"
		'
		'lblIMLocation2
		'
		Me.lblIMLocation2.AutoSize = True
		Me.lblIMLocation2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIMLocation2.DSSElementName = "locName"
		Me.lblIMLocation2.DSSLocation = 2
		Me.lblIMLocation2.DSSOffset = 0R
		Me.lblIMLocation2.Location = New System.Drawing.Point(10, 85)
		Me.lblIMLocation2.Name = "lblIMLocation2"
		Me.lblIMLocation2.Size = New System.Drawing.Size(50, 13)
		Me.lblIMLocation2.TabIndex = 209
		Me.lblIMLocation2.Text = "location2"
		'
		'lblIMLocation8
		'
		Me.lblIMLocation8.AutoSize = True
		Me.lblIMLocation8.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIMLocation8.DSSElementName = "locName"
		Me.lblIMLocation8.DSSLocation = 8
		Me.lblIMLocation8.DSSOffset = 0R
		Me.lblIMLocation8.Location = New System.Drawing.Point(10, 223)
		Me.lblIMLocation8.Name = "lblIMLocation8"
		Me.lblIMLocation8.Size = New System.Drawing.Size(50, 13)
		Me.lblIMLocation8.TabIndex = 215
		Me.lblIMLocation8.Text = "location8"
		'
		'lblEnvGini2
		'
		Me.lblEnvGini2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEnvGini2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
		Me.lblEnvGini2.DSSElementName = "OutEco13_1"
		Me.lblEnvGini2.DSSLocation = 0
		Me.lblEnvGini2.DSSOffset = 0.5R
		Me.lblEnvGini2.Location = New System.Drawing.Point(351, 421)
		Me.lblEnvGini2.Name = "lblEnvGini2"
		Me.lblEnvGini2.Size = New System.Drawing.Size(34, 20)
		Me.lblEnvGini2.TabIndex = 206
		Me.lblEnvGini2.Text = "-"
		Me.lblEnvGini2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnvMean2
		'
		Me.lblEnvMean2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEnvMean2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
		Me.lblEnvMean2.DSSElementName = "OutEco13_1"
		Me.lblEnvMean2.DSSLocation = 0
		Me.lblEnvMean2.DSSOffset = 0.5R
		Me.lblEnvMean2.Location = New System.Drawing.Point(351, 401)
		Me.lblEnvMean2.Name = "lblEnvMean2"
		Me.lblEnvMean2.Size = New System.Drawing.Size(34, 20)
		Me.lblEnvMean2.TabIndex = 205
		Me.lblEnvMean2.Text = "-"
		Me.lblEnvMean2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSocGini2
		'
		Me.lblSocGini2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblSocGini2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
		Me.lblSocGini2.DSSElementName = "OutEco13_1"
		Me.lblSocGini2.DSSLocation = 0
		Me.lblSocGini2.DSSOffset = 0.3R
		Me.lblSocGini2.Location = New System.Drawing.Point(298, 421)
		Me.lblSocGini2.Name = "lblSocGini2"
		Me.lblSocGini2.Size = New System.Drawing.Size(34, 20)
		Me.lblSocGini2.TabIndex = 204
		Me.lblSocGini2.Text = "-"
		Me.lblSocGini2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSocMean2
		'
		Me.lblSocMean2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblSocMean2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
		Me.lblSocMean2.DSSElementName = "OutEco13_1"
		Me.lblSocMean2.DSSLocation = 0
		Me.lblSocMean2.DSSOffset = 0.3R
		Me.lblSocMean2.Location = New System.Drawing.Point(298, 401)
		Me.lblSocMean2.Name = "lblSocMean2"
		Me.lblSocMean2.Size = New System.Drawing.Size(34, 20)
		Me.lblSocMean2.TabIndex = 203
		Me.lblSocMean2.Text = "-"
		Me.lblSocMean2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEcoGini2
		'
		Me.lblEcoGini2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEcoGini2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
		Me.lblEcoGini2.DSSElementName = "OutEco13_1"
		Me.lblEcoGini2.DSSLocation = 0
		Me.lblEcoGini2.DSSOffset = 0.2R
		Me.lblEcoGini2.Location = New System.Drawing.Point(246, 421)
		Me.lblEcoGini2.Name = "lblEcoGini2"
		Me.lblEcoGini2.Size = New System.Drawing.Size(34, 20)
		Me.lblEcoGini2.TabIndex = 202
		Me.lblEcoGini2.Text = "-"
		Me.lblEcoGini2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEcoMean2
		'
		Me.lblEcoMean2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEcoMean2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
		Me.lblEcoMean2.DSSElementName = "OutEco13_1"
		Me.lblEcoMean2.DSSLocation = 0
		Me.lblEcoMean2.DSSOffset = 0.2R
		Me.lblEcoMean2.Location = New System.Drawing.Point(246, 401)
		Me.lblEcoMean2.Name = "lblEcoMean2"
		Me.lblEcoMean2.Size = New System.Drawing.Size(34, 20)
		Me.lblEcoMean2.TabIndex = 201
		Me.lblEcoMean2.Text = "-"
		Me.lblEcoMean2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnvGini1
		'
		Me.lblEnvGini1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEnvGini1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
		Me.lblEnvGini1.DSSElementName = "OutEco13_1"
		Me.lblEnvGini1.DSSLocation = 0
		Me.lblEnvGini1.DSSOffset = -0.2R
		Me.lblEnvGini1.Location = New System.Drawing.Point(190, 421)
		Me.lblEnvGini1.Name = "lblEnvGini1"
		Me.lblEnvGini1.Size = New System.Drawing.Size(34, 20)
		Me.lblEnvGini1.TabIndex = 200
		Me.lblEnvGini1.Text = "-"
		Me.lblEnvGini1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnvMean1
		'
		Me.lblEnvMean1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEnvMean1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
		Me.lblEnvMean1.DSSElementName = "OutEco13_1"
		Me.lblEnvMean1.DSSLocation = 0
		Me.lblEnvMean1.DSSOffset = -0.2R
		Me.lblEnvMean1.Location = New System.Drawing.Point(190, 401)
		Me.lblEnvMean1.Name = "lblEnvMean1"
		Me.lblEnvMean1.Size = New System.Drawing.Size(34, 20)
		Me.lblEnvMean1.TabIndex = 199
		Me.lblEnvMean1.Text = "-"
		Me.lblEnvMean1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSocGini1
		'
		Me.lblSocGini1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblSocGini1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
		Me.lblSocGini1.DSSElementName = "OutEco13_1"
		Me.lblSocGini1.DSSLocation = 0
		Me.lblSocGini1.DSSOffset = -0.6R
		Me.lblSocGini1.Location = New System.Drawing.Point(137, 421)
		Me.lblSocGini1.Name = "lblSocGini1"
		Me.lblSocGini1.Size = New System.Drawing.Size(34, 20)
		Me.lblSocGini1.TabIndex = 198
		Me.lblSocGini1.Text = "-"
		Me.lblSocGini1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSocMean1
		'
		Me.lblSocMean1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblSocMean1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
		Me.lblSocMean1.DSSElementName = "OutSocMean"
		Me.lblSocMean1.DSSLocation = 0
		Me.lblSocMean1.DSSOffset = -0.6R
		Me.lblSocMean1.Location = New System.Drawing.Point(137, 401)
		Me.lblSocMean1.Name = "lblSocMean1"
		Me.lblSocMean1.Size = New System.Drawing.Size(34, 20)
		Me.lblSocMean1.TabIndex = 197
		Me.lblSocMean1.Text = "-"
		Me.lblSocMean1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEcoGini1
		'
		Me.lblEcoGini1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEcoGini1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
		Me.lblEcoGini1.DSSElementName = "OutEco13_1"
		Me.lblEcoGini1.DSSLocation = 0
		Me.lblEcoGini1.DSSOffset = -1.0R
		Me.lblEcoGini1.Location = New System.Drawing.Point(82, 421)
		Me.lblEcoGini1.Name = "lblEcoGini1"
		Me.lblEcoGini1.Size = New System.Drawing.Size(34, 20)
		Me.lblEcoGini1.TabIndex = 196
		Me.lblEcoGini1.Text = "-"
		Me.lblEcoGini1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEcoMean1
		'
		Me.lblEcoMean1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEcoMean1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
		Me.lblEcoMean1.DSSElementName = "OutEcoMean1"
		Me.lblEcoMean1.DSSLocation = 0
		Me.lblEcoMean1.DSSOffset = -1.0R
		Me.lblEcoMean1.Location = New System.Drawing.Point(82, 401)
		Me.lblEcoMean1.Name = "lblEcoMean1"
		Me.lblEcoMean1.Size = New System.Drawing.Size(34, 20)
		Me.lblEcoMean1.TabIndex = 195
		Me.lblEcoMean1.Text = "-"
		Me.lblEcoMean1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Label101
		'
		Me.Label101.Location = New System.Drawing.Point(8, 421)
		Me.Label101.Name = "Label101"
		Me.Label101.Size = New System.Drawing.Size(68, 20)
		Me.Label101.TabIndex = 194
		Me.Label101.Text = "Gini index"
		'
		'Label100
		'
		Me.Label100.Location = New System.Drawing.Point(8, 401)
		Me.Label100.Name = "Label100"
		Me.Label100.Size = New System.Drawing.Size(68, 20)
		Me.Label100.TabIndex = 193
		Me.Label100.Text = "Mean"
		'
		'pnlOutSocSmall
		'
		Me.pnlOutSocSmall.Controls.Add(Me.lblSoc14_1)
		Me.pnlOutSocSmall.Controls.Add(Me.lblSoc15_1)
		Me.pnlOutSocSmall.Controls.Add(Me.lblSoc1_1)
		Me.pnlOutSocSmall.Controls.Add(Me.lblSoc5_1)
		Me.pnlOutSocSmall.Controls.Add(Me.lblSoc4_1)
		Me.pnlOutSocSmall.Controls.Add(Me.lblSoc8_1)
		Me.pnlOutSocSmall.Controls.Add(Me.lblSoc11_1)
		Me.pnlOutSocSmall.Controls.Add(Me.lblSoc2_1)
		Me.pnlOutSocSmall.Controls.Add(Me.lblSoc6_1)
		Me.pnlOutSocSmall.Controls.Add(Me.lblSoc9_1)
		Me.pnlOutSocSmall.Controls.Add(Me.lblSoc12_1)
		Me.pnlOutSocSmall.Controls.Add(Me.lblSoc3_1)
		Me.pnlOutSocSmall.Controls.Add(Me.lblSoc7_1)
		Me.pnlOutSocSmall.Controls.Add(Me.lblSoc10_1)
		Me.pnlOutSocSmall.Controls.Add(Me.lblSoc13_1)
		Me.pnlOutSocSmall.DSSVisible = False
		Me.pnlOutSocSmall.Location = New System.Drawing.Point(133, 59)
		Me.pnlOutSocSmall.Name = "pnlOutSocSmall"
		Me.pnlOutSocSmall.Size = New System.Drawing.Size(49, 339)
		Me.pnlOutSocSmall.TabIndex = 1
		'
		'lblSoc14_1
		'
		Me.lblSoc14_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(69, Byte), CType(0, Byte))
		Me.lblSoc14_1.DSSElementName = "OutSoc14_1"
		Me.lblSoc14_1.DSSLocation = 14
		Me.lblSoc14_1.DSSOffset = -0.6R
		Me.lblSoc14_1.Location = New System.Drawing.Point(3, 296)
		Me.lblSoc14_1.Name = "lblSoc14_1"
		Me.lblSoc14_1.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc14_1.TabIndex = 146
		Me.lblSoc14_1.Text = "-"
		Me.lblSoc14_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc15_1
		'
		Me.lblSoc15_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(69, Byte), CType(0, Byte))
		Me.lblSoc15_1.DSSElementName = "OutSoc15_1"
		Me.lblSoc15_1.DSSLocation = 15
		Me.lblSoc15_1.DSSOffset = -0.6R
		Me.lblSoc15_1.Location = New System.Drawing.Point(3, 319)
		Me.lblSoc15_1.Name = "lblSoc15_1"
		Me.lblSoc15_1.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc15_1.TabIndex = 145
		Me.lblSoc15_1.Text = "-"
		Me.lblSoc15_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc1_1
		'
		Me.lblSoc1_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(69, Byte), CType(0, Byte))
		Me.lblSoc1_1.DSSElementName = "OutSoc1_1"
		Me.lblSoc1_1.DSSLocation = 1
		Me.lblSoc1_1.DSSOffset = -0.6R
		Me.lblSoc1_1.Location = New System.Drawing.Point(3, -1)
		Me.lblSoc1_1.Name = "lblSoc1_1"
		Me.lblSoc1_1.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc1_1.TabIndex = 126
		Me.lblSoc1_1.Text = "-"
		Me.lblSoc1_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc5_1
		'
		Me.lblSoc5_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(69, Byte), CType(0, Byte))
		Me.lblSoc5_1.DSSElementName = "OutSoc5_1"
		Me.lblSoc5_1.DSSLocation = 5
		Me.lblSoc5_1.DSSOffset = -0.6R
		Me.lblSoc5_1.Location = New System.Drawing.Point(3, 91)
		Me.lblSoc5_1.Name = "lblSoc5_1"
		Me.lblSoc5_1.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc5_1.TabIndex = 122
		Me.lblSoc5_1.Text = "-"
		Me.lblSoc5_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc4_1
		'
		Me.lblSoc4_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(69, Byte), CType(0, Byte))
		Me.lblSoc4_1.DSSElementName = "OutSoc4_1"
		Me.lblSoc4_1.DSSLocation = 4
		Me.lblSoc4_1.DSSOffset = -0.6R
		Me.lblSoc4_1.Location = New System.Drawing.Point(3, 68)
		Me.lblSoc4_1.Name = "lblSoc4_1"
		Me.lblSoc4_1.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc4_1.TabIndex = 119
		Me.lblSoc4_1.Text = "-"
		Me.lblSoc4_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc8_1
		'
		Me.lblSoc8_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(69, Byte), CType(0, Byte))
		Me.lblSoc8_1.DSSElementName = "OutSoc8_1"
		Me.lblSoc8_1.DSSLocation = 8
		Me.lblSoc8_1.DSSOffset = -0.6R
		Me.lblSoc8_1.Location = New System.Drawing.Point(3, 160)
		Me.lblSoc8_1.Name = "lblSoc8_1"
		Me.lblSoc8_1.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc8_1.TabIndex = 117
		Me.lblSoc8_1.Text = "-"
		Me.lblSoc8_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc11_1
		'
		Me.lblSoc11_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(69, Byte), CType(0, Byte))
		Me.lblSoc11_1.DSSElementName = "OutSoc11_1"
		Me.lblSoc11_1.DSSLocation = 11
		Me.lblSoc11_1.DSSOffset = -0.6R
		Me.lblSoc11_1.Location = New System.Drawing.Point(3, 229)
		Me.lblSoc11_1.Name = "lblSoc11_1"
		Me.lblSoc11_1.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc11_1.TabIndex = 113
		Me.lblSoc11_1.Text = "-"
		Me.lblSoc11_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc2_1
		'
		Me.lblSoc2_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(69, Byte), CType(0, Byte))
		Me.lblSoc2_1.DSSElementName = "OutSoc2_1"
		Me.lblSoc2_1.DSSLocation = 2
		Me.lblSoc2_1.DSSOffset = -0.6R
		Me.lblSoc2_1.Location = New System.Drawing.Point(3, 22)
		Me.lblSoc2_1.Name = "lblSoc2_1"
		Me.lblSoc2_1.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc2_1.TabIndex = 110
		Me.lblSoc2_1.Text = "-"
		Me.lblSoc2_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc6_1
		'
		Me.lblSoc6_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(69, Byte), CType(0, Byte))
		Me.lblSoc6_1.DSSElementName = "OutSoc6_1"
		Me.lblSoc6_1.DSSLocation = 6
		Me.lblSoc6_1.DSSOffset = -0.6R
		Me.lblSoc6_1.Location = New System.Drawing.Point(3, 114)
		Me.lblSoc6_1.Name = "lblSoc6_1"
		Me.lblSoc6_1.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc6_1.TabIndex = 127
		Me.lblSoc6_1.Text = "-"
		Me.lblSoc6_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc9_1
		'
		Me.lblSoc9_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(69, Byte), CType(0, Byte))
		Me.lblSoc9_1.DSSElementName = "OutSoc9_1"
		Me.lblSoc9_1.DSSLocation = 9
		Me.lblSoc9_1.DSSOffset = -0.6R
		Me.lblSoc9_1.Location = New System.Drawing.Point(3, 183)
		Me.lblSoc9_1.Name = "lblSoc9_1"
		Me.lblSoc9_1.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc9_1.TabIndex = 144
		Me.lblSoc9_1.Text = "-"
		Me.lblSoc9_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc12_1
		'
		Me.lblSoc12_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(69, Byte), CType(0, Byte))
		Me.lblSoc12_1.DSSElementName = "OutSoc12_1"
		Me.lblSoc12_1.DSSLocation = 12
		Me.lblSoc12_1.DSSOffset = -0.6R
		Me.lblSoc12_1.Location = New System.Drawing.Point(3, 252)
		Me.lblSoc12_1.Name = "lblSoc12_1"
		Me.lblSoc12_1.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc12_1.TabIndex = 141
		Me.lblSoc12_1.Text = "-"
		Me.lblSoc12_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc3_1
		'
		Me.lblSoc3_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(69, Byte), CType(0, Byte))
		Me.lblSoc3_1.DSSElementName = "OutSoc3_1"
		Me.lblSoc3_1.DSSLocation = 3
		Me.lblSoc3_1.DSSOffset = -0.6R
		Me.lblSoc3_1.Location = New System.Drawing.Point(3, 45)
		Me.lblSoc3_1.Name = "lblSoc3_1"
		Me.lblSoc3_1.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc3_1.TabIndex = 138
		Me.lblSoc3_1.Text = "-"
		Me.lblSoc3_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc7_1
		'
		Me.lblSoc7_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(69, Byte), CType(0, Byte))
		Me.lblSoc7_1.DSSElementName = "OutSoc7_1"
		Me.lblSoc7_1.DSSLocation = 7
		Me.lblSoc7_1.DSSOffset = -0.6R
		Me.lblSoc7_1.Location = New System.Drawing.Point(3, 137)
		Me.lblSoc7_1.Name = "lblSoc7_1"
		Me.lblSoc7_1.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc7_1.TabIndex = 135
		Me.lblSoc7_1.Text = "-"
		Me.lblSoc7_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc10_1
		'
		Me.lblSoc10_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(69, Byte), CType(0, Byte))
		Me.lblSoc10_1.DSSElementName = "OutSoc10_1"
		Me.lblSoc10_1.DSSLocation = 10
		Me.lblSoc10_1.DSSOffset = -0.6R
		Me.lblSoc10_1.Location = New System.Drawing.Point(3, 206)
		Me.lblSoc10_1.Name = "lblSoc10_1"
		Me.lblSoc10_1.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc10_1.TabIndex = 132
		Me.lblSoc10_1.Text = "-"
		Me.lblSoc10_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc13_1
		'
		Me.lblSoc13_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(69, Byte), CType(0, Byte))
		Me.lblSoc13_1.DSSElementName = "OutSoc13_1"
		Me.lblSoc13_1.DSSLocation = 13
		Me.lblSoc13_1.DSSOffset = -0.6R
		Me.lblSoc13_1.Location = New System.Drawing.Point(3, 275)
		Me.lblSoc13_1.Name = "lblSoc13_1"
		Me.lblSoc13_1.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc13_1.TabIndex = 129
		Me.lblSoc13_1.Text = "-"
		Me.lblSoc13_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssPanel7
		'
		Me.DssPanel7.DSSVisible = False
		Me.DssPanel7.Location = New System.Drawing.Point(-135, 184)
		Me.DssPanel7.Name = "DssPanel7"
		Me.DssPanel7.Size = New System.Drawing.Size(49, 317)
		Me.DssPanel7.TabIndex = 192
		'
		'pnlOutEnvLarge
		'
		Me.pnlOutEnvLarge.Controls.Add(Me.lblEnv14_2)
		Me.pnlOutEnvLarge.Controls.Add(Me.lblEnv15_2)
		Me.pnlOutEnvLarge.Controls.Add(Me.lblEnv1_2)
		Me.pnlOutEnvLarge.Controls.Add(Me.lblEnv5_2)
		Me.pnlOutEnvLarge.Controls.Add(Me.lblEnv4_2)
		Me.pnlOutEnvLarge.Controls.Add(Me.lblEnv8_2)
		Me.pnlOutEnvLarge.Controls.Add(Me.lblEnv11_2)
		Me.pnlOutEnvLarge.Controls.Add(Me.lblEnv2_2)
		Me.pnlOutEnvLarge.Controls.Add(Me.lblEnv6_2)
		Me.pnlOutEnvLarge.Controls.Add(Me.lblEnv9_2)
		Me.pnlOutEnvLarge.Controls.Add(Me.lblEnv12_2)
		Me.pnlOutEnvLarge.Controls.Add(Me.lblEnv13_2)
		Me.pnlOutEnvLarge.Controls.Add(Me.lblEnv3_2)
		Me.pnlOutEnvLarge.Controls.Add(Me.lblEnv7_2)
		Me.pnlOutEnvLarge.Controls.Add(Me.lblEnv10_2)
		Me.pnlOutEnvLarge.DSSVisible = False
		Me.pnlOutEnvLarge.Location = New System.Drawing.Point(349, 59)
		Me.pnlOutEnvLarge.Name = "pnlOutEnvLarge"
		Me.pnlOutEnvLarge.Size = New System.Drawing.Size(49, 339)
		Me.pnlOutEnvLarge.TabIndex = 1
		'
		'lblEnv14_2
		'
		Me.lblEnv14_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblEnv14_2.DSSElementName = Nothing
		Me.lblEnv14_2.DSSLocation = 14
		Me.lblEnv14_2.DSSOffset = 1.0R
		Me.lblEnv14_2.Location = New System.Drawing.Point(3, 296)
		Me.lblEnv14_2.Name = "lblEnv14_2"
		Me.lblEnv14_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv14_2.TabIndex = 189
		Me.lblEnv14_2.Text = "-"
		Me.lblEnv14_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv15_2
		'
		Me.lblEnv15_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblEnv15_2.DSSElementName = Nothing
		Me.lblEnv15_2.DSSLocation = 15
		Me.lblEnv15_2.DSSOffset = 1.0R
		Me.lblEnv15_2.Location = New System.Drawing.Point(3, 319)
		Me.lblEnv15_2.Name = "lblEnv15_2"
		Me.lblEnv15_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv15_2.TabIndex = 188
		Me.lblEnv15_2.Text = "-"
		Me.lblEnv15_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv1_2
		'
		Me.lblEnv1_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblEnv1_2.DSSElementName = Nothing
		Me.lblEnv1_2.DSSLocation = 1
		Me.lblEnv1_2.DSSOffset = 1.0R
		Me.lblEnv1_2.Location = New System.Drawing.Point(3, 0)
		Me.lblEnv1_2.Name = "lblEnv1_2"
		Me.lblEnv1_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv1_2.TabIndex = 166
		Me.lblEnv1_2.Text = "-"
		Me.lblEnv1_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv5_2
		'
		Me.lblEnv5_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblEnv5_2.DSSElementName = Nothing
		Me.lblEnv5_2.DSSLocation = 5
		Me.lblEnv5_2.DSSOffset = 1.0R
		Me.lblEnv5_2.Location = New System.Drawing.Point(3, 92)
		Me.lblEnv5_2.Name = "lblEnv5_2"
		Me.lblEnv5_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv5_2.TabIndex = 163
		Me.lblEnv5_2.Text = "-"
		Me.lblEnv5_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv4_2
		'
		Me.lblEnv4_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblEnv4_2.DSSElementName = Nothing
		Me.lblEnv4_2.DSSLocation = 4
		Me.lblEnv4_2.DSSOffset = 1.0R
		Me.lblEnv4_2.Location = New System.Drawing.Point(3, 69)
		Me.lblEnv4_2.Name = "lblEnv4_2"
		Me.lblEnv4_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv4_2.TabIndex = 160
		Me.lblEnv4_2.Text = "-"
		Me.lblEnv4_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv8_2
		'
		Me.lblEnv8_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblEnv8_2.DSSElementName = Nothing
		Me.lblEnv8_2.DSSLocation = 8
		Me.lblEnv8_2.DSSOffset = 1.0R
		Me.lblEnv8_2.Location = New System.Drawing.Point(3, 161)
		Me.lblEnv8_2.Name = "lblEnv8_2"
		Me.lblEnv8_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv8_2.TabIndex = 157
		Me.lblEnv8_2.Text = "-"
		Me.lblEnv8_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv11_2
		'
		Me.lblEnv11_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblEnv11_2.DSSElementName = Nothing
		Me.lblEnv11_2.DSSLocation = 11
		Me.lblEnv11_2.DSSOffset = 1.0R
		Me.lblEnv11_2.Location = New System.Drawing.Point(3, 230)
		Me.lblEnv11_2.Name = "lblEnv11_2"
		Me.lblEnv11_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv11_2.TabIndex = 154
		Me.lblEnv11_2.Text = "-"
		Me.lblEnv11_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv2_2
		'
		Me.lblEnv2_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblEnv2_2.DSSElementName = Nothing
		Me.lblEnv2_2.DSSLocation = 2
		Me.lblEnv2_2.DSSOffset = 1.0R
		Me.lblEnv2_2.Location = New System.Drawing.Point(3, 23)
		Me.lblEnv2_2.Name = "lblEnv2_2"
		Me.lblEnv2_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv2_2.TabIndex = 151
		Me.lblEnv2_2.Text = "-"
		Me.lblEnv2_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv6_2
		'
		Me.lblEnv6_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblEnv6_2.DSSElementName = Nothing
		Me.lblEnv6_2.DSSLocation = 6
		Me.lblEnv6_2.DSSOffset = 1.0R
		Me.lblEnv6_2.Location = New System.Drawing.Point(3, 115)
		Me.lblEnv6_2.Name = "lblEnv6_2"
		Me.lblEnv6_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv6_2.TabIndex = 178
		Me.lblEnv6_2.Text = "-"
		Me.lblEnv6_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv9_2
		'
		Me.lblEnv9_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblEnv9_2.DSSElementName = Nothing
		Me.lblEnv9_2.DSSLocation = 9
		Me.lblEnv9_2.DSSOffset = 1.0R
		Me.lblEnv9_2.Location = New System.Drawing.Point(3, 184)
		Me.lblEnv9_2.Name = "lblEnv9_2"
		Me.lblEnv9_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv9_2.TabIndex = 185
		Me.lblEnv9_2.Text = "-"
		Me.lblEnv9_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv12_2
		'
		Me.lblEnv12_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblEnv12_2.DSSElementName = Nothing
		Me.lblEnv12_2.DSSLocation = 12
		Me.lblEnv12_2.DSSOffset = 1.0R
		Me.lblEnv12_2.Location = New System.Drawing.Point(3, 253)
		Me.lblEnv12_2.Name = "lblEnv12_2"
		Me.lblEnv12_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv12_2.TabIndex = 182
		Me.lblEnv12_2.Text = "-"
		Me.lblEnv12_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv13_2
		'
		Me.lblEnv13_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblEnv13_2.DSSElementName = Nothing
		Me.lblEnv13_2.DSSLocation = 13
		Me.lblEnv13_2.DSSOffset = 1.0R
		Me.lblEnv13_2.Location = New System.Drawing.Point(3, 276)
		Me.lblEnv13_2.Name = "lblEnv13_2"
		Me.lblEnv13_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv13_2.TabIndex = 150
		Me.lblEnv13_2.Text = "-"
		Me.lblEnv13_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv3_2
		'
		Me.lblEnv3_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblEnv3_2.DSSElementName = Nothing
		Me.lblEnv3_2.DSSLocation = 3
		Me.lblEnv3_2.DSSOffset = 1.0R
		Me.lblEnv3_2.Location = New System.Drawing.Point(3, 46)
		Me.lblEnv3_2.Name = "lblEnv3_2"
		Me.lblEnv3_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv3_2.TabIndex = 187
		Me.lblEnv3_2.Text = "-"
		Me.lblEnv3_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv7_2
		'
		Me.lblEnv7_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblEnv7_2.DSSElementName = Nothing
		Me.lblEnv7_2.DSSLocation = 7
		Me.lblEnv7_2.DSSOffset = 1.0R
		Me.lblEnv7_2.Location = New System.Drawing.Point(3, 138)
		Me.lblEnv7_2.Name = "lblEnv7_2"
		Me.lblEnv7_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv7_2.TabIndex = 176
		Me.lblEnv7_2.Text = "-"
		Me.lblEnv7_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv10_2
		'
		Me.lblEnv10_2.AccessibleDescription = ""
		Me.lblEnv10_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(238, Byte), CType(130, Byte), CType(238, Byte))
		Me.lblEnv10_2.DSSElementName = Nothing
		Me.lblEnv10_2.DSSLocation = 10
		Me.lblEnv10_2.DSSOffset = 1.0R
		Me.lblEnv10_2.Location = New System.Drawing.Point(3, 207)
		Me.lblEnv10_2.Name = "lblEnv10_2"
		Me.lblEnv10_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv10_2.TabIndex = 173
		Me.lblEnv10_2.Text = "-"
		Me.lblEnv10_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'pnlOutEnvSmall
		'
		Me.pnlOutEnvSmall.Controls.Add(Me.lblEnv14_1)
		Me.pnlOutEnvSmall.Controls.Add(Me.lblEnv15_1)
		Me.pnlOutEnvSmall.Controls.Add(Me.lblEnv1_1)
		Me.pnlOutEnvSmall.Controls.Add(Me.lblEnv5_1)
		Me.pnlOutEnvSmall.Controls.Add(Me.lblEnv4_1)
		Me.pnlOutEnvSmall.Controls.Add(Me.lblEnv8_1)
		Me.pnlOutEnvSmall.Controls.Add(Me.lblEnv11_1)
		Me.pnlOutEnvSmall.Controls.Add(Me.lblEnv2_1)
		Me.pnlOutEnvSmall.Controls.Add(Me.lblEnv6_1)
		Me.pnlOutEnvSmall.Controls.Add(Me.lblEnv9_1)
		Me.pnlOutEnvSmall.Controls.Add(Me.lblEnv12_1)
		Me.pnlOutEnvSmall.Controls.Add(Me.lblEnv13_1)
		Me.pnlOutEnvSmall.Controls.Add(Me.lblEnv3_1)
		Me.pnlOutEnvSmall.Controls.Add(Me.lblEnv10_1)
		Me.pnlOutEnvSmall.Controls.Add(Me.lblEnv7_1)
		Me.pnlOutEnvSmall.DSSVisible = False
		Me.pnlOutEnvSmall.Location = New System.Drawing.Point(187, 59)
		Me.pnlOutEnvSmall.Name = "pnlOutEnvSmall"
		Me.pnlOutEnvSmall.Size = New System.Drawing.Size(49, 339)
		Me.pnlOutEnvSmall.TabIndex = 1
		'
		'lblEnv14_1
		'
		Me.lblEnv14_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEnv14_1.DSSElementName = "OutEnv14_1"
		Me.lblEnv14_1.DSSLocation = 14
		Me.lblEnv14_1.DSSOffset = -0.2R
		Me.lblEnv14_1.Location = New System.Drawing.Point(3, 296)
		Me.lblEnv14_1.Name = "lblEnv14_1"
		Me.lblEnv14_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv14_1.TabIndex = 147
		Me.lblEnv14_1.Text = "-"
		Me.lblEnv14_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv15_1
		'
		Me.lblEnv15_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEnv15_1.DSSElementName = "OutEnv15_1"
		Me.lblEnv15_1.DSSLocation = 15
		Me.lblEnv15_1.DSSOffset = -0.2R
		Me.lblEnv15_1.Location = New System.Drawing.Point(3, 319)
		Me.lblEnv15_1.Name = "lblEnv15_1"
		Me.lblEnv15_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv15_1.TabIndex = 146
		Me.lblEnv15_1.Text = "-"
		Me.lblEnv15_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv1_1
		'
		Me.lblEnv1_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEnv1_1.DSSElementName = "OutEnv1_1"
		Me.lblEnv1_1.DSSLocation = 1
		Me.lblEnv1_1.DSSOffset = -0.2R
		Me.lblEnv1_1.Location = New System.Drawing.Point(3, 0)
		Me.lblEnv1_1.Name = "lblEnv1_1"
		Me.lblEnv1_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv1_1.TabIndex = 124
		Me.lblEnv1_1.Text = "-"
		Me.lblEnv1_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv5_1
		'
		Me.lblEnv5_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEnv5_1.DSSElementName = "OutEnv5_1"
		Me.lblEnv5_1.DSSLocation = 5
		Me.lblEnv5_1.DSSOffset = -0.2R
		Me.lblEnv5_1.Location = New System.Drawing.Point(3, 92)
		Me.lblEnv5_1.Name = "lblEnv5_1"
		Me.lblEnv5_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv5_1.TabIndex = 121
		Me.lblEnv5_1.Text = "-"
		Me.lblEnv5_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv4_1
		'
		Me.lblEnv4_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEnv4_1.DSSElementName = "OutEnv4_1"
		Me.lblEnv4_1.DSSLocation = 4
		Me.lblEnv4_1.DSSOffset = -0.2R
		Me.lblEnv4_1.Location = New System.Drawing.Point(3, 69)
		Me.lblEnv4_1.Name = "lblEnv4_1"
		Me.lblEnv4_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv4_1.TabIndex = 118
		Me.lblEnv4_1.Text = "-"
		Me.lblEnv4_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv8_1
		'
		Me.lblEnv8_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEnv8_1.DSSElementName = "OutEnv8_1"
		Me.lblEnv8_1.DSSLocation = 8
		Me.lblEnv8_1.DSSOffset = -0.2R
		Me.lblEnv8_1.Location = New System.Drawing.Point(3, 161)
		Me.lblEnv8_1.Name = "lblEnv8_1"
		Me.lblEnv8_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv8_1.TabIndex = 115
		Me.lblEnv8_1.Text = "-"
		Me.lblEnv8_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv11_1
		'
		Me.lblEnv11_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEnv11_1.DSSElementName = "OutEnv11_1"
		Me.lblEnv11_1.DSSLocation = 11
		Me.lblEnv11_1.DSSOffset = -0.2R
		Me.lblEnv11_1.Location = New System.Drawing.Point(3, 230)
		Me.lblEnv11_1.Name = "lblEnv11_1"
		Me.lblEnv11_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv11_1.TabIndex = 112
		Me.lblEnv11_1.Text = "-"
		Me.lblEnv11_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv2_1
		'
		Me.lblEnv2_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEnv2_1.DSSElementName = "OutEnv2_1"
		Me.lblEnv2_1.DSSLocation = 2
		Me.lblEnv2_1.DSSOffset = -0.2R
		Me.lblEnv2_1.Location = New System.Drawing.Point(3, 23)
		Me.lblEnv2_1.Name = "lblEnv2_1"
		Me.lblEnv2_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv2_1.TabIndex = 109
		Me.lblEnv2_1.Text = "-"
		Me.lblEnv2_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv6_1
		'
		Me.lblEnv6_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEnv6_1.DSSElementName = "OutEnv6_1"
		Me.lblEnv6_1.DSSLocation = 6
		Me.lblEnv6_1.DSSOffset = -0.2R
		Me.lblEnv6_1.Location = New System.Drawing.Point(3, 115)
		Me.lblEnv6_1.Name = "lblEnv6_1"
		Me.lblEnv6_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv6_1.TabIndex = 136
		Me.lblEnv6_1.Text = "-"
		Me.lblEnv6_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv9_1
		'
		Me.lblEnv9_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEnv9_1.DSSElementName = "OutEnv9_1"
		Me.lblEnv9_1.DSSLocation = 9
		Me.lblEnv9_1.DSSOffset = -0.2R
		Me.lblEnv9_1.Location = New System.Drawing.Point(3, 184)
		Me.lblEnv9_1.Name = "lblEnv9_1"
		Me.lblEnv9_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv9_1.TabIndex = 143
		Me.lblEnv9_1.Text = "-"
		Me.lblEnv9_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv12_1
		'
		Me.lblEnv12_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEnv12_1.DSSElementName = "OutEnv12_1"
		Me.lblEnv12_1.DSSLocation = 12
		Me.lblEnv12_1.DSSOffset = -0.2R
		Me.lblEnv12_1.Location = New System.Drawing.Point(3, 253)
		Me.lblEnv12_1.Name = "lblEnv12_1"
		Me.lblEnv12_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv12_1.TabIndex = 140
		Me.lblEnv12_1.Text = "-"
		Me.lblEnv12_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv13_1
		'
		Me.lblEnv13_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEnv13_1.DSSElementName = "OutEnv13_1"
		Me.lblEnv13_1.DSSLocation = 13
		Me.lblEnv13_1.DSSOffset = -0.2R
		Me.lblEnv13_1.Location = New System.Drawing.Point(3, 276)
		Me.lblEnv13_1.Name = "lblEnv13_1"
		Me.lblEnv13_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv13_1.TabIndex = 108
		Me.lblEnv13_1.Text = "-"
		Me.lblEnv13_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv3_1
		'
		Me.lblEnv3_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEnv3_1.DSSElementName = "OutEnv3_1"
		Me.lblEnv3_1.DSSLocation = 3
		Me.lblEnv3_1.DSSOffset = -0.2R
		Me.lblEnv3_1.Location = New System.Drawing.Point(3, 46)
		Me.lblEnv3_1.Name = "lblEnv3_1"
		Me.lblEnv3_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv3_1.TabIndex = 145
		Me.lblEnv3_1.Text = "-"
		Me.lblEnv3_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv10_1
		'
		Me.lblEnv10_1.AccessibleDescription = ""
		Me.lblEnv10_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEnv10_1.DSSElementName = "OutEnv10_1"
		Me.lblEnv10_1.DSSLocation = 10
		Me.lblEnv10_1.DSSOffset = -0.2R
		Me.lblEnv10_1.Location = New System.Drawing.Point(3, 207)
		Me.lblEnv10_1.Name = "lblEnv10_1"
		Me.lblEnv10_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv10_1.TabIndex = 131
		Me.lblEnv10_1.Text = "-"
		Me.lblEnv10_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv7_1
		'
		Me.lblEnv7_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEnv7_1.DSSElementName = "OutEnv7_1"
		Me.lblEnv7_1.DSSLocation = 7
		Me.lblEnv7_1.DSSOffset = -0.2R
		Me.lblEnv7_1.Location = New System.Drawing.Point(3, 138)
		Me.lblEnv7_1.Name = "lblEnv7_1"
		Me.lblEnv7_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv7_1.TabIndex = 134
		Me.lblEnv7_1.Text = "-"
		Me.lblEnv7_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'pnlOutEcoLarge
		'
		Me.pnlOutEcoLarge.Controls.Add(Me.lblEco14_2)
		Me.pnlOutEcoLarge.Controls.Add(Me.lblEco15_2)
		Me.pnlOutEcoLarge.Controls.Add(Me.lblEco1_2)
		Me.pnlOutEcoLarge.Controls.Add(Me.lblEco5_2)
		Me.pnlOutEcoLarge.Controls.Add(Me.lblEco4_2)
		Me.pnlOutEcoLarge.Controls.Add(Me.lblEco8_2)
		Me.pnlOutEcoLarge.Controls.Add(Me.lblEco11_2)
		Me.pnlOutEcoLarge.Controls.Add(Me.lblEco2_2)
		Me.pnlOutEcoLarge.Controls.Add(Me.lblEco6_2)
		Me.pnlOutEcoLarge.Controls.Add(Me.lblEco9_2)
		Me.pnlOutEcoLarge.Controls.Add(Me.lblEco12_2)
		Me.pnlOutEcoLarge.Controls.Add(Me.lblEco13_2)
		Me.pnlOutEcoLarge.Controls.Add(Me.lblEco3_2)
		Me.pnlOutEcoLarge.Controls.Add(Me.lblEco10_2)
		Me.pnlOutEcoLarge.Controls.Add(Me.lblEco7_2)
		Me.pnlOutEcoLarge.DSSVisible = False
		Me.pnlOutEcoLarge.Location = New System.Drawing.Point(241, 59)
		Me.pnlOutEcoLarge.Name = "pnlOutEcoLarge"
		Me.pnlOutEcoLarge.Size = New System.Drawing.Size(49, 339)
		Me.pnlOutEcoLarge.TabIndex = 1
		'
		'lblEco14_2
		'
		Me.lblEco14_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEco14_2.DSSElementName = "OutEco14_2"
		Me.lblEco14_2.DSSLocation = 14
		Me.lblEco14_2.DSSOffset = 0.2R
		Me.lblEco14_2.Location = New System.Drawing.Point(3, 296)
		Me.lblEco14_2.Name = "lblEco14_2"
		Me.lblEco14_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEco14_2.TabIndex = 190
		Me.lblEco14_2.Text = "-"
		Me.lblEco14_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco15_2
		'
		Me.lblEco15_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEco15_2.DSSElementName = "OutEco15_2"
		Me.lblEco15_2.DSSLocation = 15
		Me.lblEco15_2.DSSOffset = 0.2R
		Me.lblEco15_2.Location = New System.Drawing.Point(3, 319)
		Me.lblEco15_2.Name = "lblEco15_2"
		Me.lblEco15_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEco15_2.TabIndex = 189
		Me.lblEco15_2.Text = "-"
		Me.lblEco15_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco1_2
		'
		Me.lblEco1_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEco1_2.DSSElementName = "OutEco1_2"
		Me.lblEco1_2.DSSLocation = 1
		Me.lblEco1_2.DSSOffset = 0.2R
		Me.lblEco1_2.Location = New System.Drawing.Point(3, 0)
		Me.lblEco1_2.Name = "lblEco1_2"
		Me.lblEco1_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEco1_2.TabIndex = 188
		Me.lblEco1_2.Text = "-"
		Me.lblEco1_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco5_2
		'
		Me.lblEco5_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEco5_2.DSSElementName = "OutEco5_2"
		Me.lblEco5_2.DSSLocation = 5
		Me.lblEco5_2.DSSOffset = 0.2R
		Me.lblEco5_2.Location = New System.Drawing.Point(3, 92)
		Me.lblEco5_2.Name = "lblEco5_2"
		Me.lblEco5_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEco5_2.TabIndex = 165
		Me.lblEco5_2.Text = "-"
		Me.lblEco5_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco4_2
		'
		Me.lblEco4_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEco4_2.DSSElementName = "OutEco4_2"
		Me.lblEco4_2.DSSLocation = 4
		Me.lblEco4_2.DSSOffset = 0.2R
		Me.lblEco4_2.Location = New System.Drawing.Point(3, 69)
		Me.lblEco4_2.Name = "lblEco4_2"
		Me.lblEco4_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEco4_2.TabIndex = 162
		Me.lblEco4_2.Text = "-"
		Me.lblEco4_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco8_2
		'
		Me.lblEco8_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEco8_2.DSSElementName = "OutEco8_2"
		Me.lblEco8_2.DSSLocation = 8
		Me.lblEco8_2.DSSOffset = 0.2R
		Me.lblEco8_2.Location = New System.Drawing.Point(3, 161)
		Me.lblEco8_2.Name = "lblEco8_2"
		Me.lblEco8_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEco8_2.TabIndex = 167
		Me.lblEco8_2.Text = "-"
		Me.lblEco8_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco11_2
		'
		Me.lblEco11_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEco11_2.DSSElementName = "OutEco11_2"
		Me.lblEco11_2.DSSLocation = 11
		Me.lblEco11_2.DSSOffset = 0.2R
		Me.lblEco11_2.Location = New System.Drawing.Point(3, 230)
		Me.lblEco11_2.Name = "lblEco11_2"
		Me.lblEco11_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEco11_2.TabIndex = 156
		Me.lblEco11_2.Text = "-"
		Me.lblEco11_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco2_2
		'
		Me.lblEco2_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEco2_2.DSSElementName = "OutEco2_2"
		Me.lblEco2_2.DSSLocation = 2
		Me.lblEco2_2.DSSOffset = 0.2R
		Me.lblEco2_2.Location = New System.Drawing.Point(3, 23)
		Me.lblEco2_2.Name = "lblEco2_2"
		Me.lblEco2_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEco2_2.TabIndex = 153
		Me.lblEco2_2.Text = "-"
		Me.lblEco2_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco6_2
		'
		Me.lblEco6_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEco6_2.DSSElementName = "OutEco6_2"
		Me.lblEco6_2.DSSLocation = 6
		Me.lblEco6_2.DSSOffset = 0.2R
		Me.lblEco6_2.Location = New System.Drawing.Point(3, 115)
		Me.lblEco6_2.Name = "lblEco6_2"
		Me.lblEco6_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEco6_2.TabIndex = 158
		Me.lblEco6_2.Text = "-"
		Me.lblEco6_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco9_2
		'
		Me.lblEco9_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEco9_2.DSSElementName = "OutEco9_2"
		Me.lblEco9_2.DSSLocation = 9
		Me.lblEco9_2.DSSOffset = 0.2R
		Me.lblEco9_2.Location = New System.Drawing.Point(3, 184)
		Me.lblEco9_2.Name = "lblEco9_2"
		Me.lblEco9_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEco9_2.TabIndex = 170
		Me.lblEco9_2.Text = "-"
		Me.lblEco9_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco12_2
		'
		Me.lblEco12_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEco12_2.DSSElementName = "OutEco12_2"
		Me.lblEco12_2.DSSLocation = 12
		Me.lblEco12_2.DSSOffset = 0.2R
		Me.lblEco12_2.Location = New System.Drawing.Point(3, 253)
		Me.lblEco12_2.Name = "lblEco12_2"
		Me.lblEco12_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEco12_2.TabIndex = 184
		Me.lblEco12_2.Text = "-"
		Me.lblEco12_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco13_2
		'
		Me.lblEco13_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEco13_2.DSSElementName = "OutEco13_2"
		Me.lblEco13_2.DSSLocation = 13
		Me.lblEco13_2.DSSOffset = 0.2R
		Me.lblEco13_2.Location = New System.Drawing.Point(3, 276)
		Me.lblEco13_2.Name = "lblEco13_2"
		Me.lblEco13_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEco13_2.TabIndex = 172
		Me.lblEco13_2.Text = "-"
		Me.lblEco13_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco3_2
		'
		Me.lblEco3_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEco3_2.DSSElementName = "OutEco3_2"
		Me.lblEco3_2.DSSLocation = 3
		Me.lblEco3_2.DSSOffset = 0.2R
		Me.lblEco3_2.Location = New System.Drawing.Point(3, 46)
		Me.lblEco3_2.Name = "lblEco3_2"
		Me.lblEco3_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEco3_2.TabIndex = 181
		Me.lblEco3_2.Text = "-"
		Me.lblEco3_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco10_2
		'
		Me.lblEco10_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEco10_2.DSSElementName = "OutEco10_2"
		Me.lblEco10_2.DSSLocation = 10
		Me.lblEco10_2.DSSOffset = 0.2R
		Me.lblEco10_2.Location = New System.Drawing.Point(3, 207)
		Me.lblEco10_2.Name = "lblEco10_2"
		Me.lblEco10_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEco10_2.TabIndex = 175
		Me.lblEco10_2.Text = "-"
		Me.lblEco10_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco7_2
		'
		Me.lblEco7_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
		Me.lblEco7_2.DSSElementName = "OutEco7_2"
		Me.lblEco7_2.DSSLocation = 7
		Me.lblEco7_2.DSSOffset = 0.2R
		Me.lblEco7_2.Location = New System.Drawing.Point(3, 138)
		Me.lblEco7_2.Name = "lblEco7_2"
		Me.lblEco7_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEco7_2.TabIndex = 179
		Me.lblEco7_2.Text = "-"
		Me.lblEco7_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'pnlOutSocLarge
		'
		Me.pnlOutSocLarge.Controls.Add(Me.lblSoc14_2)
		Me.pnlOutSocLarge.Controls.Add(Me.lblSoc15_2)
		Me.pnlOutSocLarge.Controls.Add(Me.lblSoc1_2)
		Me.pnlOutSocLarge.Controls.Add(Me.lblSoc5_2)
		Me.pnlOutSocLarge.Controls.Add(Me.lblSoc4_2)
		Me.pnlOutSocLarge.Controls.Add(Me.lblSoc8_2)
		Me.pnlOutSocLarge.Controls.Add(Me.lblSoc11_2)
		Me.pnlOutSocLarge.Controls.Add(Me.lblSoc2_2)
		Me.pnlOutSocLarge.Controls.Add(Me.lblSoc6_2)
		Me.pnlOutSocLarge.Controls.Add(Me.lblSoc9_2)
		Me.pnlOutSocLarge.Controls.Add(Me.lblSoc12_2)
		Me.pnlOutSocLarge.Controls.Add(Me.lblSoc13_2)
		Me.pnlOutSocLarge.Controls.Add(Me.lblSoc3_2)
		Me.pnlOutSocLarge.Controls.Add(Me.lblSoc7_2)
		Me.pnlOutSocLarge.Controls.Add(Me.lblSoc10_2)
		Me.pnlOutSocLarge.DSSVisible = False
		Me.pnlOutSocLarge.Location = New System.Drawing.Point(295, 59)
		Me.pnlOutSocLarge.Name = "pnlOutSocLarge"
		Me.pnlOutSocLarge.Size = New System.Drawing.Size(49, 339)
		Me.pnlOutSocLarge.TabIndex = 1
		'
		'lblSoc14_2
		'
		Me.lblSoc14_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblSoc14_2.DSSElementName = Nothing
		Me.lblSoc14_2.DSSLocation = 14
		Me.lblSoc14_2.DSSOffset = 0.6R
		Me.lblSoc14_2.Location = New System.Drawing.Point(3, 296)
		Me.lblSoc14_2.Name = "lblSoc14_2"
		Me.lblSoc14_2.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc14_2.TabIndex = 188
		Me.lblSoc14_2.Text = "-"
		Me.lblSoc14_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc15_2
		'
		Me.lblSoc15_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblSoc15_2.DSSElementName = Nothing
		Me.lblSoc15_2.DSSLocation = 15
		Me.lblSoc15_2.DSSOffset = 0.6R
		Me.lblSoc15_2.Location = New System.Drawing.Point(3, 319)
		Me.lblSoc15_2.Name = "lblSoc15_2"
		Me.lblSoc15_2.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc15_2.TabIndex = 187
		Me.lblSoc15_2.Text = "-"
		Me.lblSoc15_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc1_2
		'
		Me.lblSoc1_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblSoc1_2.DSSElementName = Nothing
		Me.lblSoc1_2.DSSLocation = 1
		Me.lblSoc1_2.DSSOffset = 0.6R
		Me.lblSoc1_2.Location = New System.Drawing.Point(3, 0)
		Me.lblSoc1_2.Name = "lblSoc1_2"
		Me.lblSoc1_2.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc1_2.TabIndex = 168
		Me.lblSoc1_2.Text = "-"
		Me.lblSoc1_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc5_2
		'
		Me.lblSoc5_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblSoc5_2.DSSElementName = Nothing
		Me.lblSoc5_2.DSSLocation = 5
		Me.lblSoc5_2.DSSOffset = 0.6R
		Me.lblSoc5_2.Location = New System.Drawing.Point(3, 92)
		Me.lblSoc5_2.Name = "lblSoc5_2"
		Me.lblSoc5_2.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc5_2.TabIndex = 164
		Me.lblSoc5_2.Text = "-"
		Me.lblSoc5_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc4_2
		'
		Me.lblSoc4_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblSoc4_2.DSSElementName = Nothing
		Me.lblSoc4_2.DSSLocation = 4
		Me.lblSoc4_2.DSSOffset = 0.6R
		Me.lblSoc4_2.Location = New System.Drawing.Point(3, 69)
		Me.lblSoc4_2.Name = "lblSoc4_2"
		Me.lblSoc4_2.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc4_2.TabIndex = 161
		Me.lblSoc4_2.Text = "-"
		Me.lblSoc4_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc8_2
		'
		Me.lblSoc8_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblSoc8_2.DSSElementName = Nothing
		Me.lblSoc8_2.DSSLocation = 8
		Me.lblSoc8_2.DSSOffset = 0.6R
		Me.lblSoc8_2.Location = New System.Drawing.Point(3, 161)
		Me.lblSoc8_2.Name = "lblSoc8_2"
		Me.lblSoc8_2.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc8_2.TabIndex = 159
		Me.lblSoc8_2.Text = "-"
		Me.lblSoc8_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc11_2
		'
		Me.lblSoc11_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblSoc11_2.DSSElementName = Nothing
		Me.lblSoc11_2.DSSLocation = 11
		Me.lblSoc11_2.DSSOffset = 0.6R
		Me.lblSoc11_2.Location = New System.Drawing.Point(3, 230)
		Me.lblSoc11_2.Name = "lblSoc11_2"
		Me.lblSoc11_2.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc11_2.TabIndex = 155
		Me.lblSoc11_2.Text = "-"
		Me.lblSoc11_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc2_2
		'
		Me.lblSoc2_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblSoc2_2.DSSElementName = Nothing
		Me.lblSoc2_2.DSSLocation = 2
		Me.lblSoc2_2.DSSOffset = 0.6R
		Me.lblSoc2_2.Location = New System.Drawing.Point(3, 23)
		Me.lblSoc2_2.Name = "lblSoc2_2"
		Me.lblSoc2_2.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc2_2.TabIndex = 152
		Me.lblSoc2_2.Text = "-"
		Me.lblSoc2_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc6_2
		'
		Me.lblSoc6_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblSoc6_2.DSSElementName = Nothing
		Me.lblSoc6_2.DSSLocation = 6
		Me.lblSoc6_2.DSSOffset = 0.6R
		Me.lblSoc6_2.Location = New System.Drawing.Point(3, 115)
		Me.lblSoc6_2.Name = "lblSoc6_2"
		Me.lblSoc6_2.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc6_2.TabIndex = 169
		Me.lblSoc6_2.Text = "-"
		Me.lblSoc6_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc9_2
		'
		Me.lblSoc9_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblSoc9_2.DSSElementName = Nothing
		Me.lblSoc9_2.DSSLocation = 9
		Me.lblSoc9_2.DSSOffset = 0.6R
		Me.lblSoc9_2.Location = New System.Drawing.Point(3, 184)
		Me.lblSoc9_2.Name = "lblSoc9_2"
		Me.lblSoc9_2.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc9_2.TabIndex = 186
		Me.lblSoc9_2.Text = "-"
		Me.lblSoc9_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc12_2
		'
		Me.lblSoc12_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblSoc12_2.DSSElementName = Nothing
		Me.lblSoc12_2.DSSLocation = 12
		Me.lblSoc12_2.DSSOffset = 0.6R
		Me.lblSoc12_2.Location = New System.Drawing.Point(3, 253)
		Me.lblSoc12_2.Name = "lblSoc12_2"
		Me.lblSoc12_2.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc12_2.TabIndex = 183
		Me.lblSoc12_2.Text = "-"
		Me.lblSoc12_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc13_2
		'
		Me.lblSoc13_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblSoc13_2.DSSElementName = Nothing
		Me.lblSoc13_2.DSSLocation = 13
		Me.lblSoc13_2.DSSOffset = 0.6R
		Me.lblSoc13_2.Location = New System.Drawing.Point(3, 276)
		Me.lblSoc13_2.Name = "lblSoc13_2"
		Me.lblSoc13_2.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc13_2.TabIndex = 171
		Me.lblSoc13_2.Text = "-"
		Me.lblSoc13_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc3_2
		'
		Me.lblSoc3_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblSoc3_2.DSSElementName = Nothing
		Me.lblSoc3_2.DSSLocation = 3
		Me.lblSoc3_2.DSSOffset = 0.6R
		Me.lblSoc3_2.Location = New System.Drawing.Point(3, 46)
		Me.lblSoc3_2.Name = "lblSoc3_2"
		Me.lblSoc3_2.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc3_2.TabIndex = 180
		Me.lblSoc3_2.Text = "-"
		Me.lblSoc3_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc7_2
		'
		Me.lblSoc7_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblSoc7_2.DSSElementName = Nothing
		Me.lblSoc7_2.DSSLocation = 7
		Me.lblSoc7_2.DSSOffset = 0.6R
		Me.lblSoc7_2.Location = New System.Drawing.Point(3, 138)
		Me.lblSoc7_2.Name = "lblSoc7_2"
		Me.lblSoc7_2.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc7_2.TabIndex = 177
		Me.lblSoc7_2.Text = "-"
		Me.lblSoc7_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc10_2
		'
		Me.lblSoc10_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.lblSoc10_2.DSSElementName = Nothing
		Me.lblSoc10_2.DSSLocation = 10
		Me.lblSoc10_2.DSSOffset = 0.6R
		Me.lblSoc10_2.Location = New System.Drawing.Point(3, 207)
		Me.lblSoc10_2.Name = "lblSoc10_2"
		Me.lblSoc10_2.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc10_2.TabIndex = 174
		Me.lblSoc10_2.Text = "-"
		Me.lblSoc10_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'pnlOutEcoSmall
		'
		Me.pnlOutEcoSmall.Controls.Add(Me.lblEco14_1)
		Me.pnlOutEcoSmall.Controls.Add(Me.lblEco15_1)
		Me.pnlOutEcoSmall.Controls.Add(Me.lblEco1_1)
		Me.pnlOutEcoSmall.Controls.Add(Me.lblEco5_1)
		Me.pnlOutEcoSmall.Controls.Add(Me.lblEco4_1)
		Me.pnlOutEcoSmall.Controls.Add(Me.lblEco8_1)
		Me.pnlOutEcoSmall.Controls.Add(Me.lblEco11_1)
		Me.pnlOutEcoSmall.Controls.Add(Me.lblEco2_1)
		Me.pnlOutEcoSmall.Controls.Add(Me.lblEco6_1)
		Me.pnlOutEcoSmall.Controls.Add(Me.lblEco9_1)
		Me.pnlOutEcoSmall.Controls.Add(Me.lblEco12_1)
		Me.pnlOutEcoSmall.Controls.Add(Me.lblEco3_1)
		Me.pnlOutEcoSmall.Controls.Add(Me.lblEco7_1)
		Me.pnlOutEcoSmall.Controls.Add(Me.lblEco10_1)
		Me.pnlOutEcoSmall.Controls.Add(Me.lblEco13_1)
		Me.pnlOutEcoSmall.DSSVisible = False
		Me.pnlOutEcoSmall.Location = New System.Drawing.Point(79, 59)
		Me.pnlOutEcoSmall.Name = "pnlOutEcoSmall"
		Me.pnlOutEcoSmall.Size = New System.Drawing.Size(49, 339)
		Me.pnlOutEcoSmall.TabIndex = 0
		'
		'lblEco14_1
		'
		Me.lblEco14_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEco14_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco14_1.DSSElementName = "OutEco14_1"
		Me.lblEco14_1.DSSLocation = 14
		Me.lblEco14_1.DSSOffset = -1.0R
		Me.lblEco14_1.Location = New System.Drawing.Point(3, 296)
		Me.lblEco14_1.Name = "lblEco14_1"
		Me.lblEco14_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEco14_1.TabIndex = 148
		Me.lblEco14_1.Text = "-"
		Me.lblEco14_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco15_1
		'
		Me.lblEco15_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEco15_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco15_1.DSSElementName = "OutEco15_1"
		Me.lblEco15_1.DSSLocation = 15
		Me.lblEco15_1.DSSOffset = -1.0R
		Me.lblEco15_1.Location = New System.Drawing.Point(3, 319)
		Me.lblEco15_1.Name = "lblEco15_1"
		Me.lblEco15_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEco15_1.TabIndex = 147
		Me.lblEco15_1.Text = "-"
		Me.lblEco15_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco1_1
		'
		Me.lblEco1_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEco1_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco1_1.DSSElementName = "OutEco1_1"
		Me.lblEco1_1.DSSLocation = 1
		Me.lblEco1_1.DSSOffset = -1.0R
		Me.lblEco1_1.Location = New System.Drawing.Point(3, 0)
		Me.lblEco1_1.Name = "lblEco1_1"
		Me.lblEco1_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEco1_1.TabIndex = 146
		Me.lblEco1_1.Text = "-"
		Me.lblEco1_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco5_1
		'
		Me.lblEco5_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEco5_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco5_1.DSSElementName = "OutEco5_1"
		Me.lblEco5_1.DSSLocation = 5
		Me.lblEco5_1.DSSOffset = -1.0R
		Me.lblEco5_1.Location = New System.Drawing.Point(3, 92)
		Me.lblEco5_1.Name = "lblEco5_1"
		Me.lblEco5_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEco5_1.TabIndex = 123
		Me.lblEco5_1.Text = "-"
		Me.lblEco5_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco4_1
		'
		Me.lblEco4_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEco4_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco4_1.DSSElementName = "OutEco4_1"
		Me.lblEco4_1.DSSLocation = 4
		Me.lblEco4_1.DSSOffset = -1.0R
		Me.lblEco4_1.Location = New System.Drawing.Point(3, 69)
		Me.lblEco4_1.Name = "lblEco4_1"
		Me.lblEco4_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEco4_1.TabIndex = 120
		Me.lblEco4_1.Text = "-"
		Me.lblEco4_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco8_1
		'
		Me.lblEco8_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEco8_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco8_1.DSSElementName = "OutEco8_1"
		Me.lblEco8_1.DSSLocation = 8
		Me.lblEco8_1.DSSOffset = -1.0R
		Me.lblEco8_1.Location = New System.Drawing.Point(3, 161)
		Me.lblEco8_1.Name = "lblEco8_1"
		Me.lblEco8_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEco8_1.TabIndex = 125
		Me.lblEco8_1.Text = "-"
		Me.lblEco8_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco11_1
		'
		Me.lblEco11_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEco11_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco11_1.DSSElementName = "OutEco11_1"
		Me.lblEco11_1.DSSLocation = 11
		Me.lblEco11_1.DSSOffset = -1.0R
		Me.lblEco11_1.Location = New System.Drawing.Point(3, 230)
		Me.lblEco11_1.Name = "lblEco11_1"
		Me.lblEco11_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEco11_1.TabIndex = 114
		Me.lblEco11_1.Text = "-"
		Me.lblEco11_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco2_1
		'
		Me.lblEco2_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEco2_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco2_1.DSSElementName = "OutEco2_1"
		Me.lblEco2_1.DSSLocation = 2
		Me.lblEco2_1.DSSOffset = -1.0R
		Me.lblEco2_1.Location = New System.Drawing.Point(3, 23)
		Me.lblEco2_1.Name = "lblEco2_1"
		Me.lblEco2_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEco2_1.TabIndex = 111
		Me.lblEco2_1.Text = "-"
		Me.lblEco2_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco6_1
		'
		Me.lblEco6_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEco6_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco6_1.DSSElementName = "OutEco6_1"
		Me.lblEco6_1.DSSLocation = 6
		Me.lblEco6_1.DSSOffset = -1.0R
		Me.lblEco6_1.Location = New System.Drawing.Point(3, 115)
		Me.lblEco6_1.Name = "lblEco6_1"
		Me.lblEco6_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEco6_1.TabIndex = 116
		Me.lblEco6_1.Text = "-"
		Me.lblEco6_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco9_1
		'
		Me.lblEco9_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEco9_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco9_1.DSSElementName = "OutEco9_1"
		Me.lblEco9_1.DSSLocation = 9
		Me.lblEco9_1.DSSOffset = -1.0R
		Me.lblEco9_1.Location = New System.Drawing.Point(3, 184)
		Me.lblEco9_1.Name = "lblEco9_1"
		Me.lblEco9_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEco9_1.TabIndex = 128
		Me.lblEco9_1.Text = "-"
		Me.lblEco9_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco12_1
		'
		Me.lblEco12_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEco12_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco12_1.DSSElementName = "OutEco12_1"
		Me.lblEco12_1.DSSLocation = 12
		Me.lblEco12_1.DSSOffset = -1.0R
		Me.lblEco12_1.Location = New System.Drawing.Point(3, 253)
		Me.lblEco12_1.Name = "lblEco12_1"
		Me.lblEco12_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEco12_1.TabIndex = 142
		Me.lblEco12_1.Text = "-"
		Me.lblEco12_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco3_1
		'
		Me.lblEco3_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEco3_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco3_1.DSSElementName = "OutEco3_1"
		Me.lblEco3_1.DSSLocation = 3
		Me.lblEco3_1.DSSOffset = -1.0R
		Me.lblEco3_1.Location = New System.Drawing.Point(3, 46)
		Me.lblEco3_1.Name = "lblEco3_1"
		Me.lblEco3_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEco3_1.TabIndex = 139
		Me.lblEco3_1.Text = "-"
		Me.lblEco3_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco7_1
		'
		Me.lblEco7_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEco7_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco7_1.DSSElementName = "OutEco7_1"
		Me.lblEco7_1.DSSLocation = 7
		Me.lblEco7_1.DSSOffset = -1.0R
		Me.lblEco7_1.Location = New System.Drawing.Point(3, 138)
		Me.lblEco7_1.Name = "lblEco7_1"
		Me.lblEco7_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEco7_1.TabIndex = 137
		Me.lblEco7_1.Text = "-"
		Me.lblEco7_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco10_1
		'
		Me.lblEco10_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEco10_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco10_1.DSSElementName = "OutEco10_1"
		Me.lblEco10_1.DSSLocation = 10
		Me.lblEco10_1.DSSOffset = -1.0R
		Me.lblEco10_1.Location = New System.Drawing.Point(3, 207)
		Me.lblEco10_1.Name = "lblEco10_1"
		Me.lblEco10_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEco10_1.TabIndex = 133
		Me.lblEco10_1.Text = "-"
		Me.lblEco10_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco13_1
		'
		Me.lblEco13_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEco13_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco13_1.DSSElementName = "OutEco13_1"
		Me.lblEco13_1.DSSLocation = 13
		Me.lblEco13_1.DSSOffset = -1.0R
		Me.lblEco13_1.Location = New System.Drawing.Point(3, 276)
		Me.lblEco13_1.Name = "lblEco13_1"
		Me.lblEco13_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEco13_1.TabIndex = 130
		Me.lblEco13_1.Text = "-"
		Me.lblEco13_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Label180
		'
		Me.Label180.Location = New System.Drawing.Point(82, 34)
		Me.Label180.Name = "Label180"
		Me.Label180.Size = New System.Drawing.Size(34, 20)
		Me.Label180.TabIndex = 107
		Me.Label180.Text = "eco"
		Me.Label180.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label98
		'
		Me.Label98.Location = New System.Drawing.Point(263, 14)
		Me.Label98.Name = "Label98"
		Me.Label98.Size = New System.Drawing.Size(97, 20)
		Me.Label98.TabIndex = 190
		Me.Label98.Text = "Medium"
		Me.Label98.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label179
		'
		Me.Label179.Location = New System.Drawing.Point(141, 34)
		Me.Label179.Name = "Label179"
		Me.Label179.Size = New System.Drawing.Size(34, 20)
		Me.Label179.TabIndex = 106
		Me.Label179.Text = "soc"
		Me.Label179.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label99
		'
		Me.Label99.Location = New System.Drawing.Point(110, 14)
		Me.Label99.Name = "Label99"
		Me.Label99.Size = New System.Drawing.Size(97, 20)
		Me.Label99.TabIndex = 189
		Me.Label99.Text = "Small"
		Me.Label99.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label95
		'
		Me.Label95.Location = New System.Drawing.Point(356, 34)
		Me.Label95.Name = "Label95"
		Me.Label95.Size = New System.Drawing.Size(34, 20)
		Me.Label95.TabIndex = 147
		Me.Label95.Text = "env"
		Me.Label95.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label178
		'
		Me.Label178.Location = New System.Drawing.Point(190, 34)
		Me.Label178.Name = "Label178"
		Me.Label178.Size = New System.Drawing.Size(34, 20)
		Me.Label178.TabIndex = 105
		Me.Label178.Text = "env"
		Me.Label178.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label97
		'
		Me.Label97.Location = New System.Drawing.Point(244, 34)
		Me.Label97.Name = "Label97"
		Me.Label97.Size = New System.Drawing.Size(34, 20)
		Me.Label97.TabIndex = 149
		Me.Label97.Text = "eco"
		Me.Label97.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label96
		'
		Me.Label96.Location = New System.Drawing.Point(294, 34)
		Me.Label96.Name = "Label96"
		Me.Label96.Size = New System.Drawing.Size(34, 20)
		Me.Label96.TabIndex = 148
		Me.Label96.Text = "soc"
		Me.Label96.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'tpaWeights
		'
		Me.tpaWeights.Controls.Add(Me.pboGraphWeights)
		Me.tpaWeights.Location = New System.Drawing.Point(4, 22)
		Me.tpaWeights.Name = "tpaWeights"
		Me.tpaWeights.Size = New System.Drawing.Size(465, 471)
		Me.tpaWeights.TabIndex = 4
		Me.tpaWeights.Text = "Weights"
		Me.tpaWeights.UseVisualStyleBackColor = True
		'
		'pboGraphWeights
		'
		Me.pboGraphWeights.Location = New System.Drawing.Point(37, 43)
		Me.pboGraphWeights.Name = "pboGraphWeights"
		Me.pboGraphWeights.Size = New System.Drawing.Size(441, 334)
		Me.pboGraphWeights.TabIndex = 0
		Me.pboGraphWeights.TabStop = False
		'
		'tpaStandards
		'
		Me.tpaStandards.Controls.Add(Me.pboGraphStandards)
		Me.tpaStandards.Location = New System.Drawing.Point(4, 22)
		Me.tpaStandards.Name = "tpaStandards"
		Me.tpaStandards.Size = New System.Drawing.Size(465, 471)
		Me.tpaStandards.TabIndex = 5
		Me.tpaStandards.Text = "Standards"
		Me.tpaStandards.UseVisualStyleBackColor = True
		'
		'pboGraphStandards
		'
		Me.pboGraphStandards.Location = New System.Drawing.Point(37, 43)
		Me.pboGraphStandards.Name = "pboGraphStandards"
		Me.pboGraphStandards.Size = New System.Drawing.Size(441, 334)
		Me.pboGraphStandards.TabIndex = 0
		Me.pboGraphStandards.TabStop = False
		'
		'tpaEfficencies
		'
		Me.tpaEfficencies.Controls.Add(Me.pboGraphEfficiencies)
		Me.tpaEfficencies.Location = New System.Drawing.Point(4, 22)
		Me.tpaEfficencies.Name = "tpaEfficencies"
		Me.tpaEfficencies.Size = New System.Drawing.Size(465, 471)
		Me.tpaEfficencies.TabIndex = 6
		Me.tpaEfficencies.Text = "Efficiencies"
		Me.tpaEfficencies.UseVisualStyleBackColor = True
		'
		'pboGraphEfficiencies
		'
		Me.pboGraphEfficiencies.Location = New System.Drawing.Point(37, 43)
		Me.pboGraphEfficiencies.Name = "pboGraphEfficiencies"
		Me.pboGraphEfficiencies.Size = New System.Drawing.Size(441, 334)
		Me.pboGraphEfficiencies.TabIndex = 0
		Me.pboGraphEfficiencies.TabStop = False
		'
		'grbPopulation
		'
		Me.grbPopulation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.grbPopulation.Controls.Add(Me.lblTPLocation15)
		Me.grbPopulation.Controls.Add(Me.pnlPop20_2)
		Me.grbPopulation.Controls.Add(Me.lblTPLocation14)
		Me.grbPopulation.Controls.Add(Me.pnlPop20_1)
		Me.grbPopulation.Controls.Add(Me.lblTPLocation12)
		Me.grbPopulation.Controls.Add(Me.Label69)
		Me.grbPopulation.Controls.Add(Me.lblTPLocation11)
		Me.grbPopulation.Controls.Add(Me.lblTPLocation1)
		Me.grbPopulation.Controls.Add(Me.lblTPLocation10)
		Me.grbPopulation.Controls.Add(Me.lblTPLocation13)
		Me.grbPopulation.Controls.Add(Me.lblTPLocation9)
		Me.grbPopulation.Controls.Add(Me.lblTPLocation2)
		Me.grbPopulation.Controls.Add(Me.lblTPLocation8)
		Me.grbPopulation.Controls.Add(Me.lblTPLocation3)
		Me.grbPopulation.Controls.Add(Me.lblTPLocation7)
		Me.grbPopulation.Controls.Add(Me.lblTPLocation4)
		Me.grbPopulation.Controls.Add(Me.lblTPLocation6)
		Me.grbPopulation.Controls.Add(Me.lblTPLocation5)
		Me.grbPopulation.ForeColor = System.Drawing.Color.Black
		Me.grbPopulation.Location = New System.Drawing.Point(0, 0)
		Me.grbPopulation.Name = "grbPopulation"
		Me.grbPopulation.Size = New System.Drawing.Size(294, 516)
		Me.grbPopulation.TabIndex = 22
		Me.grbPopulation.TabStop = False
		Me.grbPopulation.Text = "Total population"
		Me.grbPopulation.Visible = False
		'
		'lblTPLocation15
		'
		Me.lblTPLocation15.AutoSize = True
		Me.lblTPLocation15.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblTPLocation15.DSSElementName = "locName"
		Me.lblTPLocation15.DSSLocation = 15
		Me.lblTPLocation15.DSSOffset = 0R
		Me.lblTPLocation15.Location = New System.Drawing.Point(12, 388)
		Me.lblTPLocation15.Name = "lblTPLocation15"
		Me.lblTPLocation15.Size = New System.Drawing.Size(56, 13)
		Me.lblTPLocation15.TabIndex = 145
		Me.lblTPLocation15.Text = "location15"
		'
		'pnlPop20_2
		'
		Me.pnlPop20_2.Controls.Add(Me.nudPop20_14_2)
		Me.pnlPop20_2.Controls.Add(Me.nudPop20_15_2)
		Me.pnlPop20_2.Controls.Add(Me.lblTot20_2)
		Me.pnlPop20_2.Controls.Add(Me.nudPop20_3_2)
		Me.pnlPop20_2.Controls.Add(Me.nudPop20_7_2)
		Me.pnlPop20_2.Controls.Add(Me.nudPop20_2_2)
		Me.pnlPop20_2.Controls.Add(Me.nudPop20_12_2)
		Me.pnlPop20_2.Controls.Add(Me.nudPop20_10_2)
		Me.pnlPop20_2.Controls.Add(Me.nudPop20_13_2)
		Me.pnlPop20_2.Controls.Add(Me.nudPop20_6_2)
		Me.pnlPop20_2.Controls.Add(Me.nudPop20_8_2)
		Me.pnlPop20_2.Controls.Add(Me.nudPop20_1_2)
		Me.pnlPop20_2.Controls.Add(Me.nudPop20_4_2)
		Me.pnlPop20_2.Controls.Add(Me.nudPop20_9_2)
		Me.pnlPop20_2.Controls.Add(Me.nudPop20_11_2)
		Me.pnlPop20_2.Controls.Add(Me.nudPop20_5_2)
		Me.pnlPop20_2.Location = New System.Drawing.Point(201, 35)
		Me.pnlPop20_2.Name = "pnlPop20_2"
		Me.pnlPop20_2.Size = New System.Drawing.Size(90, 388)
		Me.pnlPop20_2.TabIndex = 114
		'
		'nudPop20_14_2
		'
		Me.nudPop20_14_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(184, Byte), CType(0, Byte))
		Me.nudPop20_14_2.DSSElementName = "Pop20_14_2"
		Me.nudPop20_14_2.DSSLocation = 14
		Me.nudPop20_14_2.DSSOffset = 0.2R
		Me.nudPop20_14_2.Location = New System.Drawing.Point(0, 327)
		Me.nudPop20_14_2.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_14_2.Name = "nudPop20_14_2"
		Me.nudPop20_14_2.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_14_2.TabIndex = 113
		Me.nudPop20_14_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_14_2.ThousandsSeparator = True
		Me.nudPop20_14_2.Value = New Decimal(New Integer() {3, 0, 0, 65536})
		'
		'nudPop20_15_2
		'
		Me.nudPop20_15_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(184, Byte), CType(0, Byte))
		Me.nudPop20_15_2.DSSElementName = "Pop20_14_2"
		Me.nudPop20_15_2.DSSLocation = 15
		Me.nudPop20_15_2.DSSOffset = 0.2R
		Me.nudPop20_15_2.Location = New System.Drawing.Point(0, 350)
		Me.nudPop20_15_2.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_15_2.Name = "nudPop20_15_2"
		Me.nudPop20_15_2.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_15_2.TabIndex = 114
		Me.nudPop20_15_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_15_2.ThousandsSeparator = True
		Me.nudPop20_15_2.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'lblTot20_2
		'
		Me.lblTot20_2.Location = New System.Drawing.Point(0, 5)
		Me.lblTot20_2.Name = "lblTot20_2"
		Me.lblTot20_2.Size = New System.Drawing.Size(90, 13)
		Me.lblTot20_2.TabIndex = 94
		Me.lblTot20_2.Text = "Medium"
		Me.lblTot20_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'nudPop20_3_2
		'
		Me.nudPop20_3_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(184, Byte), CType(0, Byte))
		Me.nudPop20_3_2.DSSElementName = "Pop20_3_2"
		Me.nudPop20_3_2.DSSLocation = 3
		Me.nudPop20_3_2.DSSOffset = 0.2R
		Me.nudPop20_3_2.Location = New System.Drawing.Point(0, 74)
		Me.nudPop20_3_2.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_3_2.Name = "nudPop20_3_2"
		Me.nudPop20_3_2.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_3_2.TabIndex = 102
		Me.nudPop20_3_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_3_2.ThousandsSeparator = True
		Me.nudPop20_3_2.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudPop20_7_2
		'
		Me.nudPop20_7_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(184, Byte), CType(0, Byte))
		Me.nudPop20_7_2.DSSElementName = "Pop20_7_2"
		Me.nudPop20_7_2.DSSLocation = 7
		Me.nudPop20_7_2.DSSOffset = 0.2R
		Me.nudPop20_7_2.Location = New System.Drawing.Point(0, 166)
		Me.nudPop20_7_2.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_7_2.Name = "nudPop20_7_2"
		Me.nudPop20_7_2.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_7_2.TabIndex = 106
		Me.nudPop20_7_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_7_2.ThousandsSeparator = True
		Me.nudPop20_7_2.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudPop20_2_2
		'
		Me.nudPop20_2_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(184, Byte), CType(0, Byte))
		Me.nudPop20_2_2.DSSElementName = "Pop20_2_2"
		Me.nudPop20_2_2.DSSLocation = 2
		Me.nudPop20_2_2.DSSOffset = 0.2R
		Me.nudPop20_2_2.Location = New System.Drawing.Point(0, 51)
		Me.nudPop20_2_2.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_2_2.Name = "nudPop20_2_2"
		Me.nudPop20_2_2.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_2_2.TabIndex = 101
		Me.nudPop20_2_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_2_2.ThousandsSeparator = True
		Me.nudPop20_2_2.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudPop20_12_2
		'
		Me.nudPop20_12_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(184, Byte), CType(0, Byte))
		Me.nudPop20_12_2.DSSElementName = "Pop20_12_2"
		Me.nudPop20_12_2.DSSLocation = 12
		Me.nudPop20_12_2.DSSOffset = 0.2R
		Me.nudPop20_12_2.Location = New System.Drawing.Point(0, 281)
		Me.nudPop20_12_2.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_12_2.Name = "nudPop20_12_2"
		Me.nudPop20_12_2.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_12_2.TabIndex = 111
		Me.nudPop20_12_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_12_2.ThousandsSeparator = True
		Me.nudPop20_12_2.Value = New Decimal(New Integer() {3, 0, 0, 65536})
		'
		'nudPop20_10_2
		'
		Me.nudPop20_10_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(184, Byte), CType(0, Byte))
		Me.nudPop20_10_2.DSSElementName = "Pop20_10_2"
		Me.nudPop20_10_2.DSSLocation = 10
		Me.nudPop20_10_2.DSSOffset = 0.2R
		Me.nudPop20_10_2.Location = New System.Drawing.Point(0, 235)
		Me.nudPop20_10_2.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_10_2.Name = "nudPop20_10_2"
		Me.nudPop20_10_2.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_10_2.TabIndex = 109
		Me.nudPop20_10_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_10_2.ThousandsSeparator = True
		Me.nudPop20_10_2.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'nudPop20_13_2
		'
		Me.nudPop20_13_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(184, Byte), CType(0, Byte))
		Me.nudPop20_13_2.DSSElementName = "Pop20_13_2"
		Me.nudPop20_13_2.DSSLocation = 13
		Me.nudPop20_13_2.DSSOffset = 0.2R
		Me.nudPop20_13_2.Location = New System.Drawing.Point(0, 304)
		Me.nudPop20_13_2.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_13_2.Name = "nudPop20_13_2"
		Me.nudPop20_13_2.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_13_2.TabIndex = 112
		Me.nudPop20_13_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_13_2.ThousandsSeparator = True
		Me.nudPop20_13_2.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'nudPop20_6_2
		'
		Me.nudPop20_6_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(184, Byte), CType(0, Byte))
		Me.nudPop20_6_2.DSSElementName = "Pop20_6_2"
		Me.nudPop20_6_2.DSSLocation = 6
		Me.nudPop20_6_2.DSSOffset = 0.2R
		Me.nudPop20_6_2.Location = New System.Drawing.Point(0, 143)
		Me.nudPop20_6_2.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_6_2.Name = "nudPop20_6_2"
		Me.nudPop20_6_2.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_6_2.TabIndex = 105
		Me.nudPop20_6_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_6_2.ThousandsSeparator = True
		Me.nudPop20_6_2.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudPop20_8_2
		'
		Me.nudPop20_8_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(184, Byte), CType(0, Byte))
		Me.nudPop20_8_2.DSSElementName = "Pop20_8_2"
		Me.nudPop20_8_2.DSSLocation = 8
		Me.nudPop20_8_2.DSSOffset = 0.2R
		Me.nudPop20_8_2.Location = New System.Drawing.Point(0, 189)
		Me.nudPop20_8_2.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_8_2.Name = "nudPop20_8_2"
		Me.nudPop20_8_2.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_8_2.TabIndex = 107
		Me.nudPop20_8_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_8_2.ThousandsSeparator = True
		Me.nudPop20_8_2.Value = New Decimal(New Integer() {6, 0, 0, 65536})
		'
		'nudPop20_1_2
		'
		Me.nudPop20_1_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(184, Byte), CType(0, Byte))
		Me.nudPop20_1_2.DSSElementName = "Pop20_1_2"
		Me.nudPop20_1_2.DSSLocation = 1
		Me.nudPop20_1_2.DSSOffset = 0.2R
		Me.nudPop20_1_2.Location = New System.Drawing.Point(0, 28)
		Me.nudPop20_1_2.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_1_2.Name = "nudPop20_1_2"
		Me.nudPop20_1_2.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_1_2.TabIndex = 100
		Me.nudPop20_1_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_1_2.ThousandsSeparator = True
		Me.nudPop20_1_2.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudPop20_4_2
		'
		Me.nudPop20_4_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(184, Byte), CType(0, Byte))
		Me.nudPop20_4_2.DSSElementName = "Pop20_4_2"
		Me.nudPop20_4_2.DSSLocation = 4
		Me.nudPop20_4_2.DSSOffset = 0.2R
		Me.nudPop20_4_2.Location = New System.Drawing.Point(0, 97)
		Me.nudPop20_4_2.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_4_2.Name = "nudPop20_4_2"
		Me.nudPop20_4_2.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_4_2.TabIndex = 103
		Me.nudPop20_4_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_4_2.ThousandsSeparator = True
		Me.nudPop20_4_2.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudPop20_9_2
		'
		Me.nudPop20_9_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(184, Byte), CType(0, Byte))
		Me.nudPop20_9_2.DSSElementName = "Pop20_9_2"
		Me.nudPop20_9_2.DSSLocation = 9
		Me.nudPop20_9_2.DSSOffset = 0.2R
		Me.nudPop20_9_2.Location = New System.Drawing.Point(0, 212)
		Me.nudPop20_9_2.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_9_2.Name = "nudPop20_9_2"
		Me.nudPop20_9_2.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_9_2.TabIndex = 108
		Me.nudPop20_9_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_9_2.ThousandsSeparator = True
		Me.nudPop20_9_2.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'nudPop20_11_2
		'
		Me.nudPop20_11_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(184, Byte), CType(0, Byte))
		Me.nudPop20_11_2.DSSElementName = "Pop20_11_2"
		Me.nudPop20_11_2.DSSLocation = 11
		Me.nudPop20_11_2.DSSOffset = 0.2R
		Me.nudPop20_11_2.Location = New System.Drawing.Point(0, 258)
		Me.nudPop20_11_2.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_11_2.Name = "nudPop20_11_2"
		Me.nudPop20_11_2.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_11_2.TabIndex = 110
		Me.nudPop20_11_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_11_2.ThousandsSeparator = True
		Me.nudPop20_11_2.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudPop20_5_2
		'
		Me.nudPop20_5_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(184, Byte), CType(0, Byte))
		Me.nudPop20_5_2.DSSElementName = "Pop20_5_2"
		Me.nudPop20_5_2.DSSLocation = 5
		Me.nudPop20_5_2.DSSOffset = 0.2R
		Me.nudPop20_5_2.Location = New System.Drawing.Point(0, 120)
		Me.nudPop20_5_2.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_5_2.Name = "nudPop20_5_2"
		Me.nudPop20_5_2.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_5_2.TabIndex = 104
		Me.nudPop20_5_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_5_2.ThousandsSeparator = True
		Me.nudPop20_5_2.Value = New Decimal(New Integer() {8, 0, 0, 65536})
		'
		'lblTPLocation14
		'
		Me.lblTPLocation14.AutoSize = True
		Me.lblTPLocation14.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblTPLocation14.DSSElementName = "locName"
		Me.lblTPLocation14.DSSLocation = 14
		Me.lblTPLocation14.DSSOffset = 0R
		Me.lblTPLocation14.Location = New System.Drawing.Point(12, 365)
		Me.lblTPLocation14.Name = "lblTPLocation14"
		Me.lblTPLocation14.Size = New System.Drawing.Size(56, 13)
		Me.lblTPLocation14.TabIndex = 144
		Me.lblTPLocation14.Text = "location14"
		'
		'pnlPop20_1
		'
		Me.pnlPop20_1.Controls.Add(Me.nudPop20_14_1)
		Me.pnlPop20_1.Controls.Add(Me.nudPop20_15_1)
		Me.pnlPop20_1.Controls.Add(Me.lblTot20_1)
		Me.pnlPop20_1.Controls.Add(Me.nudPop20_3_1)
		Me.pnlPop20_1.Controls.Add(Me.nudPop20_7_1)
		Me.pnlPop20_1.Controls.Add(Me.nudPop20_2_1)
		Me.pnlPop20_1.Controls.Add(Me.nudPop20_6_1)
		Me.pnlPop20_1.Controls.Add(Me.nudPop20_12_1)
		Me.pnlPop20_1.Controls.Add(Me.nudPop20_1_1)
		Me.pnlPop20_1.Controls.Add(Me.nudPop20_9_1)
		Me.pnlPop20_1.Controls.Add(Me.nudPop20_13_1)
		Me.pnlPop20_1.Controls.Add(Me.nudPop20_10_1)
		Me.pnlPop20_1.Controls.Add(Me.nudPop20_11_1)
		Me.pnlPop20_1.Controls.Add(Me.nudPop20_8_1)
		Me.pnlPop20_1.Controls.Add(Me.nudPop20_5_1)
		Me.pnlPop20_1.Controls.Add(Me.nudPop20_4_1)
		Me.pnlPop20_1.Location = New System.Drawing.Point(96, 35)
		Me.pnlPop20_1.Name = "pnlPop20_1"
		Me.pnlPop20_1.Size = New System.Drawing.Size(90, 388)
		Me.pnlPop20_1.TabIndex = 113
		'
		'nudPop20_14_1
		'
		Me.nudPop20_14_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(114, Byte), CType(0, Byte))
		Me.nudPop20_14_1.DSSElementName = "Pop20_14_1"
		Me.nudPop20_14_1.DSSLocation = 14
		Me.nudPop20_14_1.DSSOffset = -0.2R
		Me.nudPop20_14_1.Location = New System.Drawing.Point(0, 327)
		Me.nudPop20_14_1.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_14_1.Name = "nudPop20_14_1"
		Me.nudPop20_14_1.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_14_1.TabIndex = 13
		Me.nudPop20_14_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_14_1.ThousandsSeparator = True
		Me.nudPop20_14_1.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudPop20_15_1
		'
		Me.nudPop20_15_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(114, Byte), CType(0, Byte))
		Me.nudPop20_15_1.DSSElementName = "Pop20_15_1"
		Me.nudPop20_15_1.DSSLocation = 15
		Me.nudPop20_15_1.DSSOffset = -0.2R
		Me.nudPop20_15_1.Location = New System.Drawing.Point(0, 350)
		Me.nudPop20_15_1.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_15_1.Name = "nudPop20_15_1"
		Me.nudPop20_15_1.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_15_1.TabIndex = 14
		Me.nudPop20_15_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_15_1.ThousandsSeparator = True
		Me.nudPop20_15_1.Value = New Decimal(New Integer() {1054794521, 0, 0, 589824})
		'
		'lblTot20_1
		'
		Me.lblTot20_1.Location = New System.Drawing.Point(0, 5)
		Me.lblTot20_1.Name = "lblTot20_1"
		Me.lblTot20_1.Size = New System.Drawing.Size(90, 13)
		Me.lblTot20_1.TabIndex = 95
		Me.lblTot20_1.Text = "Small"
		Me.lblTot20_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'nudPop20_3_1
		'
		Me.nudPop20_3_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(114, Byte), CType(0, Byte))
		Me.nudPop20_3_1.DSSElementName = "Pop20_3_1"
		Me.nudPop20_3_1.DSSLocation = 3
		Me.nudPop20_3_1.DSSOffset = -0.2R
		Me.nudPop20_3_1.Location = New System.Drawing.Point(0, 74)
		Me.nudPop20_3_1.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_3_1.Name = "nudPop20_3_1"
		Me.nudPop20_3_1.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_3_1.TabIndex = 2
		Me.nudPop20_3_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_3_1.ThousandsSeparator = True
		Me.nudPop20_3_1.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'nudPop20_7_1
		'
		Me.nudPop20_7_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(114, Byte), CType(0, Byte))
		Me.nudPop20_7_1.DSSElementName = "Pop20_7_1"
		Me.nudPop20_7_1.DSSLocation = 7
		Me.nudPop20_7_1.DSSOffset = -0.2R
		Me.nudPop20_7_1.Location = New System.Drawing.Point(0, 166)
		Me.nudPop20_7_1.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_7_1.Name = "nudPop20_7_1"
		Me.nudPop20_7_1.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_7_1.TabIndex = 6
		Me.nudPop20_7_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_7_1.ThousandsSeparator = True
		Me.nudPop20_7_1.Value = New Decimal(New Integer() {10, 0, 0, 0})
		'
		'nudPop20_2_1
		'
		Me.nudPop20_2_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(114, Byte), CType(0, Byte))
		Me.nudPop20_2_1.DSSElementName = "Pop20_2_1"
		Me.nudPop20_2_1.DSSLocation = 2
		Me.nudPop20_2_1.DSSOffset = -0.2R
		Me.nudPop20_2_1.Location = New System.Drawing.Point(0, 51)
		Me.nudPop20_2_1.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_2_1.Name = "nudPop20_2_1"
		Me.nudPop20_2_1.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_2_1.TabIndex = 1
		Me.nudPop20_2_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_2_1.ThousandsSeparator = True
		Me.nudPop20_2_1.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'nudPop20_6_1
		'
		Me.nudPop20_6_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(114, Byte), CType(0, Byte))
		Me.nudPop20_6_1.DSSElementName = "Pop20_6_1"
		Me.nudPop20_6_1.DSSLocation = 6
		Me.nudPop20_6_1.DSSOffset = -0.2R
		Me.nudPop20_6_1.Location = New System.Drawing.Point(0, 143)
		Me.nudPop20_6_1.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_6_1.Name = "nudPop20_6_1"
		Me.nudPop20_6_1.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_6_1.TabIndex = 5
		Me.nudPop20_6_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_6_1.ThousandsSeparator = True
		Me.nudPop20_6_1.Value = New Decimal(New Integer() {6, 0, 0, 0})
		'
		'nudPop20_12_1
		'
		Me.nudPop20_12_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(114, Byte), CType(0, Byte))
		Me.nudPop20_12_1.DSSElementName = "Pop20_12_1"
		Me.nudPop20_12_1.DSSLocation = 12
		Me.nudPop20_12_1.DSSOffset = -0.2R
		Me.nudPop20_12_1.Location = New System.Drawing.Point(0, 281)
		Me.nudPop20_12_1.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_12_1.Name = "nudPop20_12_1"
		Me.nudPop20_12_1.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_12_1.TabIndex = 11
		Me.nudPop20_12_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_12_1.ThousandsSeparator = True
		Me.nudPop20_12_1.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudPop20_1_1
		'
		Me.nudPop20_1_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(114, Byte), CType(0, Byte))
		Me.nudPop20_1_1.DSSElementName = "Pop20_1_1"
		Me.nudPop20_1_1.DSSLocation = 1
		Me.nudPop20_1_1.DSSOffset = -0.2R
		Me.nudPop20_1_1.Location = New System.Drawing.Point(0, 28)
		Me.nudPop20_1_1.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_1_1.Name = "nudPop20_1_1"
		Me.nudPop20_1_1.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_1_1.TabIndex = 0
		Me.nudPop20_1_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_1_1.ThousandsSeparator = True
		Me.nudPop20_1_1.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'nudPop20_9_1
		'
		Me.nudPop20_9_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(114, Byte), CType(0, Byte))
		Me.nudPop20_9_1.DSSElementName = "Pop20_9_1"
		Me.nudPop20_9_1.DSSLocation = 9
		Me.nudPop20_9_1.DSSOffset = -0.2R
		Me.nudPop20_9_1.Location = New System.Drawing.Point(0, 212)
		Me.nudPop20_9_1.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_9_1.Name = "nudPop20_9_1"
		Me.nudPop20_9_1.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_9_1.TabIndex = 8
		Me.nudPop20_9_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_9_1.ThousandsSeparator = True
		Me.nudPop20_9_1.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudPop20_13_1
		'
		Me.nudPop20_13_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(114, Byte), CType(0, Byte))
		Me.nudPop20_13_1.DSSElementName = "Pop20_13_1"
		Me.nudPop20_13_1.DSSLocation = 13
		Me.nudPop20_13_1.DSSOffset = -0.2R
		Me.nudPop20_13_1.Location = New System.Drawing.Point(0, 304)
		Me.nudPop20_13_1.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_13_1.Name = "nudPop20_13_1"
		Me.nudPop20_13_1.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_13_1.TabIndex = 12
		Me.nudPop20_13_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_13_1.ThousandsSeparator = True
		Me.nudPop20_13_1.Value = New Decimal(New Integer() {1054794521, 0, 0, 589824})
		'
		'nudPop20_10_1
		'
		Me.nudPop20_10_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(114, Byte), CType(0, Byte))
		Me.nudPop20_10_1.DSSElementName = "Pop20_10_1"
		Me.nudPop20_10_1.DSSLocation = 10
		Me.nudPop20_10_1.DSSOffset = -0.2R
		Me.nudPop20_10_1.Location = New System.Drawing.Point(0, 235)
		Me.nudPop20_10_1.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_10_1.Name = "nudPop20_10_1"
		Me.nudPop20_10_1.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_10_1.TabIndex = 9
		Me.nudPop20_10_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_10_1.ThousandsSeparator = True
		Me.nudPop20_10_1.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudPop20_11_1
		'
		Me.nudPop20_11_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(114, Byte), CType(0, Byte))
		Me.nudPop20_11_1.DSSElementName = "Pop20_11_1"
		Me.nudPop20_11_1.DSSLocation = 11
		Me.nudPop20_11_1.DSSOffset = -0.2R
		Me.nudPop20_11_1.Location = New System.Drawing.Point(0, 258)
		Me.nudPop20_11_1.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_11_1.Name = "nudPop20_11_1"
		Me.nudPop20_11_1.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_11_1.TabIndex = 10
		Me.nudPop20_11_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_11_1.ThousandsSeparator = True
		Me.nudPop20_11_1.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudPop20_8_1
		'
		Me.nudPop20_8_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(114, Byte), CType(0, Byte))
		Me.nudPop20_8_1.DSSElementName = "Pop20_8_1"
		Me.nudPop20_8_1.DSSLocation = 8
		Me.nudPop20_8_1.DSSOffset = -0.2R
		Me.nudPop20_8_1.Location = New System.Drawing.Point(0, 189)
		Me.nudPop20_8_1.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_8_1.Name = "nudPop20_8_1"
		Me.nudPop20_8_1.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_8_1.TabIndex = 7
		Me.nudPop20_8_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_8_1.ThousandsSeparator = True
		Me.nudPop20_8_1.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'nudPop20_5_1
		'
		Me.nudPop20_5_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(114, Byte), CType(0, Byte))
		Me.nudPop20_5_1.DSSElementName = "Pop20_5_1"
		Me.nudPop20_5_1.DSSLocation = 5
		Me.nudPop20_5_1.DSSOffset = -0.2R
		Me.nudPop20_5_1.Location = New System.Drawing.Point(0, 120)
		Me.nudPop20_5_1.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_5_1.Name = "nudPop20_5_1"
		Me.nudPop20_5_1.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_5_1.TabIndex = 4
		Me.nudPop20_5_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_5_1.ThousandsSeparator = True
		Me.nudPop20_5_1.Value = New Decimal(New Integer() {12, 0, 0, 0})
		'
		'nudPop20_4_1
		'
		Me.nudPop20_4_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(114, Byte), CType(0, Byte))
		Me.nudPop20_4_1.DSSElementName = "Pop20_4_1"
		Me.nudPop20_4_1.DSSLocation = 4
		Me.nudPop20_4_1.DSSOffset = -0.2R
		Me.nudPop20_4_1.Location = New System.Drawing.Point(0, 97)
		Me.nudPop20_4_1.Maximum = New Decimal(New Integer() {3000000, 0, 0, 0})
		Me.nudPop20_4_1.Name = "nudPop20_4_1"
		Me.nudPop20_4_1.Size = New System.Drawing.Size(90, 20)
		Me.nudPop20_4_1.TabIndex = 3
		Me.nudPop20_4_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudPop20_4_1.ThousandsSeparator = True
		Me.nudPop20_4_1.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'lblTPLocation12
		'
		Me.lblTPLocation12.AutoSize = True
		Me.lblTPLocation12.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblTPLocation12.DSSElementName = "locName"
		Me.lblTPLocation12.DSSLocation = 12
		Me.lblTPLocation12.DSSOffset = 0R
		Me.lblTPLocation12.Location = New System.Drawing.Point(12, 319)
		Me.lblTPLocation12.Name = "lblTPLocation12"
		Me.lblTPLocation12.Size = New System.Drawing.Size(56, 13)
		Me.lblTPLocation12.TabIndex = 143
		Me.lblTPLocation12.Text = "location12"
		'
		'Label69
		'
		Me.Label69.Location = New System.Drawing.Point(148, 23)
		Me.Label69.Name = "Label69"
		Me.Label69.Size = New System.Drawing.Size(90, 13)
		Me.Label69.TabIndex = 95
		Me.Label69.Text = "2020"
		Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblTPLocation11
		'
		Me.lblTPLocation11.AutoSize = True
		Me.lblTPLocation11.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblTPLocation11.DSSElementName = "locName"
		Me.lblTPLocation11.DSSLocation = 11
		Me.lblTPLocation11.DSSOffset = 0R
		Me.lblTPLocation11.Location = New System.Drawing.Point(12, 296)
		Me.lblTPLocation11.Name = "lblTPLocation11"
		Me.lblTPLocation11.Size = New System.Drawing.Size(56, 13)
		Me.lblTPLocation11.TabIndex = 142
		Me.lblTPLocation11.Text = "location11"
		'
		'lblTPLocation1
		'
		Me.lblTPLocation1.AutoSize = True
		Me.lblTPLocation1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblTPLocation1.DSSElementName = "locName"
		Me.lblTPLocation1.DSSLocation = 1
		Me.lblTPLocation1.DSSOffset = 0R
		Me.lblTPLocation1.Location = New System.Drawing.Point(12, 66)
		Me.lblTPLocation1.Name = "lblTPLocation1"
		Me.lblTPLocation1.Size = New System.Drawing.Size(50, 13)
		Me.lblTPLocation1.TabIndex = 132
		Me.lblTPLocation1.Text = "location1"
		'
		'lblTPLocation10
		'
		Me.lblTPLocation10.AutoSize = True
		Me.lblTPLocation10.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblTPLocation10.DSSElementName = "locName"
		Me.lblTPLocation10.DSSLocation = 10
		Me.lblTPLocation10.DSSOffset = 0R
		Me.lblTPLocation10.Location = New System.Drawing.Point(12, 273)
		Me.lblTPLocation10.Name = "lblTPLocation10"
		Me.lblTPLocation10.Size = New System.Drawing.Size(56, 13)
		Me.lblTPLocation10.TabIndex = 141
		Me.lblTPLocation10.Text = "location10"
		'
		'lblTPLocation13
		'
		Me.lblTPLocation13.AutoSize = True
		Me.lblTPLocation13.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblTPLocation13.DSSElementName = "locNAme"
		Me.lblTPLocation13.DSSLocation = 13
		Me.lblTPLocation13.DSSOffset = 0R
		Me.lblTPLocation13.Location = New System.Drawing.Point(12, 342)
		Me.lblTPLocation13.Name = "lblTPLocation13"
		Me.lblTPLocation13.Size = New System.Drawing.Size(56, 13)
		Me.lblTPLocation13.TabIndex = 131
		Me.lblTPLocation13.Text = "location13"
		'
		'lblTPLocation9
		'
		Me.lblTPLocation9.AutoSize = True
		Me.lblTPLocation9.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblTPLocation9.DSSElementName = "locName"
		Me.lblTPLocation9.DSSLocation = 9
		Me.lblTPLocation9.DSSOffset = 0R
		Me.lblTPLocation9.Location = New System.Drawing.Point(12, 250)
		Me.lblTPLocation9.Name = "lblTPLocation9"
		Me.lblTPLocation9.Size = New System.Drawing.Size(50, 13)
		Me.lblTPLocation9.TabIndex = 140
		Me.lblTPLocation9.Text = "location9"
		'
		'lblTPLocation2
		'
		Me.lblTPLocation2.AutoSize = True
		Me.lblTPLocation2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblTPLocation2.DSSElementName = "locName"
		Me.lblTPLocation2.DSSLocation = 2
		Me.lblTPLocation2.DSSOffset = 0R
		Me.lblTPLocation2.Location = New System.Drawing.Point(12, 89)
		Me.lblTPLocation2.Name = "lblTPLocation2"
		Me.lblTPLocation2.Size = New System.Drawing.Size(50, 13)
		Me.lblTPLocation2.TabIndex = 133
		Me.lblTPLocation2.Text = "location2"
		'
		'lblTPLocation8
		'
		Me.lblTPLocation8.AutoSize = True
		Me.lblTPLocation8.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblTPLocation8.DSSElementName = "locName"
		Me.lblTPLocation8.DSSLocation = 8
		Me.lblTPLocation8.DSSOffset = 0R
		Me.lblTPLocation8.Location = New System.Drawing.Point(12, 227)
		Me.lblTPLocation8.Name = "lblTPLocation8"
		Me.lblTPLocation8.Size = New System.Drawing.Size(50, 13)
		Me.lblTPLocation8.TabIndex = 139
		Me.lblTPLocation8.Text = "location8"
		'
		'lblTPLocation3
		'
		Me.lblTPLocation3.AutoSize = True
		Me.lblTPLocation3.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblTPLocation3.DSSElementName = "locName"
		Me.lblTPLocation3.DSSLocation = 3
		Me.lblTPLocation3.DSSOffset = 0R
		Me.lblTPLocation3.Location = New System.Drawing.Point(12, 112)
		Me.lblTPLocation3.Name = "lblTPLocation3"
		Me.lblTPLocation3.Size = New System.Drawing.Size(50, 13)
		Me.lblTPLocation3.TabIndex = 134
		Me.lblTPLocation3.Text = "location3"
		'
		'lblTPLocation7
		'
		Me.lblTPLocation7.AutoSize = True
		Me.lblTPLocation7.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblTPLocation7.DSSElementName = "locName"
		Me.lblTPLocation7.DSSLocation = 7
		Me.lblTPLocation7.DSSOffset = 0R
		Me.lblTPLocation7.Location = New System.Drawing.Point(12, 204)
		Me.lblTPLocation7.Name = "lblTPLocation7"
		Me.lblTPLocation7.Size = New System.Drawing.Size(50, 13)
		Me.lblTPLocation7.TabIndex = 138
		Me.lblTPLocation7.Text = "location7"
		'
		'lblTPLocation4
		'
		Me.lblTPLocation4.AutoSize = True
		Me.lblTPLocation4.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblTPLocation4.DSSElementName = "locName"
		Me.lblTPLocation4.DSSLocation = 4
		Me.lblTPLocation4.DSSOffset = 0R
		Me.lblTPLocation4.Location = New System.Drawing.Point(12, 135)
		Me.lblTPLocation4.Name = "lblTPLocation4"
		Me.lblTPLocation4.Size = New System.Drawing.Size(50, 13)
		Me.lblTPLocation4.TabIndex = 135
		Me.lblTPLocation4.Text = "location4"
		'
		'lblTPLocation6
		'
		Me.lblTPLocation6.AutoSize = True
		Me.lblTPLocation6.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblTPLocation6.DSSElementName = "locName"
		Me.lblTPLocation6.DSSLocation = 6
		Me.lblTPLocation6.DSSOffset = 0R
		Me.lblTPLocation6.Location = New System.Drawing.Point(12, 181)
		Me.lblTPLocation6.Name = "lblTPLocation6"
		Me.lblTPLocation6.Size = New System.Drawing.Size(50, 13)
		Me.lblTPLocation6.TabIndex = 137
		Me.lblTPLocation6.Text = "location6"
		'
		'lblTPLocation5
		'
		Me.lblTPLocation5.AutoSize = True
		Me.lblTPLocation5.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblTPLocation5.DSSElementName = "locName"
		Me.lblTPLocation5.DSSLocation = 5
		Me.lblTPLocation5.DSSOffset = 0R
		Me.lblTPLocation5.Location = New System.Drawing.Point(12, 158)
		Me.lblTPLocation5.Name = "lblTPLocation5"
		Me.lblTPLocation5.Size = New System.Drawing.Size(50, 13)
		Me.lblTPLocation5.TabIndex = 136
		Me.lblTPLocation5.Text = "location5"
		'
		'grbIndustrialDistricts
		'
		Me.grbIndustrialDistricts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.grbIndustrialDistricts.Controls.Add(Me.lblIDLocation15)
		Me.grbIndustrialDistricts.Controls.Add(Me.pnlInddispln)
		Me.grbIndustrialDistricts.Controls.Add(Me.lblIDLocation14)
		Me.grbIndustrialDistricts.Controls.Add(Me.pnlInddiscur)
		Me.grbIndustrialDistricts.Controls.Add(Me.lblIDLocation12)
		Me.grbIndustrialDistricts.Controls.Add(Me.lblIDLocation1)
		Me.grbIndustrialDistricts.Controls.Add(Me.lblIDLocation11)
		Me.grbIndustrialDistricts.Controls.Add(Me.lblIDLocation5)
		Me.grbIndustrialDistricts.Controls.Add(Me.lblIDLocation6)
		Me.grbIndustrialDistricts.Controls.Add(Me.lblIDLocation10)
		Me.grbIndustrialDistricts.Controls.Add(Me.lblIDLocation4)
		Me.grbIndustrialDistricts.Controls.Add(Me.lblIDLocation13)
		Me.grbIndustrialDistricts.Controls.Add(Me.lblIDLocation7)
		Me.grbIndustrialDistricts.Controls.Add(Me.lblIDLocation9)
		Me.grbIndustrialDistricts.Controls.Add(Me.lblIDLocation3)
		Me.grbIndustrialDistricts.Controls.Add(Me.lblIDLocation2)
		Me.grbIndustrialDistricts.Controls.Add(Me.lblIDLocation8)
		Me.grbIndustrialDistricts.ForeColor = System.Drawing.Color.Black
		Me.grbIndustrialDistricts.Location = New System.Drawing.Point(0, 0)
		Me.grbIndustrialDistricts.Name = "grbIndustrialDistricts"
		Me.grbIndustrialDistricts.Size = New System.Drawing.Size(300, 516)
		Me.grbIndustrialDistricts.TabIndex = 23
		Me.grbIndustrialDistricts.TabStop = False
		Me.grbIndustrialDistricts.Text = "Industrial districts"
		Me.grbIndustrialDistricts.Visible = False
		'
		'lblIDLocation15
		'
		Me.lblIDLocation15.AutoSize = True
		Me.lblIDLocation15.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIDLocation15.DSSElementName = "locName"
		Me.lblIDLocation15.DSSLocation = 15
		Me.lblIDLocation15.DSSOffset = 0R
		Me.lblIDLocation15.Location = New System.Drawing.Point(12, 372)
		Me.lblIDLocation15.Name = "lblIDLocation15"
		Me.lblIDLocation15.Size = New System.Drawing.Size(56, 13)
		Me.lblIDLocation15.TabIndex = 160
		Me.lblIDLocation15.Text = "location15"
		'
		'pnlInddispln
		'
		Me.pnlInddispln.Controls.Add(Me.nudInddispln14_2)
		Me.pnlInddispln.Controls.Add(Me.nudInddispln15_2)
		Me.pnlInddispln.Controls.Add(Me.Label86)
		Me.pnlInddispln.Controls.Add(Me.nudInddispln3_2)
		Me.pnlInddispln.Controls.Add(Me.nudInddispln7_2)
		Me.pnlInddispln.Controls.Add(Me.nudInddispln2_2)
		Me.pnlInddispln.Controls.Add(Me.nudInddispln12_2)
		Me.pnlInddispln.Controls.Add(Me.nudInddispln10_2)
		Me.pnlInddispln.Controls.Add(Me.nudInddispln13_2)
		Me.pnlInddispln.Controls.Add(Me.nudInddispln6_2)
		Me.pnlInddispln.Controls.Add(Me.nudInddispln8_2)
		Me.pnlInddispln.Controls.Add(Me.nudInddispln1_2)
		Me.pnlInddispln.Controls.Add(Me.nudInddispln4_2)
		Me.pnlInddispln.Controls.Add(Me.nudInddispln9_2)
		Me.pnlInddispln.Controls.Add(Me.nudInddispln11_2)
		Me.pnlInddispln.Controls.Add(Me.nudInddispln5_2)
		Me.pnlInddispln.Location = New System.Drawing.Point(198, 12)
		Me.pnlInddispln.Name = "pnlInddispln"
		Me.pnlInddispln.Size = New System.Drawing.Size(90, 393)
		Me.pnlInddispln.TabIndex = 147
		'
		'nudInddispln14_2
		'
		Me.nudInddispln14_2.DecimalPlaces = 2
		Me.nudInddispln14_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(93, Byte), CType(93, Byte), CType(93, Byte))
		Me.nudInddispln14_2.DSSElementName = "inddispln14_1"
		Me.nudInddispln14_2.DSSLocation = 14
		Me.nudInddispln14_2.DSSOffset = 0.2R
		Me.nudInddispln14_2.Location = New System.Drawing.Point(0, 332)
		Me.nudInddispln14_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddispln14_2.Name = "nudInddispln14_2"
		Me.nudInddispln14_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddispln14_2.TabIndex = 113
		Me.nudInddispln14_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddispln14_2.Value = New Decimal(New Integer() {3, 0, 0, 65536})
		'
		'nudInddispln15_2
		'
		Me.nudInddispln15_2.DecimalPlaces = 2
		Me.nudInddispln15_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(93, Byte), CType(93, Byte), CType(93, Byte))
		Me.nudInddispln15_2.DSSElementName = "inddispln15_1"
		Me.nudInddispln15_2.DSSLocation = 15
		Me.nudInddispln15_2.DSSOffset = 0.2R
		Me.nudInddispln15_2.Location = New System.Drawing.Point(0, 355)
		Me.nudInddispln15_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddispln15_2.Name = "nudInddispln15_2"
		Me.nudInddispln15_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddispln15_2.TabIndex = 114
		Me.nudInddispln15_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddispln15_2.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'Label86
		'
		Me.Label86.Location = New System.Drawing.Point(0, 10)
		Me.Label86.Name = "Label86"
		Me.Label86.Size = New System.Drawing.Size(90, 13)
		Me.Label86.TabIndex = 144
		Me.Label86.Text = "Planned"
		Me.Label86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'nudInddispln3_2
		'
		Me.nudInddispln3_2.DecimalPlaces = 2
		Me.nudInddispln3_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(93, Byte), CType(93, Byte), CType(93, Byte))
		Me.nudInddispln3_2.DSSElementName = "inddispln3_1"
		Me.nudInddispln3_2.DSSLocation = 3
		Me.nudInddispln3_2.DSSOffset = 0.2R
		Me.nudInddispln3_2.Location = New System.Drawing.Point(0, 79)
		Me.nudInddispln3_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddispln3_2.Name = "nudInddispln3_2"
		Me.nudInddispln3_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddispln3_2.TabIndex = 102
		Me.nudInddispln3_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddispln3_2.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudInddispln7_2
		'
		Me.nudInddispln7_2.DecimalPlaces = 2
		Me.nudInddispln7_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(93, Byte), CType(93, Byte), CType(93, Byte))
		Me.nudInddispln7_2.DSSElementName = "inddispln7_1"
		Me.nudInddispln7_2.DSSLocation = 7
		Me.nudInddispln7_2.DSSOffset = 0.2R
		Me.nudInddispln7_2.Location = New System.Drawing.Point(0, 171)
		Me.nudInddispln7_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddispln7_2.Name = "nudInddispln7_2"
		Me.nudInddispln7_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddispln7_2.TabIndex = 106
		Me.nudInddispln7_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddispln7_2.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudInddispln2_2
		'
		Me.nudInddispln2_2.DecimalPlaces = 2
		Me.nudInddispln2_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(93, Byte), CType(93, Byte), CType(93, Byte))
		Me.nudInddispln2_2.DSSElementName = "inddispln2_1"
		Me.nudInddispln2_2.DSSLocation = 2
		Me.nudInddispln2_2.DSSOffset = 0.2R
		Me.nudInddispln2_2.Location = New System.Drawing.Point(0, 56)
		Me.nudInddispln2_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddispln2_2.Name = "nudInddispln2_2"
		Me.nudInddispln2_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddispln2_2.TabIndex = 101
		Me.nudInddispln2_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddispln2_2.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudInddispln12_2
		'
		Me.nudInddispln12_2.DecimalPlaces = 2
		Me.nudInddispln12_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(93, Byte), CType(93, Byte), CType(93, Byte))
		Me.nudInddispln12_2.DSSElementName = "inddispln12_1"
		Me.nudInddispln12_2.DSSLocation = 12
		Me.nudInddispln12_2.DSSOffset = 0.2R
		Me.nudInddispln12_2.Location = New System.Drawing.Point(0, 286)
		Me.nudInddispln12_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddispln12_2.Name = "nudInddispln12_2"
		Me.nudInddispln12_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddispln12_2.TabIndex = 111
		Me.nudInddispln12_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddispln12_2.Value = New Decimal(New Integer() {3, 0, 0, 65536})
		'
		'nudInddispln10_2
		'
		Me.nudInddispln10_2.DecimalPlaces = 2
		Me.nudInddispln10_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(93, Byte), CType(93, Byte), CType(93, Byte))
		Me.nudInddispln10_2.DSSElementName = "inddispln10_1"
		Me.nudInddispln10_2.DSSLocation = 10
		Me.nudInddispln10_2.DSSOffset = 0.2R
		Me.nudInddispln10_2.Location = New System.Drawing.Point(0, 240)
		Me.nudInddispln10_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddispln10_2.Name = "nudInddispln10_2"
		Me.nudInddispln10_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddispln10_2.TabIndex = 109
		Me.nudInddispln10_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddispln10_2.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'nudInddispln13_2
		'
		Me.nudInddispln13_2.DecimalPlaces = 2
		Me.nudInddispln13_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(93, Byte), CType(93, Byte), CType(93, Byte))
		Me.nudInddispln13_2.DSSElementName = "inddispln13_1"
		Me.nudInddispln13_2.DSSLocation = 13
		Me.nudInddispln13_2.DSSOffset = 0.2R
		Me.nudInddispln13_2.Location = New System.Drawing.Point(0, 309)
		Me.nudInddispln13_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddispln13_2.Name = "nudInddispln13_2"
		Me.nudInddispln13_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddispln13_2.TabIndex = 112
		Me.nudInddispln13_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddispln13_2.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'nudInddispln6_2
		'
		Me.nudInddispln6_2.DecimalPlaces = 2
		Me.nudInddispln6_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(93, Byte), CType(93, Byte), CType(93, Byte))
		Me.nudInddispln6_2.DSSElementName = "inddispln6_1"
		Me.nudInddispln6_2.DSSLocation = 6
		Me.nudInddispln6_2.DSSOffset = 0.2R
		Me.nudInddispln6_2.Location = New System.Drawing.Point(0, 148)
		Me.nudInddispln6_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddispln6_2.Name = "nudInddispln6_2"
		Me.nudInddispln6_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddispln6_2.TabIndex = 105
		Me.nudInddispln6_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddispln6_2.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudInddispln8_2
		'
		Me.nudInddispln8_2.DecimalPlaces = 2
		Me.nudInddispln8_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(93, Byte), CType(93, Byte), CType(93, Byte))
		Me.nudInddispln8_2.DSSElementName = "inddispln8_1"
		Me.nudInddispln8_2.DSSLocation = 8
		Me.nudInddispln8_2.DSSOffset = 0.2R
		Me.nudInddispln8_2.Location = New System.Drawing.Point(0, 194)
		Me.nudInddispln8_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddispln8_2.Name = "nudInddispln8_2"
		Me.nudInddispln8_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddispln8_2.TabIndex = 107
		Me.nudInddispln8_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddispln8_2.Value = New Decimal(New Integer() {6, 0, 0, 65536})
		'
		'nudInddispln1_2
		'
		Me.nudInddispln1_2.DecimalPlaces = 2
		Me.nudInddispln1_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(93, Byte), CType(93, Byte), CType(93, Byte))
		Me.nudInddispln1_2.DSSElementName = "inddispln1_1"
		Me.nudInddispln1_2.DSSLocation = 1
		Me.nudInddispln1_2.DSSOffset = 0.2R
		Me.nudInddispln1_2.Location = New System.Drawing.Point(0, 33)
		Me.nudInddispln1_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddispln1_2.Name = "nudInddispln1_2"
		Me.nudInddispln1_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddispln1_2.TabIndex = 100
		Me.nudInddispln1_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddispln1_2.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudInddispln4_2
		'
		Me.nudInddispln4_2.DecimalPlaces = 2
		Me.nudInddispln4_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(93, Byte), CType(93, Byte), CType(93, Byte))
		Me.nudInddispln4_2.DSSElementName = "inddispln4_1"
		Me.nudInddispln4_2.DSSLocation = 4
		Me.nudInddispln4_2.DSSOffset = 0.2R
		Me.nudInddispln4_2.Location = New System.Drawing.Point(0, 102)
		Me.nudInddispln4_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddispln4_2.Name = "nudInddispln4_2"
		Me.nudInddispln4_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddispln4_2.TabIndex = 103
		Me.nudInddispln4_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddispln4_2.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudInddispln9_2
		'
		Me.nudInddispln9_2.DecimalPlaces = 2
		Me.nudInddispln9_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(93, Byte), CType(93, Byte), CType(93, Byte))
		Me.nudInddispln9_2.DSSElementName = "inddispln9_1"
		Me.nudInddispln9_2.DSSLocation = 9
		Me.nudInddispln9_2.DSSOffset = 0.2R
		Me.nudInddispln9_2.Location = New System.Drawing.Point(0, 217)
		Me.nudInddispln9_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddispln9_2.Name = "nudInddispln9_2"
		Me.nudInddispln9_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddispln9_2.TabIndex = 108
		Me.nudInddispln9_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddispln9_2.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'nudInddispln11_2
		'
		Me.nudInddispln11_2.DecimalPlaces = 2
		Me.nudInddispln11_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(93, Byte), CType(93, Byte), CType(93, Byte))
		Me.nudInddispln11_2.DSSElementName = "inddispln11_1"
		Me.nudInddispln11_2.DSSLocation = 11
		Me.nudInddispln11_2.DSSOffset = 0.2R
		Me.nudInddispln11_2.Location = New System.Drawing.Point(0, 263)
		Me.nudInddispln11_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddispln11_2.Name = "nudInddispln11_2"
		Me.nudInddispln11_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddispln11_2.TabIndex = 110
		Me.nudInddispln11_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddispln11_2.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudInddispln5_2
		'
		Me.nudInddispln5_2.DecimalPlaces = 2
		Me.nudInddispln5_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(93, Byte), CType(93, Byte), CType(93, Byte))
		Me.nudInddispln5_2.DSSElementName = "inddispln5_1"
		Me.nudInddispln5_2.DSSLocation = 5
		Me.nudInddispln5_2.DSSOffset = 0.2R
		Me.nudInddispln5_2.Location = New System.Drawing.Point(0, 125)
		Me.nudInddispln5_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddispln5_2.Name = "nudInddispln5_2"
		Me.nudInddispln5_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddispln5_2.TabIndex = 104
		Me.nudInddispln5_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddispln5_2.Value = New Decimal(New Integer() {8, 0, 0, 65536})
		'
		'lblIDLocation14
		'
		Me.lblIDLocation14.AutoSize = True
		Me.lblIDLocation14.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIDLocation14.DSSElementName = "locName"
		Me.lblIDLocation14.DSSLocation = 14
		Me.lblIDLocation14.DSSOffset = 0R
		Me.lblIDLocation14.Location = New System.Drawing.Point(12, 349)
		Me.lblIDLocation14.Name = "lblIDLocation14"
		Me.lblIDLocation14.Size = New System.Drawing.Size(56, 13)
		Me.lblIDLocation14.TabIndex = 159
		Me.lblIDLocation14.Text = "location14"
		'
		'pnlInddiscur
		'
		Me.pnlInddiscur.Controls.Add(Me.nudInddiscur14_2)
		Me.pnlInddiscur.Controls.Add(Me.nudInddiscur15_2)
		Me.pnlInddiscur.Controls.Add(Me.Label88)
		Me.pnlInddiscur.Controls.Add(Me.nudInddiscur3_2)
		Me.pnlInddiscur.Controls.Add(Me.nudInddiscur7_2)
		Me.pnlInddiscur.Controls.Add(Me.nudInddiscur2_2)
		Me.pnlInddiscur.Controls.Add(Me.nudInddiscur6_2)
		Me.pnlInddiscur.Controls.Add(Me.nudInddiscur12_2)
		Me.pnlInddiscur.Controls.Add(Me.nudInddiscur1_2)
		Me.pnlInddiscur.Controls.Add(Me.nudInddiscur9_2)
		Me.pnlInddiscur.Controls.Add(Me.nudInddiscur13_2)
		Me.pnlInddiscur.Controls.Add(Me.nudInddiscur10_2)
		Me.pnlInddiscur.Controls.Add(Me.nudInddiscur11_2)
		Me.pnlInddiscur.Controls.Add(Me.nudInddiscur8_2)
		Me.pnlInddiscur.Controls.Add(Me.nudInddiscur5_2)
		Me.pnlInddiscur.Controls.Add(Me.nudInddiscur4_2)
		Me.pnlInddiscur.Location = New System.Drawing.Point(99, 12)
		Me.pnlInddiscur.Name = "pnlInddiscur"
		Me.pnlInddiscur.Size = New System.Drawing.Size(90, 393)
		Me.pnlInddiscur.TabIndex = 146
		'
		'nudInddiscur14_2
		'
		Me.nudInddiscur14_2.DecimalPlaces = 2
		Me.nudInddiscur14_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(164, Byte), CType(164, Byte), CType(164, Byte))
		Me.nudInddiscur14_2.DSSElementName = "inddiscur14_1"
		Me.nudInddiscur14_2.DSSLocation = 14
		Me.nudInddiscur14_2.DSSOffset = -0.2R
		Me.nudInddiscur14_2.Location = New System.Drawing.Point(0, 332)
		Me.nudInddiscur14_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddiscur14_2.Name = "nudInddiscur14_2"
		Me.nudInddiscur14_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddiscur14_2.TabIndex = 13
		Me.nudInddiscur14_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddiscur14_2.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudInddiscur15_2
		'
		Me.nudInddiscur15_2.DecimalPlaces = 2
		Me.nudInddiscur15_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(164, Byte), CType(164, Byte), CType(164, Byte))
		Me.nudInddiscur15_2.DSSElementName = "inddiscur15_1"
		Me.nudInddiscur15_2.DSSLocation = 15
		Me.nudInddiscur15_2.DSSOffset = -0.2R
		Me.nudInddiscur15_2.Location = New System.Drawing.Point(0, 355)
		Me.nudInddiscur15_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddiscur15_2.Name = "nudInddiscur15_2"
		Me.nudInddiscur15_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddiscur15_2.TabIndex = 14
		Me.nudInddiscur15_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddiscur15_2.Value = New Decimal(New Integer() {1054794521, 0, 0, 589824})
		'
		'Label88
		'
		Me.Label88.Location = New System.Drawing.Point(0, 10)
		Me.Label88.Name = "Label88"
		Me.Label88.Size = New System.Drawing.Size(90, 13)
		Me.Label88.TabIndex = 145
		Me.Label88.Text = "Current"
		Me.Label88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'nudInddiscur3_2
		'
		Me.nudInddiscur3_2.DecimalPlaces = 2
		Me.nudInddiscur3_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(164, Byte), CType(164, Byte), CType(164, Byte))
		Me.nudInddiscur3_2.DSSElementName = "inddiscur3_1"
		Me.nudInddiscur3_2.DSSLocation = 3
		Me.nudInddiscur3_2.DSSOffset = -0.2R
		Me.nudInddiscur3_2.Location = New System.Drawing.Point(0, 79)
		Me.nudInddiscur3_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddiscur3_2.Name = "nudInddiscur3_2"
		Me.nudInddiscur3_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddiscur3_2.TabIndex = 2
		Me.nudInddiscur3_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddiscur3_2.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'nudInddiscur7_2
		'
		Me.nudInddiscur7_2.DecimalPlaces = 2
		Me.nudInddiscur7_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(164, Byte), CType(164, Byte), CType(164, Byte))
		Me.nudInddiscur7_2.DSSElementName = "inddiscur7_1"
		Me.nudInddiscur7_2.DSSLocation = 7
		Me.nudInddiscur7_2.DSSOffset = -0.2R
		Me.nudInddiscur7_2.Location = New System.Drawing.Point(0, 171)
		Me.nudInddiscur7_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddiscur7_2.Name = "nudInddiscur7_2"
		Me.nudInddiscur7_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddiscur7_2.TabIndex = 6
		Me.nudInddiscur7_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddiscur7_2.Value = New Decimal(New Integer() {10, 0, 0, 0})
		'
		'nudInddiscur2_2
		'
		Me.nudInddiscur2_2.DecimalPlaces = 2
		Me.nudInddiscur2_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(164, Byte), CType(164, Byte), CType(164, Byte))
		Me.nudInddiscur2_2.DSSElementName = "inddiscur2_1"
		Me.nudInddiscur2_2.DSSLocation = 2
		Me.nudInddiscur2_2.DSSOffset = -0.2R
		Me.nudInddiscur2_2.Location = New System.Drawing.Point(0, 56)
		Me.nudInddiscur2_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddiscur2_2.Name = "nudInddiscur2_2"
		Me.nudInddiscur2_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddiscur2_2.TabIndex = 1
		Me.nudInddiscur2_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddiscur2_2.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'nudInddiscur6_2
		'
		Me.nudInddiscur6_2.DecimalPlaces = 2
		Me.nudInddiscur6_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(164, Byte), CType(164, Byte), CType(164, Byte))
		Me.nudInddiscur6_2.DSSElementName = "inddiscur6_1"
		Me.nudInddiscur6_2.DSSLocation = 6
		Me.nudInddiscur6_2.DSSOffset = -0.2R
		Me.nudInddiscur6_2.Location = New System.Drawing.Point(0, 148)
		Me.nudInddiscur6_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddiscur6_2.Name = "nudInddiscur6_2"
		Me.nudInddiscur6_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddiscur6_2.TabIndex = 5
		Me.nudInddiscur6_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddiscur6_2.Value = New Decimal(New Integer() {6, 0, 0, 0})
		'
		'nudInddiscur12_2
		'
		Me.nudInddiscur12_2.DecimalPlaces = 2
		Me.nudInddiscur12_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(164, Byte), CType(164, Byte), CType(164, Byte))
		Me.nudInddiscur12_2.DSSElementName = "inddiscur12_1"
		Me.nudInddiscur12_2.DSSLocation = 12
		Me.nudInddiscur12_2.DSSOffset = -0.2R
		Me.nudInddiscur12_2.Location = New System.Drawing.Point(0, 286)
		Me.nudInddiscur12_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddiscur12_2.Name = "nudInddiscur12_2"
		Me.nudInddiscur12_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddiscur12_2.TabIndex = 11
		Me.nudInddiscur12_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddiscur12_2.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudInddiscur1_2
		'
		Me.nudInddiscur1_2.DecimalPlaces = 2
		Me.nudInddiscur1_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(164, Byte), CType(164, Byte), CType(164, Byte))
		Me.nudInddiscur1_2.DSSElementName = "inddiscur1_1"
		Me.nudInddiscur1_2.DSSLocation = 1
		Me.nudInddiscur1_2.DSSOffset = -0.2R
		Me.nudInddiscur1_2.Location = New System.Drawing.Point(0, 33)
		Me.nudInddiscur1_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddiscur1_2.Name = "nudInddiscur1_2"
		Me.nudInddiscur1_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddiscur1_2.TabIndex = 0
		Me.nudInddiscur1_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddiscur1_2.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'nudInddiscur9_2
		'
		Me.nudInddiscur9_2.DecimalPlaces = 2
		Me.nudInddiscur9_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(164, Byte), CType(164, Byte), CType(164, Byte))
		Me.nudInddiscur9_2.DSSElementName = "inddiscur9_1"
		Me.nudInddiscur9_2.DSSLocation = 9
		Me.nudInddiscur9_2.DSSOffset = -0.2R
		Me.nudInddiscur9_2.Location = New System.Drawing.Point(0, 217)
		Me.nudInddiscur9_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddiscur9_2.Name = "nudInddiscur9_2"
		Me.nudInddiscur9_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddiscur9_2.TabIndex = 8
		Me.nudInddiscur9_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddiscur9_2.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudInddiscur13_2
		'
		Me.nudInddiscur13_2.DecimalPlaces = 2
		Me.nudInddiscur13_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(164, Byte), CType(164, Byte), CType(164, Byte))
		Me.nudInddiscur13_2.DSSElementName = "inddiscur13_1"
		Me.nudInddiscur13_2.DSSLocation = 13
		Me.nudInddiscur13_2.DSSOffset = -0.2R
		Me.nudInddiscur13_2.Location = New System.Drawing.Point(0, 309)
		Me.nudInddiscur13_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddiscur13_2.Name = "nudInddiscur13_2"
		Me.nudInddiscur13_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddiscur13_2.TabIndex = 12
		Me.nudInddiscur13_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddiscur13_2.Value = New Decimal(New Integer() {1054794521, 0, 0, 589824})
		'
		'nudInddiscur10_2
		'
		Me.nudInddiscur10_2.DecimalPlaces = 2
		Me.nudInddiscur10_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(164, Byte), CType(164, Byte), CType(164, Byte))
		Me.nudInddiscur10_2.DSSElementName = "inddiscur10_1"
		Me.nudInddiscur10_2.DSSLocation = 10
		Me.nudInddiscur10_2.DSSOffset = -0.2R
		Me.nudInddiscur10_2.Location = New System.Drawing.Point(0, 240)
		Me.nudInddiscur10_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddiscur10_2.Name = "nudInddiscur10_2"
		Me.nudInddiscur10_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddiscur10_2.TabIndex = 9
		Me.nudInddiscur10_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddiscur10_2.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudInddiscur11_2
		'
		Me.nudInddiscur11_2.DecimalPlaces = 2
		Me.nudInddiscur11_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(164, Byte), CType(164, Byte), CType(164, Byte))
		Me.nudInddiscur11_2.DSSElementName = "inddiscur11_1"
		Me.nudInddiscur11_2.DSSLocation = 11
		Me.nudInddiscur11_2.DSSOffset = -0.2R
		Me.nudInddiscur11_2.Location = New System.Drawing.Point(0, 263)
		Me.nudInddiscur11_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddiscur11_2.Name = "nudInddiscur11_2"
		Me.nudInddiscur11_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddiscur11_2.TabIndex = 10
		Me.nudInddiscur11_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddiscur11_2.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudInddiscur8_2
		'
		Me.nudInddiscur8_2.DecimalPlaces = 2
		Me.nudInddiscur8_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(164, Byte), CType(164, Byte), CType(164, Byte))
		Me.nudInddiscur8_2.DSSElementName = "inddiscur8_1"
		Me.nudInddiscur8_2.DSSLocation = 8
		Me.nudInddiscur8_2.DSSOffset = -0.2R
		Me.nudInddiscur8_2.Location = New System.Drawing.Point(0, 194)
		Me.nudInddiscur8_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddiscur8_2.Name = "nudInddiscur8_2"
		Me.nudInddiscur8_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddiscur8_2.TabIndex = 7
		Me.nudInddiscur8_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddiscur8_2.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'nudInddiscur5_2
		'
		Me.nudInddiscur5_2.DecimalPlaces = 2
		Me.nudInddiscur5_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(164, Byte), CType(164, Byte), CType(164, Byte))
		Me.nudInddiscur5_2.DSSElementName = "inddiscur5_1"
		Me.nudInddiscur5_2.DSSLocation = 5
		Me.nudInddiscur5_2.DSSOffset = -0.2R
		Me.nudInddiscur5_2.Location = New System.Drawing.Point(0, 125)
		Me.nudInddiscur5_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddiscur5_2.Name = "nudInddiscur5_2"
		Me.nudInddiscur5_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddiscur5_2.TabIndex = 4
		Me.nudInddiscur5_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddiscur5_2.Value = New Decimal(New Integer() {12, 0, 0, 0})
		'
		'nudInddiscur4_2
		'
		Me.nudInddiscur4_2.DecimalPlaces = 2
		Me.nudInddiscur4_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(164, Byte), CType(164, Byte), CType(164, Byte))
		Me.nudInddiscur4_2.DSSElementName = "inddiscur4_1"
		Me.nudInddiscur4_2.DSSLocation = 4
		Me.nudInddiscur4_2.DSSOffset = -0.2R
		Me.nudInddiscur4_2.Location = New System.Drawing.Point(0, 102)
		Me.nudInddiscur4_2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudInddiscur4_2.Name = "nudInddiscur4_2"
		Me.nudInddiscur4_2.Size = New System.Drawing.Size(90, 20)
		Me.nudInddiscur4_2.TabIndex = 3
		Me.nudInddiscur4_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudInddiscur4_2.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'lblIDLocation12
		'
		Me.lblIDLocation12.AutoSize = True
		Me.lblIDLocation12.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIDLocation12.DSSElementName = "locName"
		Me.lblIDLocation12.DSSLocation = 12
		Me.lblIDLocation12.DSSOffset = 0R
		Me.lblIDLocation12.Location = New System.Drawing.Point(12, 303)
		Me.lblIDLocation12.Name = "lblIDLocation12"
		Me.lblIDLocation12.Size = New System.Drawing.Size(56, 13)
		Me.lblIDLocation12.TabIndex = 158
		Me.lblIDLocation12.Text = "location12"
		'
		'lblIDLocation1
		'
		Me.lblIDLocation1.AutoSize = True
		Me.lblIDLocation1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIDLocation1.DSSElementName = "locName"
		Me.lblIDLocation1.DSSLocation = 1
		Me.lblIDLocation1.DSSOffset = 0R
		Me.lblIDLocation1.Location = New System.Drawing.Point(12, 50)
		Me.lblIDLocation1.Name = "lblIDLocation1"
		Me.lblIDLocation1.Size = New System.Drawing.Size(50, 13)
		Me.lblIDLocation1.TabIndex = 147
		Me.lblIDLocation1.Text = "location1"
		'
		'lblIDLocation11
		'
		Me.lblIDLocation11.AutoSize = True
		Me.lblIDLocation11.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIDLocation11.DSSElementName = "locName"
		Me.lblIDLocation11.DSSLocation = 11
		Me.lblIDLocation11.DSSOffset = 0R
		Me.lblIDLocation11.Location = New System.Drawing.Point(12, 280)
		Me.lblIDLocation11.Name = "lblIDLocation11"
		Me.lblIDLocation11.Size = New System.Drawing.Size(56, 13)
		Me.lblIDLocation11.TabIndex = 157
		Me.lblIDLocation11.Text = "location11"
		'
		'lblIDLocation5
		'
		Me.lblIDLocation5.AutoSize = True
		Me.lblIDLocation5.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIDLocation5.DSSElementName = "locName"
		Me.lblIDLocation5.DSSLocation = 5
		Me.lblIDLocation5.DSSOffset = 0R
		Me.lblIDLocation5.Location = New System.Drawing.Point(12, 142)
		Me.lblIDLocation5.Name = "lblIDLocation5"
		Me.lblIDLocation5.Size = New System.Drawing.Size(50, 13)
		Me.lblIDLocation5.TabIndex = 151
		Me.lblIDLocation5.Text = "location5"
		'
		'lblIDLocation6
		'
		Me.lblIDLocation6.AutoSize = True
		Me.lblIDLocation6.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIDLocation6.DSSElementName = "locName"
		Me.lblIDLocation6.DSSLocation = 6
		Me.lblIDLocation6.DSSOffset = 0R
		Me.lblIDLocation6.Location = New System.Drawing.Point(12, 165)
		Me.lblIDLocation6.Name = "lblIDLocation6"
		Me.lblIDLocation6.Size = New System.Drawing.Size(50, 13)
		Me.lblIDLocation6.TabIndex = 152
		Me.lblIDLocation6.Text = "location6"
		'
		'lblIDLocation10
		'
		Me.lblIDLocation10.AutoSize = True
		Me.lblIDLocation10.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIDLocation10.DSSElementName = "locName"
		Me.lblIDLocation10.DSSLocation = 10
		Me.lblIDLocation10.DSSOffset = 0R
		Me.lblIDLocation10.Location = New System.Drawing.Point(12, 257)
		Me.lblIDLocation10.Name = "lblIDLocation10"
		Me.lblIDLocation10.Size = New System.Drawing.Size(56, 13)
		Me.lblIDLocation10.TabIndex = 156
		Me.lblIDLocation10.Text = "location10"
		'
		'lblIDLocation4
		'
		Me.lblIDLocation4.AutoSize = True
		Me.lblIDLocation4.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIDLocation4.DSSElementName = "locName"
		Me.lblIDLocation4.DSSLocation = 4
		Me.lblIDLocation4.DSSOffset = 0R
		Me.lblIDLocation4.Location = New System.Drawing.Point(12, 119)
		Me.lblIDLocation4.Name = "lblIDLocation4"
		Me.lblIDLocation4.Size = New System.Drawing.Size(50, 13)
		Me.lblIDLocation4.TabIndex = 150
		Me.lblIDLocation4.Text = "location4"
		'
		'lblIDLocation13
		'
		Me.lblIDLocation13.AutoSize = True
		Me.lblIDLocation13.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIDLocation13.DSSElementName = "locNAme"
		Me.lblIDLocation13.DSSLocation = 13
		Me.lblIDLocation13.DSSOffset = 0R
		Me.lblIDLocation13.Location = New System.Drawing.Point(12, 326)
		Me.lblIDLocation13.Name = "lblIDLocation13"
		Me.lblIDLocation13.Size = New System.Drawing.Size(56, 13)
		Me.lblIDLocation13.TabIndex = 146
		Me.lblIDLocation13.Text = "location13"
		'
		'lblIDLocation7
		'
		Me.lblIDLocation7.AutoSize = True
		Me.lblIDLocation7.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIDLocation7.DSSElementName = "locName"
		Me.lblIDLocation7.DSSLocation = 7
		Me.lblIDLocation7.DSSOffset = 0R
		Me.lblIDLocation7.Location = New System.Drawing.Point(12, 188)
		Me.lblIDLocation7.Name = "lblIDLocation7"
		Me.lblIDLocation7.Size = New System.Drawing.Size(50, 13)
		Me.lblIDLocation7.TabIndex = 153
		Me.lblIDLocation7.Text = "location7"
		'
		'lblIDLocation9
		'
		Me.lblIDLocation9.AutoSize = True
		Me.lblIDLocation9.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIDLocation9.DSSElementName = "locName"
		Me.lblIDLocation9.DSSLocation = 9
		Me.lblIDLocation9.DSSOffset = 0R
		Me.lblIDLocation9.Location = New System.Drawing.Point(12, 234)
		Me.lblIDLocation9.Name = "lblIDLocation9"
		Me.lblIDLocation9.Size = New System.Drawing.Size(50, 13)
		Me.lblIDLocation9.TabIndex = 155
		Me.lblIDLocation9.Text = "location9"
		'
		'lblIDLocation3
		'
		Me.lblIDLocation3.AutoSize = True
		Me.lblIDLocation3.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIDLocation3.DSSElementName = "locName"
		Me.lblIDLocation3.DSSLocation = 3
		Me.lblIDLocation3.DSSOffset = 0R
		Me.lblIDLocation3.Location = New System.Drawing.Point(12, 96)
		Me.lblIDLocation3.Name = "lblIDLocation3"
		Me.lblIDLocation3.Size = New System.Drawing.Size(50, 13)
		Me.lblIDLocation3.TabIndex = 149
		Me.lblIDLocation3.Text = "location3"
		'
		'lblIDLocation2
		'
		Me.lblIDLocation2.AutoSize = True
		Me.lblIDLocation2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIDLocation2.DSSElementName = "locName"
		Me.lblIDLocation2.DSSLocation = 2
		Me.lblIDLocation2.DSSOffset = 0R
		Me.lblIDLocation2.Location = New System.Drawing.Point(12, 73)
		Me.lblIDLocation2.Name = "lblIDLocation2"
		Me.lblIDLocation2.Size = New System.Drawing.Size(50, 13)
		Me.lblIDLocation2.TabIndex = 148
		Me.lblIDLocation2.Text = "location2"
		'
		'lblIDLocation8
		'
		Me.lblIDLocation8.AutoSize = True
		Me.lblIDLocation8.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblIDLocation8.DSSElementName = "locName"
		Me.lblIDLocation8.DSSLocation = 8
		Me.lblIDLocation8.DSSOffset = 0R
		Me.lblIDLocation8.Location = New System.Drawing.Point(12, 211)
		Me.lblIDLocation8.Name = "lblIDLocation8"
		Me.lblIDLocation8.Size = New System.Drawing.Size(50, 13)
		Me.lblIDLocation8.TabIndex = 154
		Me.lblIDLocation8.Text = "location8"
		'
		'grbWaterQuality
		'
		Me.grbWaterQuality.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.grbWaterQuality.Controls.Add(Me.lblWQLocation15)
		Me.grbWaterQuality.Controls.Add(Me.lblWQLocation14)
		Me.grbWaterQuality.Controls.Add(Me.lblWQLocation12)
		Me.grbWaterQuality.Controls.Add(Me.lblWQLocation1)
		Me.grbWaterQuality.Controls.Add(Me.lblWQLocation11)
		Me.grbWaterQuality.Controls.Add(Me.lblWQLocation5)
		Me.grbWaterQuality.Controls.Add(Me.lblWQLocation6)
		Me.grbWaterQuality.Controls.Add(Me.lblWQLocation10)
		Me.grbWaterQuality.Controls.Add(Me.lblWQLocation4)
		Me.grbWaterQuality.Controls.Add(Me.lblWQLocation13)
		Me.grbWaterQuality.Controls.Add(Me.lblWQLocation7)
		Me.grbWaterQuality.Controls.Add(Me.lblWQLocation9)
		Me.grbWaterQuality.Controls.Add(Me.lblWQLocation3)
		Me.grbWaterQuality.Controls.Add(Me.lblWQLocation2)
		Me.grbWaterQuality.Controls.Add(Me.lblWQLocation8)
		Me.grbWaterQuality.Controls.Add(Me.pnlTSS)
		Me.grbWaterQuality.Controls.Add(Me.pnlTDS)
		Me.grbWaterQuality.Controls.Add(Me.pnlBOD)
		Me.grbWaterQuality.ForeColor = System.Drawing.Color.Black
		Me.grbWaterQuality.Location = New System.Drawing.Point(0, 0)
		Me.grbWaterQuality.Name = "grbWaterQuality"
		Me.grbWaterQuality.Size = New System.Drawing.Size(413, 516)
		Me.grbWaterQuality.TabIndex = 21
		Me.grbWaterQuality.TabStop = False
		Me.grbWaterQuality.Text = "Water quality indicator"
		Me.grbWaterQuality.Visible = False
		'
		'lblWQLocation15
		'
		Me.lblWQLocation15.AutoSize = True
		Me.lblWQLocation15.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWQLocation15.DSSElementName = "locName"
		Me.lblWQLocation15.DSSLocation = 15
		Me.lblWQLocation15.DSSOffset = 0R
		Me.lblWQLocation15.Location = New System.Drawing.Point(18, 372)
		Me.lblWQLocation15.Name = "lblWQLocation15"
		Me.lblWQLocation15.Size = New System.Drawing.Size(56, 13)
		Me.lblWQLocation15.TabIndex = 175
		Me.lblWQLocation15.Text = "location15"
		'
		'lblWQLocation14
		'
		Me.lblWQLocation14.AutoSize = True
		Me.lblWQLocation14.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWQLocation14.DSSElementName = "locName"
		Me.lblWQLocation14.DSSLocation = 14
		Me.lblWQLocation14.DSSOffset = 0R
		Me.lblWQLocation14.Location = New System.Drawing.Point(18, 349)
		Me.lblWQLocation14.Name = "lblWQLocation14"
		Me.lblWQLocation14.Size = New System.Drawing.Size(56, 13)
		Me.lblWQLocation14.TabIndex = 174
		Me.lblWQLocation14.Text = "location14"
		'
		'lblWQLocation12
		'
		Me.lblWQLocation12.AutoSize = True
		Me.lblWQLocation12.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWQLocation12.DSSElementName = "locName"
		Me.lblWQLocation12.DSSLocation = 12
		Me.lblWQLocation12.DSSOffset = 0R
		Me.lblWQLocation12.Location = New System.Drawing.Point(18, 303)
		Me.lblWQLocation12.Name = "lblWQLocation12"
		Me.lblWQLocation12.Size = New System.Drawing.Size(56, 13)
		Me.lblWQLocation12.TabIndex = 173
		Me.lblWQLocation12.Text = "location12"
		'
		'lblWQLocation1
		'
		Me.lblWQLocation1.AutoSize = True
		Me.lblWQLocation1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWQLocation1.DSSElementName = "locName"
		Me.lblWQLocation1.DSSLocation = 1
		Me.lblWQLocation1.DSSOffset = 0R
		Me.lblWQLocation1.Location = New System.Drawing.Point(18, 50)
		Me.lblWQLocation1.Name = "lblWQLocation1"
		Me.lblWQLocation1.Size = New System.Drawing.Size(50, 13)
		Me.lblWQLocation1.TabIndex = 162
		Me.lblWQLocation1.Text = "location1"
		'
		'lblWQLocation11
		'
		Me.lblWQLocation11.AutoSize = True
		Me.lblWQLocation11.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWQLocation11.DSSElementName = "locName"
		Me.lblWQLocation11.DSSLocation = 11
		Me.lblWQLocation11.DSSOffset = 0R
		Me.lblWQLocation11.Location = New System.Drawing.Point(18, 280)
		Me.lblWQLocation11.Name = "lblWQLocation11"
		Me.lblWQLocation11.Size = New System.Drawing.Size(56, 13)
		Me.lblWQLocation11.TabIndex = 172
		Me.lblWQLocation11.Text = "location11"
		'
		'lblWQLocation5
		'
		Me.lblWQLocation5.AccessibleDescription = ""
		Me.lblWQLocation5.AutoSize = True
		Me.lblWQLocation5.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWQLocation5.DSSElementName = "locName"
		Me.lblWQLocation5.DSSLocation = 5
		Me.lblWQLocation5.DSSOffset = 0R
		Me.lblWQLocation5.Location = New System.Drawing.Point(18, 142)
		Me.lblWQLocation5.Name = "lblWQLocation5"
		Me.lblWQLocation5.Size = New System.Drawing.Size(50, 13)
		Me.lblWQLocation5.TabIndex = 166
		Me.lblWQLocation5.Text = "location5"
		'
		'lblWQLocation6
		'
		Me.lblWQLocation6.AutoSize = True
		Me.lblWQLocation6.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWQLocation6.DSSElementName = "locName"
		Me.lblWQLocation6.DSSLocation = 6
		Me.lblWQLocation6.DSSOffset = 0R
		Me.lblWQLocation6.Location = New System.Drawing.Point(18, 165)
		Me.lblWQLocation6.Name = "lblWQLocation6"
		Me.lblWQLocation6.Size = New System.Drawing.Size(50, 13)
		Me.lblWQLocation6.TabIndex = 167
		Me.lblWQLocation6.Text = "location6"
		'
		'lblWQLocation10
		'
		Me.lblWQLocation10.AutoSize = True
		Me.lblWQLocation10.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWQLocation10.DSSElementName = "locName"
		Me.lblWQLocation10.DSSLocation = 10
		Me.lblWQLocation10.DSSOffset = 0R
		Me.lblWQLocation10.Location = New System.Drawing.Point(18, 257)
		Me.lblWQLocation10.Name = "lblWQLocation10"
		Me.lblWQLocation10.Size = New System.Drawing.Size(56, 13)
		Me.lblWQLocation10.TabIndex = 171
		Me.lblWQLocation10.Text = "location10"
		'
		'lblWQLocation4
		'
		Me.lblWQLocation4.AutoSize = True
		Me.lblWQLocation4.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWQLocation4.DSSElementName = "locName"
		Me.lblWQLocation4.DSSLocation = 4
		Me.lblWQLocation4.DSSOffset = 0R
		Me.lblWQLocation4.Location = New System.Drawing.Point(18, 119)
		Me.lblWQLocation4.Name = "lblWQLocation4"
		Me.lblWQLocation4.Size = New System.Drawing.Size(50, 13)
		Me.lblWQLocation4.TabIndex = 165
		Me.lblWQLocation4.Text = "location4"
		'
		'lblWQLocation13
		'
		Me.lblWQLocation13.AutoSize = True
		Me.lblWQLocation13.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWQLocation13.DSSElementName = "locNAme"
		Me.lblWQLocation13.DSSLocation = 13
		Me.lblWQLocation13.DSSOffset = 0R
		Me.lblWQLocation13.Location = New System.Drawing.Point(18, 326)
		Me.lblWQLocation13.Name = "lblWQLocation13"
		Me.lblWQLocation13.Size = New System.Drawing.Size(56, 13)
		Me.lblWQLocation13.TabIndex = 161
		Me.lblWQLocation13.Text = "location13"
		'
		'lblWQLocation7
		'
		Me.lblWQLocation7.AutoSize = True
		Me.lblWQLocation7.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWQLocation7.DSSElementName = "locName"
		Me.lblWQLocation7.DSSLocation = 7
		Me.lblWQLocation7.DSSOffset = 0R
		Me.lblWQLocation7.Location = New System.Drawing.Point(18, 188)
		Me.lblWQLocation7.Name = "lblWQLocation7"
		Me.lblWQLocation7.Size = New System.Drawing.Size(50, 13)
		Me.lblWQLocation7.TabIndex = 168
		Me.lblWQLocation7.Text = "location7"
		'
		'lblWQLocation9
		'
		Me.lblWQLocation9.AutoSize = True
		Me.lblWQLocation9.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWQLocation9.DSSElementName = "locName"
		Me.lblWQLocation9.DSSLocation = 9
		Me.lblWQLocation9.DSSOffset = 0R
		Me.lblWQLocation9.Location = New System.Drawing.Point(18, 234)
		Me.lblWQLocation9.Name = "lblWQLocation9"
		Me.lblWQLocation9.Size = New System.Drawing.Size(50, 13)
		Me.lblWQLocation9.TabIndex = 170
		Me.lblWQLocation9.Text = "location9"
		'
		'lblWQLocation3
		'
		Me.lblWQLocation3.AutoSize = True
		Me.lblWQLocation3.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWQLocation3.DSSElementName = "locName"
		Me.lblWQLocation3.DSSLocation = 3
		Me.lblWQLocation3.DSSOffset = 0R
		Me.lblWQLocation3.Location = New System.Drawing.Point(18, 96)
		Me.lblWQLocation3.Name = "lblWQLocation3"
		Me.lblWQLocation3.Size = New System.Drawing.Size(50, 13)
		Me.lblWQLocation3.TabIndex = 164
		Me.lblWQLocation3.Text = "location3"
		'
		'lblWQLocation2
		'
		Me.lblWQLocation2.AutoSize = True
		Me.lblWQLocation2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWQLocation2.DSSElementName = "locName"
		Me.lblWQLocation2.DSSLocation = 2
		Me.lblWQLocation2.DSSOffset = 0R
		Me.lblWQLocation2.Location = New System.Drawing.Point(18, 73)
		Me.lblWQLocation2.Name = "lblWQLocation2"
		Me.lblWQLocation2.Size = New System.Drawing.Size(50, 13)
		Me.lblWQLocation2.TabIndex = 163
		Me.lblWQLocation2.Text = "location2"
		'
		'lblWQLocation8
		'
		Me.lblWQLocation8.AutoSize = True
		Me.lblWQLocation8.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblWQLocation8.DSSElementName = "locName"
		Me.lblWQLocation8.DSSLocation = 8
		Me.lblWQLocation8.DSSOffset = 0R
		Me.lblWQLocation8.Location = New System.Drawing.Point(18, 211)
		Me.lblWQLocation8.Name = "lblWQLocation8"
		Me.lblWQLocation8.Size = New System.Drawing.Size(50, 13)
		Me.lblWQLocation8.TabIndex = 169
		Me.lblWQLocation8.Text = "location8"
		'
		'pnlTSS
		'
		Me.pnlTSS.Controls.Add(Me.nudTSS14)
		Me.pnlTSS.Controls.Add(Me.nudTSS15)
		Me.pnlTSS.Controls.Add(Me.Label21)
		Me.pnlTSS.Controls.Add(Me.nudTSS3)
		Me.pnlTSS.Controls.Add(Me.nudTSS2)
		Me.pnlTSS.Controls.Add(Me.nudTSS7)
		Me.pnlTSS.Controls.Add(Me.nudTSS10)
		Me.pnlTSS.Controls.Add(Me.nudTSS12)
		Me.pnlTSS.Controls.Add(Me.nudTSS6)
		Me.pnlTSS.Controls.Add(Me.nudTSS13)
		Me.pnlTSS.Controls.Add(Me.nudTSS1)
		Me.pnlTSS.Controls.Add(Me.nudTSS8)
		Me.pnlTSS.Controls.Add(Me.nudTSS9)
		Me.pnlTSS.Controls.Add(Me.nudTSS4)
		Me.pnlTSS.Controls.Add(Me.nudTSS5)
		Me.pnlTSS.Controls.Add(Me.nudTSS11)
		Me.pnlTSS.Location = New System.Drawing.Point(306, 15)
		Me.pnlTSS.Name = "pnlTSS"
		Me.pnlTSS.Size = New System.Drawing.Size(90, 408)
		Me.pnlTSS.TabIndex = 53
		'
		'nudTSS14
		'
		Me.nudTSS14.DecimalPlaces = 2
		Me.nudTSS14.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.nudTSS14.DSSElementName = "lmqi14_1"
		Me.nudTSS14.DSSLocation = 14
		Me.nudTSS14.DSSOffset = 0.4R
		Me.nudTSS14.Location = New System.Drawing.Point(0, 332)
		Me.nudTSS14.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudTSS14.Name = "nudTSS14"
		Me.nudTSS14.Size = New System.Drawing.Size(90, 20)
		Me.nudTSS14.TabIndex = 43
		Me.nudTSS14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTSS14.Value = New Decimal(New Integer() {3, 0, 0, 65536})
		'
		'nudTSS15
		'
		Me.nudTSS15.DecimalPlaces = 2
		Me.nudTSS15.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.nudTSS15.DSSElementName = "lmqi15_1"
		Me.nudTSS15.DSSLocation = 15
		Me.nudTSS15.DSSOffset = 0.4R
		Me.nudTSS15.Location = New System.Drawing.Point(0, 355)
		Me.nudTSS15.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudTSS15.Name = "nudTSS15"
		Me.nudTSS15.Size = New System.Drawing.Size(90, 20)
		Me.nudTSS15.TabIndex = 44
		Me.nudTSS15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTSS15.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'Label21
		'
		Me.Label21.Location = New System.Drawing.Point(0, 10)
		Me.Label21.Name = "Label21"
		Me.Label21.Size = New System.Drawing.Size(90, 13)
		Me.Label21.TabIndex = 49
		Me.Label21.Text = "TSS"
		Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'nudTSS3
		'
		Me.nudTSS3.DecimalPlaces = 2
		Me.nudTSS3.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.nudTSS3.DSSElementName = "lmqi3_1"
		Me.nudTSS3.DSSLocation = 3
		Me.nudTSS3.DSSOffset = 0.4R
		Me.nudTSS3.Location = New System.Drawing.Point(0, 79)
		Me.nudTSS3.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudTSS3.Name = "nudTSS3"
		Me.nudTSS3.Size = New System.Drawing.Size(90, 20)
		Me.nudTSS3.TabIndex = 32
		Me.nudTSS3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTSS3.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudTSS2
		'
		Me.nudTSS2.DecimalPlaces = 2
		Me.nudTSS2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.nudTSS2.DSSElementName = "lmqi2_1"
		Me.nudTSS2.DSSLocation = 2
		Me.nudTSS2.DSSOffset = 0.4R
		Me.nudTSS2.Location = New System.Drawing.Point(0, 56)
		Me.nudTSS2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudTSS2.Name = "nudTSS2"
		Me.nudTSS2.Size = New System.Drawing.Size(90, 20)
		Me.nudTSS2.TabIndex = 31
		Me.nudTSS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTSS2.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudTSS7
		'
		Me.nudTSS7.DecimalPlaces = 2
		Me.nudTSS7.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.nudTSS7.DSSElementName = "lmqi7_1"
		Me.nudTSS7.DSSLocation = 7
		Me.nudTSS7.DSSOffset = 0.4R
		Me.nudTSS7.Location = New System.Drawing.Point(0, 171)
		Me.nudTSS7.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudTSS7.Name = "nudTSS7"
		Me.nudTSS7.Size = New System.Drawing.Size(90, 20)
		Me.nudTSS7.TabIndex = 36
		Me.nudTSS7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTSS7.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudTSS10
		'
		Me.nudTSS10.DecimalPlaces = 2
		Me.nudTSS10.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.nudTSS10.DSSElementName = "lmqi10_1"
		Me.nudTSS10.DSSLocation = 10
		Me.nudTSS10.DSSOffset = 0.4R
		Me.nudTSS10.Location = New System.Drawing.Point(0, 240)
		Me.nudTSS10.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudTSS10.Name = "nudTSS10"
		Me.nudTSS10.Size = New System.Drawing.Size(90, 20)
		Me.nudTSS10.TabIndex = 39
		Me.nudTSS10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTSS10.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'nudTSS12
		'
		Me.nudTSS12.DecimalPlaces = 2
		Me.nudTSS12.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.nudTSS12.DSSElementName = "lmqi12_1"
		Me.nudTSS12.DSSLocation = 12
		Me.nudTSS12.DSSOffset = 0.4R
		Me.nudTSS12.Location = New System.Drawing.Point(0, 286)
		Me.nudTSS12.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudTSS12.Name = "nudTSS12"
		Me.nudTSS12.Size = New System.Drawing.Size(90, 20)
		Me.nudTSS12.TabIndex = 41
		Me.nudTSS12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTSS12.Value = New Decimal(New Integer() {3, 0, 0, 65536})
		'
		'nudTSS6
		'
		Me.nudTSS6.DecimalPlaces = 2
		Me.nudTSS6.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.nudTSS6.DSSElementName = "lmqi6_1"
		Me.nudTSS6.DSSLocation = 6
		Me.nudTSS6.DSSOffset = 0.4R
		Me.nudTSS6.Location = New System.Drawing.Point(0, 148)
		Me.nudTSS6.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudTSS6.Name = "nudTSS6"
		Me.nudTSS6.Size = New System.Drawing.Size(90, 20)
		Me.nudTSS6.TabIndex = 35
		Me.nudTSS6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTSS6.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudTSS13
		'
		Me.nudTSS13.DecimalPlaces = 2
		Me.nudTSS13.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.nudTSS13.DSSElementName = "lmqi13_1"
		Me.nudTSS13.DSSLocation = 13
		Me.nudTSS13.DSSOffset = 0.4R
		Me.nudTSS13.Location = New System.Drawing.Point(0, 309)
		Me.nudTSS13.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudTSS13.Name = "nudTSS13"
		Me.nudTSS13.Size = New System.Drawing.Size(90, 20)
		Me.nudTSS13.TabIndex = 42
		Me.nudTSS13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTSS13.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'nudTSS1
		'
		Me.nudTSS1.DecimalPlaces = 2
		Me.nudTSS1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.nudTSS1.DSSElementName = "lmqi1_1"
		Me.nudTSS1.DSSLocation = 1
		Me.nudTSS1.DSSOffset = 0.4R
		Me.nudTSS1.Location = New System.Drawing.Point(0, 33)
		Me.nudTSS1.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudTSS1.Name = "nudTSS1"
		Me.nudTSS1.Size = New System.Drawing.Size(90, 20)
		Me.nudTSS1.TabIndex = 30
		Me.nudTSS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTSS1.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudTSS8
		'
		Me.nudTSS8.DecimalPlaces = 2
		Me.nudTSS8.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.nudTSS8.DSSElementName = "lmqi8_1"
		Me.nudTSS8.DSSLocation = 8
		Me.nudTSS8.DSSOffset = 0.4R
		Me.nudTSS8.Location = New System.Drawing.Point(0, 194)
		Me.nudTSS8.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudTSS8.Name = "nudTSS8"
		Me.nudTSS8.Size = New System.Drawing.Size(90, 20)
		Me.nudTSS8.TabIndex = 37
		Me.nudTSS8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTSS8.Value = New Decimal(New Integer() {6, 0, 0, 65536})
		'
		'nudTSS9
		'
		Me.nudTSS9.DecimalPlaces = 2
		Me.nudTSS9.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.nudTSS9.DSSElementName = "lmqi9_1"
		Me.nudTSS9.DSSLocation = 9
		Me.nudTSS9.DSSOffset = 0.4R
		Me.nudTSS9.Location = New System.Drawing.Point(0, 217)
		Me.nudTSS9.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudTSS9.Name = "nudTSS9"
		Me.nudTSS9.Size = New System.Drawing.Size(90, 20)
		Me.nudTSS9.TabIndex = 38
		Me.nudTSS9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTSS9.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'nudTSS4
		'
		Me.nudTSS4.DecimalPlaces = 2
		Me.nudTSS4.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.nudTSS4.DSSElementName = "lmqi4_1"
		Me.nudTSS4.DSSLocation = 4
		Me.nudTSS4.DSSOffset = 0.4R
		Me.nudTSS4.Location = New System.Drawing.Point(0, 102)
		Me.nudTSS4.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudTSS4.Name = "nudTSS4"
		Me.nudTSS4.Size = New System.Drawing.Size(90, 20)
		Me.nudTSS4.TabIndex = 33
		Me.nudTSS4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTSS4.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudTSS5
		'
		Me.nudTSS5.DecimalPlaces = 2
		Me.nudTSS5.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.nudTSS5.DSSElementName = "lmqi5_1"
		Me.nudTSS5.DSSLocation = 5
		Me.nudTSS5.DSSOffset = 0.4R
		Me.nudTSS5.Location = New System.Drawing.Point(0, 125)
		Me.nudTSS5.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudTSS5.Name = "nudTSS5"
		Me.nudTSS5.Size = New System.Drawing.Size(90, 20)
		Me.nudTSS5.TabIndex = 34
		Me.nudTSS5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTSS5.Value = New Decimal(New Integer() {8, 0, 0, 65536})
		'
		'nudTSS11
		'
		Me.nudTSS11.DecimalPlaces = 2
		Me.nudTSS11.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
		Me.nudTSS11.DSSElementName = "lmqi11_1"
		Me.nudTSS11.DSSLocation = 11
		Me.nudTSS11.DSSOffset = 0.4R
		Me.nudTSS11.Location = New System.Drawing.Point(0, 263)
		Me.nudTSS11.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudTSS11.Name = "nudTSS11"
		Me.nudTSS11.Size = New System.Drawing.Size(90, 20)
		Me.nudTSS11.TabIndex = 40
		Me.nudTSS11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTSS11.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'pnlTDS
		'
		Me.pnlTDS.Controls.Add(Me.nudTDS14)
		Me.pnlTDS.Controls.Add(Me.nudTDS15)
		Me.pnlTDS.Controls.Add(Me.Label19)
		Me.pnlTDS.Controls.Add(Me.nudTDS3)
		Me.pnlTDS.Controls.Add(Me.nudTDS2)
		Me.pnlTDS.Controls.Add(Me.nudTDS7)
		Me.pnlTDS.Controls.Add(Me.nudTDS10)
		Me.pnlTDS.Controls.Add(Me.nudTDS6)
		Me.pnlTDS.Controls.Add(Me.nudTDS12)
		Me.pnlTDS.Controls.Add(Me.nudTDS1)
		Me.pnlTDS.Controls.Add(Me.nudTDS9)
		Me.pnlTDS.Controls.Add(Me.nudTDS13)
		Me.pnlTDS.Controls.Add(Me.nudTDS5)
		Me.pnlTDS.Controls.Add(Me.nudTDS11)
		Me.pnlTDS.Controls.Add(Me.nudTDS8)
		Me.pnlTDS.Controls.Add(Me.nudTDS4)
		Me.pnlTDS.Location = New System.Drawing.Point(210, 15)
		Me.pnlTDS.Name = "pnlTDS"
		Me.pnlTDS.Size = New System.Drawing.Size(90, 408)
		Me.pnlTDS.TabIndex = 52
		'
		'nudTDS14
		'
		Me.nudTDS14.DecimalPlaces = 2
		Me.nudTDS14.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.nudTDS14.DSSElementName = "lsqi14_1"
		Me.nudTDS14.DSSLocation = 14
		Me.nudTDS14.DSSOffset = 0R
		Me.nudTDS14.Location = New System.Drawing.Point(0, 332)
		Me.nudTDS14.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
		Me.nudTDS14.Name = "nudTDS14"
		Me.nudTDS14.Size = New System.Drawing.Size(90, 20)
		Me.nudTDS14.TabIndex = 28
		Me.nudTDS14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTDS14.Value = New Decimal(New Integer() {3, 0, 0, 65536})
		'
		'nudTDS15
		'
		Me.nudTDS15.DecimalPlaces = 2
		Me.nudTDS15.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.nudTDS15.DSSElementName = "lsqi15_1"
		Me.nudTDS15.DSSLocation = 15
		Me.nudTDS15.DSSOffset = 0R
		Me.nudTDS15.Location = New System.Drawing.Point(0, 355)
		Me.nudTDS15.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
		Me.nudTDS15.Name = "nudTDS15"
		Me.nudTDS15.Size = New System.Drawing.Size(90, 20)
		Me.nudTDS15.TabIndex = 29
		Me.nudTDS15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTDS15.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'Label19
		'
		Me.Label19.Location = New System.Drawing.Point(0, 10)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(90, 13)
		Me.Label19.TabIndex = 49
		Me.Label19.Text = "TDS"
		Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'nudTDS3
		'
		Me.nudTDS3.DecimalPlaces = 2
		Me.nudTDS3.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.nudTDS3.DSSElementName = "lsqi3_1"
		Me.nudTDS3.DSSLocation = 3
		Me.nudTDS3.DSSOffset = 0R
		Me.nudTDS3.Location = New System.Drawing.Point(0, 79)
		Me.nudTDS3.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
		Me.nudTDS3.Name = "nudTDS3"
		Me.nudTDS3.Size = New System.Drawing.Size(90, 20)
		Me.nudTDS3.TabIndex = 17
		Me.nudTDS3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTDS3.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudTDS2
		'
		Me.nudTDS2.DecimalPlaces = 2
		Me.nudTDS2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.nudTDS2.DSSElementName = "lsqi2_1"
		Me.nudTDS2.DSSLocation = 2
		Me.nudTDS2.DSSOffset = 0R
		Me.nudTDS2.Location = New System.Drawing.Point(0, 56)
		Me.nudTDS2.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
		Me.nudTDS2.Name = "nudTDS2"
		Me.nudTDS2.Size = New System.Drawing.Size(90, 20)
		Me.nudTDS2.TabIndex = 16
		Me.nudTDS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTDS2.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudTDS7
		'
		Me.nudTDS7.DecimalPlaces = 2
		Me.nudTDS7.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.nudTDS7.DSSElementName = "lsqi7_1"
		Me.nudTDS7.DSSLocation = 7
		Me.nudTDS7.DSSOffset = 0R
		Me.nudTDS7.Location = New System.Drawing.Point(0, 171)
		Me.nudTDS7.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
		Me.nudTDS7.Name = "nudTDS7"
		Me.nudTDS7.Size = New System.Drawing.Size(90, 20)
		Me.nudTDS7.TabIndex = 21
		Me.nudTDS7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTDS7.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudTDS10
		'
		Me.nudTDS10.DecimalPlaces = 2
		Me.nudTDS10.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.nudTDS10.DSSElementName = "lsqi10_1"
		Me.nudTDS10.DSSLocation = 10
		Me.nudTDS10.DSSOffset = 0R
		Me.nudTDS10.Location = New System.Drawing.Point(0, 240)
		Me.nudTDS10.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
		Me.nudTDS10.Name = "nudTDS10"
		Me.nudTDS10.Size = New System.Drawing.Size(90, 20)
		Me.nudTDS10.TabIndex = 24
		Me.nudTDS10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTDS10.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'nudTDS6
		'
		Me.nudTDS6.DecimalPlaces = 2
		Me.nudTDS6.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.nudTDS6.DSSElementName = "lsqi6_1"
		Me.nudTDS6.DSSLocation = 6
		Me.nudTDS6.DSSOffset = 0R
		Me.nudTDS6.Location = New System.Drawing.Point(0, 148)
		Me.nudTDS6.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
		Me.nudTDS6.Name = "nudTDS6"
		Me.nudTDS6.Size = New System.Drawing.Size(90, 20)
		Me.nudTDS6.TabIndex = 20
		Me.nudTDS6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTDS6.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudTDS12
		'
		Me.nudTDS12.DecimalPlaces = 2
		Me.nudTDS12.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.nudTDS12.DSSElementName = "lsqi12_1"
		Me.nudTDS12.DSSLocation = 12
		Me.nudTDS12.DSSOffset = 0R
		Me.nudTDS12.Location = New System.Drawing.Point(0, 286)
		Me.nudTDS12.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
		Me.nudTDS12.Name = "nudTDS12"
		Me.nudTDS12.Size = New System.Drawing.Size(90, 20)
		Me.nudTDS12.TabIndex = 26
		Me.nudTDS12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTDS12.Value = New Decimal(New Integer() {3, 0, 0, 65536})
		'
		'nudTDS1
		'
		Me.nudTDS1.DecimalPlaces = 2
		Me.nudTDS1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.nudTDS1.DSSElementName = "lsqi1_1"
		Me.nudTDS1.DSSLocation = 1
		Me.nudTDS1.DSSOffset = 0R
		Me.nudTDS1.Location = New System.Drawing.Point(0, 33)
		Me.nudTDS1.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
		Me.nudTDS1.Name = "nudTDS1"
		Me.nudTDS1.Size = New System.Drawing.Size(90, 20)
		Me.nudTDS1.TabIndex = 15
		Me.nudTDS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTDS1.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudTDS9
		'
		Me.nudTDS9.DecimalPlaces = 2
		Me.nudTDS9.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.nudTDS9.DSSElementName = "lsqi9_1"
		Me.nudTDS9.DSSLocation = 9
		Me.nudTDS9.DSSOffset = 0R
		Me.nudTDS9.Location = New System.Drawing.Point(0, 217)
		Me.nudTDS9.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
		Me.nudTDS9.Name = "nudTDS9"
		Me.nudTDS9.Size = New System.Drawing.Size(90, 20)
		Me.nudTDS9.TabIndex = 23
		Me.nudTDS9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTDS9.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'nudTDS13
		'
		Me.nudTDS13.DecimalPlaces = 2
		Me.nudTDS13.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.nudTDS13.DSSElementName = "lsqi13_1"
		Me.nudTDS13.DSSLocation = 13
		Me.nudTDS13.DSSOffset = 0R
		Me.nudTDS13.Location = New System.Drawing.Point(0, 309)
		Me.nudTDS13.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
		Me.nudTDS13.Name = "nudTDS13"
		Me.nudTDS13.Size = New System.Drawing.Size(90, 20)
		Me.nudTDS13.TabIndex = 27
		Me.nudTDS13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTDS13.Value = New Decimal(New Integer() {5, 0, 0, 65536})
		'
		'nudTDS5
		'
		Me.nudTDS5.DecimalPlaces = 2
		Me.nudTDS5.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.nudTDS5.DSSElementName = "lsqi5_1"
		Me.nudTDS5.DSSLocation = 5
		Me.nudTDS5.DSSOffset = 0R
		Me.nudTDS5.Location = New System.Drawing.Point(0, 125)
		Me.nudTDS5.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
		Me.nudTDS5.Name = "nudTDS5"
		Me.nudTDS5.Size = New System.Drawing.Size(90, 20)
		Me.nudTDS5.TabIndex = 19
		Me.nudTDS5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTDS5.Value = New Decimal(New Integer() {8, 0, 0, 65536})
		'
		'nudTDS11
		'
		Me.nudTDS11.DecimalPlaces = 2
		Me.nudTDS11.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.nudTDS11.DSSElementName = "lsqi11_1"
		Me.nudTDS11.DSSLocation = 11
		Me.nudTDS11.DSSOffset = 0R
		Me.nudTDS11.Location = New System.Drawing.Point(0, 263)
		Me.nudTDS11.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
		Me.nudTDS11.Name = "nudTDS11"
		Me.nudTDS11.Size = New System.Drawing.Size(90, 20)
		Me.nudTDS11.TabIndex = 25
		Me.nudTDS11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTDS11.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'nudTDS8
		'
		Me.nudTDS8.DecimalPlaces = 2
		Me.nudTDS8.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.nudTDS8.DSSElementName = "lsqi8_1"
		Me.nudTDS8.DSSLocation = 8
		Me.nudTDS8.DSSOffset = 0R
		Me.nudTDS8.Location = New System.Drawing.Point(0, 194)
		Me.nudTDS8.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
		Me.nudTDS8.Name = "nudTDS8"
		Me.nudTDS8.Size = New System.Drawing.Size(90, 20)
		Me.nudTDS8.TabIndex = 22
		Me.nudTDS8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTDS8.Value = New Decimal(New Integer() {6, 0, 0, 65536})
		'
		'nudTDS4
		'
		Me.nudTDS4.DecimalPlaces = 2
		Me.nudTDS4.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte), CType(0, Byte))
		Me.nudTDS4.DSSElementName = "lsqi4_1"
		Me.nudTDS4.DSSLocation = 4
		Me.nudTDS4.DSSOffset = 0R
		Me.nudTDS4.Location = New System.Drawing.Point(0, 102)
		Me.nudTDS4.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
		Me.nudTDS4.Name = "nudTDS4"
		Me.nudTDS4.Size = New System.Drawing.Size(90, 20)
		Me.nudTDS4.TabIndex = 18
		Me.nudTDS4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTDS4.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'pnlBOD
		'
		Me.pnlBOD.Controls.Add(Me.nudBOD14)
		Me.pnlBOD.Controls.Add(Me.nudBOD15)
		Me.pnlBOD.Controls.Add(Me.Label20)
		Me.pnlBOD.Controls.Add(Me.nudBOD3)
		Me.pnlBOD.Controls.Add(Me.nudBOD2)
		Me.pnlBOD.Controls.Add(Me.nudBOD7)
		Me.pnlBOD.Controls.Add(Me.nudBOD6)
		Me.pnlBOD.Controls.Add(Me.nudBOD1)
		Me.pnlBOD.Controls.Add(Me.nudBOD9)
		Me.pnlBOD.Controls.Add(Me.nudBOD12)
		Me.pnlBOD.Controls.Add(Me.nudBOD10)
		Me.pnlBOD.Controls.Add(Me.nudBOD11)
		Me.pnlBOD.Controls.Add(Me.nudBOD5)
		Me.pnlBOD.Controls.Add(Me.nudBOD13)
		Me.pnlBOD.Controls.Add(Me.nudBOD4)
		Me.pnlBOD.Controls.Add(Me.nudBOD8)
		Me.pnlBOD.Location = New System.Drawing.Point(113, 15)
		Me.pnlBOD.Name = "pnlBOD"
		Me.pnlBOD.Size = New System.Drawing.Size(90, 408)
		Me.pnlBOD.TabIndex = 51
		'
		'nudBOD14
		'
		Me.nudBOD14.DecimalPlaces = 2
		Me.nudBOD14.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.nudBOD14.DSSElementName = "lbqi14_1"
		Me.nudBOD14.DSSLocation = 14
		Me.nudBOD14.DSSOffset = -0.4R
		Me.nudBOD14.Location = New System.Drawing.Point(0, 332)
		Me.nudBOD14.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudBOD14.Name = "nudBOD14"
		Me.nudBOD14.Size = New System.Drawing.Size(90, 20)
		Me.nudBOD14.TabIndex = 13
		Me.nudBOD14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudBOD14.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudBOD15
		'
		Me.nudBOD15.DecimalPlaces = 2
		Me.nudBOD15.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.nudBOD15.DSSElementName = "lbqi15_1"
		Me.nudBOD15.DSSLocation = 15
		Me.nudBOD15.DSSOffset = -0.4R
		Me.nudBOD15.Location = New System.Drawing.Point(0, 355)
		Me.nudBOD15.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudBOD15.Name = "nudBOD15"
		Me.nudBOD15.Size = New System.Drawing.Size(90, 20)
		Me.nudBOD15.TabIndex = 14
		Me.nudBOD15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudBOD15.Value = New Decimal(New Integer() {1054794521, 0, 0, 589824})
		'
		'Label20
		'
		Me.Label20.Location = New System.Drawing.Point(0, 10)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(90, 13)
		Me.Label20.TabIndex = 50
		Me.Label20.Text = "BOD"
		Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'nudBOD3
		'
		Me.nudBOD3.DecimalPlaces = 2
		Me.nudBOD3.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.nudBOD3.DSSElementName = "lbqi3_1"
		Me.nudBOD3.DSSLocation = 3
		Me.nudBOD3.DSSOffset = -0.4R
		Me.nudBOD3.Location = New System.Drawing.Point(0, 79)
		Me.nudBOD3.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudBOD3.Name = "nudBOD3"
		Me.nudBOD3.Size = New System.Drawing.Size(90, 20)
		Me.nudBOD3.TabIndex = 2
		Me.nudBOD3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudBOD3.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'nudBOD2
		'
		Me.nudBOD2.DecimalPlaces = 2
		Me.nudBOD2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.nudBOD2.DSSElementName = "lbqi2_1"
		Me.nudBOD2.DSSLocation = 2
		Me.nudBOD2.DSSOffset = -0.4R
		Me.nudBOD2.Location = New System.Drawing.Point(0, 56)
		Me.nudBOD2.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudBOD2.Name = "nudBOD2"
		Me.nudBOD2.Size = New System.Drawing.Size(90, 20)
		Me.nudBOD2.TabIndex = 1
		Me.nudBOD2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudBOD2.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'nudBOD7
		'
		Me.nudBOD7.DecimalPlaces = 2
		Me.nudBOD7.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.nudBOD7.DSSElementName = "lbqi7_1"
		Me.nudBOD7.DSSLocation = 7
		Me.nudBOD7.DSSOffset = -0.4R
		Me.nudBOD7.Location = New System.Drawing.Point(0, 171)
		Me.nudBOD7.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudBOD7.Name = "nudBOD7"
		Me.nudBOD7.Size = New System.Drawing.Size(90, 20)
		Me.nudBOD7.TabIndex = 6
		Me.nudBOD7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudBOD7.Value = New Decimal(New Integer() {10, 0, 0, 0})
		'
		'nudBOD6
		'
		Me.nudBOD6.DecimalPlaces = 2
		Me.nudBOD6.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.nudBOD6.DSSElementName = "lbqi6_1"
		Me.nudBOD6.DSSLocation = 6
		Me.nudBOD6.DSSOffset = -0.4R
		Me.nudBOD6.Location = New System.Drawing.Point(0, 148)
		Me.nudBOD6.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudBOD6.Name = "nudBOD6"
		Me.nudBOD6.Size = New System.Drawing.Size(90, 20)
		Me.nudBOD6.TabIndex = 5
		Me.nudBOD6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudBOD6.Value = New Decimal(New Integer() {6, 0, 0, 0})
		'
		'nudBOD1
		'
		Me.nudBOD1.DecimalPlaces = 2
		Me.nudBOD1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.nudBOD1.DSSElementName = "lbqi1_1"
		Me.nudBOD1.DSSLocation = 1
		Me.nudBOD1.DSSOffset = -0.4R
		Me.nudBOD1.Location = New System.Drawing.Point(0, 33)
		Me.nudBOD1.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudBOD1.Name = "nudBOD1"
		Me.nudBOD1.Size = New System.Drawing.Size(90, 20)
		Me.nudBOD1.TabIndex = 0
		Me.nudBOD1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudBOD1.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'nudBOD9
		'
		Me.nudBOD9.DecimalPlaces = 2
		Me.nudBOD9.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.nudBOD9.DSSElementName = "lbqi9_1"
		Me.nudBOD9.DSSLocation = 9
		Me.nudBOD9.DSSOffset = -0.4R
		Me.nudBOD9.Location = New System.Drawing.Point(0, 217)
		Me.nudBOD9.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudBOD9.Name = "nudBOD9"
		Me.nudBOD9.Size = New System.Drawing.Size(90, 20)
		Me.nudBOD9.TabIndex = 8
		Me.nudBOD9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudBOD9.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudBOD12
		'
		Me.nudBOD12.DecimalPlaces = 2
		Me.nudBOD12.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.nudBOD12.DSSElementName = "lbqi12_1"
		Me.nudBOD12.DSSLocation = 12
		Me.nudBOD12.DSSOffset = -0.4R
		Me.nudBOD12.Location = New System.Drawing.Point(0, 286)
		Me.nudBOD12.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudBOD12.Name = "nudBOD12"
		Me.nudBOD12.Size = New System.Drawing.Size(90, 20)
		Me.nudBOD12.TabIndex = 11
		Me.nudBOD12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudBOD12.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudBOD10
		'
		Me.nudBOD10.DecimalPlaces = 2
		Me.nudBOD10.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.nudBOD10.DSSElementName = "lbqi10_1"
		Me.nudBOD10.DSSLocation = 10
		Me.nudBOD10.DSSOffset = -0.4R
		Me.nudBOD10.Location = New System.Drawing.Point(0, 240)
		Me.nudBOD10.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudBOD10.Name = "nudBOD10"
		Me.nudBOD10.Size = New System.Drawing.Size(90, 20)
		Me.nudBOD10.TabIndex = 9
		Me.nudBOD10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudBOD10.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudBOD11
		'
		Me.nudBOD11.DecimalPlaces = 2
		Me.nudBOD11.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.nudBOD11.DSSElementName = "lbqi11_1"
		Me.nudBOD11.DSSLocation = 11
		Me.nudBOD11.DSSOffset = -0.4R
		Me.nudBOD11.Location = New System.Drawing.Point(0, 263)
		Me.nudBOD11.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudBOD11.Name = "nudBOD11"
		Me.nudBOD11.Size = New System.Drawing.Size(90, 20)
		Me.nudBOD11.TabIndex = 10
		Me.nudBOD11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudBOD11.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'nudBOD5
		'
		Me.nudBOD5.DecimalPlaces = 2
		Me.nudBOD5.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.nudBOD5.DSSElementName = "lbqi5_1"
		Me.nudBOD5.DSSLocation = 5
		Me.nudBOD5.DSSOffset = -0.4R
		Me.nudBOD5.Location = New System.Drawing.Point(0, 125)
		Me.nudBOD5.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudBOD5.Name = "nudBOD5"
		Me.nudBOD5.Size = New System.Drawing.Size(90, 20)
		Me.nudBOD5.TabIndex = 4
		Me.nudBOD5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudBOD5.Value = New Decimal(New Integer() {12, 0, 0, 0})
		'
		'nudBOD13
		'
		Me.nudBOD13.DecimalPlaces = 2
		Me.nudBOD13.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.nudBOD13.DSSElementName = "lbqi13_1"
		Me.nudBOD13.DSSLocation = 13
		Me.nudBOD13.DSSOffset = -0.4R
		Me.nudBOD13.Location = New System.Drawing.Point(0, 309)
		Me.nudBOD13.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudBOD13.Name = "nudBOD13"
		Me.nudBOD13.Size = New System.Drawing.Size(90, 20)
		Me.nudBOD13.TabIndex = 12
		Me.nudBOD13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudBOD13.Value = New Decimal(New Integer() {1054794521, 0, 0, 589824})
		'
		'nudBOD4
		'
		Me.nudBOD4.DecimalPlaces = 2
		Me.nudBOD4.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.nudBOD4.DSSElementName = "lbqi4_1"
		Me.nudBOD4.DSSLocation = 4
		Me.nudBOD4.DSSOffset = -0.4R
		Me.nudBOD4.Location = New System.Drawing.Point(0, 102)
		Me.nudBOD4.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudBOD4.Name = "nudBOD4"
		Me.nudBOD4.Size = New System.Drawing.Size(90, 20)
		Me.nudBOD4.TabIndex = 3
		Me.nudBOD4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudBOD4.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'nudBOD8
		'
		Me.nudBOD8.DecimalPlaces = 2
		Me.nudBOD8.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(255, Byte))
		Me.nudBOD8.DSSElementName = "lbqi8_1"
		Me.nudBOD8.DSSLocation = 8
		Me.nudBOD8.DSSOffset = -0.4R
		Me.nudBOD8.Location = New System.Drawing.Point(0, 194)
		Me.nudBOD8.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudBOD8.Name = "nudBOD8"
		Me.nudBOD8.Size = New System.Drawing.Size(90, 20)
		Me.nudBOD8.TabIndex = 7
		Me.nudBOD8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudBOD8.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'ElementHost1
		'
		Me.ElementHost1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ElementHost1.Location = New System.Drawing.Point(0, 0)
		Me.ElementHost1.Name = "ElementHost1"
		Me.ElementHost1.Size = New System.Drawing.Size(192, 516)
		Me.ElementHost1.TabIndex = 0
		Me.ElementHost1.Text = "ElementHost1"
		Me.ElementHost1.Child = Me.mapControl
		'
		'btnSettings
		'
		Me.btnSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnSettings.Location = New System.Drawing.Point(148, 522)
		Me.btnSettings.Name = "btnSettings"
		Me.btnSettings.Size = New System.Drawing.Size(90, 36)
		Me.btnSettings.TabIndex = 101
		Me.btnSettings.Text = "Settings"
		Me.btnSettings.UseVisualStyleBackColor = True
		'
		'DSData
		'
		Me.DSData.DataSetName = "DSData"
		Me.DSData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'TAData
		'
		Me.TAData.ClearBeforeFill = True
		'
		'cboMatemathicaMethod
		'
		Me.cboMatemathicaMethod.FormattingEnabled = True
		Me.cboMatemathicaMethod.Items.AddRange(New Object() {"Automatic", "Differential Evolution", "Nelder Mead", "Random Search", "Simulated Annealing"})
		Me.cboMatemathicaMethod.Location = New System.Drawing.Point(2, 434)
		Me.cboMatemathicaMethod.Name = "cboMatemathicaMethod"
		Me.cboMatemathicaMethod.Size = New System.Drawing.Size(264, 21)
		Me.cboMatemathicaMethod.TabIndex = 200
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(2, 414)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(102, 13)
		Me.Label1.TabIndex = 201
		Me.Label1.Text = "Optimization method"
		'
		'frmNegotiation
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(941, 570)
		Me.Controls.Add(Me.btnSettings)
		Me.Controls.Add(Me.btnNext)
		Me.Controls.Add(Me.btnPrev)
		Me.Controls.Add(Me.btnLoadData)
		Me.Controls.Add(Me.pnlMain)
		Me.Name = "frmNegotiation"
		Me.Text = "Spatial Decision Support System"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.DSParameters, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.DSLocations, System.ComponentModel.ISupportInitialize).EndInit
		Me.pnlMain.ResumeLayout(False)
		Me.SplitContainer.Panel1.ResumeLayout(False)
		Me.SplitContainer.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit
		Me.SplitContainer.ResumeLayout(False)
		Me.grbMisc.ResumeLayout(False)
		Me.DssPanel1.ResumeLayout(False)
		Me.DssPanel1.PerformLayout
		CType(Me.nudAgrw, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudLanw, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudIndw, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTpsx, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTpmz, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudAgrUFRO, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudEnvw, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudgwsp, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTotpla, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudIndUFRO, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudSocw, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTpbx, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudEcow, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudsmqi, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudLanUFRO, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudsbqi, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudLanUF, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudssqi, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudAgrUF, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudIndUF, System.ComponentModel.ISupportInitialize).EndInit
		Me.grbWaterCosts.ResumeLayout(False)
		Me.grbWaterCosts.PerformLayout
		Me.pnlGro.ResumeLayout(False)
		CType(Me.nudGro14, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudGro15, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudGro3, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudGro7, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudGro2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudGro12, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudGro10, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudGro13, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudGro6, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudGro8, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudGro1, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudGro4, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudGro9, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudGro11, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudGro5, System.ComponentModel.ISupportInitialize).EndInit
		Me.pnlDes.ResumeLayout(False)
		CType(Me.nudDes14, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudDes15, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudDes3, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudDes7, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudDes2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudDes6, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudDes12, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudDes1, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudDes9, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudDes13, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudDes10, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudDes11, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudDes8, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudDes5, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudDes4, System.ComponentModel.ISupportInitialize).EndInit
		Me.grbOuput.ResumeLayout(False)
		Me.tcoOutput.ResumeLayout(False)
		Me.tpaUses.ResumeLayout(False)
		Me.gboOutputUses.ResumeLayout(False)
		Me.gboOutputUses.PerformLayout
		Me.pnlOutAgrSmall.ResumeLayout(False)
		Me.pnlOutIndLarge.ResumeLayout(False)
		Me.pnlOutLanSmall.ResumeLayout(False)
		Me.pnlOutLanLarge.ResumeLayout(False)
		Me.pnlOutAgrLarge.ResumeLayout(False)
		Me.tpaImpacts.ResumeLayout(False)
		Me.gboOutputImpacts.ResumeLayout(False)
		Me.gboOutputImpacts.PerformLayout
		Me.pnlOutSocSmall.ResumeLayout(False)
		Me.pnlOutEnvLarge.ResumeLayout(False)
		Me.pnlOutEnvSmall.ResumeLayout(False)
		Me.pnlOutEcoLarge.ResumeLayout(False)
		Me.pnlOutSocLarge.ResumeLayout(False)
		Me.pnlOutEcoSmall.ResumeLayout(False)
		Me.tpaWeights.ResumeLayout(False)
		CType(Me.pboGraphWeights, System.ComponentModel.ISupportInitialize).EndInit
		Me.tpaStandards.ResumeLayout(False)
		CType(Me.pboGraphStandards, System.ComponentModel.ISupportInitialize).EndInit
		Me.tpaEfficencies.ResumeLayout(False)
		CType(Me.pboGraphEfficiencies, System.ComponentModel.ISupportInitialize).EndInit
		Me.grbPopulation.ResumeLayout(False)
		Me.grbPopulation.PerformLayout
		Me.pnlPop20_2.ResumeLayout(False)
		CType(Me.nudPop20_14_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_15_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_3_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_7_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_2_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_12_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_10_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_13_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_6_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_8_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_1_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_4_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_9_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_11_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_5_2, System.ComponentModel.ISupportInitialize).EndInit
		Me.pnlPop20_1.ResumeLayout(False)
		CType(Me.nudPop20_14_1, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_15_1, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_3_1, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_7_1, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_2_1, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_6_1, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_12_1, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_1_1, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_9_1, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_13_1, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_10_1, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_11_1, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_8_1, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_5_1, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPop20_4_1, System.ComponentModel.ISupportInitialize).EndInit
		Me.grbIndustrialDistricts.ResumeLayout(False)
		Me.grbIndustrialDistricts.PerformLayout
		Me.pnlInddispln.ResumeLayout(False)
		CType(Me.nudInddispln14_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddispln15_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddispln3_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddispln7_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddispln2_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddispln12_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddispln10_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddispln13_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddispln6_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddispln8_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddispln1_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddispln4_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddispln9_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddispln11_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddispln5_2, System.ComponentModel.ISupportInitialize).EndInit
		Me.pnlInddiscur.ResumeLayout(False)
		CType(Me.nudInddiscur14_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddiscur15_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddiscur3_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddiscur7_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddiscur2_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddiscur6_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddiscur12_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddiscur1_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddiscur9_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddiscur13_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddiscur10_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddiscur11_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddiscur8_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddiscur5_2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudInddiscur4_2, System.ComponentModel.ISupportInitialize).EndInit
		Me.grbWaterQuality.ResumeLayout(False)
		Me.grbWaterQuality.PerformLayout
		Me.pnlTSS.ResumeLayout(False)
		CType(Me.nudTSS14, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTSS15, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTSS3, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTSS2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTSS7, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTSS10, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTSS12, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTSS6, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTSS13, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTSS1, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTSS8, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTSS9, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTSS4, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTSS5, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTSS11, System.ComponentModel.ISupportInitialize).EndInit
		Me.pnlTDS.ResumeLayout(False)
		CType(Me.nudTDS14, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTDS15, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTDS3, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTDS2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTDS7, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTDS10, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTDS6, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTDS12, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTDS1, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTDS9, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTDS13, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTDS5, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTDS11, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTDS8, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudTDS4, System.ComponentModel.ISupportInitialize).EndInit
		Me.pnlBOD.ResumeLayout(False)
		CType(Me.nudBOD14, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudBOD15, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudBOD3, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudBOD2, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudBOD7, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudBOD6, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudBOD1, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudBOD9, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudBOD12, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudBOD10, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudBOD11, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudBOD5, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudBOD13, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudBOD4, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudBOD8, System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.DSData, System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents nudDes1 As DSSNumericUpDown
	Friend WithEvents nudDes2 As DSSNumericUpDown
	Friend WithEvents nudDes3 As DSSNumericUpDown
	Friend WithEvents grbMisc As DSSGroupBox
	Friend WithEvents grbWaterQuality As DSSGroupBox
	Friend WithEvents grbPopulation As DSSGroupBox
	Friend WithEvents grbIndustrialDistricts As DSSGroupBox
	Friend WithEvents grbWaterCosts As DSSGroupBox
	Friend WithEvents grbOuput As DSSGroupBox
	Friend WithEvents btnNext As System.Windows.Forms.Button
	Friend WithEvents btnPrev As System.Windows.Forms.Button
	Friend WithEvents DatIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTmaxagrwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTminagrwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTindwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTminenewatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTmaxintwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTpopDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTwatperDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTpopwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTevaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTretDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatImaxagrwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIminagrwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIindwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatImarwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatInavwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIpopDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIwatperDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIpopwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatStotwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatOwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTbDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTgDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTfDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTmaxpolintcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIbDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTmarwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTnshDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTsidpayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatInshDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIsidpayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTagrwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTnbDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF5DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF6DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF8DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF9DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF10DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF11DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF12DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF13DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF14DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF15DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF16DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF17DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF18DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIequthrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTequthrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatInshthrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTnshthrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTequDifPerF3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTequDifPerF7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTequDifPerF11DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTequDifPerF15DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTnshDifPerF3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTnshDifPerF7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTnshDifPerF11DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTnshDifPerF15DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIequDifPerF4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIequDifPerF8DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIequDifPerF12DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIequDifPerF16DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatInshDifPerF4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatInshDifPerF8DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatInshDifPerF12DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatInshDifPerF16DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTurkishAgreementDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents DatIraqiAgreementDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents DataCreazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents UtenteCreazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataAggiornamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents UtenteAggiornamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents AnnullatoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents DataEstrazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DSParameters As DSParameters
	Friend WithEvents TAParameters As DSDSS.DSParametersTableAdapters.parametersTableAdapter
	Friend WithEvents nudDes7 As DSSNumericUpDown
	Friend WithEvents nudGro13 As DSSNumericUpDown
	Friend WithEvents nudDes8 As DSSNumericUpDown
	Friend WithEvents nudDes4 As DSSNumericUpDown
	Friend WithEvents nudDes5 As DSSNumericUpDown
	Friend WithEvents nudDes9 As DSSNumericUpDown
	Friend WithEvents nudDes6 As DSSNumericUpDown
	Friend WithEvents nudGro7 As DSSNumericUpDown
	Friend WithEvents nudGro12 As DSSNumericUpDown
	Friend WithEvents nudDes12 As DSSNumericUpDown
	Friend WithEvents nudDes13 As DSSNumericUpDown
	Friend WithEvents nudGro8 As DSSNumericUpDown
	Friend WithEvents nudGro4 As DSSNumericUpDown
	Friend WithEvents nudGro11 As DSSNumericUpDown
	Friend WithEvents nudGro5 As DSSNumericUpDown
	Friend WithEvents nudGro9 As DSSNumericUpDown
	Friend WithEvents nudGro1 As DSSNumericUpDown
	Friend WithEvents nudGro6 As DSSNumericUpDown
	Friend WithEvents nudGro10 As DSSNumericUpDown
	Friend WithEvents nudGro2 As DSSNumericUpDown
	Friend WithEvents nudGro3 As DSSNumericUpDown
	Friend WithEvents DSData As DSData
	Friend WithEvents Label121 As System.Windows.Forms.Label
	Friend WithEvents Label120 As System.Windows.Forms.Label
	Friend WithEvents nudDes11 As DSSNumericUpDown
	Friend WithEvents nudDes10 As DSSNumericUpDown
	Friend WithEvents btnLoadData As System.Windows.Forms.Button
	Friend WithEvents SqlConnection As System.Data.SqlClient.SqlConnection
	Friend WithEvents ElementHost1 As System.Windows.Forms.Integration.ElementHost
	Friend mapControl As mapControl.mapControl
	Friend WithEvents DALocations As System.Data.SqlClient.SqlDataAdapter
	Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
	Friend WithEvents DSLocations As DSDSS.DSLocations
	Friend WithEvents pnlMain As System.Windows.Forms.Panel
	Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
	Friend WithEvents nudTSS7 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTDS7 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudBOD7 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTSS12 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTDS12 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudBOD12 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTSS13 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTDS13 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudBOD13 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTSS8 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTDS8 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudBOD8 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTSS4 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTDS4 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudBOD4 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTSS11 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTDS11 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTSS5 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTDS5 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudBOD5 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudBOD11 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudBOD10 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudBOD9 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTSS9 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTDS9 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTSS1 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTSS6 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTDS1 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTSS10 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTDS6 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTDS10 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTSS2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudBOD1 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTDS2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTSS3 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudBOD6 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTDS3 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudBOD2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudBOD3 As DSDSS.DSSNumericUpDown
	Friend WithEvents Label21 As System.Windows.Forms.Label
	Friend WithEvents Label19 As System.Windows.Forms.Label
	Friend WithEvents Label20 As System.Windows.Forms.Label
	Friend WithEvents nudPop20_7_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_7_1 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_12_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_12_1 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_13_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_13_1 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_8_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_8_1 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_4_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_4_1 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_11_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_5_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_5_1 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_11_1 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_10_1 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_9_1 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_9_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_1_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_6_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_10_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_1_1 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_2_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_6_1 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_3_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_2_1 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_3_1 As DSDSS.DSSNumericUpDown
	Friend WithEvents lblTot20_2 As System.Windows.Forms.Label
	Friend WithEvents Label69 As System.Windows.Forms.Label
	Friend WithEvents lblTot20_1 As System.Windows.Forms.Label
	Friend WithEvents nudInddispln7_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur7_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln12_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur12_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln13_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur13_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln8_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur8_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln4_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur4_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln11_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln5_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur5_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur11_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur10_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur9_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln9_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln1_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln6_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln10_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur1_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln2_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur6_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln3_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur2_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur3_2 As DSDSS.DSSNumericUpDown
	Friend WithEvents Label86 As System.Windows.Forms.Label
	Friend WithEvents Label88 As System.Windows.Forms.Label
	Friend WithEvents lblTDS As DSSLabel
	Friend WithEvents nudSocw As DSDSS.DSSNumericUpDown
	Friend WithEvents nudEcow As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTpbx As DSDSS.DSSNumericUpDown
	Friend WithEvents nudEnvw As DSDSS.DSSNumericUpDown
	Friend WithEvents nudTpsx As DSDSS.DSSNumericUpDown
	Friend WithEvents Label25 As System.Windows.Forms.Label
	Friend WithEvents Label34 As System.Windows.Forms.Label
	Friend WithEvents Label78 As System.Windows.Forms.Label
	Friend WithEvents Label91 As System.Windows.Forms.Label
	Friend WithEvents lblBOD As DSSLabel
	Friend WithEvents Label68 As System.Windows.Forms.Label
	Friend WithEvents Label64 As System.Windows.Forms.Label
	Friend WithEvents Label92 As System.Windows.Forms.Label
	Friend WithEvents Label70 As System.Windows.Forms.Label
	Friend WithEvents nudTpmz As DSDSS.DSSNumericUpDown
	Friend WithEvents Label13 As System.Windows.Forms.Label
	Friend WithEvents nudTotpla As DSDSS.DSSNumericUpDown
	Friend WithEvents Label23 As System.Windows.Forms.Label
	Friend WithEvents Label26 As System.Windows.Forms.Label
	Friend WithEvents Label24 As System.Windows.Forms.Label
	Friend WithEvents nudLanUF As DSDSS.DSSNumericUpDown
	Friend WithEvents nudIndUF As DSDSS.DSSNumericUpDown
	Friend WithEvents nudAgrUF As DSDSS.DSSNumericUpDown
	Friend WithEvents nudLanUFRO As DSDSS.DSSNumericUpDown
	Friend WithEvents nudIndUFRO As DSDSS.DSSNumericUpDown
	Friend WithEvents nudAgrUFRO As DSDSS.DSSNumericUpDown
	Friend WithEvents Label12 As System.Windows.Forms.Label
	Friend WithEvents Label10 As System.Windows.Forms.Label
	Friend WithEvents Label30 As System.Windows.Forms.Label
	Friend WithEvents Label29 As System.Windows.Forms.Label
	Friend WithEvents nudgwsp As DSDSS.DSSNumericUpDown
	Friend WithEvents Label27 As System.Windows.Forms.Label
	Friend WithEvents Label28 As System.Windows.Forms.Label
	Friend WithEvents pnlGro As DSDSS.DSSPanel
	Friend WithEvents pnlDes As DSDSS.DSSPanel
	Friend WithEvents pnlInddispln As DSDSS.DSSPanel
	Friend WithEvents pnlInddiscur As DSDSS.DSSPanel
	Friend WithEvents pnlTSS As DSDSS.DSSPanel
	Friend WithEvents pnlTDS As DSDSS.DSSPanel
	Friend WithEvents pnlBOD As DSDSS.DSSPanel
	Friend WithEvents pnlPop20_2 As DSDSS.DSSPanel
	Friend WithEvents pnlPop20_1 As DSDSS.DSSPanel
	Friend WithEvents DssPanel1 As DSDSS.DSSPanel
	Friend WithEvents tcoOutput As System.Windows.Forms.TabControl
	Friend WithEvents tpaUses As System.Windows.Forms.TabPage
	Friend WithEvents tpaImpacts As System.Windows.Forms.TabPage
	Friend WithEvents tpaWeights As System.Windows.Forms.TabPage
	Friend WithEvents tpaStandards As System.Windows.Forms.TabPage
	Friend WithEvents tpaEfficencies As System.Windows.Forms.TabPage
	Friend WithEvents Label135 As System.Windows.Forms.Label
	Friend WithEvents Label133 As System.Windows.Forms.Label
	Friend WithEvents lblLan13_1 As DSSLabel
	Friend WithEvents lblAgr13_1 As DSSLabel
	Friend WithEvents lblLan10_1 As DSSLabel
	Friend WithEvents lblAgr10_1 As DSSLabel
	Friend WithEvents lblLan7_1 As DSSLabel
	Friend WithEvents lblAgr7_1 As DSSLabel
	Friend WithEvents lblLan3_1 As DSSLabel
	Friend WithEvents lblAgr3_1 As DSSLabel
	Friend WithEvents lblLan12_1 As DSSLabel
	Friend WithEvents lblAgr12_1 As DSSLabel
	Friend WithEvents lblLan9_1 As DSSLabel
	Friend WithEvents lblAgr9_1 As DSSLabel
	Friend WithEvents lblLan6_1 As DSSLabel
	Friend WithEvents lblAgr6_1 As DSSLabel
	Friend WithEvents lblLan2_1 As DSSLabel
	Friend WithEvents lblAgr2_1 As DSSLabel
	Friend WithEvents lblLan11_1 As DSSLabel
	Friend WithEvents lblAgr11_1 As DSSLabel
	Friend WithEvents lblLan8_1 As DSSLabel
	Friend WithEvents lblAgr8_1 As DSSLabel
	Friend WithEvents lblLan4_1 As DSSLabel
	Friend WithEvents lblAgr4_1 As DSSLabel
	Friend WithEvents lblLan5_1 As DSSLabel
	Friend WithEvents lblAgr5_1 As DSSLabel
	Friend WithEvents lblLan1_1 As DSSLabel
	Friend WithEvents lblAgr1_1 As DSSLabel
	Friend WithEvents lblEnv13_1 As DSSLabel
	Friend WithEvents lblSoc13_1 As DSSLabel
	Friend WithEvents lblEco13_1 As DSSLabel
	Friend WithEvents lblEnv10_1 As DSSLabel
	Friend WithEvents lblSoc10_1 As DSSLabel
	Friend WithEvents lblEco10_1 As DSSLabel
	Friend WithEvents lblEnv7_1 As DSSLabel
	Friend WithEvents lblSoc7_1 As DSSLabel
	Friend WithEvents lblEco7_1 As DSSLabel
	Friend WithEvents lblEnv3_1 As DSSLabel
	Friend WithEvents lblSoc3_1 As DSSLabel
	Friend WithEvents lblEco3_1 As DSSLabel
	Friend WithEvents lblEnv12_1 As DSSLabel
	Friend WithEvents lblSoc12_1 As DSSLabel
	Friend WithEvents lblEco12_1 As DSSLabel
	Friend WithEvents lblEnv9_1 As DSSLabel
	Friend WithEvents lblSoc9_1 As DSSLabel
	Friend WithEvents lblEco9_1 As DSSLabel
	Friend WithEvents lblEnv6_1 As DSSLabel
	Friend WithEvents lblSoc6_1 As DSSLabel
	Friend WithEvents lblEco6_1 As DSSLabel
	Friend WithEvents lblEnv2_1 As DSSLabel
	Friend WithEvents lblSoc2_1 As DSSLabel
	Friend WithEvents lblEco2_1 As DSSLabel
	Friend WithEvents lblEnv11_1 As DSSLabel
	Friend WithEvents lblSoc11_1 As DSSLabel
	Friend WithEvents lblEco11_1 As DSSLabel
	Friend WithEvents lblEnv8_1 As DSSLabel
	Friend WithEvents lblSoc8_1 As DSSLabel
	Friend WithEvents lblEco8_1 As DSSLabel
	Friend WithEvents lblEnv4_1 As DSSLabel
	Friend WithEvents lblSoc4_1 As DSSLabel
	Friend WithEvents lblEco4_1 As DSSLabel
	Friend WithEvents lblEnv5_1 As DSSLabel
	Friend WithEvents lblSoc5_1 As DSSLabel
	Friend WithEvents lblEco5_1 As DSSLabel
	Friend WithEvents lblEnv1_1 As DSSLabel
	Friend WithEvents lblSoc1_1 As DSSLabel
	Friend WithEvents lblEco1_1 As DSSLabel
	Friend WithEvents Label178 As System.Windows.Forms.Label
	Friend WithEvents Label179 As System.Windows.Forms.Label
	Friend WithEvents Label180 As System.Windows.Forms.Label
	Friend WithEvents Label116 As System.Windows.Forms.Label
	Friend WithEvents nudsmqi As DSDSS.DSSNumericUpDown
	Friend WithEvents nudsbqi As DSDSS.DSSNumericUpDown
	Friend WithEvents nudssqi As DSDSS.DSSNumericUpDown
	Friend WithEvents Label119 As System.Windows.Forms.Label
	Friend WithEvents Label118 As System.Windows.Forms.Label
	Friend WithEvents Label117 As System.Windows.Forms.Label
	Friend WithEvents Label94 As Label
	Friend WithEvents Label93 As Label
	Friend WithEvents lblLan13_2 As DSSLabel
	Friend WithEvents lblInd13_2 As DSSLabel
	Friend WithEvents lblAgr13_2 As DSSLabel
	Friend WithEvents lblLan10_2 As DSSLabel
	Friend WithEvents lblInd10_2 As DSSLabel
	Friend WithEvents lblAgr10_2 As DSSLabel
	Friend WithEvents lblLan7_2 As DSSLabel
	Friend WithEvents lblInd7_2 As DSSLabel
	Friend WithEvents lblAgr7_2 As DSSLabel
	Friend WithEvents lblLan3_2 As DSSLabel
	Friend WithEvents lblInd3_2 As DSSLabel
	Friend WithEvents lblAgr3_2 As DSSLabel
	Friend WithEvents lblLan12_2 As DSSLabel
	Friend WithEvents lblInd12_2 As DSSLabel
	Friend WithEvents lblAgr12_2 As DSSLabel
	Friend WithEvents lblLan9_2 As DSSLabel
	Friend WithEvents lblInd9_2 As DSSLabel
	Friend WithEvents lblAgr9_2 As DSSLabel
	Friend WithEvents lblLan6_2 As DSSLabel
	Friend WithEvents lblInd6_2 As DSSLabel
	Friend WithEvents lblAgr6_2 As DSSLabel
	Friend WithEvents lblLan2_2 As DSSLabel
	Friend WithEvents lblInd2_2 As DSSLabel
	Friend WithEvents lblAgr2_2 As DSSLabel
	Friend WithEvents lblLan11_2 As DSSLabel
	Friend WithEvents lblInd11_2 As DSSLabel
	Friend WithEvents lblAgr11_2 As DSSLabel
	Friend WithEvents lblLan8_2 As DSSLabel
	Friend WithEvents lblInd8_2 As DSSLabel
	Friend WithEvents lblAgr8_2 As DSSLabel
	Friend WithEvents lblLan4_2 As DSSLabel
	Friend WithEvents lblInd4_2 As DSSLabel
	Friend WithEvents lblAgr4_2 As DSSLabel
	Friend WithEvents lblLan5_2 As DSSLabel
	Friend WithEvents lblInd5_2 As DSSLabel
	Friend WithEvents lblAgr5_2 As DSSLabel
	Friend WithEvents lblLan1_2 As DSSLabel
	Friend WithEvents lblInd1_2 As DSSLabel
	Friend WithEvents lblAgr1_2 As DSSLabel
	Friend WithEvents Label87 As Label
	Friend WithEvents Label89 As Label
	Friend WithEvents Label90 As Label
	Friend WithEvents Label98 As Label
	Friend WithEvents Label99 As Label
	Friend WithEvents lblEnv13_2 As DSSLabel
	Friend WithEvents lblSoc13_2 As DSSLabel
	Friend WithEvents lblEco13_2 As DSSLabel
	Friend WithEvents lblEnv10_2 As DSSLabel
	Friend WithEvents lblSoc10_2 As DSSLabel
	Friend WithEvents lblEco10_2 As DSSLabel
	Friend WithEvents lblEnv7_2 As DSSLabel
	Friend WithEvents lblSoc7_2 As DSSLabel
	Friend WithEvents lblEco7_2 As DSSLabel
	Friend WithEvents lblEnv3_2 As DSSLabel
	Friend WithEvents lblSoc3_2 As DSSLabel
	Friend WithEvents lblEco3_2 As DSSLabel
	Friend WithEvents lblEnv12_2 As DSSLabel
	Friend WithEvents lblSoc12_2 As DSSLabel
	Friend WithEvents lblEco12_2 As DSSLabel
	Friend WithEvents lblEnv9_2 As DSSLabel
	Friend WithEvents lblSoc9_2 As DSSLabel
	Friend WithEvents lblEco9_2 As DSSLabel
	Friend WithEvents lblEnv6_2 As DSSLabel
	Friend WithEvents lblSoc6_2 As DSSLabel
	Friend WithEvents lblEco6_2 As DSSLabel
	Friend WithEvents lblEnv2_2 As DSSLabel
	Friend WithEvents lblSoc2_2 As DSSLabel
	Friend WithEvents lblEco2_2 As DSSLabel
	Friend WithEvents lblEnv11_2 As DSSLabel
	Friend WithEvents lblSoc11_2 As DSSLabel
	Friend WithEvents lblEco11_2 As DSSLabel
	Friend WithEvents lblEnv8_2 As DSSLabel
	Friend WithEvents lblSoc8_2 As DSSLabel
	Friend WithEvents lblEco8_2 As DSSLabel
	Friend WithEvents lblEnv4_2 As DSSLabel
	Friend WithEvents lblSoc4_2 As DSSLabel
	Friend WithEvents lblEco4_2 As DSSLabel
	Friend WithEvents lblEnv5_2 As DSSLabel
	Friend WithEvents lblSoc5_2 As DSSLabel
	Friend WithEvents lblEco5_2 As DSSLabel
	Friend WithEvents lblEnv1_2 As DSSLabel
	Friend WithEvents lblSoc1_2 As DSSLabel
	Friend WithEvents lblEco1_2 As DSSLabel
	Friend WithEvents Label95 As Label
	Friend WithEvents Label96 As Label
	Friend WithEvents Label97 As Label
	Friend WithEvents pboGraphWeights As PictureBox
	Friend WithEvents pboGraphStandards As PictureBox
	Friend WithEvents pboGraphEfficiencies As PictureBox
	Friend WithEvents pnlOutAgrSmall As DSSPanel
	Friend WithEvents pnlOutIndLarge As DSSPanel
	Friend WithEvents pnlOutLanLarge As DSSPanel
	Friend WithEvents pnlOutAgrLarge As DSSPanel
	Friend WithEvents pnlOutLanSmall As DSSPanel
	Friend WithEvents DssPanel7 As DSSPanel
	Friend WithEvents gboOutputUses As DSSGroupBox
	Friend WithEvents gboOutputImpacts As DSSGroupBox
	Friend WithEvents pnlOutSocSmall As DSSPanel
	Friend WithEvents pnlOutEnvLarge As DSSPanel
	Friend WithEvents pnlOutEnvSmall As DSSPanel
	Friend WithEvents pnlOutEcoLarge As DSSPanel
	Friend WithEvents pnlOutSocLarge As DSSPanel
	Friend WithEvents pnlOutEcoSmall As DSSPanel
	Friend WithEvents lblEnvGini2 As DSSLabel
	Friend WithEvents lblEnvMean2 As DSSLabel
	Friend WithEvents lblSocGini2 As DSSLabel
	Friend WithEvents lblSocMean2 As DSSLabel
	Friend WithEvents lblEcoGini2 As DSSLabel
	Friend WithEvents lblEcoMean2 As DSSLabel
	Friend WithEvents lblEnvGini1 As DSSLabel
	Friend WithEvents lblEnvMean1 As DSSLabel
	Friend WithEvents lblSocGini1 As DSSLabel
	Friend WithEvents lblSocMean1 As DSSLabel
	Friend WithEvents lblEcoGini1 As DSSLabel
	Friend WithEvents lblEcoMean1 As DSSLabel
	Friend WithEvents Label101 As Label
	Friend WithEvents Label100 As Label
	Friend WithEvents btnSettings As Button
	Friend WithEvents lblAgr15_1 As DSSLabel
	Friend WithEvents lblAgr14_1 As DSSLabel
	Friend WithEvents lblInd15_2 As DSSLabel
	Friend WithEvents lblInd14_2 As DSSLabel
	Friend WithEvents lblLan14_1 As DSSLabel
	Friend WithEvents lblLan15_1 As DSSLabel
	Friend WithEvents lblLan15_2 As DSSLabel
	Friend WithEvents lblLan14_2 As DSSLabel
	Friend WithEvents lblAgr14_2 As DSSLabel
	Friend WithEvents lblAgr15_2 As DSSLabel
	Friend WithEvents nudBOD14 As DSSNumericUpDown
	Friend WithEvents nudBOD15 As DSSNumericUpDown
	Friend WithEvents lblSoc14_1 As DSSLabel
	Friend WithEvents lblSoc15_1 As DSSLabel
	Friend WithEvents lblEnv14_2 As DSSLabel
	Friend WithEvents lblEnv15_2 As DSSLabel
	Friend WithEvents lblEnv14_1 As DSSLabel
	Friend WithEvents lblEnv15_1 As DSSLabel
	Friend WithEvents lblEco14_2 As DSSLabel
	Friend WithEvents lblEco15_2 As DSSLabel
	Friend WithEvents lblSoc14_2 As DSSLabel
	Friend WithEvents lblSoc15_2 As DSSLabel
	Friend WithEvents lblEco14_1 As DSSLabel
	Friend WithEvents lblEco15_1 As DSSLabel
	Friend WithEvents nudPop20_14_2 As DSSNumericUpDown
	Friend WithEvents nudPop20_15_2 As DSSNumericUpDown
	Friend WithEvents nudPop20_14_1 As DSSNumericUpDown
	Friend WithEvents nudPop20_15_1 As DSSNumericUpDown
	Friend WithEvents nudInddispln14_2 As DSSNumericUpDown
	Friend WithEvents nudInddispln15_2 As DSSNumericUpDown
	Friend WithEvents nudInddiscur14_2 As DSSNumericUpDown
	Friend WithEvents nudInddiscur15_2 As DSSNumericUpDown
	Friend WithEvents nudTSS14 As DSSNumericUpDown
	Friend WithEvents nudTSS15 As DSSNumericUpDown
	Friend WithEvents nudTDS14 As DSSNumericUpDown
	Friend WithEvents nudTDS15 As DSSNumericUpDown
	Friend WithEvents nudGro14 As DSSNumericUpDown
	Friend WithEvents nudGro15 As DSSNumericUpDown
	Friend WithEvents nudDes14 As DSSNumericUpDown
	Friend WithEvents nudDes15 As DSSNumericUpDown
	Friend WithEvents lblWCLocation13 As DSSLabel
	Friend WithEvents lblWCLocation1 As DSSLabel
	Friend WithEvents lblWCLocation15 As DSSLabel
	Friend WithEvents lblWCLocation14 As DSSLabel
	Friend WithEvents lblWCLocation12 As DSSLabel
	Friend WithEvents lblWCLocation11 As DSSLabel
	Friend WithEvents lblWCLocation10 As DSSLabel
	Friend WithEvents lblWCLocation9 As DSSLabel
	Friend WithEvents lblWCLocation8 As DSSLabel
	Friend WithEvents lblWCLocation7 As DSSLabel
	Friend WithEvents lblWCLocation6 As DSSLabel
	Friend WithEvents lblWCLocation5 As DSSLabel
	Friend WithEvents lblWCLocation4 As DSSLabel
	Friend WithEvents lblWCLocation3 As DSSLabel
	Friend WithEvents lblWCLocation2 As DSSLabel
	Friend WithEvents lblTPLocation15 As DSSLabel
	Friend WithEvents lblTPLocation14 As DSSLabel
	Friend WithEvents lblTPLocation12 As DSSLabel
	Friend WithEvents lblTPLocation11 As DSSLabel
	Friend WithEvents lblTPLocation1 As DSSLabel
	Friend WithEvents lblTPLocation10 As DSSLabel
	Friend WithEvents lblTPLocation13 As DSSLabel
	Friend WithEvents lblTPLocation9 As DSSLabel
	Friend WithEvents lblTPLocation2 As DSSLabel
	Friend WithEvents lblTPLocation8 As DSSLabel
	Friend WithEvents lblTPLocation3 As DSSLabel
	Friend WithEvents lblTPLocation7 As DSSLabel
	Friend WithEvents lblTPLocation4 As DSSLabel
	Friend WithEvents lblTPLocation6 As DSSLabel
	Friend WithEvents lblTPLocation5 As DSSLabel
	Friend WithEvents lblIDLocation15 As DSSLabel
	Friend WithEvents lblIDLocation14 As DSSLabel
	Friend WithEvents lblIDLocation12 As DSSLabel
	Friend WithEvents lblIDLocation1 As DSSLabel
	Friend WithEvents lblIDLocation11 As DSSLabel
	Friend WithEvents lblIDLocation5 As DSSLabel
	Friend WithEvents lblIDLocation6 As DSSLabel
	Friend WithEvents lblIDLocation10 As DSSLabel
	Friend WithEvents lblIDLocation4 As DSSLabel
	Friend WithEvents lblIDLocation13 As DSSLabel
	Friend WithEvents lblIDLocation7 As DSSLabel
	Friend WithEvents lblIDLocation9 As DSSLabel
	Friend WithEvents lblIDLocation3 As DSSLabel
	Friend WithEvents lblIDLocation2 As DSSLabel
	Friend WithEvents lblIDLocation8 As DSSLabel
	Friend WithEvents lblWQLocation15 As DSSLabel
	Friend WithEvents lblWQLocation14 As DSSLabel
	Friend WithEvents lblWQLocation12 As DSSLabel
	Friend WithEvents lblWQLocation1 As DSSLabel
	Friend WithEvents lblWQLocation11 As DSSLabel
	Friend WithEvents lblWQLocation5 As DSSLabel
	Friend WithEvents lblWQLocation6 As DSSLabel
	Friend WithEvents lblWQLocation10 As DSSLabel
	Friend WithEvents lblWQLocation4 As DSSLabel
	Friend WithEvents lblWQLocation13 As DSSLabel
	Friend WithEvents lblWQLocation7 As DSSLabel
	Friend WithEvents lblWQLocation9 As DSSLabel
	Friend WithEvents lblWQLocation3 As DSSLabel
	Friend WithEvents lblWQLocation2 As DSSLabel
	Friend WithEvents lblWQLocation8 As DSSLabel
	Friend WithEvents lblUSLocation15 As DSSLabel
	Friend WithEvents lblUSLocation14 As DSSLabel
	Friend WithEvents lblUSLocation12 As DSSLabel
	Friend WithEvents lblUSLocation1 As DSSLabel
	Friend WithEvents lblUSLocation11 As DSSLabel
	Friend WithEvents lblUSLocation5 As DSSLabel
	Friend WithEvents lblUSLocation6 As DSSLabel
	Friend WithEvents lblUSLocation10 As DSSLabel
	Friend WithEvents lblUSLocation4 As DSSLabel
	Friend WithEvents lblUSLocation13 As DSSLabel
	Friend WithEvents lblUSLocation7 As DSSLabel
	Friend WithEvents lblUSLocation9 As DSSLabel
	Friend WithEvents lblUSLocation3 As DSSLabel
	Friend WithEvents lblUSLocation2 As DSSLabel
	Friend WithEvents lblUSLocation8 As DSSLabel
	Friend WithEvents lblIMLocation15 As DSSLabel
	Friend WithEvents lblIMLocation14 As DSSLabel
	Friend WithEvents lblIMLocation12 As DSSLabel
	Friend WithEvents lblIMLocation1 As DSSLabel
	Friend WithEvents lblIMLocation11 As DSSLabel
	Friend WithEvents lblIMLocation5 As DSSLabel
	Friend WithEvents lblIMLocation6 As DSSLabel
	Friend WithEvents lblIMLocation10 As DSSLabel
	Friend WithEvents lblIMLocation4 As DSSLabel
	Friend WithEvents lblIMLocation13 As DSSLabel
	Friend WithEvents lblIMLocation7 As DSSLabel
	Friend WithEvents lblIMLocation9 As DSSLabel
	Friend WithEvents lblIMLocation3 As DSSLabel
	Friend WithEvents lblIMLocation2 As DSSLabel
	Friend WithEvents lblIMLocation8 As DSSLabel
	Friend WithEvents chkSalt As CheckBox
	Friend WithEvents Agr As Label
	Friend WithEvents Lan As Label
	Friend WithEvents Ind As Label
	Friend WithEvents nudAgrw As DSSNumericUpDown
	Friend WithEvents nudLanw As DSSNumericUpDown
	Friend WithEvents nudIndw As DSSNumericUpDown
	Friend WithEvents TAData As DSDataTableAdapters.dataTableAdapter
	Friend WithEvents Label1 As Label
	Friend WithEvents cboMatemathicaMethod As ComboBox
End Class
