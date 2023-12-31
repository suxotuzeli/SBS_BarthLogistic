using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_Market.Classes;
using SBS_Market.Parameters;
using Syncfusion.Windows.Forms.Tools;

namespace SBS_Market.FindForms
{
    public partial class FXarjiForm : XtraForm
    {
        private CLSFForms2old clsFForm;
        private const string NameForReports = "FShesXarji";
        private const string MasterID = "IdShes1";
        private readonly string[] numericFieldList = { "XarjiTanxa", "XarjiTanxaLari", ".", "IdShes1", "UN", "CD" };

        private const string StrComm = "SELECT * FROM ShesXarjiView ";

        private const string StrCommWithGroupBy = "SUM(Tanxa) Tanxa, SUM(TanxaLari) TanxaLari FROM ShesXarjiView ";

        public FXarjiForm()
        {
            InitializeComponent();
        }

        private void FXarjiForm_Load(object sender, EventArgs e)
        {
            clsFForm = new CLSFForms2old(panel1, txtData2, txtData1, btnFind, btnPrint, btnExcel, btnSavePTlayout, btnRestorePTlayout,
                btnSaveDGlayout, btnRestoreDGlayout, new TextEdit(), new IntegerTextBox(), new LabelControl(), new LabelControl(), new Button(), new Button(), 
                chbTotal, chbCross, chbShowValues, chbChart, new CheckBox(), new CheckBox(), chbData, chbList, lbList, new ProgressBarAdv(), cbFileName, cbXML, cbPivotXML, cbExportFormat,
                dg, gridView1, pt, chartControl1, cbChartType, cbChartOrientation,
                MasterID, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList, tabControl1,
                miFind, miPrint, miExcel, miSaveDGlayout, miRestoreDGlayout, miSavePTlayout, miRestorePTlayout, btnHideSearchPanel, btnPivotTableSettings, btnGridViewSettings);
            clsFForm.Initialize();
        }

        private void chbOrgT_CheckedChanged(object sender, EventArgs e)
        {
            ParamClass.CheckBoxAction((CheckBox)sender, ParamClass.ReturnControlViaName(this, ((CheckBox)sender).Name, 3, "cb"));
        }

        private void chbZedd_CheckedChanged(object sender, EventArgs e)
        {
            ParamClass.CheckBoxAction((CheckBox)sender, ParamClass.ReturnControlViaName(this, ((CheckBox)sender).Name, 3, "txt"));
        }

    }
}