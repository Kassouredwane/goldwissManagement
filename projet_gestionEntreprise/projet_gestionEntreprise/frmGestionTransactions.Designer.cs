namespace projet_gestionEntreprise
{
    partial class frmGestionTransactions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionTransactions));
            this.dgv_transactions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_recherche = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rechercher = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_supprimerTous = new Guna.UI2.WinForms.Guna2Button();
            this.btn_supprimer = new Guna.UI2.WinForms.Guna2Button();
            this.btn_modifier = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ajouter = new Guna.UI2.WinForms.Guna2Button();
            this.btn_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.btn_rechercher = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_dateFinale = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_dateDebut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.rb_filtreParDate = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rb_tousTransactions = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btn_imprimerLivraison = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transactions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_transactions
            // 
            this.dgv_transactions.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_transactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_transactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_transactions.ColumnHeadersHeight = 20;
            this.dgv_transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_transactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_transactions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_transactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_transactions.Location = new System.Drawing.Point(42, 106);
            this.dgv_transactions.Name = "dgv_transactions";
            this.dgv_transactions.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_transactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_transactions.RowHeadersVisible = false;
            this.dgv_transactions.Size = new System.Drawing.Size(1161, 719);
            this.dgv_transactions.TabIndex = 55;
            this.dgv_transactions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_transactions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_transactions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_transactions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_transactions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_transactions.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_transactions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_transactions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_transactions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_transactions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_transactions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_transactions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_transactions.ThemeStyle.HeaderStyle.Height = 20;
            this.dgv_transactions.ThemeStyle.ReadOnly = true;
            this.dgv_transactions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_transactions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_transactions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_transactions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_transactions.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_transactions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_transactions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Transaction";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id Client";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nom Complet";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Montant";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date Transaction";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Description";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Type Transaction";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // cb_recherche
            // 
            this.cb_recherche.FormattingEnabled = true;
            this.cb_recherche.Items.AddRange(new object[] {
            "Id Transaction",
            "Id Client",
            "Nom Client",
            "Date Transaction"});
            this.cb_recherche.Location = new System.Drawing.Point(179, 60);
            this.cb_recherche.Name = "cb_recherche";
            this.cb_recherche.Size = new System.Drawing.Size(187, 21);
            this.cb_recherche.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "Rechercher Par :";
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
            this.txt_rechercher.Location = new System.Drawing.Point(830, 53);
            this.txt_rechercher.Name = "txt_rechercher";
            this.txt_rechercher.PasswordChar = '\0';
            this.txt_rechercher.PlaceholderText = "Rechercher Sur un client...";
            this.txt_rechercher.SelectedText = "";
            this.txt_rechercher.Size = new System.Drawing.Size(249, 29);
            this.txt_rechercher.TabIndex = 67;
            // 
            // btn_supprimerTous
            // 
            this.btn_supprimerTous.BorderRadius = 2;
            this.btn_supprimerTous.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_supprimerTous.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_supprimerTous.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_supprimerTous.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_supprimerTous.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_supprimerTous.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimerTous.ForeColor = System.Drawing.Color.White;
            this.btn_supprimerTous.Image = ((System.Drawing.Image)(resources.GetObject("btn_supprimerTous.Image")));
            this.btn_supprimerTous.Location = new System.Drawing.Point(588, 831);
            this.btn_supprimerTous.Name = "btn_supprimerTous";
            this.btn_supprimerTous.Size = new System.Drawing.Size(224, 29);
            this.btn_supprimerTous.TabIndex = 75;
            this.btn_supprimerTous.Text = "Supprimer tous les transactions";
            this.btn_supprimerTous.Click += new System.EventHandler(this.btn_supprimerTous_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.BorderRadius = 2;
            this.btn_supprimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_supprimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_supprimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_supprimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_supprimer.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_supprimer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_supprimer.Image = ((System.Drawing.Image)(resources.GetObject("btn_supprimer.Image")));
            this.btn_supprimer.Location = new System.Drawing.Point(818, 831);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(121, 29);
            this.btn_supprimer.TabIndex = 74;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
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
            this.btn_modifier.Location = new System.Drawing.Point(950, 831);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(121, 29);
            this.btn_modifier.TabIndex = 73;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
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
            this.btn_ajouter.Location = new System.Drawing.Point(1082, 831);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(121, 29);
            this.btn_ajouter.TabIndex = 72;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BorderRadius = 2;
            this.btn_refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_refresh.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_refresh.Location = new System.Drawing.Point(372, 57);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_refresh.Size = new System.Drawing.Size(39, 25);
            this.btn_refresh.TabIndex = 71;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.BorderRadius = 2;
            this.btn_rechercher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_rechercher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_rechercher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_rechercher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_rechercher.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_rechercher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_rechercher.ForeColor = System.Drawing.Color.White;
            this.btn_rechercher.Image = ((System.Drawing.Image)(resources.GetObject("btn_rechercher.Image")));
            this.btn_rechercher.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_rechercher.Location = new System.Drawing.Point(1085, 53);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_rechercher.Size = new System.Drawing.Size(118, 29);
            this.btn_rechercher.TabIndex = 68;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.Click += new System.EventHandler(this.btn_rechercher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(897, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 81;
            this.label1.Text = "Date Finale :";
            // 
            // dtp_dateFinale
            // 
            this.dtp_dateFinale.BorderRadius = 2;
            this.dtp_dateFinale.Checked = true;
            this.dtp_dateFinale.FillColor = System.Drawing.Color.SlateGray;
            this.dtp_dateFinale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dateFinale.ForeColor = System.Drawing.Color.White;
            this.dtp_dateFinale.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_dateFinale.Location = new System.Drawing.Point(999, 12);
            this.dtp_dateFinale.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_dateFinale.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_dateFinale.Name = "dtp_dateFinale";
            this.dtp_dateFinale.Size = new System.Drawing.Size(204, 23);
            this.dtp_dateFinale.TabIndex = 80;
            this.dtp_dateFinale.Value = new System.DateTime(2023, 11, 24, 17, 9, 45, 896);
            this.dtp_dateFinale.ValueChanged += new System.EventHandler(this.dtp_dateFinale_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(570, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 79;
            this.label3.Text = "Date Début :";
            // 
            // dtp_dateDebut
            // 
            this.dtp_dateDebut.BorderRadius = 2;
            this.dtp_dateDebut.Checked = true;
            this.dtp_dateDebut.FillColor = System.Drawing.Color.SlateGray;
            this.dtp_dateDebut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dateDebut.ForeColor = System.Drawing.Color.White;
            this.dtp_dateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_dateDebut.Location = new System.Drawing.Point(670, 12);
            this.dtp_dateDebut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_dateDebut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_dateDebut.Name = "dtp_dateDebut";
            this.dtp_dateDebut.Size = new System.Drawing.Size(204, 23);
            this.dtp_dateDebut.TabIndex = 78;
            this.dtp_dateDebut.Value = new System.DateTime(2023, 11, 24, 17, 9, 45, 896);
            this.dtp_dateDebut.ValueChanged += new System.EventHandler(this.dtp_dateDebut_ValueChanged);
            // 
            // rb_filtreParDate
            // 
            this.rb_filtreParDate.AutoSize = true;
            this.rb_filtreParDate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_filtreParDate.CheckedState.BorderThickness = 0;
            this.rb_filtreParDate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_filtreParDate.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb_filtreParDate.CheckedState.InnerOffset = -4;
            this.rb_filtreParDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_filtreParDate.Location = new System.Drawing.Point(237, 14);
            this.rb_filtreParDate.Name = "rb_filtreParDate";
            this.rb_filtreParDate.Size = new System.Drawing.Size(123, 19);
            this.rb_filtreParDate.TabIndex = 77;
            this.rb_filtreParDate.Text = "Filtrer Par Date";
            this.rb_filtreParDate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb_filtreParDate.UncheckedState.BorderThickness = 2;
            this.rb_filtreParDate.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb_filtreParDate.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rb_filtreParDate.CheckedChanged += new System.EventHandler(this.rb_filtreParDate_CheckedChanged);
            // 
            // rb_tousTransactions
            // 
            this.rb_tousTransactions.AutoSize = true;
            this.rb_tousTransactions.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_tousTransactions.CheckedState.BorderThickness = 0;
            this.rb_tousTransactions.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_tousTransactions.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb_tousTransactions.CheckedState.InnerOffset = -4;
            this.rb_tousTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_tousTransactions.Location = new System.Drawing.Point(46, 14);
            this.rb_tousTransactions.Name = "rb_tousTransactions";
            this.rb_tousTransactions.Size = new System.Drawing.Size(169, 19);
            this.rb_tousTransactions.TabIndex = 76;
            this.rb_tousTransactions.Text = "Tous Les Transactions";
            this.rb_tousTransactions.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb_tousTransactions.UncheckedState.BorderThickness = 2;
            this.rb_tousTransactions.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb_tousTransactions.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rb_tousTransactions.CheckedChanged += new System.EventHandler(this.rb_tousTransactions_CheckedChanged);
            // 
            // btn_imprimerLivraison
            // 
            this.btn_imprimerLivraison.BorderRadius = 2;
            this.btn_imprimerLivraison.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_imprimerLivraison.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_imprimerLivraison.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_imprimerLivraison.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_imprimerLivraison.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_imprimerLivraison.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimerLivraison.ForeColor = System.Drawing.Color.White;
            this.btn_imprimerLivraison.Image = ((System.Drawing.Image)(resources.GetObject("btn_imprimerLivraison.Image")));
            this.btn_imprimerLivraison.Location = new System.Drawing.Point(42, 831);
            this.btn_imprimerLivraison.Name = "btn_imprimerLivraison";
            this.btn_imprimerLivraison.Size = new System.Drawing.Size(182, 29);
            this.btn_imprimerLivraison.TabIndex = 82;
            this.btn_imprimerLivraison.Text = "Imprimer la Transaction";
            // 
            // frmGestionTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 895);
            this.Controls.Add(this.btn_imprimerLivraison);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_dateFinale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_dateDebut);
            this.Controls.Add(this.rb_filtreParDate);
            this.Controls.Add(this.rb_tousTransactions);
            this.Controls.Add(this.btn_supprimerTous);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.cb_recherche);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_rechercher);
            this.Controls.Add(this.txt_rechercher);
            this.Controls.Add(this.dgv_transactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionTransactions";
            this.Text = "frmGestionTransactions";
            this.Load += new System.EventHandler(this.frmGestionTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_transactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private Guna.UI2.WinForms.Guna2Button btn_refresh;
        private System.Windows.Forms.ComboBox cb_recherche;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_rechercher;
        private Guna.UI2.WinForms.Guna2TextBox txt_rechercher;
        private Guna.UI2.WinForms.Guna2Button btn_supprimer;
        private Guna.UI2.WinForms.Guna2Button btn_modifier;
        private Guna.UI2.WinForms.Guna2Button btn_ajouter;
        private Guna.UI2.WinForms.Guna2Button btn_supprimerTous;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_dateFinale;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_dateDebut;
        private Guna.UI2.WinForms.Guna2RadioButton rb_filtreParDate;
        private Guna.UI2.WinForms.Guna2RadioButton rb_tousTransactions;
        private Guna.UI2.WinForms.Guna2Button btn_imprimerLivraison;
    }
}