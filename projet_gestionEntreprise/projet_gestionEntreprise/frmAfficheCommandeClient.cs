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
    public partial class frmAfficheCommandeClient : Form
    {
        int IdClient;
        public frmAfficheCommandeClient(int idClient)
        {
            InitializeComponent();
            IdClient = idClient;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void refresh()
        {
            if (chk_enCourPaiement.Checked==true)
            {
                // fill datagrid view with commandes of clients
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn.Open();
                string req = "select c.idCommande,dateCommande,numeroBon,referenceModele,qteAchat,prixAchat,designation from commande c inner join detailCommande dc on dc.idCommande=c.idCommande inner join statutPayement sp on sp.idStatutPayement=c.idStatutPayement where c.idStatutPayement=2 and idClient=" + IdClient;
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_commandeClient.Rows.Clear();
                while (dr.Read())
                {
                    dgv_commandeClient.Rows.Add(dr["idCommande"], dr["dateCommande"], dr["numeroBon"], dr["referenceModele"], dr["qteAchat"], dr["prixAchat"], dr["designation"]);
                }
                // affect number of commandes in the label
                SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn2.Open();
                SqlCommand com2 = new SqlCommand("select count(*) from commande c where c.idStatutPayement=2 and idClient=" + IdClient + " group by idClient", cn2);
                int nbCommandes = Convert.ToInt32(com2.ExecuteScalar());
                lbl_nbCommandes.Text = nbCommandes.ToString();
                // affect totale prix commandes in the label
                SqlConnection cn3 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn3.Open();
                SqlCommand com3 = new SqlCommand("select sum(prixAchat*qteAchat) from detailCommande dc inner join commande c on c.idCommande=dc.idCommande where c.idStatutPayement=2 and idClient=" + IdClient + " group by idClient", cn3);
                int totalPrix = Convert.ToInt32(com3.ExecuteScalar());
                lbl_totalePrix.Text = totalPrix.ToString();
                // affect quantite totale des commandes acheter in the label
                SqlConnection cn4 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn4.Open();
                SqlCommand com4 = new SqlCommand("select sum(qteAchat) from detailCommande dc inner join commande c on dc.idCommande=c.idCommande where c.idStatutPayement=2 and idClient=" + IdClient + " group by idClient", cn4);
                int qteTotale = Convert.ToInt32(com4.ExecuteScalar());
                lbl_qteTotale.Text = qteTotale.ToString();
                // close all commandes and connection and datareader
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
                //
                com2 = null;

                cn2.Close();
                cn2 = null;
                //
                com3 = null;

                cn3.Close();
                cn3 = null;
                //
                com4 = null;

                cn4.Close();
                cn4 = null;
                //
            }
            else
            {
                // fill datagrid view with commandes of clients
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn.Open();
                string req = "select c.idCommande,dateCommande,numeroBon,referenceModele,qteAchat,prixAchat,designation from commande c inner join detailCommande dc on dc.idCommande=c.idCommande inner join statutPayement sp on sp.idStatutPayement=c.idStatutPayement where idClient=" + IdClient;
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_commandeClient.Rows.Clear();
                while (dr.Read())
                {
                    dgv_commandeClient.Rows.Add(dr["idCommande"], dr["dateCommande"], dr["numeroBon"], dr["referenceModele"], dr["qteAchat"], dr["prixAchat"], dr["designation"]);
                }
                // affect number of commandes in the label
                SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn2.Open();
                SqlCommand com2 = new SqlCommand("select count(*) from commande where idClient=" + IdClient + " group by idClient", cn2);
                int nbCommandes = Convert.ToInt32(com2.ExecuteScalar());
                lbl_nbCommandes.Text = nbCommandes.ToString();
                // affect totale prix commandes in the label
                SqlConnection cn3 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn3.Open();
                SqlCommand com3 = new SqlCommand("select sum(prixAchat*qteAchat) from detailCommande dc inner join commande c on c.idCommande=dc.idCommande where idClient=" + IdClient + " group by idClient", cn3);
                int totalPrix = Convert.ToInt32(com3.ExecuteScalar());
                lbl_totalePrix.Text = totalPrix.ToString();
                // affect quantite totale des commandes acheter in the label
                SqlConnection cn4 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn4.Open();
                SqlCommand com4 = new SqlCommand("select sum(qteAchat) from detailCommande dc inner join commande c on dc.idCommande=c.idCommande where idClient=" + IdClient + " group by idClient", cn4);
                int qteTotale = Convert.ToInt32(com4.ExecuteScalar());
                lbl_qteTotale.Text = qteTotale.ToString();
                // close all commandes and connection and datareader
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
                //
                com2 = null;

                cn2.Close();
                cn2 = null;
                //
                com3 = null;

                cn3.Close();
                cn3 = null;
                //
                com4 = null;

                cn4.Close();
                cn4 = null;
                //
            }
        }
        private void frmAfficheCommandeClient_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            int idClient = IdClient;
            frmAjouterCommande f = new frmAjouterCommande(idClient);
            f.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {

        }

        private void frmAfficheCommandeClient_Activated(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            int idCcommande = Convert.ToInt32(dgv_commandeClient.CurrentRow.Cells[0].Value);
            frmModifierCommande f = new frmModifierCommande(idCcommande);
            f.ShowDialog();
        }

        private void chk_enCourPaiement_CheckedChanged(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
