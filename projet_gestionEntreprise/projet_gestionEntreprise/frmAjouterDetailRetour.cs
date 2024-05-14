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
    public partial class frmAjouterDetailRetour : Form
    {
        int idDetail;
        int idClient;
        public frmAjouterDetailRetour(int idD,int idC)
        {
            InitializeComponent();
            this.idDetail = idD;
            this.idClient = idC;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            SqlCommand com = new SqlCommand("select max(idRetour) from retour where idClient="+idClient, cn);
            int idRetour = Convert.ToInt32(com.ExecuteScalar());
            com = null;
            cn.Close();
            cn = null;

            // request idMatla
            SqlConnection cn8 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn8.Open();
            SqlCommand com8 = new SqlCommand("select idMatla from detailLivraison where idDetailLivraison=" + idDetail, cn8);
            int idMatla = Convert.ToInt32(com8.ExecuteScalar());
            com8 = null;
            cn8.Close();
            cn8 = null;

            //insertion dans le retour
            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn1.Open();
            string reqq1 = "insert into detailRetour(qteRetour,idRetour,idDetailLivraison) values(@qteRetour,@idRetour,@idDetailLivraison)";
            SqlCommand com1 = new SqlCommand(reqq1, cn1);
            com1.Parameters.Add(new SqlParameter("@qteRetour", txt_qteRetour.Text));
            com1.Parameters.Add(new SqlParameter("@idRetour", idRetour));
            com1.Parameters.Add(new SqlParameter("@idDetailLivraison", idDetail));
            com1.ExecuteNonQuery();

            com1 = null;
            cn1.Close();
            cn1 = null;

            // update la qteStock de matla
            SqlConnection cn3 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn3.Open();
            string reqq3 = "update matla set qteStock=(qteStock+" + Convert.ToInt32(txt_qteRetour.Text) + ") where idMatla=" + idMatla;
            SqlCommand com3 = new SqlCommand(reqq3, cn3);
            com3.ExecuteNonQuery();

            com3 = null;
            cn3.Close();
            cn3 = null;
            // update la quantité disponible de matla livré
            SqlConnection cn15 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn15.Open();
            string reqq15 = "update matla set disponible=(disponible+" + Convert.ToInt32(txt_qteRetour.Text) + ") where idMatla=" + idMatla;
            SqlCommand com15 = new SqlCommand(reqq15, cn15);
            com15.ExecuteNonQuery();

            com15 = null;
            cn15.Close();
            cn15 = null;
            // update statut terminer = 0
            SqlConnection cn4 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn4.Open();
            string reqq4 = "update matla set statutTerminer=0 where idMatla=@idMatla";
            SqlCommand com4 = new SqlCommand(reqq4, cn4);
            com4.Parameters.Add(new SqlParameter("@idMatla", idMatla));
            com4.ExecuteNonQuery();

            com4 = null;
            cn4.Close();
            cn4 = null;

            // message d'effectué
            MessageBox.Show("Le modèle a été ajouter a retour avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
