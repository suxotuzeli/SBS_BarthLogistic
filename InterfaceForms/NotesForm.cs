using System;
using System.Data;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using SBS_Moms.Classes;
using SBS_Moms.Controls;

namespace SBS_Moms.InterfaceForms
{
    public partial class NotesForm : XtraForm
    {

        public NotesForm()
        {
            InitializeComponent();
            exListBox1.DoubleClick += exListBox1_SelectedIndexChanged;
        }

        void exListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var boxItem = ((FMGListBoxItem)exListBox1.SelectedItem);
            if (boxItem == null) return;
            string id = boxItem.Id;
            string title = boxItem.Title;
            lcChat.Items.Clear();
            var table =
                SQL.Select(string.Format(" SELECT * FROM AdminNote WHERE (IdTanam1 = {0} AND IdTanam2 = {1}) " +
                                         " OR (IdTanam1 = {1} AND IdTanam2 = {0}) ORDER BY CD Desc",
                                         id, DefaultValues.IdTanam));
            foreach (DataRow row in table.Rows)
            {
                var item = new FMGListBoxItem(row["IdTanam1"].ToString(), title, row["Note"].ToString(),
                    DefaultValues.IdTanam.ToString() == row["IdTanam1"].ToString(), false);
                lcChat.Items.Add(item);
            }
        }

        void NotesForm_Load(object sender, EventArgs e)
        {
            LoadNotes();
        }

        void LoadNotes()
        {
            exListBox1.Items.Clear();
            var dtBd = SQL.Select(" SELECT Params.IdTanam, Tanam.Tanam, Params.UN, MAX(AdminNote.Data) AS Data FROM Params " +
                                  " INNER JOIN Tanam ON Params.IdTanam = Tanam.IdTanam " +
                                  " LEFT JOIN AdminNote ON Params.IdTanam = AdminNote.IdTanam2 " +
                                  //" WHERE Params.IdTanam <> " + DefaultValues.IdTanam +
                                  " GROUP BY Params.IdTanam, Tanam.Tanam, Params.UN " +
                                  " ORDER BY MAX(AdminNote.Data) DESC ");
            foreach (DataRow row in dtBd.Rows)
            {
                var item = new FMGListBoxItem(row["IdTanam"].ToString(),
                    row["Tanam"].ToString(), row["Data"].ToString(),
                    true, DefaultValues.IdTanam.ToString() == row["IdTanam"].ToString());
                exListBox1.Items.Add(item);
            }
        }

        void btnAddNote_ItemClick(object sender, ItemClickEventArgs e)
        {
            new NoteForm().ShowDialog();
            LoadNotes();
        }
    }
}