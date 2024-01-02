namespace projet_gestionEntreprise
{
    partial class frmAjouterCategorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjouterCategorie));
            this.txt_nomCategorie = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_valider = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txt_nomCategorie
            // 
            this.txt_nomCategorie.BorderRadius = 2;
            this.txt_nomCategorie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nomCategorie.DefaultText = "";
            this.txt_nomCategorie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nomCategorie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nomCategorie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nomCategorie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nomCategorie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nomCategorie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nomCategorie.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nomCategorie.Location = new System.Drawing.Point(187, 35);
            this.txt_nomCategorie.Name = "txt_nomCategorie";
            this.txt_nomCategorie.PasswordChar = '\0';
            this.txt_nomCategorie.PlaceholderText = "";
            this.txt_nomCategorie.SelectedText = "";
            this.txt_nomCategorie.Size = new System.Drawing.Size(184, 23);
            this.txt_nomCategorie.TabIndex = 37;
            this.txt_nomCategorie.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_nomCategorie_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(55, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nom Categorie :";
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
            this.btn_valider.Location = new System.Drawing.Point(261, 85);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_valider.Size = new System.Drawing.Size(110, 25);
            this.btn_valider.TabIndex = 38;
            this.btn_valider.Text = "Ajouter";
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // frmAjouterCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 134);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.txt_nomCategorie);
            this.Controls.Add(this.label4);
            this.Name = "frmAjouterCategorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAjouterCategorie";
            this.Load += new System.EventHandler(this.frmAjouterCategorie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_valider;
        private Guna.UI2.WinForms.Guna2TextBox txt_nomCategorie;
        private System.Windows.Forms.Label label4;
    }
}