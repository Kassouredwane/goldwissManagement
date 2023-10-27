namespace projet_gestionEntreprise
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_gestionClients = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_gestionCommandes = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_gestionStock = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_gestionTransfere = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_transferePhasonieToLavage = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_transfereLavageToPhasonie = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_transfereToStock = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_statistiques = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_parametres = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_deconnecter = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_gestionClients,
            this.btn_gestionCommandes,
            this.btn_gestionStock,
            this.btn_gestionTransfere,
            this.btn_statistiques,
            this.btn_parametres,
            this.btn_deconnecter});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(15, 15, 0, 15);
            this.menuStrip1.Size = new System.Drawing.Size(1494, 50);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_gestionClients
            // 
            this.btn_gestionClients.Image = ((System.Drawing.Image)(resources.GetObject("btn_gestionClients.Image")));
            this.btn_gestionClients.Name = "btn_gestionClients";
            this.btn_gestionClients.Size = new System.Drawing.Size(128, 20);
            this.btn_gestionClients.Text = "Gestion de clients";
            // 
            // btn_gestionCommandes
            // 
            this.btn_gestionCommandes.Image = ((System.Drawing.Image)(resources.GetObject("btn_gestionCommandes.Image")));
            this.btn_gestionCommandes.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_gestionCommandes.Name = "btn_gestionCommandes";
            this.btn_gestionCommandes.Size = new System.Drawing.Size(160, 20);
            this.btn_gestionCommandes.Text = "Gestion de commandes";
            // 
            // btn_gestionStock
            // 
            this.btn_gestionStock.Image = ((System.Drawing.Image)(resources.GetObject("btn_gestionStock.Image")));
            this.btn_gestionStock.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_gestionStock.Name = "btn_gestionStock";
            this.btn_gestionStock.Size = new System.Drawing.Size(122, 20);
            this.btn_gestionStock.Text = "Gestion de stock";
            // 
            // btn_gestionTransfere
            // 
            this.btn_gestionTransfere.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_transferePhasonieToLavage,
            this.btn_transfereLavageToPhasonie,
            this.btn_transfereToStock});
            this.btn_gestionTransfere.Image = ((System.Drawing.Image)(resources.GetObject("btn_gestionTransfere.Image")));
            this.btn_gestionTransfere.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_gestionTransfere.Name = "btn_gestionTransfere";
            this.btn_gestionTransfere.Size = new System.Drawing.Size(140, 20);
            this.btn_gestionTransfere.Text = "Gestion de transfere";
            // 
            // btn_transferePhasonieToLavage
            // 
            this.btn_transferePhasonieToLavage.Image = ((System.Drawing.Image)(resources.GetObject("btn_transferePhasonieToLavage.Image")));
            this.btn_transferePhasonieToLavage.Name = "btn_transferePhasonieToLavage";
            this.btn_transferePhasonieToLavage.Size = new System.Drawing.Size(198, 22);
            this.btn_transferePhasonieToLavage.Text = "Du phasonie a lavage";
            // 
            // btn_transfereLavageToPhasonie
            // 
            this.btn_transfereLavageToPhasonie.Image = ((System.Drawing.Image)(resources.GetObject("btn_transfereLavageToPhasonie.Image")));
            this.btn_transfereLavageToPhasonie.Name = "btn_transfereLavageToPhasonie";
            this.btn_transfereLavageToPhasonie.Size = new System.Drawing.Size(198, 22);
            this.btn_transfereLavageToPhasonie.Text = "Du lavage a le phasonie";
            // 
            // btn_transfereToStock
            // 
            this.btn_transfereToStock.Image = ((System.Drawing.Image)(resources.GetObject("btn_transfereToStock.Image")));
            this.btn_transfereToStock.Name = "btn_transfereToStock";
            this.btn_transfereToStock.Size = new System.Drawing.Size(198, 22);
            this.btn_transfereToStock.Text = "Du phasonie a le stock";
            // 
            // btn_statistiques
            // 
            this.btn_statistiques.Image = ((System.Drawing.Image)(resources.GetObject("btn_statistiques.Image")));
            this.btn_statistiques.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_statistiques.Name = "btn_statistiques";
            this.btn_statistiques.Size = new System.Drawing.Size(167, 20);
            this.btn_statistiques.Text = "Statiqtiques d\'entreprises";
            // 
            // btn_parametres
            // 
            this.btn_parametres.Image = ((System.Drawing.Image)(resources.GetObject("btn_parametres.Image")));
            this.btn_parametres.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_parametres.Name = "btn_parametres";
            this.btn_parametres.Size = new System.Drawing.Size(94, 20);
            this.btn_parametres.Text = "Parametres";
            // 
            // btn_deconnecter
            // 
            this.btn_deconnecter.Image = ((System.Drawing.Image)(resources.GetObject("btn_deconnecter.Image")));
            this.btn_deconnecter.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_deconnecter.Name = "btn_deconnecter";
            this.btn_deconnecter.Size = new System.Drawing.Size(102, 20);
            this.btn_deconnecter.Text = "Deconnecter";
            this.btn_deconnecter.Click += new System.EventHandler(this.btn_deconnecter_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1494, 993);
            this.panel1.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 1061);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_gestionClients;
        private System.Windows.Forms.ToolStripMenuItem btn_gestionCommandes;
        private System.Windows.Forms.ToolStripMenuItem btn_gestionStock;
        private System.Windows.Forms.ToolStripMenuItem btn_gestionTransfere;
        private System.Windows.Forms.ToolStripMenuItem btn_transferePhasonieToLavage;
        private System.Windows.Forms.ToolStripMenuItem btn_transfereLavageToPhasonie;
        private System.Windows.Forms.ToolStripMenuItem btn_transfereToStock;
        private System.Windows.Forms.ToolStripMenuItem btn_statistiques;
        private System.Windows.Forms.ToolStripMenuItem btn_parametres;
        private System.Windows.Forms.ToolStripMenuItem btn_deconnecter;
        private System.Windows.Forms.Panel panel1;
    }
}