using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.AEDForms;
using SBS_BarthLogistic.InterfaceForms;
using SBS_BarthLogistic.OtherForms;
using SBS_BarthLogistic.PrintForms;
using SBS_BarthLogistic.Tools;
using SBS_BarthLogistic.WayBill;

namespace SBS_BarthLogistic
{
    public partial class MainForm : RibbonForm
    {
        bool languageIconsDone;

        public MainForm()
        {
            InitializeComponent();
        }

        static BarItemVisibility Biv(bool state)
        {
            return state ? BarItemVisibility.Always : BarItemVisibility.Never;
        }

        void FormLoad()
        {
            while (true)
            {
                const string path = @"Params.ini";
                string serverName = string.Empty, connectionTimeout = string.Empty;
                if (File.Exists(path))
                {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        serverName = CLSTools.ReturnParam(sr.ReadLine());
                        connectionTimeout = CLSTools.ReturnParam(sr.ReadLine());
                        GlobalParameters.UserName = CLSTools.ReturnParam(sr.ReadLine());
                        GlobalParameters.DatabaseName = CLSTools.ReturnParam(sr.ReadLine());
                        GlobalParameters.SetFont = true;
                        GlobalParameters.FontName = CLSTools.ReturnParam(sr.ReadLine());
                        GlobalParameters.FontSize = float.Parse(CLSTools.ReturnParam(sr.ReadLine()));
                        GlobalParameters.Font = new Font(GlobalParameters.FontName, GlobalParameters.FontSize,
                            FontStyle.Regular);
                        GlobalParameters.ReportsFolder = CLSTools.ReturnParam(sr.ReadLine());
                        GlobalParameters.MonacemebiFolder = CLSTools.ReturnParam(sr.ReadLine());
                        GlobalParameters.XMLFolder = CLSTools.ReturnParam(sr.ReadLine());
                        GlobalParameters.DateFormat = CLSTools.ReturnParam(sr.ReadLine());
                        InterfaceParameters.PivotTableMaxRowCount = Convert.ToInt32(CLSTools.ReturnParam(sr.ReadLine()));
                        GlobalParameters.connectionTimeout = connectionTimeout;
                    }
                }
                else
                {
                    if (new CreateParamsini().ShowDialog() == DialogResult.OK) continue;
                }
                GlobalParameters.fmMain = this;
                RegistrationForm fmRegistration = new RegistrationForm(GlobalParameters.UserName);
                if (fmRegistration.ShowDialog() != DialogResult.OK)
                {
                    Close();
                    return;
                }
                try
                {
                    GlobalParameters.UserName = fmRegistration.User;
                    GlobalParameters.PassWord = fmRegistration.Pass;
                    GlobalParameters.ConnStr = "Data Source=" + serverName + ";Initial Catalog=" +
                                               GlobalParameters.DatabaseName +
                                               ";Persist Security Info=True;User ID=" + fmRegistration.User +
                                               ";Password=" + fmRegistration.Pass + ";Connection Timeout=" +
                                               connectionTimeout + ";";
                    GlobalParameters.updatestr =
                        $@"{serverName}*{GlobalParameters.DatabaseName}*{"SBS_BarthLogistic"}*{GlobalParameters.UserName}*{fmRegistration.Pass}*{GlobalParameters.ReportsFolder}*{" "}";
                    GlobalParameters.cn = new SqlConnection(GlobalParameters.ConnStr);
                    GlobalParameters.cn.Open();
                    GlobalParameters.cn.Close();
                    InterfaceParameters.updatestr = string.Format("{0}*{1}*{2}*{3}*{4}*\"{5}\"*\"{6}\"",
                        serverName, GlobalParameters.DatabaseName, Application.ProductName,
                        GlobalParameters.UserName, fmRegistration.Pass,
                        GlobalParameters.ReportsFolder,
                        GlobalParameters.XMLFolder);
                    InterfaceParameters.RegKey += GlobalParameters.UserName + "\\";

                    SetSqlBasedParameters();
                    GenerateCnobari();
                    GlobalParameters.InitializeErrorTexts();
                    laUser.Caption = GlobalParameters.UserName;
                    ShowMiItems();
                    SetFont();
                }
                catch (SqlException ex)
                {
                    string loginfail = ex.Message;
                    if (loginfail.Contains("Login failed for user"))
                    {
                        if (XtraMessageBox.Show(
                            "Invalid username or password/მომხმარებელი ან პაროლი არასწორია.\n\r" +
                            "Try again?/გაივლით ავტორიზაციას თავიდან?", "Error/შეცდომა", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            continue;
                    }
                    else
                    {
                        ex.ShowErrorDialog();
                    }
                    Close();
                }
                break;
            }
        }

        void Form1_Load(object sender, EventArgs e)
        {
            FormLoad();
            NetworkChange.NetworkAvailabilityChanged += (o, args) =>
                XtraMessageBox.Show(args.IsAvailable ? "ინტერნეტი ჩაირთო" : "თქვენ დაკარგეთ ინტერნეტთან წვდომა","",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        void GenerateCnobari()
        {
            GlobalParameters.Rc = rc;
            CLSCustomCnobari.HasTranslate = true;
            CLSCustomCnobari.Initialize();
            GlobalParameters.Rc.SetMainButtonTexts(2);
            foreach (RibbonPage page in rc.Pages)
            {
                page.Visible = true;
            }
            rc.Visible = true;

            if (!CLSCustomCnobari.HasTranslate || languageIconsDone) return;
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            DataTable dataTable = SQL.Select("SELECT InterfaceLanguage, Caption, Icon FROM InterfaceLanguage");

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                BarButtonItem rbtnNameX = new BarButtonItem();
                resources.ApplyResources(rbtnNameX, "rbtn" + dataTable.Rows[i]["InterfaceLanguage"]);

                MemoryStream memory = new MemoryStream((byte[])dataTable.Rows[i]["Icon"]);
                Image returnImage = Image.FromStream(memory);

                rbtnNameX.Glyph = returnImage;
                rbtnNameX.Id = 250 + i;
                rbtnNameX.Name = "rbtn" + dataTable.Rows[i]["InterfaceLanguage"];
                rbtnNameX.ItemClick += (sender, args) => { Language(args.Item.Name.Substring(4)); };
                rbtnNameX.Caption = dataTable.Rows[i]["Caption"].ToString();
                rc.Items.Add(rbtnNameX);
                rc.PageHeaderItemLinks.Add(rbtnNameX);
            }

            languageIconsDone = true;
        }

        void Language(string name)
        {
            if (!CLSCustomCnobari.HasTranslate) return;
            InterfaceParameters.InterfaceLanguage = name;
            CLSCustomCnobari.Initialize();
            GlobalParameters.Rc.SetMainButtonTexts(2);
        }

        void SetSqlBasedParameters()
        {
            GlobalParameters.DefaultLookAndFeel = DefaultLookAndFeel;
            DataRow dr = SQL.FillParams(GlobalParameters.UserName);
            InterfaceParameters.InterfaceLanguage = dr["InterfaceLanguage"].ToString();
            InitializeCompany(dr["IdCompany"].ToString());
        }

        private void InitializeCompany(string idCompany)
        {
            var dr = SQL.Select("SELECT * FROM Company WHERE IdCompany = " + idCompany).Rows[0];
            Company.ip = dr["CompanyIP"].ToString();
            Company.su = dr["ServiceUser"].ToString();
            Company.sp = dr["ServicePassword"].ToString();
            Company.Address = dr["CompanyAddress"].ToString();
            Company.Sagad = dr["CompanySagad"].ToString();
        }

        void CreateForm<T>() where T : Form, new()
        {
            foreach (Form f in MdiChildren)
            {
                if (f.Text == GlobalParameters.FieldName )
                {
                    f.Activate();
                    return;
                }
            }
            T frm = new T();
            frm.MdiParent = this;
            frm.Show();
            frm.Activate();
        }

        static void CheckServiceUser(bool showConnectResult)
        {
            try
            {
                CLSWayBillOperation wayBill = new CLSWayBillOperation();
                if (wayBill.CheckServiceUser())
                {
                    if (showConnectResult)
                        XtraMessageBox.Show("კავშირი დამყარებულია","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("ვერ მოხერხდა სისტემასთან კავშირი, შეამოწმეთ მომხმარებელი და პაროლი","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch
            {
                XtraMessageBox.Show("ვერ მოხერხდა საგადასახადოს საიტთან დაკავშირება","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        void miAbout_Click(object sender, ItemClickEventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        void miConnectToSite_ItemClick(object sender, ItemClickEventArgs e)
        {
            CheckServiceUser(true);
        }

        void miPrams_ItemClick(object sender, ItemClickEventArgs e)
        {
            new AddParamsForm().ShowDialog();
            SetSqlBasedParameters();
        }


        void miAddUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsUserSa())
                new AddUserForm().ShowDialog();
        }

        void miEditUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            new EditUserForm().ShowDialog();
        }

        void miDelUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsUserSa())
                new DelUserForm().ShowDialog();
        }

        void miUserPermission_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsUserSa())
                new SetUserPermissionsForm().ShowDialog();
        }

        void miExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Logout(sender.ToString());
        }

        void miSQLExecute_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (SQLExecute fmSqlExecute = new SQLExecute())
            {
                fmSqlExecute.ShowDialog();
            }
        }

        void mi_Click(object sender, ItemClickEventArgs e)
        {
            string controlName = e.Item.Name.Remove(0, 2);
            GlobalParameters.TableName = controlName;
            GlobalParameters.FieldName = e.Item.Caption;

            switch (controlName)
            {
                case "ZeddAuto":
                    CreateForm<ZeddAutoForm>();
                    break;
                case "Shem1":
                    CreateForm<Shem1Form>();
                    break;
                case "Sal":
                    CreateForm<SalForm>();
                    break;
                case "Invoice":
                    CreateForm<Invoices1Form>();
                    break;
                case "Gas1":
                    CreateForm<Gas1Form>();
                    break;
                case "Modz1":
                    CreateForm<Modz1Form>();
                    break;
                case "Agcera1":
                    CreateForm<Agcera1Form>();
                    break;
                case "Mdz":
                    CreateForm<MdzForm>();
                    break;
                case "Org":
                    CreateForm<OrgForm>();
                    break;
                case "Proek":
                    CreateForm<ProekForm>();
                    break;
                case "Company":
                    CreateForm<CompanyForm>();
                    break;
                case "ServiceReal":
                    CreateForm<ServiceRealForm>();
                    break;
                case "Nashti":
                    CreateForm<prnNashtiForm>();
                    break;
                case "AreaByOrg":
                    CreateForm<prnAreaByOrg>();
                    break;
                case "ProdBarati":
                    CreateForm<prnProdBaratiForm>();
                    break;
                default:
                    CreateForm<AedAllForm>();
                    break;
            }
        }

        void miRSInformation_Click(object sender, ItemClickEventArgs e)
        {
            using (RSInformationForm fm = new RSInformationForm())
            {
                fm.ShowDialog();
            }
        }

        void miExportSeveralTables_Click(object sender, ItemClickEventArgs e)
        {
            GlobalParameters.FieldName = e.Item.Caption;
            using (ExportSeveralTablesToExcelForm fmExportToInfo = new ExportSeveralTablesToExcelForm())
            {
                fmExportToInfo.ShowDialog();
            }
        }

        void AedClick(object sender, ItemClickEventArgs e)
        {
            GlobalParameters.TableName = e.Item.Name.Remove(0, 2);
            GlobalParameters.FieldName = e.Item.Caption;
            CreateForm<AedAllForm>();
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (XtraMessageBox.Show("ნამდვილად გსურთ პროგრამიდან გამოსვლა?", "Exit", MessageBoxButtons.YesNo) !=
            //    DialogResult.Yes)
            //    e.Cancel = true;
        }

        void miSQL_Click(object sender, EventArgs e)
        {
            SQLExecute frm = new SQLExecute();
            frm.MdiParent = this;
            frm.Show();
            frm.Activate();
        }

        void miMISub_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                if (f is MISubForm)
                {
                    f.Activate();
                    return;
                }
            }
            MISubForm frm = new MISubForm();
            frm.MdiParent = this;
            frm.Show();
            frm.Activate();
        }

        void miAdminCnobari_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                if (f is AdminCnobariForm)
                {
                    f.Activate();
                    return;
                }
            }
            AdminCnobariForm frm = new AdminCnobariForm();
            frm.MdiParent = this;
            frm.Show();
            frm.Activate();
        }

        static bool IsUserSa()
        {
            string un = GlobalParameters.UserName.Length > 2 & GlobalParameters.UserName.Contains("_")
                ? GlobalParameters.UserName.Substring(0, 3)
                : GlobalParameters.UserName + "_";

            if (un != "sa_")
            {
                XtraMessageBox.Show("თქვენ აღნიშნული ოპერაციის ჩატარების უფლება არა გაქვთ",
                    StringParameters.CaptionError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        bool IsVisible(BarItemLink itemLink)
        {
            return (itemLink.Item.Visibility == BarItemVisibility.Always ||
                    itemLink.Item.Visibility == BarItemVisibility.OnlyInRuntime) && itemLink.Visible;
        }

        void ShowMiItems()
        {
            DataTable dt = SQL.Select("SELECT * FROM MIView WHERE UN = N'" + GlobalParameters.UserName + "'");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!Convert.ToBoolean(dt.Rows[i]["CanView"].ToString()))
                {
                    ReturnMenuItem(dt.Rows[i]["ControlList"].ToString());
                }
            }

            foreach (RibbonPage pag in rc.Pages)
            {
                bool visiblePage = false;
                foreach (RibbonPageGroup pagGroup in pag.Groups)
                {
                    bool visibleAll = false;
                    foreach (BarItemLink itemLink in pagGroup.ItemLinks)
                    {
                        if (IsVisible(itemLink))
                        {
                            visibleAll = true;
                        }
                    }

                    if (!visibleAll)
                        pagGroup.Visible = false;

                    if (pagGroup.Visible)
                    {
                        visiblePage = true;
                    }
                }

                if (!visiblePage)
                    pag.Visible = false;
            }
        }

        void ReturnMenuItem(string itemName)
        {
            string[] s = itemName.Split(';');

            foreach (string t in s)
            {
                HideMenuButton(t);
            }
        }

        void HideMenuButton(string s)
        {
            if (rc.Manager.Items[s] != null)
                rc.Manager.Items[s].Visibility = BarItemVisibility.Never;
        }

        void SetFont()
        {
            Font font = GlobalParameters.Font;
            //DevExpress.Utils.AppearanceObject.DefaultFont = font;
            tabbedView1.Appearance.Font = font;
            tabbedView1.AppearancePage.Header.Font = font;
            tabbedView1.AppearancePage.HeaderActive.Font = font;
            tabbedView1.AppearancePage.HeaderDisabled.Font = font;
            tabbedView1.AppearancePage.HeaderHotTracked.Font = font;
            tabbedView1.AppearancePage.HeaderSelected.Font = font;
            tabbedView1.AppearancePage.PageClient.Font = font;
            barDockController.AppearancesBackstageView.BackstageView.Font = font;
            barDockController.AppearancesBackstageView.Button.Font = font;
            barDockController.AppearancesBackstageView.ButtonDisabled.Font = font;
            barDockController.AppearancesBackstageView.ButtonHover.Font = font;
            barDockController.AppearancesBackstageView.ButtonPressed.Font = font;
            barDockController.AppearancesBackstageView.Separator.Font = font;
            barDockController.AppearancesBackstageView.Tab.Font = font;
            barDockController.AppearancesBackstageView.TabDisabled.Font = font;
            barDockController.AppearancesBackstageView.TabHover.Font = font;
            barDockController.AppearancesBackstageView.TabSelected.Font = font;
            barDockController.AppearancesBar.BarAppearance.Disabled.Font = font;
            barDockController.AppearancesBar.BarAppearance.Hovered.Font = font;
            barDockController.AppearancesBar.BarAppearance.Normal.Font = font;
            barDockController.AppearancesBar.BarAppearance.Pressed.Font = font;
            barDockController.AppearancesBar.Dock.Font = font;
            barDockController.AppearancesBar.ItemsFont = font;
            barDockController.AppearancesBar.MainMenuAppearance.Disabled.Font = font;
            barDockController.AppearancesBar.MainMenuAppearance.Hovered.Font = font;
            barDockController.AppearancesBar.MainMenuAppearance.Normal.Font = font;
            barDockController.AppearancesBar.StatusBarAppearance.Disabled.Font = font;
            barDockController.AppearancesBar.StatusBarAppearance.Hovered.Font = font;
            barDockController.AppearancesBar.StatusBarAppearance.Normal.Font = font;
            barDockController.AppearancesBar.SubMenu.AppearanceMenu.Normal.Font = font;
            barDockController.AppearancesBar.SubMenu.HeaderItemAppearance.Font = font;
            barDockController.AppearancesBar.SubMenu.MenuBar.Font = font;
            barDockController.AppearancesBar.SubMenu.MenuCaption.Font = font;
            barDockController.AppearancesBar.SubMenu.SideStrip.Font = font;
            barDockController.AppearancesBar.SubMenu.SideStripNonRecent.Font = font;
            barDockController.AppearancesDocking.ActiveTab.Font = font;
            barDockController.AppearancesDocking.FloatFormCaption.Font = font;
            barDockController.AppearancesDocking.FloatFormCaptionActive.Font = font;
            barDockController.AppearancesDocking.HideContainer.Font = font;
            barDockController.AppearancesDocking.HidePanelButton.Font = font;
            barDockController.AppearancesDocking.HidePanelButtonActive.Font = font;
            barDockController.AppearancesDocking.Panel.Font = font;
            barDockController.AppearancesDocking.PanelCaption.Font = font;
            barDockController.AppearancesDocking.PanelCaptionActive.Font = font;
            barDockController.AppearancesDocking.Tabs.Font = font;
            barDockController.AppearancesDocumentManager.View.Font = font;
            barDockController.AppearancesRibbon.Editor.Font = font;
            barDockController.AppearancesRibbon.FormCaption.Font = font;
            barDockController.AppearancesRibbon.Gallery.FilterPanelCaption.Font = font;
            barDockController.AppearancesRibbon.Gallery.GroupCaption.Font = font;
            barDockController.AppearancesRibbon.Gallery.ItemCaptionAppearance.Disabled.Font = font;
            barDockController.AppearancesRibbon.Gallery.ItemCaptionAppearance.Hovered.Font = font;
            barDockController.AppearancesRibbon.Gallery.ItemCaptionAppearance.Normal.Font = font;
            barDockController.AppearancesRibbon.Gallery.ItemCaptionAppearance.Pressed.Font = font;
            barDockController.AppearancesRibbon.Gallery.ItemDescriptionAppearance.Disabled.Font = font;
            barDockController.AppearancesRibbon.Gallery.ItemDescriptionAppearance.Hovered.Font = font;
            barDockController.AppearancesRibbon.Gallery.ItemDescriptionAppearance.Normal.Font = font;
            barDockController.AppearancesRibbon.Gallery.ItemDescriptionAppearance.Pressed.Font = font;
            barDockController.AppearancesRibbon.Item.Font = font;
            barDockController.AppearancesRibbon.ItemDescription.Font = font;
            barDockController.AppearancesRibbon.ItemDescriptionDisabled.Font = font;
            barDockController.AppearancesRibbon.ItemDescriptionHovered.Font = font;
            barDockController.AppearancesRibbon.ItemDescriptionPressed.Font = font;
            barDockController.AppearancesRibbon.ItemDisabled.Font = font;
            barDockController.AppearancesRibbon.ItemHovered.Font = font;
            barDockController.AppearancesRibbon.ItemPressed.Font = font;
            barDockController.AppearancesRibbon.PageCategory.Font = font;
            barDockController.AppearancesRibbon.PageGroupCaption.Font = font;
            barDockController.AppearancesRibbon.PageHeader.Font = font;
        }

        void rbtnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            Logout(sender.ToString());
        }

        void Logout(string caption)
        {
            if (MDIManager.View.Documents.Count > 0)
            {
                if (XtraMessageBox.Show(
                    "გახსნილია " + MDIManager.View.Documents.Count + " ფანჯარა. გსურთ მომხმარებლიდან გამოსვლა?", caption,
                    MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
            }
            MDIManager.View.Controller.CloseAll();
            foreach (RibbonPage page in rc.Pages)
                page.Visible = false;
            FormLoad();
        }

        void btnExportDataToExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            GlobalParameters.FieldName = e.Item.Caption;
            using (ExportDataToExcelForm fm = new ExportDataToExcelForm())
            {
                fm.ShowDialog();
            }
        }

        private void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!File.Exists("SBS_Updater.exe"))
            {
                XtraMessageBox.Show("განახლების მოდული ვერ მოიძებნა. გთხოვთ დაუკავშირდეთ მხარდაჭერის ცენტრს", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Process.Start("SBS_Updater.exe", GlobalParameters.updatestr);
            Application.Exit();
        }
    }
}