using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class GenerateShesForm : XtraForm
    {
        const string TableName = "Shes1";
        bool checkData = true;
        readonly DataTable dt;
        readonly int idProek;
        readonly int idAgcera1;

        public GenerateShesForm()
        {
            InitializeComponent();
        }

        public GenerateShesForm(DataTable dt, int idProek, int idAgcera1)
        {
            InitializeComponent();
            this.dt = dt;
            this.idProek = idProek;
            this.idAgcera1 = idAgcera1;
        }

        void GenerateShesForm_Load(object sender, EventArgs e)
        {
            this.ChangeFonts();
            SetDefaultValuesFromParameters();
            txtZedd.Text = SQLOperation.CalcZeddNum(TableName);
            txtData.SetDateFormat(true);
        }

        void SetDefaultValuesFromParameters()
        {
            cbMomc.FillDataToLookUpEditAndSetFont();
            cbShesT.FillDataToLookUpEditAndSetFont();
            cbValuta.FillDataToLookUpEditAndSetFont();
            if (DefaultValues.chbShesT)
                cbShesT.EditValue = DefaultValues.IdShesT;
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            var strComm = new StringBuilder();
            strComm.Append(
                "INSERT INTO Shes1(IdAgcera1, Data, Zedd, IdProek, IdShesT, IdValuta, IdMomc, Kursi, Shen, Factura, UN, CD, IncludeDgg)  VALUES (");
            strComm.Append(idAgcera1 + ", ");
            strComm.Append("'" + txtData.DateTime.ToString(GlobalParameters.ServerDateFormat) + "', ");
            strComm.Append("N'" + txtZedd.Text + "', ");
            strComm.Append("" + idProek + ", ");
            strComm.Append("" + cbShesT.EditValue + ", ");
            strComm.Append("" + cbValuta.EditValue + ", ");
            strComm.Append("" + cbMomc.EditValue + ", ");
            strComm.Append("" + txtKursi.Value + ", ");
            strComm.Append("N'" + txtShen.Text + "', ");
            strComm.Append("N'" + txtFactura.Text + "', ");
            strComm.Append("N'" + GlobalParameters.UserName + "', ");
            strComm.Append(" GETDATE(), ");
            strComm.Append(chbIncludeDgg.ConvertCheckEditValueToInt() + "); SELECT SCOPE_IDENTITY() ");
            var masterId = Convert.ToInt32(SQL.ExecuteScalar(strComm.ToString()));

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                string shem = dt.Rows[i]["Shem"].ToString();
                string idProd = dt.Rows[i]["IdProd"].ToString();

                if (!(Convert.ToDouble(shem) > 0)) continue;

                var dtt = SQL.Select("SELECT Fasi" + txtFG.Text + ",Dgg FROM Prod WHERE IdProd = N'" + idProd + "'");

                var fasi = Convert.ToDouble(dtt.Rows[0][0].ToString());
                if (!chbIncludeDgg.Checked)
                {
                    fasi = fasi*100.00/(100.00 + Convert.ToDouble(dtt.Rows[0]["Dgg"].ToString()));
                }
                var strComm2 = "INSERT INTO  Shes2"
                               + "(IdShes1, IdProd, Raod, Tanxa, CD, UN) "
                               + " VALUES (" + masterId
                               + ", N'" + idProd + "'"
                               + ", " + shem + ""
                               + ", " + shem + "*" + fasi + ""
                               + ", GETDATE() "
                               + ", '" + GlobalParameters.UserName + "');SELECT SCOPE_IDENTITY() ";
                try
                {
                    var insert = SQL.Insert(strComm2);
                    if (insert <= 0) continue;
                    var dtNashti = SQL.Select("SELECT IdAgceraNashti FROM AgceraNashti WHERE IdAgcera1 = " + idAgcera1 + " AND IdProd = N'" +
                                              idProd + "'");
                    if (dtNashti.Rows.Count > 0)
                    {
                        SQL.Update("UPDATE AgceraNashti SET Raod += " + shem + " WHERE  IdAgcera1 = " + idAgcera1 + " AND IdProd = N'" +
                                   idProd + "'", false);
                    }
                    else
                    {
                        SQL.Insert("INSERT INTO AgceraNashti(IdAgcera1, IdProd, Raod, UN, CD) VALUES ( " + idAgcera1 + ", N'" +
                                   idProd + "', " + shem + ", N'" +
                                   GlobalParameters.UserName + "', GETDATE())");
                    }
                }
                catch
                {
                    XtraMessageBox.Show("ვერ მოხერხდა ინფორმაციის სრულად შეტანა");
                }
            }
            // string strComm3 = "UPDATE Shes2 SET TanxaTvitg = dbo.udfCalcTvitg(IdShes1, IdShes2) WHERE IdShes1=" + masterID;
            // SQL.Execute(strComm3);
            Close();
        }

        void txtData_Leave(object sender, EventArgs e)
        {
            if (!txtData.DateTime.CanUserModifyData() && checkData)
            {
                XtraMessageBox.Show("თქვენ არ შეგიძლიათ ამ თარიღით ინფორმაციის შეტანა!", StringParameters.CaptionError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtData.Focus();
            }
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            checkData = false;
            Close();
        }


    }
}