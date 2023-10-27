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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projet_gestionEntreprise
{
    public partial class frmModifierClient : Form
    {
        int IdClient;
        public frmModifierClient(int idClient)
        {
            InitializeComponent();
            txt_idClient.Text = idClient.ToString();
            IdClient=idClient;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ajouterVille_Click(object sender, EventArgs e)
        {
            frmAjouterVille f = new frmAjouterVille();
            f.ShowDialog();
        }

        private void frmModifierClient_Load(object sender, EventArgs e)
        {
            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn1.Open();
            string req = "select * from ville";
            SqlCommand com1 = new SqlCommand(req, cn1);
            SqlDataReader dr1 = com1.ExecuteReader();
            DataTable table1 = new DataTable();
            table1.Load(dr1);
            cb_villeClient.DisplayMember = "nomVille";
            cb_villeClient.ValueMember = "idVille";
            cb_villeClient.DataSource = table1;
            //fermeture de la datareader et la connexion et effacer la commande
            dr1.Close();
            dr1 = null;
            com1 = null;
            cn1.Close();
            cn1 = null;

            //cb_villeClient.SelectedIndex = 10;

            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            SqlCommand com = new SqlCommand("select idClient,nomClient,prenomClient,telephoneClient,adresseClient,c.idVille as idVille,nomVille from client c inner join ville v on v.idVille=c.idVille where idClient=" + txt_idClient.Text, cn);
            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
            {
                txt_nomClient.Text = dr["nomClient"].ToString();
                txt_prenomClient.Text = dr["prenomClient"].ToString();
                txt_telephoneClient.Text = dr["telephoneClient"].ToString();
                txt_adresseClient.Text = dr["adresseClient"].ToString();
                //int cityID = dr.GetInt32(dr.GetOrdinal("idVille"));
                //cb_villeClient.SelectedValue = cityID;

                int Ville = Convert.ToInt32(dr["idVille"].ToString());
                cb_villeClient.SelectedValue = Ville;

                //if (!dr.IsDBNull(dr.GetOrdinal("idVille")))
                //{
                //    int cityID = dr.GetInt32(dr.GetOrdinal("idVille"));
                //    cb_villeClient.SelectedValue = cityID;
                //}
            }
        }

        private void frmModifierClient_Activated(object sender, EventArgs e)
        {
            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn1.Open();
            string req = "select * from ville";
            SqlCommand com1 = new SqlCommand(req, cn1);
            SqlDataReader dr1 = com1.ExecuteReader();
            DataTable table1 = new DataTable();
            table1.Load(dr1);
            cb_villeClient.DisplayMember = "nomVille";
            cb_villeClient.ValueMember = "idVille";
            cb_villeClient.DataSource = table1;
            //fermeture de la datareader et la connexion et effacer la commande
            dr1.Close();
            dr1 = null;
            com1 = null;
            cn1.Close();
            cn1 = null;


            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            SqlCommand com = new SqlCommand("select idClient,nomClient,prenomClient,telephoneClient,adresseClient,c.idVille as idVille,nomVille from client c inner join ville v on v.idVille=c.idVille where idClient=" + txt_idClient.Text, cn);
            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
            {
                txt_nomClient.Text = dr["nomClient"].ToString();
                txt_prenomClient.Text = dr["prenomClient"].ToString();
                txt_telephoneClient.Text = dr["telephoneClient"].ToString();
                txt_adresseClient.Text = dr["adresseClient"].ToString();
                //int cityID = dr.GetInt32(dr.GetOrdinal("idVille"));
                //cb_villeClient.SelectedValue = cityID;

                int Ville = Convert.ToInt32(dr["idVille"].ToString());
                cb_villeClient.SelectedValue = Ville;

                //if (!dr.IsDBNull(dr.GetOrdinal("idVille")))
                //{
                //    int cityID = dr.GetInt32(dr.GetOrdinal("idVille"));
                //    cb_villeClient.SelectedValue = cityID;
                //}
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            string reqq = "update client set nomClient='"+txt_nomClient.Text+"',prenomClient='"+txt_prenomClient.Text+"',telephoneClient='"+txt_telephoneClient.Text+"',adresseClient='"+txt_adresseClient.Text+"',idVille="+cb_villeClient.SelectedValue+" where idClient="+txt_idClient.Text ;
            //string reqq = "update client set nomClient='@nomClient',prenomClient='@prenomClient', telephoneClient='@telephoneClient',adresseClient='@adresseClient',idVille=@idVille where idClient="+txt_idClient.Text ;
            SqlCommand com = new SqlCommand(reqq, cn);
            //com.Parameters.Add(new SqlParameter("@nomClient", txt_nomClient.Text));
            //com.Parameters.Add(new SqlParameter("@prenomClient", txt_prenomClient.Text));
            //com.Parameters.Add(new SqlParameter("@telephoneClient", txt_telephoneClient.Text));
            //com.Parameters.Add(new SqlParameter("@adresseClient", txt_adresseClient.Text));
            //com.Parameters.Add(new SqlParameter("@idVille", cb_villeClient.SelectedValue));
            com.ExecuteNonQuery();
            com = null;
            cn.Close();
            cn = null;
            MessageBox.Show("le client a été modifier avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
