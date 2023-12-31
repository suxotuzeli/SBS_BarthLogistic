using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.AddForms
{
    public partial class AddAdminCnobariForm : XtraForm
    {
        readonly bool editing;
        readonly string id;
        readonly string tableName;
        CLSTableOperation clsAdminCnobari;

        public AddAdminCnobariForm(string id, bool editing, string tableName)
        {
            this.id = id;
            this.editing = editing;
            this.tableName = tableName;
            InitializeComponent();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void AddAdminCnobariForm_Load(object sender, EventArgs e)
        {
            DataTable dt = SQL.Select("SELECT InterfaceLanguage, Caption FROM InterfaceLanguage");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LabelControl la = new LabelControl();
                la.Location = new Point(24, 144 + (i * 60));
                la.Text = dt.Rows[i]["Caption"].ToString();
                la.Name = "la" + dt.Rows[i]["InterfaceLanguage"];
                la.Font = new Font("Sylfaen", 9F);

                TextEdit txt = new TextEdit();
                txt.Location = new Point(24, 179 + (i * 60));
                txt.Name = "txt" + dt.Rows[i]["InterfaceLanguage"];
                txt.Size = new Size(678, 29);
                txt.TabIndex = i + 3;

                Controls.Add(la);
                Controls.Add(txt);
            }

            clsAdminCnobari = new CLSTableOperation(this, tableName, false);
            AcceptButton = CLSTools.SetButtonStyle(btnOK, btnAdd, editing);
            this.ChangeFonts();
            this.SetAddFormText(tableName, editing);
            GlobalParameters.IDForFind = 0;

            if (id != "0")
            {
                clsAdminCnobari.InitialazeControls(id);
            }
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            clsAdminCnobari.Update(id);
            GlobalParameters.IDForFind = Convert.ToInt32(id);
            DialogResult = DialogResult.OK;
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalParameters.IDForFind = clsAdminCnobari.Insert();
            DialogResult = DialogResult.OK;
        }
    }
}