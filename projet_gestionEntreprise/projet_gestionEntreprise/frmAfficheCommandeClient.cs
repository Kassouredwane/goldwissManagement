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
                string req = "select c.idCommande,dateCommande,designation,statutLivraison from commande c where idClient=" + IdClient + " and c.statutLivraison=0" + filtre+" order by c.idCommande desc";
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_commandeClient.Rows.Clear();
                while (dr.Read())
                {
                    dgv_commandeClient.Rows.Add(dr["idCommande"], Convert.ToDateTime(dr["dateCommande"].ToString()).ToShortDateString(), dr["designation"], dr["statutLivraison"]);
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
                string req = "select c.idCommande,dateCommande,designation,statutLivraison from commande c where idClient=" + IdClient + filtre+ " order by c.idCommande desc";
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_commandeClient.Rows.Clear();
                while (dr.Read())
                {
                    dgv_commandeClient.Rows.Add(dr["idCommande"], Convert.ToDateTime(dr["dateCommande"].ToString()).ToShortDateString(), dr["designation"], dr["statutLivraison"]);
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
                DataGridViewCheckBoxCell cell = row.Cells[5] as DataGridViewCheckBoxCell;

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
                    dgv_commandeClient.CurrentRow.Cells[3].Value = true;
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
                    dgv_commandeClient.CurrentRow.Cells[3].Value = false;
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
            int idDetailCommande = Convert.ToInt32(dgv_detailCommandeClient.CurrentRow.Cells[0].Value);
            frmModifierDetailCommandeClient f = new frmModifierDetailCommandeClient(idDetailCommande);
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
            string req = "select dc.idDetailCommande,dc.referenceModele,m.designation,qteAchat,prixAchat,statutLivraison,soldeLivraison from detailCommande dc inner join modele m on m.referenceModele=dc.referenceModele where idCommande=" + dgv_commandeClient.CurrentRow.Cells[0].Value;
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            dgv_detailCommandeClient.Rows.Clear();
            while (dr.Read())
            {
                dgv_detailCommandeClient.Rows.Add(dr["idDetailCommande"], dr["referenceModele"], dr["designation"], dr["qteAchat"], dr["prixAchat"], dr["statutLivraison"], dr["soldeLivraison"]);
            }
            // close all commandes and connection and datareader
            dr.Close();
            dr = null;
            com = null;

            cn.Close();
            cn = null;

            /// µµµµµµµµµµµµ§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§
            /// µµµµµµµµµµµµ§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§
            //// Fill datagrid view of livraison of commande
            //SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //cn2.Open();
            ////string req2 = "select dc.idLivraison, l.numeroBonLivraison,dateLivraison,idCommande,m.referenceModele,designation,prixAchat,qteLivre,prixAchat*qteLivre as totale from livraison l inner join detailCommande dc on dc.idLivraison=l.idLivraison inner join modele m on m.referenceModele=dc.referenceModele where idCommande=" + dgv_commandeClient.CurrentRow.Cells[0].Value;
            //string req2 = " SELECT l.idLivraison, numeroBonLivraison,dateLivraison,m.referenceModele,designation,SUM(dl.qteLivre) AS totalQuantity,SUM(dc.prixAchat * dl.qteLivre) AS totale FROM livraison l INNER JOIN detailLivraison dl ON dl.idLivraison = l.idLivraison INNER JOIN matla mt ON mt.idMatla = dl.idMatla INNER JOIN modele m ON m.referenceModele = mt.referenceModele INNER JOIN detailCommande dc ON dc.idCommande = l.idCommande AND dc.referenceModele = m.referenceModele WHERE l.idCommande = "+dgv_commandeClient.CurrentRow.Cells[0].Value+ " GROUP BY l.idLivraison,numeroBonLivraison,dateLivraison,m.referenceModele,designation";
            //SqlCommand com2 = new SqlCommand(req2, cn2);
            //SqlDataReader dr2 = com2.ExecuteReader();
            //dgv_livraison.Rows.Clear();
            //while (dr2.Read())
            //{
            //    dgv_livraison.Rows.Add(dr2["idLivraison"], dr2["numeroBonLivraison"], dr2["designation"], Convert.ToDateTime(dr2["dateLivraison"].ToString()).ToShortDateString(), dr2["totalQuantity"], dr2["totale"]);
            //}
            //// close all commandes and connection and datareader
            //dr2.Close();
            //dr2 = null;
            //com2 = null;

            //cn2.Close();
            //cn2 = null;
            /// µµµµµµµµµµµµ§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§
            /// µµµµµµµµµµµµ§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§
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
                        //string idCommande = dgv_commandeClient.CurrentRow.Cells[0].Value.ToString();
                        //string referenceModele = dgv_detailCommandeClient.CurrentRow.Cells[0].Value.ToString();

                        string req5 = "delete from detailCommande where idDetailCommande = @idDetailCommande";
                        SqlCommand com5 = new SqlCommand(req5, cn5);

                        // Use parameterized queries to prevent SQL injection
                        com5.Parameters.AddWithValue("@idDetailCommande", dgv_detailCommandeClient.CurrentRow.Cells[0].Value);
                        //com5.Parameters.AddWithValue("@referenceModele", referenceModele);

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
            txt_designationDetail.Enabled = true;
            txt_qteLivraison.Focus();
            dtp_dateLivraison.Enabled = false;
            btn_ajouterLivraison.Enabled=false;
            txt_prixVente.Enabled = true;
            btn_vaider.Enabled = true;
            txt_qteLivraison.Text = "";
            txt_prixVente.Text = dgv_detailCommandeClient.CurrentRow.Cells[4].Value.ToString();
            //btn_ajouterALivraison.Enabled = false;

            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn1.Open();
            string req = "select * from matla where referenceModele='"+dgv_detailCommandeClient.CurrentRow.Cells[1].Value+"' and statutTerminer=0 order by idSituationModele desc";
            SqlCommand com1 = new SqlCommand(req, cn1);
            SqlDataReader dr1 = com1.ExecuteReader();
            DataTable table1 = new DataTable();
            table1.Load(dr1);
            cb_idMatla.DisplayMember = "idMatla";
            cb_idMatla.ValueMember = "idMatla";
            cb_idMatla.DataSource = table1;
            //fermeture de la datareader et la connexion et effacer la commande
            dr1.Close();
            dr1 = null;
            com1 = null;
            cn1.Close();
            cn1 = null;
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
            txt_designationDetail.Enabled = true;
            txt_designationDetail.Text = "Aucun Description";
            txt_numeroBonLivraison.Text = "";
            txt_numeroBonLivraison.ReadOnly = false;
            dtp_dateLivraison.Value = DateTime.Today;
            dtp_dateLivraison.Enabled = true;
            btn_ajouterLivraison.Enabled = true;
            txt_prixVente.Enabled = false;

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

            // retreive le max de la situation client
            SqlConnection cn8 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn8.Open();
            SqlCommand com8 = new SqlCommand("select max(idSituationClient) from situationClient where idClient=" + IdClient, cn8);
            int situationClient = Convert.ToInt32(com8.ExecuteScalar());

            com8 = null;
            cn8.Close();
            cn8 = null;

            // ajouter nouveau livraison avec numero bon et la date a la table livraison dans sql server
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            string reqq = "insert into livraison(idLivraison,numeroBonLivraison,dateLivraison,designation,idSituationClient) values(@idLivraison,@numeroBonLivraison,@dateLivraison,@designation,@idSituationClient)";
            SqlCommand com = new SqlCommand(reqq, cn);
            com.Parameters.Add(new SqlParameter("@idLivraison", txt_idLivraison.Text));
            com.Parameters.Add(new SqlParameter("@numeroBonLivraison", txt_numeroBonLivraison.Text));
            com.Parameters.Add(new SqlParameter("@dateLivraison", dtp_dateLivraison.Value));
            com.Parameters.Add(new SqlParameter("@designation", txt_designationDetail.Text));
            com.Parameters.Add(new SqlParameter("@idSituationClient", situationClient));
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
            //////////////////////////////////////////////////////////////////////////////////////////
            /// Pour la situation de modele
            //////////////////////////////////////////////////////////////////////////////////////////

            //// checker la quantiter entrer de livraison est inférieure que la quantte en stock
            //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //cn.Open();
            //SqlCommand com = new SqlCommand("select qteStock from modele m where m.referenceModele='"+dgv_detailCommandeClient.CurrentRow.Cells[1].Value+"'" , cn);
            //int qte = Convert.ToInt32(com.ExecuteScalar());
            //if (qte >= Convert.ToInt32(txt_qteLivraison.Text))
            //{
            //// retreive la max de la situation modele
            //SqlConnection cn7 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //cn7.Open();
            //SqlCommand com7 = new SqlCommand("select max(idSituationModele) from situationModele where referenceModele='" + dgv_detailCommandeClient.CurrentRow.Cells[1].Value + "'", cn7);
            //int situationModele = Convert.ToInt32(com7.ExecuteScalar());

            //com7 = null;
            //cn7.Close();
            //cn7 = null;


            ////// retreive le max de la situation client
            ////SqlConnection cn8 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            ////cn8.Open();
            ////SqlCommand com8 = new SqlCommand("select max(idSituationClient) from situationClient where idClient" + IdClient, cn8);
            ////int situationClient = Convert.ToInt32(com8.ExecuteScalar());

            ////com8 = null;
            ////cn8.Close();
            ////cn8 = null;
            //// ajouter qteLivrer & numeroBonLivraison & statutLivraison (ajouter ce colone a database)(il modifier a "true" quand le modele ajouter
            //// ==> a la livraison ) a la table de detailCommande
            //SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn2.Open();
            //    string reqq2 = "insert into detailLivraison(idLivraison,qteLivre,prixVente,idSituationModele,idDetailCommande) values (@idLivraison,@qteLivre,@prixVente,@idSituationModele,@idDetailCommande)";
            //    SqlCommand com2 = new SqlCommand(reqq2, cn2);
            //    com2.Parameters.Add(new SqlParameter("@idLivraison", txt_idLivraison.Text));
            //    com2.Parameters.Add(new SqlParameter("@qteLivre", txt_qteLivraison.Text));
            //    com2.Parameters.Add(new SqlParameter("@prixVente", txt_prixVente.Text));
            //    com2.Parameters.Add(new SqlParameter("@idSituationModele", cb_situation.SelectedValue));
            //    com2.Parameters.Add(new SqlParameter("@idDetailCommande", dgv_detailCommandeClient.CurrentRow.Cells[0].Value));
            //    com2.ExecuteNonQuery();

            //    com2 = null;
            //    cn2.Close();
            //    cn2 = null;
            //    // update la quantite en stock de modele valider a la livraison par qte-qteLivre
            //    SqlConnection cn3 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn3.Open();
            //    string reqq3 = "update modele set qteStock=(qteStock-" + Convert.ToInt32(txt_qteLivraison.Text) + ") where referenceModele='"+dgv_detailCommandeClient.CurrentRow.Cells[1].Value+"'";
            //    SqlCommand com3 = new SqlCommand(reqq3, cn3);
            //    com3.ExecuteNonQuery();

            //    com3 = null;
            //    cn3.Close();
            //    cn3 = null;
            //    // update la quantite disponible de modele valider a la livraison par qte-qteLivre
            //    SqlConnection cn9 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn9.Open();
            //    string reqq9 = "update modele set disponible=(disponible-" + Convert.ToInt32(txt_qteLivraison.Text) + ") where referenceModele='" + dgv_detailCommandeClient.CurrentRow.Cells[1].Value + "'";
            //    SqlCommand com9 = new SqlCommand(reqq9, cn9);
            //    com9.ExecuteNonQuery();

            //    com9 = null;
            //    cn9.Close();
            //    cn9 = null;
            //    // update la quantite livré de ce detailCommande
            //    SqlConnection cn11 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn11.Open();
            //    string reqq11 = "update detailCommande set qteLivre=qteLivre+"+ Convert.ToInt32(txt_qteLivraison.Text)+" where idDetailCommande="+dgv_detailCommandeClient.CurrentRow.Cells[0].Value;
            //    SqlCommand com11 = new SqlCommand(reqq11, cn11);
            //    com11.ExecuteNonQuery();

            //    com11 = null;
            //    cn11.Close();
            //    cn11 = null;
            //    // update le statut de soldé la livraison de ce detailCommande
            //    SqlConnection cn12 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn12.Open();
            //    SqlCommand com12 = new SqlCommand("select qteLivre from detailCommande where idDetailCommande=" + dgv_detailCommandeClient.CurrentRow.Cells[0].Value, cn12);
            //    int qteLivre = Convert.ToInt32(com12.ExecuteScalar());

            //    com12 = null;
            //    cn12.Close();
            //    cn12 = null;

            //    int qteAchat = Convert.ToInt32(dgv_detailCommandeClient.CurrentRow.Cells[2].Value);
            //    if (qteLivre > qteAchat)
            //    {
            //        SqlConnection cn13 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //        cn13.Open();
            //        string reqq13 = "update detailCommande set soldeLivraison=1 where idDetailCommande="+dgv_detailCommandeClient.CurrentRow.Cells[0].Value;
            //        SqlCommand com13 = new SqlCommand(reqq13, cn13);
            //        com13.ExecuteNonQuery();

            //        com13 = null;
            //        cn13.Close();
            //        cn13 = null;
            //    }

            //    // update le reste payer de client
            //    SqlConnection cn6 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn6.Open();
            //    string reqq6 = "update client set restePayer=restePayer+@qte*@prix where idClient=" + IdClient;
            //    SqlCommand com6 = new SqlCommand(reqq6, cn6);
            //    com6.Parameters.Add(new SqlParameter("@qte", Convert.ToInt32(txt_qteLivraison.Text)));
            //    com6.Parameters.Add(new SqlParameter("@prix", Convert.ToInt32(txt_prixVente.Text)));
            //    com6.ExecuteNonQuery();
            //    com6 = null;
            //    cn6.Close();
            //    cn6 = null;

            //    MessageBox.Show("la livraison a été ajouter avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    dgv_detailCommandeClient.CurrentRow.Cells[3].Value = true;
            //    updateStatutLivraisonOfLivraison();
            //////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////
            ///
            // checker la quantiter entrer de livraison est inférieure que la quantte en stock
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            SqlCommand com = new SqlCommand("select qteStock from matla m where idMatla="+cb_idMatla.SelectedValue, cn);
            int qte = Convert.ToInt32(com.ExecuteScalar());
            if (qte >= Convert.ToInt32(txt_qteLivraison.Text))
            {
                SqlConnection cn12 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn12.Open();
                SqlCommand com12 = new SqlCommand("select qteLivre from detailCommande where idDetailCommande=" + dgv_detailCommandeClient.CurrentRow.Cells[0].Value, cn12);
                int qteLivre = Convert.ToInt32(com12.ExecuteScalar());

                com12 = null;
                cn12.Close();
                cn12 = null;
                // retreive la situation modele
                //SqlConnection cn7 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                //cn7.Open();
                //SqlCommand com7 = new SqlCommand("select idSituationModele from situationModele where idSituationModele="+cb_idMatla.SelectedValue, cn7);
                //int situationModele = Convert.ToInt32(com7.ExecuteScalar());

                //com7 = null;
                //cn7.Close();
                //cn7 = null;
                //// insertion au detail Livraion
                SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn2.Open();
                string reqq2 = "insert into detailLivraison(idLivraison,qteLivre,prixVente,idMatla,idDetailCommande) values (@idLivraison,@qteLivre,@prixVente,@idMatla,@idDetailCommande)";
                SqlCommand com2 = new SqlCommand(reqq2, cn2);
                com2.Parameters.Add(new SqlParameter("@idLivraison", txt_idLivraison.Text));
                com2.Parameters.Add(new SqlParameter("@qteLivre", txt_qteLivraison.Text));
                com2.Parameters.Add(new SqlParameter("@prixVente", txt_prixVente.Text));
                com2.Parameters.Add(new SqlParameter("@idMatla", cb_idMatla.SelectedValue));
                com2.Parameters.Add(new SqlParameter("@idSituationModele", cb_idMatla.SelectedValue));
                com2.Parameters.Add(new SqlParameter("@idDetailCommande", dgv_detailCommandeClient.CurrentRow.Cells[0].Value));
                com2.ExecuteNonQuery();

                com2 = null;
                cn2.Close();
                cn2 = null;
                // update la quantite en stock de modele valider a la livraison par qte-qteLivre
                SqlConnection cn3 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn3.Open();
                string reqq3 = "update matla set qteStock=(qteStock-" + Convert.ToInt32(txt_qteLivraison.Text) + ") where idMatla="+cb_idMatla.SelectedValue;
                SqlCommand com3 = new SqlCommand(reqq3, cn3);
                com3.ExecuteNonQuery();

                com3 = null;
                cn3.Close();
                cn3 = null;
                // update la quantite disponible de modele valider a la livraison par qte-qteLivre
                //SqlConnection cn9 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                //cn9.Open();
                //string reqq9 = "update situationModele set disponible=(disponible-" + Convert.ToInt32(txt_qteLivraison.Text) + ") where idSituationModele=" + cb_idMatla.SelectedValue;
                //SqlCommand com9 = new SqlCommand(reqq9, cn9);
                //com9.ExecuteNonQuery();

                //com9 = null;
                //cn9.Close();
                //cn9 = null;
                // update la quantite livré de ce detailCommande
                SqlConnection cn11 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn11.Open();
                string reqq11 = "update detailCommande set qteLivre=qteLivre+" + Convert.ToInt32(txt_qteLivraison.Text) + " where idDetailCommande=" + dgv_detailCommandeClient.CurrentRow.Cells[0].Value;
                SqlCommand com11 = new SqlCommand(reqq11, cn11);
                com11.ExecuteNonQuery();

                com11 = null;
                cn11.Close();
                cn11 = null;
                // update le statut de soldé la livraison de ce detailCommande
                int qteAchat = Convert.ToInt32(dgv_detailCommandeClient.CurrentRow.Cells[3].Value);
                int qteLivraison = Convert.ToInt32(txt_qteLivraison.Text);
                if (qteLivre+ qteLivraison >= qteAchat)
                {
                    SqlConnection cn13 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                    cn13.Open();
                    string reqq13 = "update detailCommande set soldeLivraison=1 where idDetailCommande=" + dgv_detailCommandeClient.CurrentRow.Cells[0].Value;
                    SqlCommand com13 = new SqlCommand(reqq13, cn13);
                    com13.ExecuteNonQuery();

                    com13 = null;
                    cn13.Close();
                    cn13 = null;
                }
                // update la quantité disponible de matla lsivré
                SqlConnection cn15 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn15.Open();
                string reqq15 = "update matla set disponible=(disponible-" + Convert.ToInt32(txt_qteLivraison.Text) + ") where idMatla=" + cb_idMatla.SelectedValue;
                SqlCommand com15 = new SqlCommand(reqq15, cn15);
                com15.ExecuteNonQuery();

                com15 = null;
                cn15.Close();
                cn15 = null;
                // update statutMatla de matla livré si qteStock=0
                if (qte - Convert.ToInt32(txt_qteLivraison.Text) == 0)
                {
                    SqlConnection cn4 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                    cn4.Open();
                    string reqq4 = "update matla set statutTerminer=1 where idMatla=@idMatla";
                    SqlCommand com4 = new SqlCommand(reqq4, cn4);
                    com4.Parameters.Add(new SqlParameter("@idMatla", cb_idMatla.SelectedValue));
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
                com6.Parameters.Add(new SqlParameter("@qte", Convert.ToInt32(txt_qteLivraison.Text)));
                com6.Parameters.Add(new SqlParameter("@prix", Convert.ToInt32(txt_prixVente.Text)));
                com6.ExecuteNonQuery();
                com6 = null;
                cn6.Close();
                cn6 = null;

                MessageBox.Show("la livraison a été ajouter avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_detailCommandeClient.CurrentRow.Cells[5].Value = true;
                updateStatutLivraisonOfLivraison();
            }
            else MessageBox.Show("la quantite qui vous avez saisi est inférieure a la quantite en stock de Matla contient - Quantite en stock : " + qte, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            com = null;
            cn.Close();
            cn = null;
            //}
            //catch (Exception error) { MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            //// Fill datagrid view of livraison of commande
               //SqlConnection cn5 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
    //        cn5.Open();
    //        //string req2 = "select dc.idLivraison, l.numeroBonLivraison,dateLivraison,idCommande,m.referenceModele,designation,prixAchat,qteLivre,prixAchat*qteLivre as totale from livraison l inner join detailCommande dc on dc.idLivraison=l.idLivraison inner join modele m on m.referenceModele=dc.referenceModele where idCommande=" + dgv_commandeClient.CurrentRow.Cells[0].Value;
    //        string req5 = " SELECT l.idLivraison, numeroBonLivraison,dateLivraison,m.referenceModele,designation,SUM(dl.qteLivre) AS totalQuantity,SUM(dc.prixAchat * dl.qteLivre) AS totale FROM livraison l INNER JOIN detailLivraison dl ON dl.idLivraison = l.idLivraison INNER JOIN matla mt ON mt.idMatla = dl.idMatla INNER JOIN modele m ON m.referenceModele = mt.referenceModele INNER JOIN detailCommande dc ON dc.idCommande = l.idCommande AND dc.referenceModele = m.referenceModele WHERE l.idCommande = " + dgv_commandeClient.CurrentRow.Cells[0].Value + " GROUP BY l.idLivraison,numeroBonLivraison,dateLivraison,m.referenceModele,designation";
    //        SqlCommand com5 = new SqlCommand(req5, cn5);
    //        SqlDataReader dr5 = com5.ExecuteReader();
    //        dgv_livraison.Rows.Clear();
    //        while (dr5.Read())
    //        {
    //            dgv_livraison.Rows.Add(dr5["idLivraison"], dr5["numeroBonLivraison"], dr5["designation"], Convert.ToDateTime(dr5["dateLivraison"].ToString()).ToShortDateString(), dr5["totalQuantity"], dr5["totale"]);
    //        }
    //        // close all commandes and connection and datareader
    //        dr5.Close();
    //        dr5 = null;
    //        com5 = null;

    //        cn5.Close();
    //        cn5 = null;
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
                    //SqlCommand com = new SqlCommand("UPDATE detailCommande SET statutLivraison = @UpdatedValue WHERE idCommande = @idCommande and referenceModele=@referenceModele", cn);
                    //com.Parameters.AddWithValue("@UpdatedValue", updatedValue);
                    //com.Parameters.AddWithValue("@idCommande", dgv_commandeClient.CurrentRow.Cells[0].Value);
                    //com.Parameters.AddWithValue("@referenceModele", referenceModele);
                    SqlCommand com = new SqlCommand("UPDATE detailCommande SET statutLivraison = @UpdatedValue WHERE idDetailCommande=@idDetailCommande", cn);
                    com.Parameters.AddWithValue("@UpdatedValue", updatedValue);
                    com.Parameters.AddWithValue("@idDetailCommande", dgv_detailCommandeClient.CurrentRow.Cells[0].Value);
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
            //string filtre = "{livraison.idLivraison}="+dgv_livraison.CurrentRow.Cells[0].Value;
            //imprimer(new BonLivraisonClient(), "", filtre);
        }

    }
}
