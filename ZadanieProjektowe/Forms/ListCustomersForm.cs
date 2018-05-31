using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PubSub;
using ZadanieProjektowe.Classes.Events;
using ZadanieProjektowe.Models;

namespace ZadanieProjektowe.Forms
{
    public partial class ListCustomersForm : Form
    {
        public ListCustomersForm()
        {
            InitializeComponent();
            CustomersDownloader.RunWorkerAsync();
            gridView.AutoGenerateColumns = false;

            this.Subscribe<NewCustomerWasCreatedEvent>(e =>
            {
                StatustoolStripStatusLabel.Text = "Ładuję Listę Faktur...";
                StatusBarLoader.Visible = true;

                CustomersDownloader.RunWorkerAsync();
            });
        }

        private void ListCustomersForm_Load(object sender, EventArgs e)
        {

        }

        private void CustomersDownloader_DoWork(object sender, DoWorkEventArgs e)
        {
            var db = new Entities();
            e.Result = db.Customers.ToList();
        }

        private void CustomersDownloader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gridView.DataSource = e.Result;
            StatusBarLoader.Visible = false;
            StatustoolStripStatusLabel.Text = "Gotowe";
        }

        private void ListCustomersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Unsubscribe<NewCustomerWasCreatedEvent>();
        }
    }
}
