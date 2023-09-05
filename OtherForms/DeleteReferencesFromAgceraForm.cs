using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class DeleteReferencesFromAgceraForm : XtraForm
    {
        readonly string idAgcera;

        public DeleteReferencesFromAgceraForm(string idAgcera)
        {
            this.idAgcera = idAgcera;
            InitializeComponent();
        }

        void DeleteReferencesFromAgceraForm_Load(object sender, EventArgs e)
        {
            CLSTools.ChangeFonts(gvShes1, gvReal1, gvShem1, gvGas1);
            dgShes1.DataSource = SQL.Select(ReturnCmd("Shes"));
            dgReal1.DataSource = SQL.Select(ReturnCmd("Real"));
            dgShem1.DataSource = SQL.Select(ReturnCmd("Shem"));
            dgGas1.DataSource = SQL.Select(ReturnCmd("Gas"));
        }

        string ReturnCmd(string tableName)
        {
            return string.Format("SELECT * FROM {0}1 INNER JOIN {0}2 ON {0}1.Id{0}1 = {0}2.Id{0}1" +
                                 " INNER JOIN Prod ON Prod.IdProd = {0}2.IdProd" +
                                 " WHERE IdAgcera1 = " + idAgcera, tableName);
        }
    }
}