using System;
using System.Linq;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.AddForms;
using SBS_BarthLogistic.FindForms;

namespace SBS_BarthLogistic.AEDForms
{
    public partial class Modz1Form : XtraForm
    {
        const string MasterId = "IdModz1";
        const string MasterTableName = "Modz1";
        const string DetailTableName = "Modz2";
        const string FieldList = "Data, Zedd, IdProek1, IdProek2, IdMdz, IdModzT, Shen, UN, CD";
        const string DetFieldList = "IdModz1, IdProd, Raod";
        const string StrComm = "SELECT * FROM Modz1View ";
        const string StrCommDetail = "SELECT * FROM Modz2View ";

        public Modz1Form()
        {
            InitializeComponent();
        }

        void Modz1Form_Load(object sender, EventArgs e)
        {
            Text = GlobalParameters.FieldName;
            dgModz1.BindContextMenu(popModz1);
            dgModz2.BindContextMenu(popModz2);

            gvModz1.ChangeFonts();
            gvModz2.ChangeFonts();
            CLSTools.InitializePeriod(cbPeriod, txtData1, txtData2);

            gvModz1.FocusedRowChanged += delegate { FillDetailTables(); };
            Activated += delegate { FormActivated(); };

            gvModz1.DoubleClick += delegate { Edit(); };
            gvModz2.DoubleClick += delegate { DetEdit(); };
        }

        void FormActivated()
        {
            gvModz1.FormActivate(StrComm, txtData1, txtData2);
        }

        void ShowAddForm(int id, bool editing)
        {
            var fm = new AddModz1Form(id, editing, MasterTableName);
            CLSTools.MdiForm(fm);
        }

        void FillDetailTables()
        {
            dgModz1.FillDetails(dgModz2, StrCommDetail);
        }

        void btnInsert_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowAddForm(0, false);
        }

        void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvModz1.CanUserModifyData(gvModz1))
                ShowAddForm(int.Parse(gvModz1.GetFocusedRowCellValue(MasterId).ToString()), true);
        }

        void Edit()
        {
            if (gvModz1.CanUserModifyData())
                ShowAddForm(int.Parse(gvModz1.GetFocusedDataRow()[MasterId].ToString()), true);
        }

        void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvModz1.CanUserModifyData())
                gvModz1.Delete();
            FormActivated();
        }

        void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormActivated();
        }

        void btnFilterWithFindID_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgModz1.MoveToId(StrComm);
        }

        void btnShowLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvModz1.ShowChangeForm();
        }

        void btnFind_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (var f in MdiParent.MdiChildren.OfType<FModz1Form>())
            {
                f.Activate();
                return;
            }

            var fmFModz1 = new FModz1Form {MdiParent = MdiParent};
            fmFModz1.Show();
            fmFModz1.Activate();
        }

        void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            var row = gvModz1.GetFocusedDataRow();
            if (row == null) return;
            var dtModz2 = SQL.Select("SELECT * FROM Modz2" + (InterfaceParameters.PrintGroupedStimul ? "Sum" : string.Empty) + "View WHERE IdModz1 = " + row["IdModz1"]);
            var stRep = new CLSStimul(DetailTableName, dtModz2);
            stRep.Initialize();
            stRep.SetDefaultVariables(row);
            stRep.Show();

            //var stRep = new CLSStimul(DetailTableName, dgModz2);
            //stRep.Initialize();
            //stRep.SetDefaultVariables(gvModz1.GetFocusedDataRow());
            //stRep.Show();
        }

        void btnCopy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvModz1.GetFocusedDataRow() != null)
                ShowAddForm(int.Parse(gvModz1.GetFocusedDataRow()[MasterId].ToString()), false);
        }

        void btnCopyWithDetails_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvModz1.GetFocusedDataRow() != null)
            {
                SQLOperation.CopyRecordWithDetails(MasterTableName, DetailTableName,
                    int.Parse(gvModz1.GetFocusedDataRow()[MasterId].ToString()), FieldList, DetFieldList);
                gvModz1.FormActivate(StrComm, txtData1, txtData2);
            }
        }

        void btnLayout_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgModz1.SaveLayouts();
        }

        void btnDetInsert_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvModz1.CanUserModifyData())
                ShowAddDetForm(0, false, int.Parse(gvModz1.GetFocusedDataRow()[MasterId].ToString()));
        }

        void btnDetEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DetEdit();
        }

        void DetEdit()
        {
            if (gvModz1.CanUserModifyData(gvModz2))
                ShowAddDetForm(int.Parse(gvModz2.GetFocusedDataRow()["Id" + DetailTableName].ToString()), true,
                    int.Parse(gvModz1.GetFocusedDataRow()["Id" + MasterTableName].ToString()));
        }

        void ShowAddDetForm(int id, bool editing, int masterId1)
        {
            var row = gvModz1.GetFocusedDataRow();
            if (row == null) return;
            var fm = new AddModz2Form(id, editing, DetailTableName, "", masterId1);
            if (editing)
                fm.ShowDialog();
            else
                CLSTools.MdiForm(fm);

        }

        void btnDetDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvModz1.CanUserModifyData(gvModz2))
                gvModz2.Delete();
            FillDetailTables();
        }

        void btnLayoutDet_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgModz2.SaveLayouts();
        }

        void chbShowLogDet_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvModz2.ShowChangeForm();
        }

        void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            CLSWayBillOperation.GridRowStyle(sender, e);
        }

        private void btnDetExportToExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            CLSExcel.ExportToExcel(dgModz2);
        }
    }
}