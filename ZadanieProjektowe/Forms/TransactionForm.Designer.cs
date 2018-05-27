namespace ZadanieProjektowe
{
    partial class TransactionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatustoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBarLoader = new System.Windows.Forms.ToolStripProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FastSaleFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.FinishButton = new System.Windows.Forms.Button();
            this.TransactionProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuanityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsDownloader = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszToolStripMenuItem,
            this.toolStripSeparator1,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.plikToolStripMenuItem.Text = "&Tranzakcja";
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zapiszToolStripMenuItem.Image")));
            this.zapiszToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.zapiszToolStripMenuItem.Text = "&Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.zakończToolStripMenuItem.Text = "&Zamknij";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.StatustoolStripStatusLabel,
            this.StatusBarLoader});
            this.statusStrip1.Location = new System.Drawing.Point(0, 483);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(880, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // StatustoolStripStatusLabel
            // 
            this.StatustoolStripStatusLabel.Name = "StatustoolStripStatusLabel";
            this.StatustoolStripStatusLabel.Size = new System.Drawing.Size(139, 17);
            this.StatustoolStripStatusLabel.Text = "Ładuję Listę Produktów...";
            // 
            // StatusBarLoader
            // 
            this.StatusBarLoader.MarqueeAnimationSpeed = 10;
            this.StatusBarLoader.Name = "StatusBarLoader";
            this.StatusBarLoader.Size = new System.Drawing.Size(100, 16);
            this.StatusBarLoader.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.StatusBarLoader.Value = 100;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.FinishButton);
            this.splitContainer1.Panel2.Controls.Add(this.TransactionProductsDataGridView);
            this.splitContainer1.Panel2MinSize = 200;
            this.splitContainer1.Size = new System.Drawing.Size(880, 483);
            this.splitContainer1.SplitterDistance = 516;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 483);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FastSaleFlowLayoutPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(508, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Szybka Sprzedaż";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FastSaleFlowLayoutPanel
            // 
            this.FastSaleFlowLayoutPanel.AutoScroll = true;
            this.FastSaleFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FastSaleFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.FastSaleFlowLayoutPanel.Name = "FastSaleFlowLayoutPanel";
            this.FastSaleFlowLayoutPanel.Size = new System.Drawing.Size(502, 429);
            this.FastSaleFlowLayoutPanel.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(508, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wszystkie Produkty";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FinishButton
            // 
            this.FinishButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FinishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishButton.Location = new System.Drawing.Point(0, 419);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(360, 64);
            this.FinishButton.TabIndex = 1;
            this.FinishButton.Text = "0,00";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // TransactionProductsDataGridView
            // 
            this.TransactionProductsDataGridView.AllowUserToAddRows = false;
            this.TransactionProductsDataGridView.AllowUserToDeleteRows = false;
            this.TransactionProductsDataGridView.AllowUserToResizeColumns = false;
            this.TransactionProductsDataGridView.AllowUserToResizeRows = false;
            this.TransactionProductsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TransactionProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.QuanityColumn,
            this.PriceColumn,
            this.SumColumn});
            this.TransactionProductsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransactionProductsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.TransactionProductsDataGridView.MultiSelect = false;
            this.TransactionProductsDataGridView.Name = "TransactionProductsDataGridView";
            this.TransactionProductsDataGridView.ReadOnly = true;
            this.TransactionProductsDataGridView.RowTemplate.Height = 20;
            this.TransactionProductsDataGridView.Size = new System.Drawing.Size(360, 483);
            this.TransactionProductsDataGridView.TabIndex = 0;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.Frozen = true;
            this.NameColumn.HeaderText = "Produkt";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // QuanityColumn
            // 
            this.QuanityColumn.DataPropertyName = "DetailedQuanity";
            dataGridViewCellStyle4.Format = "# jm\\.";
            dataGridViewCellStyle4.NullValue = null;
            this.QuanityColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.QuanityColumn.Frozen = true;
            this.QuanityColumn.HeaderText = "Ilość";
            this.QuanityColumn.Name = "QuanityColumn";
            this.QuanityColumn.ReadOnly = true;
            this.QuanityColumn.Width = 45;
            // 
            // PriceColumn
            // 
            this.PriceColumn.DataPropertyName = "Price";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.PriceColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.PriceColumn.Frozen = true;
            this.PriceColumn.HeaderText = "Cena";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            this.PriceColumn.Width = 70;
            // 
            // SumColumn
            // 
            this.SumColumn.DataPropertyName = "Sum";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.SumColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.SumColumn.Frozen = true;
            this.SumColumn.HeaderText = "Suma";
            this.SumColumn.Name = "SumColumn";
            this.SumColumn.ReadOnly = true;
            this.SumColumn.Width = 85;
            // 
            // ProductsDownloader
            // 
            this.ProductsDownloader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ProductsDownloader_DoWork);
            this.ProductsDownloader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ProductsDownloader_RunWorkerCompleted);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 505);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TransactionForm_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StatustoolStripStatusLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel FastSaleFlowLayoutPanel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView TransactionProductsDataGridView;
        private System.Windows.Forms.Button FinishButton;
        private System.ComponentModel.BackgroundWorker ProductsDownloader;
        private System.Windows.Forms.ToolStripProgressBar StatusBarLoader;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuanityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumColumn;
    }
}