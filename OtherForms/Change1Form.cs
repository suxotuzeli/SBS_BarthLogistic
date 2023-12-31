using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class Change1Form : XtraForm
    {
        const string MasterId = "IdChange1";
        const string DetailTableName = "Change2";
        readonly string tableName, id, idTableName;
        string strComm, strCommDetail;

        public Change1Form(string tableName, string id, string idTableName)
        {
            InitializeComponent();
            this.tableName = tableName;
            this.id = id;
            this.idTableName = idTableName;
        }

        void Gas1Form_Load(object sender, EventArgs e)
        {
            strComm =
                " SELECT Change1.IdChange1, Change1.Data, Change1.UserName, TableNameText, Change1.OperType, Change1.Sql, Change1.TableName" +
                " FROM  Change1 LEFT OUTER JOIN" +
                " ChangeTables ON ChangeTables.TableName = Change1.TableName ";
            strCommDetail =
                " SELECT Change2.IdChange2, Change2.FieldName, Change2.OldValue, Change2.NewValue, Change1.IdChange1, Change1.Data, Change1.UserName, " +
                " Change1.TableName, Change1.OperType, ChangeFields.FieldCaption " +
                " FROM  Change2 INNER JOIN" +
                " Change1 ON Change2.IdChange1 = Change1.IdChange1 LEFT OUTER JOIN" +
                " ChangeFields ON Change2.FieldName = ChangeFields.FieldName ";
            btnLogDelete.Visibility = BarItemVisibility.Never;
            CLSTools.InitializePeriod(cbPeriod, txtData1, txtData2);
            gvChange1.FocusedRowChanged += gvChange1_FocusedRowChanged;
        }

        void gvChange1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            DataRow row = gvChange1.GetFocusedDataRow();
            dgChange2.DataSource = row == null
                ? null
                : SQL.Select(ReturnStrCommDetail("WHERE Change1." + MasterId + " = " + row[MasterId]));
        }

        void Gas1Form_Activated(object sender, EventArgs e)
        {
            string txtComm = strComm +
                             string.Format("WHERE Data >= '{0}' AND Data <= '{1}'",
                                 Convert.ToDateTime(txtData1.EditValue).ToString(GlobalParameters.ServerDateFormat),
                                 Convert.ToDateTime(txtData2.EditValue).ToString(GlobalParameters.ServerDateFormat))
                             + " AND Change1.TableName  = N'" + tableName + "' ";

            FormActivate(txtComm);
        }

        void FormActivate(string txtComm)
        {
            dgChange1.DataSource = SQL.Select(txtComm);
        }

        string ReturnStrCommDetail(string whereClause)
        {
            string dtfltr = GlobalParameters.ViewFullLog ? string.Empty : "AND OldValue <> NewValue";
            return strCommDetail + whereClause + dtfltr;
        }

        void btnPrint_Click(object sender, ItemClickEventArgs e)
        {
            CLSStimul stRep = new CLSStimul(DetailTableName, dgChange1);
            stRep.Initialize();
            stRep.SetDefaultVariables(gvChange1.GetFocusedDataRow());
            stRep.Show();
        }

        void btnSaveDGlayout_Click(object sender, ItemClickEventArgs e)
        {
            dgChange1.SaveLayouts();
        }

        void dgDet_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string field = gvChange2.GetFocusedRowCellValue(colFieldName).ToString();
                string oldValue = gvChange2.GetFocusedRowCellValue(colOldValue).ToString();
                string newValue = gvChange2.GetFocusedRowCellValue(colNewValue).ToString();
                if (field.Length <= 2)
                    return;
                string lastChar = field.Substring(field.Length - 1);
                if (lastChar == "1" || lastChar == "2" || lastChar == "3" || lastChar == "4" || lastChar == "5")
                    field = field.Substring(0, tableName.Length - 1);
                if (field.Substring(0, 2).ToUpper() != "ID")
                    return;
                string changeTableName = field.Remove(0, 2);
                DataTable dt1 =
                    SQL.Select("SELECT " + changeTableName + " FROM " + changeTableName + " WHERE Id" + changeTableName +
                               " = N'" + oldValue + "'");
                if (dt1.Rows.Count == 0)
                    return;
                oldValue = dt1.Rows[0][0].ToString();

                dt1 =
                    SQL.Select("SELECT " + changeTableName + " FROM " + changeTableName + " WHERE Id" + changeTableName +
                               " = N'" + newValue + "'");
                newValue = dt1.Rows.Count == 0 ? "" : dt1.Rows[0][0].ToString();
                XtraMessageBox.Show("ძველი მნიშვნელობა: " + oldValue + "\nახალი მნიშვნელობა: " + newValue);
            }
            catch (Exception)
            {
            }
        }

        void btnFillById_Click(object sender, ItemClickEventArgs e)
        {
            if (id == "0")
                return;
            string txtComm = strComm + " WHERE IdChange1 IN (SELECT IdChange1 FROM Change2 WHERE FieldName = N'Id" +
                             idTableName + "' AND OldValue = N'" + id + "') ";

            FormActivate(txtComm);
        }

        void btnLogDelete_Click(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("წავშალოთ არჩეული პერიოდის ჩანაწერები?", "Confirm", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                SQL.Execute(
                    string.Format(
                        "DELETE FROM Change2 WHERE IdChange1 in (SELECT IdChange1 FROM Change1 WHERE Data>='{0}' AND Data<='{1}')",
                        txtData1.EditValue, txtData2.EditValue));
                SQL.Execute(string.Format("DELETE FROM Change1 WHERE Data >= '{0}' AND Data <= '{1}'",
                    txtData1.EditValue, txtData2.EditValue));
            }
        }

        void gridView2_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle < 0)
                return;
            if (view == null)
                return;
            if (view.GetRowCellDisplayText(e.RowHandle, view.Columns["OldValue"]) !=
                view.GetRowCellDisplayText(e.RowHandle, view.Columns["NewValue"]) & GlobalParameters.ViewFullLog &
                view.GetRowCellDisplayText(e.RowHandle, view.Columns["NewValue"]) != "")
                e.Appearance.ForeColor = Color.Red;
        }

        void btnExportToExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            CLSExcel.ExportToExcel(dgChange1);
        }

        void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Gas1Form_Activated(sender, null);
        }

        void btnDetExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            CLSExcel.ExportToExcel(dgChange2);
        }
    }
}