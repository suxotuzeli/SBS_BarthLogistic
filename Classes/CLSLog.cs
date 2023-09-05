using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SBS_BarthLogistic.Classes
{
    class CLSLog
    {
        readonly Dictionary<string, LogValues> dic;

        public CLSLog()
        {
            dic = new Dictionary<string, LogValues>();
        }

        public void AddOldValues(string tableName, string id)
        {
            if (!GlobalParameters.CreateLog)
                return;
            dic.Clear();
            DataTable columns = SQL.Select("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tableName + "'");
            DataTable dt = SQL.Select("SELECT * FROM " + tableName + " WHERE Id" + tableName + " = N'" + id + "'");
            for (int i = 0; i < columns.Rows.Count; i++)
            {
                var value = new LogValues();
                var fieldName = columns.Rows[i]["COLUMN_NAME"].ToString();
                value.OldValue = dt.Rows[0][fieldName].ToString();
                value.NewValue = string.Empty;
                dic.Add(fieldName, value);
            }
        }

        public void AddNewValues(string tableName, string id)
        {
            if (!GlobalParameters.CreateLog) return;
            DataTable columns = SQL.Select("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tableName + "'");
            DataTable dt = SQL.Select("SELECT * FROM " + tableName + " WHERE Id" + tableName + " = N'" + id + "'");
            for (int i = 0; i < columns.Rows.Count; i++)
            {
                var value = new LogValues();
                var fieldName = columns.Rows[i]["COLUMN_NAME"].ToString();
                value.NewValue = dt.Rows[0][fieldName].ToString();
                if (dic.ContainsKey(fieldName))
                    dic[fieldName].NewValue = value.NewValue;
                else
                    dic.Add(fieldName, value);
            }
        }

        public void CreateLog(string tableName, string operType, string sql)
        {
            if (!GlobalParameters.CreateLog)
                return;
            sql = sql.Replace("'", "-");
            var str = new StringBuilder();
            str.Append("INSERT INTO Change1(Data,UserName,TableName,OperType, Sql) VALUES(");
            str.AppendFormat("GETDATE(), N'{0}', N'{1}', N'{2}', '{3}' ); SELECT SCOPE_IDENTITY()",
                GlobalParameters.UserName, tableName, operType, sql);
            int id = SQL.Insert(str.ToString());

            foreach (var logValue in dic)
            {
                str.Remove(0, str.Length);
                str.Append("INSERT INTO Change2(IdChange1, FieldName, OldValue, NewValue) VALUES (");
                str.Append(id + ", ");
                str.Append("N'" + logValue.Key + "', ");
                str.Append("N'" + logValue.Value.OldValue + "', ");
                str.Append("N'" + logValue.Value.NewValue + "') ");
                SQL.Insert(str.ToString());
            }
        }
    }

    class LogValues
    {
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
