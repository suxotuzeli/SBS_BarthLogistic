using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraPivotGrid;
using SBS_Market.Classes;

namespace SBS_Market.OtherForms
{
    public partial class SaveLayout : Form
    {
        private GridControl dg;
        private PivotGridControl pt;
        private string reportName;
        private bool isDG;

        public SaveLayout(GridControl dg,string reportName)
        {
            InitializeComponent();
            this.dg = dg;
            this.reportName = reportName;
            isDG = true;
            LoadLayouts();
        }

        public SaveLayout(PivotGridControl pt, string reportName)
        {
            InitializeComponent();
            this.pt = pt;
            this.reportName = reportName;
            isDG = false;
            LoadLayouts();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chbSaveOnServer.Checked)
                SaveOnServer();
            else
                SaveLocaly();
        }

        private void SaveLocaly()
        {
            if (isDG)
                dg.DefaultView.SaveLayoutToXml(GlobalParameters.XMLFolder + "DG_" + reportName + "$" + txtName.Text +
                                               ".xml");
            else
                pt.SaveLayoutToXml(GlobalParameters.XMLFolder + "PT_" + reportName + "$" + txtName.Text + ".xml");
            Close();
        }

        private void SaveOnServer()
        {
            MemoryStream ms = new MemoryStream();
            var dt = SQL.Select(string.Format(
                        "SELECT IdLayout FROM dbo.Layout WHERE NameForReports = '{0}' AND Name = N'{1}' AND IsDG = {2}",
                        reportName, txtName.Text, Convert.ToInt32(isDG)));
            if (dt.Rows.Count != 0)
            {
                var ans = MessageBox.Show("ეს სქემა უკვე არსებობს ბაზაში. დარწმუნებული ხართ რომ გსურთ გადააწეროთ ?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.No)
                    return;
                SQL.Delete("DELETE Layout WHERE IdLayout = " + dt.Rows[0][0]);
            }
            if (isDG)
                dg.DefaultView.SaveLayoutToStream(ms);
            else
                pt.SaveLayoutToStream(ms);
            Parameters.ProceduresClass.Savelayout(ms, reportName, txtName.Text, isDG);
            Close();
        }

        private void LoadLayouts()
        {
            var dt = SQL.Select(string.Format(
            "SELECT Name,CONVERT(BIT,1) AS FromDB FROM Layout WHERE NameForReports = '{0}' AND IsDG = {1}",
            reportName, Convert.ToInt32(isDG)));
            var repName = "";
            if (isDG)
                repName = "DG_" + reportName;
            else
                repName = "PT_" + reportName;

            var files = Directory.GetFiles(GlobalParameters.XMLFolder, repName + "*");
            foreach (string file in files)
            {
                var name = file.Split('$');
                if (name.Length == 0)
                    dt.Rows.Add(file, false);
                else
                    dt.Rows.Add(name[1], false);
            }
            dgLayouts.DataSource = dt;
            
        }

        private void dgLayouts_DoubleClick(object sender, EventArgs e)
        {
            var x = gvLayouts.GetFocusedDataRow();
            txtName.Text = x["Name"].ToString();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var currnet = gvLayouts.GetFocusedDataRow();
            if (currnet == null) return;
            if (Convert.ToBoolean(currnet["FromDB"]))
            {
                byte[] data = currnet["Data"] as byte[];
                if (data == null)
                {
                    MessageBox.Show("ვერ მოხერხდა მონაცემების აღდგენა!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MemoryStream ms = new MemoryStream(data);
                if (isDG)
                    dg.DefaultView.RestoreLayoutFromStream(ms);
                else
                    pt.RestoreLayoutFromStream(ms);
            }
            else
            {
                string path = "";
                if (isDG)
                {
                    path = GlobalParameters.XMLFolder + "DG_" + reportName + "$" + currnet["Name"];
                    dg.DefaultView.RestoreLayoutFromXml(path);
                }
                else
                {
                    path = GlobalParameters.XMLFolder + "PT_" + reportName + "$" + currnet["Name"];
                    pt.RestoreLayoutFromXml(path);
                }
            }
            Close();
        }
    }
}
