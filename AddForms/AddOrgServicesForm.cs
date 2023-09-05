using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddOrgServicesForm : XtraForm
    {
        readonly bool editing;
        readonly int id;
        readonly string tableName = "OrgServices";
        private int masterId;
        CLSTableOperation clsData;

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
            Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalParameters.IDForFind = clsData.Insert();
            //if (InterfaceParameters.CloseForm)
            Close();
        }
    }
}