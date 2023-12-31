using System;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.AddForms;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AEDForms
{
    public partial class CompanyForm : XtraForm
    {
        const string NameForReports = "Company";
        const string StrComm = "SELECT * FROM Company ";
        readonly string fieldName;
        readonly string tableName;

        public CompanyForm()
        {
            InitializeComponent();
            tableName = GlobalParameters.TableName;
            fieldName = GlobalParameters.FieldName;
        }

        public CompanyForm(string tableName, string fieldName)
        {
            InitializeComponent();
            this.tableName = tableName;
            this.fieldName = fieldName;
        }

        void CompanyForm_Load(object sender, EventArgs e)
        {
            CLSTools.GetFileList(NameForReports, cbExcel, "*.xls");
            Text = fieldName;
            gvCompany.ChangeFonts();
            dgCompany.DoubleClick += delegate
            {
                ShowAddForm(gvCompany.ReturnInt32(), true);
            };
        }

        void CompanyForm_Activated(object sender, EventArgs e)
        {
            gvCompany.FormActivate(StrComm);
        }

        void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvCompany.FormActivate(StrComm);
        }

        void ShowAddForm(int id, bool editing)
        {
            foreach (var f in MdiParent.MdiChildren)
            {
                if (f is AddCompanyForm)
                {
                    f.Activate();
                    return;
                }
            }
            var fm = new AddCompanyForm(id, editing, tableName);
            fm.MdiParent = MdiParent;
            fm.Show();
            fm.Activate();
        }

        void btnExportToExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            var clsExcel = new CLSExcel(dgCompany, cbExcel.EditValue.ToString());
            clsExcel.Export();
        }

        void btnInsert_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowAddForm(0, false);
        }

        void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowAddForm(gvCompany.ReturnInt32(), true);
        }

        void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvCompany.Delete();
            CompanyForm_Activated(sender, null);
        }

        void btnCopy_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowAddForm(gvCompany.ReturnInt32(), false);
        }

        void btnShowLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvCompany.ShowChangeForm();
        }
    }
}