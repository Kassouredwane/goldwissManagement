using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace projet_gestionEntreprise
{
    public partial class frmGestionStock : Form
    {
        public frmGestionStock()
        {
            InitializeComponent();
        }
        private void colorOfCellsQteStock()
        {
            foreach (DataGridViewRow row in dgv_modeles.Rows)
            {
                DataGridViewTextBoxCell cell = row.Cells[5] as DataGridViewTextBoxCell;

                if (cell != null && cell.Value != null && cell.Value != DBNull.Value)
                {
                    int cellValue;
                    if (int.TryParse(cell.Value.ToString(), out cellValue))
                    {
                        if (cellValue < 30)
                        {
                            cell.Style.BackColor = Color.Red;
                        }
                        else if (cellValue >= 30 && cellValue < 100)
                        {
                            cell.Style.BackColor = Color.OrangeRed;
                        }
                        else
                        {
                            cell.Style.BackColor = Color.Green;
                        }
                    }
                    else
                    {
                        // Handle the case where the value cannot be converted to an integer
                        // You can set a default color or handle it as per your requirement.
                    }
                }
                else
                {
                    cell.Value = 0;
                    cell.Style.BackColor = Color.Red;
                }
            }
        }
        private void frmGestionStock_Load(object sender, EventArgs e)
        {
            cb_categorie.Items.Clear();
            cb_categorie.Items.Add("Tous les categories");

            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn1.Open();
            string req = "select * from categorie";
            SqlCommand com = new SqlCommand(req, cn1);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                string nomCategorie = dr["nomCategorie"].ToString();
                cb_categorie.Items.Add(nomCategorie);
            }
            dr.Close();
            dr = null;
            com = null;

            cn1.Close();
            cn1 = null;
            cb_categorie.SelectedIndex=0;
            fillGridModele("");
            //choose image modele
            if (txt_imageModele.Text == "") imageModele.Load("imageModeles/aucune image.jpg");
            else imageModele.Load("imageModeles/" + txt_imageModele.Text);
            // color of cells of "quantite en stock"
            colorOfCellsQteStock();

            if (dgv_modeles.Rows.Count > 0)
            {
                string connectionString = @"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "select * from modele where referenceModele=@referenceModele";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@referenceModele", dgv_modeles.CurrentRow.Cells[0].Value);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            if (!Convert.IsDBNull(reader["ProductImage"]))
                            {
                                byte[] imageData = (byte[])reader["ProductImage"];
                                DisplayProductImage(imageData);
                            }
                            else
                            {
                                // If the ProductImage column is NULL or empty, display a default image or handle it as needed
                                imageModele.Image = Properties.Resources.aucune_image; // Replace with your default image
                            }
                        }
                        else
                        {
                            MessageBox.Show("Product not found!");
                        }
                    }
                }
            }
        }
        private void fillGridModele(string filtre)
        {
            try
            {
                if (cb_categorie.Text == "Tous les categories")
                {
                    SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                    cn.Open();
                    //string req = "SELECT m.referenceModele, taille, designation, marqueModele, prixModele, SUM(mt.qteStock) AS qteStock FROM modele m left JOIN matla mt ON mt.referenceModele = m.referenceModele " + filtre + " group by m.referenceModele,taille,designation,marqueModele,prixModele";
                    string req = "SELECT m.referenceModele,m.taille,m.designation,m.marqueModele,m.prixModele,COALESCE(SUM(mt.qteStock), 0) AS QuantiteEnStock,COALESCE(( SELECT SUM(dl.qteLivre) FROM detailLivraison dl JOIN matla mt_dl ON mt_dl.idMatla = dl.idMatla WHERE mt_dl.referenceModele = m.referenceModele), 0) AS QuantiteLivree, COALESCE(SUM(mt.nbPieceSorter), 0) - COALESCE(( SELECT SUM(dl.qteLivre) FROM detailLivraison dl JOIN matla mt_dl ON mt_dl.idMatla = dl.idMatla  WHERE mt_dl.referenceModele = m.referenceModele ), 0) AS QuantiteRestante FROM modele m LEFT JOIN matla mt ON m.referenceModele = mt.referenceModele "+filtre+ " GROUP BY m.referenceModele, m.taille, m.designation, m.marqueModele, m.prixModele,dateEntree order by dateEntree desc;";
                    SqlCommand com = new SqlCommand(req, cn);
                    SqlDataReader dr = com.ExecuteReader();
                    dgv_modeles.Rows.Clear();
                    while (dr.Read())
                    {
                        dgv_modeles.Rows.Add(dr["referenceModele"], dr["taille"], dr["designation"], dr["marqueModele"], dr["prixModele"], dr["QuantiteRestante"], dr["QuantiteEnStock"]);
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
                    //string req = "SELECT m.referenceModele, taille, designation, marqueModele, prixModele, SUM(mt.qteStock) AS qteStock FROM modele m left JOIN matla mt ON mt.referenceModele = m.referenceModele  where c.nomCategorie='" + cb_categorie.Text + "' " + filtre + " group by m.referenceModele,taille,designation,marqueModele,prixModele";
                    //string req = "SELECT m.referenceModele, taille, designation, marqueModele, prixModele, SUM(mt.qteStock) AS qteStock FROM modele m left JOIN matla mt ON mt.referenceModele = m.referenceModele  where c.nomCategorie='" + cb_categorie.Text + "' " + filtre + " group by m.referenceModele,taille,designation,marqueModele,prixModele";
                    string req = "SELECT m.referenceModele,m.taille,m.designation,m.marqueModele,m.prixModele,COALESCE(SUM(mt.qteStock), 0) AS QuantiteEnStock,COALESCE(( SELECT SUM(dl.qteLivre) FROM detailLivraison dl JOIN matla mt_dl ON mt_dl.idMatla = dl.idMatla WHERE mt_dl.referenceModele = m.referenceModele), 0) AS QuantiteLivree, COALESCE(SUM(mt.nbPieceSorter), 0) - COALESCE(( SELECT SUM(dl.qteLivre) FROM detailLivraison dl JOIN matla mt_dl ON mt_dl.idMatla = dl.idMatla  WHERE mt_dl.referenceModele = m.referenceModele ), 0) AS QuantiteRestante FROM modele m LEFT JOIN matla mt ON m.referenceModele = mt.referenceModele inner join categorie c on c.idCategorie=m.idCategorie where c.nomCategorie='" + cb_categorie.Text + "' " + filtre + " GROUP BY m.referenceModele, m.taille, m.designation, m.marqueModele, m.prixModele,dateEntree order by dateEntree desc;";
                    SqlCommand com = new SqlCommand(req, cn);
                    SqlDataReader dr = com.ExecuteReader();
                    dgv_modeles.Rows.Clear();
                    while (dr.Read())
                    {
                        dgv_modeles.Rows.Add(dr["referenceModele"], dr["taille"], dr["designation"], dr["marqueModele"], dr["prixModele"], dr["QuantiteRestante"], dr["QuantiteEnStock"]);
                    }
                    dr.Close();
                    dr = null;
                    com = null;

                    cn.Close();
                    cn = null;
                }
                colorOfCellsQteStock();
                
            }
            catch (Exception error) { MessageBox.Show(error.Message.ToString()); }
        }

        private void cb_categorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillGridModele("");
            colorOfCellsQteStock();
        }
        private void DisplayProductImage(byte[] imageData)
        {
            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    imageModele.Image = Image.FromStream(ms);
                }
            }
            else
            {
                // Set a default image or display a placeholder image
                imageModele.Image = Properties.Resources.aucune_image; // Replace with your default image
            }
        }
        private void dgv_modeles_SelectionChanged(object sender, EventArgs e)
        {
            //// FIRST METHODE
            //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //cn.Open();
            //string req = "select * from modele where referenceModele='" + dgv_modeles.CurrentRow.Cells[0].Value + "'";
            //SqlCommand com = new SqlCommand(req, cn);
            //SqlDataReader dr = com.ExecuteReader();
            //if (dr.Read())
            //{
            //    txt_imageModele.Text = dr["imageModele"].ToString();
            //}
            //dr.Close();
            //dr = null;
            //com = null;
            //cn.Close();
            //cn = null;

            // SECOND METHODE 
            string connectionString = @"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select * from modele where referenceModele=@referenceModele";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@referenceModele", dgv_modeles.CurrentRow.Cells[0].Value);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        if (!Convert.IsDBNull(reader["ProductImage"]))
                        {
                            byte[] imageData = (byte[])reader["ProductImage"];
                            DisplayProductImage(imageData);
                        }
                        else
                        {
                            // If the ProductImage column is NULL or empty, display a default image or handle it as needed
                            imageModele.Image = Properties.Resources.aucune_image; // Replace with your default image
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found!");
                    }
                }
            }

        }

        private void txt_imageModele_TextChanged(object sender, EventArgs e)
        {
            if (txt_imageModele.Text == "")
                imageModele.Load("imageModeles/aucune image.jpg");
            else
                imageModele.Load("imageModeles/" + txt_imageModele.Text);
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            if(cb_categorie.SelectedIndex == 0)
            {
                fillGridModele(" where m.referenceModele='" + txt_rechercher.Text + "' or m.designation like'%"+txt_rechercher.Text+"%'");
            }
            else
            {
                fillGridModele(" and m.referenceModele='" + txt_rechercher.Text + "' or m.designation like '%"+txt_rechercher.Text+"%'");
            }
        }

        private void frmGestionStock_Activated(object sender, EventArgs e)
        {
            btn_refresh.PerformClick();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            frmAjouterModele f = new frmAjouterModele();
            f.ShowDialog(); 
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            string referenceModele = dgv_modeles.CurrentRow.Cells[0].Value.ToString() ;
            frmModifierModele f = new frmModifierModele(referenceModele);
            f.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            cb_categorie.Items.Clear();
            cb_categorie.Items.Add("Tous les categories");

            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn1.Open();
            string req = "select * from categorie";
            SqlCommand com = new SqlCommand(req, cn1);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                string nomCategorie = dr["nomCategorie"].ToString();
                cb_categorie.Items.Add(nomCategorie);
            }
            dr.Close();
            dr = null;
            com = null;

            cn1.Close();
            cn1 = null;
            cb_categorie.SelectedIndex = 0;
            fillGridModele("");
            //choose image modele
            if (txt_imageModele.Text == "") imageModele.Load("imageModeles/aucune image.jpg");
            else imageModele.Load("imageModeles/" + txt_imageModele.Text);
            txt_rechercher.Text = "";
            colorOfCellsQteStock();

            if (dgv_modeles.Rows.Count > 0)
            {
                string connectionString = @"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "select * from modele where referenceModele=@referenceModele";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@referenceModele", dgv_modeles.CurrentRow.Cells[0].Value);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            if (!Convert.IsDBNull(reader["ProductImage"]))
                            {
                                byte[] imageData = (byte[])reader["ProductImage"];
                                DisplayProductImage(imageData);
                            }
                            else
                            {
                                // If the ProductImage column is NULL or empty, display a default image or handle it as needed
                                imageModele.Image = Properties.Resources.aucune_image; // Replace with your default image
                            }
                        }
                        else
                        {
                            MessageBox.Show("Product not found!");
                        }
                    }
                }
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {

        }

        private void btn_afficherCommandes_Click(object sender, EventArgs e)
        {
            string refM = dgv_modeles.CurrentRow.Cells[0].Value.ToString();
            frmClientCommanderModele f = new frmClientCommanderModele(refM);
            f.ShowDialog();
        }

        private void btn_afficherLivraison_Click(object sender, EventArgs e)
        {
            string refM = dgv_modeles.CurrentRow.Cells[0].Value.ToString();
            frmLivraisonModele f = new frmLivraisonModele(refM);
            f.ShowDialog();
        }
        private void imprimer(ReportClass cr, string chemain = "", string filtre = "")
        {
            cr.SetDatabaseLogon("sa", "123456");
            if (chemain != "")
                cr.SetParameterValue("chemain", chemain);

            frmImpression f = new frmImpression(cr, filtre);
            f.ShowDialog();
        }
        //private void btn_imprimerLivraison_Click(object sender, EventArgs e)
        //{
        //    //string ch = Application.StartupPath + @"\imageModeles\";
        //    //lstLivraisonModele cr = new lstLivraisonModele();
        //    //cr.Refresh();
        //    //cr.SetDatabaseLogon("sa", "123456");

        //    //cr.SetParameterValue("chemain", ch);
        //    //   
        //    ////string filtre = "{modele.referenceModele}='" + dgv_modeles.CurrentRow.Cells[0].Value + "'";
        //    ////imprimer(new lstLivraisonModele(), Application.StartupPath + @"\imageModeles\", filtre);
        //    //frmImpression f = new frmImpression(cr, filtre);
        //    //f.ShowDialog();
        //    //label1.Text = Application.StartupPath;
        //    string ch = Application.StartupPath + @"\imageModeles\";

        //    lstLivraisonModele cr = new lstLivraisonModele();
        //    cr.Refresh();
        //    cr.SetDatabaseLogon("sa", "123456");

        //    cr.SetParameterValue("chemain", ch);
        //    //   
        //    string filtre = "{modele.referenceModele}='" + dgv_modeles.CurrentRow.Cells[0].Value + "'";
        //    frmImpression f = new frmImpression(cr, filtre);
        //    f.ShowDialog();
        //}

        private void chk_enAttentePieces_CheckedChanged(object sender, EventArgs e)
        {
            fillGridModele("");
        }

        private void btn_listeMatla_Click(object sender, EventArgs e)
        {
            string refM = dgv_modeles.CurrentRow.Cells[0].Value.ToString();
            frmListeMatlaModele f = new frmListeMatlaModele(refM);
            f.ShowDialog();
        }

        private void imageModele_Click(object sender, EventArgs e)
        {
            string refM = dgv_modeles.CurrentRow.Cells[0].Value.ToString();
            frmDisplayImageModele f = new frmDisplayImageModele(refM);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string filtre = "{modele.referenceModele}=" + dgv_modeles.CurrentRow.Cells[0].Value;
            //imprimer(new etiquette(),"",filtre);

            etq cr = new etq();
            cr.Refresh();
            cr.SetDatabaseLogon("sa", "123456");
            //   
            string filtre = "{modele.referenceModele}='" + dgv_modeles.CurrentRow.Cells[0].Value+"'";
            frmImpression f = new frmImpression(cr, filtre);
            f.ShowDialog();
        }
    }
}
