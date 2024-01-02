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
    public partial class frmAjouterDetailleur : Form
    {
        public frmAjouterDetailleur()
        {
            InitializeComponent();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (txt_nomDetailleur.Text != "" && txt_prenomDetailleur.Text != "")
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string reqq = "insert into detailleur values (@nomDetailleur,@prenomDetailleur,@telephoneDetailleur)";
                //string reqq = "insert into detailleur values (@idDetailleur,@nomDetailleur,@prenomDetailleur,@telephoneDetailleur)";
                SqlCommand com = new SqlCommand(reqq, cn);
                //com.Parameters.Add(new SqlParameter("@idDetailleur", txt_idDetailleur.Text));
                com.Parameters.Add(new SqlParameter("@nomDetailleur", txt_nomDetailleur.Text));
                com.Parameters.Add(new SqlParameter("@prenomDetailleur", txt_prenomDetailleur.Text));
                com.Parameters.Add(new SqlParameter("@telephoneDetailleur", txt_telephoneDetailleur.Text));
                com.ExecuteNonQuery();
                com = null;
                cn.Close();
                cn = null;
                MessageBox.Show("le detailleur a été ajouter avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("un champ est vide !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmAjouterDetailleur_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                SqlCommand com = new SqlCommand("select max(idDetailleur)+1 from detailleur", cn);
                int nb = Convert.ToInt32(com.ExecuteScalar());

                txt_idDetailleur.Text = nb.ToString();
                com = null;
                cn.Close();
                cn = null;
            }
            catch(Exception) { txt_idDetailleur.Text = "1"; }
        }
    }
}
