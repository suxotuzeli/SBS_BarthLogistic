using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class ReplaceProdInAgceraFrom : XtraForm
    {
        readonly DateTime d;
        readonly decimal gas;
        readonly string idAgcera1;
        readonly string idProd;
        readonly int idProek;
        readonly decimal shem;
        bool isValid;

        public ReplaceProdInAgceraFrom(DataRow row, string idAgcera1, int idProek, DateTime d)
        {
            this.idProek = idProek;
            this.d = d;
            this.idAgcera1 = idAgcera1;
            idProd = row["IdProd"].ToString();
            gas = Convert.ToDecimal(row["Gas"].ToString());
            shem = Convert.ToDecimal(row["Shem"].ToString());
            InitializeComponent();
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            if (!isValid) return;
            if (dgReal1.DataSource == null) return;
            if (XtraMessageBox.Show("გსურთ " + (int)txtRaod.Value
                                    + " ცალი '" + txtIdProd2.Label + "' შეიცვლაოს '" +
                                    txtIdProd1.Label + "'-თი\n\nდასრულების შემდეგ მოხდება ნაშთის გადათვლა.",
                StringParameters.Confirm, MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            StringBuilder sb = new StringBuilder("UPDATE Real2 SET IdProd = N'" + txtIdProd1.Id + "' WHERE IdReal2 IN (");
            foreach (DataRow dataRow in (dgReal1.DataSource as DataTable).Rows)
            {
                sb.Append(dataRow["IdReal2"] + ",");
            }

            SQL.Update(sb.ToString().TrimEnd(',') + ")");

            GenetatePreNashti();
            GenetateNashti();
            dgReal1.DataSource = null;
        }

        void GenetateNashti()
        {
            CLSSpAll clsSpAll = new CLSSpAll("spGenerateAgceraNashti");
            clsSpAll.AddParameter("IdAgcera1", idAgcera1);
            clsSpAll.AddParameter("UN", GlobalParameters.UserName);
            clsSpAll.Exceute();
        }

        void GenetatePreNashti()
        {
            DataTable dtPre = SQL.Select("SELECT * FROM AgceraPreNashtiView WHERE IdAgcera1 = " + idAgcera1);
            DataTable dtNashti = SQL.Select("SELECT * FROM AgceraNashtiView WHERE IdAgcera1 = " + idAgcera1);
            CLSSpAll clsSpAll = new CLSSpAll("spGenerateAgceraPreNashti");
            clsSpAll.AddParameter("IdAgcera1", idAgcera1);
            clsSpAll.AddParameter("UN", GlobalParameters.UserName);
            clsSpAll.Exceute();
            DataTable dtNew = SQL.Select("SELECT * FROM AgceraPreNashtiView WHERE IdAgcera1 = " + idAgcera1);
            double raodNew;
            foreach (DataRow r in dtPre.Rows)
            {
                string idProdLocal = r["IdProd"].ToString();
                double raod = Convert.ToDouble(r["Raod"].ToString());
                DataRow[] drNews = dtNew.Select("IdProd = '" + idProdLocal + "'");
                raodNew = drNews.Length <= 0 ? 0 : Convert.ToDouble(drNews[0]["Raod"].ToString());
                if (raod == raodNew) continue;
                SQL.Update(string.Format("UPDATE AgceraPreNashti SET Raod = {0} WHERE IdAgceraPreNashti = {1}",
                    raodNew, r["IdAgceraPreNashti"]));
                DataRow[] drNashti = dtNashti.Select("IdProd = '" + idProdLocal + "'");
                if (drNashti.Length <= 0)
                {
                    double sxvaoba = raodNew - raod;
                    SQL.Insert("INSERT INTO AgceraNashti(IdAgcera1, IdProd,Raod, UN, CD) VALUES(" +
                               idAgcera1 + ",N'" + idProdLocal + "'," + sxvaoba + ", N'" +
                               GlobalParameters.UserName +
                               "', GETDATE())");
                }
                else
                {
                    SQL.Update(string.Format(
                        "UPDATE AgceraNashti SET Raod = Raod + {0} WHERE IdProd = N'{1}' AND IdAgcera1 = {2}",
                        raodNew - raod, idProdLocal, idAgcera1));
                }
            }
            foreach (DataRow r in dtNew.Rows)
            {
                string idProdLocal = r["IdProd"].ToString();
                DataRow[] drPre = dtPre.Select("IdProd = '" + idProdLocal + "'");
                if (drPre.Length > 0) continue;
                raodNew = Convert.ToDouble(r["Raod"].ToString());
                SQL.Insert("INSERT INTO AgceraPreNashti(IdAgcera1, IdProd,Raod, UN, CD) VALUES(" +
                           idAgcera1 + ",N'" + idProdLocal + "'," + raodNew + ", N'" +
                           GlobalParameters.UserName +
                           "', GETDATE())");
                DataRow[] drNashti = dtNashti.Select("IdProd = '" + idProdLocal + "'");
                if (drNashti.Length <= 0)
                {
                    //double sxvaoba = (raodNew - raod);
                    SQL.Insert("INSERT INTO AgceraNashti(IdAgcera1, IdProd,Raod, UN, CD) VALUES(" +
                               idAgcera1 + ",N'" + idProdLocal + "'," + raodNew + ", N'" +
                               GlobalParameters.UserName +
                               "', GETDATE())");
                }
                else
                {
                    SQL.Update(string.Format(
                        "UPDATE AgceraNashti SET Raod = Raod + {0} WHERE IdProd = N'{1}' AND IdAgcera1 = {2}",
                        raodNew, idProdLocal, idAgcera1));
                }
            }
            SQL.Delete("DELETE FROM AgceraNashti WHERE IdAgcera1=" + idAgcera1 + " AND Raod=0");
            SQL.Delete("DELETE FROM AgceraPreNashti WHERE IdAgcera1=" + idAgcera1 + " AND Raod=0");
        }

        void ReplaceProdInAgceraFrom_Load(object sender, EventArgs e)
        {
            gvReal1.ChangeFonts();
            if (gas == 0)
            {
                Text = "დანაკლისი";
                txtIdProd2.Id = idProd;
                txtIdProd2.SearchForProd();
            }
            else
            {
                Text = "ზედმეტობა";
                txtIdProd1.Id = idProd;
                txtIdProd1.SearchForProd();
            }
            txtRaod.Value = gas == 0 ? (int)shem : (int)gas;
        }

        void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        void btnGenerate_Click(object sender, EventArgs e)
        {
            DataTable dtReal =
                SQL.Select("SELECT TOP " + (int)txtRaod.Value + " * FROM RealView WHERE Raod = 1 AND IdProd = N'" +
                           txtIdProd2.Id + "' AND IdProek = " + idProek + " AND Data < '" + d.ToShortDateString() + "'");
            if (dtReal.Rows.Count == txtRaod.Value)
            {
                isValid = true;
                dgReal1.DataSource = dtReal;
                return;
            }
            dgReal1.DataSource = null;
            isValid = false;
        }
    }
}