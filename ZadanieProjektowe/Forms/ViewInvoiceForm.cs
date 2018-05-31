using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZadanieProjektowe.Models;

namespace ZadanieProjektowe.Forms
{
    public partial class ViewInvoiceForm : Form
    {
        private readonly int _invoiceId;
        private readonly Invoice _invoice;

        public ViewInvoiceForm(int invoiceId)
        {
            _invoiceId = invoiceId;
            InitializeComponent();

            var db = new Entities();
            _invoice = db.Invoices.First(i => i.Id == _invoiceId);

            PositionsGW.AutoGenerateColumns = false;
        }

        private void ViewInvoiceForm_Load(object sender, EventArgs e)
        {
            Text = $"Faktura numer {_invoiceId} z dnia {_invoice.Date.ToString()}";
            SumLabel.Text = ((decimal)_invoice.Amount).ToString("C");
            BuyerLabel.Text = $"{_invoice.Customer.Name}\nNIP: {_invoice.Customer.VatID}\n{_invoice.Customer.Address}";
            PositionsGW.DataSource = _invoice.InvoicesPositions.ToList();
        }
    }
}
