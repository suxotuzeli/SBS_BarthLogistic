using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddServiceRealForm : XtraForm
    {
        readonly bool editing;
        readonly int id;
        readonly string tableName;
        bool checkData = true;
        CLSTableOperation clsServiceReal;

        public AddServiceRealForm(int id, bool editing, string tableName)
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
            clsServiceReal = new CLSTableOperation(this, tableName);
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);
            this.ChangeFonts();

            if (id > 0)
            {
                Text = "კლიენტზე გაწეული სერვისის რედაქტირება";
                clsServiceReal.InitialazeControls(id);
                txtData.SetDateFormat(false);
            }
            else
            {
                Text = "კლიენტზე გაწეული სერვისის ჩამატება";
                txtData.SetDateFormat(true);
            }
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            clsServiceReal.Update(id);
            Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var dt = SQL.Select(
                $"SELECT TOP 1 Fasi FROM dbo.OrgServices WHERE IdOrg = {cbOrg.EditValue} AND IdService = {cbService.EditValue}");
            if (dt.Rows.Count > 0)
            {
                clsServiceReal.AdditionalFieldsCount = 1;
                clsServiceReal.AdditionalFields = new[] {"TanxaStandart"};
                clsServiceReal.AdditionalValues = new[] {dt.Rows[0][0].ToString()};
            }
            var masterId = clsServiceReal.Insert();
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

        private void TxtZedd_Leave(object sender, EventArgs e)
        {
            if (!editing && txtZedd.Text == "")
                txtZedd.Text = SQLOperation.CalcZeddNum(tableName);
        }
    }
}