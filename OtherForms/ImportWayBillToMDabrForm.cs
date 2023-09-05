using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SBS_Market.Classes;
using SBS_Market.Parameters;
using Syncfusion.Windows.Forms.Tools;

namespace SBS_Market.OtherForms
{
    public partial class ImportWayBillToMDabrForm : Form
    {
        private readonly int id, idMomc;
        private readonly string zedd, idMDabrWayBill1;
        private string prodParams=" 1=1 ";
        private readonly DateTime d;
        private readonly DataTable dtRs;
        private bool checkData = true;

        private const string TableName = "MDabr";
        private CLSTableOperation clsMDabr;

        public ImportWayBillToMDabrForm(int idMomc, string idMDabrWayBill1, string zedd, DateTime d, DataTable dtRs)
        {
            this.idMomc = idMomc;
            this.idMDabrWayBill1 = idMDabrWayBill1;
            this.d = d;
            this.zedd = zedd;
            this.dtRs = dtRs;
            InitializeComponent();
        }

        private void ImportWayBillToMDabrForm_Load(object sender, EventArgs e)
        {
            clsMDabr = new CLSTableOperation(panel2, TableName);
            AcceptButton = ParamClass.SetButtonStyle(btnOK, btnAdd, false);
            ParamClass.ChangeFonts(panel2);
            SetDefaultValuesFromParameters();

            Text = "მომწოდებელზე დაბრუნების  ჩამატება";
            PeriodSettingsClass.SetDateFormat(txtData, true);
            txtZedd.Text = zedd;
            
            txtData.Value = d;
            GenerateIdProdValues();
            dgRealRs.DataSource = dtRs;
            if(idMomc > 0)
                cbMomc.SelectedValue = idMomc;
            ParamClass.ChangeFonts(gvRealRs);
            SQLOperation.FillDataToComboBoxAndSetFont("ProdTG", cbProdTG);
            SQLOperation.FillDataToComboBoxAndSetFont("ProdT", cbProdT);
            SQLOperation.FillDataToComboBoxAndSetFont("ProdG", cbProdG);
            SQLOperation.FillDataToComboBoxAndSetFont("ProdS", cbProdS);
            SQLOperation.FillDataToComboBoxAndSetFont("Feri", cbFeri);
            SQLOperation.FillDataToComboBoxAndSetFont("Forma", cbForma);
            SQLOperation.FillDataToComboBoxAndSetFont("Stili", cbStili);
            CLSCustomCnobari clsCustomCnobari = new CLSCustomCnobari();
            clsCustomCnobari.SetTexts(gbProdParams);

        }

        private void GenerateIdProdValues()
        {
            if (dtRs.Columns.IndexOf("IdProd") < 0) {
                dtRs.Columns.Add("IdProd", typeof(string));
                dtRs.Columns.Add("Dgg", typeof(double));
                dtRs.Columns.Add("CompRaod", typeof(double));
            }
            for (int i = 0; i < dtRs.Rows.Count; i++) {
                DataTable dt = SQL.Select("SELECT TOP 1 IdProd, Dgg, CompRaod FROM Prod WHERE MomcProdCode = N'" + dtRs.Rows[i]["BAR_CODE"] + "' AND " + prodParams);
                dtRs.Rows[i]["IdProd"] = dt.Rows.Count > 0 ? dt.Rows[0]["IdProd"] : "---";
                dtRs.Rows[i]["Dgg"] = dt.Rows.Count > 0 ? dt.Rows[0]["Dgg"] : 18;
                dtRs.Rows[i]["CompRaod"] = dt.Rows.Count > 0 ? dt.Rows[0]["CompRaod"] : 1;
            }

        }

        private void SetDefaultValuesFromParameters()
        {
            if (DefaultValues.chbProek)
                cbProek.SelectedValue = DefaultValues.IdProek;
            if (DefaultValues.chbMDabrT)
                cbMDabrT.SelectedValue = DefaultValues.IdMDabrT;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable dtt = SQL.Select(" SELECT * from Momc Where IdMomc=" + cbMomc.SelectedValue);
           
            for (int i = 0; i < gvRealRs.RowCount; i++) {
                if (gvRealRs.GetRowCellValue(i, "IdProd").ToString() == "---")
                    continue;
                
                
                StringBuilder str = new StringBuilder();
                str.Append("INSERT INTO dbo.MDabr ( IdMomc, IdMDabrT, IdProek, IdValuta, Data, Zedd, Factura, Shen, Kursi, IdProd, Raod, Fasi, CD, UN) VALUES  ( ");
                str.Append("" + cbMomc.SelectedValue + ", ");
                str.Append("" + cbMDabrT.SelectedValue + ", ");
                str.Append("" + cbProek.SelectedValue + ", ");
                str.Append("" + cbValuta.SelectedValue + ", ");
                str.Append("'" + txtData.Value.ToString(InterfaceParameters.ServerDateFormat) + "', ");
                str.Append("N'" + txtZedd.Text + "', ");
                str.Append("N'" + txtFactura.Text + "', ");
                str.Append("N'" + txtShen.Text + "', ");
                str.Append(txtKursi.DoubleValue + ", ");
                str.Append("N'" + gvRealRs.GetRowCellValue(i, "IdProd") + "', ");
                if (Convert.ToBoolean(dtt.Rows[0]["MomcProdFromCompRaod"].ToString()))
                {
                    str.Append("" +
                               Convert.ToDouble(gvRealRs.GetRowCellValue(i, "QUANTITY"))*
                               Convert.ToDouble(gvRealRs.GetRowCellValue(i, "CompRaod")) + ", ");
                    str.Append("" +
                               Convert.ToDouble(gvRealRs.GetRowCellValue(i, "PRICE"))/
                               Convert.ToDouble(gvRealRs.GetRowCellValue(i, "CompRaod")) + ", ");
                }
                else
                {
                    str.Append("" +Convert.ToDouble(gvRealRs.GetRowCellValue(i, "QUANTITY"))  + ", ");
                    str.Append("" + Convert.ToDouble(gvRealRs.GetRowCellValue(i, "PRICE")) + ", ");

                    
                }
                str.Append("GETDATE(), N'" + ManagementParameters.UserName + "')");
                SQL.Insert(str.ToString());
            }
            Close();


        }

        private void txtData_Leave(object sender, EventArgs e)
        {
            if (!ParamClass.CanUserModifyData(txtData.Value) && checkData) {
                MessageBox.Show("თქვენ არ შეგიძლიათ ამ თარიღით ინფორმაციის შეტანა!", "შეცდომა", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtData.Focus();
            }
            else {
                btnOK.Enabled = true;
                btnAdd.Enabled = true;
            }

        }

        private void chbProdTG_CheckedChanged(object sender, EventArgs e)
        {
            ParamClass.CheckBoxAction((CheckBox)sender, ParamClass.ReturnControlViaName(this, ((CheckBox)sender).Name, 3, "cb"));
        }

        private void btnUpdateProdParams_Click(object sender, EventArgs e)
        {
            prodParams = " (1 = 1)";
            prodParams = SQLOperation.SetWhereClause(prodParams, gbProdParams);
            GenerateIdProdValues();

        }

     

     

    }
}
