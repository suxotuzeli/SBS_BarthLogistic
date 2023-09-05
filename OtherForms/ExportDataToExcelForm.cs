using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class ExportDataToExcelForm : XtraForm
    {
        const string NameForReports = "ExportDataToExcel";

        public ExportDataToExcelForm()
        {
            InitializeComponent();
        }

        void ExportDataToExcelForm_Load(object sender, EventArgs e)
        {
            Text = GlobalParameters.FieldName;
            paExportDataToExcel.ChangeFonts();
            CLSTools.GetFileList("prn" + NameForReports, cbExcel, "*.xls");
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            var spAll = new CLSSpAll(paExportDataToExcel);
            var excel = new CLSExcel(spAll.Exceute(), cbExcel.Text);
            excel.InitializePanelParams(paExportDataToExcel);
            excel.Export();
        }
    }
}