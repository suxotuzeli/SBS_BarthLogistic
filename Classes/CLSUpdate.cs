using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SBS_BarthLogistic.Classes
{
    class CLSUpdate
    {
        public static void CheckVersia()
        {
            var auto = Convert.ToBoolean(SQL.ExecuteScalar("SELECT TOP 1 CanAutoUpdate FROM Params WHERE UN= N'" +
                                                           GlobalParameters.UserName + "'"));
            if (!auto) return;

            var curVersion = new Version(Application.ProductVersion);
            if (curVersion.Build < 0)
                curVersion = new Version(curVersion.Major, curVersion.Minor, 0);

            var sqlUpdaterVersion = new Version(SQL.ExecuteScalar("SELECT ISNULL(MAX(Version), '0.0.0') FROM Updater WHERE Program='SBS_BarthLogistic' AND Active = 1"));
            if (sqlUpdaterVersion.Build < 0)
                sqlUpdaterVersion = new Version(sqlUpdaterVersion.Major, sqlUpdaterVersion.Minor, 0);

            if (sqlUpdaterVersion <= curVersion) return;
            var startInfo = new ProcessStartInfo();
            startInfo.FileName = "SBS_Updater.exe";
            startInfo.Arguments = InterfaceParameters.updatestr;
            Process.Start(startInfo);
            Application.Exit();
        }
    }
}