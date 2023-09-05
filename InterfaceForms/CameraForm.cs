using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.InterfaceForms
{
    public partial class CameraForm : XtraForm
    {
        public CameraForm()
        {
            InitializeComponent();
        }

        public byte[] ImageData { get; set; }

        void CameraForm_Load(object sender, EventArgs e)
        {
        }

        void pictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            //InvokeDefaultCameraDialog();
        }

        //void InvokeDefaultCameraDialog()
        //{
        //    var dialog = new TakePictureDialog();
        //    dialog.Caption = "სურათის გადაღება";
        //    if (dialog.ShowDialog() == DialogResult.OK)
        //    {
        //        var image = dialog.Image;
        //        using (var ms = new MemoryStream())
        //        {
        //            image.Save(ms, ImageFormat.Jpeg);
        //            pictureEdit1.EditValue = ms.ToArray();
        //        }
        //    }
        //}

        void CameraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            cameraControl1.Stop();
        }

        void btnCapture_Click(object sender, EventArgs e)
        {
            Image shot = cameraControl1.TakeSnapshot();
            pictureEdit1.EditValue = shot;
            UpdateImage(shot);
        }

        void UpdateImage(Image shot)
        {
            using (var ms = new MemoryStream())
            {
                shot.Save(ms, ImageFormat.Jpeg);
                ImageData = ms.ToArray();
            }
        }
    }
}