using System;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.AddForms;
using SBS_BarthLogistic.AddForms;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AEDForms
{
    public partial class MdzForm : XtraForm
    {
        const string NameForReports = "Mdz";
        const string StrComm = "SELECT * FROM MdzView ";
        readonly string fieldName;
        readonly string tableName;
        AddMdzForm fmAddMdz;

        public MdzForm()
        {
            InitializeComponent();
            tableName = GlobalParameters.TableName;
            fieldName = GlobalParameters.FieldName;
        }

        public MdzForm(string tableName, string fieldName)
        {
            InitializeComponent();
            this.tableName = tableName;
            this.fieldName = fieldName;
        }

        void MdzForm_Load(object sender, EventArgs e)
        {
            CLSTools.GetFileList(NameForReports, cbExcel, "*.xls");
            Text = fieldName;
            gvMdz.ChangeFonts();
            gvMdz.DoubleClick += delegate { Edit(); };
        }

        void MdzForm_Activated(object sender, EventArgs e)
        {
            gvMdz.FormActivate(StrComm);
        }

        void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvMdz.FormActivate(StrComm);
        }

        void ShowAddForm(int id, bool editing)
        {
            fmAddMdz = new AddMdzForm(id, editing, tableName);
            CLSTools.MdiForm(fmAddMdz);
        }

        void btnInsert_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowAddForm(0, false);
        }

        void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Edit();
        }

        void Edit()
        {
            ShowAddForm(gvMdz.ReturnInt32(), true);
        }

        void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvMdz.Delete();
            MdzForm_Activated(sender, null);
        }

        void btnCopy_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowAddForm(gvMdz.ReturnInt32(), false);
        }

        void btnShowLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvMdz.ShowChangeForm();
        }

        void btnExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (cbExcel.EditValue == null)
            {
                CLSExcel.ExportToExcel(dgMdz);
                return;
            }
            var clsExcel = new CLSExcel(dgMdz, cbExcel.EditValue.ToString());
            clsExcel.Export();
        }

        void btnLayout_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgMdz.SaveLayouts();
        }
    }
}