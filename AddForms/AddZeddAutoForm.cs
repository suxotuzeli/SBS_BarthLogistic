using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddZeddAutoForm : XtraForm
    {
        private readonly bool Editing;
        private readonly int ID;
        private readonly string TableName;
        private CLSTableOperation clsReal1;

        public AddZeddAutoForm()
        {
            InitializeComponent();
        }

        public AddZeddAutoForm(int ID, bool Editing)
        {
            this.ID = ID;
            this.Editing = Editing;
            InitializeComponent();
        }

        public AddZeddAutoForm(int ID, bool Editing, string TableName)
        {
            this.ID = ID;
            this.Editing = Editing;
            this.TableName = TableName;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddZeddAutoForm_Load(object sender, EventArgs e)
        {
            clsReal1 = new CLSTableOperation(this, TableName);
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, Editing);
            if (ID > 0)
            {
                clsReal1.InitialazeControls(ID);
                Text = "რედაქტირება";
            }
            else
                Text = "ჩამატება";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            clsReal1.Update(ID);
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
//            string strComm = "INSERT INTO " + TableName
//                + "(" + TableName + ", " + "Man, Nom, Mocm, IdGvari) "
//                + " VALUES (N'" + txtPrefics.Text + "'"
//                + ", N'" + txtSufics.Text + "'"
//                + ", N'" + txtNom.Text + "'"
//                + ", N'" + txtMocm.Text + "'"
//                + ", " + cbGvari.SelectedValue + " "
//                + ") "
//                + ";SELECT SCOPE_IDENTITY()";
//            InterfaceParameters.IDForFind = DBClass.InsertDT(strComm);
//            txtPrefics.Text = "";
//            txtPrefics.Focus();
        }
    }
}