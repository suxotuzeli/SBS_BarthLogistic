using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.Interfaces;

namespace SBS_BarthLogistic.InterfaceForms
{
    public partial class PanelLayoutOperations : XtraForm
    {
        CheckedListBoxControl chbList;
        PanelControl pa;
        string reportName;

        public PanelLayoutOperations(PanelControl pa, CheckedListBoxControl chbList, string reportName)
        {
            InitializeComponent();
            this.pa = pa;
            this.chbList = chbList;
            this.reportName = reportName;
            LoadLayouts();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var currnet = gvLayouts.GetFocusedDataRow();

            if (string.IsNullOrEmpty(name) && currnet != null)
            {
                if (XtraMessageBox.Show("გსურთ გადავაწერო არსებულს ჩანაწერს?\n" + currnet["Name"], "Confirm",
                    MessageBoxButtons.YesNo) != DialogResult.Yes) return;
                name = currnet["Name"].ToString();
            }

            var path = GlobalParameters.XMLFolder + "PA_" + reportName + "$" + name + ".xml";
            if (File.Exists(path)) File.Delete(path);

            var element = new XElement("Controls",
                pa.Controls.OfType<IFMGFindControl>().
                    Where(a => a.Checked).
                    Select(x => new XElement("Control",
                        new XAttribute("FieldName", x.FieldName),
                        new XAttribute("Value", x.GetId().ToString()))));
            var xElement = new XElement("Items",
                chbList.Items.Cast<CheckedListBoxItem>().
                    Where(a => a.CheckState == CheckState.Checked).
                    Select(x => new XElement("Item",
                        new XAttribute("FieldName", x.Value.ToString()),
                        new XAttribute("Value", "True"))));
            var xdoc = new XDocument();
            var fmg = new XElement("FForms");
            fmg.Add(element);
            fmg.Add(xElement);
            xdoc.Add(fmg);
            xdoc.Save(path);
            LoadLayouts();
            txtName.Text = string.Empty;
            //Close();
        }

        void LoadLayouts()
        {
            dgLayouts.DataSource = GetLayouts(reportName);
        }

        public static void RestorePanel(PanelControl pa, CheckedListBoxControl chbList, string reportName,
            string layoutName)
        {
            var path = GlobalParameters.XMLFolder + "PA_" + reportName + "$" + layoutName + ".xml";
            if (!File.Exists(path)) return;
            var xdoc = XDocument.Load(path);

            var fValue = new Dictionary<string, string>();

            foreach (var node in xdoc.Descendants("Control"))
            {
                var fieldName = node.Attribute("FieldName");
                var value = node.Attribute("Value");

                fValue.Add(fieldName.Value, value.Value);
            }

            foreach (var ifmg in pa.Controls.OfType<IFMGFindControl>())
            {
                if (fValue.ContainsKey(ifmg.FieldName))
                {
                    ifmg.Checked = true;
                    ifmg.SetValue(fValue.FirstOrDefault(a => a.Key == ifmg.FieldName).Value);
                }
                else
                {
                    ifmg.Checked = false;
                }
            }
            fValue.Clear();

            foreach (var node in xdoc.Descendants("Item"))
            {
                var fieldName = node.Attribute("FieldName");
                var value = node.Attribute("Value");
                fValue.Add(fieldName.Value, value.Value);
            }

            foreach (CheckedListBoxItem ifmg in chbList.Items)
                ifmg.CheckState = fValue.ContainsKey(ifmg.Value.ToString()) ? CheckState.Checked : CheckState.Unchecked;
        }

        void btnLoad_Click(object sender, EventArgs e)
        {
            var currnet = gvLayouts.GetFocusedDataRow();
            if (currnet == null) return;
            RestorePanel(pa, chbList, reportName, currnet["Name"].ToString());
            //Close();
        }

        public static DataTable GetLayouts(string reportName)
        {
            var dt = SQL.Select("SELECT '' AS Name");
            dt.Rows.Clear();
            var repName = "PA_" + reportName;

            var files = Directory.GetFiles(GlobalParameters.XMLFolder, repName + "*");
            foreach (var file in files)
            {
                var name = file.Split('$');
                if (name.Length == 0)
                    dt.Rows.Add(file.Replace(".xml", string.Empty));
                else
                    dt.Rows.Add(name[1].Replace(".xml", string.Empty));
            }
            return dt;
        }

        void PanelLayoutOperations_Load(object sender, EventArgs e)
        {
            Text = StringParameters.CaptionPanelLayoutOperations;
            LoadLayouts();
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            var currnet = gvLayouts.GetFocusedDataRow();
            if (currnet == null) return;
            var path = GlobalParameters.XMLFolder + "PA_" + reportName + "$" + currnet["Name"] + ".xml";
            if (!File.Exists(path)) return;
            if (XtraMessageBox.Show("Delete?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            File.Delete(path);
            LoadLayouts();
        }
    }
}