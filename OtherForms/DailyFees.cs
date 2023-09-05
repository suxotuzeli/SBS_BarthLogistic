using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class DailyFees : Form
    {
        public DailyFees()
        {
            InitializeComponent();
        }

        private void ChbClient_CheckedChanged(object sender, EventArgs e)
        {
            cbOrg.Visible = chbClient.Checked;
        }

        private void DailyFees_Load(object sender, EventArgs e)
        {
            fmgPeriod.SetDateFormat();
            gvOrg.ChangeFonts();

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            var proc = new CLSSpAll("spCalculateDailyFees");
            proc.AddParameter("Data1", fmgPeriod.GetValueToShortDate1());
            proc.AddParameter("Data2", fmgPeriod.GetValueToShortDate2());
            proc.AddParameter("IdOrg", chbClient.Checked ? cbOrg.EditValue : 0);

            dgOrg.DataSource = proc.Exceute();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (gvOrg.RowCount == 0) return;
            var ans = XtraMessageBox.Show("შევინახმო მონაცემები?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.No) return;
            var idService = SQL.Select("SELECT IdService FROM dbo.Service WHERE IdService IN (SELECT IdServiceForEveryDay FROM dbo.Params WHERE UN = 'sa')").Rows[0][0];
            var dtExistingServices =
                SQL.Select($"SELECT * FROM ServiceReal WHERE IdService = {idService} AND Data BETWEEN '{fmgPeriod.GetValueToShortDate1()}' AND '{fmgPeriod.GetValueToShortDate2()}' AND IdAuto = 1");
            if (dtExistingServices.Rows.Count > 0)
            {
                ans = XtraMessageBox.Show("ამ პერიოდში ზოგიერთ ორგანიზაციაზე გატარებულია ეს სერვისი გთხოვთ გაითვალისწონოთ რომ ეს სერვისიები წაიშლება და თავიდან დაგენერირდება\nგანვაგრძო?"
                    , "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.No) return;
            }
            var dt = dgOrg.DataSource as DataTable;

            foreach (DataRow row in dt.Rows)
            {
                var idOrg = row["IdOrg"].ToString();
                var d1 = Convert.ToDateTime(row["Data1"]);
                var d2 = Convert.ToDateTime(row["Data2"]);
                SQL.Delete($"DELETE ServiceReal WHERE IdService = {idService} AND IdOrg = {idOrg} AND " +
                           $"Data BETWEEN '{d1.ToShortDateString()}' AND '{d2.ToShortDateString()}' AND IsAuto = 1");
                for (var day = d1; day <= d2; day = day.AddDays(1))
                {
                    SQL.Insert("INSERT INTO ServiceReal(Data, Zedd, IdOrg, IdService, Tanxa, TanxaStandart, Shen, UN, CD, CD1,IsAuto)" +
                               $"VALUES(" +
                               $"'{day.ToShortDateString()}'," +
                               $"N'{SQLOperation.CalcZeddNum("ServiceReal")}'," +
                               $"{idOrg}," +
                               $"{idService}," +
                               $"{row["Tanxa"]}," +
                               $"{row["Tanxa"]}," +
                               $"'','{GlobalParameters.UserName}',GETDATE(),GETDATE(),1" +
                               $")");
                }
            }

            XtraMessageBox.Show("ოპერაცია დასრულებულია", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
