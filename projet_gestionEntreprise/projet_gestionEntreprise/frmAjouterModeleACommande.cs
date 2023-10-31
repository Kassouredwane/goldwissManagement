using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_gestionEntreprise
{
    public partial class frmAjouterModeleACommande : Form
    {
        int idCmd;
        public frmAjouterModeleACommande(int idCmd)
        {
            InitializeComponent();
            this.idCmd = idCmd;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void frmAjouterModeleACommande_Load(object sender, EventArgs e)
        {
            txt_idCommande.Text = idCmd.ToString();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn1.Open();
                string req = "insert into detailCommande values (@idCommande,@referenceModele,@qteAchat,@prixAchat)";
                SqlCommand com1 = new SqlCommand(req, cn1);
                com1.Parameters.Add(new SqlParameter("@idCommande", txt_idCommande.Text));
                com1.Parameters.Add(new SqlParameter("@referenceModele", txt_referenceModele.Text));
                com1.Parameters.Add(new SqlParameter("@qteAchat", txt_qteAchat.Text));
                com1.Parameters.Add(new SqlParameter("@prixAchat", txt_prixAchat.Text));
                com1.ExecuteNonQuery();

                com1 = null;
                cn1.Close();
                cn1 = null;
                MessageBox.Show("le modele a été ajouter a la commande de ce client avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_referenceModele.Text = "";
                txt_qteAchat.Text = "";
                txt_prixAchat.Text = "";
                txt_referenceModele.Focus();
            }
            catch (Exception error) { MessageBox.Show(error.Message); }
        }
    }
}
