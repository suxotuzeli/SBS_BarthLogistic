using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.Parameters
{
    class ProceduresClass
    {
        const int CommandTimeout = 5000;

        public static DataTable SpReturnGvaris(string strGvari)
        {
            var dt = new DataTable();
            if (strGvari.Length < OrgProdParameters.GvariSearchSymbolCount) return null;
            var s = OrgProdParameters.GvariSearchFromFirstSymbol ? "" : "%";

            s = s + strGvari + "%";
            var comm = new SqlCommand("spReturnGvaris", GlobalParameters.cn);

            comm.CommandType = CommandType.StoredProcedure;
            var paGvari = comm.Parameters.Add("@Gvari", SqlDbType.NVarChar, 50);
            paGvari.Value = s;
            try
            {
                GlobalParameters.cn.Open();
                var da = new SqlDataAdapter(comm);
                da.Fill(dt);
                return dt;
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
        }

        public static DataTable SpReturnProds(string strProd, string fg, int prodSearchType, string addWhere)
        {
            var dt = new DataTable();
            var s = OrgProdParameters.ProdSearchFromFirstSymbol ? "" : "%";

            s = s + strProd + "%";
            var comm = new SqlCommand("spReturnProds", GlobalParameters.cn);

            comm.CommandType = CommandType.StoredProcedure;
            var paProd = comm.Parameters.Add("@Prod", SqlDbType.NVarChar, 80);
            var paFg = comm.Parameters.Add("@FG", SqlDbType.Int);
            var paProdSearchType = comm.Parameters.Add("@ProdSearchType", SqlDbType.SmallInt);
            var paAddWhere = comm.Parameters.Add("@AddWhere", SqlDbType.NVarChar, 150);
            paProd.Value = s;
            paFg.Value = fg;
            paProdSearchType.Value = prodSearchType;
            paAddWhere.Value = addWhere;
            try
            {
                GlobalParameters.cn.Open();
                var da = new SqlDataAdapter(comm);
                da.Fill(dt);
                return dt;
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
        }

        public static bool SpParamsForUsers(string un, string procName)
        {
            var comm = new SqlCommand(procName, GlobalParameters.cn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@UN", SqlDbType.NVarChar, 20).Value = un;

            try
            {
                GlobalParameters.cn.Open();
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                var parametersCmd = string.Empty;
                foreach (SqlParameter parameter in comm.Parameters)
                    parametersCmd += parameter.ParameterName + " = " + parameter.SqlValue + ",\n";
                e.ShowErrorDialog("EXEC " + comm.CommandText + Environment.NewLine + parametersCmd);
                return false;
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
        }

        public static int spCheckGvariCode(string procName)
        {
            var idGvari = 0;
            var comm = new SqlCommand(procName, GlobalParameters.cn);
            comm.CommandType = CommandType.StoredProcedure;
            var paIdGvari = comm.Parameters.Add("@IdGvari", SqlDbType.Int);
            paIdGvari.Direction = ParameterDirection.Output;

            try
            {
                GlobalParameters.cn.Open();
                comm.ExecuteNonQuery();
                idGvari = (int)paIdGvari.Value;
            }
            catch (Exception e)
            {
                var parametersCmd = string.Empty;
                foreach (SqlParameter parameter in comm.Parameters)
                    parametersCmd += parameter.ParameterName + " = " + parameter.SqlValue + ",\n";
                e.ShowErrorDialog("EXEC " + comm.CommandText + Environment.NewLine + parametersCmd);
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
            return idGvari;
        }

        public static DataTable spMomcShekveta(string procName, DateTime d, int idProek, int idMomc, int idMomcShek1)
        {
            var dt = new DataTable();
            var comm = new SqlCommand(procName, GlobalParameters.cn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandTimeout = CommandTimeout;
            var paD1 = comm.Parameters.Add("@D", SqlDbType.SmallDateTime);
            var paIdProek = comm.Parameters.Add("@IdProek", SqlDbType.Int);
            var paIdMomc = comm.Parameters.Add("@IdMomc", SqlDbType.Int);
            var paIdMomcShek1 = comm.Parameters.Add("@IdMomcShek1", SqlDbType.Int);
            paD1.Value = d;
            paIdProek.Value = idProek;
            paIdMomc.Value = idMomc;
            paIdMomcShek1.Value = idMomcShek1;
            var da = new SqlDataAdapter(comm);
            try
            {
                GlobalParameters.cn.Open();
                da.Fill(dt);
            }
            catch (Exception e)
            {
                var parametersCmd = string.Empty;
                foreach (SqlParameter parameter in comm.Parameters)
                    parametersCmd += parameter.ParameterName + " = " + parameter.SqlValue + ",\n";
                e.ShowErrorDialog("EXEC " + comm.CommandText + Environment.NewLine + parametersCmd);
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
            return dt;
        }
        public static DataTable spShesShekveta(string procName, DateTime d, int idProek, int idMomc, int idShesShek1)
        {
            var dt = new DataTable();
            var comm = new SqlCommand(procName, GlobalParameters.cn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandTimeout = CommandTimeout;
            var paD1 = comm.Parameters.Add("@D", SqlDbType.SmallDateTime);
            var paIdProek = comm.Parameters.Add("@IdProek", SqlDbType.Int);
            var paIdMomc = comm.Parameters.Add("@IdMomc", SqlDbType.Int);
            var paIdShesShek1 = comm.Parameters.Add("@IdShesShek1", SqlDbType.Int);
            paD1.Value = d;
            paIdProek.Value = idProek;
            paIdMomc.Value = idMomc;
            paIdShesShek1.Value = idShesShek1;
            var da = new SqlDataAdapter(comm);
            try
            {
                GlobalParameters.cn.Open();
                da.Fill(dt);
            }
            catch (Exception e)
            {
                var parametersCmd = string.Empty;
                foreach (SqlParameter parameter in comm.Parameters)
                    parametersCmd += parameter.ParameterName + " = " + parameter.SqlValue + ",\n";
                e.ShowErrorDialog("EXEC " + comm.CommandText + Environment.NewLine + parametersCmd);
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
            return dt;
        }
        static public DataTable spCalcZeddValiViaZedd(string procName, string zedd)
        {
            DataTable dt = new DataTable();
            //            string ProcName = "spCalcZeddValiViaZedd";
            SqlCommand comm = new SqlCommand(procName, GlobalParameters.cn);
            comm.CommandType = CommandType.StoredProcedure;
            SqlParameter paZedd = comm.Parameters.Add("@Zedd", SqlDbType.NVarChar, 15);
            paZedd.Value = zedd;

            SqlDataAdapter da = new SqlDataAdapter(comm);
            try
            {
                GlobalParameters.cn.Open();
                da.Fill(dt);
            }
            catch (Exception e)
            {
                if (MessageBox.Show("ოპერაციის შესრულება შეუძლებელია, გამოვიტანოთ სისტემური შეტყობინება?", "შეცდომა", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    MessageBox.Show(e.ToString());
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
            return dt;
        }
        static public DataTable spCalcZeddVali(string procName, int idOrg)
        {
            DataTable dt = new DataTable();
            //            string ProcName = "spCalcZeddVali";
            SqlCommand comm = new SqlCommand(procName, GlobalParameters.cn);
            comm.CommandType = CommandType.StoredProcedure;
            SqlParameter paIdOrg = comm.Parameters.Add("@IdOrg", SqlDbType.Int);
            paIdOrg.Value = idOrg;

            SqlDataAdapter da = new SqlDataAdapter(comm);
            try
            {
                GlobalParameters.cn.Open();
                da.Fill(dt);
            }
            catch (Exception e)
            {
                if (MessageBox.Show("ოპერაციის შესრულება შეუძლებელია, გამოვიტანოთ სისტემური შეტყობინება?", "შეცდომა", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    MessageBox.Show(e.ToString());
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
            return dt;
        }
        public static DataTable spCheckNashtiAgcera(string procName, DateTime d, int idProek, bool onlyAgcera,
            int idProdS, int idMomc, int idProdT)
        {
            using (var dt = new DataTable())
            {
                using (var comm = new SqlCommand(procName, GlobalParameters.cn))
                {
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandTimeout = 5000;
                    var paD = comm.Parameters.Add("@D", SqlDbType.SmallDateTime);
                    var paIdProek = comm.Parameters.Add("@IdProek", SqlDbType.Int);
                    var paOnlyAgcera = comm.Parameters.Add("@OnlyAgcera", SqlDbType.Bit);
                    var paIdProdT = comm.Parameters.Add("@IdProdT", SqlDbType.Int);
                    var paIdProdS = comm.Parameters.Add("@IdProdS", SqlDbType.Int);
                    var paIdMomc = comm.Parameters.Add("@IdMomc", SqlDbType.Int);
                    paD.Value = d;
                    paIdProek.Value = idProek;
                    paOnlyAgcera.Value = onlyAgcera;
                    paIdProdS.Value = idProdS;
                    paIdProdT.Value = idProdT;
                    paIdMomc.Value = idMomc;
                    using (var da = new SqlDataAdapter(comm))
                    {
                        try
                        {
                            GlobalParameters.cn.Open();
                            da.Fill(dt);
                        }
                        catch (Exception e)
                        {
                            var parametersCmd = string.Empty;
                            foreach (SqlParameter parameter in comm.Parameters)
                                parametersCmd += parameter.ParameterName + " = " + parameter.SqlValue + ",\n";
                            e.ShowErrorDialog("EXEC " + comm.CommandText + Environment.NewLine + parametersCmd);
                        }
                        finally
                        {
                            GlobalParameters.cn.Close();
                        }
                    }
                }
                return dt;
            }
        }

        public static DataTable spGenerateSascori(string procName, int idProdT, int idProdS, string ert)
        {
            var dt = new DataTable();
            var comm = new SqlCommand(procName, GlobalParameters.cn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandTimeout = CommandTimeout;

            var paIdProdT = comm.Parameters.Add("@IdProdT", SqlDbType.Int);
            var paIdProdS = comm.Parameters.Add("@IdProdS", SqlDbType.Int);
            var paErt = comm.Parameters.Add("@Ert", SqlDbType.NVarChar, 40);

            paIdProdT.Value = idProdT;
            paIdProdS.Value = idProdS;
            paErt.Value = ert;

            var da = new SqlDataAdapter(comm);
            try
            {
                GlobalParameters.cn.Open();
                da.Fill(dt);
            }
            catch (Exception e)
            {
                var parametersCmd = string.Empty;
                foreach (SqlParameter parameter in comm.Parameters)
                    parametersCmd += parameter.ParameterName + " = " + parameter.SqlValue + ",\n";
                e.ShowErrorDialog("EXEC " + comm.CommandText + Environment.NewLine + parametersCmd);
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
            return dt;
        }

        public static string spSetDge()
        {
            var strDge = "";
            var comm = new SqlCommand("spSelectMaxDataFromNashtiNew", GlobalParameters.cn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandTimeout = CommandTimeout;
            var paData = comm.Parameters.Add("@Data", SqlDbType.SmallDateTime);
            paData.Direction = ParameterDirection.Output;
            try
            {
                GlobalParameters.cn.Open();
                comm.ExecuteNonQuery();
                var data = Convert.ToDateTime(paData.Value);
                strDge = data.Date.ToShortDateString();
                InterfaceParameters.Dge = Convert.ToDateTime(strDge);
            }
            catch (Exception e)
            {
                var parametersCmd = string.Empty;
                foreach (SqlParameter parameter in comm.Parameters)
                    parametersCmd += parameter.ParameterName + " = " + parameter.SqlValue + ",\n";
                e.ShowErrorDialog("EXEC " + comm.CommandText + Environment.NewLine + parametersCmd);
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
            return strDge;
        }

        public static void spDgeGaxsna(string procName, DateTime data)
        {
            var comm = new SqlCommand(procName, GlobalParameters.cn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandTimeout = CommandTimeout;
            var paData = comm.Parameters.Add("@D", SqlDbType.SmallDateTime);
            paData.Value = data;
            try
            {
                GlobalParameters.cn.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                var parametersCmd = string.Empty;
                foreach (SqlParameter parameter in comm.Parameters)
                    parametersCmd += parameter.ParameterName + " = " + parameter.SqlValue + ",\n";
                e.ShowErrorDialog("EXEC " + comm.CommandText + Environment.NewLine + parametersCmd);
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
        }

        public static DataTable spDgeDaxurva(string procName, DateTime data)
        {
            using (var dt = new DataTable())
            {
                using (var comm = new SqlCommand(procName, GlobalParameters.cn))
                {
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandTimeout = CommandTimeout;
                    var paData = comm.Parameters.Add("@D", SqlDbType.SmallDateTime);
                    var paCloseMinus = comm.Parameters.Add("@CloseMinus", SqlDbType.Bit);
                    paData.Value = data;
                    paCloseMinus.Value = InterfaceParameters.CloseMinus;
                    using (var da = new SqlDataAdapter(comm))
                    {
                        try
                        {
                            GlobalParameters.cn.Open();
                            da.Fill(dt);
                        }
                        catch (Exception e)
                        {
                            var parametersCmd = string.Empty;
                            foreach (SqlParameter parameter in comm.Parameters)
                                parametersCmd += parameter.ParameterName + " = " + parameter.SqlValue + ",\n";
                            e.ShowErrorDialog("EXEC " + comm.CommandText + Environment.NewLine + parametersCmd);
                        }
                        finally
                        {
                            GlobalParameters.cn.Close();
                        }
                    }
                }
                return dt;
            }
        }

        public static DataTable spCalcProdNashti(string procName, string idProd, int idProek, decimal startRaod,
            DateTime data)
        {
            using (var dt = new DataTable())
            {
                using (var comm = new SqlCommand(procName, GlobalParameters.cn))
                {
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandTimeout = CommandTimeout;
                    var paIdProd = comm.Parameters.Add("@IdProd", SqlDbType.NVarChar, 60);
                    var paIdProek = comm.Parameters.Add("@IdProek", SqlDbType.Int);
                    var paStartRaod = comm.Parameters.Add("@StartRaod", SqlDbType.Int);
                    var paData = comm.Parameters.Add("@Data", SqlDbType.DateTime);
                    paData.Value = data;
                    paIdProd.Value = idProd;
                    paIdProek.Value = idProek;
                    paStartRaod.Value = startRaod;
                    using (var da = new SqlDataAdapter(comm))
                    {
                        try
                        {
                            GlobalParameters.cn.Open();
                            da.Fill(dt);
                        }
                        catch (Exception e)
                        {
                            var parametersCmd = string.Empty;
                            foreach (SqlParameter parameter in comm.Parameters)
                                parametersCmd += parameter.ParameterName + " = " + parameter.SqlValue + ",\n";
                            e.ShowErrorDialog("EXEC " + comm.CommandText + Environment.NewLine + parametersCmd);
                        }
                        finally
                        {
                            GlobalParameters.cn.Close();
                        }
                    }
                }
                return dt;
            }
        }

        public static void spCalcShesTvitg(string procName, int idShes1)
        {
            using (var comm = new SqlCommand(procName, GlobalParameters.cn))
            {
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandTimeout = CommandTimeout;
                var paIdShes1 = comm.Parameters.Add("@IdShes1", SqlDbType.Int);
                paIdShes1.Value = idShes1;
                try
                {
                    GlobalParameters.cn.Open();
                    comm.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    var parametersCmd = string.Empty;
                    foreach (SqlParameter parameter in comm.Parameters)
                        parametersCmd += parameter.ParameterName + " = " + parameter.SqlValue + ",\n";
                    e.ShowErrorDialog("EXEC " + comm.CommandText + Environment.NewLine + parametersCmd);
                }
                finally
                {
                    GlobalParameters.cn.Close();
                }
            }
        }

        public static DataTable spCalcCarm(string procName, DateTime data)
        {
            using (var dt = new DataTable())
            {
                using (var comm = new SqlCommand(procName, GlobalParameters.cn))
                {
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@Data", data);
                    comm.Parameters.AddWithValue("@UN", GlobalParameters.UserName);
                    using (var da = new SqlDataAdapter(comm))
                    {
                        try
                        {
                            GlobalParameters.cn.Open();
                            da.Fill(dt);
                        }
                        catch (Exception e)
                        {
                            var parametersCmd = string.Empty;
                            foreach (SqlParameter parameter in comm.Parameters)
                                parametersCmd += parameter.ParameterName + " = " + parameter.SqlValue + ",\n";
                            e.ShowErrorDialog("EXEC " + comm.CommandText + Environment.NewLine + parametersCmd);
                        }
                        finally
                        {
                            GlobalParameters.cn.Close();
                        }
                    }
                }
                return dt;
            }
        }
    }
}