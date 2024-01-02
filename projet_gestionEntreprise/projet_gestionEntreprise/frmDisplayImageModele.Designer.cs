
namespace projet_gestionEntreprise
{
    partial class frmDisplayImageModele
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
            this.imageModele = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageModele)).BeginInit();
            this.SuspendLayout();
            // 
            // imageModele
            // 
            this.imageModele.Location = new System.Drawing.Point(0, 0);
            this.imageModele.Name = "imageModele";
            this.imageModele.Size = new System.Drawing.Size(493, 480);
            this.imageModele.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageModele.TabIndex = 0;
            this.imageModele.TabStop = false;
            // 
            // frmDisplayImageModele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 480);
            this.Controls.Add(this.imageModele);
            this.Name = "frmDisplayImageModele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDisplayImageModele";
            this.Load += new System.EventHandler(this.frmDisplayImageModele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageModele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageModele;
    }
}