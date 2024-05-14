
namespace projet_gestionEntreprise
{
    partial class frmModifierMatla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifierMatla));
            this.btn_ajouterDetailleur = new System.Windows.Forms.Button();
            this.dtp_dateDetailler = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cb_phasonie = new System.Windows.Forms.ComboBox();
            this.cb_detailleur = new System.Windows.Forms.ComboBox();
            this.txt_numeroBon = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_prixPhasonie = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_ajouterPhasonie = new System.Windows.Forms.Button();
            this.btn_annuler = new Guna.UI2.WinForms.Guna2Button();
            this.btn_valider = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nbPieces = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_referenceModele = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idMatla = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_qteEnStock = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ajouterDetailleur
            // 
            this.btn_ajouterDetailleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouterDetailleur.Location = new System.Drawing.Point(348, 111);
            this.btn_ajouterDetailleur.Name = "btn_ajouterDetailleur";
            this.btn_ajouterDetailleur.Size = new System.Drawing.Size(34, 23);
            this.btn_ajouterDetailleur.TabIndex = 72;
            this.btn_ajouterDetailleur.Text = "...";
            this.btn_ajouterDetailleur.UseVisualStyleBackColor = true;
            this.btn_ajouterDetailleur.Click += new System.EventHandler(this.btn_ajouterDetailleur_Click);
            // 
            // dtp_dateDetailler
            // 
            this.dtp_dateDetailler.BorderRadius = 2;
            this.dtp_dateDetailler.Checked = true;
            this.dtp_dateDetailler.FillColor = System.Drawing.Color.Silver;
            this.dtp_dateDetailler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_dateDetailler.ForeColor = System.Drawing.Color.Black;
            this.dtp_dateDetailler.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_dateDetailler.Location = new System.Drawing.Point(549, 112);
            this.dtp_dateDetailler.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_dateDetailler.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_dateDetailler.Name = "dtp_dateDetailler";
            this.dtp_dateDetailler.Size = new System.Drawing.Size(184, 23);
            this.dtp_dateDetailler.TabIndex = 71;
            this.dtp_dateDetailler.Value = new System.DateTime(2023, 11, 23, 15, 50, 45, 378);
            // 
            // cb_phasonie
            // 
            this.cb_phasonie.FormattingEnabled = true;
            this.cb_phasonie.Location = new System.Drawing.Point(549, 187);
            this.cb_phasonie.Name = "cb_phasonie";
            this.cb_phasonie.Size = new System.Drawing.Size(184, 21);
            this.cb_phasonie.TabIndex = 70;
            // 
            // cb_detailleur
            // 
            this.cb_detailleur.FormattingEnabled = true;
            this.cb_detailleur.Location = new System.Drawing.Point(159, 112);
            this.cb_detailleur.Name = "cb_detailleur";
            this.cb_detailleur.Size = new System.Drawing.Size(184, 21);
            this.cb_detailleur.TabIndex = 69;
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
            this.txt_numeroBon.Location = new System.Drawing.Point(549, 258);
            this.txt_numeroBon.Name = "txt_numeroBon";
            this.txt_numeroBon.PasswordChar = '\0';
            this.txt_numeroBon.PlaceholderText = "";
            this.txt_numeroBon.SelectedText = "";
            this.txt_numeroBon.Size = new System.Drawing.Size(184, 23);
            this.txt_numeroBon.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(407, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 67;
            this.label9.Text = "Numero Bon :";
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
            this.txt_prixPhasonie.Location = new System.Drawing.Point(159, 258);
            this.txt_prixPhasonie.Name = "txt_prixPhasonie";
            this.txt_prixPhasonie.PasswordChar = '\0';
            this.txt_prixPhasonie.PlaceholderText = "";
            this.txt_prixPhasonie.SelectedText = "";
            this.txt_prixPhasonie.Size = new System.Drawing.Size(184, 23);
            this.txt_prixPhasonie.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(33, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 65;
            this.label7.Text = "Prix Phasonnie :";
            // 
            // btn_ajouterPhasonie
            // 
            this.btn_ajouterPhasonie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouterPhasonie.Location = new System.Drawing.Point(738, 186);
            this.btn_ajouterPhasonie.Name = "btn_ajouterPhasonie";
            this.btn_ajouterPhasonie.Size = new System.Drawing.Size(34, 23);
            this.btn_ajouterPhasonie.TabIndex = 62;
            this.btn_ajouterPhasonie.Text = "...";
            this.btn_ajouterPhasonie.UseVisualStyleBackColor = true;
            this.btn_ajouterPhasonie.Click += new System.EventHandler(this.btn_ajouterPhasonie_Click);
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
            this.btn_annuler.Location = new System.Drawing.Point(432, 323);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_annuler.Size = new System.Drawing.Size(142, 29);
            this.btn_annuler.TabIndex = 61;
            this.btn_annuler.Text = "Annuler";
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
            this.btn_valider.Location = new System.Drawing.Point(591, 323);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_valider.Size = new System.Drawing.Size(142, 29);
            this.btn_valider.TabIndex = 60;
            this.btn_valider.Text = "Valider";
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(408, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 59;
            this.label6.Text = "Date Detailler:";
            // 
            // txt_nbPieces
            // 
            this.txt_nbPieces.BorderRadius = 2;
            this.txt_nbPieces.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nbPieces.DefaultText = "";
            this.txt_nbPieces.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nbPieces.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nbPieces.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nbPieces.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nbPieces.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nbPieces.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nbPieces.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nbPieces.Location = new System.Drawing.Point(159, 185);
            this.txt_nbPieces.Name = "txt_nbPieces";
            this.txt_nbPieces.PasswordChar = '\0';
            this.txt_nbPieces.PlaceholderText = "";
            this.txt_nbPieces.SelectedText = "";
            this.txt_nbPieces.Size = new System.Drawing.Size(184, 23);
            this.txt_nbPieces.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "Nombre Pieces:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(407, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "Phasonie :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Detailleur :";
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
            this.txt_referenceModele.Location = new System.Drawing.Point(549, 46);
            this.txt_referenceModele.Name = "txt_referenceModele";
            this.txt_referenceModele.PasswordChar = '\0';
            this.txt_referenceModele.PlaceholderText = "";
            this.txt_referenceModele.SelectedText = "";
            this.txt_referenceModele.Size = new System.Drawing.Size(184, 23);
            this.txt_referenceModele.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(407, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Reference Modele:";
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
            this.txt_idMatla.Location = new System.Drawing.Point(159, 47);
            this.txt_idMatla.Name = "txt_idMatla";
            this.txt_idMatla.PasswordChar = '\0';
            this.txt_idMatla.PlaceholderText = "";
            this.txt_idMatla.ReadOnly = true;
            this.txt_idMatla.SelectedText = "";
            this.txt_idMatla.Size = new System.Drawing.Size(184, 23);
            this.txt_idMatla.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "ID Matla :";
            // 
            // txt_qteEnStock
            // 
            this.txt_qteEnStock.BorderRadius = 2;
            this.txt_qteEnStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_qteEnStock.DefaultText = "";
            this.txt_qteEnStock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_qteEnStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_qteEnStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_qteEnStock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_qteEnStock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_qteEnStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_qteEnStock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_qteEnStock.Location = new System.Drawing.Point(159, 329);
            this.txt_qteEnStock.Name = "txt_qteEnStock";
            this.txt_qteEnStock.PasswordChar = '\0';
            this.txt_qteEnStock.PlaceholderText = "";
            this.txt_qteEnStock.SelectedText = "";
            this.txt_qteEnStock.Size = new System.Drawing.Size(184, 23);
            this.txt_qteEnStock.TabIndex = 74;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(33, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 73;
            this.label10.Text = "En Stock :";
            // 
            // frmModifierMatla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 393);
            this.Controls.Add(this.txt_qteEnStock);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_ajouterDetailleur);
            this.Controls.Add(this.dtp_dateDetailler);
            this.Controls.Add(this.cb_phasonie);
            this.Controls.Add(this.cb_detailleur);
            this.Controls.Add(this.txt_numeroBon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_prixPhasonie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_ajouterPhasonie);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nbPieces);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_referenceModele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_idMatla);
            this.Controls.Add(this.label2);
            this.Name = "frmModifierMatla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModifierMatla";
            this.Load += new System.EventHandler(this.frmModifierMatla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouterDetailleur;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_dateDetailler;
        private System.Windows.Forms.ComboBox cb_phasonie;
        private System.Windows.Forms.ComboBox cb_detailleur;
        private Guna.UI2.WinForms.Guna2TextBox txt_numeroBon;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txt_prixPhasonie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_ajouterPhasonie;
        private Guna.UI2.WinForms.Guna2Button btn_annuler;
        private Guna.UI2.WinForms.Guna2Button btn_valider;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_nbPieces;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_referenceModele;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_idMatla;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_qteEnStock;
        private System.Windows.Forms.Label label10;
    }
}