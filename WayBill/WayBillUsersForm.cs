using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.WayBill
{
    public partial class WayBillUsersForm : XtraForm
    {
        readonly int operationType;
        readonly string user, pass;
        readonly CLSWayBillOperation wayBill = new CLSWayBillOperation();

        public WayBillUsersForm(string user, string pass, int operationType)
        {
            this.user = user;
            this.pass = pass;
            this.operationType = operationType;
            InitializeComponent();
        }

        void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        void WayBillUsers_Load(object sender, EventArgs e)
        {
            txtPass.Text = pass;
            txtUser.Text = user;
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            switch (operationType)
            {
                case 1:
                    InsertUser();
                    break;
                case 2:
                    UpdateUser();
                    break;
                case 3:
                    ChangePass();
                    break;
            }
        }

        void InsertUser()
        {
            XtraMessageBox.Show(wayBill.CreateServiceUser(txtUser.Text, txtPass.Text, txtIp.Text, txtName.Text,
                txtSu.Text, txtSp.Text) ? "შეიქმნა მომხმარებელი" : "ვერ შეიქმნა მომხმარებელი");
        }

        void UpdateUser()
        {
            XtraMessageBox.Show(wayBill.UpdateServiceUser(txtUser.Text, txtPass.Text, txtIp.Text, txtName.Text,
                txtSu.Text, txtSp.Text) ? "განახლდა მომხმარებელი" : "ვერ განახლდა მომხმარებელი");
        }

        void ChangePass()
        {
            wayBill.CheckServiceUser();
        }
    }
}