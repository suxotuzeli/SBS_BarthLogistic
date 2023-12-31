using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.Parameters;

namespace SBS_BarthLogistic.Tools
{
    public partial class DelUserForm : XtraForm
    {
        public DelUserForm()
        {
            InitializeComponent();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "sa")
                XtraMessageBox.Show("შეუძლებელია წავშალოთ მომხმარებელი sa");
            else
            {
                SpDeleteUser();
                DeleteParams();
            }
            Close();
        }

        void DeleteParams()
        {
            GlobalParameters.cn.Open();
            var txtComm = "DELETE Params WHERE UN = '" + txtUser.Text + "'";
            var comm = new SqlCommand(txtComm, GlobalParameters.cn);
            comm.ExecuteNonQuery();
            GlobalParameters.cn.Close();

            ProceduresClass.SpParamsForUsers(txtUser.Text, "spDeleteMISubPermissions");
        }

        void SpDeleteUser()
        {
            var comm = new SqlCommand("spDeleteUser", GlobalParameters.cn);
            comm.CommandType = CommandType.StoredProcedure;
            var paUser1 = comm.Parameters.Add("@User1", SqlDbType.NVarChar, 20);
            paUser1.Value = txtUser.Text;
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
    }
}