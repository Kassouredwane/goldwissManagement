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
    public partial class frmAjouterRetour : Form
    {
        public frmAjouterRetour()
        {
            InitializeComponent();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAjouterRetour_Load(object sender, EventArgs e)
        {
            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn1.Open();
            string req = "select * from client";
            SqlCommand com1 = new SqlCommand(req, cn1);
            SqlDataReader dr1 = com1.ExecuteReader();
            DataTable table1 = new DataTable();
            table1.Load(dr1);
            cb_client.DisplayMember = "nomClient";
            cb_client.ValueMember = "idClient";
            cb_client.DataSource = table1;
            //fermeture de la datareader et la connexion et effacer la commande
            dr1.Close();
            dr1 = null;
            com1 = null;
            cn1.Close();
            cn1 = null;

            dtp_dateRetour.Value = DateTime.Today;
            txt_description.Text = "Aucun Description";
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            string reqq = "insert into retour(dateRetour,numeroBon,idClient,designation) values(@dateRetour,@numeroBon,@idClient,@designation)";
            SqlCommand com = new SqlCommand(reqq, cn);
            com.Parameters.Add(new SqlParameter("@dateRetour", dtp_dateRetour.Value));
            com.Parameters.Add(new SqlParameter("@numeroBon", txt_numeroBon.Text));
            com.Parameters.Add(new SqlParameter("@idClient", cb_client.SelectedValue));
            com.Parameters.Add(new SqlParameter("@designation", txt_description.Text));
            com.ExecuteNonQuery();
            com = null;
            cn.Close();
            cn = null;
            MessageBox.Show("Retour a été ajouter avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
