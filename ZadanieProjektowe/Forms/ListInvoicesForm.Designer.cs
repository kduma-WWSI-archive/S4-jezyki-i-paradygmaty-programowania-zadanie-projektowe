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
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.Location = new System.Drawing.Point(0, 0);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.Size = new System.Drawing.Size(800, 428);
            this.gridView.TabIndex = 2;
            // 
            // ListInvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.statusStrip1);
            this.Name = "ListInvoicesForm";
            this.Text = "ListInvoicesForm";
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
    }
}