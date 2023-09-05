using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.InterfaceForms
{
    /// <summary>
    ///     -- ვერსია 1.0 -- 13 May 2016 20:00 ნიკა
    ///     . დავამატე ფუნქცია SetMessage && XtraDialogForm
    /// </summary>
    public partial class ErrorDialog : XtraDialogForm
    {
        public ErrorDialog()
        {
            InitializeComponent();
        }

        public void SetException(Exception exception)
        {
            SetException(exception, string.Empty);
        }

        public void SetException(Exception exception, string additionalMessage)
        {
            var message = exception.Message;

            foreach (var error in GlobalParameters.Errors)
            {
                if (exception.Message.ToUpper().Contains(error.Key))
                    message = error.Value;
            }

            txtMessage.EditValue = message;
            txtToString.EditValue = string.Empty;

            if (additionalMessage != string.Empty)
            {
                txtToString.KeyUp += (sender, args) =>
                {
                    if (args.KeyCode != Keys.F12) return;
                    if (txtToString.Tag == null)
                    {
                        txtToString.EditValue = string.Format("Additional Message:{0}{1}{0}{0}", Environment.NewLine,
                            additionalMessage);
                        txtToString.EditValue += string.Format("Exception ToString:{0}{1}", Environment.NewLine,
                            exception);
                        txtToString.Tag = true;
                    }
                    else
                    {
                        txtToString.EditValue = string.Format("Exception ToString:{0}{1}", Environment.NewLine,
                            exception);
                        txtToString.Tag = null;
                    }
                };
            }
            txtToString.EditValue += string.Format("Exception ToString:{0}{1}", Environment.NewLine, exception);
        }

        public void SetMessage(string mainMessage, string additionalMessage)
        {
            foreach (var error in GlobalParameters.Errors)
            {
                if (mainMessage == error.Key)
                    mainMessage = error.Value;
            }

            txtMessage.EditValue = mainMessage;
            txtToString.EditValue = string.Empty;

            if (additionalMessage == string.Empty) return;

            txtToString.KeyUp += (sender, args) =>
            {
                if (args.KeyCode != Keys.F12) return;
                if (txtToString.EditValue.ToString() == string.Empty)
                {
                    txtToString.EditValue = string.Format("Additional Message:{0}{1}{0}", Environment.NewLine,
                        additionalMessage);
                }
                else
                {
                    txtToString.EditValue = string.Empty;
                }
            };
        }

        void btnDetail_Click(object sender, EventArgs e)
        {
            paBottom2.Visible = !paBottom2.Visible;
            paBottom2.Height = paBottom2.Visible ? 100 : 0;
            Height = paBottom2.Visible ? panelControl1.Height + 36 + 100 : panelControl1.Height + 36;
        }

        void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(100);
        }

        void ErrorDialog_Load(object sender, EventArgs e)
        {
        }
    }
}