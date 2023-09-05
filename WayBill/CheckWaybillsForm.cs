using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.WayBill
{
    public partial class CheckWaybillsForm : Form
    {
        readonly CLSWayBillOperation wayBill = new CLSWayBillOperation();
        DataTable dtRs = new DataTable();

        public CheckWaybillsForm()
        {
            InitializeComponent();
        }

        void CheckWaybillsForm_Load(object sender, EventArgs e)
        {
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
            string sagad = "", piradiNom = "", zedd = "", man = "", comment = "";

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
            //            const string status = "0,1,2";
            const string status = "";
            var type = GenerateStatus(gbZeddType);
            using (dtRs = wayBill.GetWayBills(dataBegin1, dataBegin2, dataCreate1, dataCreate2, dataDelivery1,
                dataDelivery2, dataClose1, dataClose2, man, piradiNom, zedd, sagad, tanxa, type, status, comment))
            {
                if (dtRs != null)
                {
                    dtRs.Columns.Add("Tanxa", typeof (decimal));
                    dtRs.Columns.Add("WayBillStatus", typeof (int));

                    UpdateZeddTanxa(dtRs);
                }
                else
                {
                    MessageBox.Show("არ მოიძებნა ინფორმაცია");
                    dgReal1.DataSource = null;
                }
            }
        }

        void UpdateZeddTanxa(DataTable dt)
        {
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    var tableName = GetZeddTableName(Convert.ToInt32(dt.Rows[i]["TYPE"].ToString()));
                    dt.Rows[i]["Tanxa"] =
                        SQL.ExecuteScalar("SELECT ISNULL(SUM(Tanxa), 0) FROM " + tableName + " WHERE Zedd= N'" +
                                          dt.Rows[i]["WAYBILL_NUMBER"] + "'");
                    dt.Rows[i]["WayBillStatus"] = Convert.ToInt32(dt.Rows[i]["STATUS"].ToString());
                    dt.Rows[i]["STATUS"] = GetZeddStatus(Convert.ToInt32(dt.Rows[i]["STATUS"].ToString()));
                    dgReal1.DataSource = dt;
                }
                catch (Exception)
                {
                }
            }
        }

        static string GenerateStatus(Control gb)
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

        //        private void ImportReal(DateTime data1, DateTime data2, string man, string zeddType)
        //        {
        //            wayBill.GetWayBills(data1, data2, man, zeddType);
        //        }
        //
        void chbDataCreate_CheckedChanged(object sender, EventArgs e)
        {
            var name = "txt" + ((Control)sender).Name.Remove(0, 3);
            panel2.Controls[name + "1"].Visible = panel2.Controls[name + "2"].Visible = ((CheckEdit)sender).Checked;
        }

        void chbZedd_CheckedChanged(object sender, EventArgs e)
        {
            var name = ((Control)sender).Name.Remove(0, 3);
            panel2.Controls["txt" + name].Visible = ((CheckEdit)sender).Checked;
        }

        void gvReal1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(gvReal1.GetFocusedRowCellValue(colID).ToString());
                var zedd = gvReal1.GetFocusedRowCellValue(colWAYBILL_NUMBER).ToString();
                FillRealDetail(id, zedd);
            }
            catch
            {
            }
        }

        void FillRealDetail(int id, string zedd)
        {
            using (var ds = wayBill.GetWayBillDataSet(id))
            {
                if (ds.Tables.Count <= 2)
                {
                    MessageBox.Show("არ მოიძებნა ინფორმაცია");
                    dgRealRs.DataSource = null;
                    return;
                }
                dgRealRs.DataSource = ds.Tables[2];
                dtRs = ds.Tables[2];
            }

            var tableName = GetZeddTableName(Convert.ToInt32(gvReal1.GetFocusedRowCellValue(colTYPE).ToString()));
            dgReal2.DataSource =
                SQL.Select("SELECT IdProd, Prod, Raod, Fasi, Tanxa, UN, CD FROM " + tableName + " WHERE Zedd = N'" +
                           zedd + "'");
        }

        string GetZeddTableName(int type)
        {
            var tableName = "";
            switch (type)
            {
                case 1:
                    tableName = "ModzView";
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    tableName = "RealView";
                    break;
            }
            return tableName;
        }

        string GetZeddStatus(int status)
        {
            var strStatus = "";
            switch (status)
            {
                case -2:
                    strStatus = "-2 გაუქმებული";
                    break;
                case -1:
                    strStatus = "-1 წაშლილი";
                    break;
                case 0:
                    strStatus = "0 გადაგზავნილია";
                    break;
                case 1:
                    strStatus = "1 გააქტიურებულია";
                    break;
                case 2:
                    strStatus = "2 დახურულია";
                    break;
            }
            return strStatus;
        }

        void gvReal1_RowStyle(object sender, RowStyleEventArgs e)
        {
            var view = sender as GridView;
            if (e.RowHandle < 0)
                return;
            if (view == null)
                return;
            var value = view.GetRowCellDisplayText(e.RowHandle, view.Columns["STATUS"]);
            switch (value)
            {
                case "-2 გაუქმებული":
                    e.Appearance.ForeColor = Color.Red;
                    break;
                case "-1 წაშლილი":
                    e.Appearance.ForeColor = Color.Red;
                    break;
                case "0 გადაგზავნილია":
                    e.Appearance.ForeColor = Color.Green;
                    break;
                case "1 გააქტიურებულია":
                    e.Appearance.ForeColor = Color.Navy;
                    break;
                case "2 დახურულია":
                    e.Appearance.ForeColor = Color.Black;
                    break;
            }
            //if (view.Columns["FULL_AMOUNT"].ToString() == "სტატუსი") return;
            //var amount = Convert.ToDouble(view.GetRowCellDisplayText(e.RowHandle, view.Columns["FULL_AMOUNT"]));
            //var tanxa = Convert.ToDouble(view.GetRowCellDisplayText(e.RowHandle, view.Columns["Tanxa"]));
            //if (Math.Abs(amount - tanxa) > 0.01)
            //{
            //    e.Appearance.BackColor = Color.Yellow;
            //}
        }

        void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        void btnImport_Click(object sender, EventArgs e)
        {
            if (gvReal1.GetFocusedRowCellValue(colTYPE).ToString() == "1")
            {
                if (
                    MessageBox.Show("ჩამოვტვირთოთ 'შიდა გადაზიდვის' ზედნადები?", "შეტყობინება",
                        MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    using (
                        var fmM = new ImportWayBillToModzForm(gvReal1.GetFocusedRowCellValue(colID).ToString(),
                            gvReal1.GetFocusedRowCellValue(colWAYBILL_NUMBER).ToString(),
                            Convert.ToDateTime(gvReal1.GetFocusedRowCellValue(colACTIVATE_DATE).ToString()), dtRs))
                    {
                        fmM.ShowDialog();
                    }
                    return;
                }
            }
            else if (
                MessageBox.Show("ჩამოვტვირთოთ ზედნადები?", "შეტყობინება",
                    MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                var driverTin = gvReal1.GetFocusedRowCellValue(colDRIVER_TIN);
                var driverName = gvReal1.GetFocusedRowCellValue(colDRIVER_NAME);

                using (var fmM = new ImportWayBillToRealForm(gvReal1.GetFocusedRowCellValue(colID).ToString(),
                    gvReal1.GetFocusedRowCellValue(colSTATUS).ToString(),
                    gvReal1.GetFocusedRowCellValue(colBUYER_TIN).ToString(),
                    gvReal1.GetFocusedRowCellValue(colEND_ADDRESS).ToString(),
                    gvReal1.GetFocusedRowCellValue(colWAYBILL_NUMBER).ToString(),
                    Convert.ToDateTime(gvReal1.GetFocusedRowCellValue(colACTIVATE_DATE).ToString()), dtRs,
                    driverTin == null ? string.Empty : driverTin.ToString(),
                    gvReal1.GetFocusedRowCellValue(colCAR_NUMBER).ToString(),
                    driverName == null ? string.Empty : driverName.ToString(),
                    Convert.ToInt32(gvReal1.GetFocusedRowCellValue(colTYPE).ToString()) == 5 ? -1 : 1))
                {
                    fmM.ShowDialog();
                }
                return;
            }

            gvReal1.SetFocusedRowCellValue(colTanxa,
                Convert.ToDouble(SQL.ExecuteScalar("SELECT ISNULL(SUM(Tanxa), 0) FROM RealView WHERE Zedd = N'" +
                                                   gvReal1.GetFocusedRowCellValue(colWAYBILL_NUMBER) + "'"))); //TODO

            //SELECT ISNULL(SUM(Tanxa), 0) FROM " + tableName + " WHERE Zedd= N'" +
            //                              dt.Rows[i]["WAYBILL_NUMBER"] + "'"
            UpdateZeddTanxa(dtRs);
        }

        DataTable FillWayBillGoods(int id)
        {
            using (var ds = wayBill.GetWayBillDataSet(id))
            {
                if (ds.Tables.Count <= 2)
                {
                    return null;
                }
                return ds.Tables[2];
            }
        }
    }
}