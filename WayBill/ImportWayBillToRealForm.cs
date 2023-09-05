using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.AddForms;
using SBS_BarthLogistic.AddForms;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.WayBill
{
    public partial class ImportWayBillToRealForm : Form
    {
        const string TableName = "Real1";
        readonly DataTable dtRs;
        readonly DateTime shesdata;
        readonly string zedd, idRealWayBill1, sagad, address, idWayBillstatus, mdzSagad, manqana, mdz;
        CLSTableOperation clsReal1;

        public ImportWayBillToRealForm(string idShesWayBill1, string idWayBillstatus, string sagad, string address,
            string zedd, DateTime shesdata, DataTable dtRs, string mdzSagad, string manqana, string mdz, int dabr)
        {
            for (var i = 0; i < dtRs.Rows.Count; i++)
            {
                dtRs.Rows[i]["QUANTITY"] = Convert.ToDouble(dtRs.Rows[i]["QUANTITY"]) * dabr;
                dtRs.Rows[i]["AMOUNT"] = Convert.ToDouble(dtRs.Rows[i]["AMOUNT"]) * dabr;
            }
            idRealWayBill1 = idShesWayBill1;
            this.sagad = sagad;
            this.mdzSagad = mdzSagad;
            this.address = address;
            this.mdz = mdz;
            this.manqana = manqana;
            this.idWayBillstatus = idWayBillstatus;
            this.zedd = zedd;
            this.dtRs = dtRs;
            this.shesdata = shesdata;
            InitializeComponent();
        }

        void ImportWayBillToRealForm_Load(object sender, EventArgs e)
        {
            clsReal1 = new CLSTableOperation(panel2, TableName);
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, false);
            panel2.ChangeFonts();
            SetDefaultValuesFromParameters();
            Text = "რეალიზაციის ჩამატება";
            txtData.SetDateFormat();
            txtActivateData.SetDateFormat();

            var dtgvari = SQL.Select("SELECT IdGvari, Address FROM Gvari WHERE Sagad='" + sagad + "'");
            if (dtgvari.Rows.Count > 0)
            {
                if (dtgvari.Rows.Count > 1)
                    MessageBox.Show(
                        "აღნიშნული საიდენტიფიკაციო კოდით მოიძებნა ერთზე მეტი კლიენტი. \n ავტომატურად აიჩევა პირველივე, შეცვლა შესაძლებელია ხელით");
                txtIdGvari.Id = dtgvari.Rows[0]["IdGvari"].ToString();
            }
            else
            {
                if (MessageBox.Show(
                    "აღნიშნული საიდენტიფიკაციო კოდით მყიდველი ვერ მოიძებნა.ჩავამატოთ ახალი?", "Confirm",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                }
            }
            if (mdzSagad.Length > 0)
            {
                dtgvari = SQL.Select("SELECT IdMdz, Mdz FROM Mdz WHERE PiradiNom='" + mdzSagad + "'");
                if (dtgvari.Rows.Count > 0)
                {
                    if (dtgvari.Rows.Count > 1)
                        MessageBox.Show(
                            "აღნიშნული პირადი ნომრით მოიძებნა ერთზე მეტი მძღოლი. \n ავტომატურად აიჩევა პირველივე, შეცვლა შესაძლებელია ხელით");
                    cbMdz.EditValue = dtgvari.Rows[0]["IdMdz"];
                }
                else
                {
                    if (MessageBox.Show(
                        "აღნიშნული პირადი ნომრით მძღოლი ვერ მოიძებნა.ჩავამატოთ ახალი?", "Confirm",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var fm = new AddMdzForm("Mdz", mdzSagad, manqana, mdz);
                        fm.ShowDialog();
                        cbMdz.FillDataToLookUpEditAndSetFont();
                        cbMdz.SetLookUpEditValue(GlobalParameters.IDForFind);
                    }
                }
            }
            txtIdWayBillStatus.Text = idWayBillstatus.Substring(1, 1);
            txtZedd.Text = zedd;
            txtGvariAddress.Text = address;
            txtIdRealWayBill1.Text = idRealWayBill1;
            txtData.DateTime = shesdata;
            GenerateIdProdValues();
            dgRealRs.DataSource = dtRs;
            gvRealRs.ChangeFonts();
        }

        void GenerateIdProdValues()
        {
            if (dtRs.Columns.IndexOf("IdProd") < 0)
            {
                dtRs.Columns.Add("IdProd", typeof (string));
            }
            for (var i = 0; i < dtRs.Rows.Count; i++)
            {
                using (
                    var dt =
                        SQL.Select("SELECT TOP 1 IdProd FROM ProdView WHERE IdProd = N'" + dtRs.Rows[i]["BAR_CODE"] +
                                   "'"))
                {
                    if (dt.Rows.Count > 0)
                    {
                        dtRs.Rows[i]["IdProd"] = dt.Rows[0]["IdProd"];
                    }
                    else
                    {
                        dtRs.Rows[i]["IdProd"] = "---";
                    }
                }
            }
        }

        void SetDefaultValuesFromParameters()
        {
            if (DefaultValues.chbProek)
                cbProek.SetLookUpEditValue(DefaultValues.IdProek);
            if (DefaultValues.chbModzT)
                cbRealT.SetLookUpEditValue(DefaultValues.IdRealT);
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var masterId = clsReal1.Insert();
            for (var i = 0; i < gvRealRs.RowCount; i++)
            {
                if (gvRealRs.GetRowCellValue(i, "IdProd").ToString() == "---")
                    continue;
                var str = new StringBuilder();
                str.Append("INSERT INTO dbo.Real2 ( IdReal1, IdProd, Raod, Tanxa, CD, UN) VALUES  ( ");
                str.Append("" + masterId + ", ");
                str.Append("N'" + gvRealRs.GetRowCellValue(i, "IdProd") + "', ");
                str.Append("" + gvRealRs.GetRowCellValue(i, "QUANTITY") + ", ");
                str.Append("" + gvRealRs.GetRowCellValue(i, "AMOUNT") + ", ");
                str.Append("GETDATE(), N'" + GlobalParameters.UserName + "')");
                SQL.Insert(str.ToString());
            }
            Close();
        }

        void btnChangeMomcCode_Click(object sender, EventArgs e)
        {
            var dtrow = dtRs.Rows[gvRealRs.FocusedRowHandle];
            OrgProdParameters.IdProd = gvRealRs.GetFocusedRowCellValue(colRsBAR_CODE).ToString();
            OrgProdParameters.Prod = gvRealRs.GetFocusedRowCellValue(colRsW_NAME).ToString();
            OrgProdParameters.IdUnit = Convert.ToInt32(dtrow["UNIT_ID"]);
            if (OrgProdParameters.IdUnit == 99)
                OrgProdParameters.UnitName = dtrow.ItemArray[3].ToString();

            var txtIdProd = new TextEdit();
            DBClass.SelectFromProd("1", txtIdProd);
            OrgProdParameters.IdProd = "";
            OrgProdParameters.IdMomc = "";
            OrgProdParameters.Prod = "";
            OrgProdParameters.Fasi10 = 0;
            OrgProdParameters.IdUnit = 1;
            OrgProdParameters.UnitName = "";

            gvRealRs.SetFocusedRowCellValue(colRsIdProd, txtIdProd.Text);
        }
    }
}