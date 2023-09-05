using DevExpress.XtraWaitForm;

namespace SBS_BarthLogistic.InterfaceForms
{
    public partial class WaitngForm : WaitForm
    {
        public enum WaitFormCommand
        {

        }

        public WaitngForm()
        {
            InitializeComponent();
            progressPanel1.AutoHeight = true;
        }

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            progressPanel1.Caption = caption;
        }

        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            progressPanel1.Description = description;
        }
    }
}