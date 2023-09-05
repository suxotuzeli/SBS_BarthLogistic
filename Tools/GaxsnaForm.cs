using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Parameters;

namespace SBS_BarthLogistic.Tools
{
    public partial class GaxsnaForm : XtraForm
    {
        public GaxsnaForm()
        {
            InitializeComponent();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            ProceduresClass.spDgeGaxsna("spDelDge", txtData1.DateTime);
            Close();
        }

        void GaxsnaForm_Load(object sender, EventArgs e)
        {
            txtData1.DateTime = DateTime.Today;
        }
    }
}