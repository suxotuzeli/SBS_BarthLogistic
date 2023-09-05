using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class ImportGegmaCarmToCarm1 : XtraForm
    {
        const string TableName = "ProekShek1";
        readonly DateTime data;
        readonly int idGegmaCarm1, idProek;
        readonly string zedd;
        CLSTableOperation clsProekShek1;
        DataTable dtGegmaCarm;
        bool ukve;

        public ImportGegmaCarmToCarm1()
        {
            data = DateTime.Today;

            InitializeComponent();
        }

        public bool Exported { get; private set; }

        void ImportGegmaCarmToCarm1_Load(object sender, EventArgs e)
        {
            clsProekShek1 = new CLSTableOperation(panel2, TableName);
            AcceptButton = btnAdd;
            panel2.ChangeFonts();
            SetDefaultValuesFromParameters();
            Text = "ექსპორტი წარმოებაში";
            txtData.SetDateFormat(true);
          
            txtData.DateTime = data;
            gvGegmaCarm.ChangeFonts();
            Exported = false;
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
            DateTime d = Convert.ToDateTime((txtData.DateTime).ToString(GlobalParameters.ServerDateTimeFormat));
            for (var i = 0; i < gvGegmaCarm.RowCount; i++)
            {
                if ((Convert.ToDouble(gvGegmaCarm.GetRowCellValue(i, "Raod"))) > 0)
                {
                    var str = new StringBuilder();
                    str.Append("INSERT INTO Carm1(IdProd,IdCarmT,IdProek,Data,Zedd,Shen,CarmRaod,CD,UN,CarmTanxa,IsMeoradi,GegmaCarmZedd) VALUES  ( ");
                    str.Append("N'" + gvGegmaCarm.GetRowCellValue(i, "IdProd") + "', ");
                    str.Append("" + cbCarmT.EditValue + ", ");
                    str.Append("" + cbProek2.EditValue + ", ");
                    str.Append("N'" + d.ToShortDateString() + "', ");
                    str.Append("N'" + SQLOperation.CalcZeddNum("Carm1") + "', ");
                    str.Append("N'" + txtShen.Text + "', ");
                    str.Append("" + (Convert.ToDouble(gvGegmaCarm.GetRowCellValue(i, "Raod"))) + ", ");
                    str.Append("GETDATE(), N'" + GlobalParameters.UserName + "',0,0,N'"+zedd+"')");
                    SQL.Insert(str.ToString());
                }
            }
            Exported = true;
            SQL.Update("Update GegmaCarm1 SET IsReady=1 WHERE IdProek2= " + cbProek2.EditValue + " AND IsReady=0 ");
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

        void simpleButton1_Click(object sender, EventArgs e)
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

        void gvGegmaCarm_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var clsSpAll = new CLSSpAll(panel1, "spGenerateCarm1FromCarmGegma");
            clsSpAll.AddParameter("IdProek", cbProek2.EditValue);
            dtGegmaCarm = clsSpAll.Exceute();
            dgGegmaCarm.DataSource = dtGegmaCarm;
        }
    }
}