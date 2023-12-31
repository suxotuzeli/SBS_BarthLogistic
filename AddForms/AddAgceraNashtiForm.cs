using System;
using System.Data;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddAgceraNashtiForm : XtraForm
    {
        readonly bool editing;
        readonly int id, masterId;
        readonly string masterTableName;
        readonly string tableName;
        CLSTableOperation clsAgceraNashti;
        DataTable dtAgceraNashti;
        bool returnToId;

        public AddAgceraNashtiForm(int id, bool editing, string tableName, int masterId)
        {
            returnToId = false;
            this.id = id;
            this.masterId = masterId;
            this.editing = editing;
            this.tableName = tableName;
            masterTableName = "Agcera1";
            InitializeComponent();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void AddAgceraNashtiForm_Load(object sender, EventArgs e)
        {
            string[] strFields =
            {
                "IdAgcera1"
            };
            string[] strValues =
            {
                ""
            };
            strValues[0] = masterId.ToString();
            clsAgceraNashti = new CLSTableOperation(paAgceraNashti, tableName, strFields, strValues, 1);

            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);
            btnAdd.Enabled = !InterfaceParameters.cbBScan;

            this.ChangeFonts();
            gvAgceraNashti.ChangeFonts();

            if (id > 0)
            {
                Text = "აღწერა/ნაშთი რედაქტირება";
                clsAgceraNashti.InitialazeControls(id);
            }
            else
            {
                Text = "აღწერა/ნაშთი ჩამატება";
                FilldtDet();
            }
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            clsAgceraNashti.Update(id);
            Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            clsAgceraNashti.Insert();
            returnToId = false;

            FilldtDet();

            txtIdProd.Id = "";
            txtIdProd.Focus();
        }

        void FilldtDet()
        {
            dtAgceraNashti =
                SQL.Select(string.Format("SELECT * FROM {0}View WHERE Id{1} = {2} ", tableName,
                    masterTableName, masterId));

            dgAgceraNashti.DataSource = dtAgceraNashti;
        }

        void txtRaod_Enter(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            txtIdProd.SearchForProd();
            OrgProdParameters.selID = txtIdProd.Id;
            txtRaod.SelectAll();
            if (OrgProdParameters.selID == "")
                txtIdProd.Focus();
        }

        void dgDet_DoubleClick(object sender, EventArgs e)
        {
            txtIdProd.Id = gvAgceraNashti.ReturnValue("IdProd");
            txtRaod.Focus();
            txtRaod.Value = Convert.ToDecimal(gvAgceraNashti.ReturnValue("Raod"));
            clsAgceraNashti.Delete(gvAgceraNashti.ReturnInt32("Id" + tableName));
            FilldtDet();
            txtRaod.SelectAll();
        }

        void txtIdProd_Leave(object sender, EventArgs e)
        {
        }

        void txtIdProd_Enter(object sender, EventArgs e)
        {
            btnAdd.Enabled = !InterfaceParameters.cbBScan;
            if (!OrgProdParameters.ProdCodeInput && !editing && !returnToId)
                txtRaod.Focus();
        }
    }
}