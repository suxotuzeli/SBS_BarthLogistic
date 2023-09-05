using System;
using System.Data;
using System.Text;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class GenerateRealForm : XtraForm
    {
        const string TableName = "Real1";
        readonly DataTable dt;
        readonly int idProek, idAgcera1;

        public GenerateRealForm(DataTable dt, int idProek, int idAgcera1)
        {
            InitializeComponent();
            this.dt = dt;
            this.idProek = idProek;
            this.idAgcera1 = idAgcera1;
        }

        void GenerateRealForm_Load(object sender, EventArgs e)
        {
            this.ChangeFonts();
            SetDefaultValuesFromParameters();
            txtZedd.Text = SQLOperation.CalcZeddNum(TableName);
            txtData.SetDateFormat();
            txtDataFactura.SetDateFormat();
            txtActivateData.SetDateFormat(true, true);
        }

        void SetDefaultValuesFromParameters()
        {
            cbTransTypes.FillDataToLookUpEditAndSetFont();
            cbRealT.FillDataToLookUpEditAndSetFont();
            cbMdz.FillDataToLookUpEditAndSetFont();
            if (DefaultValues.chbRealT)
                cbRealT.EditValue = DefaultValues.IdRealT;
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            var strComm = new StringBuilder();
            strComm.Append(
                "INSERT INTO Real1(IdAgcera1, Data, Zedd, IdProek, IdRealT, IdGvari, IdMdz, ActivateData, Factura, DataFactura,  Shen, TransTanxa, MdzNom, IsTransportireba, TransGamkidveli, IdTransTypes, TransTypesName, UN, CD)  VALUES (");
            strComm.Append(idAgcera1 + ", ");
            strComm.Append("'" + txtData.DateTime.ToString(GlobalParameters.ServerDateFormat) + "', ");
            strComm.Append("N'" + txtZedd.Text + "', ");
            strComm.Append("" + idProek + ", ");
            strComm.Append("" + cbRealT.EditValue + ", ");
            strComm.Append("" + txtIdGvari.Id + ", ");
            strComm.Append("" + cbMdz.EditValue + ", ");
            strComm.Append("'" + txtActivateData.DateTime.ToString(GlobalParameters.ServerDateFormat) + "', ");
            strComm.Append("N'" + txtFactura.Text + "', ");
            strComm.Append("'" + txtDataFactura.DateTime.ToString(GlobalParameters.ServerDateFormat) + "', ");
            strComm.Append("N'" + txtShen.Text + "', ");
            strComm.Append("" + txtTransTanxa.Value + ", ");
            strComm.Append("N'" + txtMdzNom.Text + "', ");
            strComm.Append("" + chbIsTransportireba.ConvertCheckEditValueToInt() + ", ");
            strComm.Append("" + chbTransGamkidveli.ConvertCheckEditValueToInt() + ", ");
            strComm.Append("" + cbTransTypes.EditValue + ", ");
            strComm.Append("N'" + txtTransTypesName.Text + "', ");
            strComm.Append("N'" + GlobalParameters.UserName + "', ");
            strComm.Append(" GETDATE()); SELECT SCOPE_IDENTITY()");

            var masterId = Convert.ToInt32(SQL.ExecuteScalar(strComm.ToString()));

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToDouble(dt.Rows[i]["Gas"].ToString()) > 0)
                {
                    var dtt = SQL.Select("SELECT * FROM Prod WHERE IdProd = N'" + dt.Rows[i]["IdProd"] + "'");
                    var fasi = Convert.ToDouble(dtt.Rows[0]["Fasi" + txtFG.Text].ToString());
                    var idProd = dt.Rows[i]["IdProd"].ToString();
                    var gas = dt.Rows[i]["Gas"].ToString();
                    var strComm2 = "INSERT INTO  Real2"
                                   + "(IdReal1, IdProd, Raod, Tanxa, CD, UN) "
                                   + " VALUES (" + masterId
                                   + ", N'" + dt.Rows[i]["IdProd"] + "'"
                                   + ", " + dt.Rows[i]["Gas"] + ""
                                   + ", " + fasi + "*" + dt.Rows[i]["Gas"]
                                   + ", GETDATE() "
                                   + ", '" + GlobalParameters.UserName + "' "
                                   + ") "
                                   + ";SELECT SCOPE_IDENTITY()";
                    try
                    {
                        var insert = SQL.Insert(strComm2);
                        if (insert <= 0) continue;
                        var dtNashti =
                            SQL.Select("SELECT IdAgceraNashti FROM AgceraNashti WHERE IdAgcera1 = " + idAgcera1 +
                                       " AND IdProd = N'" +
                                       idProd + "'");
                        if (dtNashti.Rows.Count > 0)
                        {
                            SQL.Update("UPDATE AgceraNashti SET Raod -= " + gas + " WHERE  IdAgcera1 = " + idAgcera1 +
                                       " AND IdProd = N'" +
                                       idProd + "'", false);
                        }
                        else
                        {
                            SQL.Insert("INSERT INTO AgceraNashti(IdAgcera1, IdProd, Raod, UN, CD) VALUES ( " + idAgcera1 +
                                       ", N'" +
                                       idProd + "', " + gas + ", N'" +
                                       GlobalParameters.UserName + "', GETDATE())");
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("ვერ მოხერხდა ინფორმაციის სრულად შეტანა");
                    }
                }
            }

            Close();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void cbRealT_Enter(object sender, EventArgs e)
        {
            txtIdGvari.SearchForGvari();
            OrgProdParameters.selID = txtIdGvari.Id;
            if (OrgProdParameters.selID == "")
                txtIdGvari.Focus();
        }
    }
}