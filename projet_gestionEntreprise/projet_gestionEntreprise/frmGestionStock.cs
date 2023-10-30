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
    public partial class frmGestionStock : Form
    {
        public frmGestionStock()
        {
            InitializeComponent();
        }

        private void frmGestionStock_Load(object sender, EventArgs e)
        {
            cb_categorie.Items.Clear();
            cb_categorie.Items.Add("Tous les categories");

            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
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
            fillGridModele();
            //choose image modele
            if (txt_imageModele.Text == "") imageModele.Load("image modeles/aucune image.jpg");
            else imageModele.Load("image modeles/" + txt_imageModele.Text);
        }
        private void fillGridModele()
        {
            //try
            //{
                if (cb_categorie.Text == "Tous les categories")
                {
                    SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                    cn.Open();
                    string req = "select * from modele m inner join categorie c on c.idCategorie=m.idCategorie ";
                    SqlCommand com = new SqlCommand(req, cn);
                    SqlDataReader dr = com.ExecuteReader();
                    dgv_modeles.Rows.Clear();
                    while (dr.Read())
                    {
                        dgv_modeles.Rows.Add(dr["referenceModele"], dr["taille"], dr["designation"], dr["marqueModele"], dr["prixModele"], dr["qteStock"]);
                    }
                    dr.Close();
                    dr = null;
                    com = null;

                    cn.Close();
                    cn = null;
                }
                else
                {
                    SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                    cn.Open();
                    string req = "select * from modele m inner join categorie c on c.idCategorie=m.idCategorie where nomCategorie='"+cb_categorie.Text+"'";
                    SqlCommand com = new SqlCommand(req, cn);
                    SqlDataReader dr = com.ExecuteReader();
                    dgv_modeles.Rows.Clear();
                    while (dr.Read())
                    {
                        dgv_modeles.Rows.Add(dr["referenceModele"], dr["taille"], dr["designation"], dr["referenceModele"], dr["marqueModele"], dr["prixModele"], dr["qteStock"]);
                    }
                    dr.Close();
                    dr = null;
                    com = null;

                    cn.Close();
                    cn = null;
                }
            //}
            //catch (Exception error) { MessageBox.Show(error.Message.ToString()); }
        }

        private void cb_categorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillGridModele();
        }

        private void dgv_modeles_SelectionChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            string req = "select * from modele where referenceModele='" + dgv_modeles.CurrentRow.Cells[0].Value + "'";
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            if(dr.Read())
            {
                txt_imageModele.Text = dr["imageModele"].ToString();
            }
            dr.Close();
            dr = null;
            com = null;
            cn.Close();
            cn = null;
        }

        private void txt_imageModele_TextChanged(object sender, EventArgs e)
        {
            if (txt_imageModele.Text == "")
                imageModele.Load("image modeles/aucune image.jpg");
            else
                imageModele.Load("image modeles/" + txt_imageModele.Text);
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            if(cb_categorie.SelectedIndex == 0)
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn.Open();
                string req = "select * from modele m inner join categorie c on c.idCategorie=m.idCategorie where referenceModele like '%"+txt_rechercher.Text+"%' or designation like '%"+txt_rechercher.Text+"%'";
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_modeles.Rows.Clear();
                while (dr.Read())
                {
                    dgv_modeles.Rows.Add(dr["referenceModele"], dr["taille"], dr["designation"], dr["referenceModele"], dr["marqueModele"], dr["prixModele"], dr["qteStock"]);
                }
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
            }
            else
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn.Open();
                string req = "select * from modele m inner join categorie c on c.idCategorie=m.idCategorie where nomCategorie='"+cb_categorie.Text+"' and (referenceModele like '%" + txt_rechercher.Text + "%' or designation like '%" + txt_rechercher.Text + "%')";
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_modeles.Rows.Clear();
                while (dr.Read())
                {
                    dgv_modeles.Rows.Add(dr["referenceModele"], dr["taille"], dr["designation"], dr["referenceModele"], dr["marqueModele"], dr["prixModele"], dr["qteStock"]);
                }
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
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

            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
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
            fillGridModele();
            //choose image modele
            if (txt_imageModele.Text == "") imageModele.Load("image modeles/aucune image.jpg");
            else imageModele.Load("image modeles/" + txt_imageModele.Text);
            txt_rechercher.Text = "";
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
