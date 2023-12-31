using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddInvoices1Form : XtraForm
    {
        readonly bool editing;
        readonly int id, idInvoices1;
        readonly string tableName;
        bool checkData = true;
        CLSTableOperation clsInvoices1;
        AddInvoices2Form fmAddGas2;

        public AddInvoices1Form()
        {
            InitializeComponent();
        }

        public AddInvoices1Form(int id, bool editing)
        {
            this.id = id;
            this.editing = editing;
            InitializeComponent();
        }

        public AddInvoices1Form(int id, bool editing, string tableName) : this(id, editing)
        {
            this.tableName = tableName;
        }

        public AddInvoices1Form(int id, bool editing, string tableName, int idInvoices1)
            : this(id, editing)
        {
            this.tableName = tableName;
            this.idInvoices1 = idInvoices1;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            checkData = false;
            Close();
        }

        void AddInvoices1Form_Load(object sender, EventArgs e)
        {
            clsInvoices1 = new CLSTableOperation(this, tableName);
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);
            this.ChangeFonts();
            txtData.SetDateFormat();

            if (id > 0)
            {
                Text = "გასავლის რედაქტირება";
                clsInvoices1.InitialazeControls(id);
            }
            else
            {
                Text = "გასავლის ჩამატება";
            }
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            clsInvoices1.Update(id);
            Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var masterId = clsInvoices1.Insert();
            GlobalParameters.IDForFind = masterId;
            txtShen.Text = "";
            txtData.Focus();
            if (masterId > 0)
                ShowAddDetForm(masterId);
            txtZedd.Text = "";
        }

        void ShowAddDetForm(int masterId)
        {
            var bOpen = false;
            foreach (var f in MdiParent.MdiChildren)
            {
                if (f is AddGas2Form)
                    bOpen = true;
            }
            if (!bOpen)
            {
                fmAddGas2 = new AddInvoices2Form(0, false, "Invoices2",masterId);
                fmAddGas2.MdiParent = MdiParent;
            }
            fmAddGas2.Show();
        }

        void txtZedd_Leave(object sender, EventArgs e)
        {
            if (!editing && txtZedd.Text == "")
                txtZedd.Text = SQLOperation.CalcZeddNum(tableName);
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