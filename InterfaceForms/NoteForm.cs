using System;
using System.Text;
using DevExpress.XtraEditors;
using SBS_Moms.Classes;

namespace SBS_Moms.InterfaceForms
{
    public partial class NoteForm : XtraForm
    {
        public NoteForm()
        {
            InitializeComponent();
        }

        void NoteForm_Load(object sender, EventArgs e)
        {
            paTop.ChangeFonts();
        }

        void chbTanam_CheckedChanged(object sender, EventArgs e)
        {
            btnSave.Text = chbTanamshromeli.Checked ? "Send" : "Save";
        }

        void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            StringBuilder cmd = new StringBuilder("INSERT INTO AdminNote(IdTanam1, IdTanam2, Note, Data, CD) ");
            cmd.AppendFormat("VALUES ({0}, {1}, ", DefaultValues.IdTanam,
                chbTanamshromeli.Checked ? cbTanam.EditValue : DefaultValues.IdTanam);
            cmd.AppendFormat("N'{0}', GETDATE(), GETDATE())", txtNote.Text);
            SQL.Insert(cmd.ToString());
        }
    }
}