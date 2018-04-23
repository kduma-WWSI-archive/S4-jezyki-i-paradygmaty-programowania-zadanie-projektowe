namespace ZadanieProjektowe
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
            this.CloseAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oknaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozmieśćKaskadowoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozmieśćPionowoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozmieśćPoziomoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oknoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijWszystkieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyodrębnijAktywneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.pomocToolStripMenuItem,
            this.oknaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.CloseAppToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "&Plik";
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
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AboutToolStripMenuItem.Text = "&Informacje...";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nowyToolStripMenuItem.Image")));
            this.nowyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.nowyToolStripMenuItem.Text = "&Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // oknaToolStripMenuItem
            // 
            this.oknaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rozmieśćKaskadowoToolStripMenuItem,
            this.rozmieśćPionowoToolStripMenuItem,
            this.rozmieśćPoziomoToolStripMenuItem,
            this.oknoToolStripMenuItem});
            this.oknaToolStripMenuItem.Name = "oknaToolStripMenuItem";
            this.oknaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.oknaToolStripMenuItem.Text = "Widok";
            // 
            // rozmieśćKaskadowoToolStripMenuItem
            // 
            this.rozmieśćKaskadowoToolStripMenuItem.Name = "rozmieśćKaskadowoToolStripMenuItem";
            this.rozmieśćKaskadowoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.rozmieśćKaskadowoToolStripMenuItem.Text = "Rozmieść Kaskadowo";
            // 
            // rozmieśćPionowoToolStripMenuItem
            // 
            this.rozmieśćPionowoToolStripMenuItem.Name = "rozmieśćPionowoToolStripMenuItem";
            this.rozmieśćPionowoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.rozmieśćPionowoToolStripMenuItem.Text = "Rozmieść Pionowo";
            // 
            // rozmieśćPoziomoToolStripMenuItem
            // 
            this.rozmieśćPoziomoToolStripMenuItem.Name = "rozmieśćPoziomoToolStripMenuItem";
            this.rozmieśćPoziomoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.rozmieśćPoziomoToolStripMenuItem.Text = "Rozmieść Poziomo";
            // 
            // oknoToolStripMenuItem
            // 
            this.oknoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijWszystkieToolStripMenuItem,
            this.wyodrębnijAktywneToolStripMenuItem});
            this.oknoToolStripMenuItem.Name = "oknoToolStripMenuItem";
            this.oknoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.oknoToolStripMenuItem.Text = "Okna";
            // 
            // zamknijWszystkieToolStripMenuItem
            // 
            this.zamknijWszystkieToolStripMenuItem.Name = "zamknijWszystkieToolStripMenuItem";
            this.zamknijWszystkieToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.zamknijWszystkieToolStripMenuItem.Text = "Zamknij Wszystkie";
            // 
            // wyodrębnijAktywneToolStripMenuItem
            // 
            this.wyodrębnijAktywneToolStripMenuItem.Name = "wyodrębnijAktywneToolStripMenuItem";
            this.wyodrębnijAktywneToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.wyodrębnijAktywneToolStripMenuItem.Text = "Wyodrębnij Aktywne";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SprzedaSZ v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oknaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozmieśćKaskadowoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozmieśćPionowoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozmieśćPoziomoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oknoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijWszystkieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyodrębnijAktywneToolStripMenuItem;
    }
}

