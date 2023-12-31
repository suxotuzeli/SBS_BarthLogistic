using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.AddForms;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.FindForms;

namespace SBS_BarthLogistic.AEDForms
{
    public partial class SalForm : XtraForm
    {
        const string MasterId = "IdSal";
        const string MasterTableName = "Sal";
        const string StrComm = "SELECT * FROM SalView ";

        public SalForm()
        {
            InitializeComponent();
        }

        void SalForm_Load(object sender, EventArgs e)
        {
            Text = GlobalParameters.FieldName;
            dgSal.BindContextMenu(popSal);
            gvSal.ChangeFonts();
            CLSTools.InitializePeriod(cbPeriod, txtData1, txtData2);

            Activated += delegate { FormActivated(); };

            gvSal.DoubleClick += delegate { Edit(); };
        }

        void FormActivated()
        {
            gvSal.FormActivate(StrComm, txtData1, txtData2);
        }

        void ShowAddForm(int id, bool editing)
        {
            foreach (Form f in MdiParent.MdiChildren)
            {
                if (f is AddSalForm)
                {
                    f.Activate();
                    return;
                }
            }
            AddSalForm fm = new AddSalForm(id, editing, MasterTableName);
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
            if (gvSal.CanUserModifyData(gvSal))
                ShowAddForm(int.Parse(gvSal.GetFocusedRowCellValue(MasterId).ToString()), true);
        }

        void Edit()
        {
            if (gvSal.CanUserModifyData())
                ShowAddForm(int.Parse(gvSal.GetFocusedDataRow()[MasterId].ToString()), true);
        }

        void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvSal.CanUserModifyData())
                gvSal.Delete();
            FormActivated();
        }

        void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvSal.FormActivate(StrComm, txtData1, txtData2);
        }

        void btnFilterWithFindID_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgSal.MoveToId(StrComm);
        }

        void btnShowLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvSal.ShowChangeForm();
        }

        void btnFind_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in MdiParent.MdiChildren)
            {
                if (f is FSalForm)
                {
                    f.Activate();
                    return;
                }
            }
            FSalForm fmFSal = new FSalForm();
            fmFSal.MdiParent = MdiParent;
            fmFSal.Show();
            fmFSal.Activate();
        }

        void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            string strComm1 =
                string.Format("SELECT TOP 1 IdSal, Data, Zedd, Shen, '' Mizezi, Momc Gvari, '' SalAparati, " +
                              "CAST(Tanxa AS FLOAT) Tanxa, '' TanxaText FROM SalView WHERE IdSal = {0}",
                    gvSal.ReturnId());
            PrintSalZedd(strComm1);
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
            if (gvSal.GetFocusedDataRow() != null)
                ShowAddForm(int.Parse(gvSal.GetFocusedDataRow()[MasterId].ToString()), false);
        }

        void btnLayout_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgSal.SaveLayouts();
        }

        void btnPrintSalZedd_ItemClick(object sender, ItemClickEventArgs e)
        {
            string strComm1 =
                string.Format(
                    "SELECT TOP 1 IdSal, Data, N'პროდუქციის ღირებულება' Mizezi, Zedd, Factura, Gvari, '' SalAparati, Tanxa, '' TanxaText, Shen FROM SalView WHERE IdSal = {0}",
                    gvSal.ReturnValue("IdSal"));
            PrintSalZedd(strComm1);
        }
    }
}