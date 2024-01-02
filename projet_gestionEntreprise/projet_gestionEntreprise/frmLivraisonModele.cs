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
    public partial class frmLivraisonModele : Form
    {
        string refMd;
        public frmLivraisonModele(string refM)
        {
            InitializeComponent();
            this.refMd = refM;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void refresh(string filtre)
        {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn.Open();
                string req = "SELECT livraison.idLivraison,livraison.numeroBonLivraison,livraison.dateLivraison,client.idClient,client.nomClient+' '+client.prenomClient AS nomComplet,commande.idCommande,matla.idMatla,detailLivraison.qteLivre FROM livraison INNER JOIN detailLivraison ON livraison.idLivraison = detailLivraison.idLivraison INNER JOIN matla ON detailLivraison.idMatla = matla.idMatla INNER JOIN modele ON matla.referenceModele = modele.referenceModele INNER JOIN commande ON livraison.idCommande = commande.idCommande INNER JOIN client ON commande.idClient = client.idClient WHERE modele.referenceModele = '"+refMd+"' "+filtre+" order by dateLivraison desc";
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_livraisonClient.Rows.Clear();
                while (dr.Read())
                {
                    dgv_livraisonClient.Rows.Add(dr["idLivraison"], dr["numeroBonLivraison"], Convert.ToDateTime(dr["dateLivraison"].ToString()).ToShortDateString(), dr["idClient"], dr["nomComplet"], dr["idCommande"], dr["idMatla"], dr["qteLivre"]);
                }
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
        }
        private void frmLivraisonModele_Load(object sender, EventArgs e)
        {
            refresh("");
            cb_recherche.SelectedIndex = 0;
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cb_recherche.SelectedIndex)
                {
                    case 0:
                        refresh(" and livraison.idLivraison=" + txt_rechercher.Text);
                        break;
                    case 1:
                        refresh(" and livraison.numeroBonLivraison=" + txt_rechercher.Text);
                        break;
                    case 2:
                        refresh(" and (nomClient like '%" + txt_rechercher.Text + "%' or prenomClient like '%" + txt_rechercher.Text + "%')");
                        break;
                    case 3:
                        refresh(" and matla.idMatla="+txt_rechercher.Text);
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("doit etre rechercher par l'element séléctionner","Inforamtion",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh("");
            txt_rechercher.Text = "";
        }

        private void chk_resteEnStock_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
