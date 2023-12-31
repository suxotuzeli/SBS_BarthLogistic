using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddModz1Form : XtraForm
    {
        readonly bool editing;
        readonly int id;
        readonly string idProek1;
        readonly string idProek2;
        readonly string tableName;
        bool checkData = true;
        CLSTableOperation clsModz1;
        AddModz2Form fmAddModz2;
        readonly bool fromShek;

        public AddModz1Form(int id, bool editing, string tableName)
        {
            this.tableName = tableName;
            this.id = id;
            this.editing = editing;
            InitializeComponent();
        }

        public AddModz1Form(int id, bool editing, string tableName, string idProek1, string idProek2)
        {
            fromShek = true;
            this.tableName = tableName;
            this.id = id;
            this.idProek1 = idProek1;
            this.idProek2 = idProek2;
            this.editing = editing;
            InitializeComponent();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            checkData = false;
            Close();
        }

        void AddModz1Form_Load(object sender, EventArgs e)
        {
            clsModz1 = new CLSTableOperation(this, tableName);
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);
            this.ChangeFonts();
            SetDefaultValuesFromParameters();
            if (id > 0)
            {
                Text = "მოძრაობის რედაქტირება";
                clsModz1.InitialazeControls(id);
                txtData.SetDateFormat(false);
            }
            else
            {
                Text = "მოძრაობის ჩამატება";
                txtData.SetDateFormat();
                if (!fromShek) return;
                cbProek1.SetLookUpEditValue(idProek1);
                cbProek2.SetLookUpEditValue(idProek2);
            }
        }

        void SetDefaultValuesFromParameters()
        {
            if (!editing)
            {
                if (DefaultValues.chbProek)
                    cbProek1.EditValue = DefaultValues.IdProek;
                if (DefaultValues.chbModzT)
                    cbModzT.EditValue = DefaultValues.IdModzT;
            }
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            clsModz1.Update(id);
            Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var masterId = clsModz1.Insert();
            GlobalParameters.IDForFind = masterId;

            if (fromShek)
            {
                Close();
                return;
            }

            txtShen.Text = "";
            txtData.Focus();
            if (masterId > 0)
                ShowAddDetForm(masterId);
            txtZedd.Text = "";
        }

        void ShowAddDetForm(int masterId)
        {
            if (fromShek) return;
            var bOpen = false;
            foreach (var f in MdiParent.MdiChildren)
            {
                if (f is AddModz2Form)
                    bOpen = true;
            }
            if (!bOpen)
            {
                fmAddModz2 = new AddModz2Form(0, false, "Modz2", txtZedd.Text, masterId);
                fmAddModz2.MdiParent = MdiParent;
            }
            fmAddModz2.Show();
        }

        void txtZedd_Leave(object sender, EventArgs e)
        {
            if (!(!editing && txtZedd.Text == ""))
                return;

            txtZedd.Text = SQLOperation.CalcZeddNum(tableName);
        }

        void txtData_Leave(object sender, EventArgs e)
        {
            if (!txtData.DateTime.CanUserModifyData() && checkData)
            {
                XtraMessageBox.Show("თქვენ არ შეგიძლიათ ამ თარიღით ინფორმაციის შეტანა!", "შეცდომა", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtData.Focus();
            }
        }
    }
}