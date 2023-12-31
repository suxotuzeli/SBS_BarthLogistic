using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.OtherForms;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddAgcera2Form : XtraForm
    {
        readonly bool editing;
        readonly int id, masterId;
        readonly string masterTableName;
        readonly string tableName;
        CLSTableOperation clsAgcera2;
        bool returnToId;
        private string idOrg;

        public AddAgcera2Form(int id, bool editing, string tableName, int masterId)
        {
            returnToId = false;
            this.id = id;
            this.masterId = masterId;
            this.editing = editing;
            this.tableName = tableName;
            masterTableName = tableName.Substring(0, tableName.Length - 1) + "1";
            InitializeComponent();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void AddAgcera2Form_Load(object sender, EventArgs e)
        {
            string[] strFields =
            {
                "IdAgcera1",
                "Prod"
            };
            string[] strValues =
            {
                "",""
            };
            strValues[0] = masterId.ToString();
            clsAgcera2 = new CLSTableOperation(panel2, tableName, strFields, strValues, 2);
            panel2.ChangeFonts();
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);

            var dtAgcera1 = SQL.Select("SELECT IdOrg,IdProek FROM Agcera1 WHERE IdAgcera1 = " + masterId);
            var idProek = dtAgcera1.Rows[0]["IdProek"].ToString();
            idOrg = dtAgcera1.Rows[0]["IdOrg"].ToString();

            this.ChangeFonts();
            cbProekSector.FillDataToLookUpEditAndSetFont("ProekSector", "WHERE IdProek = " + idProek);
            gvAgcera2.ChangeFonts();

            if (id > 0)
            {
                Text = "აღწერის რედაქტირება";
                clsAgcera2.InitialazeControls(id);
            }
            else
            {
                Text = "აღწერის ჩამატება";
                FilldtDet();
            }
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            if (!CheckIdProd()) return;
            clsAgcera2.AdditionalValues[1] = laProdText.Text;
            clsAgcera2.Update(id);
            Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckIdProd()) return;
            clsAgcera2.AdditionalValues[1] = laProdText.Text;

            clsAgcera2.Insert();
            returnToId = false;

            FilldtDet();

            txtIdProd.Text = string.Empty;
            txtProekSectorZone.Text = string.Empty;
            txtRaod.Value = 1;
            txtIdProd.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var fm = new SearchGasProd(idOrg))
            {
                if (fm.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(fm.IdProd))
                {
                    txtIdProd.Text = fm.IdProd;
                    laProdText.Text = fm.Prod;
                    txtRaod.Focus();
                }
            }
        }

        void FilldtDet()
        {
            dgAgcera2.DataSource =
                SQL.Select(string.Format("SELECT * FROM {0}View WHERE Id{1} = {2} ORDER BY Id{0}", tableName,
                    masterTableName, masterId));
        }

        private void txtRaod_Enter(object sender, EventArgs e)
        {
            CheckIdProd(true);
        }

        private bool CheckIdProd(bool visualCheck = false)
        {
            if (string.IsNullOrEmpty(txtProekSectorZone.Text))
            {
                XtraMessageBox.Show("გთხოვთ შეიტანოთ ლოკაცია","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtProekSectorZone.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtIdProd.Text))
            {
                XtraMessageBox.Show("გთხოვთ შეიტანოთ პროდუქციის კოდი", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                txtIdProd.Focus();
                return false;
            }
            var dt = SQL.Select(
                "SELECT Prod FROM dbo.Shem2 INNER JOIN dbo.Shem1 ON Shem1.IdShem1 = Shem2.IdShem1 " +
                $"WHERE IdProd = N'{txtIdProd.Text}' AND IdOrg = {idOrg} " +
                "GROUP BY Prod");

            //თუ ისეთ პროდუქტს ატარებს რაც არ შეუსყიდია ამ ორგანიზაციას მააშინ 
            if (dt.Rows.Count == 0)
            {
                XtraMessageBox.Show("პროდუქცია ამ კოდით ამ ორგანიზაციის შესყიდვაზე არ ფიქსირდება", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                txtIdProd.Focus();
                txtIdProd.SelectAll();
                return false;
            }
            //იდეალური ვარიანტი
            if (dt.Rows.Count == 1)
            {
                laProdText.Text = dt.Rows[0][0].ToString();
            }
            //თუ ამ ორგანიზაციას ამ შტრიხ კოდზე ორი სხვადასხვა დასახელების პროდუქტი აქვს 
            else
            {
                if (!visualCheck) return true;
                using (var fm = new SearchGasProd(idOrg,txtIdProd.Text))
                {
                    if (fm.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(fm.IdProd))
                    {
                        txtIdProd.Text = fm.IdProd;
                        laProdText.Text = fm.Prod;
                    }
                }
            }

            return true;
        }
    }
}