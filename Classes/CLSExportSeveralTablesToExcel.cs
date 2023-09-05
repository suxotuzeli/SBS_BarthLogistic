using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Aspose.Cells;

namespace SBS_BarthLogistic.Classes
{
    class CLSExportSeveralTablesToExcel
    {
        readonly DateTime d1, d2;
        readonly string fileName;
        readonly string idExportName;
        DataTable dtSheet;

        public CLSExportSeveralTablesToExcel(DateTime d1, DateTime d2, string fileName)
        {
            this.d1 = d1;
            this.fileName = fileName;
            this.d2 = d2;
            idExportName = "1";
        }

        public CLSExportSeveralTablesToExcel(DateTime d1, DateTime d2, string fileName, string idExportName)
        {
            this.d1 = d1;
            this.fileName = fileName;
            this.d2 = d2;
            this.idExportName = idExportName;
        }

        public void ExportToExcel()
        {
            dtSheet = SQL.Select("SELECT * FROM ExportSheet WHERE idExportName = " + idExportName);
            var workbook = new Workbook(GlobalParameters.ReportsFolder + fileName + ".XLS");
            ExportTable(workbook);
        }

        void ExportTable(Workbook workbook)
        {
            var outputFileName = GlobalParameters.MonacemebiFolder + fileName + (PrintParameters.ReportNumber++) +
                                 ".XLS";
            for (var i = 0; i < dtSheet.Rows.Count; i++)
            {
                var sheet = workbook.Worksheets[dtSheet.Rows[i]["ExportSheet"].ToString()];
                var dt =
                    SQL.Select("SELECT * FROM ExportTable WHERE IdExportSheet = " + dtSheet.Rows[i]["IdExportSheet"]);
                var dt1 = new DataTable();

                var str = new StringBuilder();
                for (var j = 0; j < dt.Rows.Count; j++)
                {
                    var exportField = dt.Rows[j]["ExportField"].ToString();
                    str.Remove(0, str.Length);
                    str.Append("SELECT N'" + dt.Rows[j]["OperT"] + "' OperT, " + exportField + " ");
                    var hasSummary = dt.Rows[j]["SummaryField"].ToString().Length > 1;
                    if (hasSummary)
                    {
                        var s = (dt.Rows[j]["SummaryField"].ToString()).Split(new[]
                        {
                            ','
                        }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string t in s)
                            str.AppendFormat(", SUM({0}) {0}", t);
                    }
                    str.Append(" FROM " + dt.Rows[j]["ExportTable"]);

                    str.Append(Convert.ToBoolean(dt.Rows[j]["HasWhereCondition"].ToString())
                        ? " WHERE Data >= '" + d1 + "' AND Data <= N'" + d2 + "'" +
                          dt.Rows[j]["AdditionalWhereCondition"]
                        : " WHERE 1 = 1 " + dt.Rows[j]["AdditionalWhereCondition"]);
                    if (hasSummary)
                        str.Append(" GROUP BY " + exportField);
                    str.Append(" ORDER BY " + exportField);
                    if (j == 0)
                    {
                        dt1 = SQL.Select(str.ToString());
                        FieldsFontChange(dt1, dt.Rows[j]["FontChangeField"].ToString());
                    }
                    else
                    {
                        var dt2 = SQL.Select(str.ToString());
                        FieldsFontChange(dt2, dt.Rows[j]["FontChangeField"].ToString());
                        dt1 = ConcatenateTables(dt1, dt2, Convert.ToBoolean(dtSheet.Rows[i]["TopAndBottom"].ToString()),
                            dt.Rows[j]["ExportTable"].ToString(), dt.Rows[j]["SummaryField"].ToString(),
                            dt.Rows[j]["ExportField"].ToString());
                    }
                }
                if (dt1.Rows.Count <= 0)
                    continue;
                var excel = new CLSExcel(dt1, fileName, sheet);
                excel.ExportDt(sheet);
            }
            try
            {
                workbook.Save(outputFileName);
                Process.Start(outputFileName);
            }
            catch (Exception e)
            {
                e.ShowErrorDialog();
            }
        }

        static DataTable ConcatenateTables(DataTable dt1, DataTable dt2, bool topAndBottom, string tableFieldSufics,
            string summaryField, string exportField)
        {
            var dt2Count = dt2.Rows.Count;
            if (topAndBottom)
            {
                for (var i = 0; i < dt2Count; i++)
                {
                    var dr = dt1.NewRow();
                    for (var j = 0; j < dt2.Columns.Count; j++)
                    {
                        dr[dt2.Columns[j].ColumnName] = dt2.Rows[i][j];
                    }
                    dt1.Rows.Add(dr);
                }
            }
            else
            {
                var numeric = summaryField.Split(new[]
                {
                    ','
                }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var t in numeric)
                {
                    dt1.Columns.Add(tableFieldSufics + t, Type.GetType("System.Decimal"));
                }
                var field = exportField.Split(new[]
                {
                    ','
                }, StringSplitOptions.RemoveEmptyEntries);
                for (var i = 0; i < dt2Count; i++)
                {
                    var updated = false;
                    for (var j = 0; j < dt1.Rows.Count; j++)
                    {
                        var isEqual = field.All(t => dt1.Rows[j][t].ToString() == dt2.Rows[i][t].ToString());
                        if (!isEqual) continue;

                        foreach (var t in field)
                        {
                            dt1.Rows[j][t] = dt2.Rows[i][t];
                        }
                        foreach (var t in numeric)
                        {
                            dt1.Rows[j][tableFieldSufics + t] = dt2.Rows[i][t];
                        }
                        dt1.Rows[j]["OperT"] = dt1.Rows[j]["OperT"] + " - " + dt2.Rows[i]["OperT"];
                        updated = true;
                        break;
                    }
                    if (updated)
                        continue;
                    var dr = dt1.NewRow();
                    foreach (var t in field)
                    {
                        dr[t] = dt2.Rows[i][t];
                    }
                    foreach (var t in numeric)
                    {
                        dr[tableFieldSufics + t] = dt2.Rows[i][t];
                    }
                    dr["OperT"] = dt2.Rows[i]["OperT"];
                    dt1.Rows.Add(dr);
                }
            }

            return dt1;
        }

        void FieldsFontChange(DataTable dt, string fontChangeField)
        {
            if (fontChangeField.Trim().Length < 2)
                return;
            var s = fontChangeField.Split(new[]
            {
                ','
            }, StringSplitOptions.RemoveEmptyEntries);
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                foreach (var t in s)
                {
                    dt.Rows[i][t] = ChangeFont(dt.Rows[i][t.Trim()].ToString());
                }
            }
        }

        string ChangeFont(string field)
        {
            var s = new StringBuilder();
            foreach (var t in field)
            {
                switch (idExportName)
                {
                    case "1": //info
                        s.Append(ChangeCharFontUnicodeToInfo(t));
                        break;
                    default:
                        s.Append(t);
                        break;
                }
            }
            return s.ToString();
        }

        static char ChangeCharFontUnicodeToInfo(char c)
        {
            switch (c)
            {
                case (char)4304:
                    return '‹';
                case (char)4305:
                    return 'Œ';
                case (char)4306:
                    return '•';
                case (char)4307:
                    return '–';
                case (char)4308:
                    return '—';
                case (char)4309:
                    return '˜';
                case (char)4310:
                    return 'š';
                case (char)4311:
                    return '›';
                case (char)4312:
                    return 'œ';
                case (char)4313:
                    return 'Ÿ';
                case (char)4314:
                    return '¡';
                case (char)4315:
                    return '¢';
                case (char)4316:
                    return '£';
                case (char)4317:
                    return '¤';
                case (char)4318:
                    return '¥';
                case (char)4319:
                    return '¦';
                case (char)4320:
                    return 'ª';
                case (char)4321:
                    return '«';
                case (char)4322:
                    return '¬';
                case (char)4323:
                    return '­';
                case (char)4324:
                    return '¯';
                case (char)4325:
                    return '°';
                case (char)4326:
                    return '±';
                case (char)4327:
                    return '²';
                case (char)4328:
                    return '³';
                case (char)4329:
                    return '´';
                case (char)4330:
                    return 'µ';
                case (char)4331:
                    return 'º';
                case (char)4332:
                    return '»';
                case (char)4333:
                    return '¼';
                case (char)4334:
                    return '½';
                case (char)4335:
                    return '¾';
                case (char)4336:
                    return '¿';

                //                case (char) 4304:
                //                    return (char) 1040;
                //                case (char) 4305:
                //                    return (char) 1041;
                //                case (char) 4306:
                //                    return (char) 1042;
                //                case (char) 4307:
                //                    return (char) 1043;
                //                case (char) 4308:
                //                    return (char) 1044;
                //                case (char) 4309:
                //                    return (char) 1045;
                //                case (char) 4310:
                //                    return (char) 1046;
                //                case (char) 4311:
                //                    return (char) 1048;
                //                case (char) 4312:
                //                    return (char) 1049;
                //                case (char) 4313:
                //                    return (char) 1050;
                //                case (char) 4314:
                //                    return (char) 1051;
                //                case (char) 4315:
                //                    return (char) 1052;
                //                case (char) 4316:
                //                    return (char) 1053;
                //                case (char) 4317:
                //                    return (char) 1055;
                //                case (char) 4318:
                //                    return (char) 1056;
                //                case (char) 4319:
                //                    return (char) 1057;
                //                case (char) 4320:
                //                    return (char) 1058;
                //                case (char) 4321:
                //                    return (char) 1059;
                //                case (char) 4322:
                //                    return (char) 1060;
                //                case (char) 4323:
                //                    return (char) 1062;
                //                case (char) 4324:
                //                    return (char) 1063;
                //                case (char) 4325:
                //                    return (char) 1064;
                //                case (char) 4326:
                //                    return (char) 1065;
                //                case (char) 4327:
                //                    return (char) 1066;
                //                case (char) 4328:
                //                    return (char) 1067;
                //                case (char) 4329:
                //                    return (char) 1068;
                //                case (char) 4330:
                //                    return (char) 1069;
                //                case (char) 4331:
                //                    return (char) 1070;
                //                case (char) 4332:
                //                    return (char) 1071;
                //                case (char) 4333:
                //                    return (char) 1072;
                //                case (char) 4334:
                //                    return (char) 1074;
                //                case (char) 4335:
                //                    return (char) 1075;
                //                case (char) 4336:
                //                    return (char) 1076;
            }
            return c;
        }
    }
}