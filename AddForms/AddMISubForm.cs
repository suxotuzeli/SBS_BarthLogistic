using System;
using System.Data;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddMISubForm : XtraForm
    {
        readonly bool editing;
        readonly string id;
        readonly string tableName;
        CLSTableOperation clsMiSub;

        public AddMISubForm()
        {
            id = 0.ToString();
            editing = false;
            tableName = "MISub";
            InitializeComponent();
        }

        public AddMISubForm(string id, bool editing, string tableName)
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

        void AddMISubForm_Load(object sender, EventArgs e)
        {
            clsMiSub = new CLSTableOperation(this, tableName, false);
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);
            this.ChangeFonts();
            this.SetAddFormText(tableName, editing);
            GlobalParameters.IDForFind = 0;

            if (id != "0")
            {
                clsMiSub.InitialazeControls(id);
            }
            else
            {
                DataTable table = SQL.Select("SELECT MAX(IdMISub) + 1 FROM MISub");
                if (table.Rows.Count < 1) return;
                txtIdMISub.Text = table.Rows[0][0].ToString();
            }
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            clsMiSub.Update(id);
            GlobalParameters.IDForFind = Convert.ToInt32(id);
            Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalParameters.IDForFind = clsMiSub.Insert(false);
            Close();
        }

        void txtTableList_Leave(object sender, EventArgs e)
        {
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);
        }

        void txtTableList_Enter(object sender, EventArgs e)
        {
            AcceptButton = null;
        }
    }
}