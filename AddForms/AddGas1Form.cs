using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddGas1Form : XtraForm
    {
        readonly bool editing;
        readonly int id, idGas1;
        readonly string tableName;
        bool checkData = true;
        CLSTableOperation clsGas1;
        AddGas2Form fmAddGas2;

        public AddGas1Form()
        {
            InitializeComponent();
        }

        public AddGas1Form(int id, bool editing)
        {
            this.id = id;
            this.editing = editing;
            InitializeComponent();
        }

        public AddGas1Form(int id, bool editing, string tableName) : this(id, editing)
        {
            this.tableName = tableName;
        }

        public AddGas1Form(int id, bool editing, string tableName, int idGas1)
            : this(id, editing)
        {
            this.tableName = tableName;
            this.idGas1 = idGas1;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            checkData = false;
            Close();
        }

        void AddGas1Form_Load(object sender, EventArgs e)
        {
            clsGas1 = new CLSTableOperation(this, tableName);
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);
            this.ChangeFonts();
            SetDefaultValuesFromParameters();
            txtData.SetDateFormat();

            if (id > 0)
            {
                Text = "გასავლის რედაქტირება";
                clsGas1.InitialazeControls(id);
            }
            else
            {
                Text = "გასავლის ჩამატება";
                if (idGas1 > 0)
                    SetModzValues();
            }
        }

        void SetDefaultValuesFromParameters()
        {
            if (!editing)
            {
                if (DefaultValues.chbProek)
                    cbProek.EditValue = DefaultValues.IdProek;
                if (DefaultValues.chbGasT)
                    cbGasT.EditValue = DefaultValues.IdGasT;
            }
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            clsGas1.Update(id);
            Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var masterId = clsGas1.Insert();
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
                fmAddGas2 = new AddGas2Form(0, false, "Gas2", masterId) {MdiParent = MdiParent};
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

        void SetModzValues()
        {
            var dt = SQL.Select("SELECt Data, Zedd, IdProek1 FROM Modz1 WHERE idGas1=" + idGas1);
            cbProek.EditValue = dt.Rows[0]["IdProek1"];
            txtData.DateTime = Convert.ToDateTime(dt.Rows[0]["Data"]);
            txtZedd.Text = dt.Rows[0]["zedd"].ToString();
        }
    }
}