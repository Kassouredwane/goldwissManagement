using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_gestionEntreprise
{
    public partial class frmAfficheLivraisonClient : Form
    {
        int id;
        public frmAfficheLivraisonClient(int idC)
        {
            InitializeComponent();
            this.id = idC;
        }
        private void refresh(string filtre)
        {
            // fill datagrid view with commandes of clients
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            string req = "SELECT l.idLivraison,l.numeroBonLivraison,l.dateLivraison,cmd.idClient,cmd.idCommande,SUM(dl.qteLivre) AS totalQuantity,SUM(dc.prixAchat * dl.qteLivre) AS totalAmount FROM livraison l  INNER JOIN detailLivraison dl ON dl.idLivraison = l.idLivraison  INNER JOIN matla mt ON mt.idMatla = dl.idMatla  INNER JOIN modele m ON m.referenceModele = mt.referenceModele  INNER JOIN detailCommande dc ON dc.idCommande = l.idCommande AND dc.referenceModele = m.referenceModele  INNER JOIN commande cmd on cmd.idCommande=dc.idCommande where cmd.idClient="+id+filtre+ " GROUP BY l.idLivraison, l.numeroBonLivraison, l.dateLivraison,cmd.idClient,cmd.idCommande order by l.idLivraison desc";
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            dgv_livraisonClient.Rows.Clear();
            while (dr.Read())
            {
                dgv_livraisonClient.Rows.Add(dr["idLivraison"], dr["numeroBonLivraison"], Convert.ToDateTime(dr["dateLivraison"].ToString()).ToShortDateString(), dr["idCommande"], dr["totalQuantity"], dr["totalAmount"]);
            }
            // affect number of commandes in the label
            SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn2.Open();
            SqlCommand com2 = new SqlCommand("SELECT COUNT(*) from livraison l inner join commande cmd on cmd.idCommande=l.idCommande inner join client c on c.idClient=cmd.idClient where c.idClient="+id, cn2);
            int nbLivraison = Convert.ToInt32(com2.ExecuteScalar());
            lbl_nbLivraison.Text = nbLivraison.ToString();
            // affect totale prix commandes in the label
            SqlConnection cn3 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn3.Open();
            SqlCommand com3 = new SqlCommand("SELECT SUM(dl.qteLivre * dc.prixAchat) AS TotalPrixLivraisons FROM client c INNER JOIN commande cmd ON c.idClient = cmd.idClient INNER JOIN livraison l ON cmd.idCommande = l.idCommande INNER JOIN detailLivraison dl ON l.idLivraison = dl.idLivraison INNER JOIN matla m ON dl.idMatla = m.idMatla INNER JOIN detailCommande dc ON m.referenceModele = dc.referenceModele AND cmd.idCommande = dc.idCommande WHERE c.idClient = "+id+" GROUP BY c.idClient", cn3);
            int totalPrix = Convert.ToInt32(com3.ExecuteScalar());
            lbl_totalePrix.Text = totalPrix.ToString() + " DH";
            // affect quantite totale des commandes acheter in the label
            SqlConnection cn4 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn4.Open();
            SqlCommand com4 = new SqlCommand("SELECT SUM(dl.qteLivre) AS QuantiteTotaleLivre FROM client c INNER JOIN commande cmd ON c.idClient = cmd.idClient INNER JOIN livraison l ON cmd.idCommande = l.idCommande INNER JOIN detailLivraison dl ON l.idLivraison = dl.idLivraison INNER JOIN matla m ON dl.idMatla = m.idMatla INNER JOIN modele mo ON m.referenceModele = mo.referenceModele WHERE c.idClient = "+id+" GROUP BY c.idClient", cn4);
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
        }
        private void frmAfficheLivraisonClient_Load(object sender, EventArgs e)
        {
            refresh("");
            cb_recherche.SelectedIndex = 0;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh("");
        }
        //N° Bon Livraison
        //ID Livraison
        //Date Livraison
        //Reference Modele
        //ID Commandele
        //ID Commande
        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cb_recherche.SelectedIndex)
                {
                    case 0:
                        refresh(" and l.numeroBonLivraison=" + txt_rechercher.Text);
                        break;
                    case 1:
                        refresh(" and l.idLivraison=" + txt_rechercher.Text);
                        break;
                    case 2:
                        refresh(" and dateLivraison like'%" + txt_rechercher.Text + "%'");
                        break;
                    case 3:
                        refresh(" and m.referenceModele ='"+ txt_rechercher.Text + "'");
                    break;
                    case 4:
                        refresh(" and cmd.idCommande=" + txt_rechercher.Text);
                    break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("doit étre rechercher par l'élement séléctionner", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_livraisonClient_SelectionChanged(object sender, EventArgs e)
        {
            // fill datagrid view with commandes of clients
            //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //cn.Open();
            //string req = "SELECT l.idCommande,m.referenceModele,m.designation AS designationModele,sum(dl.qteLivre) as qteTotaleLivraison FROM livraison l INNER JOIN detailLivraison dl ON l.idLivraison = dl.idLivraison INNER JOIN matla ma ON dl.idMatla = ma.idMatla INNER JOIN modele m ON ma.referenceModele = m.referenceModele WHERE l.idLivraison = "+dgv_livraisonClient.CurrentRow.Cells[0].Value+" group by  l.idCommande,m.referenceModele,m.designation";
            //SqlCommand com = new SqlCommand(req, cn);
            //SqlDataReader dr = com.ExecuteReader();
            //dgv_detailLivraison.Rows.Clear();
            //while (dr.Read())
            //{
            //    dgv_detailLivraison.Rows.Add(dr["referenceModele"], dr["designationModele"], dr["idCommande"], dr["qteTotaleLivraison"]);
            //}
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            string req = "SELECT livraison.idCommande,matla.referenceModele,modele.designation AS designationModele,detailCommande.qteAchat AS quantiteCommande,detailCommande.prixAchat AS prixAchatModele,SUM(detailLivraison.qteLivre) AS quantiteLivre FROM livraison INNER JOIN detailCommande ON livraison.idCommande = detailCommande.idCommande INNER JOIN matla ON detailCommande.referenceModele = matla.referenceModele INNER JOIN modele ON matla.referenceModele = modele.referenceModele inner JOIN detailLivraison ON livraison.idLivraison = detailLivraison.idLivraison AND matla.idMatla = detailLivraison.idMatla where livraison.idLivraison = " + dgv_livraisonClient.CurrentRow.Cells[0].Value + " GROUP BY livraison.idCommande,matla.referenceModele,modele.designation,detailCommande.qteAchat,detailCommande.prixAchat";
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            dgv_detailLivraison.Rows.Clear();
            while (dr.Read())
            {
                dgv_detailLivraison.Rows.Add(dr["referenceModele"], dr["designationModele"], dr["quantiteCommande"], dr["prixAchatModele"], dr["quantiteLivre"]);
            }
            dr.Close();
            dr = null;
            com = null;

            cn.Close();
            cn = null;
        }
    }
}
