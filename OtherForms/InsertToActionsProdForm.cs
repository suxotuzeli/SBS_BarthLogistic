using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class InsertToActionsProdForm : XtraForm
    {
        private string idActions;
        public InsertToActionsProdForm(string idActions)
        {
            this.idActions = idActions;
            InitializeComponent();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        string SetWhereClause()
        {
            var strComm = " WHERE (1 = 1) ";
            if (fmgProdT.Checked)
                strComm += " AND IdProdT = " + fmgProdT.GetId();
            if (fmgProdS.Checked)
                strComm += " AND IdProdS = " + fmgProdS.GetId();
            if (fmgProdG.Checked)
                strComm += " AND IdProdG = " + fmgProdG.GetId();
            return strComm;
        }

        void btnOK_Click(object sender, EventArgs e)
        {

            var strComm = "INSERT INTO ActionsProd(IdActions,IdProd,ActionsFasi,UN,CD) " ;
            strComm += "SELECT N'" + idActions + "', IdProd,0,N'" + GlobalParameters.UserName+"', GETDATE() ";
            strComm += " FROM Prod ";
            strComm += SetWhereClause() + " AND IdProd NOT IN (SELECT IdProd FROM ActionsProd WHERE IdActions=N'"+idActions+"')";

            SQL.Execute(strComm);

            Close();
        }

        static double Ricxvi(int dabrgvalebaCifri)
        {
            switch (dabrgvalebaCifri)
            {
                case -3:
                    return 0.001;
                case -2:
                    return 0.01;
                case -1:
                    return 0.1;
                case 1:
                    return 10;
                case 2:
                    return 100;
                case 3:
                    return 1000;
                default:
                    return 1;
            }
        }


        void InsertToActionsProdForm_Load(object sender, EventArgs e)
        {
            panel1.ChangeFonts();
        }

      
    }
}