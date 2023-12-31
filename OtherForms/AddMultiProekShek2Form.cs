using System;
using System.Data;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class AddMultiProekShek2Form : XtraForm
    {
        readonly string idProek;
        readonly string idProekShek2;
        readonly DateTime d;

        public AddMultiProekShek2Form(string idProekShek2, string idProek, DateTime d)
        {
            this.idProek = idProek;
            this.idProekShek2 = idProekShek2;
            this.d = d;
            InitializeComponent();
        }

        void AddMultiProekShek2Form_Load(object sender, EventArgs e)
        {
            paFilter.ChangeFonts();
            gvProd.ChangeFonts();
        }

        void btnFind_Click(object sender, ItemClickEventArgs e)
        {
            var proc = new CLSSpAll(paFilter, "spNashtiProekShekNew");
            proc.AddParameter("IdProek", idProek);
            dgProd.DataSource = proc.Exceute();
        }

        void btnLayout_ItemClick(object sender, ItemClickEventArgs e)
        {
            gvProd.SaveLayouts();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            
            foreach (DataRow row in (dgProd.DataSource as DataTable).Rows)
            {
                var edit = Convert.ToDouble(row["NewReal"]);
                if (edit <= 0) continue;
                var cmd = string.Format(
                    "INSERT INTO ProekShek2 (IdProekShek1, IdProd, Raod, UN, CD) VALUES ({0}, N'{1}', {2}, N'{3}', GETDATE())",
                    idProekShek2, row["IdProd"], row["NewReal"], GlobalParameters.UserName);
                SQL.Insert(cmd);
            }
            Close();
        }

        void btnExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            CLSExcel.ExportToExcel(dgProd);
        }
    }
}