﻿namespace projet_gestionEntreprise
{
    partial class frmAjouterTransactionAClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjouterTransactionAClient));
            this.cb_modePaiement = new System.Windows.Forms.ComboBox();
            this.dtp_dateTransaction = new System.Windows.Forms.DateTimePicker();
            this.txt_description = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_idClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_montant = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_annuler = new Guna.UI2.WinForms.Guna2Button();
            this.btn_valider = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // cb_modePaiement
            // 
            this.cb_modePaiement.FormattingEnabled = true;
            this.cb_modePaiement.Items.AddRange(new object[] {
            "Espèce",
            "Chèque",
            "Virement bancaire",
            "transfert"});
            this.cb_modePaiement.Location = new System.Drawing.Point(197, 209);
            this.cb_modePaiement.Name = "cb_modePaiement";
            this.cb_modePaiement.Size = new System.Drawing.Size(184, 21);
            this.cb_modePaiement.TabIndex = 63;
            // 
            // dtp_dateTransaction
            // 
            this.dtp_dateTransaction.Location = new System.Drawing.Point(197, 97);
            this.dtp_dateTransaction.Name = "dtp_dateTransaction";
            this.dtp_dateTransaction.Size = new System.Drawing.Size(184, 20);
            this.dtp_dateTransaction.TabIndex = 62;
            // 
            // txt_description
            // 
            this.txt_description.BorderRadius = 2;
            this.txt_description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_description.DefaultText = "";
            this.txt_description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_description.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_description.Location = new System.Drawing.Point(197, 268);
            this.txt_description.Name = "txt_description";
            this.txt_description.PasswordChar = '\0';
            this.txt_description.PlaceholderText = "";
            this.txt_description.SelectedText = "";
            this.txt_description.Size = new System.Drawing.Size(184, 23);
            this.txt_description.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(37, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Date Transaction :";
            // 
            // txt_idClient
            // 
            this.txt_idClient.BorderRadius = 2;
            this.txt_idClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idClient.DefaultText = "";
            this.txt_idClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_idClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_idClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_idClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idClient.Location = new System.Drawing.Point(197, 40);
            this.txt_idClient.Name = "txt_idClient";
            this.txt_idClient.PasswordChar = '\0';
            this.txt_idClient.PlaceholderText = "";
            this.txt_idClient.ReadOnly = true;
            this.txt_idClient.SelectedText = "";
            this.txt_idClient.Size = new System.Drawing.Size(184, 23);
            this.txt_idClient.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(37, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "ID Client  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(37, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "Mode de paiement :";
            // 
            // txt_montant
            // 
            this.txt_montant.BorderRadius = 2;
            this.txt_montant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_montant.DefaultText = "";
            this.txt_montant.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_montant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_montant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_montant.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_montant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_montant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_montant.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_montant.Location = new System.Drawing.Point(197, 150);
            this.txt_montant.Name = "txt_montant";
            this.txt_montant.PasswordChar = '\0';
            this.txt_montant.PlaceholderText = "";
            this.txt_montant.SelectedText = "";
            this.txt_montant.Size = new System.Drawing.Size(184, 23);
            this.txt_montant.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Montant :";
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
            this.btn_annuler.Location = new System.Drawing.Point(63, 331);
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
            this.btn_valider.Location = new System.Drawing.Point(211, 331);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_valider.Size = new System.Drawing.Size(142, 29);
            this.btn_valider.TabIndex = 60;
            this.btn_valider.Text = "Valider";
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // frmAjouterTransactionAClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 401);
            this.Controls.Add(this.cb_modePaiement);
            this.Controls.Add(this.dtp_dateTransaction);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_idClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_montant);
            this.Controls.Add(this.label3);
            this.Name = "frmAjouterTransactionAClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAjouterTransactionAClient";
            this.Load += new System.EventHandler(this.frmAjouterTransactionAClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_modePaiement;
        private System.Windows.Forms.DateTimePicker dtp_dateTransaction;
        private Guna.UI2.WinForms.Guna2Button btn_annuler;
        private Guna.UI2.WinForms.Guna2Button btn_valider;
        private Guna.UI2.WinForms.Guna2TextBox txt_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_idClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_montant;
        private System.Windows.Forms.Label label3;
    }
}