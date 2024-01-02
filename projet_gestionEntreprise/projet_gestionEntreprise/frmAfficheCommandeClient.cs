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
using CrystalDecisions.CrystalReports.Engine;

namespace projet_gestionEntreprise
{
    public partial class frmAfficheCommandeClient : Form
    {
        int IdClient;
        //private ConnectionManager connectionManager;
        public frmAfficheCommandeClient(int idClient)
        {
            InitializeComponent();
            IdClient = idClient;
            //connectionManager = new ConnectionManager();
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

                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string req = "select c.idCommande,dateCommande,statutLivraison from commande c where idClient=" + IdClient + " and c.statutLivraison=0" + filtre+" order by c.idCommande desc";
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

                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string req = "select c.idCommande,dateCommande,statutLivraison from commande c where idClient=" + IdClient + filtre+ " order by c.idCommande desc";
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
                DataGridViewCheckBoxCell cell = row.Cells[3] as DataGridViewCheckBoxCell;

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

                    using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456"))
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

                    using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456"))
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
        int dgvCommandeClientIndexSelected;
        private void dgv_commandeClient_SelectionChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            string req = "select referenceModele,qteAchat,prixAchat,statutLivraison from detailCommande where idCommande=" + dgv_commandeClient.CurrentRow.Cells[0].Value;
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            dgv_detailCommandeClient.Rows.Clear();
            while (dr.Read())
            {
                dgv_detailCommandeClient.Rows.Add(dr["referenceModele"], dr["qteAchat"], dr["prixAchat"], dr["statutLivraison"]);
            }
            // close all commandes and connection and datareader
            dr.Close();
            dr = null;
            com = null;

            cn.Close();
            cn = null;

            // Fill datagrid view of livraison of commande
            SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn2.Open();
            //string req2 = "select dc.idLivraison, l.numeroBonLivraison,dateLivraison,idCommande,m.referenceModele,designation,prixAchat,qteLivre,prixAchat*qteLivre as totale from livraison l inner join detailCommande dc on dc.idLivraison=l.idLivraison inner join modele m on m.referenceModele=dc.referenceModele where idCommande=" + dgv_commandeClient.CurrentRow.Cells[0].Value;
            string req2 = " SELECT l.idLivraison, numeroBonLivraison,dateLivraison,m.referenceModele,designation,SUM(dl.qteLivre) AS totalQuantity,SUM(dc.prixAchat * dl.qteLivre) AS totale FROM livraison l INNER JOIN detailLivraison dl ON dl.idLivraison = l.idLivraison INNER JOIN matla mt ON mt.idMatla = dl.idMatla INNER JOIN modele m ON m.referenceModele = mt.referenceModele INNER JOIN detailCommande dc ON dc.idCommande = l.idCommande AND dc.referenceModele = m.referenceModele WHERE l.idCommande = "+dgv_commandeClient.CurrentRow.Cells[0].Value+ " GROUP BY l.idLivraison,numeroBonLivraison,dateLivraison,m.referenceModele,designation";
            SqlCommand com2 = new SqlCommand(req2, cn2);
            SqlDataReader dr2 = com2.ExecuteReader();
            dgv_livraison.Rows.Clear();
            while (dr2.Read())
            {
                dgv_livraison.Rows.Add(dr2["idLivraison"], dr2["numeroBonLivraison"], dr2["designation"], Convert.ToDateTime(dr2["dateLivraison"].ToString()).ToShortDateString(), dr2["totalQuantity"], dr2["totale"]);
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
                    SqlConnection cn5 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
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
            refresh(" and idCommande=" + txt_rechercher.Text + " or dateCommande like '%"+ txt_rechercher.Text + "%'");
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
            //txt_idMatla.Enabled = true;
            cb_matla.Enabled = true;
            txt_qteLivraison.Focus();
            dtp_dateLivraison.Enabled = false;
            btn_ajouterLivraison.Enabled=false;
            btn_vaider.Enabled = true;
            txt_qteLivraison.Text = "";
            //btn_ajouterALivraison.Enabled = false;
            SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn2.Open();
            string req2 = "select idMatla from matla where statutTerminer=0 and referenceModele='"+dgv_detailCommandeClient.CurrentRow.Cells[0].Value+"'";
            SqlCommand com2 = new SqlCommand(req2, cn2);
            SqlDataReader dr2 = com2.ExecuteReader();
            DataTable table2 = new DataTable();
            table2.Load(dr2);
            cb_matla.DisplayMember = "idMatla";
            cb_matla.ValueMember = "idMatla";
            cb_matla.DataSource = table2;
            dr2.Close();
            dr2 = null;
            com2 = null;

            cn2.Close();
            cn2 = null;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            activate(false);
            updateStatutLivraisonOfLivraison();
        }

        private void btn_nouveauLivraison_Click(object sender, EventArgs e)
        {
            activate(true);
            txt_qteLivraison.Enabled = false;
            //txt_idMatla.Enabled = false;
            cb_matla.Enabled = false;
            txt_numeroBonLivraison.Text = "";
            txt_numeroBonLivraison.ReadOnly = false;
            dtp_dateLivraison.Value = DateTime.Today;
            dtp_dateLivraison.Enabled = true;
            btn_ajouterLivraison.Enabled = true;

            btn_vaider.Enabled = false;
            try
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                SqlCommand com = new SqlCommand("select max(idLivraison)+1 from livraison", cn);
                int nb = Convert.ToInt32(com.ExecuteScalar());

                txt_idLivraison.Text = nb.ToString();
                com = null;
                cn.Close();
                cn = null;
            }
            catch(Exception error) { txt_idLivraison.Text = "1"; }
        }
        private void btn_ajouterLivraison_Click(object sender, EventArgs e)
        {
            activate(false);
            bool existe = false;
            // ajouter nouveau livraison avec numero bon et la date a la table livraison dans sql server
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            string reqq = "insert into livraison(numeroBonLivraison,dateLivraison,idCommande) values(@numeroBonLivraison,@dateLivraison,@idCommande)";
            SqlCommand com = new SqlCommand(reqq, cn);
            com.Parameters.Add(new SqlParameter("@numeroBonLivraison", txt_numeroBonLivraison.Text));
            com.Parameters.Add(new SqlParameter("@dateLivraison", dtp_dateLivraison.Value));
            com.Parameters.Add(new SqlParameter("@idCommande", dgv_commandeClient.CurrentRow.Cells[0].Value));
            com.ExecuteNonQuery();

            com = null;
            cn.Close();
            cn = null;
            MessageBox.Show("la livraison a été ajouter avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
        }

        private void btn_vaider_Click(object sender, EventArgs e)
        {
            try
            {
                // checker la quantiter entrer de livraison est inférieure que la quantte en stock
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                SqlCommand com = new SqlCommand("select qteStock from matla mt where mt.idMatla=" + cb_matla.SelectedValue, cn);
                int qte = Convert.ToInt32(com.ExecuteScalar());
                if (qte >= Convert.ToInt32(txt_qteLivraison.Text))
                {
                    // ajouter qteLivrer & numeroBonLivraison & statutLivraison (ajouter ce colone a database)(il modifier a "true" quand le modele ajouter
                    // ==> a la livraison ) a la table de detailCommande
                    SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                    cn2.Open();
                    string reqq2 = "insert into detailLivraison values(@idLivraison,@idMatla,@qteLivre)";
                    SqlCommand com2 = new SqlCommand(reqq2, cn2);
                    com2.Parameters.Add(new SqlParameter("@idLivraison", txt_idLivraison.Text));
                    com2.Parameters.Add(new SqlParameter("@idMatla", cb_matla.SelectedValue));
                    com2.Parameters.Add(new SqlParameter("@qteLivre", txt_qteLivraison.Text));
                    com2.ExecuteNonQuery();
                    
                    com2 = null;
                    cn2.Close();
                    cn2 = null;
                    // update la quantite en stock de modele valider a la livraison par qte-qteLivre
                    SqlConnection cn3 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                    cn3.Open();
                    string reqq3 = "update matla set qteStock=(qteStock-" + Convert.ToInt32(txt_qteLivraison.Text) + ") where idMatla=@idMatla";
                    SqlCommand com3 = new SqlCommand(reqq3, cn3);
                    com3.Parameters.Add(new SqlParameter("@idMatla", cb_matla.SelectedValue));
                    com3.ExecuteNonQuery();

                    com3 = null;
                    cn3.Close();
                    cn3 = null;
                    // update le statut terminer de matla si la qteStock = 0
                    if (qte - Convert.ToInt32(txt_qteLivraison.Text) == 0)
                    {
                        SqlConnection cn4 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                        cn4.Open();
                        string reqq4 = "update matla set statutTerminer=1 where idMatla=@idMatla";
                        SqlCommand com4 = new SqlCommand(reqq4, cn4);
                        com4.Parameters.Add(new SqlParameter("@idMatla", cb_matla.SelectedValue));
                        com4.ExecuteNonQuery();

                        com4 = null;
                        cn4.Close();
                        cn4 = null;
                    }
                    // update le reste payer de client
                    SqlConnection cn6 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                    cn6.Open();
                    string reqq6 = "update client set restePayer=restePayer+@qte*@prix where idClient=" + IdClient;
                    SqlCommand com6 = new SqlCommand(reqq6, cn6);
                    com6.Parameters.Add(new SqlParameter("@qte", txt_qteLivraison.Text));
                    com6.Parameters.Add(new SqlParameter("@prix", dgv_detailCommandeClient.CurrentRow.Cells[2].Value));
                    com6.ExecuteNonQuery();
                    com6 = null;
                    cn6.Close();
                    cn6 = null;

                    MessageBox.Show("la livraison a été ajouter avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_detailCommandeClient.CurrentRow.Cells[3].Value = true;
                    updateStatutLivraisonOfLivraison();
                }
                else MessageBox.Show("la quantite qui vous avez saisi est inférieure a la quantite en stock de Matla contient - Quantite en stock : " + qte, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                com = null;
                cn.Close();
                cn = null;
            }
            catch (Exception error) { MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            // Fill datagrid view of livraison of commande
            SqlConnection cn5 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn5.Open();
            //string req2 = "select dc.idLivraison, l.numeroBonLivraison,dateLivraison,idCommande,m.referenceModele,designation,prixAchat,qteLivre,prixAchat*qteLivre as totale from livraison l inner join detailCommande dc on dc.idLivraison=l.idLivraison inner join modele m on m.referenceModele=dc.referenceModele where idCommande=" + dgv_commandeClient.CurrentRow.Cells[0].Value;
            string req5 = " SELECT l.idLivraison, numeroBonLivraison,dateLivraison,m.referenceModele,designation,SUM(dl.qteLivre) AS totalQuantity,SUM(dc.prixAchat * dl.qteLivre) AS totale FROM livraison l INNER JOIN detailLivraison dl ON dl.idLivraison = l.idLivraison INNER JOIN matla mt ON mt.idMatla = dl.idMatla INNER JOIN modele m ON m.referenceModele = mt.referenceModele INNER JOIN detailCommande dc ON dc.idCommande = l.idCommande AND dc.referenceModele = m.referenceModele WHERE l.idCommande = " + dgv_commandeClient.CurrentRow.Cells[0].Value + " GROUP BY l.idLivraison,numeroBonLivraison,dateLivraison,m.referenceModele,designation";
            SqlCommand com5 = new SqlCommand(req5, cn5);
            SqlDataReader dr5 = com5.ExecuteReader();
            dgv_livraison.Rows.Clear();
            while (dr5.Read())
            {
                dgv_livraison.Rows.Add(dr5["idLivraison"], dr5["numeroBonLivraison"], dr5["designation"], Convert.ToDateTime(dr5["dateLivraison"].ToString()).ToShortDateString(), dr5["totalQuantity"], dr5["totale"]);
            }
            // close all commandes and connection and datareader
            dr5.Close();
            dr5 = null;
            com5 = null;

            cn5.Close();
            cn5 = null;
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
                    SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
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
                    SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
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
        private void imprimer(ReportClass cr, string chemain = "", string filtre = "")
        {
            cr.SetDatabaseLogon("sa", "123456");
            if (chemain != "")
                cr.SetParameterValue("chemain", chemain);

            frmImpression f = new frmImpression(cr, filtre);    
            f.ShowDialog();
        }
        private void btn_imprimerLivraison_Click(object sender, EventArgs e)
        {
            string filtre = "{livraison.idLivraison}="+dgv_livraison.CurrentRow.Cells[0].Value;
            imprimer(new BonLivraisonClient(), "", filtre);
        }
    }
}
