using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;


namespace SBS_BarthLogistic.AddForms
{
    public partial class AddOrgServicesForm : XtraForm
    {
        readonly bool editing;
        readonly int id;
        readonly string tableName = "OrgServices";
        private int masterId;
        CLSTableOperation clsData;
        private FileStream FS;
        private byte[] img;

        public AddOrgServicesForm()
        {
            id = 0;
            editing = false;
            tableName = GlobalParameters.TableName;
            InitializeComponent();
        }
        public AddOrgServicesForm(int id, bool editing, int masterId)
        {
            this.id = id;
            this.editing = editing;
            this.masterId = masterId;
            InitializeComponent();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void AddOrgServicesForm_Load(object sender, EventArgs e)
        {
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);
            this.ChangeFonts();
            txtBeginDate.SetDateFormat();
            txtEndDate.SetDateFormat();
            GlobalParameters.IDForFind = 0;
            string[] strFields =
            {
                "IdOrg"
            };
            string[] strValues =
            {
                masterId.ToString()
            };
            clsData = new CLSTableOperation(this, tableName, strFields,strValues,true);

            if (id > 0)
            {
                Text = "ორგ(სერვისები) რედაქტირება";
                clsData.InitialazeControls(id);
            }
            else
                Text = "ორგ(სერვისები) ჩამატება";
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            clsData.Update(id);
            GlobalParameters.IDForFind = id;
            imgupdate(GlobalParameters.IDForFind);
            Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalParameters.IDForFind = clsData.Insert();
            imgupdate(GlobalParameters.IDForFind);
            //if (InterfaceParameters.CloseForm)
            Close();
        }
        private void imgupdate(int ids)
        {
            try
            {
                string query = "UPDATE OrgServices SET FileDoc=@img Where IdOrgServices=" + ids;
                SqlParameter picparameter = new SqlParameter();
                picparameter.SqlDbType = SqlDbType.VarBinary;
                picparameter.ParameterName = "img";
                picparameter.Value = img;
                SqlCommand cmd = new SqlCommand(query, GlobalParameters.cn);
                cmd.Parameters.Add(picparameter);
                GlobalParameters.cn.Open();
                cmd.ExecuteNonQuery();
                GlobalParameters.cn.Close();
            }

            catch (
                Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
        }

        private void btnFFileName_Click(object sender, EventArgs e)
        {
            OpenFileDialog fop = new OpenFileDialog();
            if (fop.ShowDialog() == DialogResult.OK)
            {
                FS = new FileStream(@fop.FileName, FileMode.Open, FileAccess.Read);
                img = new byte[FS.Length];
                FS.Read(img, 0, Convert.ToInt32(FS.Length));
                txtFileName.Text = fop.SafeFileName;
            }
            else
            {
                MessageBox.Show("ფაილი არაა არჩეული", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtFileName.Text = "";
            }
        }
    }
}
