using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projet_gestionEntreprise
{
    public partial class frmGestionClients : Form
    {
        public frmGestionClients()
        {
            InitializeComponent();
        }
        private void colorOfCellsRestePayer()
        {
            foreach (DataGridViewRow row in dgv_clients.Rows)
            {
                DataGridViewTextBoxCell cell = row.Cells[6] as DataGridViewTextBoxCell;

                if (cell != null && Convert.ToInt32(cell.Value) > 0 && Convert.ToInt32(cell.Value)<=5000)
                {
                    cell.Style.BackColor = Color.Orange;
                    cell.Style.ForeColor = Color.Black;
                }
                else if (cell != null && Convert.ToInt32(cell.Value) > 2500 && Convert.ToInt32(cell.Value)<=20000)
                {
                    cell.Style.BackColor = Color.OrangeRed;
                    cell.Style.ForeColor = Color.Black;
                }
                else if (cell != null && Convert.ToInt32(cell.Value) == 0)
                {
                    cell.Style.BackColor = Color.Green;
                    cell.Style.ForeColor = Color.Black;
                }
                else if (cell != null && Convert.ToInt32(cell.Value) < 0)
                {
                    cell.Style.BackColor = Color.Yellow;
                    cell.Style.ForeColor = Color.Black;
                }
                else
                {
                    cell.Style.BackColor = Color.Red;
                    cell.Style.ForeColor = Color.Black;
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void frmGestionClients_Activated(object sender, EventArgs e)
        {
            cb_villeClient.Items.Clear();
            cb_villeClient.Items.Add("Tous les villes");

            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn1.Open();
            string req = "select * from ville";
            SqlCommand com = new SqlCommand(req, cn1);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                string nomVille = dr["nomVille"].ToString();
                cb_villeClient.Items.Add(nomVille);
            }
            dr.Close();
            dr = null;
            com = null;

            cn1.Close();
            cn1 = null;
            colorOfCellsRestePayer();
        }
        private void frmGestionClients_Load(object sender, EventArgs e)
        {
            // fill combobx of ville client
            cb_villeClient.Items.Add("Tous les villes");

            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn1.Open();
            string req = "select * from ville";
            SqlCommand com = new SqlCommand(req, cn1);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                string nomVille = dr["nomVille"].ToString();
                cb_villeClient.Items.Add(nomVille);
            }
            dr.Close();
            dr = null;
            com = null;

            cn1.Close();
            cn1 = null;

            cb_classement.SelectedIndex = 0;
            cb_recherche.SelectedIndex = 0;
            cb_villeClient.SelectedIndex = 0;

            filtreClassement("");
        }
        private void fillDgvClient(string filtre,string orderBy)
        {
            try
            {
                if (cb_villeClient.Text == "Tous les villes")
                {
                    SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                    cn.Open();
                    string req = "select idClient,nomClient,prenomClient,telephoneClient,adresseClient,restePayer,nomVille from client c inner join ville v on v.idVille=c.idVille " + filtre + " order by " + orderBy;
                    SqlCommand com = new SqlCommand(req, cn);
                    SqlDataReader dr = com.ExecuteReader();
                    dgv_clients.Rows.Clear();
                    while (dr.Read())
                    {
                        dgv_clients.Rows.Add(dr["idClient"], dr["nomClient"], dr["prenomClient"], dr["telephoneClient"], dr["adresseClient"], dr["nomVille"], dr["restePayer"]);
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
                    string req = "select idClient,nomClient,prenomClient,telephoneClient,adresseClient,restePayer,nomVille from client c inner join ville v on v.idVille=c.idVille where c.idVille = (select idVille from ville  where nomVille='" + cb_villeClient.Text+"')  " + filtre + " order by " + orderBy;
                    SqlCommand com = new SqlCommand(req, cn);
                    SqlDataReader dr = com.ExecuteReader();
                    dgv_clients.Rows.Clear();
                    while (dr.Read())
                    {
                        dgv_clients.Rows.Add(dr["idClient"], dr["nomClient"], dr["prenomClient"], dr["telephoneClient"], dr["adresseClient"], dr["nomVille"], dr["restePayer"]);
                    }
                    dr.Close();
                    dr = null;
                    com = null;

                    cn.Close();
                    cn = null;
                }
            }
            catch (Exception error) { MessageBox.Show(error.Message.ToString()); }
            colorOfCellsRestePayer();

        }
        private void rechercheClient()
        {
            switch (cb_recherche.SelectedIndex)
            {
                case 0:
                    if (cb_villeClient.Text == "Tous les villes") filtreClassement("where idClient = " + txt_rechercher.Text);
                    else filtreClassement(" and idClient = " + txt_rechercher.Text);
                    break;
                case 1:
                    if (cb_villeClient.Text == "Tous les villes") filtreClassement("where nomClient like '%" + txt_rechercher.Text + "%'");
                    else filtreClassement(" and nomClient like '%" + txt_rechercher.Text + "%'");
                    break;
                case 2:
                    if (cb_villeClient.Text == "Tous les villes") filtreClassement("where prenomClient like '%" + txt_rechercher.Text + "%'");
                    else filtreClassement(" and prenomClient like '%" + txt_rechercher.Text + "%'");
                    break;
                case 3:
                    if (cb_villeClient.Text == "Tous les villes") filtreClassement("where telephoneClient like '%" + txt_rechercher.Text + "%'");
                    else filtreClassement(" and telephoneClient like '%" + txt_rechercher.Text + "%'");
                    break;
            }
        }
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            frmAjouterClient f = new frmAjouterClient();
            f.ShowDialog();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            int idClient = Convert.ToInt32(dgv_clients.CurrentRow.Cells[0].Value);
            frmModifierClient f = new frmModifierClient(idClient);
            f.ShowDialog();
        }

        private void btn_afficherCommandes_Click(object sender, EventArgs e)
        {
            int idClient = Convert.ToInt32(dgv_clients.CurrentRow.Cells[0].Value);
            frmAfficheCommandeClient f = new frmAfficheCommandeClient(idClient);
            f.ShowDialog();
        }

        private void cb_villeClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtreClassement("");
            txt_rechercher.Text = "";
        }
        private void filtreClassement(string filtre)
        {
            switch (cb_classement.SelectedIndex)
            {
                case 0:
                    fillDgvClient(filtre,"idClient asc");
                    break;
                case 1:
                    fillDgvClient(filtre, "idClient desc");
                    break;
                case 2:
                    fillDgvClient(filtre, "nomClient asc");
                    break;
                case 3:
                    fillDgvClient(filtre, "nomClient desc");
                    break;
            }
        }
        private void cb_classement_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtreClassement("");
            txt_rechercher.Text = "";
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            try
            {
                if(cb_classement.SelectedIndex == 0 && txt_rechercher.Text=="")
                {
                    filtreClassement("");
                }
                else
                {
                    rechercheClient();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_rechercher_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) btn_rechercher.PerformClick();
        }
        /// <summary>
        /// ////////////
        /// </summary>
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            cb_villeClient.Items.Clear();
            cb_villeClient.Items.Add("Tous les villes");

            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn1.Open();
            string req = "select * from ville";
            SqlCommand com = new SqlCommand(req, cn1);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                string nomVille = dr["nomVille"].ToString();
                cb_villeClient.Items.Add(nomVille);
            }
            dr.Close();
            dr = null;
            com = null;

            cn1.Close();
            cn1 = null;

            filtreClassement("");
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous vraiment veux supprimer ce client ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn.Open();
                string req = "delete from client where idClient=" + dgv_clients.CurrentRow.Cells[0].Value;
                SqlCommand com = new SqlCommand(req, cn);
                com.ExecuteNonQuery();
                com = null;
                cn.Close();
                cn = null;
                filtreClassement("");
            }
        }

        private void btn_afficherLivraison_Click(object sender, EventArgs e)
        {
            int idClient = Convert.ToInt32(dgv_clients.CurrentRow.Cells[0].Value);
            frmAfficheLivraisonClient f = new frmAfficheLivraisonClient(idClient);
            f.ShowDialog();
        }

        private void btn_ajouterTransaction_Click(object sender, EventArgs e)
        {
            int idClient = Convert.ToInt32(dgv_clients.CurrentRow.Cells[0].Value);
            frmAjouterTransactionAClient f = new frmAjouterTransactionAClient(idClient);
            f.ShowDialog();
        }
    }
}
