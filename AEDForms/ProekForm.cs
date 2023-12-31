using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using SBS_BarthLogistic.AddForms;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AEDForms
{
    public partial class ProekForm : XtraForm
    {
        const string StrComm ="SELECT * FROM Proek INNER JOIN ProekT ON Proek.IdProekT = ProekT.IdProekT ";

        readonly string fieldName;
        readonly string tableName;

        public ProekForm()
        {
            InitializeComponent();
            tableName = GlobalParameters.TableName;
            fieldName = GlobalParameters.FieldName;
        }

        public ProekForm(string tableName, string fieldName)
        {
            InitializeComponent();
            this.tableName = tableName;
            this.fieldName = fieldName;
        }

        void ProekForm_Load(object sender, EventArgs e)
        {
            Text = fieldName;
            gvProek.ChangeFonts();
            dgProek.BindContextMenu(popProek);
            dgProek.DoubleClick += delegate { EditProek(); };
        }

        void ProekForm_Activated(object sender, EventArgs e)
        {
            FormActivated();
        }

        void FormActivated()
        {
            gvProek.FormActivate(StrComm);
        }

        void ShowAddForm(int id, bool editing)
        {
            foreach (var f in MdiParent.MdiChildren)
            {
                if (f is AddProekForm)
                {
                    f.Activate();
                    return;
                }
            }
            var fm = new AddProekForm(id, editing, tableName);
            fm.MdiParent = MdiParent;
            fm.Show();
            fm.Activate();
        }


        void ShowAddProekSalaroForm(int id, bool editing)
        {

        }

        void ShowAddProekAkcia1Form(int id, bool editing)
        {

        }

        void ShowAddProekProdForm(int id, bool editing)
        {

        }

        void btnInsert_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowAddForm(0, false);
        }

        void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditProek();
        }

        void EditProek()
        {
            if (gvProek.GetFocusedDataRow() == null) return;
            ShowAddForm(gvProek.ReturnInt32(), true);
        }

        void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvProek.Delete())
                FormActivated();
        }

        void btnCopy_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowAddForm(gvProek.ReturnInt32(), false);
        }
    }
}