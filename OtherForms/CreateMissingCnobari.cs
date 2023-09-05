using System;
using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class CreateMissingCnobari : XtraForm
    {
        readonly string cnobariColumnName;
        readonly string cnobariTableName;
        readonly string columnName;

        public CreateMissingCnobari(string columnName, string cnobariTableName, string cnobariColumnName)
        {
            this.columnName = columnName;
            this.cnobariTableName = cnobariTableName;
            this.cnobariColumnName = cnobariColumnName;
            InitializeComponent();
        }

        void CreateMissingCnobari_Load(object sender, EventArgs e)
        {
            colName.FieldName = cnobariColumnName;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void btnImport_Click(object sender, EventArgs e)
        {
            //InterfaceParameters.CloseForm = true;
            //var o = Activator.CreateInstance(
            //    Type.GetType(Assembly.GetExecutingAssembly().GetName().Name + ".AddForms.Add" + cnobariTableName + "Form"));
            //if (o == null)
            //{
            //    Close();
            //    return;
            //}
            //var instance = (Form)o;
            //instance.StartPosition = FormStartPosition.CenterParent;
            //instance.ShowDialog();
            //InterfaceParameters.CloseForm = false;

            //foreach (var row in rows)
            //{
            //    SQL.Insert(string.Format("INSERT INTO {0}({0}) VALUES(N'{1}')", cnobariTableName, row[columnName]));
            //}
            //MessageBox.Show("ცნობარების იმპორტი დასრულებულია!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}