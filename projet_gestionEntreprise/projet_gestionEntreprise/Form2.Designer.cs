namespace projet_gestionEntreprise
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_deconnecter = new Guna.UI2.WinForms.Guna2Button();
            this.btn_parametres = new Guna.UI2.WinForms.Guna2Button();
            this.btn_statistiques = new Guna.UI2.WinForms.Guna2Button();
            this.dropDownContainer = new System.Windows.Forms.Panel();
            this.btn_phasonieToStock = new Guna.UI2.WinForms.Guna2Button();
            this.btn_transfereLavageToPhasonie = new Guna.UI2.WinForms.Guna2Button();
            this.btn_transferePhasonieToLavage = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_gestionTransfere = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_gestionStock = new Guna.UI2.WinForms.Guna2Button();
            this.btn_gestionCommandes = new Guna.UI2.WinForms.Guna2Button();
            this.btn_gestionClients = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.dropDownContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dropDownContainer);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_gestionStock);
            this.panel1.Controls.Add(this.btn_gestionCommandes);
            this.panel1.Controls.Add(this.btn_gestionClients);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 878);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_deconnecter);
            this.panel2.Controls.Add(this.btn_parametres);
            this.panel2.Controls.Add(this.btn_statistiques);
            this.panel2.Location = new System.Drawing.Point(4, 449);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 174);
            this.panel2.TabIndex = 11;
            // 
            // btn_deconnecter
            // 
            this.btn_deconnecter.Animated = true;
            this.btn_deconnecter.BackColor = System.Drawing.Color.Transparent;
            this.btn_deconnecter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_deconnecter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_deconnecter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_deconnecter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_deconnecter.FillColor = System.Drawing.Color.Transparent;
            this.btn_deconnecter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_deconnecter.ForeColor = System.Drawing.Color.White;
            this.btn_deconnecter.Image = ((System.Drawing.Image)(resources.GetObject("btn_deconnecter.Image")));
            this.btn_deconnecter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_deconnecter.Location = new System.Drawing.Point(2, 130);
            this.btn_deconnecter.Name = "btn_deconnecter";
            this.btn_deconnecter.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_deconnecter.Size = new System.Drawing.Size(240, 35);
            this.btn_deconnecter.TabIndex = 9;
            this.btn_deconnecter.Text = "Deconnecter";
            this.btn_deconnecter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_deconnecter.UseTransparentBackground = true;
            this.btn_deconnecter.Click += new System.EventHandler(this.btn_deconnecter_Click);
            // 
            // btn_parametres
            // 
            this.btn_parametres.Animated = true;
            this.btn_parametres.BackColor = System.Drawing.Color.Transparent;
            this.btn_parametres.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_parametres.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_parametres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_parametres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_parametres.FillColor = System.Drawing.Color.Transparent;
            this.btn_parametres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_parametres.ForeColor = System.Drawing.Color.White;
            this.btn_parametres.Image = ((System.Drawing.Image)(resources.GetObject("btn_parametres.Image")));
            this.btn_parametres.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_parametres.Location = new System.Drawing.Point(2, 73);
            this.btn_parametres.Name = "btn_parametres";
            this.btn_parametres.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_parametres.Size = new System.Drawing.Size(240, 35);
            this.btn_parametres.TabIndex = 8;
            this.btn_parametres.Text = "Parametres";
            this.btn_parametres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_parametres.UseTransparentBackground = true;
            // 
            // btn_statistiques
            // 
            this.btn_statistiques.Animated = true;
            this.btn_statistiques.BackColor = System.Drawing.Color.Transparent;
            this.btn_statistiques.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_statistiques.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_statistiques.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_statistiques.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_statistiques.FillColor = System.Drawing.Color.Transparent;
            this.btn_statistiques.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_statistiques.ForeColor = System.Drawing.Color.White;
            this.btn_statistiques.Image = ((System.Drawing.Image)(resources.GetObject("btn_statistiques.Image")));
            this.btn_statistiques.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_statistiques.Location = new System.Drawing.Point(2, 16);
            this.btn_statistiques.Name = "btn_statistiques";
            this.btn_statistiques.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_statistiques.Size = new System.Drawing.Size(240, 35);
            this.btn_statistiques.TabIndex = 7;
            this.btn_statistiques.Text = "Statistiques";
            this.btn_statistiques.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_statistiques.UseTransparentBackground = true;
            // 
            // dropDownContainer
            // 
            this.dropDownContainer.Controls.Add(this.btn_phasonieToStock);
            this.dropDownContainer.Controls.Add(this.btn_transfereLavageToPhasonie);
            this.dropDownContainer.Controls.Add(this.btn_transferePhasonieToLavage);
            this.dropDownContainer.Controls.Add(this.panel3);
            this.dropDownContainer.Location = new System.Drawing.Point(6, 407);
            this.dropDownContainer.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.dropDownContainer.MaximumSize = new System.Drawing.Size(240, 155);
            this.dropDownContainer.MinimumSize = new System.Drawing.Size(240, 35);
            this.dropDownContainer.Name = "dropDownContainer";
            this.dropDownContainer.Size = new System.Drawing.Size(240, 37);
            this.dropDownContainer.TabIndex = 7;
            // 
            // btn_phasonieToStock
            // 
            this.btn_phasonieToStock.Animated = true;
            this.btn_phasonieToStock.BackColor = System.Drawing.Color.Transparent;
            this.btn_phasonieToStock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_phasonieToStock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_phasonieToStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_phasonieToStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_phasonieToStock.FillColor = System.Drawing.Color.Transparent;
            this.btn_phasonieToStock.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phasonieToStock.ForeColor = System.Drawing.Color.White;
            this.btn_phasonieToStock.Image = ((System.Drawing.Image)(resources.GetObject("btn_phasonieToStock.Image")));
            this.btn_phasonieToStock.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_phasonieToStock.Location = new System.Drawing.Point(0, 115);
            this.btn_phasonieToStock.Name = "btn_phasonieToStock";
            this.btn_phasonieToStock.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_phasonieToStock.Size = new System.Drawing.Size(240, 35);
            this.btn_phasonieToStock.TabIndex = 15;
            this.btn_phasonieToStock.Text = "Du phasonie a stock";
            this.btn_phasonieToStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_phasonieToStock.UseTransparentBackground = true;
            // 
            // btn_transfereLavageToPhasonie
            // 
            this.btn_transfereLavageToPhasonie.Animated = true;
            this.btn_transfereLavageToPhasonie.BackColor = System.Drawing.Color.Transparent;
            this.btn_transfereLavageToPhasonie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_transfereLavageToPhasonie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_transfereLavageToPhasonie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_transfereLavageToPhasonie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_transfereLavageToPhasonie.FillColor = System.Drawing.Color.Transparent;
            this.btn_transfereLavageToPhasonie.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transfereLavageToPhasonie.ForeColor = System.Drawing.Color.White;
            this.btn_transfereLavageToPhasonie.Image = ((System.Drawing.Image)(resources.GetObject("btn_transfereLavageToPhasonie.Image")));
            this.btn_transfereLavageToPhasonie.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_transfereLavageToPhasonie.Location = new System.Drawing.Point(0, 77);
            this.btn_transfereLavageToPhasonie.Name = "btn_transfereLavageToPhasonie";
            this.btn_transfereLavageToPhasonie.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_transfereLavageToPhasonie.Size = new System.Drawing.Size(240, 35);
            this.btn_transfereLavageToPhasonie.TabIndex = 13;
            this.btn_transfereLavageToPhasonie.Text = "Du lavage a phasonie";
            this.btn_transfereLavageToPhasonie.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_transfereLavageToPhasonie.UseTransparentBackground = true;
            // 
            // btn_transferePhasonieToLavage
            // 
            this.btn_transferePhasonieToLavage.Animated = true;
            this.btn_transferePhasonieToLavage.BackColor = System.Drawing.Color.Transparent;
            this.btn_transferePhasonieToLavage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_transferePhasonieToLavage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_transferePhasonieToLavage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_transferePhasonieToLavage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_transferePhasonieToLavage.FillColor = System.Drawing.Color.Transparent;
            this.btn_transferePhasonieToLavage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transferePhasonieToLavage.ForeColor = System.Drawing.Color.White;
            this.btn_transferePhasonieToLavage.Image = ((System.Drawing.Image)(resources.GetObject("btn_transferePhasonieToLavage.Image")));
            this.btn_transferePhasonieToLavage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_transferePhasonieToLavage.Location = new System.Drawing.Point(0, 37);
            this.btn_transferePhasonieToLavage.Name = "btn_transferePhasonieToLavage";
            this.btn_transferePhasonieToLavage.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_transferePhasonieToLavage.Size = new System.Drawing.Size(240, 35);
            this.btn_transferePhasonieToLavage.TabIndex = 12;
            this.btn_transferePhasonieToLavage.Text = "Du phasonie a lavage";
            this.btn_transferePhasonieToLavage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_transferePhasonieToLavage.UseTransparentBackground = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.btn_gestionTransfere);
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 35);
            this.panel3.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btn_gestionTransfere
            // 
            this.btn_gestionTransfere.Animated = true;
            this.btn_gestionTransfere.BackColor = System.Drawing.Color.Transparent;
            this.btn_gestionTransfere.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_gestionTransfere.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_gestionTransfere.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_gestionTransfere.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_gestionTransfere.FillColor = System.Drawing.Color.Transparent;
            this.btn_gestionTransfere.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_gestionTransfere.ForeColor = System.Drawing.Color.White;
            this.btn_gestionTransfere.Image = global::projet_gestionEntreprise.Properties.Resources.icons8_flèche_développer_64;
            this.btn_gestionTransfere.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_gestionTransfere.Location = new System.Drawing.Point(0, -1);
            this.btn_gestionTransfere.Name = "btn_gestionTransfere";
            this.btn_gestionTransfere.Padding = new System.Windows.Forms.Padding(6, 0, 10, 0);
            this.btn_gestionTransfere.Size = new System.Drawing.Size(240, 35);
            this.btn_gestionTransfere.TabIndex = 11;
            this.btn_gestionTransfere.Text = "Gestion transferes";
            this.btn_gestionTransfere.UseTransparentBackground = true;
            this.btn_gestionTransfere.Click += new System.EventHandler(this.btn_gestionTransfere_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_gestionStock
            // 
            this.btn_gestionStock.Animated = true;
            this.btn_gestionStock.BackColor = System.Drawing.Color.Transparent;
            this.btn_gestionStock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_gestionStock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_gestionStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_gestionStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_gestionStock.FillColor = System.Drawing.Color.Transparent;
            this.btn_gestionStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_gestionStock.ForeColor = System.Drawing.Color.White;
            this.btn_gestionStock.Image = ((System.Drawing.Image)(resources.GetObject("btn_gestionStock.Image")));
            this.btn_gestionStock.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_gestionStock.Location = new System.Drawing.Point(6, 351);
            this.btn_gestionStock.Name = "btn_gestionStock";
            this.btn_gestionStock.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_gestionStock.Size = new System.Drawing.Size(240, 35);
            this.btn_gestionStock.TabIndex = 3;
            this.btn_gestionStock.Text = "Gestion stock";
            this.btn_gestionStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_gestionStock.UseTransparentBackground = true;
            // 
            // btn_gestionCommandes
            // 
            this.btn_gestionCommandes.Animated = true;
            this.btn_gestionCommandes.BackColor = System.Drawing.Color.Transparent;
            this.btn_gestionCommandes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_gestionCommandes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_gestionCommandes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_gestionCommandes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_gestionCommandes.FillColor = System.Drawing.Color.Transparent;
            this.btn_gestionCommandes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_gestionCommandes.ForeColor = System.Drawing.Color.White;
            this.btn_gestionCommandes.Image = ((System.Drawing.Image)(resources.GetObject("btn_gestionCommandes.Image")));
            this.btn_gestionCommandes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_gestionCommandes.Location = new System.Drawing.Point(6, 294);
            this.btn_gestionCommandes.Name = "btn_gestionCommandes";
            this.btn_gestionCommandes.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_gestionCommandes.Size = new System.Drawing.Size(240, 35);
            this.btn_gestionCommandes.TabIndex = 2;
            this.btn_gestionCommandes.Text = "Gestion commandes";
            this.btn_gestionCommandes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_gestionCommandes.UseTransparentBackground = true;
            this.btn_gestionCommandes.Click += new System.EventHandler(this.btn_gestionCommandes_Click);
            // 
            // btn_gestionClients
            // 
            this.btn_gestionClients.Animated = true;
            this.btn_gestionClients.BackColor = System.Drawing.Color.Transparent;
            this.btn_gestionClients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_gestionClients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_gestionClients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_gestionClients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_gestionClients.FillColor = System.Drawing.Color.Transparent;
            this.btn_gestionClients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_gestionClients.ForeColor = System.Drawing.Color.White;
            this.btn_gestionClients.Image = ((System.Drawing.Image)(resources.GetObject("btn_gestionClients.Image")));
            this.btn_gestionClients.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_gestionClients.Location = new System.Drawing.Point(6, 239);
            this.btn_gestionClients.Name = "btn_gestionClients";
            this.btn_gestionClients.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_gestionClients.Size = new System.Drawing.Size(240, 35);
            this.btn_gestionClients.TabIndex = 1;
            this.btn_gestionClients.Text = "Gestion Clients";
            this.btn_gestionClients.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_gestionClients.UseTransparentBackground = true;
            this.btn_gestionClients.Click += new System.EventHandler(this.btn_gestionClients_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(255, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1249, 878);
            this.panel4.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 878);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.dropDownContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_gestionClients;
        private Guna.UI2.WinForms.Guna2Button btn_gestionStock;
        private Guna.UI2.WinForms.Guna2Button btn_gestionCommandes;
        private Guna.UI2.WinForms.Guna2Button btn_deconnecter;
        private Guna.UI2.WinForms.Guna2Button btn_parametres;
        private Guna.UI2.WinForms.Guna2Button btn_statistiques;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel dropDownContainer;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btn_gestionTransfere;
        private Guna.UI2.WinForms.Guna2Button btn_transferePhasonieToLavage;
        private Guna.UI2.WinForms.Guna2Button btn_phasonieToStock;
        private Guna.UI2.WinForms.Guna2Button btn_transfereLavageToPhasonie;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
    }
}