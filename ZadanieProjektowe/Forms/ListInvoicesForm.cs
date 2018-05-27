using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieProjektowe.Forms
{
    public partial class ListInvoicesForm : Form
    {
        public ListInvoicesForm()
        {
            InitializeComponent();
            InvoicesDownloader.RunWorkerAsync();
        }

        private void InvoicesDownloader_DoWork(object sender, DoWorkEventArgs e)
        {
            var db = new Entities();
            e.Result = db.Invoices.ToList();
            Thread.Sleep(1 * 1000);
        }

        private void InvoicesDownloader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGridView1.DataSource = e.Result;
            StatustoolStripStatusLabel.Text = "Gotowe";
            StatusBarLoader.Visible = false;
        }

        private void ListInvoicesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
