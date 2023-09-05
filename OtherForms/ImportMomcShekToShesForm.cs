using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class ImportMomcShekToShesForm : XtraForm
    {
        const string TableName = "Shes1";
        readonly DateTime data;
        readonly DataTable dtMomcShek;
        readonly int idMomc, idProek, idValuta;
        readonly string zedd;
        CLSTableOperation clsShes1;

        public ImportMomcShekToShesForm(DataRow rowMomcShek, DataTable dtMomcShek)
        {
            idMomc = Convert.ToInt32(rowMomcShek["idMomc"].ToString());
            zedd = rowMomcShek["zedd"].ToString();
            data = Convert.ToDateTime(rowMomcShek["DataDelivery"].ToString());
            idProek = Convert.ToInt32(rowMomcShek["IdProek"].ToString());
            idValuta = Convert.ToInt32(rowMomcShek["IdValuta"].ToString());
            this.dtMomcShek = dtMomcShek;
            InitializeComponent();
        }

        void ImportMomcShekToShesForm_Load(object sender, EventArgs e)
        {
            clsShes1 = new CLSTableOperation(panel2, TableName);
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, false);
            panel2.ChangeFonts();
            SetDefaultValuesFromParameters();

            Text = "შესყიდვის  ჩამატება";
            txtData.SetDateFormat(true);
            txtZedd.Text = zedd;
            dgMomcShek.DataSource = dtMomcShek;
            cbMomc.EditValue = idMomc;
            cbProek.EditValue = idProek;
            cbValuta.EditValue = idValuta;
            txtData.DateTime = data;
            gvMomcShek.ChangeFonts();
            cbCalcType.EditValue = 10;
        }

        void SetDefaultValuesFromParameters()
        {
            if (DefaultValues.chbProek)
                cbProek.EditValue = DefaultValues.IdProek;
            if (DefaultValues.chbShesT)
                cbShesT.EditValue = DefaultValues.IdShesT;
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var masterId = clsShes1.Insert();
            for (var i = 0; i < gvMomcShek.RowCount; i++)
            {
                var str = new StringBuilder();
                str.Append(
                    "INSERT INTO dbo.Shes2 ( IdShes1, IdProd, Raod, Tanxa, TanxaTvitg, ShesDgg, CD, UN) VALUES  ( ");
                str.Append("" + masterId + ", ");
                str.Append("N'" + gvMomcShek.GetRowCellValue(i, "IdProd") + "', ");
                str.Append("" + (Convert.ToDouble(gvMomcShek.GetRowCellValue(i, "Raod"))) + ", ");
                str.Append("" + gvMomcShek.GetRowCellValue(i, "Tanxa") + ", ");
                str.Append("0, 0, "); //TanxaTvitg, ShesDgg
                str.Append("GETDATE(), N'" + GlobalParameters.UserName + "')");
                SQL.Insert(str.ToString());
            }
            Close();
        }

        void txtData_Leave(object sender, EventArgs e)
        {
            if (!txtData.DateTime.CanUserModifyData())
            {
                XtraMessageBox.Show(StringParameters.GascorebaDgeError, StringParameters.CaptionError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtData.Focus();
            }
            else
            {
                btnOK.Enabled = true;
                btnAdd.Enabled = true;
            }
        }
    }
}