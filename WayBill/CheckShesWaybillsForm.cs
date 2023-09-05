using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.AddForms;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.WayBill
{
    public partial class CheckShesWaybillsForm : XtraForm
    {
        readonly DateTime dataBegin;
        readonly CLSWayBillOperation wayBill = new CLSWayBillOperation();

        GridControl activeControl;
        DataTable dtRs = new DataTable();
        DataTable dtRsHeaders = new DataTable();
        string sagad;

        public CheckShesWaybillsForm(string sagad, DateTime dataBegin)
        {
            this.sagad = sagad;
            this.dataBegin = dataBegin;
            InitializeComponent();
        }

        public void CheckFilter(params int[] chb)
        {
            foreach (var i in chb)
            {
                var chkbox = (CheckEdit)Controls.Find("chb" + i, true)[0];
                if (chkbox != null)
                    chkbox.Checked = true;
            }
        }

        void CheckWaybillsForm_Load(object sender, EventArgs e)
        {
            OrgProdParameters.ShesFG = 10;
            txtDataBegin1.SetDateFormat();
            txtDataBegin2.SetDateFormat();
            txtDataClose1.SetDateFormat();
            txtDataClose2.SetDateFormat();
            txtDataCreate1.SetDateFormat();
            txtDataCreate2.SetDateFormat();
            txtDataDelivery1.SetDateFormat();
            txtDataDelivery2.SetDateFormat();
            gvReal1.ChangeFonts();
            gvReal2.ChangeFonts();
            gvRealRs.ChangeFonts();
            if (string.IsNullOrEmpty(sagad))
                return;
            chbSagad.Checked = true;
            txtSagad.Text = sagad;
            chbDataBegin.Checked = true;
            txtDataBegin1.Visible = txtDataBegin2.Visible = true;
            txtDataBegin1.EditValue = txtDataBegin2.EditValue = dataBegin;
            dgReal1.RestoreLayoutFromXml();
        }

        void btnImportWaybills_Click(object sender, EventArgs e)
        {
            DateTime? dataBegin1,
                dataBegin2,
                dataClose1,
                dataClose2,
                dataCreate1,
                dataCreate2,
                dataDelivery1,
                dataDelivery2;
            decimal? tanxa;
            string piradiNom = "", zedd = "", man = "", comment = "";

            if (chbDataBegin.Checked)
            {
                dataBegin1 = txtDataBegin1.DateTime;
                dataBegin2 = txtDataBegin2.DateTime.AddDays(1);
            }
            else
            {
                dataBegin1 = null;
                dataBegin2 = null;
            }

            if (chbDataClose.Checked)
            {
                dataClose1 = txtDataClose1.DateTime;
                dataClose2 = txtDataClose2.DateTime.AddDays(1);
            }
            else
            {
                dataClose1 = null;
                dataClose2 = null;
            }

            if (chbDataCreate.Checked)
            {
                dataCreate1 = txtDataCreate1.DateTime;
                dataCreate2 = txtDataCreate2.DateTime.AddDays(1);
            }
            else
            {
                dataCreate1 = null;
                dataCreate2 = null;
            }

            if (chbDataDelivery.Checked)
            {
                dataDelivery1 = txtDataDelivery1.DateTime;
                dataDelivery2 = txtDataDelivery2.DateTime.AddDays(1);
            }
            else
            {
                dataDelivery1 = null;
                dataDelivery2 = null;
            }

            if (chbTanxa.Checked)
            {
                tanxa = Convert.ToDecimal(txtTanxa.Text);
            }
            else
            {
                tanxa = null;
            }

            if (chbMan.Checked)
            {
                man = txtMan.Text;
            }

            if (chbPiradiNom.Checked)
            {
                piradiNom = txtPiradiNom.Text;
            }

            if (chbSagad.Checked)
            {
                sagad = txtSagad.Text;
            }

            if (chbZedd.Checked)
            {
                zedd = txtZedd.Text;
            }

            if (chbComment.Checked)
            {
                comment = txtComment.Text;
            }

            //            string status = GenerateStatus(gbZeddStatus);
            const string status = "";
            var type = GenerateStatus(gbZeddType);

            dtRsHeaders = wayBill.GetBuyerWayBills(dataBegin1, dataBegin2, dataCreate1, dataCreate2, dataDelivery1,
                dataDelivery2, dataClose1, dataClose2, man, piradiNom, zedd, sagad,
                tanxa, type, status, comment);
            dtRsHeaders.Columns.Add("TypeText");
            if (dtRsHeaders != null || dtRsHeaders.Rows.Count == 0)
            {
                dtRsHeaders.Columns.Add("Tanxa", typeof(decimal));
                for (var i = 0; i < dtRsHeaders.Rows.Count; i++)
                {
                    dtRsHeaders.Rows[i]["Tanxa"] =
                        Convert.ToDouble(
                            SQL.ExecuteScalar("SELECT ISNULL(SUM(Tanxa), 0) FROM ShesView WHERE Zedd = N'" +
                                              dtRsHeaders.Rows[i]["WAYBILL_NUMBER"] + "'")) +
                        Convert.ToDouble(
                            SQL.ExecuteScalar("SELECT ISNULL(SUM(Tanxa), 0) FROM MDabrView WHERE Zedd = N'" +
                                              dtRsHeaders.Rows[i]["WAYBILL_NUMBER"] + "'"));

                    dtRsHeaders.Rows[i]["IS_CONFIRMED"] = dtRsHeaders.Rows[i]["IS_CONFIRMED"].ToString() == "0"
                        ? "დაუდასტურებელი"
                        : "დადასტურებული";
                    switch (dtRsHeaders.Rows[i]["STATUS"].ToString())
                    {
                        case "1":
                            dtRsHeaders.Rows[i]["STATUS"] = "აქტიური";
                            break;
                        case "2":
                            dtRsHeaders.Rows[i]["STATUS"] = "დასრულებული";
                            break;
                        case "-2":
                            dtRsHeaders.Rows[i]["STATUS"] = "გაუქმებული";
                            break;
                    }
                    switch (dtRsHeaders.Rows[i]["TYPE"].ToString())
                    {
                        case "1":
                            dtRsHeaders.Rows[i]["TypeText"] = "შიდა გადაზიდვა";
                            break;
                        case "2":
                            dtRsHeaders.Rows[i]["TypeText"] = "ტრანსპორტირებით";
                            break;
                        case "3":
                            dtRsHeaders.Rows[i]["TypeText"] = "ტრანსპორტირების გარეშე";
                            break;
                        case "4":
                            dtRsHeaders.Rows[i]["TypeText"] = "დისტრიბუცია";
                            break;
                        case "5":
                            dtRsHeaders.Rows[i]["TypeText"] = "უკან დაბრუნება";
                            break;
                        case "6":
                            dtRsHeaders.Rows[i]["TypeText"] = "ქვეზედნადები";
                            break;
                    }
                }

                dgReal1.DataSource = dtRsHeaders;
            }
            else
            {
                MessageBox.Show("არ მოიძებნა ინფორმაცია");
                dgReal1.DataSource = null;
            }
            gvReal1_FocusedRowChanged(null, null);
            gvReal1.BestFitColumns();
        }

        static string GenerateStatus(GroupControl gb)
        {
            var str = new StringBuilder();
            foreach (var control in gb.Controls)
            {
                var chb = (CheckEdit)control;
                if (chb.Checked)
                    str.Append(chb.Tag + ",");
            }
            return str.ToString().Length > 0 ? str.ToString().Remove(str.Length - 1, 1) : "";
        }

        void chbDataCreate_CheckedChanged(object sender, EventArgs e)
        {
            var name = "txt" + ((Control)sender).Name.Remove(0, 3);
            panel2.Controls[name + "1"].Visible = panel2.Controls[name + "2"].Visible = ((CheckEdit)sender).Checked;
        }

        void chbZedd_CheckedChanged(object sender, EventArgs e)
        {
            var name = ((Control)sender).Name.Remove(0, 3);
            panel2.Controls["txt" + name].Visible = ((CheckEdit)sender).Checked;
            if (((CheckEdit)sender).Checked)
                panel2.Controls["txt" + name].Focus();
        }

        void gvReal1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            FocusedRowChanged();
        }

        void FocusedRowChanged()
        {
            var row = gvReal1.GetFocusedDataRow();
            if (row == null) return;
            var idWayBill = Convert.ToInt32(gvReal1.GetFocusedRowCellValue(colID).ToString());
            var zedd = gvReal1.GetFocusedRowCellValue(colWAYBILL_NUMBER).ToString();
            FillRealDetail(idWayBill, zedd);
        }

        void FillRealDetail(int idWayBill, string zedd)
        {
            using (var ds = wayBill.GetWayBillDataSet(idWayBill))
            {
                if (ds.Tables.Count <= 2)
                {
                    MessageBox.Show("არ მოიძებნა ინფორმაცია");
                    dgRealRs.DataSource = null;
                    return;
                }
                DataTable dtRealRs = ds.Tables[2];
                dtRealRs.Columns.Add("VAT_TYPE_NAME");
                if (!dtRealRs.Columns.Contains("UNIT_TXT"))
                    dtRealRs.Columns.Add("UNIT_TXT");
                foreach (DataRow row in dtRealRs.Rows)
                {
                    if (row["UNIT_ID"].ToString() != "99")
                    {
                        var row1 = row;
                        var unit = InterfaceParameters.Units.FirstOrDefault(a => a.IdUnit == row1["UNIT_ID"].ToString());
                        if (unit != null)
                            row["UNIT_TXT"] = unit.UnitText;
                    }
                    row["BAR_CODE"] = row["BAR_CODE"].ToString().Replace("\'", string.Empty);
                    row["W_NAME"] = row["W_NAME"].ToString().Replace("\'", string.Empty);
                    switch (row["VAT_TYPE"].ToString())
                    {
                        case "0":
                            row["VAT_TYPE_NAME"] = "ჩვეულებრივი";
                            break;
                        case "1":
                            row["VAT_TYPE_NAME"] = "ნულოვანი";
                            break;
                        case "2":
                            row["VAT_TYPE_NAME"] = "დაუბეგრავი";
                            break;
                    }
                }
                dgRealRs.DataSource = dtRs = dtRealRs;
            }

            var dtreal2 =
                SQL.Select("SELECT IdProd, Prod, Raod, Fasi, Tanxa, UN, CD, VatType, Unit FROM ShesView WHERE Zedd = N'" + zedd + "'");
            if (dtreal2.Rows.Count < 1)
                dtreal2 =
                    SQL.Select("SELECT IdProd, Prod, Raod, Fasi, Tanxa, UN, CD, Unit FROM MDabrView WHERE Zedd = N'" + zedd +
                               "'");
            if (dtreal2.Rows.Count < 1)
                dtreal2 =
                    SQL.Select("SELECT IdProd, Prod, Raod, Fasi, Tanxa, UN, CD, Unit FROM ModzView WHERE Zedd = N'" + zedd +
                               "'");

            dgReal2.DataSource = dtreal2;
        }

        void gvReal1_RowStyle(object sender, RowStyleEventArgs e)
        {
            var view = sender as GridView;
            if (e.RowHandle < 0)
                return;
            if (view == null)
                return;
            var value = view.GetRowCellDisplayText(e.RowHandle, view.Columns["IS_CONFIRMED"]);
            switch (value)
            {
                case "დადასტურებული":
                    e.Appearance.ForeColor = Color.Black;
                    break;
                case "დაუდასტურებელი":
                    e.Appearance.ForeColor = Color.Red;
                    break;
            }

            var amount = Convert.ToDouble(view.GetRowCellDisplayText(e.RowHandle, view.Columns["FULL_AMOUNT"]));
            var tanxa = Convert.ToDouble(view.GetRowCellDisplayText(e.RowHandle, view.Columns["Tanxa"]));

            if (Math.Abs(amount - tanxa) > 0.01)
            {
                e.Appearance.BackColor = Color.LightBlue;
            }
        }

        void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        void btnConfirm_Click(object sender, EventArgs e)
        {
            if (gvReal1.GetFocusedRowCellValue(colID).ToString() == "დადასტურებული")
            {
                MessageBox.Show("ზედნადები უკვე დადასტურებულია");
                return;
            }

            if (wayBill.ConfirmWayBill(Convert.ToInt32(gvReal1.GetFocusedRowCellValue(colID).ToString())))
            {
                gvReal1.SetFocusedRowCellValue(colIS_CONFIRMED, "დადასტურებული");
                gvReal1.RefreshRow(gvReal1.FocusedRowHandle);
                MessageBox.Show("დადასტურებულია");
                return;
            }
            MessageBox.Show("ვერ მოხერხდა ზედნადების დადასტირება");
        }

        void btnImport_Click(object sender, EventArgs e)
        {
            if (gvReal1.GetFocusedRowCellValue(colSTATUS).ToString() == "გაუქმებული")
            {
                XtraMessageBox.Show("გაუქმებული ზედადების ჩამოტვირთვა ვერ მოხდება");
                return;
            }

            if (gvReal2.RowCount > 0)
            {
                XtraMessageBox.Show("ზედნადები უკვე ჩამოტვირთულია");
                return;
            }

            var type = gvReal1.GetFocusedRowCellValue(colTYPE).ToString();
            var zedd = gvReal1.GetFocusedRowCellValue(colWAYBILL_NUMBER).ToString();
            var shen = gvReal1.GetFocusedRowCellValue(colWAYBILL_COMMENT)?.ToString();
            var id = gvReal1.GetFocusedRowCellValue(colID).ToString();
            var activateDate = Convert.ToDateTime(gvReal1.GetFocusedRowCellValue(colACTIVATE_DATE).ToString());

            OrgProdParameters.MomcSagad = gvReal1.GetFocusedRowCellValue(colSELLER_TIN).ToString();
            OrgProdParameters.GvariAddress = gvReal1.GetFocusedRowCellValue(colSTART_ADDRESS).ToString();
            OrgProdParameters.Miigo = gvReal1.GetFocusedRowCellValue(colSELLER_NAME).ToString();

            var dtMomc = SQL.Select("SELECT TOP 1 IdMomc FROM Momc WHERE MomcSagad = N'" +
                                    gvReal1.GetFocusedRowCellValue(colSELLER_TIN) + "'");
            int idMomc = 0;

            if (type == "5")
            {
                new ImportWayBillToMDabrForm(idMomc, id, zedd, activateDate, dtRs).ShowDialog();
                FocusedRowChanged();
                return;
            }

            if (type == "1")
            {
                new ImportWayBillToModzForm(id, zedd, activateDate, dtRs).ShowDialog();
                FocusedRowChanged();
                return;
            }

            if (new ImportWayBillToShesForm(idMomc, id, zedd, shen, activateDate, dtRs).ShowDialog() != DialogResult.OK)
                return;

            OrgProdParameters.MomcSagad = OrgProdParameters.GvariAddress = OrgProdParameters.Miigo = string.Empty;
            gvReal1.SetFocusedRowCellValue(colTanxa,
                Convert.ToDouble(SQL.ExecuteScalar("SELECT ISNULL(SUM(Tanxa), 0) FROM ShesView WHERE Zedd = N'" +
                                                   gvReal1.GetFocusedRowCellValue(colWAYBILL_NUMBER) + "'")) +
                Convert.ToDouble(SQL.ExecuteScalar("SELECT ISNULL(SUM(Tanxa), 0) FROM MDabrView WHERE Zedd = N'" +
                                                   gvReal1.GetFocusedRowCellValue(colWAYBILL_NUMBER) + "'")));
            FocusedRowChanged();
        }

        void gvReal1_ColumnPositionChanged(object sender, EventArgs e)
        {
            dgReal1.SaveLayoutToXml();
        }

        void gvReal1_ColumnWidthChanged(object sender, ColumnEventArgs e)
        {
            dgReal1.SaveLayoutToXml();
        }

        void miExportToExcel_Click(object sender, EventArgs e)
        {
            if (activeControl != null)
                CLSExcel.ExportToExcel(activeControl);
        }

        void cmExcel_Opening(object sender, CancelEventArgs e)
        {
            if (cmExcel.SourceControl is GridControl)
            {
                activeControl = (GridControl)cmExcel.SourceControl;
            }
            else
            {
                e.Cancel = true;
                activeControl = null;
            }
        }
    }
}