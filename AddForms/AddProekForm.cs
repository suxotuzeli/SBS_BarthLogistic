using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddProekForm : XtraForm
    {
        readonly bool editing;
        readonly int id;
        readonly string tableName;
        CLSTableOperation clsProek;

        public AddProekForm()
        {
            id = 0;
            editing = false;
            tableName = GlobalParameters.TableName;
            InitializeComponent();
        }

        public AddProekForm(int id, bool editing, string tableName)
        {
            this.id = id;
            this.editing = editing;
            this.tableName = tableName;
            InitializeComponent();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void AddProekForm_Load(object sender, EventArgs e)
        {
            clsProek = new CLSTableOperation(this, tableName, false);
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);
            this.ChangeFonts();
            GlobalParameters.IDForFind = 0;

            if (id > 0)
            {
                clsProek.InitialazeControls(id);
                Text = "ობიექტი (რედაქტირება)";
            }
            else
                Text = "ობიექტი (ჩამატება)";
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            clsProek.Update(id);
            GlobalParameters.IDForFind = id;
            Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalParameters.IDForFind = clsProek.Insert();
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtProek.Text = "";
            txtProek.Focus();
            if (InterfaceParameters.CloseForm)
                Close();
        }
    }
}