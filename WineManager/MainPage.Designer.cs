
namespace WineManager
{
    partial class MainPagefrm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesBouteillesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesCasiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLhistoriqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.researchStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picMainPage = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainPage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gToolStripMenuItem,
            this.gestionDesBouteillesToolStripMenuItem,
            this.gestionDesCasiersToolStripMenuItem,
            this.afficherLhistoriqueToolStripMenuItem,
            this.researchStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gToolStripMenuItem.Text = "Gérer les alertes";
            this.gToolStripMenuItem.Click += new System.EventHandler(this.GérerLesAlertesToolStripMenuItem_Click);
            // 
            // gestionDesBouteillesToolStripMenuItem
            // 
            this.gestionDesBouteillesToolStripMenuItem.Name = "gestionDesBouteillesToolStripMenuItem";
            this.gestionDesBouteillesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionDesBouteillesToolStripMenuItem.Text = "Gérer les bouteilles";
            this.gestionDesBouteillesToolStripMenuItem.Click += new System.EventHandler(this.GestionDesBouteillesToolStripMenuItem_Click);
            // 
            // gestionDesCasiersToolStripMenuItem
            // 
            this.gestionDesCasiersToolStripMenuItem.Name = "gestionDesCasiersToolStripMenuItem";
            this.gestionDesCasiersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionDesCasiersToolStripMenuItem.Text = "Gérer les casiers";
            this.gestionDesCasiersToolStripMenuItem.Click += new System.EventHandler(this.GestionDesCasiersToolStripMenuItem_Click);
            // 
            // afficherLhistoriqueToolStripMenuItem
            // 
            this.afficherLhistoriqueToolStripMenuItem.Name = "afficherLhistoriqueToolStripMenuItem";
            this.afficherLhistoriqueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.afficherLhistoriqueToolStripMenuItem.Text = "Historique";
            this.afficherLhistoriqueToolStripMenuItem.Click += new System.EventHandler(this.AfficherLhistoriqueToolStripMenuItem_Click);
            // 
            // researchStripMenuItem
            // 
            this.researchStripMenuItem.Name = "researchStripMenuItem";
            this.researchStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.researchStripMenuItem.Text = "Rechercher";
            this.researchStripMenuItem.Click += new System.EventHandler(this.researchToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
            // 
            // picMainPage
            // 
            this.picMainPage.Location = new System.Drawing.Point(124, 90);
            this.picMainPage.Name = "picMainPage";
            this.picMainPage.Size = new System.Drawing.Size(569, 269);
            this.picMainPage.TabIndex = 1;
            this.picMainPage.TabStop = false;
            // 
            // MainPagefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picMainPage);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainPagefrm";
            this.Text = "WineManager";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesBouteillesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesCasiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem researchStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLhistoriqueToolStripMenuItem;
        private System.Windows.Forms.PictureBox picMainPage;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}

