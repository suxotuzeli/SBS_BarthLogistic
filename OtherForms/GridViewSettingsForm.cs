using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace SBS_Market.OtherForms
{
    public partial class GridViewSettingsForm : XtraForm
    {
        private readonly GridView dgv;

        public GridViewSettingsForm(GridView dgv)
        {
            this.dgv = dgv;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GridViewSettingsForm_Load(object sender, EventArgs e)
        {
        }

        private void btnFixedColumns_Click(object sender, EventArgs e)
        {
            int n = (int) txtLeftFixedColumns.Value;
            for (int i = 0; i < n; i++){                
                if (dgv.Columns[i].Visible)
                    dgv.Columns[i].Fixed = FixedStyle.Left;
                else
                    n++;
            }

            n = (int)txtRightFixedColumns.Value;
            for (int i = dgv.Columns.Count - 1; i > dgv.Columns.Count - 1 - n; i--) {
                if (dgv.Columns[i].Visible)
                    dgv.Columns[i].Fixed = FixedStyle.Right;
                else
                    n++;
            }
        }

        private void btnChoiseMultipleValuesInFilter_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv.Columns.Count; i++){
                dgv.Columns[i].OptionsFilter.FilterPopupMode = chbChoiseMultipleValuesInFilter.Checked ? FilterPopupMode.CheckedList : FilterPopupMode.Default;
            }
        }

    }
}
