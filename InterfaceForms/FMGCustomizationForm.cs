using System;
using DevExpress.XtraBars.Customization;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.InterfaceForms
{
    public partial class FMGCustomizationForm : CustomizationForm
    {
        public FMGCustomizationForm()
        {
            InitializeComponent();
        }

        void FMGCustomizationForm_Load(object sender, EventArgs e)
        {
            localizationManager.SetTexts();
        }
    }
}