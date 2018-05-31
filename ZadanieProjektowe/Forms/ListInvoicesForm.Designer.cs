namespace ZadanieProjektowe.Forms
{
    partial class ListInvoicesForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatustoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBarLoader = new System.Windows.Forms.ToolStripProgressBar();
            this.InvoicesDownloader = new System.ComponentModel.BackgroundWorker();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.InvoiceNumberHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.StatustoolStripStatusLabel,
            this.StatusBarLoader});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
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
            this.StatustoolStripStatusLabel.Size = new System.Drawing.Size(114, 17);
            this.StatustoolStripStatusLabel.Text = "Ładuję Listę Faktur...";
            // 
            // StatusBarLoader
            // 
            this.StatusBarLoader.MarqueeAnimationSpeed = 10;
            this.StatusBarLoader.Name = "StatusBarLoader";
            this.StatusBarLoader.Size = new System.Drawing.Size(100, 16);
            this.StatusBarLoader.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.StatusBarLoader.Value = 100;
            // 
            // InvoicesDownloader
            // 
            this.InvoicesDownloader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.InvoicesDownloader_DoWork);
            this.InvoicesDownloader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.InvoicesDownloader_RunWorkerCompleted);
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceNumberHeader,
            this.AmountHeader,
            this.DateHeader,
            this.CustomerHeader});
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.Location = new System.Drawing.Point(0, 0);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.Size = new System.Drawing.Size(800, 428);
            this.gridView.TabIndex = 2;
            this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellDoubleClick);
            // 
            // InvoiceNumberHeader
            // 
            this.InvoiceNumberHeader.DataPropertyName = "Id";
            this.InvoiceNumberHeader.HeaderText = "Numer Faktury";
            this.InvoiceNumberHeader.Name = "InvoiceNumberHeader";
            this.InvoiceNumberHeader.ReadOnly = true;
            // 
            // AmountHeader
            // 
            this.AmountHeader.DataPropertyName = "Amount";
            this.AmountHeader.HeaderText = "Kwota";
            this.AmountHeader.Name = "AmountHeader";
            this.AmountHeader.ReadOnly = true;
            // 
            // DateHeader
            // 
            this.DateHeader.DataPropertyName = "Date";
            this.DateHeader.HeaderText = "Data Wystawienia";
            this.DateHeader.Name = "DateHeader";
            this.DateHeader.ReadOnly = true;
            // 
            // CustomerHeader
            // 
            this.CustomerHeader.DataPropertyName = "CustomerName";
            this.CustomerHeader.HeaderText = "Nazwa Kontrachenta";
            this.CustomerHeader.Name = "CustomerHeader";
            this.CustomerHeader.ReadOnly = true;
            // 
            // ListInvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.statusStrip1);
            this.Name = "ListInvoicesForm";
            this.Text = "Lista Faktur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListInvoicesForm_FormClosing);
            this.Load += new System.EventHandler(this.ListInvoicesForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StatustoolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar StatusBarLoader;
        private System.ComponentModel.BackgroundWorker InvoicesDownloader;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumberHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerHeader;
    }
}