using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class GenerateMomcShekForm : XtraForm
    {
        const string TableName = "Shes1";
        readonly int id;
        int idProek, idMomc;

        public GenerateMomcShekForm(int id, int idProek, int idMomc)
        {
            this.id = id;
            this.idProek = idProek;
            this.idMomc = idMomc;
            InitializeComponent();
        }

        void GenerateMomcShekToShesForm_Load(object sender, EventArgs e)
        {
            Text = "რეალიზაციის მიხედვით შეკვეთის გენერირება";
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
        }

        void btnFind_Click(object sender, EventArgs e)
        {
            var proc = new CLSSpAll(panel2, "spGenerateMomcShek");
            proc.AddParameter("IdMomcShek1", id);
            dgShesShek.DataSource = proc.Exceute();
        }
    }
}