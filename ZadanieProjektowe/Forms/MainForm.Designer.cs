namespace ZadanieProjektowe.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaFakturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oknaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CascadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticalyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HorizontalyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oknoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseAlllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExtractActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaKontrachentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.oknaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaFakturToolStripMenuItem,
            this.listaKontrachentToolStripMenuItem,
            this.nowyToolStripMenuItem,
            this.CloseAppToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "&Plik";
            // 
            // listaFakturToolStripMenuItem
            // 
            this.listaFakturToolStripMenuItem.Name = "listaFakturToolStripMenuItem";
            this.listaFakturToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.listaFakturToolStripMenuItem.Text = "Lista Faktur";
            this.listaFakturToolStripMenuItem.Click += new System.EventHandler(this.listaFakturToolStripMenuItem_Click);
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nowyToolStripMenuItem.Image")));
            this.nowyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.nowyToolStripMenuItem.Text = "&Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.NewTransactionToolStripMenuItem_Click);
            // 
            // CloseAppToolStripMenuItem
            // 
            this.CloseAppToolStripMenuItem.Name = "CloseAppToolStripMenuItem";
            this.CloseAppToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F4)));
            this.CloseAppToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.CloseAppToolStripMenuItem.Text = "Zakończ Aplikację";
            this.CloseAppToolStripMenuItem.Click += new System.EventHandler(this.CloseAppToolStripMenuItem_Click);
            // 
            // oknaToolStripMenuItem
            // 
            this.oknaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CascadingToolStripMenuItem,
            this.VerticalyToolStripMenuItem,
            this.HorizontalyToolStripMenuItem,
            this.oknoToolStripMenuItem});
            this.oknaToolStripMenuItem.Name = "oknaToolStripMenuItem";
            this.oknaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.oknaToolStripMenuItem.Text = "Widok";
            // 
            // CascadingToolStripMenuItem
            // 
            this.CascadingToolStripMenuItem.Name = "CascadingToolStripMenuItem";
            this.CascadingToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.CascadingToolStripMenuItem.Text = "Rozmieść Kaskadowo";
            this.CascadingToolStripMenuItem.Click += new System.EventHandler(this.CascadingToolStripMenuItem_Click);
            // 
            // VerticalyToolStripMenuItem
            // 
            this.VerticalyToolStripMenuItem.Name = "VerticalyToolStripMenuItem";
            this.VerticalyToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.VerticalyToolStripMenuItem.Text = "Rozmieść Pionowo";
            this.VerticalyToolStripMenuItem.Click += new System.EventHandler(this.VerticalyToolStripMenuItem_Click);
            // 
            // HorizontalyToolStripMenuItem
            // 
            this.HorizontalyToolStripMenuItem.Name = "HorizontalyToolStripMenuItem";
            this.HorizontalyToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.HorizontalyToolStripMenuItem.Text = "Rozmieść Poziomo";
            this.HorizontalyToolStripMenuItem.Click += new System.EventHandler(this.HorizontalyToolStripMenuItem_Click);
            // 
            // oknoToolStripMenuItem
            // 
            this.oknoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseAlllToolStripMenuItem,
            this.ExtractActiveToolStripMenuItem});
            this.oknoToolStripMenuItem.Name = "oknoToolStripMenuItem";
            this.oknoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.oknoToolStripMenuItem.Text = "Okna";
            // 
            // CloseAlllToolStripMenuItem
            // 
            this.CloseAlllToolStripMenuItem.Name = "CloseAlllToolStripMenuItem";
            this.CloseAlllToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.CloseAlllToolStripMenuItem.Text = "Zamknij Wszystkie";
            this.CloseAlllToolStripMenuItem.Click += new System.EventHandler(this.CloseAlllToolStripMenuItem_Click);
            // 
            // ExtractActiveToolStripMenuItem
            // 
            this.ExtractActiveToolStripMenuItem.Name = "ExtractActiveToolStripMenuItem";
            this.ExtractActiveToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ExtractActiveToolStripMenuItem.Text = "Wyodrębnij Aktywne";
            this.ExtractActiveToolStripMenuItem.Click += new System.EventHandler(this.ExtractActiveToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.AboutToolStripMenuItem.Text = "&Informacje...";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // listaKontrachentToolStripMenuItem
            // 
            this.listaKontrachentToolStripMenuItem.Name = "listaKontrachentToolStripMenuItem";
            this.listaKontrachentToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.listaKontrachentToolStripMenuItem.Text = "Lista Kontrachent";
            this.listaKontrachentToolStripMenuItem.Click += new System.EventHandler(this.listaKontrachentToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SprzedaSZ v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oknaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CascadingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VerticalyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HorizontalyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oknoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseAlllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExtractActiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaFakturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaKontrachentToolStripMenuItem;
    }
}

