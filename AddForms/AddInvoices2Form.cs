using System;
using System.Data;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddInvoices2Form : XtraForm
    {
        readonly bool editing;
        readonly int id, masterId;
        readonly string masterTableName;
        readonly string tableName;
        CLSTableOperation clsInvoices2;
        DataTable dtInvoices2;

        public AddInvoices2Form(int id, bool editing, string tableName, int masterId)
        {
            this.id = id;
            this.masterId = masterId;
            this.editing = editing;
            this.tableName = tableName;
            masterTableName = tableName.Substring(0, tableName.Length - 1) + "1";
            InitializeComponent();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void AddInvoices2Form_Load(object sender, EventArgs e)
        {
            string[] strFields =
            {
                "IdInvoices1"
            };
            string[] strValues =
            {
                masterId.ToString()
            };
            clsInvoices2 = new CLSTableOperation(paInvoices2, tableName, strFields, strValues, 1);

            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);
            btnAdd.Enabled = !InterfaceParameters.cbBScan;

            paInvoices2.ChangeFonts();
            gvInvoices2.ChangeFonts();

            if (id > 0)
            {
                Text = "ინვოისის რედაქტირება";
                clsInvoices2.InitialazeControls(id);
            }
            else
            {
                Text = "გასავლის ჩამატება";
                FilldtDet();
            }
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            clsInvoices2.Update(id);
            Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            clsInvoices2.Insert();
            FilldtDet();
            txtRaod.Value = 0;
        }

        void FilldtDet()
        {
            dtInvoices2 =
                SQL.Select(string.Format("SELECT * FROM {0}View WHERE Id{1} = {2} ORDER BY Id{0}", tableName,masterTableName, masterId));

            dgInvoices2.DataSource = dtInvoices2;
        }

        private void TxtRaod_Enter(object sender, EventArgs e)
        {
        }

        void dgDet_DoubleClick(object sender, EventArgs e)
        {
            txtRaod.Focus();
            txtRaod.Value = Convert.ToDecimal(gvInvoices2.ReturnValue("Raod"));
            cbService.EditValue = gvInvoices2.ReturnInt32("Service");
            clsInvoices2.Delete(gvInvoices2.ReturnInt32("Id" + tableName));
            FilldtDet();
            txtRaod.SelectAll();
        }

        private void cbService_EditValueChanged(object sender, EventArgs e)
        {
            if (cbService.EditValue == null) return;
            var dtService = SQL.Select("SELECT Fasi FROM dbo.Service WHERE IdService = " + cbService.EditValue);
            txtFasi.EditValue = dtService.Rows[0][0];
        }

        private void txtRaod_ValueChanged(object sender, EventArgs e)
        {
            laTanxaValue.Text = (txtRaod.Value * txtFasi.Value).ToString("F2");
        }
    }
}