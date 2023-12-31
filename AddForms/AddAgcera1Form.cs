using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddAgcera1Form : XtraForm
    {
        readonly bool editing;
        readonly int id, idAgcera1;
        readonly string tableName;
        bool checkData = true;
        CLSTableOperation clsAgcera1;
        AddAgcera2Form fmAddAgcera2;

        public AddAgcera1Form()
        {
            InitializeComponent();
        }

        public AddAgcera1Form(int id, bool editing)
        {
            this.id = id;
            this.editing = editing;
            InitializeComponent();
        }

        public AddAgcera1Form(int id, bool editing, string tableName) : this(id, editing)
        {
            this.tableName = tableName;
        }

        public AddAgcera1Form(int id, bool editing, string tableName, int idAgcera1)
            : this(id, editing)
        {
            this.tableName = tableName;
            this.idAgcera1 = idAgcera1;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            checkData = false;
            Close();
        }

        void AddAgcera1Form_Load(object sender, EventArgs e)
        {
            clsAgcera1 = new CLSTableOperation(this, tableName);
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);
            this.ChangeFonts();
            SetDefaultValuesFromParameters();
            txtData.SetDateFormat();

            if (id > 0)
            {
                Text = "აღწერის რედაქტირება";
                clsAgcera1.InitialazeControls(id);
            }
            else
            {
                Text = "აღწერის ჩამატება";
            }
        }

        void SetDefaultValuesFromParameters()
        {
            if (!editing)
            {
                if (DefaultValues.chbProek)
                    cbProek.EditValue = DefaultValues.IdProek;
            }
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            clsAgcera1.Update(id);
            Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var masterId = clsAgcera1.Insert();
            if (idAgcera1 > 0)
            {
                SQL.Insert(string.Format("INSERT INTO Agcera2(idAgcera1,IdProd,Raod,UN,CD) " +
                                         "SELECT {0},IdProd, Raod, N'{1}', Getdate() FROM Modz2 WHERE idAgcera1={2}",
                    masterId, GlobalParameters.UserName, idAgcera1));
                Close();
            }
            else
            {
                GlobalParameters.IDForFind = masterId;
                txtShen.Text = "";
                txtData.Focus();
                if (masterId > 0)
                    ShowAddDetForm(masterId);
            }
        }

        void ShowAddDetForm(int masterId)
        {
            var bOpen = false;
            foreach (var f in MdiParent.MdiChildren)
            {
                if (f is AddAgcera2Form)
                    bOpen = true;
            }
            if (!bOpen)
            {
                fmAddAgcera2 = new AddAgcera2Form(0, false, "Agcera2", masterId);
                fmAddAgcera2.MdiParent = MdiParent;
            }
            fmAddAgcera2.Show();
        }

        void textBox1_Leave(object sender, EventArgs e)
        {
            if (!txtData.CanUserModifyData() && checkData)
            {
                XtraMessageBox.Show("თქვენ არ შეგიძლიათ ამ თარიღით ინფორმაციის შეტანა!", "შეცდომა", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtData.Focus();
            }
        }
    }
}