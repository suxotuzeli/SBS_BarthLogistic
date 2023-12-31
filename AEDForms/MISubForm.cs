using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.AddForms;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AEDForms
{
    public partial class MISubForm : XtraForm
    {
        const string NameForReports = "MISub";
        readonly string fieldName;
        readonly string tableName;
        string strComm;

        public MISubForm()
        {
            InitializeComponent();
            tableName = GlobalParameters.TableName;
            fieldName = GlobalParameters.FieldName;
        }

        void MISubForm_Load(object sender, EventArgs e)
        {
            strComm =
                string.Format(" SELECT IdMISub, IdMIMain, MISub, TableList, ProcList, ViewList, ControlList, " +
                              " ISNULL((SELECT TOP 1 {0} FROM AdminCnobari WHERE FieldName = MISub), '') MIName " +
                              " FROM dbo.MISub ", InterfaceParameters.InterfaceLanguage);
            Text = fieldName;
            Activated += delegate { FormActivated(); };

            CLSTools.GetFileList(NameForReports, cbExcel, "*.xls");
        }

        void FormActivated()
        {
            gvMISub.FormActivate(strComm);
        }

        void ShowAddForm(string id, bool editing)
        {
            if (new AddMISubForm(id, editing, tableName).ShowDialog() != DialogResult.OK) return;
            btnRefresh.PerformClick();
            CLSCustomCnobari.Initialize();
        }

        void btnInsert_Click(object sender, ItemClickEventArgs e)
        {
            ShowAddForm("0", false);
        }

        void btnEdit_Click(object sender, ItemClickEventArgs e)
        {
            ShowAddForm(gvMISub.ReturnId(), true);
        }

        void btnCopy_Click(object sender, ItemClickEventArgs e)
        {
            ShowAddForm(gvMISub.ReturnId(), false);
        }

        void btnDelete_Click(object sender, ItemClickEventArgs e)
        {
            if (gvMISub.Delete())
                FormActivated();
        }

        void btnExcel_Click(object sender, ItemClickEventArgs e)
        {
            var clsExcel = new CLSExcel(dgMISub, cbExcel.EditValue.ToString());
            clsExcel.Export();
        }

        void btnLayout_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvMISub.SaveLayouts();
        }

        void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormActivated();
        }
    }
}