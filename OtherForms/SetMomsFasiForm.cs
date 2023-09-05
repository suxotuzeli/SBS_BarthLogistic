using System;
using System.Windows.Forms;
using SBS_Market.Classes;
using SBS_Market.Parameters;

namespace SBS_Market.OtherForms
{
    public partial class SetMomsFasiForm : Form
    {
        public SetMomsFasiForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string SetWhereClause()
        {
            string strComm = " WHERE (1 = 1) ";
            if (chbMomsT.Checked)
                strComm += " AND IdMomsT = " + cbMomsT.SelectedValue;
            if (chbMomsS.Checked)
                strComm += " AND IdMomsS = " + cbMomsS.SelectedValue;
            return strComm;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string fasi;
            string expr = "(Fasi" + txtFasi2.IntegerValue +
                          " + ( " + txtTanxa.DoubleValue + " )) * (" + txtPercent.DoubleValue + ")";
            if (chbDamrgvaleba.Checked) {
                double ricxvi = Ricxvi((int)txtDabrgvalebaCifri.IntegerValue);
                fasi = "CASE WHEN 1.0 * CAST(" + expr + " * " + ricxvi + " AS INT) / " + ricxvi + " < " + expr + " THEN  (1.0 * CAST(" + expr + " * " + ricxvi + " AS INT) + 1) / " + ricxvi + " ELSE " +
                       expr + " END";
            }
            else
                fasi = expr;
            string strComm = "UPDATE Moms SET Fasi" + txtFasi1.IntegerValue + " = " + fasi;
            strComm += SetWhereClause();

            SQL.Update(strComm);

            Close();
        }

        private static Double Ricxvi(int DabrgvalebaCifri)
        {
            switch (DabrgvalebaCifri) {
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

        private void chbMomsT_CheckedChanged(object sender, EventArgs e)
        {
            ParamClass.CheckBoxAction((CheckBox)sender, ParamClass.ReturnControlViaName(this, ((CheckBox)sender).Name, 3, "cb"));
        }

        private void SetMomsFasiForm_Load(object sender, EventArgs e)
        {
            SQLOperation.FillDataToComboBoxAndSetFont("MomsT", cbMomsT);
            SQLOperation.FillDataToComboBoxAndSetFont("MomsS", cbMomsS);
        }

        private void chbDamrgvaleba_CheckedChanged(object sender, EventArgs e)
        {
            txtDabrgvalebaCifri.Visible = chbDamrgvaleba.Checked;
            if (chbDamrgvaleba.Checked)
                txtDabrgvalebaCifri.Focus();
        }
    }
}
