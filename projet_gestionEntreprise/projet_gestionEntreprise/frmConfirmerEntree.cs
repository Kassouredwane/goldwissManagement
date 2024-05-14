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
    public partial class frmConfirmerEntree : Form
    {
        int idEntree;
        int qteStocker;
        int idMatla;
        public frmConfirmerEntree(int idPss,int qte,int idMt)
        {
            InitializeComponent();
            this.idEntree = idPss;
            this.qteStocker = qte;
            this.idMatla = idMt;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            //- update la quantité confirmer de l'entrée
            SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn2.Open();
            string reqq2 = "update phasonieStocker set qteConfirmer=@qteConfirmer where idPhasonierStocker="+idEntree;
            SqlCommand com2 = new SqlCommand(reqq2, cn2);
            com2.Parameters.Add(new SqlParameter("@qteConfirmer", Convert.ToInt32(txt_qteConfirmer.Text)));
            com2.ExecuteNonQuery();
            com2 = null;
            cn2.Close();
            cn2 = null;
            //- update l'entree de matla
            SqlConnection cn6 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn6.Open();
            string reqq6 = "update matla set entrees=entrees-@qteStocker+@qteConfirmer where idMatla=" + idMatla;
            SqlCommand com6 = new SqlCommand(reqq6, cn6);
            com6.Parameters.Add(new SqlParameter("@qteStocker", qteStocker));
            com6.Parameters.Add(new SqlParameter("@qteConfirmer", Convert.ToInt32(txt_qteConfirmer.Text)));
            com6.ExecuteNonQuery();
            com6 = null;
            cn6.Close();
            cn6 = null;
            //- update la quantité disponible de situationModele
            SqlConnection cn11 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn11.Open();
            string reqq11 = "update matla set disponible=disponible-@qteStocker+" + Convert.ToInt32(txt_qteConfirmer.Text) + " where idMatla=" + idMatla;
            SqlCommand com11 = new SqlCommand(reqq11, cn11);
            com11.Parameters.Add(new SqlParameter("@qteStocker", qteStocker));
            com11.ExecuteNonQuery();
            com11 = null;
            cn11.Close();
            cn11 = null;
            //- update statutComplet de matla
            SqlConnection cn5 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn5.Open();
            SqlCommand com5 = new SqlCommand("select nbPieceSorter from matla where idMatla=" + idMatla, cn5);
            int nbPieceSorter = Convert.ToInt32(com5.ExecuteScalar());

            SqlConnection cn4 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn4.Open();
            SqlCommand com4 = new SqlCommand("select sum(qteConfirmer) from phasonieStocker pss inner join matla mt on mt.idMatla=pss.idMatla where mt.idMatla=" + idMatla + " group by mt.idMatla", cn4);
            int nbPieceStocker = Convert.ToInt32(com4.ExecuteScalar());
            //int qteStocker = Convert.ToInt32(txt_qteStocker.Text);
            if (nbPieceStocker >= nbPieceSorter)
            {
                SqlConnection cn3 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn3.Open();
                string reqq3 = "update matla set statutComplet=1 where idMatla=" + idMatla;
                SqlCommand com3 = new SqlCommand(reqq3, cn3);
                com3.ExecuteNonQuery();
                com3 = null;
                cn3.Close();
                cn3 = null;
            }
            //- update statut confirmer
            SqlConnection cn12 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn12.Open();
            string reqq12 = "update phasonieStocker set confirmer=1 where idPhasonierStocker="+idEntree;
            SqlCommand com12 = new SqlCommand(reqq12, cn12);
            com12.ExecuteNonQuery();
            com12 = null;
            cn12.Close();
            cn12 = null;
            MessageBox.Show("le stockage de matla a été confirmer avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Close();
        }

        private void frmConfirmerEntree_Load(object sender, EventArgs e)
        {

        }
    }
}
