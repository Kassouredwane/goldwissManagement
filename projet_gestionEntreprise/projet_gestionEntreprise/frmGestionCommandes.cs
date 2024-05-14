using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
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
    public partial class frmGestionCommandes : Form
    {
        public frmGestionCommandes()
        {
            InitializeComponent();
        }
        private void refresh(string filtre)
        {
            if(chk_enCourLivraison.Checked==false) 
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string req = "select c.idClient,nomClient as nomComplet,cmd.idCommande,dateCommande,designation,cmd.statutLivraison from client c inner join commande cmd on cmd.idClient=c.idClient where archiver='"+chk_archive.Checked+"' " + filtre+" order by cmd.idCommande desc";
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_commandeClient.Rows.Clear();
                while (dr.Read())
                {
                    dgv_commandeClient.Rows.Add(dr["idClient"], dr["nomComplet"], dr["idCommande"], Convert.ToDateTime(dr["dateCommande"].ToString()).ToShortDateString(), dr["designation"], dr["statutLivraison"]);
                }
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
            }
            else
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string req = "select c.idClient,nomClient+' '+prenomClient as nomComplet,cmd.idCommande,dateCommande,designation,cmd.statutLivraison from client c inner join commande cmd on cmd.idClient=c.idClient where archiver='"+chk_archive.Checked+"' and cmd.statutLivraison=0 " + filtre+ " order by cmd.idCommande desc";
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_commandeClient.Rows.Clear();
                while (dr.Read())
                {
                    dgv_commandeClient.Rows.Add(dr["idClient"], dr["nomComplet"], dr["idCommande"], Convert.ToDateTime(dr["dateCommande"].ToString()).ToShortDateString(), dr["designation"], dr["statutLivraison"]);
                }
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
            }
        }
        private void frmGestionCommandes_Load(object sender, EventArgs e)
        {
            refresh("");
            cb_recherche.SelectedIndex= 0;  
        }

        private void chk_enCourLivraison_CheckedChanged(object sender, EventArgs e)
        {
            refresh("");
        }

        private void dgv_commandeClient_SelectionChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            //string req = "select dc.referenceModele,designation,qteAchat,prixAchat,statutLivraison from detailCommande dc inner join modele m on m.referenceModele=dc.referenceModele where idCommande=" + dgv_commandeClient.CurrentRow.Cells[2].Value;
            string req = "select dc.referenceModele,m.designation,qteAchat,prixAchat,qteLivre,dc.designation as design,statutLivraison,soldeLivraison from detailCommande dc inner join modele m on m.referenceModele=dc.referenceModele where idCommande=" + dgv_commandeClient.CurrentRow.Cells[2].Value;
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            dgv_detailCommandeClient.Rows.Clear();
            while (dr.Read())
            {
                dgv_detailCommandeClient.Rows.Add(dr["referenceModele"], dr["designation"], dr["qteAchat"], dr["prixAchat"], dr["qteLivre"], dr["design"], dr["statutLivraison"], dr["soldeLivraison"]);
            }
            dr.Close();
            dr = null;
            com = null;

            cn.Close();
            cn = null;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh("");
        }
        //Code Client
        //Nom Complet
        //Id Commande
        //Date Commande
        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            switch (cb_recherche.SelectedIndex)
            {
                case 0:
                    if (chk_enCourLivraison.Checked==false) refresh(" and c.idClient="+txt_rechercher.Text);
                    else refresh(" and c.idClient=" + txt_rechercher.Text);
                    break;
                case 1:
                    if (chk_enCourLivraison.Checked == false) refresh(" and nomClient like'%"+ txt_rechercher.Text + "%' or prenomClient like'%"+txt_rechercher.Text+"%'");
                    else refresh(" and nomClient like'%" + txt_rechercher.Text + "%' or prenomClient like'%" + txt_rechercher.Text + "%'");
                    break;
                case 2:
                    if (chk_enCourLivraison.Checked == false) refresh(" and cmd.idCommande=" + txt_rechercher.Text);
                    else refresh(" and cmd.idCommande=" + txt_rechercher.Text);
                    break;
                case 3:
                    if (chk_enCourLivraison.Checked == false) refresh(" and cmd.dateCommande like '%" + txt_rechercher.Text+"%'");
                    else refresh(" and cmd.dateCommande like '%" + txt_rechercher.Text+"%'");
                    break;
                case 4:
                    if (chk_enCourLivraison.Checked == false) refresh(" and cmd.idCommande in (select idCommande from detailCommande where referenceModele='"+txt_rechercher.Text+"')");
                    else refresh(" and cmd.idCommande in (select idCommande from detailCommande where referenceModele='" + txt_rechercher.Text + "')");
                    break;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Etes-vous vraiment veux supprimer ce commande ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    // delete the "commande" from table detailCommande because she has a foreign key of IdCommande
            //    SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn1.Open();
            //    string req1 = "delete from detailCommande where idCommande=" + dgv_commandeClient.CurrentRow.Cells[2].Value;
            //    SqlCommand com1 = new SqlCommand(req1, cn1);

            //    com1.ExecuteNonQuery();
            //    com1 = null;
            //    cn1.Close();
            //    cn1 = null;
            //    //// delete the "commande" from table livraison because she has a foreign key of IdCommande
            //    //SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    //cn1.Open();
            //    //string req1 = "delete from detailCommande where idCommande=" + dgv_commandeClient.CurrentRow.Cells[2].Value;
            //    //SqlCommand com1 = new SqlCommand(req1, cn1);
            //    //com1.ExecuteNonQuery();
            //    //com1 = null;
            //    //cn1.Close();
            //    //cn1 = null;
            //    // delete the "commande" from table of commmande
            //    SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn.Open();
            //    string req = "delete from commande where idCommande=" + dgv_commandeClient.CurrentRow.Cells[2].Value;
            //    SqlCommand com = new SqlCommand(req, cn);
            //    com.ExecuteNonQuery();
            //    com = null;
            //    cn.Close();
            //    cn = null;
            //    MessageBox.Show("La commande a été supprimer avec succé","Information",MessageBoxButtons.OK, MessageBoxIcon.Question);
            //    refresh("");
            //}
        }

        private void btn_supprimerTousCommandes_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Etes-vous vraiment veux supprimer tous les commandes ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    // delete the "commande" from table detailCommande because she has a foreign key of IdCommande
            //    SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn1.Open();
            //    string req1 = "delete from detailCommande";
            //    SqlCommand com1 = new SqlCommand(req1, cn1);
            //    com1.ExecuteNonQuery();
            //    com1 = null;
            //    cn1.Close();
            //    cn1 = null;
            //    // delete the "commande" from table of commmande
            //    SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn.Open();
            //    string req = "delete from commande";
            //    SqlCommand com = new SqlCommand(req, cn);
            //    com.ExecuteNonQuery();
            //    com = null;
            //    cn.Close();
            //    cn = null;
            //    MessageBox.Show("Tous les commandes a été supprimer avec succé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //    refresh("");
            //}

            //try
            //{
            //    if (MessageBox.Show("Etes-vous vraiment veux supprimer tous les Matla dans la grid ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        foreach (DataGridViewRow row in dgv_commandeClient.Rows)
            //        {
            //            int idCmd = Convert.ToInt32(row.Cells[2].Value);

            //            if (idCmd != null)
            //            {
            //                //delete the "commande" from table detailCommande because she has a foreign key of IdCommande
            //                SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //                cn1.Open();
            //                string req1 = "delete from detailCommande where idCommande="+idCmd;
            //                SqlCommand com1 = new SqlCommand(req1, cn1);
            //                com1.ExecuteNonQuery();
            //                com1 = null;
            //                cn1.Close();
            //                cn1 = null;
            //                // delete the "commande" from table of commmande
            //                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //                cn.Open();
            //                string req = "delete from commande where idCommande="+idCmd;
            //                SqlCommand com = new SqlCommand(req, cn);
            //                com.ExecuteNonQuery();
            //                com = null;
            //                cn.Close();
            //                cn = null;
            //            }
            //        }
            //    }
            //}
            //catch (Exception error) { MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void imprimer(ReportClass cr, string chemain = "", string filtre = "")
        {
            cr.SetDatabaseLogon("sa", "123456");
            //if (chemain != "")
            //    cr.SetParameterValue("chemain", chemain);
            frmImpression f = new frmImpression(cr, filtre);
            f.ShowDialog();
        }
        private void btn_imprimerCommande_Click(object sender, EventArgs e)
        {
            //bonCommande cr = new bonCommande();
            ////cr.Refresh();
            //cr.SetDatabaseLogon("sa", "123456");

            ////string filtre = "{commande.idCommande}=" + dgv_commandeClient.CurrentRow.Cells[2].Value;
            //string filtre = "{commande.idCommande}=" + dgv_commandeClient.CurrentRow.Cells[2].Value + " and {detailCommande.statutLivraison}=false ";
            //frmImpression f = new frmImpression(cr, filtre);
            //f.ShowDialog();

            int idCommande = Convert.ToInt32(dgv_commandeClient.CurrentRow.Cells[2].Value);
            frmMenuImprimerCommande f = new frmMenuImprimerCommande(idCommande);
            f.ShowDialog();









            //// Connectez-vous à la base de données et exécutez votre requête SQL
            //string connectionString = @"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456";
            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();

            //// Executez votre requête SQL spécifique à idLivraison
            //string req = "select cmd.idCommande,dateCommande,c.idClient,nomClient,prenomClient,adresseClient,referenceModele,qteAchat,prixAchat from commande cmd inner join detailCommande dc on dc.idCommande=cmd.idCommande inner join client c on c.idClient=cmd.idClient where cmd.idCommande= @idCommande";
            //SqlCommand command = new SqlCommand(req, connection);
            //command.Parameters.AddWithValue("@idCommande", dgv_commandeClient.CurrentRow.Cells[2].Value);
            ////command.Parameters.AddWithValue("@idLivraison", idLivraison);

            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataSet dataSet = new DataSet();
            //adapter.Fill(dataSet);

            //// Créez une instance de votre rapport Crystal Reports
            //ReportDocument reportDocument = new ReportDocument();
            //reportDocument.Load("commandeReport.rpt"); // Remplacez par le chemin vers votre rapport

            //// Ajoutez les données de votre DataSet au rapport
            //reportDocument.SetDataSource(dataSet.Tables[0]);

            //// Affichez le rapport dans une CrystalReportViewer ou une fenêtre personnalisée
            //CrystalReportViewer crystalReportViewer = new CrystalReportViewer();
            //crystalReportViewer.ReportSource = reportDocument;

            //// Affichez la visionneuse dans une fenêtre ou un formulaire
            //Form form = new Form();
            //form.Controls.Add(crystalReportViewer);
            //form.WindowState = FormWindowState.Maximized;
            //form.ShowDialog();






            //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //cn.Open();
            //string req = "select cmd.idCommande,dateCommande,c.idClient,nomClient,prenomClient,adresseClient,referenceModele,qteAchat,prixAchat from commande cmd inner join detailCommande dc on dc.idCommande=cmd.idCommande inner join client c on c.idClient=cmd.idClient where cmd.idCommande= @idCommande";

            //SqlCommand com = new SqlCommand(req, cn);
            //com.Parameters.AddWithValue("@idCommande", dgv_commandeClient.CurrentRow.Cells[2].Value);
            ////com.Parameters.AddWithValue("@dateDebut", dtp_dateDebut.Value);
            ////com.Parameters.AddWithValue("@dateFin", dtp_dateFinale.Value);
            //SqlDataAdapter ad = new SqlDataAdapter(com);
            //DataSet ds = new DataSet();
            //ad.Fill(ds, "detailCommande");

            //CrystalReport14 cr = new CrystalReport14();
            ////cr.Refresh();
            //cr.SetDatabaseLogon("sa", "123456");
            //cr.SetDataSource(ds.Tables["detailCommande"]);
            //frmImpression f = new frmImpression(cr);
            //f.ShowDialog();


            //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //cn.Open();
            //string req = "select cmd.idCommande,dateCommande,c.idClient,nomClient,prenomClient,adresseClient,referenceModele,qteAchat,prixAchat from commande cmd inner join detailCommande dc on dc.idCommande=cmd.idCommande inner join client c on c.idClient=cmd.idClient where cmd.idCommande= @idCommande";

            //SqlCommand com = new SqlCommand(req, cn);
            //com.Parameters.AddWithValue("@idCommande", dgv_commandeClient.CurrentRow.Cells[2].Value);
            ////com.Parameters.AddWithValue("@dateDebut", dtp_dateDebut.Value);
            ////com.Parameters.AddWithValue("@dateFin", dtp_dateFinale.Value);
            //SqlDataAdapter ad = new SqlDataAdapter(com);
            //DataSet ds = new DataSet();
            //ad.Fill(ds, "commande");

            //CrystalReport14 cr = new CrystalReport14();
            ////cr.Refresh();
            //cr.SetDatabaseLogon("sa", "123456");
            //cr.SetDataSource(ds.Tables["commande"]);
            //frmImpression f = new frmImpression(cr);
            //f.ShowDialog();
            //imprimer(cr);


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            listeClientCommandeNonLivre cr = new listeClientCommandeNonLivre();
            //cr.Refresh();
            cr.SetDatabaseLogon("sa", "123456");

            //string filtre = "{commande.idCommande}=" + dgv_commandeClient.CurrentRow.Cells[2].Value;
            //string filtre = "{commande.idCommande}=" + dgv_commandeClient.CurrentRow.Cells[2].Value + " and {detailCommande.statutLivraison}=false ";
            frmImpression f = new frmImpression(cr);
            f.ShowDialog();
        }

        private void chk_archive_CheckedChanged(object sender, EventArgs e)
        {
            refresh("");
        }
    }
}
