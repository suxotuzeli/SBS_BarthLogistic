using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.InterfaceForms
{
    public partial class ImportFromExcelForm : XtraForm
    {
        readonly string masterField;
        readonly string masterValue;
        readonly string tableName;
        CLSImportExcel clsExcel;

        public ImportFromExcelForm(string tableName)
        {
            this.tableName = tableName;
            masterField = string.Empty;
            masterValue = string.Empty;
            InitializeComponent();
            gvCnobari.ChangeFonts();
        }

        public ImportFromExcelForm(string tableName, string masterField, string masterValue)
        {
            this.tableName = tableName;
            this.masterField = masterField;
            this.masterValue = masterValue;
            InitializeComponent();
            gvCnobari.ChangeFonts();
        }

        void btnBrowse_Click(object sender, EventArgs e)
        {
            ofd.Filter = @"Excel-ის ფაილი|*.xlsx;*.xls";
            if (ofd.ShowDialog() == DialogResult.OK)
                txtFileName.EditValue = ofd.FileName;
            if (!File.Exists(txtFileName.Text)) return;
            btnImport.Enabled = false;
            btnCnobariCheckCnobari.Enabled = false;
            clsExcel = new CLSImportExcel(tableName, masterField, masterValue);
            clsExcel.FillDgFromExcel(dgCnobari, txtFileName.Text);
            btnCnobariCheckCnobari.Enabled = true;
        }

        void ImportFromExcelFullForm_Load(object sender, EventArgs e)
        {
            btnImport.Enabled = false;
            btnCnobariCheckCnobari.Enabled = false;
            clsExcel = new CLSImportExcel(tableName, masterField, masterValue);
        }

        void btnImport_Click(object sender, EventArgs e)
        {
            if (chbUpdate.Checked)
                clsExcel.Update(gvCnobari);
            else
                clsExcel.Import(gvCnobari);
        }

        void btnCnobariCheckCnobari_Click(object sender, EventArgs e)
        {
            bool ans = clsExcel.ValidateInfo(chbUpdate.Checked);
            if (ans)
            {
                XtraMessageBox.Show("შეტანილი მომანაცემები სწორია", string.Empty, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                btnImport.Enabled = true;
            }
            else
            {
                XtraMessageBox.Show(
                    "შეტანილი მომანაცემები არ არის სწორი! გთხოვთ გადაამოწმოთ და თავიდან ჩატვირთოთ ფაილი",
                    string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgErrors.DataSource = clsExcel.DtErrors;
                tabControl1.SelectTab(tpErrors);
            }
            btnCnobariCheckCnobari.Enabled = false;
        }

        void btnCreateExcelModel_Click(object sender, EventArgs e)
        {
            SaveFileDialog fm = new SaveFileDialog();
            fm.Filter = @"Excel-ის ფაილი|*.xlsx;*.xls";
            if (fm.ShowDialog() == DialogResult.OK)
            {
                clsExcel.CreateExcelModel(tableName, fm.FileName);
            }
        }

        void btnCreateExcelModelUpdate_Click(object sender, EventArgs e)
        {
            SaveFileDialog fm = new SaveFileDialog();
            fm.Filter = @"Excel-ის ფაილი|*.xlsx;*.xls";
            if (fm.ShowDialog() == DialogResult.OK)
            {
                clsExcel.CreateExcelModelForUpdate(tableName, fm.FileName,masterField,masterValue);
                chbUpdate.Checked = true;
            }
        }
    }
}