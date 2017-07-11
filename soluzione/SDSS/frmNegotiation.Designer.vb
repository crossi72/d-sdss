<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNegotiation
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
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.tpaUses = New System.Windows.Forms.TabPage()
		Me.lblLan1_13 = New SDSS.DSSLabel()
		Me.lblInd1_13 = New SDSS.DSSLabel()
		Me.lblAgr1_13 = New SDSS.DSSLabel()
		Me.lblLan1_10 = New SDSS.DSSLabel()
		Me.lblInd1_10 = New SDSS.DSSLabel()
		Me.lblAgr1_10 = New SDSS.DSSLabel()
		Me.lblLan1_7 = New SDSS.DSSLabel()
		Me.lblInd1_7 = New SDSS.DSSLabel()
		Me.lblAgr1_7 = New SDSS.DSSLabel()
		Me.lblLan1_3 = New SDSS.DSSLabel()
		Me.lblInd1_3 = New SDSS.DSSLabel()
		Me.lblAgr1_3 = New SDSS.DSSLabel()
		Me.lblLan1_12 = New SDSS.DSSLabel()
		Me.lblInd1_12 = New SDSS.DSSLabel()
		Me.lblAgr1_12 = New SDSS.DSSLabel()
		Me.lblLan1_9 = New SDSS.DSSLabel()
		Me.lblInd1_9 = New SDSS.DSSLabel()
		Me.lblAgr1_9 = New SDSS.DSSLabel()
		Me.lblLan1_6 = New SDSS.DSSLabel()
		Me.lblInd1_6 = New SDSS.DSSLabel()
		Me.lblAgr1_6 = New SDSS.DSSLabel()
		Me.lblLan1_2 = New SDSS.DSSLabel()
		Me.lblInd1_2 = New SDSS.DSSLabel()
		Me.lblAgr1_2 = New SDSS.DSSLabel()
		Me.lblLan1_11 = New SDSS.DSSLabel()
		Me.lblInd1_11 = New SDSS.DSSLabel()
		Me.lblAgr1_11 = New SDSS.DSSLabel()
		Me.lblLan1_8 = New SDSS.DSSLabel()
		Me.lblInd1_8 = New SDSS.DSSLabel()
		Me.lblAgr1_8 = New SDSS.DSSLabel()
		Me.lblLan1_4 = New SDSS.DSSLabel()
		Me.lblInd1_4 = New SDSS.DSSLabel()
		Me.lblAgr1_4 = New SDSS.DSSLabel()
		Me.lblLan1_5 = New SDSS.DSSLabel()
		Me.lblInd1_5 = New SDSS.DSSLabel()
		Me.lblAgr1_5 = New SDSS.DSSLabel()
		Me.lblLan1_1 = New SDSS.DSSLabel()
		Me.lblInd1_1 = New SDSS.DSSLabel()
		Me.lblAgr1_1 = New SDSS.DSSLabel()
		Me.Label135 = New System.Windows.Forms.Label()
		Me.Label134 = New System.Windows.Forms.Label()
		Me.Label133 = New System.Windows.Forms.Label()
		Me.Label31 = New System.Windows.Forms.Label()
		Me.Label33 = New System.Windows.Forms.Label()
		Me.Label35 = New System.Windows.Forms.Label()
		Me.Label36 = New System.Windows.Forms.Label()
		Me.Label60 = New System.Windows.Forms.Label()
		Me.Label61 = New System.Windows.Forms.Label()
		Me.Label79 = New System.Windows.Forms.Label()
		Me.Label80 = New System.Windows.Forms.Label()
		Me.Label81 = New System.Windows.Forms.Label()
		Me.Label82 = New System.Windows.Forms.Label()
		Me.Label83 = New System.Windows.Forms.Label()
		Me.Label84 = New System.Windows.Forms.Label()
		Me.Label85 = New System.Windows.Forms.Label()
		Me.tpaImpacts = New System.Windows.Forms.TabPage()
		Me.lblEnv13_1 = New SDSS.DSSLabel()
		Me.lblSoc13_1 = New SDSS.DSSLabel()
		Me.lblEco13_1 = New SDSS.DSSLabel()
		Me.lblEnv10_1 = New SDSS.DSSLabel()
		Me.lblSoc10_1 = New SDSS.DSSLabel()
		Me.lblEco10_1 = New SDSS.DSSLabel()
		Me.lblEnv1_7 = New SDSS.DSSLabel()
		Me.lblSoc1_7 = New SDSS.DSSLabel()
		Me.lblEco1_7 = New SDSS.DSSLabel()
		Me.lblEnv1_3 = New SDSS.DSSLabel()
		Me.lblSoc1_3 = New SDSS.DSSLabel()
		Me.lblEco1_3 = New SDSS.DSSLabel()
		Me.lblEnv1_12 = New SDSS.DSSLabel()
		Me.lblSoc1_12 = New SDSS.DSSLabel()
		Me.lblEco1_12 = New SDSS.DSSLabel()
		Me.lblEnv1_9 = New SDSS.DSSLabel()
		Me.lblSoc1_9 = New SDSS.DSSLabel()
		Me.lblEco1_9 = New SDSS.DSSLabel()
		Me.lblEnv1_6 = New SDSS.DSSLabel()
		Me.lblSoc1_6 = New SDSS.DSSLabel()
		Me.lblEco1_6 = New SDSS.DSSLabel()
		Me.lblEnv1_2 = New SDSS.DSSLabel()
		Me.lblSoc1_2 = New SDSS.DSSLabel()
		Me.lblEco1_2 = New SDSS.DSSLabel()
		Me.lblEnv1_11 = New SDSS.DSSLabel()
		Me.lblSoc1_11 = New SDSS.DSSLabel()
		Me.lblEco1_11 = New SDSS.DSSLabel()
		Me.lblEnv1_8 = New SDSS.DSSLabel()
		Me.lblSoc1_8 = New SDSS.DSSLabel()
		Me.lblEco1_8 = New SDSS.DSSLabel()
		Me.lblEnv1_4 = New SDSS.DSSLabel()
		Me.lblSoc1_4 = New SDSS.DSSLabel()
		Me.lblEco1_4 = New SDSS.DSSLabel()
		Me.lblEnv1_5 = New SDSS.DSSLabel()
		Me.lblSoc1_5 = New SDSS.DSSLabel()
		Me.lblEco1_5 = New SDSS.DSSLabel()
		Me.lblEnv1_1 = New SDSS.DSSLabel()
		Me.lblSoc1_1 = New SDSS.DSSLabel()
		Me.lblEco1_1 = New SDSS.DSSLabel()
		Me.Label178 = New System.Windows.Forms.Label()
		Me.Label179 = New System.Windows.Forms.Label()
		Me.Label180 = New System.Windows.Forms.Label()
		Me.Label103 = New System.Windows.Forms.Label()
		Me.Label104 = New System.Windows.Forms.Label()
		Me.Label105 = New System.Windows.Forms.Label()
		Me.Label106 = New System.Windows.Forms.Label()
		Me.Label107 = New System.Windows.Forms.Label()
		Me.Label108 = New System.Windows.Forms.Label()
		Me.Label109 = New System.Windows.Forms.Label()
		Me.Label110 = New System.Windows.Forms.Label()
		Me.Label111 = New System.Windows.Forms.Label()
		Me.Label112 = New System.Windows.Forms.Label()
		Me.Label113 = New System.Windows.Forms.Label()
		Me.Label114 = New System.Windows.Forms.Label()
		Me.Label115 = New System.Windows.Forms.Label()
		Me.tpaWeights = New System.Windows.Forms.TabPage()
		Me.tpaStandards = New System.Windows.Forms.TabPage()
		Me.tpaEfficencies = New System.Windows.Forms.TabPage()
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
		Me.ElementHost1 = New System.Windows.Forms.Integration.ElementHost()
		Me.mapControl = New mapControl.mapControl()
		Me.DssLabel1 = New SDSS.DSSLabel()
		Me.DssLabel2 = New SDSS.DSSLabel()
		Me.DssLabel3 = New SDSS.DSSLabel()
		Me.DssLabel4 = New SDSS.DSSLabel()
		Me.DssLabel5 = New SDSS.DSSLabel()
		Me.DssLabel6 = New SDSS.DSSLabel()
		Me.DssLabel7 = New SDSS.DSSLabel()
		Me.DssLabel8 = New SDSS.DSSLabel()
		Me.DssLabel9 = New SDSS.DSSLabel()
		Me.DssLabel10 = New SDSS.DSSLabel()
		Me.DssLabel11 = New SDSS.DSSLabel()
		Me.DssLabel12 = New SDSS.DSSLabel()
		Me.DssLabel13 = New SDSS.DSSLabel()
		Me.DssLabel14 = New SDSS.DSSLabel()
		Me.DssLabel15 = New SDSS.DSSLabel()
		Me.DssLabel16 = New SDSS.DSSLabel()
		Me.DssLabel17 = New SDSS.DSSLabel()
		Me.DssLabel18 = New SDSS.DSSLabel()
		Me.DssLabel19 = New SDSS.DSSLabel()
		Me.DssLabel20 = New SDSS.DSSLabel()
		Me.DssLabel21 = New SDSS.DSSLabel()
		Me.DssLabel22 = New SDSS.DSSLabel()
		Me.DssLabel23 = New SDSS.DSSLabel()
		Me.DssLabel24 = New SDSS.DSSLabel()
		Me.DssLabel25 = New SDSS.DSSLabel()
		Me.DssLabel26 = New SDSS.DSSLabel()
		Me.DssLabel27 = New SDSS.DSSLabel()
		Me.DssLabel28 = New SDSS.DSSLabel()
		Me.DssLabel29 = New SDSS.DSSLabel()
		Me.DssLabel30 = New SDSS.DSSLabel()
		Me.DssLabel31 = New SDSS.DSSLabel()
		Me.DssLabel32 = New SDSS.DSSLabel()
		Me.DssLabel33 = New SDSS.DSSLabel()
		Me.DssLabel34 = New SDSS.DSSLabel()
		Me.DssLabel35 = New SDSS.DSSLabel()
		Me.DssLabel36 = New SDSS.DSSLabel()
		Me.DssLabel37 = New SDSS.DSSLabel()
		Me.DssLabel38 = New SDSS.DSSLabel()
		Me.DssLabel39 = New SDSS.DSSLabel()
		Me.Label87 = New System.Windows.Forms.Label()
		Me.Label89 = New System.Windows.Forms.Label()
		Me.Label90 = New System.Windows.Forms.Label()
		Me.Label93 = New System.Windows.Forms.Label()
		Me.Label94 = New System.Windows.Forms.Label()
		Me.DssLabel40 = New SDSS.DSSLabel()
		Me.DssLabel41 = New SDSS.DSSLabel()
		Me.DssLabel42 = New SDSS.DSSLabel()
		Me.DssLabel43 = New SDSS.DSSLabel()
		Me.DssLabel44 = New SDSS.DSSLabel()
		Me.DssLabel45 = New SDSS.DSSLabel()
		Me.DssLabel46 = New SDSS.DSSLabel()
		Me.DssLabel47 = New SDSS.DSSLabel()
		Me.DssLabel48 = New SDSS.DSSLabel()
		Me.DssLabel49 = New SDSS.DSSLabel()
		Me.DssLabel50 = New SDSS.DSSLabel()
		Me.DssLabel51 = New SDSS.DSSLabel()
		Me.DssLabel52 = New SDSS.DSSLabel()
		Me.DssLabel53 = New SDSS.DSSLabel()
		Me.DssLabel54 = New SDSS.DSSLabel()
		Me.DssLabel55 = New SDSS.DSSLabel()
		Me.DssLabel56 = New SDSS.DSSLabel()
		Me.DssLabel57 = New SDSS.DSSLabel()
		Me.DssLabel58 = New SDSS.DSSLabel()
		Me.DssLabel59 = New SDSS.DSSLabel()
		Me.DssLabel60 = New SDSS.DSSLabel()
		Me.DssLabel61 = New SDSS.DSSLabel()
		Me.DssLabel62 = New SDSS.DSSLabel()
		Me.DssLabel63 = New SDSS.DSSLabel()
		Me.DssLabel64 = New SDSS.DSSLabel()
		Me.DssLabel65 = New SDSS.DSSLabel()
		Me.DssLabel66 = New SDSS.DSSLabel()
		Me.DssLabel67 = New SDSS.DSSLabel()
		Me.DssLabel68 = New SDSS.DSSLabel()
		Me.DssLabel69 = New SDSS.DSSLabel()
		Me.DssLabel70 = New SDSS.DSSLabel()
		Me.DssLabel71 = New SDSS.DSSLabel()
		Me.DssLabel72 = New SDSS.DSSLabel()
		Me.DssLabel73 = New SDSS.DSSLabel()
		Me.DssLabel74 = New SDSS.DSSLabel()
		Me.DssLabel75 = New SDSS.DSSLabel()
		Me.DssLabel76 = New SDSS.DSSLabel()
		Me.DssLabel77 = New SDSS.DSSLabel()
		Me.DssLabel78 = New SDSS.DSSLabel()
		Me.Label95 = New System.Windows.Forms.Label()
		Me.Label96 = New System.Windows.Forms.Label()
		Me.Label97 = New System.Windows.Forms.Label()
		Me.Label98 = New System.Windows.Forms.Label()
		Me.Label99 = New System.Windows.Forms.Label()
		CType(Me.dsParameters, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DSData, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DSLocations, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlMain.SuspendLayout()
		CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer.Panel1.SuspendLayout()
		Me.SplitContainer.Panel2.SuspendLayout()
		Me.SplitContainer.SuspendLayout()
		Me.grbOuput.SuspendLayout()
		Me.TabControl1.SuspendLayout()
		Me.tpaUses.SuspendLayout()
		Me.tpaImpacts.SuspendLayout()
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
		Me.btnNext.Location = New System.Drawing.Point(441, 505)
		Me.btnNext.Name = "btnNext"
		Me.btnNext.Size = New System.Drawing.Size(90, 36)
		Me.btnNext.TabIndex = 0
		Me.btnNext.Text = "Next"
		Me.btnNext.UseVisualStyleBackColor = True
		'
		'btnPrev
		'
		Me.btnPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnPrev.Location = New System.Drawing.Point(342, 505)
		Me.btnPrev.Name = "btnPrev"
		Me.btnPrev.Size = New System.Drawing.Size(90, 36)
		Me.btnPrev.TabIndex = 29
		Me.btnPrev.Text = "Previous"
		Me.btnPrev.UseVisualStyleBackColor = True
		'
		'btnLoadData
		'
		Me.btnLoadData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnLoadData.Location = New System.Drawing.Point(114, 505)
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
		Me.pnlMain.Size = New System.Drawing.Size(940, 499)
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
		Me.SplitContainer.Panel1.Controls.Add(Me.grbMisc)
		Me.SplitContainer.Panel1.Controls.Add(Me.grbWaterQuality)
		Me.SplitContainer.Panel1.Controls.Add(Me.grbWaterCosts)
		'
		'SplitContainer.Panel2
		'
		Me.SplitContainer.Panel2.Controls.Add(Me.ElementHost1)
		Me.SplitContainer.Size = New System.Drawing.Size(940, 499)
		Me.SplitContainer.SplitterDistance = 746
		Me.SplitContainer.SplitterWidth = 2
		Me.SplitContainer.TabIndex = 0
		Me.SplitContainer.TabStop = False
		'
		'grbOuput
		'
		Me.grbOuput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.grbOuput.Controls.Add(Me.TabControl1)
		Me.grbOuput.DSSDrawOnMap = True
		Me.grbOuput.DSSVisible = True
		Me.grbOuput.ForeColor = System.Drawing.Color.Black
		Me.grbOuput.Location = New System.Drawing.Point(0, 0)
		Me.grbOuput.Name = "grbOuput"
		Me.grbOuput.Size = New System.Drawing.Size(578, 499)
		Me.grbOuput.TabIndex = 26
		Me.grbOuput.TabStop = False
		Me.grbOuput.Text = "Summary"
		Me.grbOuput.Visible = False
		'
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.tpaUses)
		Me.TabControl1.Controls.Add(Me.tpaImpacts)
		Me.TabControl1.Controls.Add(Me.tpaWeights)
		Me.TabControl1.Controls.Add(Me.tpaStandards)
		Me.TabControl1.Controls.Add(Me.tpaEfficencies)
		Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TabControl1.Location = New System.Drawing.Point(3, 16)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(572, 480)
		Me.TabControl1.TabIndex = 0
		'
		'tpaUses
		'
		Me.tpaUses.Controls.Add(Me.Label94)
		Me.tpaUses.Controls.Add(Me.Label93)
		Me.tpaUses.Controls.Add(Me.DssLabel1)
		Me.tpaUses.Controls.Add(Me.DssLabel2)
		Me.tpaUses.Controls.Add(Me.DssLabel3)
		Me.tpaUses.Controls.Add(Me.DssLabel4)
		Me.tpaUses.Controls.Add(Me.DssLabel5)
		Me.tpaUses.Controls.Add(Me.DssLabel6)
		Me.tpaUses.Controls.Add(Me.DssLabel7)
		Me.tpaUses.Controls.Add(Me.DssLabel8)
		Me.tpaUses.Controls.Add(Me.DssLabel9)
		Me.tpaUses.Controls.Add(Me.DssLabel10)
		Me.tpaUses.Controls.Add(Me.DssLabel11)
		Me.tpaUses.Controls.Add(Me.DssLabel12)
		Me.tpaUses.Controls.Add(Me.DssLabel13)
		Me.tpaUses.Controls.Add(Me.DssLabel14)
		Me.tpaUses.Controls.Add(Me.DssLabel15)
		Me.tpaUses.Controls.Add(Me.DssLabel16)
		Me.tpaUses.Controls.Add(Me.DssLabel17)
		Me.tpaUses.Controls.Add(Me.DssLabel18)
		Me.tpaUses.Controls.Add(Me.DssLabel19)
		Me.tpaUses.Controls.Add(Me.DssLabel20)
		Me.tpaUses.Controls.Add(Me.DssLabel21)
		Me.tpaUses.Controls.Add(Me.DssLabel22)
		Me.tpaUses.Controls.Add(Me.DssLabel23)
		Me.tpaUses.Controls.Add(Me.DssLabel24)
		Me.tpaUses.Controls.Add(Me.DssLabel25)
		Me.tpaUses.Controls.Add(Me.DssLabel26)
		Me.tpaUses.Controls.Add(Me.DssLabel27)
		Me.tpaUses.Controls.Add(Me.DssLabel28)
		Me.tpaUses.Controls.Add(Me.DssLabel29)
		Me.tpaUses.Controls.Add(Me.DssLabel30)
		Me.tpaUses.Controls.Add(Me.DssLabel31)
		Me.tpaUses.Controls.Add(Me.DssLabel32)
		Me.tpaUses.Controls.Add(Me.DssLabel33)
		Me.tpaUses.Controls.Add(Me.DssLabel34)
		Me.tpaUses.Controls.Add(Me.DssLabel35)
		Me.tpaUses.Controls.Add(Me.DssLabel36)
		Me.tpaUses.Controls.Add(Me.DssLabel37)
		Me.tpaUses.Controls.Add(Me.DssLabel38)
		Me.tpaUses.Controls.Add(Me.DssLabel39)
		Me.tpaUses.Controls.Add(Me.Label87)
		Me.tpaUses.Controls.Add(Me.Label89)
		Me.tpaUses.Controls.Add(Me.Label90)
		Me.tpaUses.Controls.Add(Me.lblLan1_13)
		Me.tpaUses.Controls.Add(Me.lblInd1_13)
		Me.tpaUses.Controls.Add(Me.lblAgr1_13)
		Me.tpaUses.Controls.Add(Me.lblLan1_10)
		Me.tpaUses.Controls.Add(Me.lblInd1_10)
		Me.tpaUses.Controls.Add(Me.lblAgr1_10)
		Me.tpaUses.Controls.Add(Me.lblLan1_7)
		Me.tpaUses.Controls.Add(Me.lblInd1_7)
		Me.tpaUses.Controls.Add(Me.lblAgr1_7)
		Me.tpaUses.Controls.Add(Me.lblLan1_3)
		Me.tpaUses.Controls.Add(Me.lblInd1_3)
		Me.tpaUses.Controls.Add(Me.lblAgr1_3)
		Me.tpaUses.Controls.Add(Me.lblLan1_12)
		Me.tpaUses.Controls.Add(Me.lblInd1_12)
		Me.tpaUses.Controls.Add(Me.lblAgr1_12)
		Me.tpaUses.Controls.Add(Me.lblLan1_9)
		Me.tpaUses.Controls.Add(Me.lblInd1_9)
		Me.tpaUses.Controls.Add(Me.lblAgr1_9)
		Me.tpaUses.Controls.Add(Me.lblLan1_6)
		Me.tpaUses.Controls.Add(Me.lblInd1_6)
		Me.tpaUses.Controls.Add(Me.lblAgr1_6)
		Me.tpaUses.Controls.Add(Me.lblLan1_2)
		Me.tpaUses.Controls.Add(Me.lblInd1_2)
		Me.tpaUses.Controls.Add(Me.lblAgr1_2)
		Me.tpaUses.Controls.Add(Me.lblLan1_11)
		Me.tpaUses.Controls.Add(Me.lblInd1_11)
		Me.tpaUses.Controls.Add(Me.lblAgr1_11)
		Me.tpaUses.Controls.Add(Me.lblLan1_8)
		Me.tpaUses.Controls.Add(Me.lblInd1_8)
		Me.tpaUses.Controls.Add(Me.lblAgr1_8)
		Me.tpaUses.Controls.Add(Me.lblLan1_4)
		Me.tpaUses.Controls.Add(Me.lblInd1_4)
		Me.tpaUses.Controls.Add(Me.lblAgr1_4)
		Me.tpaUses.Controls.Add(Me.lblLan1_5)
		Me.tpaUses.Controls.Add(Me.lblInd1_5)
		Me.tpaUses.Controls.Add(Me.lblAgr1_5)
		Me.tpaUses.Controls.Add(Me.lblLan1_1)
		Me.tpaUses.Controls.Add(Me.lblInd1_1)
		Me.tpaUses.Controls.Add(Me.lblAgr1_1)
		Me.tpaUses.Controls.Add(Me.Label135)
		Me.tpaUses.Controls.Add(Me.Label134)
		Me.tpaUses.Controls.Add(Me.Label133)
		Me.tpaUses.Controls.Add(Me.Label31)
		Me.tpaUses.Controls.Add(Me.Label33)
		Me.tpaUses.Controls.Add(Me.Label35)
		Me.tpaUses.Controls.Add(Me.Label36)
		Me.tpaUses.Controls.Add(Me.Label60)
		Me.tpaUses.Controls.Add(Me.Label61)
		Me.tpaUses.Controls.Add(Me.Label79)
		Me.tpaUses.Controls.Add(Me.Label80)
		Me.tpaUses.Controls.Add(Me.Label81)
		Me.tpaUses.Controls.Add(Me.Label82)
		Me.tpaUses.Controls.Add(Me.Label83)
		Me.tpaUses.Controls.Add(Me.Label84)
		Me.tpaUses.Controls.Add(Me.Label85)
		Me.tpaUses.Location = New System.Drawing.Point(4, 22)
		Me.tpaUses.Name = "tpaUses"
		Me.tpaUses.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaUses.Size = New System.Drawing.Size(564, 454)
		Me.tpaUses.TabIndex = 0
		Me.tpaUses.Text = "Uses S"
		Me.tpaUses.UseVisualStyleBackColor = True
		'
		'lblLan1_13
		'
		Me.lblLan1_13.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblLan1_13.DSSElementName = Nothing
		Me.lblLan1_13.DSSLocation = 0
		Me.lblLan1_13.DSSOffset = 0R
		Me.lblLan1_13.Location = New System.Drawing.Point(166, 326)
		Me.lblLan1_13.Name = "lblLan1_13"
		Me.lblLan1_13.Size = New System.Drawing.Size(34, 20)
		Me.lblLan1_13.TabIndex = 63
		Me.lblLan1_13.Text = "-"
		Me.lblLan1_13.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd1_13
		'
		Me.lblInd1_13.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd1_13.DSSElementName = Nothing
		Me.lblInd1_13.DSSLocation = 0
		Me.lblInd1_13.DSSOffset = 0R
		Me.lblInd1_13.Location = New System.Drawing.Point(126, 326)
		Me.lblInd1_13.Name = "lblInd1_13"
		Me.lblInd1_13.Size = New System.Drawing.Size(34, 20)
		Me.lblInd1_13.TabIndex = 63
		Me.lblInd1_13.Text = "-"
		Me.lblInd1_13.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr1_13
		'
		Me.lblAgr1_13.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblAgr1_13.DSSElementName = Nothing
		Me.lblAgr1_13.DSSLocation = 0
		Me.lblAgr1_13.DSSOffset = 0R
		Me.lblAgr1_13.Location = New System.Drawing.Point(93, 326)
		Me.lblAgr1_13.Name = "lblAgr1_13"
		Me.lblAgr1_13.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr1_13.TabIndex = 63
		Me.lblAgr1_13.Text = "-"
		Me.lblAgr1_13.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan1_10
		'
		Me.lblLan1_10.AccessibleDescription = ""
		Me.lblLan1_10.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblLan1_10.DSSElementName = Nothing
		Me.lblLan1_10.DSSLocation = 0
		Me.lblLan1_10.DSSOffset = 0R
		Me.lblLan1_10.Location = New System.Drawing.Point(166, 257)
		Me.lblLan1_10.Name = "lblLan1_10"
		Me.lblLan1_10.Size = New System.Drawing.Size(34, 20)
		Me.lblLan1_10.TabIndex = 63
		Me.lblLan1_10.Text = "-"
		Me.lblLan1_10.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd1_10
		'
		Me.lblInd1_10.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd1_10.DSSElementName = Nothing
		Me.lblInd1_10.DSSLocation = 0
		Me.lblInd1_10.DSSOffset = 0R
		Me.lblInd1_10.Location = New System.Drawing.Point(126, 257)
		Me.lblInd1_10.Name = "lblInd1_10"
		Me.lblInd1_10.Size = New System.Drawing.Size(34, 20)
		Me.lblInd1_10.TabIndex = 63
		Me.lblInd1_10.Text = "-"
		Me.lblInd1_10.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr1_10
		'
		Me.lblAgr1_10.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblAgr1_10.DSSElementName = Nothing
		Me.lblAgr1_10.DSSLocation = 0
		Me.lblAgr1_10.DSSOffset = 0R
		Me.lblAgr1_10.Location = New System.Drawing.Point(93, 257)
		Me.lblAgr1_10.Name = "lblAgr1_10"
		Me.lblAgr1_10.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr1_10.TabIndex = 63
		Me.lblAgr1_10.Text = "-"
		Me.lblAgr1_10.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan1_7
		'
		Me.lblLan1_7.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblLan1_7.DSSElementName = Nothing
		Me.lblLan1_7.DSSLocation = 0
		Me.lblLan1_7.DSSOffset = 0R
		Me.lblLan1_7.Location = New System.Drawing.Point(166, 188)
		Me.lblLan1_7.Name = "lblLan1_7"
		Me.lblLan1_7.Size = New System.Drawing.Size(34, 20)
		Me.lblLan1_7.TabIndex = 63
		Me.lblLan1_7.Text = "-"
		Me.lblLan1_7.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd1_7
		'
		Me.lblInd1_7.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd1_7.DSSElementName = Nothing
		Me.lblInd1_7.DSSLocation = 0
		Me.lblInd1_7.DSSOffset = 0R
		Me.lblInd1_7.Location = New System.Drawing.Point(126, 188)
		Me.lblInd1_7.Name = "lblInd1_7"
		Me.lblInd1_7.Size = New System.Drawing.Size(34, 20)
		Me.lblInd1_7.TabIndex = 63
		Me.lblInd1_7.Text = "-"
		Me.lblInd1_7.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr1_7
		'
		Me.lblAgr1_7.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblAgr1_7.DSSElementName = Nothing
		Me.lblAgr1_7.DSSLocation = 0
		Me.lblAgr1_7.DSSOffset = 0R
		Me.lblAgr1_7.Location = New System.Drawing.Point(93, 188)
		Me.lblAgr1_7.Name = "lblAgr1_7"
		Me.lblAgr1_7.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr1_7.TabIndex = 63
		Me.lblAgr1_7.Text = "-"
		Me.lblAgr1_7.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan1_3
		'
		Me.lblLan1_3.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblLan1_3.DSSElementName = Nothing
		Me.lblLan1_3.DSSLocation = 0
		Me.lblLan1_3.DSSOffset = 0R
		Me.lblLan1_3.Location = New System.Drawing.Point(166, 96)
		Me.lblLan1_3.Name = "lblLan1_3"
		Me.lblLan1_3.Size = New System.Drawing.Size(34, 20)
		Me.lblLan1_3.TabIndex = 63
		Me.lblLan1_3.Text = "-"
		Me.lblLan1_3.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd1_3
		'
		Me.lblInd1_3.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd1_3.DSSElementName = Nothing
		Me.lblInd1_3.DSSLocation = 0
		Me.lblInd1_3.DSSOffset = 0R
		Me.lblInd1_3.Location = New System.Drawing.Point(126, 96)
		Me.lblInd1_3.Name = "lblInd1_3"
		Me.lblInd1_3.Size = New System.Drawing.Size(34, 20)
		Me.lblInd1_3.TabIndex = 63
		Me.lblInd1_3.Text = "-"
		Me.lblInd1_3.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr1_3
		'
		Me.lblAgr1_3.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblAgr1_3.DSSElementName = Nothing
		Me.lblAgr1_3.DSSLocation = 0
		Me.lblAgr1_3.DSSOffset = 0R
		Me.lblAgr1_3.Location = New System.Drawing.Point(93, 96)
		Me.lblAgr1_3.Name = "lblAgr1_3"
		Me.lblAgr1_3.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr1_3.TabIndex = 63
		Me.lblAgr1_3.Text = "-"
		Me.lblAgr1_3.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan1_12
		'
		Me.lblLan1_12.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblLan1_12.DSSElementName = Nothing
		Me.lblLan1_12.DSSLocation = 0
		Me.lblLan1_12.DSSOffset = 0R
		Me.lblLan1_12.Location = New System.Drawing.Point(166, 303)
		Me.lblLan1_12.Name = "lblLan1_12"
		Me.lblLan1_12.Size = New System.Drawing.Size(34, 20)
		Me.lblLan1_12.TabIndex = 63
		Me.lblLan1_12.Text = "-"
		Me.lblLan1_12.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd1_12
		'
		Me.lblInd1_12.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd1_12.DSSElementName = Nothing
		Me.lblInd1_12.DSSLocation = 0
		Me.lblInd1_12.DSSOffset = 0R
		Me.lblInd1_12.Location = New System.Drawing.Point(126, 303)
		Me.lblInd1_12.Name = "lblInd1_12"
		Me.lblInd1_12.Size = New System.Drawing.Size(34, 20)
		Me.lblInd1_12.TabIndex = 63
		Me.lblInd1_12.Text = "-"
		Me.lblInd1_12.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr1_12
		'
		Me.lblAgr1_12.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblAgr1_12.DSSElementName = Nothing
		Me.lblAgr1_12.DSSLocation = 0
		Me.lblAgr1_12.DSSOffset = 0R
		Me.lblAgr1_12.Location = New System.Drawing.Point(93, 303)
		Me.lblAgr1_12.Name = "lblAgr1_12"
		Me.lblAgr1_12.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr1_12.TabIndex = 63
		Me.lblAgr1_12.Text = "-"
		Me.lblAgr1_12.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan1_9
		'
		Me.lblLan1_9.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblLan1_9.DSSElementName = Nothing
		Me.lblLan1_9.DSSLocation = 0
		Me.lblLan1_9.DSSOffset = 0R
		Me.lblLan1_9.Location = New System.Drawing.Point(166, 234)
		Me.lblLan1_9.Name = "lblLan1_9"
		Me.lblLan1_9.Size = New System.Drawing.Size(34, 20)
		Me.lblLan1_9.TabIndex = 63
		Me.lblLan1_9.Text = "-"
		Me.lblLan1_9.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd1_9
		'
		Me.lblInd1_9.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd1_9.DSSElementName = Nothing
		Me.lblInd1_9.DSSLocation = 0
		Me.lblInd1_9.DSSOffset = 0R
		Me.lblInd1_9.Location = New System.Drawing.Point(126, 234)
		Me.lblInd1_9.Name = "lblInd1_9"
		Me.lblInd1_9.Size = New System.Drawing.Size(34, 20)
		Me.lblInd1_9.TabIndex = 63
		Me.lblInd1_9.Text = "-"
		Me.lblInd1_9.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr1_9
		'
		Me.lblAgr1_9.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblAgr1_9.DSSElementName = Nothing
		Me.lblAgr1_9.DSSLocation = 0
		Me.lblAgr1_9.DSSOffset = 0R
		Me.lblAgr1_9.Location = New System.Drawing.Point(93, 234)
		Me.lblAgr1_9.Name = "lblAgr1_9"
		Me.lblAgr1_9.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr1_9.TabIndex = 63
		Me.lblAgr1_9.Text = "-"
		Me.lblAgr1_9.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan1_6
		'
		Me.lblLan1_6.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblLan1_6.DSSElementName = Nothing
		Me.lblLan1_6.DSSLocation = 0
		Me.lblLan1_6.DSSOffset = 0R
		Me.lblLan1_6.Location = New System.Drawing.Point(166, 165)
		Me.lblLan1_6.Name = "lblLan1_6"
		Me.lblLan1_6.Size = New System.Drawing.Size(34, 20)
		Me.lblLan1_6.TabIndex = 63
		Me.lblLan1_6.Text = "-"
		Me.lblLan1_6.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd1_6
		'
		Me.lblInd1_6.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd1_6.DSSElementName = Nothing
		Me.lblInd1_6.DSSLocation = 0
		Me.lblInd1_6.DSSOffset = 0R
		Me.lblInd1_6.Location = New System.Drawing.Point(126, 165)
		Me.lblInd1_6.Name = "lblInd1_6"
		Me.lblInd1_6.Size = New System.Drawing.Size(34, 20)
		Me.lblInd1_6.TabIndex = 63
		Me.lblInd1_6.Text = "-"
		Me.lblInd1_6.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr1_6
		'
		Me.lblAgr1_6.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblAgr1_6.DSSElementName = Nothing
		Me.lblAgr1_6.DSSLocation = 0
		Me.lblAgr1_6.DSSOffset = 0R
		Me.lblAgr1_6.Location = New System.Drawing.Point(93, 165)
		Me.lblAgr1_6.Name = "lblAgr1_6"
		Me.lblAgr1_6.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr1_6.TabIndex = 63
		Me.lblAgr1_6.Text = "-"
		Me.lblAgr1_6.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan1_2
		'
		Me.lblLan1_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblLan1_2.DSSElementName = Nothing
		Me.lblLan1_2.DSSLocation = 0
		Me.lblLan1_2.DSSOffset = 0R
		Me.lblLan1_2.Location = New System.Drawing.Point(166, 73)
		Me.lblLan1_2.Name = "lblLan1_2"
		Me.lblLan1_2.Size = New System.Drawing.Size(34, 20)
		Me.lblLan1_2.TabIndex = 63
		Me.lblLan1_2.Text = "-"
		Me.lblLan1_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd1_2
		'
		Me.lblInd1_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd1_2.DSSElementName = Nothing
		Me.lblInd1_2.DSSLocation = 0
		Me.lblInd1_2.DSSOffset = 0R
		Me.lblInd1_2.Location = New System.Drawing.Point(126, 73)
		Me.lblInd1_2.Name = "lblInd1_2"
		Me.lblInd1_2.Size = New System.Drawing.Size(34, 20)
		Me.lblInd1_2.TabIndex = 63
		Me.lblInd1_2.Text = "-"
		Me.lblInd1_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr1_2
		'
		Me.lblAgr1_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblAgr1_2.DSSElementName = Nothing
		Me.lblAgr1_2.DSSLocation = 0
		Me.lblAgr1_2.DSSOffset = 0R
		Me.lblAgr1_2.Location = New System.Drawing.Point(93, 73)
		Me.lblAgr1_2.Name = "lblAgr1_2"
		Me.lblAgr1_2.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr1_2.TabIndex = 63
		Me.lblAgr1_2.Text = "-"
		Me.lblAgr1_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan1_11
		'
		Me.lblLan1_11.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblLan1_11.DSSElementName = Nothing
		Me.lblLan1_11.DSSLocation = 0
		Me.lblLan1_11.DSSOffset = 0R
		Me.lblLan1_11.Location = New System.Drawing.Point(166, 280)
		Me.lblLan1_11.Name = "lblLan1_11"
		Me.lblLan1_11.Size = New System.Drawing.Size(34, 20)
		Me.lblLan1_11.TabIndex = 63
		Me.lblLan1_11.Text = "-"
		Me.lblLan1_11.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd1_11
		'
		Me.lblInd1_11.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd1_11.DSSElementName = Nothing
		Me.lblInd1_11.DSSLocation = 0
		Me.lblInd1_11.DSSOffset = 0R
		Me.lblInd1_11.Location = New System.Drawing.Point(126, 280)
		Me.lblInd1_11.Name = "lblInd1_11"
		Me.lblInd1_11.Size = New System.Drawing.Size(34, 20)
		Me.lblInd1_11.TabIndex = 63
		Me.lblInd1_11.Text = "-"
		Me.lblInd1_11.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr1_11
		'
		Me.lblAgr1_11.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblAgr1_11.DSSElementName = Nothing
		Me.lblAgr1_11.DSSLocation = 0
		Me.lblAgr1_11.DSSOffset = 0R
		Me.lblAgr1_11.Location = New System.Drawing.Point(93, 280)
		Me.lblAgr1_11.Name = "lblAgr1_11"
		Me.lblAgr1_11.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr1_11.TabIndex = 63
		Me.lblAgr1_11.Text = "-"
		Me.lblAgr1_11.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan1_8
		'
		Me.lblLan1_8.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblLan1_8.DSSElementName = Nothing
		Me.lblLan1_8.DSSLocation = 0
		Me.lblLan1_8.DSSOffset = 0R
		Me.lblLan1_8.Location = New System.Drawing.Point(166, 211)
		Me.lblLan1_8.Name = "lblLan1_8"
		Me.lblLan1_8.Size = New System.Drawing.Size(34, 20)
		Me.lblLan1_8.TabIndex = 63
		Me.lblLan1_8.Text = "-"
		Me.lblLan1_8.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd1_8
		'
		Me.lblInd1_8.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd1_8.DSSElementName = Nothing
		Me.lblInd1_8.DSSLocation = 0
		Me.lblInd1_8.DSSOffset = 0R
		Me.lblInd1_8.Location = New System.Drawing.Point(126, 211)
		Me.lblInd1_8.Name = "lblInd1_8"
		Me.lblInd1_8.Size = New System.Drawing.Size(34, 20)
		Me.lblInd1_8.TabIndex = 63
		Me.lblInd1_8.Text = "-"
		Me.lblInd1_8.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr1_8
		'
		Me.lblAgr1_8.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblAgr1_8.DSSElementName = Nothing
		Me.lblAgr1_8.DSSLocation = 0
		Me.lblAgr1_8.DSSOffset = 0R
		Me.lblAgr1_8.Location = New System.Drawing.Point(93, 211)
		Me.lblAgr1_8.Name = "lblAgr1_8"
		Me.lblAgr1_8.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr1_8.TabIndex = 63
		Me.lblAgr1_8.Text = "-"
		Me.lblAgr1_8.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan1_4
		'
		Me.lblLan1_4.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblLan1_4.DSSElementName = Nothing
		Me.lblLan1_4.DSSLocation = 0
		Me.lblLan1_4.DSSOffset = 0R
		Me.lblLan1_4.Location = New System.Drawing.Point(166, 119)
		Me.lblLan1_4.Name = "lblLan1_4"
		Me.lblLan1_4.Size = New System.Drawing.Size(34, 20)
		Me.lblLan1_4.TabIndex = 63
		Me.lblLan1_4.Text = "-"
		Me.lblLan1_4.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd1_4
		'
		Me.lblInd1_4.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd1_4.DSSElementName = Nothing
		Me.lblInd1_4.DSSLocation = 0
		Me.lblInd1_4.DSSOffset = 0R
		Me.lblInd1_4.Location = New System.Drawing.Point(126, 119)
		Me.lblInd1_4.Name = "lblInd1_4"
		Me.lblInd1_4.Size = New System.Drawing.Size(34, 20)
		Me.lblInd1_4.TabIndex = 63
		Me.lblInd1_4.Text = "-"
		Me.lblInd1_4.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr1_4
		'
		Me.lblAgr1_4.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblAgr1_4.DSSElementName = Nothing
		Me.lblAgr1_4.DSSLocation = 0
		Me.lblAgr1_4.DSSOffset = 0R
		Me.lblAgr1_4.Location = New System.Drawing.Point(93, 119)
		Me.lblAgr1_4.Name = "lblAgr1_4"
		Me.lblAgr1_4.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr1_4.TabIndex = 63
		Me.lblAgr1_4.Text = "-"
		Me.lblAgr1_4.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan1_5
		'
		Me.lblLan1_5.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblLan1_5.DSSElementName = Nothing
		Me.lblLan1_5.DSSLocation = 0
		Me.lblLan1_5.DSSOffset = 0R
		Me.lblLan1_5.Location = New System.Drawing.Point(166, 142)
		Me.lblLan1_5.Name = "lblLan1_5"
		Me.lblLan1_5.Size = New System.Drawing.Size(34, 20)
		Me.lblLan1_5.TabIndex = 63
		Me.lblLan1_5.Text = "-"
		Me.lblLan1_5.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd1_5
		'
		Me.lblInd1_5.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd1_5.DSSElementName = Nothing
		Me.lblInd1_5.DSSLocation = 0
		Me.lblInd1_5.DSSOffset = 0R
		Me.lblInd1_5.Location = New System.Drawing.Point(126, 142)
		Me.lblInd1_5.Name = "lblInd1_5"
		Me.lblInd1_5.Size = New System.Drawing.Size(34, 20)
		Me.lblInd1_5.TabIndex = 63
		Me.lblInd1_5.Text = "-"
		Me.lblInd1_5.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr1_5
		'
		Me.lblAgr1_5.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblAgr1_5.DSSElementName = Nothing
		Me.lblAgr1_5.DSSLocation = 0
		Me.lblAgr1_5.DSSOffset = 0R
		Me.lblAgr1_5.Location = New System.Drawing.Point(93, 142)
		Me.lblAgr1_5.Name = "lblAgr1_5"
		Me.lblAgr1_5.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr1_5.TabIndex = 63
		Me.lblAgr1_5.Text = "-"
		Me.lblAgr1_5.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblLan1_1
		'
		Me.lblLan1_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblLan1_1.DSSElementName = Nothing
		Me.lblLan1_1.DSSLocation = 0
		Me.lblLan1_1.DSSOffset = 0R
		Me.lblLan1_1.Location = New System.Drawing.Point(166, 50)
		Me.lblLan1_1.Name = "lblLan1_1"
		Me.lblLan1_1.Size = New System.Drawing.Size(34, 20)
		Me.lblLan1_1.TabIndex = 63
		Me.lblLan1_1.Text = "-"
		Me.lblLan1_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblInd1_1
		'
		Me.lblInd1_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblInd1_1.DSSElementName = Nothing
		Me.lblInd1_1.DSSLocation = 0
		Me.lblInd1_1.DSSOffset = 0R
		Me.lblInd1_1.Location = New System.Drawing.Point(126, 50)
		Me.lblInd1_1.Name = "lblInd1_1"
		Me.lblInd1_1.Size = New System.Drawing.Size(34, 20)
		Me.lblInd1_1.TabIndex = 63
		Me.lblInd1_1.Text = "-"
		Me.lblInd1_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblAgr1_1
		'
		Me.lblAgr1_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblAgr1_1.DSSElementName = Nothing
		Me.lblAgr1_1.DSSLocation = 0
		Me.lblAgr1_1.DSSOffset = 0R
		Me.lblAgr1_1.Location = New System.Drawing.Point(93, 50)
		Me.lblAgr1_1.Name = "lblAgr1_1"
		Me.lblAgr1_1.Size = New System.Drawing.Size(34, 20)
		Me.lblAgr1_1.TabIndex = 63
		Me.lblAgr1_1.Text = "-"
		Me.lblAgr1_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Label135
		'
		Me.Label135.Location = New System.Drawing.Point(166, 33)
		Me.Label135.Name = "Label135"
		Me.Label135.Size = New System.Drawing.Size(34, 20)
		Me.Label135.TabIndex = 62
		Me.Label135.Text = "lan"
		Me.Label135.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label134
		'
		Me.Label134.Location = New System.Drawing.Point(126, 33)
		Me.Label134.Name = "Label134"
		Me.Label134.Size = New System.Drawing.Size(34, 20)
		Me.Label134.TabIndex = 62
		Me.Label134.Text = "ind"
		Me.Label134.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label133
		'
		Me.Label133.Location = New System.Drawing.Point(93, 33)
		Me.Label133.Name = "Label133"
		Me.Label133.Size = New System.Drawing.Size(34, 20)
		Me.Label133.TabIndex = 62
		Me.Label133.Text = "agr"
		Me.Label133.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label31
		'
		Me.Label31.Location = New System.Drawing.Point(9, 326)
		Me.Label31.Name = "Label31"
		Me.Label31.Size = New System.Drawing.Size(75, 20)
		Me.Label31.TabIndex = 49
		Me.Label31.Text = "Tabouk"
		'
		'Label33
		'
		Me.Label33.Location = New System.Drawing.Point(9, 188)
		Me.Label33.Name = "Label33"
		Me.Label33.Size = New System.Drawing.Size(75, 20)
		Me.Label33.TabIndex = 50
		Me.Label33.Text = "Jizan"
		'
		'Label35
		'
		Me.Label35.Location = New System.Drawing.Point(9, 303)
		Me.Label35.Name = "Label35"
		Me.Label35.Size = New System.Drawing.Size(75, 20)
		Me.Label35.TabIndex = 51
		Me.Label35.Text = "Riyadh"
		'
		'Label36
		'
		Me.Label36.Location = New System.Drawing.Point(9, 165)
		Me.Label36.Name = "Label36"
		Me.Label36.Size = New System.Drawing.Size(75, 20)
		Me.Label36.TabIndex = 52
		Me.Label36.Text = "Hail"
		'
		'Label60
		'
		Me.Label60.Location = New System.Drawing.Point(9, 280)
		Me.Label60.Name = "Label60"
		Me.Label60.Size = New System.Drawing.Size(75, 20)
		Me.Label60.TabIndex = 53
		Me.Label60.Text = "North Border"
		'
		'Label61
		'
		Me.Label61.Location = New System.Drawing.Point(9, 257)
		Me.Label61.Name = "Label61"
		Me.Label61.Size = New System.Drawing.Size(75, 20)
		Me.Label61.TabIndex = 61
		Me.Label61.Text = "Najran"
		'
		'Label79
		'
		Me.Label79.Location = New System.Drawing.Point(9, 96)
		Me.Label79.Name = "Label79"
		Me.Label79.Size = New System.Drawing.Size(75, 20)
		Me.Label79.TabIndex = 54
		Me.Label79.Text = "Al - Jouf"
		'
		'Label80
		'
		Me.Label80.Location = New System.Drawing.Point(9, 234)
		Me.Label80.Name = "Label80"
		Me.Label80.Size = New System.Drawing.Size(75, 20)
		Me.Label80.TabIndex = 55
		Me.Label80.Text = "Mecca"
		'
		'Label81
		'
		Me.Label81.Location = New System.Drawing.Point(9, 142)
		Me.Label81.Name = "Label81"
		Me.Label81.Size = New System.Drawing.Size(75, 20)
		Me.Label81.TabIndex = 56
		Me.Label81.Text = "Eastern Area"
		'
		'Label82
		'
		Me.Label82.Location = New System.Drawing.Point(9, 73)
		Me.Label82.Name = "Label82"
		Me.Label82.Size = New System.Drawing.Size(75, 20)
		Me.Label82.TabIndex = 57
		Me.Label82.Text = "Al - Gassem"
		'
		'Label83
		'
		Me.Label83.Location = New System.Drawing.Point(9, 211)
		Me.Label83.Name = "Label83"
		Me.Label83.Size = New System.Drawing.Size(75, 20)
		Me.Label83.TabIndex = 58
		Me.Label83.Text = "Madina"
		'
		'Label84
		'
		Me.Label84.Location = New System.Drawing.Point(9, 119)
		Me.Label84.Name = "Label84"
		Me.Label84.Size = New System.Drawing.Size(75, 20)
		Me.Label84.TabIndex = 59
		Me.Label84.Text = "Aseer"
		'
		'Label85
		'
		Me.Label85.Location = New System.Drawing.Point(9, 50)
		Me.Label85.Name = "Label85"
		Me.Label85.Size = New System.Drawing.Size(75, 20)
		Me.Label85.TabIndex = 60
		Me.Label85.Text = "Al - Baha"
		'
		'tpaImpacts
		'
		Me.tpaImpacts.Controls.Add(Me.Label98)
		Me.tpaImpacts.Controls.Add(Me.Label99)
		Me.tpaImpacts.Controls.Add(Me.DssLabel40)
		Me.tpaImpacts.Controls.Add(Me.DssLabel41)
		Me.tpaImpacts.Controls.Add(Me.DssLabel42)
		Me.tpaImpacts.Controls.Add(Me.DssLabel43)
		Me.tpaImpacts.Controls.Add(Me.DssLabel44)
		Me.tpaImpacts.Controls.Add(Me.DssLabel45)
		Me.tpaImpacts.Controls.Add(Me.DssLabel46)
		Me.tpaImpacts.Controls.Add(Me.DssLabel47)
		Me.tpaImpacts.Controls.Add(Me.DssLabel48)
		Me.tpaImpacts.Controls.Add(Me.DssLabel49)
		Me.tpaImpacts.Controls.Add(Me.DssLabel50)
		Me.tpaImpacts.Controls.Add(Me.DssLabel51)
		Me.tpaImpacts.Controls.Add(Me.DssLabel52)
		Me.tpaImpacts.Controls.Add(Me.DssLabel53)
		Me.tpaImpacts.Controls.Add(Me.DssLabel54)
		Me.tpaImpacts.Controls.Add(Me.DssLabel55)
		Me.tpaImpacts.Controls.Add(Me.DssLabel56)
		Me.tpaImpacts.Controls.Add(Me.DssLabel57)
		Me.tpaImpacts.Controls.Add(Me.DssLabel58)
		Me.tpaImpacts.Controls.Add(Me.DssLabel59)
		Me.tpaImpacts.Controls.Add(Me.DssLabel60)
		Me.tpaImpacts.Controls.Add(Me.DssLabel61)
		Me.tpaImpacts.Controls.Add(Me.DssLabel62)
		Me.tpaImpacts.Controls.Add(Me.DssLabel63)
		Me.tpaImpacts.Controls.Add(Me.DssLabel64)
		Me.tpaImpacts.Controls.Add(Me.DssLabel65)
		Me.tpaImpacts.Controls.Add(Me.DssLabel66)
		Me.tpaImpacts.Controls.Add(Me.DssLabel67)
		Me.tpaImpacts.Controls.Add(Me.DssLabel68)
		Me.tpaImpacts.Controls.Add(Me.DssLabel69)
		Me.tpaImpacts.Controls.Add(Me.DssLabel70)
		Me.tpaImpacts.Controls.Add(Me.DssLabel71)
		Me.tpaImpacts.Controls.Add(Me.DssLabel72)
		Me.tpaImpacts.Controls.Add(Me.DssLabel73)
		Me.tpaImpacts.Controls.Add(Me.DssLabel74)
		Me.tpaImpacts.Controls.Add(Me.DssLabel75)
		Me.tpaImpacts.Controls.Add(Me.DssLabel76)
		Me.tpaImpacts.Controls.Add(Me.DssLabel77)
		Me.tpaImpacts.Controls.Add(Me.DssLabel78)
		Me.tpaImpacts.Controls.Add(Me.Label95)
		Me.tpaImpacts.Controls.Add(Me.Label96)
		Me.tpaImpacts.Controls.Add(Me.Label97)
		Me.tpaImpacts.Controls.Add(Me.lblEnv13_1)
		Me.tpaImpacts.Controls.Add(Me.lblSoc13_1)
		Me.tpaImpacts.Controls.Add(Me.lblEco13_1)
		Me.tpaImpacts.Controls.Add(Me.lblEnv10_1)
		Me.tpaImpacts.Controls.Add(Me.lblSoc10_1)
		Me.tpaImpacts.Controls.Add(Me.lblEco10_1)
		Me.tpaImpacts.Controls.Add(Me.lblEnv1_7)
		Me.tpaImpacts.Controls.Add(Me.lblSoc1_7)
		Me.tpaImpacts.Controls.Add(Me.lblEco1_7)
		Me.tpaImpacts.Controls.Add(Me.lblEnv1_3)
		Me.tpaImpacts.Controls.Add(Me.lblSoc1_3)
		Me.tpaImpacts.Controls.Add(Me.lblEco1_3)
		Me.tpaImpacts.Controls.Add(Me.lblEnv1_12)
		Me.tpaImpacts.Controls.Add(Me.lblSoc1_12)
		Me.tpaImpacts.Controls.Add(Me.lblEco1_12)
		Me.tpaImpacts.Controls.Add(Me.lblEnv1_9)
		Me.tpaImpacts.Controls.Add(Me.lblSoc1_9)
		Me.tpaImpacts.Controls.Add(Me.lblEco1_9)
		Me.tpaImpacts.Controls.Add(Me.lblEnv1_6)
		Me.tpaImpacts.Controls.Add(Me.lblSoc1_6)
		Me.tpaImpacts.Controls.Add(Me.lblEco1_6)
		Me.tpaImpacts.Controls.Add(Me.lblEnv1_2)
		Me.tpaImpacts.Controls.Add(Me.lblSoc1_2)
		Me.tpaImpacts.Controls.Add(Me.lblEco1_2)
		Me.tpaImpacts.Controls.Add(Me.lblEnv1_11)
		Me.tpaImpacts.Controls.Add(Me.lblSoc1_11)
		Me.tpaImpacts.Controls.Add(Me.lblEco1_11)
		Me.tpaImpacts.Controls.Add(Me.lblEnv1_8)
		Me.tpaImpacts.Controls.Add(Me.lblSoc1_8)
		Me.tpaImpacts.Controls.Add(Me.lblEco1_8)
		Me.tpaImpacts.Controls.Add(Me.lblEnv1_4)
		Me.tpaImpacts.Controls.Add(Me.lblSoc1_4)
		Me.tpaImpacts.Controls.Add(Me.lblEco1_4)
		Me.tpaImpacts.Controls.Add(Me.lblEnv1_5)
		Me.tpaImpacts.Controls.Add(Me.lblSoc1_5)
		Me.tpaImpacts.Controls.Add(Me.lblEco1_5)
		Me.tpaImpacts.Controls.Add(Me.lblEnv1_1)
		Me.tpaImpacts.Controls.Add(Me.lblSoc1_1)
		Me.tpaImpacts.Controls.Add(Me.lblEco1_1)
		Me.tpaImpacts.Controls.Add(Me.Label178)
		Me.tpaImpacts.Controls.Add(Me.Label179)
		Me.tpaImpacts.Controls.Add(Me.Label180)
		Me.tpaImpacts.Controls.Add(Me.Label103)
		Me.tpaImpacts.Controls.Add(Me.Label104)
		Me.tpaImpacts.Controls.Add(Me.Label105)
		Me.tpaImpacts.Controls.Add(Me.Label106)
		Me.tpaImpacts.Controls.Add(Me.Label107)
		Me.tpaImpacts.Controls.Add(Me.Label108)
		Me.tpaImpacts.Controls.Add(Me.Label109)
		Me.tpaImpacts.Controls.Add(Me.Label110)
		Me.tpaImpacts.Controls.Add(Me.Label111)
		Me.tpaImpacts.Controls.Add(Me.Label112)
		Me.tpaImpacts.Controls.Add(Me.Label113)
		Me.tpaImpacts.Controls.Add(Me.Label114)
		Me.tpaImpacts.Controls.Add(Me.Label115)
		Me.tpaImpacts.Location = New System.Drawing.Point(4, 22)
		Me.tpaImpacts.Name = "tpaImpacts"
		Me.tpaImpacts.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaImpacts.Size = New System.Drawing.Size(564, 454)
		Me.tpaImpacts.TabIndex = 2
		Me.tpaImpacts.Text = "Impacts S"
		Me.tpaImpacts.UseVisualStyleBackColor = True
		'
		'lblEnv13_1
		'
		Me.lblEnv13_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEnv13_1.DSSElementName = Nothing
		Me.lblEnv13_1.DSSLocation = 0
		Me.lblEnv13_1.DSSOffset = 0R
		Me.lblEnv13_1.Location = New System.Drawing.Point(165, 327)
		Me.lblEnv13_1.Name = "lblEnv13_1"
		Me.lblEnv13_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv13_1.TabIndex = 108
		Me.lblEnv13_1.Text = "-"
		Me.lblEnv13_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc13_1
		'
		Me.lblSoc13_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblSoc13_1.DSSElementName = Nothing
		Me.lblSoc13_1.DSSLocation = 0
		Me.lblSoc13_1.DSSOffset = 0R
		Me.lblSoc13_1.Location = New System.Drawing.Point(125, 327)
		Me.lblSoc13_1.Name = "lblSoc13_1"
		Me.lblSoc13_1.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc13_1.TabIndex = 129
		Me.lblSoc13_1.Text = "-"
		Me.lblSoc13_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco13_1
		'
		Me.lblEco13_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco13_1.DSSElementName = Nothing
		Me.lblEco13_1.DSSLocation = 0
		Me.lblEco13_1.DSSOffset = 0R
		Me.lblEco13_1.Location = New System.Drawing.Point(92, 327)
		Me.lblEco13_1.Name = "lblEco13_1"
		Me.lblEco13_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEco13_1.TabIndex = 130
		Me.lblEco13_1.Text = "-"
		Me.lblEco13_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv10_1
		'
		Me.lblEnv10_1.AccessibleDescription = ""
		Me.lblEnv10_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEnv10_1.DSSElementName = Nothing
		Me.lblEnv10_1.DSSLocation = 0
		Me.lblEnv10_1.DSSOffset = 0R
		Me.lblEnv10_1.Location = New System.Drawing.Point(165, 258)
		Me.lblEnv10_1.Name = "lblEnv10_1"
		Me.lblEnv10_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv10_1.TabIndex = 131
		Me.lblEnv10_1.Text = "-"
		Me.lblEnv10_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc10_1
		'
		Me.lblSoc10_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblSoc10_1.DSSElementName = Nothing
		Me.lblSoc10_1.DSSLocation = 0
		Me.lblSoc10_1.DSSOffset = 0R
		Me.lblSoc10_1.Location = New System.Drawing.Point(125, 258)
		Me.lblSoc10_1.Name = "lblSoc10_1"
		Me.lblSoc10_1.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc10_1.TabIndex = 132
		Me.lblSoc10_1.Text = "-"
		Me.lblSoc10_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco10_1
		'
		Me.lblEco10_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco10_1.DSSElementName = Nothing
		Me.lblEco10_1.DSSLocation = 0
		Me.lblEco10_1.DSSOffset = 0R
		Me.lblEco10_1.Location = New System.Drawing.Point(92, 258)
		Me.lblEco10_1.Name = "lblEco10_1"
		Me.lblEco10_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEco10_1.TabIndex = 133
		Me.lblEco10_1.Text = "-"
		Me.lblEco10_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv1_7
		'
		Me.lblEnv1_7.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEnv1_7.DSSElementName = Nothing
		Me.lblEnv1_7.DSSLocation = 0
		Me.lblEnv1_7.DSSOffset = 0R
		Me.lblEnv1_7.Location = New System.Drawing.Point(165, 189)
		Me.lblEnv1_7.Name = "lblEnv1_7"
		Me.lblEnv1_7.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv1_7.TabIndex = 134
		Me.lblEnv1_7.Text = "-"
		Me.lblEnv1_7.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc1_7
		'
		Me.lblSoc1_7.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblSoc1_7.DSSElementName = Nothing
		Me.lblSoc1_7.DSSLocation = 0
		Me.lblSoc1_7.DSSOffset = 0R
		Me.lblSoc1_7.Location = New System.Drawing.Point(125, 189)
		Me.lblSoc1_7.Name = "lblSoc1_7"
		Me.lblSoc1_7.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc1_7.TabIndex = 135
		Me.lblSoc1_7.Text = "-"
		Me.lblSoc1_7.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco1_7
		'
		Me.lblEco1_7.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco1_7.DSSElementName = Nothing
		Me.lblEco1_7.DSSLocation = 0
		Me.lblEco1_7.DSSOffset = 0R
		Me.lblEco1_7.Location = New System.Drawing.Point(92, 189)
		Me.lblEco1_7.Name = "lblEco1_7"
		Me.lblEco1_7.Size = New System.Drawing.Size(34, 20)
		Me.lblEco1_7.TabIndex = 137
		Me.lblEco1_7.Text = "-"
		Me.lblEco1_7.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv1_3
		'
		Me.lblEnv1_3.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEnv1_3.DSSElementName = Nothing
		Me.lblEnv1_3.DSSLocation = 0
		Me.lblEnv1_3.DSSOffset = 0R
		Me.lblEnv1_3.Location = New System.Drawing.Point(165, 97)
		Me.lblEnv1_3.Name = "lblEnv1_3"
		Me.lblEnv1_3.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv1_3.TabIndex = 145
		Me.lblEnv1_3.Text = "-"
		Me.lblEnv1_3.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc1_3
		'
		Me.lblSoc1_3.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblSoc1_3.DSSElementName = Nothing
		Me.lblSoc1_3.DSSLocation = 0
		Me.lblSoc1_3.DSSOffset = 0R
		Me.lblSoc1_3.Location = New System.Drawing.Point(125, 97)
		Me.lblSoc1_3.Name = "lblSoc1_3"
		Me.lblSoc1_3.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc1_3.TabIndex = 138
		Me.lblSoc1_3.Text = "-"
		Me.lblSoc1_3.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco1_3
		'
		Me.lblEco1_3.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco1_3.DSSElementName = Nothing
		Me.lblEco1_3.DSSLocation = 0
		Me.lblEco1_3.DSSOffset = 0R
		Me.lblEco1_3.Location = New System.Drawing.Point(92, 97)
		Me.lblEco1_3.Name = "lblEco1_3"
		Me.lblEco1_3.Size = New System.Drawing.Size(34, 20)
		Me.lblEco1_3.TabIndex = 139
		Me.lblEco1_3.Text = "-"
		Me.lblEco1_3.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv1_12
		'
		Me.lblEnv1_12.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEnv1_12.DSSElementName = Nothing
		Me.lblEnv1_12.DSSLocation = 0
		Me.lblEnv1_12.DSSOffset = 0R
		Me.lblEnv1_12.Location = New System.Drawing.Point(165, 304)
		Me.lblEnv1_12.Name = "lblEnv1_12"
		Me.lblEnv1_12.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv1_12.TabIndex = 140
		Me.lblEnv1_12.Text = "-"
		Me.lblEnv1_12.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc1_12
		'
		Me.lblSoc1_12.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblSoc1_12.DSSElementName = Nothing
		Me.lblSoc1_12.DSSLocation = 0
		Me.lblSoc1_12.DSSOffset = 0R
		Me.lblSoc1_12.Location = New System.Drawing.Point(125, 304)
		Me.lblSoc1_12.Name = "lblSoc1_12"
		Me.lblSoc1_12.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc1_12.TabIndex = 141
		Me.lblSoc1_12.Text = "-"
		Me.lblSoc1_12.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco1_12
		'
		Me.lblEco1_12.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco1_12.DSSElementName = Nothing
		Me.lblEco1_12.DSSLocation = 0
		Me.lblEco1_12.DSSOffset = 0R
		Me.lblEco1_12.Location = New System.Drawing.Point(92, 304)
		Me.lblEco1_12.Name = "lblEco1_12"
		Me.lblEco1_12.Size = New System.Drawing.Size(34, 20)
		Me.lblEco1_12.TabIndex = 142
		Me.lblEco1_12.Text = "-"
		Me.lblEco1_12.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv1_9
		'
		Me.lblEnv1_9.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEnv1_9.DSSElementName = Nothing
		Me.lblEnv1_9.DSSLocation = 0
		Me.lblEnv1_9.DSSOffset = 0R
		Me.lblEnv1_9.Location = New System.Drawing.Point(165, 235)
		Me.lblEnv1_9.Name = "lblEnv1_9"
		Me.lblEnv1_9.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv1_9.TabIndex = 143
		Me.lblEnv1_9.Text = "-"
		Me.lblEnv1_9.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc1_9
		'
		Me.lblSoc1_9.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblSoc1_9.DSSElementName = Nothing
		Me.lblSoc1_9.DSSLocation = 0
		Me.lblSoc1_9.DSSOffset = 0R
		Me.lblSoc1_9.Location = New System.Drawing.Point(125, 235)
		Me.lblSoc1_9.Name = "lblSoc1_9"
		Me.lblSoc1_9.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc1_9.TabIndex = 144
		Me.lblSoc1_9.Text = "-"
		Me.lblSoc1_9.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco1_9
		'
		Me.lblEco1_9.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco1_9.DSSElementName = Nothing
		Me.lblEco1_9.DSSLocation = 0
		Me.lblEco1_9.DSSOffset = 0R
		Me.lblEco1_9.Location = New System.Drawing.Point(92, 235)
		Me.lblEco1_9.Name = "lblEco1_9"
		Me.lblEco1_9.Size = New System.Drawing.Size(34, 20)
		Me.lblEco1_9.TabIndex = 128
		Me.lblEco1_9.Text = "-"
		Me.lblEco1_9.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv1_6
		'
		Me.lblEnv1_6.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEnv1_6.DSSElementName = Nothing
		Me.lblEnv1_6.DSSLocation = 0
		Me.lblEnv1_6.DSSOffset = 0R
		Me.lblEnv1_6.Location = New System.Drawing.Point(165, 166)
		Me.lblEnv1_6.Name = "lblEnv1_6"
		Me.lblEnv1_6.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv1_6.TabIndex = 136
		Me.lblEnv1_6.Text = "-"
		Me.lblEnv1_6.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc1_6
		'
		Me.lblSoc1_6.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblSoc1_6.DSSElementName = Nothing
		Me.lblSoc1_6.DSSLocation = 0
		Me.lblSoc1_6.DSSOffset = 0R
		Me.lblSoc1_6.Location = New System.Drawing.Point(125, 166)
		Me.lblSoc1_6.Name = "lblSoc1_6"
		Me.lblSoc1_6.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc1_6.TabIndex = 127
		Me.lblSoc1_6.Text = "-"
		Me.lblSoc1_6.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco1_6
		'
		Me.lblEco1_6.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco1_6.DSSElementName = Nothing
		Me.lblEco1_6.DSSLocation = 0
		Me.lblEco1_6.DSSOffset = 0R
		Me.lblEco1_6.Location = New System.Drawing.Point(92, 166)
		Me.lblEco1_6.Name = "lblEco1_6"
		Me.lblEco1_6.Size = New System.Drawing.Size(34, 20)
		Me.lblEco1_6.TabIndex = 116
		Me.lblEco1_6.Text = "-"
		Me.lblEco1_6.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv1_2
		'
		Me.lblEnv1_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEnv1_2.DSSElementName = Nothing
		Me.lblEnv1_2.DSSLocation = 0
		Me.lblEnv1_2.DSSOffset = 0R
		Me.lblEnv1_2.Location = New System.Drawing.Point(165, 74)
		Me.lblEnv1_2.Name = "lblEnv1_2"
		Me.lblEnv1_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv1_2.TabIndex = 109
		Me.lblEnv1_2.Text = "-"
		Me.lblEnv1_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc1_2
		'
		Me.lblSoc1_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblSoc1_2.DSSElementName = Nothing
		Me.lblSoc1_2.DSSLocation = 0
		Me.lblSoc1_2.DSSOffset = 0R
		Me.lblSoc1_2.Location = New System.Drawing.Point(125, 74)
		Me.lblSoc1_2.Name = "lblSoc1_2"
		Me.lblSoc1_2.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc1_2.TabIndex = 110
		Me.lblSoc1_2.Text = "-"
		Me.lblSoc1_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco1_2
		'
		Me.lblEco1_2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco1_2.DSSElementName = Nothing
		Me.lblEco1_2.DSSLocation = 0
		Me.lblEco1_2.DSSOffset = 0R
		Me.lblEco1_2.Location = New System.Drawing.Point(92, 74)
		Me.lblEco1_2.Name = "lblEco1_2"
		Me.lblEco1_2.Size = New System.Drawing.Size(34, 20)
		Me.lblEco1_2.TabIndex = 111
		Me.lblEco1_2.Text = "-"
		Me.lblEco1_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv1_11
		'
		Me.lblEnv1_11.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEnv1_11.DSSElementName = Nothing
		Me.lblEnv1_11.DSSLocation = 0
		Me.lblEnv1_11.DSSOffset = 0R
		Me.lblEnv1_11.Location = New System.Drawing.Point(165, 281)
		Me.lblEnv1_11.Name = "lblEnv1_11"
		Me.lblEnv1_11.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv1_11.TabIndex = 112
		Me.lblEnv1_11.Text = "-"
		Me.lblEnv1_11.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc1_11
		'
		Me.lblSoc1_11.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblSoc1_11.DSSElementName = Nothing
		Me.lblSoc1_11.DSSLocation = 0
		Me.lblSoc1_11.DSSOffset = 0R
		Me.lblSoc1_11.Location = New System.Drawing.Point(125, 281)
		Me.lblSoc1_11.Name = "lblSoc1_11"
		Me.lblSoc1_11.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc1_11.TabIndex = 113
		Me.lblSoc1_11.Text = "-"
		Me.lblSoc1_11.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco1_11
		'
		Me.lblEco1_11.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco1_11.DSSElementName = Nothing
		Me.lblEco1_11.DSSLocation = 0
		Me.lblEco1_11.DSSOffset = 0R
		Me.lblEco1_11.Location = New System.Drawing.Point(92, 281)
		Me.lblEco1_11.Name = "lblEco1_11"
		Me.lblEco1_11.Size = New System.Drawing.Size(34, 20)
		Me.lblEco1_11.TabIndex = 114
		Me.lblEco1_11.Text = "-"
		Me.lblEco1_11.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv1_8
		'
		Me.lblEnv1_8.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEnv1_8.DSSElementName = Nothing
		Me.lblEnv1_8.DSSLocation = 0
		Me.lblEnv1_8.DSSOffset = 0R
		Me.lblEnv1_8.Location = New System.Drawing.Point(165, 212)
		Me.lblEnv1_8.Name = "lblEnv1_8"
		Me.lblEnv1_8.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv1_8.TabIndex = 115
		Me.lblEnv1_8.Text = "-"
		Me.lblEnv1_8.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc1_8
		'
		Me.lblSoc1_8.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblSoc1_8.DSSElementName = Nothing
		Me.lblSoc1_8.DSSLocation = 0
		Me.lblSoc1_8.DSSOffset = 0R
		Me.lblSoc1_8.Location = New System.Drawing.Point(125, 212)
		Me.lblSoc1_8.Name = "lblSoc1_8"
		Me.lblSoc1_8.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc1_8.TabIndex = 117
		Me.lblSoc1_8.Text = "-"
		Me.lblSoc1_8.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco1_8
		'
		Me.lblEco1_8.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco1_8.DSSElementName = Nothing
		Me.lblEco1_8.DSSLocation = 0
		Me.lblEco1_8.DSSOffset = 0R
		Me.lblEco1_8.Location = New System.Drawing.Point(92, 212)
		Me.lblEco1_8.Name = "lblEco1_8"
		Me.lblEco1_8.Size = New System.Drawing.Size(34, 20)
		Me.lblEco1_8.TabIndex = 125
		Me.lblEco1_8.Text = "-"
		Me.lblEco1_8.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv1_4
		'
		Me.lblEnv1_4.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEnv1_4.DSSElementName = Nothing
		Me.lblEnv1_4.DSSLocation = 0
		Me.lblEnv1_4.DSSOffset = 0R
		Me.lblEnv1_4.Location = New System.Drawing.Point(165, 120)
		Me.lblEnv1_4.Name = "lblEnv1_4"
		Me.lblEnv1_4.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv1_4.TabIndex = 118
		Me.lblEnv1_4.Text = "-"
		Me.lblEnv1_4.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc1_4
		'
		Me.lblSoc1_4.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblSoc1_4.DSSElementName = Nothing
		Me.lblSoc1_4.DSSLocation = 0
		Me.lblSoc1_4.DSSOffset = 0R
		Me.lblSoc1_4.Location = New System.Drawing.Point(125, 120)
		Me.lblSoc1_4.Name = "lblSoc1_4"
		Me.lblSoc1_4.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc1_4.TabIndex = 119
		Me.lblSoc1_4.Text = "-"
		Me.lblSoc1_4.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco1_4
		'
		Me.lblEco1_4.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco1_4.DSSElementName = Nothing
		Me.lblEco1_4.DSSLocation = 0
		Me.lblEco1_4.DSSOffset = 0R
		Me.lblEco1_4.Location = New System.Drawing.Point(92, 120)
		Me.lblEco1_4.Name = "lblEco1_4"
		Me.lblEco1_4.Size = New System.Drawing.Size(34, 20)
		Me.lblEco1_4.TabIndex = 120
		Me.lblEco1_4.Text = "-"
		Me.lblEco1_4.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv1_5
		'
		Me.lblEnv1_5.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEnv1_5.DSSElementName = Nothing
		Me.lblEnv1_5.DSSLocation = 0
		Me.lblEnv1_5.DSSOffset = 0R
		Me.lblEnv1_5.Location = New System.Drawing.Point(165, 143)
		Me.lblEnv1_5.Name = "lblEnv1_5"
		Me.lblEnv1_5.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv1_5.TabIndex = 121
		Me.lblEnv1_5.Text = "-"
		Me.lblEnv1_5.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc1_5
		'
		Me.lblSoc1_5.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblSoc1_5.DSSElementName = Nothing
		Me.lblSoc1_5.DSSLocation = 0
		Me.lblSoc1_5.DSSOffset = 0R
		Me.lblSoc1_5.Location = New System.Drawing.Point(125, 143)
		Me.lblSoc1_5.Name = "lblSoc1_5"
		Me.lblSoc1_5.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc1_5.TabIndex = 122
		Me.lblSoc1_5.Text = "-"
		Me.lblSoc1_5.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco1_5
		'
		Me.lblEco1_5.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco1_5.DSSElementName = Nothing
		Me.lblEco1_5.DSSLocation = 0
		Me.lblEco1_5.DSSOffset = 0R
		Me.lblEco1_5.Location = New System.Drawing.Point(92, 143)
		Me.lblEco1_5.Name = "lblEco1_5"
		Me.lblEco1_5.Size = New System.Drawing.Size(34, 20)
		Me.lblEco1_5.TabIndex = 123
		Me.lblEco1_5.Text = "-"
		Me.lblEco1_5.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEnv1_1
		'
		Me.lblEnv1_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEnv1_1.DSSElementName = Nothing
		Me.lblEnv1_1.DSSLocation = 0
		Me.lblEnv1_1.DSSOffset = 0R
		Me.lblEnv1_1.Location = New System.Drawing.Point(165, 51)
		Me.lblEnv1_1.Name = "lblEnv1_1"
		Me.lblEnv1_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEnv1_1.TabIndex = 124
		Me.lblEnv1_1.Text = "-"
		Me.lblEnv1_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblSoc1_1
		'
		Me.lblSoc1_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblSoc1_1.DSSElementName = Nothing
		Me.lblSoc1_1.DSSLocation = 0
		Me.lblSoc1_1.DSSOffset = 0R
		Me.lblSoc1_1.Location = New System.Drawing.Point(125, 51)
		Me.lblSoc1_1.Name = "lblSoc1_1"
		Me.lblSoc1_1.Size = New System.Drawing.Size(34, 20)
		Me.lblSoc1_1.TabIndex = 126
		Me.lblSoc1_1.Text = "-"
		Me.lblSoc1_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblEco1_1
		'
		Me.lblEco1_1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.lblEco1_1.DSSElementName = Nothing
		Me.lblEco1_1.DSSLocation = 0
		Me.lblEco1_1.DSSOffset = 0R
		Me.lblEco1_1.Location = New System.Drawing.Point(92, 51)
		Me.lblEco1_1.Name = "lblEco1_1"
		Me.lblEco1_1.Size = New System.Drawing.Size(34, 20)
		Me.lblEco1_1.TabIndex = 146
		Me.lblEco1_1.Text = "-"
		Me.lblEco1_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Label178
		'
		Me.Label178.Location = New System.Drawing.Point(165, 34)
		Me.Label178.Name = "Label178"
		Me.Label178.Size = New System.Drawing.Size(34, 20)
		Me.Label178.TabIndex = 105
		Me.Label178.Text = "env"
		Me.Label178.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label179
		'
		Me.Label179.Location = New System.Drawing.Point(125, 34)
		Me.Label179.Name = "Label179"
		Me.Label179.Size = New System.Drawing.Size(34, 20)
		Me.Label179.TabIndex = 106
		Me.Label179.Text = "soc"
		Me.Label179.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label180
		'
		Me.Label180.Location = New System.Drawing.Point(92, 34)
		Me.Label180.Name = "Label180"
		Me.Label180.Size = New System.Drawing.Size(34, 20)
		Me.Label180.TabIndex = 107
		Me.Label180.Text = "eco"
		Me.Label180.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label103
		'
		Me.Label103.Location = New System.Drawing.Point(8, 327)
		Me.Label103.Name = "Label103"
		Me.Label103.Size = New System.Drawing.Size(68, 20)
		Me.Label103.TabIndex = 49
		Me.Label103.Text = "Tabouk"
		'
		'Label104
		'
		Me.Label104.Location = New System.Drawing.Point(8, 189)
		Me.Label104.Name = "Label104"
		Me.Label104.Size = New System.Drawing.Size(68, 20)
		Me.Label104.TabIndex = 50
		Me.Label104.Text = "Jizan"
		'
		'Label105
		'
		Me.Label105.Location = New System.Drawing.Point(8, 304)
		Me.Label105.Name = "Label105"
		Me.Label105.Size = New System.Drawing.Size(68, 20)
		Me.Label105.TabIndex = 51
		Me.Label105.Text = "Riyadh"
		'
		'Label106
		'
		Me.Label106.Location = New System.Drawing.Point(8, 166)
		Me.Label106.Name = "Label106"
		Me.Label106.Size = New System.Drawing.Size(68, 20)
		Me.Label106.TabIndex = 52
		Me.Label106.Text = "Hail"
		'
		'Label107
		'
		Me.Label107.Location = New System.Drawing.Point(8, 281)
		Me.Label107.Name = "Label107"
		Me.Label107.Size = New System.Drawing.Size(68, 20)
		Me.Label107.TabIndex = 53
		Me.Label107.Text = "North Border"
		'
		'Label108
		'
		Me.Label108.Location = New System.Drawing.Point(8, 258)
		Me.Label108.Name = "Label108"
		Me.Label108.Size = New System.Drawing.Size(68, 20)
		Me.Label108.TabIndex = 61
		Me.Label108.Text = "Najran"
		'
		'Label109
		'
		Me.Label109.Location = New System.Drawing.Point(8, 97)
		Me.Label109.Name = "Label109"
		Me.Label109.Size = New System.Drawing.Size(68, 20)
		Me.Label109.TabIndex = 54
		Me.Label109.Text = "Al - Jouf"
		'
		'Label110
		'
		Me.Label110.Location = New System.Drawing.Point(8, 235)
		Me.Label110.Name = "Label110"
		Me.Label110.Size = New System.Drawing.Size(68, 20)
		Me.Label110.TabIndex = 55
		Me.Label110.Text = "Mecca"
		'
		'Label111
		'
		Me.Label111.Location = New System.Drawing.Point(8, 143)
		Me.Label111.Name = "Label111"
		Me.Label111.Size = New System.Drawing.Size(68, 20)
		Me.Label111.TabIndex = 56
		Me.Label111.Text = "Eastern Area"
		'
		'Label112
		'
		Me.Label112.Location = New System.Drawing.Point(8, 74)
		Me.Label112.Name = "Label112"
		Me.Label112.Size = New System.Drawing.Size(68, 20)
		Me.Label112.TabIndex = 57
		Me.Label112.Text = "Al - Gassem"
		'
		'Label113
		'
		Me.Label113.Location = New System.Drawing.Point(8, 212)
		Me.Label113.Name = "Label113"
		Me.Label113.Size = New System.Drawing.Size(68, 20)
		Me.Label113.TabIndex = 58
		Me.Label113.Text = "Madina"
		'
		'Label114
		'
		Me.Label114.Location = New System.Drawing.Point(8, 120)
		Me.Label114.Name = "Label114"
		Me.Label114.Size = New System.Drawing.Size(68, 20)
		Me.Label114.TabIndex = 59
		Me.Label114.Text = "Aseer"
		'
		'Label115
		'
		Me.Label115.Location = New System.Drawing.Point(8, 51)
		Me.Label115.Name = "Label115"
		Me.Label115.Size = New System.Drawing.Size(68, 20)
		Me.Label115.TabIndex = 60
		Me.Label115.Text = "Al - Baha"
		'
		'tpaWeights
		'
		Me.tpaWeights.Location = New System.Drawing.Point(4, 22)
		Me.tpaWeights.Name = "tpaWeights"
		Me.tpaWeights.Size = New System.Drawing.Size(564, 454)
		Me.tpaWeights.TabIndex = 4
		Me.tpaWeights.Text = "Weights"
		Me.tpaWeights.UseVisualStyleBackColor = True
		'
		'tpaStandards
		'
		Me.tpaStandards.Location = New System.Drawing.Point(4, 22)
		Me.tpaStandards.Name = "tpaStandards"
		Me.tpaStandards.Size = New System.Drawing.Size(564, 454)
		Me.tpaStandards.TabIndex = 5
		Me.tpaStandards.Text = "Standards"
		Me.tpaStandards.UseVisualStyleBackColor = True
		'
		'tpaEfficencies
		'
		Me.tpaEfficencies.Location = New System.Drawing.Point(4, 22)
		Me.tpaEfficencies.Name = "tpaEfficencies"
		Me.tpaEfficencies.Size = New System.Drawing.Size(564, 454)
		Me.tpaEfficencies.TabIndex = 6
		Me.tpaEfficencies.Text = "Efficiencies"
		Me.tpaEfficencies.UseVisualStyleBackColor = True
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
		Me.grbPopulation.DSSDrawOnMap = True
		Me.grbPopulation.DSSVisible = True
		Me.grbPopulation.ForeColor = System.Drawing.Color.Black
		Me.grbPopulation.Location = New System.Drawing.Point(0, 0)
		Me.grbPopulation.Name = "grbPopulation"
		Me.grbPopulation.Size = New System.Drawing.Size(294, 499)
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
		Me.pnlPop20_2.DSSVisible = True
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
		Me.pnlPop20_1.DSSVisible = True
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
		Me.grbIndustrialDistricts.DSSDrawOnMap = True
		Me.grbIndustrialDistricts.DSSVisible = True
		Me.grbIndustrialDistricts.ForeColor = System.Drawing.Color.Black
		Me.grbIndustrialDistricts.Location = New System.Drawing.Point(0, 0)
		Me.grbIndustrialDistricts.Name = "grbIndustrialDistricts"
		Me.grbIndustrialDistricts.Size = New System.Drawing.Size(300, 499)
		Me.grbIndustrialDistricts.TabIndex = 23
		Me.grbIndustrialDistricts.TabStop = False
		Me.grbIndustrialDistricts.Text = "Industril districts"
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
		Me.pnlInddispln.DSSVisible = True
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
		Me.pnlInddiscur.DSSVisible = True
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
		Me.grbMisc.DSSDrawOnMap = False
		Me.grbMisc.DSSVisible = True
		Me.grbMisc.ForeColor = System.Drawing.Color.Black
		Me.grbMisc.Location = New System.Drawing.Point(0, 0)
		Me.grbMisc.Name = "grbMisc"
		Me.grbMisc.Size = New System.Drawing.Size(759, 499)
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
		Me.DssPanel1.DSSVisible = True
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
		Me.Label10.Text = "Cost"
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
		Me.nudTpsx.DSSLocation = 2
		Me.nudTpsx.DSSOffset = -0.2R
		Me.nudTpsx.Location = New System.Drawing.Point(291, 43)
		Me.nudTpsx.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
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
		Me.nudTpmz.DSSLocation = 2
		Me.nudTpmz.DSSOffset = -0.2R
		Me.nudTpmz.Location = New System.Drawing.Point(389, 89)
		Me.nudTpmz.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
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
		Me.Label24.Text = "Cost"
		Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'nudAgrUFRO
		'
		Me.nudAgrUFRO.DecimalPlaces = 2
		Me.nudAgrUFRO.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(215, Byte), CType(0, Byte))
		Me.nudAgrUFRO.DSSElementName = "inddiscur2_1"
		Me.nudAgrUFRO.DSSLocation = 2
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
		Me.nudEnvw.DSSLocation = 6
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
		Me.nudgwsp.DSSLocation = 6
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
		Me.nudTotpla.DSSLocation = 7
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
		Me.nudIndUFRO.DSSLocation = 2
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
		Me.nudSocw.DSSLocation = 7
		Me.nudSocw.DSSOffset = -0.2R
		Me.nudSocw.Location = New System.Drawing.Point(389, 158)
		Me.nudSocw.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
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
		Me.nudTpbx.DSSLocation = 1
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
		Me.nudEcow.DSSLocation = 5
		Me.nudEcow.DSSOffset = -0.2R
		Me.nudEcow.Location = New System.Drawing.Point(291, 158)
		Me.nudEcow.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
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
		Me.nudsmqi.DSSLocation = 1
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
		Me.nudLanUFRO.DSSLocation = 2
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
		Me.nudsbqi.DSSLocation = 1
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
		Me.nudLanUF.DSSLocation = 1
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
		Me.nudssqi.DSSLocation = 1
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
		Me.nudAgrUF.DSSLocation = 1
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
		Me.nudIndUF.DSSLocation = 1
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
		Me.grbWaterQuality.DSSDrawOnMap = True
		Me.grbWaterQuality.DSSVisible = True
		Me.grbWaterQuality.ForeColor = System.Drawing.Color.Black
		Me.grbWaterQuality.Location = New System.Drawing.Point(0, 0)
		Me.grbWaterQuality.Name = "grbWaterQuality"
		Me.grbWaterQuality.Size = New System.Drawing.Size(413, 499)
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
		Me.pnlTSS.DSSVisible = True
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
		Me.pnlTDS.DSSVisible = True
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
		Me.pnlBOD.DSSVisible = True
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
		Me.grbWaterCosts.DSSDrawOnMap = True
		Me.grbWaterCosts.DSSVisible = True
		Me.grbWaterCosts.ForeColor = System.Drawing.Color.Black
		Me.grbWaterCosts.Location = New System.Drawing.Point(0, 0)
		Me.grbWaterCosts.Name = "grbWaterCosts"
		Me.grbWaterCosts.Size = New System.Drawing.Size(349, 499)
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
		Me.pnlGro.DSSVisible = True
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
		Me.pnlDes.DSSVisible = True
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
		'ElementHost1
		'
		Me.ElementHost1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ElementHost1.Location = New System.Drawing.Point(0, 0)
		Me.ElementHost1.Name = "ElementHost1"
		Me.ElementHost1.Size = New System.Drawing.Size(192, 499)
		Me.ElementHost1.TabIndex = 0
		Me.ElementHost1.Text = "ElementHost1"
		Me.ElementHost1.Child = Me.mapControl
		'
		'DssLabel1
		'
		Me.DssLabel1.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel1.DSSElementName = Nothing
		Me.DssLabel1.DSSLocation = 0
		Me.DssLabel1.DSSOffset = 0R
		Me.DssLabel1.Location = New System.Drawing.Point(303, 326)
		Me.DssLabel1.Name = "DssLabel1"
		Me.DssLabel1.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel1.TabIndex = 105
		Me.DssLabel1.Text = "-"
		Me.DssLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel2
		'
		Me.DssLabel2.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel2.DSSElementName = Nothing
		Me.DssLabel2.DSSLocation = 0
		Me.DssLabel2.DSSOffset = 0R
		Me.DssLabel2.Location = New System.Drawing.Point(263, 326)
		Me.DssLabel2.Name = "DssLabel2"
		Me.DssLabel2.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel2.TabIndex = 87
		Me.DssLabel2.Text = "-"
		Me.DssLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel3
		'
		Me.DssLabel3.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel3.DSSElementName = Nothing
		Me.DssLabel3.DSSLocation = 0
		Me.DssLabel3.DSSOffset = 0R
		Me.DssLabel3.Location = New System.Drawing.Point(230, 326)
		Me.DssLabel3.Name = "DssLabel3"
		Me.DssLabel3.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel3.TabIndex = 88
		Me.DssLabel3.Text = "-"
		Me.DssLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel4
		'
		Me.DssLabel4.AccessibleDescription = ""
		Me.DssLabel4.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel4.DSSElementName = Nothing
		Me.DssLabel4.DSSLocation = 0
		Me.DssLabel4.DSSOffset = 0R
		Me.DssLabel4.Location = New System.Drawing.Point(303, 257)
		Me.DssLabel4.Name = "DssLabel4"
		Me.DssLabel4.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel4.TabIndex = 89
		Me.DssLabel4.Text = "-"
		Me.DssLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel5
		'
		Me.DssLabel5.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel5.DSSElementName = Nothing
		Me.DssLabel5.DSSLocation = 0
		Me.DssLabel5.DSSOffset = 0R
		Me.DssLabel5.Location = New System.Drawing.Point(263, 257)
		Me.DssLabel5.Name = "DssLabel5"
		Me.DssLabel5.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel5.TabIndex = 90
		Me.DssLabel5.Text = "-"
		Me.DssLabel5.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel6
		'
		Me.DssLabel6.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel6.DSSElementName = Nothing
		Me.DssLabel6.DSSLocation = 0
		Me.DssLabel6.DSSOffset = 0R
		Me.DssLabel6.Location = New System.Drawing.Point(230, 257)
		Me.DssLabel6.Name = "DssLabel6"
		Me.DssLabel6.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel6.TabIndex = 91
		Me.DssLabel6.Text = "-"
		Me.DssLabel6.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel7
		'
		Me.DssLabel7.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel7.DSSElementName = Nothing
		Me.DssLabel7.DSSLocation = 0
		Me.DssLabel7.DSSOffset = 0R
		Me.DssLabel7.Location = New System.Drawing.Point(303, 188)
		Me.DssLabel7.Name = "DssLabel7"
		Me.DssLabel7.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel7.TabIndex = 92
		Me.DssLabel7.Text = "-"
		Me.DssLabel7.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel8
		'
		Me.DssLabel8.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel8.DSSElementName = Nothing
		Me.DssLabel8.DSSLocation = 0
		Me.DssLabel8.DSSOffset = 0R
		Me.DssLabel8.Location = New System.Drawing.Point(263, 188)
		Me.DssLabel8.Name = "DssLabel8"
		Me.DssLabel8.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel8.TabIndex = 93
		Me.DssLabel8.Text = "-"
		Me.DssLabel8.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel9
		'
		Me.DssLabel9.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel9.DSSElementName = Nothing
		Me.DssLabel9.DSSLocation = 0
		Me.DssLabel9.DSSOffset = 0R
		Me.DssLabel9.Location = New System.Drawing.Point(230, 188)
		Me.DssLabel9.Name = "DssLabel9"
		Me.DssLabel9.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel9.TabIndex = 94
		Me.DssLabel9.Text = "-"
		Me.DssLabel9.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel10
		'
		Me.DssLabel10.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel10.DSSElementName = Nothing
		Me.DssLabel10.DSSLocation = 0
		Me.DssLabel10.DSSOffset = 0R
		Me.DssLabel10.Location = New System.Drawing.Point(303, 96)
		Me.DssLabel10.Name = "DssLabel10"
		Me.DssLabel10.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel10.TabIndex = 95
		Me.DssLabel10.Text = "-"
		Me.DssLabel10.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel11
		'
		Me.DssLabel11.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel11.DSSElementName = Nothing
		Me.DssLabel11.DSSLocation = 0
		Me.DssLabel11.DSSOffset = 0R
		Me.DssLabel11.Location = New System.Drawing.Point(263, 96)
		Me.DssLabel11.Name = "DssLabel11"
		Me.DssLabel11.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel11.TabIndex = 96
		Me.DssLabel11.Text = "-"
		Me.DssLabel11.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel12
		'
		Me.DssLabel12.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel12.DSSElementName = Nothing
		Me.DssLabel12.DSSLocation = 0
		Me.DssLabel12.DSSOffset = 0R
		Me.DssLabel12.Location = New System.Drawing.Point(230, 96)
		Me.DssLabel12.Name = "DssLabel12"
		Me.DssLabel12.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel12.TabIndex = 97
		Me.DssLabel12.Text = "-"
		Me.DssLabel12.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel13
		'
		Me.DssLabel13.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel13.DSSElementName = Nothing
		Me.DssLabel13.DSSLocation = 0
		Me.DssLabel13.DSSOffset = 0R
		Me.DssLabel13.Location = New System.Drawing.Point(303, 303)
		Me.DssLabel13.Name = "DssLabel13"
		Me.DssLabel13.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel13.TabIndex = 98
		Me.DssLabel13.Text = "-"
		Me.DssLabel13.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel14
		'
		Me.DssLabel14.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel14.DSSElementName = Nothing
		Me.DssLabel14.DSSLocation = 0
		Me.DssLabel14.DSSOffset = 0R
		Me.DssLabel14.Location = New System.Drawing.Point(263, 303)
		Me.DssLabel14.Name = "DssLabel14"
		Me.DssLabel14.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel14.TabIndex = 99
		Me.DssLabel14.Text = "-"
		Me.DssLabel14.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel15
		'
		Me.DssLabel15.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel15.DSSElementName = Nothing
		Me.DssLabel15.DSSLocation = 0
		Me.DssLabel15.DSSOffset = 0R
		Me.DssLabel15.Location = New System.Drawing.Point(230, 303)
		Me.DssLabel15.Name = "DssLabel15"
		Me.DssLabel15.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel15.TabIndex = 100
		Me.DssLabel15.Text = "-"
		Me.DssLabel15.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel16
		'
		Me.DssLabel16.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel16.DSSElementName = Nothing
		Me.DssLabel16.DSSLocation = 0
		Me.DssLabel16.DSSOffset = 0R
		Me.DssLabel16.Location = New System.Drawing.Point(303, 234)
		Me.DssLabel16.Name = "DssLabel16"
		Me.DssLabel16.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel16.TabIndex = 101
		Me.DssLabel16.Text = "-"
		Me.DssLabel16.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel17
		'
		Me.DssLabel17.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel17.DSSElementName = Nothing
		Me.DssLabel17.DSSLocation = 0
		Me.DssLabel17.DSSOffset = 0R
		Me.DssLabel17.Location = New System.Drawing.Point(263, 234)
		Me.DssLabel17.Name = "DssLabel17"
		Me.DssLabel17.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel17.TabIndex = 102
		Me.DssLabel17.Text = "-"
		Me.DssLabel17.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel18
		'
		Me.DssLabel18.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel18.DSSElementName = Nothing
		Me.DssLabel18.DSSLocation = 0
		Me.DssLabel18.DSSOffset = 0R
		Me.DssLabel18.Location = New System.Drawing.Point(230, 234)
		Me.DssLabel18.Name = "DssLabel18"
		Me.DssLabel18.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel18.TabIndex = 103
		Me.DssLabel18.Text = "-"
		Me.DssLabel18.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel19
		'
		Me.DssLabel19.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel19.DSSElementName = Nothing
		Me.DssLabel19.DSSLocation = 0
		Me.DssLabel19.DSSOffset = 0R
		Me.DssLabel19.Location = New System.Drawing.Point(303, 165)
		Me.DssLabel19.Name = "DssLabel19"
		Me.DssLabel19.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel19.TabIndex = 86
		Me.DssLabel19.Text = "-"
		Me.DssLabel19.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel20
		'
		Me.DssLabel20.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel20.DSSElementName = Nothing
		Me.DssLabel20.DSSLocation = 0
		Me.DssLabel20.DSSOffset = 0R
		Me.DssLabel20.Location = New System.Drawing.Point(263, 165)
		Me.DssLabel20.Name = "DssLabel20"
		Me.DssLabel20.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel20.TabIndex = 104
		Me.DssLabel20.Text = "-"
		Me.DssLabel20.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel21
		'
		Me.DssLabel21.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel21.DSSElementName = Nothing
		Me.DssLabel21.DSSLocation = 0
		Me.DssLabel21.DSSOffset = 0R
		Me.DssLabel21.Location = New System.Drawing.Point(230, 165)
		Me.DssLabel21.Name = "DssLabel21"
		Me.DssLabel21.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel21.TabIndex = 85
		Me.DssLabel21.Text = "-"
		Me.DssLabel21.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel22
		'
		Me.DssLabel22.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel22.DSSElementName = Nothing
		Me.DssLabel22.DSSLocation = 0
		Me.DssLabel22.DSSOffset = 0R
		Me.DssLabel22.Location = New System.Drawing.Point(303, 73)
		Me.DssLabel22.Name = "DssLabel22"
		Me.DssLabel22.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel22.TabIndex = 83
		Me.DssLabel22.Text = "-"
		Me.DssLabel22.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel23
		'
		Me.DssLabel23.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel23.DSSElementName = Nothing
		Me.DssLabel23.DSSLocation = 0
		Me.DssLabel23.DSSOffset = 0R
		Me.DssLabel23.Location = New System.Drawing.Point(263, 73)
		Me.DssLabel23.Name = "DssLabel23"
		Me.DssLabel23.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel23.TabIndex = 68
		Me.DssLabel23.Text = "-"
		Me.DssLabel23.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel24
		'
		Me.DssLabel24.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel24.DSSElementName = Nothing
		Me.DssLabel24.DSSLocation = 0
		Me.DssLabel24.DSSOffset = 0R
		Me.DssLabel24.Location = New System.Drawing.Point(230, 73)
		Me.DssLabel24.Name = "DssLabel24"
		Me.DssLabel24.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel24.TabIndex = 69
		Me.DssLabel24.Text = "-"
		Me.DssLabel24.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel25
		'
		Me.DssLabel25.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel25.DSSElementName = Nothing
		Me.DssLabel25.DSSLocation = 0
		Me.DssLabel25.DSSOffset = 0R
		Me.DssLabel25.Location = New System.Drawing.Point(303, 280)
		Me.DssLabel25.Name = "DssLabel25"
		Me.DssLabel25.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel25.TabIndex = 70
		Me.DssLabel25.Text = "-"
		Me.DssLabel25.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel26
		'
		Me.DssLabel26.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel26.DSSElementName = Nothing
		Me.DssLabel26.DSSLocation = 0
		Me.DssLabel26.DSSOffset = 0R
		Me.DssLabel26.Location = New System.Drawing.Point(263, 280)
		Me.DssLabel26.Name = "DssLabel26"
		Me.DssLabel26.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel26.TabIndex = 71
		Me.DssLabel26.Text = "-"
		Me.DssLabel26.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel27
		'
		Me.DssLabel27.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel27.DSSElementName = Nothing
		Me.DssLabel27.DSSLocation = 0
		Me.DssLabel27.DSSOffset = 0R
		Me.DssLabel27.Location = New System.Drawing.Point(230, 280)
		Me.DssLabel27.Name = "DssLabel27"
		Me.DssLabel27.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel27.TabIndex = 72
		Me.DssLabel27.Text = "-"
		Me.DssLabel27.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel28
		'
		Me.DssLabel28.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel28.DSSElementName = Nothing
		Me.DssLabel28.DSSLocation = 0
		Me.DssLabel28.DSSOffset = 0R
		Me.DssLabel28.Location = New System.Drawing.Point(303, 211)
		Me.DssLabel28.Name = "DssLabel28"
		Me.DssLabel28.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel28.TabIndex = 73
		Me.DssLabel28.Text = "-"
		Me.DssLabel28.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel29
		'
		Me.DssLabel29.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel29.DSSElementName = Nothing
		Me.DssLabel29.DSSLocation = 0
		Me.DssLabel29.DSSOffset = 0R
		Me.DssLabel29.Location = New System.Drawing.Point(263, 211)
		Me.DssLabel29.Name = "DssLabel29"
		Me.DssLabel29.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel29.TabIndex = 74
		Me.DssLabel29.Text = "-"
		Me.DssLabel29.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel30
		'
		Me.DssLabel30.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel30.DSSElementName = Nothing
		Me.DssLabel30.DSSLocation = 0
		Me.DssLabel30.DSSOffset = 0R
		Me.DssLabel30.Location = New System.Drawing.Point(230, 211)
		Me.DssLabel30.Name = "DssLabel30"
		Me.DssLabel30.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel30.TabIndex = 75
		Me.DssLabel30.Text = "-"
		Me.DssLabel30.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel31
		'
		Me.DssLabel31.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel31.DSSElementName = Nothing
		Me.DssLabel31.DSSLocation = 0
		Me.DssLabel31.DSSOffset = 0R
		Me.DssLabel31.Location = New System.Drawing.Point(303, 119)
		Me.DssLabel31.Name = "DssLabel31"
		Me.DssLabel31.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel31.TabIndex = 84
		Me.DssLabel31.Text = "-"
		Me.DssLabel31.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel32
		'
		Me.DssLabel32.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel32.DSSElementName = Nothing
		Me.DssLabel32.DSSLocation = 0
		Me.DssLabel32.DSSOffset = 0R
		Me.DssLabel32.Location = New System.Drawing.Point(263, 119)
		Me.DssLabel32.Name = "DssLabel32"
		Me.DssLabel32.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel32.TabIndex = 76
		Me.DssLabel32.Text = "-"
		Me.DssLabel32.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel33
		'
		Me.DssLabel33.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel33.DSSElementName = Nothing
		Me.DssLabel33.DSSLocation = 0
		Me.DssLabel33.DSSOffset = 0R
		Me.DssLabel33.Location = New System.Drawing.Point(230, 119)
		Me.DssLabel33.Name = "DssLabel33"
		Me.DssLabel33.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel33.TabIndex = 77
		Me.DssLabel33.Text = "-"
		Me.DssLabel33.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel34
		'
		Me.DssLabel34.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel34.DSSElementName = Nothing
		Me.DssLabel34.DSSLocation = 0
		Me.DssLabel34.DSSOffset = 0R
		Me.DssLabel34.Location = New System.Drawing.Point(303, 142)
		Me.DssLabel34.Name = "DssLabel34"
		Me.DssLabel34.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel34.TabIndex = 78
		Me.DssLabel34.Text = "-"
		Me.DssLabel34.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel35
		'
		Me.DssLabel35.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel35.DSSElementName = Nothing
		Me.DssLabel35.DSSLocation = 0
		Me.DssLabel35.DSSOffset = 0R
		Me.DssLabel35.Location = New System.Drawing.Point(263, 142)
		Me.DssLabel35.Name = "DssLabel35"
		Me.DssLabel35.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel35.TabIndex = 79
		Me.DssLabel35.Text = "-"
		Me.DssLabel35.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel36
		'
		Me.DssLabel36.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel36.DSSElementName = Nothing
		Me.DssLabel36.DSSLocation = 0
		Me.DssLabel36.DSSOffset = 0R
		Me.DssLabel36.Location = New System.Drawing.Point(230, 142)
		Me.DssLabel36.Name = "DssLabel36"
		Me.DssLabel36.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel36.TabIndex = 80
		Me.DssLabel36.Text = "-"
		Me.DssLabel36.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel37
		'
		Me.DssLabel37.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel37.DSSElementName = Nothing
		Me.DssLabel37.DSSLocation = 0
		Me.DssLabel37.DSSOffset = 0R
		Me.DssLabel37.Location = New System.Drawing.Point(303, 50)
		Me.DssLabel37.Name = "DssLabel37"
		Me.DssLabel37.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel37.TabIndex = 81
		Me.DssLabel37.Text = "-"
		Me.DssLabel37.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel38
		'
		Me.DssLabel38.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel38.DSSElementName = Nothing
		Me.DssLabel38.DSSLocation = 0
		Me.DssLabel38.DSSOffset = 0R
		Me.DssLabel38.Location = New System.Drawing.Point(263, 50)
		Me.DssLabel38.Name = "DssLabel38"
		Me.DssLabel38.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel38.TabIndex = 82
		Me.DssLabel38.Text = "-"
		Me.DssLabel38.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel39
		'
		Me.DssLabel39.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel39.DSSElementName = Nothing
		Me.DssLabel39.DSSLocation = 0
		Me.DssLabel39.DSSOffset = 0R
		Me.DssLabel39.Location = New System.Drawing.Point(230, 50)
		Me.DssLabel39.Name = "DssLabel39"
		Me.DssLabel39.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel39.TabIndex = 67
		Me.DssLabel39.Text = "-"
		Me.DssLabel39.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Label87
		'
		Me.Label87.Location = New System.Drawing.Point(303, 33)
		Me.Label87.Name = "Label87"
		Me.Label87.Size = New System.Drawing.Size(34, 20)
		Me.Label87.TabIndex = 66
		Me.Label87.Text = "lan"
		Me.Label87.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label89
		'
		Me.Label89.Location = New System.Drawing.Point(263, 33)
		Me.Label89.Name = "Label89"
		Me.Label89.Size = New System.Drawing.Size(34, 20)
		Me.Label89.TabIndex = 65
		Me.Label89.Text = "ind"
		Me.Label89.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label90
		'
		Me.Label90.Location = New System.Drawing.Point(230, 33)
		Me.Label90.Name = "Label90"
		Me.Label90.Size = New System.Drawing.Size(34, 20)
		Me.Label90.TabIndex = 64
		Me.Label90.Text = "agr"
		Me.Label90.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label93
		'
		Me.Label93.Location = New System.Drawing.Point(103, 12)
		Me.Label93.Name = "Label93"
		Me.Label93.Size = New System.Drawing.Size(97, 20)
		Me.Label93.TabIndex = 106
		Me.Label93.Text = "Small"
		Me.Label93.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label94
		'
		Me.Label94.Location = New System.Drawing.Point(240, 8)
		Me.Label94.Name = "Label94"
		Me.Label94.Size = New System.Drawing.Size(97, 20)
		Me.Label94.TabIndex = 107
		Me.Label94.Text = "Large"
		Me.Label94.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'DssLabel40
		'
		Me.DssLabel40.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel40.DSSElementName = Nothing
		Me.DssLabel40.DSSLocation = 0
		Me.DssLabel40.DSSOffset = 0R
		Me.DssLabel40.Location = New System.Drawing.Point(304, 328)
		Me.DssLabel40.Name = "DssLabel40"
		Me.DssLabel40.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel40.TabIndex = 150
		Me.DssLabel40.Text = "-"
		Me.DssLabel40.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel41
		'
		Me.DssLabel41.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel41.DSSElementName = Nothing
		Me.DssLabel41.DSSLocation = 0
		Me.DssLabel41.DSSOffset = 0R
		Me.DssLabel41.Location = New System.Drawing.Point(264, 328)
		Me.DssLabel41.Name = "DssLabel41"
		Me.DssLabel41.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel41.TabIndex = 171
		Me.DssLabel41.Text = "-"
		Me.DssLabel41.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel42
		'
		Me.DssLabel42.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel42.DSSElementName = Nothing
		Me.DssLabel42.DSSLocation = 0
		Me.DssLabel42.DSSOffset = 0R
		Me.DssLabel42.Location = New System.Drawing.Point(231, 328)
		Me.DssLabel42.Name = "DssLabel42"
		Me.DssLabel42.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel42.TabIndex = 172
		Me.DssLabel42.Text = "-"
		Me.DssLabel42.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel43
		'
		Me.DssLabel43.AccessibleDescription = ""
		Me.DssLabel43.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel43.DSSElementName = Nothing
		Me.DssLabel43.DSSLocation = 0
		Me.DssLabel43.DSSOffset = 0R
		Me.DssLabel43.Location = New System.Drawing.Point(304, 259)
		Me.DssLabel43.Name = "DssLabel43"
		Me.DssLabel43.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel43.TabIndex = 173
		Me.DssLabel43.Text = "-"
		Me.DssLabel43.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel44
		'
		Me.DssLabel44.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel44.DSSElementName = Nothing
		Me.DssLabel44.DSSLocation = 0
		Me.DssLabel44.DSSOffset = 0R
		Me.DssLabel44.Location = New System.Drawing.Point(264, 259)
		Me.DssLabel44.Name = "DssLabel44"
		Me.DssLabel44.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel44.TabIndex = 174
		Me.DssLabel44.Text = "-"
		Me.DssLabel44.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel45
		'
		Me.DssLabel45.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel45.DSSElementName = Nothing
		Me.DssLabel45.DSSLocation = 0
		Me.DssLabel45.DSSOffset = 0R
		Me.DssLabel45.Location = New System.Drawing.Point(231, 259)
		Me.DssLabel45.Name = "DssLabel45"
		Me.DssLabel45.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel45.TabIndex = 175
		Me.DssLabel45.Text = "-"
		Me.DssLabel45.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel46
		'
		Me.DssLabel46.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel46.DSSElementName = Nothing
		Me.DssLabel46.DSSLocation = 0
		Me.DssLabel46.DSSOffset = 0R
		Me.DssLabel46.Location = New System.Drawing.Point(304, 190)
		Me.DssLabel46.Name = "DssLabel46"
		Me.DssLabel46.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel46.TabIndex = 176
		Me.DssLabel46.Text = "-"
		Me.DssLabel46.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel47
		'
		Me.DssLabel47.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel47.DSSElementName = Nothing
		Me.DssLabel47.DSSLocation = 0
		Me.DssLabel47.DSSOffset = 0R
		Me.DssLabel47.Location = New System.Drawing.Point(264, 190)
		Me.DssLabel47.Name = "DssLabel47"
		Me.DssLabel47.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel47.TabIndex = 177
		Me.DssLabel47.Text = "-"
		Me.DssLabel47.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel48
		'
		Me.DssLabel48.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel48.DSSElementName = Nothing
		Me.DssLabel48.DSSLocation = 0
		Me.DssLabel48.DSSOffset = 0R
		Me.DssLabel48.Location = New System.Drawing.Point(231, 190)
		Me.DssLabel48.Name = "DssLabel48"
		Me.DssLabel48.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel48.TabIndex = 179
		Me.DssLabel48.Text = "-"
		Me.DssLabel48.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel49
		'
		Me.DssLabel49.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel49.DSSElementName = Nothing
		Me.DssLabel49.DSSLocation = 0
		Me.DssLabel49.DSSOffset = 0R
		Me.DssLabel49.Location = New System.Drawing.Point(304, 98)
		Me.DssLabel49.Name = "DssLabel49"
		Me.DssLabel49.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel49.TabIndex = 187
		Me.DssLabel49.Text = "-"
		Me.DssLabel49.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel50
		'
		Me.DssLabel50.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel50.DSSElementName = Nothing
		Me.DssLabel50.DSSLocation = 0
		Me.DssLabel50.DSSOffset = 0R
		Me.DssLabel50.Location = New System.Drawing.Point(264, 98)
		Me.DssLabel50.Name = "DssLabel50"
		Me.DssLabel50.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel50.TabIndex = 180
		Me.DssLabel50.Text = "-"
		Me.DssLabel50.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel51
		'
		Me.DssLabel51.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel51.DSSElementName = Nothing
		Me.DssLabel51.DSSLocation = 0
		Me.DssLabel51.DSSOffset = 0R
		Me.DssLabel51.Location = New System.Drawing.Point(231, 98)
		Me.DssLabel51.Name = "DssLabel51"
		Me.DssLabel51.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel51.TabIndex = 181
		Me.DssLabel51.Text = "-"
		Me.DssLabel51.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel52
		'
		Me.DssLabel52.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel52.DSSElementName = Nothing
		Me.DssLabel52.DSSLocation = 0
		Me.DssLabel52.DSSOffset = 0R
		Me.DssLabel52.Location = New System.Drawing.Point(304, 305)
		Me.DssLabel52.Name = "DssLabel52"
		Me.DssLabel52.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel52.TabIndex = 182
		Me.DssLabel52.Text = "-"
		Me.DssLabel52.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel53
		'
		Me.DssLabel53.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel53.DSSElementName = Nothing
		Me.DssLabel53.DSSLocation = 0
		Me.DssLabel53.DSSOffset = 0R
		Me.DssLabel53.Location = New System.Drawing.Point(264, 305)
		Me.DssLabel53.Name = "DssLabel53"
		Me.DssLabel53.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel53.TabIndex = 183
		Me.DssLabel53.Text = "-"
		Me.DssLabel53.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel54
		'
		Me.DssLabel54.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel54.DSSElementName = Nothing
		Me.DssLabel54.DSSLocation = 0
		Me.DssLabel54.DSSOffset = 0R
		Me.DssLabel54.Location = New System.Drawing.Point(231, 305)
		Me.DssLabel54.Name = "DssLabel54"
		Me.DssLabel54.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel54.TabIndex = 184
		Me.DssLabel54.Text = "-"
		Me.DssLabel54.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel55
		'
		Me.DssLabel55.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel55.DSSElementName = Nothing
		Me.DssLabel55.DSSLocation = 0
		Me.DssLabel55.DSSOffset = 0R
		Me.DssLabel55.Location = New System.Drawing.Point(304, 236)
		Me.DssLabel55.Name = "DssLabel55"
		Me.DssLabel55.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel55.TabIndex = 185
		Me.DssLabel55.Text = "-"
		Me.DssLabel55.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel56
		'
		Me.DssLabel56.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel56.DSSElementName = Nothing
		Me.DssLabel56.DSSLocation = 0
		Me.DssLabel56.DSSOffset = 0R
		Me.DssLabel56.Location = New System.Drawing.Point(264, 236)
		Me.DssLabel56.Name = "DssLabel56"
		Me.DssLabel56.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel56.TabIndex = 186
		Me.DssLabel56.Text = "-"
		Me.DssLabel56.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel57
		'
		Me.DssLabel57.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel57.DSSElementName = Nothing
		Me.DssLabel57.DSSLocation = 0
		Me.DssLabel57.DSSOffset = 0R
		Me.DssLabel57.Location = New System.Drawing.Point(231, 236)
		Me.DssLabel57.Name = "DssLabel57"
		Me.DssLabel57.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel57.TabIndex = 170
		Me.DssLabel57.Text = "-"
		Me.DssLabel57.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel58
		'
		Me.DssLabel58.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel58.DSSElementName = Nothing
		Me.DssLabel58.DSSLocation = 0
		Me.DssLabel58.DSSOffset = 0R
		Me.DssLabel58.Location = New System.Drawing.Point(304, 167)
		Me.DssLabel58.Name = "DssLabel58"
		Me.DssLabel58.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel58.TabIndex = 178
		Me.DssLabel58.Text = "-"
		Me.DssLabel58.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel59
		'
		Me.DssLabel59.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel59.DSSElementName = Nothing
		Me.DssLabel59.DSSLocation = 0
		Me.DssLabel59.DSSOffset = 0R
		Me.DssLabel59.Location = New System.Drawing.Point(264, 167)
		Me.DssLabel59.Name = "DssLabel59"
		Me.DssLabel59.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel59.TabIndex = 169
		Me.DssLabel59.Text = "-"
		Me.DssLabel59.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel60
		'
		Me.DssLabel60.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel60.DSSElementName = Nothing
		Me.DssLabel60.DSSLocation = 0
		Me.DssLabel60.DSSOffset = 0R
		Me.DssLabel60.Location = New System.Drawing.Point(231, 167)
		Me.DssLabel60.Name = "DssLabel60"
		Me.DssLabel60.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel60.TabIndex = 158
		Me.DssLabel60.Text = "-"
		Me.DssLabel60.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel61
		'
		Me.DssLabel61.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel61.DSSElementName = Nothing
		Me.DssLabel61.DSSLocation = 0
		Me.DssLabel61.DSSOffset = 0R
		Me.DssLabel61.Location = New System.Drawing.Point(304, 75)
		Me.DssLabel61.Name = "DssLabel61"
		Me.DssLabel61.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel61.TabIndex = 151
		Me.DssLabel61.Text = "-"
		Me.DssLabel61.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel62
		'
		Me.DssLabel62.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel62.DSSElementName = Nothing
		Me.DssLabel62.DSSLocation = 0
		Me.DssLabel62.DSSOffset = 0R
		Me.DssLabel62.Location = New System.Drawing.Point(264, 75)
		Me.DssLabel62.Name = "DssLabel62"
		Me.DssLabel62.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel62.TabIndex = 152
		Me.DssLabel62.Text = "-"
		Me.DssLabel62.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel63
		'
		Me.DssLabel63.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel63.DSSElementName = Nothing
		Me.DssLabel63.DSSLocation = 0
		Me.DssLabel63.DSSOffset = 0R
		Me.DssLabel63.Location = New System.Drawing.Point(231, 75)
		Me.DssLabel63.Name = "DssLabel63"
		Me.DssLabel63.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel63.TabIndex = 153
		Me.DssLabel63.Text = "-"
		Me.DssLabel63.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel64
		'
		Me.DssLabel64.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel64.DSSElementName = Nothing
		Me.DssLabel64.DSSLocation = 0
		Me.DssLabel64.DSSOffset = 0R
		Me.DssLabel64.Location = New System.Drawing.Point(304, 282)
		Me.DssLabel64.Name = "DssLabel64"
		Me.DssLabel64.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel64.TabIndex = 154
		Me.DssLabel64.Text = "-"
		Me.DssLabel64.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel65
		'
		Me.DssLabel65.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel65.DSSElementName = Nothing
		Me.DssLabel65.DSSLocation = 0
		Me.DssLabel65.DSSOffset = 0R
		Me.DssLabel65.Location = New System.Drawing.Point(264, 282)
		Me.DssLabel65.Name = "DssLabel65"
		Me.DssLabel65.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel65.TabIndex = 155
		Me.DssLabel65.Text = "-"
		Me.DssLabel65.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel66
		'
		Me.DssLabel66.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel66.DSSElementName = Nothing
		Me.DssLabel66.DSSLocation = 0
		Me.DssLabel66.DSSOffset = 0R
		Me.DssLabel66.Location = New System.Drawing.Point(231, 282)
		Me.DssLabel66.Name = "DssLabel66"
		Me.DssLabel66.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel66.TabIndex = 156
		Me.DssLabel66.Text = "-"
		Me.DssLabel66.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel67
		'
		Me.DssLabel67.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel67.DSSElementName = Nothing
		Me.DssLabel67.DSSLocation = 0
		Me.DssLabel67.DSSOffset = 0R
		Me.DssLabel67.Location = New System.Drawing.Point(304, 213)
		Me.DssLabel67.Name = "DssLabel67"
		Me.DssLabel67.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel67.TabIndex = 157
		Me.DssLabel67.Text = "-"
		Me.DssLabel67.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel68
		'
		Me.DssLabel68.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel68.DSSElementName = Nothing
		Me.DssLabel68.DSSLocation = 0
		Me.DssLabel68.DSSOffset = 0R
		Me.DssLabel68.Location = New System.Drawing.Point(264, 213)
		Me.DssLabel68.Name = "DssLabel68"
		Me.DssLabel68.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel68.TabIndex = 159
		Me.DssLabel68.Text = "-"
		Me.DssLabel68.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel69
		'
		Me.DssLabel69.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel69.DSSElementName = Nothing
		Me.DssLabel69.DSSLocation = 0
		Me.DssLabel69.DSSOffset = 0R
		Me.DssLabel69.Location = New System.Drawing.Point(231, 213)
		Me.DssLabel69.Name = "DssLabel69"
		Me.DssLabel69.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel69.TabIndex = 167
		Me.DssLabel69.Text = "-"
		Me.DssLabel69.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel70
		'
		Me.DssLabel70.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel70.DSSElementName = Nothing
		Me.DssLabel70.DSSLocation = 0
		Me.DssLabel70.DSSOffset = 0R
		Me.DssLabel70.Location = New System.Drawing.Point(304, 121)
		Me.DssLabel70.Name = "DssLabel70"
		Me.DssLabel70.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel70.TabIndex = 160
		Me.DssLabel70.Text = "-"
		Me.DssLabel70.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel71
		'
		Me.DssLabel71.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel71.DSSElementName = Nothing
		Me.DssLabel71.DSSLocation = 0
		Me.DssLabel71.DSSOffset = 0R
		Me.DssLabel71.Location = New System.Drawing.Point(264, 121)
		Me.DssLabel71.Name = "DssLabel71"
		Me.DssLabel71.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel71.TabIndex = 161
		Me.DssLabel71.Text = "-"
		Me.DssLabel71.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel72
		'
		Me.DssLabel72.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel72.DSSElementName = Nothing
		Me.DssLabel72.DSSLocation = 0
		Me.DssLabel72.DSSOffset = 0R
		Me.DssLabel72.Location = New System.Drawing.Point(231, 121)
		Me.DssLabel72.Name = "DssLabel72"
		Me.DssLabel72.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel72.TabIndex = 162
		Me.DssLabel72.Text = "-"
		Me.DssLabel72.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel73
		'
		Me.DssLabel73.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel73.DSSElementName = Nothing
		Me.DssLabel73.DSSLocation = 0
		Me.DssLabel73.DSSOffset = 0R
		Me.DssLabel73.Location = New System.Drawing.Point(304, 144)
		Me.DssLabel73.Name = "DssLabel73"
		Me.DssLabel73.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel73.TabIndex = 163
		Me.DssLabel73.Text = "-"
		Me.DssLabel73.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel74
		'
		Me.DssLabel74.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel74.DSSElementName = Nothing
		Me.DssLabel74.DSSLocation = 0
		Me.DssLabel74.DSSOffset = 0R
		Me.DssLabel74.Location = New System.Drawing.Point(264, 144)
		Me.DssLabel74.Name = "DssLabel74"
		Me.DssLabel74.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel74.TabIndex = 164
		Me.DssLabel74.Text = "-"
		Me.DssLabel74.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel75
		'
		Me.DssLabel75.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel75.DSSElementName = Nothing
		Me.DssLabel75.DSSLocation = 0
		Me.DssLabel75.DSSOffset = 0R
		Me.DssLabel75.Location = New System.Drawing.Point(231, 144)
		Me.DssLabel75.Name = "DssLabel75"
		Me.DssLabel75.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel75.TabIndex = 165
		Me.DssLabel75.Text = "-"
		Me.DssLabel75.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel76
		'
		Me.DssLabel76.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel76.DSSElementName = Nothing
		Me.DssLabel76.DSSLocation = 0
		Me.DssLabel76.DSSOffset = 0R
		Me.DssLabel76.Location = New System.Drawing.Point(304, 52)
		Me.DssLabel76.Name = "DssLabel76"
		Me.DssLabel76.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel76.TabIndex = 166
		Me.DssLabel76.Text = "-"
		Me.DssLabel76.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel77
		'
		Me.DssLabel77.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel77.DSSElementName = Nothing
		Me.DssLabel77.DSSLocation = 0
		Me.DssLabel77.DSSOffset = 0R
		Me.DssLabel77.Location = New System.Drawing.Point(264, 52)
		Me.DssLabel77.Name = "DssLabel77"
		Me.DssLabel77.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel77.TabIndex = 168
		Me.DssLabel77.Text = "-"
		Me.DssLabel77.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'DssLabel78
		'
		Me.DssLabel78.DSSElementColor = System.Windows.Media.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte), CType(0, Byte))
		Me.DssLabel78.DSSElementName = Nothing
		Me.DssLabel78.DSSLocation = 0
		Me.DssLabel78.DSSOffset = 0R
		Me.DssLabel78.Location = New System.Drawing.Point(231, 52)
		Me.DssLabel78.Name = "DssLabel78"
		Me.DssLabel78.Size = New System.Drawing.Size(34, 20)
		Me.DssLabel78.TabIndex = 188
		Me.DssLabel78.Text = "-"
		Me.DssLabel78.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Label95
		'
		Me.Label95.Location = New System.Drawing.Point(304, 35)
		Me.Label95.Name = "Label95"
		Me.Label95.Size = New System.Drawing.Size(34, 20)
		Me.Label95.TabIndex = 147
		Me.Label95.Text = "env"
		Me.Label95.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label96
		'
		Me.Label96.Location = New System.Drawing.Point(264, 35)
		Me.Label96.Name = "Label96"
		Me.Label96.Size = New System.Drawing.Size(34, 20)
		Me.Label96.TabIndex = 148
		Me.Label96.Text = "soc"
		Me.Label96.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label97
		'
		Me.Label97.Location = New System.Drawing.Point(231, 35)
		Me.Label97.Name = "Label97"
		Me.Label97.Size = New System.Drawing.Size(34, 20)
		Me.Label97.TabIndex = 149
		Me.Label97.Text = "eco"
		Me.Label97.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label98
		'
		Me.Label98.Location = New System.Drawing.Point(239, 6)
		Me.Label98.Name = "Label98"
		Me.Label98.Size = New System.Drawing.Size(97, 20)
		Me.Label98.TabIndex = 190
		Me.Label98.Text = "Large"
		Me.Label98.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label99
		'
		Me.Label99.Location = New System.Drawing.Point(102, 10)
		Me.Label99.Name = "Label99"
		Me.Label99.Size = New System.Drawing.Size(97, 20)
		Me.Label99.TabIndex = 189
		Me.Label99.Text = "Small"
		Me.Label99.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'frmNegotiation
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(941, 553)
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
		Me.TabControl1.ResumeLayout(False)
		Me.tpaUses.ResumeLayout(False)
		Me.tpaImpacts.ResumeLayout(False)
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
	Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
	Friend WithEvents tpaUses As System.Windows.Forms.TabPage
	Friend WithEvents tpaImpacts As System.Windows.Forms.TabPage
	Friend WithEvents tpaWeights As System.Windows.Forms.TabPage
	Friend WithEvents tpaStandards As System.Windows.Forms.TabPage
	Friend WithEvents tpaEfficencies As System.Windows.Forms.TabPage
	Friend WithEvents Label135 As System.Windows.Forms.Label
	Friend WithEvents Label134 As System.Windows.Forms.Label
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
	Friend WithEvents lblLan1_13 As DSSLabel
	Friend WithEvents lblInd1_13 As DSSLabel
	Friend WithEvents lblAgr1_13 As DSSLabel
	Friend WithEvents lblLan1_10 As DSSLabel
	Friend WithEvents lblInd1_10 As DSSLabel
	Friend WithEvents lblAgr1_10 As DSSLabel
	Friend WithEvents lblLan1_7 As DSSLabel
	Friend WithEvents lblInd1_7 As DSSLabel
	Friend WithEvents lblAgr1_7 As DSSLabel
	Friend WithEvents lblLan1_3 As DSSLabel
	Friend WithEvents lblInd1_3 As DSSLabel
	Friend WithEvents lblAgr1_3 As DSSLabel
	Friend WithEvents lblLan1_12 As DSSLabel
	Friend WithEvents lblInd1_12 As DSSLabel
	Friend WithEvents lblAgr1_12 As DSSLabel
	Friend WithEvents lblLan1_9 As DSSLabel
	Friend WithEvents lblInd1_9 As DSSLabel
	Friend WithEvents lblAgr1_9 As DSSLabel
	Friend WithEvents lblLan1_6 As DSSLabel
	Friend WithEvents lblInd1_6 As DSSLabel
	Friend WithEvents lblAgr1_6 As DSSLabel
	Friend WithEvents lblLan1_2 As DSSLabel
	Friend WithEvents lblInd1_2 As DSSLabel
	Friend WithEvents lblAgr1_2 As DSSLabel
	Friend WithEvents lblLan1_11 As DSSLabel
	Friend WithEvents lblInd1_11 As DSSLabel
	Friend WithEvents lblAgr1_11 As DSSLabel
	Friend WithEvents lblLan1_8 As DSSLabel
	Friend WithEvents lblInd1_8 As DSSLabel
	Friend WithEvents lblAgr1_8 As DSSLabel
	Friend WithEvents lblLan1_4 As DSSLabel
	Friend WithEvents lblInd1_4 As DSSLabel
	Friend WithEvents lblAgr1_4 As DSSLabel
	Friend WithEvents lblLan1_5 As DSSLabel
	Friend WithEvents lblInd1_5 As DSSLabel
	Friend WithEvents lblAgr1_5 As DSSLabel
	Friend WithEvents lblLan1_1 As DSSLabel
	Friend WithEvents lblInd1_1 As DSSLabel
	Friend WithEvents lblAgr1_1 As DSSLabel
	Friend WithEvents lblEnv13_1 As DSSLabel
	Friend WithEvents lblSoc13_1 As DSSLabel
	Friend WithEvents lblEco13_1 As DSSLabel
	Friend WithEvents lblEnv10_1 As DSSLabel
	Friend WithEvents lblSoc10_1 As DSSLabel
	Friend WithEvents lblEco10_1 As DSSLabel
	Friend WithEvents lblEnv1_7 As DSSLabel
	Friend WithEvents lblSoc1_7 As DSSLabel
	Friend WithEvents lblEco1_7 As DSSLabel
	Friend WithEvents lblEnv1_3 As DSSLabel
	Friend WithEvents lblSoc1_3 As DSSLabel
	Friend WithEvents lblEco1_3 As DSSLabel
	Friend WithEvents lblEnv1_12 As DSSLabel
	Friend WithEvents lblSoc1_12 As DSSLabel
	Friend WithEvents lblEco1_12 As DSSLabel
	Friend WithEvents lblEnv1_9 As DSSLabel
	Friend WithEvents lblSoc1_9 As DSSLabel
	Friend WithEvents lblEco1_9 As DSSLabel
	Friend WithEvents lblEnv1_6 As DSSLabel
	Friend WithEvents lblSoc1_6 As DSSLabel
	Friend WithEvents lblEco1_6 As DSSLabel
	Friend WithEvents lblEnv1_2 As DSSLabel
	Friend WithEvents lblSoc1_2 As DSSLabel
	Friend WithEvents lblEco1_2 As DSSLabel
	Friend WithEvents lblEnv1_11 As DSSLabel
	Friend WithEvents lblSoc1_11 As DSSLabel
	Friend WithEvents lblEco1_11 As DSSLabel
	Friend WithEvents lblEnv1_8 As DSSLabel
	Friend WithEvents lblSoc1_8 As DSSLabel
	Friend WithEvents lblEco1_8 As DSSLabel
	Friend WithEvents lblEnv1_4 As DSSLabel
	Friend WithEvents lblSoc1_4 As DSSLabel
	Friend WithEvents lblEco1_4 As DSSLabel
	Friend WithEvents lblEnv1_5 As DSSLabel
	Friend WithEvents lblSoc1_5 As DSSLabel
	Friend WithEvents lblEco1_5 As DSSLabel
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
	Friend WithEvents DssLabel1 As DSSLabel
	Friend WithEvents DssLabel2 As DSSLabel
	Friend WithEvents DssLabel3 As DSSLabel
	Friend WithEvents DssLabel4 As DSSLabel
	Friend WithEvents DssLabel5 As DSSLabel
	Friend WithEvents DssLabel6 As DSSLabel
	Friend WithEvents DssLabel7 As DSSLabel
	Friend WithEvents DssLabel8 As DSSLabel
	Friend WithEvents DssLabel9 As DSSLabel
	Friend WithEvents DssLabel10 As DSSLabel
	Friend WithEvents DssLabel11 As DSSLabel
	Friend WithEvents DssLabel12 As DSSLabel
	Friend WithEvents DssLabel13 As DSSLabel
	Friend WithEvents DssLabel14 As DSSLabel
	Friend WithEvents DssLabel15 As DSSLabel
	Friend WithEvents DssLabel16 As DSSLabel
	Friend WithEvents DssLabel17 As DSSLabel
	Friend WithEvents DssLabel18 As DSSLabel
	Friend WithEvents DssLabel19 As DSSLabel
	Friend WithEvents DssLabel20 As DSSLabel
	Friend WithEvents DssLabel21 As DSSLabel
	Friend WithEvents DssLabel22 As DSSLabel
	Friend WithEvents DssLabel23 As DSSLabel
	Friend WithEvents DssLabel24 As DSSLabel
	Friend WithEvents DssLabel25 As DSSLabel
	Friend WithEvents DssLabel26 As DSSLabel
	Friend WithEvents DssLabel27 As DSSLabel
	Friend WithEvents DssLabel28 As DSSLabel
	Friend WithEvents DssLabel29 As DSSLabel
	Friend WithEvents DssLabel30 As DSSLabel
	Friend WithEvents DssLabel31 As DSSLabel
	Friend WithEvents DssLabel32 As DSSLabel
	Friend WithEvents DssLabel33 As DSSLabel
	Friend WithEvents DssLabel34 As DSSLabel
	Friend WithEvents DssLabel35 As DSSLabel
	Friend WithEvents DssLabel36 As DSSLabel
	Friend WithEvents DssLabel37 As DSSLabel
	Friend WithEvents DssLabel38 As DSSLabel
	Friend WithEvents DssLabel39 As DSSLabel
	Friend WithEvents Label87 As Label
	Friend WithEvents Label89 As Label
	Friend WithEvents Label90 As Label
	Friend WithEvents Label98 As Label
	Friend WithEvents Label99 As Label
	Friend WithEvents DssLabel40 As DSSLabel
	Friend WithEvents DssLabel41 As DSSLabel
	Friend WithEvents DssLabel42 As DSSLabel
	Friend WithEvents DssLabel43 As DSSLabel
	Friend WithEvents DssLabel44 As DSSLabel
	Friend WithEvents DssLabel45 As DSSLabel
	Friend WithEvents DssLabel46 As DSSLabel
	Friend WithEvents DssLabel47 As DSSLabel
	Friend WithEvents DssLabel48 As DSSLabel
	Friend WithEvents DssLabel49 As DSSLabel
	Friend WithEvents DssLabel50 As DSSLabel
	Friend WithEvents DssLabel51 As DSSLabel
	Friend WithEvents DssLabel52 As DSSLabel
	Friend WithEvents DssLabel53 As DSSLabel
	Friend WithEvents DssLabel54 As DSSLabel
	Friend WithEvents DssLabel55 As DSSLabel
	Friend WithEvents DssLabel56 As DSSLabel
	Friend WithEvents DssLabel57 As DSSLabel
	Friend WithEvents DssLabel58 As DSSLabel
	Friend WithEvents DssLabel59 As DSSLabel
	Friend WithEvents DssLabel60 As DSSLabel
	Friend WithEvents DssLabel61 As DSSLabel
	Friend WithEvents DssLabel62 As DSSLabel
	Friend WithEvents DssLabel63 As DSSLabel
	Friend WithEvents DssLabel64 As DSSLabel
	Friend WithEvents DssLabel65 As DSSLabel
	Friend WithEvents DssLabel66 As DSSLabel
	Friend WithEvents DssLabel67 As DSSLabel
	Friend WithEvents DssLabel68 As DSSLabel
	Friend WithEvents DssLabel69 As DSSLabel
	Friend WithEvents DssLabel70 As DSSLabel
	Friend WithEvents DssLabel71 As DSSLabel
	Friend WithEvents DssLabel72 As DSSLabel
	Friend WithEvents DssLabel73 As DSSLabel
	Friend WithEvents DssLabel74 As DSSLabel
	Friend WithEvents DssLabel75 As DSSLabel
	Friend WithEvents DssLabel76 As DSSLabel
	Friend WithEvents DssLabel77 As DSSLabel
	Friend WithEvents DssLabel78 As DSSLabel
	Friend WithEvents Label95 As Label
	Friend WithEvents Label96 As Label
	Friend WithEvents Label97 As Label
End Class
