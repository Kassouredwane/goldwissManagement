
namespace projet_gestionEntreprise
{
    partial class frmTransactionsClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactionsClient));
            this.dgv_transactions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rb_tousTransactions = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rb_filtreParDate = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btn_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.txt_rechercher = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_rechercher = new Guna.UI2.WinForms.Guna2Button();
            this.dtp_dateDebut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_dateFinale = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_annuler = new Guna.UI2.WinForms.Guna2Button();
            this.btn_imprimerTransaction = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transactions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_transactions
            // 
            this.dgv_transactions.AllowUserToAddRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgv_transactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_transactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_transactions.ColumnHeadersHeight = 20;
            this.dgv_transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_transactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_transactions.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_transactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_transactions.Location = new System.Drawing.Point(42, 130);
            this.dgv_transactions.Name = "dgv_transactions";
            this.dgv_transactions.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_transactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_transactions.RowHeadersVisible = false;
            this.dgv_transactions.Size = new System.Drawing.Size(851, 471);
            this.dgv_transactions.TabIndex = 56;
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
            // rb_tousTransactions
            // 
            this.rb_tousTransactions.AutoSize = true;
            this.rb_tousTransactions.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_tousTransactions.CheckedState.BorderThickness = 0;
            this.rb_tousTransactions.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_tousTransactions.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb_tousTransactions.CheckedState.InnerOffset = -4;
            this.rb_tousTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_tousTransactions.Location = new System.Drawing.Point(42, 36);
            this.rb_tousTransactions.Name = "rb_tousTransactions";
            this.rb_tousTransactions.Size = new System.Drawing.Size(169, 19);
            this.rb_tousTransactions.TabIndex = 57;
            this.rb_tousTransactions.Text = "Tous Les Transactions";
            this.rb_tousTransactions.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb_tousTransactions.UncheckedState.BorderThickness = 2;
            this.rb_tousTransactions.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb_tousTransactions.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rb_tousTransactions.CheckedChanged += new System.EventHandler(this.rb_tousTransactions_CheckedChanged);
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
            this.rb_filtreParDate.Location = new System.Drawing.Point(233, 36);
            this.rb_filtreParDate.Name = "rb_filtreParDate";
            this.rb_filtreParDate.Size = new System.Drawing.Size(123, 19);
            this.rb_filtreParDate.TabIndex = 58;
            this.rb_filtreParDate.Text = "Filtrer Par Date";
            this.rb_filtreParDate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb_filtreParDate.UncheckedState.BorderThickness = 2;
            this.rb_filtreParDate.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb_filtreParDate.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rb_filtreParDate.CheckedChanged += new System.EventHandler(this.rb_filtreParDate_CheckedChanged);
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
            this.btn_refresh.Location = new System.Drawing.Point(854, 34);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_refresh.Size = new System.Drawing.Size(39, 25);
            this.btn_refresh.TabIndex = 64;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
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
            this.txt_rechercher.Location = new System.Drawing.Point(498, 34);
            this.txt_rechercher.Name = "txt_rechercher";
            this.txt_rechercher.PasswordChar = '\0';
            this.txt_rechercher.PlaceholderText = "Rechercher Sur Une Matla ...";
            this.txt_rechercher.SelectedText = "";
            this.txt_rechercher.Size = new System.Drawing.Size(231, 25);
            this.txt_rechercher.TabIndex = 63;
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
            this.btn_rechercher.Location = new System.Drawing.Point(735, 34);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_rechercher.Size = new System.Drawing.Size(113, 25);
            this.btn_rechercher.TabIndex = 62;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.Click += new System.EventHandler(this.btn_rechercher_Click);
            // 
            // dtp_dateDebut
            // 
            this.dtp_dateDebut.BorderRadius = 2;
            this.dtp_dateDebut.Checked = true;
            this.dtp_dateDebut.FillColor = System.Drawing.Color.SlateGray;
            this.dtp_dateDebut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dateDebut.ForeColor = System.Drawing.Color.White;
            this.dtp_dateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_dateDebut.Location = new System.Drawing.Point(141, 84);
            this.dtp_dateDebut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_dateDebut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_dateDebut.Name = "dtp_dateDebut";
            this.dtp_dateDebut.Size = new System.Drawing.Size(204, 23);
            this.dtp_dateDebut.TabIndex = 65;
            this.dtp_dateDebut.Value = new System.DateTime(2023, 11, 24, 17, 9, 45, 896);
            this.dtp_dateDebut.ValueChanged += new System.EventHandler(this.dtp_dateDebut_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 66;
            this.label2.Text = "Date Début :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(366, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 68;
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
            this.dtp_dateFinale.Location = new System.Drawing.Point(468, 86);
            this.dtp_dateFinale.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_dateFinale.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_dateFinale.Name = "dtp_dateFinale";
            this.dtp_dateFinale.Size = new System.Drawing.Size(204, 23);
            this.dtp_dateFinale.TabIndex = 67;
            this.dtp_dateFinale.Value = new System.DateTime(2023, 11, 24, 17, 9, 45, 896);
            this.dtp_dateFinale.ValueChanged += new System.EventHandler(this.dtp_dateFinale_ValueChanged);
            // 
            // btn_annuler
            // 
            this.btn_annuler.BorderRadius = 2;
            this.btn_annuler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_annuler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_annuler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_annuler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_annuler.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_annuler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.ForeColor = System.Drawing.Color.White;
            this.btn_annuler.Image = ((System.Drawing.Image)(resources.GetObject("btn_annuler.Image")));
            this.btn_annuler.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_annuler.Location = new System.Drawing.Point(772, 607);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_annuler.Size = new System.Drawing.Size(121, 29);
            this.btn_annuler.TabIndex = 69;
            this.btn_annuler.Text = "Fermer";
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_imprimerTransaction
            // 
            this.btn_imprimerTransaction.BorderRadius = 2;
            this.btn_imprimerTransaction.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_imprimerTransaction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_imprimerTransaction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_imprimerTransaction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_imprimerTransaction.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_imprimerTransaction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimerTransaction.ForeColor = System.Drawing.Color.White;
            this.btn_imprimerTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btn_imprimerTransaction.Image")));
            this.btn_imprimerTransaction.Location = new System.Drawing.Point(42, 607);
            this.btn_imprimerTransaction.Name = "btn_imprimerTransaction";
            this.btn_imprimerTransaction.Size = new System.Drawing.Size(182, 29);
            this.btn_imprimerTransaction.TabIndex = 72;
            this.btn_imprimerTransaction.Text = "Imprimer les Transaction";
            this.btn_imprimerTransaction.Click += new System.EventHandler(this.btn_imprimerTransaction_Click);
            // 
            // frmTransactionsClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 644);
            this.Controls.Add(this.btn_imprimerTransaction);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_dateFinale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_dateDebut);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.txt_rechercher);
            this.Controls.Add(this.btn_rechercher);
            this.Controls.Add(this.rb_filtreParDate);
            this.Controls.Add(this.rb_tousTransactions);
            this.Controls.Add(this.dgv_transactions);
            this.Name = "frmTransactionsClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransactionsClient";
            this.Load += new System.EventHandler(this.frmTransactionsClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_transactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private Guna.UI2.WinForms.Guna2RadioButton rb_tousTransactions;
        private Guna.UI2.WinForms.Guna2RadioButton rb_filtreParDate;
        private Guna.UI2.WinForms.Guna2Button btn_refresh;
        private Guna.UI2.WinForms.Guna2TextBox txt_rechercher;
        private Guna.UI2.WinForms.Guna2Button btn_rechercher;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_dateDebut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_dateFinale;
        private Guna.UI2.WinForms.Guna2Button btn_annuler;
        private Guna.UI2.WinForms.Guna2Button btn_imprimerTransaction;
    }
}