using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.WayBill
{
    public partial class ImportWayBillToMDabrForm : XtraForm
    {
        const string TableName = "MDabr1";
        readonly DataTable dtRs;
        readonly int idMomc;
        readonly string zedd, idMDabrBill1;
        CLSTableOperation clsMDabr1;
        DateTime mDabrData;

        public ImportWayBillToMDabrForm(int idMomc, string idMDabrBill1, string zedd, DateTime mDabrData, DataTable dtRs)
        {
            this.idMomc = idMomc;
            this.idMDabrBill1 = idMDabrBill1;
            this.zedd = zedd;
            this.dtRs = dtRs;
            this.mDabrData = mDabrData;
            InitializeComponent();
        }

        void ImportWayBillToMDabrForm_Load(object sender, EventArgs e)
        {
            clsMDabr1 = new CLSTableOperation(paMDabr1, TableName);
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, false);
            paMDabr1.ChangeFonts();
            SetDefaultValuesFromParameters();
            txtData.SetDateFormat();
            txtZedd.Text = zedd;
            txtidMDabrBill1.Text = idMDabrBill1;
            if (InterfaceParameters.RsDateSet)
                txtData.DateTime = Convert.ToDateTime(mDabrData.ToShortDateString());
            GenerateIdProdValues();
            dgRealRs.DataSource = dtRs;
            if (idMomc > 0)
                cbMomc.SelectedValue = idMomc;
            gvRealRs.ChangeFonts();
        }

        void GenerateIdProdValues()
        {
            if (dtRs.Columns.IndexOf("IdProd") < 0)
            {
                dtRs.Columns.Add("IdProd", typeof(string));
                dtRs.Columns.Add("Prod", typeof(string));
                dtRs.Columns.Add("Dgg", typeof(double));
                dtRs.Columns.Add("Koef", typeof(double));
            }
            for (var i = 0; i < dtRs.Rows.Count; i++)
            {
                using (
                    var dt =
                        SQL.Select(
                            "SELECT TOP 1 IdProd, Prod, Dgg, Koef, dbo.udfGetLasShesFasi(IdProd) as WinaFasi FROM ProdMomcView WHERE IdMomc = " +
                            idMomc + " AND MomcProdCode = N'" + dtRs.Rows[i]["BAR_CODE"] + "'"))
                {
                    if (dt.Rows.Count > 0)
                    {
                        dtRs.Rows[i]["IdProd"] = dt.Rows[0]["IdProd"];
                        dtRs.Rows[i]["Prod"] = dt.Rows[0]["Prod"];
                        dtRs.Rows[i]["Dgg"] = dt.Rows[0]["Dgg"];
                        dtRs.Rows[i]["Koef"] = dt.Rows[0]["Koef"];
                    }
                    else
                    {
                        dtRs.Rows[i]["IdProd"] = "---";
                        dtRs.Rows[i]["Prod"] = string.Empty;
                        dtRs.Rows[i]["Dgg"] = 18;
                        dtRs.Rows[i]["Koef"] = 1;
                    }
                }
            }
        }

        void SetDefaultValuesFromParameters()
        {
            if (DefaultValues.chbProek)
                cbProek.EditValue = DefaultValues.IdProek;
            if (DefaultValues.chbShesT)
                cbMDabrT.EditValue = DefaultValues.IdMDabrT;
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var masterId = clsMDabr1.Insert();
            for (var i = 0; i < gvRealRs.RowCount; i++)
            {
                if (gvRealRs.GetRowCellValue(i, "IdProd").ToString() == "---")
                    continue;
                var str = new StringBuilder();
                str.Append("INSERT INTO dbo.Mdabr2 ( IdMDabr1, IdProd, Raod, Fasi, CD, UN) VALUES  ( ");
                str.Append("" + masterId + ", ");
                str.Append("N'" + gvRealRs.GetRowCellValue(i, "IdProd") + "', ");
                str.Append("" +
                           (Convert.ToDouble(gvRealRs.GetRowCellValue(i, "QUANTITY")) *
                            Convert.ToDouble(gvRealRs.GetRowCellValue(i, "Koef"))) + ", ");
                str.Append("" +
                           (Convert.ToDouble(gvRealRs.GetRowCellValue(i, "AMOUNT")) /
                            (Convert.ToDouble(gvRealRs.GetRowCellValue(i, "QUANTITY")) *
                             Convert.ToDouble(gvRealRs.GetRowCellValue(i, "Koef"))) + ", "));
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
            OrgProdParameters.IdMomc = cbMomc.SelectedValue;
            OrgProdParameters.Prod = gvRealRs.GetFocusedRowCellValue(colRsW_NAME).ToString();
            OrgProdParameters.Fasi10 = Convert.ToDouble(gvRealRs.GetFocusedRowCellValue(colRsPRICE).ToString());
            OrgProdParameters.IdUnit = Convert.ToInt32(dtrow["UNIT_ID"]);
            if (OrgProdParameters.IdUnit == 99)
                OrgProdParameters.UnitName = dtrow.ItemArray[3].ToString();

            var txtIdProd = new TextEdit();
            //txtIdProd.Id = OrgProdParameters.Prod;
            DBClass.SelectFromProd("1", txtIdProd);
            OrgProdParameters.IdProd = "";
            OrgProdParameters.IdMomc = "";
            OrgProdParameters.Prod = "";
            OrgProdParameters.Fasi10 = 0;
            OrgProdParameters.IdUnit = 1;
            OrgProdParameters.UnitName = "";

            //            SQL.Update("UPDATE ProdMomc SET MomcProdCode = N'" + gvRealRs.GetFocusedRowCellValue(colRsBAR_CODE) + "' WHERE IdProd = N'" + txtIdProd.Id + "' AND IdMomc = " + cbMomc.SelectedValue);
            using (
                var dt =
                    SQL.Select("SELECT * FROM ProdMomc WHERE IdProd = N'" + txtIdProd.Text + "' AND IdMomc = " +
                               cbMomc.SelectedValue))
            {
                if (string.IsNullOrEmpty(txtIdProd.Text))
                    return;
                if (dt.Rows.Count == 0)
                {
                    var txtComm = "INSERT INTO dbo.ProdMomc ( IdProd, IdMomc, MomcProdCode, Koef ) VALUES  (N'" +
                                  txtIdProd.Text + "', " + cbMomc.SelectedValue + ", N'" +
                                  gvRealRs.GetFocusedRowCellValue(colRsBAR_CODE) + "', " + txtKoef.Value + "  )";
                    SQL.Insert(txtComm);
                }
                else
                    SQL.Update("UPDATE ProdMomc SET MomcProdCode = N'" + gvRealRs.GetFocusedRowCellValue(colRsBAR_CODE) +
                               "' WHERE IdProd = N'" + txtIdProd.Text + "' AND IdMomc = " + cbMomc.SelectedValue);
            }

            GenerateIdProdValues();
        }
    }
}