using System;
using System.Linq;
using System.Windows.Forms;
using PubSub;
using ZadanieProjektowe.Classes;
using ZadanieProjektowe.Classes.Events;

namespace ZadanieProjektowe.Forms
{
    public partial class MainForm : Form
    {
        private readonly BarCodeScanner _scanner = new BarCodeScanner();

        public MainForm()
        {
            InitializeComponent();
            // ReSharper disable once VirtualMemberCallInConstructor
            Text = $@"{AssemblyInfoHelper.GetTitle()} v{AssemblyInfoHelper.GetVersion()}";

            this.Subscribe<CantConnectToTheBarcodeReaderEvent>(e => {
                Invoke(new Action(() =>
                {
                    MessageBox.Show("Skaner Kodów Kreskowych nie został podłączony.\nSkanowanie kodów nie będzie możliwe.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }));
            });

            this.Subscribe<BarcodeWasScannedEvent>(e => {
                Invoke(new Action(() =>
                {
                    var activeChild = ActiveMdiChild;

                    if (activeChild != null)
                    {
                        try
                        {
                            var transactionForm = (TransactionForm)activeChild;
                            if (transactionForm.AddProductByBarcode(e.Barcode))
                                return;

                            this.Publish(new BarcodeErrorEncounteredEvent());

                            MessageBox.Show("Produktu o kodzie " + e.Barcode + " nie ma w bazie produktów!", "Błędny Kod", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }));
            });
        }

        private void OpenInvoicesListForm()
        {
            var form = new ListInvoicesForm { MdiParent = this };
            form.Show();
        }

        private void OpenCustomersListForm()
        {
            var form = new ListCustomersForm() { MdiParent = this };
            form.Show();
        }

        private void OpenNewTransactionForm()
        {
            var form = new TransactionForm {MdiParent = this};
            form.Show();
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
            _scanner.Start();

            OpenNewTransactionForm();
            OpenInvoicesListForm();
            OpenCustomersListForm();
        }

        private void listaFakturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenInvoicesListForm();
        }

        private void listaKontrachentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCustomersListForm();
        }
    }
}
