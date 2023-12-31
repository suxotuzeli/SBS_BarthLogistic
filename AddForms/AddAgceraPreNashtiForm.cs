using System;
using System.Data;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddAgceraPreNashtiForm : XtraForm
    {
        readonly bool editing;
        readonly int id, masterId;
        readonly string masterTableName;
        readonly string tableName;
        CLSTableOperation clsAgceraPreNashti;
        DataTable dtAgceraPreNashti;
        bool returnToId;

        public AddAgceraPreNashtiForm(int id, bool editing, string tableName, int masterId)
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

        void AddAgceraPreNashtiForm_Load(object sender, EventArgs e)
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
            clsAgceraPreNashti = new CLSTableOperation(paAgceraPreNashti, tableName, strFields, strValues, 1);

            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);
            btnAdd.Enabled = !InterfaceParameters.cbBScan;

            this.ChangeFonts();
            gvAgceraPreNashti.ChangeFonts();

            if (id > 0)
            {
                Text = "წინა დღის ნაშთის რედაქტირება";
                clsAgceraPreNashti.InitialazeControls(id);
            }
            else
            {
                Text = "წინა დღის ნაშთის ჩამატება";
                FilldtDet();
            }
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            clsAgceraPreNashti.Update(id);
            Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            clsAgceraPreNashti.Insert();
            returnToId = false;

            FilldtDet();

            txtIdProd.Id = "";
            txtIdProd.Focus();
        }

        void FilldtDet()
        {
            dtAgceraPreNashti =
                SQL.Select(string.Format("SELECT * FROM {0}View WHERE Id{1} = {2} ", tableName,
                    masterTableName, masterId));

            dgAgceraPreNashti.DataSource = dtAgceraPreNashti;
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
            txtIdProd.Id = gvAgceraPreNashti.ReturnValue("IdProd");
            txtRaod.Focus();
            txtRaod.Value = Convert.ToDecimal(gvAgceraPreNashti.ReturnValue("Raod"));
            clsAgceraPreNashti.Delete(gvAgceraPreNashti.ReturnInt32("Id" + tableName));
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