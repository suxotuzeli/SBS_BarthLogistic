using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Services;

namespace SBS_BarthLogistic.Classes.Database
{
    public static class FMGDataBase
    {
        public static List<Column> Columns = new List<Column>();
        public static List<Procedure> Procedures = new List<Procedure>();
        public static List<Relation> Relations = new List<Relation>();
        public static List<Table> Tables = new List<Table>();

        public static void LoadStruct(RichEditControl txtScript, TreeView treeView)
        {
            LoadStruct();
            var cmTable = new ContextMenuStrip();
            var miTableInsert = new ToolStripMenuItem();
            miTableInsert.Size = new Size(181, 26);
            miTableInsert.Text = "Insert";
            miTableInsert.Click += delegate
            {
                var treeNode = treeView.SelectedNode;
                if (treeNode == null) return;
                if (treeNode.Tag == null || treeNode.Tag.GetType() != typeof(Table)) return;
                txtScript.Document.InsertText(txtScript.Document.CaretPosition,
                    GenerateInsert(treeView.SelectedNode.Tag));
            };

            cmTable.Items.AddRange(new ToolStripItem[]
            {
                miTableInsert
            });

            var cmProcedure = new ContextMenuStrip();
            var miProcedureModify = new ToolStripMenuItem();
            miProcedureModify.Size = new Size(181, 26);
            miProcedureModify.Text = "Modify";
            miProcedureModify.Click += delegate
            {
                var treeNode = treeView.SelectedNode;
                if (treeNode == null) return;
                if (treeNode.Tag == null || treeNode.Tag.GetType() != typeof(Procedure)) return;
                txtScript.Document.InsertText(txtScript.Document.CaretPosition, (treeNode.Tag as Procedure).GetRoutineDefinition());
            };

            cmProcedure.Items.AddRange(new ToolStripItem[]
            {
                miProcedureModify
            });
            //cmTable.Size = new Size(182, 58);

            var nodariTable = new TreeNode("Tables", 0, 0);
            var nodariViews = new TreeNode("Views", 0, 0);
            var nodariProcs = new TreeNode("Procedures", 0, 0);
            if (treeView != null)
            {
                treeView.Nodes.Clear();
                treeView.Nodes.Add(nodariTable);
                treeView.Nodes.Add(nodariViews);
                treeView.Nodes.Add(nodariProcs);
            }

            foreach (var proc in Procedures)
            {
                var tnProc = new TreeNode(proc.RoutineName);
                tnProc.ContextMenuStrip = cmProcedure;
                tnProc.Tag = proc;
                nodariProcs.Nodes.Add(tnProc);
            }

            foreach (var table in Tables)
            {
                var ltn = new List<TreeNode>();
                var lTable = table;
                var tableColumns = Columns.Where(a => a.Table == lTable);
                foreach (var column in tableColumns)
                {
                    var columnNode = new TreeNode(column.ColumnName, 0, 0);
                    columnNode.Tag = column;
                    ltn.Add(columnNode);
                    var lColumn = column;
                    foreach (var relation in Relations.Where(a => a.ColumnA == lColumn || a.ColumnB == lColumn))
                    {
                        var relationNode = new TreeNode(relation.FkName, 0, 0);
                        relationNode.Tag = relation;
                        columnNode.Nodes.Add(relationNode);
                    }
                }
                var tnNode = new TreeNode(table.TableName, ltn.ToArray());
                tnNode.Tag = table;
                if (treeView != null)
                {
                    if (table.TableName.Contains("View"))
                        nodariViews.Nodes.Add(tnNode);
                    else
                    {
                        nodariTable.Nodes.Add(tnNode);
                        tnNode.ContextMenuStrip = cmTable;
                    }
                }
            }
        }

        public static void LoadStruct()
        {
            Columns.Clear();
            Procedures.Clear();
            Tables.Clear();
            Relations.Clear();
            GC.Collect();
            var dtColumns = SQL.Select(
                "SELECT T.TABLE_CATALOG, C.TABLE_NAME, COLUMN_NAME, C.TABLE_SCHEMA, TABLE_TYPE, COLUMN_DEFAULT, IS_NULLABLE,  DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, NUMERIC_PRECISION, NUMERIC_SCALE  " +
                " FROM INFORMATION_SCHEMA.COLUMNS C " +
                " INNER JOIN INFORMATION_SCHEMA.TABLES T ON T.TABLE_NAME = C.TABLE_NAME " +
                " ORDER BY C.TABLE_NAME");

            foreach (DataRow row in dtColumns.Rows)
            {
                var tn = row["TABLE_NAME"].ToString();
                var t = Tables.FirstOrDefault(a => a.TableName == tn);
                if (t == null)
                {
                    t = new Table(row["TABLE_CATALOG"].ToString(), row["TABLE_SCHEMA"].ToString(),
                        row["TABLE_NAME"].ToString());
                    Tables.Add(t);
                }
                var dt = row["DATA_TYPE"].ToString();
                Columns.Add(new Column(t, row["COLUMN_NAME"].ToString(), row["TABLE_SCHEMA"].ToString(),
                    row["COLUMN_DEFAULT"].ToString(), row["IS_NULLABLE"].ToString(),
                    new SqlTypes(dt, row["CHARACTER_MAXIMUM_LENGTH"].ToString(), row["NUMERIC_PRECISION"].ToString(),
                        row["NUMERIC_SCALE"].ToString())));
            }

            dtColumns = SQL.Select(
                @"SELECT fk.name, tp.name, cp.name, tr.name, cr.name, fk.delete_referential_action, fk.update_referential_action
                FROM  sys.foreign_keys fk
                INNER JOIN sys.tables tp ON fk.parent_object_id = tp.object_id
                INNER JOIN sys.tables tr ON fk.referenced_object_id = tr.object_id
                INNER JOIN sys.foreign_key_columns fkc ON fkc.constraint_object_id = fk.object_id
                INNER JOIN sys.columns cp ON fkc.parent_column_id = cp.column_id AND fkc.parent_object_id = cp.object_id
                INNER JOIN sys.columns cr ON fkc.referenced_column_id = cr.column_id AND fkc.referenced_object_id = cr.object_id ");
            foreach (DataRow row in dtColumns.Rows)
            {
                Relations.Add(new Relation(row[0].ToString(),
                    Columns.First(a => a.TableName == row[1].ToString() && a.ColumnName == row[2].ToString()),
                    Columns.First(a => a.TableName == row[3].ToString() && a.ColumnName == row[4].ToString())));
            }

            dtColumns = SQL.Select(
                "SELECT ROUTINE_NAME, ROUTINE_SCHEMA" +
                " FROM INFORMATION_SCHEMA.ROUTINES r WHERE r.ROUTINE_TYPE = 'PROCEDURE' AND ROUTINE_NAME LIKE 'sp%'" +
                " ORDER BY ROUTINE_NAME");

            foreach (DataRow row in dtColumns.Rows)
            {
                var procBody = new Procedure(row[0].ToString(), row[1].ToString());
                Procedures.Add(procBody);
            }
        }

        public static string GenerateInsert(object treeNodeTag)
        {
            var tc = treeNodeTag as Table;
            if (tc == null) return string.Empty;
            var cmd1 =
                new StringBuilder("INSERT INTO " + tc.TableSchema + "." + tc.TableName + Environment.NewLine + "(");
            var cmd2 = new StringBuilder("VALUES (");
            foreach (var c in Columns.Where(a => a.TableName == tc.TableName))
            {
                cmd1.Append(c.ColumnName + ", ");
                if (c.ColumnDefault == string.Empty)
                    cmd2.Append(c.ColumnName + "<" + c.DataType + ">, ");
                else
                    cmd2.Append(c.ColumnName + "<" + c.DataType + ">(" + c.ColumnDefault + "), ");
            }
            cmd1.Remove(cmd1.Length - 2, 2);
            cmd1.Append(")" + Environment.NewLine + cmd2.Remove(cmd2.Length - 2, 2) + ")");
            return cmd1.ToString();
        }

        public static string[] Split(this string value, params string[] by)
        {
            return value.Split(by, StringSplitOptions.None);
        }

        public class CustomSyntaxHighlightService : ISyntaxHighlightService
        {
            readonly SyntaxHighlightProperties commentSettings = new SyntaxHighlightProperties
            {
                ForeColor = Color.Gray
            };

            readonly SyntaxHighlightProperties defaultSettings = new SyntaxHighlightProperties
            {
                ForeColor = Color.Black
            };

            readonly Document document;

            readonly string[] function =
            {
                "GETDATE", "DATEPART", "DATEADD", "DATEDIFF", "ISNULL", "SUM", "COUNT", "MIN", "MAX", "LIST",
                "SUBSTRING",
                "CHAR_LENGTH", "RTRIM", "LTRIM", "SUBSTRING", "CONVERT", "AVG"
            };

            readonly SyntaxHighlightProperties functionSettings = new SyntaxHighlightProperties
            {
                ForeColor = Color.DarkViolet
            };

            readonly string[] keywords =
            {
                "INSERT", "INTO", "DECLARE", "DISTINCT", "SELECT", "CREATE", "TABLE", "USE", "IDENTITY", "ON", "OFF",
                "NOT",
                "NULL", "WITH", "SET", "FROM", "WHERE", "CASE", "WHEN", "AS", "PROC", "PROCEDURE", "AND", "OR", "LIKE",
                "UPDATE", "DELETE", "DROP", "WHILE", "EXEC", "EXECUTE", "IF", "ELSE", "BY", "IS", "TO",
                "VALUES", "ALTER", "GRANT", "GROUP", "ORDER", "BEGIN", "END", "TRAN", "TRANSACTION", "ROLLBACK",
                "COMMIT", "SAVE",
                "INT", "INTEGER", "TEXT", "IMAGE", "DECIMAL", "BIT", "INT", "NUMERIC", "TINYINT", "CHAR", "VARCHAR",
                "UNSIGNED"
            };

            readonly SyntaxHighlightProperties keywordSettings = new SyntaxHighlightProperties
            {
                ForeColor = Color.Blue
            };

            readonly SyntaxHighlightProperties stringSettings = new SyntaxHighlightProperties
            {
                ForeColor = Color.Green
            };

            public CustomSyntaxHighlightService(Document document)
            {
                this.document = document;
            }

            public void ForceExecute()
            {
                Execute();
            }

            public void Execute()
            {
                document.ApplySyntaxHighlight(ParseTokens());
            }

            List<SyntaxHighlightToken> ParseTokens()
            {
                var tokens = new List<SyntaxHighlightToken>();

                var ranges = document.FindAll("'", SearchOptions.None);
                for (var i = 0; i < ranges.Length / 2; i++)
                {
                    if (ranges[i * 2 + 1].Start.ToInt() - ranges[i * 2].Start.ToInt() + 1 >= 0)
                        tokens.Add(new SyntaxHighlightToken(ranges[i * 2].Start.ToInt(),
                            ranges[i * 2 + 1].Start.ToInt() - ranges[i * 2].Start.ToInt() + 1, stringSettings));
                }

                foreach (var t in keywords)
                {
                    ranges = document.FindAll(t, SearchOptions.WholeWord);
                    foreach (var r in ranges)
                    {
                        if (!IsRangeInTokens(r, tokens))
                            tokens.Add(new SyntaxHighlightToken(r.Start.ToInt(), r.Length, keywordSettings));
                    }
                }

                foreach (var f in function)
                {
                    ranges = document.FindAll(f, SearchOptions.None | SearchOptions.WholeWord);
                    foreach (var r in ranges)
                    {
                        if (!IsRangeInTokens(r, tokens))
                            tokens.Add(new SyntaxHighlightToken(r.Start.ToInt(), r.Length, functionSettings));
                    }
                }

                var expr = new Regex(@"(/\*([^*]|[\r\n]|(\*+([^*/]|[\r\n])))*\*+/)|(--.*)");
                ranges = document.FindAll(expr);
                foreach (var t in ranges)
                {
                    if (!IsRangeInTokens(t, tokens))
                        tokens.Add(new SyntaxHighlightToken(t.Start.ToInt(), t.Length, commentSettings));
                }

                //expr = new Regex(@"(@\w*)");
                //ranges = document.FindAll(expr);
                //foreach (DocumentRange r in ranges)
                //{
                //    if (!IsRangeInTokens(r, tokens))
                //        tokens.Add(new SyntaxHighlightToken(r.Start.ToInt(), r.Length, variableSettings));
                //}

                //foreach (var t in Tables)
                //{
                //    ranges = document.FindAll(t.TableName, SearchOptions.None | SearchOptions.WholeWord);

                //    foreach (DocumentRange r in ranges)
                //    {
                //        if (!IsRangeInTokens(r, tokens))
                //            tokens.Add(new SyntaxHighlightToken(r.Start.ToInt(), r.Length, functionSettings));
                //    }
                //}
                tokens.Sort(new SyntaxHighlightTokenComparer());
                AddPlainTextTokens(tokens);
                return tokens;
            }

            void AddPlainTextTokens(IList<SyntaxHighlightToken> tokens)
            {
                var count = tokens.Count;
                if (count == 0)
                {
                    tokens.Add(new SyntaxHighlightToken(0, document.Range.End.ToInt(), defaultSettings));
                    return;
                }
                tokens.Insert(0, new SyntaxHighlightToken(0, tokens[0].Start, defaultSettings));
                for (var i = 1; i < count; i++)
                {
                    tokens.Insert(i * 2, new SyntaxHighlightToken(tokens[i * 2 - 1].End,
                        tokens[i * 2].Start - tokens[i * 2 - 1].End, defaultSettings));
                }
                if (document.Range.End.ToInt() - tokens[count * 2 - 1].End >= 0)
                    tokens.Add(new SyntaxHighlightToken(tokens[count * 2 - 1].End,
                        document.Range.End.ToInt() - tokens[count * 2 - 1].End, defaultSettings));
            }

            bool IsRangeInTokens(DocumentRange range, List<SyntaxHighlightToken> tokens)
            {
                return tokens.Any(t => range.Start.ToInt() >= t.Start && range.End.ToInt() <= t.End);
            }
        }

        class SyntaxHighlightTokenComparer : IComparer<SyntaxHighlightToken>
        {
            public int Compare(SyntaxHighlightToken x, SyntaxHighlightToken y)
            {
                return x.Start - y.Start;
            }
        }
    }
}