using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddMdzForm : XtraForm
    {
        readonly bool editing;
        readonly int id;
        readonly string tableName;
        CLSTableOperation clsData;

        public AddMdzForm()
        {
            id = 0;
            editing = false;
            tableName = GlobalParameters.TableName;
            InitializeComponent();
        }
        public AddMdzForm(int id, bool editing, string tableName)
        {
            this.id = id;
            this.editing = editing;
            this.tableName = tableName;
            InitializeComponent();
        }

        public AddMdzForm(string tableName, string mdzSagad, string manqana, string mdz)
        {
            id = 0;
            editing = false;
            this.tableName = tableName;
            InitializeComponent();
            txtPiradiNom.Text = mdzSagad;
            txtMan.Text = manqana;
            txtMdz.Text = mdz;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void AddMdzForm_Load(object sender, EventArgs e)
        {
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);
            this.ChangeFonts();
            GlobalParameters.IDForFind = 0;
            clsData = new CLSTableOperation(this, tableName, false);

            if (id > 0)
            {
                Text = "მძღოლის რედაქტირება";
                clsData.InitialazeControls(id);
            }
            else
                Text = "მძღოლის ჩამატება";
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
            txtMdz.Text = "";
            txtMdz.Focus();
            //if (InterfaceParameters.CloseForm)
            Close();
        }

        void btnCheckSagad_Click(object sender, EventArgs e)
        {
            var wayBill = new CLSWayBillOperation();
            var gvari = wayBill.GetNameFromTin(txtPiradiNom.Text);
            if (gvari == "")
            {
                XtraMessageBox.Show("ასეთი საიდენტიფიკაციო კოდი არ მოიძებნა");
                return;
            }
            if (txtMdz.Text != gvari)
            {
                if (
                    XtraMessageBox.Show(
                        "ორგანიზაციის დასახელება განსხვავებულია, შევცვალოთ მიმდინარე ჩანაწერი: \n ძველი: " + txtMdz.Text +
                        "\n ახალი: " + gvari, "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    txtMdz.Text = gvari;
                return;
            }
            XtraMessageBox.Show("ჩანაწერი იდენტურია");
        }
    }
}