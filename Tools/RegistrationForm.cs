using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.Win32;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.InterfaceForms;

namespace SBS_BarthLogistic.Tools
{
    public partial class RegistrationForm : XtraForm
    {
        readonly List<string> usrs = new List<string>();
        RegistryKey key;
        string keyPath;

        string[] users =
        {
            "sa"
        };

        public RegistrationForm()
        {
            InitializeComponent();
        }

        public RegistrationForm(string userName)
        {
            User = userName;
            InitializeComponent();
        }

        public string User { get; set; }
        public string Pass { get; set; }

        void btnOK_Click(object sender, EventArgs e)
        {
            Pass = txtPass.Text;
            User = cbUser.Text;
            Registry.SetValue(InterfaceParameters.RegKey, "DefaultUser", cbUser.Text, RegistryValueKind.String);
            txtUser_Leave(sender, e);
        }

        void RegistrationForm_Load(object sender, EventArgs e)
        {
            var defaultuser = "sa";
            keyPath = "SOFTWARE\\FMGSoft\\" + Application.ProductName + "\\";
            InterfaceParameters.RegKey = "HKEY_CURRENT_USER\\" + keyPath;
            key = Registry.CurrentUser.CreateSubKey(keyPath);
            try
            {
                users = (string[])key.GetValue("Users", "sa");
                defaultuser = (string)key.GetValue("defaultuser", "sa");
            }
            catch
            {
                Registry.SetValue(InterfaceParameters.RegKey, "Users", users, RegistryValueKind.MultiString);
            }
            key.Close();
            cbUser.Properties.Items.AddRange(users);
            if (cbUser.Properties.Items.Count > 0)
                cbUser.SelectedText = defaultuser;
            txtPass.Text = "aaa";
        }

        void txtUser_Leave(object sender, EventArgs e)
        {
            usrs.Clear();
            foreach (string t in users)
                if (t != cbUser.Text)
                    usrs.Add(t);
            if ((sender as SimpleButton).Name == "btnOK")
                usrs.Add(cbUser.Text);
            users.Initialize();
            users = usrs.ToArray();
            Registry.SetValue(InterfaceParameters.RegKey, "Users", users, RegistryValueKind.MultiString);
        }

        void btnDel_Enter(object sender, EventArgs e)
        {
            txtUser_Leave(sender, e);
            cbUser.Focus();
            cbUser.Properties.Items.Clear();
            cbUser.Properties.Items.AddRange(users);
            if (cbUser.Properties.Items.Count > 0)
                cbUser.SelectedIndex = 0;
        }

        private void paParams_DoubleClick(object sender, EventArgs e)
        {
            new CreateParamsini().ShowDialog();
        }
    }
}