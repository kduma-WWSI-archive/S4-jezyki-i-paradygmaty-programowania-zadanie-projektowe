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
using PubSub;
using ZadanieProjektowe.Classes.Events;
using ZadanieProjektowe.Models;

namespace ZadanieProjektowe.Forms
{
    public partial class ListInvoicesForm : Form
    {
        public ListInvoicesForm()
        {
            InitializeComponent();
            InvoicesDownloader.RunWorkerAsync();
            gridView.AutoGenerateColumns = false;

            this.Subscribe<NewInvoiceWasCreatedEvent>(e =>
            {
                StatustoolStripStatusLabel.Text = "Ładuję Listę Faktur...";
                StatusBarLoader.Visible = true;

                InvoicesDownloader.RunWorkerAsync();
            });
        }

        ~ListInvoicesForm()
        {
            this.Unsubscribe<NewInvoiceWasCreatedEvent>();
        }

        private void InvoicesDownloader_DoWork(object sender, DoWorkEventArgs e)
        {
            var db = new Entities();
            e.Result = db.Invoices.ToList();
        }

        private void InvoicesDownloader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gridView.DataSource = e.Result;
            StatusBarLoader.Visible = false;
            StatustoolStripStatusLabel.Text = "Gotowe";
        }

        private void ListInvoicesForm_Load(object sender, EventArgs e)
        {

        }

        private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var invoiceId = (int) gridView.Rows[e.RowIndex].Cells[0].Value;
            var form = new ViewInvoiceForm(invoiceId) {MdiParent = this.MdiParent};
            form.Show();
        }
    }
}
