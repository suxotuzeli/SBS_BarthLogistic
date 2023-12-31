using System;
using System.Diagnostics;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPivotGrid;

namespace SBS_BarthLogistic.Classes
{
    class CLSChartOperation
    {
        readonly BarEditItem cbChartOrientation;
        readonly ComboBoxEdit cbChartOrientation1;
        readonly BarEditItem cbChartType;
        readonly ComboBoxEdit cbChartType1;
        readonly ChartControl chart;
        readonly BarCheckItem chbShowValues;
        readonly PivotGridControl pt;

        public CLSChartOperation(PivotGridControl pt, ChartControl chart, ComboBoxEdit cbChartOrientation,
            ComboBoxEdit cbChartType)
        {
            this.pt = pt;
            this.chart = chart;
            cbChartType1 = cbChartType;
            cbChartOrientation1 = cbChartOrientation;
            this.chart.PaletteRepository.Add("Palette 1",
                new Palette("Palette 1", PaletteScaleMode.Repeat,
                    new[]
                    {
                        new PaletteEntry(Color.Black, Color.Black),
                        new PaletteEntry(Color.Gray, Color.Gray),
                        new PaletteEntry(Color.Silver, Color.Silver)
                    }));
        }

        public CLSChartOperation(PivotGridControl pt, ChartControl chart, BarEditItem cbChartOrientation,
            BarEditItem cbChartType, BarCheckItem chbShowValues)
        {
            this.pt = pt;
            this.chart = chart;
            this.cbChartType = cbChartType;
            this.cbChartOrientation = cbChartOrientation;
            this.chbShowValues = chbShowValues;
        }

        void chbShowValues_CheckedChanged2(object sender, EventArgs e)
        {
            chart.SeriesTemplate.Label.LineVisibility = chbShowValues.Checked
                ? DefaultBoolean.True : DefaultBoolean.False;
            chart.Legend.Visibility = chbShowValues.Checked
                ? DefaultBoolean.True : DefaultBoolean.False;
        }

        void cbChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart.SeriesTemplate.ChangeView((ViewType)cbChartType1.SelectedItem);
            if (chart.Diagram is Diagram3D)
            {
                var diagram = (Diagram3D)chart.Diagram;
                diagram.RuntimeRotation = true;
                diagram.RuntimeZooming = true;
                diagram.RuntimeScrolling = true;
            }
        }

        void cbChartOrientation_SelectedIndexChanged(object sender, EventArgs e)
        {
            pt.OptionsChartDataSource.ProvideDataByColumns = cbChartOrientation1.SelectedIndex == 1;
        }

        public void InitializeChart2()
        {
            chbShowValues.CheckedChanged += chbShowValues_CheckedChanged2;
            cbChartOrientation1.SelectedIndexChanged += cbChartOrientation_SelectedIndexChanged;
            cbChartType1.SelectedIndexChanged += cbChartType_SelectedIndexChanged;

            foreach (ViewType type in Enum.GetValues(typeof(ViewType)))
            {
                if (type == ViewType.PolarArea || type == ViewType.PolarLine ||
                    type == ViewType.PolarPoint || type == ViewType.Stock || type == ViewType.CandleStick) continue;
                cbChartType1.Properties.Items.Add(type);
            }
            cbChartType1.SelectedItem = ViewType.Line;
            cbChartOrientation1.Properties.Items.Add(StringParameters.ChartOperationHorizontal);
            cbChartOrientation1.Properties.Items.Add(StringParameters.ChartOperationVertical);
            cbChartOrientation1.SelectedItem = StringParameters.ChartOperationHorizontal;

            chart.DataSource = pt;
            chart.SeriesDataMember = "Series";
            chart.SeriesTemplate.ArgumentDataMember = "Arguments";
            chart.SeriesTemplate.ValueDataMembers.AddRange("Values");
            chart.Font = new Font(GlobalParameters.FontName, GlobalParameters.FontSize, FontStyle.Regular);
            chart.Legend.Font = new Font(GlobalParameters.FontName, GlobalParameters.FontSize, FontStyle.Regular);
        }

        public void InitializeChart()
        {
            chbShowValues.CheckedChanged += chbShowValues_CheckedChanged;
            cbChartOrientation.EditValueChanged += CLSChartOperation_SelectedIndexChanged;
            cbChartType.EditValueChanged += cbChartType_EditValueChanged;

            foreach (ViewType type in Enum.GetValues(typeof(ViewType)))
            {
                if (type == ViewType.PolarArea || type == ViewType.PolarLine ||
                    type == ViewType.PolarPoint || type == ViewType.Stock || type == ViewType.CandleStick) continue;
                ((RepositoryItemComboBox)cbChartType.Edit).Items.Add(type);
            }
            cbChartType.EditValue = ViewType.Bar;
            ((RepositoryItemComboBox)cbChartOrientation.Edit).Items.Add(StringParameters.ChartOperationHorizontal);
            ((RepositoryItemComboBox)cbChartOrientation.Edit).Items.Add(StringParameters.ChartOperationVertical);
            cbChartOrientation.EditValue = StringParameters.ChartOperationHorizontal;

            chart.DataSource = pt;
            chart.SeriesDataMember = "Series";
            chart.SeriesTemplate.ArgumentDataMember = "Arguments";
            chart.SeriesTemplate.ValueDataMembers.AddRange("Values");
            chart.Font = new Font(GlobalParameters.FontName, GlobalParameters.FontSize, FontStyle.Regular);
            chart.Legend.Font = new Font(GlobalParameters.FontName, GlobalParameters.FontSize, FontStyle.Regular);
        }

        void CLSChartOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            pt.OptionsChartDataSource.ProvideDataByColumns = cbChartOrientation.EditValue.ToString() ==
                                                             StringParameters.ChartOperationHorizontal;
        }

        void cbChartType_EditValueChanged(object sender, EventArgs e)
        {
            chart.SeriesTemplate.ChangeView((ViewType)cbChartType.EditValue);
            if (chart.Diagram is Diagram3D)
            {
                var diagram = (Diagram3D)chart.Diagram;
                diagram.RuntimeRotation = true;
                diagram.RuntimeZooming = true;
                diagram.RuntimeScrolling = true;
            }
        }

        void chbShowValues_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            chart.SeriesTemplate.Label.LineVisibility = chbShowValues.Checked
                ? DefaultBoolean.True : DefaultBoolean.False;

            chart.Legend.Visibility = chbShowValues.Checked
                ? DefaultBoolean.True : DefaultBoolean.False;
        }

        public string ExportToXls(string fileName)
        {
            return Export(fileName);
        }

        string Export(string fileName)
        {
            var fName = GlobalParameters.MonacemebiFolder + "ch" + fileName + PrintParameters.ReportNumber + ".xls";
            chart.ExportToXls(fName);
            Process.Start(fName);
            PrintParameters.ReportNumber++;
            return fName;
        }
    }
}