using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class GenerateShesShekForm : XtraForm
    {
        readonly int id;
        readonly int idProek, idMomc;
        private DataTable dtProekShekData=SQL.Select(" SELECT  '' Proek, '' IdProd, '' Ert, 0.01  Raod, 0.01 Nashti FROM RealT WHERE 1=2 ");

        public GenerateShesShekForm(int id, int idProek, int idMomc)
        {
            this.id = id;
            this.idProek = idProek;
            this.idMomc = idMomc;
            InitializeComponent();
        }

        void GenerateShesShekToShesForm_Load(object sender, EventArgs e)
        {
            Text = "ობიექტის შეკვეთების მიხედვით შეკვეთის გენერირება";
            fmgData.SetDateFormat();
            gvShesShek.FocusedRowChanged += delegate { fillProekShekData(gvShesShek.ReturnValue("IdProd")); };
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime d1 = fmgData.txtData1.DateTime;
            DateTime d2 = fmgData.txtData2.DateTime;

            for (int i = 0; i < gvShesShek.RowCount; i++)
            {
                DataRow row = gvShesShek.GetDataRow(i);
                if (Convert.ToDouble(row["Raod"].ToString()) - Convert.ToDouble(row["Nashti"].ToString()) > 0)
                {
                    double Shek = 0;
                    if (Convert.ToDouble(row["Nashti"].ToString()) < 0)
                        Shek = Convert.ToDouble(row["Raod"].ToString());
                    else
                        Shek = Convert.ToDouble(row["Raod"].ToString()) - Convert.ToDouble(row["Nashti"].ToString());
                        

                    string strComm = " INSERT INTO ShesShek2(IdShesShek1,IdProd,Raod,Tanxa,UN,CD) VALUES(";
                    strComm += id + ", ";
                    strComm += "N'"+row["IdProd"] + "', ";
                    strComm += "" + Shek + ", ";
                    strComm += ""+row["Tanxa"] + ", N'"+GlobalParameters.UserName+"', GETDATE()) ";
                    SQL.Execute(strComm);
                }
            }
            for (int i = 0; i <dtProekShekData.Rows.Count; i++)
            {
                if (dtProekShekData.Rows[i]["Accepted"].ToString() == "1")
                {
                    SQL.Update("UPDATE ProekShek2 SET Fullfilled=1 FROM ProekShek2 INNER JOIN ProekShekView ON ProekShek2.IdProekShek1=ProekShekView.IdProekShek1 WHERE ProekShek2.IdProd=N'" +
                               dtProekShekData.Rows[i]["IdProd"].ToString() + "' AND Data>='" + d1.ToShortDateString() +
                               "' AND Data<='" + d2.ToShortDateString() + "' AND ProekShek2.Fullfilled=0 AND IdProek2= " + idProek + " AND IdMomc=" + idMomc);
                }
            }
            Close();
        }

        void btnFind_Click(object sender, EventArgs e)
        {
            var proc = new CLSSpAll(panel2, "spGenerateShesShek1");
            proc.AddParameter("IdMomc", idMomc);
            proc.AddParameter("IdProek", idProek);
            dgShesShek.DataSource = proc.Exceute();
            if (gvShesShek.RowCount == 0)
            {
                XtraMessageBox.Show("შეკვეთა ამ პერიდოში ვერ მოიძებნა გთხოვთ შეამოწმოთ \"ობიექტზე შეკვეთები\"".Translate(),"",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            var proc2 = new CLSSpAll(panel2, "spGenerateShesShek2");
            proc2.AddParameter("IdMomc", idMomc);
            proc2.AddParameter("IdProek", idProek);
            dtProekShekData = proc2.Exceute();
            if(gvShesShek.RowCount==0)
                return;
            fillProekShekData(gvShesShek.ReturnValue("IdProd"));
        }

        private void fillProekShekData(string idprod)
        {
            DataRow [] rows = dtProekShekData.Select("IdProd='" + idprod + "' ");
            DataTable dt2 = dtProekShekData.Clone();
            foreach (var row in rows)
            {
                dt2.ImportRow(row);
            }
            dgProekShesShek.DataSource = dt2;
        }

        private void dgProekShesShek_DoubleClick(object sender, EventArgs e)
        {
//            if (gvProekShesShek.GetFocusedRowCellValue(colIdProd) == null)
//                return;
            double oldRaod = Convert.ToDouble(gvProekShesShek.GetFocusedRowCellValue(colProekShek).ToString());
            if (gvProekShesShek.GetFocusedRowCellValue(colAccepted).ToString() == "1")
            {
                gvProekShesShek.SetFocusedRowCellValue(colAccepted, "0");
                gvShesShek.SetFocusedRowCellValue(colSulRaod,
                    Convert.ToDouble(gvShesShek.GetFocusedRowCellValue(colSulRaod)) - oldRaod);
                gvShesShek.SetFocusedRowCellValue(colTanxa, Convert.ToDouble(gvShesShek.GetFocusedRowCellValue(colFasi)) * Convert.ToDouble(gvShesShek.GetFocusedRowCellValue(colSulRaod)));
                for (int i = 0; i < dtProekShekData.Rows.Count; i++)
                {
                    string aa = dtProekShekData.Rows[i]["IdProd"].ToString();
                    string bb = gvProekShesShek.GetFocusedRowCellValue(colIdProd).ToString();
                    if (dtProekShekData.Rows[i]["IdProd"].ToString() ==
                        gvProekShesShek.GetFocusedRowCellValue(colIdProd).ToString() &&
                        dtProekShekData.Rows[i]["IdProek1"].ToString() ==
                        gvProekShesShek.GetFocusedRowCellValue(colIdProek1).ToString())
                    {
                        dtProekShekData.Rows[i]["Accepted"] = 0;
                        break;
                    }
                }
            }
            else
            {
                gvProekShesShek.SetFocusedRowCellValue(colAccepted, "1");
                gvShesShek.SetFocusedRowCellValue(colSulRaod,
                    Convert.ToDouble(gvShesShek.GetFocusedRowCellValue(colSulRaod)) + oldRaod);
                gvShesShek.SetFocusedRowCellValue(colTanxa, Convert.ToDouble(gvShesShek.GetFocusedRowCellValue(colFasi)) * Convert.ToDouble(gvShesShek.GetFocusedRowCellValue(colSulRaod)));
                for (int i = 0; i < dtProekShekData.Rows.Count; i++)
                {
                    if (dtProekShekData.Rows[i]["IdProd"].ToString() ==
                        gvProekShesShek.GetFocusedRowCellValue(colIdProd).ToString() &&
                        dtProekShekData.Rows[i]["IdProek1"].ToString() ==
                        gvProekShesShek.GetFocusedRowCellValue(colIdProek1).ToString())
                    {
                        dtProekShekData.Rows[i]["Accepted"] = 1;
                        break;
                    }
                }
            }
        }

        private void gvShesShek_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "colSulRaod")
            {
                gvShesShek.SetFocusedRowCellValue(colTanxa, Convert.ToDouble(gvShesShek.GetFocusedRowCellValue(colFasi)) * Convert.ToDouble(gvShesShek.GetFocusedRowCellValue(colSulRaod)));
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            var clsExcel = new CLSExcel(dgShesShek, "ShesShekNashti");
            clsExcel.Export();
        }
    }
}