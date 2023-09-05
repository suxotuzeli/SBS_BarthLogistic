using System;
using System.Windows.Forms;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class FinishOperation : Form
    {
        private string tableName;
        private int id;
        public FinishOperation(string tableName, int id)
        {
            this.tableName = tableName;
            this.id = id;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SQL.Update($"UPDATE {tableName} SET TotalOcupatedArea = {txtPalet.EditValue} WHERE Id{tableName} = {id}");
            Close();
        }
    }
}
