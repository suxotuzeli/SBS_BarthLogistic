using System;
using System.Data;
using System.Linq;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.AddForms;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.FindForms;
using SBS_BarthLogistic.OtherForms;

namespace SBS_BarthLogistic.AEDForms
{
    public partial class Invoices1Form : XtraForm
    {
        const string MasterId = "IdInvoices1";
        const string MasterTableName = "Invoices1";
        const string DetailTableName = "Invoices2";
        const string FieldList = "Data, Zedd, UN, CD";
        const string DetFieldList = "IdInvoices1, IdProd, Raod";
        const string NameForReports = "Invoices1";
        const string StrComm = "SELECT * FROM Invoices1View ";
        const string StrCommDetail = "SELECT * FROM Invoices2View ";
        private FInvoices1Form fmFInvoices1;
        #region Initialize

        public Invoices1Form()
        {
            InitializeComponent();
        }

        void Invoices1Form_Load(object sender, EventArgs e)
        {
            Text = GlobalParameters.FieldName;
            dgInvoices1.BindContextMenu(popInvoices1);
            dgInvoices2.BindContextMenu(popGas2);
            //            barInvoices1.RestoreLayoutFromRegistry(ManagementParameters.RegKey + "barGas");

            gvInvoices1.ChangeFonts();
            gvInvoices2.ChangeFonts();
            CLSTools.InitializePeriod(cbPeriod, txtData1, txtData2);

            gvInvoices1.FocusedRowChanged += delegate { FillDetailTables(); };
            Activated += delegate { FormActivated(); };

            gvInvoices1.DoubleClick += delegate { Edit(); };
            gvInvoices2.DoubleClick += delegate { DetEdit(); };
        }

        #endregion Initialize

        #region Master

        void FormActivated()
        {
            gvInvoices1.FormActivate(StrComm, txtData1, txtData2);
            FillDetailTables();
        }

        void ShowAddForm(int id, bool editing)
        {
            var fm = new AddInvoices1Form(id, editing, MasterTableName);
            CLSTools.MdiForm(fm);
        }

        void FillDetailTables()
        {
            dgInvoices1.FillDetails(dgInvoices2, StrCommDetail);
        }

        void btnXLSImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            var fm = new ImportFromExcelOldForm(new[]
            {
                "Raod"
            }, new[]
            {
                "Prod"
            }, MasterId, gvInvoices1.GetFocusedRowCellValue(MasterId).ToString(), true);
            fm.ShowDialog();
            fm.Dispose();
            FillDetailTables();
        }

        void btnInsert_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowAddForm(0, false);
        }

        void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvInvoices1.CanUserModifyData(gvInvoices1))
                ShowAddForm(int.Parse(gvInvoices1.GetFocusedRowCellValue(MasterId).ToString()), true);
        }

        void Edit()
        {
            if (gvInvoices1.CanUserModifyData())
                ShowAddForm(gvInvoices1.ReturnInt32(), true);
        }

        void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvInvoices1.CanUserModifyData())
                gvInvoices1.Delete();
            FormActivated();
        }

        void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvInvoices1.FormActivate(StrComm, txtData1, txtData2);
            FillDetailTables();
        }

        void btnFilterWithFindID_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgInvoices1.MoveToId(StrComm);
            FillDetailTables();
        }

        void btnShowLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvInvoices1.ShowChangeForm();
        }

        void btnFind_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (var f in MdiParent.MdiChildren.OfType<FInvoices1Form>())
            {
                f.Activate();
                return;
            }
            fmFInvoices1 = new FInvoices1Form();
            fmFInvoices1.MdiParent = MdiParent;
            fmFInvoices1.Show();
            fmFInvoices1.Activate();
        }

        void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            var stRep = new CLSStimul(DetailTableName, dgInvoices2);
            stRep.Initialize();
            stRep.SetDefaultVariables(gvInvoices1.GetFocusedDataRow());
            stRep.Show();
        }

        void btnCopy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvInvoices1.GetFocusedDataRow() != null)
            {
                ShowAddForm(gvInvoices1.ReturnInt32(), false);
            }
        }

        void btnCopyWithDetails_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvInvoices1.GetFocusedDataRow() != null)
            {
                SQLOperation.CopyRecordWithDetails(MasterTableName, DetailTableName,
                    gvInvoices1.ReturnInt32(), FieldList, DetFieldList);
                gvInvoices1.FormActivate(StrComm, txtData1, txtData2);
            }
        }

        void btnLayout_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgInvoices1.SaveLayouts();
        }

        #endregion Master

        #region Detail

        void btnDetInsert_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvInvoices1.CanUserModifyData())
                ShowAddDetForm(0, false);
        }

        void btnDetEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DetEdit();
        }

        void DetEdit()
        {
            if (gvInvoices1.CanUserModifyData(gvInvoices2))
                ShowAddDetForm(gvInvoices2.ReturnInt32(), true);
        }

        void ShowAddDetForm(int id, bool editing)
        {
            var row = gvInvoices1.GetFocusedDataRow();
            if (row == null) return;
            var fm = new AddInvoices2Form(id, editing, DetailTableName, gvInvoices1.ReturnInt32());
            CLSTools.MdiForm(fm);
        }

        void btnDetDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvInvoices1.CanUserModifyData(gvInvoices2))
                gvInvoices2.Delete();
            FillDetailTables();
        }

        void btnLayoutDet_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgInvoices2.SaveLayouts();
        }

        void chbShowLogDet_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvInvoices2.ShowChangeForm();
        }

        #endregion Detail
    }
}