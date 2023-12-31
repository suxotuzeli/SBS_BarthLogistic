using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.OtherForms;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddModz2Form : XtraForm
    {
        readonly bool editing;
        readonly int id, masterId;
        readonly string masterTableName;
        readonly string tableName;
        private string idOrg, idProek1, idProek2;
        CLSTableOperation clsModz2;
        DataTable dtModz2;

        public AddModz2Form(int id, bool editing, string tableName, string fieldName, int masterId)
        {
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

        void AddModz2Form_Load(object sender, EventArgs e)
        {
            string[] strFields =
            {
                "IdModz1",
                "Prod"
            };
            string[] strValues =
            {
                "",
                ""
            };
            strValues[0] = masterId.ToString();
            clsModz2 = new CLSTableOperation(paModz2, tableName, strFields, strValues, 2);

            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);
            var dtShem1 = SQL.Select("SELECT IdProek1,IdProek2,IdOrg FROM dbo.Modz1 WHERE IdModz1 = " + masterId);

            idProek1 = dtShem1.Rows[0]["IdProek1"].ToString();
            idProek2 = dtShem1.Rows[0]["IdProek2"].ToString();

            idOrg = dtShem1.Rows[0]["IdOrg"].ToString();

            paModz2.ChangeFonts();
            gvModz2.ChangeFonts();

            if (id > 0)
            {
                Text = "მოძრაობის რედაქტირება";
                clsModz2.InitialazeControls(id);
                dgModz2.Visible = false;
            }
            else
            {
                Text = "მოძრაობის ჩამატება";
                FillDet();
                cbProekSector1.FillDataToLookUpEditAndSetFont("ProekSector","WHERE IdProek = " + idProek1);
                cbProekSector2.FillDataToLookUpEditAndSetFont("ProekSector","WHERE IdProek = " + idProek2);

            }
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            if (!CheckIdProd()) return;
            clsModz2.AdditionalValues[1] = laProdText.Text;
            clsModz2.Update(id);
            Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckIdProd()) return;
            clsModz2.AdditionalValues[1] = laProdText.Text;
            clsModz2.Insert();

            FillDet();

            txtRaod.Value = 0;
            txtIdProd.Focus();
        }

        void FillDet()
        {
            dtModz2 =
                SQL.Select(string.Format("SELECT * FROM {0}View WHERE Id{1} = {2} ORDER BY Id{0}", tableName,
                    masterTableName, masterId));

            dgModz2.DataSource = dtModz2;
        }

        private void txtRaod_Enter(object sender, EventArgs e)
        {
            CheckIdProd(true);
        }


        void dgDet_DoubleClick(object sender, EventArgs e)
        {
            txtRaod.Focus();
            txtRaod.Value = Convert.ToDecimal(gvModz2.ReturnValue("Raod"));
            clsModz2.Delete(gvModz2.ReturnInt32());
            FillDet();
            txtRaod.SelectAll();
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

        private bool CheckIdProd(bool visualCheck = false)
        {
            if (string.IsNullOrEmpty(txtProekSectorZone1.Text))
            {
                XtraMessageBox.Show("გთხოვთ შეიტანოთ ლოკაცია 1 ","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtProekSectorZone1.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtProekSectorZone2.Text))
            {
                XtraMessageBox.Show("გთხოვთ შეიტანოთ ლოკაცია 2 ","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtProekSectorZone2.Focus();
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