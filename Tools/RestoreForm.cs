using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_Market.Classes;
using SBS_Market.Parameters;

namespace SBS_Market.Tools
{
    public partial class RestoreForm : XtraForm
    {
        public RestoreForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

      

        private void btnOK_Click(object sender, EventArgs e)
        {
            spCreateExportData();
            Close();
//            DBClass.ExecuteSQL(@"backup database SBS_Market to disk = '" + txtFileName.Text + "'");
        }
        private void spCreateExportData()
        {
            SqlCommand comm = new SqlCommand("spImportData", GlobalParameters.cn);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                GlobalParameters.cn.Open();
                comm.ExecuteNonQuery();
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
        }

        private void RestoreForm_Load(object sender, EventArgs e)
        {
//            CLSTools.SetReportFormParametersWhenLoading(panel1, "", new ComboBox(), new ComboBox(), new ToolStripComboBox());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBClass.ExecuteSQL(@"IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'SBS_RSMB_TempExport') DROP DATABASE SBS_RSMB_TempExport ");
            DBClass.ExecuteSQL(@"CREATE DATABASE SBS_RSMB_TempExport  ON (NAME = N'SBS_RSMB_TempExport_Data', FILENAME = N'C:\Progs\SBS_RSMB_TempExport_Data.MDF' , SIZE = 3, FILEGROWTH = 10%) LOG ON (NAME = N'SBS_RSMB_TempExport_Log', FILENAME = N'C:\Progs\SBS_RSMB_TempExport_Log.LDF' , SIZE = 1, FILEGROWTH = 10%) COLLATE SQL_Latin1_General_CP1_CI_AS ");
            DBClass.ExecuteSQL(@"RESTORE database SBS_RSMB_TempExport FROM DISK = 'C:\Progs\DataExportOfisidan'");
            DataTable dt = SQL.Select("SELECT * FROM SBS_RSMB_TempExport.dbo.ExportParams");
            laBaza.Text = dt.Rows[0]["ExportName"].ToString();
            laProeqti.Text = dt.Rows[0]["ProekT"].ToString();
            laPeriodi.Text = (Convert.ToDateTime(dt.Rows[0]["Data1"].ToString())).ToShortDateString() + "-" + (Convert.ToDateTime(dt.Rows[0]["Data2"].ToString())).ToShortDateString();
            
        }
    }
}
