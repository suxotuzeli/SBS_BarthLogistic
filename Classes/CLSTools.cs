using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Windows.Forms;
using System.Xml;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPivotGrid;
using Microsoft.Win32;
using SBS_BarthLogistic.Controls;
using SBS_BarthLogistic.InterfaceForms;
using SBS_BarthLogistic.Interfaces;
using SBS_BarthLogistic.OtherForms;
using SBS_BarthLogistic.Properties;
using ComboBox = System.Windows.Forms.ComboBox;
using PopupMenuShowingEventArgs = DevExpress.XtraPivotGrid.PopupMenuShowingEventArgs;

namespace SBS_BarthLogistic.Classes
{
    /// <summary>
    ///     -- ვერსია 2.6 -- 6 Jun 2016 14:00 ნიკა
    ///     . Font ებზე შევცვალე რაღაცები
    ///     -- ვერსია 2.5 -- 23 May 2016 19:00 ნიკა
    ///     . SearchLookUpEdit სთვის გადავტვირთე შევსების ფუნქციები
    ///     . FormActivate ის გამოცდაზება უკვე შესაძლებელია თუ თარიღის ველს არ ქვია Data
    ///     -- ვერსია 2.4 -- 18 May 2016 19:00 ნიკა
    ///     . SetLookUpEditValue -ში მეორე არგუმენრი შეიცვალა object-ად, იყო სტრინგი
    ///     -- ვერსია 2.3 -- 13 May 2016 20:00 ნიკა
    ///     . დავამატე ფუნქცია ShowMessageDialog
    ///     . BindContextMenu ინახავს რეგისტრებში ცვლილებებს
    ///     -- ვერსია 2.2 -- 25 Mar 2016 13:00 ნიკა
    ///     . FillDataToLookUpEditAndSetFont ში Id(EditValue) ყოველთივს ივსება როგორც Int(32)
    ///     -- ვერსია 2.1 -- 24 Mar 2016 15:00 ნიკა
    ///     . f9 აწ უკვე მუშაობს Combobox-ზეც :)
    ///     -- ვერსია 2.0 -- 16 March 2016 16:00 ნიკა
    ///     . ChangeFonts(this GridView gv) ში კონტროლ ცე აკოპირებს უჯრას.
    ///     -- ვერსია 1.9 -- 10 March 2016 18:00 ნიკა
    ///     . ChangeFonts(this PivotGridControl pt) Dataს გამოჩენა ხდება.
    ///     -- ვერსია 1.8 -- 8 March 2016 18:00 ნიკა
    ///     . ჩავამატე SaveLayoutToXml, RestoreLayoutFromXml ძებნის ფორმებისთვის (FProd, FOrg..)
    ///     ფილტრს არ უნდა ინახავდეს სეივის დროს და ამიტომ ფუნქცია ჩავსვი
    ///     -- ვერსია 1.7 -- 29 Feb 2016 18:00 ნიკა
    ///     . გავასწორე MoveToId, არ რეფრეშდებოდა ქვედა ცხრილი.
    ///     -- ვერსია 1.6 -- 22 Feb 2016 18:00 ნიკა
    ///     . გავასწორე FMGDateFilterControlზე საათების მინიჭება.
    ///     . ChangeFonts(GridView) ში, არაქოლუმის ადგილას კონტექტური მენიუს გამოძახებაზე შეცდომას აგდებდა.
    ///       აქვე ხდება GroupPanelText-ის თარგმნა. +StringParameters გაახლდა
    ///     . GridView.Return ები გავასწორე და დავამატე რამდენიმე ანოტაცია
    ///     . ChangeFonts(this XtraForm frm) ის დრო არ გარბოდა FMG კონტროლებს
    ///     -- ვერსია 1.5 -- 15 Feb 2016 18:00 ნიკა
    ///     . ჩავამატე ReturnDecimal, CalcEdit ებისთვისაა საჭირო.
    ///     -- ვერსია 1.4 -- 14 Dec 2015 13:00 ნიკა
    ///     . ჩავამატე #Aed MoveToId(this GridControl dgMaster, string strComm)
    ///     . გადავტვირთე GetFileList (x2) LookUpEdit ის და BarEditItem ის შევსება, დავამატე class ReportFile და enum FileType
    ///     -- ვერსია 1.3 -- 24 Noe 2015 17:00 ნიკა
    ///     . გავასწორე ShowChangeForm, მუშაობდა მხოლოდ მაშინ როცა ერთი მაინც ჩანაწერი იყო, ცარიელზე არა.
    ///     -- ვერსია 1.2 -- 10 Noe 2015 19:00 ნიკა
    ///     . გავასწორე UserCanModifyData(DateTime)
    ///     . ჩავამატე GetCurrency()
    ///     -- ვერსია 1.1 -- 5 Noe 2015 19:00 ნიკა
    ///     . GetFileList გამოსწორდა, fmgData ზე გამოსწორდა საათი ფორმატი, ამოვიღე ფუნქცია DLGForm
    ///     -- ვერსია 1.0 -- 30 Oct 2015 14:00 ბადრი
    ///     . დაემატა CheckBoxAction, ReturnControlViaName
    ///     -- ვერსია 0.9 -- 29 Oct 2015 16:00 სანდრო
    ///     . დაემატა მეთოდი CopyRecordWithDetails
    ///     -- ვერსია 0.8 -- 28 Oct 2015 12:00 ნიკა
    ///     . ptShowDetailedRecords გადაკეთდა ShowDetailedRecords
    ///     . ამოვაგდე რამდენიმე Linq კოდი
    ///     . შევცვალე FillDetails როგორც შევთანხმდით
    ///     -- ვერსია 0.7 -- 27 Oct 2015 18:00 სანდრო
    ///     . FProd, FOrg ფორმებისთვის დაემატა პოზიციისა და გრიდის შენახვა
    ///     -- ვერსია 0.6 -- 18 Oct 2015 19:00 ნიკა
    ///     . SetDateFormat ს დავუმატე ღილაკზე თარიღის ასარჩევი იკონი.
    ///     . ChangeFonts(this GridView gv) ში კონტექტური მენიუს გამოძახებისას დაემატა Columnის ფილტრის საშვალება რამდენიმეს
    ///     მნიშვნელობით.
    /// </summary>

    static class CLSTools
    {
        static bool showAedPopup;

        public static void ShowMessageDialog(string mainMessage)
        {
            ShowMessageDialog(mainMessage, string.Empty);
        }

        public static void ShowMessageDialog(string mainMessage, string additionalMessage)
        {
            var errorDialog = new ErrorDialog();
            errorDialog.SetMessage(mainMessage, additionalMessage);
            errorDialog.ShowDialog();
        }

        public static void ShowErrorDialog(this Exception ex)
        {
            ex.ShowErrorDialog(string.Empty);
        }

        public static void ShowErrorDialog(this Exception ex, string additionalMessage)
        {
            var errorDialog = new ErrorDialog();
            errorDialog.SetException(ex, additionalMessage);
            errorDialog.ShowDialog();
        }

        public static string ReturnParam(string s)
        {
            return s.Substring(0, s.IndexOf("--", StringComparison.Ordinal));
        }

        public static void MdiForm<T>(T form) where T : XtraForm
        {
            foreach (var child in GlobalParameters.fmMain.MdiChildren)
            {
                if (form.GetType() != child.GetType()) continue;
                child.Activate();
                return;
            }
            form.MdiParent = GlobalParameters.fmMain;
            form.Show();
            form.Activate();
        }

        public static void MdiFindForm<T>(T form, string tableName, string fieldName) where T : XtraForm
        {
            GlobalParameters.TableName = tableName;
            GlobalParameters.FieldName = fieldName;
            foreach (var child in GlobalParameters.fmMain.MdiChildren)
            {
                if (form.GetType() != child.GetType()) continue;
                child.Activate();
                return;
            }
            form.MdiParent = GlobalParameters.fmMain;
            CLSGraphicalElements.Show();
            form.Show();
            form.Activate();
        }

        public static void ShowDetailedRecords(PivotCellEventArgs e, PivotGridControl pt)
        {
            var fm = new PTRowsForm(e, pt);
            fm.ShowDialog();
            fm.Dispose();
        }

        public static bool ContainsControl(this PanelControl pa, Control cont)
        {
            if (cont is TextBoxMaskBox)
            {
                return pa.Controls.Contains(cont.Parent);
            }
            return pa.Controls.Contains(cont);
        }

        #region Currency

        public static double CalcTanxa(DataTable dt)
        {
            return CalcTanxa(dt, "Tanxa");
        }

        public static double CalcTanxa(DataTable dt, string fieldName)
        {
            double sum = 0;
            foreach (DataRow dr in dt.Rows)
                sum += Convert.ToDouble(dr[fieldName].ToString());
            return sum;
        }

        public static string[] GetCurrency()
        {
            const string rssFeedUrl = "http://www.nbg.ge/rss.php";
            var reader = XmlReader.Create(rssFeedUrl);
            var feed = SyndicationFeed.Load(reader);
            var text = feed.Items.ToArray()[0].Summary.Text;
            text = text.Replace("<table border=\"0\">", string.Empty);
            text = text.Replace("</table>", string.Empty);
            text = text.Replace("<td><img  src=\"https://www.nbg.gov.ge/images/red.gif\"></td>", string.Empty);
            text = text.Replace("<td><img  src=\"https://www.nbg.gov.ge/images/green.gif\"></td>", string.Empty);
            text = text.Replace("\n\t\t\t", string.Empty);
            text = text.Replace("\n\t\t", string.Empty);
            text = text.Replace("</td>", string.Empty);

            return text.Split(new[]
            {
                "<tr>"
            }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static double GetCurrency(string valuta)
        {
            foreach (var s in GetCurrency())
            {
                if (!s.Contains(valuta)) continue;
                var k = s.Split(new[] {
                    "<td>"
                }, StringSplitOptions.RemoveEmptyEntries);
                var raod = k[1].Split(' ')[0];
                return Convert.ToDouble(k[2]) / Convert.ToDouble(raod);
            }
            return 0;
        }

        #endregion

        #region Controls

        public static SimpleButton SetButtonStyle(SimpleButton btnOk, SimpleButton btnAdd, bool editing)
        {
            btnOk.Visible = editing;
            btnAdd.Visible = !editing;
            return editing ? btnOk : btnAdd;
        }

        public static BarItem FindControlInForm(this BarManager fm, string crName)
        {
            var res = fm.Items[crName];
            return res ?? new BarButtonItem();
        }

        public static int ConvertCheckEditValueToInt(this CheckEdit chb)
        {
            return chb.Checked ? 1 : 0;
        }

        [Obsolete("გადასაყვანია CheckEdit-ზე")]
        public static int ConvertCheckBoxValueToInt(this CheckBox chb)
        {
            return chb.Checked ? 1 : 0;
        }

        public static void CheckBoxAction(CheckBox chb, Control cb)
        {
            cb.Visible = chb.Checked;
            if (chb.Checked) cb.Focus();
        }

        public static void CheckBoxAction(CheckEdit chb, Control cb)
        {
            cb.Visible = chb.Checked;
            if (chb.Checked) cb.Focus();
        }

        public static Control ReturnControlViaName(Form frm, string checkBoxName, int startSymbols,
            string startSymbolsText)
        {
            var name = startSymbolsText + ReturnTextFromName(checkBoxName, startSymbols);
            var ctl = frm.Controls.Find(name, true);
            return ctl[0];
        }

        public static string ReturnTextFromName(string name, int startSymbols)
        {
            var l = name.Length;
            return name.Substring(startSymbols, l - startSymbols);
        }

        #endregion

        #region AedForm

        public static void ShowChangeForm(this GridView gv)
        {
            var tablemane = gv.Name.Substring(2);
            var row = gv.GetFocusedDataRow();
            var id = row == null ? "0" : row["Id" + tablemane].ToString();
            var fm = new Change1Form(tablemane, id, "Id" + tablemane);
            fm.Show();
        }

        public static bool Delete(this GridView gv)
        {
            var tableName = gv.Name.Substring(2);
            var selected = gv.GetSelectedRows();
            if (selected.Length < 1) return false;
            if (
                XtraMessageBox.Show(StringParameters.ConfirmDelete, StringParameters.Confirm, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) !=
                DialogResult.Yes) return false;
            var values = " IN (";
            foreach (var s in selected)
                values = values + string.Format("N'{0}', ", gv.GetDataRow(s)["Id" + tableName]);
            values = values.Substring(0, values.Length - 2) + ")";
            var pos = gv.FocusedRowHandle;
            var clsLog = new CLSLog();
            clsLog.AddOldValues(tableName, gv.ReturnId());
            clsLog.CreateLog(tableName, "DELETE", string.Empty);
            SQL.Delete("DELETE FROM " + tableName + " WHERE Id" + tableName + values);
            gv.FocusedRowHandle = pos - 1;
            return true;
        }

        public static void SaveLayouts(this GridControl dg)
        {
            dg.SaveLayouts(dg.Name.Substring(2));
        }

        public static void SaveLayouts(this GridControl dg, string nameForReports)
        {
            using (var fm = new GridLayoutOperations(dg, nameForReports))
                fm.ShowDialog();
        }

        public static void SaveLayouts(this GridView gv)
        {
            gv.SaveLayouts(gv.Name.Substring(2));
        }

        public static void SaveLayouts(this GridView gv, string nameForReports)
        {
            using (var fm = new GridLayoutOperations(gv.GridControl, nameForReports))
                fm.ShowDialog();
        }

        public static void BindContextMenu(this GridControl dg, PopupMenu cmAed)
        {
            var x = dg.DefaultView as GridView;
            //TODO რესთორი აკეთებს Form ის Activate-ს თავის პონტში, ამიტომ ძალიან არ გვაწყობს ამის გამოყენება
            //cmAed.Manager.RestoreFromRegistry("SOFTWARE\\FMGSoft\\" + GlobalParameters.DatabaseName + "\\Defaults\\bm" + dg.Name.Substring(2));
            cmAed.Manager.EndCustomization += (sender, e) => (sender as BarManager).SaveToRegistry("SOFTWARE\\FMGSoft\\" + GlobalParameters.DatabaseName + "\\Defaults\\bm" + dg.Name.Substring(2));
            cmAed.Manager.CreateCustomizationForm += (sender, e) =>
            {
                e.CustomizationForm = new FMGCustomizationForm();
            };
            x.PopupMenuShowing += (sender, args) =>
            {
                if (!showAedPopup) return;
                cmAed.ShowPopup(Control.MousePosition);
            };
        }

        public static void InitializePeriod(BarEditItem cbPeriod, BarEditItem txtData1, BarEditItem txtData2)
        {
            var clsPeriod = new CLSPeriodSettings(cbPeriod, txtData1, txtData2);
            clsPeriod.InitializeBarItems();
        }

        public static void FillDetails(this GridControl dgMaster, GridControl dgDet, string strCommDetail)
        {
            var masterRow = (dgMaster.MainView as GridView).GetFocusedDataRow();
            if (masterRow == null)
            {
                if ((dgMaster.MainView as GridView).RowCount > 0)
                    return;
                dgDet.DataSource = null;
                return;
            }
            var masterTableName = dgMaster.Name.Substring(2);
            var id = masterRow["Id"+masterTableName];
            dgDet.DataSource = SQL.Select(strCommDetail + " WHERE Id" + masterTableName + " = N'" + id + "'");
        }
        public static void FillDetails(this GridControl dgMaster, GridControl dgDet, string strCommDetail, string masterField)
        {
            var masterRow = (dgMaster.MainView as GridView).GetFocusedDataRow();
            if (masterRow == null)
            {
                if ((dgMaster.MainView as GridView).RowCount > 0)
                    return;
                dgDet.DataSource = null;
                return;
            }
            var id = masterRow[masterField];
            dgDet.DataSource = SQL.Select(strCommDetail + " WHERE " + masterField + " = N'" + id + "'");
        }

        public static void MoveToId(this GridControl dgMaster, string strComm)
        {
            if (GlobalParameters.FindID <= 0) return;
            dgMaster.DataSource = null;
            dgMaster.DataSource =
                SQL.Select(strComm + " WHERE Id" + dgMaster.Name.Substring(2) + " = " + GlobalParameters.FindID);
        }

        public static void CopyRecordWithDetails(string tableName, string detTableName, int masterId, string fieldList,
            string detFieldList)
        {
            if (XtraMessageBox.Show("შევასრულოთ კოპირება?".Translate(), StringParameters.CaptionCopy,
                MessageBoxButtons.YesNo) !=
                DialogResult.Yes) return;

            var shortDetFieldList = detFieldList.Substring(detFieldList.IndexOf(',') + 1,
                detFieldList.Length - detFieldList.IndexOf(',') - 1);
            fieldList = fieldList.Replace(" ", string.Empty);
            var selFieldList = fieldList.Replace(",Zedd,", ",N'" + SQLOperation.CalcZeddNum(tableName) + "',");
            var id = GlobalParameters.IDForFind = SQL.Insert(string.Format(
                "INSERT INTO {0}({1}) SELECT {3} FROM {0} WHERE Id{0} = {2}; SELECT SCOPE_IDENTITY()",
                tableName, fieldList, masterId, selFieldList));

            var strDetInsertCommand = string.Format(
                "INSERT INTO {0}({1}, UN, CD) SELECT {2}, {3}, '{6}', GETDATE() FROM {0} WHERE Id{4} = {5}",
                detTableName, detFieldList, id, shortDetFieldList, tableName, masterId, GlobalParameters.UserName);
            SQL.Insert(strDetInsertCommand);
        }

        #endregion

        #region FileFilterLayout

        public static void SaveLayoutToXml(this GridControl dg)
        {
            dg.SaveLayoutToXml(dg.Name.Substring(2));
        }

        public static void SaveLayoutToXml(this GridControl dg, string nameForReports)
        {
            var optionsLayoutGrid = new OptionsLayoutGrid();
            optionsLayoutGrid.StoreAllOptions = true;
            optionsLayoutGrid.StoreDataSettings = false;
            dg.DefaultView.SaveLayoutToXml(GlobalParameters.XMLFolder + nameForReports + "Search.xml", optionsLayoutGrid);
        }

        public static void RestoreLayoutFromXml(this GridControl dg)
        {
            dg.RestoreLayoutFromXml(dg.Name.Substring(2));
        }
        public static void RestoreLayoutFromXml(this GridControl dg, string nameForReports)
        {
            if (File.Exists(GlobalParameters.XMLFolder + nameForReports + "Search.xml"))
                dg.DefaultView.RestoreLayoutFromXml(GlobalParameters.XMLFolder + nameForReports + "Search.xml");
        }

        public static void SaveLayoutToXml(this GridView dg)
        {
            dg.SaveLayoutToXml(dg.Name.Substring(2));
        }

        public static void SaveLayoutToXml(this GridView dg, string nameForReports)
        {
            var optionsLayoutGrid = new OptionsLayoutGrid();
            optionsLayoutGrid.StoreAllOptions = true;
            optionsLayoutGrid.StoreDataSettings = false;
            dg.SaveLayoutToXml(GlobalParameters.XMLFolder + nameForReports + "Search.xml", optionsLayoutGrid);
        }

        public static void RestoreLayoutFromXml(this GridView dg)
        {
            dg.RestoreLayoutFromXml(dg.Name.Substring(2));
        }
        public static void RestoreLayoutFromXml(this GridView dg, string nameForReports)
        {
            if (File.Exists(GlobalParameters.XMLFolder + nameForReports + "Search.xml"))
                dg.RestoreLayoutFromXml(GlobalParameters.XMLFolder + nameForReports + "Search.xml");
        }

        public static void GetFileList(this LookUpEdit cbFileName, string filter, FileType fileType)
        {
            var s = GetStringFileList(filter, fileType);
            var dt = new List<ReportFile>();
            foreach (var item in s)
            {
                var info = new DirectoryInfo(item);
                var file = new ReportFile(info);
                if (file.Name.StartsWith("st"))
                    file.Name = file.Name.Substring(2);
                dt.Add(file);
            }
            cbFileName.Properties.Columns.Clear();
            cbFileName.Properties.Columns.Add(new LookUpColumnInfo("Name", "Name"));
            cbFileName.Properties.ShowHeader = false;
            cbFileName.Properties.DataSource = dt;
            cbFileName.Properties.DisplayMember = "Name";
            cbFileName.Properties.ValueMember = "Name";
            cbFileName.Properties.NullText = StringParameters.LookupEditNullTextReport;
            if (dt.Count > 0)
                cbFileName.ItemIndex = 0;
        }

        public static void GetFileList(this BarEditItem cbFileName, string filter, FileType fileType)
        {
            var s = GetStringFileList(filter, fileType);
            var cb = (cbFileName.Edit as RepositoryItemComboBox);
            cb.Items.Clear();
            foreach (var item in s)
            {
                var info = new DirectoryInfo(item);
                var file = new ReportFile(info);
                if (file.Name.StartsWith("st"))
                    file.Name = file.Name.Substring(2);
                cb.Items.Add(file);
            }

            if (cb.Items.Count > 0)
                cbFileName.EditValue = cb.Items[0];
        }

        public static string[] GetStringFileList(string filter, FileType type)
        {
            var folder = GlobalParameters.ReportsFolder;
            var gafartoeba = GetDescriptionAttributeForFilter(type);
            return Directory.GetFiles(folder, filter + gafartoeba);
        }

        public static string GetDescriptionAttributeForFilter(this FileType a)
        {
            var type = a.GetType();
            var memberInfo = type.GetMember(a.ToString());
            if (memberInfo.Length > 0)
            {
                var attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            return a.ToString();
        }

        public static string GetDescriptionAttribute(this FileType a)
        {
            return a.GetDescriptionAttributeForFilter().Replace("*", string.Empty);
        }

        public static void OpenFile(string fileName)
        {
            try
            {
                var process = new Process();
                process.StartInfo.FileName = fileName;
                process.StartInfo.Verb = "Open";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.Start();
            }
            catch (Exception e)
            {
                e.ShowErrorDialog();
            }
        }

        [Obsolete("გადასაყვანია Devexpress-ზე")]
        public static void GetFileList(string filter, ToolStripComboBox cbFileName, string gafartoeba)
        {
            GetFileList(filter, cbFileName, gafartoeba, false);
        }

        [Obsolete("გადასაყვანია Devexpress-ზე")]
        public static void GetFileList(string filter, ToolStripComboBox cbFileName, string gafartoeba,
            bool replaceFilter)
        {
            var s = GetStringFileList(filter, gafartoeba);
            cbFileName.Items.Clear();
            foreach (var item in s)
            {
                var s1 = item.Substring(item.LastIndexOf("\\", StringComparison.Ordinal) + 1,
                    item.Length - item.LastIndexOf("\\", StringComparison.Ordinal) - 1);
                s1 = s1.Substring(0, s1.Length - 4);
                if (replaceFilter)
                    s1 = s1.Replace(filter, string.Empty);
                cbFileName.Items.Add(s1);
            }
            if (cbFileName.Items.Count > 0)
                cbFileName.Text = cbFileName.Items[0].ToString();
        }

        public static void GetFileList(string filter, LookUpEdit cbFileName, string gafartoeba)
        {
            var s = GetStringFileList(filter, gafartoeba);
            var dt = new DataTable();
            dt.Columns.Add("Name");
            foreach (var item in s)
            {
                var s1 = item.Substring(item.LastIndexOf("\\") + 1, item.Length - item.LastIndexOf("\\") - 1);
                s1 = s1.Substring(0, s1.Length - 4);
                dt.Rows.Add(s1);
            }
            cbFileName.Properties.ShowHeader = false;
            cbFileName.Properties.DataSource = dt;
            cbFileName.Properties.DisplayMember = "Name";
            cbFileName.Properties.ValueMember = "Name";
            cbFileName.Properties.NullText = StringParameters.LookupEditNullTextReport;
            cbFileName.ItemIndex = 0;
        }

        [Obsolete("გადასაყვანია Devexpress-ზე")]
        public static void GetFileList(string filter, ComboBox cbFileName, string gafartoeba)
        {
            var s = GetStringFileList(filter, gafartoeba);
            cbFileName.Items.Clear();
            foreach (var item in s)
            {
                var s1 = item.Substring(item.LastIndexOf("\\", StringComparison.Ordinal) + 1,
                    item.Length - item.LastIndexOf("\\", StringComparison.Ordinal) - 1);
                s1 = s1.Substring(0, s1.Length - 4);
                cbFileName.Items.Add(s1);
            }
            if (cbFileName.Items.Count > 0)
                cbFileName.Text = cbFileName.Items[0].ToString();
        }

        public static void GetFileList(string filter, BarEditItem cbFileName, string gafartoeba)
        {
            var s = GetStringFileList(filter, gafartoeba);
            var cb = (cbFileName.Edit as RepositoryItemComboBox);
            cb.Items.Clear();
            foreach (var item in s)
            {
                var s1 = item.Substring(item.LastIndexOf("\\") + 1, item.Length - item.LastIndexOf("\\") - 1);
                s1 = s1.Substring(0, s1.Length - 4);
                if (s1.EndsWith("."))
                    s1 = s1.Substring(0, s1.Length - 1);
                if (s1.StartsWith("st"))
                    s1 = s1.Substring(2);
                if (gafartoeba == "*.xml")
                {
                    if (filter.Length >= s1.Length) continue;
                    s1 = s1.Substring(filter.Length, s1.Length - filter.Length);
                    cb.Items.Add(s1);
                }
                else
                    cb.Items.Add(s1);
            }

            if (cb.Items.Count > 0)
                cbFileName.EditValue = cb.Items[0].ToString();
        }

        public static string[] GetStringFileList(string filter, string gafartoeba)
        {
            string folder;
            switch (gafartoeba)
            {
                case "*.xml":
                    folder = GlobalParameters.XMLFolder;
                    break;
                default:
                    folder = GlobalParameters.ReportsFolder;
                    break;
            }
            return Directory.GetFiles(folder, filter + gafartoeba);
        }

        [Obsolete("გადასაყვანია Devexpress-ზე")]
        public static void SetDGParameters(string filter, ToolStripComboBox cbXml, GridControl dg)
        {
            GetFileList(filter, cbXml, "*.xml", true);
            if (!InterfaceParameters.RestoreDgSettings) return;
            if (File.Exists(GlobalParameters.XMLFolder + filter + cbXml.Text + ".xml"))
                dg.DefaultView.RestoreLayoutFromXml(GlobalParameters.XMLFolder + filter + cbXml.Text + ".xml");
        }

        [Obsolete("გადასაყვანია Devexpress-ზე")]
        public static void SaveLayouts(ToolStripButton btn, GridControl dg, GridControl dgDet, string nameForReports,
            ToolStripComboBox cbXml, ToolStripComboBox cbDetXml)
        {
            SaveLayouts(btn, dg, nameForReports, cbXml);
            switch (btn.Name)
            {
                case "btnDetSaveDGlayout":
                    dgDet.DefaultView.SaveLayoutToXml(GlobalParameters.XMLFolder + cbDetXml.Text + ".xml");
                    GetFileList("DGDet" + nameForReports, cbDetXml, "*.xml", true);
                    break;
                case "btnDetRestoreDGlayout":
                    if (File.Exists(GlobalParameters.XMLFolder + cbDetXml.Text + ".xml"))
                        dgDet.DefaultView.RestoreLayoutFromXml(GlobalParameters.XMLFolder + cbDetXml.Text + ".xml");
                    break;
            }
        }

        [Obsolete("გადასაყვანია Devexpress-ზე")]
        public static void SaveLayouts(ToolStripButton btn, GridControl dg, string nameForReports,
            ToolStripComboBox cbXml)
        {
            if (btn.Name.Contains("Save"))
            {
                dg.DefaultView.SaveLayoutToXml(GlobalParameters.XMLFolder + "DG" + nameForReports + cbXml.Text +
                                               ".xml");
                GetFileList("DG" + nameForReports, cbXml, "*.xml", true);
            }
            else if (btn.Name.Contains("Restore"))
                if (File.Exists(GlobalParameters.XMLFolder + "DG" + nameForReports + cbXml.Text + ".xml"))
                    dg.DefaultView.RestoreLayoutFromXml(GlobalParameters.XMLFolder + "DG" + nameForReports +
                                                        cbXml.Text + ".xml");
        }

        public static void OrgProd_Layouts(string lName, GridControl dg, bool restore)
        {
            if (restore)
                dg.DefaultView.RestoreLayoutFromRegistry(InterfaceParameters.RegKey + lName);
            else
                dg.DefaultView.SaveLayoutToRegistry(InterfaceParameters.RegKey + lName);
        }

        public static void FPosition_Save(Form frm)
        {
            try
            {
                Registry.SetValue(InterfaceParameters.RegKey, frm.Name + "Pos",
                    frm.Location.X + ";" + frm.Location.Y + ";" + frm.Size.Width + ";" + frm.Size.Height,
                    RegistryValueKind.String);
                Registry.SetValue(InterfaceParameters.RegKey, frm.Name + "WState", frm.WindowState.ToString(),
                    RegistryValueKind.String);
            }
            catch
            {
            }
        }

        public static void FPosition_Restore(Form frm)
        {
            var key = Registry.CurrentUser.OpenSubKey(InterfaceParameters.RegKey.Remove(0, 18)) ??
                      Registry.CurrentUser.CreateSubKey(InterfaceParameters.RegKey);
            try
            {
                var posit = key.GetValue(frm.Name + "Pos").ToString().Split(';');

                var rect = new Rectangle(Convert.ToInt32(posit[0]), Convert.ToInt32(posit[1]),
                    Convert.ToInt32(posit[2]), Convert.ToInt32(posit[3]));
                if (rect != Rectangle.Empty &&
                    IsVisibleOnAnyScreen(rect))
                {
                    frm.DesktopBounds = rect;
                }
                else
                {
                    frm.StartPosition = FormStartPosition.WindowsDefaultLocation;
                }
            }
            finally
            {
                key.Close();
            }
        }

        static bool IsVisibleOnAnyScreen(Rectangle rect)
        {
            foreach (var screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.IntersectsWith(rect))
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region StringOperations

        public static string RerurnDataText(this DateTime d)
        {
            return string.Format("{0} {1} {2}", d.Day, ReturnTveText(d.Month), d.Year);
        }

        public static string ReturnTextDataForReports(DateTime d1, DateTime d2)
        {
            return string.Format("{0}/{1}/{2} - {3}/{4}/{5}",
                d1.Day, d1.Month, d1.Year, d2.Day, d2.Month, d2.Year);
        }

        public static string ReturnTveText(int tve)
        {
            string tveText;
            switch (tve)
            {
                case 1:
                    tveText = StringParameters.January;
                    break;
                case 2:
                    tveText = StringParameters.February;
                    break;
                case 3:
                    tveText = StringParameters.March;
                    break;
                case 4:
                    tveText = StringParameters.April;
                    break;
                case 5:
                    tveText = StringParameters.May;
                    break;
                case 6:
                    tveText = StringParameters.June;
                    break;
                case 7:
                    tveText = StringParameters.July;
                    break;
                case 8:
                    tveText = StringParameters.August;
                    break;
                case 9:
                    tveText = StringParameters.September;
                    break;
                case 10:
                    tveText = StringParameters.October;
                    break;
                case 11:
                    tveText = StringParameters.November;
                    break;
                default:
                    tveText = StringParameters.December;
                    break;
            }
            return tveText;
        }

        public static string ReturnTanxaText(double tanxa)
        {
            var s2 = "";
            tanxa = Convert.ToDouble(tanxa.ToString("0.00"));
            var s = tanxa.ToString("0");
            var i = Convert.ToInt32(s);
            tanxa = Convert.ToDouble(((tanxa - i) * 100).ToString("0"));
            if (tanxa < 0)
            {
                tanxa += 100;
                i = i - 1;
            }

            var j = i / 1000000;
            if (j > 0)
                s2 = ReturnIntValueToText(j) + "მილიონი";

            i = i - i / 1000000 * 1000000;
            j = i / 1000;
            if (j > 0)
            {
                if (s2.Length > 0)
                    s2 = s2.Substring(0, s2.Length - 1);
                s2 += ReturnIntValueToText(j) + "ათასი";
            }

            j = i - i / 1000 * 1000;
            if (j > 0)
            {
                if (s2.Length > 0)
                    s2 = s2.Substring(0, s2.Length - 1);
                s2 += ReturnIntValueToText(j);
            }

            s2 += " ლარი " + tanxa.ToString("0") + " თეთრი ";
            return s2;
        }

        public static string ReturnIntValueToText(int j)
        {
            string[] tanxaText =
            {
                "ნული", "ერთი", "ორი", "სამი", "ოთხი", "ხუთი", "ექვსი", "შვიდი", "რვა", "ცხრა", "ათი",
                "თერთმეტი", "თორმეტი", "ცამეტი", "თოთხმეტი", "თხუთმეტი", "თექვსმეტი", "ჩვიდმეტი", "თვრამეტი", "ცხრამეტი",
                "ოც", "ორმოც", "სამოც", "ოთხმოც", "ას"
            };

            int k;
            var s = string.Empty;

            var i = j / 100;
            if (i != 0)
            {
                if (i != 1)
                    s += tanxaText[i];
                k = s.Length;
                if (k != 0 && s[k - 1] == 'ი')
                    s = s.Substring(0, k - 1);
                s += tanxaText[24];
            }

            j = j - j / 100 * 100;
            i = j / 20;
            k = 0;
            var da = false;
            if (i != 0)
            {
                if (i != 1)
                    k = s.Length;
                if (k != 0 && s[k - 1] == 'ი')
                    s = s.Substring(0, k - 1);
                s += tanxaText[19 + i];
                da = true;
            }

            i = j - j / 20 * 20;
            if (i != 0)
            {
                if (s != string.Empty && da)
                    s += "და";
                s += tanxaText[i];
            }
            else
            {
                k = s.Length;
                if (k != 0 && s[k - 1] != 'ი')
                    s = s + "ი";
            }

            return s;
        }

        #endregion

        #region IFMG

        public static void SaveToRegistry(this IFMGFindControl ctr)
        {
            if (ctr.SplitContainer.Panel2Collapsed) return;
            if (ctr.FieldName == null) return;
            var key = Registry.CurrentUser.OpenSubKey(
                "SOFTWARE\\FMGSoft\\" + GlobalParameters.DatabaseName + "\\Defaults\\", true);
            if (key == null)
            {
                Registry.CurrentUser.CreateSubKey("SOFTWARE\\FMGSoft\\");
                Registry.CurrentUser.CreateSubKey("SOFTWARE\\FMGSoft\\" + GlobalParameters.DatabaseName + "\\");
                key =
                    Registry.CurrentUser.CreateSubKey("SOFTWARE\\FMGSoft\\" + GlobalParameters.DatabaseName +
                                                      "\\Defaults\\");
            }
            key.SetValue(ctr.FieldName, ctr.SplitContainer.SplitterDistance, RegistryValueKind.String);
            key.Close();
        }

        public static void RestoreFromRegistry(this IFMGFindControl ctr)
        {
            if (ctr.FieldName == null) return;
            var key = Registry.CurrentUser.OpenSubKey(
                "SOFTWARE\\FMGSoft\\" + GlobalParameters.DatabaseName + "\\Defaults\\", true);
            if (key == null) return;
            var s = key.GetValue(ctr.FieldName, 150).ToString();
            ctr.SplitContainer.SplitterDistance = Convert.ToInt32(s);
        }

        public static bool IsInRuntimeMode(this IComponent component)
        {
            bool ret = IsInDesignMode(component);
            return !ret;
        }

        public static bool IsInDesignMode(this IComponent component)
        {
            bool ret = false;
            if (null == component) return false;
            ISite site = component.Site;
            if (null != site)
            {
                ret = site.DesignMode;
            }
            else if (component is Control)
            {
                IComponent parent = ((Control)component).Parent;
                ret = IsInDesignMode(parent);
            }

            return ret;
        }

        #endregion

        #region DateTime

        public static void SetDateFormat(this DateEdit txtData, bool assignDate = true, bool hasTime = false)
        {
            txtData.SetDateFormat(assignDate ? DateTime.Now : txtData.DateTime, hasTime);
        }

        public static void SetDateFormat(this DateEdit txtData, DateTime date, bool hasTime = true)
        {
            if (!hasTime)
                date = Convert.ToDateTime(date.ToShortDateString());
            txtData.DateTime = date;
            txtData.Properties.AllowNullInput = DefaultBoolean.False;
            txtData.Properties.Appearance.Font = new Font(GlobalParameters.FontName, GlobalParameters.FontSize);
            txtData.Properties.Appearance.Options.UseFont = true;
            txtData.Properties.Buttons.Clear();
            txtData.Properties.ShowClear = false;
            txtData.Properties.Buttons.AddRange(new[]
            {
                new EditorButton(ButtonPredefines.Glyph, StringParameters.CaptionTxtData, -1, true, true, false,
                    ImageLocation.MiddleCenter, Resources.AED_txtData_16x16)
            });
            var format = GlobalParameters.DateFormat + (hasTime ? " HH:mm" : string.Empty);
            txtData.Properties.DisplayFormat.FormatString = format;
            txtData.Properties.DisplayFormat.FormatType = FormatType.DateTime;
            txtData.Properties.EditFormat.FormatString = format;
            txtData.Properties.EditFormat.FormatType = FormatType.DateTime;
            txtData.Properties.Mask.EditMask = format;
            txtData.Font = GlobalParameters.Font;
            var tSize = TextRenderer.MeasureText(txtData.Text, GlobalParameters.Font);
            txtData.Size = new Size(tSize.Width + Resources.AED_txtData_16x16.Size.Width + 4, tSize.Height);
        }

        public static void SetDateFormat(this FMGDateFilterControl dtp)
        {
            dtp.txtData1.SetDateFormat(DateTime.Today, dtp.ShowTime);
            dtp.txtData2.SetDateFormat(DateTime.Today.AddDays(1).AddMinutes(-1), dtp.ShowTime);
        }

        #endregion

        #region CanUserModifyData

        public static bool CanUserModifyData(this GridView gv)
        {
            var row = gv.GetFocusedDataRow();
            if (row == null) return false;
            return CanUserModifyData(Convert.ToDateTime(row["Data"]), row["UN"].ToString());
        }

        public static bool CanUserModifyData(this GridView gv, GridView gvDet)
        {
            var row = gv.GetFocusedDataRow();
            var rowDet = gvDet.GetFocusedDataRow();
            if (row == null) return false;
            if (rowDet == null)
                return CanUserModifyData(Convert.ToDateTime(row["Data"]));
            return CanUserModifyData(Convert.ToDateTime(row["Data"]), rowDet["UN"].ToString());
        }

        public static bool CanUserModifyData(this DateEdit d)
        {
            return d.DateTime.CanUserModifyData();
        }

        public static bool CanUserModifyData(this DateTime d)
        {
            var result = d.AddDays(InterfaceParameters.GascorebaDge) >= DateTime.Today;
            if (InterfaceParameters.DeniedAfterClose && d <= InterfaceParameters.Dge) result = false;
            return result;
        }

        public static bool CanUserModifyData(DateTime d, string un)
        {
            if (un.ToLower() == "sa") return true;
            if (d.AddDays(InterfaceParameters.GascorebaDge) < DateTime.Today ||
                (InterfaceParameters.DeniedAfterClose && d <= InterfaceParameters.Dge))
            {
                XtraMessageBox.Show(StringParameters.GascorebaDgeError, StringParameters.CaptionError,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (InterfaceParameters.GascorebaSxva || un == GlobalParameters.UserName)
                return true;

            XtraMessageBox.Show(StringParameters.GascorebaSxvaError, StringParameters.CaptionError, MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return false;
        }

        #endregion

        #region ChangeFonts

        [Obsolete("ამოსაღებია, გამოიყენეთ CLSTools.ChangeFonts(gv1, gv2...)")]
        public static void SetAEDFormParametersWhenLoading(params GridView[] gvs)
        {
            foreach (var view in gvs)
                view.ChangeFonts();
        }

        public static void ChangeFonts(params GridView[] gvs)
        {
            foreach (var view in gvs)
                view.ChangeFonts();
        }

        public static void ChangeFonts(this GridView gv, bool isDataTable = false)
        {
            CLSCustomCnobari.SetTexts(gv, gv.Name.Substring(2));
            gv.Appearance.HeaderPanel.TextOptions.WordWrap = WordWrap.Wrap;
            gv.GroupPanelText = StringParameters.GridViewGroupPanelText;
            gv.KeyDown += (sender, e) =>
            {
                if (e.Control && e.KeyCode == Keys.C)
                {
                    var text = gv.GetFocusedDisplayText();
                    if (string.IsNullOrEmpty(text)) return;
                    Clipboard.SetText(gv.GetFocusedDisplayText());
                    e.Handled = true;
                }
            };
            var dxMenuCheckItem = new DXMenuCheckItem(StringParameters.GridColumnFilterMode, false);
            gv.PopupMenuShowing += (a, e) =>
            {
                if (e.Menu == null)
                {
                    showAedPopup = true;
                    return;
                }
                if (e.Menu.MenuType != GridMenuType.Column && e.Menu.MenuType != GridMenuType.Summary)
                {
                    showAedPopup = true;
                    return;
                }
                showAedPopup = false;

                if (CLSCustomCnobari.HasTranslate && InterfaceParameters.InterfaceLanguage != "NameEng")
                    foreach (DXMenuItem i in e.Menu.Items)
                        i.Caption = i.Caption.TranslateFromEng();

                if (e.MenuType != GridMenuType.Column) return;

                if (e.HitInfo.Column != null)
                    e.Menu.Items.Add(new DXMenuItem(StringParameters.GridColumnFreezeLeft,
                        delegate { e.HitInfo.Column.Fixed = FixedStyle.Left; }, Resources.Freeze_Column_Left)
                    {
                        BeginGroup = true
                    });

                if (e.HitInfo.Column != null)
                    e.Menu.Items.Add(new DXMenuItem(StringParameters.GridColumnFreezeRight,
                        delegate { e.HitInfo.Column.Fixed = FixedStyle.Right; }, Resources.Freeze_Column_Right));

                if (e.HitInfo.Column != null && e.HitInfo.Column.Fixed != FixedStyle.None)
                    e.Menu.Items.Add(new DXMenuItem(StringParameters.GridColumnRemoveFreeze,
                        delegate { e.HitInfo.Column.Fixed = FixedStyle.None; }, Resources.Freeze_Column_Remove));

                if (e.HitInfo.Column != null)
                    e.Menu.Items.Add(new DXMenuItem(StringParameters.GridColumnRemoveFreezeAll,
                        delegate
                        {
                            foreach (GridColumn column in gv.Columns)
                            {
                                if (column.Fixed != FixedStyle.None)
                                    column.Fixed = FixedStyle.None;
                            }
                        }, Resources.Freeze_Column_Remove_All));

                dxMenuCheckItem.CheckedChanged += (sender, args) =>
                {
                    var checkItem = sender as DXMenuCheckItem;
                    if (checkItem == null) return;
                    for (var i = 0; i < gv.Columns.Count; i++)
                    {
                        gv.Columns[i].OptionsFilter.FilterPopupMode = checkItem.Checked
                            ? FilterPopupMode.CheckedList : FilterPopupMode.Default;
                    }
                };
                dxMenuCheckItem.CloseMenuOnClick = false;
                e.Menu.Items.Add(dxMenuCheckItem);

                if (!isDataTable) return;
                if (e.HitInfo.Column == null) return;
                var ints = gv.GetSelectedRows();
                if (ints.Length <= 0) return;
                var tableName = gv.Name.Substring(2);
                var fieldName = e.HitInfo.Column.FieldName;
                if (!GlobalParameters.AdminChangeSelecteds.ContainsKey(fieldName + CLSCustomCnobari.Mid + tableName)) return;
                e.Menu.Items.Add(new DXMenuItem(StringParameters.GridColumnChangeSelected + " (" + e.HitInfo.Column.Caption + ")",
                    delegate
                    {
                        var form = new ChangeSelectedForm(gv, e.HitInfo.Column, GlobalParameters.AdminChangeSelecteds[fieldName + CLSCustomCnobari.Mid + tableName]);
                        if (form.ShowDialog() != DialogResult.OK) return;
                        XtraMessageBox.Show("ინფორმაცია წარმატებით გაახლდა, გთხოვთ გაახლოთ გვერდი");
                    }, Resources.AED_ChangeSelected_16x16));
            };

            var menu = gv.GridControl.ContextMenuStrip;
            if (menu == null)
            {
                menu = new ContextMenuStrip();
                gv.GridControl.ContextMenuStrip = menu;
            }
            var itemShowFields = new ToolStripMenuItem("ველების გამოჩენა");
            itemShowFields.ShortcutKeys = Keys.Control | Keys.F12;
            itemShowFields.Visible = false;
            itemShowFields.Click += delegate
            {
                foreach (GridColumn col in gv.Columns)
                {
                    if (col.Tag == null)
                    {
                        col.Tag = col.Caption;
                        col.Caption = col.FieldName;
                    }
                    else
                    {
                        col.Caption = col.Tag.ToString();
                        col.Tag = null;
                    }
                }
            };
            menu.Items.Add(itemShowFields);
        }

        public static void ChangeFonts(this PivotGridControl pt)
        {
            pt.OptionsDataField.Area = PivotDataArea.ColumnArea;
            pt.OptionsDataField.Caption = StringParameters.PtOptionsDataFieldCaption;
            CLSCustomCnobari.SetTexts(pt, pt.Name.Substring(2));

            if (!CLSCustomCnobari.HasTranslate) return;
            pt.PopupMenuShowing += delegate(object a, PopupMenuShowingEventArgs e)
            {
                if (InterfaceParameters.InterfaceLanguage == "NameEng") return;
                foreach (DXMenuItem i in e.Menu.Items)
                    i.Caption = i.Caption.TranslateFromEng();
            };
        }

        public static void ChangeFonts(this XtraForm frm, params string[] notIncludedComboBoxNames)
        {
            foreach (Control cr in frm.Controls)
            {
                if (cr is IFMGFindControl)
                {
                    if (cr is FMGComboFilterControl)
                        (cr as FMGComboFilterControl).FillDataToComboBox();
                    if (cr is FMGDateFilterControl)
                    {
                        (cr as FMGDateFilterControl).SetDateFormat();
                    }

                    (cr as IFMGFindControl).SetText(frm.Name);
                    continue;
                }
                if (cr is LookUpEdit)
                {
                    cr.Font = GlobalParameters.Font;
                    (cr as LookUpEdit).Properties.AppearanceDropDown.Font = GlobalParameters.Font;
                    if (!notIncludedComboBoxNames.Contains(cr.Name))
                        ((LookUpEdit)cr).FillDataToLookUpEditAndSetFont();
                    continue;
                }
                if (cr is ComboBox)
                {
                    cr.Font = GlobalParameters.Font;
                    if (!notIncludedComboBoxNames.Contains(cr.Name))
                        FillDataToComboBoxAndSetFont((ComboBox)cr, ReturnTextFromName(cr.Name, 2));
                    continue;
                }
                if (cr is TextEdit)
                {
                    cr.Font = GlobalParameters.Font;
                    //cr.TextChanged += txtvalue_TextChanged;
                    continue;
                }
                if (cr is LabelControl || cr is CheckEdit || cr is SimpleButton)
                {
                    cr.Font = GlobalParameters.Font;
                    cr.SetText(frm.Name.Substring(3, frm.Name.Length - 7));
                }
            }
        }

        private static void txtvalue_TextChanged(object sender, EventArgs e)
        {
            (sender as TextEdit).Text=(sender as TextEdit).Text.Replace("\'", "ʼ");
        }

        public static void ChangeFonts(this PanelControl pnl, params string[] notIncludedComboBoxNames)
        {
            pnl.Text = pnl.Text.Translate();
            foreach (Control cr in pnl.Controls)
            {
                if (cr is IFMGFindControl)
                {
                    if (cr is FMGComboFilterControl)
                        (cr as FMGComboFilterControl).FillDataToComboBox();
                    if (cr is FMGDateFilterControl)
                    {
                        (cr as FMGDateFilterControl).SetDateFormat();
                    }

                    (cr as IFMGFindControl).SetText(pnl.Name.Substring(2));
                    continue;
                }
                if (cr is LookUpEdit)
                {
                    cr.Font = GlobalParameters.Font;
                    (cr as LookUpEdit).Properties.AppearanceDropDown.Font = GlobalParameters.Font;
                    if (!notIncludedComboBoxNames.Contains(cr.Name))
                        (cr as LookUpEdit).FillDataToLookUpEditAndSetFont();
                    continue;
                }
                if (cr is ComboBox)
                {
                    cr.Font = GlobalParameters.Font;
                    if (!notIncludedComboBoxNames.Contains(cr.Name))
                        FillDataToComboBoxAndSetFont((ComboBox)cr, ReturnTextFromName(cr.Name, 2));
                    continue;
                }
                if (cr is TextEdit)
                {
                    cr.Font = GlobalParameters.Font;
                    continue;
                }
                if (cr is LabelControl || cr is CheckEdit || cr is SimpleButton)
                {
                    cr.Font = GlobalParameters.Font;
                    cr.SetText(pnl.Name.Substring(2));
                }
            }
        }

        public static void ChangeFonts(this GroupBox pnl, params string[] notIncludedComboBoxNames)
        {
            pnl.Text = pnl.Text.Translate();
            foreach (Control cr in pnl.Controls)
            {
                if (cr is IFMGFindControl)
                {
                    if (cr is FMGComboFilterControl)
                        (cr as FMGComboFilterControl).FillDataToComboBox();
                    if (cr is FMGDateFilterControl)
                    {
                        (cr as FMGDateFilterControl).SetDateFormat();
                    }

                    (cr as IFMGFindControl).SetText(pnl.Name.Substring(2));
                    continue;
                }
                if (cr is LookUpEdit)
                {
                    cr.Font = GlobalParameters.Font;
                    (cr as LookUpEdit).Properties.AppearanceDropDown.Font = GlobalParameters.Font;
                    if (!notIncludedComboBoxNames.Contains(cr.Name))
                        (cr as LookUpEdit).FillDataToLookUpEditAndSetFont();
                    continue;
                }
                if (cr is ComboBox)
                {
                    cr.Font = GlobalParameters.Font;
                    if (!notIncludedComboBoxNames.Contains(cr.Name))
                        FillDataToComboBoxAndSetFont((ComboBox)cr, ReturnTextFromName(cr.Name, 2));
                    continue;
                }
                if (cr is TextEdit)
                {
                    cr.Font = GlobalParameters.Font;
                    continue;
                }
                if (cr is LabelControl || cr is CheckEdit || cr is SimpleButton)
                {
                    cr.Font = GlobalParameters.Font;
                    cr.SetText(pnl.Name.Substring(2));
                }
            }
        }

        #endregion

        #region Returns

        /// <summary>
        /// gvProd ის შემთხვევაში აბრუნებს "Prod" ის მნიშვნელობას
        /// </summary>
        /// <param name="gv"></param>
        /// <returns></returns>
        public static string ReturnValue(this GridView gv)
        {
            return gv.ReturnValue(gv.Name.Substring(2));
        }

        public static string ReturnValue(this GridView gv, string columnName)
        {
            if (gv.FocusedRowHandle < 0) return "0";
            try
            {
                var o = gv.GetFocusedRowCellValue(columnName);
                return o != null ? o.ToString() : "0";
            }
            catch
            {
                XtraMessageBox.Show(columnName + " ვერ მოიძებნა ");
                return "0";
            }
        }

        public static string ReturnZedd(this GridView gv)
        {
            return gv.ReturnValue("Zedd");
        }

        public static string ReturnId(this GridView gv)
        {
            if (gv.FocusedRowHandle < 0) return "0";
            var columnName = "Id" + gv.Name.Substring(2);
            try
            {
                var o = gv.GetFocusedRowCellValue(columnName);
                return o != null ? o.ToString() : "0";
            }
            catch
            {
                XtraMessageBox.Show(columnName + " ვერ მოიძებნა ");
                return "0";
            }
        }

        /// <summary>
        /// WHERE columnName = N'value'
        /// ექსეფშენის შემთხვევაში WHERE 1 = 1
        /// </summary>
        /// <param name="gv"></param>
        /// <returns></returns>
        public static string ReturnWhereId(this GridView gv)
        {
            if (gv.FocusedRowHandle < 0) return " WHERE 1 = 1 ";
            var columnName = "Id" + gv.Name.Substring(2);
            try
            {
                var o = gv.GetFocusedRowCellValue(columnName);
                return " WHERE " + columnName + " = N'" + (o != null ? o.ToString() : "0") + "'";
            }
            catch
            {
                XtraMessageBox.Show(columnName + " ვერ მოიძებნა ");
                return " WHERE 1 = 1 ";
            }
        }

        /// <summary>
        /// WHERE columnName = N'value'
        /// ექსეფშენის შემთხვევაში WHERE 1 = 1
        /// </summary>
        /// <param name="gv"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static string ReturnWhereId(this GridView gv, string columnName)
        {
            if (gv.FocusedRowHandle < 0) return " WHERE 1 = 1 ";
            try
            {
                var o = gv.GetFocusedRowCellValue(columnName);
                return " WHERE " + columnName + " = N'" + (o != null ? o.ToString() : "0") + "'";
            }
            catch
            {
                XtraMessageBox.Show(columnName + " ვერ მოიძებნა ");
                return " WHERE 1 = 1 ";
            }
        }

        public static int ReturnInt32(this GridView gv)
        {
            var columnName = "Id" + gv.Name.Substring(2);
            return gv.ReturnInt32(columnName);
        }

        public static int ReturnInt32(this GridView gv, string columnName)
        {
            if (gv.FocusedRowHandle < 0) return 0;
            try
            {
                var o = gv.GetFocusedRowCellValue(columnName);
                return o != null ? Convert.ToInt32(o.ToString()) : 0;
            }
            catch
            {
                XtraMessageBox.Show(columnName + " ვერ მოიძებნა ");
                return 0;
            }
        }

        public static double ReturnDouble(this GridView gv, string columnName)
        {
            if (gv.FocusedRowHandle < 0) return 0;
            try
            {
                var o = gv.GetFocusedRowCellValue(columnName);
                return o != null ? Convert.ToDouble(o.ToString()) : 0;
            }
            catch
            {
                XtraMessageBox.Show(columnName + " ვერ მოიძებნა ");
                return 0;
            }
        }

        public static decimal ReturnDecimal(this GridView gv, string columnName)
        {
            if (gv.FocusedRowHandle < 0) return 0;
            try
            {
                var o = gv.GetFocusedRowCellValue(columnName);
                return o != null ? Convert.ToDecimal(o.ToString()) : 0;
            }
            catch
            {
                XtraMessageBox.Show(columnName + " ვერ მოიძებნა ");
                return 0;
            }
        }

        public static bool ReturnBool(this GridView gv, string columnName)
        {
            if (gv.FocusedRowHandle < 0) return false;
            try
            {
                var o = gv.GetFocusedRowCellValue(columnName);
                return o != null && Convert.ToBoolean(o.ToString());
            }
            catch
            {
                XtraMessageBox.Show(columnName + " ვერ მოიძებნა ");
                return false;
            }
        }

        public static DateTime ReturnDate(this GridView gv, string columnName = "Data")
        {
            if (gv.FocusedRowHandle < 0) return DateTime.Now;
            try
            {
                var o = gv.GetFocusedRowCellValue(columnName);
                return o != null ? Convert.ToDateTime(o.ToString()) : DateTime.Now;
            }
            catch
            {
                XtraMessageBox.Show(columnName + " ვერ მოიძებნა ");
                return DateTime.Now;
            }
        }

        #endregion

        #region FormActivate

        [Obsolete("გადასაყვანია Devexpress-ზე")]
        public static DataTable FormActivate(this GridView gv, string strComm, DateTimePicker txtFind,
            DateTimePicker txtFind1, string dataText = "Data")
        {
            return gv.FormActivate(strComm, txtFind.Value, txtFind1.Value, dataText);
        }

        public static DataTable FormActivate(this GridView gv, string strComm, BarEditItem txtFind, BarEditItem txtFind1, string dataText = "Data")
        {
            return gv.FormActivate(strComm, Convert.ToDateTime(txtFind.EditValue),
                Convert.ToDateTime(txtFind1.EditValue), dataText);
        }

        public static DataTable FormActivate(this GridView gv, string strComm, DateTime txtFind, DateTime txtFind1, string dataText)
        {
            strComm += string.Format(" WHERE {0} >= '{1}' AND {0} <= '{2}' ", dataText,
                txtFind.ToString(GlobalParameters.ServerDateTimeFormat),
                txtFind1.ToString(GlobalParameters.ServerDateTimeFormat));
            return gv.FormActivate(strComm);
        }

        public static DataTable FormActivate(this GridView gv, string strComm)
        {
            if (gv.GridControl == null) return null;
            var tableName = gv.Name.Remove(0, 2);
            var returnId = gv.ReturnId();
            var dt = SQL.Select(strComm);
            gv.GridControl.DataSource = null;
            gv.GridControl.DataSource = dt;
            gv.ClearSelection();
            if (GlobalParameters.IDForFind > 0)
            {
                gv.FocusedRowHandle = gv.LocateByValue("Id" + tableName, GlobalParameters.IDForFind);
                GlobalParameters.IDForFind = 0;
            }
            else
            {
                if (gv.Columns.ColumnByFieldName("Id" + tableName) == null)
                {
                    ShowMessageDialog("პროგრამული შეცდომა", "გრიდში არ მოიძებნა სვეტი Id" + tableName);
                    return dt;
                }
                int pos;
                switch (gv.Columns["Id" + tableName].ColumnType.FullName)
                {
                    case "System.String":
                    case "System.Object":
                        pos = gv.LocateByValue("Id" + tableName, returnId);
                        break;
                    case "System.Int32":
                        pos = gv.LocateByValue("Id" + tableName, Convert.ToInt32(returnId));
                        break;
                    case "System.Int16":
                        pos = gv.LocateByValue("Id" + tableName, Convert.ToInt16(returnId));
                        break;
                    default:
                        pos = 0;
                        break;
                }
                gv.FocusedRowHandle = pos;
            }
            gv.SelectRow(gv.FocusedRowHandle);
            return dt;
        }

        #endregion

        #region Combo

        public static void FillDataToComboBoxAndSetFont(this ComboBox cb)
        {
            cb.FillDataToComboBoxAndSetFont(cb.Name.Remove(0, 2));
        }

        public static void FillDataToComboBoxAndSetFont(this ComboBox cb, string tableName)
        {
            cb.FillDataToComboBoxAndSetFont(tableName, string.Empty);
        }

        public static void FillDataToComboBoxAndSetFont(this ComboBox cb, string tableName, string where)
        {
            cb.FillDataToComboBoxAndSetFont(tableName,  where, true);
        }
      
        public static void FillDataToComboBoxAndSetFont(this ComboBox cb, string tableName, string where,
            bool deleteLastNumber)
        {
            var lastChar = cb.Name.Substring(cb.Name.Length - 1);
            if (deleteLastNumber && (lastChar == "1" || lastChar == "2" || lastChar == "3" || lastChar == "4" ||
                                     lastChar == "5"))
                tableName = tableName.Substring(0, tableName.Length - 1);
            var dt = SQL.Select(string.Format("SELECT Id{0}, {0} FROM {0} {1}", tableName, where));
            cb.DataSource = dt;
            cb.ValueMember = "Id" + tableName;
            cb.DisplayMember = tableName;
            cb.KeyDown += null;
            cb.KeyDown += cb_KeyDown;
        }
     
        static void cb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.F9) return;
            var cls = new CLSAddToCombo();
            cls.ShowAddForm(sender as Control);
        }

        #endregion

        #region LookUpEdit

        public static void FillDataToLookUpEditAndSetFont(this LookUpEdit cb)
        {
            var tableName = cb.Name.Remove(0, 2);
            FillDataToLookUpEditAndSetFont(cb, tableName);
        }

        public static void FillDataToLookUpEditAndSetFont(this LookUpEdit cb, string tableName)
        {
            FillDataToLookUpEditAndSetFont(cb, tableName, string.Empty);
        }

        public static void FillDataToLookUpEditAndSetFont(this LookUpEdit cb, string tableName, string whereClause)
        {
            FillDataToLookUpEditAndSetFont(cb, tableName, whereClause, true);
        }

        public static void FillDataToLookUpEditAndSetFont(this LookUpEdit cb, string tableName, string whereClause,
            bool deleteLastNumber)
        {
            var lastChar = tableName == string.Empty
                ? cb.Name.Substring(cb.Name.Length - 1) : tableName.Substring(tableName.Length - 1);
            if (deleteLastNumber && (lastChar == "1" || lastChar == "2" || lastChar == "3" || lastChar == "4" ||
                lastChar == "5"))
                tableName = tableName.Substring(0, tableName.Length - 1);
            var dt = SQL.Select(string.Format("SELECT * FROM {0} {1}", tableName, whereClause));
            cb.Properties.DataSource = dt;
            cb.Properties.ValueMember = "Id" + tableName;
            cb.Properties.DisplayMember = tableName;
            cb.Properties.TextEditStyle = TextEditStyles.Standard;
            cb.Properties.NullText = StringParameters.LookupEditNullText;
            cb.Properties.ShowHeader = false;
            cb.Properties.Columns.Clear();
            cb.Properties.Columns.Add(new LookUpColumnInfo(tableName));
            cb.Properties.ShowNullValuePromptWhenFocused = true;
            if (dt.Rows.Count > 0)
                cb.EditValue = dt.Rows[0]["Id" + tableName];
            cb.PreviewKeyDown -= cb_KeyDown;
            cb.PreviewKeyDown += cb_KeyDown;
        }

        public static void FillDataToLookUpEditAndSetFont(this LookUpEdit cb, string tableName, bool deleteLastNumber,
            bool isView)
        {
            cb.FillDataToLookUpEditAndSetFont(tableName, deleteLastNumber, isView, string.Empty);
        }

        public static void FillDataToLookUpEditAndSetFont(this LookUpEdit cb, string tableName, bool deleteLastNumber,
            bool isView, string whereClause)
        {
            var lastChar = cb.Name.Substring(cb.Name.Length - 1);
            if (deleteLastNumber && (lastChar == "1" || lastChar == "2" || lastChar == "3" || lastChar == "4" ||
                lastChar == "5"))
                tableName = tableName.Substring(0, tableName.Length - 1);
            var dt =
                SQL.Select(string.Format("SELECT * FROM {0}{1} {2}", tableName,
                isView ? "View" : string.Empty, whereClause));
            cb.Properties.DataSource = dt;
            cb.Properties.ValueMember = "Id" + tableName;
            cb.Properties.DisplayMember = tableName;
            cb.Properties.TextEditStyle = TextEditStyles.Standard;
            cb.Properties.NullText = StringParameters.LookupEditNullText;
            cb.Properties.ShowHeader = isView;
            cb.Properties.Columns.Clear();
            cb.Properties.Columns.Add(new LookUpColumnInfo(tableName));
            cb.Properties.ShowNullValuePromptWhenFocused = true;
            if (dt.Rows.Count > 0)
                cb.EditValue = dt.Rows[0]["Id" + tableName];
            cb.PreviewKeyDown -= cb_KeyDown;
            cb.PreviewKeyDown += cb_KeyDown;
        }

        static void cb_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode != Keys.F9) return;
            var cls = new CLSAddToCombo();
            cls.ShowAddForm(sender as Control);
        }

        public static void SetLookUpEditValue(this LookUpEdit cb, object value)
        {
            cb.SetLookUpEditValue(value, true);
        }

        public static void SetLookUpEditValue(this LookUpEdit cb, object value, bool deleteLastNumber)
        {
            var tableName = cb.Name.Remove(0, 2);
            if (deleteLastNumber)
            {
                if (char.IsDigit(tableName[tableName.Length - 1]))
                    tableName = tableName.Substring(0, tableName.Length - 1);
            }
            var i = cb.Properties.GetDataSourceRowIndex("Id" + tableName, value);
            cb.EditValue = cb.Properties.GetDataSourceValue("Id" + tableName, i);
        }

        public static void SetLookUpEditColumns(this LookUpEdit cb, string[] fields, string[] captions, int[] width,
            bool showHeader)
        {
            cb.Properties.Columns.Clear();
            cb.Properties.ShowHeader = showHeader;
            for (var i = 0; i < fields.Length; i++)
            {
                cb.Properties.Columns.Add(new LookUpColumnInfo(fields[i], captions[i].Translate(), width[i]));
            }
        }

        public static void FillDataToComboBox(this FMGComboFilterControl fmgFilter)
        {
            fmgFilter.cb.Name = "cb" + fmgFilter.FieldName;
            fmgFilter.cb.FillDataToLookUpEditAndSetFont();
        }

        #endregion

        #region SearchLookUpEdit

        public static void FillDataToSearchLookUpEditAndSetFont(this SearchLookUpEdit cb)
        {
            var tableName = cb.Name.Remove(0, 2);
            FillDataToSearchLookUpEditAndSetFont(cb, tableName);
        }

        public static void FillDataToSearchLookUpEditAndSetFont(this SearchLookUpEdit cb, string tableName)
        {
            FillDataToSearchLookUpEditAndSetFont(cb, tableName, string.Empty);
        }

        public static void FillDataToSearchLookUpEditAndSetFont(this SearchLookUpEdit cb, string tableName, string whereClause)
        {
            FillDataToSearchLookUpEditAndSetFont(cb, tableName, whereClause, true);
        }

        public static void FillDataToSearchLookUpEditAndSetFont(this SearchLookUpEdit cb, string tableName, string whereClause,
            bool deleteLastNumber)
        {
            var lastChar = tableName == string.Empty
                ? cb.Name.Substring(cb.Name.Length - 1) : tableName.Substring(tableName.Length - 1);
            if (deleteLastNumber && (lastChar == "1" || lastChar == "2" || lastChar == "3" || lastChar == "4" ||
                                     lastChar == "5"))
                tableName = tableName.Substring(0, tableName.Length - 1);
            //var dt = SQL.Select(string.Format("SELECT CAST(Id{0} AS INT) Id{0}, * FROM {0}{1}", tableName, whereClause));
            var dt = SQL.Select(string.Format("SELECT Id{0}, {0} FROM {0}{1}", tableName, whereClause));
            cb.Properties.DataSource = dt;
            cb.Properties.ValueMember = "Id" + tableName;
            cb.Properties.DisplayMember = tableName;
            cb.Properties.TextEditStyle = TextEditStyles.Standard;

            cb.Properties.ShowFooter = false;
            cb.Properties.ShowClearButton = false;
            cb.Properties.View.Name = cb.Name + "View";

            cb.Properties.View.Columns.AddField("Id" + tableName).Visible = false;
            cb.Properties.View.Columns.AddField(tableName).Visible = true;

            cb.Properties.View.FocusRectStyle = DrawFocusRectStyle.RowFocus;
            cb.Properties.View.OptionsSelection.EnableAppearanceFocusedCell = false;
            cb.Properties.View.OptionsView.ShowColumnHeaders = false;
            cb.Properties.View.OptionsView.ShowGroupPanel = false;
            cb.Properties.NullText = StringParameters.LookupEditNullText;
            cb.Properties.ShowNullValuePromptWhenFocused = true;
            if (dt.Rows.Count > 0)
                cb.EditValue = dt.Rows[0]["Id" + tableName];
            cb.PreviewKeyDown -= cb_KeyDown;
            cb.PreviewKeyDown += cb_KeyDown;
            foreach (AppearanceObject ao in cb.Properties.View.Appearance)
            {
                ao.Font = GlobalParameters.Font;
            }
        }

        //public static void FillDataToSearchLookUpEditAndSetFont(this SearchLookUpEdit cb, string tableName, bool deleteLastNumber,
        //    bool isView)
        //{
        //    cb.FillDataToSearchLookUpEditAndSetFont(tableName, deleteLastNumber, isView, string.Empty);
        //}

        //public static void FillDataToSearchLookUpEditAndSetFont(this SearchLookUpEdit cb, string tableName, bool deleteLastNumber,
        //    bool isView, string whereClause)
        //{
        //    var lastChar = cb.Name.Substring(cb.Name.Length - 1);
        //    if (deleteLastNumber && lastChar == "1" || lastChar == "2" || lastChar == "3" || lastChar == "4" ||
        //        lastChar == "5")
        //        tableName = tableName.Substring(0, tableName.Length - 1);
        //    var dt =
        //        SQL.Select(string.Format("SELECT CAST(Id{0} AS INT) Id{0}, * FROM {0}{1} {2}", tableName,
        //            (isView ? "View" : string.Empty), whereClause));
        //    cb.Properties.DataSource = dt;
        //    cb.Properties.ValueMember = "Id" + tableName;
        //    cb.Properties.DisplayMember = tableName;
        //    cb.Properties.TextEditStyle = TextEditStyles.Standard;
        //    cb.Properties.NullText = StringParameters.SearchLookUpEditNullText;

        //    if (dt.Rows.Count > 0)
        //        cb.Text = dt.Rows[0][tableName].ToString();
        //    cb.Properties.Columns.Clear();
        //    cb.Properties.Columns.Add(new LookUpColumnInfo(tableName));
        //    cb.PreviewKeyDown -= cb_SearchKeyDown;
        //    cb.PreviewKeyDown += cb_SearchKeyDown;
        //}

        //static void cb_SearchKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    if (e.KeyCode != Keys.F9) return;
        //    var cls = new CLSAddToCombo();
        //    cls.ShowAddForm(sender as Control);
        //}

        //public static void SetSearchLookUpEditValue(this SearchLookUpEdit cb, object value)
        //{
        //    cb.SetSearchLookUpEditValue(value, true);
        //}

        //public static void SetSearchLookUpEditValue(this SearchLookUpEdit cb, object value, bool deleteLastNumber)
        //{
        //    var tableName = cb.Name.Remove(0, 2);
        //    var c = tableName[tableName.Length - 1];
        //    if (char.IsDigit(c) && deleteLastNumber)
        //        tableName = tableName.Substring(0, tableName.Length - 1);
        //    var i = cb.Properties.GetDataSourceRowIndex("Id" + tableName, value);
        //    cb.EditValue = cb.Properties.GetDataSourceValue("Id" + tableName, i);
        //}

        //public static void SetSearchLookUpEditColumns(this SearchLookUpEdit cb, string[] fields, string[] captions, int[] width,
        //    bool showHeader)
        //{
        //    cb.Properties.Columns.Clear();
        //    cb.Properties.ShowHeader = showHeader;
        //    for (var i = 0; i < fields.Length; i++)
        //    {
        //        cb.Properties.Columns.Add(new LookUpColumnInfo(fields[i], captions[i].Translate(), width[i]));
        //    }
        //}
        #endregion
    }

    #region Classes

    public enum FileType
    {
        [Description("*.xls")]
        Excel,
        [Description("*.xlsx")]
        ExcelX,
        [Description("*.xls*")]
        ExcelAny,
        [Description("*.doc")]
        Word,
        [Description("*.docx")]
        WordX,
        [Description("*.doc*")]
        WordAny,
        [Description("*.mrt")]
        StimulReport,
        [Description("*.xml")]
        Xml
    }

    public class ReportFile : object
    {
        public ReportFile(FileSystemInfo info)
        {
            Extension = info.Extension;
            Name = info.Name.Replace(info.Extension, string.Empty);
            FullName = info.Name;
            Path = info.FullName;
        }

        public ReportFile(string fileName)
        {
            FileSystemInfo info = new DirectoryInfo(GlobalParameters.ReportsFolder + fileName);
            Extension = info.Extension;
            Name = info.Name.Replace(info.Extension, string.Empty);
            FullName = info.Name;
            Path = info.FullName;
        }

        public ReportFile(string fileName, FileType fileType)
        {
            FileSystemInfo info =
                new DirectoryInfo(GlobalParameters.ReportsFolder + fileName + fileType.GetDescriptionAttribute());
            Extension = info.Extension;
            Name = info.Name.Replace(info.Extension, string.Empty);
            FullName = info.Name;
            Path = info.FullName;
        }

        public string Path { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Extension { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public string GetUniqueNameForExport()
        {
            return
                new DirectoryInfo(GlobalParameters.MonacemebiFolder + Name + DateTime.Now.ToString("yyMMddmmss") +
                                  Extension).FullName;
        }

        public bool Exists()
        {
            return File.Exists(Path);
        }
    }

    #endregion
}