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
using System.Net.Sockets;

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
                    dgv_commandeClient.Rows.Add(dr["idCommande"], Convert.ToDateTime(dr["dateCommande"].ToString()).ToShortDateString(), dr["statutLivraison"]);
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
                    dgv_commandeClient.Rows.Add(dr["idCommande"], Convert.ToDateTime(dr["dateCommande"].ToString()).ToShortDateString(), dr["statutLivraison"]);
                }
                // close all commandes and connection and datareader
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
            }
        }
        private void updateStatutLivraisonOfLivraison()
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
            if (!anyUnchecked)
            {
                if (dgv_commandeClient.CurrentRow != null)
                {
                    int idCommande = Convert.ToInt32(dgv_commandeClient.CurrentRow.Cells[0].Value);

                    using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456"))
                    {
                        cn.Open();
                        using (SqlCommand com = new SqlCommand("UPDATE Commande SET statutLivraison = 1 WHERE idCommande = @idCommande", cn))
                        {
                            com.Parameters.AddWithValue("@idCommande", idCommande);
                            com.ExecuteNonQuery();
                        }
                    }
                    dgv_commandeClient.CurrentRow.Cells[2].Value = true;
                }
            }
            else
            {
                if (dgv_commandeClient.CurrentRow != null)
                {
                    int idCommande = Convert.ToInt32(dgv_commandeClient.CurrentRow.Cells[0].Value);

                    using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456"))
                    {
                        cn.Open();
                        using (SqlCommand com = new SqlCommand("UPDATE Commande SET statutLivraison = 0 WHERE idCommande = @idCommande", cn))
                        {
                            com.Parameters.AddWithValue("@idCommande", idCommande);
                            com.ExecuteNonQuery();
                        }
                    }
                    dgv_commandeClient.CurrentRow.Cells[2].Value = false;
                }
            }

        }
        private void frmAfficheCommandeClient_Load(object sender, EventArgs e)
        {
            refresh("");
            activate(false);
            //updateStatutOfLivraison();
            //updateStatutLivraisonOfLivraison(); 
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            int idCommande = Convert.ToInt32(dgv_commandeClient.CurrentRow.Cells[0].Value);
            frmAjouterModeleACommande f = new frmAjouterModeleACommande(idCommande);
            f.ShowDialog();
        }

        private void frmAfficheCommandeClient_Activated(object sender, EventArgs e)
        {
            refresh("");
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
        int dgvCommandeClientIndexSelected;
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

            // Fill datagrid view of livraison of commande
            SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn2.Open();
            string req2 = "select dc.idLivraison, l.numeroBonLivraison,dateLivraison,idCommande,m.referenceModele,designation,prixAchat,qteLivre,prixAchat*qteLivre as totale from livraison l inner join detailCommande dc on dc.idLivraison=l.idLivraison inner join modele m on m.referenceModele=dc.referenceModele where idCommande=" + dgv_commandeClient.CurrentRow.Cells[0].Value;
            SqlCommand com2 = new SqlCommand(req2, cn2);
            SqlDataReader dr2 = com2.ExecuteReader();
            dgv_livraison.Rows.Clear();
            while (dr2.Read())
            {
                dgv_livraison.Rows.Add(dr2["idLivraison"], dr2["numeroBonLivraison"], dr2["designation"], Convert.ToDateTime(dr2["dateLivraison"].ToString()).ToShortDateString(), dr2["prixAchat"], dr2["qteLivre"], dr2["totale"]);
            }
            // close all commandes and connection and datareader
            dr2.Close();
            dr2 = null;
            com2 = null;

            cn2.Close();
            cn2 = null;
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
            refresh(" and idCommande like'%" + txt_rechercher.Text + "%' or dateCommande='"+ txt_rechercher.Text + "'");
        }

        private void btn_refresh_Click_1(object sender, EventArgs e)
        {
            refresh("");
            txt_rechercher.Text = "";
            if (dgvCommandeClientIndexSelected >= 0 && dgvCommandeClientIndexSelected < dgv_commandeClient.Rows.Count)
            {
                dgv_commandeClient.Rows[dgvCommandeClientIndexSelected].Selected = true;
            }
        }

        private void btn_ajouterALivraison_Click(object sender, EventArgs e)
        {
            activate(true);
            txt_qteLivraison.Enabled = true;
            txt_numeroBonLivraison.ReadOnly = true;
            txt_qteLivraison.Focus();
            dtp_dateLivraison.Enabled = false;
            btn_ajouterLivraison.Enabled=false;
            btn_vaider.Enabled = true;
            txt_qteLivraison.Text = "";
            //btn_ajouterALivraison.Enabled = false;
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
            btn_vaider.Enabled = false;
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            SqlCommand com = new SqlCommand("select max(idLivraison)+1 from livraison", cn);
            int nb = Convert.ToInt32(com.ExecuteScalar());

            txt_idLivraison.Text = nb.ToString();
            com = null;
            cn.Close();
            cn = null;
        }
        private void btn_ajouterLivraison_Click(object sender, EventArgs e)
        {
            activate(false);
            bool existe = false;
            // ajouter nouveau livraison avec numero bon et la date a la table livraison dans sql server
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            string reqq = "insert into livraison values(@numeroBonLivraison,@dateLivraison,@idClient)";
            SqlCommand com = new SqlCommand(reqq, cn);
            com.Parameters.Add(new SqlParameter("@numeroBonLivraison", txt_numeroBonLivraison.Text));
            com.Parameters.Add(new SqlParameter("@dateLivraison", dtp_dateLivraison.Value));
            com.Parameters.Add(new SqlParameter("@idClient", IdClient));
            com.ExecuteNonQuery();

            com = null;
            cn.Close();
            cn = null;
            MessageBox.Show("la livraison a été ajouter avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
        }

        private void btn_vaider_Click(object sender, EventArgs e)
        {
            //try
            //{
                // checker la quantiter entrer de livraison est inférieure que la quantte en stock
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn.Open();
                SqlCommand com = new SqlCommand("select qteStock from modele m where referenceModele='" + dgv_detailCommandeClient.CurrentRow.Cells[0].Value + "'", cn);
                int qte = Convert.ToInt32(com.ExecuteScalar());
                if (qte > Convert.ToInt32(txt_qteLivraison.Text))
                {
                    // ajouter qteLivrer & numeroBonLivraison & statutLivraison (ajouter ce colone a database)(il modifier a "true" quand le modele ajouter
                    // ==> a la livraison ) a la table de detailCommande
                    SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                    cn2.Open();
                    string reqq2 = "update detailCommande set qteLivre=@qteLivre,idLivraison=@idLivraison,statutLivraison=1 where detailCommande.idCommande=" + dgv_commandeClient.CurrentRow.Cells[0].Value + " and referenceModele='" + dgv_detailCommandeClient.CurrentRow.Cells[0].Value + "'";
                    SqlCommand com2 = new SqlCommand(reqq2, cn2);
                    com2.Parameters.Add(new SqlParameter("@qteLivre", txt_qteLivraison.Text));
                    com2.Parameters.Add(new SqlParameter("@idLivraison", txt_idLivraison.Text));
                    com2.ExecuteNonQuery();

                    com2 = null;
                    cn2.Close();
                    cn2 = null;
                    // update la quantite en stock de modele valider a la livraison par qte-qteLivre
                    SqlConnection cn3 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                    cn3.Open();
                    string reqq3 = "update modele set qteStock=(qteStock-" + Convert.ToInt32(txt_qteLivraison.Text) + ") where referenceModele=@referenceModele";
                    SqlCommand com3 = new SqlCommand(reqq3, cn3);
                    com3.Parameters.Add(new SqlParameter("@referenceModele", dgv_detailCommandeClient.CurrentRow.Cells[0].Value));
                    com3.ExecuteNonQuery();

                    com3 = null;
                    cn3.Close();
                    cn3 = null;
                    MessageBox.Show("la livraison a été ajouter avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_detailCommandeClient.CurrentRow.Cells[4].Value = true;
                    updateStatutLivraisonOfLivraison();
                }
                else MessageBox.Show("la quantite qui vous avez saisi est inférieure a la quantite en stock - Quantite en stock : " + qte, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                com = null;
                cn.Close();
                cn = null;
            //}
            //catch (Exception error) { MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
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
                    SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                    cn.Open();
                    SqlCommand com = new SqlCommand("UPDATE Commande SET statutLivraison = @UpdatedValue WHERE idCommande = @idCommande", cn);
                    com.Parameters.AddWithValue("@UpdatedValue", updatedValue);
                    com.Parameters.AddWithValue("@idCommande", commandeID);
                    SqlDataReader dr = com.ExecuteReader();
                    dr.Close();
                    dr = null;
                    com.ExecuteNonQuery();
                    com = null;
                    cn.Close();
                    cn = null;
                }
            }
        }
        private void dgv_detailCommandeClient_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Check if the column corresponds to the checkbox column
                DataGridViewColumn column = dgv_detailCommandeClient.Columns[e.ColumnIndex];
                if (column is DataGridViewCheckBoxColumn)
                {
                    // Get the updated value from the DataGridView (true/false)
                    bool updatedValue = (bool)dgv_detailCommandeClient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    // Get the ID of the Commande from the DataGridView
                    string referenceModele = dgv_detailCommandeClient.Rows[e.RowIndex].Cells[0].Value.ToString();

                    // Update the database
                    SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                    cn.Open();
                    SqlCommand com = new SqlCommand("UPDATE detailCommande SET statutLivraison = @UpdatedValue WHERE idCommande = @idCommande and referenceModele=@referenceModele", cn);
                    com.Parameters.AddWithValue("@UpdatedValue", updatedValue);
                    com.Parameters.AddWithValue("@idCommande", dgv_commandeClient.CurrentRow.Cells[0].Value);
                    com.Parameters.AddWithValue("@referenceModele", referenceModele);
                    SqlDataReader dr = com.ExecuteReader();
                    dr.Close();
                    dr = null;
                    com.ExecuteNonQuery();
                    com = null;
                    cn.Close();
                    cn = null;
                }
            }
            updateStatutLivraisonOfLivraison();
        }
    }
}
