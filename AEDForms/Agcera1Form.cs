using System;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.AddForms;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.FindForms;
using SBS_BarthLogistic.OtherForms;

namespace SBS_BarthLogistic.AEDForms
{
    public partial class Agcera1Form : XtraForm
    {
        const string MasterId = "IdAgcera1";
        const string MasterTableName = "Agcera1";
        const string DetailTableName = "Agcera2";
        const string StrComm = "SELECT * FROM Agcera1View ";
        const string StrCommDetail = "SELECT * FROM Agcera2View ";

        public Agcera1Form()
        {
            InitializeComponent();
        }


        void Agcera1Form_Load(object sender, EventArgs e)
        {
            Text = GlobalParameters.FieldName;
            dgAgcera1.BindContextMenu(popAgcera1);
            dgAgcera2.BindContextMenu(popAgcera2);

            gvAgcera1.ChangeFonts();
            gvAgcera2.ChangeFonts();
            CLSTools.InitializePeriod(cbPeriod, txtData1, txtData2);

            gvAgcera1.FocusedRowChanged += delegate { FillDetailTables(); };
            Activated += delegate { FormActivated(); };

            gvAgcera1.DoubleClick += delegate { Edit(); };
            gvAgcera2.DoubleClick += delegate { DetEdit(); };
        }

        void FormActivated()
        {
            gvAgcera1.FormActivate(StrComm, txtData1, txtData2);
        }

        void ShowAddForm(int id, bool editing)
        {
            foreach (var f in MdiParent.MdiChildren)
            {
                if (f is AddAgcera1Form)
                {
                    f.Activate();
                    return;
                }
            }

            var fm = new AddAgcera1Form(id, editing, MasterTableName) {MdiParent = MdiParent};
            fm.Show();
            fm.Activate();
        }

        void FillDetailTables()
        {
            dgAgcera1.FillDetails(dgAgcera2, StrCommDetail);
        }

        void btnInsert_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowAddForm(0, false);
        }

        void Edit()
        {
            if (gvAgcera1.CanUserModifyData())
                ShowAddForm(gvAgcera1.ReturnInt32(), true);
        }

        void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Edit();
        }

        void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gvAgcera1.CanUserModifyData()) return;
            if (gvAgcera1.Delete())
                FormActivated();
        }

        void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormActivated();
        }

        void btnFilterWithFindID_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgAgcera1.MoveToId(StrComm);
            FillDetailTables();
        }

        void btnShowLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvAgcera1.ShowChangeForm();
        }

        void btnFind_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (var f in MdiParent.MdiChildren)
            {
                if (f is FAgcera1Form)
                {
                    f.Activate();
                    return;
                }
            }

            var fmFAgcera1 = new FAgcera1Form {MdiParent = MdiParent};
            fmFAgcera1.Show();
            fmFAgcera1.Activate();
        }

        void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            var stRep = new CLSStimul(DetailTableName, dgAgcera2);
            stRep.Initialize();
            stRep.SetDefaultVariables(gvAgcera1.GetFocusedDataRow());
            stRep.Show();
        }

        void btnCopy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvAgcera1.GetFocusedDataRow() != null)
                ShowAddForm(gvAgcera1.ReturnInt32(), false);
        }

        void btnLayout_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgAgcera1.SaveLayouts();
        }

        void btnDetInsert_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvAgcera1.CanUserModifyData())
                ShowAddDetForm(0, false);
        }

        void btnDetEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DetEdit();
        }

        void DetEdit()
        {
            if (gvAgcera1.CanUserModifyData(gvAgcera2))
                ShowAddDetForm(gvAgcera2.ReturnInt32(), true);
        }

        void ShowAddDetForm(int id, bool editing)
        {
            var row = gvAgcera1.GetFocusedDataRow();
            if (row == null) return;
            foreach (var f in MdiParent.MdiChildren)
            {
                if (f is AddAgcera2Form)
                {
                    f.Activate();
                    return;
                }
            }

            var fm = new AddAgcera2Form(id, editing, DetailTableName, gvAgcera1.ReturnInt32()) {MdiParent = MdiParent};
            fm.Show();
            fm.Activate();
        }

        void btnDetDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gvAgcera1.CanUserModifyData(gvAgcera2)) return;
            if (gvAgcera2.Delete())
                FillDetailTables();
        }

        void btnLayoutDet_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgAgcera2.SaveLayouts();
        }

        void chbShowLogDet_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvAgcera2.ShowChangeForm();
        }

        void btnCheckNashti_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvAgcera1.GetFocusedDataRow() == null) return;
            using (var fm = new CheckNashtiAgceraForm(gvAgcera1.ReturnDate(), gvAgcera1.ReturnInt32("IdProek"),
                gvAgcera1.ReturnInt32()))
            {
                fm.ShowDialog();
                FillDetailTables();
            }
        }

        void btnAgcera2ExportToExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            CLSExcel.ExportToExcel(dgAgcera2);
        }

        void btnImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            var fm = new ImportFromExcelOldForm(new[]
            {
                "Raod"
            }, new[]
            {
                "Prod"
            }, MasterId, gvAgcera1.ReturnId(), true);
            fm.ShowDialog();
            fm.Dispose();
            FillDetailTables();
        }

        #region Additional

        void gridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            FillDetailTables();
        }

        void btnGad_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        void miImportFromExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            CLSExcel.ExportToExcel(dgAgcera1);
        }

        #endregion Additional
    }
}