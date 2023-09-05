using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;
using SBS_Market.Parameters;

namespace SBS_Market.OtherForms
{
    public partial class PTRowsForm : Form
    {
        private readonly PivotCellEventArgs pce;
        private readonly PivotGridControl pt;
        private readonly DataTable dt;
        private readonly string[] FieldList, FieldCaption;
        private readonly bool hasDG, isDataSourceDT;
        public PTRowsForm()
        {
            InitializeComponent();
        }

        public PTRowsForm(PivotCellEventArgs pce, PivotGridControl pt)
        {
            this.pce = pce;
            this.pt = pt;
            hasDG = false;
            isDataSourceDT = false;
            InitializeComponent();
        }

        public PTRowsForm(PivotCellEventArgs pce, string[] FieldList, string[] FieldCaption)
        {
            this.pce = pce;
            this.FieldList = FieldList;
            this.FieldCaption = FieldCaption;
            hasDG = true;
            isDataSourceDT = false;
            InitializeComponent();
        }

        public PTRowsForm(DataTable dt, string[] FieldList, string[] FieldCaption)
        {
            this.dt = dt;
            this.FieldList = FieldList;
            this.FieldCaption = FieldCaption;
            hasDG = true;
            isDataSourceDT = true;
            InitializeComponent();
        }

        private void PTRowsForm_Load(object sender, EventArgs e)
        {
            if(isDataSourceDT)
                dg.DataSource = dt;
            else
                dg.DataSource = pce.CreateDrillDownDataSource();

            if(hasDG)
                SetColumnsCaptions();
            else
                SetColumnCaptionsForPT();
        }

        private void SetColumnCaptionsForPT()
        {
            Dictionary<string, string> fields = new Dictionary<string, string>();
            int fieldsCount = 0;
            for (int i = 0; i < pt.Fields.Count; i++) {
                if (!fields.ContainsKey(pt.Fields[i].FieldName)) {
                    fields.Add(pt.Fields[i].FieldName, pt.Fields[i].Caption);
                    fieldsCount++;
                }
            }
            for (int i = 0; i < fieldsCount; i++) {
                ParamClass.SetFont(dgv.Columns[i]);
                if (fields.ContainsKey(pt.Fields[i].FieldName))
                    dgv.Columns[pt.Fields[i].FieldName].Caption = fields[pt.Fields[i].FieldName];
                else
                    dgv.Columns[pt.Fields[i].FieldName].Visible = false;
            }
            for (int i = 0; i < dgv.Columns.Count; i++) {
                if (!fields.ContainsKey(dgv.Columns[i].FieldName))
                    dgv.Columns[i].Visible = false;
            }
        }
        private void SetColumnsCaptions()
        {
            Dictionary<string, string> fields = new Dictionary<string, string>();
            for (int i = 0; i < FieldList.Length; i++)
                if (FieldList[i] != null)
                    fields.Add(FieldList[i], FieldCaption[i]);
            for (int i = 0; i < dgv.Columns.Count; i++) {
                ParamClass.SetFont(dgv.Columns[i]);
                if (fields.ContainsKey(dgv.Columns[i].FieldName))
                    dgv.Columns[i].Caption = fields[dgv.Columns[i].FieldName];
                else
                    dgv.Columns[i].Visible = false;
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            ParamClass.ExportDataGrid(cbExportFormat, "PT", dg);
        }

        

    }
}
