namespace DBW2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catégoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.catalogueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            // 
            // catalogueToolStripMenuItem
            // 
            this.catalogueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produitsToolStripMenuItem,
            this.catégoriesToolStripMenuItem});
            this.catalogueToolStripMenuItem.Name = "catalogueToolStripMenuItem";
            this.catalogueToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.catalogueToolStripMenuItem.Text = "Catalogue";
            // 
            // produitsToolStripMenuItem
            // 
            this.produitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.consulterToolStripMenuItem});
            this.produitsToolStripMenuItem.Name = "produitsToolStripMenuItem";
            this.produitsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.produitsToolStripMenuItem.Text = "Produits";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.AjouterToolStripMenuItem_Click);
            // 
            // consulterToolStripMenuItem
            // 
            this.consulterToolStripMenuItem.Name = "consulterToolStripMenuItem";
            this.consulterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.consulterToolStripMenuItem.Text = "Consulter";
            this.consulterToolStripMenuItem.Click += new System.EventHandler(this.ConsulterToolStripMenuItem_Click);
            // 
            // catégoriesToolStripMenuItem
            // 
            this.catégoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.consulterToolStripMenuItem1});
            this.catégoriesToolStripMenuItem.Name = "catégoriesToolStripMenuItem";
            this.catégoriesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.catégoriesToolStripMenuItem.Text = "Catégories";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            // 
            // consulterToolStripMenuItem1
            // 
            this.consulterToolStripMenuItem1.Name = "consulterToolStripMenuItem1";
            this.consulterToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.consulterToolStripMenuItem1.Text = "consulter";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 552);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Catalogue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catégoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem1;
    }
}

