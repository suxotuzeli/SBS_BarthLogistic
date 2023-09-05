using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class SetCalcFasiForm : XtraForm
    {
        decimal dgg = (decimal)1.18;
        readonly int idCalc;

        public SetCalcFasiForm(int idCalc)
        {
            this.idCalc = idCalc;
            InitializeComponent();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            var strComm = " UPDATE Prod SET Fasi1=" + txtTanxa.Text +
                          " FROM Prod INNER JOIN Calc ON Prod.IdProd=Calc.IdProd WHERE IdCalc = " + idCalc;
            SQL.Execute(strComm);
            Close();
        }

        void SetCalcFasiForm_Load(object sender, EventArgs e)
        {
            using (var dt = SQL.Select(
                " SELECT SUM(DanakRaod *" +
                " dbo.udfCalcLastTvitg(IdProd,GETDATE())) Tanxa FROM CalcProdView WHERE IdCalc=" +
                idCalc))
                txtTvitg.Value = Convert.ToDecimal(dt.Rows[0]["Tanxa"].ToString());
            txtDanamati.ValueChanged += txtDanamati_KeyPress;
            txtTanxa.ValueChanged += txtTanxa_KeyPress;
            txtPercent.ValueChanged += txtPercent_KeyPress;
        }

        void txtDanamati_KeyPress(object sender, EventArgs e)
        {
            if (txtTanxa.Value != (txtTvitg.Value * (100 + txtPercent.Value) / 100 + txtDanamati.Value) * dgg)
                txtTanxa.Value = (txtTvitg.Value * (100 + txtPercent.Value) / 100 + txtDanamati.Value) * dgg;
        }

        void txtTanxa_KeyPress(object sender, EventArgs e)
        {
            if (txtDanamati.Value != txtTanxa.Value / dgg - txtTvitg.Value)
                txtDanamati.Value = txtTanxa.Value / dgg - txtTvitg.Value;
            txtPercent.Value = 0;
        }

        void txtPercent_KeyPress(object sender, EventArgs e)
        {
            if (txtPercent.Value == 0) return;
            if (txtTanxa.Value != (txtTvitg.Value * (100 + txtPercent.Value) / 100 + txtDanamati.Value) * dgg)
                txtTanxa.Value = (txtTvitg.Value * (100 + txtPercent.Value) / 100 + txtDanamati.Value) * dgg;
        }
    }
}