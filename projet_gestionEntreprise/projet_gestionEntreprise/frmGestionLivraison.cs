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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace projet_gestionEntreprise
{
    public partial class frmGestionLivraison : Form
    {
        public frmGestionLivraison()
        {
            InitializeComponent();
        }
        private void refresh(string filtre)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            //string req = "SELECT l.idLivraison,l.numeroBonLivraison,l.dateLivraison,c.idClient,nomClient+' '+prenomClient as nomComplet,cmd.idCommande,SUM(dl.qteLivre) AS totalQuantity,SUM(dl.prixVente * dl.qteLivre) AS totalAmount FROM livraison l  INNER JOIN detailLivraison dl ON dl.idLivraison = l.idLivraison  INNER JOIN matla mt ON mt.idMatla = dl.idMatla  INNER JOIN modele m ON m.referenceModele = mt.referenceModele  INNER JOIN detailCommande dc ON dc.idCommande = l.idCommande AND dc.referenceModele = m.referenceModele  INNER JOIN commande cmd on cmd.idCommande=dc.idCommande INNER JOIN client c on c.idClient=cmd.idClient " + filtre+ " GROUP BY l.idLivraison, l.numeroBonLivraison, l.dateLivraison,c.idClient,nomClient,prenomClient,cmd.idCommande ORDER BY l.idLivraison desc";
            /////string req = "SELECT l.idLivraison,l.numeroBonLivraison,l.dateLivraison,c.idClient,nomClient+' '+prenomClient as nomComplet,cmd.idCommande,SUM(dl.qteLivre) AS totalQuantity,SUM(dc.prixAchat * dl.qteLivre) AS totalAmount FROM livraison l  INNER JOIN detailLivraison dl ON dl.idLivraison = l.idLivraison  INNER JOIN matla mt ON mt.idMatla = dl.idMatla  INNER JOIN modele m ON m.referenceModele = mt.referenceModele  INNER JOIN detailCommande dc ON dc.idCommande = l.idCommande AND dc.referenceModele = m.referenceModele  INNER JOIN commande cmd on cmd.idCommande=dc.idCommande INNER JOIN client c on c.idClient=cmd.idClient " + filtre+ " GROUP BY l.idLivraison, l.numeroBonLivraison, l.dateLivraison,c.idClient,nomClient,prenomClient,cmd.idCommande ORDER BY dateLivraison desc";
            //string req = "select l.idLivraison,numeroBonLivraison,dateLivraison,nomClient,l.designation,sum(dl.qteLivre) as totalQuantity,totalPaye,remise from livraison l inner join detailLivraison dl on dl.idLivraison=l.idLivraison inner join detailCommande dc on dc.idDetailCommande=dl.idDetailCommande inner join commande cmd on cmd.idCommande=dc.idCommande inner join client c on c.idClient=cmd.idClient " + filtre+ " group by l.idLivraison,numeroBonLivraison,dateLivraison,nomClient,l.designation,totalPaye,remise  ORDER BY l.idLivraison desc";
            string req = "select l.idLivraison,numeroBonLivraison,dateLivraison,c.idClient,nomClient,l.designation,sum(dl.qteLivre) as totalQuantity,sum(dl.qteLivre*dl.prixVente) as totalPaye,remise from livraison l left join detailLivraison dl on dl.idLivraison=l.idLivraison inner join detailCommande dc on dc.idDetailCommande=dl.idDetailCommande inner join commande cmd on cmd.idCommande=dc.idCommande inner join client c on c.idClient=cmd.idClient " + filtre+ " group by l.idLivraison,numeroBonLivraison,dateLivraison,c.idClient,nomClient,l.designation,remise  ORDER BY l.idLivraison desc";
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            dgv_livraison.Rows.Clear();
            while (dr.Read())
            {
                dgv_livraison.Rows.Add(dr["idLivraison"], dr["numeroBonLivraison"], Convert.ToDateTime(dr["dateLivraison"].ToString()).ToShortDateString(), dr["nomClient"], dr["designation"], dr["totalQuantity"], dr["totalPaye"], dr["remise"], dr["idClient"]);
            }
            dr.Close();
            dr = null;
            com = null;

            cn.Close();
            cn = null;
            //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //cn.Open();
            //string req = "select l.idLivraison,numeroBonLivraison,dateLivraison,c.idClient,nomClient+' '+prenomClient as nomComplet,idCommande,m.referenceModele,designation,qteLivre from livraison l inner join detailCommande dc on dc.idLivraison=l.idLivraison inner join modele m on m.referenceModele=dc.referenceModele inner join client c on c.idClient=l.idClient " + filtre+" order by dateLivraison";
            //SqlCommand com = new SqlCommand(req, cn);
            //SqlDataReader dr = com.ExecuteReader();
            //dgv_livraison.Rows.Clear();
            //while (dr.Read())
            //{
            //    dgv_livraison.Rows.Add(dr["idLivraison"], dr["numeroBonLivraison"], dr["dateLivraison"], dr["idClient"], dr["nomComplet"], dr["idCommande"], dr["referenceModele"], dr["designation"], dr["qteLivre"]);
            //}
            //dr.Close();
            //dr = null;
            //com = null;

            //cn.Close();
            //cn = null;
        }
        private void frmGestionLivraison_Load(object sender, EventArgs e)
        {
            refresh("");
            cb_recherche.SelectedIndex = 0;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh("");
            txt_rechercher.Text = "";
        }
        //Id Livraison
        //N° Bon Livraison
        //Date Livraison
        //Nom de Client
        //Reference Modele
        //ID Commande
        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cb_recherche.SelectedIndex)
                {
                    case 0:
                        refresh(" where l.idLivraison=" + txt_rechercher.Text);
                        break;
                    case 1:
                        refresh(" where l.numeroBonLivraison=" + txt_rechercher.Text);
                        break;
                    case 2:
                        refresh(" where dateLivraison like'%" + txt_rechercher.Text+"%'");
                        break;
                    case 3:
                        refresh(" where nomClient like '%"+ txt_rechercher.Text + "%' or prenomClient like '%"+txt_rechercher.Text+"%'");
                        break;
                    //case 4:
                    //    refresh(" where m.referenceModele='" + txt_rechercher.Text + "'");
                    //    break;
                    //case 5:
                    //    refresh(" where idCommande=" + txt_rechercher.Text);
                    //    break;
                    case 4:
                        refresh(" where m.referenceModele='"+ txt_rechercher.Text + "'");
                        break;
                    case 5:
                        refresh(" where l.idCommande=" + txt_rechercher.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("doit etre rechercher par l'element séléctionner", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_livraison_SelectionChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            //string req = "SELECT livraison.idCommande,matla.referenceModele,modele.designation AS designationModele,detailCommande.qteAchat AS quantiteCommande,prixVente AS prixAchatModele,SUM(detailLivraison.qteLivre) AS quantiteLivre FROM livraison INNER JOIN detailCommande ON livraison.idCommande = detailCommande.idCommande INNER JOIN matla ON detailCommande.referenceModele = matla.referenceModele INNER JOIN modele ON matla.referenceModele = modele.referenceModele inner JOIN detailLivraison ON livraison.idLivraison = detailLivraison.idLivraison AND matla.idMatla = detailLivraison.idMatla where livraison.idLivraison = "+dgv_livraison.CurrentRow.Cells[0].Value+ " GROUP BY livraison.idCommande,matla.referenceModele,modele.designation,detailCommande.qteAchat,prixVente";
            string req = "select m.referenceModele,m.designation,qteAchat,dl.qteLivre,prixVente,idDetailLivraison,sum(dl.qteLivre*dl.prixVente) as totalePrix from detailLivraison dl inner join detailCommande dc on dc.idDetailCommande=dl.idDetailCommande inner join modele m on m.referenceModele=dc.referenceModele where dl.idLivraison="+dgv_livraison.CurrentRow.Cells[0].Value+ " group by m.referenceModele,m.designation,qteAchat,dl.qteLivre,prixVente,idDetailLivraison";
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            dgv_detailLivraison.Rows.Clear();
            while (dr.Read())
            {
                dgv_detailLivraison.Rows.Add(dr["referenceModele"], dr["designation"], dr["qteAchat"], dr["qteLivre"], dr["prixVente"], dr["totalePrix"], dr["idDetailLivraison"]) ;
            }
            dr.Close();
            dr = null;
            com = null;

            cn.Close();
            cn = null;
        }
        private void imprimer(ReportClass cr, string chemain = "", string filtre = "")
        {
            cr.SetDatabaseLogon("sa", "123456");
            //if (chemain != "")
            //    cr.SetParameterValue("chemain", chemain);

            frmImpression f = new frmImpression(cr, filtre);
            f.ShowDialog();
        }
        private void btn_imprimerLivraison_Click(object sender, EventArgs e)
        {
            //string filtre = "{livraison.idLivraison}=" + dgv_livraison.CurrentRow.Cells[0].Value;
            //imprimer(new CrystalReport9(), "", filtre);
            ///
            /// 
            /// 
            //// Supposons que idLivraison soit l'idLivraison entré par l'utilisateur
            //int idLivraison = Convert.ToInt32(dgv_livraison.CurrentRow.Cells[0].Value); // Vous devez implémenter GetIdLivraisonFromUser() pour obtenir l'idLivraison entré par l'utilisateur

            //// Connexion à la base de données et récupération des données de la livraison spécifique
            //string connectionString = @"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456"; // Remplacez ceci par votre chaîne de connexion SQL Server

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();

            //    string query = $"SELECT c.nomClient, c.prenomClient, c.adresseClient, livraison.dateLivraison, livraison.numeroBonLivraison, dl.qteLivre, m.designation, dc.prixAchat " +
            //                   $"FROM livraison " +
            //                   $"INNER JOIN detailLivraison dl ON livraison.idLivraison = dl.idLivraison " +
            //                   $"INNER JOIN matla mt ON dl.idMatla = mt.idMatla " +
            //                   $"INNER JOIN modele m ON mt.referenceModele = m.referenceModele " +
            //                   $"INNER JOIN detailCommande dc ON livraison.idCommande = dc.idCommande AND m.referenceModele = dc.referenceModele " +
            //                   $"INNER JOIN commande cmd ON livraison.idCommande = cmd.idCommande " +
            //                   $"INNER JOIN client c ON cmd.idClient = c.idClient " +
            //                   $"WHERE livraison.idLivraison = @idLivraison"; // Utilisation d'un paramètre pour idLivraison pour éviter les injections SQL

            //    SqlCommand command = new SqlCommand(query, connection);
            //    command.Parameters.AddWithValue("@idLivraison", idLivraison); // Ajout du paramètre idLivraison

            //    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            //    DataSet dataSet = new DataSet();
            //    dataAdapter.Fill(dataSet, "LivraisonData");

            //    // Chargement du rapport Crystal Reports
            //    ReportDocument reportDocument = new ReportDocument();
            //    reportDocument.Load(@"C:\Users\user\Desktop\redwane kassou\projet gestionEntrprise\projet_gestionEntreprise\projet_gestionEntreprise\CrystalReport1.rpt"); // Remplacez ceci par le chemin vers votre fichier de rapport Crystal Reports
            //    reportDocument.SetDataSource(dataSet.Tables["LivraisonData"]);

            //    // Affichage du rapport dans une fenêtre CrystalReportViewer ou impression directe
            //    CrystalReportViewer crystalReportViewer = new CrystalReportViewer();
            //    crystalReportViewer.ReportSource = reportDocument;
            //    crystalReportViewer.Refresh();
            //    Form form = new Form();
            //    form.Controls.Add(crystalReportViewer);
            //    form.ShowDialog(); // Affiche le rapport dans une fenêtre modale
            //    connection.Close();


            //string connectionString = @"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456"; // Remplacez ceci par votre chaîne de connexion SQL Server
            //int idLivraison = Convert.ToInt32(dgv_livraison.CurrentRow.Cells[0].Value);
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();

            //    string query = $"SELECT c.nomClient, c.prenomClient, c.adresseClient, livraison.dateLivraison, livraison.numeroBonLivraison, dl.qteLivre, m.designation, dc.prixAchat " +
            //                   $"FROM livraison " +
            //                   $"INNER JOIN detailLivraison dl ON livraison.idLivraison = dl.idLivraison " +
            //                   $"INNER JOIN matla mt ON dl.idMatla = mt.idMatla " +
            //                   $"INNER JOIN modele m ON mt.referenceModele = m.referenceModele " +
            //                   $"INNER JOIN detailCommande dc ON livraison.idCommande = dc.idCommande AND m.referenceModele = dc.referenceModele " +
            //                   $"INNER JOIN commande cmd ON livraison.idCommande = cmd.idCommande " +
            //                   $"INNER JOIN client c ON cmd.idClient = c.idClient " +
            //                   $"WHERE livraison.idLivraison = @idLivraison"; // Utilisation d'un paramètre pour idLivraison pour éviter les injections SQL

            //    SqlCommand command = new SqlCommand(query, connection);
            //    command.Parameters.AddWithValue("@idLivraison", idLivraison); // Ajout du paramètre idLivraison

            //}


            //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //cn.Open();
            //string req = "EXEC getLivraison " + dgv_livraison.CurrentRow.Cells[0].Value;

            //SqlCommand com = new SqlCommand(req, cn);
            //DataSet ds = new DataSet();
            //SqlDataAdapter ad = new SqlDataAdapter(com);
            //ad.Fill(ds, "table");

            //bonLivraison cr = new bonLivraison();
            //cr.SetDatabaseLogon("sa", "123456");
            //cr.SetDataSource(ds.Tables["table"]);

            //frmImpression f = new frmImpression(cr);
            //f.ShowDialog();
            //imprimer(cr);

            //string filtre = "{matla.idMatla} = " + idMt;

            //imprimer(new bonLivraison());



            //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //cn.Open();

            //SqlCommand com = new SqlCommand("getLivraison", cn);
            //com.CommandType = CommandType.StoredProcedure;

            //// Set a default value for the @idLivraison parameter
            //com.Parameters.AddWithValue("@idLivraison", DBNull.Value); // You can replace DBNull.Value with an appropriate default value

            //SqlDataAdapter ad = new SqlDataAdapter(com);
            //DataSet ds = new DataSet();
            //ad.Fill(ds, "Livraison");

            /////////////bonLivraison cr = new bonLivraison();
            //cr.SetDataSource(ds.Tables["Livraison"]);

            //////////////imprimer(cr);


            bonDeLivraison cr = new bonDeLivraison();
            //cr.Refresh();
            cr.SetDatabaseLogon("sa", "123456");

            string filtre = "{livraison.idLivraison}=" + dgv_livraison.CurrentRow.Cells[0].Value;
            frmImpression f = new frmImpression(cr, filtre);
            f.ShowDialog();

        }

        private void dgv_detailLivraison_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_detailLivraison.Columns[e.ColumnIndex].Name== "Column12")
            {
                int idDl = Convert.ToInt32(dgv_detailLivraison.CurrentRow.Cells[6].Value);
                frmModifierDetailLivraison f = new frmModifierDetailLivraison(idDl);
                f.ShowDialog();
            }
            if (dgv_detailLivraison.Columns[e.ColumnIndex].Name == "Column14")
            {
                int idDl = Convert.ToInt32(dgv_detailLivraison.CurrentRow.Cells[6].Value);
                int idCl = Convert.ToInt32(dgv_livraison.CurrentRow.Cells[8].Value);
                frmAjouterDetailRetour f = new frmAjouterDetailRetour(idDl,idCl);
                f.ShowDialog();
            }
        }

        private void dgv_livraison_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
