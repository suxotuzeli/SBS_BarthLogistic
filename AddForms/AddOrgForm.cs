using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddOrgForm : XtraForm
    {
        readonly bool editing;
        readonly int id;
        readonly string tableName = "Org";
        CLSTableOperation clsData;

        public AddOrgForm()
        {
            id = 0;
            editing = false;
            tableName = GlobalParameters.TableName;
            InitializeComponent();
        }
        public AddOrgForm(int id, bool editing)
        {
            this.id = id;
            this.editing = editing;
            InitializeComponent();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void AddOrgForm_Load(object sender, EventArgs e)
        {
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);
            this.ChangeFonts();
            GlobalParameters.IDForFind = 0;
            clsData = new CLSTableOperation(this, tableName);

            if (id > 0)
            {
                Text = "ორგანიზაციის რედაქტირება";
                clsData.InitialazeControls(id);
            }
            else
                Text = "ორგანიზაციის ჩამატება";
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            clsData.Update(id);
            GlobalParameters.IDForFind = id;
            Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalParameters.IDForFind = clsData.Insert();
            txtOrg.Text = "";
            txtOrg.Focus();
            Close();
        }

        void btnCheckSagad_Click(object sender, EventArgs e)
        {
            var wayBill = new CLSWayBillOperation();
            var gvari = wayBill.GetNameFromTin(txtSagad.Text);
            if (gvari == "")
            {
                XtraMessageBox.Show("ასეთი საიდენტიფიკაციო კოდი არ მოიძებნა");
                return;
            }
            if (txtOrg.Text != gvari)
            {
                if (
                    XtraMessageBox.Show(
                        "ორგანიზაციის დასახელება განსხვავებულია, შევცვალოთ მიმდინარე ჩანაწერი: \n ძველი: " + txtOrg.Text +
                        "\n ახალი: " + gvari, "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    txtOrg.Text = gvari;
                return;
            }
            XtraMessageBox.Show("ჩანაწერი იდენტურია");
        }
    }
}