using System;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace SBS_BarthLogistic.Classes
{
    class CLSGridViewOperation
    {
        readonly GridView gv;
        readonly string[] numericFieldList;

        public CLSGridViewOperation(GridView gv, string[] numericFieldList)
        {
            this.numericFieldList = numericFieldList;
            this.gv = gv;
        }

        public GridView ShowOtherCols(bool b)
        {
            foreach (GridColumn col in gv.Columns)
                col.Visible = b;
            ShowNumberCols(true);
            return gv;
        }

        void ShowNumberCols(bool b)
        {
            var b1 = true;
            foreach (var n in numericFieldList)
            {
                if (n == ".")
                {
                    b1 = false;
                    continue;
                }
                var columnByName = gv.Columns.ColumnByName("col" + n.Trim());
                if (columnByName != null)
                    columnByName.Visible = b1 && b;
            }
        }

        public GridView SetVisibleColumnsViaGroupByClause(string fieldList)
        {
            char[] c =
            {
                ','
            };
            var s = fieldList.Split(c, StringSplitOptions.RemoveEmptyEntries);
            foreach (var s1 in s)
                gv.Columns.ColumnByName("col" + s1.Trim()).Visible = true;
            return gv;
        }
    }
}