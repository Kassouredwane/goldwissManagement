namespace projet_gestionEntreprise
{
    partial class frmGestionCommandes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionCommandes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_modifier = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ajouter = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_commandeClient = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_qteTotale = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_totalePrix = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_nbCommandes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_recherche = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_rechercher = new Guna.UI2.WinForms.Guna2Button();
            this.txt_rechercher = new Guna.UI2.WinForms.Guna2TextBox();
            this.chk_enCourPaiement = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commandeClient)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_modifier
            // 
            this.btn_modifier.BorderRadius = 2;
            this.btn_modifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_modifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_modifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_modifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_modifier.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_modifier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.ForeColor = System.Drawing.Color.White;
            this.btn_modifier.Image = ((System.Drawing.Image)(resources.GetObject("btn_modifier.Image")));
            this.btn_modifier.Location = new System.Drawing.Point(835, 757);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(121, 29);
            this.btn_modifier.TabIndex = 46;
            this.btn_modifier.Text = "Modifier";
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.BorderRadius = 2;
            this.btn_ajouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ajouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ajouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ajouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ajouter.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_ajouter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter.Image = ((System.Drawing.Image)(resources.GetObject("btn_ajouter.Image")));
            this.btn_ajouter.Location = new System.Drawing.Point(971, 757);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(121, 29);
            this.btn_ajouter.TabIndex = 45;
            this.btn_ajouter.Text = "Ajouter";
            // 
            // dgv_commandeClient
            // 
            this.dgv_commandeClient.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_commandeClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_commandeClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_commandeClient.ColumnHeadersHeight = 15;
            this.dgv_commandeClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_commandeClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_commandeClient.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_commandeClient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_commandeClient.Location = new System.Drawing.Point(143, 230);
            this.dgv_commandeClient.Name = "dgv_commandeClient";
            this.dgv_commandeClient.RowHeadersVisible = false;
            this.dgv_commandeClient.Size = new System.Drawing.Size(948, 511);
            this.dgv_commandeClient.TabIndex = 44;
            this.dgv_commandeClient.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_commandeClient.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_commandeClient.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_commandeClient.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_commandeClient.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_commandeClient.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_commandeClient.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_commandeClient.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_commandeClient.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_commandeClient.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_commandeClient.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_commandeClient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_commandeClient.ThemeStyle.HeaderStyle.Height = 15;
            this.dgv_commandeClient.ThemeStyle.ReadOnly = false;
            this.dgv_commandeClient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_commandeClient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_commandeClient.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_commandeClient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_commandeClient.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_commandeClient.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_commandeClient.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Commande";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date Commande";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "numero de Bon";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Reference modele";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quantite Achat";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Prix Achat";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Statut Payement";
            this.Column7.Name = "Column7";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.lbl_qteTotale);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(842, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 58);
            this.panel3.TabIndex = 42;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_qteTotale
            // 
            this.lbl_qteTotale.AutoSize = true;
            this.lbl_qteTotale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qteTotale.ForeColor = System.Drawing.Color.White;
            this.lbl_qteTotale.Location = new System.Drawing.Point(140, 32);
            this.lbl_qteTotale.Name = "lbl_qteTotale";
            this.lbl_qteTotale.Size = new System.Drawing.Size(31, 16);
            this.lbl_qteTotale.TabIndex = 31;
            this.lbl_qteTotale.Text = "897";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(92, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Quantite totale ;";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lbl_totalePrix);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(500, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 58);
            this.panel1.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(156, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "DH";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_totalePrix
            // 
            this.lbl_totalePrix.AutoSize = true;
            this.lbl_totalePrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalePrix.ForeColor = System.Drawing.Color.White;
            this.lbl_totalePrix.Location = new System.Drawing.Point(97, 32);
            this.lbl_totalePrix.Name = "lbl_totalePrix";
            this.lbl_totalePrix.Size = new System.Drawing.Size(63, 16);
            this.lbl_totalePrix.TabIndex = 31;
            this.lbl_totalePrix.Text = "1080520";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Totale de commandes;";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbl_nbCommandes);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(143, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 58);
            this.panel2.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_nbCommandes
            // 
            this.lbl_nbCommandes.AutoSize = true;
            this.lbl_nbCommandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nbCommandes.ForeColor = System.Drawing.Color.White;
            this.lbl_nbCommandes.Location = new System.Drawing.Point(127, 32);
            this.lbl_nbCommandes.Name = "lbl_nbCommandes";
            this.lbl_nbCommandes.Size = new System.Drawing.Size(23, 16);
            this.lbl_nbCommandes.TabIndex = 31;
            this.lbl_nbCommandes.Text = "17";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre des commandes ;";
            // 
            // cb_recherche
            // 
            this.cb_recherche.FormattingEnabled = true;
            this.cb_recherche.Items.AddRange(new object[] {
            "Code Client",
            "Nom Client",
            "Prénom Client",
            "Telephone Client"});
            this.cb_recherche.Location = new System.Drawing.Point(281, 167);
            this.cb_recherche.Name = "cb_recherche";
            this.cb_recherche.Size = new System.Drawing.Size(182, 21);
            this.cb_recherche.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(143, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Rechercher Par :";
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.BorderRadius = 2;
            this.btn_rechercher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_rechercher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_rechercher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_rechercher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_rechercher.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_rechercher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rechercher.ForeColor = System.Drawing.Color.White;
            this.btn_rechercher.Image = ((System.Drawing.Image)(resources.GetObject("btn_rechercher.Image")));
            this.btn_rechercher.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_rechercher.Location = new System.Drawing.Point(948, 161);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_rechercher.Size = new System.Drawing.Size(142, 29);
            this.btn_rechercher.TabIndex = 50;
            this.btn_rechercher.Text = "Rechercher";
            // 
            // txt_rechercher
            // 
            this.txt_rechercher.BorderRadius = 5;
            this.txt_rechercher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_rechercher.DefaultText = "";
            this.txt_rechercher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_rechercher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_rechercher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_rechercher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_rechercher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_rechercher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_rechercher.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_rechercher.Location = new System.Drawing.Point(618, 161);
            this.txt_rechercher.Name = "txt_rechercher";
            this.txt_rechercher.PasswordChar = '\0';
            this.txt_rechercher.PlaceholderText = "Rechercher Sur un client...";
            this.txt_rechercher.SelectedText = "";
            this.txt_rechercher.Size = new System.Drawing.Size(313, 29);
            this.txt_rechercher.TabIndex = 49;
            // 
            // chk_enCourPaiement
            // 
            this.chk_enCourPaiement.AutoSize = true;
            this.chk_enCourPaiement.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_enCourPaiement.CheckedState.BorderRadius = 0;
            this.chk_enCourPaiement.CheckedState.BorderThickness = 0;
            this.chk_enCourPaiement.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_enCourPaiement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_enCourPaiement.Location = new System.Drawing.Point(145, 757);
            this.chk_enCourPaiement.Name = "chk_enCourPaiement";
            this.chk_enCourPaiement.Size = new System.Drawing.Size(168, 20);
            this.chk_enCourPaiement.TabIndex = 51;
            this.chk_enCourPaiement.Text = "En cour de paiement";
            this.chk_enCourPaiement.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_enCourPaiement.UncheckedState.BorderRadius = 0;
            this.chk_enCourPaiement.UncheckedState.BorderThickness = 0;
            this.chk_enCourPaiement.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // frmGestionCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 807);
            this.Controls.Add(this.chk_enCourPaiement);
            this.Controls.Add(this.btn_rechercher);
            this.Controls.Add(this.txt_rechercher);
            this.Controls.Add(this.cb_recherche);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.dgv_commandeClient);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionCommandes";
            this.Text = "frmGestionCommandes";
            this.Load += new System.EventHandler(this.frmGestionCommandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commandeClient)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_modifier;
        private Guna.UI2.WinForms.Guna2Button btn_ajouter;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_commandeClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_qteTotale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_totalePrix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_nbCommandes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_recherche;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_rechercher;
        private Guna.UI2.WinForms.Guna2TextBox txt_rechercher;
        private Guna.UI2.WinForms.Guna2CheckBox chk_enCourPaiement;
    }
}