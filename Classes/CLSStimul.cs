using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;

namespace SBS_BarthLogistic.Classes
{
    class CLSStimul
    {
        DataTable dtMaster, dtSasZeddDanarti;
        StiReport report;

        public CLSStimul()
        {
            TableName = "NOTable";
            Dt = new DataTable("NOTable");
        }

        public CLSStimul(string reportName)
        {
            TableName = reportName;
            ReportName = reportName;
        }

        public CLSStimul(string reportName, DataTable dt)
        {
            TableName = reportName;
            ReportName = reportName;
            Dt = dt;
        }

        public CLSStimul(string reportName, GridControl dg)
        {
            TableName = reportName;
            ReportName = reportName;
            Dt = dg.DataSource as DataTable;
        }

        public CLSStimul(string reportName, DataTable dt, DataTable dtMaster)
        {
            TableName = reportName;
            ReportName = reportName;
            Dt = dt;
            this.dtMaster = dtMaster;
        }

        public CLSStimul(string reportName, DataTable dt, string tablename)
        {
            TableName = tablename;
            ReportName = reportName;
            Dt = dt;
        }

        public string TableName { get; set; }
        public DataTable Dt { get; set; }
        public string ReportName { get; set; }

        public void Initialize()
        {
            report = new StiReport();
            if (Dt != null)
            {
                Dt.TableName = TableName;
                report.RegData(TableName, Dt);
            }
            report.Load(GlobalParameters.ReportsFolder + "st" + ReportName + ".mrt");
        }

        public void Initialize(string masterTableName)
        {
            report = new StiReport();

            if (Dt != null)
            {
                Dt.TableName = TableName;
                dtMaster.TableName = masterTableName;
                report.RegData(TableName, Dt);
            }
            report.RegData(masterTableName, dtMaster);
            report.Load(GlobalParameters.ReportsFolder + "st" + ReportName + ".mrt");
        }

        public void InitializeDesigner()
        {
            report = new StiReport();
        }

        public void InitializeWithOutLoading()
        {
            report = new StiReport();
        }

        public void LoadReport(string reportName1)
        {
            report.Load(GlobalParameters.ReportsFolder + "st" + reportName1 + ".mrt");
        }

        public void RegDataTable(DataTable dt1, string tableName1)
        {
            report.RegData(tableName1, dt1);
        }

        public void SetDefaultVariables(DataTable dtVars, int pos)
        {
            var vars = new Dictionary<string, string>();
            for (var i = 0; i < dtVars.Columns.Count; i++)
                vars.Add(dtVars.Columns[i].ColumnName, dtVars.Rows[pos][i].ToString());

            if (!dtVars.Columns.Contains("CompanyName"))
            {
                vars.Add("CompanyName", Company.Name);
                vars.Add("CompanySagad", Company.Sagad);
                vars.Add("CompanyAddress", Company.Address);
            }

            for (var i = 0; i < report.Dictionary.Variables.Count; i++)
                if (vars.ContainsKey(report.Dictionary.Variables[i].Name))
                {
                    if (report.Dictionary.Variables[i].Name == "Data")
                        report.Dictionary.Variables[i].Value =
                            Convert.ToDateTime(vars[report.Dictionary.Variables[i].Name]).ToShortDateString();
                    else
                        report.Dictionary.Variables[i].Value = vars[report.Dictionary.Variables[i].Name];
                }
        }

        public void SetDefaultVariables(DataRow dtVars)
        {
            var vars = new Dictionary<string, string>();
            for (var i = 0; i < dtVars.Table.Columns.Count; i++)
                vars.Add(dtVars.Table.Columns[i].ColumnName, dtVars[i].ToString());

            if (!dtVars.Table.Columns.Contains("CompanyName"))
            {
                vars.Add("CompanyName", Company.Name);
                vars.Add("CompanySagad", Company.Sagad);
                vars.Add("CompanyAddress", Company.Address);
            }

            for (var i = 0; i < report.Dictionary.Variables.Count; i++)
                if (vars.ContainsKey(report.Dictionary.Variables[i].Name))
                {
                    if (report.Dictionary.Variables[i].Name == "Data")
                        report.Dictionary.Variables[i].Value =
                            Convert.ToDateTime(vars[report.Dictionary.Variables[i].Name]).ToShortDateString();
                    else
                        report.Dictionary.Variables[i].Value = vars[report.Dictionary.Variables[i].Name];
                }
        }

        public void SetVariableValue(string variableName, string variableValue)
        {
            report.Dictionary.Variables[variableName].Value = variableValue;
        }

        public void SetConnectionString()
        {
            report.Dictionary.Databases.Clear();
            report.Dictionary.Databases.Add(new StiSqlDatabase("FMG", GlobalParameters.ConnStr));
        }

        public void Show()
        {
            report.Show();
        }

        public void Print()
        {
            Print(1);
        }

        public void Print(short copies)
        {
            report.Print(false, copies);
        }

        public void Design()
        {
            report.Design();
        }

        public void Design(string newReportName)
        {
            report.Load(newReportName);
            report.Design();
        }

        #region PrintSasZedd

        void GenerateSasZeddTables(string zeddTableName, GridView gv, bool hasOrgInformation)
        {
            var orgInformation = hasOrgInformation
                ? "IdOrg, Gvari, Address, LegalAddress, Sagad," : " ProekAddress1, ProekAddress2,PiradiNom, ";

            dtMaster =
                SQL.Select(
                    string.Format(
                        "SELECT Id{1}1, Data, Zedd, Mdz, Nom, Mocm, Man, ActivateData,TransTanxa, shen, {2} '' TanxaText, '' DataText, SUM(Tanxa) Tanxa FROM {1}View {0} " +
                        "GROUP BY Id{1}1, Data, Zedd, Mdz, Nom, ActivateData, TransTanxa, Mocm, shen,  {2} Man ORDER BY Id{1}1",
                        GenerateWhereClause(gv, zeddTableName), zeddTableName, orgInformation));

            Dt = SQL.Select(
                string.Format(
                    "SELECT Id{1}1, Id{1}2, 1 RigitiNom, IdProd, Prod, Ert, Raod, Fasi, Tanxa ,UnitName FROM {1}View WHERE Id{1}1 IN (SELECT Id{1}1 FROM {1}View {0} GROUP BY Id{1}1 )" +
                    // HAVING COUNT(Id{1}2) <= 23
                    " ORDER BY Id{1}1, Prod", GenerateWhereClause(gv, zeddTableName), zeddTableName));
            dtSasZeddDanarti =
                SQL.Select("SELECT TOP 0 0 Id" + zeddTableName +
                           "1,'' IdProd, '' Prod, '' Ert, 0.0 Raod, 0.0 Fasi, 0.0 Tanxa, ' ' UnitName");
            TableName = zeddTableName + "2";
            for (var i = 0; i < dtMaster.Rows.Count; i++)
            {
                dtMaster.Rows[i]["TanxaText"] = CLSTools.ReturnTanxaText(Convert.ToDouble(dtMaster.Rows[i]["Tanxa"]));
                dtMaster.Rows[i]["DataText"] = Convert.ToDateTime(dtMaster.Rows[i]["Data"].ToString()).RerurnDataText();
            }
        }

        void PrintSasZeddReport(string zeddTableName, string zeddReportName)
        {
            ReportName = zeddReportName;
            Initialize("" + zeddTableName + "1");
            if (report.Dictionary.Variables.Contains("CompanyName"))
                report.Dictionary.Variables["CompanyName"].Value = Company.Name;
            if (report.Dictionary.Variables.Contains("CompanyAddress"))
                report.Dictionary.Variables["CompanyAddress"].Value = Company.Address;
            if (report.Dictionary.Variables.Contains("CompanySagad"))
                report.Dictionary.Variables["CompanySagad"].Value = Company.Sagad;
            if (report.Dictionary.Variables.Contains("CompanyNebaDarto"))
                report.Dictionary.Variables["CompanyNebaDarto"].Value = Company.NebaDarto;
            if (report.Dictionary.Variables.Contains("CompanyDirek"))
                report.Dictionary.Variables["CompanyDirek"].Value = Company.Direk;
            if (report.Dictionary.Variables.Contains("CompanyContact"))
                report.Dictionary.Variables["CompanyContact"].Value = Company.Contact;
            if (report.Dictionary.Variables.Contains("CompanyMail"))
                report.Dictionary.Variables["CompanyMail"].Value = Company.Mail;
            if (report.Dictionary.Variables.Contains("CompanyShen"))
                report.Dictionary.Variables["CompanyShen"].Value = Company.Shen;
            if (report.Dictionary.Variables.Contains("TransType"))
                report.Dictionary.Variables["TransType"].Value = WayBillParameters.TransTypes;
            //if (report.Dictionary.Variables.Contains("ZeddType"))
            //    report.Dictionary.Variables["ZeddType"].Value = WayBillParameters.ZeddType;

            report.Pages["Page2"].Enabled = dtSasZeddDanarti.Rows.Count != 0;
            dtSasZeddDanarti.TableName = zeddTableName + "2Danarti";
            RegDataTable(dtSasZeddDanarti, zeddTableName + "2Danarti");

            Show();
            //Print((short)PrintParameters.SasZeddCopies);   
        }

        void NotPrintedZedd(GridView gv, string zeddTableName)
        {
            var id = new int[100];

            var dtNotPrinted = SQL.Select("SELECT Id" + zeddTableName + "1, Zedd FROM " + zeddTableName + "View " +
                                          GenerateWhereClause(gv, zeddTableName) + " GROUP BY Zedd,Id" + zeddTableName +
                                          "1 HAVING COUNT(Id" + zeddTableName + "2) > 23 ");
            if (dtNotPrinted.Rows.Count > 0)
            {
                var count = 0;
                for (var i = 0; i < dtNotPrinted.Rows.Count; i++)
                {
                    id[count++] = Convert.ToInt32(dtNotPrinted.Rows[i]["Id" + zeddTableName + "1"].ToString());
                }
                GenerateDtSasZeddDanartiWithout1(id, count, zeddTableName);
            }
        }

        void GenerateDtSasZeddDanartiWithout1(int[] id, int count, string zeddTableName)
        {
            var bs = new BindingSource();
            bs.DataSource = Dt;
            for (var i = 0; i < count; i++)
            {
                bs.Filter = "Id" + zeddTableName + "1 = " + id[i];
                bs.Position = 22;
                double sum = 0, raod = 0;
                var n = bs.Count - 24;
                for (var j = 0; j < n; j++)
                {
                    var dr = dtSasZeddDanarti.NewRow();
                    dr["Id" + zeddTableName + "1"] = id[i];
                    dr["IdProd"] = ((DataRowView)bs.Current)["IdProd"]; //((DataRowView)bs.Current)["Data"]
                    dr["Prod"] = ((DataRowView)bs.Current)["Prod"];
                    dr["Ert"] = ((DataRowView)bs.Current)["Ert"];
                    dr["Raod"] = ((DataRowView)bs.Current)["Raod"];
                    dr["Fasi"] = ((DataRowView)bs.Current)["Fasi"];
                    dr["Tanxa"] = ((DataRowView)bs.Current)["Tanxa"];
                    dtSasZeddDanarti.Rows.Add(dr);
                    sum += Convert.ToDouble(((DataRowView)bs.Current)["Tanxa"]);
                    raod += Convert.ToDouble(((DataRowView)bs.Current)["Raod"]);
                    var pos = bs.Position;
                    Dt.Rows.RemoveAt(ReturnDtRecordNumber(Dt,
                        Convert.ToInt32(((DataRowView)bs.Current)["Id" + zeddTableName + "2"].ToString()), zeddTableName));
                    bs.Position = pos;
                }
                var dr1 = Dt.NewRow();
                dr1["Id" + zeddTableName + "1"] = id[i];
                dr1["RigitiNom"] = 2;
                dr1["IdProd"] = "-";
                dr1["Prod"] = "დანართის მიხედვით";
                dr1["Ert"] = "-";
                dr1["Raod"] = raod;
                dr1["Fasi"] = 0;
                dr1["Tanxa"] = sum;
                Dt.Rows.Add(dr1);
                bs.Filter = "";
                bs.Sort = "RigitiNom,Prod";
            }
        }

        static int ReturnDtRecordNumber(DataTable dt2, int id2, string zeddTableName)
        {
            for (var i = 0; i < dt2.Rows.Count; i++)
            {
                if (Convert.ToInt32(dt2.Rows[i]["Id" + zeddTableName + "2"].ToString()) == id2)
                    return i;
            }
            return -1;
        }

        public void PrintSasZedd(string zeddTableName, string zeddReportName, GridView gv, bool hasOrgInformation)
        {
            GenerateSasZeddTables(zeddTableName, gv, hasOrgInformation);
            NotPrintedZedd(gv, zeddTableName);
            PrintSasZeddReport(zeddTableName, zeddReportName);
        }

        public static string GenerateWhereClause(GridView gv, string zeddTableName)
        {
            var selected = gv.GetSelectedRows();
            var s = " WHERE Id" + zeddTableName + "1 IN (";
            foreach (int t in selected)
                s += gv.GetDataRow(t)["Id" + zeddTableName + "1"] + ", ";
            return s.Substring(0, s.Length - 2) + ") ";
        }

        #endregion PrintSasZedd
    }
}