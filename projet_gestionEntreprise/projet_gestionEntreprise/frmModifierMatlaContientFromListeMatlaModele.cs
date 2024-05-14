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
    public partial class frmModifierMatlaContientFromListeMatlaModele : Form
    {
        int id;
        public frmModifierMatlaContientFromListeMatlaModele(int idMtC)
        {
            InitializeComponent();
            this.id = idMtC;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModifierMatlaContientFromListeMatlaModele_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            SqlCommand com = new SqlCommand("select * from matla where idMatla="+id, cn);
            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
            {
                txt_referenceModele.Text = dr["referenceModele"].ToString();
                txt_taille.Text = dr["taille"].ToString();
                txt_qteSorter.Text = dr["nbPieceSorter"].ToString();
                txt_entree.Text = dr["entrees"].ToString();
                txt_qteStock.Text = dr["qteStock"].ToString();
            }
        }

        //private void btn_valider_Click(object sender, EventArgs e)
        //{
        //    // update matla contient
        //    SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
        //    cn.Open();
        //    string reqq = "update matla set referenceModele=@referenceModele,qteSorter=@qteSorter,taille=@taille,entree=@entree,idSituationModele=@idSituationModele where idMatla=" + id;
        //    SqlCommand com = new SqlCommand(reqq, cn);
        //    com.Parameters.Add(new SqlParameter("@referenceModele", txt_referenceModele.Text));
        //    com.Parameters.Add(new SqlParameter("@qteSorter", txt_qteSorter.Text));
        //    com.Parameters.Add(new SqlParameter("@taille", txt_taille.Text));
        //    com.Parameters.Add(new SqlParameter("@entree", txt_entree.Text));
        //    com.Parameters.Add(new SqlParameter("@idSituationModele", Convert.ToInt32(cb_situationModele.SelectedValue)));
        //    com.ExecuteNonQuery();
        //    com = null;
        //    cn.Close();
        //    cn = null;
        //    MessageBox.Show("Matla a été modifier avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    this.Close();
        //}

        private void btn_validerReference_Click(object sender, EventArgs e)
        {
            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn1.Open();
            string req = "select * from situationModele where referenceModele='"+txt_referenceModele.Text+"'";
            SqlCommand com1 = new SqlCommand(req, cn1);
            SqlDataReader dr1 = com1.ExecuteReader();
            DataTable table1 = new DataTable();
            table1.Load(dr1);
            cb_situationModele.DisplayMember = "numeroSituation";
            cb_situationModele.ValueMember = "idSituationModele";
            cb_situationModele.DataSource = table1;
            //fermeture de la datareader et la connexion et effacer la commande
            dr1.Close();
            dr1 = null;
            com1 = null;
            cn1.Close();
            cn1 = null;
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            // update matla contient
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            string reqq = "update matla set referenceModele=@referenceModele,nbPieceSorter=@qteSorter,taille=@taille,entrees=@entrees,qteStock=@qteStock,disponible=@disponible where idMatla=" + id;
            SqlCommand com = new SqlCommand(reqq, cn);
            com.Parameters.Add(new SqlParameter("@referenceModele", txt_referenceModele.Text));
            com.Parameters.Add(new SqlParameter("@qteSorter", txt_qteSorter.Text));
            com.Parameters.Add(new SqlParameter("@taille", txt_taille.Text));
            com.Parameters.Add(new SqlParameter("@entrees", txt_entree.Text));
            com.Parameters.Add(new SqlParameter("@qteStock", txt_qteStock.Text));
            com.Parameters.Add(new SqlParameter("@disponible", txt_disponible.Text));
            //com.Parameters.Add(new SqlParameter("@idSituationModele", Convert.ToInt32(cb_situationModele.SelectedValue)));
            com.ExecuteNonQuery();
            com = null;
            cn.Close();
            cn = null;
            MessageBox.Show("Matla a été modifier avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_annuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
