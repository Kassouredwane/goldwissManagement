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
                // fill datagrid view with commandes of clients
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn.Open();
                string req = "select c.idCommande,dateCommande,sum(qteAchat) as quantite from commande c inner join detailCommande dc on dc.idCommande=c.idCommande where idClient="+IdClient+" group by c.idCommande,dateCommande";
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_commandeClient.Rows.Clear();
                while (dr.Read())
                {
                    dgv_commandeClient.Rows.Add(dr["idCommande"], dr["dateCommande"], dr["quantite"]);
                }
                // close all commandes and connection and datareader
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
        }
        private void frmAfficheCommandeClient_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            //int idClient = IdClient;
            //frmAjouterCommande f = new frmAjouterCommande(idClient);
            //f.ShowDialog();
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
            int idCcommande = Convert.ToInt32(dgv_detailCommandeClient.CurrentRow.Cells[0].Value);
            frmModifierCommande f = new frmModifierCommande(idCcommande);
            f.ShowDialog();
        }

        private void chk_enCourPaiement_CheckedChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_nouveauCommande_Click(object sender, EventArgs e)
        {
            int idClient = IdClient;
            frmNouveauCommande f = new frmNouveauCommande(idClient);
            f.ShowDialog();
        }

        private void dgv_commandeClient_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dgv_commandeClient.CurrentRow.Cells[0].Value.ToString());
            //label1.Text = dgv_commandeClient.CurrentRow.Cells[0].Value.ToString();
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            string req = "select referenceModele,qteAchat,prixAchat from detailCommande where idCommande="+ dgv_commandeClient.CurrentRow.Cells[0].Value;
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            dgv_detailCommandeClient.Rows.Clear();
            while (dr.Read())
            {
                dgv_detailCommandeClient.Rows.Add(dr["referenceModele"], dr["qteAchat"], dr["prixAchat"]);
            }
            // close all commandes and connection and datareader
            dr.Close();
            dr = null;
            com = null;

            cn.Close();
            cn = null;
        }
    }
}
