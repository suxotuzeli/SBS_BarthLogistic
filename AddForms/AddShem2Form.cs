using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.InterfaceForms;
using SBS_BarthLogistic.OtherForms;
using MessageBoxButtons = System.Windows.Forms.MessageBoxButtons;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddShem2Form : XtraForm
    {
        readonly bool editing;
        readonly int id, masterId;
        readonly string masterTableName;
        readonly string tableName;
        private string idProek;
        CLSTableOperation clsShem2;

        public AddShem2Form(int id, bool editing, string tableName, int masterId)
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

        void AddShem2Form_Load(object sender, EventArgs e)
        {
            string[] strFields =
            {
                "IdShem1"
            };
            string[] strValues =
            {
                ""
            };
            strValues[0] = masterId.ToString();
            clsShem2 = new CLSTableOperation(paShem2, tableName, strFields, strValues, 1);

            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);

            paShem2.ChangeFonts();
            gvShem2.ChangeFonts();
            var dtShem1 = SQL.Select("SELECT IdProek,IdOrg,Org,Proek,IsCustomClearance FROM Shem1View WHERE IdShem1 = " + masterId);

            idProek = dtShem1.Rows[0]["IdProek"].ToString();
            gcPlace.Text += dtShem1.Rows[0]["Proek"].ToString();
            gcCustomClearance.Visible = Convert.ToBoolean(dtShem1.Rows[0]["IsCustomClearance"]);
            
            cbProekSector.FillDataToLookUpEditAndSetFont("ProekSector", "WHERE IdProek = " + idProek);
            gcCustomClearance.ChangeFonts();
            gcPlace.ChangeFonts();
            gcProd.ChangeFonts();
            gcShem2.ChangeFonts();
            if (id > 0)
            {
                Text = "შემოსავლის რედაქტირება";
                clsShem2.InitialazeControls(id);
                btnImportFromExcel.Visible = false;
                btnEndProccess.Visible = false;
                dgShem2.Visible = false;
            }
            else
            {
                Text = "შემოსავლის ჩამატება";
                FillDet();
            }

            txtIdProd.Focus();
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProekSectorZone.Text))
            {
                XtraMessageBox.Show("გთხოვთ შეიტანოთ ლოკაცია","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtProekSectorZone.Focus();
                return;
            }
            clsShem2.Update(id);
            Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProekSectorZone.Text))
            {
                XtraMessageBox.Show("გთხოვთ შეიტანოთ ლოკაცია","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtProekSectorZone.Focus();
                return;
            }
            clsShem2.Insert();
            FillDet();
            txtRaod.Value = 0;
            txtIdProd.EditValue = string.Empty;
            txtProd.EditValue = string.Empty;
            txtPartNumber.EditValue =string.Empty;
            txtCompRaod.EditValue = 0.00;
            txtRaodInBox.EditValue = string.Empty;
            txtPalet.EditValue = 0.00;
            txtWeight.EditValue = 0.00;
            txtFasi.EditValue = 0.00;
            txtAnumber.EditValue = string.Empty;
            txtCnumber.EditValue = string.Empty;
            txtShen.EditValue = string.Empty;
            txtProekSectorZone.EditValue = string.Empty;
        }

        void FillDet()
        {
            dgShem2.DataSource =
                SQL.Select(string.Format("SELECT * FROM {0}View WHERE Id{1} = {2} ORDER BY Id{0}", tableName,
                    masterTableName, masterId));
        }

        private void btnEndProcess_Click(object sender, EventArgs e)
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
            using (var fm = new ImportFromExcelForm(tableName,"IdShem1",masterId.ToString()))
            {
                fm.ShowDialog();
                FillDet();
            }
        }

        void dgDet_DoubleClick(object sender, EventArgs e)
        {
            txtRaod.Focus();
            txtRaod.Value = gvShem2.ReturnDecimal("Raod");
            txtIdProd.EditValue = gvShem2.ReturnValue("IdProd");
            txtProd.EditValue = gvShem2.ReturnValue("Prod");
            txtPartNumber.EditValue = gvShem2.ReturnValue("PartNumber");
            txtCompRaod.EditValue = gvShem2.ReturnDouble("CompRaod");
            txtRaodInBox.EditValue = gvShem2.ReturnValue("RaodInBox");
            txtPalet.EditValue = gvShem2.ReturnDouble("Palet");
            txtWeight.EditValue = gvShem2.ReturnDouble("Weight");
            txtFasi.EditValue = gvShem2.ReturnDouble("Fasi");
            cbValuta.EditValue = gvShem2.ReturnInt32("IdValuta");
            cbUnit.EditValue = gvShem2.ReturnInt32("IdUnit");
            cbCustomClearanceMode.EditValue = gvShem2.ReturnInt32("IdCustomClearanceMode");
            txtAnumber.EditValue = gvShem2.ReturnValue("Anumber");
            txtCnumber.EditValue = gvShem2.ReturnValue("Cnumber");
            txtShen.EditValue = gvShem2.ReturnValue("Shen");
            cbProekSector.EditValue = gvShem2.ReturnInt32("IdProekSector");
            txtProekSectorZone.EditValue = gvShem2.ReturnValue("ProekSectorZone");
            clsShem2.Delete(gvShem2.ReturnInt32());
            FillDet();
            txtRaod.SelectAll();
        }
    }
}