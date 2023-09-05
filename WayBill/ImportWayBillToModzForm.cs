using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.WayBill
{
    public partial class ImportWayBillToModzForm : XtraForm
    {
        const string TableName = "Modz1";
        readonly DataTable dtRs;
        readonly string zedd, idModzWayBill1;
        CLSTableOperation clsModz1;
        DateTime shesdata;

        public ImportWayBillToModzForm(string idShesWayBill1, string zedd, DateTime shesdata, DataTable dtRs)
        {
            idModzWayBill1 = idShesWayBill1;
            this.zedd = zedd;
            this.dtRs = dtRs;
            this.shesdata = shesdata;
            InitializeComponent();
        }

        void ImportWayBillToModzForm_Load(object sender, EventArgs e)
        {
            clsModz1 = new CLSTableOperation(panel2, TableName);
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, false);
            panel2.ChangeFonts();
            SetDefaultValuesFromParameters();
            txtData.SetDateFormat();
            txtZedd.Text = zedd;
            txtIdModzWayBill1.Text = idModzWayBill1;
            txtData.DateTime = Convert.ToDateTime(shesdata.ToShortDateString());
            GenerateIdProdValues();
            dgRealRs.DataSource = dtRs;
            gvRealRs.ChangeFonts();
        }

        void GenerateIdProdValues()
        {
            if (dtRs.Columns.IndexOf("IdProd") < 0)
            {
                dtRs.Columns.Add("IdProd", typeof (string));
            }
            for (var i = 0; i < dtRs.Rows.Count; i++)
            {
                using (
                    var dt =
                        SQL.Select("SELECT TOP 1 IdProd FROM Prod WHERE IdProd = N'" + dtRs.Rows[i]["BAR_CODE"] +
                                   "'"))
                {
                    if (dt.Rows.Count > 0)
                    {
                        dtRs.Rows[i]["IdProd"] = dt.Rows[0]["IdProd"];
                    }
                    else
                    {
                        dtRs.Rows[i]["IdProd"] = "---";
                    }
                }
            }
        }

        void SetDefaultValuesFromParameters()
        {
            if (DefaultValues.chbProek)
                cbProek1.EditValue = DefaultValues.IdProek;
            if (DefaultValues.chbModzT)
                cbModzT.EditValue = DefaultValues.IdModzT;
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var masterId = clsModz1.Insert();
            for (var i = 0; i < gvRealRs.RowCount; i++)
            {
                if (gvRealRs.GetRowCellValue(i, "IdProd").ToString() == "---")
                    continue;
                var str = new StringBuilder();
                str.Append("INSERT INTO dbo.Modz2 ( IdModz1, IdProd, Raod, CD, UN) VALUES  ( ");
                str.Append("" + masterId + ", ");
                str.Append("N'" + gvRealRs.GetRowCellValue(i, "IdProd") + "', ");
                str.Append("" + gvRealRs.GetRowCellValue(i, "QUANTITY") + ", ");
                str.Append("GETDATE(), N'" + GlobalParameters.UserName + "')");
                SQL.Insert(str.ToString());
            }
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

        void btnChangeMomcCode_Click(object sender, EventArgs e)
        {
            var dtrow = dtRs.Rows[gvRealRs.FocusedRowHandle];
            OrgProdParameters.IdProd = gvRealRs.GetFocusedRowCellValue(colRsBAR_CODE).ToString();
            OrgProdParameters.Prod = gvRealRs.GetFocusedRowCellValue(colRsW_NAME).ToString();
            OrgProdParameters.IdUnit = Convert.ToInt32(dtrow["UNIT_ID"]);
            if (OrgProdParameters.IdUnit == 99)
                OrgProdParameters.UnitName = dtrow.ItemArray[3].ToString();

            var txtIdProd = new TextEdit();
            DBClass.SelectFromProd("1", txtIdProd);
            OrgProdParameters.IdProd = "";
            OrgProdParameters.IdMomc = "";
            OrgProdParameters.Prod = "";
            OrgProdParameters.Fasi10 = 0;
            OrgProdParameters.IdUnit = 1;
            OrgProdParameters.UnitName = "";

            gvRealRs.SetFocusedRowCellValue(colRsIdProd, txtIdProd.Text);
        }
    }
}