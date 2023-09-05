using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class ExportSeveralTablesToExcelForm : XtraForm
    {
        const string NameForReports = "SBS_TO";

        public ExportSeveralTablesToExcelForm()
        {
            InitializeComponent();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            var info = new CLSExportSeveralTablesToExcel(fmgData.txtData1.DateTime, fmgData.txtData2.DateTime,
                cbExcel.Text, "1");
            info.ExportToExcel();
        }

        void ExportToInfoForm_Load(object sender, EventArgs e)
        {
            Text = GlobalParameters.FieldName;
            paExportSeveralTablesToExcel.ChangeFonts();
            CLSTools.GetFileList("prn" + NameForReports, cbExcel, "*.xls");
        }
    }
}