using System;
using System.Data;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class GenerateAllShesShekForm : XtraForm
    {
        private DataTable dtProekShekData = SQL.Select(" SELECT  '' Proek, '' IdProd, '' Ert, 0.01  Raod, 0.01 Nashti FROM RealT WHERE 1=2 ");
        private DataTable dtShekData;
        private DataTable dtMomc;
        private string whereIdMomc = " WHERE IdMomc>0";
        private int idProek;

        public GenerateAllShesShekForm()
        {
            InitializeComponent();

        }

        void GenerateShesShekToShesForm_Load(object sender, EventArgs e)
        {
            Text = "ობიექტის შეკვეთების მიხედვით შეკვეთის გენერირება";
            panel1.ChangeFonts();
            panel2.ChangeFonts();
            fmgData.SetDateFormat();
            gvShesShek.FocusedRowChanged += delegate { fillProekShekData(gvShesShek.ReturnValue("IdProd")); };
            fmgMomc.Checked = false;
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime d1 = fmgData.txtData1.DateTime;
            DateTime d2 = fmgData.txtData2.DateTime;
            idProek = Convert.ToInt32(fmgProek.GetId());
            DataTable dtMMomc;
            if (fmgMomc.Checked)
                dtMMomc = SQL.Select("SELECT * FROM Momc WHERE " + whereIdMomc);
            else
                dtMMomc = dtMomc;
            for (int i = 0; i < dtMMomc.Rows.Count; i++)
            {
                int idMomc = Convert.ToInt32(dtMMomc.Rows[i]["IdMomc"]);
                string strComm1 =
                    "INSERT INTO ShesShek1(Data,DataDelivery,Zedd,IdProek,IdShesShekT,IdValuta,Kursi,IdMomc,UN,CD,Shen) Values(";
                strComm1 += "'" + DateTime.Now.ToShortDateString() + "', ";
                strComm1 += "'" + DateTime.Now.ToShortDateString() + "', ";
                strComm1 += "'" + SQLOperation.CalcZeddNum("ShesShek1") + "', ";
                strComm1 += "" + idProek + ", ";
                strComm1 += "" + DefaultValues.IdShesShekT + ",1,1, ";
                strComm1 += "" + idMomc + ", ";
                strComm1 += "N'" + GlobalParameters.UserName + "', GETDATE(),''); SELECT SCOPE_IDENTITY()";
                int id = Convert.ToInt32(SQL.ExecuteScalar(strComm1.ToString()));
               
                for (int j = 0; j < gvShesShek.RowCount; j++)
                {
                    DataRow row = gvShesShek.GetDataRow(j);
                    if (Convert.ToInt32(row["IdMomc"].ToString()) == idMomc)
                    {if (Convert.ToDouble(row["Raod"].ToString()) > 0)
                        {
                            string strComm = " INSERT INTO ShesShek2(IdShesShek1,IdProd,Raod,Tanxa,UN,CD) VALUES(";
                            strComm += id + ", ";
                            strComm += "N'" + row["IdProd"] + "', ";
                            strComm += "" + row["Raod"] + ", ";
                            strComm += "" + row["Tanxa"] + ", N'" + GlobalParameters.UserName + "', GETDATE()) ";
                            SQL.Execute(strComm);
                        }
                    }
                }
                for (int j = 0; j < dtProekShekData.Rows.Count; j++)
                {
                    if (dtProekShekData.Rows[j]["Accepted"].ToString() == "1" && Convert.ToInt32(dtProekShekData.Rows[j]["IdMomc"].ToString()) == idMomc)
                    {
                        SQL.Update("UPDATE ProekShek2 SET Fullfilled=1 FROM ProekShek2 INNER JOIN ProekShekView ON ProekShek2.IdProekShek1=ProekShekView.IdProekShek1 WHERE ProekShek2.IdProd=N'" +
                                   dtProekShekData.Rows[j]["IdProd"].ToString() + "' AND Data>='" + d1.ToShortDateString() +
                                   "' AND Data<='" + d2.ToShortDateString() + "' AND ProekShek2.Fullfilled=0 AND IdProek2= " + idProek + " AND IdMomc=" + idMomc);
                    }
                }
            }

           
            Close();
        }

        void btnFind_Click(object sender, EventArgs e)
        {
            fmgMomc.Checked = false;
            var proc = new CLSSpAll(panel2, "spAllGenerateShesShek");
            dtShekData = proc.Exceute();
            dgShesShek.DataSource = dtShekData;
            var proc2 = new CLSSpAll(panel2, "spAllGenerateShesShek2");
            dtProekShekData = proc2.Exceute();
            var procMomc = new CLSSpAll(panel2, "spAllGenerateShesShekMomc");
            dtMomc = procMomc.Exceute();
            string whereClause = " WHERE IdMomc IN (0, ";
            for (int i = 0; i < dtMomc.Rows.Count; i++)
            {
                whereClause += dtMomc.Rows[i]["IdMomc"].ToString() + ", ";
            }
            whereClause = whereClause.Remove(whereClause.Length - 2, 2) + ") ";
            fmgMomc.WhereClause = whereClause;
            fmgMomc.Checked = true;
            fmgMomc.Checked = false;
            if (gvShesShek.RowCount == 0)
                return;
            fillProekShekData(gvShesShek.ReturnValue("IdProd"));
        }

        private void fillProekShekData(string idprod)
        {
            DataRow[] rows = dtProekShekData.Select("IdProd='" + idprod + "' ");
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

        private void fmgMomc_Leave(object sender, EventArgs e)
        {
            if (!fmgMomc.Checked)
                whereIdMomc = "  IdMomc>0 ";
            else
                whereIdMomc = " IdMomc IN (" + fmgMomc.GetId().ToString()+") ";
            DataTable dt2 = dtShekData.Clone();
            DataRow[] drs = dtShekData.Select(whereIdMomc);
            foreach (DataRow d in drs)
            {
                dt2.ImportRow(d);

            }
            dgShesShek.DataSource = dt2;
            if (gvShesShek.RowCount == 0)
            {
                dgProekShesShek.DataSource = SQL.Select(" SELECT  '' Proek, '' IdProd, '' Ert, 0.01  Raod, 0.01 Nashti FROM RealT WHERE 1=2 ");
                return;
            }
            fillProekShekData(gvShesShek.ReturnValue("IdProd"));

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            var clsExcel = new CLSExcel(dgShesShek, "ShesShekNashti");
            clsExcel.Export();
        }
    }
}