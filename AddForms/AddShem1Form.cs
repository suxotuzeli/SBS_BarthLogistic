using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddShem1Form : XtraForm
    {
        readonly bool editing;
        readonly int id, idModz1;
        readonly string tableName;
        bool checkData = true;
        CLSTableOperation clsShem1;

        public AddShem1Form(int id, bool editing, string tableName)
        {
            this.id = id;
            this.editing = editing;
            this.tableName = tableName;
            InitializeComponent();
        }

        public AddShem1Form(int id, bool editing, string tableName, int idModz1)
            : this(id, editing, tableName)
        {
            this.idModz1 = idModz1;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            checkData = false;
            Close();
        }

        void AddShem1Form_Load(object sender, EventArgs e)
        {
            clsShem1 = new CLSTableOperation(this, tableName);
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);
            this.ChangeFonts();
            SetDefaultValuesFromParameters();
            txtData.SetDateFormat();
            txtKeepengData1.SetDateFormat();
            txtKeepengData2.SetDateFormat();


            if (id > 0)
            {
                Text = "შემოსავალი (რედაქტირება)";

                clsShem1.InitialazeControls(id);
            }
            else
            {
                Text = "შემოსავალი (ჩამატება)";
                if (idModz1 > 0)
                    SetModzValues();
            }
        }

        void SetDefaultValuesFromParameters()
        {
            if (!editing)
            {
                if (DefaultValues.chbProek)
                    cbProek.EditValue = DefaultValues.IdProek;
                if (DefaultValues.chbShemT)
                    cbShemT.EditValue = DefaultValues.IdShemT;
            }
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            clsShem1.Update(id);
            Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var masterId = clsShem1.Insert();

            if (idModz1 > 0)
            {
                SQL.Insert(string.Format("INSERT INTO Shem2(IdShem1, IdProd, Raod, UN, CD) " +
                                         "SELECT {0},IdProd, Raod, N'{1}', Getdate() FROM Modz2 WHERE IdModz1={2}",
                    masterId, GlobalParameters.UserName, idModz1));
                Close();
            }
            else
            {
                GlobalParameters.IDForFind = masterId;
                txtShen.Text = "";
                txtData.Focus();
                if (masterId > 0)
                    ShowAddDetForm(masterId);
                txtZedd.Text = "";
            }
        }

        void ShowAddDetForm(int masterId)
        {
            foreach (var f in MdiParent.MdiChildren)
            {
                if (f is AddShem2Form)
                {
                    f.Activate();
                    return;
                }
            }
            var fmAddShem2 = new AddShem2Form(0, false, "Shem2", masterId);
            fmAddShem2.MdiParent = MdiParent;
            fmAddShem2.Show();
        }

        void txtZedd_Leave(object sender, EventArgs e)
        {
            if (!editing && txtZedd.Text == "")
                txtZedd.Text = SQLOperation.CalcZeddNum(tableName);
        }

        void textBox1_Leave(object sender, EventArgs e)
        {
            if (!txtData.DateTime.CanUserModifyData() && checkData)
            {
                XtraMessageBox.Show("თქვენ არ შეგიძლიათ ამ თარიღით ინფორმაციის შეტანა!", "შეცდომა", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtData.Focus();
            }
        }

        void SetModzValues()
        {
            var dt = SQL.Select("SELECt Data, Zedd, IdProek2 FROM Modz1 WHERE IdModz1=" + idModz1);
            cbProek.EditValue = dt.Rows[0]["IdProek2"];
            txtData.DateTime = Convert.ToDateTime(dt.Rows[0]["Data"]);
            txtZedd.Text = dt.Rows[0]["zedd"].ToString();
        }
    }
}