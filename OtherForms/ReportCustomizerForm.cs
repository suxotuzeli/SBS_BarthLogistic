using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using SBS_Market.Classes;
using SBS_Market.Parameters;

namespace SBS_Market.OtherForms
{
    public partial class ReportCustomizerForm : Form
    {
        private CLSStimul report;
        private DataTable dt;
        private string stimulSchema, excelSchema, stimulID, excelID;
        private bool stimulIsShabloni, excelIsShabloni;


        private bool getReportsInformation;

        public ReportCustomizerForm()
        {
            InitializeComponent();
        }

        private void ReportCustomizerForm_Load(object sender, EventArgs e)
        {
            getReportsInformation = false;
//            string[] s = Directory.GetFiles(ParamClass.ReportsFolder, ".mrt");
            lstStimul.Items.AddRange(Directory.GetFiles(InterfaceParameters.ReportsFolder, "*.mrt"));
            lstExcel.Items.AddRange(Directory.GetFiles(InterfaceParameters.ReportsFolder, "*.xls"));
            lstStimul.SelectedIndex = 0;
            lstExcel.SelectedIndex = 0;
            getReportsInformation = true;
            GetReportInformation(lstStimul, laStimul);
            GetReportInformation(lstExcel, laExcel);


            report = new CLSStimul();
            report.InitializeDesigner();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStimulRefresh_Click(object sender, EventArgs e)
        {
            Refresh(lstStimul, "*.mrt");
        }

        private void btnExcelRefresh_Click(object sender, EventArgs e)
        {
            Refresh(lstExcel, "*.xls");
        }

        private static void Refresh(ListBox lst, string filter)
        {
            lst.Items.Clear();
            lst.Items.AddRange(Directory.GetFiles(InterfaceParameters.ReportsFolder, filter));
            lst.SelectedIndex = 0;
            
        }


        private void btnStimulDesign_Click(object sender, EventArgs e)
        {
            report.Design(lstStimul.SelectedItem.ToString());
        }

        private void btnExcelDesign_Click(object sender, EventArgs e)
        {
            Process.Start(lstExcel.SelectedItem.ToString());
        }

        private void lstStimul_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetReportInformation(lstStimul, laStimul);
        }

        private void GetReportInformation(ListBox lst, Control la)
        {
            if (!getReportsInformation)
                return;

            string strComm = "SELECT TOP 1 IdReports, ReportName, ReportDesc, ReportSchema, isShabloni FROM Reports WHERE ReportName = N'" +
                            lst.SelectedItem + "'";
            dt = SQL.Select(strComm);
            la.Text = dt.Rows.Count == 0 ? "-" : dt.Rows[0]["ReportDesc"].ToString();
            if (la.Name.Contains("Stimul")) {
                stimulSchema = dt.Rows[0]["ReportSchema"].ToString();
                stimulID = dt.Rows[0]["IdReports"].ToString();
                stimulIsShabloni = Convert.ToBoolean(dt.Rows[0]["isShabloni"].ToString());
            }
            else {
                excelSchema = dt.Rows[0]["ReportSchema"].ToString();
                excelID = dt.Rows[0]["IdReports"].ToString();
                excelIsShabloni = Convert.ToBoolean(dt.Rows[0]["isShabloni"].ToString());
            }
        }

        private void lstExcel_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetReportInformation(lstExcel, laExcel);
        }

        private void btnStimulEdit_Click(object sender, EventArgs e)
        {
            ShowEditCopyForm(stimulID, lstStimul.SelectedItem.ToString(), laStimul.Text, stimulSchema, stimulIsShabloni, true);
        }

        private void ShowEditCopyForm(string id, string name, string desc, string schema, bool isShabloni, bool editing)
        {
            EditCopyReportForm fm = new EditCopyReportForm(schema, id, name, desc, isShabloni, editing);
            fm.ShowDialog();
            fm.Dispose();

            Refresh(lstStimul, "*.mrt");
            Refresh(lstExcel, "*.xls");

        }

        private void btnStimulCopy_Click(object sender, EventArgs e)
        {
            ShowEditCopyForm(stimulID, lstStimul.SelectedItem.ToString(), laStimul.Text, stimulSchema, stimulIsShabloni, false);
        }

        private void btnExcelEdit_Click(object sender, EventArgs e)
        {
            ShowEditCopyForm(excelID, lstExcel.SelectedItem.ToString(), laExcel.Text, excelSchema, excelIsShabloni, true);
        }

        private void btnExcelCopy_Click(object sender, EventArgs e)
        {
            ShowEditCopyForm(excelID, lstExcel.SelectedItem.ToString(), laExcel.Text, excelSchema, excelIsShabloni, false);
        }

        private void btnStimulDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("წავშალოთ რეპორტი?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                File.Delete(lstStimul.SelectedItem.ToString());
                Refresh(lstStimul, "*.mrt");
            }
        }

        private void btnExcelDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("წავშალოთ რეპორტი?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                File.Delete(lstExcel.SelectedItem.ToString());
                Refresh(lstExcel, "*.xls");
                
            }
        }

        
    }
}
