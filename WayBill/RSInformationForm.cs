using System;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.WayBill
{
    public partial class RSInformationForm : XtraForm
    {
        readonly CLSWayBillOperation wayBill = new CLSWayBillOperation(Company.su, Company.sp, Company.ip);

        public RSInformationForm()
        {
            InitializeComponent();
        }

        void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        void btnReceive_Click(object sender, EventArgs e)
        {
            switch (tc.SelectedTabPageIndex)
            {
                case 0:
                    dgBarCodes.DataSource = wayBill.GetBarCodes();
                    break;
                case 1:
                    dgErrorCodes.DataSource = wayBill.GetErrorCodes();
                    break;
                case 2:
                    dgWaybillUnits.DataSource = wayBill.GetWayBillUnits();
                    break;
                case 3:
                    dgCarNumbers.DataSource = wayBill.GetCarNumbers();
                    break;
                case 4:
                    dgWayBillTypes.DataSource = wayBill.GetWayBillTypes();
                    break;
                case 5:
                    dgServiceUsers.DataSource = wayBill.GetUsers(txtUser.Text, txtPass.Text);
                    break;
                case 6:
                    dgTrans.DataSource = wayBill.GetTransTypes();
                    break;
                case 7:
                    dgAqcizi.DataSource = wayBill.GetAqcizi();
                    break;
            }
        }

        void RSInformationForm_Load(object sender, EventArgs e)
        {
            gvBarCodes.ChangeFonts();
            gvCarNumbers.ChangeFonts();
            gvServiceUsers.ChangeFonts();
            gvWayBillTypes.ChangeFonts();
            gvWaybillUnits.ChangeFonts();
            gvTrans.ChangeFonts();
            gvAqcizi.ChangeFonts();
            gvErrorCodes.ChangeFonts();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            switch (tc.SelectedTabPageIndex)
            {
                case 1:
                    SaveTable("ErrorCodes", gvErrorCodes);
                    break;
                case 2:
                    SaveTable("Unit", gvWaybillUnits);
                    break;
                case 6:
                    SaveTable("TransTypes", gvTrans);
                    break;
            }
        }

        void SaveTable(string tableName, GridView gv)
        {
            //            DataTable dt = SQL.Select("SELECT * From " + tableName);
            for (var i = 0; i <= gv.RowCount - 1; i++)
            {
                var id = gv.GetRowCellValue(i, gv.Columns[0]).ToString();
                var dt = SQL.Select("SELECT * FROM " + tableName + " WHERE Id" + tableName + "  = " + id);
                if (dt.Rows.Count == 0)
                {
                    var txtComm = "INSERT INTO " + tableName + "(Id" + tableName + ", " + tableName + ") VALUES(" +
                                  gv.GetRowCellValue(i, gv.Columns[0]) + ", N'" + gv.GetRowCellValue(i, gv.Columns[1]) +
                                  "')";
                    SQL.Insert(txtComm);
                }
                else
                {
                    var txtComm = "UPDATE " + tableName + " SET " + tableName + " = N'" +
                                  gv.GetRowCellValue(i, gv.Columns[1]) + "' WHERE Id" + tableName + " = " +
                                  gv.GetRowCellValue(i, gv.Columns[0]);
                    SQL.Update(txtComm);
                }
            }
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            switch (tc.SelectedTabPageIndex)
            {
                case 1:
                    var id = gvBarCodes.GetFocusedRowCellValue("ID").ToString();
                    wayBill.DeleteBarCode(id);
                    break;
                case 6:
                    SaveTable("TransTypes", gvTrans);
                    break;
            }
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            using (var fm = new WayBillUsersForm(txtUser.Text, txtPass.Text, 1))
            {
                fm.ShowDialog();
            }
        }

        void btnEdit_Click(object sender, EventArgs e)
        {
            using (var fm = new WayBillUsersForm(txtUser.Text, txtPass.Text, 2))
            {
                fm.ShowDialog();
            }
        }

        void btnExcel_Click(object sender, EventArgs e)
        {
            switch (tc.SelectedTabPageIndex)
            {
                case 0:
                    CLSExcel.ExportToExcel(dgBarCodes);
                    break;
                case 1:
                    CLSExcel.ExportToExcel(dgErrorCodes);
                    break;
                case 2:
                    CLSExcel.ExportToExcel(dgWaybillUnits);
                    break;
                case 3:
                    CLSExcel.ExportToExcel(dgCarNumbers);
                    break;
                case 4:
                    CLSExcel.ExportToExcel(dgWayBillTypes);
                    break;
                case 5:
                    CLSExcel.ExportToExcel(dgServiceUsers);
                    break;
                case 6:
                    CLSExcel.ExportToExcel(dgTrans);
                    break;
                case 7:
                    CLSExcel.ExportToExcel(dgAqcizi);
                    break;
            }
        }
    }
}