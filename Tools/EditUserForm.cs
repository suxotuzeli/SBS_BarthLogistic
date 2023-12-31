using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.Tools
{
    public partial class EditUserForm : XtraForm
    {
        public EditUserForm()
        {
            InitializeComponent();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPass1.Text != txtPass2.Text)
            {
                XtraMessageBox.Show("არასწორი პაროლი");
                txtPass1.Focus();
                return;
            }

            SpChangePassword();
            Close();
        }

        void SpChangePassword()
        {
            var comm = new SqlCommand("spChangePassword", GlobalParameters.cn);
            comm.CommandType = CommandType.StoredProcedure;
            var paUser1 = comm.Parameters.Add("@User1", SqlDbType.VarChar, 50);
            var paNewPassword = comm.Parameters.Add("@NewPassword", SqlDbType.VarChar, 50);
            var paOldPassword = comm.Parameters.Add("@OldPassword", SqlDbType.VarChar, 50);
            paUser1.Value = GlobalParameters.UserName;
            paNewPassword.Value = txtPass1.Text;
            paOldPassword.Value = txtOldPass.Text;
            try
            {
                GlobalParameters.cn.Open();
                comm.ExecuteNonQuery();
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
        }

        void EditUserForm_Load(object sender, EventArgs e)
        {
        }
    }
}