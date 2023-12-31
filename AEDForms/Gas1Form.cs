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
    public partial class Gas1Form : XtraForm
    {
        const string MasterId = "IdGas1";
        const string MasterTableName = "Gas1";
        const string DetailTableName = "Gas2";
        const string FieldList = "Data, Zedd, IdProek, IdGasT, Shen, UN, CD";
        const string DetFieldList = "IdGas1, IdProd, Raod";
        const string NameForReports = "Gas1";
        const string StrComm = "SELECT * FROM Gas1View ";
        const string StrCommDetail = "SELECT * FROM Gas2View ";
        FGas1Form fmFGas1;

        #region Initialize

        public Gas1Form()
        {
            InitializeComponent();
        }

        void Gas1Form_Load(object sender, EventArgs e)
        {
            Text = GlobalParameters.FieldName;
            dgGas1.BindContextMenu(popGas1);
            dgGas2.BindContextMenu(popGas2);
            //            barGas1.RestoreLayoutFromRegistry(ManagementParameters.RegKey + "barGas");

            gvGas1.ChangeFonts();
            gvGas2.ChangeFonts();
            CLSTools.InitializePeriod(cbPeriod, txtData1, txtData2);

            gvGas1.FocusedRowChanged += delegate { FillDetailTables(); };
            Activated += delegate { FormActivated(); };

            gvGas1.DoubleClick += delegate { Edit(); };
            gvGas2.DoubleClick += delegate { DetEdit(); };
        }

        #endregion Initialize

        #region Master

        void FormActivated()
        {
            gvGas1.FormActivate(StrComm, txtData1, txtData2);
            FillDetailTables();
        }

        void ShowAddForm(int id, bool editing)
        {
            var fm = new AddGas1Form(id, editing, MasterTableName);
            CLSTools.MdiForm(fm);
        }

        void FillDetailTables()
        {
            dgGas1.FillDetails(dgGas2, StrCommDetail);
        }

        void btnXLSImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            var fm = new ImportFromExcelOldForm(new[]
            {
                "Raod"
            }, new[]
            {
                "Prod"
            }, MasterId, gvGas1.GetFocusedRowCellValue(MasterId).ToString(), true);
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
            if (gvGas1.CanUserModifyData(gvGas1))
                ShowAddForm(int.Parse(gvGas1.GetFocusedRowCellValue(MasterId).ToString()), true);
        }

        void Edit()
        {
            if (gvGas1.CanUserModifyData())
                ShowAddForm(gvGas1.ReturnInt32(), true);
        }

        void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvGas1.CanUserModifyData())
                gvGas1.Delete();
            FormActivated();
        }

        void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvGas1.FormActivate(StrComm, txtData1, txtData2);
            FillDetailTables();
        }

        void btnFilterWithFindID_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgGas1.MoveToId(StrComm);
            FillDetailTables();
        }

        void btnShowLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvGas1.ShowChangeForm();
        }

        void btnFind_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (var f in MdiParent.MdiChildren.OfType<FGas1Form>())
            {
                f.Activate();
                return;
            }
            fmFGas1 = new FGas1Form();
            fmFGas1.MdiParent = MdiParent;
            fmFGas1.Show();
            fmFGas1.Activate();
        }

        void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            var stRep = new CLSStimul(DetailTableName);
            stRep.Initialize();
            stRep.SetConnectionString();
            stRep.SetVariableValue(MasterId, gvGas1.ReturnId());
            stRep.Show();
        }

        void btnCopy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvGas1.GetFocusedDataRow() != null)
            {
                ShowAddForm(gvGas1.ReturnInt32(), false);
            }
        }

        void btnCopyWithDetails_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvGas1.GetFocusedDataRow() != null)
            {
                SQLOperation.CopyRecordWithDetails(MasterTableName, DetailTableName,
                    gvGas1.ReturnInt32(), FieldList, DetFieldList);
                gvGas1.FormActivate(StrComm, txtData1, txtData2);
            }
        }

        void btnLayout_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgGas1.SaveLayouts();
        }

        #endregion Master

        #region Detail

        void btnDetInsert_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvGas1.CanUserModifyData())
                ShowAddDetForm(0, false);
        }

        void btnDetEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DetEdit();
        }

        void DetEdit()
        {
            if (gvGas1.CanUserModifyData(gvGas2))
                ShowAddDetForm(gvGas2.ReturnInt32(), true);
        }

        void ShowAddDetForm(int id, bool editing)
        {
            var row = gvGas1.GetFocusedDataRow();
            if (row == null) return;
            var fm = new AddGas2Form(id, editing, DetailTableName, gvGas1.ReturnInt32());
            CLSTools.MdiForm(fm);
        }

        void btnDetDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvGas1.CanUserModifyData(gvGas2))
                gvGas2.Delete();
            FillDetailTables();
        }

        void btnLayoutDet_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgGas2.SaveLayouts();
        }

        void chbShowLogDet_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvGas2.ShowChangeForm();
        }

        #endregion Detail
    }
}