using System;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.AddForms;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AEDForms
{
    public partial class ZeddAutoForm : XtraForm
    {
        const string NameForReports = "ZeddAuto";
        readonly string fieldName;
        readonly string tableName;
        string strComm;

        public ZeddAutoForm()
        {
            InitializeComponent();
            tableName = GlobalParameters.TableName;
            fieldName = GlobalParameters.FieldName;
        }

        public ZeddAutoForm(string tableName, string fieldName)
        {
            InitializeComponent();
            this.tableName = tableName;
            this.fieldName = fieldName;
        }

        void ZeddAutoForm_Load(object sender, EventArgs e)
        {
            Text = fieldName;
            CLSTools.GetFileList(NameForReports, cbExcel, "*.xls");
            gvZeddAuto.ChangeFonts();
        }

        void ShowAddForm(int id, bool editing)
        {
            foreach (var f in MdiParent.MdiChildren)
            {
                if (f is AddZeddAutoForm)
                {
                    f.Activate();
                    return;
                }
            }
            var fm = new AddZeddAutoForm(id, editing, tableName);
            fm.MdiParent = MdiParent;
            fm.Show();
            fm.Activate();
        }

        void btnEdit_Click()
        {
            ShowAddForm(Convert.ToInt32(gvZeddAuto.ReturnId()), true);
        }

        void ZeddAutoForm_Activated(object sender, EventArgs e)
        {
            strComm = " SELECT IdZeddAuto, TableName, TableDesc, Sufics, Prefics, Num, Active FROM ZeddAuto ";
            gvZeddAuto.FormActivate(strComm);
        }

        void btnInsert_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowAddForm(0, false);
        }

        void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnEdit_Click();
        }

        void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvZeddAuto.Delete();
            ZeddAutoForm_Activated(sender, e);
        }

        void btnCopy_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowAddForm(Convert.ToInt32(gvZeddAuto.ReturnId()), false);
        }

        void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            ZeddAutoForm_Activated(sender, null);
        }

        void btnShowLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvZeddAuto.ShowChangeForm();
        }

        void btnExportToExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            var clsExcel = new CLSExcel(dgZeddAuto, cbExcel.EditValue.ToString());
            clsExcel.Export();
        }
    }
}