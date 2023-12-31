using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddSalForm : XtraForm
    {
        readonly bool editing;
        readonly int id;
        readonly string tableName;
        bool checkData = true;
        CLSTableOperation clsGvari;

        public AddSalForm(int id, bool editing, string tableName)
        {
            this.id = id;
            this.editing = editing;
            this.tableName = tableName;
            InitializeComponent();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            checkData = false;
            Close();
        }

        void AddSalForm_Load(object sender, EventArgs e)
        {
            clsGvari = new CLSTableOperation(this, tableName);
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);
            this.ChangeFonts();

            SetDefaultValuesFromParameters();

            if (id > 0)
            {
                Text = "თანხის გადახდის რედაქტირება";
                clsGvari.InitialazeControls(id);
                txtData.SetDateFormat(false);
            }
            else
            {
                Text = "თანხის გადახდის ჩამატება";
                txtData.SetDateFormat(true);
            }
        }

        void SetDefaultValuesFromParameters()
        {
            if (!editing)
            {
                if (DefaultValues.chbSalT)
                {
                    cbSalT.EditValue = DefaultValues.IdSalT;
                    cbSalaro.EditValue = DefaultValues.IdSalaro;
                }
            }
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            clsGvari.Update(id);
            Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var masterId = clsGvari.Insert();
            GlobalParameters.IDForFind = masterId;
            txtShen.Text = "";
            txtTanxa.Value = 0;
            txtZedd.Text = "";
            txtData.Focus();
        }

        void txtData_Leave(object sender, EventArgs e)
        {
            if (!txtData.CanUserModifyData() && checkData)
            {
                XtraMessageBox.Show("თქვენ არ შეგიძლიათ ამ თარიღით ინფორმაციის შეტანა!", "შეცდომა", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtData.Focus();
            }
        }

        void txtZedd_Enter(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void cbSalaro_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtZedd.Text))
                txtZedd.Text = SQLOperation.CalcZeddNum(tableName);
        }
    }
}