using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.InterfaceForms;
using SBS_BarthLogistic.OtherForms;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddGas2Form : XtraForm
    {
        readonly bool editing;
        readonly int id, masterId;
        readonly string masterTableName;
        readonly string tableName;
        CLSTableOperation clsGas2;
        DataTable dtGas2;
        private string idOrg;

        public AddGas2Form(int id, bool editing, string tableName,  int masterId)
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

        void AddGas2Form_Load(object sender, EventArgs e)
        {
            string[] strFields =
            {
                "IdGas1",
                "Prod"
            };
            string[] strValues =
            {
                "",
                ""
            };
            strValues[0] = masterId.ToString();
            clsGas2 = new CLSTableOperation(paGas2, tableName, strFields, strValues, 2);

            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);

            var dtShem1 = SQL.Select("SELECT IdOrg FROM Gas1View WHERE IdGas1 = " + masterId);

            idOrg = dtShem1.Rows[0]["IdOrg"].ToString();

            paGas2.ChangeFonts();
            gvGas2.ChangeFonts();

            if (id > 0)
            {
                Text = "გასავლის რედაქტირება";
                clsGas2.InitialazeControls(id);
            }
            else
            {
                Text = "გასავლის ჩამატება";
                FillDet();
            }
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            if (!CheckIdProd()) return;
            clsGas2.AdditionalValues[1] = laProdText.Text;
            clsGas2.Update(id);
            Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckIdProd()) return;
            clsGas2.AdditionalValues[1] = laProdText.Text;
            clsGas2.Insert();

            FillDet();

            txtIdProd.Text = string.Empty;
            txtProekSectorZone.Text = string.Empty;
            txtRaod.Value = 0;
            txtIdProd.Focus();
        }

        void FillDet()
        {
            dtGas2 =
                SQL.Select(string.Format("SELECT * FROM {0}View WHERE Id{1} = {2} ORDER BY Id{0}", tableName,masterTableName, masterId));

            dgGas2.DataSource = dtGas2;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
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

        private void TxtRaod_Enter(object sender, EventArgs e)
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

        private void txtIdProd_EditValueChanged(object sender, EventArgs e)
        {
            laProdText.Text = "-";
        }

        private void btnEndProccess_Click(object sender, EventArgs e)
        {
            using (var fm = new FinishOperation(masterTableName,masterId))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    Close();
                }
            }
        }

        private void btnImportFromExcel_Click(object sender, EventArgs e)
        {
            using (var fm = new ImportFromExcelForm(tableName,masterTableName,masterId.ToString()))
            {
                fm.ShowDialog();
                FillDet();
            }
        }

        void dgDet_DoubleClick(object sender, EventArgs e)
        {
            txtRaod.Focus();
            txtIdProd.Text = gvGas2.ReturnValue("IdProd");
            txtRaod.Value = Convert.ToDecimal(gvGas2.ReturnValue("Raod"));
            cbProekSector.EditValue = gvGas2.ReturnInt32("IdProekSector");
            txtProekSectorZone.EditValue = gvGas2.ReturnValue("ProekSectorZone");
            clsGas2.Delete(gvGas2.ReturnInt32("Id" + tableName));
            FillDet();
            txtRaod.SelectAll();
        }
    }
}