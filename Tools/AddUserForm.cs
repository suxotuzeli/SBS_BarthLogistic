using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.Parameters;

namespace SBS_BarthLogistic.Tools
{
    public partial class AddUserForm : XtraForm
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass1.Text) ||
                string.IsNullOrEmpty(txtPass2.Text))
            {
                XtraMessageBox.Show("ველები ცარიელია");
                txtPass1.Focus();
                return;
            }
            if (txtPass1.Text != txtPass2.Text)
            {
                XtraMessageBox.Show("პაროლები არ ემთხვევა ერთმანეთს");
                txtPass1.Focus();
                return;
            }

            const string s = "SBS_Market";

            if (SpAddUser(s))
            {
                if (InsertParams())
                    Close();
            }
        }

        bool InsertParams()
        {
            if (ProceduresClass.SpParamsForUsers(txtUser.Text, "spAddParamsForUser"))
                return ProceduresClass.SpParamsForUsers(txtUser.Text, "spInsertMISubPermissions");
            return false;
        }

        bool SpAddUser(string role)
        {
            SqlCommand comm = new SqlCommand("spAddUser", GlobalParameters.cn);
            comm.CommandType = CommandType.StoredProcedure;
            SqlParameter paUser1 = comm.Parameters.Add("@User1", SqlDbType.NVarChar, 20);
            SqlParameter paPass = comm.Parameters.Add("@Pass", SqlDbType.NVarChar, 20);
            SqlParameter paRoles = comm.Parameters.Add("@Roles", SqlDbType.NVarChar, 40);
            paUser1.Value = txtUser.Text;
            paPass.Value = txtPass1.Text;
            paRoles.Value = role;
            try
            {
                GlobalParameters.cn.Open();
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                e.ShowErrorDialog();
                return false;
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
        }

        void AddUserForm_Load(object sender, EventArgs e)
        {
        }
    }
}