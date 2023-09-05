using System;
using System.Data;
using System.Drawing;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.Parameters;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class CheckNashtiAgceraForm : XtraForm
    {
        readonly DateTime d;
        readonly int idProek, id;
        DataTable dt;

        public CheckNashtiAgceraForm(DateTime d, int idProek, int id)
        {
            this.d = d;
            this.id = id;
            this.idProek = idProek;
            InitializeComponent();
        }

        void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        void Calculate()
        {

            dt = ProceduresClass.spCheckNashtiAgcera("spCheckNashtiAgcera", d, idProek, chbOnlyAgcera.Checked,
                Convert.ToInt32(fmgProdS.GetId()), Convert.ToInt32(fmgMomc.GetId()), Convert.ToInt32(fmgProdT.GetId()));
            dgCheckNashtiAgcera.DataSource = dt;
        }

        void btnNashti_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        void CheckNashtiAgceraForm_Load(object sender, EventArgs e)
        {
            gvReal2.ChangeFonts();
            paFilter.ChangeFonts();
        }

        void gvReal2_RowStyle(object sender, RowStyleEventArgs e)
        {
            var view = sender as GridView;
            if (e.RowHandle < 0)
                return;
            if (view == null)
                return;
            var value = Convert.ToDouble(view.GetRowCellDisplayText(e.RowHandle, view.Columns["Shem"]));
            e.Appearance.ForeColor = value > 0 ? Color.Blue : Color.Red;
        }

        void btnExportToShem_Click(object sender, EventArgs e)
        {
            ExportToTable("Shem");
        }

        void btnExportToGas_Click(object sender, EventArgs e)
        {
            ExportToTable("Gas");
        }

        void ExportToTable(string tableName)
        {
            var operT = tableName == "Shem" ? DefaultValues.IdShemT : DefaultValues.IdGasT;
            var str = new StringBuilder();
            str.Append("INSERT INTO dbo." + tableName + "1 ( IdAgcera1, Data, Zedd, Id" + tableName +
                       "T, IdProek, Shen, UN, CD ) VALUES (");
            str.Append("" + id + ",");
            str.Append("'" + d + "',");
            str.Append("N'" + SQLOperation.CalcZeddNum(tableName) + "', ");
            str.Append("" + operT + ", ");
            str.Append("" + idProek + ", ");
            str.Append("N'', N'" + GlobalParameters.UserName + "', GETDATE()); SELECT SCOPE_IDENTITY()");
            var id32 = Convert.ToInt32(SQL.ExecuteScalar(str.ToString()));

            for (var i = 0; i < gvReal2.RowCount; i++)
            {
                if (Math.Abs(Convert.ToDouble(gvReal2.GetRowCellValue(i, tableName)) - 0) < 0.01)
                    continue;
                string idProd = gvReal2.GetRowCellValue(i, "IdProd").ToString();
                string raod = gvReal2.GetRowCellValue(i, tableName).ToString();
                var str1 = new StringBuilder();
                str1.Append("INSERT INTO dbo." + tableName + "2 ( Id" + tableName + "1, IdProd, Raod, UN, CD ) VALUES (");
                str1.Append("" + id32 + ",");
                str1.Append("N'" + idProd + "',");
                str1.Append("" + raod + ",");
                str1.Append("N'" + GlobalParameters.UserName + "', GETDATE())");
                SQL.Insert(str1.ToString());

                var dtNashti = SQL.Select("SELECT IdAgceraNashti FROM AgceraNashti WHERE IdAgcera1 = " + id + " AND IdProd = N'" +
                                                 idProd + "'");
                double r = tableName == "Shem" ? Convert.ToDouble(raod) : -Convert.ToDouble(raod);
                if (dtNashti.Rows.Count > 0)
                {
                    SQL.Update("UPDATE AgceraNashti SET Raod += " + r + " WHERE  IdAgcera1 = " + id + " AND IdProd = N'" +
                               idProd + "'");
                }
                else
                {
                    SQL.Insert("INSERT INTO AgceraNashti(IdAgcera1, IdProd, Raod, UN, CD) VALUES ( " + id + ", N'" +
                               idProd + "', " + raod + ", N'" +
                               GlobalParameters.UserName + "', GETDATE())");
                }
            }
            XtraMessageBox.Show("მონაცემთა ექსპორტი დამთავრებულია");
            Calculate();
        }

        void btnExportToExcel_Click(object sender, EventArgs e)
        {
            CLSExcel.ExportToExcel(dgCheckNashtiAgcera);
        }

        void simpleButton1_Click(object sender, EventArgs e)
        {
            using (var fm = new GenerateShesForm(dt, idProek, id))
            {
                fm.ShowDialog();
                XtraMessageBox.Show("მონაცემთა ექსპორტი დამთავრებულია");
                Calculate();
            }
        }

        void btnExportToShes_Click(object sender, EventArgs e)
        {
            using (var fm = new GenerateRealForm(dt, idProek, id))
            {
                fm.ShowDialog();
                Calculate();
                XtraMessageBox.Show("მონაცემთა ექსპორტი დამთავრებულია");
            }
        }

        void chbOnlyAgcera_CheckedChanged(object sender, EventArgs e)
        {
            paFilter.Visible = !chbOnlyAgcera.Checked;
        }

        //void btnSave_Click(object sender, EventArgs e)
        //{
        //    if (XtraMessageBox.Show("დარწმუნებული ხართ რომ გინდათ ცვლილებების შენახვა? \n ძველი ინფორმაცია წაიშლება",
        //        "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
        //    fmgMomc.Focus();
        //    var k = 0;
        //    SQL.Select("DELETE FROM Agcera2 WHERE IdAgcera1=" + id);
        //    for (var i = 0; i < dt.Rows.Count; i++)
        //    {
        //        if (Convert.ToDouble(dt.Rows[i]["Agcera"].ToString()) > 0)
        //        {
        //            k += 1;
        //            SQL.Insert(
        //                string.Format(
        //                    "INSERT INTO Agcera2(IdAgcera1, IdProd, Raod, UN, CD, IdDalageba) VALUES({0},N'{1}',{2},N'{3}',GETDATE(),{4})",
        //                    id,
        //                    dt.Rows[i]["IdProd"], dt.Rows[i]["Agcera"], GlobalParameters.UserName, k));
        //        }
        //    }
        //    Close();
        //}

        void btnChangeProd_Click(object sender, EventArgs e)
        {
            var row = gvReal2.GetFocusedDataRow();
            if (row == null) return;
            using (var fm = new ReplaceProdInAgceraFrom(row, id.ToString(), idProek, d))
            {
                fm.ShowDialog();   
            }
        }
    }
}