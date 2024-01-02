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
    public partial class frmAjouterClient : Form
    {
        public frmAjouterClient()
        {
            InitializeComponent();
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

        private void frmAjouterClient_Activated(object sender, EventArgs e)
        {
            //cb_villeClient.Items.Clear();
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            string req = "select * from ville";
            SqlCommand com1 = new SqlCommand(req, cn);
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
            cn.Close();
            cn = null;
        }

        private void frmAjouterClient_Load(object sender, EventArgs e)
        {
            try 
            { 
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                SqlCommand com = new SqlCommand("select max(idClient)+1 from client", cn);
                int nb = Convert.ToInt32(com.ExecuteScalar());

                txt_idClient.Text = nb.ToString();
                com = null;
                cn.Close();
                cn = null;
            }
            catch(Exception error) { txt_idClient.Text = "1"; }

            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
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
            txt_adresseClient.Text = "Aucun Adresse";
        }
        
        private void btn_valider_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            string reqq = "insert into client(nomClient,prenomClient,telephoneClient,adresseClient,idVille) values (@nomClient,@prenomClient,@telephoneClient,@adresseClient,@idVille)";
            SqlCommand com = new SqlCommand(reqq, cn);
            com.Parameters.Add(new SqlParameter("@nomClient", txt_nomClient.Text));
            com.Parameters.Add(new SqlParameter("@prenomClient", txt_prenomClient.Text));
            com.Parameters.Add(new SqlParameter("@telephoneClient", txt_telephoneClient.Text));
            com.Parameters.Add(new SqlParameter("@adresseClient", txt_adresseClient.Text));
            com.Parameters.Add(new SqlParameter("@idVille", cb_villeClient.SelectedValue));
            com.ExecuteNonQuery();

            //string req = "insert into client values('"+txt_nomClient.Text+"','"+txt_prenomClient.Text+"','"+txt_telephoneClient.Text+"','"+txt_adresseClient.Text+"',"+cb_villeClient.SelectedValue+")";
            //SqlCommand com = new SqlCommand(req, cn);
            //com.ExecuteNonQuery();

            com = null;
            cn.Close();
            cn = null;
            MessageBox.Show("le client a été ajouter avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //empty all text box
            txt_idClient.Text = "";
            txt_nomClient.Text = "";
            txt_prenomClient.Text = "";
            txt_telephoneClient.Text = "";
        }
    }
}
