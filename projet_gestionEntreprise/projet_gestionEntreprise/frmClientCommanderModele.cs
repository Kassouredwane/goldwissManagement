using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace projet_gestionEntreprise
{
    public partial class frmClientCommanderModele : Form
    {
        string refMd;
        public frmClientCommanderModele(string idMd)
        {
            InitializeComponent();
            this.refMd = idMd;
        }
        private void refresh(string filtre)
        {
            if(chk_enCourLivraison.Checked==false)
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn.Open();
                string req = "select c.idClient,nomClient+' '+prenomClient as nomComplet,cmd.idCommande,dateCommande,qteAchat,taille,cmd.statutLivraison from client c inner join commande cmd on cmd.idClient=c.idClient inner join detailCommande dc on dc.idCommande=cmd.idCommande inner join modele m on m.referenceModele=dc.referenceModele where m.referenceModele='"+refMd+"' "+filtre;
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_clients.Rows.Clear();
                while (dr.Read())
                {
                    dgv_clients.Rows.Add(dr["idClient"], dr["nomComplet"], dr["idCommande"], dr["dateCommande"], dr["qteAchat"], dr["taille"], dr["statutLivraison"]);
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
                string req = "select c.idClient,nomClient+' '+prenomClient as nomComplet,cmd.idCommande,dateCommande,qteAchat,taille,cmd.statutLivraison from client c inner join commande cmd on cmd.idClient=c.idClient inner join detailCommande dc on dc.idCommande=cmd.idCommande inner join modele m on m.referenceModele=dc.referenceModele where m.referenceModele='" + refMd + "' and cmd.statutLivraison=0 "+filtre;
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_clients.Rows.Clear();
                while (dr.Read())
                {
                    dgv_clients.Rows.Add(dr["idClient"], dr["nomComplet"], dr["idCommande"], dr["dateCommande"], dr["qteAchat"], dr["taille"], dr["statutLivraison"]);
                }
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
            }
        }
        private void frmClientCommanderModele_Load(object sender, EventArgs e)
        {
            refresh("");
        }

        private void chk_enCourLivraison_CheckedChanged(object sender, EventArgs e)
        {
            refresh("");
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            refresh(" and c.idClient="+txt_rechercher.Text+ " or nomComplet like '%" + txt_rechercher.Text+"%'");
        }
    }
}
