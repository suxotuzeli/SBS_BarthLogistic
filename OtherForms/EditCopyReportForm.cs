using System;
using System.IO;
using System.Windows.Forms;
using SBS_Market.Classes;
using SBS_Market.Parameters;

namespace SBS_Market.OtherForms
{
    public partial class EditCopyReportForm : Form
    {
        private readonly string schema, id, name, desc;
        private readonly bool isShabloni, editing;

        public EditCopyReportForm()
        {
            InitializeComponent();
        }

        public EditCopyReportForm(string schema, string id, string name, string desc, bool isShabloni, bool editing)
        {
            this.schema = schema;
            this.id = id;
            this.name = name;
            this.desc = desc;
            this.isShabloni = isShabloni;
            this.editing = editing;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditCopyReportForm_Load(object sender, EventArgs e)
        {
            txtReportSchema.Text = schema;
            txtReportName.Text = name;
            txtReportDesc.Text = desc;

            if(isShabloni) {
                laSchema.Visible = false;
                txtReportSchema.Visible = false;
            }
            if(editing)
                txtReportName.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(editing)
                Update();
            else
                Insert();
        }

        private void Insert()
        {
            try {
                if(name == txtReportName.Text) {
                    MessageBox.Show("თქვენ არ შეგიცვლიათ ფაილის სახელი");
                    return;
                }
                if (File.Exists(txtReportName.Text)) {
                    MessageBox.Show("ასეთი ფაილი უკვე არსებობს");
                    return;
                }
                File.Copy(name, txtReportName.Text);
                string strComm = "INSERT INTO Reports"
                                 + "(ReportName, ReportSchema, ReportDesc, isShabloni) "
                                 + " VALUES (N'" + txtReportName.Text + "'"
                                 + ", N'" + txtReportSchema.Text + "'"
                                 + ", N'" + txtReportDesc.Text + "' "
                                 + ", 0"
                                 + ") ";
                SQL.Insert(strComm);
                Close();
            }
            catch {
                
                
            }
        }

        private new void Update()
        {
            string strComm = "UPDATE Reports"
                + " SET ReportName = N'" + txtReportName.Text + "'"
                + ", ReportSchema = N'" + txtReportSchema.Text + "' "
                + ", ReportDesc = N'" + txtReportDesc.Text + "' "
                + "WHERE IdReports = " + id;
            SQL.Update(strComm);
            Close();

        }
    }
}
