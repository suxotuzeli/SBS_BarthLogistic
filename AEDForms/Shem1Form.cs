using System;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.AddForms;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.FindForms;
using SBS_BarthLogistic.OtherForms;

namespace SBS_BarthLogistic.AEDForms
{
    public partial class Shem1Form : XtraForm
    {
        const string MasterId = "IdShem1";
        const string MasterTableName = "Shem1";
        const string DetailTableName = "Shem2";
        const string FieldList = "Data, Zedd, IdProek, IdShemT, Shen, UN, CD";
        const string DetFieldList = "IdShem1, IdProd, Raod";
        const string StrComm = "SELECT * FROM Shem1View ";
        const string StrCommDetail = "SELECT * FROM Shem2View ";

        void btnDetRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            FillDetailTables();
        }

        void btnLayout_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            dgShem1.SaveLayouts();
        }

        public Shem1Form()
        {
            InitializeComponent();
        }

        void Shem1Form_Load(object sender, EventArgs e)
        {
            Text = GlobalParameters.FieldName;
            dgShem1.BindContextMenu(popShem1);
            dgShem2.BindContextMenu(popShem2);

            gvShem1.ChangeFonts();
            gvShem2.ChangeFonts();
            CLSTools.InitializePeriod(cbPeriod, txtData1, txtData2);

            gvShem1.FocusedRowChanged += delegate { FillDetailTables(); };
            Activated += delegate { FormActivated(); };

            gvShem1.DoubleClick += delegate { Edit(); };
            gvShem2.DoubleClick += delegate { DetEdit(); };
        }

        void FormActivated()
        {
            gvShem1.FormActivate(StrComm, txtData1, txtData2);
        }

        void ShowAddForm(int id, bool editing)
        {
            var fm = new AddShem1Form(id, editing, MasterTableName);
            CLSTools.MdiForm(fm);
        }

        void FillDetailTables()
        {
            dgShem1.FillDetails(dgShem2, StrCommDetail);
        }

        void btnXLSImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            var fm = new ImportFromExcelOldForm(new[]
            {
                "Raod"
            }, new[]
            {
                "Prod"
            }, MasterId, gvShem1.GetFocusedRowCellValue(MasterId).ToString(), true);
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
            if (gvShem1.CanUserModifyData(gvShem1))
                ShowAddForm(int.Parse(gvShem1.GetFocusedRowCellValue(MasterId).ToString()), true);
        }

        void Edit()
        {
            if (gvShem1.CanUserModifyData())
                ShowAddForm(int.Parse(gvShem1.GetFocusedDataRow()[MasterId].ToString()), true);
        }

        void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvShem1.CanUserModifyData())
                gvShem1.Delete();
            FormActivated();
        }

        void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormActivated();
        }

        void btnFilterWithFindID_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgShem1.MoveToId(StrComm);
        }

        void btnShowLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvShem1.ShowChangeForm();
        }

        void btnFind_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (var f in MdiParent.MdiChildren)
            {
                if (f is FShem1Form)
                {
                    f.Activate();
                    return;
                }
            }

            var fm = new FShem1Form {MdiParent = MdiParent};
            fm.Show();
            fm.Activate();
        }

        void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            var stRep = new CLSStimul(DetailTableName);
            stRep.Initialize();
            stRep.SetConnectionString();
            stRep.SetVariableValue(MasterId, gvShem1.ReturnId());
            stRep.Show();
        }

        void btnCopy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvShem1.GetFocusedDataRow() != null)
                ShowAddForm(int.Parse(gvShem1.GetFocusedDataRow()[MasterId].ToString()), false);
        }

        void btnCopyWithDetails_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvShem1.GetFocusedDataRow() != null)
            {
                SQLOperation.CopyRecordWithDetails(MasterTableName, DetailTableName,
                    int.Parse(gvShem1.GetFocusedDataRow()[MasterId].ToString()), FieldList, DetFieldList);
                FormActivated();
            }
        }

        void btnDetInsert_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvShem1.CanUserModifyData())
                ShowAddDetForm(0, false, int.Parse(gvShem1.GetFocusedDataRow()[MasterId].ToString()));
        }

        void btnDetEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DetEdit();
        }

        void DetEdit()
        {
            if (gvShem1.CanUserModifyData(gvShem2))
                ShowAddDetForm(gvShem2.ReturnInt32(), true,gvShem1.ReturnInt32());
        }

        void ShowAddDetForm(int id, bool editing, int masterId1)
        {
            var row = gvShem1.GetFocusedDataRow();
            if (row == null) return;
            foreach (var f in MdiParent.MdiChildren)
            {
                if (f is AddShem2Form)
                {
                    f.Activate();
                    return;
                }
            }

            var fm = new AddShem2Form(id, editing, DetailTableName, masterId1) {MdiParent = GlobalParameters.fmMain};
            fm.Show();
            fm.Activate();
        }

        void btnDetDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvShem1.CanUserModifyData(gvShem2))
                gvShem2.Delete();
            FillDetailTables();
        }

        void btnLayoutDet_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgShem2.SaveLayouts();
        }

        void chbShowLogDet_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvShem2.ShowChangeForm();
        }
    }
}