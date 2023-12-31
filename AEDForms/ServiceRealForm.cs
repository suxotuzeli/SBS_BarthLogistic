using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.AddForms;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.FindForms;
using SBS_BarthLogistic.OtherForms;

namespace SBS_BarthLogistic.AEDForms
{
    public partial class ServiceRealForm : XtraForm
    {
        const string MasterId = "IdServiceReal";
        const string MasterTableName = "ServiceReal";
        const string StrComm = "SELECT * FROM ServiceRealView ";

        public ServiceRealForm()
        {
            InitializeComponent();
        }

        void SalForm_Load(object sender, EventArgs e)
        {
            Text = GlobalParameters.FieldName;
            dgServiceReal.BindContextMenu(popSal);
            gvServiceReal.ChangeFonts();
            CLSTools.InitializePeriod(cbPeriod, txtData1, txtData2);

            Activated += delegate { FormActivated(); };

            gvServiceReal.DoubleClick += delegate { Edit(); };
        }

        void FormActivated()
        {
            gvServiceReal.FormActivate(StrComm, txtData1, txtData2);
        }

        void ShowAddForm(int id, bool editing)
        {
            foreach (Form f in MdiParent.MdiChildren)
            {
                if (f is AddServiceRealForm)
                {
                    f.Activate();
                    return;
                }
            }
            AddServiceRealForm fm = new AddServiceRealForm(id, editing, MasterTableName);
            fm.MdiParent = MdiParent;
            fm.Show();
            fm.Activate();
        }

        void btnInsert_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowAddForm(0, false);
        }

        void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvServiceReal.CanUserModifyData(gvServiceReal))
                ShowAddForm(int.Parse(gvServiceReal.GetFocusedRowCellValue(MasterId).ToString()), true);
        }

        void Edit()
        {
            if (gvServiceReal.CanUserModifyData())
                ShowAddForm(int.Parse(gvServiceReal.GetFocusedDataRow()[MasterId].ToString()), true);
        }

        void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvServiceReal.CanUserModifyData())
                gvServiceReal.Delete();
            FormActivated();
        }

        void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvServiceReal.FormActivate(StrComm, txtData1, txtData2);
        }

        void btnFilterWithFindID_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgServiceReal.MoveToId(StrComm);
        }

        void btnShowLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvServiceReal.ShowChangeForm();
        }

        void btnFind_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in MdiParent.MdiChildren)
            {
                if (f is FServiceRealForm)
                {
                    f.Activate();
                    return;
                }
            }
            FServiceRealForm fmFSal = new FServiceRealForm();
            fmFSal.MdiParent = MdiParent;
            fmFSal.Show();
            fmFSal.Activate();
        }


        void PrintSalZedd(string strComm1)
        {
            DataTable dtSalZedd = SQL.Select(strComm1);
            for (int i = 0; i < dtSalZedd.Rows.Count; i++)
            {
                dtSalZedd.Rows[i]["TanxaText"] =
                    CLSTools.ReturnTanxaText(Convert.ToDouble(dtSalZedd.Rows[i]["Tanxa"].ToString()));
            }
            CLSStimul stRep = new CLSStimul();
            stRep.ReportName = "SalShem";
            stRep.Initialize();
            stRep.SetDefaultVariables(dtSalZedd, 0);
            stRep.Show();
        }

        void btnCopy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvServiceReal.GetFocusedDataRow() != null)
                ShowAddForm(int.Parse(gvServiceReal.GetFocusedDataRow()[MasterId].ToString()), false);
        }

        void btnLayout_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgServiceReal.SaveLayouts();
        }

        void btnPrintSalZedd_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void BtnDailyFees_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var fm = new DailyFees())
            {
                fm.ShowDialog();
                FormActivated();
            }
        }

        private void btnCreateInvoice_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ans = XtraMessageBox.Show("შევქმა მონიშნული სერვისების ინვოისი ?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (ans == DialogResult.No) return;


            XtraMessageBox.Show("დაგენერირების კლოგიკა არ არის გრანსაზღვრული", "", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}