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
    public partial class frmModifierDetailCommandeClient : Form
    {
        int idDC;
        public frmModifierDetailCommandeClient(int idC)
        {
            InitializeComponent();
            this.idDC = idC;
        }

        private void frmModifierDetailCommandeClient_Load(object sender, EventArgs e)
        {
            txt_idCommande.Text=idDC.ToString();
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            SqlCommand com = new SqlCommand("select qteAchat,prixAchat,referenceModele,designation from detailCommande where idDetailCommande="+idDC, cn);
            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
            {
                txt_qteAchat.Text = dr["qteAchat"].ToString();
                txt_prixAchat.Text = dr["prixAchat"].ToString();
                txt_nouveauReferenceModele.Text= dr["referenceModele"].ToString();
                txt_designation.Text= dr["designation"].ToString();
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            string reqq = "update detailCommande set qteAchat=@qteAchat,prixAchat=@prixAchat,referenceModele=@referenceModele,designation=@designation where idDetailCommande="+idDC;
            SqlCommand com = new SqlCommand(reqq, cn);
            com.Parameters.Add(new SqlParameter("@qteAchat", txt_qteAchat.Text));
            com.Parameters.Add(new SqlParameter("@prixAchat", txt_prixAchat.Text));
            com.Parameters.Add(new SqlParameter("@referenceModele", txt_nouveauReferenceModele.Text));
            com.Parameters.Add(new SqlParameter("@designation", txt_designation.Text));
            com.ExecuteNonQuery();
            com = null;
            cn.Close();
            cn = null;
            MessageBox.Show("le detaille de ce modele a été modifier avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // UPDATE STATUT LIVRAISON OF COMMANDE OF THIS DETAIL COMMANDE WILLL BE ADDED IN TO FALSE !!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //cn2.Open();
            //SqlCommand com2 = new SqlCommand("UPDATE Commande SET statutLivraison = 0 WHERE idCommande = @idCommande", cn2);
            //com2.Parameters.Add(new SqlParameter("@idCommande", idDC));
            //com2.ExecuteNonQuery();
            //com2 = null;
            //cn2.Close();
            //cn2 = null;
            ////fermer le formulaire
            //this.Close();
        }
    }
}
