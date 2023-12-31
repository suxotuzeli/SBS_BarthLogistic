using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.AddForms;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AEDForms
{
    public partial class AedAllForm : XtraForm
    {
        readonly string fieldName;
        readonly string tableName;
        AddAllForm fmAddAll;
        string selectString;

        public AedAllForm()
        {
            InitializeComponent();
            tableName = GlobalParameters.TableName;
            fieldName = GlobalParameters.FieldName;
        }

        public AedAllForm(string tableName, string fieldName)
        {
            InitializeComponent();
            this.tableName = tableName;
            this.fieldName = fieldName;
        }

        void AEDForm_Load(object sender, EventArgs e)
        {
            Text = fieldName;

            gv.Name = "gv" + tableName;
            dg.Name = "dg" + tableName;
            CLSAedAll aed = new CLSAedAll(tableName);
            selectString = aed.GetSelectString();
            aed.GenerateGridViewFields(gv);
            gv.ChangeFonts();
            dg.BindContextMenu(cmAED);
        }

        void ShowAddForm(int id, bool editing)
        {
            foreach (Form f in MdiParent.MdiChildren)
            {
                if (f.Name == fieldName)
                {
                    f.Activate();
                    return;
                }
            }
            fmAddAll = new AddAllForm(id, editing, tableName, fieldName);
            fmAddAll.MdiParent = MdiParent;
            fmAddAll.Show();
            fmAddAll.Activate();
        }

        void AEDForm_Activated(object sender, EventArgs e)
        {
            FormActivate();
        }

        void FormActivate()
        {
            gv.FormActivate(selectString);
        }

        void btnInsert_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowAddForm(0, false);
        }

        void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowAddForm(gv.ReturnInt32(), true);
        }

        void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gv.Delete())
                FormActivate();
        }

        void btnCopy_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowAddForm(gv.ReturnInt32(), false);
        }

        void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormActivate();
        }

        void dg_DoubleClick(object sender, EventArgs e)
        {
            ShowAddForm(gv.ReturnInt32(), true);
        }

        void btnExportToExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            CLSExcel.ExportToExcel(dg);
        }
    }
}