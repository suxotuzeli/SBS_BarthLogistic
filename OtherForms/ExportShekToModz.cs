using System;
using System.Text;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class ExportShekToModz : XtraForm
    {
        readonly DateTime data;
        readonly string idShek1, idProek1, idProek2;
        CLSTableOperation clsModz1;

        public ExportShekToModz(string idShek1, string idProek1, string idProek2, DateTime data)
        {
            this.idShek1 = idShek1;
            this.idProek1 = idProek1;
            this.idProek2 = idProek2;
            this.data = data;
            InitializeComponent();
        }

        void ExportShekToModz_Load(object sender, EventArgs e)
        {
            clsModz1 = new CLSTableOperation(this, "Modz1");
            this.ChangeFonts();
            cbProek1.EditValue = idProek2;
            cbProek2.EditValue = idProek1;
            txtData.DateTime = data;
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            if (txtZedd.Text == "")
                txtZedd.Text = SQLOperation.CalcZeddNum("Modz1");
            var masterId = clsModz1.Insert();
            var str = new StringBuilder("INSERT INTO Modz2 ( IdModz1, IdProd, Raod, UN, CD ) ");
            str.Append("SELECT " + masterId + ", IdProd, Raod, N'" + GlobalParameters.UserName + "', GETDATE() ");
            str.Append("FROM Shek2 ");
            str.Append("WHERE IdShek1 = " + idShek1);
            SQL.Update(str.ToString());

            SQL.Update("UPDATE Shek1 SET Active = 0 WHERE IdShek1 = " + idShek1);
            Close();
        }
    }
}