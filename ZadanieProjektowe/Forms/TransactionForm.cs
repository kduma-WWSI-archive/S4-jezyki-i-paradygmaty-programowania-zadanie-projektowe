using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ZadanieProjektowe.Classes;

namespace ZadanieProjektowe.Forms
{
    public partial class TransactionForm : Form
    {
        private readonly Transaction _transaction = new Transaction();

        public TransactionForm()
        {
            InitializeComponent();
            TransactionProductsDataGridView.AutoGenerateColumns = false;

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = DateTime.Now.ToString(CultureInfo.CurrentCulture);


            TransactionProductsDataGridView.DataSource = _transaction.Items;
            _transaction.Update += transaction =>
            {
                FinishButton.Text = transaction.Sum.ToString("C");
            };

            ProductsDownloader.RunWorkerAsync();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
//            WindowState = FormWindowState.Minimized;
//            WindowState = FormWindowState.Maximized;
        }

        private void TransactionForm_Paint(object sender, PaintEventArgs e)
        {
            menuStrip1.Visible = MdiParent == null;
        }

        // ReSharper disable once CollectionNeverQueried.Local
        private readonly List<Button> _fastSaleButtonsList = new List<Button>();

        private void ProductsDownloader_DoWork(object sender, DoWorkEventArgs e)
        {
            var db = new Entities();
            e.Result = db.Products.ToList();
            Thread.Sleep(1*1000);
        }

        private void ProductsDownloader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (var product in (List<Product>) e.Result)
            {
                var button = new Button();
                FastSaleFlowLayoutPanel.Controls.Add(button);
                button.Location = new Point(3, 3);
                button.Name = "FastSaleButton";
                button.Size = new Size(100, 100);
                button.TabIndex = 0;
                button.Text = $"{product.Name}\n({product.Price})";
                button.UseVisualStyleBackColor = true;
                button.Click += (s, args) =>
                {
                    _transaction.AddItem(product);
                };
                _fastSaleButtonsList.Add(button);
            }

            StatustoolStripStatusLabel.Text = "Gotowe";
            StatusBarLoader.Visible = false;
        }

        public bool AddProductByBarcode(string barcode)
        {
            try
            {
                var db = new Entities();
                var product = db.Products.Single(p => p.Barcode == barcode);
                _transaction.AddItem(product);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            ShowFinalizeDialog();
        }

        private void ShowFinalizeDialog()
        {
            var form = new FinalizeTransactionForm(_transaction);
            form.Save += FormOnSave;
            form.ShowDialog();
        }

        private void FormOnSave(Transaction obj)
        {
            Close();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFinalizeDialog();
        }
    }
}
