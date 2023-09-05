using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.InterfaceForms
{
    public partial class UpdateInsert : XtraForm
    {
        bool customDragDropTarget;
        bool exep, kavSiri = false;
        readonly string fieldName;
        SqlConnection cnLocal;
        Graphics richEditGraphics;
        int tnLen;

        public UpdateInsert()
        {
            InitializeComponent();

        }

        private void UpdateInsert_Load(object sender, EventArgs e)
        {
            DataTable dtProek = SQL.Select("SELECT * FROM Proek WHERE IdProek=" + DefaultValues.IdProek);
            if (dtProek.Rows.Count == 0)
            {
                XtraMessageBox.Show("მომხმარებელზე არ არის ობიექტი მიბმული");
                return;
            }
            if (dtProek.Rows[0]["IPAddress"].ToString() == "")
            {
                XtraMessageBox.Show(dtProek.Rows[0]["Proek"].ToString() + " -ზე არ არის განსაზღვრული ლოკალური სერვერის მისამართი");
                return;
            }
            string serverName = dtProek.Rows[0]["IPAddress"].ToString();
            string ConnStr = "Data Source=" + serverName + ";Initial Catalog=" +
                                       GlobalParameters.DatabaseName +
                                       ";Persist Security Info=True;User ID=" + dtProek.Rows[0]["LocalServerUser"] +
                                       ";Password=" + dtProek.Rows[0]["LocalServerPass"] + ";Connection Timeout=" +
                                       GlobalParameters.connectionTimeout + ";";
            cnLocal = new SqlConnection(ConnStr);

            try
            {
                cnLocal.Open();
                cnLocal.Close();
                kavSiri = true;
            }
            catch (Exception)
            {
                XtraMessageBox.Show("ლოკალურ სერვერთან კავშირი არ დამყარდა");


            }
            if (!kavSiri)
                return;
        }
        public void SQL_Local_Execute(string txtComm)
        {
            if (txtComm == string.Empty) return;
            try
            {
                cnLocal.Open();
                var comm = new SqlCommand(txtComm, cnLocal);
                comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                e.ShowErrorDialog(txtComm);
            }
            finally
            {
                cnLocal.Close();
            }
        }
        public DataTable SelectFromLocal(string txtComm)
        {
            using (var dt = new DataTable())
            {
                try
                {
                    cnLocal.Open();
                    new SqlDataAdapter(new SqlCommand(txtComm, cnLocal)).Fill(dt);
                }
                catch (Exception e)
                {
                    e.ShowErrorDialog(txtComm);
                }
                finally
                {
                    cnLocal.Close();
                }
                return dt;
            }
        }



        private void btnCalcProekNashti_Click(object sender, EventArgs e)
        {
            DateTime d = Convert.ToDateTime(DateTime.Now.ToShortDateString()).AddDays(-1);
            CLSSpAll proc = new CLSSpAll("");
            SqlParameter param = new SqlParameter("D2", SqlDbType.SmallDateTime);
            param.Direction = ParameterDirection.Input;
            param.Value = d.AddDays(-1);
            proc.Comm.Parameters.Add(param);
            param = new SqlParameter("IdProek", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = DefaultValues.IdProek;
            proc.Comm.Parameters.Add(param);
            DataTable dt = proc.Exceute();
            SQL_Local_Execute("Truncate Table LocalPreNashti ");
            string strComm;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strComm = "INSERT INTO LocalPreNashti(Data,IdProd,Raod) Values(";
                strComm += "N'" + d.ToShortDateString() + "',";
                strComm += "N'" + dt.Rows[i]["IdProd"] + "',";
                strComm += "" + dt.Rows[i]["Raod"] + ")";
                SQL_Local_Execute(strComm);
            }
            XtraMessageBox.Show("ნაშთის განახლება მორჩა");
        }

        private void btnCalcProekBrunva_Click(object sender, EventArgs e)
        {
            btnCalcProekBrunva.Enabled = false;
            DateTime d = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            CLSSpAll proc = new CLSSpAll(paCalcProekBrunva1, true);
            SqlParameter param = new SqlParameter("D2", SqlDbType.SmallDateTime);
            param.Direction = ParameterDirection.Input;
            param.Value = d;
            proc.Comm.Parameters.Add(param);
            param = new SqlParameter("IdProek", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = DefaultValues.IdProek;
            proc.Comm.Parameters.Add(param);
            SQL_Local_Execute("Truncate Table LocalBrunva2; DELETE FROM LocalBrunva1 ");
            DataTable dt = proc.Exceute();

            proc = new CLSSpAll(paCalcProekBrunva2, true);
            param = new SqlParameter("D2", SqlDbType.SmallDateTime);
            param.Direction = ParameterDirection.Input;
            param.Value = d;
            proc.Comm.Parameters.Add(param);
            param = new SqlParameter("IdProek", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = DefaultValues.IdProek;
            proc.Comm.Parameters.Add(param);
            string strComm;
            DataTable dt2 = proc.Exceute();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strComm = "INSERT INTO LocalBrunva1(Data,Zedd,BrunvaT,BrunvaType,SafuZveli,Shen,ShemGas,IdOperacia,IdOperaciaT,UN,CD) Values(";
                strComm += "N'" + d.ToShortDateString() + "',";
                strComm += "N'" + dt.Rows[i]["Zedd"] + "',";
                strComm += "N'" + dt.Rows[i]["BrunvaT"] + "',";
                strComm += "N'" + dt.Rows[i]["BrunvaType"] + "',";
                strComm += "N'" + dt.Rows[i]["SafuZveli"] + "',";
                strComm += "N'" + dt.Rows[i]["Shen"] + "',";
                strComm += "N'" + dt.Rows[i]["ShemGas"] + "',";
                strComm += "" + dt.Rows[i]["IdOperacia"] + ",";
                strComm += "" + dt.Rows[i]["IdOperaciaT"] + ",";
                strComm += "N'" + dt.Rows[i]["UN"] + "',";
                strComm += "N'" + Convert.ToDateTime(dt.Rows[i]["CD"]).ToShortDateString() + "') ; SELECT SCOPE_IDENTITY() AS IDD ";
                DataTable dtr = SelectFromLocal(strComm);
                string idd = dtr.Rows[0]["IDD"].ToString();
                DataRow[] rows =
                    dt2.Select(" IdOperacia=" + dt.Rows[i]["IdOperacia"] + " AND IdOperaciaT=" +
                               dt.Rows[i]["IdOperaciaT"]);
                foreach (var row in rows)
                {
                    strComm = "INSERT INTO LocalBrunva2(IdLocalBrunva1,IdProd,Raod,Tanxa,UN,CD) VALUES(";
                    strComm += "" + idd + ",";
                    strComm += "N'" + row["IdProd"] + "',";
                    strComm += "" + row["Raod"] + ",";
                    strComm += "" + row["Tanxa"] + ",";
                    strComm += "N'" + row["UN"] + "',";
                    strComm += "N'" + Convert.ToDateTime(row["CD"]).ToShortDateString() + "') ";
                    SQL_Local_Execute(strComm);

                }
            }


            XtraMessageBox.Show("დღის ბრუნვის განახლება მორჩა");
            btnCalcProekBrunva.Enabled = true;
        }

        private void btnCalcQvariQula_Click(object sender, EventArgs e)
        {
            btnCalcQvariQula.Enabled = false;
            CLSSpAll proc = new CLSSpAll(paCalcQvariQula, true);
            DataTable dt = proc.Exceute();
            string strComm;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strComm = "UPDATE Gvari SET SumQula=" + Convert.ToDouble(dt.Rows[i]["Qula"]) + " WHERE IdGvari=" + dt.Rows[i]["IdGvari"].ToString();
                SQL_Local_Execute(strComm);
            }
            XtraMessageBox.Show("ქულების განახლება მორჩა");
            btnCalcQvariQula.Enabled = true;
        }

        private void btnUpdateLocalServer_Click(object sender, EventArgs e)
        {
            btnUpdateLocalServer.Enabled = false;
            DateTime updateDate;
            DataTable dtParams;
            try
            {
                dtParams = SelectFromLocal("SELECT ISNULL(MAX(UpdateData),'1/1/2015') UpdateData FROM UpdateLocalServer ");
            }
            catch (Exception)
            {
                SelectFromLocal("SELECT ISNULL(MAX(UpdateData),'1/1/2015') UpdateData FROM UpdateLocalServer ");
                throw;
            }
           

            if (dtParams.Rows.Count > 0)
            {
                updateDate = Convert.ToDateTime(dtParams.Rows[0]["UpdateData"].ToString());
                try
                {
                    string Table_Name = "Prod";
                    update_Local_Table(Table_Name, updateDate, true, false);
                    Table_Name = "Disc1";
                    update_Local_Table(Table_Name, updateDate, false, true);
                    Table_Name = "Disc2";
                    update_Local_Table(Table_Name, updateDate, false, true);
                    Table_Name = "Momc";
                    update_Local_Table(Table_Name, updateDate, true, false);
                    Table_Name = "ProdMomc";
                    update_Local_Table(Table_Name, updateDate, true, false);
                    Table_Name = "Gvari";
                    update_Local_Table(Table_Name, updateDate, false, false);
                    Table_Name = "ProdG";
                    update_Local_Table(Table_Name, updateDate, true, false);
                    Table_Name = "Mdz";
                    update_Local_Table(Table_Name, updateDate, false, false);
                    Table_Name = "ProdS";
                    update_Local_Table(Table_Name, updateDate, true, false);
                    Table_Name = "ProdT";
                    update_Local_Table(Table_Name, updateDate, true, false);
                    Table_Name = "RealT";
                    update_Local_Table(Table_Name, updateDate, true, false);
                    Table_Name = "Salaro";
                    update_Local_Table(Table_Name, updateDate, true, false);
                    Table_Name = "DabrT";
                    update_Local_Table(Table_Name, updateDate, true, false);
                    Table_Name = "ShesT";
                    update_Local_Table(Table_Name, updateDate, true, false);
                    Table_Name = "SalT";
                    update_Local_Table(Table_Name, updateDate, true, false);
                    Table_Name = "GadT";
                    update_Local_Table(Table_Name, updateDate, true, false);
                    Table_Name = "MDabrT";
                    update_Local_Table(Table_Name, updateDate, true, false);
                    Table_Name = "MDabrT";
                    update_Local_Table(Table_Name, updateDate, true, false);
                    Table_Name = "Proek";
                    update_Local_Table(Table_Name, updateDate, true, false);
                    Table_Name = "ProekSalaro";
                    update_Local_Table(Table_Name, updateDate, true, false);
                    Table_Name = "ProdBarCode";
                    update_Local_Table(Table_Name, updateDate, true, false);
                    Table_Name = "ProekProd";
                    update_Local_Table(Table_Name, updateDate, true, false);
                    Table_Name = "Tanam";
                    update_Local_Table(Table_Name, updateDate, true, false);

                    Table_Name = "Company";
                    update_Local_Table(Table_Name, updateDate, false, true);
                    Table_Name = "Users";
                    update_Local_Table(Table_Name, updateDate, false, true);
                    var idUpdate = SelectFromLocal("INSERT INTO UpdateLocalServer(UpdateData,Finished) VALUES(GETDATE(),0); SELECT SCOPE_IDENTITY() IDD ").Rows[0]["IDD"];
                    MessageBox.Show("განახლება წარმატებით დასრულდა");
                }
                catch (Exception)
                {

                    MessageBox.Show("განახლება ვერ დასრულდა");
                    return;
                }




            }
            else
            {
                MessageBox.Show("განახლება ვერ დასრულდა");
                return;
            }
            btnUpdateLocalServer.Enabled = true;
        }
        private void update_Local_Table(string Table_Name, DateTime updateDate, bool Check_Date, bool hasIdentity)
        {
            DataTable dtStrcuter = SQL.Select("SELECT 1 As IDD, '' Field_Name, '' Field_Type FROM Prod WHERE 1=2");
            DataTable dtGlobalTable = Check_Date ? SQL.Select("SELECT * FROM " + Table_Name + " WHERE DATEADD(hh,1,CD)>'" + updateDate + "'") : SQL.Select("SELECT * FROM " + Table_Name);
            DataTable dtGTS = SQL.Select(" SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME =N'" + Table_Name + "' ");
            DataTable dtLocalTable = SelectFromLocal("SELECT * FROM " + Table_Name);
            DataTable dtGTL = SelectFromLocal(" SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME =N'" + Table_Name + "' ");
            if (dtGTS.Rows.Count > 0 && dtGTL.Rows.Count > 0)
            {
                int k = 0;
                for (int i = 0; i < dtGTS.Rows.Count; i++)
                {
                    string COLUMN_NAME = dtGTS.Rows[i]["COLUMN_NAME"].ToString();
                    if (COLUMN_NAME != "Id" + Table_Name)
                    {
                        for (int j = 0; j < dtGTL.Rows.Count; j++)
                        {
                            if (COLUMN_NAME == dtGTL.Rows[j]["COLUMN_NAME"].ToString())
                            {
                                DataRow dr = dtStrcuter.NewRow();
                                dr["IDD"] = k;
                                dr["Field_Name"] = dtGTL.Rows[j]["COLUMN_NAME"].ToString();
                                dr["Field_Type"] = dtGTL.Rows[j]["DATA_TYPE"].ToString();
                                dtStrcuter.Rows.Add(dr);
                                k += 1;
                                break;
                            }
                        }
                    }


                }
            }
            string strCommInsert = hasIdentity ? "SET IDENTITY_INSERT " + Table_Name + " ON INSERT INTO " + Table_Name + "(Id" + Table_Name + ", " : " INSERT  INTO " + Table_Name + "(Id" + Table_Name + ", ";
            for (int i = 0; i < dtStrcuter.Rows.Count; i++)
            {
                strCommInsert += dtStrcuter.Rows[i]["Field_Name"].ToString() + ", ";

            }
            strCommInsert = strCommInsert.Remove(strCommInsert.Length - 2, 2) + ") VALUES( ";
            for (int i = 0; i < dtGlobalTable.Rows.Count; i++)
            {
                string idd = dtGlobalTable.Rows[i]["Id" + Table_Name].ToString();
               
                string strComm;
                DataRow[] rows = dtLocalTable.Select(" Id" + Table_Name + "='" + idd + "'");
                if (rows.Length > 0)
                {
                    strComm = " UPDATE " + Table_Name + " SET ";
                    for (int j = 0; j < dtStrcuter.Rows.Count; j++)
                    {
                        strComm += dtStrcuter.Rows[j]["Field_Name"].ToString() + "=N'" + dtGlobalTable.Rows[i][dtStrcuter.Rows[j]["Field_Name"].ToString()].ToString() + "' , ";
                    }
                    strComm = hasIdentity ? strComm.Remove(strComm.Length - 2, 2) + " WHERE Id" + Table_Name + "=N'" + idd + "' SET IDENTITY_INSERT " + Table_Name + " OFF" : strComm.Remove(strComm.Length - 2, 2) + " WHERE Id" + Table_Name + "=N'" + idd + "'";
                    SQL_Local_Execute(strComm);
                }
                else
                {
                    strComm = strCommInsert +"N'"+ idd + "', ";
                    for (int j = 0; j < dtStrcuter.Rows.Count; j++)
                    {
                        strComm += "N'" +
                                   dtGlobalTable.Rows[i][dtStrcuter.Rows[j]["Field_Name"].ToString()].ToString() +
                                   "', ";
                    }
                    strComm = strComm.Remove(strComm.Length - 2, 2) + ") ";
                    SQL_Local_Execute(strComm);
                }
            }
            //            for (int i = 0; i < dtLocalTable.Rows.Count; i++)
            //            {
            //                string idd = dtLocalTable.Rows[i]["Id" + Table_Name].ToString();
            //                if (SQL.Select("SELECT * FROM " + Table_Name + " WHERE Id" + Table_Name + "=N'" + idd + "'").Rows.Count == 0)
            //                {
            //                    SQL_Local_Execute("DELETE FROM " + Table_Name + " WHERE Id" + Table_Name + "=N'" + idd + "'");
            //                }
            //            }
        }

        private bool ExportReal()
        {
            //TODO es suxos aqvs gasaketebeli
            var dtReal1 = SelectFromLocal(" SELECT * From Real1 WHERE Exported=0 ");
            var dtReal2 = SelectFromLocal(" SELECT * From Real2 WHERE IdReal1 IN(SELECT IdReal1 FROM Real1 WHERE Exported=0 )");
            var dtSal = SelectFromLocal(" SELECT * From Sal WHERE Zedd IN(SELECT Zedd FROM Real1 WHERE Exported=0 )");
            if (dtReal1.Rows.Count == 0)
            {

                return false;
            }

            //            var server = serverNames[0].Split(':');
            //            serverName = server[0];
            //            if (!TServerConnect(serverName))
            //            {
            //                MessageBox.Show("ვერ ხერხდება გლობალურ სერვერთან დაკავშირება");
            //                return true;
            //            }
            var strCommReal11 = "INSERT INTO Real1(";
            var strCommReal21 = "INSERT INTO Real2(";
            var strCommSal1 = "INSERT INTO Sal(";

            for (var i = 0; i < dtReal1.Columns.Count; i++)
            {
                if (dtReal1.Columns[i].ColumnName != "IdReal1" && dtReal1.Columns[i].ColumnName != "OldLocalZedd" &&
                    dtReal1.Columns[i].ColumnName != "ServerIdReal1")
                    strCommReal11 += dtReal1.Columns[i].ColumnName + ", ";
            }
            strCommReal11 = strCommReal11.Remove(strCommReal11.Length - 2, 2) + ") ";
            for (var i = 0; i < dtReal2.Columns.Count; i++)
            {
                if (dtReal2.Columns[i].ColumnName != "IdReal2" && dtReal2.Columns[i].ColumnName != "Fasi")
                    strCommReal21 += dtReal2.Columns[i].ColumnName + ", ";
            }
            strCommReal21 = strCommReal21.Remove(strCommReal21.Length - 2, 2) + ") ";

            for (var i = 0; i < dtSal.Columns.Count; i++)
            {
                if (dtSal.Columns[i].ColumnName != "IdSal")
                    strCommSal1 += dtSal.Columns[i].ColumnName + ", ";
            }
            strCommSal1 = strCommSal1.Remove(strCommSal1.Length - 2, 2) + ") ";

            for (var i = 0; i < dtReal1.Rows.Count; i++)
            {
                var strCommReal12 = "Values(";

                var localZedd = dtReal1.Rows[i]["Zedd"].ToString();
                var globalZedd = SQLOperation.CalcZeddNum("Real1");
                var idWayBill = dtReal1.Rows[i]["IdWayBillStatus"].ToString();
                var localIdReal1 = dtReal1.Rows[i]["IdReal1"].ToString();
                for (var j = 0; j < dtReal1.Columns.Count; j++)
                {
                    if (dtReal1.Columns[j].ColumnName == "IdReal1" || dtReal1.Columns[j].ColumnName == "OldLocalZedd" || dtReal1.Columns[j].ColumnName == "ServerIdReal1") continue;

                    if (dtReal1.Columns[j].DataType == typeof(DateTime))
                    {
                        if (dtReal1.Columns[j].Caption == "Data")
                            strCommReal12 += "N'" + Convert.ToDateTime(dtReal1.Rows[i][dtReal1.Columns[j].ColumnName]).ToString("M/d/yyyy 00:00") + "', ";
                        else
                            strCommReal12 += "N'" + Convert.ToDateTime(dtReal1.Rows[i][dtReal1.Columns[j].ColumnName]).ToString("M/d/yyyy H:mm.ss") + "', ";
                    }
                    else
                        switch (dtReal1.Columns[j].ColumnName)
                        {
                            case "Zedd":
                                if (idWayBill == "-1")
                                    strCommReal12 += "N'" + globalZedd + "', ";
                                else
                                    strCommReal12 += "N'" + dtReal1.Rows[i][dtReal1.Columns[j].ColumnName] + "', ";
                                break;
                            case "OldLocalZedd":
                                if (idWayBill == "-1")
                                    strCommReal12 += "N'" + localZedd + "', ";
                                else
                                    strCommReal12 += "N'" + dtReal1.Rows[i][dtReal1.Columns[j].ColumnName] + "', ";
                                break;
                            case "ServerIdReal1":
                                strCommReal12 += "N'" + dtReal1.Rows[i]["IdReal1"] + "', ";
                                break;
                            default:
                                strCommReal12 += "N'" + dtReal1.Rows[i][dtReal1.Columns[j].ColumnName] + "', ";
                                break;
                        }
                }
                strCommReal12 = strCommReal12.Remove(strCommReal12.Length - 2, 2) + ") ; SELECT SCOPE_IDENTITY()";
                int idReal1;
                try
                {
                    idReal1 = SQL.Insert(strCommReal11 + strCommReal12);
                    dtReal1.Rows[i]["ServerIdReal1"] = idReal1;
                    var drReal2 = dtReal2.Select("IdReal1=" + localIdReal1);

                    foreach (var row in drReal2)
                    {
                        var strCommReal22 = "Values(";

                        for (var j = 0; j < dtReal2.Columns.Count; j++)
                        {
                            if (dtReal2.Columns[j].ColumnName != "IdReal2" && dtReal2.Columns[j].ColumnName != "Fasi")
                            {
                                if (dtReal2.Columns[j].DataType == typeof(DateTime))

                                    if (dtReal1.Columns[j].Caption == "Data")
                                        strCommReal22 += "N'" +
                                                         Convert.ToDateTime(row[dtReal2.Columns[j].ColumnName])
                                                             .ToString("M/d/yyyy 00:00:00") + "', ";
                                    else

                                        strCommReal22 += "N'" +
                                                         Convert.ToDateTime(row[dtReal2.Columns[j].ColumnName])
                                                             .ToString("M/d/yyyy H:mm:ss") + "', ";
                                else if (dtReal2.Columns[j].ColumnName == "IdReal1")
                                    strCommReal22 += "N'" + idReal1 + "', ";
                                else
                                    strCommReal22 += "N'" + row[dtReal2.Columns[j].ColumnName] + "', ";
                            }
                        }
                        strCommReal22 = strCommReal22.Remove(strCommReal22.Length - 2, 2) + ") ";
                        try
                        {
                            SQL.Execute(strCommReal21 + strCommReal22);
                        }
                        catch
                        {
                            throw;
                        }
                    }

                    var drSal = dtSal.Select("Zedd='" + localZedd + "'");
                    foreach (var row in drSal)
                    {
                        var strCommSal2 = "Values(";
                        for (var j = 0; j < dtSal.Columns.Count; j++)
                        {
                            if (dtSal.Columns[j].ColumnName != "IdSal")
                            {
                                if (dtSal.Columns[j].DataType == typeof(DateTime))
                                    if (dtReal1.Columns[j].Caption == "Data")

                                        strCommSal2 += "N'" +
                                                       Convert.ToDateTime(row[dtSal.Columns[j].ColumnName])
                                                           .ToString("M/d/yyyy 00:00") + "', ";
                                    else
                                        strCommSal2 += "N'" +
                                                       Convert.ToDateTime(row[dtSal.Columns[j].ColumnName])
                                                           .ToString("M/d/yyyy H:m:ss") + "', ";
                                else if (dtSal.Columns[j].ColumnName == "Zedd")
                                {
                                    strCommSal2 += "N'" + globalZedd + "', ";
                                }
                                else
                                    strCommSal2 += "N'" + row[dtSal.Columns[j].ColumnName] + "', ";
                            }
                        }
                        strCommSal2 = strCommSal2.Remove(strCommSal2.Length - 2, 2) + ") ";
                        try
                        {
                            SQL.Execute(strCommSal1 + strCommSal2);
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                catch
                {
                    throw;
                }
                if (idReal1 > 0)
                {
                    SQL_Local_Execute(
                        "Update Real1 SET Finished=1, ServerIdReal1=" + idReal1 + ",Exported=1 WHERE IdReal1=" + localIdReal1);
                    dtReal1.Rows[i]["Exported"] = 1;
                }
            }
            //            var values = " UPDATE Real1 SET Exported=1 WHERE IdReal1 IN (";
            //            for (var i = 0; i < dtReal1.Rows.Count; i++)
            //            {
            //                if (Convert.ToBoolean(dtReal1.Rows[i]["Exported"].ToString()))
            //                    values += dtReal1.Rows[i]["IdReal1"] + ", ";
            //            }
            //            values = values.Remove(values.Length - 2, 2) + ") ";
            //            
            //            SQL_Local_Execute(values);
            return true;
        }

        private bool ExportDabr()
        {
            //TODO es suxos aqvs gasaketebeli
            var dtDabr1 = SelectFromLocal(" SELECT * From Dabr1 WHERE Exported=0 ");
            var dtDabr2 = SelectFromLocal(" SELECT * From Dabr2 WHERE IdDabr1 IN(SELECT IdDabr1 FROM Dabr1 WHERE Exported=0 )");
            var dtSal = SelectFromLocal(" SELECT * From Sal WHERE Zedd IN (SELECT Zedd FROM Dabr1 WHERE Exported=0 )");
            if (dtDabr1.Rows.Count == 0)
            {
                //                GlobalParameters.cn = GlobalParameters.cnG;
                return false;
            }

            //            var server = serverNames[0].Split(':');
            //            serverName = server[0];
            //            if (!TServerConnect(serverName))
            //            {
            //                MessageBox.Show("ვერ ხერხდება გლობალურ სერვერთან დაკავშირება");
            //                return true;
            //            }
            var strCommDabr11 = "INSERT INTO Dabr1(";
            var strCommDabr21 = "INSERT INTO Dabr2(";
            var strCommSal1 = "INSERT INTO Sal(";

            for (var i = 0; i < dtDabr1.Columns.Count; i++)
            {
                if (dtDabr1.Columns[i].ColumnName != "IdDabr1" && dtDabr1.Columns[i].ColumnName != "OldLocalZedd" &&
                    dtDabr1.Columns[i].ColumnName != "ServerIdDabr1")
                    strCommDabr11 += dtDabr1.Columns[i].ColumnName + ", ";
            }
            strCommDabr11 = strCommDabr11.Remove(strCommDabr11.Length - 2, 2) + ") ";
            for (var i = 0; i < dtDabr2.Columns.Count; i++)
            {
                if (dtDabr2.Columns[i].ColumnName != "IdDabr2" && dtDabr2.Columns[i].ColumnName != "Fasi")
                    strCommDabr21 += dtDabr2.Columns[i].ColumnName + ", ";
            }
            strCommDabr21 = strCommDabr21.Remove(strCommDabr21.Length - 2, 2) + ") ";

            for (var i = 0; i < dtSal.Columns.Count; i++)
            {
                if (dtSal.Columns[i].ColumnName != "IdSal")
                    strCommSal1 += dtSal.Columns[i].ColumnName + ", ";
            }
            strCommSal1 = strCommSal1.Remove(strCommSal1.Length - 2, 2) + ") ";

            for (var i = 0; i < dtDabr1.Rows.Count; i++)
            {
                var strCommDabr12 = "Values(";

                var localZedd = dtDabr1.Rows[i]["Zedd"].ToString();
                var globalZedd = SQLOperation.CalcZeddNum("Dabr1");
                var localIdDabr1 = dtDabr1.Rows[i]["IdDabr1"].ToString();
                for (var j = 0; j < dtDabr1.Columns.Count; j++)
                {
                    if (dtDabr1.Columns[j].ColumnName != "IdDabr1" && dtDabr1.Columns[j].ColumnName != "OldLocalZedd" &&
                        dtDabr1.Columns[j].ColumnName != "ServerIdDabr1")
                    {
                        switch (dtDabr1.Columns[j].ColumnName)
                        {
                            case "Zedd":
                                strCommDabr12 += "N'" + globalZedd + "', ";
                                break;
                            case "OldLocalZedd":
                                strCommDabr12 += "N'" + localZedd + "', ";
                                break;
                            case "ServerIdDabr1":
                                strCommDabr12 += "N'" + dtDabr1.Rows[i]["IdDabr1"] + "', ";
                                break;
                            default:
                                strCommDabr12 += "N'" + dtDabr1.Rows[i][dtDabr1.Columns[j].ColumnName] + "', ";
                                break;
                        }
                    }
                }
                strCommDabr12 = strCommDabr12.Remove(strCommDabr12.Length - 2, 2) + ") ; SELECT SCOPE_IDENTITY()";
                int idDabr1;
                try
                {
                    idDabr1 = SQL.Insert(strCommDabr11 + strCommDabr12);
                    dtDabr1.Rows[i]["ServerIdDabr1"] = idDabr1;
                    var drDabr2 = dtDabr2.Select("IdDabr1=" + localIdDabr1);

                    foreach (var row in drDabr2)
                    {
                        var strCommDabr22 = "Values(";

                        for (var j = 0; j < dtDabr2.Columns.Count; j++)
                        {
                            if (dtDabr2.Columns[j].ColumnName != "IdDabr2" && dtDabr2.Columns[j].ColumnName != "Fasi")
                            {
                                if (dtDabr2.Columns[j].ColumnName == "IdDabr1")
                                    strCommDabr22 += "N'" + idDabr1 + "', ";
                                else
                                    strCommDabr22 += "N'" + row[dtDabr2.Columns[j].ColumnName] + "', ";
                            }
                        }
                        strCommDabr22 = strCommDabr22.Remove(strCommDabr22.Length - 2, 2) + ") ";
                        try
                        {
                            SQL.Execute(strCommDabr21 + strCommDabr22);
                        }
                        catch
                        {
                            throw;
                        }
                    }

                    var drSal = dtSal.Select("Zedd='" + localZedd + "'");
                    foreach (var row in drSal)
                    {
                        var strCommSal2 = "Values(";
                        for (var j = 0; j < dtSal.Columns.Count; j++)
                        {
                            if (dtSal.Columns[j].ColumnName != "IdSal")
                            {
                                if (dtSal.Columns[j].ColumnName == "Zedd")
                                {
                                    strCommSal2 += "N'" + globalZedd + "', ";
                                }
                                else
                                    strCommSal2 += "N'" + row[dtSal.Columns[j].ColumnName] + "', ";
                            }
                        }
                        strCommSal2 = strCommSal2.Remove(strCommSal2.Length - 2, 2) + ") ";
                        try
                        {
                            SQL.Execute(strCommSal1 + strCommSal2);
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                catch
                {
                    throw;
                }
                if (idDabr1 > 0)
                {
                    SQL_Local_Execute("Update Dabr1 SET Finished=1, ServerIdDabr1=" + idDabr1 + " WHERE IdDabr1=" + localIdDabr1);
                    dtDabr1.Rows[i]["Exported"] = 1;
                }
            }
            var values = " UPDATE Dabr1 SET Exported=1 WHERE IdDabr1 IN (";
            for (var i = 0; i < dtDabr1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dtDabr1.Rows[i]["Exported"].ToString()))
                    values += dtDabr1.Rows[i]["IdDabr1"] + ", ";
            }
            values = values.Remove(values.Length - 2, 2) + ") ";

            SQL_Local_Execute(values);
            return true;
        }
        private bool ExportRealDel()
        {
            var dtRealDel = SelectFromLocal(" SELECT * From RealDel WHERE Exported=0 ");
            if (dtRealDel.Rows.Count == 0)
            {
                return false;
            }

            var strCommRealDel="";

        

            for (var i = 0; i < dtRealDel.Rows.Count; i++)
            {
                int idRealDel;
                strCommRealDel = "INSERT INTO RealDel(Data,IdGvari,IdProek,IdProd,Raod,Fasi,Tanxa,UN,CD,CardUser,Cardnumber,StandardFasi,LocalIdRealDel) VALUES(";
                var localIdRealDel = dtRealDel.Rows[i]["IdRealDel"].ToString();
                for (var j = 0; j < dtRealDel.Columns.Count; j++)
                {
                    if (dtRealDel.Columns[j].ColumnName != "IdRealDel" & dtRealDel.Columns[j].ColumnName != "Exported")
                    {
                        strCommRealDel += "N'" + dtRealDel.Rows[i][dtRealDel.Columns[j].ColumnName] + "', ";
                    }
                }
                strCommRealDel += "N'" + dtRealDel.Rows[i]["IdRealDel"] + "', ";
                try
                {
                    strCommRealDel = strCommRealDel.Remove(strCommRealDel.Length - 2, 2) + ") ; SELECT SCOPE_IDENTITY() AS IDD ";
                    idRealDel = SQL.Insert(strCommRealDel);

                }
                catch
                {
                    throw;
                }
                if (idRealDel > 0)
                {
                    dtRealDel.Rows[i]["Exported"] = 1;
                }
            }
            var values = " UPDATE RealDel SET Exported=1 WHERE IdRealDel IN (";
            for (var i = 0; i < dtRealDel.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dtRealDel.Rows[i]["Exported"].ToString()))
                    values += dtRealDel.Rows[i]["IdRealDel"] + ", ";
            }
            values = values.Remove(values.Length - 2, 2) + ") ";
            SQL_Local_Execute(values);
            return true;
        }
        private void btnGeneratePreProekNashti_Click(object sender, EventArgs e)
        {
            btnGeneratePreProekNashti.Enabled = false;
            DateTime d = Convert.ToDateTime(DateTime.Now.ToShortDateString()).AddDays(-1);
            string strComm =
                " DELETE FROM PreProekNashti2 WHERE IdPreProekNashti IN (SELECT IdPreProekNashti FROM PreProekNashti WHERE IdProek>0 AND IdProek NOT IN (SELECT IdProek FROM Proek WHERE CalcProekNashti=1)) ";
            SQL.Execute(strComm);
            strComm =
                " DELETE FROM PreProekNashti WHERE IdPreProekNashti IN (SELECT IdPreProekNashti FROM PreProekNashti WHERE IdProek>0 AND IdProek NOT IN (SELECT IdProek FROM Proek WHERE CalcProekNashti=1 )) ";
            SQL.Execute(strComm);
            strComm =
                " INSERT INTO PreProekNashti(IdProek,Finished,CD) SELECT IdProek,0,GETDATE() FROM Proek WHERE CalcProekNashti=1 AND IdProek NOT IN (SELECT IdProek FROM PreProekNashti)";
            SQL.Execute(strComm);
            DataTable dtProek = SQL.Select("SELECT * FROM Proek INNER JOIN PreProekNashti ON Proek.IdProek=PreProekNashti.IdProek WHERE CalcProekNashti=1");
            for (int i = 0; i < dtProek.Rows.Count; i++)
            {
                CLSSpAll proc = new CLSSpAll("spCalcProekNashti");
                SqlParameter param = new SqlParameter("D2", SqlDbType.SmallDateTime);
                param.Direction = ParameterDirection.Input;
                param.Value = d.AddDays(-1);
                proc.Comm.Parameters.Add(param);
                param = new SqlParameter("IdProek", SqlDbType.Int);
                param.Direction = ParameterDirection.Input;
                param.Value = dtProek.Rows[i]["IdProek"];
                proc.Comm.Parameters.Add(param);
                param = new SqlParameter("IdPreProekNashti", SqlDbType.Int);
                param.Direction = ParameterDirection.Input;
                param.Value = dtProek.Rows[i]["IdPreProekNashti"];
                proc.Comm.Parameters.Add(param);
                proc.Exceute();
                SQL.Execute(" UPDATE PreProekNashti SET Finished=1, CD=GETDATE() WHERE IdProek=" + dtProek.Rows[i]["IdProek"]);
            }


            XtraMessageBox.Show("ნაშთის განახლება მორჩა");
            btnGeneratePreProekNashti.Enabled = true;

        }

        private void btnImportPreNashti_Click(object sender, EventArgs e)
        {
            btnImportPreNashti.Enabled = false;
            DateTime d = Convert.ToDateTime(DateTime.Now.ToShortDateString()).AddDays(-1);
            DataTable dt = SQL.Select("SELECT * FROM PreProekNashti2 INNER JOIN PreProekNashti ON PreProekNashti2.IdPreProekNashti=PreProekNashti.IdPreProekNashti WHERE IdProek=" + DefaultValues.IdProek);
            DataTable dtLocal = SelectFromLocal("UPDATE LocalPreNashti SET Aris=0; SELECT * FROM LocalPreNashti ");
            string strComm;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow[] rows = dtLocal.Select("IdProd='" + dt.Rows[i]["IdProd"] + "'");
                if (rows.Length > 0)
                {
                    strComm = "UPDATE LocalPreNashti SET Data='" + d.ToShortDateString() + "',Raod=" + dt.Rows[i]["Raod"] + ",Aris=1 WHERE IdProd=N'" + dt.Rows[i]["IdProd"] + "'";
                    SQL_Local_Execute(strComm);
                }
                else
                {
                    strComm = "INSERT INTO LocalPreNashti(Data,IdProd,Raod,Aris) Values(";
                    strComm += "N'" + d.ToShortDateString() + "',";
                    strComm += "N'" + dt.Rows[i]["IdProd"] + "',";
                    strComm += "" + dt.Rows[i]["Raod"] + ",1)";
                    SQL_Local_Execute(strComm);
                }

            }
            SQL_Local_Execute("DELETE FROM LocalPreNashti WHERE Aris=0");
            XtraMessageBox.Show("ნაშთის განახლება მორჩა");
            btnImportPreNashti.Enabled = true;
        }

        private void btnExportToGlobalServer_Click(object sender, EventArgs e)
        {
            btnExportToGlobalServer.Enabled = false;
            ExportReal();
            ExportDabr();
            ExportRealDel();
            MessageBox.Show("ექსპორტი დასრულდა");
            btnExportToGlobalServer.Enabled = true;
        }

        private void btnDelFromLocal_Click(object sender, EventArgs e)
        {
            btnDelFromLocal.Enabled = false;
            string Table_Name = "Prod";
            Del_From_local(Table_Name);
            Table_Name = "Momc";
            Del_From_local(Table_Name);
            Table_Name = "ProdMomc";
            Del_From_local(Table_Name);
            Table_Name = "Gvari";
            Del_From_local(Table_Name);
            Table_Name = "ProdG";
            Del_From_local(Table_Name);
            Table_Name = "Mdz";
            Del_From_local(Table_Name);
            Table_Name = "ProdS";
            Del_From_local(Table_Name);
            Table_Name = "ProdT";
            Del_From_local(Table_Name);
            Table_Name = "RealT";
            Del_From_local(Table_Name);
            Table_Name = "Salaro";
            Del_From_local(Table_Name);
            Table_Name = "DabrT";
            Del_From_local(Table_Name);
            Table_Name = "ShesT";
            Del_From_local(Table_Name);
            Table_Name = "SalT";
            Del_From_local(Table_Name);
            Table_Name = "GadT";
            Del_From_local(Table_Name);
            Table_Name = "MDabrT";
            Del_From_local(Table_Name);
            Table_Name = "MDabrT";
            Del_From_local(Table_Name);
            Table_Name = "Proek";
            Del_From_local(Table_Name);
            Table_Name = "ProekSalaro";
            Del_From_local(Table_Name);
            Table_Name = "ProdBarCode";
            Del_From_local(Table_Name);
            Table_Name = "ProekProd";
            Del_From_local(Table_Name);
            Table_Name = "Tanam";
            Del_From_local(Table_Name);
            MessageBox.Show("წაშლა წარმატებით დასრულდა");
            btnDelFromLocal.Enabled = true;
        }

        private void Del_From_local(string Table_Name)
        {
            DataTable dtGlobalTable = SQL.Select("SELECT * FROM " + Table_Name);
            DataTable dtLocalTable = SelectFromLocal("SELECT *, 1 Aris FROM " + Table_Name);

            for (int i = 0; i < dtLocalTable.Rows.Count; i++)
            {
                string idd = dtLocalTable.Rows[i]["Id" + Table_Name].ToString();
                if (dtGlobalTable.Select("  Id" + Table_Name + "='" + idd + "'").Length == 0)
                {
                    dtLocalTable.Rows[i]["Aris"] = 0;
                }
            }
            DataRow[] rows = dtLocalTable.Select(" Aris=0 ");
            foreach (var dr in rows)
            {
                SQL_Local_Execute("DELETE FROM " + Table_Name + " WHERE Id" + Table_Name + "=N'" + dr["Id" + Table_Name].ToString() + "' ");
            }
        }
















    }
}