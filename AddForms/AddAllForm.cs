using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddAllForm : XtraForm
    {
        readonly bool editing;
        readonly int id;
        readonly string tableName;
        CLSTableOperation clsData;
        string fieldName;

        public AddAllForm()
        {
            id = 0;
            editing = false;
            tableName = GlobalParameters.TableName;
            fieldName = GlobalParameters.FieldName;
            InitializeComponent();
        }

        public AddAllForm(int id, bool editing, string tableName, string fieldName)
        {
            this.id = id;
            this.editing = editing;
            this.tableName = tableName;
            this.fieldName = fieldName;
            InitializeComponent();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void AddForm_Load(object sender, EventArgs e)
        {
            paComponents.Name = "pa" + tableName;
            CLSAedAll aed = new CLSAedAll(tableName, paComponents);
            bool userInformation = aed.HasUserInformation();
            aed.GenerateFormControls();
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);
            paComponents.ChangeFonts();
            GlobalParameters.IDForFind = 0;
            clsData = new CLSTableOperation(paComponents, tableName, userInformation);

            this.SetAddFormText(tableName, editing, id);

            //TODO ნიკა: აქ უნდა თარგმანი 
            if (id > 0)
                clsData.InitialazeControls(id);
            //if (editing)
            //    Text = "რედაქტირება (" + fieldName + ")";
            //else
            //    Text = "ჩამატება (" + fieldName + ")";
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
            paComponents.Controls["txt" + tableName].Focus();
            paComponents.Controls["txt" + tableName].Text = string.Empty;
            if (InterfaceParameters.CloseForm)
                Close();
        }
    }
}