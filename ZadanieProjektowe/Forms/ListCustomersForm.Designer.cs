namespace ZadanieProjektowe.Forms
{
    partial class ListCustomersForm
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
            this.gridView = new System.Windows.Forms.DataGridView();
            this.InvoiceNumberHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VatIDHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatustoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBarLoader = new System.Windows.Forms.ToolStripProgressBar();
            this.CustomersDownloader = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceNumberHeader,
            this.NameHeader,
            this.VatIDHeader});
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.Location = new System.Drawing.Point(0, 0);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.Size = new System.Drawing.Size(800, 450);
            this.gridView.TabIndex = 3;
            // 
            // InvoiceNumberHeader
            // 
            this.InvoiceNumberHeader.DataPropertyName = "Id";
            this.InvoiceNumberHeader.HeaderText = "Numer Klienta";
            this.InvoiceNumberHeader.Name = "InvoiceNumberHeader";
            this.InvoiceNumberHeader.ReadOnly = true;
            // 
            // NameHeader
            // 
            this.NameHeader.DataPropertyName = "Name";
            this.NameHeader.HeaderText = "Nazwa";
            this.NameHeader.Name = "NameHeader";
            this.NameHeader.ReadOnly = true;
            // 
            // VatIDHeader
            // 
            this.VatIDHeader.DataPropertyName = "VatID";
            this.VatIDHeader.HeaderText = "Nip";
            this.VatIDHeader.Name = "VatIDHeader";
            this.VatIDHeader.ReadOnly = true;
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
            this.statusStrip1.TabIndex = 4;
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
            // CustomersDownloader
            // 
            this.CustomersDownloader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CustomersDownloader_DoWork);
            this.CustomersDownloader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CustomersDownloader_RunWorkerCompleted);
            // 
            // ListCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gridView);
            this.Name = "ListCustomersForm";
            this.Text = "Lista Kontrachentow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListCustomersForm_FormClosing);
            this.Load += new System.EventHandler(this.ListCustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StatustoolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar StatusBarLoader;
        private System.ComponentModel.BackgroundWorker CustomersDownloader;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumberHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn VatIDHeader;
    }
}