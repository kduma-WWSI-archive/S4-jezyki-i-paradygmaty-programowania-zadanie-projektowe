using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZadanieProjektowe.Classes;
using ZadanieProjektowe.Forms;

namespace ZadanieProjektowe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $@"{AssemblyInfoHelper.GetTitle()} v{AssemblyInfoHelper.GetVersion()}";
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.OfType<AboutBox>().Any()) return;

            var about = new AboutBox
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.FixedToolWindow
            };
            about.Show();
        }

        private void CloseAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewTransactionForm();
        }

        private void OpenNewTransactionForm()
        {
            var form = new TransactionForm {MdiParent = this};
            form.Show();
        }

        private void CascadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void VerticalyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void HorizontalyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CloseAlllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var window in MdiChildren)
            {
                window.Close();
            }
        }

        private void ExtractActiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                return;

            var form = ActiveMdiChild;
            form.MdiParent = null;
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                BarCodeReader.Open();
                BarCodeReader.DiscardInBuffer();
                BarCodeReader.NewLine = "\r\n";
            }
            catch (Exception exception)
            {
                //MessageBox.Show("Skaner Kodów Kreskowych nie został podłączony.\nSkanowanie kodów nie będzie możliwe.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //           OpenNewTransactionForm();
            OpenInvoicesListForm();
        }

        private void BarCodeReader_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                while (BarCodeReader.BytesToRead != 0)
                {
                    Form activeChild = this.ActiveMdiChild;
                    var barcode = BarCodeReader.ReadLine().Trim();
                    if (activeChild != null)
                    {
                        try
                        {
                            var transactionForm = (TransactionForm)activeChild;
                            if (!transactionForm.AddProductByBarcode(barcode))
                            {
                                BarCodeReader.WriteLine("$?GGG");
                                MessageBox.Show("Produktu o kodzie " + barcode + " nie ma w bazie produktów!", "Błędny Kod", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Aby zeskanować kod kreskowy, aktywuj okno z tranzakcją", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aby zeskanować kod kreskowy, aktywuj okno z tranzakcją", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }));
        }

        private void listaFakturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenInvoicesListForm();
        }

        private void OpenInvoicesListForm()
        {
            var form = new ListInvoicesForm { MdiParent = this };
            form.Show();
        }
    }
}
