using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class ImportGadadebaToReal : XtraForm
    {
        const string TableName = "Real1";
        readonly DateTime data;
        readonly DataTable dtGadadeba;
        readonly int idProek;
        readonly string zedd, idGvari;
        CLSTableOperation clsReal1;

        public ImportGadadebaToReal(DataRow rowGadadeba, DataTable dtGadadeba)
        {
            zedd = rowGadadeba["Zedd"].ToString();
            data = DateTime.Today;
            idProek = Convert.ToInt32(rowGadadeba["IdProek"].ToString());
            idGvari = rowGadadeba["IdGvari"].ToString();
            this.dtGadadeba = dtGadadeba;
            InitializeComponent();
        }

        public bool Exported { get; private set; }

        void ImportGadadebaToReal_Load(object sender, EventArgs e)
        {
            clsReal1 = new CLSTableOperation(panel2, TableName);
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, false);
            panel2.ChangeFonts();
            SetDefaultValuesFromParameters();

            Text = "რეალიზაციაში  ჩამატება";
            txtData.SetDateFormat(true);
            txtDataFactura.SetDateFormat(true);
            txtActivateData.SetDateFormat(true, true);
            txtZedd.Text = zedd;
            dgGadadeba.DataSource = dtGadadeba;
            txtIdGvari.Id = idGvari;

            cbProek.SetLookUpEditValue(idProek.ToString());
            txtData.DateTime = data;
            gvGadadeba.ChangeFonts();
            Exported = false;
            if ((txtZedd.Text == ""))
                txtZedd.Text = SQLOperation.CalcZeddNum(TableName);
        }

        void SetDefaultValuesFromParameters()
        {
            if (DefaultValues.chbProek)
                cbProek.EditValue = DefaultValues.IdProek;
            if (DefaultValues.chbRealT)
                cbRealT.EditValue = DefaultValues.IdRealT;
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var masterId = clsReal1.Insert();
            for (var i = 0; i < gvGadadeba.RowCount; i++)
            {
                var str = new StringBuilder();
                str.Append("INSERT INTO dbo.Real2 ( IdReal1, IdProd, Raod, Tanxa, StandardFasi, CD, UN) VALUES  ( ");
                str.Append("" + masterId + ", ");
                str.Append("N'" + gvGadadeba.GetRowCellValue(i, "IdProd") + "', ");
                str.Append("" + Convert.ToDouble(gvGadadeba.GetRowCellValue(i, "Raod")) + ", ");
                str.Append("" + gvGadadeba.GetRowCellValue(i, "Tanxa") + ", ");
                str.Append("" + gvGadadeba.GetRowCellValue(i, "StandardFasi") + ", ");
                str.Append("GETDATE(), N'" + GlobalParameters.UserName + "')");
                SQL.Insert(str.ToString());
            }
            Exported = true;
            Close();
        }

        void txtData_Leave(object sender, EventArgs e)
        {
            if (!txtData.DateTime.CanUserModifyData())
            {
                XtraMessageBox.Show("თქვენ არ შეგიძლიათ ამ თარიღით ინფორმაციის შეტანა!", StringParameters.CaptionError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtData.Focus();
            }
            else
            {
                btnOK.Enabled = true;
                btnAdd.Enabled = true;
            }
        }

        void cbRealT_Enter(object sender, EventArgs e)
        {
            txtIdGvari.SearchForGvari();
            OrgProdParameters.selID = txtIdGvari.Id;
            if (OrgProdParameters.selID == "")
                txtIdGvari.Focus();
        }

        void txtIdGvari_Enter(object sender, EventArgs e)
        {
            if (!OrgProdParameters.GvariCodeInput)
            {
                cbRealT.Focus();
            }
        }

        void txtZedd_Leave(object sender, EventArgs e)
        {
            if ((txtZedd.Text == ""))
                txtZedd.Text = SQLOperation.CalcZeddNum(TableName);
        }
    }
}