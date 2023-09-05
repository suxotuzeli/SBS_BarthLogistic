using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.WayBill
{
    public partial class ImportWayBillToShesForm : XtraForm
    {
        const string TableName = "Shes1";
        readonly DataTable dtRs;
        readonly DateTime shesdata;
        readonly string zedd, idShesWayBill1,shen;
        CLSTableOperation clsShes1;
        int idMomc, newIdMomc;

        public ImportWayBillToShesForm(int idMomc, string idShesWayBill1, string zedd, string shen, DateTime shesdata, DataTable dtRs)
        {
            this.idMomc = idMomc;
            this.idShesWayBill1 = idShesWayBill1;
            this.zedd = zedd;
            this.shen = shen;
            this.dtRs = dtRs;
            this.shesdata = shesdata;
            InitializeComponent();
        }

        void ImportWayBillToShesForm_Load(object sender, EventArgs e)
        {
            clsShes1 = new CLSTableOperation(paShes1, TableName);
            AcceptButton = btnAdd;
            paShes1.ChangeFonts();
            SetDefaultValuesFromParameters();

            txtData.SetDateFormat();
            txtZedd.Text = zedd;
            txtShen.Text = shen;
            txtIdShesWayBill1.Text = idShesWayBill1;
            if (InterfaceParameters.RsDateSet)
                txtData.DateTime = Convert.ToDateTime(shesdata.ToShortDateString());
            GenerateIdProdValues();
            dgRealRs.DataSource = dtRs;
            if (idMomc > 0)
                cbMomc.SelectedValue = idMomc;
            gvRealRs.ChangeFonts();
            cbCalcType.SelectedValue = 10;
            chbFasiUpdate.Visible = OrgProdParameters.ShesSetRealFasi;
            gvRealRs.BestFitColumns();
        }

        void GenerateIdProdValues()
        {
            if (dtRs.Columns.IndexOf("IdProd") < 0)
            {
                dtRs.Columns.Add("IdProd", typeof(string));
                dtRs.Columns.Add("Prod", typeof(string));
                dtRs.Columns.Add("Dgg", typeof(double));
                dtRs.Columns.Add("Koef", typeof(double));
                dtRs.Columns.Add("WinaFasi", typeof(double));
                dtRs.Columns.Add("Sxvaoba", typeof(double));
                dtRs.Columns.Add("Fasi", typeof(double));
                dtRs.Columns.Add("RaodTanxa", typeof(double));
                dtRs.Columns.Add("CompRaodFasi", typeof(double));
                dtRs.Columns.Add("Unit", typeof(string));
            }
            for (var i = 0; i < dtRs.Rows.Count; i++)
            {
                using (
                    var dt =
                        SQL.Select(
                            "SELECT TOP 1 IdProd, Prod, Dgg, Koef, dbo.udfGetLasShesFasi(IdProd) as WinaFasi, Fasi" +
                            OrgProdParameters.ShesFG + " as Fasi, CompRaod, Unit " +
                            " FROM ProdMomcView WHERE IdMomc = " + idMomc + " AND MomcProdCode = N'" +
                            dtRs.Rows[i]["BAR_CODE"] + "'"))
                {
                    if (dt.Rows.Count > 0)
                    {
                        dtRs.Rows[i]["IdProd"] = dt.Rows[0]["IdProd"];
                        dtRs.Rows[i]["Dgg"] = dt.Rows[0]["Dgg"];
                        dtRs.Rows[i]["Prod"] = dt.Rows[0]["Prod"];
                        dtRs.Rows[i]["Koef"] = dt.Rows[0]["Koef"];
                        dtRs.Rows[i]["WinaFasi"] = dt.Rows.Count > 0 ? Convert.ToDouble(dt.Rows[0]["WinaFasi"])*Convert.ToDouble(dt.Rows[0]["Koef"]) : 0;
                        dtRs.Rows[i]["Sxvaoba"] = dt.Rows.Count > 0
                            ? Convert.ToDouble(dtRs.Rows[i]["WinaFasi"])-
                              Convert.ToDouble(dtRs.Rows[i]["PRICE"].ToString())
                            : 0;
                        dtRs.Rows[i]["Fasi"] = dt.Rows[0]["Fasi"];
                        dtRs.Rows[i]["CompRaodFasi"] = (Convert.ToDouble(dt.Rows[0]["Fasi"].ToString()) *
                                                        Convert.ToDouble(dtRs.Rows[i]["Koef"].ToString())).ToString();
                        dtRs.Rows[i]["RaodTanxa"] = Math.Round(Convert.ToDouble(dt.Rows[0]["Fasi"].ToString()) *
                                                               Convert.ToDouble(dtRs.Rows[i]["Koef"].ToString()) *
                                                               Convert.ToDouble(dtRs.Rows[i]["QUANTITY"].ToString()), 2)
                            .ToString();
                        dtRs.Rows[i]["Unit"] = dt.Rows[0]["Unit"];
                    }
                    else
                    {
                        dtRs.Rows[i]["IdProd"] = "---";
                        if (dtRs.Rows[i]["VAT_TYPE_NAME"].ToString() == "ჩვეულებრივი")
                            dtRs.Rows[i]["Dgg"] = 18;
                        else
                            dtRs.Rows[i]["Dgg"] = 0;
                        dtRs.Rows[i]["Koef"] = 1;
                        dtRs.Rows[i]["WinaFasi"] = 0;
                        dtRs.Rows[i]["Sxvaoba"] = 0;
                        dtRs.Rows[i]["Fasi"] = 0;
                        dtRs.Rows[i]["RaodTanxa"] = 0;
                        dtRs.Rows[i]["CompRaodFasi"] = 0;
                        dtRs.Rows[i]["Unit"] = string.Empty;
                    }
                    dtRs.AcceptChanges();
                }
            }
        }

        void SetDefaultValuesFromParameters()
        {
            cbProek.SelectedValue = DefaultValues.IdProek;
            cbShesT.SelectedValue = DefaultValues.IdShesT;
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dtRs.Rows)
            {
                if (dr["IdProd"].ToString() != "---" || !InterfaceParameters.RsFullImport) continue;
                XtraMessageBox.Show(
                    "ყველა პროდუქციაზე არაა არჩეული შესაბამისი კოდი, ნაწილობრივი ჩამოტვირთვა ვერ მოხდება");
                return;
            }
            var masterId = clsShes1.Insert();
            for (var i = 0; i < gvRealRs.RowCount; i++)
            {
                if (gvRealRs.GetRowCellValue(i, "IdProd").ToString() == "---")
                    continue;
                var str = new StringBuilder();
                str.Append(
                    "INSERT INTO dbo.Shes2 ( IdShes1, IdProd, Raod, Tanxa, TanxaTvitg, ShesDgg, IdVatType, CD, UN, FasiGas) VALUES  ( ");
                str.Append("" + masterId + ", ");
                str.Append("N'" + gvRealRs.GetRowCellValue(i, "IdProd") + "', ");
                str.Append("" +
                           (Convert.ToDouble(gvRealRs.GetRowCellValue(i, "QUANTITY")) *
                            Convert.ToDouble(gvRealRs.GetRowCellValue(i, "Koef"))) + ", ");
                str.Append("" + gvRealRs.GetRowCellValue(i, "AMOUNT") + ", ");
                str.Append("0, 0, "); //TanxaTvitg, ShesDgg
                str.Append(gvRealRs.GetRowCellValue(i, "VAT_TYPE") + ", "); //IdVatType
                str.Append("GETDATE(), N'" + GlobalParameters.UserName + "', " + gvRealRs.GetRowCellValue(i, "Fasi") +
                           ")");
                SQL.Insert(str.ToString());
            }
            if (OrgProdParameters.ShesSetRealFasi && chbFasiUpdate.Checked)
            {
                for (var i = 0; i < gvRealRs.RowCount; i++)
                {
                    if (gvRealRs.GetRowCellValue(i, "IdProd").ToString() == "---" ||
                        gvRealRs.GetDataRow(i).RowState != DataRowState.Modified)
                        continue;
                    var str = new StringBuilder();
                    str.Append("UPDATE Prod SET Fasi" + OrgProdParameters.ShesFG + " =" +
                               Convert.ToDouble(gvRealRs.GetRowCellValue(i, "Fasi")) + " WHERE IdProd=N'" +
                               gvRealRs.GetRowCellValue(i, "IdProd") + "'");
                    SQL.Update(str.ToString());
                }
            }
            DialogResult = DialogResult.OK;
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
                btnAdd.Enabled = true;
            }
        }

        void btnChangeMomcCode_Click(object sender, EventArgs e)
        {
            var dtrow = dtRs.Rows[gvRealRs.FocusedRowHandle];
            OrgProdParameters.IdProd = gvRealRs.GetFocusedRowCellValue(colRsBAR_CODE).ToString();
            OrgProdParameters.IdMomc = cbMomc.SelectedValue;
            OrgProdParameters.Prod = gvRealRs.GetFocusedRowCellValue(colRsW_NAME).ToString().Replace("'", @"""");
            OrgProdParameters.Fasi10 = Convert.ToDouble(gvRealRs.GetFocusedRowCellValue(colRsPRICE).ToString());
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

            if (txtIdProd.Text == "0" || txtIdProd.Text == "")
                return;
            using (var dt =
                SQL.Select("SELECT * FROM ProdMomc WHERE IdProd = N'" + txtIdProd.Text + "' AND IdMomc = " +
                           cbMomc.SelectedValue))
            {
                if (dt.Rows.Count == 0)
                {
                    var txtComm = "INSERT INTO dbo.ProdMomc ( IdProd, IdMomc, MomcProdCode, Koef ) VALUES  (N'" +
                                  txtIdProd.Text + "', " + cbMomc.SelectedValue + ", N'" +
                                  gvRealRs.GetFocusedRowCellValue(colRsBAR_CODE) + "', " + txtKoef.EditValue +
                                  "  )";
                    SQL.Insert(txtComm);
                }
                else
                    SQL.Update("UPDATE ProdMomc SET MomcProdCode = N'" + gvRealRs.GetFocusedRowCellValue(colRsBAR_CODE) +
                               "', Koef = N'" + txtKoef.EditValue + "' WHERE IdProd = N'" + txtIdProd.Text +
                               "' AND IdMomc = " + cbMomc.SelectedValue);
            }

            GenerateIdProdValues();
        }

        void gvRealRs_RowStyle(object sender, RowStyleEventArgs e)
        {
            var view = sender as GridView;
            if (e.RowHandle < 0)
                return;
            if (view == null)
                return;
            var value = view.GetRowCellDisplayText(e.RowHandle, view.Columns["Sxvaoba"]);
            e.Appearance.ForeColor = Math.Abs(Convert.ToDouble(value)) > 0.001 ? Color.Red : Color.Black;
        }

        void cbMomc_SelectedI()
        {
            var dt =
                SQL.Select("SELECT TOP 1 * FROM Momc WHERE IdMomc=" +
                           cbMomc.SelectedValue);
            if (dt.Rows.Count > 0)
            {
                chbIncludeDgg.Checked = Convert.ToBoolean(dt.Rows[0]["MomcPaidDgg"].ToString());
                newIdMomc = Convert.ToInt16(dt.Rows[0]["IdMomc"]);
            }
        }

        void cbMomc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMomc.SelectedValue.ToString().Length < 15)
            {
                cbMomc_SelectedI();
            }
        }

        void chbFasiUpdate_CheckedChanged(object sender, EventArgs e)
        {
            colFasi.Visible = chbFasiUpdate.Checked;
            colCompRaodFasi.Visible = chbFasiUpdate.Checked;
            colRaodTanxa.Visible = chbFasiUpdate.Checked;
        }

        void gvRealRs_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.RowHandle > -1)
            {
                var i = e.RowHandle;

                if (e.Column.Name == "colCompRaodFasi")
                    dtRs.Rows[i]["Fasi"] = Math.Round(Convert.ToDouble(dtRs.Rows[i]["CompRaodFasi"].ToString()) /
                                                      Convert.ToDouble(dtRs.Rows[i]["Koef"].ToString()), 3).ToString();
                if (e.Column.Name == "colFasi")
                    dtRs.Rows[i]["CompRaodFasi"] = (Convert.ToDouble(dtRs.Rows[i]["Fasi"].ToString()) *
                                                    Convert.ToDouble(dtRs.Rows[i]["Koef"].ToString())).ToString();
                dtRs.Rows[i]["RaodTanxa"] = Convert.ToDouble(dtRs.Rows[i]["CompRaodFasi"]) *
                                            Convert.ToDouble(dtRs.Rows[i]["QUANTITY"]);
            }
        }

        void cbMomc_Leave(object sender, EventArgs e)
        {
            cbMomc_SelectedI();
            idMomc = newIdMomc;
        }

        void btnNameMatch_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dtRs.Rows)
            {
                if (dr["IdProd"].ToString() == "---")
                {
                    var dt =
                        SQL.Select("SELECT TOP 1 IdProd, Prod FROM Prod WHERE Prod = N'" + dr["W_NAME"] + "'");
                    if (dt.Rows.Count > 0)
                    {
                        dr["IdProd"] = dt.Rows[0]["IdProd"];
                    }
                }
            }
        }

        void gvRealRs_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle > -1)
                txtKoef.Text = dtRs.Rows[gvRealRs.FocusedRowHandle]["Koef"].ToString();
        }
    }
}