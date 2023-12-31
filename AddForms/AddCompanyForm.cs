using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddCompanyForm : XtraForm
    {
        private readonly bool editing;
        private readonly int id;
        private readonly string tableName;
        private CLSTableOperation clsCompany;

        public AddCompanyForm()
        {
            id = 0;
            editing = false;
            tableName = GlobalParameters.TableName;
            InitializeComponent();
        }

        public AddCompanyForm(int id, bool editing)
        {
            this.id = id;
            this.editing = editing;
            InitializeComponent();
        }

        public AddCompanyForm(int id, bool editing, string tableName)
        {
            this.id = id;
            this.editing = editing;
            this.tableName = tableName;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddCompanyForm_Load(object sender, EventArgs e)
        {
            clsCompany = new CLSTableOperation(this, tableName, false);
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);
            this.ChangeFonts();
            GlobalParameters.IDForFind = 0;

            if (id > 0)
            {
                Text = "კომპანიის რეკვიზიტების რედაქტირება";
                clsCompany.InitialazeControls(id);
            }
            else
                Text = "კომპანიის რეკვიზიტების ჩამატება";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            clsCompany.Update(id);
            Company.ip = txtCompanyIP.Text;
            Company.su = txtServiceUser.Text;
            Company.sp = txtServicePassword.Text;
            Company.Address = txtCompanyAddress.Text;
            Company.Sagad = txtCompanySagad.Text;
            GlobalParameters.IDForFind = id;
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalParameters.IDForFind = clsCompany.Insert();

            txtCompanyName.Text = "";
            txtCompanyPhone.Text = "";
            txtCompanyDirek.Text = "";
        }
    }
}