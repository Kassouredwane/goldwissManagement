﻿using System;
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
    public partial class frmAjouterModele : Form
    {
        public frmAjouterModele()
        {
            InitializeComponent();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            string reqq = "insert into modele(referenceModele,idCategorie,taille,designation,imageModele,marqueModele,prixModele,idStock) values (@referenceModele,@idCategorie,@taille,@designation,@imageModele,@marqueModele,@prixModele,1)";
            SqlCommand com = new SqlCommand(reqq, cn);
            com.Parameters.Add(new SqlParameter("@referenceModele", txt_reference.Text));
            com.Parameters.Add(new SqlParameter("@idCategorie", cb_categorie.SelectedValue));
            com.Parameters.Add(new SqlParameter("@taille", txt_taille.Text));
            com.Parameters.Add(new SqlParameter("@designation", txt_designation.Text));
            com.Parameters.Add(new SqlParameter("@imageModele", txt_imageModele.Text));
            com.Parameters.Add(new SqlParameter("@marqueModele", txt_marque.Text));
            com.Parameters.Add(new SqlParameter("@prixModele", txt_prix.Text));
            com.ExecuteNonQuery();

            com = null;
            cn.Close();
            cn = null;
            MessageBox.Show("le modele a été ajouter avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //empty all text box
            txt_reference.Text = "";
            txt_taille.Text = "";
            txt_designation.Text = "";
            txt_imageModele.Text = "";
            txt_marque.Text = "";
            txt_prix.Text = "";
            cb_categorie.SelectedIndex = 0; 
            this.Close();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btn_ajouterCategorie_Click(object sender, EventArgs e)
        {
            frmAjouterCategorie f =new frmAjouterCategorie();
            f.ShowDialog();
        }

        private void frmAjouterModele_Load(object sender, EventArgs e)
        {
            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
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
        }

        private void frmAjouterModele_Activated(object sender, EventArgs e)
        {
            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
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
        }

        private void btn_choisirImage_Click(object sender, EventArgs e)
        {
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                Random r = new Random();
                string name = DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "") + (Math.Abs(r.Next()) * 1000);
                string ext = Path.GetExtension(ofdImage.FileName);
                File.Copy(ofdImage.FileName, "image modeles/" + name + ext);
                txt_imageModele.Text = name + ext;

                imageModele.Load("image modeles/" + txt_imageModele.Text);
            }
        }
    }
}
