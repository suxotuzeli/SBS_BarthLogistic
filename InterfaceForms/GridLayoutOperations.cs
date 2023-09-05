using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraPivotGrid;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.InterfaceForms
{
    public partial class GridLayoutOperations : XtraForm
    {
        GridControl dg;
        bool isDg;
        PivotGridControl pt;
        string reportName;

        public GridLayoutOperations(GridControl dg, string reportName)
        {
            InitializeComponent();
            this.dg = dg;
            this.reportName = reportName;
            isDg = true;
        }

        public GridLayoutOperations(PivotGridControl pt, string reportName)
        {
            InitializeComponent();
            this.pt = pt;
            this.reportName = reportName;
            isDg = false;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            if (chbSaveOnServer.Checked)
                SaveOnServer();
            else
                SaveLocaly();
        }

        void SaveLocaly()
        {
            if (isDg)
                dg.DefaultView.SaveLayoutToXml(GlobalParameters.XMLFolder + "DG_" + reportName + "$" + txtName.Text +
                                               ".xml");
            else
                pt.SaveLayoutToXml(GlobalParameters.XMLFolder + "PT_" + reportName + "$" + txtName.Text + ".xml");
            Close();
        }

        void SaveOnServer()
        {
            var ms = new MemoryStream();
            var dt = SQL.Select(string.Format(
                "SELECT IdLayout FROM dbo.Layout WHERE NameForReports = '{0}' AND Name = N'{1}' AND IsDG = {2}",
                reportName, txtName.Text, Convert.ToInt32(isDg)));
            if (dt.Rows.Count != 0)
            {
                var ans = XtraMessageBox.Show(
                    "ეს სქემა უკვე არსებობს ბაზაში. დარწმუნებული ხართ რომ გსურთ გადააწეროთ ?", string.Empty,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.No)
                    return;
                SQL.Delete("DELETE Layout WHERE IdLayout = " + dt.Rows[0][0]);
            }
            if (isDg)
                dg.DefaultView.SaveLayoutToStream(ms);
            else
                pt.SaveLayoutToStream(ms);
            CLSProcedures.Savelayout(ms, reportName, txtName.Text, isDg);
            Close();
        }

        void LoadLayouts()
        {
            dgLayouts.DataSource = GetLayouts(reportName, isDg);
        }

        void btnLoad_Click(object sender, EventArgs e)
        {
            var currnet = gvLayouts.GetFocusedDataRow();
            if (currnet == null) return;
            if (Convert.ToBoolean(currnet["FromDB"]))
            {
                var data = currnet["Data"] as byte[];
                if (data == null)
                {
                    XtraMessageBox.Show("ვერ მოხერხდა მონაცემების აღდგენა!", string.Empty, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                var ms = new MemoryStream(data);
                if (isDg)
                    dg.DefaultView.RestoreLayoutFromStream(ms);
                else
                    pt.RestoreLayoutFromStream(ms);
            }
            else
            {
                string path;
                if (isDg)
                {
                    path = GlobalParameters.XMLFolder + "DG_" + reportName + "$" + currnet["Name"] + ".xml";
                    dg.DefaultView.RestoreLayoutFromXml(path);
                }
                else
                {
                    path = GlobalParameters.XMLFolder + "PT_" + reportName + "$" + currnet["Name"] + ".xml";
                    pt.RestoreLayoutFromXml(path);
                }
            }
            Close();
        }

        public static DataTable GetLayouts(string reportName, bool isDg)
        {
            var dt = SQL.Select(string.Format(
                "SELECT Name,CONVERT(BIT,1) AS FromDB,Data FROM Layout WHERE NameForReports = '{0}' AND IsDG = {1}",
                reportName, Convert.ToInt32(isDg)));
            string repName;
            if (isDg)
                repName = "DG_" + reportName;
            else
                repName = "PT_" + reportName;

            var files = Directory.GetFiles(GlobalParameters.XMLFolder, repName + "*");
            foreach (var file in files)
            {
                var name = file.Split('$');
                if (name.Length == 0)
                    dt.Rows.Add(file.Replace(".xml", string.Empty), false);
                else
                    dt.Rows.Add(name[1].Replace(".xml", string.Empty), false);
            }
            return dt;
        }

        public static void RestoreLayout(GridControl dg, string nameForReports, string layoutName)
        {
            var path = GlobalParameters.XMLFolder + "DG_" + nameForReports + "$" + layoutName + ".xml";
            if (File.Exists(path))
                dg.DefaultView.RestoreLayoutFromXml(path);
            else
            {
                var row = SQL.Select(string.Format(
                    "SELECT * FROM Layout WHERE NameForReports = '{0}' AND IsDG = {1} AND Name = N'{2}'",
                    nameForReports, 1, layoutName)).Rows[0];
                RestoreLayout(dg, row);
            }
        }

        public static void RestoreLayout(GridControl dg, DataRow row)
        {
            var data = row["Data"] as byte[];
            if (data == null)
            {
                XtraMessageBox.Show("ვერ მოხერხდა მონაცემების აღდგენა!", string.Empty, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            var ms = new MemoryStream(data);
            dg.DefaultView.RestoreLayoutFromStream(ms);
        }

        public static void RestoreLayout(PivotGridControl pt, string nameForReports, string layoutName)
        {
            var path = GlobalParameters.XMLFolder + "PT_" + nameForReports + "$" + layoutName + ".xml";
            if (File.Exists(path))
                pt.RestoreLayoutFromXml(path);
            else
            {
                var row = SQL.Select(string.Format(
                    "SELECT * FROM Layout WHERE NameForReports = '{0}' AND IsDG = {1} AND Name = N'{2}'",
                    nameForReports, 0, layoutName)).Rows[0];
                RestoreLayout(pt, row);
            }
        }

        public static void RestoreLayout(PivotGridControl pt, DataRow row)
        {
            var data = row["Data"] as byte[];
            if (data == null)
            {
                XtraMessageBox.Show("ვერ მოხერხდა მონაცემების აღდგენა!", string.Empty, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            var ms = new MemoryStream(data);
            pt.RestoreLayoutFromStream(ms);
        }

        public static void FillLayouts(BarEditItem cbLayout, string reportName, bool isDg)
        {
            var cb = (cbLayout.Edit as RepositoryItemComboBox);
            var layours = GetLayouts(reportName, isDg);
            cb.Items.Clear();
            foreach (DataRow row in layours.Rows)
            {
                cb.Items.Add(row["Name"]);
            }
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            var currnet = gvLayouts.GetFocusedDataRow();
            if (currnet == null) return;
            string path;
            if (isDg)
                path = GlobalParameters.XMLFolder + "DG_" + reportName + "$" + currnet["Name"] + ".xml";
            else
                path = GlobalParameters.XMLFolder + "PT_" + reportName + "$" + currnet["Name"] + ".xml";
            ;
            if (!File.Exists(path)) return;
            if (XtraMessageBox.Show("Delete?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            File.Delete(path);
            LoadLayouts();
        }

        void GridLayoutOperations_Load(object sender, EventArgs e)
        {
            Text = StringParameters.CaptionGridLayoutOperations;
            LoadLayouts();
        }
    }
}