using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.Parameters;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddOrgProdForm : XtraForm
    {
        readonly bool editing;
        readonly int id, masterId;
        readonly string masterTableName;
        readonly string tableName = "OrgProd";
        CLSTableOperation clsOrgProd;
        DataTable dtGas2;
        bool returnToId;
        decimal startRaod, nashti;
        private bool closeAfterAdding;

        public AddOrgProdForm(int id, bool editing, int masterId,bool closeAfterAdding = false)
        {
            returnToId = false;
            this.id = id;
            this.masterId = masterId;
            this.editing = editing;
            this.closeAfterAdding = closeAfterAdding;
            masterTableName = "Org";
            InitializeComponent();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void AddOrgProdForm_Load(object sender, EventArgs e)
        {
            string[] strFields =
            {
                "IdOrg"
            };
            string[] strValues =
            {
                masterId.ToString()
            };
            clsOrgProd = new CLSTableOperation(paGas2, tableName, strFields, strValues, 1);

            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);
            btnAdd.Enabled = !InterfaceParameters.cbBScan;

            paGas2.ChangeFonts();
            gvOrgProd.ChangeFonts();

            if (id > 0)
            {
                Text = "ორგ(პროდუქცია) რედაქტირება";
                clsOrgProd.InitialazeControls(id);
            }
            else
            {
                Text = "ორგ(პროდუქცია)  ჩამატება";
                FillDet();
            }
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            clsOrgProd.Update(id);
            Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            clsOrgProd.Insert();
            returnToId = false;

            FillDet();
            txtIdProd.Text = txtProd.Text = txtPalet.Text = txtBox.Text = string.Empty;
            txtIdProd.Focus();
            if(closeAfterAdding)
                Close();
        }

        void FillDet()
        {
            dtGas2 = SQL.Select(string.Format("SELECT * FROM {0}View WHERE Id{1} = {2} ORDER BY Id{0}", tableName,
                    masterTableName, masterId));
            dgOrgProd.DataSource = dtGas2;
        }

        void dgDet_DoubleClick(object sender, EventArgs e)
        {
            txtIdProd.Text = gvOrgProd.ReturnValue("IdProd");
            txtProd.Text = gvOrgProd.ReturnValue("Prod");
            txtBox.Text = gvOrgProd.ReturnValue("Box");
            txtPalet.Text = gvOrgProd.ReturnValue("Palet");
            cbUnit.SetLookUpEditValue(gvOrgProd.ReturnInt32("IdUnit"));
            clsOrgProd.Delete(gvOrgProd.ReturnInt32());
            FillDet();
        }
    }
}