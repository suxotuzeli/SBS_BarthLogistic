using System;
using System.Windows.Forms;
using SBS_BuilderBudjet.Classes;

namespace SBS_BuilderBudjet.WayBill
{
    public partial class WayBillImportShesForm : Form
    {
        private readonly string idShes1, momcSagad;
        private readonly DateTime data;

        public WayBillImportShesForm(string idShes1, string momcSagad, DateTime data)
        {
            this.idShes1 = idShes1;
            this.momcSagad = momcSagad;
            this.data = data;
            InitializeComponent();
        }

        private void chbSagad_CheckedChanged(object sender, EventArgs e)
        {
            txtWayBillSagad.Visible = chbMomcSagad.Checked;
        }

        private void WayBillImportShesForm_Load(object sender, EventArgs e)
        {
            txtWayBillData.Value = data;
            txtWayBillSagad.Text = momcSagad;

            CLSWayBillOperation wayBill = new CLSWayBillOperation();
            string buyerTin = chbMomcSagad.Checked ? txtWayBillSagad.Text : "";
//            DataSet ds = wayBill.GetBuyerWayBills(txtWayBillData.Value, buyerTin);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }
    }
}
