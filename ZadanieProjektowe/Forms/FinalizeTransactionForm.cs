using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieProjektowe.Classes
{
    public partial class FinalizeTransactionForm : Form
    {
        private readonly Transaction _transaction;

        public FinalizeTransactionForm(Transaction transaction)
        {
            _transaction = transaction;
            InitializeComponent();
        }

        private void FinalizeTransactionForm_Load(object sender, EventArgs e)
        {
            label1.Text = _transaction.Sum.ToString("C");

            var db = new Entities();
            listBox1.DataSource = db.Customers.ToList();
            listBox1.DisplayMember = "Name";
            listBox1.Invalidate();
        }

        public event Action<Transaction> Save;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var db = new Entities();

            var invoice = new Invoice
            {
                CustomerId = ((Customer)listBox1.SelectedItem).Id,
                Date = DateTime.Now,
                Number = 1
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
            }


            db.SaveChanges();



            OnSave();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual void OnSave()
        {
            Save?.Invoke(_transaction);
        }
    }
}
