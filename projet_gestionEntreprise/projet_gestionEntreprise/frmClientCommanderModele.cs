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
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            string req = "select c.idClient,nomClient+' '+prenomClient as nomComplet,cmd.idCommande,dateCommande,qteAchat,prixAchat,cmd.statutLivraison from client c inner join commande cmd on cmd.idClient=c.idClient inner join detailCommande dc on dc.idCommande=cmd.idCommande inner join modele m on m.referenceModele=dc.referenceModele where m.referenceModele='" + refMd + "' and cmd.statutLivraison=0 " + filtre;
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            dgv_clients.Rows.Clear();
            while (dr.Read())
            {
                dgv_clients.Rows.Add(dr["idClient"], dr["nomComplet"], dr["idCommande"], dr["dateCommande"], dr["qteAchat"], dr["prixAchat"], dr["statutLivraison"]);
            }
            dr.Close();
            dr = null;
            com = null;

            cn.Close();
            cn = null;
            //if(chk_enCourLivraison.Checked==false)
            //{
            //SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            //cn2.Open();
            //string req2 = "select distinct c.idClient,nomClient+' '+prenomClient as nomComplet from client c inner join commande cmd on cmd.idClient=c.idClient inner join detailCommande dc on dc.idCommande=cmd.idCommande inner join modele m on m.referenceModele=dc.referenceModele where m.referenceModele='"+refMd+"' "+filtre;
            //SqlCommand com2 = new SqlCommand(req2, cn2);
            //SqlDataReader dr2 = com2.ExecuteReader();
            //DataTable table1 = new DataTable();
            //table1.Load(dr2);
            //lst_clients.DisplayMember = "nomComplet";
            //lst_clients.ValueMember = "idClient";
            //lst_clients.DataSource = table1;
            ////fermeture de la datareader et la connexion et effacer la commande
            //dr2.Close();
            //dr2 = null;
            //com2 = null;
            //cn2.Close();
            //cn2 = null;
            // fill datagrid view
            //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            //cn.Open();
            //string req = "select c.idClient,nomClient+' '+prenomClient as nomComplet,cmd.idCommande,dateCommande,qteAchat,taille,cmd.statutLivraison from client c inner join commande cmd on cmd.idClient=c.idClient inner join detailCommande dc on dc.idCommande=cmd.idCommande inner join modele m on m.referenceModele=dc.referenceModele where c.idClient="+lst_clients.SelectedValue+" and m.referenceModele='"+refMd+"'";
            //SqlCommand com = new SqlCommand(req, cn);
            //SqlDataReader dr = com.ExecuteReader();
            //dgv_clients.Rows.Clear();
            //while (dr.Read())
            //{
            //    dgv_clients.Rows.Add(dr["idClient"], dr["nomComplet"], dr["idCommande"], dr["dateCommande"], dr["qteAchat"], dr["taille"], dr["statutLivraison"]);
            //}
            //dr.Close();
            //dr = null;
            //com = null;

            //cn.Close();
            //cn = null;
            //}
            //else
            //{
            //SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            //cn2.Open();
            //string req2 = "select distinct c.idClient,nomClient+' '+prenomClient as nomComplet from client c inner join commande cmd on cmd.idClient=c.idClient inner join detailCommande dc on dc.idCommande=cmd.idCommande inner join modele m on m.referenceModele=dc.referenceModele where m.referenceModele='" + refMd + "' and cmd.statutLivraison=0 "+filtre;
            //SqlCommand com2 = new SqlCommand(req2, cn2);
            //SqlDataReader dr2 = com2.ExecuteReader();
            //DataTable table1 = new DataTable();
            //table1.Load(dr2);
            //lst_clients.DisplayMember = "nomComplet";
            //lst_clients.ValueMember = "idClient";
            //lst_clients.DataSource = table1;
            ////fermeture de la datareader et la connexion et effacer la commande
            //dr2.Close();
            //dr2 = null;
            //com2 = null;
            //cn2.Close();
            //cn2 = null;
            // fill data grid view
            //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            //cn.Open();
            //string req = "select c.idClient,nomClient+' '+prenomClient as nomComplet,cmd.idCommande,dateCommande,qteAchat,taille,cmd.statutLivraison from client c inner join commande cmd on cmd.idClient=c.idClient inner join detailCommande dc on dc.idCommande=cmd.idCommande inner join modele m on m.referenceModele=dc.referenceModele where m.referenceModele='" + refMd + "' and cmd.statutLivraison=0";
            //SqlCommand com = new SqlCommand(req, cn);
            //SqlDataReader dr = com.ExecuteReader();
            //dgv_clients.Rows.Clear();
            //while (dr.Read())
            //{
            //    dgv_clients.Rows.Add(dr["idClient"], dr["nomComplet"], dr["idCommande"], dr["dateCommande"], dr["qteAchat"], dr["taille"], dr["statutLivraison"]);
            //}
            //dr.Close();
            //dr = null;
            //com = null;

            //cn.Close();
            //cn = null;
            //}
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
            refresh(" and (c.idClient="+txt_rechercher.Text+ " or nomClient like '%" + txt_rechercher.Text+"%' or prenomClient like'%"+txt_rechercher.Text+"%')");
        }

        private void lst_clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (chk_enCourLivraison.Checked == false)
            //{
            //    // fill datagrid view
            //    SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            //    cn.Open();
            //    string req = "select c.idClient,nomClient+' '+prenomClient as nomComplet,cmd.idCommande,m.referenceModele,dateCommande,qteAchat,prixAchat,taille,cmd.statutLivraison from client c inner join commande cmd on cmd.idClient=c.idClient inner join detailCommande dc on dc.idCommande=cmd.idCommande inner join modele m on m.referenceModele=dc.referenceModele where c.idClient=" + lst_clients.SelectedValue + " and m.referenceModele='" + refMd + "'";
            //    SqlCommand com = new SqlCommand(req, cn);
            //    SqlDataReader dr = com.ExecuteReader();
            //    dgv_clients.Rows.Clear();
            //    while (dr.Read())
            //    {
            //        dgv_clients.Rows.Add(dr["idCommande"], dr["dateCommande"], dr["qteAchat"], dr["prixAchat"], dr["statutLivraison"]);
            //    }
            //    dr.Close();
            //    dr = null;
            //    com = null;

            //    cn.Close();
            //    cn = null;
            //}
            //else
            //{
            //    // fill data grid view
            //    SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            //    cn.Open();
            //    string req = "select c.idClient,nomClient+' '+prenomClient as nomComplet,cmd.idCommande,m.referenceModele,dateCommande,qteAchat,prixAchat,taille,cmd.statutLivraison from client c inner join commande cmd on cmd.idClient=c.idClient inner join detailCommande dc on dc.idCommande=cmd.idCommande inner join modele m on m.referenceModele=dc.referenceModele where c.idClient=" + lst_clients.SelectedValue +" and m.referenceModele='" + refMd + "' and cmd.statutLivraison=0";
            //    SqlCommand com = new SqlCommand(req, cn);
            //    SqlDataReader dr = com.ExecuteReader();
            //    dgv_clients.Rows.Clear();
            //    while (dr.Read())
            //    {
            //        dgv_clients.Rows.Add(dr["idCommande"], dr["dateCommande"], dr["qteAchat"], dr["prixAchat"], dr["statutLivraison"]);
            //    }
            //    dr.Close();
            //    dr = null;
            //    com = null;

            //    cn.Close();
            //    cn = null;
            //}
        }

        private void btn_refresh_Click_1(object sender, EventArgs e)
        {
            refresh("");
            txt_rechercher.Text = "";
        }
    }
}
