using System;
using DevExpress.Data;
using DevExpress.Data.PivotGrid;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.InterfaceForms
{
    public partial class PivotTableSettingsForm : XtraForm
    {
        readonly PivotGridControl pt;

        public PivotTableSettingsForm(PivotGridControl pt)
        {
            this.pt = pt;
            InitializeComponent();
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            if (chbCompactStyle.Checked)
            {
                chbSumRowValues.Checked = pt.OptionsView.ShowRowTotals = true;

                pt.OptionsView.ShowTotalsForSingleValues = true;
                pt.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Tree;
                pt.OptionsBehavior.HorizontalScrolling = PivotGridScrolling.CellsArea;
            }
            else
            {
                pt.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Far;
                pt.OptionsBehavior.HorizontalScrolling = PivotGridScrolling.Control;
                pt.OptionsView.ShowTotalsForSingleValues = false;
            }

            pt.OptionsView.ShowRowTotals = chbSumRowValues.Checked;
            pt.OptionsView.ShowColumnTotals = chbSumColumnValues.Checked;

            Close();
        }

        void PivotTableSettingsForm_Load(object sender, EventArgs e)
        {
            chbSumRowValues.Checked = pt.OptionsView.ShowRowTotals;
            chbSumColumnValues.Checked = pt.OptionsView.ShowColumnTotals;
            chbCompactStyle.Checked = pt.OptionsView.ShowTotalsForSingleValues;
        }

        PivotGridField GetNewInvisibleBonusField()
        {
            var newField = new PivotGridField(txtName.Text, PivotArea.DataArea);
            newField.Name = "pcolExpressionField" + InterfaceParameters.PivotTableFieldCount++;
            newField.Caption = txtName.Text;
            newField.Visible = false;
            newField.UnboundType = UnboundColumnType.Decimal;
            newField.UnboundExpression = txtExpression.Text;
            newField.Options.ShowUnboundExpressionMenu = true;
            return newField;
        }

        void btnExpression_Click(object sender, EventArgs e)
        {
            var newBonus = GetNewInvisibleBonusField();
            pt.Fields.Add(newBonus);
            pt.ShowUnboundExpressionEditor(newBonus);
            txtExpression.Text = newBonus.UnboundExpression;
            pt.Fields.Remove(newBonus);
        }

        void btnAddField_Click(object sender, EventArgs e)
        {
            var newBonus = GetNewInvisibleBonusField();
            newBonus.Visible = true;
            newBonus.FieldName = txtFieldName.Text;
            newBonus.Name = "col" + txtFieldName.Text;
            newBonus.CellFormat.FormatString = txtFormatText.Text;
            switch (cbFormat.Text)
            {
                case "":
                case "None":
                    newBonus.CellFormat.FormatType = FormatType.None;
                    break;
                case "რიცხვი":
                    newBonus.CellFormat.FormatType = FormatType.Numeric;
                    break;
                case "თარიღი":
                    newBonus.CellFormat.FormatType = FormatType.DateTime;
                    break;
                case "შერჩევით":
                    newBonus.CellFormat.FormatType = FormatType.Custom;
                    break;
            }

            pt.Fields.Add(newBonus);
            txtName.Text = string.Empty;
            btnAddField.Enabled = false;
            txtExpression.Text = string.Empty;
            txtExpression.Enabled = false;
            pt.BestFit();
        }

        void btnTopValues_Click(object sender, EventArgs e)
        {
            pt.BeginUpdate();
            foreach (PivotGridField field in pt.Fields)
            {
                if (field.Visible && field.Area == PivotArea.RowArea)
                {
                    foreach (PivotGridField fieldSummary in pt.Fields)
                    {
                        if (fieldSummary.Visible && fieldSummary.Area == PivotArea.DataArea)
                        {
                            field.SortBySummaryInfo.Field = fieldSummary;
                            field.SortOrder = chbDescended.Checked
                                ? PivotSortOrder.Descending : PivotSortOrder.Ascending;
                            break;
                        }
                    }
                    field.TopValueCount = Convert.ToInt32(txtTopValues.Value);
                    field.TopValueShowOthers = chbTopValues.Checked;
                    break;
                }
            }
            pt.EndUpdate();
        }

        void btnSummaryAdd_Click(object sender, EventArgs e)
        {
            try
            {
                pt.BeginUpdate();
                foreach (PivotGridField field in pt.Fields)
                {
                    field.CustomTotals.Clear();
                    if (chbAverage.Checked)
                        field.CustomTotals.Add(PivotSummaryType.Average);
                    if (chbSum.Checked)
                        field.CustomTotals.Add(PivotSummaryType.Sum);
                    if (chbMax.Checked)
                        field.CustomTotals.Add(PivotSummaryType.Max);
                    //                    PivotGridCustomTotalBase min = field.CustomTotals.Add(PivotSummaryType.Min);
                    if (chbMin.Checked)
                        field.CustomTotals.Add(PivotSummaryType.Min);
                    if (chbCount.Checked)
                        field.CustomTotals.Add(PivotSummaryType.Count);
                    field.TotalsVisibility = PivotTotalsVisibility.CustomTotals;
                    //                PivotGridCustomTotalBase f = field.CustomTotals.Add(PivotSummaryType.Sum);
                    //                field.CustomTotals.Remove(f);
                }
            }
            finally
            {
                pt.EndUpdate();
            }
        }
    }
}