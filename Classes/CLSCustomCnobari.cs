using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.PivotGrid;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Customization;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraTab;
using SBS_BarthLogistic.Interfaces;

namespace SBS_BarthLogistic.Classes
{
    /// <summary>
    ///     -- ვერსია 1.4 -- 11 Aug 2016 20:00 ნიკა
    ///     . დაემატა AdminFieldProperties.
    ///     . StringParameters გავასწორე და სხვა შეცდომები იყო.
    ///     -- ვერსია 1.3 -- 13 July 2016 14:00 ნიკა
    ///     . PivotGridControl ზე გავასწორე რაღაცები 2
    ///     . თარგმნასთან ერთად ენიჭება ფორმატიც
    ///     -- ვერსია 1.2 -- 30 May 2016 17:00 ნიკა
    ///     . გრიდზე ფონტი მუშოაბს უნაკლოდ :)))
    ///     -- ვერსია 1.1 -- 10 March 2016 18:00 ნიკა
    ///     . PivotGridControl ზე გავასწორე რაღაცები
    ///     -- ვერსია 1.0 -- 16 Feb 2016 14:00 ნიკა
    ///     . ფონტის მინიჭება არ ხდებოდა გრიდზე თუ HasTranslate = false
    ///     -- ვერსია 0.9 -- 14 Dec 2015 11:00 ნიკა
    ///     . PivotGrid ის თარგმნაში გამოვასწორე ხარვეზი, როცა FieldName იგივეა, მაგრამ GroupInterval სხვადასხვა, ითარგმნებოდა
    ///     ერთიანად.
    ///     {მაგ: Data - კვირის დღე}
    ///     -- ვერსია 0.8 -- 9 Dec 2015 17:00 ნიკა
    ///     . private კლასებს შევუცვალე სახელები.
    ///     -- ვერსია 0.7 -- 2 Noe 2015 13:00 ნიკა
    ///     . გამოსწორდა SetAddFormText HasTranslate = false-ის შემთხვევაში
    ///     -- ვერსია 0.6 -- 18 Oct 2015 19:00 ნიკა
    ///     . Initialize-დან ამოვიღე GlobalParameters.Errors ის ინიციალიზაცია, და გადავიტანე იქვე კლასში
    ///     GlobalParameters.InitializeErrorTexts()
    ///     -- ვერსია 0.5 -- 7 Oct 2015 14:00 ნიკა
    /// </summary>
    internal static class CLSCustomCnobari
    {
        public const char Mid = '_';
        public static bool HasTranslate = false;

        public static void Initialize()
        {
            GlobalParameters.FieldContainerName.Clear();
            GlobalParameters.Languages.Clear();
            GlobalParameters.AdminFieldProperties.Clear();
            GlobalParameters.AdminChangeSelecteds.Clear();
            if (!HasTranslate) return;
            var dt = SQL.Select("SELECT FieldName, NameGeo, NameEng FROM AdminCnobari WHERE Active = 1");

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["FieldName"].ToString() == string.Empty) continue;

                GlobalParameters.FieldContainerName.Add(dt.Rows[i]["FieldName"].ToString(),
                    new Language(dt.Rows[i]["NameGeo"].ToString(), dt.Rows[i]["NameEng"].ToString(),
                        dt.Rows[i][InterfaceParameters.InterfaceLanguage].ToString()));
            }
            dt = SQL.Select(string.Format(
                "SELECT NameGeo, MAX(NameEng) NameEng, MAX({0}) {0} FROM AdminCnobari WHERE Active = 1 GROUP BY NameGeo",
                InterfaceParameters.InterfaceLanguage));

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["NameGeo"].ToString() == string.Empty) continue;

                GlobalParameters.Languages.Add(dt.Rows[i]["NameGeo"].ToString(),
                    new Language(dt.Rows[i]["NameGeo"].ToString(), dt.Rows[i]["NameEng"].ToString(),
                        dt.Rows[i][InterfaceParameters.InterfaceLanguage].ToString()));
            }
            //foreach (var field in typeof(StringParameters).GetFields())
            //{
            //    var val = field.GetValue(null).ToString();
            //    field.SetValue(null, val.Translate());
            //}
            dt = SQL.Select("SELECT * FROM AdminFieldProperty WHERE Active = 1");

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                GlobalParameters.AdminFieldProperties.Add(dt.Rows[i]["FieldName"].ToString(),
                    new AdminFieldProperty(dt.Rows[i]["EditFormat"].ToString(), dt.Rows[i]["DisplayFormat"].ToString()));
            }
            dt = SQL.Select("SELECT * FROM AdminChangeSelected");

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                GlobalParameters.AdminChangeSelecteds.Add(dt.Rows[i]["FieldName"].ToString(),
                    new AdminChangeSelected(Convert.ToInt16(dt.Rows[i]["IdAdminControlType"].ToString())));
            }
        }

        #region Local Methods

        static string GetText(this Language pair)
        {
            return pair.NameX;
        }

        static string GetAddFormTextByLanguage(Language pair, bool editing, string id)
        {
            if (editing)
                return pair.NameX + " (" + StringParameters.CaptionEdit + ")";
            return pair.NameX +
                   (id == "0" ? " (" + StringParameters.CaptionAdd + ")" : " (" + StringParameters.CaptionCopy + ")");
        }

        static string GetAddFormTextByLanguage(bool editing, string id)
        {
            if (editing)
                return GlobalParameters.FieldName + " (" + StringParameters.CaptionEdit + ")";
            return GlobalParameters.FieldName +
                   (id == "0" ? " (" + StringParameters.CaptionAdd + ")" : " (" + StringParameters.CaptionCopy + ")");
        }

        static string GetFFormTextByLanguage(Language pair)
        {
            return pair.NameX + " (" + StringParameters.CaptionFind + ")";
        }

        static string GetText(string name)
        {
            if (!GlobalParameters.FieldContainerName.ContainsKey(name)) return null;
            var pair = GlobalParameters.FieldContainerName[name];
            return GetText(pair);
        }

        public static string GetText(string name, string tableName)
        {
            if (GlobalParameters.FieldContainerName.ContainsKey(name + Mid + tableName))
            {
                var pair = GlobalParameters.FieldContainerName[name + Mid + tableName];
                return GetText(pair);
            }
            if (GlobalParameters.FieldContainerName.ContainsKey(name))
            {
                var pair = GlobalParameters.FieldContainerName[name];
                return GetText(pair);
            }
            return null;
        }

        static IEnumerable<ToolStripMenuItem> GetItems(this ToolStripDropDownItem item)
        {
            foreach (var dropDownItem in item.DropDownItems.OfType<ToolStripMenuItem>())
            {
                if (dropDownItem.HasDropDownItems)
                {
                    foreach (var subItem in GetItems(dropDownItem))
                        yield return subItem;
                }
                yield return dropDownItem;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        ///     Add-ფორმას ანიჭებს ტექსტს ცხრილის სახელის მიხედვით
        /// </summary>
        /// <param name="form">Add-ფორმა</param>
        /// <param name="tableName">ცხრილის სახელი</param>
        public static void SetAddFormText(this Form form, string tableName)
        {
            form.SetAddFormText(tableName, false);
        }

        /// <summary>
        ///     Add-ფორმას ანიჭებს ტექსტს ცხრილის სახელის მიხედვით
        /// </summary>
        /// <param name="form">Add-ფორმა</param>
        /// <param name="tableName">ცხრილის სახელი</param>
        /// <param name="editing">არის თუ არა რედაქტირება</param>
        public static void SetAddFormText(this Form form, string tableName, bool editing)
        {
            form.SetAddFormText(tableName, editing, "0");
        }

        /// <summary>
        ///     Add-ფორმას ანიჭებს ტექსტს ცხრილის სახელის მიხედვით
        /// </summary>
        /// <param name="form">Add-ფორმა</param>
        /// <param name="tableName">ცხრილის სახელი</param>
        /// <param name="editing">არის თუ არა რედაქტირება</param>
        /// <param name="id">მიმდინარე Id</param>
        public static void SetAddFormText(this Form form, string tableName, bool editing, int id)
        {
            form.SetAddFormText(tableName, editing, id.ToString());
        }

        /// <summary>
        ///     Add-ფორმას ანიჭებს ტექსტს ცხრილის სახელის მიხედვით
        /// </summary>
        /// <param name="form">Add-ფორმა</param>
        /// <param name="tableName">ცხრილის სახელი</param>
        /// <param name="editing">არის თუ არა რედაქტირება</param>
        /// <param name="id">მიმდინარე Id</param>
        public static void SetAddFormText(this Form form, string tableName, bool editing, string id)
        {
            if (!HasTranslate)
            {
                form.Text = GetAddFormTextByLanguage(editing, id);
                return;
            }
            if (GlobalParameters.FieldContainerName.ContainsKey(tableName))
            {
                var pair = GlobalParameters.FieldContainerName[tableName];
                form.Text = GetAddFormTextByLanguage(pair, editing, id);
            }
            else
            {
                form.Text = tableName;
            }
        }

        /// <summary>
        ///     ძებნის ფორმას ანიჭებს ტექსტს ფილტრის პანელის მიხედვით, ცხრილის სახელის მიხედვით
        /// </summary>
        /// <param name="pa">ფილტრის პანელი</param>
        /// <param name="tableName">ცხრილის სახელი</param>
        public static void SetFFormText(this PanelControl pa, string tableName)
        {
            if (!HasTranslate) return;
            var form = pa.Parent as Form;
            if (form == null) return;
            if (GlobalParameters.FieldContainerName.ContainsKey(tableName))
            {
                var pair = GlobalParameters.FieldContainerName[tableName];
                form.Text = GetFFormTextByLanguage(pair);
            }
        }

        public static void SetText(this IFMGFindControl ctl, string tableName)
        {
            if (!HasTranslate) return;
            var text = GetText(ctl.FieldName, tableName);
            if (text == null) return;
            ctl.Text = text;
        }

        /// <summary>
        ///     თარგმნადი კონტროლის თარგმნა
        /// </summary>
        /// <param name="ctl">კონტროლი: LabelControl, CheckEdit, Button, SimpleButton</param>
        /// <param name="tableName">ცხრილის სახელი</param>
        public static void SetText(this Control ctl, string tableName)
        {
            if (!HasTranslate) return;
            if (ctl is Button || ctl is SimpleButton)
            {
                //ctl.Font = GlobalParameters.Font;
                ctl.Text = ctl.Text.Translate();
                return;
            }
            var name = ctl.Name;
            if (ctl is LabelControl)
            {
                name = name.Substring(2, name.Length - 2);
            }
            else if (ctl is CheckEdit)
            {
                name = name.Substring(3, name.Length - 3);
            }
            else return;

            var text = GetText(name, tableName);
            if (text == null) return;
            ctl.Text = text;
        }

        /// <summary>
        ///     თარგმნადი კონტროლის თარგმნა
        /// </summary>
        /// <param name="ctl">კონტროლი: LabelControl, CheckEdit, Button, SimpleButton</param>
        public static void SetText(this Control ctl)
        {
            if (!HasTranslate) return;
            if (ctl is Button || ctl is SimpleButton)
            {
                ctl.Text = ctl.Text.Translate();
                return;
            }
            var name = ctl.Name;
            if (ctl is LabelControl)
            {
                name = name.Substring(2, name.Length - 2);
            }
            else if (ctl is CheckEdit)
            {
                name = name.Substring(3, name.Length - 3);
            }
            else return;
            var text = GetText(name);
            if (text == null) return;
            ctl.Text = text;
        }

        public static void TranslateFromEng(Control ctl)
        {
            if (!HasTranslate) return;
            ctl.Text = ctl.Text.TranslateFromEng();
        }

        public static void SetTexts(this CustomizationControl ctl)
        {
            if (!HasTranslate) return;
            foreach (Control control in ctl.Controls)
            {
                TranslateFromEng(control);
            }
            foreach (Control control in ctl.tabControl.Controls)
            {
                foreach (Control c in (control as XtraTabPage).Controls)
                    TranslateFromEng(c);
                TranslateFromEng(control);
            }
        }

        /// <summary>
        ///     პანელის ყველა კონტროლზე სრულდება თარგმნა ცხრილის სახელის მიხედვით
        /// </summary>
        /// <param name="pa">ფილტრის პანელი</param>
        /// <param name="tableName">ცხრილის სახელი</param>
        public static void SetTexts(this PanelControl pa, string tableName)
        {
            if (!HasTranslate) return;
            foreach (Control control in pa.Controls)
            {
                SetText(control, tableName);
            }
        }

        /// <summary>
        ///     პანელის ყველა კონტროლზე სრულდება თარგმნა ცხრილის სახელის მიხედვით
        /// </summary>
        /// <param name="pa">ფილტრის პანელი</param>
        /// <param name="tableName">ცხრილის სახელი</param>
        public static void SetTexts(this GroupControl pa, string tableName)
        {
            if (!HasTranslate) return;
            pa.Text = pa.Text.Translate();
            foreach (Control control in pa.Controls)
            {
                SetText(control, tableName);
            }
        }

        public static void SetTexts(this Form ctl)
        {
            if (!HasTranslate) return;
            ctl.SetTexts(string.Empty);
        }

        /// <summary>
        ///     ფორმის ყველა კონტროლზე სრულდება თარგმნა ცხრილის სახელის მიხედვით, ასევე თუ ფორმაში ხვდება პანელი მის თარგმნასაც
        ///     ახორციელებს
        /// </summary>
        /// <param name="ctl">ფილტრის პანელი</param>
        /// <param name="tableName">ცხრილის სახელი</param>
        public static void SetTexts(this Form ctl, string tableName)
        {
            if (!HasTranslate) return;
            foreach (Control control in ctl.Controls)
            {
                if (control is GroupControl)
                    SetTexts(control as GroupControl, tableName);
                else if (control is PanelControl)
                    SetTexts(control as PanelControl, tableName);
                else
                    SetText(control, tableName);
            }
        }

        public static void SetTexts(GridView dgv, string tableName)
        {
            foreach (AppearanceObject ap in dgv.Appearance)
                ap.Font = GlobalParameters.Font;
            foreach (GridColumn col in dgv.Columns)
            {
                SetText(col, tableName);
            }
        }

        public static void SetTexts(PivotGridControl dgv, string tableName)
        {
            foreach (PivotGridField col in dgv.Fields)
            {
                col.Appearance.Reset();
                if (!HasTranslate) continue;
                SetText(col, tableName);
            }
            foreach (AppearanceObject ap in dgv.Appearance)
                ap.Font = GlobalParameters.Font;
        }

        public static void SetTexts(this ToolStripMenuItem mi)
        {
            if (!HasTranslate) return;
            for (var i = 0; i < mi.DropDownItems.Count; i++)
            {
                var ctl = mi.DropDownItems[i] as ToolStripMenuItem;
                if (ctl != null)
                    SetText(ctl);
            }
        }

        public static void SetTexts(params ToolStrip[] mi)
        {
            foreach (var t in mi)
            {
                t.GripStyle = ToolStripGripStyle.Hidden;
                if (!HasTranslate) continue;
                for (var i = 0; i < t.Items.Count; i++)
                {
                    var item = t.Items[i];
                    if (!(item is ToolStripButton))
                    {
                        if (item is ToolStripDropDownItem)
                        {
                            var tt = item.Text;
                            item.Text = tt.Translate();
                            foreach (ToolStripMenuItem dItem in (item as ToolStripDropDownItem).DropDownItems)
                            {
                                tt = dItem.Text;
                                dItem.Text = tt.Translate();
                            }
                        }
                        continue;
                    }
                    var text = item.ToolTipText;
                    item.Text = string.Empty;
                    item.ToolTipText = string.Empty;
                    item.ToolTipText = text.Translate();
                }
            }
        }

        public static void SetMainButtonTexts(this RibbonControl rc, int namePrefixLength)
        {
            if (!HasTranslate) return;
            for (var i = 0; i < rc.Items.Count; i++)
            {
                if (!(rc.Items[i] is BarButtonItem) && !(rc.Items[i] is BarSubItem)) continue;
                if (rc.Items[i].Name.Length < namePrefixLength) continue;
                var rbtn = rc.Items[i];
                var name = rbtn.Name.Substring(namePrefixLength);
                var text = GetText(name);
                if (text != null)
                    rbtn.Caption = text;
                if (File.Exists(GlobalParameters.MailFolder + name + "1.png"))
                {
                    rbtn.Glyph = Image.FromFile(GlobalParameters.MailFolder + name + "1.png");
                }
                if (File.Exists(GlobalParameters.MailFolder + name + "2.png"))
                {
                    rbtn.LargeGlyph = Image.FromFile(GlobalParameters.MailFolder + name + "2.png");
                }
            }
            for (var i = 0; i < rc.Pages.Count; i++)
            {
                var page = rc.Pages[i];
                //rpProd
                var pName = page.Name.Substring(2);
                var pText = GetText(pName);
                if (pText != null)
                    page.Text = pText;

                for (var j = 0; j < page.Groups.Count; j++)
                {
                    var rbtn = page.Groups[j];
                    //rpgProd
                    var name = rbtn.Name.Substring(3);
                    var text = GetText(name);
                    if (text != null)
                        rbtn.Text = text;
                }
            }
        }

        public static void SetTexts(params ContextMenuStrip[] cms)
        {
            foreach (var cm in cms)
            {
                cm.GripStyle = ToolStripGripStyle.Hidden;
                if (!HasTranslate) continue;
                for (var i = 0; i < cm.Items.Count; i++)
                {
                    var item = cm.Items[i];
                    if (item is ToolStripMenuItem)
                        item.Text = item.Text.Translate();
                }
            }
        }

        public static void SetTexts(params BarManager[] bms)
        {
            if (!HasTranslate) return;
            foreach (var bm in bms)
            {
                for (var i = 0; i < bm.Items.Count; i++)
                {
                    var item = bm.Items[i];
                    item.Caption = item.Caption.Translate();
                }
            }
        }

        public static void SetTexts(ContextMenuStrip[] cms, ToolStrip[] mi)
        {
            if (!HasTranslate) return;
            SetTexts(cms);
            SetTexts(mi);
        }

        public static void SetTexts(this MenuStrip mi)
        {
            if (!HasTranslate) return;
            var allItems = new List<ToolStripMenuItem>();
            foreach (ToolStripMenuItem toolItem in mi.Items)
            {
                allItems.Add(toolItem);
                allItems.AddRange(GetItems(toolItem));
            }
            foreach (var t in allItems)
            {
                SetText(t);
            }
        }

        public static void SetTexts(this ToolStripDropDownItem ctl)
        {
            if (!HasTranslate) return;
            for (var i = 0; i < ctl.DropDownItems.Count; i++)
                SetText(ctl.DropDownItems[i]);
        }

        public static void SetTexts(this TabControl ctl)
        {
            if (!HasTranslate) return;
            for (var i = 0; i < ctl.TabPages.Count; i++)
                SetText(ctl.TabPages[i]);
        }

        public static void SetTexts(this XtraTabControl ctl)
        {
            for (var i = 0; i < ctl.TabPages.Count; i++)
                SetText(ctl.TabPages[i]);
        }

        public static void SetParamsTexts(this XtraTabPage ctl, string tableName)
        {
            if (!HasTranslate) return;
            for (var i = 0; i < ctl.Controls.Count; i++)
            {
                if (ctl.Controls[i] is GroupControl)
                {
                    SetTexts((GroupControl)ctl.Controls[i], tableName);
                    continue;
                }
                var name = ctl.Controls[i].Name;
                if (ctl.Controls[i] is LabelControl)
                {
                    name = name.Substring(2, name.Length - 2);
                }
                else if (ctl.Controls[i] is CheckEdit)
                {
                    name = name.Substring(3, name.Length - 3);
                }
                else continue;
                var text = GetText(name, tableName);
                if (text != null)
                    ctl.Controls[i].Text = text;
            }
        }

        /// <summary>
        ///     ქართული ტექსტის თარგმნა
        /// </summary>
        /// <param name="geo">ქართული ტექსტი</param>
        /// <returns>ნათარგმნი ტექსტი</returns>
        public static string Translate(this string geo)
        {
            if (!HasTranslate) return geo;
            if (geo == string.Empty) return string.Empty;
            if (InterfaceParameters.InterfaceLanguage == "NameGeo") return geo;
            if (GlobalParameters.Languages.ContainsKey(geo))
            {
                var pair = GlobalParameters.Languages[geo];
                return GetText(pair);
            }
            return geo;
        }

        /// <summary>
        ///     ინგლისური ტექსტის თარგმნა
        /// </summary>
        /// <param name="eng">ინგლისური ტექსტი</param>
        /// <returns>ნათარგმნი ტექსტი</returns>
        public static string TranslateFromEng(this string eng)
        {
            if (!HasTranslate) return eng;
            if (eng == string.Empty) return string.Empty;
            eng = eng.Replace("&", string.Empty);
            var pair = GlobalParameters.Languages.Where(a => a.Value.NameEng == eng).Select(a => a.Value)
                .DefaultIfEmpty(new Language()).First();
            if (pair.NameGeo != "EmptyValue")
                return GetText(pair) == string.Empty ? eng : GetText(pair);
            return eng;
        }

        public static void SetAdminFieldProperties(this BaseEdit ctl, string tableName)
        {
            var name = ctl.Name;
            name = name.Substring(3, name.Length - 3);
            AdminFieldProperty pair = null;
            if (GlobalParameters.AdminFieldProperties.ContainsKey(name + Mid + tableName))
                pair = GlobalParameters.AdminFieldProperties[name + Mid + tableName];
            else if (GlobalParameters.AdminFieldProperties.ContainsKey(name))
                pair = GlobalParameters.AdminFieldProperties[name];
            if (pair == null) return;
            ctl.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            ctl.Properties.EditFormat.FormatType = FormatType.Numeric;
            if (ctl.Properties.DisplayFormat.FormatString != pair.EditFormat)
                ctl.Properties.DisplayFormat.FormatString = pair.EditFormat;
            if (ctl.Properties.EditFormat.FormatString != pair.EditFormat)
                ctl.Properties.EditFormat.FormatString = pair.EditFormat;
            //if (ctl is CalcEdit)
            //    if (((CalcEdit)ctl).Properties.Mask.EditMask != pair.Value)
            //        ((CalcEdit)ctl).Properties.Mask.EditMask = pair.Value;
        }

        #endregion

        #region Private Methods

        static void SetText(TabPage ctl)
        {
            ctl.Font = GlobalParameters.Font;
            if (!HasTranslate) return;
            var name = ctl.Name.Substring(2);
            var text = GetText(name);
            ctl.Text = text == null ? ctl.Text.Translate() : GetText(name);
        }

        static void SetText(XtraTabPage ctl)
        {
            ctl.Appearance.Header.Font = GlobalParameters.Font;
            if (!HasTranslate) return;
            var name = ctl.Name.Substring(2);
            var text = GetText(name);
            ctl.Text = text == null ? ctl.Text.Translate() : GetText(name);
        }

        static void SetText(ToolStripMenuItem ctl)
        {
            if (!HasTranslate) return;
            var name = ctl.Name.Substring(2, ctl.Name.Length - 2);
            var text = GetText(name);
            if (text == null) return;
            ctl.Text = text;
        }

        static void SetText(DXMenuItem ctl)
        {
            if (!HasTranslate) return;
            ctl.Caption = ctl.Caption.Translate();
        }

        static void SetText(ToolStripItem ctl)
        {
            if (!HasTranslate) return;
            var name = ctl.Name.Substring(2, ctl.Name.Length - 2);
            var text = GetText(name);
            if (text == null) return;
            ctl.Text = text;
        }

        static void SetText(GridColumn ctl, string tableName)
        {
            var name = ctl.FieldName;
            AdminFieldProperty property = null;
            if (GlobalParameters.AdminFieldProperties.ContainsKey(name + Mid + tableName))
                property = GlobalParameters.AdminFieldProperties[name + Mid + tableName];
            else if (GlobalParameters.AdminFieldProperties.ContainsKey(name))
                property = GlobalParameters.AdminFieldProperties[name];
            if (property != null)
            {
                ctl.DisplayFormat.FormatType = FormatType.Numeric;
                if (ctl.DisplayFormat.FormatString != property.DisplayFormat)
                    ctl.DisplayFormat.FormatString = property.DisplayFormat;
            }
            if (ctl.DisplayFormat.FormatType == FormatType.DateTime)
                ctl.FilterMode = ColumnFilterMode.DisplayText;
            if (!HasTranslate) return;
            var text = GetText(name, tableName);
            if (text == null) return;
            ctl.Caption = text;
        }

        static void SetText(PivotGridField ctl, string tableName)
        {
            if (!HasTranslate) return;
            var name = ctl.FieldName;
            if (ctl.GroupInterval != PivotGroupInterval.Default)
                name = ctl.FieldName + Mid + ctl.GroupInterval;
            if (ctl.SummaryDisplayType != PivotSummaryDisplayType.Default)
                name = ctl.FieldName + Mid + ctl.SummaryDisplayType;
            var text = GetText(name, tableName);
            if (text == null) return;
            ctl.Caption = text;
        }

        #endregion
    }
}