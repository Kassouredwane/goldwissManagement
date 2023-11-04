using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Input;

namespace projet_gestionEntreprise
{
    public partial class frmAfficheCommandeClient : Form
    {
        int IdClient;
        public frmAfficheCommandeClient(int idClient)
        {
            InitializeComponent();
            IdClient = idClient;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void activate(bool v)
        {
            panel1.Enabled = !v;
            panel2.Enabled = v;
        }
        private void refresh(string filtre)
        {
            if (chk_enCourLivraison.Checked)
            {
                // fill datagrid view with commandes of clients

                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn.Open();
                string req = "select c.idCommande,dateCommande,statutLivraison from commande c where idClient=" + IdClient + " and c.statutLivraison=0" + filtre;
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_commandeClient.Rows.Clear();
                while (dr.Read())
                {
                    dgv_commandeClient.Rows.Add(dr["idCommande"], dr["dateCommande"], dr["statutLivraison"]);
                }
                // close all commandes and connection and datareader
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
            }
            else
            {
                // fill datagrid view with commandes of clients

                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn.Open();
                string req = "select c.idCommande,dateCommande,statutLivraison from commande c where idClient=" + IdClient + filtre;
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_commandeClient.Rows.Clear();
                while (dr.Read())
                {
                    dgv_commandeClient.Rows.Add(dr["idCommande"], dr["dateCommande"], dr["statutLivraison"]);
                }
                // close all commandes and connection and datareader
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
            }
        }
        private void updateStatutOfLivraison()
        {
            bool anyUnchecked = false;

            foreach (DataGridViewRow row in dgv_detailCommandeClient.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells[4] as DataGridViewCheckBoxCell;

                if (cell != null && Convert.ToBoolean(cell.Value)==false)
                {
                    anyUnchecked = true;
                    break; // Exit the loop as soon as an unchecked checkbox is found
                }
            }
            ////   this continue work lundi   !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //if (!anyUnchecked)
            //{
            //    // All checkboxes are checked; update the database
            //    using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456"))
            //    {
            //        connection.Open();
            //        string updateQuery = "UPDATE Commande SET StatutLivraison = 1 WHERE YourCondition";


            //        using (SqlCommand command = new SqlCommand(updateQuery, connection))
            //        {
            //            // Add parameters or specify a condition as needed
            //            command.ExecuteNonQuery();
            //        }
            //    }
            //}
            //else
            //{

            //}

        }
        private void frmAfficheCommandeClient_Load(object sender, EventArgs e)
        {
            refresh("");
            activate(false);
            activateButton(false);
            //updateStatutOfLivraison();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            int idCommande = Convert.ToInt32(dgv_commandeClient.CurrentRow.Cells[0].Value);
            frmAjouterModeleACommande f = new frmAjouterModeleACommande(idCommande);
            f.ShowDialog();
        }

        private void frmAfficheCommandeClient_Activated(object sender, EventArgs e)
        {
            //refresh("");
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            int idCcommande = Convert.ToInt32(dgv_commandeClient.CurrentRow.Cells[0].Value);
            string refModele = dgv_detailCommandeClient.CurrentRow.Cells[0].Value.ToString();
            frmModifierDetailCommandeClient f = new frmModifierDetailCommandeClient(idCcommande, refModele);
            f.ShowDialog();
        }

        private void btn_nouveauCommande_Click(object sender, EventArgs e)
        {
            int idClient = IdClient;
            frmNouveauCommande f = new frmNouveauCommande(idClient);
            f.ShowDialog();
        }
        private void dgv_commandeClient_SelectionChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            string req = "select referenceModele,qteAchat,prixAchat,qteLivre,statutLivraison from detailCommande where idCommande=" + dgv_commandeClient.CurrentRow.Cells[0].Value;
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            dgv_detailCommandeClient.Rows.Clear();
            while (dr.Read())
            {
                dgv_detailCommandeClient.Rows.Add(dr["referenceModele"], dr["qteAchat"], dr["prixAchat"], dr["qteLivre"], dr["statutLivraison"]);
            }
            // close all commandes and connection and datareader
            dr.Close();
            dr = null;
            com = null;

            cn.Close();
            cn = null;
        }

        private void chk_enCourLivraison_CheckedChanged(object sender, EventArgs e)
        {
            refresh("");
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (dgv_commandeClient.CurrentRow != null && dgv_detailCommandeClient.CurrentRow != null)
            {
                if (MessageBox.Show("Etes-vous vraiment veux supprimer ce modele ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection cn5 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                    cn5.Open();

                    // Check if the cells are not null before accessing their Value property
                    if (dgv_commandeClient.CurrentRow.Cells[0] != null && dgv_detailCommandeClient.CurrentRow.Cells[0] != null)
                    {
                        string idCommande = dgv_commandeClient.CurrentRow.Cells[0].Value.ToString();
                        string referenceModele = dgv_detailCommandeClient.CurrentRow.Cells[0].Value.ToString();

                        string req5 = "delete from detailCommande where idCommande = @idCommande and referenceModele = @referenceModele";
                        SqlCommand com5 = new SqlCommand(req5, cn5);

                        // Use parameterized queries to prevent SQL injection
                        com5.Parameters.AddWithValue("@idCommande", idCommande);
                        com5.Parameters.AddWithValue("@referenceModele", referenceModele);

                        com5.ExecuteNonQuery();
                        com5 = null;
                    }
                    cn5.Close();
                    cn5 = null;
                    refresh("");
                }
            }
            //MessageBox.Show("idCommande : " + dgv_commandeClient.CurrentRow.Cells[0].Value + " -  referenceModele : " + dgv_detailCommandeClient.CurrentRow.Cells[0].Value);
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            refresh(" and idCommande like'%" + txt_rechercher.Text + "%'");
        }

        private void btn_refresh_Click_1(object sender, EventArgs e)
        {
            refresh("");
            txt_rechercher.Text = "";
        }

        private void btn_ajouterALivraison_Click(object sender, EventArgs e)
        {
            activate(true);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            activate(false);
        }

        private void btn_nouveauLivraison_Click(object sender, EventArgs e)
        {
            activate(true);
            txt_qteLivraison.Enabled = false;
            txt_numeroBonLivraison.Text = "";
            dtp_dateLivraison.Value = DateTime.Today;
        }
        private void fillDgvLivraisonOfCommandeSelect()
        {

        }
        private void btn_ajouterLivraison_Click(object sender, EventArgs e)
        {
            activate(false);
            // ajouter nouveau livraison avec numero bon et la date a la table livraison dans sql server
        }

        private void btn_vaider_Click(object sender, EventArgs e)
        {
            // ajouter qteLivrer & numeroBonLivraison & statutLivraison (ajouter ce colone a database)(il modifier a "true" quand le modele ajouter
            // ==> a la livraison ) a la table de detailCommande

        }

        private void dgv_commandeClient_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Check if the column corresponds to the checkbox column
                DataGridViewColumn column = dgv_commandeClient.Columns[e.ColumnIndex];
                if (column is DataGridViewCheckBoxColumn)
                {
                    // Get the updated value from the DataGridView (true/false)
                    bool updatedValue = (bool)dgv_commandeClient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    // Get the ID of the Commande from the DataGridView
                    int commandeID = Convert.ToInt32(dgv_commandeClient.Rows[e.RowIndex].Cells[0].Value);

                    // Update the database

                    //string updateQuery = "UPDATE Commande SET test = @UpdatedValue WHERE idCommande = @CommandeID";

                    //using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456"))
                    //{
                    //    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    //    {
                    //        command.Parameters.AddWithValue("@UpdatedValue", updatedValue);
                    //        command.Parameters.AddWithValue("@CommandeID", commandeID);

                    //        connection.Open();
                    //        command.ExecuteNonQuery();
                    //    }
                    //    connection.Close();
                    //}

                }
            }
        }
        private void activateButton(bool v)
        {
            btn_enregistrer.Enabled = v;
            btn_ajouterALivraison.Enabled = !v;
            btn_nouveauCommande.Enabled = !v;
            btn_modifier.Enabled = !v;
            btn_ajouter.Enabled = !v;
            btn_supprimer.Enabled = !v;
        }
        private void dgv_detailCommandeClient_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            //if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //{
            //    // Check if the column corresponds to the checkbox column
            //    DataGridViewColumn column = dgv_detailCommandeClient.Columns[e.ColumnIndex];
            //    if (column is DataGridViewCheckBoxColumn)
            //    {
            //        // Get the updated value from the DataGridView (true/false)
            //        bool updatedValue = (bool)dgv_detailCommandeClient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            //        // Get the ID of the Commande from the DataGridView
            //        int commandeID = Convert.ToInt32(dgv_detailCommandeClient.Rows[e.RowIndex].Cells["ID_Commande"].Value);

            //        // Update the database
            //        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            //        cn.Open();
            //        SqlCommand com = new SqlCommand("UPDATE Commande SET test = @UpdatedValue WHERE idCommande = @CommandeID", cn);
            //        com.Parameters.AddWithValue("@UpdatedValue", updatedValue);
            //        com.Parameters.AddWithValue("@CommandeID", commandeID);
            //        SqlDataReader dr = com.ExecuteReader();
            //        dr.Close();
            //        dr = null;
            //        com.ExecuteNonQuery();
            //        com = null;
            //        cn.Close();
            //        cn = null;
            //    }
            //}
            activateButton(true);
            updateStatutOfLivraison();

        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            activateButton(false);
        }
    }
}
