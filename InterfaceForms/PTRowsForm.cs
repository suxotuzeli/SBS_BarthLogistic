using System;
using System.Collections.Generic;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.InterfaceForms
{
    public partial class PTRowsForm : XtraForm
    {
        readonly DataTable dt;
        readonly string[] fieldList, fieldCaption;
        readonly bool hasDg, isDataSourceDt;
        readonly PivotCellEventArgs pce;
        readonly PivotGridControl pt;

        public PTRowsForm()
        {
            InitializeComponent();
        }

        public PTRowsForm(PivotCellEventArgs pce, PivotGridControl pt)
        {
            this.pce = pce;
            this.pt = pt;
            hasDg = false;
            isDataSourceDt = false;
            InitializeComponent();
        }

        public PTRowsForm(PivotCellEventArgs pce, string[] fieldList, string[] fieldCaption)
        {
            this.pce = pce;
            this.fieldList = fieldList;
            this.fieldCaption = fieldCaption;
            hasDg = true;
            isDataSourceDt = false;
            InitializeComponent();
        }

        public PTRowsForm(DataTable dt, string[] fieldList, string[] fieldCaption)
        {
            this.dt = dt;
            this.fieldList = fieldList;
            this.fieldCaption = fieldCaption;
            hasDg = true;
            isDataSourceDt = true;
            InitializeComponent();
        }

        void PTRowsForm_Load(object sender, EventArgs e)
        {
            if (isDataSourceDt)
                dg.DataSource = dt;
            else
                dg.DataSource = pce.CreateDrillDownDataSource();

            if (hasDg)
                SetColumnsCaptions();
            else
                SetColumnCaptionsForPt();
        }

        void SetColumnCaptionsForPt()
        {
            var fields = new Dictionary<string, string>();
            var fieldsCount = 0;
            for (var i = 0; i < pt.Fields.Count; i++)
            {
                if (fields.ContainsKey(pt.Fields[i].FieldName)) continue;
                fields.Add(pt.Fields[i].FieldName, pt.Fields[i].Caption);
                fieldsCount++;
            }
            for (var i = 0; i < fieldsCount; i++)
            {
                var columnByFieldName = gv.Columns.ColumnByFieldName(pt.Fields[i].FieldName);
                if (columnByFieldName == null) continue;
                if (fields.ContainsKey(pt.Fields[i].FieldName))
                    columnByFieldName.Caption = fields[pt.Fields[i].FieldName];
                else
                    columnByFieldName.Visible = false;
            }
            for (var i = 0; i < gv.Columns.Count; i++)
            {
                if (!fields.ContainsKey(gv.Columns[i].FieldName))
                    gv.Columns[i].Visible = false;
            }
        }

        void SetColumnsCaptions()
        {
            var fields = new Dictionary<string, string>();
            for (var i = 0; i < fieldList.Length; i++)
                if (fieldList[i] != null)
                    fields.Add(fieldList[i], fieldCaption[i]);
            for (var i = 0; i < gv.Columns.Count; i++)
            {
                if (fields.ContainsKey(gv.Columns[i].FieldName))
                    gv.Columns[i].Caption = fields[gv.Columns[i].FieldName];
                else
                    gv.Columns[i].Visible = false;
            }
        }

        void btnPrint_Click(object sender, EventArgs e)
        {
            CLSExcel.ExportToExcel(dg, "minus");
        }
    }
}