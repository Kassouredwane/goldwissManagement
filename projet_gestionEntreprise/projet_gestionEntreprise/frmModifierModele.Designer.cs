namespace projet_gestionEntreprise
{
    partial class frmModifierModele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifierModele));
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.txt_imageModele = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_designation = new System.Windows.Forms.RichTextBox();
            this.btn_ajouterCategorie = new System.Windows.Forms.Button();
            this.cb_categorie = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_prix = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_marque = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_taille = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_reference = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_choisirImage = new Guna.UI2.WinForms.Guna2Button();
            this.imageModele = new System.Windows.Forms.PictureBox();
            this.btn_annuler = new Guna.UI2.WinForms.Guna2Button();
            this.btn_valider = new Guna.UI2.WinForms.Guna2Button();
            this.ProductImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageModele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "openFileDialog1";
            // 
            // txt_imageModele
            // 
            this.txt_imageModele.BorderRadius = 2;
            this.txt_imageModele.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_imageModele.DefaultText = "";
            this.txt_imageModele.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_imageModele.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_imageModele.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_imageModele.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_imageModele.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_imageModele.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_imageModele.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_imageModele.Location = new System.Drawing.Point(38, 454);
            this.txt_imageModele.Name = "txt_imageModele";
            this.txt_imageModele.PasswordChar = '\0';
            this.txt_imageModele.PlaceholderText = "";
            this.txt_imageModele.SelectedText = "";
            this.txt_imageModele.Size = new System.Drawing.Size(140, 18);
            this.txt_imageModele.TabIndex = 63;
            this.txt_imageModele.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(362, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 62;
            this.label7.Text = "Designation :";
            // 
            // txt_designation
            // 
            this.txt_designation.Location = new System.Drawing.Point(470, 205);
            this.txt_designation.Name = "txt_designation";
            this.txt_designation.Size = new System.Drawing.Size(215, 37);
            this.txt_designation.TabIndex = 61;
            this.txt_designation.Text = "";
            // 
            // btn_ajouterCategorie
            // 
            this.btn_ajouterCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouterCategorie.Location = new System.Drawing.Point(656, 48);
            this.btn_ajouterCategorie.Name = "btn_ajouterCategorie";
            this.btn_ajouterCategorie.Size = new System.Drawing.Size(29, 21);
            this.btn_ajouterCategorie.TabIndex = 58;
            this.btn_ajouterCategorie.Text = "...";
            this.btn_ajouterCategorie.UseVisualStyleBackColor = true;
            this.btn_ajouterCategorie.Click += new System.EventHandler(this.btn_ajouterCategorie_Click);
            // 
            // cb_categorie
            // 
            this.cb_categorie.FormattingEnabled = true;
            this.cb_categorie.Location = new System.Drawing.Point(470, 48);
            this.cb_categorie.Name = "cb_categorie";
            this.cb_categorie.Size = new System.Drawing.Size(184, 21);
            this.cb_categorie.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(363, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "Categorie :";
            // 
            // txt_prix
            // 
            this.txt_prix.BorderRadius = 2;
            this.txt_prix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_prix.DefaultText = "";
            this.txt_prix.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_prix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_prix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prix.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prix.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_prix.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prix.Location = new System.Drawing.Point(130, 205);
            this.txt_prix.Name = "txt_prix";
            this.txt_prix.PasswordChar = '\0';
            this.txt_prix.PlaceholderText = "";
            this.txt_prix.SelectedText = "";
            this.txt_prix.Size = new System.Drawing.Size(184, 23);
            this.txt_prix.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Prix :";
            // 
            // txt_marque
            // 
            this.txt_marque.BorderRadius = 2;
            this.txt_marque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_marque.DefaultText = "";
            this.txt_marque.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_marque.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_marque.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_marque.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_marque.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_marque.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_marque.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_marque.Location = new System.Drawing.Point(470, 121);
            this.txt_marque.Name = "txt_marque";
            this.txt_marque.PasswordChar = '\0';
            this.txt_marque.PlaceholderText = "";
            this.txt_marque.SelectedText = "";
            this.txt_marque.Size = new System.Drawing.Size(215, 23);
            this.txt_marque.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(362, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Marque :";
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
            this.txt_taille.Location = new System.Drawing.Point(130, 122);
            this.txt_taille.Name = "txt_taille";
            this.txt_taille.PasswordChar = '\0';
            this.txt_taille.PlaceholderText = "";
            this.txt_taille.SelectedText = "";
            this.txt_taille.Size = new System.Drawing.Size(184, 23);
            this.txt_taille.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Taille :";
            // 
            // txt_reference
            // 
            this.txt_reference.BorderRadius = 2;
            this.txt_reference.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_reference.DefaultText = "";
            this.txt_reference.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_reference.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_reference.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_reference.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_reference.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_reference.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_reference.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_reference.Location = new System.Drawing.Point(130, 46);
            this.txt_reference.Name = "txt_reference";
            this.txt_reference.PasswordChar = '\0';
            this.txt_reference.PlaceholderText = "";
            this.txt_reference.SelectedText = "";
            this.txt_reference.Size = new System.Drawing.Size(184, 23);
            this.txt_reference.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Reference  :";
            // 
            // btn_choisirImage
            // 
            this.btn_choisirImage.BorderRadius = 2;
            this.btn_choisirImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_choisirImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_choisirImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_choisirImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_choisirImage.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_choisirImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_choisirImage.ForeColor = System.Drawing.Color.White;
            this.btn_choisirImage.Image = ((System.Drawing.Image)(resources.GetObject("btn_choisirImage.Image")));
            this.btn_choisirImage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_choisirImage.Location = new System.Drawing.Point(132, 422);
            this.btn_choisirImage.Name = "btn_choisirImage";
            this.btn_choisirImage.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_choisirImage.Size = new System.Drawing.Size(184, 29);
            this.btn_choisirImage.TabIndex = 60;
            this.btn_choisirImage.Text = "Choisir une image";
            this.btn_choisirImage.Click += new System.EventHandler(this.btn_choisirImage_Click);
            // 
            // imageModele
            // 
            this.imageModele.Image = ((System.Drawing.Image)(resources.GetObject("imageModele.Image")));
            this.imageModele.Location = new System.Drawing.Point(132, 261);
            this.imageModele.Name = "imageModele";
            this.imageModele.Size = new System.Drawing.Size(184, 155);
            this.imageModele.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageModele.TabIndex = 59;
            this.imageModele.TabStop = false;
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
            this.btn_annuler.Location = new System.Drawing.Point(384, 422);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_annuler.Size = new System.Drawing.Size(142, 29);
            this.btn_annuler.TabIndex = 57;
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
            this.btn_valider.Location = new System.Drawing.Point(543, 422);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_valider.Size = new System.Drawing.Size(142, 29);
            this.btn_valider.TabIndex = 56;
            this.btn_valider.Text = "Valider";
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // ProductImage
            // 
            this.ProductImage.Image = ((System.Drawing.Image)(resources.GetObject("ProductImage.Image")));
            this.ProductImage.Location = new System.Drawing.Point(132, 261);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(184, 155);
            this.ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductImage.TabIndex = 66;
            this.ProductImage.TabStop = false;
            // 
            // frmModifierModele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 478);
            this.Controls.Add(this.ProductImage);
            this.Controls.Add(this.txt_imageModele);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_designation);
            this.Controls.Add(this.btn_choisirImage);
            this.Controls.Add(this.imageModele);
            this.Controls.Add(this.btn_ajouterCategorie);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.cb_categorie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_prix);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_marque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_taille);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_reference);
            this.Controls.Add(this.label2);
            this.Name = "frmModifierModele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModifierModele";
            this.Load += new System.EventHandler(this.frmModifierModele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageModele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdImage;
        private Guna.UI2.WinForms.Guna2TextBox txt_imageModele;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txt_designation;
        private Guna.UI2.WinForms.Guna2Button btn_choisirImage;
        private System.Windows.Forms.PictureBox imageModele;
        private System.Windows.Forms.Button btn_ajouterCategorie;
        private Guna.UI2.WinForms.Guna2Button btn_annuler;
        private Guna.UI2.WinForms.Guna2Button btn_valider;
        private System.Windows.Forms.ComboBox cb_categorie;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_prix;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_marque;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_taille;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_reference;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ProductImage;
    }
}