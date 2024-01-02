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
    public partial class frmDisplayImageModele : Form
    {
        string reference;
        public frmDisplayImageModele(string id)
        {
            InitializeComponent();
            this.reference = id;
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
        private void frmDisplayImageModele_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select ProductImage from modele where referenceModele=@referenceModele";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@referenceModele", reference);
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
}
