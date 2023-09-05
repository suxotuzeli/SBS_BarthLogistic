using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class ImportGegmaCarmToModz : XtraForm
    {
        const string TableName = "Modz1";
        readonly DateTime data;
        readonly int idGegmaCarm1, idProek1,idProek2;
        readonly string zedd;
        CLSTableOperation clsModz1;
        DataTable dtGegmaCarm;
        bool ukve;

        public ImportGegmaCarmToModz(DataRowView rowGegmaCarm)
        {
            zedd = rowGegmaCarm["zedd"].ToString();
            data = DateTime.Today;
            idProek1 = Convert.ToInt32(rowGegmaCarm["IdProek1"].ToString());
            idProek2 = Convert.ToInt32(rowGegmaCarm["IdProek2"].ToString());
            idGegmaCarm1 = Convert.ToInt32(rowGegmaCarm["IdGegmaCarm1"].ToString());

            InitializeComponent();
        }

        public bool Exported { get; private set; }

        void ImportGegmaCarmToModz_Load(object sender, EventArgs e)
        {
            clsModz1 = new CLSTableOperation(panel2, TableName);
            AcceptButton = btnAdd;
            txtActivateData.SetDateFormat(true, true);
            panel2.ChangeFonts();
            SetDefaultValuesFromParameters();
            cbProek1.SetLookUpEditValue(idProek2.ToString());
            cbProek2.SetLookUpEditValue(idProek1.ToString());
            Text = "მოძრაობაში ექსპორტი";
            txtData.SetDateFormat(true);
            txtGegmaCarmZedd.Text = zedd;
            dtGegmaCarm = SQL.Select(" SELECT * FROM GegmaCarm2View WHERE IdGegmaCarm1=" + idGegmaCarm1);
            dgGegmaCarm.DataSource = dtGegmaCarm;
            txtData.DateTime = data;
            gvGegmaCarm.ChangeFonts();
            Exported = false;
            gvGegmaCarm.CellValueChanging += gvGegmaCarm_CellValueChanging;
            txtGegmaCarmZedd.Text = zedd;
        }

        void gvGegmaCarm_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
        }

        void SetDefaultValuesFromParameters()
        {
            //            if (DefaultValues.chbProek)
            //                cbProek.EditValue = DefaultValues.IdProek;
            //            if (DefaultValues.chbModzT)
            //                cbModzT.EditValue = DefaultValues.IdModzT;
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtZedd.Text=="")
                txtZedd.Text = SQLOperation.CalcZeddNum("Modz1");

            var masterId = clsModz1.Insert();
            for (var i = 0; i < gvGegmaCarm.RowCount; i++)
            {
                if ((Convert.ToDouble(gvGegmaCarm.GetRowCellValue(i, "Raod"))) > 0)
                {
                    var str = new StringBuilder();
                    str.Append("INSERT INTO Modz2 ( IdModz1, IdProd, Raod, CD, UN) VALUES  ( ");
                    str.Append("" + masterId + ", ");
                    str.Append("N'" + gvGegmaCarm.GetRowCellValue(i, "IdProd") + "', ");
                    str.Append("" + (Convert.ToDouble(gvGegmaCarm.GetRowCellValue(i, "Raod"))) + ", ");
                    str.Append("GETDATE(), N'" + GlobalParameters.UserName + "')");
                    SQL.Insert(str.ToString());
                }
            }
            Exported = true;
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

        private void txtZedd_Leave(object sender, EventArgs e)
        {
            txtZedd.Text = SQLOperation.CalcZeddNum("Modz1");
        }

        private void cbMdz_Leave(object sender, EventArgs e)
        {
            var dt = SQL.Select("SELECT Nom, IdTransTypes FROM Mdz WHERE IdMdz = " + cbMdz.EditValue);
            if (dt.Rows.Count != 0)
            {
                txtMdzNom.Text = dt.Rows[0]["Nom"].ToString();
                cbTransTypes.EditValue = dt.Rows[0]["IdTransTypes"].ToString();
            }
        }
    }
}