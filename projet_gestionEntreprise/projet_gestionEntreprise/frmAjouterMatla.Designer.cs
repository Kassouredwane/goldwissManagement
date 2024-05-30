
namespace projet_gestionEntreprise
{
    partial class frmAjouterMatla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjouterMatla));
            this.btn_ajouterPhasonie = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_idMatla = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_prixPhasonie = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_qteSorter = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_numeroBon = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_detailleur = new System.Windows.Forms.ComboBox();
            this.cb_phasonie = new System.Windows.Forms.ComboBox();
            this.dtp_dateDetailler = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_ajouterDetailleur = new System.Windows.Forms.Button();
            this.btn_annuler = new Guna.UI2.WinForms.Guna2Button();
            this.btn_valider = new Guna.UI2.WinForms.Guna2Button();
            this.txt_taille = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_referenceModele = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ajouterPhasonie
            // 
            this.btn_ajouterPhasonie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouterPhasonie.Location = new System.Drawing.Point(748, 47);
            this.btn_ajouterPhasonie.Name = "btn_ajouterPhasonie";
            this.btn_ajouterPhasonie.Size = new System.Drawing.Size(34, 23);
            this.btn_ajouterPhasonie.TabIndex = 40;
            this.btn_ajouterPhasonie.Text = "...";
            this.btn_ajouterPhasonie.UseVisualStyleBackColor = true;
            this.btn_ajouterPhasonie.Click += new System.EventHandler(this.btn_ajouterPhasonie_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(382, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Date Detailler:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(382, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Phasonie :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Detailleur :";
            // 
            // txt_idMatla
            // 
            this.txt_idMatla.BorderRadius = 2;
            this.txt_idMatla.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idMatla.DefaultText = "";
            this.txt_idMatla.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_idMatla.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_idMatla.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idMatla.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idMatla.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idMatla.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_idMatla.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idMatla.Location = new System.Drawing.Point(133, 25);
            this.txt_idMatla.Name = "txt_idMatla";
            this.txt_idMatla.PasswordChar = '\0';
            this.txt_idMatla.PlaceholderText = "";
            this.txt_idMatla.SelectedText = "";
            this.txt_idMatla.Size = new System.Drawing.Size(184, 23);
            this.txt_idMatla.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "ID Matla :";
            // 
            // txt_prixPhasonie
            // 
            this.txt_prixPhasonie.BorderRadius = 2;
            this.txt_prixPhasonie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_prixPhasonie.DefaultText = "";
            this.txt_prixPhasonie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_prixPhasonie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_prixPhasonie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prixPhasonie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prixPhasonie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prixPhasonie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_prixPhasonie.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prixPhasonie.Location = new System.Drawing.Point(133, 156);
            this.txt_prixPhasonie.Name = "txt_prixPhasonie";
            this.txt_prixPhasonie.PasswordChar = '\0';
            this.txt_prixPhasonie.PlaceholderText = "";
            this.txt_prixPhasonie.SelectedText = "";
            this.txt_prixPhasonie.Size = new System.Drawing.Size(184, 23);
            this.txt_prixPhasonie.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "Prix Phasonnie :";
            // 
            // txt_qteSorter
            // 
            this.txt_qteSorter.BorderRadius = 2;
            this.txt_qteSorter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_qteSorter.DefaultText = "";
            this.txt_qteSorter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_qteSorter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_qteSorter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_qteSorter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_qteSorter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_qteSorter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_qteSorter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_qteSorter.Location = new System.Drawing.Point(133, 221);
            this.txt_qteSorter.Name = "txt_qteSorter";
            this.txt_qteSorter.PasswordChar = '\0';
            this.txt_qteSorter.PlaceholderText = "";
            this.txt_qteSorter.SelectedText = "";
            this.txt_qteSorter.Size = new System.Drawing.Size(184, 23);
            this.txt_qteSorter.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(7, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "Sorter :";
            // 
            // txt_numeroBon
            // 
            this.txt_numeroBon.BorderRadius = 2;
            this.txt_numeroBon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_numeroBon.DefaultText = "";
            this.txt_numeroBon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_numeroBon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_numeroBon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_numeroBon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_numeroBon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_numeroBon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_numeroBon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_numeroBon.Location = new System.Drawing.Point(524, 158);
            this.txt_numeroBon.Name = "txt_numeroBon";
            this.txt_numeroBon.PasswordChar = '\0';
            this.txt_numeroBon.PlaceholderText = "";
            this.txt_numeroBon.SelectedText = "";
            this.txt_numeroBon.Size = new System.Drawing.Size(184, 23);
            this.txt_numeroBon.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(382, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "Numero Bon :";
            // 
            // cb_detailleur
            // 
            this.cb_detailleur.FormattingEnabled = true;
            this.cb_detailleur.Location = new System.Drawing.Point(133, 90);
            this.cb_detailleur.Name = "cb_detailleur";
            this.cb_detailleur.Size = new System.Drawing.Size(184, 21);
            this.cb_detailleur.TabIndex = 47;
            // 
            // cb_phasonie
            // 
            this.cb_phasonie.FormattingEnabled = true;
            this.cb_phasonie.Location = new System.Drawing.Point(524, 26);
            this.cb_phasonie.Name = "cb_phasonie";
            this.cb_phasonie.Size = new System.Drawing.Size(184, 21);
            this.cb_phasonie.TabIndex = 48;
            // 
            // dtp_dateDetailler
            // 
            this.dtp_dateDetailler.BorderRadius = 2;
            this.dtp_dateDetailler.Checked = true;
            this.dtp_dateDetailler.FillColor = System.Drawing.Color.Silver;
            this.dtp_dateDetailler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_dateDetailler.ForeColor = System.Drawing.Color.Black;
            this.dtp_dateDetailler.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_dateDetailler.Location = new System.Drawing.Point(523, 90);
            this.dtp_dateDetailler.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_dateDetailler.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_dateDetailler.Name = "dtp_dateDetailler";
            this.dtp_dateDetailler.Size = new System.Drawing.Size(184, 23);
            this.dtp_dateDetailler.TabIndex = 49;
            this.dtp_dateDetailler.Value = new System.DateTime(2023, 11, 23, 15, 50, 45, 378);
            // 
            // btn_ajouterDetailleur
            // 
            this.btn_ajouterDetailleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouterDetailleur.Location = new System.Drawing.Point(322, 89);
            this.btn_ajouterDetailleur.Name = "btn_ajouterDetailleur";
            this.btn_ajouterDetailleur.Size = new System.Drawing.Size(34, 23);
            this.btn_ajouterDetailleur.TabIndex = 50;
            this.btn_ajouterDetailleur.Text = "...";
            this.btn_ajouterDetailleur.UseVisualStyleBackColor = true;
            this.btn_ajouterDetailleur.Click += new System.EventHandler(this.btn_ajouterDetailleur_Click);
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
            this.btn_annuler.Location = new System.Drawing.Point(406, 281);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_annuler.Size = new System.Drawing.Size(142, 29);
            this.btn_annuler.TabIndex = 39;
            this.btn_annuler.Text = "Fermer";
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.BorderRadius = 2;
            this.btn_valider.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_valider.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_valider.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_valider.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_valider.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_valider.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider.ForeColor = System.Drawing.Color.White;
            this.btn_valider.Image = ((System.Drawing.Image)(resources.GetObject("btn_valider.Image")));
            this.btn_valider.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_valider.Location = new System.Drawing.Point(565, 281);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_valider.Size = new System.Drawing.Size(142, 29);
            this.btn_valider.TabIndex = 38;
            this.btn_valider.Text = "Valider";
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // txt_taille
            // 
            this.txt_taille.BorderRadius = 2;
            this.txt_taille.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_taille.DefaultText = "";
            this.txt_taille.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_taille.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_taille.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_taille.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_taille.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_taille.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_taille.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_taille.Location = new System.Drawing.Point(523, 221);
            this.txt_taille.Name = "txt_taille";
            this.txt_taille.PasswordChar = '\0';
            this.txt_taille.PlaceholderText = "";
            this.txt_taille.SelectedText = "";
            this.txt_taille.Size = new System.Drawing.Size(184, 23);
            this.txt_taille.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(397, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 51;
            this.label10.Text = "Taille :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ref Modele:";
            // 
            // txt_referenceModele
            // 
            this.txt_referenceModele.BorderRadius = 2;
            this.txt_referenceModele.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_referenceModele.DefaultText = "";
            this.txt_referenceModele.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_referenceModele.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_referenceModele.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_referenceModele.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_referenceModele.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_referenceModele.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_referenceModele.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_referenceModele.Location = new System.Drawing.Point(133, 285);
            this.txt_referenceModele.Name = "txt_referenceModele";
            this.txt_referenceModele.PasswordChar = '\0';
            this.txt_referenceModele.PlaceholderText = "";
            this.txt_referenceModele.SelectedText = "";
            this.txt_referenceModele.Size = new System.Drawing.Size(184, 23);
            this.txt_referenceModele.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_taille);
            this.groupBox2.Controls.Add(this.btn_valider);
            this.groupBox2.Controls.Add(this.btn_annuler);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btn_ajouterDetailleur);
            this.groupBox2.Controls.Add(this.dtp_dateDetailler);
            this.groupBox2.Controls.Add(this.cb_phasonie);
            this.groupBox2.Controls.Add(this.txt_referenceModele);
            this.groupBox2.Controls.Add(this.cb_detailleur);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_numeroBon);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_prixPhasonie);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_qteSorter);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_idMatla);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(35, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 322);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information Matla";
            // 
            // frmAjouterMatla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 362);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_ajouterPhasonie);
            this.Name = "frmAjouterMatla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAjouterMatla";
            this.Activated += new System.EventHandler(this.frmAjouterMatla_Activated);
            this.Load += new System.EventHandler(this.frmAjouterMatla_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouterPhasonie;
        private Guna.UI2.WinForms.Guna2Button btn_annuler;
        private Guna.UI2.WinForms.Guna2Button btn_valider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_idMatla;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_prixPhasonie;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_qteSorter;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txt_numeroBon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_detailleur;
        private System.Windows.Forms.ComboBox cb_phasonie;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_dateDetailler;
        private System.Windows.Forms.Button btn_ajouterDetailleur;
        private Guna.UI2.WinForms.Guna2TextBox txt_taille;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_referenceModele;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}