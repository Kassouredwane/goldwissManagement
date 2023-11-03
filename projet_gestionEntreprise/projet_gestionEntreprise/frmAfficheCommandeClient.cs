﻿using System;
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
        private void activate(bool v)
        {
            panel1.Enabled = !v;
            panel2.Enabled = v;
        }
            private void refresh(string filtre)
        {
            if(chk_enCourLivraison.Checked)
            {
                // fill datagrid view with commandes of clients

                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn.Open();
                string req = "select c.idCommande,dateCommande,designation,test from commande c inner join statutLivraison sl on sl.idStatutLivraison=c.idStatutLivraison where idClient=" + IdClient + " and c.idStatutLivraison=2"+filtre;
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_commandeClient.Rows.Clear();
                while (dr.Read())
                {
                    dgv_commandeClient.Rows.Add(dr["idCommande"], dr["dateCommande"], dr["designation"], dr["test"]);
                }
                // close all commandes and connection and datareader
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
            }
            else
            {
                // fill datagrid view with commandes of clients

                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn.Open();
                string req = "select c.idCommande,dateCommande,designation,test from commande c inner join statutLivraison sl on sl.idStatutLivraison=c.idStatutLivraison where idClient=" + IdClient+filtre;
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_commandeClient.Rows.Clear();
                while (dr.Read())
                {
                    dgv_commandeClient.Rows.Add(dr["idCommande"], dr["dateCommande"], dr["designation"], dr["test"]);
                }
                // close all commandes and connection and datareader
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
            }
        }
        private void frmAfficheCommandeClient_Load(object sender, EventArgs e)
        {
            refresh("");
            activate(false);
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            int idCommande = Convert.ToInt32(dgv_commandeClient.CurrentRow.Cells[0].Value); 
            frmAjouterModeleACommande f = new frmAjouterModeleACommande(idCommande);
            f.ShowDialog();
        }

        private void frmAfficheCommandeClient_Activated(object sender, EventArgs e)
        {
            //refresh("");
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            int idCcommande = Convert.ToInt32(dgv_commandeClient.CurrentRow.Cells[0].Value);
            string refModele = dgv_detailCommandeClient.CurrentRow.Cells[0].Value.ToString();
            frmModifierDetailCommandeClient f = new frmModifierDetailCommandeClient(idCcommande,refModele);
            f.ShowDialog();
        }

        private void btn_nouveauCommande_Click(object sender, EventArgs e)
        {
            int idClient = IdClient;
            frmNouveauCommande f = new frmNouveauCommande(idClient);
            f.ShowDialog();
        }
        private void dgv_commandeClient_SelectionChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            string req = "select referenceModele,qteAchat,prixAchat from detailCommande where idCommande=" + dgv_commandeClient.CurrentRow.Cells[0].Value;
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

        private void chk_enCourLivraison_CheckedChanged(object sender, EventArgs e)
        {
            refresh("");
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (dgv_commandeClient.CurrentRow != null && dgv_detailCommandeClient.CurrentRow != null)
            {
                if (MessageBox.Show("Etes-vous vraiment veux supprimer ce modele ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection cn5 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                    cn5.Open();

                    // Check if the cells are not null before accessing their Value property
                    if (dgv_commandeClient.CurrentRow.Cells[0] != null && dgv_detailCommandeClient.CurrentRow.Cells[0] != null)
                    {
                        string idCommande = dgv_commandeClient.CurrentRow.Cells[0].Value.ToString();
                        string referenceModele = dgv_detailCommandeClient.CurrentRow.Cells[0].Value.ToString();

                        string req5 = "delete from detailCommande where idCommande = @idCommande and referenceModele = @referenceModele";
                        SqlCommand com5 = new SqlCommand(req5, cn5);

                        // Use parameterized queries to prevent SQL injection
                        com5.Parameters.AddWithValue("@idCommande", idCommande);
                        com5.Parameters.AddWithValue("@referenceModele", referenceModele);

                        com5.ExecuteNonQuery();
                        com5 = null;
                    }
                    cn5.Close();
                    cn5 = null;
                    refresh("");
                }
            }
            //MessageBox.Show("idCommande : " + dgv_commandeClient.CurrentRow.Cells[0].Value + " -  referenceModele : " + dgv_detailCommandeClient.CurrentRow.Cells[0].Value);
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            refresh(" and idCommande like'%"+ txt_rechercher.Text + "%'");
        }

        private void btn_refresh_Click_1(object sender, EventArgs e)
        {
            refresh("");
            txt_rechercher.Text = "";
        }

        private void btn_ajouterALivraison_Click(object sender, EventArgs e)
        {
            activate(true);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            activate(false);
        }

    }
}
