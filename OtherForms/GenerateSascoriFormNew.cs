using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Security.Principal;
using Aspose.Cells;
using Microsoft.Win32;
using System.Text;
using SBS_BarthLogistic.Classes;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.Parameters;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class GenerateSascoriFormNew : Form
    {
        public GenerateSascoriFormNew()
        {
            InitializeComponent();
            cb_sascori.SelectedIndex = 0;
            txtFG.Value = 1;
        }

        private void btn_CreateFile_Click(object sender, EventArgs e)
        {
            switch (cb_sascori.SelectedIndex)
            {
                case 0: DIGIFiles();break;
                case 1: BizerbaFiles();break;
                case 2: ShtrithFiles();break;
                case 3: CASFiles(); break;
                case 4: CASFiles(); break;
                case 5: LPFiles(); break;

            }
            RegistryKey k = Registry.CurrentUser;
            RegistryKey key = k.CreateSubKey(@"SOFTWARE\" + Application.ProductName);
            key.SetValue("Path", txt_Path.Text);
            key.SetValue("SascType", cb_sascori.SelectedIndex);
            key.Close();
            MessageBox.Show("მონაცემთა ექსპორტი წარმატებით დასრულდა!", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void LPFiles()
        {
            if (File.Exists(txt_Path.Text))
                File.Delete(txt_Path.Text);
            FileStream fs = new FileStream(txt_Path.Text, FileMode.Create);
            Workbook excel = new Workbook();
            excel.Worksheets.Add("Merchandise");
            Worksheet ws = excel.Worksheets["Merchandise"];
            DataTable dt = spGenerateSascori();
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
            FileStream fs = new FileStream(Path.GetDirectoryName(txt_Path.Text) + @"\ProdList.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding(1252));
            DataTable dt = spGenerateSascori();
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
            FileStream fs = new FileStream(Path.GetDirectoryName(txt_Path.Text) + @"\ProdList.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding(1252));
            DataTable dt = spGenerateSascori();
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
            FileStream fs = new FileStream(Path.GetDirectoryName(txt_Path.Text) + @"\PRODUCT_SENDFULL_2013_7_5_023.001", FileMode.OpenOrCreate);
            File.Create(Path.GetDirectoryName(txt_Path.Text) + @"\SENDFULL_2013_7_5_023.001").Close();
            StreamWriter sw = new StreamWriter(fs);
            DataTable dt = spGenerateSascori();
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
            if(File.Exists(txt_Path.Text))
                File.Delete(txt_Path.Text);
            FileStream fs = new FileStream(txt_Path.Text,FileMode.Create);
            Workbook excel = new Workbook();
            excel.Worksheets.Add("PLU");
            Worksheet ws = excel.Worksheets["PLU"];
            DataTable dt = spGenerateSascori();
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
            excel.Save(fs,SaveFormat.Excel97To2003);
            fs.Close();
        }

        private DataTable spGenerateSascori()
        {
            DataTable dt = new DataTable();
            /*string connectionString = "Data Source=" + txt_Server.Text + ";Initial Catalog=" + txt_Base.Text +
                                      ";Persist Security Info=True;User ID=" + txt_User.Text + ";Password=" +
                                      txt_Pass.Text + ";";*/
            SqlConnection cn = new SqlConnection(GlobalParameters.ConnStr);
            SqlCommand comm = new SqlCommand("spGenerateSascori", cn);
            comm.CommandType = CommandType.StoredProcedure;

            SqlParameter paIdProdT = comm.Parameters.Add("@IdProdT", SqlDbType.Int);
            SqlParameter paIdProdS = comm.Parameters.Add("@IdProdS", SqlDbType.Int);
            SqlParameter paErt = comm.Parameters.Add("@Ert", SqlDbType.NVarChar, 40);
            SqlParameter paSasc = comm.Parameters.Add("@SascoriModel", SqlDbType.NVarChar, 40);
            SqlParameter paFG = comm.Parameters.Add("@FG", SqlDbType.Int, 40);

            paIdProdT.Value = 0;
            paIdProdS.Value = 0;
            paErt.Value = "კგ";
            paSasc.Value = cb_sascori.SelectedIndex + 1;
            paFG.Value = Convert.ToInt32(txtFG.Value);

            SqlDataAdapter da = new SqlDataAdapter(comm);
            try
            {
                cn.Open();
                da.Fill(dt);
            }
            catch (Exception e)
            {
                if (MessageBox.Show("ოპერაციის შესრულება შეუძლებელია, გამოვიტანოთ სისტემური შეტყობინება?", "შეცდომა", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    MessageBox.Show(e.ToString());
            }
            finally
            {
                cn.Close();
            }
            return dt;
        }

        private void GenerateSascoriFormNew_Load(object sender, EventArgs e)
        {
            RegistryKey k = Registry.CurrentUser;
            RegistryKey key = k.OpenSubKey(@"SOFTWARE\" + Application.ProductName);
            if (key == null) return;
            /*txt_Server.Text = key.GetValue("Server").ToString();
            txt_Base.Text = key.GetValue(@"Base").ToString();
            txt_User.Text = key.GetValue(@"User").ToString();
            txt_Pass.Text = key.GetValue(@"Pass").ToString();*/
            txt_Path.Text = key.GetValue(@"Path").ToString();
            cb_sascori.SelectedIndex = Convert.ToInt32(key.GetValue(@"SascType").ToString());
            key.Close();
        }

        private void btn_Path_Click(object sender, EventArgs e)
        {
            SaveFileDialog fm = new SaveFileDialog();
            if(fm.ShowDialog() == DialogResult.OK)
            {
                txt_Path.Text = fm.FileName;
                RegistryKey k = Registry.CurrentUser;
                RegistryKey key = k.CreateSubKey(@"SOFTWARE\" + Application.ProductName);
                /*key.SetValue("Server",txt_Server.Text);
                key.SetValue("Base", txt_Base.Text);
                key.SetValue("User", txt_User.Text);
                key.SetValue("Pass", txt_Pass.Text);*/
                key.SetValue("Path", txt_Path.Text);
                //key.SetValue("SascType", cb_sascori.SelectedIndex);
                key.Close();
            }
        }

    }
}
