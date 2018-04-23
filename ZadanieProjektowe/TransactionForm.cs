using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZadanieProjektowe.Classes;

namespace ZadanieProjektowe
{
    public partial class TransactionForm : Form
    {
        private readonly Transaction _transaction = new Transaction();

        public TransactionForm()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            Text = DateTime.Now.ToString(CultureInfo.CurrentCulture);


            TransactionProductsDataGridView.DataSource = _transaction.Items;
            _transaction.Update += transaction =>
            {
                FinishButton.Text = transaction.Sum.ToString("C");
            };

            var fastSaleProducts = new List<Product>();
            for (var i = 0; i < 50; i++)
            {
                fastSaleProducts.Add(new Product(){Name = $"Produkt {i}", Price = i*1.29});
            }

            var fastSaleButtonsList = new List<System.Windows.Forms.Button>();
            foreach (var product in fastSaleProducts)
            {
                var button = new System.Windows.Forms.Button();
                this.FastSaleFlowLayoutPanel.Controls.Add(button);
                button.Location = new System.Drawing.Point(3, 3);
                button.Name = "FastSaleButton";
                button.Size = new System.Drawing.Size(100, 100);
                button.TabIndex = 0;
                button.Text = $"{product.Name}\n({product.Price})";
                button.UseVisualStyleBackColor = true;
                button.Click += (sender, args) =>
                {
                    _transaction.AddItem(product);
                };
                fastSaleButtonsList.Add(button);
            }
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
        }

        private void TransactionForm_Paint(object sender, PaintEventArgs e)
        {
            menuStrip1.Visible = MdiParent == null;
        }
    }
}
