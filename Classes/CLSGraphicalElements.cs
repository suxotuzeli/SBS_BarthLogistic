using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using SBS_BarthLogistic.InterfaceForms;

namespace SBS_BarthLogistic.Classes
{
    class CLSGraphicalElements
    {
        public static void Show()
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (WaitngForm));
            }
            catch
            {
            }
        }

        public static void ShowWaiting()
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (WaitngForm));
            }
            catch
            {
            }
        }

        public static void Show(Form form)
        {
            Hide();
            try
            {
                SplashScreenManager.ShowForm(form, typeof (WaitngForm), false, false);
            }
            catch
            {
            }
        }

        public static void ShowWaiting(Form form)
        {
            Hide();
            try
            {
                SplashScreenManager.ShowForm(form, typeof (WaitngForm), false, false);
            }
            catch
            {
            }
        }

        public static void Hide()
        {
            if (SplashScreenManager.Default != null && SplashScreenManager.Default.IsSplashFormVisible)
                SplashScreenManager.CloseForm(false);
        }
    }
}