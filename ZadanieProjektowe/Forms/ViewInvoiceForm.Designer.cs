﻿namespace ZadanieProjektowe.Forms
{
    partial class ViewInvoiceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewInvoiceForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SumLabel = new System.Windows.Forms.Label();
            this.PositionsGW = new System.Windows.Forms.DataGridView();
            this.ProductCOl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarcodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuaniteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUmCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyerLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drukujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PositionsGW)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SumLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.PositionsGW, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BuyerLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pozycje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kupujacy";
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Location = new System.Drawing.Point(103, 383);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(51, 20);
            this.SumLabel.TabIndex = 0;
            this.SumLabel.Text = "Suma";
            // 
            // PositionsGW
            // 
            this.PositionsGW.AllowUserToAddRows = false;
            this.PositionsGW.AllowUserToDeleteRows = false;
            this.PositionsGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PositionsGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCOl,
            this.BarcodeCol,
            this.QuaniteCol,
            this.PriceCol,
            this.SUmCol});
            this.PositionsGW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositionsGW.Location = new System.Drawing.Point(103, 143);
            this.PositionsGW.Name = "PositionsGW";
            this.PositionsGW.ReadOnly = true;
            this.PositionsGW.Size = new System.Drawing.Size(694, 237);
            this.PositionsGW.TabIndex = 1;
            // 
            // ProductCOl
            // 
            this.ProductCOl.DataPropertyName = "ProductStr";
            this.ProductCOl.HeaderText = "Produkt";
            this.ProductCOl.Name = "ProductCOl";
            this.ProductCOl.ReadOnly = true;
            // 
            // BarcodeCol
            // 
            this.BarcodeCol.DataPropertyName = "Barcode";
            this.BarcodeCol.HeaderText = "Kod Kreskowy";
            this.BarcodeCol.Name = "BarcodeCol";
            this.BarcodeCol.ReadOnly = true;
            // 
            // QuaniteCol
            // 
            this.QuaniteCol.DataPropertyName = "Quanity";
            this.QuaniteCol.HeaderText = "Ilosc";
            this.QuaniteCol.Name = "QuaniteCol";
            this.QuaniteCol.ReadOnly = true;
            // 
            // PriceCol
            // 
            this.PriceCol.DataPropertyName = "Price";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.PriceCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.PriceCol.HeaderText = "Cena";
            this.PriceCol.Name = "PriceCol";
            this.PriceCol.ReadOnly = true;
            // 
            // SUmCol
            // 
            this.SUmCol.DataPropertyName = "Sum";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.SUmCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.SUmCol.HeaderText = "Suma";
            this.SUmCol.Name = "SUmCol";
            this.SUmCol.ReadOnly = true;
            // 
            // BuyerLabel
            // 
            this.BuyerLabel.AutoSize = true;
            this.BuyerLabel.Location = new System.Drawing.Point(103, 0);
            this.BuyerLabel.Name = "BuyerLabel";
            this.BuyerLabel.Size = new System.Drawing.Size(73, 20);
            this.BuyerLabel.TabIndex = 0;
            this.BuyerLabel.Text = "Kupujacy";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drukujToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "&Plik";
            // 
            // drukujToolStripMenuItem
            // 
            this.drukujToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("drukujToolStripMenuItem.Image")));
            this.drukujToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drukujToolStripMenuItem.Name = "drukujToolStripMenuItem";
            this.drukujToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.drukujToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drukujToolStripMenuItem.Text = "&Drukuj";
            this.drukujToolStripMenuItem.Click += new System.EventHandler(this.drukujToolStripMenuItem_Click);
            // 
            // ViewInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewInvoiceForm";
            this.Text = "ViewInvoiceForm";
            this.Load += new System.EventHandler(this.ViewInvoiceForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PositionsGW)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.DataGridView PositionsGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCOl;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarcodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuaniteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUmCol;
        private System.Windows.Forms.Label BuyerLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drukujToolStripMenuItem;
    }
}