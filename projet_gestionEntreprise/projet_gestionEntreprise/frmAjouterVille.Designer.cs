namespace projet_gestionEntreprise
{
    partial class frmAjouterVille
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjouterVille));
            this.txt_nomVille = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_valider = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txt_nomVille
            // 
            this.txt_nomVille.BorderRadius = 2;
            this.txt_nomVille.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nomVille.DefaultText = "";
            this.txt_nomVille.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nomVille.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nomVille.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nomVille.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nomVille.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nomVille.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nomVille.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nomVille.Location = new System.Drawing.Point(186, 51);
            this.txt_nomVille.Name = "txt_nomVille";
            this.txt_nomVille.PasswordChar = '\0';
            this.txt_nomVille.PlaceholderText = "";
            this.txt_nomVille.SelectedText = "";
            this.txt_nomVille.Size = new System.Drawing.Size(184, 23);
            this.txt_nomVille.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(86, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Nom Ville :";
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
            this.btn_valider.Location = new System.Drawing.Point(260, 97);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_valider.Size = new System.Drawing.Size(110, 25);
            this.btn_valider.TabIndex = 35;
            this.btn_valider.Text = "Ajouter";
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // frmAjouterVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 145);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.txt_nomVille);
            this.Controls.Add(this.label4);
            this.Name = "frmAjouterVille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAjouterVille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_nomVille;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btn_valider;
    }
}