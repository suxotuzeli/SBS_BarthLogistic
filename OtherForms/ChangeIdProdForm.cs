using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class ChangeIdProdForm : XtraForm
    {
        public ChangeIdProdForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var ans = XtraMessageBox.Show("დარწმუნებული ხართო რომ გსურთ ცვლილება", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(ans != DialogResult.Yes)return;

            foreach (CheckedListBoxItem item in chbListOfTables.CheckedItems)
            {
                var tableName = item.Tag.ToString();

                var cmd = $"UPDATE t2 SET t2.IdProd = N'{fmgIdProd2.Id}' FROM dbo.{tableName} t2";
                var filter = $" WHERE Data BETWEEN '{txtData1.DateTime.ToShortDateString()}' AND '{txtData2.DateTime.ToShortDateString()}' AND t2.IdProd = N'{fmgIdProd1.Id}'";
                //უთარიღოები
                if (tableName == "CalcProd" || tableName == "Calc")
                    filter = $" WHERE IdProd = N'{fmgIdProd1.Id}'";
                if (tableName.EndsWith("2"))
                {
                    var tableName1 = tableName.TrimEnd('2') + "1";
                    cmd += $" INNER JOIN dbo.{tableName1} t1 ON t1.Id{tableName1} = t2.Id{tableName1}";
                }

                SQL.Update(cmd + filter,false);
            }

            Close();
        }

        private void ChangeIdProdForm_Load(object sender, EventArgs e)
        {
            txtData1.SetDateFormat();
            txtData2.SetDateFormat();
            AddTableToList("Calc","კალკულაცია");
            AddTableToList("CalcProd","კალკულაციის შემადგენელი პროდ.");
            AddTableToList("Carm1","ნაწარმოები პროდ.");
            AddTableToList("Carm2","წარმოებაზე დახარჯული ნედლ.");
            AddTableToList("Dabr2","დაბრუნება");
            AddTableToList("Gadadeba2","შეკვეთა");
            AddTableToList("Gas2","გასავალი");
            AddTableToList("MDabr2","მომწოდებელზე დაბრუნება");
            AddTableToList("Modz2","მოძრაობა");
            AddTableToList("RealDel","გაუქმებული რეალიზაცია");
            AddTableToList("Real2","რეალიზაცია");
            AddTableToList("Shem2","შემოსავალი");
            AddTableToList("Shes2","შესყიდვა");
            chbListOfTables.CheckAll();

        }

        private void AddTableToList(string tableName, string title)
        {
            var item = new CheckedListBoxItem
            {
                Value = title,
                Tag = tableName.Translate()
            };
            chbListOfTables.Items.Add(item);
        }
    }
}
