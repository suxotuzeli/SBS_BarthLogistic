using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.InterfaceForms;
using SBS_BarthLogistic.Parameters;

namespace SBS_BarthLogistic.Tools
{
    public partial class FullDaxurvaForm : XtraForm
    {
        DateTime data2;
        int full;


        public FullDaxurvaForm()
        {
            InitializeComponent();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void FullDaxurvaForm_Load(object sender, EventArgs e)
        {
            laDge.Text = InterfaceParameters.Dge.ToShortDateString();
            data2 = InterfaceParameters.Dge.AddDays(5);
            txtData1.DateTime = data2;
            Refresher();
        }

        void Refresher()
        {
            laDasaxuri.Text = Math.Round(data2.Subtract(InterfaceParameters.Dge).TotalDays).ToString();
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            
            full = Convert.ToInt16(laDasaxuri.Text);
            bool tato = false;
            for (var iii = 0; iii < full; iii++)
            {
                if (full - Math.Round(data2.Subtract(InterfaceParameters.Dge).TotalDays) > iii)iii = full - Convert.ToInt16(Math.Round(data2.Subtract(InterfaceParameters.Dge).TotalDays));

                DateTime lday = Convert.ToDateTime( ProceduresClass.spSetDge());
                InterfaceParameters.Dge = InterfaceParameters.Dge > lday ? lday : InterfaceParameters.Dge;
                
                    SQL.Delete("Truncate Table NashtiDge");
                    SQL.Delete("Truncate Table NashtiDgeCarm");
                    var dt1 = ProceduresClass.spDgeDaxurva("spInsertToNashtiDge", InterfaceParameters.Dge);
                    if (dt1.Rows.Count == 0)
                    {
                        XtraMessageBox.Show("ვერ ხერხდება დღის დახურვა");
                        return;
                    }
                    var d = Convert.ToDateTime(dt1.Rows[0]["Data"].ToString()).AddDays(1);
                    var count = 0;
                    bool result;
                    while (true)
                    {
                        result = true;
                        StringBuilder str = new StringBuilder();str.Append("SELECT * FROM dbo.Carm1 ");
                        str.Append("WHERE Data = '" + d + "' AND CarmRaod>0 AND dbo.Carm1.CarmTanxa = 0 AND IdCarm1 NOT IN (SELECT Carm2.IdCarm1 FROM dbo.Carm2 INNER JOIN Carm1 ON Carm1.IdCarm1=Carm2.IdCarm1 INNER JOIN Carm1 C ON  Carm2.IdProd=C.IdProd AND Carm1.Data=C.Data WHERE Carm1.Data='" + d + "' AND C.CarmRaod>0 AND C.CarmTanxa=0) ");
                        //                str.Append("SELECT * FROM dbo.Carm1 ");
                        //                str.Append("WHERE Data = '" + d + "' AND CarmRaod>0 AND IdCarm1 NOT IN (SELECT IdCarm1 FROM dbo.Carm2  ");
                        //                str.Append(
                        ////                    "WHERE IdProd NOT IN (SELECT IdProd FROM dbo.NashtiDge) )  AND dbo.Carm1.CarmTanxa = 0");
                        //                    "WHERE IdProd NOT IN (SELECT IdProd FROM dbo.NashtiDge) AND dbo.Carm2.IdProd NOT IN (SELECT IdProd FROM dbo.NashtiDgeCarm))  AND dbo.Carm1.CarmTanxa = 0");
                        DataTable dtCarm = SQL.Select(str.ToString());
                        if (dtCarm.Rows.Count == 0)
                            break;
                        for (int i = 0; i < dtCarm.Rows.Count; i++)
                        {

                            string idCarm1 = dtCarm.Rows[i]["IdCarm1"].ToString();


                            string idProd = dtCarm.Rows[i]["IdProd"].ToString();
                            string txtComm =
                                "UPDATE Carm1 SET CarmTanxa = dbo.udfCalcCarmTotalTvitg(idCarm1) WHERE IdCarm1 = " +
                                idCarm1;
                            SQL.Update(txtComm);

                            DataTable dtCarmProd =
                                SQL.Select("SELECT IdProd FROM NashtiDge WHERE IdProd = N'" + idProd + "'");
                            if (dtCarmProd.Rows.Count == 0)
                            {
                                StringBuilder str1 = new StringBuilder();
                                str1.Append("INSERT INTO dbo.NashtiDge ( IdProd, Raod, Tanxa, Fasi ) ");
                                str1.Append("SELECT IdProd, CarmRaod, CarmTanxa, CarmTanxa / CarmRaod ");
                                str1.Append("FROM dbo.Carm1 ");
                                str1.Append("WHERE IdCarm1 = " + idCarm1);
                                SQL.Insert(str1.ToString());
                            }
                            else
                            {
                                StringBuilder str1 = new StringBuilder();
                                str1.Append("UPDATE NashtiDge ");
                                str1.Append(
                                    "SET Raod = Raod + Carm1.CarmRaod, Tanxa = Tanxa + Carm1.CarmTanxa, Fasi = (Tanxa + Carm1.CarmTanxa) / (Raod + Carm1.CarmRaod) ");
                                str1.Append(
                                    "FROM dbo.NashtiDge INNER JOIN dbo.Carm1 ON dbo.NashtiDge.IdProd = dbo.Carm1.IdProd ");
                                str1.Append("WHERE IdCarm1 = " + idCarm1);
                                SQL.Execute(str1.ToString());
                            }
                            StringBuilder str2 = new StringBuilder();
                            str2.Append("INSERT INTO dbo.NashtiDgeCarm ( IdProd, Raod, Tanxa, Fasi ) ");
                            str2.Append("SELECT IdProd, CarmRaod, CarmTanxa, CarmTanxa / CarmRaod ");
                            str2.Append("FROM dbo.Carm1 ");
                            str2.Append("WHERE IdCarm1 = " + idCarm1);
                            SQL.Insert(str2.ToString());

                            StringBuilder str3 = new StringBuilder();

                        }
                        count++;
                        if (count == 8)
                        {
                            MessageBox.Show("ვერ ხერხდება წარმოების თვითღირებულების დათვლა.");
                            PTRowsForm fm = new PTRowsForm(dtCarm, new[] { "IdProd", "Raod" }, new[] { "პროდ.კოდი", "რაოდენობა" });
                            fm.ShowDialog();
                            fm.Dispose();
                            result = false;
                            break;
                            result = true;
                            //                          SQL.Execute("UPDATE Carm1 SET CarmTanxa=dbo.udfCalcCudiCarm(IdCarm1) WHERE Data='" + InterfaceParameters.Dge.ToShortDateString() + "' AND CarmTanxa=0 ");
                            break;
                        }

                    }

                    if (result)
                    {

                        var dt = ProceduresClass.spDgeDaxurva("spCalculateDge", InterfaceParameters.Dge);
                        if (dt.Rows.Count > 0)
                        {
                            var fm = new PTRowsForm(dt, new[]
                                {
                                    "IdProd", "Prod", "Raod"
                                },
                                new[]
                                {
                                    "პროდ.კოდი", "პროდუქცია", "რაოდენობა"
                                });
                            fm.ShowDialog();
                            fm.Dispose();
                            return;
                        }
                    }
                InterfaceParameters.Dge = InterfaceParameters.Dge.AddDays(1);
                Refresher();
            }

            Close();
        }

        void txtData1_ValueChanged(object sender, EventArgs e)
        {
            data2 = txtData1.DateTime;
            Refresher();
        }
    }
}