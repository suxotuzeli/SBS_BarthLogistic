using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using SBS_Market.Classes;
using SBS_Market.Parameters;

namespace SBS_Market.OtherForms
{
    public partial class CheckShesWaybillsForm : Form
    {
        private string sagad;
        private int id;
        private DataTable dtRs = new DataTable();
        private readonly DateTime dataBegin;
        readonly CLSWayBillOperation wayBill = new CLSWayBillOperation();

        public CheckShesWaybillsForm(string sagad, DateTime dataBegin, int id)
        {
            this.sagad = sagad;
            this.id = id;
            this.dataBegin = dataBegin;
            InitializeComponent();
        }

        private void CheckWaybillsForm_Load(object sender, EventArgs e)
        {
            PeriodSettingsClass.SetDateFormat(txtDataBegin1, true);
            PeriodSettingsClass.SetDateFormat(txtDataBegin2, true);
            PeriodSettingsClass.SetDateFormat(txtDataClose1, true);
            PeriodSettingsClass.SetDateFormat(txtDataClose2, true);
            PeriodSettingsClass.SetDateFormat(txtDataCreate1, true);
            PeriodSettingsClass.SetDateFormat(txtDataCreate2, true);
            PeriodSettingsClass.SetDateFormat(txtDataDelivery1, true);
            PeriodSettingsClass.SetDateFormat(txtDataDelivery2, true);
            ParamClass.ChangeFonts(gvReal1);
            ParamClass.ChangeFonts(gvReal2);
            ParamClass.ChangeFonts(gvRealRs);
            
            if(sagad == "")
                return;
            chbSagad.Checked = true;
            txtSagad.Text = sagad;
            chbDataBegin.Checked = true;
            txtDataBegin1.Visible = txtDataBegin2.Visible = true;
            txtDataBegin1.Value = txtDataBegin2.Value = dataBegin;
         
        }

        private void btnImportWaybills_Click(object sender, EventArgs e)
        {


            DateTime? dataBegin1, dataBegin2, dataClose1, dataClose2, dataCreate1, dataCreate2, dataDelivery1, dataDelivery2;
            decimal? tanxa;
            string piradiNom = "", zedd = "", man = "", comment = "";

            if(chbDataBegin.Checked){
                dataBegin1 = txtDataBegin1.Value;
                dataBegin2 = txtDataBegin2.Value.AddDays(1);
            }
            else{
                dataBegin1 = null;
                dataBegin2 = null;
            }

            if(chbDataClose.Checked){
                dataClose1 = txtDataClose1.Value;
                dataClose2 = txtDataClose2.Value.AddDays(1);
            }
            else {
                dataClose1 = null;
                dataClose2 = null;
            }
            
            if (chbDataCreate.Checked) {
                dataCreate1 = txtDataCreate1.Value;
                dataCreate2 = txtDataCreate2.Value.AddDays(1);
            }
            else {
                dataCreate1 = null;
                dataCreate2 = null;
            }
            
            if(chbDataDelivery.Checked){
                dataDelivery1 = txtDataDelivery1.Value;
                dataDelivery2 = txtDataDelivery2.Value.AddDays(1);
            }
            else {
                dataDelivery1 = null;
                dataDelivery2 = null;
            }

            if(chbTanxa.Checked){
                tanxa = Convert.ToDecimal(txtTanxa.Text);
            }
            else{
                tanxa = null;
            }

            if(chbMan.Checked){
                man = txtMan.Text;
            }

            if(chbPiradiNom.Checked){
                piradiNom = txtPiradiNom.Text;
            }

            if(chbSagad.Checked){
                sagad = txtSagad.Text;
            }

            if(chbZedd.Checked){
                zedd = txtZedd.Text;
            }

            if(chbComment.Checked){
                comment = txtComment.Text;
            }


            const string status = "";
            string type = GenerateStatus(gbZeddType);
            using (DataTable dt = wayBill.GetBuyerWayBills(dataBegin1, dataBegin2, dataCreate1, dataCreate2, dataDelivery1, dataDelivery2, dataClose1, dataClose2, man, piradiNom, zedd, sagad, tanxa, type, status, comment)){
                if (dt != null){
                    dt.Columns.Add("Tanxa", typeof (decimal));
                    dt.Columns.Add("Tipi", typeof (string));
                    for (int i = 0; i < dt.Rows.Count; i++){
                        dt.Rows[i]["Tanxa"] = SQL.ExecuteScalar("SELECT ISNULL(SUM(Tanxa), 0) FROM ShesView WHERE Zedd = N'" + dt.Rows[i]["WAYBILL_NUMBER"] + "'");
                        dt.Rows[i]["IS_CONFIRMED"] = dt.Rows[i]["IS_CONFIRMED"].ToString() == "0" ? "დაუდასტურებელი" : "დადასტურებული";
                        string zeddtype=dt.Rows[i]["TYPE"].ToString();
                        switch (zeddtype)
                        {
                            case "1":
                                dt.Rows[i]["Tipi"] = "შიდა გადაზიდვა";
                                break;
                            case "2":
                                dt.Rows[i]["Tipi"] = "ტრანსპორტირებით";
                                break;
                            case "3":
                                dt.Rows[i]["Tipi"] = "ტრანსპორტირების გარეშე";
                                break;
                            case "4":
                                dt.Rows[i]["Tipi"] = "დისტრიბუცია";
                                break;
                            case "5":
                                dt.Rows[i]["Tipi"] = "უკან დაბრუნება";
                                break;
                            case "6":
                                dt.Rows[i]["Tipi"] = "ქვეზედნადები";
                                break;


                        }


                    }
                    dgReal1.DataSource = dt;
                }
                else {
                    MessageBox.Show("არ მოიძებნა ინფორმაცია");
                    dgReal1.DataSource = null;
                }
            }
        }

        private static string GenerateStatus(GroupBox gb)
        {
            StringBuilder str = new StringBuilder();
            foreach (var control in gb.Controls){
                var chb = (CheckBox)control;
                if (chb.Checked)
                    str.Append(chb.Tag + ",");
            }
            return str.ToString().Length > 0 ? str.ToString().Remove(str.Length - 1, 1): "";
        }

//        private void ImportReal(DateTime data1, DateTime data2, string man, string zeddType)
//        {
//            wayBill.GetWayBills(data1, data2, man, zeddType);
//        }
//
        private void chbDataCreate_CheckedChanged(object sender, EventArgs e)
        {
            string name = "txt" + ((Control) sender).Name.Remove(0, 3);
            panel2.Controls[name + "1"].Visible = panel2.Controls[name + "2"].Visible = ((CheckBox)sender).Checked;            
        }

        private void chbZedd_CheckedChanged(object sender, EventArgs e)
        {
            string name = ((Control)sender).Name.Remove(0, 3);
            panel2.Controls["txt" + name].Visible = ((CheckBox)sender).Checked;            

        }

        private void gvReal1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try {
                int idWayBill = Convert.ToInt32(gvReal1.GetFocusedRowCellValue(colID).ToString());
                string zedd = gvReal1.GetFocusedRowCellValue(colWAYBILL_NUMBER).ToString();
                FillRealDetail(idWayBill, zedd);
            }
            // ReSharper disable EmptyGeneralCatchClause
            catch {
                // ReSharper restore EmptyGeneralCatchClause

            }

        }

        private void FillRealDetail(int idWayBill, string zedd)
        {
            using (DataSet ds = wayBill.GetWayBillDataSet(idWayBill)) {
                if (ds.Tables.Count <= 2){
                    MessageBox.Show("არ მოიძებნა ინფორმაცია");
                    dgRealRs.DataSource = null;
                    return;
                }
                dgRealRs.DataSource = ds.Tables[2];
                dtRs = ds.Tables[2];
            }

            dgReal2.DataSource = SQL.Select("SELECT IdProd, Prod, Raod, Fasi, Tanxa, UN, CD FROM ShesView WHERE Zedd = N'" + zedd + "'");

        }

        private void gvReal1_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle < 0)
                return;
            if (view == null)
                return;
            string value = view.GetRowCellDisplayText(e.RowHandle, view.Columns["IS_CONFIRMED"]);
            switch (value) {
                case "დადასტურებული":
                    e.Appearance.ForeColor = Color.Black;
                    break;
                case "დაუდასტურებელი":
                    e.Appearance.ForeColor = Color.Red;
                    break;
            }

            double amount = Convert.ToDouble(view.GetRowCellDisplayText(e.RowHandle, view.Columns["FULL_AMOUNT"]));
            double tanxa = Convert.ToDouble(view.GetRowCellDisplayText(e.RowHandle, view.Columns["Tanxa"]));
            if (Math.Abs(amount - tanxa) > 0.01) {
                e.Appearance.BackColor = Color.LightCyan;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (gvReal1.GetFocusedRowCellValue(colID).ToString() == "დადასტურებული") {
                MessageBox.Show("ზედნადები უკვე დადასტურებულია");
                return;
            }

            if (wayBill.ConfirmWayBill(Convert.ToInt32(gvReal1.GetFocusedRowCellValue(colID).ToString()))) {
                gvReal1.SetFocusedRowCellValue(colIS_CONFIRMED, "დადასტურებული");
                gvReal1.RefreshRow(gvReal1.FocusedRowHandle);
                MessageBox.Show("დადასტურებულია");
                return;
            }
            MessageBox.Show("ვერ მოხერხდა ზედნადების დადასტირება");
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string zeddtype = gvReal1.GetFocusedRowCellValue(colType).ToString();
            DataTable dt;
            int idMomc;
            DateTime d;
            string data;
            switch (zeddtype)
            {
                case "2":
                    dt = SQL.Select("SELECT TOP 1 * FROM Momc WHERE MomcSagad = N'" + gvReal1.GetFocusedRowCellValue(colSELLER_TIN) + "'");
                    idMomc = dt.Rows.Count == 0 ? 0 : Convert.ToInt32(dt.Rows[0]["IdMomc"].ToString());
                    data = gvReal1.GetFocusedRowCellValue(colACTIVATE_DATE).ToString();
                    d = Convert.ToDateTime(data);
                    using (ImportWayBillToShesForm fm = new ImportWayBillToShesForm(idMomc, gvReal1.GetFocusedRowCellValue(colID).ToString(), gvReal1.GetFocusedRowCellValue(colWAYBILL_NUMBER).ToString(), d, dtRs))
                    {
                        fm.ShowDialog();
                    }
                    break;
                case "3":
                    dt = SQL.Select("SELECT TOP 1 * FROM Momc WHERE MomcSagad = N'" + gvReal1.GetFocusedRowCellValue(colSELLER_TIN) + "'");
                    idMomc = dt.Rows.Count == 0 ? 0 : Convert.ToInt32(dt.Rows[0]["IdMomc"].ToString());
                    data = gvReal1.GetFocusedRowCellValue(colACTIVATE_DATE).ToString();
                    d = Convert.ToDateTime(data);
                    using (ImportWayBillToShesForm fm = new ImportWayBillToShesForm(idMomc, gvReal1.GetFocusedRowCellValue(colID).ToString(), gvReal1.GetFocusedRowCellValue(colWAYBILL_NUMBER).ToString(), d, dtRs))
                    {
                        fm.ShowDialog();
                    }
                    break;
                case "4":
                    dt = SQL.Select("SELECT TOP 1 * FROM Momc WHERE MomcSagad = N'" + gvReal1.GetFocusedRowCellValue(colSELLER_TIN) + "'");
                    idMomc = dt.Rows.Count == 0 ? 0 : Convert.ToInt32(dt.Rows[0]["IdMomc"].ToString());
                    data = gvReal1.GetFocusedRowCellValue(colACTIVATE_DATE).ToString();
                    d = Convert.ToDateTime(data);
                    using (ImportWayBillToShesForm fm = new ImportWayBillToShesForm(idMomc, gvReal1.GetFocusedRowCellValue(colID).ToString(), gvReal1.GetFocusedRowCellValue(colWAYBILL_NUMBER).ToString(), d, dtRs))
                    {
                        fm.ShowDialog();
                    }
                    break;
                case "6":
                    dt = SQL.Select("SELECT TOP 1 * FROM Momc WHERE MomcSagad = N'" + gvReal1.GetFocusedRowCellValue(colSELLER_TIN) + "'");
                    idMomc = dt.Rows.Count == 0 ? 0 : Convert.ToInt32(dt.Rows[0]["IdMomc"].ToString());
                    data = gvReal1.GetFocusedRowCellValue(colACTIVATE_DATE).ToString();
                    d = Convert.ToDateTime(data);
                    using (ImportWayBillToShesForm fm = new ImportWayBillToShesForm(idMomc, gvReal1.GetFocusedRowCellValue(colID).ToString(), gvReal1.GetFocusedRowCellValue(colWAYBILL_NUMBER).ToString(), d, dtRs))
                    {
                        fm.ShowDialog();
                    }
                    break;
                case "5":
                    dt = SQL.Select("SELECT TOP 1 * FROM Momc WHERE MomcSagad = N'" + gvReal1.GetFocusedRowCellValue(colSELLER_TIN) + "'");
                    idMomc = dt.Rows.Count == 0 ? 0 : Convert.ToInt32(dt.Rows[0]["IdMomc"].ToString());
                    data = gvReal1.GetFocusedRowCellValue(colACTIVATE_DATE).ToString();
                    d = Convert.ToDateTime(data);
                    using (ImportWayBillToMDabrForm fm = new ImportWayBillToMDabrForm(idMomc, gvReal1.GetFocusedRowCellValue(colID).ToString(), gvReal1.GetFocusedRowCellValue(colWAYBILL_NUMBER).ToString(), d, dtRs))
                    {
                        fm.ShowDialog();
                    }
                    break;
            }
            
        }

     

//        private void ImportValues()
//        {
//            SQL.Update("UPDATE Shes1 SET OldZedd = Zedd, Zedd = N'" + gvReal1.GetFocusedRowCellValue(colWAYBILL_NUMBER) + "', IdShesWayBill = " + gvReal1.GetFocusedRowCellValue(colID) + " WHERE IdShes1 = " + id);
//            
//            for (int i = 0; i < gvRealRs.RowCount; i++){
//                
//            }
//        }
//
//        private int ShowShes1Form1()
//        {
//            return 0;
//        }
    }
}
