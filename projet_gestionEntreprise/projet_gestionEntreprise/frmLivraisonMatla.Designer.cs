
namespace projet_gestionEntreprise
{
    partial class frmLivraisonMatla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLivraisonMatla));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_imprimerLivraison = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_livraison = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_annuler = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livraison)).BeginInit();
            this.SuspendLayout();
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
            this.btn_imprimerLivraison.Location = new System.Drawing.Point(824, 455);
            this.btn_imprimerLivraison.Name = "btn_imprimerLivraison";
            this.btn_imprimerLivraison.Size = new System.Drawing.Size(149, 29);
            this.btn_imprimerLivraison.TabIndex = 71;
            this.btn_imprimerLivraison.Text = "Imprimer Livraisons";
            this.btn_imprimerLivraison.Click += new System.EventHandler(this.btn_imprimerLivraison_Click);
            // 
            // dgv_livraison
            // 
            this.dgv_livraison.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_livraison.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_livraison.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_livraison.ColumnHeadersHeight = 20;
            this.dgv_livraison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_livraison.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column2,
            this.Column1,
            this.Column4,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_livraison.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_livraison.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_livraison.Location = new System.Drawing.Point(24, 26);
            this.dgv_livraison.Name = "dgv_livraison";
            this.dgv_livraison.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_livraison.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_livraison.RowHeadersVisible = false;
            this.dgv_livraison.Size = new System.Drawing.Size(949, 423);
            this.dgv_livraison.TabIndex = 72;
            this.dgv_livraison.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_livraison.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_livraison.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_livraison.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_livraison.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_livraison.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_livraison.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_livraison.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_livraison.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_livraison.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_livraison.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_livraison.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_livraison.ThemeStyle.HeaderStyle.Height = 20;
            this.dgv_livraison.ThemeStyle.ReadOnly = true;
            this.dgv_livraison.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_livraison.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_livraison.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_livraison.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_livraison.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_livraison.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_livraison.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Id livraison";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date Livraison";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N° Bon Livraison";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nom Complet";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantité";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
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
            this.btn_annuler.Location = new System.Drawing.Point(678, 455);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_annuler.Size = new System.Drawing.Size(140, 29);
            this.btn_annuler.TabIndex = 73;
            this.btn_annuler.Text = "Fermer";
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // frmLivraisonMatla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 499);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.dgv_livraison);
            this.Controls.Add(this.btn_imprimerLivraison);
            this.Name = "frmLivraisonMatla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLivraisonMatla";
            this.Load += new System.EventHandler(this.frmLivraisonMatla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livraison)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_imprimerLivraison;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_livraison;
        private Guna.UI2.WinForms.Guna2Button btn_annuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}