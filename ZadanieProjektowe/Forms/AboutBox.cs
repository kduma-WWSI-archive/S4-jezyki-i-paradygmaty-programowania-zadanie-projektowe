using System;
using System.Drawing;
using System.Windows.Forms;
using ZadanieProjektowe.Classes;

namespace ZadanieProjektowe.Forms
{
    partial class AboutBox : Form
    {
        private Image _gearImage;

        public AboutBox()
        {
            InitializeComponent();
            this.Text = String.Format("Informacje o {0} v{1}", AssemblyInfoHelper.GetTitle(), AssemblyInfoHelper.GetVersion());
            this.labelProductName.Text = AssemblyInfoHelper.GetProduct();
            this.labelVersion.Text = String.Format("Wersja {0}", AssemblyInfoHelper.GetVersion());
            this.labelCopyright.Text = AssemblyInfoHelper.GetCopyright();
            this.labelCompanyName.Text = AssemblyInfoHelper.GetCompany();
            this.textBoxDescription.Text = AssemblyInfoHelper.GetDescription();

            
            _gearImage = Image.FromFile(@"Images\gear.png");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int _angle = 0;
        private void AboutBox_Paint(object sender, PaintEventArgs e)
        {
            var m = e.Graphics.Transform;

            e.Graphics.TranslateTransform(75, 75);
            e.Graphics.ScaleTransform(0.25f, 0.25f);
            e.Graphics.RotateTransform(_angle);
            // ReSharper disable once PossibleLossOfFraction
            e.Graphics.DrawImage(_gearImage, -256, -256);
            e.Graphics.Transform = m;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _angle = (_angle + 5) % 360;
            Invalidate(this.ClientRectangle);
        }
    }
}
