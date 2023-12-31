using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Interfaces;

namespace SBS_BarthLogistic.Classes
{
    class CLSProcedures
    {
        public const int CommandTimeout = 600;

        public static void Savelayout(MemoryStream ms, string reportName, string name, bool isDg)
        {
            var cmd = new SqlCommand();
            cmd.Connection = GlobalParameters.cn;
            cmd.CommandText =
                string.Format("INSERT INTO Layout( NameForReports, Name, Data,isDg) VALUES ('{0}',N'{1}',@data,{2})",
                    reportName, name, Convert.ToInt32(isDg));
            cmd.Parameters.AddWithValue("@data", ms.ToArray());
            try
            {
                GlobalParameters.cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                e.ShowErrorDialog();
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
        }
    }

    public class CLSSpAll
    {
        public CLSSpAll(string procName)
            : this(null, procName)
        {
        }

        public CLSSpAll(PanelControl pa, string procName, bool allowNoResutl = false)
        {
            AllowNoResutl = allowNoResutl;
            Comm = new SqlCommand(procName, GlobalParameters.cn);
            Comm.CommandType = CommandType.StoredProcedure;
            Comm.CommandTimeout = CLSProcedures.CommandTimeout;
            if (pa == null) return;
            foreach (var ctr in pa.Controls.OfType<IFMGFindControl>())
            {
                ctr.AddProcParameter(Comm);
            }
        }

        public CLSSpAll(PanelControl pa, bool allowNoResutl = false)
        {
            var procName = "sp" + pa.Name.Substring(2);
            AllowNoResutl = allowNoResutl;
            Comm = new SqlCommand(procName, GlobalParameters.cn);
            Comm.CommandType = CommandType.StoredProcedure;
            Comm.CommandTimeout = CLSProcedures.CommandTimeout;
            foreach (var ctr in pa.Controls.OfType<IFMGFindControl>())
            {
                ctr.AddProcParameter(Comm);
            }
        }

        public SqlCommand Comm { get; set; }
        public bool AllowNoResutl { get; set; }

        public DataTable Exceute()
        {
            var dt = new DataTable();
            var da = new SqlDataAdapter(Comm);
            try
            {
                GlobalParameters.cn.Open();
                da.Fill(dt);
            }
            catch (Exception e)
            {
                var parametersCmd = string.Empty;
                foreach (SqlParameter parameter in Comm.Parameters)
                    parametersCmd += parameter.ParameterName + " = " + parameter.SqlValue + ",\n";
                e.ShowErrorDialog("EXEC " + Comm.CommandText + Environment.NewLine + parametersCmd);
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
            if (AllowNoResutl && dt.Rows.Count == 0)
                XtraMessageBox.Show("მონაცემები ვერ მოიძებნა", string.Empty, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            return dt;
        }

        public void AddParameter(string paramName, object value)
        {
            Comm.Parameters.AddWithValue(paramName, value);
        }
    }
}