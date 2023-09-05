using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class SetProdFasiForm : XtraForm
    {
        public SetProdFasiForm()
        {
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
            string fasi;
            var expr = "(Fasi" + txtFasi2.Value +
                       " + ( " + txtTanxa.Value + " )) * (" + txtPercent.Value + ")";
            if (chbDamrgvaleba.Checked)
            {
                var ricxvi = Ricxvi((int)txtDabrgvalebaCifri.Value);
                fasi = "CASE WHEN 1.0 * CAST(" + expr + " * " + ricxvi + " AS INT) / " + ricxvi + " < " + expr +
                       " THEN  (1.0 * CAST(" + expr + " * " + ricxvi + " AS INT) + 1) / " + ricxvi + " ELSE " +
                       expr + " END";
            }
            else
                fasi = expr;
            var strComm = "UPDATE Prod SET Fasi" + txtFasi1.Value + " = " + fasi;
            strComm += SetWhereClause();

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


        void SetProdFasiForm_Load(object sender, EventArgs e)
        {
            panel1.ChangeFonts();
        }

        void chbDamrgvaleba_CheckedChanged(object sender, EventArgs e)
        {
            txtDabrgvalebaCifri.Visible = chbDamrgvaleba.Checked;
            if (chbDamrgvaleba.Checked)
                txtDabrgvalebaCifri.Focus();
        }
    }
}