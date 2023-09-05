using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class ImportFromExcelOldForm : XtraForm
    {
        readonly bool addUserInformation;
        readonly string[] foreignTableName;
        readonly string masterField, masterId;
        readonly string[] numericFields;
        readonly string tableNameForImport;
        CLSExcel clsExcel;

        public ImportFromExcelOldForm(string[] numericFields, string[] foreignTableName, string masterField,
            string masterId, bool addUserInformation, string tableNameForImport = "")
        {
            this.numericFields = numericFields;
            this.foreignTableName = foreignTableName;
            this.masterField = masterField;
            this.masterId = masterId;
            this.addUserInformation = addUserInformation;
            this.tableNameForImport = tableNameForImport;

            InitializeComponent();
        }

        void btnImport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFileName.Text) || !File.Exists(txtFileName.Text))
            {
                return;
            }
            clsExcel = new CLSExcel();
            clsExcel.TableNameForImport = tableNameForImport;
            clsExcel.Fields.NumericFields = numericFields;
            if (chbUpdate.Checked)
                clsExcel.Update(txtFileName.Text, masterField, masterId, foreignTableName);
            else
                clsExcel.Import(txtFileName.Text, masterField, masterId, foreignTableName, addUserInformation);
            if (clsExcel.DtNo.Rows.Count > 0)
            {
                foreach (DataColumn col in clsExcel.DtNo.Columns)
                {
                    if (gvNotImportedRows.Columns.ColumnByFieldName(col.ColumnName) != null) continue;
                    GridColumn gCol = new GridColumn();
                    gCol.FieldName = col.ColumnName;
                    gCol.Name = "col" + col.ColumnName;
                    gCol.Visible = true;

                    gvNotImportedRows.Columns.Add(gCol);
                }
                dgNotImportedRows.DataSource = clsExcel.DtNo;
                laCount.Text =
                    string.Format("ბაზაში იმპორტირებული იქნა {1} ჩანაწერი, ვერ მოხერხდა {0} ჩანაწერის გადმოტანა",
                        clsExcel.DtNo.Rows.Count, clsExcel.ImportedRowsCount);
                btnExport.Enabled = true;
            }
            else
            {
                XtraMessageBox.Show("იმპორტი დარულებულია");
                Close();
            }
        }

        void btnBrowse_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
                txtFileName.Text = ofd.FileName;
        }

        void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        void btnExport_Click(object sender, EventArgs e)
        {
            CLSExcel.ExportToExcel(dgNotImportedRows);
        }
    }
}