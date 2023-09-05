
using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.Tools
{
    public partial class AboutForm : XtraForm
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        void linkLabel1_LinkClicked(object sender, HyperlinkClickEventArgs e)
        {
            Process.Start("http://www.fmgsoft.ge");
        }

        void AboutForm_Activated(object sender, EventArgs e)
        {
            txtInfo.BackColor = BackColor;
            laUN.Text = GlobalParameters.UserName;
            var versia = SQL.Select("SELECT Versia FROM Versia");
            laVersia.Text = versia.Rows[0][0].ToString();
            laBuild.Text = Application.ProductVersion;
        }

        void laBuild_Click(object sender, EventArgs e)
        {
        }

        void AboutForm_Load(object sender, EventArgs e)
        {
        }
    }
}