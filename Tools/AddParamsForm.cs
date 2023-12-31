using System;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.Tools
{
    public partial class AddParamsForm : XtraForm
    {
        const string TableName = "Params";
        bool updateLanguage;
        bool userIsSa;

        public AddParamsForm()
        {
            InitializeComponent();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void AddParamsForm_Load(object sender, EventArgs e)
        {
            FillMomxParams();
            InitializeValues();
            tc.SetTexts();
            paUser.SetTexts(TableName);
            tpParams1.SetParamsTexts(TableName);
            tpParams2.SetParamsTexts(TableName);
            tpParams5.SetParamsTexts(TableName);
            cbInterfaceLanguage.SelectedValueChanged += delegate { updateLanguage = true; };
        }

        void SetPeriodText()
        {
            cbDefaultPeriodIndex.Items.Clear();
            cbDefaultPeriodIndex.Items.AddRange(new object[]
            {
                StringParameters.Today,
                StringParameters.Last3Days,
                StringParameters.LastWeek,
                StringParameters.LastMonth,
                StringParameters.LastYear,
                StringParameters.Everything
            });
        }

        void InitializeValues()
        {
            FillComboBoxes();
            var dr = SQL.FillParams(cbMomx.Text);


            txtData1.DateTime = Convert.ToDateTime(dr["Data1"].ToString());
            txtData2.DateTime = Convert.ToDateTime(dr["Data2"].ToString());
            chbCompanyDgg.Checked = Convert.ToBoolean(dr["CompanyDgg"].ToString());
            chbSaangPeriodi.Checked = Convert.ToBoolean(dr["SaangPeriodi"].ToString());
            cbDefaultPeriodIndex.SelectedIndex = Convert.ToInt32(dr["DefaultPeriodIndex"].ToString());
            chbRestoreDGSettings.Checked = Convert.ToBoolean(dr["RestoreDGSettings"].ToString());
            cbShemT.SelectedValue = dr["IdShemT"].ToString();
            cbGasT.SelectedValue = dr["IdGasT"].ToString();
            cbModzT.SelectedValue = dr["IdModzT"].ToString();
            cbCompany.SelectedValue = dr["IdCompany"].ToString();
            cbServiceForEveryDay.SelectedValue = dr["IdServiceForEveryDay"].ToString();

            cbDggStatus.SelectedValue = dr["IdDggStatus"].ToString();
            txtFasi.EditValue = Convert.ToDouble(dr["Fasi"]);
            chbDgFullSettings.Checked = Convert.ToBoolean(dr["DgFullSettings"].ToString());
            chbCreateLog.Checked = Convert.ToBoolean(dr["CreateLog"].ToString());
            chbCreateLogRs.Checked = Convert.ToBoolean(dr["CreateLogRs"].ToString());

            chbViewFullLog.Checked = Convert.ToBoolean(dr["ViewFullLog"].ToString());
            cbInterfaceLanguage.SelectedValue = dr["InterfaceLanguage"].ToString();
        }

        void FillMomxParams()
        {
            cbMomx.Text = GlobalParameters.UserName;
            var un = GlobalParameters.UserName.Length > 2
                ? GlobalParameters.UserName.Substring(0, 3)
                : GlobalParameters.UserName + "_";
            userIsSa = un == "sa_";
            if (!userIsSa)
            {
                paUser.Enabled = chbCopy.Visible = false;
                tc.TabPages.RemoveAt(0);
            }

            var dtUser = SQL.Select("SELECT UN FROM Params GROUP BY UN");
            cbMomx.Properties.DataSource = dtUser;
            cbMomx.Properties.ValueMember = "UN";
            cbMomx.Properties.DisplayMember = "UN";
            Text = "პარამეტრები - მომხმარებელი: " + GlobalParameters.UserName;
            cbMomx.EditValue = GlobalParameters.UserName;

            cbMomx.EditValueChanged += CbMomxSelectedIndexChanged;
            cbMomx2.Properties.DataSource = dtUser.Copy();
            cbMomx2.Properties.ValueMember = "UN";
            cbMomx2.Properties.DisplayMember = "UN";
            cbMomx.EditValue = GlobalParameters.UserName;
        }

        void CbMomxSelectedIndexChanged(object sender, EventArgs e)
        {
            tc.Enabled = false;
            InitializeValues();
            tc.Enabled = true;
        }

        void FillComboBoxes()
        {
            SetPeriodText();


            var dt = SQL.Select("SELECT InterfaceLanguage, Caption FROM InterfaceLanguage");
            cbInterfaceLanguage.DataSource = dt;
            cbInterfaceLanguage.ValueMember = "InterfaceLanguage";
            cbInterfaceLanguage.DisplayMember = "Caption";

            cbGasT.FillDataToComboBoxAndSetFont();
            cbShemT.FillDataToComboBoxAndSetFont();
            cbModzT.FillDataToComboBoxAndSetFont();
            cbDggStatus.FillDataToComboBoxAndSetFont();
            cbCompany.FillDataToComboBoxAndSetFont();
            cbServiceForEveryDay.FillDataToComboBoxAndSetFont("Service");
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            SaveParams();
            if (updateLanguage)
            {
                InterfaceParameters.InterfaceLanguage = cbInterfaceLanguage.SelectedValue.ToString();
                CLSCustomCnobari.Initialize();
                GlobalParameters.Rc.SetMainButtonTexts(2);
            }
            Close();
        }

        void SaveMainParams()
        {
            var strComm = $"UPDATE Params SET " +
                          $"CompanyDgg = {chbCompanyDgg.ConvertCheckEditValueToInt()} " +
                          ", Fasi = " + txtFasi.EditValue + " " +
                          ", IdServiceForEveryDay = " + cbServiceForEveryDay.SelectedValue + " ";
            SQL.Update(strComm, false);
        }

        void SaveParams()
        {
            string un;
            if (chbCopy.Checked)
            {
                if (XtraMessageBox.Show(
                        "გსურთ მომხმარებელი " + cbMomx2.Text + "-ის პატამეტრები შეიცვალოს, როგორც მომხმარებელი " +
                        cbMomx.Text + "-ს", "დასტური", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                un = cbMomx2.Text;
            }
            else
                un = cbMomx.Text;
            var strComm = "UPDATE Params"
                          + " SET SaangPeriodi = " + chbSaangPeriodi.ConvertCheckEditValueToInt() + " "
                          + ", Data1 = '" + txtData1.DateTime + "' "
                          + ", Data2 = '" + txtData2.DateTime + "' "
                          + ", DefaultPeriodIndex = " + cbDefaultPeriodIndex.SelectedIndex + " "
                          + ", RestoreDGSettings = " + chbRestoreDGSettings.ConvertCheckEditValueToInt() + " "
                          + ", CreateLog = " + chbCreateLog.ConvertCheckEditValueToInt() + " "
                          + ", CreateLogRs = " + chbCreateLogRs.ConvertCheckEditValueToInt() + " "
                          + ", ViewFullLog = " + chbViewFullLog.ConvertCheckEditValueToInt() + " "
                          + ", IdShemT = " + cbShemT.SelectedValue + " "
                          + ", IdGasT = " + cbGasT.SelectedValue + " "
                          + ", IdModzT = " + cbModzT.SelectedValue + " "
                          + ", InterfaceLanguage = N'" + cbInterfaceLanguage.SelectedValue + "' "
                          + ", IdCompany = " + cbCompany.SelectedValue + " "
                          + (tc.TabPages.Count > 7 ? ", IdDggStatus = " + cbDggStatus.SelectedValue + " " : " ")
                          + ", CompanyDgg = " + chbCompanyDgg.ConvertCheckEditValueToInt() + " "
                          + "WHERE UN = '" + un + "'";
            SQL.Update(strComm, false);

            if (userIsSa)
            {
                SaveMainParams();
            }
        }

        void btnApply_Click(object sender, EventArgs e)
        {
            SaveParams();
            if (!updateLanguage) return;
            InterfaceParameters.InterfaceLanguage = cbInterfaceLanguage.SelectedValue.ToString();
            CLSCustomCnobari.Initialize();
            GlobalParameters.Rc.SetMainButtonTexts(2);
        }

        void chbCopy_CheckedChanged(object sender, EventArgs e)
        {
            cbMomx2.Visible = chbCopy.Checked;
        }

        private void TxtFasi_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}