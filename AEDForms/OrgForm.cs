using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.AddForms;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AEDForms
{
    public partial class OrgForm : XtraForm
    {
        const string NameForReports = "Org";
        const string StrComm = "SELECT * FROM dbo.Org INNER JOIN dbo.OrgT ON OrgT.IdOrgT = Org.IdOrgT";
        const string StrCommServices = "SELECT * FROM dbo.OrgServices INNER JOIN dbo.Service ON Service.IdService = OrgServices.IdService";
        const string StrCommProd = "SELECT * FROM dbo.OrgProd";

        readonly string fieldName;
        readonly string tableName;

        private int focusedDataRow;

        public OrgForm()
        {
            InitializeComponent();
            tableName = GlobalParameters.TableName;
            fieldName = GlobalParameters.FieldName;
        }

        void GvariForm_Load(object sender, EventArgs e)
        {
            CLSTools.GetFileList(NameForReports, cbExcel, "*.xls");
            Text = fieldName;
            gvOrg.ChangeFonts();
            gvOrgServices.ChangeFonts();

            gvOrg.DoubleClick += delegate { btnEdit_ItemClick(); };
            gvOrgServices.DoubleClick += delegate { BtnEditOrgServices_ItemClick(); };

            Activated += delegate { FormActivated(); };
            gvOrg.FocusedRowChanged += delegate { FillDetailTables(); };
        }
        void FillDetailTables()
        {
            dgOrg.FillDetails(dgOrgServices,StrCommServices);
        }

        void FormActivated()
        {
            gvOrg.FormActivate(StrComm);
            FillDetailTables();
            if (focusedDataRow < 0)
                gvOrg.MoveLast();
            else
            {
                gvOrg.MakeRowVisible(focusedDataRow);
                gvOrg.FocusedRowHandle = focusedDataRow;
            }
        }

        #region ShowAddForm

        void ShowAddForm(int id = 0, bool editing = false)
        {
            var fm = new AddOrgForm(id,editing);
            focusedDataRow = id == 0?-1:gvOrg.FocusedRowHandle;
            CLSTools.MdiForm(fm);
        }
        void ShowAddServicesForm(int id = 0, bool editing = false)
        {
            if (gvOrg.GetFocusedDataRow() == null) return;
            focusedDataRow = id == 0?-1:gvOrg.FocusedRowHandle;
            var fm = new AddOrgServicesForm(id,editing,gvOrg.ReturnInt32());
            CLSTools.MdiForm(fm);
        }

        void ShowAddProdForm(int id = 0, bool editing = false)
        {
            if (gvOrg.GetFocusedDataRow() == null) return;
            focusedDataRow = id == 0?-1:gvOrg.FocusedRowHandle;
            var fm = new AddOrgProdForm(id,editing,gvOrg.ReturnInt32());
            CLSTools.MdiForm(fm);
        }

        #endregion

        #region MainMenu

        void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormActivated();
        }


        void btnInsert_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowAddForm();
        }

        void btnEdit_ItemClick(object sender = null, ItemClickEventArgs e = null)
        {
            ShowAddForm(gvOrg.ReturnInt32(), true);
        }

        void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvOrg.Delete();
            FormActivated();
        }

        void btnCopy_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowAddForm(gvOrg.ReturnInt32(), false);
        }

        void btnShowLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvOrg.ShowChangeForm();
        }

        void btnExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            var exp = ((DataTable)dgOrg.DataSource).Copy();
            var clsExcel = new CLSExcel(exp, cbExcel.EditValue.ToString());
            clsExcel.Export();
        }

        void btnLayout_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgOrg.SaveLayouts();
        }

        #endregion

        #region OrgProd

        private void BtnAddOrgProd_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowAddProdForm();
        }

        private void BtnEditOrgProd_ItemClick(object sender = null, ItemClickEventArgs e = null)
        {

        }

        private void BtnDelOrgProd_ItemClick(object sender, ItemClickEventArgs e)
        {
            FillDetailTables();
        }

        private void BtnRefreshOrgProd_ItemClick(object sender, ItemClickEventArgs e)
        {
            FillDetailTables();
        }

        #endregion

        #region OrgServices

        private void BtnAddOrgServices_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowAddServicesForm();
        }

        private void BtnEditOrgServices_ItemClick(object sender = null, ItemClickEventArgs e = null)
        {
            ShowAddServicesForm(gvOrgServices.ReturnInt32(), true);
        }

        private void BtnDelOrgServices_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvOrgServices.Delete();
            FillDetailTables();
        }

        private void BtnRefreshOrgServices_ItemClick(object sender, ItemClickEventArgs e)
        {
            FillDetailTables();
        }

        #endregion

        private void btnFileOpen_ItemClick(object sender, ItemClickEventArgs e)
        {
            DocClick(GlobalParameters.MonacemebiFolder);
        }

        private void btnFileSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            DocClick("");
        }

        private void DocClick(string filepath)
        {
            if (gvOrgServices.FocusedRowHandle > -1)
                try
                {
                    DataTable dt1 =
                        SQL.Select("SELECT FileDoc, FileName FROM OrgServices WHERE IdOrgServices=" +
                                   gvOrgServices.GetFocusedRowCellValue("IdOrgServices"));
                    SaveFileDialog sd = new SaveFileDialog();
                    sd.FileName = dt1.Rows[0]["FileName"].ToString();
                    if (filepath == "")
                    {
                        if (sd.ShowDialog() == DialogResult.Cancel)
                            return;
                        filepath = sd.FileName;
                    }
                    else filepath = filepath + dt1.Rows[0]["FileName"].ToString();
                    if (dt1.Rows.Count > 0)
                    {
                        MemoryStream ms = new MemoryStream((byte[])dt1.Rows[0]["FileDoc"]);
                        // FileStream FS = new FileStream(@sd.FileName, FileMode.Create, FileAccess.Write);
                        using (var fileStream = File.Create(@filepath))
                        {
                            ms.WriteTo(fileStream);
                            fileStream.Close();
                            if (sd.FileName == dt1.Rows[0]["FileName"].ToString())
                                System.Diagnostics.Process.Start(@filepath);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}