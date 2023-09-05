using System;
using System.Text;
using System.Windows.Forms;
using SBS_Market.Parameters;

namespace SBS_Market.OtherForms
{
    public partial class SQLExecute : Form
    {

        public SQLExecute()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            string[] ss = txtScript.Text.Split('\n');
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string s in ss){
                if (s.ToUpper() == "GO\r" || s.ToUpper() == "GO") {
                    DBClass.ExecuteSQL(stringBuilder.ToString());
                    stringBuilder.Remove(0, stringBuilder.Length);
                }
                else{
                    stringBuilder.Append(s + "\n ");
                }
            }
//            DBClass.ExecuteSQL(txtScript.Text);
            Close();
        }
     
    }
}
