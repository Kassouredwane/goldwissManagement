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

namespace projet_gestionEntreprise
{
    public partial class frmModifierModele : Form
    {
        string referenceMd;
        public frmModifierModele(string referenceMD)
        {
            InitializeComponent();
            this.referenceMd = referenceMD;
        }

        private void frmModifierModele_Load(object sender, EventArgs e)
        {
            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn1.Open();
            string req = "select * from categorie";
            SqlCommand com1 = new SqlCommand(req, cn1);
            SqlDataReader dr1 = com1.ExecuteReader();
            DataTable table1 = new DataTable();
            table1.Load(dr1);
            cb_categorie.DisplayMember = "nomCategorie";
            cb_categorie.ValueMember = "idCategorie";
            cb_categorie.DataSource = table1;
            //fermeture de la datareader et la connexion et effacer la commande
            dr1.Close();
            dr1 = null;
            com1 = null;
            cn1.Close();
            cn1 = null;

            //// FIRST METHODE 
            //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //cn.Open();
            //SqlCommand com = new SqlCommand("select * from modele where referenceModele='"+referenceMd+"'", cn);
            //SqlDataReader dr = com.ExecuteReader();
            //if (dr.Read())
            //{
            //    txt_reference.Text = dr["referenceModele"].ToString();
            //    txt_taille.Text = dr["taille"].ToString();
            //    txt_designation.Text = dr["designation"].ToString();
            //    txt_imageModele.Text = dr["imageModele"].ToString();
            //    txt_marque.Text = dr["marqueModele"].ToString();
            //    txt_prix.Text = dr["prixModele"].ToString();
            //    //txt_qteStock.Text = dr["qteStock"].ToString();

            //    int idCategorie = Convert.ToInt32(dr["idCategorie"].ToString());
            //    cb_categorie.SelectedValue = idCategorie;
            //}
            //if (txt_imageModele.Text == "") imageModele.Load("imageModeles/aucune image.jpg");
            //else imageModele.Load("imageModeles/" + txt_imageModele.Text);
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
                string query = "select * from modele where referenceModele=@referenceMd";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@referenceMd", referenceMd);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txt_reference.Text = reader["referenceModele"].ToString();
                        txt_taille.Text = reader["taille"].ToString();
                        txt_designation.Text = reader["designation"].ToString();
                        txt_imageModele.Text = reader["imageModele"].ToString();
                        txt_marque.Text = reader["marqueModele"].ToString();
                        txt_prix.Text = reader["prixModele"].ToString();
                        //txt_qteStock.Text = dr["qteStock"].ToString();

                        int idCategorie = Convert.ToInt32(reader["idCategorie"].ToString());
                        cb_categorie.SelectedValue = idCategorie;

                        if (!Convert.IsDBNull(reader["ProductImage"]))
                        {
                            byte[] imageData = (byte[])reader["ProductImage"];
                            MemoryStream ms = new MemoryStream(imageData);
                            ProductImage.Image = Image.FromStream(ms);
                        }
                        else
                        {
                            // If the ProductImage column is NULL or empty, display a default image or handle it as needed
                            imageModele.Image = Properties.Resources.aucune_image; // Replace with your default image
                        }
                        if (txt_imageModele.Text == "") imageModele.Load("imageModeles/aucune image.jpg");
                        else imageModele.Load("imageModeles/" + txt_imageModele.Text);
                    }
                    else
                    {
                        MessageBox.Show("Le Modele n'existe pas !");
                    }
                }
            }

        }

        private void btn_ajouterCategorie_Click(object sender, EventArgs e)
        {
            frmAjouterCategorie frm = new frmAjouterCategorie();
            frm.ShowDialog();   
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //cn.Open();
            //SqlCommand com = new SqlCommand("update modele set idCategorie="+cb_categorie.SelectedValue + ",taille='"+txt_taille.Text+"',designation='"+txt_designation.Text+"',imageModele='"+txt_imageModele.Text+"',marqueModele='"+txt_marque.Text+"',prixModele="+Convert.ToInt32(txt_prix.Text)+" where referenceModele='"+txt_reference.Text+"'", cn);
            //SqlDataReader dr = com.ExecuteReader();
            ////com.Parameters.Add(new SqlParameter("@referenceModele", txt_reference.Text));
            ////com.Parameters.Add(new SqlParameter("@idCategorie", cb_categorie.SelectedValue));
            ////com.Parameters.Add(new SqlParameter("@taille", txt_taille.Text));
            ////com.Parameters.Add(new SqlParameter("@designation", txt_designation.Text));
            ////com.Parameters.Add(new SqlParameter("@imageModele", txt_imageModele.Text));
            ////com.Parameters.Add(new SqlParameter("@marqueModele", txt_marque.Text));
            ////com.Parameters.Add(new SqlParameter("@prixModele", txt_prix.Text));
            ////com.Parameters.Add(new SqlParameter("@qteStock", Convert.ToInt32(txt_qteStock.Text)));
            //dr.Close();
            //dr = null;
            //com.ExecuteNonQuery();
            //com = null;
            //cn.Close();
            //cn = null;
            //MessageBox.Show("le modele a été modifier avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Close();


            // SECOND METHODE
            byte[] newImageData;

            // Convert the newly selected image to a byte array
            if (imageModele.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imageModele.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    newImageData = ms.ToArray();
                }

                // Update product details and image in the database
                string connectionString = @"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "update modele set idCategorie=@idCategorie,taille=@taille,designation=@designation,imageModele=@imageModele,marqueModele=@marqueModele,prixModele=@prixModele,ProductImage=@ProductImage where referenceModele=@referenceModele";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@referenceModele", txt_reference.Text));
                        command.Parameters.Add(new SqlParameter("@idCategorie", cb_categorie.SelectedValue));
                        command.Parameters.Add(new SqlParameter("@taille", txt_taille.Text));
                        command.Parameters.Add(new SqlParameter("@designation", txt_designation.Text));
                        command.Parameters.Add(new SqlParameter("@imageModele", txt_imageModele.Text));
                        command.Parameters.Add(new SqlParameter("@marqueModele", txt_marque.Text));
                        command.Parameters.Add(new SqlParameter("@prixModele", txt_prix.Text));
                        command.Parameters.Add(new SqlParameter("@ProductImage", newImageData));

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("le modele a été modifier avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Echec de modifer le modele !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Séléctionner une image pour le modele", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_choisirImage_Click(object sender, EventArgs e)
        {
            //if (ofdImage.ShowDialog() == DialogResult.OK)
            //{
            //    Random r = new Random();
            //    string name = DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "") + (Math.Abs(r.Next()) * 1000);
            //    string ext = Path.GetExtension(ofdImage.FileName);
            //    File.Copy(ofdImage.FileName, "imageModeles/" + name + ext);
            //    txt_imageModele.Text = name + ext;

            //    imageModele.Load("imageModeles/" + txt_imageModele.Text);
            //}

            // SECOND METHODE
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                Random r = new Random();
                string name = DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "") + (Math.Abs(r.Next()) * 1000);
                string ext = Path.GetExtension(ofdImage.FileName);
                File.Copy(ofdImage.FileName, "imageModeles/" + name + ext);
                txt_imageModele.Text = name + ext;

                imageModele.Load("imageModeles/" + txt_imageModele.Text);

                // SECOND METHODE :
                // second methode for insert image in productImage column in database
                string imagePath = ofdImage.FileName;
                //Show image in second pictur box (ProductImage)
                ProductImage.Image = Image.FromFile(imagePath);
            }
        }
    }
}
