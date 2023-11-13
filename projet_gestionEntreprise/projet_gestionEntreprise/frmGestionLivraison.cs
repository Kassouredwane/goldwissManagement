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
    public partial class frmGestionLivraison : Form
    {
        public frmGestionLivraison()
        {
            InitializeComponent();
        }
        private void refresh(string filtre)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            string req = "select l.idLivraison,numeroBonLivraison,dateLivraison,c.idClient,nomClient+' '+prenomClient as nomComplet from livraison l inner join client c on c.idClient=l.idClient " + filtre + " order by dateLivraison";
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            dgv_livraison.Rows.Clear();
            while (dr.Read())
            {
                dgv_livraison.Rows.Add(dr["idLivraison"], dr["numeroBonLivraison"], dr["dateLivraison"], dr["idClient"], dr["nomComplet"]);
            }
            dr.Close();
            dr = null;
            com = null;

            cn.Close();
            cn = null;
            //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            //cn.Open();
            //string req = "select l.idLivraison,numeroBonLivraison,dateLivraison,c.idClient,nomClient+' '+prenomClient as nomComplet,idCommande,m.referenceModele,designation,qteLivre from livraison l inner join detailCommande dc on dc.idLivraison=l.idLivraison inner join modele m on m.referenceModele=dc.referenceModele inner join client c on c.idClient=l.idClient " + filtre+" order by dateLivraison";
            //SqlCommand com = new SqlCommand(req, cn);
            //SqlDataReader dr = com.ExecuteReader();
            //dgv_livraison.Rows.Clear();
            //while (dr.Read())
            //{
            //    dgv_livraison.Rows.Add(dr["idLivraison"], dr["numeroBonLivraison"], dr["dateLivraison"], dr["idClient"], dr["nomComplet"], dr["idCommande"], dr["referenceModele"], dr["designation"], dr["qteLivre"]);
            //}
            //dr.Close();
            //dr = null;
            //com = null;

            //cn.Close();
            //cn = null;
        }
        private void frmGestionLivraison_Load(object sender, EventArgs e)
        {
            refresh("");
            cb_recherche.SelectedIndex = 0;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh("");
            txt_rechercher.Text = "";
        }
        //Id Livraison
        //N° Bon Livraison
        //Date Livraison
        //Nom de Client
        //Reference Modele
        //ID Commande
        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cb_recherche.SelectedIndex)
                {
                    case 0:
                        refresh(" where l.idLivraison=" + txt_rechercher.Text);
                        break;
                    case 1:
                        refresh(" where l.numeroBonLivraison=" + txt_rechercher.Text);
                        break;
                    case 2:
                        refresh(" where dateLivraison like'%" + txt_rechercher.Text+"%'");
                        break;
                    case 3:
                        refresh(" where nomClient like '%"+ txt_rechercher.Text + "%' or prenomClient like '%"+txt_rechercher.Text+"%'");
                        break;
                    //case 4:
                    //    refresh(" where m.referenceModele='" + txt_rechercher.Text + "'");
                    //    break;
                    //case 5:
                    //    refresh(" where idCommande=" + txt_rechercher.Text);
                    //    break;
                    case 4:
                        refresh(" where l.idLivraison in (select idLivraison from detailCommande where referenceModele='"+ txt_rechercher.Text + "')");
                        break;
                    case 5:
                        refresh(" where l.idLivraison in (select idLivraison from detailCommande where idCommande=" + txt_rechercher.Text+")");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("doit etre rechercher par l'element séléctionner", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_livraison_SelectionChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            string req = "select idCommande,m.referenceModele,designation,qteAchat,prixAchat,qteLivre from detailCommande dc inner join modele m on m.referenceModele=dc.referenceModele where idLivraison=" + dgv_livraison.CurrentRow.Cells[0].Value;
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            dgv_detailLivraison.Rows.Clear();
            while (dr.Read())
            {
                dgv_detailLivraison.Rows.Add(dr["idCommande"], dr["referenceModele"], dr["designation"], dr["qteAchat"], dr["prixAchat"], dr["qteLivre"]);
            }
            dr.Close();
            dr = null;
            com = null;

            cn.Close();
            cn = null;
        }
    }
}
