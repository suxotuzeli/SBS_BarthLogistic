using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class ShrobaAddForm : XtraForm
    {
        readonly DataRow dtrow;
        BindingSource bs;
        DataTable dt;
        int idShes1;
        
        public ShrobaAddForm()
        {
            InitializeComponent();
        }

        public ShrobaAddForm(DataRow modz1)
        {
            dtrow = modz1;
            InitializeComponent();
        }

        void ShrobaAddForm_Load(object sender, EventArgs e)
        {
            this.ChangeFonts("cbZedd");
            gridView2.ChangeFonts();
            SetDefaultValuesFromParameters();
            idShes1 = Convert.ToInt32(dtrow["IdShes1"].ToString());

            txtData.SetDateFormat(true);
            bs = new BindingSource();
            dt =
                SQL.Select(
                    "SELECT IdProd, Raod, Prod, Raod*Shroba/100 as GasRaod  FROM Shes2View WHERE Shroba<>0 AND IdShes1 = " +
                    idShes1);
            bs.DataSource = dt;
            dgDet.DataSource = bs;
            btnOK.Enabled = false;
        }

        void SetDefaultValuesFromParameters()
        {
            if (DefaultValues.chbProek)
                cbProek.EditValue = DefaultValues.IdProek;
            if (DefaultValues.chbRealT)
                cbGasT.EditValue = DefaultValues.IdGasT;
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (dt.Rows.Count > 0)
                {
                    var strComm = "INSERT INTO Gas1 "
                                  + "(Data,Zedd,IdGasT,IdProek,Shen,UN,CD) "
                                  + " VALUES ("
                                  + " '" + txtData.DateTime.ToString(GlobalParameters.ServerDateFormat) + "' "
                                  + ", N'" + txtZedd.Text + "'"
                                  + ", " + cbGasT.EditValue + " "
                                  + ", " + cbProek.EditValue + " "
                                  + ", N'" + txtShen.Text + "'"
                                  + ", N'" + GlobalParameters.UserName + "'"
                                  + ", GETDATE() "
                                  + ") "
                                  + ";SELECT SCOPE_IDENTITY()";
                    var masterId = SQL.Insert(strComm);
                    GlobalParameters.IDForFind = masterId;
                    foreach (DataRow dr in dt.Rows)
                    {
                        var strComm1 = "INSERT INTO Gas2"
                                       + "(IdGas1, IdProd, Raod, UN, CD) "
                                       + " VALUES ("
                                       + " " + masterId + " "
                                       + ", N'" + dr["IdProd"] + "' "
                                       + ", " + dr["GasRaod"] + " "
                                       + ", N'" + GlobalParameters.UserName + "'"
                                       + ", GETDATE() "
                                       + ") ";
                        SQL.Insert(strComm1);
                    }
                    if (masterId > 0)
                        SQL.Execute("UPDATE Shes1 SET ShrobaAdded = 1 WHERE IdShes1 = " + idShes1);
                }
                else
                {
                    XtraMessageBox.Show("პროდუქციებს არ აქვს გაწერილი შრობის ნორმა");
                }
            }
            catch
            {
                XtraMessageBox.Show("მონაცემების იმპორტი შეუძლებელია");
            }
            Close();
        }

        void txtData_Leave(object sender, EventArgs e)
        {
            if (!txtData.DateTime.CanUserModifyData())
            {
                XtraMessageBox.Show("თქვენ არ შეგიძლიათ ამ თარიღით ინფორმაციის შეტანა!", StringParameters.CaptionError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtData.Focus();
            }
            else
            {
                btnOK.Enabled = true;
            }
        }

        void txtZedd_Leave_1(object sender, EventArgs e)
        {
            if (txtZedd.Text == "")
                txtZedd.Text = SQLOperation.CalcZeddNum("Gas1");
        }
    }
}