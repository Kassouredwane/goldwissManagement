using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
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
    public partial class frmLivraisonMatla : Form
    {
        int idMt;
        int entree;
        int reste;
        int resteMatla;
        public frmLivraisonMatla(int id, int entr, int res)
        {
            InitializeComponent();
            this.idMt = id;
            this.entree = entr;
            this.reste = res;
        }

        private void frmLivraisonMatla_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            string req = "select l.idLivraison,dateLivraison,numeroBonLivraison,nomClient+' '+prenomClient as nomComplet,idMatla,qteLivre from livraison l inner join detailLivraison dl on dl.idLivraison=l.idLivraison inner join commande cmd on cmd.idCommande=l.idCommande inner join client c on c.idClient=cmd.idClient where idMatla="+idMt;
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            dgv_livraison.Rows.Clear();
            while (dr.Read())
            {
                dgv_livraison.Rows.Add(dr["idLivraison"], Convert.ToDateTime(dr["dateLivraison"].ToString()).ToShortDateString(), dr["numeroBonLivraison"], dr["nomComplet"], dr["qteLivre"]);
            }
            // close all commandes and connection and datareader
            dr.Close();
            dr = null;
            com = null;

            cn.Close();
            cn = null;


            SqlConnection cn4 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn4.Open();
            SqlCommand com4 = new SqlCommand("select nbPieceSorter-sum(qteLivre) from matla mt inner join detailLivraison dl on dl.idMatla=mt.idMatla where mt.idMatla="+idMt+" group by mt.idMatla,nbPieceSorter", cn4);
            resteMatla = Convert.ToInt32(com4.ExecuteScalar());
            // close all commandes and connection and datareader
            com4 = null;
            cn4.Close();
            cn4 = null;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void imprimer(ReportClass cr, string chemain = "", string filtre = "")
        {
            cr.SetDatabaseLogon("sa", "123456");
            if (chemain != "")
                cr.SetParameterValue("chemain", chemain);
            cr.SetParameterValue("entree",entree);
            cr.SetParameterValue("reste",reste);
            cr.SetParameterValue("resteMatla", resteMatla);
            frmImpression f = new frmImpression(cr, filtre);
            f.ShowDialog();
        }
        private void btn_imprimerLivraison_Click(object sender, EventArgs e)
        {
            //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //cn.Open();
            //string req = "select livraison.idLivraison,dateLivraison,numeroBonLivraison,nomClient,prenomClient,idMatla,qteLivre from livraison inner join detailLivraison on detailLivraison.idLivraison=livraison.idLivraison inner join commande on commande.idCommande=livraison.idCommande inner join client on client.idClient=commande.idClient where detailLivraison.idMatla=" + idMt;

            //SqlCommand com = new SqlCommand(req, cn);
            //DataSet ds = new DataSet();
            //SqlDataAdapter ad = new SqlDataAdapter(com);
            //ad.Fill(ds, "Orders");

            //CrystalReport13 cr = new CrystalReport13();
            //cr.SetDatabaseLogon("sa", "123456");
            //cr.SetDataSource(ds.Tables["Orders"]);

            //frmImpression f = new frmImpression(cr);
            //f.ShowDialog();
            //imprimer(cr);

            //string filtre = "{matla.idMatla} = " + idMt;

            //imprimer(new ficheLivraisonMatla(), "", filtre);

            string ch = Application.StartupPath + @"\imageModeles\";

            MatlaLivraisonReport cr = new MatlaLivraisonReport();
            cr.Refresh();
            cr.SetDatabaseLogon("sa", "123456");

            cr.SetParameterValue("chemain", ch);
            cr.SetParameterValue("entree", entree);
            cr.SetParameterValue("reste", reste);
            cr.SetParameterValue("resteMatla", resteMatla);
            //   
            string filtre = "{matla.idMatla}=" + idMt;
            frmImpression f = new frmImpression(cr, filtre);
            f.ShowDialog();

        }
    }
}
