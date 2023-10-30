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

            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            SqlCommand com = new SqlCommand("select * from modele where referenceModele='"+referenceMd+"'", cn);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                txt_reference.Text = dr["referenceModele"].ToString();
                txt_taille.Text = dr["taille"].ToString();
                txt_designation.Text = dr["designation"].ToString();
                txt_imageModele.Text = dr["imageModele"].ToString();
                txt_marque.Text = dr["marqueModele"].ToString();
                txt_prix.Text = dr["prixModele"].ToString();
                txt_qteStock.Text = dr["qteStock"].ToString();

                int idCategorie = Convert.ToInt32(dr["idCategorie"].ToString());
                cb_categorie.SelectedValue = idCategorie;
            }
            if (txt_imageModele.Text == "") imageModele.Load("image modeles/aucune image.jpg");
            else imageModele.Load("image modeles/" + txt_imageModele.Text);
            dr.Close();
            dr = null;
            com = null;
            cn.Close();
            cn = null;
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
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            SqlCommand com = new SqlCommand("update modele set idCategorie="+cb_categorie.SelectedValue + ",taille='"+txt_taille.Text+"',designation='"+txt_designation.Text+"',imageModele='"+txt_imageModele.Text+"',marqueModele='"+txt_marque.Text+"',prixModele="+Convert.ToInt32(txt_prix.Text)+",qteStock="+ Convert.ToInt32(txt_qteStock.Text)+" where referenceModele='"+txt_reference.Text+"'", cn);
            SqlDataReader dr = com.ExecuteReader();
            //com.Parameters.Add(new SqlParameter("@referenceModele", txt_reference.Text));
            //com.Parameters.Add(new SqlParameter("@idCategorie", cb_categorie.SelectedValue));
            //com.Parameters.Add(new SqlParameter("@taille", txt_taille.Text));
            //com.Parameters.Add(new SqlParameter("@designation", txt_designation.Text));
            //com.Parameters.Add(new SqlParameter("@imageModele", txt_imageModele.Text));
            //com.Parameters.Add(new SqlParameter("@marqueModele", txt_marque.Text));
            //com.Parameters.Add(new SqlParameter("@prixModele", txt_prix.Text));
            //com.Parameters.Add(new SqlParameter("@qteStock", Convert.ToInt32(txt_qteStock.Text)));
            dr.Close();
            dr = null;
            com.ExecuteNonQuery();
            com = null;
            cn.Close();
            cn = null;
            MessageBox.Show("le modele a été modifier avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
