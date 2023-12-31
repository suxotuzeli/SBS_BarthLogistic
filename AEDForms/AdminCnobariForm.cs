using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using SBS_BarthLogistic.AddForms;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AEDForms
{
    public partial class AdminCnobariForm : XtraForm
    {
        const string NameForReports = "AdminCnobari";
        const string StrComm = " SELECT * FROM AdminCnobari ";
        readonly string tableName;
        public AdminCnobariForm()
        {
            InitializeComponent();
            tableName = NameForReports;
        }

        void AdminCnobariForm_Load(object sender, EventArgs e)
        {
            CLSTools.GetFileList(NameForReports, cbExcel, "*.xls");

            foreach (DataRow dataRow in SQL.Select("SELECT InterfaceLanguage, Caption FROM InterfaceLanguage").Rows)
            {
                GridColumn gc = new GridColumn();
                gc.Caption = dataRow["Caption"].ToString();
                gc.FieldName = dataRow["InterfaceLanguage"].ToString();
                gc.Name = "col" + dataRow["InterfaceLanguage"];
                gc.Visible = true;
                gc.Width = 200;
                gvAdminCnobari.Columns.Add(gc);
            }
        }

        void AdminCnobariForm_Activated(object sender, EventArgs e)
        {
            gvAdminCnobari.FormActivate(StrComm);
        }

        void ShowAddForm(string id, bool editing)
        {
            if (new AddAdminCnobariForm(id, editing, tableName).ShowDialog() != DialogResult.OK) return;
            btnRefresh.PerformClick();
            CLSCustomCnobari.Initialize();
            GlobalParameters.Rc.SetMainButtonTexts(4);
        }

        void btnInsert_Click(object sender, ItemClickEventArgs e)
        {
            ShowAddForm("0", false);
        }

        void btnEdit_Click(object sender, ItemClickEventArgs e)
        {
            ShowAddForm(gvAdminCnobari.ReturnId(), true);
        }

        void btnCopy_Click(object sender, ItemClickEventArgs e)
        {
            ShowAddForm(gvAdminCnobari.ReturnId(), false);
        }

        void btnDelete_Click(object sender, ItemClickEventArgs e)
        {
            if (gvAdminCnobari.Delete())
                gvAdminCnobari.FormActivate(StrComm);
        }

        void btnExcel_Click(object sender, ItemClickEventArgs e)
        {
            var clsExcel = new CLSExcel(dgAdminCnobari, cbExcel.EditValue.ToString());
            clsExcel.Export();
        }

        void btnShowCaption_Click(object sender, ItemClickEventArgs e)
        {
            var rc = GlobalParameters.Rc;
            for (var i = 0; i < rc.Items.Count; i++)
            {
                if (!(rc.Items[i] is BarButtonItem) && !(rc.Items[i] is BarSubItem)) continue;
                if (rc.Items[i].Name.Length < 4) continue;
                var rbtn = rc.Items[i];
                if (rbtn.Tag == null)
                {
                    rbtn.Tag = rbtn.Caption;
                    rbtn.Caption = rbtn.Name;
                }
                else
                {
                    rbtn.Caption = rbtn.Tag.ToString();
                    rbtn.Tag = null;
                }
            }
            for (var i = 0; i < rc.Pages.Count; i++)
            {
                var page = rc.Pages[i];
                if (page.Tag == null)
                {
                    page.Tag = page.Text;
                    page.Text = page.Name;
                }
                else
                {
                    page.Text = page.Tag.ToString();
                    page.Tag = null;
                }


                for (var j = 0; j < page.Groups.Count; j++)
                {
                    var rbtn = page.Groups[j];
                    if (rbtn.Tag == null)
                    {
                        rbtn.Tag = rbtn.Text;
                        rbtn.Text = rbtn.Name;
                    }
                    else
                    {
                        rbtn.Text = rbtn.Tag.ToString();
                        rbtn.Tag = null;
                    }

                }
            }
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvAdminCnobari.FormActivate(StrComm);
        }
    }
}