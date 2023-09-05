using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Aspose.Cells;
using DevExpress.XtraEditors;
using Microsoft.Win32;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.Parameters;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class GenerateSascoriForm : XtraForm
    {
        private string path = "";
        private string pathInit = "";
        string  keyLocation = $@"SOFTWARE\FMGSoft\{GlobalParameters.DatabaseName}\Sascori\";

        public GenerateSascoriForm()
        {
            InitializeComponent();
        }

        void GenerateSascoriForm_Load(object sender, EventArgs e)
        {
            panel1.ChangeFonts();
            try
            {
                RegistryKey reg = Registry.LocalMachine;
                var key = reg.OpenSubKey(keyLocation);
                if (key == null)
                {
                    reg.CreateSubKey(keyLocation);
                }
                else
                {
                    txtPath.EditValue = path =pathInit= key.GetValue("SascoriPath").ToString();
                    key.Close();
                }

            }
            catch (UnauthorizedAccessException)
            {
                XtraMessageBox.Show("თქვენ არ გაქვთ ადმინისტრატორის უფლება\n" +
                                    "გთხოვთ გაუშვათ პროგრამა ადმინისტრატორით(Run as Administrator)"
                    ,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            switch (cbSascoriModel.EditValue.ToString())
            {
                case "1":
                    DIGIFiles();
                    break;
                case "2":
                    BizerbaFiles();
                    break;
                case "3":
                    ShtrithFiles();
                    break;
                case "4":
                    CASFiles();
                    break;
                case "5":
                    CASFiles();
                    break;
                case "6":
                    LPFiles();
                    break;
            }

            XtraMessageBox.Show("ოპერაცია შესრულებულია","",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void LPFiles()
        {
            if (File.Exists(path))
                File.Delete(path);
            FileStream fs = new FileStream(path, FileMode.Create);
            Workbook excel = new Workbook();
            excel.Worksheets.Add("Merchandise");
            Worksheet ws = excel.Worksheets["Merchandise"];
            DataTable dt = spGenerateSascori(6);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                var col = dt.Columns[i];
                ws.Cells[0, i].Value = col.ColumnName;
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    ws.Cells[i + 1, j].Value = dt.Rows[i][j].ToString();
                }
            }

            excel.Worksheets.RemoveAt(0);
            excel.Save(fs, SaveFormat.Excel97To2003);
            fs.Close();
        }

        private void ShtrithFiles()
        {
            FileStream fs = new FileStream(Path.GetDirectoryName(path) + @"\ProdList.txt",
                FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding(1252));
            DataTable dt = spGenerateSascori(3);
            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    sw.WriteLine(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }

        private void DIGIFiles()
        {
            FileStream fs = new FileStream(Path.GetDirectoryName(path) + @"\ProdList.txt",
                FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding(1252));
            DataTable dt = spGenerateSascori(1);
            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    sw.WriteLine(row[0].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }

        private void BizerbaFiles()
        {
            FileStream fs = new FileStream(Path.GetDirectoryName(path) + @"\PRODUCT_SENDFULL_2013_7_5_023.001",
                FileMode.OpenOrCreate);
            File.Create(Path.GetDirectoryName(path) + @"\SENDFULL_2013_7_5_023.001").Close();
            StreamWriter sw = new StreamWriter(fs);
            DataTable dt = spGenerateSascori(2);
            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    sw.WriteLine(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }

        private void CASFiles()
        {
            if (File.Exists(path))
                File.Delete(path);
            FileStream fs = new FileStream(path, FileMode.Create);
            Workbook excel = new Workbook();
            excel.Worksheets.Add("PLU");
            Worksheet ws = excel.Worksheets["PLU"];
            DataTable dt = spGenerateSascori(3);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                var col = dt.Columns[i];
                ws.Cells[0, i].Value = col.ColumnName;
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    ws.Cells[i + 1, j].Value = dt.Rows[i][j].ToString();
                }
            }

            excel.Worksheets.RemoveAt(0);
            excel.Save(fs, SaveFormat.Excel97To2003);
            fs.Close();
        }

        private DataTable spGenerateSascori(int sascoriModel)
        {
            DataTable dt = new DataTable();
            SqlCommand comm = new SqlCommand("spGenerateSascori", GlobalParameters.cn) {CommandType = CommandType.StoredProcedure};

            SqlParameter paIdProdT = comm.Parameters.Add("@IdProdT", SqlDbType.Int);
            SqlParameter paIdProdS = comm.Parameters.Add("@IdProdS", SqlDbType.Int);
            SqlParameter paErt = comm.Parameters.Add("@Ert", SqlDbType.NVarChar, 40);
            SqlParameter paSasc = comm.Parameters.Add("@sascoriModel", SqlDbType.NVarChar, 40);
            SqlParameter paFG = comm.Parameters.Add("@FG", SqlDbType.Int, 40);

            paIdProdT.Value = fmgProdT.Checked?fmgProdT.GetValue():0;
            paIdProdS.Value = fmgProdS.Checked?fmgProdS.GetValue():0;
            paErt.Value = txtErt.Text;
            paSasc.Value = sascoriModel;
            paFG.Value = Convert.ToInt32(txtFG.Value);

            SqlDataAdapter da = new SqlDataAdapter(comm);
            try
            {
                GlobalParameters.cn.Open();
                da.Fill(dt);
            }
            catch (Exception e)
            {
                if (XtraMessageBox.Show("ოპერაციის შესრულება შეუძლებელია, გამოვიტანოთ სისტემური შეტყობინება?",
                        "შეცდომა", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) ==
                    DialogResult.OK)
                    XtraMessageBox.Show(e.ToString());
            }
            finally
            {
                GlobalParameters.cn.Close();
            }

            return dt;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog fm = new SaveFileDialog();
            fm.Title = "სასწორის ფაილისი მისამართი";
            fm.OverwritePrompt = false;
            if(fm.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fm.FileName;
            }
        }

        private void GenerateSascoriForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtPath.Text != pathInit)
            {
                var ans = XtraMessageBox.Show("შევინახო სასწორის ფაილის მისამართი".Translate(), "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes)
                {
                    try
                    {
                        RegistryKey reg = Registry.LocalMachine;
                        var key = reg.OpenSubKey(keyLocation,true);
                        key.SetValue("SascoriPath",txtPath.Text);
                        key.Close();
                    }
                    catch (UnauthorizedAccessException)
                    {
                        XtraMessageBox.Show("თქვენ არ გაქვთ ადმინისტრატორის უფლება\n" +
                                            "გთხოვთ გაუშვათ პროგრამა ადმინისტრატორით(Run as Administrator)"
                            ,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                    }
                }
            }
        }

        private void txtPath_EditValueChanged(object sender, EventArgs e)
        {
            path = txtPath.Text;
        }
    }
}