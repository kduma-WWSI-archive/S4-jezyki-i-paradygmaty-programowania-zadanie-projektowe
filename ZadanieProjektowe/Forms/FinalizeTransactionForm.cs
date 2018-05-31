using System;
using System.Linq;
using System.Windows.Forms;
using PubSub;
using ZadanieProjektowe.Classes;
using ZadanieProjektowe.Classes.Events;
using ZadanieProjektowe.Models;

namespace ZadanieProjektowe.Forms
{
    public partial class FinalizeTransactionForm : Form
    {
        private readonly Transaction _transaction;

        public event Action<Transaction> Save;

        public FinalizeTransactionForm(Transaction transaction)
        {
            _transaction = transaction;
            InitializeComponent();
            this.Subscribe<NewCustomerWasCreatedEvent>(ec => ReloadList());
        }

        private void FinalizeTransactionForm_Load(object sender, EventArgs e)
        {
            label1.Text = _transaction.Sum.ToString("C");

            ReloadList();
        }

        private void ReloadList()
        {
            var db = new Entities();
            listBox1.DataSource = db.Customers.ToList();
            listBox1.DisplayMember = "Name";
            listBox1.Invalidate();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var customer = ((Customer)listBox1.SelectedItem);

            SaveInvoice(customer);
        }

        private void SaveInvoice(Customer customer)
        {
            var db = new Entities();
            var invoice = new Invoice
            {
                CustomerId = customer.Id,
                Date = DateTime.Now,
                Amount = _transaction.Sum
            };
            db.Invoices.Add(invoice);

            foreach (var transactionItem in _transaction.Items)
            {
                var position = new InvoicesPosition
                {
                    InvoiceId = invoice.Id,
                    ProductId = transactionItem.Product.Id,
                    Price = transactionItem.Product.Price,
                    Quanity = (short) transactionItem.Quanity
                };
                db.InvoicesPositions.Add(position);
                var product = db.Products.First(p => p.Id == transactionItem.Product.Id);
                product.Quanity -= (short) transactionItem.Quanity;
            }

            db.SaveChanges();

            OnSave(invoice);
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual void OnSave(Invoice invoice)
        {
            Save?.Invoke(_transaction);
            this.Publish(new NewInvoiceWasCreatedEvent(invoice));
        }

        private void NewAndSaveButton_Click(object sender, EventArgs e)
        {

            var form = new NewCustomerForm(){TopMost = true};
            form.Save += SaveInvoice;
            form.ShowDialog();
        }

        private void FinalizeTransactionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Unsubscribe<NewCustomerWasCreatedEvent>();
        }
    }
}
