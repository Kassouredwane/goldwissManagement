
namespace projet_gestionEntreprise
{
    partial class frmAjouterPhasonie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjouterPhasonie));
            this.btn_annuler = new Guna.UI2.WinForms.Guna2Button();
            this.btn_valider = new Guna.UI2.WinForms.Guna2Button();
            this.txt_telephonePhasonie = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_prenomPhasonie = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nomPhasonie = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_idPhasonie = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btn_annuler.Location = new System.Drawing.Point(62, 273);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_annuler.Size = new System.Drawing.Size(142, 29);
            this.btn_annuler.TabIndex = 51;
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
            this.btn_valider.Location = new System.Drawing.Point(210, 273);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_valider.Size = new System.Drawing.Size(142, 29);
            this.btn_valider.TabIndex = 50;
            this.btn_valider.Text = "Valider";
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // txt_telephonePhasonie
            // 
            this.txt_telephonePhasonie.BorderRadius = 2;
            this.txt_telephonePhasonie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_telephonePhasonie.DefaultText = "";
            this.txt_telephonePhasonie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_telephonePhasonie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_telephonePhasonie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_telephonePhasonie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_telephonePhasonie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_telephonePhasonie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_telephonePhasonie.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_telephonePhasonie.Location = new System.Drawing.Point(184, 216);
            this.txt_telephonePhasonie.Name = "txt_telephonePhasonie";
            this.txt_telephonePhasonie.PasswordChar = '\0';
            this.txt_telephonePhasonie.PlaceholderText = "";
            this.txt_telephonePhasonie.SelectedText = "";
            this.txt_telephonePhasonie.Size = new System.Drawing.Size(184, 23);
            this.txt_telephonePhasonie.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(42, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Telephone :";
            // 
            // txt_prenomPhasonie
            // 
            this.txt_prenomPhasonie.BorderRadius = 2;
            this.txt_prenomPhasonie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_prenomPhasonie.DefaultText = "";
            this.txt_prenomPhasonie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_prenomPhasonie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_prenomPhasonie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prenomPhasonie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prenomPhasonie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prenomPhasonie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_prenomPhasonie.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prenomPhasonie.Location = new System.Drawing.Point(184, 156);
            this.txt_prenomPhasonie.Name = "txt_prenomPhasonie";
            this.txt_prenomPhasonie.PasswordChar = '\0';
            this.txt_prenomPhasonie.PlaceholderText = "";
            this.txt_prenomPhasonie.SelectedText = "";
            this.txt_prenomPhasonie.Size = new System.Drawing.Size(184, 23);
            this.txt_prenomPhasonie.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(42, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Prenom :";
            // 
            // txt_nomPhasonie
            // 
            this.txt_nomPhasonie.BorderRadius = 2;
            this.txt_nomPhasonie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nomPhasonie.DefaultText = "";
            this.txt_nomPhasonie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nomPhasonie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nomPhasonie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nomPhasonie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nomPhasonie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nomPhasonie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nomPhasonie.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nomPhasonie.Location = new System.Drawing.Point(184, 98);
            this.txt_nomPhasonie.Name = "txt_nomPhasonie";
            this.txt_nomPhasonie.PasswordChar = '\0';
            this.txt_nomPhasonie.PlaceholderText = "";
            this.txt_nomPhasonie.SelectedText = "";
            this.txt_nomPhasonie.Size = new System.Drawing.Size(184, 23);
            this.txt_nomPhasonie.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nom :";
            // 
            // txt_idPhasonie
            // 
            this.txt_idPhasonie.BorderRadius = 2;
            this.txt_idPhasonie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idPhasonie.DefaultText = "";
            this.txt_idPhasonie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_idPhasonie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_idPhasonie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idPhasonie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idPhasonie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idPhasonie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_idPhasonie.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idPhasonie.Location = new System.Drawing.Point(184, 38);
            this.txt_idPhasonie.Name = "txt_idPhasonie";
            this.txt_idPhasonie.PasswordChar = '\0';
            this.txt_idPhasonie.PlaceholderText = "";
            this.txt_idPhasonie.SelectedText = "";
            this.txt_idPhasonie.Size = new System.Drawing.Size(184, 23);
            this.txt_idPhasonie.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "ID Phasonie :";
            // 
            // frmAjouterPhasonie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 330);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.txt_telephonePhasonie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_prenomPhasonie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nomPhasonie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_idPhasonie);
            this.Controls.Add(this.label1);
            this.Name = "frmAjouterPhasonie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAjouterPhasonie";
            this.Load += new System.EventHandler(this.frmAjouterPhasonie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_annuler;
        private Guna.UI2.WinForms.Guna2Button btn_valider;
        private Guna.UI2.WinForms.Guna2TextBox txt_telephonePhasonie;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_prenomPhasonie;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_nomPhasonie;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_idPhasonie;
        private System.Windows.Forms.Label label1;
    }
}