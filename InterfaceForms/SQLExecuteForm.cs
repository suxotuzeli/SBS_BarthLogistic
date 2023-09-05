using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Office.Utils;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Services;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.Classes.Database;
using SBS_BarthLogistic.Properties;

namespace SBS_BarthLogistic.InterfaceForms
{
    public partial class SQLExecute : XtraForm
    {
        bool customDragDropTarget;
        bool exep;
        readonly string fieldName;
        SuggesionReplaceType replaceType;
        Graphics richEditGraphics;
        int tnLen;

        public SQLExecute()
        {
            InitializeComponent();
            tabMessage.ShowCloseButton = DefaultBoolean.False;
            txtScript.Document.Sections[0].Page.Width = Units.InchesToDocumentsF(80f);
            txtScript.Document.DefaultCharacterProperties.FontName = "Consolas";
            fieldName = GlobalParameters.FieldName;
        }

        public void SelectCurrentLine()
        {
            var start = txtScript.Document.CaretPosition.ToInt();
            var length = txtScript.Document.CaretPosition.ToInt() - start;
            var range = txtScript.Document.CreateRange(start, length);
            var range2 = txtScript.Document.CreateRange(start, length + 1);
            var text = txtScript.Document.GetText(range2);
            txtScript.Document.Selection = text.EndsWith(Environment.NewLine) ? range2 : range;
        }

        void ExecuteScript()
        {
            exep = false;
            txtResult.ForeColor = Color.Black;
            txtResult.Text = string.Empty;

            var length = txtScript.Document.Selection.Length;
            var cmdTemp = length <= 0
                ? txtScript.Document.Text
                : txtScript.Document.GetText(txtScript.Document.Selection);
            var cmd = string.Empty;
            var strings = cmdTemp.Split(Environment.NewLine);

            foreach (var s in strings)
                cmd += s.Trim().ToUpper() != "GO" ? s + Environment.NewLine : Environment.NewLine;

            try
            {
                var rowCounts = new List<int>();
                var ds = new DataSet();
                using (var command = new SqlCommand(cmd, GlobalParameters.cn))
                {
                    command.StatementCompleted += (sender, e) => rowCounts.Add(e.RecordCount);
                    GlobalParameters.cn.Open();
                    new SqlDataAdapter(command).Fill(ds);
                }
                foreach (DataTable table in ds.Tables)
                {
                    var page = new XtraTabPage();
                    page.Name = "page" + table.TableName;
                    page.Text = table.TableName;
                    xtraTabControl1.TabPages.Add(page);
                    var dgv = new GridControl();
                    var gv = new GridView();

                    gv.Appearance.HeaderPanel.Font = new Font("Sylfaen", 9F);
                    gv.Appearance.HeaderPanel.Options.UseFont = true;

                    for (var i = 0; i < table.Columns.Count; i++)
                    {
                        gv.Columns.Add(new GridColumn
                        {
                            FieldName = table.Columns[i].ColumnName,
                            Visible = true,
                            VisibleIndex = i + 1
                        });
                    }
                    gv.FooterPanelHeight = 1;
                    gv.GridControl = dgv;
                    gv.GroupRowHeight = 1;
                    gv.Name = "gv";
                    gv.OptionsBehavior.AllowIncrementalSearch = true;
                    gv.OptionsBehavior.Editable = false;
                    gv.OptionsDetail.AllowZoomDetail = false;
                    gv.OptionsDetail.SmartDetailExpandButtonMode = DetailExpandButtonMode.CheckDefaultDetail;
                    gv.OptionsSelection.MultiSelect = true;
                    gv.OptionsView.ColumnAutoWidth = false;
                    gv.OptionsView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways;
                    gv.OptionsView.ShowAutoFilterRow = true;
                    gv.OptionsView.ShowDetailButtons = false;
                    gv.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
                    gv.OptionsView.ShowFooter = true;
                    gv.OptionsView.ShowGroupPanel = false;

                    dgv.Dock = DockStyle.Fill;
                    dgv.MainView = gv;
                    dgv.Name = "dgv" + table.TableName;
                    dgv.TabIndex = 1;
                    dgv.ViewCollection.AddRange(new BaseView[] { gv });
                    var mi = new ToolStripMenuItem();
                    mi.Text = "ექსპოეტი ექსელში";
                    mi.Click += delegate { CLSExcel.ExportToExcel(dgv); };
                    dgv.ContextMenuStrip = new ContextMenuStrip { Items = { mi } };

                    dgv.DataSource = table;
                    page.Controls.Add(dgv);
                    xtraTabControl1.SelectedTabPage = page;
                }
                txtResult.Text = string.Empty;
                if (rowCounts.Count > 0)
                {
                    foreach (var rows in rowCounts)
                    {
                        txtResult.Text += "(" + rows + ") Rows efected" + Environment.NewLine;
                    }
                }
                else
                {
                    txtResult.Text = "Command(s) completed successfully.";
                }
            }
            catch (Exception ex)
            {
                exep = true;
                txtResult.ForeColor = Color.Red;
                if (ex is SqlException)
                {
                    foreach (SqlError error in ((SqlException)ex).Errors)
                    {
                        txtResult.Text += error.Message + " Line: " + error.LineNumber + Environment.NewLine;
                    }
                }
                else
                {
                    txtResult.Text = ex.Message;
                }
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
            if (!exep)
            {
                txtResult.ForeColor = Color.Black;
                exep = false;
            }
            txtScript.Focus();
        }

        void btnExecute_Click(object sender, EventArgs e)
        {
            if (txtScript.Document.Text.Trim() == string.Empty) return;
            ExecuteScript();
            txtScript.Focus();
        }

        string GetLastWord()
        {
            var pos1 = txtScript.Document.CaretPosition;
            var start = pos1.ToInt() - 1;
            while (true)
            {
                if (start <= 0)
                {
                    return txtScript.Document.GetText(txtScript.Document.CreateRange(0, pos1.ToInt()));
                }
                var c = txtScript.Document.GetText(txtScript.Document.CreateRange(start, 1));
                if (char.IsWhiteSpace(c, 0))
                    return txtScript.Document.GetText(txtScript.Document.CreateRange(start + 1, pos1.ToInt() - start));
                start--;
            }
        }

        void txtScript_KeyDown(object sender, KeyEventArgs e)
        {
            var pos1 = txtScript.Document.CaretPosition;
            if (e.KeyCode == Keys.Space && e.Control)
            {
                //var tnt =
                //    txtScript.Document.GetText(txtScript.Document.CreateRange(pos1.ToInt() - raod, raod))
                //        .Trim().Split(' ');
                //if (tnt.Length < 1) return;
                //if (tnt.All(a => a.ToLower() != "from")) return;

                replaceType = SuggesionReplaceType.ReplaceLastWord;
                var tn = GetLastWord();

                var tnt = tn.Split('.');
                if (tnt.Length > 1)
                    tn = tnt[tnt.Length - 1];
                tnLen = tn.Length;
                var tableColumn =
                    FMGDataBase.Tables.Where(a => a.TableName.StartsWith(tn, StringComparison.CurrentCultureIgnoreCase))
                        .Select(a => a.TableName).ToArray();
                e.SuppressKeyPress = true;
                e.Handled = true;
                FillAndShowSugg(tableColumn);
                return;
            }

            if (e.KeyCode == Keys.Tab)
            {
                var rOfAll = txtScript.Document.CreateRange(pos1.ToInt() - 1, 1);
                if (txtScript.Document.GetText(rOfAll) != "*")
                {
                    return;
                }
                var rOfTableName = txtScript.Document.CreateRange(pos1.ToInt() + 1, 40);
                var findAll = txtScript.Document.FindAll("from", SearchOptions.WholeWord, rOfTableName);
                if (findAll.Length <= 0) return;
                var drTanbleName = txtScript.Document.CreateRange(findAll[0].End.ToInt(), 40);
                var split = txtScript.Document.GetText(drTanbleName).Split(' ', '\n');
                if (split.Length <= 0) return;
                foreach (var s in split.Where(s => s.Trim() != string.Empty))
                {
                    var tableName = s.Trim();
                    var pair = FMGDataBase.Columns.Where(
                        a => string.Equals(a.Table.TableName, tableName, StringComparison.CurrentCultureIgnoreCase));
                    var locColumns = pair as Column[] ?? pair.ToArray();
                    if (!locColumns.Any()) return;
                    var insert = locColumns.Aggregate(string.Empty,
                        (current, column) => current + column.ColumnName + ", ");
                    txtScript.Document.Replace(rOfAll, insert.Substring(0, insert.Length - 2));
                    e.Handled = true;
                    return;
                }
                return;
            }

            if (e.KeyCode == Keys.Decimal)
            {
                replaceType = SuggesionReplaceType.AddAtCarot;
                var tableName = GetLastWord();
                var columns = FMGDataBase.Columns.Where(a => a.TableName == tableName);
                var z = columns.Select(a => a.ColumnName);
                FillAndShowSugg(z);
            }
        }

        void FillAndShowSugg(IEnumerable<string> suggs)
        {
            var enumerable = suggs as string[] ?? suggs.ToArray();
            if (!enumerable.Any()) return;
            var pos1 = txtScript.Document.CaretPosition;
            lbSugg.Items.Clear();
            foreach (var table in enumerable)
                lbSugg.Items.Add(table);
            lbSugg.SelectedIndex = 0;
            lbSugg.Visible = true;

            var rect = Units.DocumentsToPixels(txtScript.GetBoundsFromPosition(pos1), txtScript.DpiX, txtScript.DpiY);
            lbSugg.Top = rect.Bottom + fpa1.Height;
            lbSugg.Left = rect.Left;

            lbSugg.Focus();
        }

        void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            var arg = e as ClosePageButtonEventArgs;
            xtraTabControl1.TabPages.Remove(arg.Page as XtraTabPage);
            GC.Collect();
        }

        void btnLoadStruct_Click(object sender, EventArgs e)
        {
            FMGDataBase.LoadStruct(txtScript, treeView);
            txtScript.Focus();
        }

        void SQLExecute_Load(object sender, EventArgs e)
        {
            Text = fieldName;
            txtScript.DragDrop += txtScript_DragDrop;
            txtScript.DragEnter += txtScript_DragEnter;
            txtScript.DragOver += txtScript_DragOver;
            treeView.ItemDrag += treeView_ItemDrag;
            txtScript.Document.Sections[0].Page.Width = Units.InchesToDocumentsF(15F);
            imageList1.Images.Add(Resources.Freeze_Column_Remove_All);
        }

        void txtScript_DragOver(object sender, DragEventArgs e)
        {
            if (!customDragDropTarget) return;

            var docPoint = Units.PixelsToDocuments(txtScript.PointToClient(MousePosition),
                txtScript.DpiX, txtScript.DpiY);

            var pos = txtScript.GetPositionFromPoint(docPoint);

            if (pos == null) return;

            var rect = Units.DocumentsToPixels(txtScript.GetBoundsFromPosition(pos),
                txtScript.DpiX, txtScript.DpiY);

            txtScript.Document.CaretPosition = pos;

            if (richEditGraphics == null)
                richEditGraphics = txtScript.CreateGraphics();

            rect.Width = 2;
            txtScript.Refresh();
            richEditGraphics.FillRectangle(Brushes.Blue, rect);
            txtScript.ScrollToCaret();
        }

        void treeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            customDragDropTarget = true;

            var cur = e.Item as TreeNode;
            if (cur == null) return;
            if (cur.Tag == null) return;
            if (cur.Tag.GetType() == typeof(Column))
            {
                DoDragDrop(cur.Parent.Text + "." + cur.Text, DragDropEffects.Copy);
                customDragDropTarget = false;
            }
            if (cur.Tag.GetType() == typeof(Procedure))
            {
                DoDragDrop((cur.Tag as Procedure).GetRoutineDefinition(), DragDropEffects.Copy);
                customDragDropTarget = false;
            }
        }

        void txtScript_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = e.AllowedEffect;
        }

        void txtScript_DragDrop(object sender, DragEventArgs e)
        {
            if (!customDragDropTarget) return;
            var s = e.Data.GetData(DataFormats.Text).ToString();
            var server = new RichEditDocumentServer();
            server.CreateNewDocument();
            server.Document.AppendText(s);
            txtScript.BeginUpdate();
            txtScript.Document.InsertDocumentContent(txtScript.Document.CaretPosition, server.Document.Range);
            txtScript.EndUpdate();

            //txtScript.Document.InsertText(pos1, s);
        }

        void lbSugg_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    switch (replaceType)
                    {
                        case SuggesionReplaceType.ReplaceLastWord:
                            txtScript.Document.Replace(
                                txtScript.Document.CreateRange(txtScript.Document.CaretPosition.ToInt() - tnLen, tnLen),
                                lbSugg.Text);
                            break;

                        case SuggesionReplaceType.AddAtCarot:
                            //txtScript.Document.InsertText(txtScript.Document.CaretPosition, lbSugg.Text);
                            var server = new RichEditDocumentServer();
                            server.CreateNewDocument();
                            server.Document.AppendText(lbSugg.Text);
                            txtScript.BeginUpdate();
                            txtScript.Document.InsertDocumentContent(txtScript.Document.CaretPosition,
                                server.Document.Range);
                            txtScript.EndUpdate();
                            break;
                    }
                    e.SuppressKeyPress = true;
                    lbSugg.Visible = false;
                    txtScript.Focus();
                    break;
                case Keys.Escape:
                    e.SuppressKeyPress = true;
                    lbSugg.Visible = false;
                    txtScript.Focus();
                    break;
            }
        }

        void txtScript_Paint(object sender, PaintEventArgs e)
        {
            //var pos = txtScript.Document.CaretPosition;
            //if (pos != null)
            //{
            //    var rect = Units.DocumentsToPixels(
            //        txtScript.GetBoundsFromPosition(pos),
            //        txtScript.DpiX,
            //        txtScript.DpiY).Bottom;

            //    var firstSection = txtScript.Document.Sections[0];
            //    var pageWidth =
            //        Convert.ToInt32(firstSection.Page.Width - firstSection.Margins.Left - firstSection.Margins.Right);
            //    e.Graphics.DrawLine(Pens.Red, new Point(0, rect), new Point(pageWidth, rect));
            //}
        }

        void lbSugg_Leave(object sender, EventArgs e)
        {
            lbSugg.Items.Clear();
            lbSugg.Visible = false;
        }

        void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                treeView.SelectedNode = e.Node;
        }

        void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            propertyGrid.Rows.Clear();
            if (e.Node == null || e.Node.Tag == null)
            {
                propertyGrid.SelectedObject = null;
                return;
            }
            propertyGrid.SelectedObject = e.Node.Tag;
        }

        void txtScript_TextChanged(object sender, EventArgs e)
        {
            //            var split = txtScript.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            //            var max = split.Max(a => a.Length);
            //           txtScript.Document.CreateRange(split.First(a => a.Length == max))
            //            txtScript.Document.Sections[0].Page.Width = Units.PixelsToDocumentsF(txtScript.Width, txtScript.DpiX);
        }

        void chbSyntax_CheckedChanged(object sender, EventArgs e)
        {
            txtScript.ReplaceService<ISyntaxHighlightService>(chbSyntax.Checked
                ? new FMGDataBase.CustomSyntaxHighlightService(txtScript.Document)
                : null);
        }

        void btnSetText_Click(object sender, EventArgs e)
        {
            Text = txtText.Text;
        }

        enum SuggesionReplaceType
        {
            AddAtCarot,
            ReplaceLastWord
        }
    }
}