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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNegotiation))
		Me.daData = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlDeleteCommand = New System.Data.SqlClient.SqlCommand()
		Me.SqlConnection = New System.Data.SqlClient.SqlConnection()
		Me.SqlInsertCommand = New System.Data.SqlClient.SqlCommand()
		Me.SqlSelectCommand = New System.Data.SqlClient.SqlCommand()
		Me.SqlUpdateCommand = New System.Data.SqlClient.SqlCommand()
		Me.btnNext = New System.Windows.Forms.Button()
		Me.btnPrev = New System.Windows.Forms.Button()
		Me.btnLoadData = New System.Windows.Forms.Button()
		Me.dsParameters = New SDSS.parameters()
		Me.TAParameters = New SDSS.parametersTableAdapters.parametersTableAdapter()
		Me.DSData = New SDSS.DSData()
		Me.daLocations = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
		Me.DSLocations = New SDSS.DSLocations()
		Me.pnlMain = New System.Windows.Forms.Panel()
		Me.SplitContainer = New System.Windows.Forms.SplitContainer()
		Me.grbOuput = New SDSS.DSSGroupBox()
		Me.tcoOutput = New System.Windows.Forms.TabControl()
		Me.tpaImpacts = New System.Windows.Forms.TabPage()
		Me.gboOutputImpacts = New SDSS.DSSGroupBox()
		Me.lblEnvGini2 = New SDSS.DSSLabel()
		Me.lblEnvMean2 = New SDSS.DSSLabel()
		Me.lblSocGini2 = New SDSS.DSSLabel()
		Me.lblSocMean2 = New SDSS.DSSLabel()
		Me.lblEcoGini2 = New SDSS.DSSLabel()
		Me.lblEcoMean2 = New SDSS.DSSLabel()
		Me.lblEnvGini1 = New SDSS.DSSLabel()
		Me.lblEnvMean1 = New SDSS.DSSLabel()
		Me.lblSocGini1 = New SDSS.DSSLabel()
		Me.lblSocMean1 = New SDSS.DSSLabel()
		Me.lblEcoGini1 = New SDSS.DSSLabel()
		Me.lblEcoMean1 = New SDSS.DSSLabel()
		Me.Label101 = New System.Windows.Forms.Label()
		Me.Label100 = New System.Windows.Forms.Label()
		Me.pnlOutSocSmall = New SDSS.DSSPanel()
		Me.lblSoc1_1 = New SDSS.DSSLabel()
		Me.lblSoc5_1 = New SDSS.DSSLabel()
		Me.lblSoc4_1 = New SDSS.DSSLabel()
		Me.lblSoc8_1 = New SDSS.DSSLabel()
		Me.lblSoc11_1 = New SDSS.DSSLabel()
		Me.lblSoc2_1 = New SDSS.DSSLabel()
		Me.lblSoc6_1 = New SDSS.DSSLabel()
		Me.lblSoc9_1 = New SDSS.DSSLabel()
		Me.lblSoc12_1 = New SDSS.DSSLabel()
		Me.lblSoc3_1 = New SDSS.DSSLabel()
		Me.lblSoc7_1 = New SDSS.DSSLabel()
		Me.lblSoc10_1 = New SDSS.DSSLabel()
		Me.lblSoc13_1 = New SDSS.DSSLabel()
		Me.DssPanel7 = New SDSS.DSSPanel()
		Me.pnlOutEnvLarge = New SDSS.DSSPanel()
		Me.lblEnv1_2 = New SDSS.DSSLabel()
		Me.lblEnv5_2 = New SDSS.DSSLabel()
		Me.lblEnv4_2 = New SDSS.DSSLabel()
		Me.lblEnv8_2 = New SDSS.DSSLabel()
		Me.lblEnv11_2 = New SDSS.DSSLabel()
		Me.lblEnv2_2 = New SDSS.DSSLabel()
		Me.lblEnv6_2 = New SDSS.DSSLabel()
		Me.lblEnv9_2 = New SDSS.DSSLabel()
		Me.lblEnv12_2 = New SDSS.DSSLabel()
		Me.lblEnv13_2 = New SDSS.DSSLabel()
		Me.lblEnv3_2 = New SDSS.DSSLabel()
		Me.lblEnv7_2 = New SDSS.DSSLabel()
		Me.lblEnv10_2 = New SDSS.DSSLabel()
		Me.pnlOutEnvSmall = New SDSS.DSSPanel()
		Me.lblEnv1_1 = New SDSS.DSSLabel()
		Me.lblEnv5_1 = New SDSS.DSSLabel()
		Me.lblEnv4_1 = New SDSS.DSSLabel()
		Me.lblEnv8_1 = New SDSS.DSSLabel()
		Me.lblEnv11_1 = New SDSS.DSSLabel()
		Me.lblEnv2_1 = New SDSS.DSSLabel()
		Me.lblEnv6_1 = New SDSS.DSSLabel()
		Me.lblEnv9_1 = New SDSS.DSSLabel()
		Me.lblEnv12_1 = New SDSS.DSSLabel()
		Me.lblEnv13_1 = New SDSS.DSSLabel()
		Me.lblEnv3_1 = New SDSS.DSSLabel()
		Me.lblEnv10_1 = New SDSS.DSSLabel()
		Me.lblEnv7_1 = New SDSS.DSSLabel()
		Me.pnlOutEcoLarge = New SDSS.DSSPanel()
		Me.lblEco1_2 = New SDSS.DSSLabel()
		Me.lblEco5_2 = New SDSS.DSSLabel()
		Me.lblEco4_2 = New SDSS.DSSLabel()
		Me.lblEco8_2 = New SDSS.DSSLabel()
		Me.lblEco11_2 = New SDSS.DSSLabel()
		Me.lblEco2_2 = New SDSS.DSSLabel()
		Me.lblEco6_2 = New SDSS.DSSLabel()
		Me.lblEco9_2 = New SDSS.DSSLabel()
		Me.lblEco12_2 = New SDSS.DSSLabel()
		Me.lblEco13_2 = New SDSS.DSSLabel()
		Me.lblEco3_2 = New SDSS.DSSLabel()
		Me.lblEco10_2 = New SDSS.DSSLabel()
		Me.lblEco7_2 = New SDSS.DSSLabel()
		Me.pnlOutSocLarge = New SDSS.DSSPanel()
		Me.lblSoc1_2 = New SDSS.DSSLabel()
		Me.lblSoc5_2 = New SDSS.DSSLabel()
		Me.lblSoc4_2 = New SDSS.DSSLabel()
		Me.lblSoc8_2 = New SDSS.DSSLabel()
		Me.lblSoc11_2 = New SDSS.DSSLabel()
		Me.lblSoc2_2 = New SDSS.DSSLabel()
		Me.lblSoc6_2 = New SDSS.DSSLabel()
		Me.lblSoc9_2 = New SDSS.DSSLabel()
		Me.lblSoc12_2 = New SDSS.DSSLabel()
		Me.lblSoc13_2 = New SDSS.DSSLabel()
		Me.lblSoc3_2 = New SDSS.DSSLabel()
		Me.lblSoc7_2 = New SDSS.DSSLabel()
		Me.lblSoc10_2 = New SDSS.DSSLabel()
		Me.pnlOutEcoSmall = New SDSS.DSSPanel()
		Me.lblEco1_1 = New SDSS.DSSLabel()
		Me.lblEco5_1 = New SDSS.DSSLabel()
		Me.lblEco4_1 = New SDSS.DSSLabel()
		Me.lblEco8_1 = New SDSS.DSSLabel()
		Me.lblEco11_1 = New SDSS.DSSLabel()
		Me.lblEco2_1 = New SDSS.DSSLabel()
		Me.lblEco6_1 = New SDSS.DSSLabel()
		Me.lblEco9_1 = New SDSS.DSSLabel()
		Me.lblEco12_1 = New SDSS.DSSLabel()
		Me.lblEco3_1 = New SDSS.DSSLabel()
		Me.lblEco7_1 = New SDSS.DSSLabel()
		Me.lblEco10_1 = New SDSS.DSSLabel()
		Me.lblEco13_1 = New SDSS.DSSLabel()
		Me.Label180 = New System.Windows.Forms.Label()
		Me.Label103 = New System.Windows.Forms.Label()
		Me.Label98 = New System.Windows.Forms.Label()
		Me.Label104 = New System.Windows.Forms.Label()
		Me.Label179 = New System.Windows.Forms.Label()
		Me.Label105 = New System.Windows.Forms.Label()
		Me.Label99 = New System.Windows.Forms.Label()
		Me.Label106 = New System.Windows.Forms.Label()
		Me.Label95 = New System.Windows.Forms.Label()
		Me.Label107 = New System.Windows.Forms.Label()
		Me.Label178 = New System.Windows.Forms.Label()
		Me.Label108 = New System.Windows.Forms.Label()
		Me.Label97 = New System.Windows.Forms.Label()
		Me.Label109 = New System.Windows.Forms.Label()
		Me.Label96 = New System.Windows.Forms.Label()
		Me.Label110 = New System.Windows.Forms.Label()
		Me.Label115 = New System.Windows.Forms.Label()
		Me.Label111 = New System.Windows.Forms.Label()
		Me.Label114 = New System.Windows.Forms.Label()
		Me.Label112 = New System.Windows.Forms.Label()
		Me.Label113 = New System.Windows.Forms.Label()
		Me.tpaWeights = New System.Windows.Forms.TabPage()
		Me.pboGraphWeights = New System.Windows.Forms.PictureBox()
		Me.tpaStandards = New System.Windows.Forms.TabPage()
		Me.pboGraphStandards = New System.Windows.Forms.PictureBox()
		Me.tpaEfficencies = New System.Windows.Forms.TabPage()
		Me.pboGraphEfficiencies = New System.Windows.Forms.PictureBox()
		Me.tpaUses = New System.Windows.Forms.TabPage()
		Me.gboOutputUses = New SDSS.DSSGroupBox()
		Me.pnlOutAgrSmall = New SDSS.DSSPanel()
		Me.lblAgr1_1 = New SDSS.DSSLabel()
		Me.lblAgr5_1 = New SDSS.DSSLabel()
		Me.lblAgr4_1 = New SDSS.DSSLabel()
		Me.lblAgr8_1 = New SDSS.DSSLabel()
		Me.lblAgr11_1 = New SDSS.DSSLabel()
		Me.lblAgr2_1 = New SDSS.DSSLabel()
		Me.lblAgr6_1 = New SDSS.DSSLabel()
		Me.lblAgr9_1 = New SDSS.DSSLabel()
		Me.lblAgr12_1 = New SDSS.DSSLabel()
		Me.lblAgr3_1 = New SDSS.DSSLabel()
		Me.lblAgr7_1 = New SDSS.DSSLabel()
		Me.lblAgr10_1 = New SDSS.DSSLabel()
		Me.lblAgr13_1 = New SDSS.DSSLabel()
		Me.Label94 = New System.Windows.Forms.Label()
		Me.pnlOutIndLarge = New SDSS.DSSPanel()
		Me.lblInd1_2 = New SDSS.DSSLabel()
		Me.lblInd5_2 = New SDSS.DSSLabel()
		Me.lblInd4_2 = New SDSS.DSSLabel()
		Me.lblInd8_2 = New SDSS.DSSLabel()
		Me.lblInd11_2 = New SDSS.DSSLabel()
		Me.lblInd2_2 = New SDSS.DSSLabel()
		Me.lblInd6_2 = New SDSS.DSSLabel()
		Me.lblInd9_2 = New SDSS.DSSLabel()
		Me.lblInd13_2 = New SDSS.DSSLabel()
		Me.lblInd12_2 = New SDSS.DSSLabel()
		Me.lblInd3_2 = New SDSS.DSSLabel()
		Me.lblInd10_2 = New SDSS.DSSLabel()
		Me.lblInd7_2 = New SDSS.DSSLabel()
		Me.Label93 = New System.Windows.Forms.Label()
		Me.Label87 = New System.Windows.Forms.Label()
		Me.pnlOutLanSmall = New SDSS.DSSPanel()
		Me.lblLan1_1 = New SDSS.DSSLabel()
		Me.lblLan5_1 = New SDSS.DSSLabel()
		Me.lblLan4_1 = New SDSS.DSSLabel()
		Me.lblLan8_1 = New SDSS.DSSLabel()
		Me.lblLan11_1 = New SDSS.DSSLabel()
		Me.lblLan2_1 = New SDSS.DSSLabel()
		Me.lblLan6_1 = New SDSS.DSSLabel()
		Me.lblLan9_1 = New SDSS.DSSLabel()
		Me.lblLan12_1 = New SDSS.DSSLabel()
		Me.lblLan3_1 = New SDSS.DSSLabel()
		Me.lblLan7_1 = New SDSS.DSSLabel()
		Me.lblLan10_1 = New SDSS.DSSLabel()
		Me.lblLan13_1 = New SDSS.DSSLabel()
		Me.Label89 = New System.Windows.Forms.Label()
		Me.pnlOutLanLarge = New SDSS.DSSPanel()
		Me.lblLan1_2 = New SDSS.DSSLabel()
		Me.lblLan5_2 = New SDSS.DSSLabel()
		Me.lblLan4_2 = New SDSS.DSSLabel()
		Me.lblLan8_2 = New SDSS.DSSLabel()
		Me.lblLan11_2 = New SDSS.DSSLabel()
		Me.lblLan2_2 = New SDSS.DSSLabel()
		Me.lblLan6_2 = New SDSS.DSSLabel()
		Me.lblLan13_2 = New SDSS.DSSLabel()
		Me.lblLan9_2 = New SDSS.DSSLabel()
		Me.lblLan10_2 = New SDSS.DSSLabel()
		Me.lblLan12_2 = New SDSS.DSSLabel()
		Me.lblLan7_2 = New SDSS.DSSLabel()
		Me.lblLan3_2 = New SDSS.DSSLabel()
		Me.Label90 = New System.Windows.Forms.Label()
		Me.pnlOutAgrLarge = New SDSS.DSSPanel()
		Me.lblAgr1_2 = New SDSS.DSSLabel()
		Me.lblAgr5_2 = New SDSS.DSSLabel()
		Me.lblAgr4_2 = New SDSS.DSSLabel()
		Me.lblAgr8_2 = New SDSS.DSSLabel()
		Me.lblAgr11_2 = New SDSS.DSSLabel()
		Me.lblAgr2_2 = New SDSS.DSSLabel()
		Me.lblAgr6_2 = New SDSS.DSSLabel()
		Me.lblAgr9_2 = New SDSS.DSSLabel()
		Me.lblAgr12_2 = New SDSS.DSSLabel()
		Me.lblAgr13_2 = New SDSS.DSSLabel()
		Me.lblAgr3_2 = New SDSS.DSSLabel()
		Me.lblAgr7_2 = New SDSS.DSSLabel()
		Me.lblAgr10_2 = New SDSS.DSSLabel()
		Me.Label135 = New System.Windows.Forms.Label()
		Me.Label85 = New System.Windows.Forms.Label()
		Me.Label133 = New System.Windows.Forms.Label()
		Me.Label84 = New System.Windows.Forms.Label()
		Me.Label83 = New System.Windows.Forms.Label()
		Me.Label31 = New System.Windows.Forms.Label()
		Me.Label82 = New System.Windows.Forms.Label()
		Me.Label33 = New System.Windows.Forms.Label()
		Me.Label81 = New System.Windows.Forms.Label()
		Me.Label35 = New System.Windows.Forms.Label()
		Me.Label80 = New System.Windows.Forms.Label()
		Me.Label36 = New System.Windows.Forms.Label()
		Me.Label79 = New System.Windows.Forms.Label()
		Me.Label60 = New System.Windows.Forms.Label()
		Me.Label61 = New System.Windows.Forms.Label()
		Me.grbPopulation = New SDSS.DSSGroupBox()
		Me.pnlPop20_2 = New SDSS.DSSPanel()
		Me.Label66 = New System.Windows.Forms.Label()
		Me.nudPop20_3_2 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_7_2 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_2_2 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_12_2 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_10_2 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_13_2 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_6_2 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_8_2 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_1_2 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_4_2 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_9_2 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_11_2 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_5_2 = New SDSS.DSSNumericUpDown()
		Me.pnlPop20_1 = New SDSS.DSSPanel()
		Me.Label67 = New System.Windows.Forms.Label()
		Me.nudPop20_3_1 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_7_1 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_2_1 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_6_1 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_12_1 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_1_1 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_9_1 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_13_1 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_10_1 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_11_1 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_8_1 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_5_1 = New SDSS.DSSNumericUpDown()
		Me.nudPop20_4_1 = New SDSS.DSSNumericUpDown()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label22 = New System.Windows.Forms.Label()
		Me.Label32 = New System.Windows.Forms.Label()
		Me.Label37 = New System.Windows.Forms.Label()
		Me.Label44 = New System.Windows.Forms.Label()
		Me.Label45 = New System.Windows.Forms.Label()
		Me.Label46 = New System.Windows.Forms.Label()
		Me.Label48 = New System.Windows.Forms.Label()
		Me.Label49 = New System.Windows.Forms.Label()
		Me.Label58 = New System.Windows.Forms.Label()
		Me.Label59 = New System.Windows.Forms.Label()
		Me.Label65 = New System.Windows.Forms.Label()
		Me.Label69 = New System.Windows.Forms.Label()
		Me.grbIndustrialDistricts = New SDSS.DSSGroupBox()
		Me.pnlInddispln = New SDSS.DSSPanel()
		Me.Label86 = New System.Windows.Forms.Label()
		Me.nudInddispln3_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddispln7_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddispln2_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddispln12_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddispln10_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddispln13_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddispln6_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddispln8_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddispln1_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddispln4_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddispln9_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddispln11_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddispln5_2 = New SDSS.DSSNumericUpDown()
		Me.pnlInddiscur = New SDSS.DSSPanel()
		Me.Label88 = New System.Windows.Forms.Label()
		Me.nudInddiscur3_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddiscur7_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddiscur2_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddiscur6_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddiscur12_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddiscur1_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddiscur9_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddiscur13_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddiscur10_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddiscur11_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddiscur8_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddiscur5_2 = New SDSS.DSSNumericUpDown()
		Me.nudInddiscur4_2 = New SDSS.DSSNumericUpDown()
		Me.Label38 = New System.Windows.Forms.Label()
		Me.Label39 = New System.Windows.Forms.Label()
		Me.Label40 = New System.Windows.Forms.Label()
		Me.Label41 = New System.Windows.Forms.Label()
		Me.Label42 = New System.Windows.Forms.Label()
		Me.Label43 = New System.Windows.Forms.Label()
		Me.Label71 = New System.Windows.Forms.Label()
		Me.Label72 = New System.Windows.Forms.Label()
		Me.Label73 = New System.Windows.Forms.Label()
		Me.Label74 = New System.Windows.Forms.Label()
		Me.Label75 = New System.Windows.Forms.Label()
		Me.Label76 = New System.Windows.Forms.Label()
		Me.Label77 = New System.Windows.Forms.Label()
		Me.grbWaterQuality = New SDSS.DSSGroupBox()
		Me.pnlTSS = New SDSS.DSSPanel()
		Me.Label21 = New System.Windows.Forms.Label()
		Me.nudTSS3 = New SDSS.DSSNumericUpDown()
		Me.nudTSS2 = New SDSS.DSSNumericUpDown()
		Me.nudTSS7 = New SDSS.DSSNumericUpDown()
		Me.nudTSS10 = New SDSS.DSSNumericUpDown()
		Me.nudTSS12 = New SDSS.DSSNumericUpDown()
		Me.nudTSS6 = New SDSS.DSSNumericUpDown()
		Me.nudTSS13 = New SDSS.DSSNumericUpDown()
		Me.nudTSS1 = New SDSS.DSSNumericUpDown()
		Me.nudTSS8 = New SDSS.DSSNumericUpDown()
		Me.nudTSS9 = New SDSS.DSSNumericUpDown()
		Me.nudTSS4 = New SDSS.DSSNumericUpDown()
		Me.nudTSS5 = New SDSS.DSSNumericUpDown()
		Me.nudTSS11 = New SDSS.DSSNumericUpDown()
		Me.pnlTDS = New SDSS.DSSPanel()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.nudTDS3 = New SDSS.DSSNumericUpDown()
		Me.nudTDS2 = New SDSS.DSSNumericUpDown()
		Me.nudTDS7 = New SDSS.DSSNumericUpDown()
		Me.nudTDS10 = New SDSS.DSSNumericUpDown()
		Me.nudTDS6 = New SDSS.DSSNumericUpDown()
		Me.nudTDS12 = New SDSS.DSSNumericUpDown()
		Me.nudTDS1 = New SDSS.DSSNumericUpDown()
		Me.nudTDS9 = New SDSS.DSSNumericUpDown()
		Me.nudTDS13 = New SDSS.DSSNumericUpDown()
		Me.nudTDS5 = New SDSS.DSSNumericUpDown()
		Me.nudTDS11 = New SDSS.DSSNumericUpDown()
		Me.nudTDS8 = New SDSS.DSSNumericUpDown()
		Me.nudTDS4 = New SDSS.DSSNumericUpDown()
		Me.pnlBOD = New SDSS.DSSPanel()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.nudBOD3 = New SDSS.DSSNumericUpDown()
		Me.nudBOD2 = New SDSS.DSSNumericUpDown()
		Me.nudBOD7 = New SDSS.DSSNumericUpDown()
		Me.nudBOD6 = New SDSS.DSSNumericUpDown()
		Me.nudBOD1 = New SDSS.DSSNumericUpDown()
		Me.nudBOD9 = New SDSS.DSSNumericUpDown()
		Me.nudBOD12 = New SDSS.DSSNumericUpDown()
		Me.nudBOD10 = New SDSS.DSSNumericUpDown()
		Me.nudBOD11 = New SDSS.DSSNumericUpDown()
		Me.nudBOD5 = New SDSS.DSSNumericUpDown()
		Me.nudBOD13 = New SDSS.DSSNumericUpDown()
		Me.nudBOD4 = New SDSS.DSSNumericUpDown()
		Me.nudBOD8 = New SDSS.DSSNumericUpDown()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.grbWaterCosts = New SDSS.DSSGroupBox()
		Me.pnlGro = New SDSS.DSSPanel()
		Me.Label121 = New System.Windows.Forms.Label()
		Me.nudGro3 = New SDSS.DSSNumericUpDown()
		Me.nudGro7 = New SDSS.DSSNumericUpDown()
		Me.nudGro2 = New SDSS.DSSNumericUpDown()
		Me.nudGro12 = New SDSS.DSSNumericUpDown()
		Me.nudGro10 = New SDSS.DSSNumericUpDown()
		Me.nudGro13 = New SDSS.DSSNumericUpDown()
		Me.nudGro6 = New SDSS.DSSNumericUpDown()
		Me.nudGro8 = New SDSS.DSSNumericUpDown()
		Me.nudGro1 = New SDSS.DSSNumericUpDown()
		Me.nudGro4 = New SDSS.DSSNumericUpDown()
		Me.nudGro9 = New SDSS.DSSNumericUpDown()
		Me.nudGro11 = New SDSS.DSSNumericUpDown()
		Me.nudGro5 = New SDSS.DSSNumericUpDown()
		Me.pnlDes = New SDSS.DSSPanel()
		Me.Label120 = New System.Windows.Forms.Label()
		Me.nudDes3 = New SDSS.DSSNumericUpDown()
		Me.nudDes7 = New SDSS.DSSNumericUpDown()
		Me.nudDes2 = New SDSS.DSSNumericUpDown()
		Me.nudDes6 = New SDSS.DSSNumericUpDown()
		Me.nudDes12 = New SDSS.DSSNumericUpDown()
		Me.nudDes1 = New SDSS.DSSNumericUpDown()
		Me.nudDes9 = New SDSS.DSSNumericUpDown()
		Me.nudDes13 = New SDSS.DSSNumericUpDown()
		Me.nudDes10 = New SDSS.DSSNumericUpDown()
		Me.nudDes11 = New SDSS.DSSNumericUpDown()
		Me.nudDes8 = New SDSS.DSSNumericUpDown()
		Me.nudDes5 = New SDSS.DSSNumericUpDown()
		Me.nudDes4 = New SDSS.DSSNumericUpDown()
		Me.Label63 = New System.Windows.Forms.Label()
		Me.Label55 = New System.Windows.Forms.Label()
		Me.Label62 = New System.Windows.Forms.Label()
		Me.Label54 = New System.Windows.Forms.Label()
		Me.Label130 = New System.Windows.Forms.Label()
		Me.Label128 = New System.Windows.Forms.Label()
		Me.Label51 = New System.Windows.Forms.Label()
		Me.Label57 = New System.Windows.Forms.Label()
		Me.Label53 = New System.Windows.Forms.Label()
		Me.Label50 = New System.Windows.Forms.Label()
		Me.Label56 = New System.Windows.Forms.Label()
		Me.Label52 = New System.Windows.Forms.Label()
		Me.Label47 = New System.Windows.Forms.Label()
		Me.grbMisc = New SDSS.DSSGroupBox()
		Me.DssPanel1 = New SDSS.DSSPanel()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.lblBOD = New SDSS.DSSLabel()
		Me.Label92 = New System.Windows.Forms.Label()
		Me.Label28 = New System.Windows.Forms.Label()
		Me.Label30 = New System.Windows.Forms.Label()
		Me.Label64 = New System.Windows.Forms.Label()
		Me.Label70 = New System.Windows.Forms.Label()
		Me.Label116 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label26 = New System.Windows.Forms.Label()
		Me.nudTpsx = New SDSS.DSSNumericUpDown()
		Me.Label68 = New System.Windows.Forms.Label()
		Me.nudTpmz = New SDSS.DSSNumericUpDown()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.nudAgrUFRO = New SDSS.DSSNumericUpDown()
		Me.Label29 = New System.Windows.Forms.Label()
		Me.nudEnvw = New SDSS.DSSNumericUpDown()
		Me.lblTDS = New SDSS.DSSLabel()
		Me.nudgwsp = New SDSS.DSSNumericUpDown()
		Me.nudTotpla = New SDSS.DSSNumericUpDown()
		Me.nudIndUFRO = New SDSS.DSSNumericUpDown()
		Me.nudSocw = New SDSS.DSSNumericUpDown()
		Me.nudTpbx = New SDSS.DSSNumericUpDown()
		Me.nudEcow = New SDSS.DSSNumericUpDown()
		Me.nudsmqi = New SDSS.DSSNumericUpDown()
		Me.nudLanUFRO = New SDSS.DSSNumericUpDown()
		Me.nudsbqi = New SDSS.DSSNumericUpDown()
		Me.nudLanUF = New SDSS.DSSNumericUpDown()
		Me.nudssqi = New SDSS.DSSNumericUpDown()
		Me.nudAgrUF = New SDSS.DSSNumericUpDown()
		Me.nudIndUF = New SDSS.DSSNumericUpDown()
		Me.Label25 = New System.Windows.Forms.Label()
		Me.Label119 = New System.Windows.Forms.Label()
		Me.Label34 = New System.Windows.Forms.Label()
		Me.Label27 = New System.Windows.Forms.Label()
		Me.Label23 = New System.Windows.Forms.Label()
		Me.Label118 = New System.Windows.Forms.Label()
		Me.Label78 = New System.Windows.Forms.Label()
		Me.Label117 = New System.Windows.Forms.Label()
		Me.Label91 = New System.Windows.Forms.Label()
		Me.ElementHost1 = New System.Windows.Forms.Integration.ElementHost()
		Me.mapControl = New mapControl.mapControl()
		CType(Me.dsParameters, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DSData, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DSLocations, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlMain.SuspendLayout()
		CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer.Panel1.SuspendLayout()
		Me.SplitContainer.Panel2.SuspendLayout()
		Me.SplitContainer.SuspendLayout()
		Me.grbOuput.SuspendLayout()
		Me.tcoOutput.SuspendLayout()
		Me.tpaImpacts.SuspendLayout()
		Me.gboOutputImpacts.SuspendLayout()
		Me.pnlOutSocSmall.SuspendLayout()
		Me.pnlOutEnvLarge.SuspendLayout()
		Me.pnlOutEnvSmall.SuspendLayout()
		Me.pnlOutEcoLarge.SuspendLayout()
		Me.pnlOutSocLarge.SuspendLayout()
		Me.pnlOutEcoSmall.SuspendLayout()
		Me.tpaWeights.SuspendLayout()
		CType(Me.pboGraphWeights, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tpaStandards.SuspendLayout()
		CType(Me.pboGraphStandards, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tpaEfficencies.SuspendLayout()
		CType(Me.pboGraphEfficiencies, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tpaUses.SuspendLayout()
		Me.gboOutputUses.SuspendLayout()
		Me.pnlOutAgrSmall.SuspendLayout()
		Me.pnlOutIndLarge.SuspendLayout()
		Me.pnlOutLanSmall.SuspendLayout()
		Me.pnlOutLanLarge.SuspendLayout()
		Me.pnlOutAgrLarge.SuspendLayout()
		Me.grbPopulation.SuspendLayout()
		Me.pnlPop20_2.SuspendLayout()
		CType(Me.nudPop20_3_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_7_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_2_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_12_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_10_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_13_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_6_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_8_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_1_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_4_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_9_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_11_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_5_2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlPop20_1.SuspendLayout()
		CType(Me.nudPop20_3_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_7_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_2_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_6_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_12_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_1_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_9_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_13_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_10_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_11_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_8_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_5_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudPop20_4_1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grbIndustrialDistricts.SuspendLayout()
		Me.pnlInddispln.SuspendLayout()
		CType(Me.nudInddispln3_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddispln7_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddispln2_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddispln12_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddispln10_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddispln13_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddispln6_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddispln8_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddispln1_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddispln4_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddispln9_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddispln11_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddispln5_2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlInddiscur.SuspendLayout()
		CType(Me.nudInddiscur3_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddiscur7_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddiscur2_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddiscur6_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddiscur12_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddiscur1_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddiscur9_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddiscur13_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddiscur10_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddiscur11_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddiscur8_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddiscur5_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInddiscur4_2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grbWaterQuality.SuspendLayout()
		Me.pnlTSS.SuspendLayout()
		CType(Me.nudTSS3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTSS2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTSS7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTSS10, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTSS12, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTSS6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTSS13, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTSS1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTSS8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTSS9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTSS4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTSS5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTSS11, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlTDS.SuspendLayout()
		CType(Me.nudTDS3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTDS2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTDS7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTDS10, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTDS6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTDS12, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTDS1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTDS9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTDS13, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTDS5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTDS11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTDS8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTDS4, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlBOD.SuspendLayout()
		CType(Me.nudBOD3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudBOD2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudBOD7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudBOD6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudBOD1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudBOD9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudBOD12, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudBOD10, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudBOD11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudBOD5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudBOD13, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudBOD4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudBOD8, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grbWaterCosts.SuspendLayout()
		Me.pnlGro.SuspendLayout()
		CType(Me.nudGro3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudGro7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudGro2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudGro12, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudGro10, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudGro13, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudGro6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudGro8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudGro1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudGro4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudGro9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudGro11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudGro5, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlDes.SuspendLayout()
		CType(Me.nudDes3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudDes7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudDes2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudDes6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudDes12, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudDes1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudDes9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudDes13, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudDes10, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudDes11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudDes8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudDes5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudDes4, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grbMisc.SuspendLayout()
		Me.DssPanel1.SuspendLayout()
		CType(Me.nudTpsx, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTpmz, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudAgrUFRO, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudEnvw, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudgwsp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTotpla, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudIndUFRO, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudSocw, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTpbx, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudEcow, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudsmqi, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudLanUFRO, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudsbqi, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudLanUF, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudssqi, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudAgrUF, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudIndUF, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'daData
		'
		Me.daData.DeleteCommand = Me.SqlDeleteCommand
		Me.daData.InsertCommand = Me.SqlInsertCommand
		Me.daData.SelectCommand = Me.SqlSelectCommand
		Me.daData.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "data", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("datID", "datID"), New System.Data.Common.DataColumnMapping("indcc1_1", "indcc1_1"), New System.Data.Common.DataColumnMapping("indcc2_1", "indcc2_1"), New System.Data.Common.DataColumnMapping("indcc3_1", "indcc3_1"), New System.Data.Common.DataColumnMapping("indcc4_1", "indcc4_1"), New System.Data.Common.DataColumnMapping("indcc5_1", "indcc5_1"), New System.Data.Common.DataColumnMapping("indcc6_1", "indcc6_1"), New System.Data.Common.DataColumnMapping("indcc7_1", "indcc7_1"), New System.Data.Common.DataColumnMapping("indcc8_1", "indcc8_1"), New System.Data.Common.DataColumnMapping("indcc9_1", "indcc9_1"), New System.Data.Common.DataColumnMapping("indcc10_1", "indcc10_1"), New System.Data.Common.DataColumnMapping("indcc11_1", "indcc11_1"), New System.Data.Common.DataColumnMapping("indcc12_1", "indcc12_1"), New System.Data.Common.DataColumnMapping("indcc13_1", "indcc13_1"), New System.Data.Common.DataColumnMapping("indcc1_2", "indcc1_2"), New System.Data.Common.DataColumnMapping("indcc2_2", "indcc2_2"), New System.Data.Common.DataColumnMapping("indcc3_2", "indcc3_2"), New System.Data.Common.DataColumnMapping("indcc4_2", "indcc4_2"), New System.Data.Common.DataColumnMapping("indcc5_2", "indcc5_2"), New System.Data.Common.DataColumnMapping("indcc6_2", "indcc6_2"), New System.Data.Common.DataColumnMapping("indcc7_2", "indcc7_2"), New System.Data.Common.DataColumnMapping("indcc8_2", "indcc8_2"), New System.Data.Common.DataColumnMapping("indcc9_2", "indcc9_2"), New System.Data.Common.DataColumnMapping("indcc10_2", "indcc10_2"), New System.Data.Common.DataColumnMapping("indcc11_2", "indcc11_2"), New System.Data.Common.DataColumnMapping("indcc12_2", "indcc12_2"), New System.Data.Common.DataColumnMapping("indcc13_2", "indcc13_2"), New System.Data.Common.DataColumnMapping("agrcc1_1", "agrcc1_1"), New System.Data.Common.DataColumnMapping("agrcc2_1", "agrcc2_1"), New System.Data.Common.DataColumnMapping("agrcc3_1", "agrcc3_1"), New System.Data.Common.DataColumnMapping("agrcc4_1", "agrcc4_1"), New System.Data.Common.DataColumnMapping("agrcc5_1", "agrcc5_1"), New System.Data.Common.DataColumnMapping("agrcc6_1", "agrcc6_1"), New System.Data.Common.DataColumnMapping("agrcc7_1", "agrcc7_1"), New System.Data.Common.DataColumnMapping("agrcc8_1", "agrcc8_1"), New System.Data.Common.DataColumnMapping("agrcc9_1", "agrcc9_1"), New System.Data.Common.DataColumnMapping("agrcc10_1", "agrcc10_1"), New System.Data.Common.DataColumnMapping("agrcc11_1", "agrcc11_1"), New System.Data.Common.DataColumnMapping("agrcc12_1", "agrcc12_1"), New System.Data.Common.DataColumnMapping("agrcc13_1", "agrcc13_1"), New System.Data.Common.DataColumnMapping("agrcc1_2", "agrcc1_2"), New System.Data.Common.DataColumnMapping("agrcc2_2", "agrcc2_2"), New System.Data.Common.DataColumnMapping("agrcc3_2", "agrcc3_2"), New System.Data.Common.DataColumnMapping("agrcc4_2", "agrcc4_2"), New System.Data.Common.DataColumnMapping("agrcc5_2", "agrcc5_2"), New System.Data.Common.DataColumnMapping("agrcc6_2", "agrcc6_2"), New System.Data.Common.DataColumnMapping("agrcc7_2", "agrcc7_2"), New System.Data.Common.DataColumnMapping("agrcc8_2", "agrcc8_2"), New System.Data.Common.DataColumnMapping("agrcc9_2", "agrcc9_2"), New System.Data.Common.DataColumnMapping("agrcc10_2", "agrcc10_2"), New System.Data.Common.DataColumnMapping("agrcc11_2", "agrcc11_2"), New System.Data.Common.DataColumnMapping("agrcc12_2", "agrcc12_2"), New System.Data.Common.DataColumnMapping("agrcc13_2", "agrcc13_2"), New System.Data.Common.DataColumnMapping("lancc1_1", "lancc1_1"), New System.Data.Common.DataColumnMapping("lancc2_1", "lancc2_1"), New System.Data.Common.DataColumnMapping("lancc3_1", "lancc3_1"), New System.Data.Common.DataColumnMapping("lancc4_1", "lancc4_1"), New System.Data.Common.DataColumnMapping("lancc5_1", "lancc5_1"), New System.Data.Common.DataColumnMapping("lancc6_1", "lancc6_1"), New System.Data.Common.DataColumnMapping("lancc7_1", "lancc7_1"), New System.Data.Common.DataColumnMapping("lancc8_1", "lancc8_1"), New System.Data.Common.DataColumnMapping("lancc9_1", "lancc9_1"), New System.Data.Common.DataColumnMapping("lancc10_1", "lancc10_1"), New System.Data.Common.DataColumnMapping("lancc11_1", "lancc11_1"), New System.Data.Common.DataColumnMapping("lancc12_1", "lancc12_1"), New System.Data.Common.DataColumnMapping("lancc13_1", "lancc13_1"), New System.Data.Common.DataColumnMapping("lancc1_2", "lancc1_2"), New System.Data.Common.DataColumnMapping("lancc2_2", "lancc2_2"), New System.Data.Common.DataColumnMapping("lancc3_2", "lancc3_2"), New System.Data.Common.DataColumnMapping("lancc4_2", "lancc4_2"), New System.Data.Common.DataColumnMapping("lancc5_2", "lancc5_2"), New System.Data.Common.DataColumnMapping("lancc6_2", "lancc6_2"), New System.Data.Common.DataColumnMapping("lancc7_2", "lancc7_2"), New System.Data.Common.DataColumnMapping("lancc8_2", "lancc8_2"), New System.Data.Common.DataColumnMapping("lancc9_2", "lancc9_2"), New System.Data.Common.DataColumnMapping("lancc10_2", "lancc10_2"), New System.Data.Common.DataColumnMapping("lancc11_2", "lancc11_2"), New System.Data.Common.DataColumnMapping("lancc12_2", "lancc12_2"), New System.Data.Common.DataColumnMapping("lancc13_2", "lancc13_2"), New System.Data.Common.DataColumnMapping("lbqi1_1", "lbqi1_1"), New System.Data.Common.DataColumnMapping("lbqi2_1", "lbqi2_1"), New System.Data.Common.DataColumnMapping("lbqi3_1", "lbqi3_1"), New System.Data.Common.DataColumnMapping("lbqi4_1", "lbqi4_1"), New System.Data.Common.DataColumnMapping("lbqi5_1", "lbqi5_1"), New System.Data.Common.DataColumnMapping("lbqi6_1", "lbqi6_1"), New System.Data.Common.DataColumnMapping("lbqi7_1", "lbqi7_1"), New System.Data.Common.DataColumnMapping("lbqi8_1", "lbqi8_1"), New System.Data.Common.DataColumnMapping("lbqi9_1", "lbqi9_1"), New System.Data.Common.DataColumnMapping("lbqi10_1", "lbqi10_1"), New System.Data.Common.DataColumnMapping("lbqi11_1", "lbqi11_1"), New System.Data.Common.DataColumnMapping("lbqi12_1", "lbqi12_1"), New System.Data.Common.DataColumnMapping("lbqi13_1", "lbqi13_1"), New System.Data.Common.DataColumnMapping("lbqi1_2", "lbqi1_2"), New System.Data.Common.DataColumnMapping("lbqi2_2", "lbqi2_2"), New System.Data.Common.DataColumnMapping("lbqi3_2", "lbqi3_2"), New System.Data.Common.DataColumnMapping("lbqi4_2", "lbqi4_2"), New System.Data.Common.DataColumnMapping("lbqi5_2", "lbqi5_2"), New System.Data.Common.DataColumnMapping("lbqi6_2", "lbqi6_2"), New System.Data.Common.DataColumnMapping("lbqi7_2", "lbqi7_2"), New System.Data.Common.DataColumnMapping("lbqi8_2", "lbqi8_2"), New System.Data.Common.DataColumnMapping("lbqi9_2", "lbqi9_2"), New System.Data.Common.DataColumnMapping("lbqi10_2", "lbqi10_2"), New System.Data.Common.DataColumnMapping("lbqi11_2", "lbqi11_2"), New System.Data.Common.DataColumnMapping("lbqi12_2", "lbqi12_2"), New System.Data.Common.DataColumnMapping("lbqi13_2", "lbqi13_2"), New System.Data.Common.DataColumnMapping("lsqi1_1", "lsqi1_1"), New System.Data.Common.DataColumnMapping("lsqi2_1", "lsqi2_1"), New System.Data.Common.DataColumnMapping("lsqi3_1", "lsqi3_1"), New System.Data.Common.DataColumnMapping("lsqi4_1", "lsqi4_1"), New System.Data.Common.DataColumnMapping("lsqi5_1", "lsqi5_1"), New System.Data.Common.DataColumnMapping("lsqi6_1", "lsqi6_1"), New System.Data.Common.DataColumnMapping("lsqi7_1", "lsqi7_1"), New System.Data.Common.DataColumnMapping("lsqi8_1", "lsqi8_1"), New System.Data.Common.DataColumnMapping("lsqi9_1", "lsqi9_1"), New System.Data.Common.DataColumnMapping("lsqi10_1", "lsqi10_1"), New System.Data.Common.DataColumnMapping("lsqi11_1", "lsqi11_1"), New System.Data.Common.DataColumnMapping("lsqi12_1", "lsqi12_1"), New System.Data.Common.DataColumnMapping("lsqi13_1", "lsqi13_1"), New System.Data.Common.DataColumnMapping("lsqi1_2", "lsqi1_2"), New System.Data.Common.DataColumnMapping("lsqi2_2", "lsqi2_2"), New System.Data.Common.DataColumnMapping("lsqi3_2", "lsqi3_2"), New System.Data.Common.DataColumnMapping("lsqi4_2", "lsqi4_2"), New System.Data.Common.DataColumnMapping("lsqi5_2", "lsqi5_2"), New System.Data.Common.DataColumnMapping("lsqi6_2", "lsqi6_2"), New System.Data.Common.DataColumnMapping("lsqi7_2", "lsqi7_2"), New System.Data.Common.DataColumnMapping("lsqi8_2", "lsqi8_2"), New System.Data.Common.DataColumnMapping("lsqi9_2", "lsqi9_2"), New System.Data.Common.DataColumnMapping("lsqi10_2", "lsqi10_2"), New System.Data.Common.DataColumnMapping("lsqi11_2", "lsqi11_2"), New System.Data.Common.DataColumnMapping("lsqi12_2", "lsqi12_2"), New System.Data.Common.DataColumnMapping("lsqi13_2", "lsqi13_2"), New System.Data.Common.DataColumnMapping("lmqi1_1", "lmqi1_1"), New System.Data.Common.DataColumnMapping("lmqi2_1", "lmqi2_1"), New System.Data.Common.DataColumnMapping("lmqi3_1", "lmqi3_1"), New System.Data.Common.DataColumnMapping("lmqi4_1", "lmqi4_1"), New System.Data.Common.DataColumnMapping("lmqi5_1", "lmqi5_1"), New System.Data.Common.DataColumnMapping("lmqi6_1", "lmqi6_1"), New System.Data.Common.DataColumnMapping("lmqi7_1", "lmqi7_1"), New System.Data.Common.DataColumnMapping("lmqi8_1", "lmqi8_1"), New System.Data.Common.DataColumnMapping("lmqi9_1", "lmqi9_1"), New System.Data.Common.DataColumnMapping("lmqi10_1", "lmqi10_1"), New System.Data.Common.DataColumnMapping("lmqi11_1", "lmqi11_1"), New System.Data.Common.DataColumnMapping("lmqi12_1", "lmqi12_1"), New System.Data.Common.DataColumnMapping("lmqi13_1", "lmqi13_1"), New System.Data.Common.DataColumnMapping("lmqi1_2", "lmqi1_2"), New System.Data.Common.DataColumnMapping("lmqi2_2", "lmqi2_2"), New System.Data.Common.DataColumnMapping("lmqi3_2", "lmqi3_2"), New System.Data.Common.DataColumnMapping("lmqi4_2", "lmqi4_2"), New System.Data.Common.DataColumnMapping("lmqi5_2", "lmqi5_2"), New System.Data.Common.DataColumnMapping("lmqi6_2", "lmqi6_2"), New System.Data.Common.DataColumnMapping("lmqi7_2", "lmqi7_2"), New System.Data.Common.DataColumnMapping("lmqi8_2", "lmqi8_2"), New System.Data.Common.DataColumnMapping("lmqi9_2", "lmqi9_2"), New System.Data.Common.DataColumnMapping("lmqi10_2", "lmqi10_2"), New System.Data.Common.DataColumnMapping("lmqi11_2", "lmqi11_2"), New System.Data.Common.DataColumnMapping("lmqi12_2", "lmqi12_2"), New System.Data.Common.DataColumnMapping("lmqi13_2", "lmqi13_2"), New System.Data.Common.DataColumnMapping("pop20_1_1", "pop20_1_1"), New System.Data.Common.DataColumnMapping("pop20_2_1", "pop20_2_1"), New System.Data.Common.DataColumnMapping("pop20_3_1", "pop20_3_1"), New System.Data.Common.DataColumnMapping("pop20_4_1", "pop20_4_1"), New System.Data.Common.DataColumnMapping("pop20_5_1", "pop20_5_1"), New System.Data.Common.DataColumnMapping("pop20_6_1", "pop20_6_1"), New System.Data.Common.DataColumnMapping("pop20_7_1", "pop20_7_1"), New System.Data.Common.DataColumnMapping("pop20_8_1", "pop20_8_1"), New System.Data.Common.DataColumnMapping("pop20_9_1", "pop20_9_1"), New System.Data.Common.DataColumnMapping("pop20_10_1", "pop20_10_1"), New System.Data.Common.DataColumnMapping("pop20_11_1", "pop20_11_1"), New System.Data.Common.DataColumnMapping("pop20_12_1", "pop20_12_1"), New System.Data.Common.DataColumnMapping("pop20_13_1", "pop20_13_1"), New System.Data.Common.DataColumnMapping("pop20_1_2", "pop20_1_2"), New System.Data.Common.DataColumnMapping("pop20_2_2", "pop20_2_2"), New System.Data.Common.DataColumnMapping("pop20_3_2", "pop20_3_2"), New System.Data.Common.DataColumnMapping("pop20_4_2", "pop20_4_2"), New System.Data.Common.DataColumnMapping("pop20_5_2", "pop20_5_2"), New System.Data.Common.DataColumnMapping("pop20_6_2", "pop20_6_2"), New System.Data.Common.DataColumnMapping("pop20_7_2", "pop20_7_2"), New System.Data.Common.DataColumnMapping("pop20_8_2", "pop20_8_2"), New System.Data.Common.DataColumnMapping("pop20_9_2", "pop20_9_2"), New System.Data.Common.DataColumnMapping("pop20_10_2", "pop20_10_2"), New System.Data.Common.DataColumnMapping("pop20_11_2", "pop20_11_2"), New System.Data.Common.DataColumnMapping("pop20_12_2", "pop20_12_2"), New System.Data.Common.DataColumnMapping("pop20_13_2", "pop20_13_2"), New System.Data.Common.DataColumnMapping("inddis1_1", "inddis1_1"), New System.Data.Common.DataColumnMapping("inddis2_1", "inddis2_1"), New System.Data.Common.DataColumnMapping("inddis3_1", "inddis3_1"), New System.Data.Common.DataColumnMapping("inddis4_1", "inddis4_1"), New System.Data.Common.DataColumnMapping("inddis5_1", "inddis5_1"), New System.Data.Common.DataColumnMapping("inddis6_1", "inddis6_1"), New System.Data.Common.DataColumnMapping("inddis7_1", "inddis7_1"), New System.Data.Common.DataColumnMapping("inddis8_1", "inddis8_1"), New System.Data.Common.DataColumnMapping("inddis9_1", "inddis9_1"), New System.Data.Common.DataColumnMapping("inddis10_1", "inddis10_1"), New System.Data.Common.DataColumnMapping("inddis11_1", "inddis11_1"), New System.Data.Common.DataColumnMapping("inddis12_1", "inddis12_1"), New System.Data.Common.DataColumnMapping("inddis13_1", "inddis13_1"), New System.Data.Common.DataColumnMapping("inddis1_2", "inddis1_2"), New System.Data.Common.DataColumnMapping("inddis2_2", "inddis2_2"), New System.Data.Common.DataColumnMapping("inddis3_2", "inddis3_2"), New System.Data.Common.DataColumnMapping("inddis4_2", "inddis4_2"), New System.Data.Common.DataColumnMapping("inddis5_2", "inddis5_2"), New System.Data.Common.DataColumnMapping("inddis6_2", "inddis6_2"), New System.Data.Common.DataColumnMapping("inddis7_2", "inddis7_2"), New System.Data.Common.DataColumnMapping("inddis8_2", "inddis8_2"), New System.Data.Common.DataColumnMapping("inddis9_2", "inddis9_2"), New System.Data.Common.DataColumnMapping("inddis10_2", "inddis10_2"), New System.Data.Common.DataColumnMapping("inddis11_2", "inddis11_2"), New System.Data.Common.DataColumnMapping("inddis12_2", "inddis12_2"), New System.Data.Common.DataColumnMapping("inddis13_2", "inddis13_2"), New System.Data.Common.DataColumnMapping("inddiscur1_1", "inddiscur1_1"), New System.Data.Common.DataColumnMapping("inddiscur2_1", "inddiscur2_1"), New System.Data.Common.DataColumnMapping("inddiscur3_1", "inddiscur3_1"), New System.Data.Common.DataColumnMapping("inddiscur4_1", "inddiscur4_1"), New System.Data.Common.DataColumnMapping("inddiscur5_1", "inddiscur5_1"), New System.Data.Common.DataColumnMapping("inddiscur6_1", "inddiscur6_1"), New System.Data.Common.DataColumnMapping("inddiscur7_1", "inddiscur7_1"), New System.Data.Common.DataColumnMapping("inddiscur8_1", "inddiscur8_1"), New System.Data.Common.DataColumnMapping("inddiscur9_1", "inddiscur9_1"), New System.Data.Common.DataColumnMapping("inddiscur10_1", "inddiscur10_1"), New System.Data.Common.DataColumnMapping("inddiscur11_1", "inddiscur11_1"), New System.Data.Common.DataColumnMapping("inddiscur12_1", "inddiscur12_1"), New System.Data.Common.DataColumnMapping("inddiscur13_1", "inddiscur13_1"), New System.Data.Common.DataColumnMapping("inddiscur1_2", "inddiscur1_2"), New System.Data.Common.DataColumnMapping("inddiscur2_2", "inddiscur2_2"), New System.Data.Common.DataColumnMapping("inddiscur3_2", "inddiscur3_2"), New System.Data.Common.DataColumnMapping("inddiscur4_2", "inddiscur4_2"), New System.Data.Common.DataColumnMapping("inddiscur5_2", "inddiscur5_2"), New System.Data.Common.DataColumnMapping("inddiscur6_2", "inddiscur6_2"), New System.Data.Common.DataColumnMapping("inddiscur7_2", "inddiscur7_2"), New System.Data.Common.DataColumnMapping("inddiscur8_2", "inddiscur8_2"), New System.Data.Common.DataColumnMapping("inddiscur9_2", "inddiscur9_2"), New System.Data.Common.DataColumnMapping("inddiscur10_2", "inddiscur10_2"), New System.Data.Common.DataColumnMapping("inddiscur11_2", "inddiscur11_2"), New System.Data.Common.DataColumnMapping("inddiscur12_2", "inddiscur12_2"), New System.Data.Common.DataColumnMapping("inddiscur13_2", "inddiscur13_2"), New System.Data.Common.DataColumnMapping("inddispln1_1", "inddispln1_1"), New System.Data.Common.DataColumnMapping("inddispln2_1", "inddispln2_1"), New System.Data.Common.DataColumnMapping("inddispln3_1", "inddispln3_1"), New System.Data.Common.DataColumnMapping("inddispln4_1", "inddispln4_1"), New System.Data.Common.DataColumnMapping("inddispln5_1", "inddispln5_1"), New System.Data.Common.DataColumnMapping("inddispln6_1", "inddispln6_1"), New System.Data.Common.DataColumnMapping("inddispln7_1", "inddispln7_1"), New System.Data.Common.DataColumnMapping("inddispln8_1", "inddispln8_1"), New System.Data.Common.DataColumnMapping("inddispln9_1", "inddispln9_1"), New System.Data.Common.DataColumnMapping("inddispln10_1", "inddispln10_1"), New System.Data.Common.DataColumnMapping("inddispln11_1", "inddispln11_1"), New System.Data.Common.DataColumnMapping("inddispln12_1", "inddispln12_1"), New System.Data.Common.DataColumnMapping("inddispln13_1", "inddispln13_1"), New System.Data.Common.DataColumnMapping("inddispln1_2", "inddispln1_2"), New System.Data.Common.DataColumnMapping("inddispln2_2", "inddispln2_2"), New System.Data.Common.DataColumnMapping("inddispln3_2", "inddispln3_2"), New System.Data.Common.DataColumnMapping("inddispln4_2", "inddispln4_2"), New System.Data.Common.DataColumnMapping("inddispln5_2", "inddispln5_2"), New System.Data.Common.DataColumnMapping("inddispln6_2", "inddispln6_2"), New System.Data.Common.DataColumnMapping("inddispln7_2", "inddispln7_2"), New System.Data.Common.DataColumnMapping("inddispln8_2", "inddispln8_2"), New System.Data.Common.DataColumnMapping("inddispln9_2", "inddispln9_2"), New System.Data.Common.DataColumnMapping("inddispln10_2", "inddispln10_2"), New System.Data.Common.DataColumnMapping("inddispln11_2", "inddispln11_2"), New System.Data.Common.DataColumnMapping("inddispln12_2", "inddispln12_2"), New System.Data.Common.DataColumnMapping("inddispln13_2", "inddispln13_2"), New System.Data.Common.DataColumnMapping("tpbx", "tpbx"), New System.Data.Common.DataColumnMapping("tpsx", "tpsx"), New System.Data.Common.DataColumnMapping("tpmz", "tpmz"), New System.Data.Common.DataColumnMapping("envw", "envw"), New System.Data.Common.DataColumnMapping("ecow", "ecow"), New System.Data.Common.DataColumnMapping("socw", "socw"), New System.Data.Common.DataColumnMapping("totpla", "totpla"), New System.Data.Common.DataColumnMapping("bod1", "bod1"), New System.Data.Common.DataColumnMapping("bod2", "bod2"), New System.Data.Common.DataColumnMapping("bod3", "bod3"), New System.Data.Common.DataColumnMapping("bod4", "bod4"), New System.Data.Common.DataColumnMapping("bod5", "bod5"), New System.Data.Common.DataColumnMapping("bod6", "bod6"), New System.Data.Common.DataColumnMapping("bod7", "bod7"), New System.Data.Common.DataColumnMapping("bod8", "bod8"), New System.Data.Common.DataColumnMapping("bod9", "bod9"), New System.Data.Common.DataColumnMapping("bod10", "bod10"), New System.Data.Common.DataColumnMapping("bod11", "bod11"), New System.Data.Common.DataColumnMapping("bod12", "bod12"), New System.Data.Common.DataColumnMapping("bod13", "bod13"), New System.Data.Common.DataColumnMapping("tds1", "tds1"), New System.Data.Common.DataColumnMapping("tds2", "tds2"), New System.Data.Common.DataColumnMapping("tds3", "tds3"), New System.Data.Common.DataColumnMapping("tds4", "tds4"), New System.Data.Common.DataColumnMapping("tds5", "tds5"), New System.Data.Common.DataColumnMapping("tds6", "tds6"), New System.Data.Common.DataColumnMapping("tds7", "tds7"), New System.Data.Common.DataColumnMapping("tds8", "tds8"), New System.Data.Common.DataColumnMapping("tds9", "tds9"), New System.Data.Common.DataColumnMapping("tds10", "tds10"), New System.Data.Common.DataColumnMapping("tds11", "tds11"), New System.Data.Common.DataColumnMapping("tds12", "tds12"), New System.Data.Common.DataColumnMapping("tds13", "tds13"), New System.Data.Common.DataColumnMapping("tss1", "tss1"), New System.Data.Common.DataColumnMapping("tss2", "tss2"), New System.Data.Common.DataColumnMapping("tss3", "tss3"), New System.Data.Common.DataColumnMapping("tss4", "tss4"), New System.Data.Common.DataColumnMapping("tss5", "tss5"), New System.Data.Common.DataColumnMapping("tss6", "tss6"), New System.Data.Common.DataColumnMapping("tss7", "tss7"), New System.Data.Common.DataColumnMapping("tss8", "tss8"), New System.Data.Common.DataColumnMapping("tss9", "tss9"), New System.Data.Common.DataColumnMapping("tss10", "tss10"), New System.Data.Common.DataColumnMapping("tss11", "tss11"), New System.Data.Common.DataColumnMapping("tss12", "tss12"), New System.Data.Common.DataColumnMapping("tss13", "tss13"), New System.Data.Common.DataColumnMapping("agruf", "agruf"), New System.Data.Common.DataColumnMapping("agrufro", "agrufro"), New System.Data.Common.DataColumnMapping("induf", "induf"), New System.Data.Common.DataColumnMapping("indufro", "indufro"), New System.Data.Common.DataColumnMapping("lanuf", "lanuf"), New System.Data.Common.DataColumnMapping("lanufro", "lanufro"), New System.Data.Common.DataColumnMapping("gwsp", "gwsp"), New System.Data.Common.DataColumnMapping("sbqi", "sbqi"), New System.Data.Common.DataColumnMapping("ssqi", "ssqi"), New System.Data.Common.DataColumnMapping("smqi", "smqi"), New System.Data.Common.DataColumnMapping("DataCreazione", "DataCreazione"), New System.Data.Common.DataColumnMapping("UtenteCreazione", "UtenteCreazione"), New System.Data.Common.DataColumnMapping("DataAggiornamento", "DataAggiornamento"), New System.Data.Common.DataColumnMapping("UtenteAggiornamento", "UtenteAggiornamento"), New System.Data.Common.DataColumnMapping("Annullato", "Annullato"), New System.Data.Common.DataColumnMapping("DataEstrazione", "DataEstrazione")})})
		Me.daData.UpdateCommand = Me.SqlUpdateCommand
		'
		'SqlDeleteCommand
		'
		Me.SqlDeleteCommand.CommandText = resources.GetString("SqlDeleteCommand.CommandText")
		Me.SqlDeleteCommand.Connection = Me.SqlConnection
		Me.SqlDeleteCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_datID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc1_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc1_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc1_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc2_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc2_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc2_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc3_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc3_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc3_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc4_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc4_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc4_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc5_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc5_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc5_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc6_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc6_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc6_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc7_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc7_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc7_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc8_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc8_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc8_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc9_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc9_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc9_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc10_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc10_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc10_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc11_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc11_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc11_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc12_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc12_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc12_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc13_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc13_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc13_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc1_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc1_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc1_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc2_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc2_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc2_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc3_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc3_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc3_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc4_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc4_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc4_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc5_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc5_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc5_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc6_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc6_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc6_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc7_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc7_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc7_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc8_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc8_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc8_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc9_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc9_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc9_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc10_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc10_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc10_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc11_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc11_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc11_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc12_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc12_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc12_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc13_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc13_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc13_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc1_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc1_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc1_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc2_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc2_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc2_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc3_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc3_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc3_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc4_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc4_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc4_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc5_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc5_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc5_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc6_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc6_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc6_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc7_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc7_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc7_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc8_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc8_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc8_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc9_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc9_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc9_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc10_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc10_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc10_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc11_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc11_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc11_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc12_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc12_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc12_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc13_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc13_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc13_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc1_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc1_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc1_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc2_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc2_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc2_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc3_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc3_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc3_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc4_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc4_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc4_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc5_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc5_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc5_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc6_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc6_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc6_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc7_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc7_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc7_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc8_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc8_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc8_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc9_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc9_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc9_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc10_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc10_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc10_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc11_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc11_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc11_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc12_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc12_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc12_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc13_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc13_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc13_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc1_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc1_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc1_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc2_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc2_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc2_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc3_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc3_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc3_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc4_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc4_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc4_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc5_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc5_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc5_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc6_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc6_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc6_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc7_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc7_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc7_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc8_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc8_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc8_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc9_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc9_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc9_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc10_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc10_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc10_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc11_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc11_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc11_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc12_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc12_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc12_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc13_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc13_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc13_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc1_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc1_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc1_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc2_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc2_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc2_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc3_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc3_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc3_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc4_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc4_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc4_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc5_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc5_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc5_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc6_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc6_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc6_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc7_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc7_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc7_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc8_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc8_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc8_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc9_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc9_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc9_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc10_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc10_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc10_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc11_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc11_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc11_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc12_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc12_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc12_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc13_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc13_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc13_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi1_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi1_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi1_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi2_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi2_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi2_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi3_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi3_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi3_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi4_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi4_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi4_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi5_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi5_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi5_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi6_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi6_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi6_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi7_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi7_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi7_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi8_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi8_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi8_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi9_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi9_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi9_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi10_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi10_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi10_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi11_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi11_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi11_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi12_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi12_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi12_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi13_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi13_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi13_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi1_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi1_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi1_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi2_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi2_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi2_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi3_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi3_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi3_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi4_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi4_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi4_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi5_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi5_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi5_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi6_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi6_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi6_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi7_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi7_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi7_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi8_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi8_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi8_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi9_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi9_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi9_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi10_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi10_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi10_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi11_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi11_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi11_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi12_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi12_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi12_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi13_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi13_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi13_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi1_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi1_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi1_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi2_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi2_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi2_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi3_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi3_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi3_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi4_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi4_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi4_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi5_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi5_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi5_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi6_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi6_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi6_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi7_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi7_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi7_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi8_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi8_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi8_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi9_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi9_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi9_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi10_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi10_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi10_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi11_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi11_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi11_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi12_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi12_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi12_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi13_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi13_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi13_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi1_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi1_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi1_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi2_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi2_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi2_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi3_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi3_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi3_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi4_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi4_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi4_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi5_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi5_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi5_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi6_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi6_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi6_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi7_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi7_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi7_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi8_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi8_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi8_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi9_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi9_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi9_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi10_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi10_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi10_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi11_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi11_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi11_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi12_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi12_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi12_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi13_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi13_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi13_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi1_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi1_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi1_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi2_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi2_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi2_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi3_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi3_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi3_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi4_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi4_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi4_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi5_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi5_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi5_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi6_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi6_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi6_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi7_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi7_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi7_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi8_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi8_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi8_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi9_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi9_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi9_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi10_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi10_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi10_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi11_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi11_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi11_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi12_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi12_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi12_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi13_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi13_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi13_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi1_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi1_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi1_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi2_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi2_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi2_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi3_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi3_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi3_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi4_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi4_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi4_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi5_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi5_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi5_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi6_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi6_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi6_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi7_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi7_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi7_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi8_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi8_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi8_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi9_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi9_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi9_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi10_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi10_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi10_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi11_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi11_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi11_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi12_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi12_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi12_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi13_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi13_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi13_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_1_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_1_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_2_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_2_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_3_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_3_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_4_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_4_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_5_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_5_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_6_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_6_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_7_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_7_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_8_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_8_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_9_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_9_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_10_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_10_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_11_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_11_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_12_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_12_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_13_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_13_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_1_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_1_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_2_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_2_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_3_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_3_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_4_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_4_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_5_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_5_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_6_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_6_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_7_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_7_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_8_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_8_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_9_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_9_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_10_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_10_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_11_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_11_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_12_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_12_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_13_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_13_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis1_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis1_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis2_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis2_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis3_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis3_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis4_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis4_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis5_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis5_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis6_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis6_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis7_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis7_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis8_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis8_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis9_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis9_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis10_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis10_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis11_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis11_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis12_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis12_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis13_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis13_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis1_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis1_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis2_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis2_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis3_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis3_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis4_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis4_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis5_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis5_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis6_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis6_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis7_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis7_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis8_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis8_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis9_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis9_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis10_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis10_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis11_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis11_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis12_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis12_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis13_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis13_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur1_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur1_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur2_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur2_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur3_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur3_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur4_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur4_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur5_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur5_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur6_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur6_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur7_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur7_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur8_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur8_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur9_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur9_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur10_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur10_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur11_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur11_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur12_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur12_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur13_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur13_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur1_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur1_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur2_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur2_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur3_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur3_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur4_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur4_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur5_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur5_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur6_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur6_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur7_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur7_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur8_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur8_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur9_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur9_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur10_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur10_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur11_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur11_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur12_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur12_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur13_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur13_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln1_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln1_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln2_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln2_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln3_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln3_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln4_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln4_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln5_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln5_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln6_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln6_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln7_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln7_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln8_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln8_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln9_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln9_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln10_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln10_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln11_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln11_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln12_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln12_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln13_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln13_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln1_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln1_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln2_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln2_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln3_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln3_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln4_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln4_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln5_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln5_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln6_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln6_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln7_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln7_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln8_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln8_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln9_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln9_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln10_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln10_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln11_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln11_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln12_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln12_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln13_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln13_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tpbx", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tpbx", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tpbx", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tpbx", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tpsx", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tpsx", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tpsx", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tpsx", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tpmz", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tpmz", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tpmz", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tpmz", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_envw", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "envw", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_envw", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "envw", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ecow", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ecow", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ecow", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ecow", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_socw", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "socw", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_socw", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "socw", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_totpla", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "totpla", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_totpla", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "totpla", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod3", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod3", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod4", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod4", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod5", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod5", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod5", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod6", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod6", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod6", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod7", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod7", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod7", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod7", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod8", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod8", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod8", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod8", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod9", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod9", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod9", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod9", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod10", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod10", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod10", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod10", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod11", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod11", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod11", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod12", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod12", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod12", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod12", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod13", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod13", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod13", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod13", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds3", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds3", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds4", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds4", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds5", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds5", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds5", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds6", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds6", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds6", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds7", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds7", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds7", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds7", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds8", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds8", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds8", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds8", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds9", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds9", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds9", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds9", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds10", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds10", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds10", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds10", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds11", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds11", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds11", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds12", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds12", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds12", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds12", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds13", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds13", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds13", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds13", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss3", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss3", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss4", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss4", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss5", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss5", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss5", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss6", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss6", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss6", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss7", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss7", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss7", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss7", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss8", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss8", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss8", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss8", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss9", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss9", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss9", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss9", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss10", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss10", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss10", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss10", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss11", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss11", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss11", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss12", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss12", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss12", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss12", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss13", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss13", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss13", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss13", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agruf", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agruf", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agruf", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agruf", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrufro", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrufro", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrufro", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrufro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_induf", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "induf", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_induf", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "induf", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indufro", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indufro", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indufro", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indufro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lanuf", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lanuf", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lanuf", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lanuf", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lanufro", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lanufro", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lanufro", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lanufro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_gwsp", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "gwsp", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_gwsp", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "gwsp", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_sbqi", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sbqi", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_sbqi", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sbqi", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ssqi", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ssqi", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ssqi", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ssqi", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_smqi", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "smqi", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_smqi", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "smqi", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DataCreazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DataCreazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DataCreazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataCreazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UtenteCreazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UtenteCreazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UtenteCreazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UtenteCreazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DataAggiornamento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DataAggiornamento", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DataAggiornamento", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataAggiornamento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UtenteAggiornamento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UtenteAggiornamento", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UtenteAggiornamento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UtenteAggiornamento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Annullato", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Annullato", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Annullato", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Annullato", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DataEstrazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DataEstrazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DataEstrazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataEstrazione", System.Data.DataRowVersion.Original, Nothing)})
		'
		'SqlConnection
		'
		Me.SqlConnection.ConnectionString = "Data Source=economia11-181\sqlexpress;Initial Catalog=SDSS;Persist Security Info=" &
	"True;User ID=SDSS"
		Me.SqlConnection.FireInfoMessageEventOnUserErrors = False
		'
		'SqlInsertCommand
		'
		Me.SqlInsertCommand.CommandText = resources.GetString("SqlInsertCommand.CommandText")
		Me.SqlInsertCommand.Connection = Me.SqlConnection
		Me.SqlInsertCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@indcc1_1", System.Data.SqlDbType.Float, 0, "indcc1_1"), New System.Data.SqlClient.SqlParameter("@indcc2_1", System.Data.SqlDbType.Float, 0, "indcc2_1"), New System.Data.SqlClient.SqlParameter("@indcc3_1", System.Data.SqlDbType.Float, 0, "indcc3_1"), New System.Data.SqlClient.SqlParameter("@indcc4_1", System.Data.SqlDbType.Float, 0, "indcc4_1"), New System.Data.SqlClient.SqlParameter("@indcc5_1", System.Data.SqlDbType.Float, 0, "indcc5_1"), New System.Data.SqlClient.SqlParameter("@indcc6_1", System.Data.SqlDbType.Float, 0, "indcc6_1"), New System.Data.SqlClient.SqlParameter("@indcc7_1", System.Data.SqlDbType.Float, 0, "indcc7_1"), New System.Data.SqlClient.SqlParameter("@indcc8_1", System.Data.SqlDbType.Float, 0, "indcc8_1"), New System.Data.SqlClient.SqlParameter("@indcc9_1", System.Data.SqlDbType.Float, 0, "indcc9_1"), New System.Data.SqlClient.SqlParameter("@indcc10_1", System.Data.SqlDbType.Float, 0, "indcc10_1"), New System.Data.SqlClient.SqlParameter("@indcc11_1", System.Data.SqlDbType.Float, 0, "indcc11_1"), New System.Data.SqlClient.SqlParameter("@indcc12_1", System.Data.SqlDbType.Float, 0, "indcc12_1"), New System.Data.SqlClient.SqlParameter("@indcc13_1", System.Data.SqlDbType.Float, 0, "indcc13_1"), New System.Data.SqlClient.SqlParameter("@indcc1_2", System.Data.SqlDbType.Float, 0, "indcc1_2"), New System.Data.SqlClient.SqlParameter("@indcc2_2", System.Data.SqlDbType.Float, 0, "indcc2_2"), New System.Data.SqlClient.SqlParameter("@indcc3_2", System.Data.SqlDbType.Float, 0, "indcc3_2"), New System.Data.SqlClient.SqlParameter("@indcc4_2", System.Data.SqlDbType.Float, 0, "indcc4_2"), New System.Data.SqlClient.SqlParameter("@indcc5_2", System.Data.SqlDbType.Float, 0, "indcc5_2"), New System.Data.SqlClient.SqlParameter("@indcc6_2", System.Data.SqlDbType.Float, 0, "indcc6_2"), New System.Data.SqlClient.SqlParameter("@indcc7_2", System.Data.SqlDbType.Float, 0, "indcc7_2"), New System.Data.SqlClient.SqlParameter("@indcc8_2", System.Data.SqlDbType.Float, 0, "indcc8_2"), New System.Data.SqlClient.SqlParameter("@indcc9_2", System.Data.SqlDbType.Float, 0, "indcc9_2"), New System.Data.SqlClient.SqlParameter("@indcc10_2", System.Data.SqlDbType.Float, 0, "indcc10_2"), New System.Data.SqlClient.SqlParameter("@indcc11_2", System.Data.SqlDbType.Float, 0, "indcc11_2"), New System.Data.SqlClient.SqlParameter("@indcc12_2", System.Data.SqlDbType.Float, 0, "indcc12_2"), New System.Data.SqlClient.SqlParameter("@indcc13_2", System.Data.SqlDbType.Float, 0, "indcc13_2"), New System.Data.SqlClient.SqlParameter("@agrcc1_1", System.Data.SqlDbType.Float, 0, "agrcc1_1"), New System.Data.SqlClient.SqlParameter("@agrcc2_1", System.Data.SqlDbType.Float, 0, "agrcc2_1"), New System.Data.SqlClient.SqlParameter("@agrcc3_1", System.Data.SqlDbType.Float, 0, "agrcc3_1"), New System.Data.SqlClient.SqlParameter("@agrcc4_1", System.Data.SqlDbType.Float, 0, "agrcc4_1"), New System.Data.SqlClient.SqlParameter("@agrcc5_1", System.Data.SqlDbType.Float, 0, "agrcc5_1"), New System.Data.SqlClient.SqlParameter("@agrcc6_1", System.Data.SqlDbType.Float, 0, "agrcc6_1"), New System.Data.SqlClient.SqlParameter("@agrcc7_1", System.Data.SqlDbType.Float, 0, "agrcc7_1"), New System.Data.SqlClient.SqlParameter("@agrcc8_1", System.Data.SqlDbType.Float, 0, "agrcc8_1"), New System.Data.SqlClient.SqlParameter("@agrcc9_1", System.Data.SqlDbType.Float, 0, "agrcc9_1"), New System.Data.SqlClient.SqlParameter("@agrcc10_1", System.Data.SqlDbType.Float, 0, "agrcc10_1"), New System.Data.SqlClient.SqlParameter("@agrcc11_1", System.Data.SqlDbType.Float, 0, "agrcc11_1"), New System.Data.SqlClient.SqlParameter("@agrcc12_1", System.Data.SqlDbType.Float, 0, "agrcc12_1"), New System.Data.SqlClient.SqlParameter("@agrcc13_1", System.Data.SqlDbType.Float, 0, "agrcc13_1"), New System.Data.SqlClient.SqlParameter("@agrcc1_2", System.Data.SqlDbType.Float, 0, "agrcc1_2"), New System.Data.SqlClient.SqlParameter("@agrcc2_2", System.Data.SqlDbType.Float, 0, "agrcc2_2"), New System.Data.SqlClient.SqlParameter("@agrcc3_2", System.Data.SqlDbType.Float, 0, "agrcc3_2"), New System.Data.SqlClient.SqlParameter("@agrcc4_2", System.Data.SqlDbType.Float, 0, "agrcc4_2"), New System.Data.SqlClient.SqlParameter("@agrcc5_2", System.Data.SqlDbType.Float, 0, "agrcc5_2"), New System.Data.SqlClient.SqlParameter("@agrcc6_2", System.Data.SqlDbType.Float, 0, "agrcc6_2"), New System.Data.SqlClient.SqlParameter("@agrcc7_2", System.Data.SqlDbType.Float, 0, "agrcc7_2"), New System.Data.SqlClient.SqlParameter("@agrcc8_2", System.Data.SqlDbType.Float, 0, "agrcc8_2"), New System.Data.SqlClient.SqlParameter("@agrcc9_2", System.Data.SqlDbType.Float, 0, "agrcc9_2"), New System.Data.SqlClient.SqlParameter("@agrcc10_2", System.Data.SqlDbType.Float, 0, "agrcc10_2"), New System.Data.SqlClient.SqlParameter("@agrcc11_2", System.Data.SqlDbType.Float, 0, "agrcc11_2"), New System.Data.SqlClient.SqlParameter("@agrcc12_2", System.Data.SqlDbType.Float, 0, "agrcc12_2"), New System.Data.SqlClient.SqlParameter("@agrcc13_2", System.Data.SqlDbType.Float, 0, "agrcc13_2"), New System.Data.SqlClient.SqlParameter("@lancc1_1", System.Data.SqlDbType.Float, 0, "lancc1_1"), New System.Data.SqlClient.SqlParameter("@lancc2_1", System.Data.SqlDbType.Float, 0, "lancc2_1"), New System.Data.SqlClient.SqlParameter("@lancc3_1", System.Data.SqlDbType.Float, 0, "lancc3_1"), New System.Data.SqlClient.SqlParameter("@lancc4_1", System.Data.SqlDbType.Float, 0, "lancc4_1"), New System.Data.SqlClient.SqlParameter("@lancc5_1", System.Data.SqlDbType.Float, 0, "lancc5_1"), New System.Data.SqlClient.SqlParameter("@lancc6_1", System.Data.SqlDbType.Float, 0, "lancc6_1"), New System.Data.SqlClient.SqlParameter("@lancc7_1", System.Data.SqlDbType.Float, 0, "lancc7_1"), New System.Data.SqlClient.SqlParameter("@lancc8_1", System.Data.SqlDbType.Float, 0, "lancc8_1"), New System.Data.SqlClient.SqlParameter("@lancc9_1", System.Data.SqlDbType.Float, 0, "lancc9_1"), New System.Data.SqlClient.SqlParameter("@lancc10_1", System.Data.SqlDbType.Float, 0, "lancc10_1"), New System.Data.SqlClient.SqlParameter("@lancc11_1", System.Data.SqlDbType.Float, 0, "lancc11_1"), New System.Data.SqlClient.SqlParameter("@lancc12_1", System.Data.SqlDbType.Float, 0, "lancc12_1"), New System.Data.SqlClient.SqlParameter("@lancc13_1", System.Data.SqlDbType.Float, 0, "lancc13_1"), New System.Data.SqlClient.SqlParameter("@lancc1_2", System.Data.SqlDbType.Float, 0, "lancc1_2"), New System.Data.SqlClient.SqlParameter("@lancc2_2", System.Data.SqlDbType.Float, 0, "lancc2_2"), New System.Data.SqlClient.SqlParameter("@lancc3_2", System.Data.SqlDbType.Float, 0, "lancc3_2"), New System.Data.SqlClient.SqlParameter("@lancc4_2", System.Data.SqlDbType.Float, 0, "lancc4_2"), New System.Data.SqlClient.SqlParameter("@lancc5_2", System.Data.SqlDbType.Float, 0, "lancc5_2"), New System.Data.SqlClient.SqlParameter("@lancc6_2", System.Data.SqlDbType.Float, 0, "lancc6_2"), New System.Data.SqlClient.SqlParameter("@lancc7_2", System.Data.SqlDbType.Float, 0, "lancc7_2"), New System.Data.SqlClient.SqlParameter("@lancc8_2", System.Data.SqlDbType.Float, 0, "lancc8_2"), New System.Data.SqlClient.SqlParameter("@lancc9_2", System.Data.SqlDbType.Float, 0, "lancc9_2"), New System.Data.SqlClient.SqlParameter("@lancc10_2", System.Data.SqlDbType.Float, 0, "lancc10_2"), New System.Data.SqlClient.SqlParameter("@lancc11_2", System.Data.SqlDbType.Float, 0, "lancc11_2"), New System.Data.SqlClient.SqlParameter("@lancc12_2", System.Data.SqlDbType.Float, 0, "lancc12_2"), New System.Data.SqlClient.SqlParameter("@lancc13_2", System.Data.SqlDbType.Float, 0, "lancc13_2"), New System.Data.SqlClient.SqlParameter("@lbqi1_1", System.Data.SqlDbType.Float, 0, "lbqi1_1"), New System.Data.SqlClient.SqlParameter("@lbqi2_1", System.Data.SqlDbType.Float, 0, "lbqi2_1"), New System.Data.SqlClient.SqlParameter("@lbqi3_1", System.Data.SqlDbType.Float, 0, "lbqi3_1"), New System.Data.SqlClient.SqlParameter("@lbqi4_1", System.Data.SqlDbType.Float, 0, "lbqi4_1"), New System.Data.SqlClient.SqlParameter("@lbqi5_1", System.Data.SqlDbType.Float, 0, "lbqi5_1"), New System.Data.SqlClient.SqlParameter("@lbqi6_1", System.Data.SqlDbType.Float, 0, "lbqi6_1"), New System.Data.SqlClient.SqlParameter("@lbqi7_1", System.Data.SqlDbType.Float, 0, "lbqi7_1"), New System.Data.SqlClient.SqlParameter("@lbqi8_1", System.Data.SqlDbType.Float, 0, "lbqi8_1"), New System.Data.SqlClient.SqlParameter("@lbqi9_1", System.Data.SqlDbType.Float, 0, "lbqi9_1"), New System.Data.SqlClient.SqlParameter("@lbqi10_1", System.Data.SqlDbType.Float, 0, "lbqi10_1"), New System.Data.SqlClient.SqlParameter("@lbqi11_1", System.Data.SqlDbType.Float, 0, "lbqi11_1"), New System.Data.SqlClient.SqlParameter("@lbqi12_1", System.Data.SqlDbType.Float, 0, "lbqi12_1"), New System.Data.SqlClient.SqlParameter("@lbqi13_1", System.Data.SqlDbType.Float, 0, "lbqi13_1"), New System.Data.SqlClient.SqlParameter("@lbqi1_2", System.Data.SqlDbType.Float, 0, "lbqi1_2"), New System.Data.SqlClient.SqlParameter("@lbqi2_2", System.Data.SqlDbType.Float, 0, "lbqi2_2"), New System.Data.SqlClient.SqlParameter("@lbqi3_2", System.Data.SqlDbType.Float, 0, "lbqi3_2"), New System.Data.SqlClient.SqlParameter("@lbqi4_2", System.Data.SqlDbType.Float, 0, "lbqi4_2"), New System.Data.SqlClient.SqlParameter("@lbqi5_2", System.Data.SqlDbType.Float, 0, "lbqi5_2"), New System.Data.SqlClient.SqlParameter("@lbqi6_2", System.Data.SqlDbType.Float, 0, "lbqi6_2"), New System.Data.SqlClient.SqlParameter("@lbqi7_2", System.Data.SqlDbType.Float, 0, "lbqi7_2"), New System.Data.SqlClient.SqlParameter("@lbqi8_2", System.Data.SqlDbType.Float, 0, "lbqi8_2"), New System.Data.SqlClient.SqlParameter("@lbqi9_2", System.Data.SqlDbType.Float, 0, "lbqi9_2"), New System.Data.SqlClient.SqlParameter("@lbqi10_2", System.Data.SqlDbType.Float, 0, "lbqi10_2"), New System.Data.SqlClient.SqlParameter("@lbqi11_2", System.Data.SqlDbType.Float, 0, "lbqi11_2"), New System.Data.SqlClient.SqlParameter("@lbqi12_2", System.Data.SqlDbType.Float, 0, "lbqi12_2"), New System.Data.SqlClient.SqlParameter("@lbqi13_2", System.Data.SqlDbType.Float, 0, "lbqi13_2"), New System.Data.SqlClient.SqlParameter("@lsqi1_1", System.Data.SqlDbType.Float, 0, "lsqi1_1"), New System.Data.SqlClient.SqlParameter("@lsqi2_1", System.Data.SqlDbType.Float, 0, "lsqi2_1"), New System.Data.SqlClient.SqlParameter("@lsqi3_1", System.Data.SqlDbType.Float, 0, "lsqi3_1"), New System.Data.SqlClient.SqlParameter("@lsqi4_1", System.Data.SqlDbType.Float, 0, "lsqi4_1"), New System.Data.SqlClient.SqlParameter("@lsqi5_1", System.Data.SqlDbType.Float, 0, "lsqi5_1"), New System.Data.SqlClient.SqlParameter("@lsqi6_1", System.Data.SqlDbType.Float, 0, "lsqi6_1"), New System.Data.SqlClient.SqlParameter("@lsqi7_1", System.Data.SqlDbType.Float, 0, "lsqi7_1"), New System.Data.SqlClient.SqlParameter("@lsqi8_1", System.Data.SqlDbType.Float, 0, "lsqi8_1"), New System.Data.SqlClient.SqlParameter("@lsqi9_1", System.Data.SqlDbType.Float, 0, "lsqi9_1"), New System.Data.SqlClient.SqlParameter("@lsqi10_1", System.Data.SqlDbType.Float, 0, "lsqi10_1"), New System.Data.SqlClient.SqlParameter("@lsqi11_1", System.Data.SqlDbType.Float, 0, "lsqi11_1"), New System.Data.SqlClient.SqlParameter("@lsqi12_1", System.Data.SqlDbType.Float, 0, "lsqi12_1"), New System.Data.SqlClient.SqlParameter("@lsqi13_1", System.Data.SqlDbType.Float, 0, "lsqi13_1"), New System.Data.SqlClient.SqlParameter("@lsqi1_2", System.Data.SqlDbType.Float, 0, "lsqi1_2"), New System.Data.SqlClient.SqlParameter("@lsqi2_2", System.Data.SqlDbType.Float, 0, "lsqi2_2"), New System.Data.SqlClient.SqlParameter("@lsqi3_2", System.Data.SqlDbType.Float, 0, "lsqi3_2"), New System.Data.SqlClient.SqlParameter("@lsqi4_2", System.Data.SqlDbType.Float, 0, "lsqi4_2"), New System.Data.SqlClient.SqlParameter("@lsqi5_2", System.Data.SqlDbType.Float, 0, "lsqi5_2"), New System.Data.SqlClient.SqlParameter("@lsqi6_2", System.Data.SqlDbType.Float, 0, "lsqi6_2"), New System.Data.SqlClient.SqlParameter("@lsqi7_2", System.Data.SqlDbType.Float, 0, "lsqi7_2"), New System.Data.SqlClient.SqlParameter("@lsqi8_2", System.Data.SqlDbType.Float, 0, "lsqi8_2"), New System.Data.SqlClient.SqlParameter("@lsqi9_2", System.Data.SqlDbType.Float, 0, "lsqi9_2"), New System.Data.SqlClient.SqlParameter("@lsqi10_2", System.Data.SqlDbType.Float, 0, "lsqi10_2"), New System.Data.SqlClient.SqlParameter("@lsqi11_2", System.Data.SqlDbType.Float, 0, "lsqi11_2"), New System.Data.SqlClient.SqlParameter("@lsqi12_2", System.Data.SqlDbType.Float, 0, "lsqi12_2"), New System.Data.SqlClient.SqlParameter("@lsqi13_2", System.Data.SqlDbType.Float, 0, "lsqi13_2"), New System.Data.SqlClient.SqlParameter("@lmqi1_1", System.Data.SqlDbType.Float, 0, "lmqi1_1"), New System.Data.SqlClient.SqlParameter("@lmqi2_1", System.Data.SqlDbType.Float, 0, "lmqi2_1"), New System.Data.SqlClient.SqlParameter("@lmqi3_1", System.Data.SqlDbType.Float, 0, "lmqi3_1"), New System.Data.SqlClient.SqlParameter("@lmqi4_1", System.Data.SqlDbType.Float, 0, "lmqi4_1"), New System.Data.SqlClient.SqlParameter("@lmqi5_1", System.Data.SqlDbType.Float, 0, "lmqi5_1"), New System.Data.SqlClient.SqlParameter("@lmqi6_1", System.Data.SqlDbType.Float, 0, "lmqi6_1"), New System.Data.SqlClient.SqlParameter("@lmqi7_1", System.Data.SqlDbType.Float, 0, "lmqi7_1"), New System.Data.SqlClient.SqlParameter("@lmqi8_1", System.Data.SqlDbType.Float, 0, "lmqi8_1"), New System.Data.SqlClient.SqlParameter("@lmqi9_1", System.Data.SqlDbType.Float, 0, "lmqi9_1"), New System.Data.SqlClient.SqlParameter("@lmqi10_1", System.Data.SqlDbType.Float, 0, "lmqi10_1"), New System.Data.SqlClient.SqlParameter("@lmqi11_1", System.Data.SqlDbType.Float, 0, "lmqi11_1"), New System.Data.SqlClient.SqlParameter("@lmqi12_1", System.Data.SqlDbType.Float, 0, "lmqi12_1"), New System.Data.SqlClient.SqlParameter("@lmqi13_1", System.Data.SqlDbType.Float, 0, "lmqi13_1"), New System.Data.SqlClient.SqlParameter("@lmqi1_2", System.Data.SqlDbType.Float, 0, "lmqi1_2"), New System.Data.SqlClient.SqlParameter("@lmqi2_2", System.Data.SqlDbType.Float, 0, "lmqi2_2"), New System.Data.SqlClient.SqlParameter("@lmqi3_2", System.Data.SqlDbType.Float, 0, "lmqi3_2"), New System.Data.SqlClient.SqlParameter("@lmqi4_2", System.Data.SqlDbType.Float, 0, "lmqi4_2"), New System.Data.SqlClient.SqlParameter("@lmqi5_2", System.Data.SqlDbType.Float, 0, "lmqi5_2"), New System.Data.SqlClient.SqlParameter("@lmqi6_2", System.Data.SqlDbType.Float, 0, "lmqi6_2"), New System.Data.SqlClient.SqlParameter("@lmqi7_2", System.Data.SqlDbType.Float, 0, "lmqi7_2"), New System.Data.SqlClient.SqlParameter("@lmqi8_2", System.Data.SqlDbType.Float, 0, "lmqi8_2"), New System.Data.SqlClient.SqlParameter("@lmqi9_2", System.Data.SqlDbType.Float, 0, "lmqi9_2"), New System.Data.SqlClient.SqlParameter("@lmqi10_2", System.Data.SqlDbType.Float, 0, "lmqi10_2"), New System.Data.SqlClient.SqlParameter("@lmqi11_2", System.Data.SqlDbType.Float, 0, "lmqi11_2"), New System.Data.SqlClient.SqlParameter("@lmqi12_2", System.Data.SqlDbType.Float, 0, "lmqi12_2"), New System.Data.SqlClient.SqlParameter("@lmqi13_2", System.Data.SqlDbType.Float, 0, "lmqi13_2"), New System.Data.SqlClient.SqlParameter("@pop20_1_1", System.Data.SqlDbType.Int, 0, "pop20_1_1"), New System.Data.SqlClient.SqlParameter("@pop20_2_1", System.Data.SqlDbType.Int, 0, "pop20_2_1"), New System.Data.SqlClient.SqlParameter("@pop20_3_1", System.Data.SqlDbType.Int, 0, "pop20_3_1"), New System.Data.SqlClient.SqlParameter("@pop20_4_1", System.Data.SqlDbType.Int, 0, "pop20_4_1"), New System.Data.SqlClient.SqlParameter("@pop20_5_1", System.Data.SqlDbType.Int, 0, "pop20_5_1"), New System.Data.SqlClient.SqlParameter("@pop20_6_1", System.Data.SqlDbType.Int, 0, "pop20_6_1"), New System.Data.SqlClient.SqlParameter("@pop20_7_1", System.Data.SqlDbType.Int, 0, "pop20_7_1"), New System.Data.SqlClient.SqlParameter("@pop20_8_1", System.Data.SqlDbType.Int, 0, "pop20_8_1"), New System.Data.SqlClient.SqlParameter("@pop20_9_1", System.Data.SqlDbType.Int, 0, "pop20_9_1"), New System.Data.SqlClient.SqlParameter("@pop20_10_1", System.Data.SqlDbType.Int, 0, "pop20_10_1"), New System.Data.SqlClient.SqlParameter("@pop20_11_1", System.Data.SqlDbType.Int, 0, "pop20_11_1"), New System.Data.SqlClient.SqlParameter("@pop20_12_1", System.Data.SqlDbType.Int, 0, "pop20_12_1"), New System.Data.SqlClient.SqlParameter("@pop20_13_1", System.Data.SqlDbType.Int, 0, "pop20_13_1"), New System.Data.SqlClient.SqlParameter("@pop20_1_2", System.Data.SqlDbType.Int, 0, "pop20_1_2"), New System.Data.SqlClient.SqlParameter("@pop20_2_2", System.Data.SqlDbType.Int, 0, "pop20_2_2"), New System.Data.SqlClient.SqlParameter("@pop20_3_2", System.Data.SqlDbType.Int, 0, "pop20_3_2"), New System.Data.SqlClient.SqlParameter("@pop20_4_2", System.Data.SqlDbType.Int, 0, "pop20_4_2"), New System.Data.SqlClient.SqlParameter("@pop20_5_2", System.Data.SqlDbType.Int, 0, "pop20_5_2"), New System.Data.SqlClient.SqlParameter("@pop20_6_2", System.Data.SqlDbType.Int, 0, "pop20_6_2"), New System.Data.SqlClient.SqlParameter("@pop20_7_2", System.Data.SqlDbType.Int, 0, "pop20_7_2"), New System.Data.SqlClient.SqlParameter("@pop20_8_2", System.Data.SqlDbType.Int, 0, "pop20_8_2"), New System.Data.SqlClient.SqlParameter("@pop20_9_2", System.Data.SqlDbType.Int, 0, "pop20_9_2"), New System.Data.SqlClient.SqlParameter("@pop20_10_2", System.Data.SqlDbType.Int, 0, "pop20_10_2"), New System.Data.SqlClient.SqlParameter("@pop20_11_2", System.Data.SqlDbType.Int, 0, "pop20_11_2"), New System.Data.SqlClient.SqlParameter("@pop20_12_2", System.Data.SqlDbType.Int, 0, "pop20_12_2"), New System.Data.SqlClient.SqlParameter("@pop20_13_2", System.Data.SqlDbType.Int, 0, "pop20_13_2"), New System.Data.SqlClient.SqlParameter("@inddis1_1", System.Data.SqlDbType.Int, 0, "inddis1_1"), New System.Data.SqlClient.SqlParameter("@inddis2_1", System.Data.SqlDbType.Int, 0, "inddis2_1"), New System.Data.SqlClient.SqlParameter("@inddis3_1", System.Data.SqlDbType.Int, 0, "inddis3_1"), New System.Data.SqlClient.SqlParameter("@inddis4_1", System.Data.SqlDbType.Int, 0, "inddis4_1"), New System.Data.SqlClient.SqlParameter("@inddis5_1", System.Data.SqlDbType.Int, 0, "inddis5_1"), New System.Data.SqlClient.SqlParameter("@inddis6_1", System.Data.SqlDbType.Int, 0, "inddis6_1"), New System.Data.SqlClient.SqlParameter("@inddis7_1", System.Data.SqlDbType.Int, 0, "inddis7_1"), New System.Data.SqlClient.SqlParameter("@inddis8_1", System.Data.SqlDbType.Int, 0, "inddis8_1"), New System.Data.SqlClient.SqlParameter("@inddis9_1", System.Data.SqlDbType.Int, 0, "inddis9_1"), New System.Data.SqlClient.SqlParameter("@inddis10_1", System.Data.SqlDbType.Int, 0, "inddis10_1"), New System.Data.SqlClient.SqlParameter("@inddis11_1", System.Data.SqlDbType.Int, 0, "inddis11_1"), New System.Data.SqlClient.SqlParameter("@inddis12_1", System.Data.SqlDbType.Int, 0, "inddis12_1"), New System.Data.SqlClient.SqlParameter("@inddis13_1", System.Data.SqlDbType.Int, 0, "inddis13_1"), New System.Data.SqlClient.SqlParameter("@inddis1_2", System.Data.SqlDbType.Int, 0, "inddis1_2"), New System.Data.SqlClient.SqlParameter("@inddis2_2", System.Data.SqlDbType.Int, 0, "inddis2_2"), New System.Data.SqlClient.SqlParameter("@inddis3_2", System.Data.SqlDbType.Int, 0, "inddis3_2"), New System.Data.SqlClient.SqlParameter("@inddis4_2", System.Data.SqlDbType.Int, 0, "inddis4_2"), New System.Data.SqlClient.SqlParameter("@inddis5_2", System.Data.SqlDbType.Int, 0, "inddis5_2"), New System.Data.SqlClient.SqlParameter("@inddis6_2", System.Data.SqlDbType.Int, 0, "inddis6_2"), New System.Data.SqlClient.SqlParameter("@inddis7_2", System.Data.SqlDbType.Int, 0, "inddis7_2"), New System.Data.SqlClient.SqlParameter("@inddis8_2", System.Data.SqlDbType.Int, 0, "inddis8_2"), New System.Data.SqlClient.SqlParameter("@inddis9_2", System.Data.SqlDbType.Int, 0, "inddis9_2"), New System.Data.SqlClient.SqlParameter("@inddis10_2", System.Data.SqlDbType.Int, 0, "inddis10_2"), New System.Data.SqlClient.SqlParameter("@inddis11_2", System.Data.SqlDbType.Int, 0, "inddis11_2"), New System.Data.SqlClient.SqlParameter("@inddis12_2", System.Data.SqlDbType.Int, 0, "inddis12_2"), New System.Data.SqlClient.SqlParameter("@inddis13_2", System.Data.SqlDbType.Int, 0, "inddis13_2"), New System.Data.SqlClient.SqlParameter("@inddiscur1_1", System.Data.SqlDbType.Int, 0, "inddiscur1_1"), New System.Data.SqlClient.SqlParameter("@inddiscur2_1", System.Data.SqlDbType.Int, 0, "inddiscur2_1"), New System.Data.SqlClient.SqlParameter("@inddiscur3_1", System.Data.SqlDbType.Int, 0, "inddiscur3_1"), New System.Data.SqlClient.SqlParameter("@inddiscur4_1", System.Data.SqlDbType.Int, 0, "inddiscur4_1"), New System.Data.SqlClient.SqlParameter("@inddiscur5_1", System.Data.SqlDbType.Int, 0, "inddiscur5_1"), New System.Data.SqlClient.SqlParameter("@inddiscur6_1", System.Data.SqlDbType.Int, 0, "inddiscur6_1"), New System.Data.SqlClient.SqlParameter("@inddiscur7_1", System.Data.SqlDbType.Int, 0, "inddiscur7_1"), New System.Data.SqlClient.SqlParameter("@inddiscur8_1", System.Data.SqlDbType.Int, 0, "inddiscur8_1"), New System.Data.SqlClient.SqlParameter("@inddiscur9_1", System.Data.SqlDbType.Int, 0, "inddiscur9_1"), New System.Data.SqlClient.SqlParameter("@inddiscur10_1", System.Data.SqlDbType.Int, 0, "inddiscur10_1"), New System.Data.SqlClient.SqlParameter("@inddiscur11_1", System.Data.SqlDbType.Int, 0, "inddiscur11_1"), New System.Data.SqlClient.SqlParameter("@inddiscur12_1", System.Data.SqlDbType.Int, 0, "inddiscur12_1"), New System.Data.SqlClient.SqlParameter("@inddiscur13_1", System.Data.SqlDbType.Int, 0, "inddiscur13_1"), New System.Data.SqlClient.SqlParameter("@inddiscur1_2", System.Data.SqlDbType.Int, 0, "inddiscur1_2"), New System.Data.SqlClient.SqlParameter("@inddiscur2_2", System.Data.SqlDbType.Int, 0, "inddiscur2_2"), New System.Data.SqlClient.SqlParameter("@inddiscur3_2", System.Data.SqlDbType.Int, 0, "inddiscur3_2"), New System.Data.SqlClient.SqlParameter("@inddiscur4_2", System.Data.SqlDbType.Int, 0, "inddiscur4_2"), New System.Data.SqlClient.SqlParameter("@inddiscur5_2", System.Data.SqlDbType.Int, 0, "inddiscur5_2"), New System.Data.SqlClient.SqlParameter("@inddiscur6_2", System.Data.SqlDbType.Int, 0, "inddiscur6_2"), New System.Data.SqlClient.SqlParameter("@inddiscur7_2", System.Data.SqlDbType.Int, 0, "inddiscur7_2"), New System.Data.SqlClient.SqlParameter("@inddiscur8_2", System.Data.SqlDbType.Int, 0, "inddiscur8_2"), New System.Data.SqlClient.SqlParameter("@inddiscur9_2", System.Data.SqlDbType.Int, 0, "inddiscur9_2"), New System.Data.SqlClient.SqlParameter("@inddiscur10_2", System.Data.SqlDbType.Int, 0, "inddiscur10_2"), New System.Data.SqlClient.SqlParameter("@inddiscur11_2", System.Data.SqlDbType.Int, 0, "inddiscur11_2"), New System.Data.SqlClient.SqlParameter("@inddiscur12_2", System.Data.SqlDbType.Int, 0, "inddiscur12_2"), New System.Data.SqlClient.SqlParameter("@inddiscur13_2", System.Data.SqlDbType.Int, 0, "inddiscur13_2"), New System.Data.SqlClient.SqlParameter("@inddispln1_1", System.Data.SqlDbType.Int, 0, "inddispln1_1"), New System.Data.SqlClient.SqlParameter("@inddispln2_1", System.Data.SqlDbType.Int, 0, "inddispln2_1"), New System.Data.SqlClient.SqlParameter("@inddispln3_1", System.Data.SqlDbType.Int, 0, "inddispln3_1"), New System.Data.SqlClient.SqlParameter("@inddispln4_1", System.Data.SqlDbType.Int, 0, "inddispln4_1"), New System.Data.SqlClient.SqlParameter("@inddispln5_1", System.Data.SqlDbType.Int, 0, "inddispln5_1"), New System.Data.SqlClient.SqlParameter("@inddispln6_1", System.Data.SqlDbType.Int, 0, "inddispln6_1"), New System.Data.SqlClient.SqlParameter("@inddispln7_1", System.Data.SqlDbType.Int, 0, "inddispln7_1"), New System.Data.SqlClient.SqlParameter("@inddispln8_1", System.Data.SqlDbType.Int, 0, "inddispln8_1"), New System.Data.SqlClient.SqlParameter("@inddispln9_1", System.Data.SqlDbType.Int, 0, "inddispln9_1"), New System.Data.SqlClient.SqlParameter("@inddispln10_1", System.Data.SqlDbType.Int, 0, "inddispln10_1"), New System.Data.SqlClient.SqlParameter("@inddispln11_1", System.Data.SqlDbType.Int, 0, "inddispln11_1"), New System.Data.SqlClient.SqlParameter("@inddispln12_1", System.Data.SqlDbType.Int, 0, "inddispln12_1"), New System.Data.SqlClient.SqlParameter("@inddispln13_1", System.Data.SqlDbType.Int, 0, "inddispln13_1"), New System.Data.SqlClient.SqlParameter("@inddispln1_2", System.Data.SqlDbType.Int, 0, "inddispln1_2"), New System.Data.SqlClient.SqlParameter("@inddispln2_2", System.Data.SqlDbType.Int, 0, "inddispln2_2"), New System.Data.SqlClient.SqlParameter("@inddispln3_2", System.Data.SqlDbType.Int, 0, "inddispln3_2"), New System.Data.SqlClient.SqlParameter("@inddispln4_2", System.Data.SqlDbType.Int, 0, "inddispln4_2"), New System.Data.SqlClient.SqlParameter("@inddispln5_2", System.Data.SqlDbType.Int, 0, "inddispln5_2"), New System.Data.SqlClient.SqlParameter("@inddispln6_2", System.Data.SqlDbType.Int, 0, "inddispln6_2"), New System.Data.SqlClient.SqlParameter("@inddispln7_2", System.Data.SqlDbType.Int, 0, "inddispln7_2"), New System.Data.SqlClient.SqlParameter("@inddispln8_2", System.Data.SqlDbType.Int, 0, "inddispln8_2"), New System.Data.SqlClient.SqlParameter("@inddispln9_2", System.Data.SqlDbType.Int, 0, "inddispln9_2"), New System.Data.SqlClient.SqlParameter("@inddispln10_2", System.Data.SqlDbType.Int, 0, "inddispln10_2"), New System.Data.SqlClient.SqlParameter("@inddispln11_2", System.Data.SqlDbType.Int, 0, "inddispln11_2"), New System.Data.SqlClient.SqlParameter("@inddispln12_2", System.Data.SqlDbType.Int, 0, "inddispln12_2"), New System.Data.SqlClient.SqlParameter("@inddispln13_2", System.Data.SqlDbType.Int, 0, "inddispln13_2"), New System.Data.SqlClient.SqlParameter("@tpbx", System.Data.SqlDbType.Float, 0, "tpbx"), New System.Data.SqlClient.SqlParameter("@tpsx", System.Data.SqlDbType.Float, 0, "tpsx"), New System.Data.SqlClient.SqlParameter("@tpmz", System.Data.SqlDbType.Float, 0, "tpmz"), New System.Data.SqlClient.SqlParameter("@envw", System.Data.SqlDbType.Float, 0, "envw"), New System.Data.SqlClient.SqlParameter("@ecow", System.Data.SqlDbType.Float, 0, "ecow"), New System.Data.SqlClient.SqlParameter("@socw", System.Data.SqlDbType.Float, 0, "socw"), New System.Data.SqlClient.SqlParameter("@totpla", System.Data.SqlDbType.Int, 0, "totpla"), New System.Data.SqlClient.SqlParameter("@bod1", System.Data.SqlDbType.Float, 0, "bod1"), New System.Data.SqlClient.SqlParameter("@bod2", System.Data.SqlDbType.Float, 0, "bod2"), New System.Data.SqlClient.SqlParameter("@bod3", System.Data.SqlDbType.Float, 0, "bod3"), New System.Data.SqlClient.SqlParameter("@bod4", System.Data.SqlDbType.Float, 0, "bod4"), New System.Data.SqlClient.SqlParameter("@bod5", System.Data.SqlDbType.Float, 0, "bod5"), New System.Data.SqlClient.SqlParameter("@bod6", System.Data.SqlDbType.Float, 0, "bod6"), New System.Data.SqlClient.SqlParameter("@bod7", System.Data.SqlDbType.Float, 0, "bod7"), New System.Data.SqlClient.SqlParameter("@bod8", System.Data.SqlDbType.Float, 0, "bod8"), New System.Data.SqlClient.SqlParameter("@bod9", System.Data.SqlDbType.Float, 0, "bod9"), New System.Data.SqlClient.SqlParameter("@bod10", System.Data.SqlDbType.Float, 0, "bod10"), New System.Data.SqlClient.SqlParameter("@bod11", System.Data.SqlDbType.Float, 0, "bod11"), New System.Data.SqlClient.SqlParameter("@bod12", System.Data.SqlDbType.Float, 0, "bod12"), New System.Data.SqlClient.SqlParameter("@bod13", System.Data.SqlDbType.Float, 0, "bod13"), New System.Data.SqlClient.SqlParameter("@tds1", System.Data.SqlDbType.Float, 0, "tds1"), New System.Data.SqlClient.SqlParameter("@tds2", System.Data.SqlDbType.Float, 0, "tds2"), New System.Data.SqlClient.SqlParameter("@tds3", System.Data.SqlDbType.Float, 0, "tds3"), New System.Data.SqlClient.SqlParameter("@tds4", System.Data.SqlDbType.Float, 0, "tds4"), New System.Data.SqlClient.SqlParameter("@tds5", System.Data.SqlDbType.Float, 0, "tds5"), New System.Data.SqlClient.SqlParameter("@tds6", System.Data.SqlDbType.Float, 0, "tds6"), New System.Data.SqlClient.SqlParameter("@tds7", System.Data.SqlDbType.Float, 0, "tds7"), New System.Data.SqlClient.SqlParameter("@tds8", System.Data.SqlDbType.Float, 0, "tds8"), New System.Data.SqlClient.SqlParameter("@tds9", System.Data.SqlDbType.Float, 0, "tds9"), New System.Data.SqlClient.SqlParameter("@tds10", System.Data.SqlDbType.Float, 0, "tds10"), New System.Data.SqlClient.SqlParameter("@tds11", System.Data.SqlDbType.Float, 0, "tds11"), New System.Data.SqlClient.SqlParameter("@tds12", System.Data.SqlDbType.Float, 0, "tds12"), New System.Data.SqlClient.SqlParameter("@tds13", System.Data.SqlDbType.Float, 0, "tds13"), New System.Data.SqlClient.SqlParameter("@tss1", System.Data.SqlDbType.Float, 0, "tss1"), New System.Data.SqlClient.SqlParameter("@tss2", System.Data.SqlDbType.Float, 0, "tss2"), New System.Data.SqlClient.SqlParameter("@tss3", System.Data.SqlDbType.Float, 0, "tss3"), New System.Data.SqlClient.SqlParameter("@tss4", System.Data.SqlDbType.Float, 0, "tss4"), New System.Data.SqlClient.SqlParameter("@tss5", System.Data.SqlDbType.Float, 0, "tss5"), New System.Data.SqlClient.SqlParameter("@tss6", System.Data.SqlDbType.Float, 0, "tss6"), New System.Data.SqlClient.SqlParameter("@tss7", System.Data.SqlDbType.Float, 0, "tss7"), New System.Data.SqlClient.SqlParameter("@tss8", System.Data.SqlDbType.Float, 0, "tss8"), New System.Data.SqlClient.SqlParameter("@tss9", System.Data.SqlDbType.Float, 0, "tss9"), New System.Data.SqlClient.SqlParameter("@tss10", System.Data.SqlDbType.Float, 0, "tss10"), New System.Data.SqlClient.SqlParameter("@tss11", System.Data.SqlDbType.Float, 0, "tss11"), New System.Data.SqlClient.SqlParameter("@tss12", System.Data.SqlDbType.Float, 0, "tss12"), New System.Data.SqlClient.SqlParameter("@tss13", System.Data.SqlDbType.Float, 0, "tss13"), New System.Data.SqlClient.SqlParameter("@agruf", System.Data.SqlDbType.Float, 0, "agruf"), New System.Data.SqlClient.SqlParameter("@agrufro", System.Data.SqlDbType.Float, 0, "agrufro"), New System.Data.SqlClient.SqlParameter("@induf", System.Data.SqlDbType.Float, 0, "induf"), New System.Data.SqlClient.SqlParameter("@indufro", System.Data.SqlDbType.Float, 0, "indufro"), New System.Data.SqlClient.SqlParameter("@lanuf", System.Data.SqlDbType.Float, 0, "lanuf"), New System.Data.SqlClient.SqlParameter("@lanufro", System.Data.SqlDbType.Float, 0, "lanufro"), New System.Data.SqlClient.SqlParameter("@gwsp", System.Data.SqlDbType.Float, 0, "gwsp"), New System.Data.SqlClient.SqlParameter("@sbqi", System.Data.SqlDbType.Float, 0, "sbqi"), New System.Data.SqlClient.SqlParameter("@ssqi", System.Data.SqlDbType.Float, 0, "ssqi"), New System.Data.SqlClient.SqlParameter("@smqi", System.Data.SqlDbType.Float, 0, "smqi"), New System.Data.SqlClient.SqlParameter("@DataCreazione", System.Data.SqlDbType.DateTime, 0, "DataCreazione"), New System.Data.SqlClient.SqlParameter("@UtenteCreazione", System.Data.SqlDbType.Int, 0, "UtenteCreazione"), New System.Data.SqlClient.SqlParameter("@DataAggiornamento", System.Data.SqlDbType.DateTime, 0, "DataAggiornamento"), New System.Data.SqlClient.SqlParameter("@UtenteAggiornamento", System.Data.SqlDbType.Int, 0, "UtenteAggiornamento"), New System.Data.SqlClient.SqlParameter("@Annullato", System.Data.SqlDbType.Bit, 0, "Annullato"), New System.Data.SqlClient.SqlParameter("@DataEstrazione", System.Data.SqlDbType.DateTime, 0, "DataEstrazione")})
		'
		'SqlSelectCommand
		'
		Me.SqlSelectCommand.CommandText = resources.GetString("SqlSelectCommand.CommandText")
		Me.SqlSelectCommand.Connection = Me.SqlConnection
		'
		'SqlUpdateCommand
		'
		Me.SqlUpdateCommand.CommandText = resources.GetString("SqlUpdateCommand.CommandText")
		Me.SqlUpdateCommand.Connection = Me.SqlConnection
		Me.SqlUpdateCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@indcc1_1", System.Data.SqlDbType.Float, 0, "indcc1_1"), New System.Data.SqlClient.SqlParameter("@indcc2_1", System.Data.SqlDbType.Float, 0, "indcc2_1"), New System.Data.SqlClient.SqlParameter("@indcc3_1", System.Data.SqlDbType.Float, 0, "indcc3_1"), New System.Data.SqlClient.SqlParameter("@indcc4_1", System.Data.SqlDbType.Float, 0, "indcc4_1"), New System.Data.SqlClient.SqlParameter("@indcc5_1", System.Data.SqlDbType.Float, 0, "indcc5_1"), New System.Data.SqlClient.SqlParameter("@indcc6_1", System.Data.SqlDbType.Float, 0, "indcc6_1"), New System.Data.SqlClient.SqlParameter("@indcc7_1", System.Data.SqlDbType.Float, 0, "indcc7_1"), New System.Data.SqlClient.SqlParameter("@indcc8_1", System.Data.SqlDbType.Float, 0, "indcc8_1"), New System.Data.SqlClient.SqlParameter("@indcc9_1", System.Data.SqlDbType.Float, 0, "indcc9_1"), New System.Data.SqlClient.SqlParameter("@indcc10_1", System.Data.SqlDbType.Float, 0, "indcc10_1"), New System.Data.SqlClient.SqlParameter("@indcc11_1", System.Data.SqlDbType.Float, 0, "indcc11_1"), New System.Data.SqlClient.SqlParameter("@indcc12_1", System.Data.SqlDbType.Float, 0, "indcc12_1"), New System.Data.SqlClient.SqlParameter("@indcc13_1", System.Data.SqlDbType.Float, 0, "indcc13_1"), New System.Data.SqlClient.SqlParameter("@indcc1_2", System.Data.SqlDbType.Float, 0, "indcc1_2"), New System.Data.SqlClient.SqlParameter("@indcc2_2", System.Data.SqlDbType.Float, 0, "indcc2_2"), New System.Data.SqlClient.SqlParameter("@indcc3_2", System.Data.SqlDbType.Float, 0, "indcc3_2"), New System.Data.SqlClient.SqlParameter("@indcc4_2", System.Data.SqlDbType.Float, 0, "indcc4_2"), New System.Data.SqlClient.SqlParameter("@indcc5_2", System.Data.SqlDbType.Float, 0, "indcc5_2"), New System.Data.SqlClient.SqlParameter("@indcc6_2", System.Data.SqlDbType.Float, 0, "indcc6_2"), New System.Data.SqlClient.SqlParameter("@indcc7_2", System.Data.SqlDbType.Float, 0, "indcc7_2"), New System.Data.SqlClient.SqlParameter("@indcc8_2", System.Data.SqlDbType.Float, 0, "indcc8_2"), New System.Data.SqlClient.SqlParameter("@indcc9_2", System.Data.SqlDbType.Float, 0, "indcc9_2"), New System.Data.SqlClient.SqlParameter("@indcc10_2", System.Data.SqlDbType.Float, 0, "indcc10_2"), New System.Data.SqlClient.SqlParameter("@indcc11_2", System.Data.SqlDbType.Float, 0, "indcc11_2"), New System.Data.SqlClient.SqlParameter("@indcc12_2", System.Data.SqlDbType.Float, 0, "indcc12_2"), New System.Data.SqlClient.SqlParameter("@indcc13_2", System.Data.SqlDbType.Float, 0, "indcc13_2"), New System.Data.SqlClient.SqlParameter("@agrcc1_1", System.Data.SqlDbType.Float, 0, "agrcc1_1"), New System.Data.SqlClient.SqlParameter("@agrcc2_1", System.Data.SqlDbType.Float, 0, "agrcc2_1"), New System.Data.SqlClient.SqlParameter("@agrcc3_1", System.Data.SqlDbType.Float, 0, "agrcc3_1"), New System.Data.SqlClient.SqlParameter("@agrcc4_1", System.Data.SqlDbType.Float, 0, "agrcc4_1"), New System.Data.SqlClient.SqlParameter("@agrcc5_1", System.Data.SqlDbType.Float, 0, "agrcc5_1"), New System.Data.SqlClient.SqlParameter("@agrcc6_1", System.Data.SqlDbType.Float, 0, "agrcc6_1"), New System.Data.SqlClient.SqlParameter("@agrcc7_1", System.Data.SqlDbType.Float, 0, "agrcc7_1"), New System.Data.SqlClient.SqlParameter("@agrcc8_1", System.Data.SqlDbType.Float, 0, "agrcc8_1"), New System.Data.SqlClient.SqlParameter("@agrcc9_1", System.Data.SqlDbType.Float, 0, "agrcc9_1"), New System.Data.SqlClient.SqlParameter("@agrcc10_1", System.Data.SqlDbType.Float, 0, "agrcc10_1"), New System.Data.SqlClient.SqlParameter("@agrcc11_1", System.Data.SqlDbType.Float, 0, "agrcc11_1"), New System.Data.SqlClient.SqlParameter("@agrcc12_1", System.Data.SqlDbType.Float, 0, "agrcc12_1"), New System.Data.SqlClient.SqlParameter("@agrcc13_1", System.Data.SqlDbType.Float, 0, "agrcc13_1"), New System.Data.SqlClient.SqlParameter("@agrcc1_2", System.Data.SqlDbType.Float, 0, "agrcc1_2"), New System.Data.SqlClient.SqlParameter("@agrcc2_2", System.Data.SqlDbType.Float, 0, "agrcc2_2"), New System.Data.SqlClient.SqlParameter("@agrcc3_2", System.Data.SqlDbType.Float, 0, "agrcc3_2"), New System.Data.SqlClient.SqlParameter("@agrcc4_2", System.Data.SqlDbType.Float, 0, "agrcc4_2"), New System.Data.SqlClient.SqlParameter("@agrcc5_2", System.Data.SqlDbType.Float, 0, "agrcc5_2"), New System.Data.SqlClient.SqlParameter("@agrcc6_2", System.Data.SqlDbType.Float, 0, "agrcc6_2"), New System.Data.SqlClient.SqlParameter("@agrcc7_2", System.Data.SqlDbType.Float, 0, "agrcc7_2"), New System.Data.SqlClient.SqlParameter("@agrcc8_2", System.Data.SqlDbType.Float, 0, "agrcc8_2"), New System.Data.SqlClient.SqlParameter("@agrcc9_2", System.Data.SqlDbType.Float, 0, "agrcc9_2"), New System.Data.SqlClient.SqlParameter("@agrcc10_2", System.Data.SqlDbType.Float, 0, "agrcc10_2"), New System.Data.SqlClient.SqlParameter("@agrcc11_2", System.Data.SqlDbType.Float, 0, "agrcc11_2"), New System.Data.SqlClient.SqlParameter("@agrcc12_2", System.Data.SqlDbType.Float, 0, "agrcc12_2"), New System.Data.SqlClient.SqlParameter("@agrcc13_2", System.Data.SqlDbType.Float, 0, "agrcc13_2"), New System.Data.SqlClient.SqlParameter("@lancc1_1", System.Data.SqlDbType.Float, 0, "lancc1_1"), New System.Data.SqlClient.SqlParameter("@lancc2_1", System.Data.SqlDbType.Float, 0, "lancc2_1"), New System.Data.SqlClient.SqlParameter("@lancc3_1", System.Data.SqlDbType.Float, 0, "lancc3_1"), New System.Data.SqlClient.SqlParameter("@lancc4_1", System.Data.SqlDbType.Float, 0, "lancc4_1"), New System.Data.SqlClient.SqlParameter("@lancc5_1", System.Data.SqlDbType.Float, 0, "lancc5_1"), New System.Data.SqlClient.SqlParameter("@lancc6_1", System.Data.SqlDbType.Float, 0, "lancc6_1"), New System.Data.SqlClient.SqlParameter("@lancc7_1", System.Data.SqlDbType.Float, 0, "lancc7_1"), New System.Data.SqlClient.SqlParameter("@lancc8_1", System.Data.SqlDbType.Float, 0, "lancc8_1"), New System.Data.SqlClient.SqlParameter("@lancc9_1", System.Data.SqlDbType.Float, 0, "lancc9_1"), New System.Data.SqlClient.SqlParameter("@lancc10_1", System.Data.SqlDbType.Float, 0, "lancc10_1"), New System.Data.SqlClient.SqlParameter("@lancc11_1", System.Data.SqlDbType.Float, 0, "lancc11_1"), New System.Data.SqlClient.SqlParameter("@lancc12_1", System.Data.SqlDbType.Float, 0, "lancc12_1"), New System.Data.SqlClient.SqlParameter("@lancc13_1", System.Data.SqlDbType.Float, 0, "lancc13_1"), New System.Data.SqlClient.SqlParameter("@lancc1_2", System.Data.SqlDbType.Float, 0, "lancc1_2"), New System.Data.SqlClient.SqlParameter("@lancc2_2", System.Data.SqlDbType.Float, 0, "lancc2_2"), New System.Data.SqlClient.SqlParameter("@lancc3_2", System.Data.SqlDbType.Float, 0, "lancc3_2"), New System.Data.SqlClient.SqlParameter("@lancc4_2", System.Data.SqlDbType.Float, 0, "lancc4_2"), New System.Data.SqlClient.SqlParameter("@lancc5_2", System.Data.SqlDbType.Float, 0, "lancc5_2"), New System.Data.SqlClient.SqlParameter("@lancc6_2", System.Data.SqlDbType.Float, 0, "lancc6_2"), New System.Data.SqlClient.SqlParameter("@lancc7_2", System.Data.SqlDbType.Float, 0, "lancc7_2"), New System.Data.SqlClient.SqlParameter("@lancc8_2", System.Data.SqlDbType.Float, 0, "lancc8_2"), New System.Data.SqlClient.SqlParameter("@lancc9_2", System.Data.SqlDbType.Float, 0, "lancc9_2"), New System.Data.SqlClient.SqlParameter("@lancc10_2", System.Data.SqlDbType.Float, 0, "lancc10_2"), New System.Data.SqlClient.SqlParameter("@lancc11_2", System.Data.SqlDbType.Float, 0, "lancc11_2"), New System.Data.SqlClient.SqlParameter("@lancc12_2", System.Data.SqlDbType.Float, 0, "lancc12_2"), New System.Data.SqlClient.SqlParameter("@lancc13_2", System.Data.SqlDbType.Float, 0, "lancc13_2"), New System.Data.SqlClient.SqlParameter("@lbqi1_1", System.Data.SqlDbType.Float, 0, "lbqi1_1"), New System.Data.SqlClient.SqlParameter("@lbqi2_1", System.Data.SqlDbType.Float, 0, "lbqi2_1"), New System.Data.SqlClient.SqlParameter("@lbqi3_1", System.Data.SqlDbType.Float, 0, "lbqi3_1"), New System.Data.SqlClient.SqlParameter("@lbqi4_1", System.Data.SqlDbType.Float, 0, "lbqi4_1"), New System.Data.SqlClient.SqlParameter("@lbqi5_1", System.Data.SqlDbType.Float, 0, "lbqi5_1"), New System.Data.SqlClient.SqlParameter("@lbqi6_1", System.Data.SqlDbType.Float, 0, "lbqi6_1"), New System.Data.SqlClient.SqlParameter("@lbqi7_1", System.Data.SqlDbType.Float, 0, "lbqi7_1"), New System.Data.SqlClient.SqlParameter("@lbqi8_1", System.Data.SqlDbType.Float, 0, "lbqi8_1"), New System.Data.SqlClient.SqlParameter("@lbqi9_1", System.Data.SqlDbType.Float, 0, "lbqi9_1"), New System.Data.SqlClient.SqlParameter("@lbqi10_1", System.Data.SqlDbType.Float, 0, "lbqi10_1"), New System.Data.SqlClient.SqlParameter("@lbqi11_1", System.Data.SqlDbType.Float, 0, "lbqi11_1"), New System.Data.SqlClient.SqlParameter("@lbqi12_1", System.Data.SqlDbType.Float, 0, "lbqi12_1"), New System.Data.SqlClient.SqlParameter("@lbqi13_1", System.Data.SqlDbType.Float, 0, "lbqi13_1"), New System.Data.SqlClient.SqlParameter("@lbqi1_2", System.Data.SqlDbType.Float, 0, "lbqi1_2"), New System.Data.SqlClient.SqlParameter("@lbqi2_2", System.Data.SqlDbType.Float, 0, "lbqi2_2"), New System.Data.SqlClient.SqlParameter("@lbqi3_2", System.Data.SqlDbType.Float, 0, "lbqi3_2"), New System.Data.SqlClient.SqlParameter("@lbqi4_2", System.Data.SqlDbType.Float, 0, "lbqi4_2"), New System.Data.SqlClient.SqlParameter("@lbqi5_2", System.Data.SqlDbType.Float, 0, "lbqi5_2"), New System.Data.SqlClient.SqlParameter("@lbqi6_2", System.Data.SqlDbType.Float, 0, "lbqi6_2"), New System.Data.SqlClient.SqlParameter("@lbqi7_2", System.Data.SqlDbType.Float, 0, "lbqi7_2"), New System.Data.SqlClient.SqlParameter("@lbqi8_2", System.Data.SqlDbType.Float, 0, "lbqi8_2"), New System.Data.SqlClient.SqlParameter("@lbqi9_2", System.Data.SqlDbType.Float, 0, "lbqi9_2"), New System.Data.SqlClient.SqlParameter("@lbqi10_2", System.Data.SqlDbType.Float, 0, "lbqi10_2"), New System.Data.SqlClient.SqlParameter("@lbqi11_2", System.Data.SqlDbType.Float, 0, "lbqi11_2"), New System.Data.SqlClient.SqlParameter("@lbqi12_2", System.Data.SqlDbType.Float, 0, "lbqi12_2"), New System.Data.SqlClient.SqlParameter("@lbqi13_2", System.Data.SqlDbType.Float, 0, "lbqi13_2"), New System.Data.SqlClient.SqlParameter("@lsqi1_1", System.Data.SqlDbType.Float, 0, "lsqi1_1"), New System.Data.SqlClient.SqlParameter("@lsqi2_1", System.Data.SqlDbType.Float, 0, "lsqi2_1"), New System.Data.SqlClient.SqlParameter("@lsqi3_1", System.Data.SqlDbType.Float, 0, "lsqi3_1"), New System.Data.SqlClient.SqlParameter("@lsqi4_1", System.Data.SqlDbType.Float, 0, "lsqi4_1"), New System.Data.SqlClient.SqlParameter("@lsqi5_1", System.Data.SqlDbType.Float, 0, "lsqi5_1"), New System.Data.SqlClient.SqlParameter("@lsqi6_1", System.Data.SqlDbType.Float, 0, "lsqi6_1"), New System.Data.SqlClient.SqlParameter("@lsqi7_1", System.Data.SqlDbType.Float, 0, "lsqi7_1"), New System.Data.SqlClient.SqlParameter("@lsqi8_1", System.Data.SqlDbType.Float, 0, "lsqi8_1"), New System.Data.SqlClient.SqlParameter("@lsqi9_1", System.Data.SqlDbType.Float, 0, "lsqi9_1"), New System.Data.SqlClient.SqlParameter("@lsqi10_1", System.Data.SqlDbType.Float, 0, "lsqi10_1"), New System.Data.SqlClient.SqlParameter("@lsqi11_1", System.Data.SqlDbType.Float, 0, "lsqi11_1"), New System.Data.SqlClient.SqlParameter("@lsqi12_1", System.Data.SqlDbType.Float, 0, "lsqi12_1"), New System.Data.SqlClient.SqlParameter("@lsqi13_1", System.Data.SqlDbType.Float, 0, "lsqi13_1"), New System.Data.SqlClient.SqlParameter("@lsqi1_2", System.Data.SqlDbType.Float, 0, "lsqi1_2"), New System.Data.SqlClient.SqlParameter("@lsqi2_2", System.Data.SqlDbType.Float, 0, "lsqi2_2"), New System.Data.SqlClient.SqlParameter("@lsqi3_2", System.Data.SqlDbType.Float, 0, "lsqi3_2"), New System.Data.SqlClient.SqlParameter("@lsqi4_2", System.Data.SqlDbType.Float, 0, "lsqi4_2"), New System.Data.SqlClient.SqlParameter("@lsqi5_2", System.Data.SqlDbType.Float, 0, "lsqi5_2"), New System.Data.SqlClient.SqlParameter("@lsqi6_2", System.Data.SqlDbType.Float, 0, "lsqi6_2"), New System.Data.SqlClient.SqlParameter("@lsqi7_2", System.Data.SqlDbType.Float, 0, "lsqi7_2"), New System.Data.SqlClient.SqlParameter("@lsqi8_2", System.Data.SqlDbType.Float, 0, "lsqi8_2"), New System.Data.SqlClient.SqlParameter("@lsqi9_2", System.Data.SqlDbType.Float, 0, "lsqi9_2"), New System.Data.SqlClient.SqlParameter("@lsqi10_2", System.Data.SqlDbType.Float, 0, "lsqi10_2"), New System.Data.SqlClient.SqlParameter("@lsqi11_2", System.Data.SqlDbType.Float, 0, "lsqi11_2"), New System.Data.SqlClient.SqlParameter("@lsqi12_2", System.Data.SqlDbType.Float, 0, "lsqi12_2"), New System.Data.SqlClient.SqlParameter("@lsqi13_2", System.Data.SqlDbType.Float, 0, "lsqi13_2"), New System.Data.SqlClient.SqlParameter("@lmqi1_1", System.Data.SqlDbType.Float, 0, "lmqi1_1"), New System.Data.SqlClient.SqlParameter("@lmqi2_1", System.Data.SqlDbType.Float, 0, "lmqi2_1"), New System.Data.SqlClient.SqlParameter("@lmqi3_1", System.Data.SqlDbType.Float, 0, "lmqi3_1"), New System.Data.SqlClient.SqlParameter("@lmqi4_1", System.Data.SqlDbType.Float, 0, "lmqi4_1"), New System.Data.SqlClient.SqlParameter("@lmqi5_1", System.Data.SqlDbType.Float, 0, "lmqi5_1"), New System.Data.SqlClient.SqlParameter("@lmqi6_1", System.Data.SqlDbType.Float, 0, "lmqi6_1"), New System.Data.SqlClient.SqlParameter("@lmqi7_1", System.Data.SqlDbType.Float, 0, "lmqi7_1"), New System.Data.SqlClient.SqlParameter("@lmqi8_1", System.Data.SqlDbType.Float, 0, "lmqi8_1"), New System.Data.SqlClient.SqlParameter("@lmqi9_1", System.Data.SqlDbType.Float, 0, "lmqi9_1"), New System.Data.SqlClient.SqlParameter("@lmqi10_1", System.Data.SqlDbType.Float, 0, "lmqi10_1"), New System.Data.SqlClient.SqlParameter("@lmqi11_1", System.Data.SqlDbType.Float, 0, "lmqi11_1"), New System.Data.SqlClient.SqlParameter("@lmqi12_1", System.Data.SqlDbType.Float, 0, "lmqi12_1"), New System.Data.SqlClient.SqlParameter("@lmqi13_1", System.Data.SqlDbType.Float, 0, "lmqi13_1"), New System.Data.SqlClient.SqlParameter("@lmqi1_2", System.Data.SqlDbType.Float, 0, "lmqi1_2"), New System.Data.SqlClient.SqlParameter("@lmqi2_2", System.Data.SqlDbType.Float, 0, "lmqi2_2"), New System.Data.SqlClient.SqlParameter("@lmqi3_2", System.Data.SqlDbType.Float, 0, "lmqi3_2"), New System.Data.SqlClient.SqlParameter("@lmqi4_2", System.Data.SqlDbType.Float, 0, "lmqi4_2"), New System.Data.SqlClient.SqlParameter("@lmqi5_2", System.Data.SqlDbType.Float, 0, "lmqi5_2"), New System.Data.SqlClient.SqlParameter("@lmqi6_2", System.Data.SqlDbType.Float, 0, "lmqi6_2"), New System.Data.SqlClient.SqlParameter("@lmqi7_2", System.Data.SqlDbType.Float, 0, "lmqi7_2"), New System.Data.SqlClient.SqlParameter("@lmqi8_2", System.Data.SqlDbType.Float, 0, "lmqi8_2"), New System.Data.SqlClient.SqlParameter("@lmqi9_2", System.Data.SqlDbType.Float, 0, "lmqi9_2"), New System.Data.SqlClient.SqlParameter("@lmqi10_2", System.Data.SqlDbType.Float, 0, "lmqi10_2"), New System.Data.SqlClient.SqlParameter("@lmqi11_2", System.Data.SqlDbType.Float, 0, "lmqi11_2"), New System.Data.SqlClient.SqlParameter("@lmqi12_2", System.Data.SqlDbType.Float, 0, "lmqi12_2"), New System.Data.SqlClient.SqlParameter("@lmqi13_2", System.Data.SqlDbType.Float, 0, "lmqi13_2"), New System.Data.SqlClient.SqlParameter("@pop20_1_1", System.Data.SqlDbType.Int, 0, "pop20_1_1"), New System.Data.SqlClient.SqlParameter("@pop20_2_1", System.Data.SqlDbType.Int, 0, "pop20_2_1"), New System.Data.SqlClient.SqlParameter("@pop20_3_1", System.Data.SqlDbType.Int, 0, "pop20_3_1"), New System.Data.SqlClient.SqlParameter("@pop20_4_1", System.Data.SqlDbType.Int, 0, "pop20_4_1"), New System.Data.SqlClient.SqlParameter("@pop20_5_1", System.Data.SqlDbType.Int, 0, "pop20_5_1"), New System.Data.SqlClient.SqlParameter("@pop20_6_1", System.Data.SqlDbType.Int, 0, "pop20_6_1"), New System.Data.SqlClient.SqlParameter("@pop20_7_1", System.Data.SqlDbType.Int, 0, "pop20_7_1"), New System.Data.SqlClient.SqlParameter("@pop20_8_1", System.Data.SqlDbType.Int, 0, "pop20_8_1"), New System.Data.SqlClient.SqlParameter("@pop20_9_1", System.Data.SqlDbType.Int, 0, "pop20_9_1"), New System.Data.SqlClient.SqlParameter("@pop20_10_1", System.Data.SqlDbType.Int, 0, "pop20_10_1"), New System.Data.SqlClient.SqlParameter("@pop20_11_1", System.Data.SqlDbType.Int, 0, "pop20_11_1"), New System.Data.SqlClient.SqlParameter("@pop20_12_1", System.Data.SqlDbType.Int, 0, "pop20_12_1"), New System.Data.SqlClient.SqlParameter("@pop20_13_1", System.Data.SqlDbType.Int, 0, "pop20_13_1"), New System.Data.SqlClient.SqlParameter("@pop20_1_2", System.Data.SqlDbType.Int, 0, "pop20_1_2"), New System.Data.SqlClient.SqlParameter("@pop20_2_2", System.Data.SqlDbType.Int, 0, "pop20_2_2"), New System.Data.SqlClient.SqlParameter("@pop20_3_2", System.Data.SqlDbType.Int, 0, "pop20_3_2"), New System.Data.SqlClient.SqlParameter("@pop20_4_2", System.Data.SqlDbType.Int, 0, "pop20_4_2"), New System.Data.SqlClient.SqlParameter("@pop20_5_2", System.Data.SqlDbType.Int, 0, "pop20_5_2"), New System.Data.SqlClient.SqlParameter("@pop20_6_2", System.Data.SqlDbType.Int, 0, "pop20_6_2"), New System.Data.SqlClient.SqlParameter("@pop20_7_2", System.Data.SqlDbType.Int, 0, "pop20_7_2"), New System.Data.SqlClient.SqlParameter("@pop20_8_2", System.Data.SqlDbType.Int, 0, "pop20_8_2"), New System.Data.SqlClient.SqlParameter("@pop20_9_2", System.Data.SqlDbType.Int, 0, "pop20_9_2"), New System.Data.SqlClient.SqlParameter("@pop20_10_2", System.Data.SqlDbType.Int, 0, "pop20_10_2"), New System.Data.SqlClient.SqlParameter("@pop20_11_2", System.Data.SqlDbType.Int, 0, "pop20_11_2"), New System.Data.SqlClient.SqlParameter("@pop20_12_2", System.Data.SqlDbType.Int, 0, "pop20_12_2"), New System.Data.SqlClient.SqlParameter("@pop20_13_2", System.Data.SqlDbType.Int, 0, "pop20_13_2"), New System.Data.SqlClient.SqlParameter("@inddis1_1", System.Data.SqlDbType.Int, 0, "inddis1_1"), New System.Data.SqlClient.SqlParameter("@inddis2_1", System.Data.SqlDbType.Int, 0, "inddis2_1"), New System.Data.SqlClient.SqlParameter("@inddis3_1", System.Data.SqlDbType.Int, 0, "inddis3_1"), New System.Data.SqlClient.SqlParameter("@inddis4_1", System.Data.SqlDbType.Int, 0, "inddis4_1"), New System.Data.SqlClient.SqlParameter("@inddis5_1", System.Data.SqlDbType.Int, 0, "inddis5_1"), New System.Data.SqlClient.SqlParameter("@inddis6_1", System.Data.SqlDbType.Int, 0, "inddis6_1"), New System.Data.SqlClient.SqlParameter("@inddis7_1", System.Data.SqlDbType.Int, 0, "inddis7_1"), New System.Data.SqlClient.SqlParameter("@inddis8_1", System.Data.SqlDbType.Int, 0, "inddis8_1"), New System.Data.SqlClient.SqlParameter("@inddis9_1", System.Data.SqlDbType.Int, 0, "inddis9_1"), New System.Data.SqlClient.SqlParameter("@inddis10_1", System.Data.SqlDbType.Int, 0, "inddis10_1"), New System.Data.SqlClient.SqlParameter("@inddis11_1", System.Data.SqlDbType.Int, 0, "inddis11_1"), New System.Data.SqlClient.SqlParameter("@inddis12_1", System.Data.SqlDbType.Int, 0, "inddis12_1"), New System.Data.SqlClient.SqlParameter("@inddis13_1", System.Data.SqlDbType.Int, 0, "inddis13_1"), New System.Data.SqlClient.SqlParameter("@inddis1_2", System.Data.SqlDbType.Int, 0, "inddis1_2"), New System.Data.SqlClient.SqlParameter("@inddis2_2", System.Data.SqlDbType.Int, 0, "inddis2_2"), New System.Data.SqlClient.SqlParameter("@inddis3_2", System.Data.SqlDbType.Int, 0, "inddis3_2"), New System.Data.SqlClient.SqlParameter("@inddis4_2", System.Data.SqlDbType.Int, 0, "inddis4_2"), New System.Data.SqlClient.SqlParameter("@inddis5_2", System.Data.SqlDbType.Int, 0, "inddis5_2"), New System.Data.SqlClient.SqlParameter("@inddis6_2", System.Data.SqlDbType.Int, 0, "inddis6_2"), New System.Data.SqlClient.SqlParameter("@inddis7_2", System.Data.SqlDbType.Int, 0, "inddis7_2"), New System.Data.SqlClient.SqlParameter("@inddis8_2", System.Data.SqlDbType.Int, 0, "inddis8_2"), New System.Data.SqlClient.SqlParameter("@inddis9_2", System.Data.SqlDbType.Int, 0, "inddis9_2"), New System.Data.SqlClient.SqlParameter("@inddis10_2", System.Data.SqlDbType.Int, 0, "inddis10_2"), New System.Data.SqlClient.SqlParameter("@inddis11_2", System.Data.SqlDbType.Int, 0, "inddis11_2"), New System.Data.SqlClient.SqlParameter("@inddis12_2", System.Data.SqlDbType.Int, 0, "inddis12_2"), New System.Data.SqlClient.SqlParameter("@inddis13_2", System.Data.SqlDbType.Int, 0, "inddis13_2"), New System.Data.SqlClient.SqlParameter("@inddiscur1_1", System.Data.SqlDbType.Int, 0, "inddiscur1_1"), New System.Data.SqlClient.SqlParameter("@inddiscur2_1", System.Data.SqlDbType.Int, 0, "inddiscur2_1"), New System.Data.SqlClient.SqlParameter("@inddiscur3_1", System.Data.SqlDbType.Int, 0, "inddiscur3_1"), New System.Data.SqlClient.SqlParameter("@inddiscur4_1", System.Data.SqlDbType.Int, 0, "inddiscur4_1"), New System.Data.SqlClient.SqlParameter("@inddiscur5_1", System.Data.SqlDbType.Int, 0, "inddiscur5_1"), New System.Data.SqlClient.SqlParameter("@inddiscur6_1", System.Data.SqlDbType.Int, 0, "inddiscur6_1"), New System.Data.SqlClient.SqlParameter("@inddiscur7_1", System.Data.SqlDbType.Int, 0, "inddiscur7_1"), New System.Data.SqlClient.SqlParameter("@inddiscur8_1", System.Data.SqlDbType.Int, 0, "inddiscur8_1"), New System.Data.SqlClient.SqlParameter("@inddiscur9_1", System.Data.SqlDbType.Int, 0, "inddiscur9_1"), New System.Data.SqlClient.SqlParameter("@inddiscur10_1", System.Data.SqlDbType.Int, 0, "inddiscur10_1"), New System.Data.SqlClient.SqlParameter("@inddiscur11_1", System.Data.SqlDbType.Int, 0, "inddiscur11_1"), New System.Data.SqlClient.SqlParameter("@inddiscur12_1", System.Data.SqlDbType.Int, 0, "inddiscur12_1"), New System.Data.SqlClient.SqlParameter("@inddiscur13_1", System.Data.SqlDbType.Int, 0, "inddiscur13_1"), New System.Data.SqlClient.SqlParameter("@inddiscur1_2", System.Data.SqlDbType.Int, 0, "inddiscur1_2"), New System.Data.SqlClient.SqlParameter("@inddiscur2_2", System.Data.SqlDbType.Int, 0, "inddiscur2_2"), New System.Data.SqlClient.SqlParameter("@inddiscur3_2", System.Data.SqlDbType.Int, 0, "inddiscur3_2"), New System.Data.SqlClient.SqlParameter("@inddiscur4_2", System.Data.SqlDbType.Int, 0, "inddiscur4_2"), New System.Data.SqlClient.SqlParameter("@inddiscur5_2", System.Data.SqlDbType.Int, 0, "inddiscur5_2"), New System.Data.SqlClient.SqlParameter("@inddiscur6_2", System.Data.SqlDbType.Int, 0, "inddiscur6_2"), New System.Data.SqlClient.SqlParameter("@inddiscur7_2", System.Data.SqlDbType.Int, 0, "inddiscur7_2"), New System.Data.SqlClient.SqlParameter("@inddiscur8_2", System.Data.SqlDbType.Int, 0, "inddiscur8_2"), New System.Data.SqlClient.SqlParameter("@inddiscur9_2", System.Data.SqlDbType.Int, 0, "inddiscur9_2"), New System.Data.SqlClient.SqlParameter("@inddiscur10_2", System.Data.SqlDbType.Int, 0, "inddiscur10_2"), New System.Data.SqlClient.SqlParameter("@inddiscur11_2", System.Data.SqlDbType.Int, 0, "inddiscur11_2"), New System.Data.SqlClient.SqlParameter("@inddiscur12_2", System.Data.SqlDbType.Int, 0, "inddiscur12_2"), New System.Data.SqlClient.SqlParameter("@inddiscur13_2", System.Data.SqlDbType.Int, 0, "inddiscur13_2"), New System.Data.SqlClient.SqlParameter("@inddispln1_1", System.Data.SqlDbType.Int, 0, "inddispln1_1"), New System.Data.SqlClient.SqlParameter("@inddispln2_1", System.Data.SqlDbType.Int, 0, "inddispln2_1"), New System.Data.SqlClient.SqlParameter("@inddispln3_1", System.Data.SqlDbType.Int, 0, "inddispln3_1"), New System.Data.SqlClient.SqlParameter("@inddispln4_1", System.Data.SqlDbType.Int, 0, "inddispln4_1"), New System.Data.SqlClient.SqlParameter("@inddispln5_1", System.Data.SqlDbType.Int, 0, "inddispln5_1"), New System.Data.SqlClient.SqlParameter("@inddispln6_1", System.Data.SqlDbType.Int, 0, "inddispln6_1"), New System.Data.SqlClient.SqlParameter("@inddispln7_1", System.Data.SqlDbType.Int, 0, "inddispln7_1"), New System.Data.SqlClient.SqlParameter("@inddispln8_1", System.Data.SqlDbType.Int, 0, "inddispln8_1"), New System.Data.SqlClient.SqlParameter("@inddispln9_1", System.Data.SqlDbType.Int, 0, "inddispln9_1"), New System.Data.SqlClient.SqlParameter("@inddispln10_1", System.Data.SqlDbType.Int, 0, "inddispln10_1"), New System.Data.SqlClient.SqlParameter("@inddispln11_1", System.Data.SqlDbType.Int, 0, "inddispln11_1"), New System.Data.SqlClient.SqlParameter("@inddispln12_1", System.Data.SqlDbType.Int, 0, "inddispln12_1"), New System.Data.SqlClient.SqlParameter("@inddispln13_1", System.Data.SqlDbType.Int, 0, "inddispln13_1"), New System.Data.SqlClient.SqlParameter("@inddispln1_2", System.Data.SqlDbType.Int, 0, "inddispln1_2"), New System.Data.SqlClient.SqlParameter("@inddispln2_2", System.Data.SqlDbType.Int, 0, "inddispln2_2"), New System.Data.SqlClient.SqlParameter("@inddispln3_2", System.Data.SqlDbType.Int, 0, "inddispln3_2"), New System.Data.SqlClient.SqlParameter("@inddispln4_2", System.Data.SqlDbType.Int, 0, "inddispln4_2"), New System.Data.SqlClient.SqlParameter("@inddispln5_2", System.Data.SqlDbType.Int, 0, "inddispln5_2"), New System.Data.SqlClient.SqlParameter("@inddispln6_2", System.Data.SqlDbType.Int, 0, "inddispln6_2"), New System.Data.SqlClient.SqlParameter("@inddispln7_2", System.Data.SqlDbType.Int, 0, "inddispln7_2"), New System.Data.SqlClient.SqlParameter("@inddispln8_2", System.Data.SqlDbType.Int, 0, "inddispln8_2"), New System.Data.SqlClient.SqlParameter("@inddispln9_2", System.Data.SqlDbType.Int, 0, "inddispln9_2"), New System.Data.SqlClient.SqlParameter("@inddispln10_2", System.Data.SqlDbType.Int, 0, "inddispln10_2"), New System.Data.SqlClient.SqlParameter("@inddispln11_2", System.Data.SqlDbType.Int, 0, "inddispln11_2"), New System.Data.SqlClient.SqlParameter("@inddispln12_2", System.Data.SqlDbType.Int, 0, "inddispln12_2"), New System.Data.SqlClient.SqlParameter("@inddispln13_2", System.Data.SqlDbType.Int, 0, "inddispln13_2"), New System.Data.SqlClient.SqlParameter("@tpbx", System.Data.SqlDbType.Float, 0, "tpbx"), New System.Data.SqlClient.SqlParameter("@tpsx", System.Data.SqlDbType.Float, 0, "tpsx"), New System.Data.SqlClient.SqlParameter("@tpmz", System.Data.SqlDbType.Float, 0, "tpmz"), New System.Data.SqlClient.SqlParameter("@envw", System.Data.SqlDbType.Float, 0, "envw"), New System.Data.SqlClient.SqlParameter("@ecow", System.Data.SqlDbType.Float, 0, "ecow"), New System.Data.SqlClient.SqlParameter("@socw", System.Data.SqlDbType.Float, 0, "socw"), New System.Data.SqlClient.SqlParameter("@totpla", System.Data.SqlDbType.Int, 0, "totpla"), New System.Data.SqlClient.SqlParameter("@bod1", System.Data.SqlDbType.Float, 0, "bod1"), New System.Data.SqlClient.SqlParameter("@bod2", System.Data.SqlDbType.Float, 0, "bod2"), New System.Data.SqlClient.SqlParameter("@bod3", System.Data.SqlDbType.Float, 0, "bod3"), New System.Data.SqlClient.SqlParameter("@bod4", System.Data.SqlDbType.Float, 0, "bod4"), New System.Data.SqlClient.SqlParameter("@bod5", System.Data.SqlDbType.Float, 0, "bod5"), New System.Data.SqlClient.SqlParameter("@bod6", System.Data.SqlDbType.Float, 0, "bod6"), New System.Data.SqlClient.SqlParameter("@bod7", System.Data.SqlDbType.Float, 0, "bod7"), New System.Data.SqlClient.SqlParameter("@bod8", System.Data.SqlDbType.Float, 0, "bod8"), New System.Data.SqlClient.SqlParameter("@bod9", System.Data.SqlDbType.Float, 0, "bod9"), New System.Data.SqlClient.SqlParameter("@bod10", System.Data.SqlDbType.Float, 0, "bod10"), New System.Data.SqlClient.SqlParameter("@bod11", System.Data.SqlDbType.Float, 0, "bod11"), New System.Data.SqlClient.SqlParameter("@bod12", System.Data.SqlDbType.Float, 0, "bod12"), New System.Data.SqlClient.SqlParameter("@bod13", System.Data.SqlDbType.Float, 0, "bod13"), New System.Data.SqlClient.SqlParameter("@tds1", System.Data.SqlDbType.Float, 0, "tds1"), New System.Data.SqlClient.SqlParameter("@tds2", System.Data.SqlDbType.Float, 0, "tds2"), New System.Data.SqlClient.SqlParameter("@tds3", System.Data.SqlDbType.Float, 0, "tds3"), New System.Data.SqlClient.SqlParameter("@tds4", System.Data.SqlDbType.Float, 0, "tds4"), New System.Data.SqlClient.SqlParameter("@tds5", System.Data.SqlDbType.Float, 0, "tds5"), New System.Data.SqlClient.SqlParameter("@tds6", System.Data.SqlDbType.Float, 0, "tds6"), New System.Data.SqlClient.SqlParameter("@tds7", System.Data.SqlDbType.Float, 0, "tds7"), New System.Data.SqlClient.SqlParameter("@tds8", System.Data.SqlDbType.Float, 0, "tds8"), New System.Data.SqlClient.SqlParameter("@tds9", System.Data.SqlDbType.Float, 0, "tds9"), New System.Data.SqlClient.SqlParameter("@tds10", System.Data.SqlDbType.Float, 0, "tds10"), New System.Data.SqlClient.SqlParameter("@tds11", System.Data.SqlDbType.Float, 0, "tds11"), New System.Data.SqlClient.SqlParameter("@tds12", System.Data.SqlDbType.Float, 0, "tds12"), New System.Data.SqlClient.SqlParameter("@tds13", System.Data.SqlDbType.Float, 0, "tds13"), New System.Data.SqlClient.SqlParameter("@tss1", System.Data.SqlDbType.Float, 0, "tss1"), New System.Data.SqlClient.SqlParameter("@tss2", System.Data.SqlDbType.Float, 0, "tss2"), New System.Data.SqlClient.SqlParameter("@tss3", System.Data.SqlDbType.Float, 0, "tss3"), New System.Data.SqlClient.SqlParameter("@tss4", System.Data.SqlDbType.Float, 0, "tss4"), New System.Data.SqlClient.SqlParameter("@tss5", System.Data.SqlDbType.Float, 0, "tss5"), New System.Data.SqlClient.SqlParameter("@tss6", System.Data.SqlDbType.Float, 0, "tss6"), New System.Data.SqlClient.SqlParameter("@tss7", System.Data.SqlDbType.Float, 0, "tss7"), New System.Data.SqlClient.SqlParameter("@tss8", System.Data.SqlDbType.Float, 0, "tss8"), New System.Data.SqlClient.SqlParameter("@tss9", System.Data.SqlDbType.Float, 0, "tss9"), New System.Data.SqlClient.SqlParameter("@tss10", System.Data.SqlDbType.Float, 0, "tss10"), New System.Data.SqlClient.SqlParameter("@tss11", System.Data.SqlDbType.Float, 0, "tss11"), New System.Data.SqlClient.SqlParameter("@tss12", System.Data.SqlDbType.Float, 0, "tss12"), New System.Data.SqlClient.SqlParameter("@tss13", System.Data.SqlDbType.Float, 0, "tss13"), New System.Data.SqlClient.SqlParameter("@agruf", System.Data.SqlDbType.Float, 0, "agruf"), New System.Data.SqlClient.SqlParameter("@agrufro", System.Data.SqlDbType.Float, 0, "agrufro"), New System.Data.SqlClient.SqlParameter("@induf", System.Data.SqlDbType.Float, 0, "induf"), New System.Data.SqlClient.SqlParameter("@indufro", System.Data.SqlDbType.Float, 0, "indufro"), New System.Data.SqlClient.SqlParameter("@lanuf", System.Data.SqlDbType.Float, 0, "lanuf"), New System.Data.SqlClient.SqlParameter("@lanufro", System.Data.SqlDbType.Float, 0, "lanufro"), New System.Data.SqlClient.SqlParameter("@gwsp", System.Data.SqlDbType.Float, 0, "gwsp"), New System.Data.SqlClient.SqlParameter("@sbqi", System.Data.SqlDbType.Float, 0, "sbqi"), New System.Data.SqlClient.SqlParameter("@ssqi", System.Data.SqlDbType.Float, 0, "ssqi"), New System.Data.SqlClient.SqlParameter("@smqi", System.Data.SqlDbType.Float, 0, "smqi"), New System.Data.SqlClient.SqlParameter("@DataCreazione", System.Data.SqlDbType.DateTime, 0, "DataCreazione"), New System.Data.SqlClient.SqlParameter("@UtenteCreazione", System.Data.SqlDbType.Int, 0, "UtenteCreazione"), New System.Data.SqlClient.SqlParameter("@DataAggiornamento", System.Data.SqlDbType.DateTime, 0, "DataAggiornamento"), New System.Data.SqlClient.SqlParameter("@UtenteAggiornamento", System.Data.SqlDbType.Int, 0, "UtenteAggiornamento"), New System.Data.SqlClient.SqlParameter("@Annullato", System.Data.SqlDbType.Bit, 0, "Annullato"), New System.Data.SqlClient.SqlParameter("@DataEstrazione", System.Data.SqlDbType.DateTime, 0, "DataEstrazione"), New System.Data.SqlClient.SqlParameter("@Original_datID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc1_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc1_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc1_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc2_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc2_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc2_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc3_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc3_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc3_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc4_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc4_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc4_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc5_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc5_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc5_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc6_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc6_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc6_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc7_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc7_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc7_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc8_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc8_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc8_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc9_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc9_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc9_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc10_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc10_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc10_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc11_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc11_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc11_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc12_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc12_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc12_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc13_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc13_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc13_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc1_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc1_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc1_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc2_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc2_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc2_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc3_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc3_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc3_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc4_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc4_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc4_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc5_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc5_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc5_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc6_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc6_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc6_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc7_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc7_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc7_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc8_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc8_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc8_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc9_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc9_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc9_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc10_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc10_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc10_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc11_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc11_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc11_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc12_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc12_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc12_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indcc13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indcc13_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indcc13_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indcc13_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc1_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc1_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc1_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc2_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc2_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc2_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc3_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc3_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc3_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc4_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc4_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc4_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc5_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc5_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc5_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc6_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc6_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc6_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc7_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc7_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc7_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc8_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc8_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc8_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc9_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc9_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc9_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc10_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc10_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc10_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc11_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc11_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc11_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc12_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc12_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc12_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc13_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc13_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc13_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc1_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc1_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc1_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc2_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc2_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc2_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc3_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc3_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc3_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc4_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc4_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc4_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc5_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc5_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc5_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc6_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc6_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc6_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc7_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc7_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc7_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc8_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc8_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc8_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc9_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc9_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc9_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc10_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc10_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc10_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc11_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc11_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc11_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc12_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc12_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc12_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrcc13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrcc13_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrcc13_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrcc13_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc1_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc1_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc1_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc2_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc2_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc2_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc3_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc3_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc3_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc4_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc4_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc4_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc5_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc5_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc5_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc6_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc6_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc6_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc7_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc7_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc7_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc8_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc8_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc8_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc9_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc9_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc9_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc10_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc10_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc10_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc11_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc11_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc11_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc12_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc12_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc12_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc13_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc13_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc13_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc1_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc1_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc1_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc2_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc2_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc2_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc3_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc3_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc3_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc4_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc4_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc4_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc5_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc5_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc5_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc6_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc6_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc6_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc7_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc7_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc7_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc8_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc8_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc8_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc9_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc9_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc9_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc10_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc10_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc10_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc11_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc11_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc11_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc12_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc12_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc12_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lancc13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lancc13_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lancc13_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lancc13_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi1_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi1_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi1_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi2_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi2_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi2_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi3_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi3_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi3_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi4_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi4_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi4_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi5_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi5_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi5_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi6_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi6_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi6_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi7_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi7_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi7_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi8_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi8_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi8_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi9_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi9_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi9_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi10_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi10_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi10_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi11_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi11_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi11_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi12_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi12_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi12_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi13_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi13_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi13_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi1_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi1_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi1_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi2_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi2_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi2_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi3_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi3_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi3_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi4_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi4_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi4_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi5_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi5_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi5_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi6_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi6_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi6_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi7_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi7_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi7_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi8_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi8_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi8_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi9_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi9_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi9_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi10_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi10_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi10_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi11_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi11_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi11_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi12_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi12_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi12_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lbqi13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lbqi13_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lbqi13_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lbqi13_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi1_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi1_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi1_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi2_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi2_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi2_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi3_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi3_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi3_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi4_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi4_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi4_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi5_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi5_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi5_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi6_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi6_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi6_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi7_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi7_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi7_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi8_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi8_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi8_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi9_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi9_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi9_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi10_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi10_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi10_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi11_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi11_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi11_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi12_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi12_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi12_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi13_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi13_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi13_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi1_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi1_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi1_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi2_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi2_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi2_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi3_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi3_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi3_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi4_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi4_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi4_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi5_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi5_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi5_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi6_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi6_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi6_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi7_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi7_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi7_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi8_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi8_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi8_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi9_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi9_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi9_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi10_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi10_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi10_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi11_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi11_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi11_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi12_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi12_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi12_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lsqi13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lsqi13_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lsqi13_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lsqi13_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi1_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi1_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi1_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi2_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi2_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi2_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi3_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi3_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi3_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi4_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi4_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi4_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi5_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi5_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi5_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi6_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi6_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi6_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi7_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi7_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi7_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi8_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi8_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi8_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi9_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi9_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi9_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi10_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi10_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi10_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi11_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi11_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi11_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi12_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi12_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi12_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi13_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi13_1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi13_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi1_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi1_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi1_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi2_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi2_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi2_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi3_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi3_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi3_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi4_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi4_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi4_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi5_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi5_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi5_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi6_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi6_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi6_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi7_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi7_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi7_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi8_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi8_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi8_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi9_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi9_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi9_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi10_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi10_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi10_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi11_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi11_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi11_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi12_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi12_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi12_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lmqi13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lmqi13_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lmqi13_2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lmqi13_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_1_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_1_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_2_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_2_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_3_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_3_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_4_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_4_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_5_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_5_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_6_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_6_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_7_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_7_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_8_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_8_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_9_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_9_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_10_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_10_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_11_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_11_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_12_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_12_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_13_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_13_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_1_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_1_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_2_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_2_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_3_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_3_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_4_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_4_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_5_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_5_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_6_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_6_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_7_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_7_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_8_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_8_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_9_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_9_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_10_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_10_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_11_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_11_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_12_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_12_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pop20_13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pop20_13_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pop20_13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pop20_13_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis1_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis1_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis2_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis2_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis3_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis3_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis4_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis4_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis5_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis5_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis6_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis6_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis7_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis7_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis8_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis8_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis9_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis9_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis10_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis10_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis11_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis11_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis12_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis12_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis13_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis13_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis1_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis1_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis2_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis2_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis3_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis3_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis4_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis4_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis5_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis5_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis6_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis6_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis7_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis7_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis8_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis8_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis9_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis9_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis10_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis10_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis11_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis11_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis12_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis12_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddis13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddis13_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddis13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddis13_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur1_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur1_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur2_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur2_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur3_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur3_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur4_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur4_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur5_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur5_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur6_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur6_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur7_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur7_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur8_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur8_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur9_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur9_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur10_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur10_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur11_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur11_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur12_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur12_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur13_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur13_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur1_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur1_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur2_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur2_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur3_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur3_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur4_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur4_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur5_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur5_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur6_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur6_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur7_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur7_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur8_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur8_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur9_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur9_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur10_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur10_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur11_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur11_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur12_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur12_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddiscur13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddiscur13_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddiscur13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddiscur13_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln1_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln1_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln1_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln2_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln2_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln2_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln3_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln3_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln3_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln4_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln4_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln4_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln5_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln5_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln5_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln6_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln6_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln6_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln7_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln7_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln7_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln8_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln8_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln8_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln9_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln9_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln9_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln10_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln10_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln10_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln11_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln11_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln11_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln12_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln12_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln12_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln13_1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln13_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln13_1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln1_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln1_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln1_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln2_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln2_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln2_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln3_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln3_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln3_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln4_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln4_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln4_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln5_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln5_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln5_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln6_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln6_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln6_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln7_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln7_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln7_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln8_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln8_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln8_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln9_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln9_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln9_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln10_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln10_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln10_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln11_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln11_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln11_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln12_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln12_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln12_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_inddispln13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "inddispln13_2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_inddispln13_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inddispln13_2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tpbx", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tpbx", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tpbx", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tpbx", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tpsx", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tpsx", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tpsx", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tpsx", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tpmz", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tpmz", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tpmz", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tpmz", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_envw", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "envw", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_envw", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "envw", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ecow", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ecow", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ecow", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ecow", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_socw", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "socw", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_socw", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "socw", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_totpla", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "totpla", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_totpla", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "totpla", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod3", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod3", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod4", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod4", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod5", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod5", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod5", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod6", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod6", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod6", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod7", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod7", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod7", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod7", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod8", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod8", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod8", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod8", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod9", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod9", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod9", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod9", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod10", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod10", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod10", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod10", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod11", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod11", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod11", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod12", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod12", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod12", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod12", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_bod13", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "bod13", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_bod13", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bod13", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds3", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds3", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds4", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds4", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds5", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds5", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds5", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds6", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds6", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds6", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds7", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds7", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds7", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds7", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds8", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds8", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds8", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds8", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds9", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds9", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds9", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds9", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds10", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds10", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds10", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds10", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds11", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds11", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds11", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds12", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds12", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds12", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds12", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tds13", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tds13", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tds13", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tds13", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss3", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss3", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss4", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss4", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss5", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss5", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss5", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss6", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss6", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss6", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss7", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss7", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss7", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss7", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss8", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss8", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss8", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss8", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss9", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss9", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss9", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss9", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss10", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss10", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss10", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss10", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss11", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss11", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss11", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss12", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss12", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss12", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss12", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_tss13", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "tss13", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_tss13", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tss13", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agruf", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agruf", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agruf", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agruf", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_agrufro", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "agrufro", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_agrufro", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agrufro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_induf", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "induf", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_induf", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "induf", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_indufro", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "indufro", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_indufro", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "indufro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lanuf", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lanuf", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lanuf", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lanuf", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_lanufro", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "lanufro", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_lanufro", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lanufro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_gwsp", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "gwsp", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_gwsp", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "gwsp", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_sbqi", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sbqi", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_sbqi", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sbqi", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ssqi", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ssqi", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ssqi", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ssqi", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_smqi", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "smqi", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_smqi", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "smqi", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DataCreazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DataCreazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DataCreazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataCreazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UtenteCreazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UtenteCreazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UtenteCreazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UtenteCreazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DataAggiornamento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DataAggiornamento", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DataAggiornamento", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataAggiornamento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UtenteAggiornamento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UtenteAggiornamento", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UtenteAggiornamento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UtenteAggiornamento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Annullato", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Annullato", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Annullato", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Annullato", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DataEstrazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DataEstrazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DataEstrazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataEstrazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@datID", System.Data.SqlDbType.Int, 4, "datID")})
		'
		'btnNext
		'
		Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnNext.Location = New System.Drawing.Point(441, 522)
		Me.btnNext.Name = "btnNext"
		Me.btnNext.Size = New System.Drawing.Size(90, 36)
		Me.btnNext.TabIndex = 0
		Me.btnNext.Text = "Next"
		Me.btnNext.UseVisualStyleBackColor = True
		'
		'btnPrev
		'
		Me.btnPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnPrev.Location = New System.Drawing.Point(342, 522)
		Me.btnPrev.Name = "btnPrev"
		Me.btnPrev.Size = New System.Drawing.Size(90, 36)
		Me.btnPrev.TabIndex = 29
		Me.btnPrev.Text = "Previous"
		Me.btnPrev.UseVisualStyleBackColor = True
		'
		'btnLoadData
		'
		Me.btnLoadData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnLoadData.Location = New System.Drawing.Point(114, 522)
		Me.btnLoadData.Name = "btnLoadData"
		Me.btnLoadData.Size = New System.Drawing.Size(90, 36)
		Me.btnLoadData.TabIndex = 29
		Me.btnLoadData.Text = "Load data"
		Me.btnLoadData.UseVisualStyleBackColor = True
		'
		'dsParameters
		'
		Me.dsParameters.DataSetName = "parameters"
		Me.dsParameters.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'TAParameters
		'
		Me.TAParameters.ClearBeforeFill = True
		'
		'DSData
		'
		Me.DSData.DataSetName = "DSData"
		Me.DSData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'daLocations
		'
		Me.daLocations.SelectCommand = Me.SqlCommand2
		Me.daLocations.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "locations", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("locID", "locID"), New System.Data.Common.DataColumnMapping("locName", "locName"), New System.Data.Common.DataColumnMapping("locLatitude", "locLatitude"), New System.Data.Common.DataColumnMapping("locLongitude", "locLongitude")})})
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
		Me.SplitContainer.Panel1.Controls.Add(Me.grbOuput)
		Me.SplitContainer.Panel1.Controls.Add(Me.grbPopulation)
		Me.SplitContainer.Panel1.Controls.Add(Me.grbIndustrialDistricts)
		Me.SplitContainer.Panel1.Controls.Add(Me.grbWaterQuality)
		Me.SplitContainer.Panel1.Controls.Add(Me.grbMisc)
		Me.SplitContainer.Panel1.Controls.Add(Me.grbWaterCosts)
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
		Me.gboOutputImpacts.Controls.Add(Me.Label103)
		Me.gboOutputImpacts.Controls.Add(Me.Label98)
		Me.gboOutputImpacts.Controls.Add(Me.Label104)
		Me.gboOutputImpacts.Controls.Add(Me.Label179)
		Me.gboOutputImpacts.Controls.Add(Me.Label105)
		Me.gboOutputImpacts.Controls.Add(Me.Label99)
		Me.gboOutputImpacts.Controls.Add(Me.Label106)
		Me.gboOutputImpacts.Controls.Add(Me.Label95)
		Me.gboOutputImpacts.Controls.Add(Me.Label107)
		Me.gboOutputImpacts.Controls.Add(Me.Label178)
		Me.gboOutputImpacts.Controls.Add(Me.Label108)
		Me.gboOutputImpacts.Controls.Add(Me.Label97)
		Me.gboOutputImpacts.Controls.Add(Me.Label109)
		Me.gboOutputImpacts.Controls.Add(Me.Label96)
		Me.gboOutputImpacts.Controls.Add(Me.Label110)
		Me.gboOutputImpacts.Controls.Add(Me.Label115)
		Me.gboOutputImpacts.Controls.Add(Me.Label111)
		Me.gboOutputImpacts.Controls.Add(Me.Label114)
		Me.gboOutputImpacts.Controls.Add(Me.Label112)
		Me.gboOutputImpacts.Controls.Add(Me.Label113)
		Me.gboOutputImpacts.DSSVisible = False
		Me.gboOutputImpacts.Location = New System.Drawing.Point(15, 11)
		Me.gboOutputImpacts.Name = "gboOutputImpacts"
		Me.gboOutputImpacts.Size = New System.Drawing.Size(422, 446)
		Me.gboOutputImpacts.TabIndex = 195
		Me.gboOutputImpacts.TabStop = False
		Me.gboOutputImpacts.Visible = False
		'
		'lblEnvGini2
		'
		Me.lblEnvGini2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEnvGini2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
		Me.lblEnvGini2.DSSElementName = "OutEco13_1"
		Me.lblEnvGini2.DSSLocation = 0
		Me.lblEnvGini2.DSSOffset = 0.5R
		Me.lblEnvGini2.Location = New System.Drawing.Point(351, 399)
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
		Me.lblEnvMean2.Location = New System.Drawing.Point(351, 379)
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
		Me.lblSocGini2.Location = New System.Drawing.Point(298, 399)
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
		Me.lblSocMean2.Location = New System.Drawing.Point(298, 379)
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
		Me.lblEcoGini2.Location = New System.Drawing.Point(246, 399)
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
		Me.lblEcoMean2.Location = New System.Drawing.Point(246, 379)
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
		Me.lblEnvGini1.Location = New System.Drawing.Point(190, 399)
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
		Me.lblEnvMean1.Location = New System.Drawing.Point(190, 379)
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
		Me.lblSocGini1.Location = New System.Drawing.Point(137, 399)
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
		Me.lblSocMean1.Location = New System.Drawing.Point(137, 379)
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
		Me.lblEcoGini1.Location = New System.Drawing.Point(82, 399)
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
		Me.lblEcoMean1.Location = New System.Drawing.Point(82, 379)
		Me.lblEcoMean1.Name = "lblEcoMean1"
		Me.lblEcoMean1.Size = New System.Drawing.Size(34, 20)
		Me.lblEcoMean1.TabIndex = 195
		Me.lblEcoMean1.Text = "-"
		Me.lblEcoMean1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Label101
		'
		Me.Label101.Location = New System.Drawing.Point(8, 399)
		Me.Label101.Name = "Label101"
		Me.Label101.Size = New System.Drawing.Size(68, 20)
		Me.Label101.TabIndex = 194
		Me.Label101.Text = "Gini index"
		'
		'Label100
		'
		Me.Label100.Location = New System.Drawing.Point(8, 379)
		Me.Label100.Name = "Label100"
		Me.Label100.Size = New System.Drawing.Size(68, 20)
		Me.Label100.TabIndex = 193
		Me.Label100.Text = "Mean"
		'
		'pnlOutSocSmall
		'
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
		Me.pnlOutSocSmall.Size = New System.Drawing.Size(49, 317)
		Me.pnlOutSocSmall.TabIndex = 1
		'
		'lblSoc1_1
		'
		Me.lblSoc1_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(255, Byte))
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
		Me.lblSoc5_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(255, Byte))
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
		Me.lblSoc4_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(255, Byte))
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
		Me.lblSoc8_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(255, Byte))
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
		Me.lblSoc11_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(255, Byte))
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
		Me.lblSoc2_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(255, Byte))
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
		Me.lblSoc6_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(255, Byte))
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
		Me.lblSoc9_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(255, Byte))
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
		Me.lblSoc12_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(255, Byte))
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
		Me.lblSoc3_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(255, Byte))
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
		Me.lblSoc7_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(255, Byte))
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
		Me.lblSoc10_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(255, Byte))
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
		Me.lblSoc13_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(255, Byte))
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
		Me.pnlOutEnvLarge.Size = New System.Drawing.Size(49, 317)
		Me.pnlOutEnvLarge.TabIndex = 1
		'
		'lblEnv1_2
		'
		Me.lblEnv1_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEnv5_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEnv4_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEnv8_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEnv11_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEnv2_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEnv6_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEnv9_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEnv12_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEnv13_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEnv3_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEnv7_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEnv10_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.pnlOutEnvSmall.Size = New System.Drawing.Size(49, 317)
		Me.pnlOutEnvSmall.TabIndex = 1
		'
		'lblEnv1_1
		'
		Me.lblEnv1_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEnv5_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEnv4_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEnv8_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEnv11_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEnv2_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEnv6_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEnv9_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEnv12_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEnv13_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEnv3_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEnv10_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEnv7_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.pnlOutEcoLarge.Size = New System.Drawing.Size(49, 317)
		Me.pnlOutEcoLarge.TabIndex = 1
		'
		'lblEco1_2
		'
		Me.lblEco1_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEco5_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEco4_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEco8_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEco11_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEco2_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEco6_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEco9_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEco12_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEco13_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEco3_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEco10_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblEco7_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.pnlOutSocLarge.Size = New System.Drawing.Size(49, 317)
		Me.pnlOutSocLarge.TabIndex = 1
		'
		'lblSoc1_2
		'
		Me.lblSoc1_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
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
		Me.lblSoc5_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
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
		Me.lblSoc4_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
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
		Me.lblSoc8_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
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
		Me.lblSoc11_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
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
		Me.lblSoc2_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
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
		Me.lblSoc6_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
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
		Me.lblSoc9_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
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
		Me.lblSoc12_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
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
		Me.lblSoc13_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
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
		Me.lblSoc3_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
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
		Me.lblSoc7_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
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
		Me.lblSoc10_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(0, Byte), CType(255, Byte), CType(0, Byte))
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
		Me.pnlOutEcoSmall.Size = New System.Drawing.Size(49, 317)
		Me.pnlOutEcoSmall.TabIndex = 0
		'
		'lblEco1_1
		'
		Me.lblEco1_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.lblEco1_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEco5_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEco4_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEco8_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEco11_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEco2_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEco6_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEco9_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEco12_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEco3_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEco7_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEco10_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblEco13_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(102, Byte), CType(0, Byte))
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
		'Label103
		'
		Me.Label103.Location = New System.Drawing.Point(8, 339)
		Me.Label103.Name = "Label103"
		Me.Label103.Size = New System.Drawing.Size(68, 20)
		Me.Label103.TabIndex = 49
		Me.Label103.Text = "Tabouk"
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
		'Label104
		'
		Me.Label104.Location = New System.Drawing.Point(8, 201)
		Me.Label104.Name = "Label104"
		Me.Label104.Size = New System.Drawing.Size(68, 20)
		Me.Label104.TabIndex = 50
		Me.Label104.Text = "Jizan"
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
		'Label105
		'
		Me.Label105.Location = New System.Drawing.Point(8, 316)
		Me.Label105.Name = "Label105"
		Me.Label105.Size = New System.Drawing.Size(68, 20)
		Me.Label105.TabIndex = 51
		Me.Label105.Text = "Riyadh"
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
		'Label106
		'
		Me.Label106.Location = New System.Drawing.Point(8, 178)
		Me.Label106.Name = "Label106"
		Me.Label106.Size = New System.Drawing.Size(68, 20)
		Me.Label106.TabIndex = 52
		Me.Label106.Text = "Hail"
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
		'Label107
		'
		Me.Label107.Location = New System.Drawing.Point(8, 293)
		Me.Label107.Name = "Label107"
		Me.Label107.Size = New System.Drawing.Size(68, 20)
		Me.Label107.TabIndex = 53
		Me.Label107.Text = "North Border"
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
		'Label108
		'
		Me.Label108.Location = New System.Drawing.Point(8, 270)
		Me.Label108.Name = "Label108"
		Me.Label108.Size = New System.Drawing.Size(68, 20)
		Me.Label108.TabIndex = 61
		Me.Label108.Text = "Najran"
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
		'Label109
		'
		Me.Label109.Location = New System.Drawing.Point(8, 109)
		Me.Label109.Name = "Label109"
		Me.Label109.Size = New System.Drawing.Size(68, 20)
		Me.Label109.TabIndex = 54
		Me.Label109.Text = "Al - Jouf"
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
		'Label110
		'
		Me.Label110.Location = New System.Drawing.Point(8, 247)
		Me.Label110.Name = "Label110"
		Me.Label110.Size = New System.Drawing.Size(68, 20)
		Me.Label110.TabIndex = 55
		Me.Label110.Text = "Mecca"
		'
		'Label115
		'
		Me.Label115.Location = New System.Drawing.Point(8, 63)
		Me.Label115.Name = "Label115"
		Me.Label115.Size = New System.Drawing.Size(68, 20)
		Me.Label115.TabIndex = 60
		Me.Label115.Text = "Al - Baha"
		'
		'Label111
		'
		Me.Label111.Location = New System.Drawing.Point(8, 155)
		Me.Label111.Name = "Label111"
		Me.Label111.Size = New System.Drawing.Size(68, 20)
		Me.Label111.TabIndex = 56
		Me.Label111.Text = "Eastern Area"
		'
		'Label114
		'
		Me.Label114.Location = New System.Drawing.Point(8, 132)
		Me.Label114.Name = "Label114"
		Me.Label114.Size = New System.Drawing.Size(68, 20)
		Me.Label114.TabIndex = 59
		Me.Label114.Text = "Aseer"
		'
		'Label112
		'
		Me.Label112.Location = New System.Drawing.Point(8, 86)
		Me.Label112.Name = "Label112"
		Me.Label112.Size = New System.Drawing.Size(68, 20)
		Me.Label112.TabIndex = 57
		Me.Label112.Text = "Al - Gassem"
		'
		'Label113
		'
		Me.Label113.Location = New System.Drawing.Point(8, 224)
		Me.Label113.Name = "Label113"
		Me.Label113.Size = New System.Drawing.Size(68, 20)
		Me.Label113.TabIndex = 58
		Me.Label113.Text = "Madina"
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
		Me.gboOutputUses.Controls.Add(Me.Label85)
		Me.gboOutputUses.Controls.Add(Me.Label133)
		Me.gboOutputUses.Controls.Add(Me.Label84)
		Me.gboOutputUses.Controls.Add(Me.Label83)
		Me.gboOutputUses.Controls.Add(Me.Label31)
		Me.gboOutputUses.Controls.Add(Me.Label82)
		Me.gboOutputUses.Controls.Add(Me.Label33)
		Me.gboOutputUses.Controls.Add(Me.Label81)
		Me.gboOutputUses.Controls.Add(Me.Label35)
		Me.gboOutputUses.Controls.Add(Me.Label80)
		Me.gboOutputUses.Controls.Add(Me.Label36)
		Me.gboOutputUses.Controls.Add(Me.Label79)
		Me.gboOutputUses.Controls.Add(Me.Label60)
		Me.gboOutputUses.Controls.Add(Me.Label61)
		Me.gboOutputUses.Location = New System.Drawing.Point(15, 15)
		Me.gboOutputUses.Name = "gboOutputUses"
		Me.gboOutputUses.Size = New System.Drawing.Size(451, 406)
		Me.gboOutputUses.TabIndex = 112
		Me.gboOutputUses.TabStop = False
		Me.gboOutputUses.Visible = False
		'
		'pnlOutAgrSmall
		'
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
		Me.pnlOutAgrSmall.Size = New System.Drawing.Size(49, 317)
		Me.pnlOutAgrSmall.TabIndex = 108
		'
		'lblAgr1_1
		'
		Me.lblAgr1_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr5_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr4_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr8_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr11_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr2_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr6_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr9_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr12_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr3_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr7_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr10_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr13_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.pnlOutIndLarge.Size = New System.Drawing.Size(49, 317)
		Me.pnlOutIndLarge.TabIndex = 111
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
		Me.pnlOutLanSmall.Size = New System.Drawing.Size(49, 317)
		Me.pnlOutLanSmall.TabIndex = 109
		'
		'lblLan1_1
		'
		Me.lblLan1_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblLan5_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblLan4_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblLan8_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblLan11_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblLan2_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblLan6_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblLan9_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblLan12_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblLan3_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblLan7_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblLan10_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblLan13_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.pnlOutLanLarge.Size = New System.Drawing.Size(49, 317)
		Me.pnlOutLanLarge.TabIndex = 111
		'
		'lblLan1_2
		'
		Me.lblLan1_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblLan5_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblLan4_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblLan8_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblLan11_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblLan2_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblLan6_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblLan13_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblLan9_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblLan10_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblLan12_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblLan7_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.lblLan3_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(102, Byte), CType(0, Byte))
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
		Me.pnlOutAgrLarge.Size = New System.Drawing.Size(49, 317)
		Me.pnlOutAgrLarge.TabIndex = 110
		'
		'lblAgr1_2
		'
		Me.lblAgr1_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr5_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr4_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr8_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr11_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr2_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr6_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr9_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr12_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr13_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr3_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr7_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(0, Byte), CType(0, Byte))
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
		Me.lblAgr10_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(102, Byte), CType(0, Byte), CType(0, Byte))
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
		'Label85
		'
		Me.Label85.Location = New System.Drawing.Point(13, 59)
		Me.Label85.Name = "Label85"
		Me.Label85.Size = New System.Drawing.Size(75, 20)
		Me.Label85.TabIndex = 60
		Me.Label85.Text = "Al - Baha"
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
		'Label84
		'
		Me.Label84.Location = New System.Drawing.Point(13, 128)
		Me.Label84.Name = "Label84"
		Me.Label84.Size = New System.Drawing.Size(75, 20)
		Me.Label84.TabIndex = 59
		Me.Label84.Text = "Aseer"
		'
		'Label83
		'
		Me.Label83.Location = New System.Drawing.Point(13, 220)
		Me.Label83.Name = "Label83"
		Me.Label83.Size = New System.Drawing.Size(75, 20)
		Me.Label83.TabIndex = 58
		Me.Label83.Text = "Madina"
		'
		'Label31
		'
		Me.Label31.Location = New System.Drawing.Point(13, 335)
		Me.Label31.Name = "Label31"
		Me.Label31.Size = New System.Drawing.Size(75, 20)
		Me.Label31.TabIndex = 49
		Me.Label31.Text = "Tabouk"
		'
		'Label82
		'
		Me.Label82.Location = New System.Drawing.Point(13, 82)
		Me.Label82.Name = "Label82"
		Me.Label82.Size = New System.Drawing.Size(75, 20)
		Me.Label82.TabIndex = 57
		Me.Label82.Text = "Al - Gassem"
		'
		'Label33
		'
		Me.Label33.Location = New System.Drawing.Point(13, 197)
		Me.Label33.Name = "Label33"
		Me.Label33.Size = New System.Drawing.Size(75, 20)
		Me.Label33.TabIndex = 50
		Me.Label33.Text = "Jizan"
		'
		'Label81
		'
		Me.Label81.Location = New System.Drawing.Point(13, 151)
		Me.Label81.Name = "Label81"
		Me.Label81.Size = New System.Drawing.Size(75, 20)
		Me.Label81.TabIndex = 56
		Me.Label81.Text = "Eastern Area"
		'
		'Label35
		'
		Me.Label35.Location = New System.Drawing.Point(13, 312)
		Me.Label35.Name = "Label35"
		Me.Label35.Size = New System.Drawing.Size(75, 20)
		Me.Label35.TabIndex = 51
		Me.Label35.Text = "Riyadh"
		'
		'Label80
		'
		Me.Label80.Location = New System.Drawing.Point(13, 243)
		Me.Label80.Name = "Label80"
		Me.Label80.Size = New System.Drawing.Size(75, 20)
		Me.Label80.TabIndex = 55
		Me.Label80.Text = "Mecca"
		'
		'Label36
		'
		Me.Label36.Location = New System.Drawing.Point(13, 174)
		Me.Label36.Name = "Label36"
		Me.Label36.Size = New System.Drawing.Size(75, 20)
		Me.Label36.TabIndex = 52
		Me.Label36.Text = "Hail"
		'
		'Label79
		'
		Me.Label79.Location = New System.Drawing.Point(13, 105)
		Me.Label79.Name = "Label79"
		Me.Label79.Size = New System.Drawing.Size(75, 20)
		Me.Label79.TabIndex = 54
		Me.Label79.Text = "Al - Jouf"
		'
		'Label60
		'
		Me.Label60.Location = New System.Drawing.Point(13, 289)
		Me.Label60.Name = "Label60"
		Me.Label60.Size = New System.Drawing.Size(75, 20)
		Me.Label60.TabIndex = 53
		Me.Label60.Text = "North Border"
		'
		'Label61
		'
		Me.Label61.Location = New System.Drawing.Point(13, 266)
		Me.Label61.Name = "Label61"
		Me.Label61.Size = New System.Drawing.Size(75, 20)
		Me.Label61.TabIndex = 61
		Me.Label61.Text = "Najran"
		'
		'grbPopulation
		'
		Me.grbPopulation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.grbPopulation.Controls.Add(Me.pnlPop20_2)
		Me.grbPopulation.Controls.Add(Me.pnlPop20_1)
		Me.grbPopulation.Controls.Add(Me.Label1)
		Me.grbPopulation.Controls.Add(Me.Label2)
		Me.grbPopulation.Controls.Add(Me.Label22)
		Me.grbPopulation.Controls.Add(Me.Label32)
		Me.grbPopulation.Controls.Add(Me.Label37)
		Me.grbPopulation.Controls.Add(Me.Label44)
		Me.grbPopulation.Controls.Add(Me.Label45)
		Me.grbPopulation.Controls.Add(Me.Label46)
		Me.grbPopulation.Controls.Add(Me.Label48)
		Me.grbPopulation.Controls.Add(Me.Label49)
		Me.grbPopulation.Controls.Add(Me.Label58)
		Me.grbPopulation.Controls.Add(Me.Label59)
		Me.grbPopulation.Controls.Add(Me.Label65)
		Me.grbPopulation.Controls.Add(Me.Label69)
		Me.grbPopulation.ForeColor = System.Drawing.Color.Black
		Me.grbPopulation.Location = New System.Drawing.Point(0, 0)
		Me.grbPopulation.Name = "grbPopulation"
		Me.grbPopulation.Size = New System.Drawing.Size(294, 516)
		Me.grbPopulation.TabIndex = 22
		Me.grbPopulation.TabStop = False
		Me.grbPopulation.Text = "Total population"
		Me.grbPopulation.Visible = False
		'
		'pnlPop20_2
		'
		Me.pnlPop20_2.Controls.Add(Me.Label66)
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
		Me.pnlPop20_2.Size = New System.Drawing.Size(90, 338)
		Me.pnlPop20_2.TabIndex = 114
		'
		'Label66
		'
		Me.Label66.Location = New System.Drawing.Point(0, 5)
		Me.Label66.Name = "Label66"
		Me.Label66.Size = New System.Drawing.Size(90, 13)
		Me.Label66.TabIndex = 94
		Me.Label66.Text = "Medium"
		Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
		'pnlPop20_1
		'
		Me.pnlPop20_1.Controls.Add(Me.Label67)
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
		Me.pnlPop20_1.Size = New System.Drawing.Size(90, 338)
		Me.pnlPop20_1.TabIndex = 113
		'
		'Label67
		'
		Me.Label67.Location = New System.Drawing.Point(0, 5)
		Me.Label67.Name = "Label67"
		Me.Label67.Size = New System.Drawing.Size(90, 13)
		Me.Label67.TabIndex = 95
		Me.Label67.Text = "Small"
		Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(15, 340)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(76, 20)
		Me.Label1.TabIndex = 80
		Me.Label1.Text = "Tabouk"
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(15, 202)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(76, 20)
		Me.Label2.TabIndex = 81
		Me.Label2.Text = "Jizan"
		'
		'Label22
		'
		Me.Label22.Location = New System.Drawing.Point(15, 317)
		Me.Label22.Name = "Label22"
		Me.Label22.Size = New System.Drawing.Size(76, 20)
		Me.Label22.TabIndex = 82
		Me.Label22.Text = "Riyadh"
		'
		'Label32
		'
		Me.Label32.Location = New System.Drawing.Point(15, 179)
		Me.Label32.Name = "Label32"
		Me.Label32.Size = New System.Drawing.Size(76, 20)
		Me.Label32.TabIndex = 83
		Me.Label32.Text = "Hail"
		'
		'Label37
		'
		Me.Label37.Location = New System.Drawing.Point(15, 294)
		Me.Label37.Name = "Label37"
		Me.Label37.Size = New System.Drawing.Size(76, 20)
		Me.Label37.TabIndex = 84
		Me.Label37.Text = "North Border"
		'
		'Label44
		'
		Me.Label44.Location = New System.Drawing.Point(15, 271)
		Me.Label44.Name = "Label44"
		Me.Label44.Size = New System.Drawing.Size(76, 20)
		Me.Label44.TabIndex = 92
		Me.Label44.Text = "Najran"
		'
		'Label45
		'
		Me.Label45.Location = New System.Drawing.Point(15, 110)
		Me.Label45.Name = "Label45"
		Me.Label45.Size = New System.Drawing.Size(76, 20)
		Me.Label45.TabIndex = 85
		Me.Label45.Text = "Al - Jouf"
		'
		'Label46
		'
		Me.Label46.Location = New System.Drawing.Point(15, 248)
		Me.Label46.Name = "Label46"
		Me.Label46.Size = New System.Drawing.Size(76, 20)
		Me.Label46.TabIndex = 86
		Me.Label46.Text = "Mecca"
		'
		'Label48
		'
		Me.Label48.Location = New System.Drawing.Point(15, 156)
		Me.Label48.Name = "Label48"
		Me.Label48.Size = New System.Drawing.Size(76, 20)
		Me.Label48.TabIndex = 87
		Me.Label48.Text = "Eastern Area"
		'
		'Label49
		'
		Me.Label49.Location = New System.Drawing.Point(15, 87)
		Me.Label49.Name = "Label49"
		Me.Label49.Size = New System.Drawing.Size(76, 20)
		Me.Label49.TabIndex = 88
		Me.Label49.Text = "Al - Gassem"
		'
		'Label58
		'
		Me.Label58.Location = New System.Drawing.Point(15, 225)
		Me.Label58.Name = "Label58"
		Me.Label58.Size = New System.Drawing.Size(76, 20)
		Me.Label58.TabIndex = 89
		Me.Label58.Text = "Madina"
		'
		'Label59
		'
		Me.Label59.Location = New System.Drawing.Point(15, 133)
		Me.Label59.Name = "Label59"
		Me.Label59.Size = New System.Drawing.Size(76, 20)
		Me.Label59.TabIndex = 90
		Me.Label59.Text = "Aseer"
		'
		'Label65
		'
		Me.Label65.Location = New System.Drawing.Point(15, 64)
		Me.Label65.Name = "Label65"
		Me.Label65.Size = New System.Drawing.Size(76, 20)
		Me.Label65.TabIndex = 91
		Me.Label65.Text = "Al - Baha"
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
		'grbIndustrialDistricts
		'
		Me.grbIndustrialDistricts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.grbIndustrialDistricts.Controls.Add(Me.pnlInddispln)
		Me.grbIndustrialDistricts.Controls.Add(Me.pnlInddiscur)
		Me.grbIndustrialDistricts.Controls.Add(Me.Label38)
		Me.grbIndustrialDistricts.Controls.Add(Me.Label39)
		Me.grbIndustrialDistricts.Controls.Add(Me.Label40)
		Me.grbIndustrialDistricts.Controls.Add(Me.Label41)
		Me.grbIndustrialDistricts.Controls.Add(Me.Label42)
		Me.grbIndustrialDistricts.Controls.Add(Me.Label43)
		Me.grbIndustrialDistricts.Controls.Add(Me.Label71)
		Me.grbIndustrialDistricts.Controls.Add(Me.Label72)
		Me.grbIndustrialDistricts.Controls.Add(Me.Label73)
		Me.grbIndustrialDistricts.Controls.Add(Me.Label74)
		Me.grbIndustrialDistricts.Controls.Add(Me.Label75)
		Me.grbIndustrialDistricts.Controls.Add(Me.Label76)
		Me.grbIndustrialDistricts.Controls.Add(Me.Label77)
		Me.grbIndustrialDistricts.ForeColor = System.Drawing.Color.Black
		Me.grbIndustrialDistricts.Location = New System.Drawing.Point(0, 0)
		Me.grbIndustrialDistricts.Name = "grbIndustrialDistricts"
		Me.grbIndustrialDistricts.Size = New System.Drawing.Size(300, 516)
		Me.grbIndustrialDistricts.TabIndex = 23
		Me.grbIndustrialDistricts.TabStop = False
		Me.grbIndustrialDistricts.Text = "Industrial districts"
		Me.grbIndustrialDistricts.Visible = False
		'
		'pnlInddispln
		'
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
		Me.pnlInddispln.Size = New System.Drawing.Size(90, 333)
		Me.pnlInddispln.TabIndex = 147
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
		'pnlInddiscur
		'
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
		Me.pnlInddiscur.Size = New System.Drawing.Size(90, 333)
		Me.pnlInddiscur.TabIndex = 146
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
		'Label38
		'
		Me.Label38.Location = New System.Drawing.Point(15, 322)
		Me.Label38.Name = "Label38"
		Me.Label38.Size = New System.Drawing.Size(76, 20)
		Me.Label38.TabIndex = 131
		Me.Label38.Text = "Tabouk"
		'
		'Label39
		'
		Me.Label39.Location = New System.Drawing.Point(15, 184)
		Me.Label39.Name = "Label39"
		Me.Label39.Size = New System.Drawing.Size(76, 20)
		Me.Label39.TabIndex = 132
		Me.Label39.Text = "Jizan"
		'
		'Label40
		'
		Me.Label40.Location = New System.Drawing.Point(15, 299)
		Me.Label40.Name = "Label40"
		Me.Label40.Size = New System.Drawing.Size(76, 20)
		Me.Label40.TabIndex = 133
		Me.Label40.Text = "Riyadh"
		'
		'Label41
		'
		Me.Label41.Location = New System.Drawing.Point(15, 161)
		Me.Label41.Name = "Label41"
		Me.Label41.Size = New System.Drawing.Size(76, 20)
		Me.Label41.TabIndex = 134
		Me.Label41.Text = "Hail"
		'
		'Label42
		'
		Me.Label42.Location = New System.Drawing.Point(15, 276)
		Me.Label42.Name = "Label42"
		Me.Label42.Size = New System.Drawing.Size(76, 20)
		Me.Label42.TabIndex = 135
		Me.Label42.Text = "North Border"
		'
		'Label43
		'
		Me.Label43.Location = New System.Drawing.Point(15, 253)
		Me.Label43.Name = "Label43"
		Me.Label43.Size = New System.Drawing.Size(76, 20)
		Me.Label43.TabIndex = 143
		Me.Label43.Text = "Najran"
		'
		'Label71
		'
		Me.Label71.Location = New System.Drawing.Point(15, 92)
		Me.Label71.Name = "Label71"
		Me.Label71.Size = New System.Drawing.Size(76, 20)
		Me.Label71.TabIndex = 136
		Me.Label71.Text = "Al - Jouf"
		'
		'Label72
		'
		Me.Label72.Location = New System.Drawing.Point(15, 230)
		Me.Label72.Name = "Label72"
		Me.Label72.Size = New System.Drawing.Size(76, 20)
		Me.Label72.TabIndex = 137
		Me.Label72.Text = "Mecca"
		'
		'Label73
		'
		Me.Label73.Location = New System.Drawing.Point(15, 138)
		Me.Label73.Name = "Label73"
		Me.Label73.Size = New System.Drawing.Size(76, 20)
		Me.Label73.TabIndex = 138
		Me.Label73.Text = "Eastern Area"
		'
		'Label74
		'
		Me.Label74.Location = New System.Drawing.Point(15, 69)
		Me.Label74.Name = "Label74"
		Me.Label74.Size = New System.Drawing.Size(76, 20)
		Me.Label74.TabIndex = 139
		Me.Label74.Text = "Al - Gassem"
		'
		'Label75
		'
		Me.Label75.Location = New System.Drawing.Point(15, 207)
		Me.Label75.Name = "Label75"
		Me.Label75.Size = New System.Drawing.Size(76, 20)
		Me.Label75.TabIndex = 140
		Me.Label75.Text = "Madina"
		'
		'Label76
		'
		Me.Label76.Location = New System.Drawing.Point(15, 115)
		Me.Label76.Name = "Label76"
		Me.Label76.Size = New System.Drawing.Size(76, 20)
		Me.Label76.TabIndex = 141
		Me.Label76.Text = "Aseer"
		'
		'Label77
		'
		Me.Label77.Location = New System.Drawing.Point(15, 46)
		Me.Label77.Name = "Label77"
		Me.Label77.Size = New System.Drawing.Size(76, 20)
		Me.Label77.TabIndex = 142
		Me.Label77.Text = "Al - Baha"
		'
		'grbWaterQuality
		'
		Me.grbWaterQuality.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.grbWaterQuality.Controls.Add(Me.pnlTSS)
		Me.grbWaterQuality.Controls.Add(Me.pnlTDS)
		Me.grbWaterQuality.Controls.Add(Me.pnlBOD)
		Me.grbWaterQuality.Controls.Add(Me.Label3)
		Me.grbWaterQuality.Controls.Add(Me.Label4)
		Me.grbWaterQuality.Controls.Add(Me.Label5)
		Me.grbWaterQuality.Controls.Add(Me.Label6)
		Me.grbWaterQuality.Controls.Add(Me.Label7)
		Me.grbWaterQuality.Controls.Add(Me.Label8)
		Me.grbWaterQuality.Controls.Add(Me.Label9)
		Me.grbWaterQuality.Controls.Add(Me.Label11)
		Me.grbWaterQuality.Controls.Add(Me.Label14)
		Me.grbWaterQuality.Controls.Add(Me.Label15)
		Me.grbWaterQuality.Controls.Add(Me.Label16)
		Me.grbWaterQuality.Controls.Add(Me.Label17)
		Me.grbWaterQuality.Controls.Add(Me.Label18)
		Me.grbWaterQuality.ForeColor = System.Drawing.Color.Black
		Me.grbWaterQuality.Location = New System.Drawing.Point(0, 0)
		Me.grbWaterQuality.Name = "grbWaterQuality"
		Me.grbWaterQuality.Size = New System.Drawing.Size(413, 516)
		Me.grbWaterQuality.TabIndex = 21
		Me.grbWaterQuality.TabStop = False
		Me.grbWaterQuality.Text = "Water quality indicator"
		Me.grbWaterQuality.Visible = False
		'
		'pnlTSS
		'
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
		Me.pnlTSS.Size = New System.Drawing.Size(90, 338)
		Me.pnlTSS.TabIndex = 53
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
		Me.nudTSS3.TabIndex = 28
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
		Me.nudTSS2.TabIndex = 27
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
		Me.nudTSS7.TabIndex = 32
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
		Me.nudTSS10.TabIndex = 35
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
		Me.nudTSS12.TabIndex = 37
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
		Me.nudTSS6.TabIndex = 31
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
		Me.nudTSS13.TabIndex = 38
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
		Me.nudTSS1.TabIndex = 26
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
		Me.nudTSS8.TabIndex = 33
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
		Me.nudTSS9.TabIndex = 34
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
		Me.nudTSS4.TabIndex = 29
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
		Me.nudTSS5.TabIndex = 30
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
		Me.nudTSS11.TabIndex = 36
		Me.nudTSS11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTSS11.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'pnlTDS
		'
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
		Me.pnlTDS.Size = New System.Drawing.Size(90, 338)
		Me.pnlTDS.TabIndex = 52
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
		Me.nudTDS3.TabIndex = 15
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
		Me.nudTDS2.TabIndex = 14
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
		Me.nudTDS7.TabIndex = 19
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
		Me.nudTDS10.TabIndex = 22
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
		Me.nudTDS6.TabIndex = 18
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
		Me.nudTDS12.TabIndex = 24
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
		Me.nudTDS1.TabIndex = 13
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
		Me.nudTDS9.TabIndex = 21
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
		Me.nudTDS13.TabIndex = 25
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
		Me.nudTDS5.TabIndex = 17
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
		Me.nudTDS11.TabIndex = 23
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
		Me.nudTDS8.TabIndex = 20
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
		Me.nudTDS4.TabIndex = 16
		Me.nudTDS4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudTDS4.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'pnlBOD
		'
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
		Me.pnlBOD.Size = New System.Drawing.Size(90, 338)
		Me.pnlBOD.TabIndex = 51
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
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(17, 325)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(91, 20)
		Me.Label3.TabIndex = 36
		Me.Label3.Text = "Tabouk"
		'
		'Label4
		'
		Me.Label4.Location = New System.Drawing.Point(17, 187)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(91, 20)
		Me.Label4.TabIndex = 37
		Me.Label4.Text = "Jizan"
		'
		'Label5
		'
		Me.Label5.Location = New System.Drawing.Point(17, 302)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(91, 20)
		Me.Label5.TabIndex = 38
		Me.Label5.Text = "Riyadh"
		'
		'Label6
		'
		Me.Label6.Location = New System.Drawing.Point(17, 164)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(91, 20)
		Me.Label6.TabIndex = 39
		Me.Label6.Text = "Hail"
		'
		'Label7
		'
		Me.Label7.Location = New System.Drawing.Point(17, 279)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(91, 20)
		Me.Label7.TabIndex = 40
		Me.Label7.Text = "North Border"
		'
		'Label8
		'
		Me.Label8.Location = New System.Drawing.Point(17, 256)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(91, 20)
		Me.Label8.TabIndex = 48
		Me.Label8.Text = "Najran"
		'
		'Label9
		'
		Me.Label9.Location = New System.Drawing.Point(17, 95)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(91, 20)
		Me.Label9.TabIndex = 41
		Me.Label9.Text = "Al - Jouf"
		'
		'Label11
		'
		Me.Label11.Location = New System.Drawing.Point(17, 233)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(91, 20)
		Me.Label11.TabIndex = 42
		Me.Label11.Text = "Mecca"
		'
		'Label14
		'
		Me.Label14.Location = New System.Drawing.Point(17, 141)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(91, 20)
		Me.Label14.TabIndex = 43
		Me.Label14.Text = "Eastern Area"
		'
		'Label15
		'
		Me.Label15.Location = New System.Drawing.Point(17, 72)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(91, 20)
		Me.Label15.TabIndex = 44
		Me.Label15.Text = "Al - Gassem"
		'
		'Label16
		'
		Me.Label16.Location = New System.Drawing.Point(17, 210)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(91, 20)
		Me.Label16.TabIndex = 45
		Me.Label16.Text = "Madina"
		'
		'Label17
		'
		Me.Label17.Location = New System.Drawing.Point(17, 118)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(91, 20)
		Me.Label17.TabIndex = 46
		Me.Label17.Text = "Aseer"
		'
		'Label18
		'
		Me.Label18.Location = New System.Drawing.Point(17, 49)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(91, 20)
		Me.Label18.TabIndex = 47
		Me.Label18.Text = "Al - Baha"
		'
		'grbWaterCosts
		'
		Me.grbWaterCosts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.grbWaterCosts.Controls.Add(Me.pnlGro)
		Me.grbWaterCosts.Controls.Add(Me.pnlDes)
		Me.grbWaterCosts.Controls.Add(Me.Label63)
		Me.grbWaterCosts.Controls.Add(Me.Label55)
		Me.grbWaterCosts.Controls.Add(Me.Label62)
		Me.grbWaterCosts.Controls.Add(Me.Label54)
		Me.grbWaterCosts.Controls.Add(Me.Label130)
		Me.grbWaterCosts.Controls.Add(Me.Label128)
		Me.grbWaterCosts.Controls.Add(Me.Label51)
		Me.grbWaterCosts.Controls.Add(Me.Label57)
		Me.grbWaterCosts.Controls.Add(Me.Label53)
		Me.grbWaterCosts.Controls.Add(Me.Label50)
		Me.grbWaterCosts.Controls.Add(Me.Label56)
		Me.grbWaterCosts.Controls.Add(Me.Label52)
		Me.grbWaterCosts.Controls.Add(Me.Label47)
		Me.grbWaterCosts.ForeColor = System.Drawing.Color.Black
		Me.grbWaterCosts.Location = New System.Drawing.Point(0, 0)
		Me.grbWaterCosts.Name = "grbWaterCosts"
		Me.grbWaterCosts.Size = New System.Drawing.Size(349, 516)
		Me.grbWaterCosts.TabIndex = 24
		Me.grbWaterCosts.TabStop = False
		Me.grbWaterCosts.Text = "Water costs"
		Me.grbWaterCosts.Visible = False
		'
		'pnlGro
		'
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
		Me.pnlGro.Size = New System.Drawing.Size(90, 332)
		Me.pnlGro.TabIndex = 114
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
		Me.nudGro3.Location = New System.Drawing.Point(0, 76)
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
		Me.nudGro7.Location = New System.Drawing.Point(0, 168)
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
		Me.nudGro2.Location = New System.Drawing.Point(0, 53)
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
		Me.nudGro12.Location = New System.Drawing.Point(0, 283)
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
		Me.nudGro10.Location = New System.Drawing.Point(0, 237)
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
		Me.nudGro13.Location = New System.Drawing.Point(0, 306)
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
		Me.nudGro6.Location = New System.Drawing.Point(0, 145)
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
		Me.nudGro8.Location = New System.Drawing.Point(0, 191)
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
		Me.nudGro1.Location = New System.Drawing.Point(0, 30)
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
		Me.nudGro4.Location = New System.Drawing.Point(0, 99)
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
		Me.nudGro9.Location = New System.Drawing.Point(0, 214)
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
		Me.nudGro11.Location = New System.Drawing.Point(0, 260)
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
		Me.nudGro5.Location = New System.Drawing.Point(0, 122)
		Me.nudGro5.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudGro5.Name = "nudGro5"
		Me.nudGro5.Size = New System.Drawing.Size(90, 20)
		Me.nudGro5.TabIndex = 104
		Me.nudGro5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudGro5.Value = New Decimal(New Integer() {8, 0, 0, 65536})
		'
		'pnlDes
		'
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
		Me.pnlDes.Size = New System.Drawing.Size(90, 332)
		Me.pnlDes.TabIndex = 113
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
		'Label63
		'
		Me.Label63.Location = New System.Drawing.Point(26, 315)
		Me.Label63.Name = "Label63"
		Me.Label63.Size = New System.Drawing.Size(91, 20)
		Me.Label63.TabIndex = 4
		Me.Label63.Text = "Tabouk"
		'
		'Label55
		'
		Me.Label55.Location = New System.Drawing.Point(26, 177)
		Me.Label55.Name = "Label55"
		Me.Label55.Size = New System.Drawing.Size(91, 20)
		Me.Label55.TabIndex = 4
		Me.Label55.Text = "Jizan"
		'
		'Label62
		'
		Me.Label62.Location = New System.Drawing.Point(26, 292)
		Me.Label62.Name = "Label62"
		Me.Label62.Size = New System.Drawing.Size(91, 20)
		Me.Label62.TabIndex = 4
		Me.Label62.Text = "Riyadh"
		'
		'Label54
		'
		Me.Label54.Location = New System.Drawing.Point(26, 154)
		Me.Label54.Name = "Label54"
		Me.Label54.Size = New System.Drawing.Size(91, 20)
		Me.Label54.TabIndex = 4
		Me.Label54.Text = "Hail"
		'
		'Label130
		'
		Me.Label130.Location = New System.Drawing.Point(26, 269)
		Me.Label130.Name = "Label130"
		Me.Label130.Size = New System.Drawing.Size(91, 20)
		Me.Label130.TabIndex = 4
		Me.Label130.Text = "North Border"
		'
		'Label128
		'
		Me.Label128.Location = New System.Drawing.Point(26, 246)
		Me.Label128.Name = "Label128"
		Me.Label128.Size = New System.Drawing.Size(91, 20)
		Me.Label128.TabIndex = 4
		Me.Label128.Text = "Najran"
		'
		'Label51
		'
		Me.Label51.Location = New System.Drawing.Point(26, 85)
		Me.Label51.Name = "Label51"
		Me.Label51.Size = New System.Drawing.Size(91, 20)
		Me.Label51.TabIndex = 4
		Me.Label51.Text = "Al - Jouf"
		'
		'Label57
		'
		Me.Label57.Location = New System.Drawing.Point(26, 223)
		Me.Label57.Name = "Label57"
		Me.Label57.Size = New System.Drawing.Size(91, 20)
		Me.Label57.TabIndex = 4
		Me.Label57.Text = "Mecca"
		'
		'Label53
		'
		Me.Label53.Location = New System.Drawing.Point(26, 131)
		Me.Label53.Name = "Label53"
		Me.Label53.Size = New System.Drawing.Size(91, 20)
		Me.Label53.TabIndex = 4
		Me.Label53.Text = "Eastern Area"
		'
		'Label50
		'
		Me.Label50.Location = New System.Drawing.Point(26, 62)
		Me.Label50.Name = "Label50"
		Me.Label50.Size = New System.Drawing.Size(91, 20)
		Me.Label50.TabIndex = 4
		Me.Label50.Text = "Al - Gassem"
		'
		'Label56
		'
		Me.Label56.Location = New System.Drawing.Point(26, 200)
		Me.Label56.Name = "Label56"
		Me.Label56.Size = New System.Drawing.Size(91, 20)
		Me.Label56.TabIndex = 4
		Me.Label56.Text = "Madina"
		'
		'Label52
		'
		Me.Label52.Location = New System.Drawing.Point(26, 108)
		Me.Label52.Name = "Label52"
		Me.Label52.Size = New System.Drawing.Size(91, 20)
		Me.Label52.TabIndex = 4
		Me.Label52.Text = "Aseer"
		'
		'Label47
		'
		Me.Label47.Location = New System.Drawing.Point(26, 39)
		Me.Label47.Name = "Label47"
		Me.Label47.Size = New System.Drawing.Size(91, 20)
		Me.Label47.TabIndex = 4
		Me.Label47.Text = "Al - Baha"
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
		Me.DssPanel1.Size = New System.Drawing.Size(575, 367)
		Me.DssPanel1.TabIndex = 193
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
		Me.Label28.Location = New System.Drawing.Point(195, 138)
		Me.Label28.Name = "Label28"
		Me.Label28.Size = New System.Drawing.Size(90, 13)
		Me.Label28.TabIndex = 179
		Me.Label28.Text = "Env"
		Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label30
		'
		Me.Label30.Location = New System.Drawing.Point(389, 138)
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
		Me.nudTpsx.TabIndex = 1
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
		Me.nudTpmz.TabIndex = 2
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
		Me.nudAgrUFRO.TabIndex = 1
		Me.nudAgrUFRO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudAgrUFRO.Value = New Decimal(New Integer() {50, 0, 0, 0})
		'
		'Label29
		'
		Me.Label29.Location = New System.Drawing.Point(291, 138)
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
		Me.nudEnvw.Location = New System.Drawing.Point(195, 158)
		Me.nudEnvw.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.nudEnvw.Name = "nudEnvw"
		Me.nudEnvw.Size = New System.Drawing.Size(90, 20)
		Me.nudEnvw.TabIndex = 3
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
		Me.nudgwsp.TabIndex = 3
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
		Me.nudTotpla.TabIndex = 6
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
		Me.nudIndUFRO.TabIndex = 1
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
		Me.nudSocw.Location = New System.Drawing.Point(389, 158)
		Me.nudSocw.Name = "nudSocw"
		Me.nudSocw.Size = New System.Drawing.Size(90, 20)
		Me.nudSocw.TabIndex = 5
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
		Me.nudTpbx.TabIndex = 0
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
		Me.nudEcow.Location = New System.Drawing.Point(291, 158)
		Me.nudEcow.Name = "nudEcow"
		Me.nudEcow.Size = New System.Drawing.Size(90, 20)
		Me.nudEcow.TabIndex = 4
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
		Me.nudsmqi.TabIndex = 0
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
		Me.nudLanUFRO.TabIndex = 1
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
		Me.nudsbqi.TabIndex = 0
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
		Me.nudLanUF.TabIndex = 0
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
		Me.nudssqi.TabIndex = 0
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
		Me.nudIndUF.TabIndex = 0
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
		'frmNegotiation
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(941, 570)
		Me.Controls.Add(Me.btnNext)
		Me.Controls.Add(Me.btnPrev)
		Me.Controls.Add(Me.btnLoadData)
		Me.Controls.Add(Me.pnlMain)
		Me.Name = "frmNegotiation"
		Me.Text = "Spatial Decision Support System"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.dsParameters, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DSData, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DSLocations, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlMain.ResumeLayout(False)
		Me.SplitContainer.Panel1.ResumeLayout(False)
		Me.SplitContainer.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer.ResumeLayout(False)
		Me.grbOuput.ResumeLayout(False)
		Me.tcoOutput.ResumeLayout(False)
		Me.tpaImpacts.ResumeLayout(False)
		Me.gboOutputImpacts.ResumeLayout(False)
		Me.pnlOutSocSmall.ResumeLayout(False)
		Me.pnlOutEnvLarge.ResumeLayout(False)
		Me.pnlOutEnvSmall.ResumeLayout(False)
		Me.pnlOutEcoLarge.ResumeLayout(False)
		Me.pnlOutSocLarge.ResumeLayout(False)
		Me.pnlOutEcoSmall.ResumeLayout(False)
		Me.tpaWeights.ResumeLayout(False)
		CType(Me.pboGraphWeights, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tpaStandards.ResumeLayout(False)
		CType(Me.pboGraphStandards, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tpaEfficencies.ResumeLayout(False)
		CType(Me.pboGraphEfficiencies, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tpaUses.ResumeLayout(False)
		Me.gboOutputUses.ResumeLayout(False)
		Me.pnlOutAgrSmall.ResumeLayout(False)
		Me.pnlOutIndLarge.ResumeLayout(False)
		Me.pnlOutLanSmall.ResumeLayout(False)
		Me.pnlOutLanLarge.ResumeLayout(False)
		Me.pnlOutAgrLarge.ResumeLayout(False)
		Me.grbPopulation.ResumeLayout(False)
		Me.pnlPop20_2.ResumeLayout(False)
		CType(Me.nudPop20_3_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_7_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_2_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_12_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_10_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_13_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_6_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_8_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_1_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_4_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_9_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_11_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_5_2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlPop20_1.ResumeLayout(False)
		CType(Me.nudPop20_3_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_7_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_2_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_6_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_12_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_1_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_9_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_13_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_10_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_11_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_8_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_5_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudPop20_4_1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grbIndustrialDistricts.ResumeLayout(False)
		Me.pnlInddispln.ResumeLayout(False)
		CType(Me.nudInddispln3_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddispln7_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddispln2_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddispln12_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddispln10_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddispln13_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddispln6_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddispln8_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddispln1_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddispln4_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddispln9_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddispln11_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddispln5_2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlInddiscur.ResumeLayout(False)
		CType(Me.nudInddiscur3_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddiscur7_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddiscur2_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddiscur6_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddiscur12_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddiscur1_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddiscur9_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddiscur13_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddiscur10_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddiscur11_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddiscur8_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddiscur5_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInddiscur4_2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grbWaterQuality.ResumeLayout(False)
		Me.pnlTSS.ResumeLayout(False)
		CType(Me.nudTSS3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTSS2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTSS7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTSS10, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTSS12, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTSS6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTSS13, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTSS1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTSS8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTSS9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTSS4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTSS5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTSS11, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlTDS.ResumeLayout(False)
		CType(Me.nudTDS3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTDS2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTDS7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTDS10, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTDS6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTDS12, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTDS1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTDS9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTDS13, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTDS5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTDS11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTDS8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTDS4, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlBOD.ResumeLayout(False)
		CType(Me.nudBOD3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudBOD2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudBOD7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudBOD6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudBOD1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudBOD9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudBOD12, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudBOD10, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudBOD11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudBOD5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudBOD13, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudBOD4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudBOD8, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grbWaterCosts.ResumeLayout(False)
		Me.pnlGro.ResumeLayout(False)
		CType(Me.nudGro3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudGro7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudGro2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudGro12, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudGro10, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudGro13, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudGro6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudGro8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudGro1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudGro4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudGro9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudGro11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudGro5, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlDes.ResumeLayout(False)
		CType(Me.nudDes3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudDes7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudDes2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudDes6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudDes12, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudDes1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudDes9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudDes13, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudDes10, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudDes11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudDes8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudDes5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudDes4, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grbMisc.ResumeLayout(False)
		Me.DssPanel1.ResumeLayout(False)
		CType(Me.nudTpsx, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTpmz, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudAgrUFRO, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudEnvw, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudgwsp, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTotpla, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudIndUFRO, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudSocw, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTpbx, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudEcow, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudsmqi, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudLanUFRO, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudsbqi, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudLanUF, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudssqi, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudAgrUF, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudIndUF, System.ComponentModel.ISupportInitialize).EndInit()
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
	Friend WithEvents dsParameters As parameters
	Friend WithEvents TAParameters As SDSS.parametersTableAdapters.parametersTableAdapter
	Friend WithEvents Label51 As System.Windows.Forms.Label
	Friend WithEvents Label50 As System.Windows.Forms.Label
	Friend WithEvents Label47 As System.Windows.Forms.Label
	Friend WithEvents Label54 As System.Windows.Forms.Label
	Friend WithEvents Label53 As System.Windows.Forms.Label
	Friend WithEvents Label52 As System.Windows.Forms.Label
	Friend WithEvents Label63 As System.Windows.Forms.Label
	Friend WithEvents Label55 As System.Windows.Forms.Label
	Friend WithEvents Label62 As System.Windows.Forms.Label
	Friend WithEvents Label57 As System.Windows.Forms.Label
	Friend WithEvents Label56 As System.Windows.Forms.Label
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
	Friend WithEvents daData As SqlClient.SqlDataAdapter
	Friend WithEvents Label121 As System.Windows.Forms.Label
	Friend WithEvents Label120 As System.Windows.Forms.Label
	Friend WithEvents nudDes11 As DSSNumericUpDown
	Friend WithEvents nudDes10 As DSSNumericUpDown
	Friend WithEvents Label130 As System.Windows.Forms.Label
	Friend WithEvents Label128 As System.Windows.Forms.Label
	Friend WithEvents btnLoadData As System.Windows.Forms.Button
	Friend WithEvents SqlInsertCommand As System.Data.SqlClient.SqlCommand
	Friend WithEvents SqlConnection As System.Data.SqlClient.SqlConnection
	Friend WithEvents SqlSelectCommand As System.Data.SqlClient.SqlCommand
	Friend WithEvents ElementHost1 As System.Windows.Forms.Integration.ElementHost
	Friend mapControl As mapControl.mapControl
	Friend WithEvents daLocations As System.Data.SqlClient.SqlDataAdapter
	Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
	Friend WithEvents DSLocations As SDSS.DSLocations
	Friend WithEvents pnlMain As System.Windows.Forms.Panel
	Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
	Friend WithEvents nudTSS7 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTDS7 As SDSS.DSSNumericUpDown
	Friend WithEvents nudBOD7 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTSS12 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTDS12 As SDSS.DSSNumericUpDown
	Friend WithEvents nudBOD12 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTSS13 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTDS13 As SDSS.DSSNumericUpDown
	Friend WithEvents nudBOD13 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTSS8 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTDS8 As SDSS.DSSNumericUpDown
	Friend WithEvents nudBOD8 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTSS4 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTDS4 As SDSS.DSSNumericUpDown
	Friend WithEvents nudBOD4 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTSS11 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTDS11 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTSS5 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTDS5 As SDSS.DSSNumericUpDown
	Friend WithEvents nudBOD5 As SDSS.DSSNumericUpDown
	Friend WithEvents nudBOD11 As SDSS.DSSNumericUpDown
	Friend WithEvents nudBOD10 As SDSS.DSSNumericUpDown
	Friend WithEvents nudBOD9 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTSS9 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTDS9 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTSS1 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTSS6 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTDS1 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTSS10 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTDS6 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTDS10 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTSS2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudBOD1 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTDS2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTSS3 As SDSS.DSSNumericUpDown
	Friend WithEvents nudBOD6 As SDSS.DSSNumericUpDown
	Friend WithEvents nudTDS3 As SDSS.DSSNumericUpDown
	Friend WithEvents nudBOD2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudBOD3 As SDSS.DSSNumericUpDown
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents Label8 As System.Windows.Forms.Label
	Friend WithEvents Label9 As System.Windows.Forms.Label
	Friend WithEvents Label11 As System.Windows.Forms.Label
	Friend WithEvents Label14 As System.Windows.Forms.Label
	Friend WithEvents Label15 As System.Windows.Forms.Label
	Friend WithEvents Label16 As System.Windows.Forms.Label
	Friend WithEvents Label17 As System.Windows.Forms.Label
	Friend WithEvents Label21 As System.Windows.Forms.Label
	Friend WithEvents Label18 As System.Windows.Forms.Label
	Friend WithEvents Label19 As System.Windows.Forms.Label
	Friend WithEvents Label20 As System.Windows.Forms.Label
	Friend WithEvents nudPop20_7_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_7_1 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_12_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_12_1 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_13_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_13_1 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_8_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_8_1 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_4_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_4_1 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_11_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_5_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_5_1 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_11_1 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_10_1 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_9_1 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_9_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_1_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_6_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_10_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_1_1 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_2_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_6_1 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_3_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_2_1 As SDSS.DSSNumericUpDown
	Friend WithEvents nudPop20_3_1 As SDSS.DSSNumericUpDown
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label22 As System.Windows.Forms.Label
	Friend WithEvents Label32 As System.Windows.Forms.Label
	Friend WithEvents Label37 As System.Windows.Forms.Label
	Friend WithEvents Label44 As System.Windows.Forms.Label
	Friend WithEvents Label45 As System.Windows.Forms.Label
	Friend WithEvents Label46 As System.Windows.Forms.Label
	Friend WithEvents Label48 As System.Windows.Forms.Label
	Friend WithEvents Label49 As System.Windows.Forms.Label
	Friend WithEvents Label58 As System.Windows.Forms.Label
	Friend WithEvents Label59 As System.Windows.Forms.Label
	Friend WithEvents Label65 As System.Windows.Forms.Label
	Friend WithEvents Label66 As System.Windows.Forms.Label
	Friend WithEvents Label69 As System.Windows.Forms.Label
	Friend WithEvents Label67 As System.Windows.Forms.Label
	Friend WithEvents nudInddispln7_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur7_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln12_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur12_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln13_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur13_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln8_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur8_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln4_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur4_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln11_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln5_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur5_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur11_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur10_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur9_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln9_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln1_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln6_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln10_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur1_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln2_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur6_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddispln3_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur2_2 As SDSS.DSSNumericUpDown
	Friend WithEvents nudInddiscur3_2 As SDSS.DSSNumericUpDown
	Friend WithEvents Label38 As System.Windows.Forms.Label
	Friend WithEvents Label39 As System.Windows.Forms.Label
	Friend WithEvents Label40 As System.Windows.Forms.Label
	Friend WithEvents Label41 As System.Windows.Forms.Label
	Friend WithEvents Label42 As System.Windows.Forms.Label
	Friend WithEvents Label43 As System.Windows.Forms.Label
	Friend WithEvents Label71 As System.Windows.Forms.Label
	Friend WithEvents Label72 As System.Windows.Forms.Label
	Friend WithEvents Label73 As System.Windows.Forms.Label
	Friend WithEvents Label74 As System.Windows.Forms.Label
	Friend WithEvents Label75 As System.Windows.Forms.Label
	Friend WithEvents Label76 As System.Windows.Forms.Label
	Friend WithEvents Label77 As System.Windows.Forms.Label
	Friend WithEvents Label86 As System.Windows.Forms.Label
	Friend WithEvents Label88 As System.Windows.Forms.Label
	Friend WithEvents lblTDS As DSSLabel
	Friend WithEvents nudSocw As SDSS.DSSNumericUpDown
	Friend WithEvents nudEcow As SDSS.DSSNumericUpDown
	Friend WithEvents nudTpbx As SDSS.DSSNumericUpDown
	Friend WithEvents nudEnvw As SDSS.DSSNumericUpDown
	Friend WithEvents nudTpsx As SDSS.DSSNumericUpDown
	Friend WithEvents Label25 As System.Windows.Forms.Label
	Friend WithEvents Label34 As System.Windows.Forms.Label
	Friend WithEvents Label78 As System.Windows.Forms.Label
	Friend WithEvents Label91 As System.Windows.Forms.Label
	Friend WithEvents lblBOD As DSSLabel
	Friend WithEvents Label68 As System.Windows.Forms.Label
	Friend WithEvents Label64 As System.Windows.Forms.Label
	Friend WithEvents Label92 As System.Windows.Forms.Label
	Friend WithEvents Label70 As System.Windows.Forms.Label
	Friend WithEvents nudTpmz As SDSS.DSSNumericUpDown
	Friend WithEvents Label13 As System.Windows.Forms.Label
	Friend WithEvents nudTotpla As SDSS.DSSNumericUpDown
	Friend WithEvents Label23 As System.Windows.Forms.Label
	Friend WithEvents SqlDeleteCommand As System.Data.SqlClient.SqlCommand
	Friend WithEvents SqlUpdateCommand As System.Data.SqlClient.SqlCommand
	Friend WithEvents Label26 As System.Windows.Forms.Label
	Friend WithEvents Label24 As System.Windows.Forms.Label
	Friend WithEvents nudLanUF As SDSS.DSSNumericUpDown
	Friend WithEvents nudIndUF As SDSS.DSSNumericUpDown
	Friend WithEvents nudAgrUF As SDSS.DSSNumericUpDown
	Friend WithEvents nudLanUFRO As SDSS.DSSNumericUpDown
	Friend WithEvents nudIndUFRO As SDSS.DSSNumericUpDown
	Friend WithEvents nudAgrUFRO As SDSS.DSSNumericUpDown
	Friend WithEvents Label12 As System.Windows.Forms.Label
	Friend WithEvents Label10 As System.Windows.Forms.Label
	Friend WithEvents Label30 As System.Windows.Forms.Label
	Friend WithEvents Label29 As System.Windows.Forms.Label
	Friend WithEvents nudgwsp As SDSS.DSSNumericUpDown
	Friend WithEvents Label27 As System.Windows.Forms.Label
	Friend WithEvents Label28 As System.Windows.Forms.Label
	Friend WithEvents pnlGro As SDSS.DSSPanel
	Friend WithEvents pnlDes As SDSS.DSSPanel
	Friend WithEvents pnlInddispln As SDSS.DSSPanel
	Friend WithEvents pnlInddiscur As SDSS.DSSPanel
	Friend WithEvents pnlTSS As SDSS.DSSPanel
	Friend WithEvents pnlTDS As SDSS.DSSPanel
	Friend WithEvents pnlBOD As SDSS.DSSPanel
	Friend WithEvents pnlPop20_2 As SDSS.DSSPanel
	Friend WithEvents pnlPop20_1 As SDSS.DSSPanel
	Friend WithEvents DssPanel1 As SDSS.DSSPanel
	Friend WithEvents tcoOutput As System.Windows.Forms.TabControl
	Friend WithEvents tpaUses As System.Windows.Forms.TabPage
	Friend WithEvents tpaImpacts As System.Windows.Forms.TabPage
	Friend WithEvents tpaWeights As System.Windows.Forms.TabPage
	Friend WithEvents tpaStandards As System.Windows.Forms.TabPage
	Friend WithEvents tpaEfficencies As System.Windows.Forms.TabPage
	Friend WithEvents Label135 As System.Windows.Forms.Label
	Friend WithEvents Label133 As System.Windows.Forms.Label
	Friend WithEvents Label31 As System.Windows.Forms.Label
	Friend WithEvents Label33 As System.Windows.Forms.Label
	Friend WithEvents Label35 As System.Windows.Forms.Label
	Friend WithEvents Label36 As System.Windows.Forms.Label
	Friend WithEvents Label60 As System.Windows.Forms.Label
	Friend WithEvents Label61 As System.Windows.Forms.Label
	Friend WithEvents Label79 As System.Windows.Forms.Label
	Friend WithEvents Label80 As System.Windows.Forms.Label
	Friend WithEvents Label81 As System.Windows.Forms.Label
	Friend WithEvents Label82 As System.Windows.Forms.Label
	Friend WithEvents Label83 As System.Windows.Forms.Label
	Friend WithEvents Label84 As System.Windows.Forms.Label
	Friend WithEvents Label85 As System.Windows.Forms.Label
	Friend WithEvents Label103 As System.Windows.Forms.Label
	Friend WithEvents Label104 As System.Windows.Forms.Label
	Friend WithEvents Label105 As System.Windows.Forms.Label
	Friend WithEvents Label106 As System.Windows.Forms.Label
	Friend WithEvents Label107 As System.Windows.Forms.Label
	Friend WithEvents Label108 As System.Windows.Forms.Label
	Friend WithEvents Label109 As System.Windows.Forms.Label
	Friend WithEvents Label110 As System.Windows.Forms.Label
	Friend WithEvents Label111 As System.Windows.Forms.Label
	Friend WithEvents Label112 As System.Windows.Forms.Label
	Friend WithEvents Label113 As System.Windows.Forms.Label
	Friend WithEvents Label114 As System.Windows.Forms.Label
	Friend WithEvents Label115 As System.Windows.Forms.Label
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
	Friend WithEvents nudsmqi As SDSS.DSSNumericUpDown
	Friend WithEvents nudsbqi As SDSS.DSSNumericUpDown
	Friend WithEvents nudssqi As SDSS.DSSNumericUpDown
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
End Class
