using System;
using System.Windows.Forms;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class GenerateShesTanxaForm : Form
    {
        readonly string idShes1;

        public GenerateShesTanxaForm(string idShes1)
        {
            this.idShes1 = idShes1;
            InitializeComponent();
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            var koef = txtTanxaNew.Value / txtTanxa.Value;
            SQL.Update("UPDATE Shes2 SET Tanxa = Tanxa * " + koef + "  WHERE IdShes1 = " + idShes1);
            var table = SQL.Select("SELECT SUM(Tanxa) - " + txtTanxaNew.Value + " FROM Shes2 WHERE IdShes1 = " + idShes1);
            if (table.Rows.Count != 1) return;
            var round = Convert.ToDecimal(table.Rows[0][0].ToString());
            if (round <= 0)
            {
                Close();
                return;
            }
            SQL.Update("UPDATE Shes2 SET Tanxa = Tanxa + " + round +
                       "  WHERE IdShes2 IN (SELECT MAX(IdShes2) FROM Shes2 WHERE IdShes1 = " + idShes1 + ")");
            Close();
        }

        void GenerateShesTanxaForm_Load(object sender, EventArgs e)
        {
            var table = SQL.Select("SELECT SUM(Tanxa) FROM Shes2 WHERE IdShes1 = " + idShes1);
            if (table.Rows.Count == 1)
            {
                txtTanxa.Value = Convert.ToDecimal(table.Rows[0][0].ToString());
            }
        }
    }
}