
namespace projet_gestionEntreprise
{
    partial class frmModifierTransferePhasonieToStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifierTransferePhasonieToStock));
            this.dtp_dateStocker = new System.Windows.Forms.DateTimePicker();
            this.txt_numeroBon = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_annuler = new Guna.UI2.WinForms.Guna2Button();
            this.btn_valider = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_qteStocker = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_idMatla = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_oldQte = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // dtp_dateStocker
            // 
            this.dtp_dateStocker.Location = new System.Drawing.Point(175, 148);
            this.dtp_dateStocker.Name = "dtp_dateStocker";
            this.dtp_dateStocker.Size = new System.Drawing.Size(184, 20);
            this.dtp_dateStocker.TabIndex = 92;
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
            this.txt_numeroBon.Location = new System.Drawing.Point(175, 208);
            this.txt_numeroBon.Name = "txt_numeroBon";
            this.txt_numeroBon.PasswordChar = '\0';
            this.txt_numeroBon.PlaceholderText = "";
            this.txt_numeroBon.SelectedText = "";
            this.txt_numeroBon.Size = new System.Drawing.Size(184, 23);
            this.txt_numeroBon.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 90;
            this.label5.Text = "N° Bon :";
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
            this.btn_annuler.Location = new System.Drawing.Point(50, 262);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_annuler.Size = new System.Drawing.Size(142, 29);
            this.btn_annuler.TabIndex = 89;
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
            this.btn_valider.Location = new System.Drawing.Point(198, 262);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_valider.Size = new System.Drawing.Size(142, 29);
            this.btn_valider.TabIndex = 88;
            this.btn_valider.Text = "Valider";
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(33, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 87;
            this.label4.Text = "Date Transfere :";
            // 
            // txt_qteStocker
            // 
            this.txt_qteStocker.BorderRadius = 2;
            this.txt_qteStocker.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_qteStocker.DefaultText = "";
            this.txt_qteStocker.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_qteStocker.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_qteStocker.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_qteStocker.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_qteStocker.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_qteStocker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_qteStocker.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_qteStocker.Location = new System.Drawing.Point(175, 90);
            this.txt_qteStocker.Name = "txt_qteStocker";
            this.txt_qteStocker.PasswordChar = '\0';
            this.txt_qteStocker.PlaceholderText = "";
            this.txt_qteStocker.SelectedText = "";
            this.txt_qteStocker.Size = new System.Drawing.Size(184, 23);
            this.txt_qteStocker.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 85;
            this.label3.Text = "Quantite :";
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
            this.txt_idMatla.Location = new System.Drawing.Point(175, 31);
            this.txt_idMatla.Name = "txt_idMatla";
            this.txt_idMatla.PasswordChar = '\0';
            this.txt_idMatla.PlaceholderText = "";
            this.txt_idMatla.SelectedText = "";
            this.txt_idMatla.Size = new System.Drawing.Size(184, 23);
            this.txt_idMatla.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 82;
            this.label1.Text = "ID Matla :";
            // 
            // txt_oldQte
            // 
            this.txt_oldQte.BorderRadius = 2;
            this.txt_oldQte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_oldQte.DefaultText = "";
            this.txt_oldQte.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_oldQte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_oldQte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_oldQte.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_oldQte.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_oldQte.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_oldQte.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_oldQte.Location = new System.Drawing.Point(175, 119);
            this.txt_oldQte.Name = "txt_oldQte";
            this.txt_oldQte.PasswordChar = '\0';
            this.txt_oldQte.PlaceholderText = "";
            this.txt_oldQte.SelectedText = "";
            this.txt_oldQte.Size = new System.Drawing.Size(184, 23);
            this.txt_oldQte.TabIndex = 93;
            // 
            // frmModifierTransferePhasonieToStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 318);
            this.Controls.Add(this.txt_oldQte);
            this.Controls.Add(this.dtp_dateStocker);
            this.Controls.Add(this.txt_numeroBon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_qteStocker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_idMatla);
            this.Controls.Add(this.label1);
            this.Name = "frmModifierTransferePhasonieToStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModifierTransferePhasonieToStock";
            this.Load += new System.EventHandler(this.frmModifierTransferePhasonieToStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_dateStocker;
        private Guna.UI2.WinForms.Guna2TextBox txt_numeroBon;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btn_annuler;
        private Guna.UI2.WinForms.Guna2Button btn_valider;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_qteStocker;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_idMatla;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_oldQte;
    }
}