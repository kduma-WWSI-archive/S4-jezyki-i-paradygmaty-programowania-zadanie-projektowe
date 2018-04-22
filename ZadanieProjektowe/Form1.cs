﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieProjektowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.OfType<AboutBox>().Any()) return;

            var about = new AboutBox {MdiParent = this};
            about.Show();
        }

        private void CloseAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}