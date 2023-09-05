using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class ImportGegmaCarmToProekShek : XtraForm
    {
        const string TableName = "ProekShek1";
        readonly DateTime data;
        readonly int idProek;
        readonly string zedd;
        CLSTableOperation clsProekShek1;
        DataTable dtGegmaCarm;
        bool ukve;

        public ImportGegmaCarmToProekShek()
        {
            data = DateTime.Today;
            
            InitializeComponent();
        }

        public bool Exported { get; private set; }

        void ImportGegmaCarmToProekShek_Load(object sender, EventArgs e)
        {

            clsProekShek1 = new CLSTableOperation(panel2, TableName);
            AcceptButton = btnAdd;
            panel2.ChangeFonts();
            SetDefaultValuesFromParameters();
//            cbProek1.SetLookUpEditValue(idProek.ToString());
            Text = "ობიექტების შეკვეთის გენერირება";
            txtData.SetDateFormat(true);
            txtZedd.Text = zedd;
           
            txtData.DateTime = data;
            gvGegmaCarm.ChangeFonts();
            Exported = false;
            gvGegmaCarm.CellValueChanging += gvGegmaCarm_CellValueChanging;
        }

        void gvGegmaCarm_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            //            if (Convert.ToDouble(e.Value.ToString()) > value)
        }

        void SetDefaultValuesFromParameters()
        {
            //            if (DefaultValues.chbProek)
            //                cbProek.EditValue = DefaultValues.IdProek;
            //            if (DefaultValues.chbProekShekT)
            //                cbProekShekT.EditValue = DefaultValues.IdProekShekT;
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtZedd.Text == "")
                txtZedd.Text = SQLOperation.CalcZeddNum("ProekShek1");
            var masterId = clsProekShek1.Insert();
            for (var i = 0; i < gvGegmaCarm.RowCount; i++)
            {
                if ((Convert.ToDouble(gvGegmaCarm.GetRowCellValue(i, "Raod"))) > 0)
                {
                    var str = new StringBuilder();
                    str.Append("INSERT INTO ProekShek2 ( IdProekShek1, IdProd, Raod, CD, UN) VALUES  ( ");
                    str.Append("" + masterId + ", ");
                    str.Append("N'" + gvGegmaCarm.GetRowCellValue(i, "IdProd") + "', ");
                    str.Append("" + (Convert.ToDouble(gvGegmaCarm.GetRowCellValue(i, "Raod"))) + ", ");
                    str.Append("GETDATE(), N'" + GlobalParameters.UserName + "')");
                    SQL.Insert(str.ToString());
                }
            }
            Exported = true;
            SQL.Update("Update GegmaCarm1 SET ExportedToProekShek=1 WHERE IdProek2= " + cbProek1.EditValue + " AND ExportedToProekShek=0 ");
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
                btnAdd.Enabled = true;
            }
        }

       
        void gvGegmaCarm_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
        }

        private void btnTakeOffNashti_Click(object sender, EventArgs e)
        {
            if (ukve)
            {
                XtraMessageBox.Show("ობიექტის ნაშთი უკვე დაკლებულია");
                return;
            }
            for (var i = 0; i < dtGegmaCarm.Rows.Count; i++)
            {
                dtGegmaCarm.Rows[i]["Raod"] = Convert.ToDouble(dtGegmaCarm.Rows[i]["Raod"].ToString()) -
                                              Convert.ToDouble(dtGegmaCarm.Rows[i]["Nashti"].ToString());
                if (Convert.ToDouble(dtGegmaCarm.Rows[i]["Raod"].ToString()) < 0)
                    dtGegmaCarm.Rows[i]["Raod"] = 0;
            }
            ukve = true;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var clsSpAll = new CLSSpAll(panel1, "spGenerateFromCarmGegma");
            clsSpAll.AddParameter("IdProek", cbProek1.EditValue);
            clsSpAll.AddParameter("D", txtData.DateTime.Date);
            dtGegmaCarm = clsSpAll.Exceute();
            dgGegmaCarm.DataSource = dtGegmaCarm;
        }
    }
}