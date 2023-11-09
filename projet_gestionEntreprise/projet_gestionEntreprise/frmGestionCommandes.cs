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
    public partial class frmGestionCommandes : Form
    {
        public frmGestionCommandes()
        {
            InitializeComponent();
        }
        private void refresh(string filtre)
        {
            if(chk_enCourLivraison.Checked==false) 
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn.Open();
                string req = "select c.idClient,nomClient+' '+prenomClient as nomComplet,cmd.idCommande,dateCommande,cmd.statutLivraison from client c inner join commande cmd on cmd.idClient=c.idClient " + filtre+" order by dateCommande";
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_commandeClient.Rows.Clear();
                while (dr.Read())
                {
                    dgv_commandeClient.Rows.Add(dr["idClient"], dr["nomComplet"], dr["idCommande"], dr["dateCommande"], dr["statutLivraison"]);
                }
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
            }
            else
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn.Open();
                string req = "select c.idClient,nomClient+' '+prenomClient as nomComplet,cmd.idCommande,dateCommande,cmd.statutLivraison from client c inner join commande cmd on cmd.idClient=c.idClient where cmd.statutLivraison=0 " + filtre+" order by dateCommande";
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_commandeClient.Rows.Clear();
                while (dr.Read())
                {
                    dgv_commandeClient.Rows.Add(dr["idClient"], dr["nomComplet"], dr["idCommande"], dr["dateCommande"], dr["statutLivraison"]);
                }
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
            }
        }
        private void frmGestionCommandes_Load(object sender, EventArgs e)
        {
            refresh("");
            cb_recherche.SelectedIndex= 0;  
        }

        private void chk_enCourLivraison_CheckedChanged(object sender, EventArgs e)
        {
            refresh("");
        }

        private void dgv_commandeClient_SelectionChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            string req = "select dc.referenceModele,designation,qteAchat,prixAchat,qteLivre,statutLivraison from detailCommande dc inner join modele m on m.referenceModele=dc.referenceModele where idCommande=" + dgv_commandeClient.CurrentRow.Cells[2].Value;
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            dgv_detailCommandeClient.Rows.Clear();
            while (dr.Read())
            {
                dgv_detailCommandeClient.Rows.Add(dr["referenceModele"], dr["designation"], dr["qteAchat"], dr["prixAchat"], dr["qteLivre"], dr["statutLivraison"]);
            }
            dr.Close();
            dr = null;
            com = null;

            cn.Close();
            cn = null;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh("");
        }
        //Code Client
        //Nom Complet
        //Id Commande
        //Date Commande
        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            switch (cb_recherche.SelectedIndex)
            {
                case 0:
                    if (chk_enCourLivraison.Checked==false) refresh(" where c.idClient="+txt_rechercher.Text);
                    else refresh(" and c.idClient=" + txt_rechercher.Text);
                    break;
                case 1:
                    if (chk_enCourLivraison.Checked == false) refresh(" where nomClient like'%"+ txt_rechercher.Text + "%' or prenomClient like'%"+txt_rechercher.Text+"%'");
                    else refresh(" and c.idClient=" + txt_rechercher.Text);
                    break;
                case 2:
                    if (chk_enCourLivraison.Checked == false) refresh(" where cmd.idCommande=" + txt_rechercher.Text);
                    else refresh(" and c.idClient=" + txt_rechercher.Text);
                    break;
                case 3:
                    //if (chk_enCourLivraison.Checked == false) refresh(" where cmd.dateCommande=" + txt_rechercher.Text);
                    //else refresh(" and c.idClient=" + txt_rechercher.Text);
                    if (chk_enCourLivraison.Checked == false) refresh(" where idCommande in (select ...)");
                    //else refresh(" and c.idClient=" + txt_rechercher.Text);
                    break;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous vraiment veux supprimer ce client ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // delete the "commande" from table detailCommande because she has a foreign key of IdCommande
                SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn1.Open();
                string req1 = "delete from detailCommande where idCommande=" + dgv_commandeClient.CurrentRow.Cells[2].Value;
                SqlCommand com1 = new SqlCommand(req1, cn1);
                com1.ExecuteNonQuery();
                com1 = null;
                cn1.Close();
                cn1 = null;
                // delete the "commande" from table of commmande
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn.Open();
                string req = "delete from detailCommande where idCommande=" + dgv_commandeClient.CurrentRow.Cells[2].Value;
                SqlCommand com = new SqlCommand(req, cn);
                com.ExecuteNonQuery();
                com = null;
                cn.Close();
                cn = null;
                MessageBox.Show("La commande a été supprimer avec succé","Information",MessageBoxButtons.OK, MessageBoxIcon.Question);  
            }
        }
    }
}
