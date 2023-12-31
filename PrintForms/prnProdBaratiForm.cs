using System;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.InterfaceForms;

namespace SBS_BarthLogistic.PrintForms
{
    public partial class prnProdBaratiForm : XtraForm
    {
        const string NameForReports = "prnNashti";

        public prnProdBaratiForm()
        {
            InitializeComponent();
        }

        void prnProdBaratiForm_Load(object sender, EventArgs e)
        {
            Text = GlobalParameters.FieldName;
            paProdBarati.ChangeFonts();
            gvProdBarati.ChangeFonts();
            fmgOrg.FillDataToComboBox();
            GridLayoutOperations.FillLayouts(cbLayoutPT, NameForReports, false);
        }


        void btnFind_Click(object sender, ItemClickEventArgs e)
        {
            CLSSpAll proc = new CLSSpAll(paProdBarati, "spProdBarati");
            dgProdBarati.DataSource = proc.Exceute();
        }

        void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            CLSExcel.ExportToExcel(dgProdBarati, nameForReports: NameForReports);
        }

        void btnDGLayoutLoad_ItemClick(object sender, ItemClickEventArgs e)
        {
            var layout = cbLayoutPT.EditValue.ToString();
            GridLayoutOperations.RestoreLayout(dgProdBarati, NameForReports, layout);
            Text = GlobalParameters.FieldName;
        }

        void btnDGLayoutSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new GridLayoutOperations(dgProdBarati, NameForReports))
            {
                f.ShowDialog();
                GridLayoutOperations.FillLayouts(cbLayoutPT, NameForReports, false);
            }
        }
    }
}