using System;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.AddForms;
using ComboBox = System.Windows.Forms.ComboBox;

namespace SBS_BarthLogistic.Classes
{
    /// <summary>
    /// -- ვერსია 0.2 -- 24 Mar 2016 15:00 ნიკა
    /// . აწ უკვე მუშაობს Combobox-ზეც :)
    /// -- ვერსია 0.1 -- 23 Oct 2015 14:00 ნიკა
    /// . შეიცვალა ფუნქცია CreateFormDialog, მიეთითა პროექტის სახელი წინ, რაც უნივერსალურია ვიდრე ხელით ეწეროს
    /// </summary>

    class CLSAddToCombo
    {
        string caption, tableName;

        public void ShowAddForm(Control ctl)
        {
            if (ctl is LookUpEdit)
            {
                var fullTableName = ctl.Name.Remove(0, 2);
                tableName = char.IsDigit(fullTableName[fullTableName.Length - 1])
                    ? fullTableName.Remove(fullTableName.Length - 1)
                    : fullTableName;

                using (var dt = SQL.Select("SELECT TOP 1 * FROM AdminCombos WHERE ComboName = N'" + tableName + "'"))
                {
                    if (dt.Rows.Count < 1)
                        return;
                    switch (Convert.ToInt32(dt.Rows[0]["FormType"].ToString()))
                    {
                        case 0:
                            return;
                        case 10:
                        case 20:
                        case 30:
                            caption = dt.Rows[0]["ComboCaption"].ToString();
                            miAdd_Click();
                            break;
                        case 100:
                            caption = dt.Rows[0]["ComboCaption"].ToString();
                            mi_Click();
                            break;
                    }
                }
                ((LookUpEdit)ctl).FillDataToLookUpEditAndSetFont(fullTableName);
                if (GlobalParameters.IDForFind > 0)
                    ((LookUpEdit)ctl).SetLookUpEditValue(GlobalParameters.IDForFind.ToString());
            }
            if (ctl is ComboBox)
            {
                var fullTableName = ctl.Name.Remove(0, 2);
                tableName = char.IsDigit(fullTableName[fullTableName.Length - 1])
                    ? fullTableName.Remove(fullTableName.Length - 1)
                    : fullTableName;

                using (var dt = SQL.Select("SELECT TOP 1 * FROM AdminCombos WHERE ComboName = N'" + tableName + "'"))
                {
                    if (dt.Rows.Count < 1)
                        return;
                    switch (Convert.ToInt32(dt.Rows[0]["FormType"].ToString()))
                    {
                        case 0:
                            return;
                        case 10:
                        case 20:
                        case 30:
                            caption = dt.Rows[0]["ComboCaption"].ToString();
                            miAdd_Click();
                            break;
                        case 100:
                            caption = dt.Rows[0]["ComboCaption"].ToString();
                            mi_Click();
                            break;
                    }
                }
                if (GlobalParameters.IDForFind > 0)
                {
                    ((ComboBox)ctl).FillDataToComboBoxAndSetFont(fullTableName);
                    ((ComboBox)ctl).SelectedValue = GlobalParameters.IDForFind.ToString();
                }
            }
        }

        void miAdd_Click()
        {
            InterfaceParameters.CloseForm = true;
            GlobalParameters.TableName = tableName;
            GlobalParameters.FieldName = caption;
            new AddAllForm().ShowDialog();
            InterfaceParameters.CloseForm = false;
        }

        void mi_Click()
        {
            InterfaceParameters.CloseForm = true;
            GlobalParameters.TableName = tableName;
            GlobalParameters.FieldName = caption;
            CreateFormDialog(tableName);
            InterfaceParameters.CloseForm = false;
        }

        public static void CreateFormDialog(string tn)
        {
            InterfaceParameters.CloseForm = true;
            var instance = (Form)Activator.CreateInstance(Type.GetType(Assembly.GetExecutingAssembly().GetName().Name + ".AddForms.Add" + tn + "Form"));
            instance.StartPosition = FormStartPosition.CenterParent;
            instance.ShowDialog();
            InterfaceParameters.CloseForm = false;
        }
    }
}