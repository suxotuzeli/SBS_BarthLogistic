using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SBS_Market.AEDForms;
using SBS_Market.Classes;
using SBS_Market.OtherForms;
using SBS_Market.Parameters;
using SBS_Market.PrintForms;
using SBS_Market.Tools;
using SBS_Market.WayBill;
using Syncfusion.Windows.Forms.Tools;


namespace SBS_Market {
    public partial class Form1 : Form {

        CompanyForm fmCompany;

        RegistrationForm fmRegistration;
        AEDForm fmAED;
        AEDWithComboForm fmAEDWithCombo;
        AEDWithCheckForm fmAEDWithCheck;
        ProdForm fmProd;
        CalcForm fmCalc;
        MdzForm fmMdz;
        Real1Form fmReal1;
        Shes1Form fmShes1;
        XGasForm fmXGas;
        GadForm fmGad;
        SalForm fmSal;
        MDabr1Form fmMDabr1;
        XModzForm fmXModz;
        XShemForm fmXShem;
        ZeddAutoForm fmZeddAuto;
        Shem1Form fmShem1;
        Gas1Form fmGas1;
        Modz1Form fmModz1;
        Agcera1Form fmAgcera1;
        Carm1Form fmCarm1;
        MailForm fmMail;
        MomcForm fmMomc;
        GvariForm fmGvari;
        ProekTForm fmProekT;
        ProekForm fmProek;
        UsersForm fmUsers;
        SalaroForm fmSalaro;
        Gadadeba1Form fmGadadeba1;
        MomcShek1Form fmMomcShek1;

        prnSalaroBaratiForm fmSalaroBarati;
        prnNashtiForm fmprnNashti;
        prnSalaroNashtiForm fmprnSalaroNashti;
        prnFNashtiForm fmprnFNashti;
        prnMValiForm fmprnMVali;
        prnValiForm fmprnVali;
        prnMogebaProdForm fmprnMogebaProd;
        prnMogebaGvariForm fmprnMogebaGvari;
        ReportCustomizerForm fmReportCustomizer;
        prnTBForm fmprnTB;
        prnMTBForm fmprnMTB;
        prnProdBaratiForm fmprnProdBarati;
        prnSalaroBrunvaByHourForm fmprnSalaroBrunvaByHour;
        prnShemGasShedarebaForm fmprnShemGasShedareba;

        private Timer timer;

        public Form1()
        {
            InitializeComponent();
        }
        #region ToolsForms
        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miAddUser_Click(object sender, EventArgs e)
        {
            if (!isUserSa())
                return;
            AddUserForm fmAddUser = new AddUserForm();
            fmAddUser.ShowDialog();
            fmAddUser.Dispose();
        }


        private void miEditUser_Click(object sender, EventArgs e)
        {
//            if (!isUserSa())
//                return;
            EditUserForm fmEditUser = new EditUserForm();
            fmEditUser.ShowDialog();
            fmEditUser.Dispose();
        }

        private void miDelUser_Click(object sender, EventArgs e)
        {
            if (!isUserSa())
                return;
            DelUserForm fmDelUser = new DelUserForm();
            fmDelUser.ShowDialog();
            fmDelUser.Dispose();

        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            AboutForm fmAbout = new AboutForm();
            fmAbout.ShowDialog();
            fmAbout.Dispose();
        }

        private static bool isUserSa()
        {
            string un = ManagementParameters.UserName.Length > 2
                            ? ManagementParameters.UserName.Substring(0, 3)
                            : ManagementParameters.UserName + "_";

            if (un!= "sa_") {
                MessageBox.Show("თქვენ აღნიშნული ოპერაციის ჩატარების უფლება არა გაქვთ", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void miDaxurva_Click(object sender, EventArgs e)
        {
            DaxurvaForm fmDaxurva = new DaxurvaForm();
            fmDaxurva.ShowDialog();
            fmDaxurva.Dispose();
            laDge.Text = ProceduresClass.spSetDge();
        }

        private void miGaxsna_Click(object sender, EventArgs e)
        {
            GaxsnaForm fmGaxsna = new GaxsnaForm();
            fmGaxsna.ShowDialog();
            fmGaxsna.Dispose();
            laDge.Text = ProceduresClass.spSetDge();
        }

        private void miParams_Click(object sender, EventArgs e)
        {
            AddParamsForm fmAddParams = new AddParamsForm();
            fmAddParams.ShowDialog();
            fmAddParams.Dispose();

            SetSQLBasedParameters();
        }

        private void miUserPermission_Click(object sender, EventArgs e)
        {
            if (!isUserSa())
                return;
            SetUserPermissionsForm fmSetUserPermissions = new SetUserPermissionsForm();
            fmSetUserPermissions.ShowDialog();
            fmSetUserPermissions.Dispose();
//            SetTablePermissions();
        }

        private void ShowMIItems()
        {
            DataTable dt = SQL.Select("SELECT * FROM MIView WHERE UN = N'" + ManagementParameters.UserName + "'");
            for(int i = 0; i < dt.Rows.Count;i++) {
                if(!Convert.ToBoolean(dt.Rows[i]["CanView"].ToString())) {
                    ReturnMenuItem(dt.Rows[i]["MIName"].ToString());
                }
            }
        }
        private void ReturnMenuItem(string itemName)
        {
            string[] s = ParamClass.SplitString(itemName, ';');
            
            foreach (string t in s){
                HideMenuButton(t);
            }
        }

        private void HideMenuButton(string s)
        {
            if (miSystem.DropDownItems[s] != null)
                miSystem.DropDownItems[s].Visible = false;
            if (miInput.DropDownItems[s] != null)
                miInput.DropDownItems[s].Visible = false;
            if (miPrint.DropDownItems[s] != null)
                miPrint.DropDownItems[s].Visible = false;
            if (miCnobari.DropDownItems[s] != null)
                miCnobari.DropDownItems[s].Visible = false;

            if (toolStrip1.Items[s] != null)
                toolStrip1.Items[s].Visible = false;
        }


        #endregion ToolsForms

        private void Form1_Load(object sender, EventArgs e)
        {

            const string path = @"Params.ini";
            string serverName = "";
            string connectionTimeout = "";
            if (File.Exists(path)) {
                using (StreamReader sr = File.OpenText(path)) {
                    serverName = ParamClass.ReturnParam(sr.ReadLine());
                    connectionTimeout = ParamClass.ReturnParam(sr.ReadLine());
                    ManagementParameters.UserName = ParamClass.ReturnParam(sr.ReadLine());
                    ManagementParameters.DatabaseName = ParamClass.ReturnParam(sr.ReadLine());

                    InterfaceParameters.setFont = true;
                    InterfaceParameters.FontName = ParamClass.ReturnParam(sr.ReadLine());
                    InterfaceParameters.FontSize = float.Parse(ParamClass.ReturnParam(sr.ReadLine()));

                    InterfaceParameters.ReportsFolder = ParamClass.ReturnParam(sr.ReadLine());
                    InterfaceParameters.MonacemebiFolder = ParamClass.ReturnParam(sr.ReadLine());
                    InterfaceParameters.MailFolder = ParamClass.ReturnParam(sr.ReadLine());
                    InterfaceParameters.XMLFolder = ParamClass.ReturnParam(sr.ReadLine());
                    InterfaceParameters.PicturesFolder = ParamClass.ReturnParam(sr.ReadLine());
                    InterfaceParameters.DateFormat = ParamClass.ReturnParam(sr.ReadLine());
                    InterfaceParameters.PivotTableMaxRowCount = Convert.ToInt32(ParamClass.ReturnParam(sr.ReadLine()));
                }
            }

            fmRegistration = new RegistrationForm(ManagementParameters.UserName);
            if (fmRegistration.ShowDialog() == DialogResult.OK) {
                try {
                    ManagementParameters.UserName = fmRegistration.User;
                    ManagementParameters.ConnStr = "Data Source=" + serverName + ";Initial Catalog=" + ManagementParameters.DatabaseName + ";Persist Security Info=True;User ID=" + fmRegistration.User + ";Password=" + fmRegistration.Pass + ";Connection Timeout=" + connectionTimeout + ";";
                    ManagementParameters.cn = new SqlConnection(ManagementParameters.ConnStr);
                    ManagementParameters.cn.Open();
                    ManagementParameters.cn.Close();
                    SetSQLBasedParameters();
                    ShowMIItems();
                    laDge.Text = ProceduresClass.spSetDge();
//                    using (DataTable dtBonusProcName = SQL.Select("SELECT * FROM BonusProcName")) {
//                        if (dtBonusProcName.Rows.Count > 0) {
//                            miCalcBonus.Visible = true;
//                            ParamClass.BonusProcName = dtBonusProcName.Rows[0]["BonusProcName"].ToString();
//                            miCalcBonus.Text = dtBonusProcName.Rows[0]["MenuCaption"].ToString();
//                        }
//                    }
                    CLSCustomCnobari cc = new CLSCustomCnobari();
                    cc.SetTexts(miMProd);
                }
                catch (Exception ex) {
                    string loginfail=ex.ToString();
                    if (loginfail.Contains(": Login failed for user")) {
                        if (MessageBox.Show("მომხმარებელი ან პაროლი არასწორია. \n\r გავიაროთ ავტორიზაცია თავიდან?", "შეცდომა", MessageBoxButtons.OKCancel,
                                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                        {
                            Form1_Load(sender, e);
                            return;
                        }
                    }
                    else {
                        if (
                            MessageBox.Show("ვერ მოხერხდა ბაზასთან დაკავშირება, გამოვიტანოთ სისტემური შ ეტყობინება?",
                                            "შეცდომა", MessageBoxButtons.OKCancel, MessageBoxIcon.Error,
                                            MessageBoxDefaultButton.Button2) == DialogResult.OK)
                            MessageBox.Show(loginfail);
                    }
                    Close();
               }
            }
            else {
                Close();
            }
           
            
        }

        private void TimerTick(object sender, EventArgs e)
        {

        }

        private void SetSQLBasedParameters()
        {
            DataRow dr = SQL.FillParams(ManagementParameters.UserName);

            InterfaceParameters.TimerInterval = Convert.ToInt16(dr["TimerInterval"].ToString());

            timer = new Timer();
            if (InterfaceParameters.TimerInterval > 0) {
                timer.Interval = InterfaceParameters.TimerInterval * 60 * 1000;
                timer.Tick += TimerTick;
                timer.Enabled = true;
            }
            else
                timer.Enabled = false;

            OrgProdParameters.GvariSearchSymbolCount = Convert.ToInt16(dr["GvariSearchSymbolCount"].ToString());
            OrgProdParameters.GvariSearchFromFirstSymbol = Convert.ToBoolean(dr["GvariSearchType"].ToString());
            OrgProdParameters.GvariSortByCode = Convert.ToBoolean(dr["GvariSortByCode"].ToString());
            OrgProdParameters.GvariCodeInput = Convert.ToBoolean(dr["GvariCodeInput"].ToString());
            OrgProdParameters.GvariIncrement = Convert.ToInt16(dr["GvariIncrement"].ToString());

            OrgProdParameters.ProdSearchSymbolCount = Convert.ToInt16(dr["ProdSearchSymbolCount"].ToString());
            OrgProdParameters.ProdSearchFromFirstSymbol = Convert.ToBoolean(dr["ProdSearchType"].ToString());
            OrgProdParameters.ProdSearchInCode = Convert.ToBoolean(dr["ProdSearchInCode"].ToString());
            OrgProdParameters.ProdSortByCode = Convert.ToBoolean(dr["ProdSortByCode"].ToString());
            OrgProdParameters.ProdCodeInput = Convert.ToBoolean(dr["ProdCodeInput"].ToString());
            OrgProdParameters.ProdMomcFilter = Convert.ToBoolean(dr["ProdMomcFilter"].ToString());
            OrgProdParameters.ProdIncrement = Convert.ToInt16(dr["ProdIncrement"].ToString());
            OrgProdParameters.WayBillClientCanUpdate = Convert.ToBoolean(dr["WayBillClientCanUpdate"].ToString());
            OrgProdParameters.UpdateProdMomcPrice = Convert.ToBoolean(dr["UpdateProdMomcPrice"].ToString());

            ManagementParameters.chbZeddDaxurvaShes = Convert.ToBoolean(dr["ZeddDaxurvaShes"].ToString());


            InterfaceParameters.cbSaangPeriodi = Convert.ToBoolean(dr["cbSaangPeriodi"].ToString());
            ManagementParameters.cbBScan = Convert.ToBoolean(dr["cbBScan"].ToString());
            ManagementParameters.ShowShesTvitg = Convert.ToBoolean(dr["ShowShesTvitg"].ToString());
            InterfaceParameters.D1 = Convert.ToDateTime(dr["debData1"].ToString());
            InterfaceParameters.D2 = Convert.ToDateTime(dr["debData2"].ToString());
            InterfaceParameters.DefaultPeriodIndex = Convert.ToInt32(dr["DefaultPeriodIndex"].ToString());
            InterfaceParameters.RestoreDataGridSettings = Convert.ToBoolean(dr["RestoreDGSettings"].ToString());
            ManagementParameters.GascorebaDge = Convert.ToInt32(dr["GascorebaDge"].ToString());
            ManagementParameters.GascorebaSxva = Convert.ToBoolean(dr["GascorebaSxva"].ToString());
//            ParamClass.TableInput = Convert.ToBoolean(dr["TableInput"].ToString());
            ManagementParameters.CloseMinus = Convert.ToBoolean(dr["CloseMinus"].ToString());
            ManagementParameters.DeniedAfterClose = Convert.ToBoolean(dr["DeniedAfterClose"].ToString());
            ManagementParameters.CheckNashti = Convert.ToBoolean(dr["CheckNashti"].ToString());
            ManagementParameters.ShowTvitg = Convert.ToBoolean(dr["ShowTvitg"].ToString());
            InterfaceParameters.GroupAgceraByIdProd = Convert.ToBoolean(dr["GroupAgceraByIdProd"].ToString());
            PrintParameters.SasZeddAllInDanarti = Convert.ToBoolean(dr["SasZeddAllInDanarti"].ToString());
            ManagementParameters.ShowCompanyName = Convert.ToBoolean(dr["ShowCompanyName"].ToString());
            ManagementParameters.SearchbyHours = Convert.ToBoolean(dr["chbSearchByHours"].ToString());
            OrgProdParameters.ShowProdPicture = Convert.ToBoolean(dr["ShowProdPicture"].ToString());
            OrgProdParameters.PictureMaxRaod = Convert.ToInt16(dr["PictureMaxRaod"].ToString());
           
            OrgProdParameters.IdProd = "";

            if (Convert.ToBoolean(dr["TabledMDI"].ToString())) {
                tabbedMDIManager1.AttachedTo = this;
                miWindows.Visible = false;
            }
            else {
                tabbedMDIManager1.AttachedTo = null;
                miWindows.Visible = true;
            }
           
            miExportSeveralTables.Visible = Convert.ToBoolean(dr["ShowInfoItem"].ToString());
            miSQLExecute.Visible = Convert.ToBoolean(dr["SQLExecute"].ToString());


//            PrintParameters.cbColumnAutoFit = Convert.ToBoolean(dr["cbColumnAutoFit"].ToString());
//            PrintParameters.cbFreezePanes = Convert.ToBoolean(dr["cbFreezePanes"].ToString());
//            ParamClass.FreezeColumnCount = Convert.ToInt16(dr["FreezeColumnCount"].ToString());
            PrintParameters.SasZeddCopies = Convert.ToInt16(dr["SasZeddCopies"].ToString());
            PrintParameters.FacturaRowCount = Convert.ToInt16(dr["FacturaRowCount"].ToString());
            PrintParameters.ZeddRowCount = Convert.ToInt16(dr["ZeddRowCount"].ToString());


            DefaultValues.cbTabVisualStyle = Convert.ToInt16(dr["cbTabVisualStyle"].ToString());
            DefaultValues.IdRealT = Convert.ToInt16(dr["IdRealT"].ToString());
            DefaultValues.IdProek = Convert.ToInt16(dr["IdProek"].ToString());
            DefaultValues.IdSalaro = Convert.ToInt16(dr["IdSalaro"].ToString());
            DefaultValues.IdShemT = Convert.ToInt16(dr["IdShemT"].ToString());
            DefaultValues.IdGasT = Convert.ToInt16(dr["IdGasT"].ToString());
            DefaultValues.IdShesT = Convert.ToInt16(dr["IdShesT"].ToString());
            DefaultValues.IdGadT = Convert.ToInt16(dr["IdGadT"].ToString());
            DefaultValues.IdModzT = Convert.ToInt16(dr["IdModzT"].ToString());
            DefaultValues.IdSalT = Convert.ToInt16(dr["IdSalT"].ToString());
            DefaultValues.IdTanam = Convert.ToInt16(dr["IdTanam"].ToString());
            DefaultValues.IdCarmT = Convert.ToInt16(dr["IdCarmT"].ToString());
            DefaultValues.IdDggStatus = Convert.ToInt16(dr["IDDggStatus"].ToString());

            DefaultValues.chbRealT = Convert.ToBoolean(dr["chbRealT"].ToString());
            DefaultValues.chbProek = Convert.ToBoolean(dr["chbProek"].ToString());
            DefaultValues.chbSalaro = Convert.ToBoolean(dr["chbSalaro"].ToString());
            DefaultValues.chbShemT = Convert.ToBoolean(dr["chbShemT"].ToString());
            DefaultValues.chbGasT = Convert.ToBoolean(dr["chbGasT"].ToString());
            DefaultValues.chbShesT = Convert.ToBoolean(dr["chbShesT"].ToString());
            DefaultValues.chbSalT = Convert.ToBoolean(dr["chbSalT"].ToString());
            DefaultValues.chbGadT = Convert.ToBoolean(dr["chbGadT"].ToString());
            DefaultValues.chbCarmT = Convert.ToBoolean(dr["chbCarmT"].ToString());
            DefaultValues.chbModzT = Convert.ToBoolean(dr["chbModzT"].ToString());

            WayBillParameters.CanEditClosedZedd = Convert.ToBoolean(dr["WayBillCanEditClosedZedd"].ToString());
            WayBillParameters.ShowInColors = Convert.ToBoolean(dr["WayBillShowInColors"].ToString());
            WayBillParameters.CanSendFactura = Convert.ToBoolean(dr["WayBillCanSendFactura"].ToString());
            WayBillParameters.TransGamkidveli = Convert.ToBoolean(dr["WayBillTransGamkidveli"].ToString());
            WayBillParameters.IdTransTypes = dr["WayBillIdTransTypes"].ToString();
            WayBillParameters.TransTypes = dr["WayBillTransTypes"].ToString();

            Company.id = Convert.ToInt16(dr["IdCompany"].ToString());
            DataTable dt = SQL.Select("SELECT TOP 1 * FROM Company WHERE IdCompany = " + Company.id);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("კომპანიის რეკვიზიტები არაა განსაზღვრული");
            }
            else
            {
                Company.Name = dt.Rows[0]["CompanyName"].ToString();
                Company.ip = dt.Rows[0]["CompanyIP"].ToString();
                Company.su = dt.Rows[0]["ServiceUser"].ToString();
                Company.sp = dt.Rows[0]["ServicePassword"].ToString();
                Company.Address = dt.Rows[0]["CompanyAddress"].ToString();
                Company.Contact = dt.Rows[0]["CompanyContact"].ToString();
                Company.Direk = dt.Rows[0]["CompanyDirek"].ToString();
                Company.NebaDarto = dt.Rows[0]["CompanyNebaDarto"].ToString();
                Company.Mail = dt.Rows[0]["CompanyMail"].ToString();
                Company.Sagad = dt.Rows[0]["CompanySagad"].ToString();
                Company.Shen = dt.Rows[0]["CompanyShen"].ToString();
                CheckServiceUser(false);
            }

            if (ManagementParameters.ShowCompanyName)
                Text = "FMG გაყიდვები - " + Company.Name;
            else
                Text = "FMG გაყიდვები";
             switch (DefaultValues.cbTabVisualStyle)
            {
                case 1:
                    tabbedMDIManager1.TabStyle = typeof(TabRenderer2D);
                    break;
                case 2:
                    tabbedMDIManager1.TabStyle = typeof(TabRenderer3D);
                    break;
                case 3:
                    tabbedMDIManager1.TabStyle = typeof(TabRendererWorkbookMode);
                    break;
                case 4:
                    tabbedMDIManager1.TabStyle = typeof(TabRendererIE7);
                    break;
                case 5:
                    tabbedMDIManager1.TabStyle = typeof(TabRendererOffice2003);
                    break;
                case 6:
                    tabbedMDIManager1.TabStyle = typeof(TabRendererOffice2007);
                    break;
                case 7:
                    tabbedMDIManager1.TabStyle = typeof(TabRendererWhidbey);
                    break;
                case 8:
                    tabbedMDIManager1.TabStyle = typeof(TabRendererDockingWhidbeyBeta);
                    break;
                default:
                    tabbedMDIManager1.TabStyle = typeof(OneNoteStyleRenderer);
                    break;
            }

        }

        private void ShowAEDCheckForm(string tableName, string fieldName, string fieldNameCheck, string fieldCaptionCheck)
        {
            bool bOpen = false;
            foreach (Form f in MdiChildren)
                if (f.Text == fieldName)
                    bOpen = true;

            if (!bOpen) {
                fmAEDWithCheck = new AEDWithCheckForm(tableName, fieldName, fieldNameCheck, fieldCaptionCheck)
                                     {MdiParent = this};
            }
            fmAEDWithCheck.Show();
            fmAEDWithCheck.Activate();
        }

        private void ShowAEDCheckForm(string tableName, string fieldName, string fieldNameCheck, string fieldCaptionCheck, string fieldNameCheck1, string fieldCaptionCheck1)
        {
            bool bOpen = false;
            foreach (Form f in MdiChildren)
                if (f.Text == fieldName)
                    bOpen = true;

            if (!bOpen)
            {
                fmAEDWithCheck = new AEDWithCheckForm(tableName, fieldName, fieldNameCheck, fieldCaptionCheck,fieldNameCheck1, fieldCaptionCheck1) { MdiParent = this };
            }
            fmAEDWithCheck.Show();
            fmAEDWithCheck.Activate();
        }

        private void ShowAEDForm(string tableName, string fieldName, string tableNameCombo, string fieldNameCombo)
        {
            bool bOpen = false;
            foreach (Form f in MdiChildren)
                if (f.Text == fieldName)
                    bOpen = true;

            if (!bOpen)
            {
                fmAEDWithCombo = new AEDWithComboForm(tableName, fieldName, tableNameCombo, fieldNameCombo) { MdiParent = this };
            }
            fmAEDWithCombo.Show();
            fmAEDWithCombo.Activate();
        }
        private void miProdS_Click(object sender, EventArgs e)
        {
            switch (sender.ToString()) {
                case "პროდუქციის ტიპი": ShowAEDForm("ProdT", sender.ToString(), "ProdTG", "პროდუქციის ტიპის ჯგუფი"); break;
                case "თანამშრომელი": ShowAEDForm("Tanam", sender.ToString(), "Gank", "განყოფილება"); break;
                case "თანხის შემოსავლის ტიპი": ShowAEDCheckForm("XShemT", sender.ToString(), "isMogeba", "ერიცხება მოგებას?"); break;
                case "თანხის გასავლის ტიპი": ShowAEDCheckForm("XGasT", sender.ToString(), "isMogeba", "გადის მოგებიდან?"); break;
                case "რეალიზაციის ტიპი": ShowAEDCheckForm("RealT", sender.ToString(), "IsVali", "გაიზარდოს არსებული ვალი?"); break;
                case "ხარჯის ტიპი": ShowAEDCheckForm("XarjiT", sender.ToString(), "GadanacilebaTrans", "გადანაწილდეს წონის მიხედვით?"); break;
                case "შესყიდვის ტიპი": ShowAEDCheckForm("ShesT", sender.ToString(), "IsVali", "გაიზარდოს არსებული ვალი?"); break;
                case "ვალუტა": ShowAEDCheckForm("Valuta", sender.ToString(), "isMain", "მთავარი ვალუტა?"); break;
                case "სალარო": ShowAEDCheckForm("Salaro", sender.ToString(), "IsFiskaluri", "სჭირდება ჩეკის დაბეჭდვა?"); break;
                case "პროდუქციის ჯგუფი": ShowAEDCheckForm("ProdG", sender.ToString(), "SacControl", "გაკონტროლდეს ნაშთი?", "ShowTouch","გამოჩნდეს სწრაფ გაყიდვებში?"); break;
            }
        }

        private void miAED_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
                InterfaceParameters.TableName = (sender as ToolStripMenuItem).Name.Remove(0, 2);
            else {
                InterfaceParameters.TableName = ((ToolStripButton) sender).Name.Remove(0, 3);
            }

            InterfaceParameters.FieldName = sender.ToString();
            CreateForm(ref fmAED);

        }

        private void mi_Click(object sender, EventArgs e)
        {
            string controlName;
            if (sender is ToolStripMenuItem)
                controlName = (sender as ToolStripMenuItem).Name.Remove(0, 2);
            else {
                controlName = ((ToolStripButton)sender).Name.Remove(0, 3);
            }

            InterfaceParameters.TableName = controlName;
            InterfaceParameters.FieldName = sender.ToString();

            // ReSharper disable CSharpWarnings::CS0197
            switch (controlName)
            {
                case "ZeddAuto": CreateForm(ref fmZeddAuto); break;
                case "Real1": CreateForm(ref fmReal1); break;
                case "Shes1": CreateForm(ref fmShes1); break;
                case "Shem1": CreateForm(ref fmShem1); break;
                case "Gas1": CreateForm(ref fmGas1); break;
                case "Gadadeba1": CreateForm(ref fmGadadeba1); break;
                case "Modz1": CreateForm(ref fmModz1); break;
                case "XModz": CreateForm(ref fmXModz); break;
                case "XShem": CreateForm(ref fmXShem); break;
                case "XGas": CreateForm(ref fmXGas); break;
                case "MDabr1": CreateForm(ref fmMDabr1); break;
                case "Gad": CreateForm(ref fmGad); break;
                case "Sal": CreateForm(ref fmSal); break;
                case "Users": CreateForm(ref fmUsers); break;
                case "Agcera1": CreateForm(ref fmAgcera1); break;
                case "Carm1": CreateForm(ref fmCarm1); break;
                case "Prod": CreateForm(ref fmProd); break;
                case "Calc": CreateForm(ref fmCalc); break;
                case "Mdz": CreateForm(ref fmMdz); break;
                case "Momc": CreateForm(ref fmMomc); break;
                case "Gvari": CreateForm(ref fmGvari); break;
                case "ProekT": CreateForm(ref fmProekT); break;
                case "Proek": CreateForm(ref fmProek); break;
                case "Salaro": CreateForm(ref fmSalaro); break;
                case "Mail": CreateForm(ref fmMail); break;
                case "Company": CreateForm(ref fmCompany); break;

                case "Nashti": CreateForm(ref fmprnNashti); break;
                case "MogebaProd": CreateForm(ref fmprnMogebaProd); break;
                case "FNashti": CreateForm(ref fmprnFNashti); break;
                case "SalaroNashti": CreateForm(ref fmprnSalaroNashti); break;
                case "MVali": CreateForm(ref fmprnMVali); break;
                case "Vali": CreateForm(ref fmprnVali); break;
                case "MTB": CreateForm(ref fmprnMTB); break;
                case "TB": CreateForm(ref fmprnTB); break;
                case "MogebaGvari": CreateForm(ref fmprnMogebaGvari); break;
                case "ProdBarati": CreateForm(ref fmprnProdBarati); break;
                case "SalaroBrunvaByHour": CreateForm(ref fmprnSalaroBrunvaByHour); break;
                case "ShemGasShedareba": CreateForm(ref fmprnShemGasShedareba); break;
                case "SalaroBarati": CreateForm(ref fmSalaroBarati); break;

                case "ReportCustomizer": CreateForm(ref fmReportCustomizer); break;
                case "MomcShek1": CreateForm(ref fmMomcShek1); break;
                // ReSharper restore CSharpWarnings::CS0197
            }
        }

        private void CreateForm<T>(ref T frm) where T : Form, new()
        {
            bool bOpen = false;
            foreach (Form f in MdiChildren) {
                if (f.Text == InterfaceParameters.FieldName)
                    bOpen = true;
            }
            if (!bOpen) {
                frm = new T {MdiParent = this};
            }
            frm.Show();
            frm.Activate();
        }

        private void miRestore_Click(object sender, EventArgs e)
        {
            using (RestoreForm fmRestore = new RestoreForm()){
                fmRestore.ShowDialog();
                fmRestore.Dispose();
            }
        }

        private void miSQLExecute_Click(object sender, EventArgs e)
        {
            using (SQLExecute fmSQLExecute = new SQLExecute()) {
                fmSQLExecute.ShowDialog();
            }
        }

        private void miExportSeveralTables_Click(object sender, EventArgs e)
        {
            using (ExportSeveralTablesToExcelForm fmExportToInfo = new ExportSeveralTablesToExcelForm()) {
                fmExportToInfo.ShowDialog();
            }

        }
        private void miConnectToSite_Click(object sender, EventArgs e)
        {
            CheckServiceUser(true);
        }
        private static void CheckServiceUser(bool showConnectResult)
        {
            try
            {
                CLSWayBillOperation wayBill = new CLSWayBillOperation();
                if (wayBill.CheckServiceUser()) {
                    if (showConnectResult)
                        MessageBox.Show("კავშირი დამყარებულია");
                }
                else {
                    MessageBox.Show("ვერ მოხერხდა სისტემასთან კავშირი, შეამოწმეთ მომხმარებელი და პაროლი");
                }
            }
            catch
            {
                MessageBox.Show("ვერ მოხერხდა საგადასახადოს საიტთან დაკავშირება");
            }
        }

        private void miRSInformation_Click(object sender, EventArgs e)
        {
            using (RSInformationForm fm = new RSInformationForm()) {
                fm.ShowDialog();
            }
        }

        private void tabbedMDIManager1_TabControlAdded(object sender, Syncfusion.Windows.Forms.Tools.TabbedMDITabControlEventArgs args)
        {
            args.TabControl.ActiveTabFont = new Font("Sylfaen", 11);
            args.TabControl.Font = new Font("Sylfaen", 10); 
        }

      
    
    }
}