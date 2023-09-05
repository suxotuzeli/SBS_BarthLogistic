using System;
using System.Data.Sql;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.InterfaceForms
{
    public partial class CreateParamsini : XtraForm
    {
        public CreateParamsini()
        {
            InitializeComponent();
        }

        void Browse(object sender, EventArgs e)
        {
            var fm = new FolderBrowserDialog();
            if (fm.ShowDialog() != DialogResult.OK) return;
            var x = (sender as SimpleButton).Name.Substring(3, (sender as SimpleButton).Name.Length - 3);
            var cr = Controls.Find("txt" + x, true);
            cr[0].Text = fm.SelectedPath;
        }

        void CreateParams_Load(object sender, EventArgs e)
        {
            var fonts = new InstalledFontCollection();
            cbFontName.Properties.DisplayMember = "Name";
            cbFontName.Properties.ValueMember = "Name";
            cbFontName.Properties.DataSource = fonts.Families;
            cbFontName.EditValue = "Sylfaen";
            const string path = @"Params.ini";
            if (!File.Exists(path))
            {
                DirectoryInfo info = new DirectoryInfo(System.Reflection.Assembly.GetEntryAssembly().Location);
                if (info.Parent.Parent.Name == "bin")
                {
                    info = info.Parent.Parent.Parent;
                }
                else if (info.Parent.Name == "Prog")
                {
                    info = info.Parent.Parent;
                }
                else return;
                if (!new DirectoryInfo(info.FullName + "\\Reports").Exists)
                    new DirectoryInfo(info.FullName + "\\Reports").Create();
                if (!new DirectoryInfo(info.FullName + "\\XML").Exists)
                    new DirectoryInfo(info.FullName + "\\XML").Create();
                if (!new DirectoryInfo(info.FullName + "\\Reports\\Monacemebi").Exists)
                    new DirectoryInfo(info.FullName + "\\Reports\\Monacemebi").Create();
                txtMonacemebi.Text = info.FullName + "\\Reports\\Monacemebi";
                txtReports.Text = info.FullName + "\\Reports";
                txtScanned.Text = info.FullName + "\\Mail";
                txtXML.Text = info.FullName + "\\XML";
                return;
            }
            using (var sr = File.OpenText(path))
            {
                SetParameter(cbServerName, sr);
                SetParameter(txtTimeOut, sr);
                SetParameter(txtDefaulUser, sr);
                SetParameter(cbFontName, sr);
                SetParameter(txtFontSize, sr);
                SetParameter(txtReports, sr);
                SetParameter(txtMonacemebi, sr);
                SetParameter(txtScanned, sr);
                SetParameter(txtXML, sr);
                SetParameter(cbDateFormat, sr);
                SetParameter(txtDB, sr);
            }
        }

        static void SetParameter(Control ctl, TextReader sr)
        {
            var s = sr.ReadLine();
            ctl.Text = s.Substring(0, s.IndexOf("--", StringComparison.Ordinal));
        }

        void Save(object sender, EventArgs e)
        {
            var fs = new FileStream("Params.ini", FileMode.Create);
            var writer = new StreamWriter(fs);
            writer.WriteLine(cbServerName.Text + "--სერვერის სახელი");
            writer.WriteLine(txtTimeOut.Text + "--კავშირის პერიოდი");
            writer.WriteLine(txtDefaulUser.Text + "--მომხმარებლის სახელი");
            writer.WriteLine(txtDB.Text + "--ბაზის სახელი");
            writer.WriteLine(cbFontName.Text + "--შრიფტის დასახელება");
            writer.WriteLine(txtFontSize.Text + "--შრიფტის ზომა");
            writer.WriteLine(txtReports.Text + "\\--რეპორტების მდებარეობა");
            writer.WriteLine(txtMonacemebi.Text + "\\--მონაცემების მდებარეობა");
            writer.WriteLine(txtXML.Text + "\\--XML ფაილების მდებარეობა");
            writer.WriteLine(txtXML.Text + "\\--XML ფაილების მდებარეობა");
            writer.WriteLine(txtScanned.Text + "\\--დოკუმენტების მდებარეობა");
            writer.WriteLine(cbDateFormat.Text + "--Date Format");
            writer.WriteLine("20000--Max Records For Pivot Tables");
            writer.WriteLine(@"D:\Progs\SBS\Market\SBS_BarthLogisticMobile\Data\SBS_BarthLogisticMobile.sdf--Path For Pictures");
            writer.WriteLine(@"\SBS_BarthLogisticMobile\Data\SBS_BarthLogisticMobile.sdf--");
            writer.WriteLine("-------------------------");
            writer.Close();
            fs.Close();
            DialogResult = DialogResult.OK;
            Close();
        }

        void btnSearchServers_Click(object sender, EventArgs e)
        {
            var instances = SqlDataSourceEnumerator.Instance.GetDataSources();
            for (var i = 0; i < instances.Rows.Count; i++)
                cbServerName.Properties.Items.Add(instances.Rows[i][0].ToString());
        }
    }
}