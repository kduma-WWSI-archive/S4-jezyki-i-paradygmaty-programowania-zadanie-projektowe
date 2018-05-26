using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieProjektowe
{
    partial class AboutBox : Form
    {

        public AboutBox()
        {
            InitializeComponent();
            this.Text = String.Format("Informacje o {0} v{1}", AssemblyInfoHelper.GetTitle(), AssemblyInfoHelper.GetVersion());
            this.labelProductName.Text = AssemblyInfoHelper.GetProduct();
            this.labelVersion.Text = String.Format("Wersja {0}", AssemblyInfoHelper.GetVersion());
            this.labelCopyright.Text = AssemblyInfoHelper.GetCopyright();
            this.labelCompanyName.Text = AssemblyInfoHelper.GetCompany();
            this.textBoxDescription.Text = AssemblyInfoHelper.GetDescription();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
