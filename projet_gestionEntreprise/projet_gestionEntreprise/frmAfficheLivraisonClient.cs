﻿using System;
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
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            string req = "select l.numeroBonLivraison,dateLivraison,dc.idCommande,m.referenceModele,designation,qteLivre from livraison l inner join detailCommande dc on dc.numeroBonLivraison=l.numeroBonLivraison inner join modele m on m.referenceModele=dc.referenceModele where idClient=" + id + filtre ;
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            dgv_livraisonClient.Rows.Clear();
            while (dr.Read())
            {
                dgv_livraisonClient.Rows.Add(dr["numeroBonLivraison"], dr["dateLivraison"], dr["idCommande"], dr["referenceModele"], dr["designation"], dr["qteLivre"]);
            }
            // affect number of commandes in the label
            SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn2.Open();
            SqlCommand com2 = new SqlCommand("select count(*) from livraison l inner join detailCommande dc on dc.numeroBonLivraison=l.numeroBonLivraison where idClient=" + id + filtre +" group by idClient", cn2);
            int nbLivraison = Convert.ToInt32(com2.ExecuteScalar());
            lbl_nbLivraison.Text = nbLivraison.ToString();
            // affect totale prix commandes in the label
            SqlConnection cn3 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn3.Open();
            SqlCommand com3 = new SqlCommand("select sum(prixAchat*qteLivre) from detailCommande dc inner join livraison l on l.numeroBonLivraison=dc.numeroBonLivraison where idClient=" + id + filtre +" group by idClient", cn3);
            int totalPrix = Convert.ToInt32(com3.ExecuteScalar());
            lbl_totalePrix.Text = totalPrix.ToString();
            // affect quantite totale des commandes acheter in the label
            SqlConnection cn4 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn4.Open();
            SqlCommand com4 = new SqlCommand("select sum(qteLivre) from detailCommande dc inner join livraison l on dc.numeroBonLivraison=l.numeroBonLivraison where idClient=" + id + filtre +" group by idClient", cn4);
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
                        refresh(" and dateLivraison like'%" + txt_rechercher.Text + "%'");
                        break;
                    case 2:
                        refresh(" and dc.referenceModele='" + txt_rechercher.Text + "'");
                        break;
                    case 3:
                        refresh(" and idCommande=" + txt_rechercher.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("doit etre rechercher par l'element séléctionner", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
