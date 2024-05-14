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
    public partial class frmAjouterMatla : Form
    {
        public frmAjouterMatla()
        {
            InitializeComponent();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ajouterDetailleur_Click(object sender, EventArgs e)
        {
            frmAjouterDetailleur f = new frmAjouterDetailleur();
            f.ShowDialog();
        }

        private void btn_ajouterPhasonie_Click(object sender, EventArgs e)
        {
            frmAjouterPhasonie f = new frmAjouterPhasonie();
            f.ShowDialog();
        }
        private void refresh()
        {
            // fill cb_phasonie with phasonies
            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn1.Open();
            string req = "SELECT idPhasonie, nomPhasonie+' '+prenomPhasonie as nomComplet FROM phasonie";
            SqlCommand com1 = new SqlCommand(req, cn1);
            SqlDataReader dr1 = com1.ExecuteReader();
            DataTable table1 = new DataTable();
            table1.Load(dr1);
            cb_phasonie.DisplayMember = "nomComplet";
            cb_phasonie.ValueMember = "idPhasonie";
            cb_phasonie.DataSource = table1;
            //fermeture de la datareader et la connexion et effacer la commande
            dr1.Close();
            dr1 = null;
            com1 = null;
            cn1.Close();
            cn1 = null;
            // fill cb_phasonie with detailleur
            SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn2.Open();
            string req2 = "select idDetailleur,nomDetailleur+' '+prenomDetailleur as nomComplet,telephoneDetailleur from detailleur";
            SqlCommand com2 = new SqlCommand(req2, cn2);
            SqlDataReader dr2 = com2.ExecuteReader();
            DataTable table2 = new DataTable();
            table2.Load(dr2);
            cb_detailleur.DisplayMember = "nomComplet";
            cb_detailleur.ValueMember = "idDetailleur";
            cb_detailleur.DataSource = table2;
            //fermeture de la datareader et la connexion et effacer la commande
            dr2.Close();
            dr2 = null;
            com2 = null;
            cn2.Close();
            cn2 = null;
            // fill txt_idMatla with the id of matla will be added
            try
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                SqlCommand com = new SqlCommand("select max(idMatla)+1 from matla", cn);
                int nb = Convert.ToInt32(com.ExecuteScalar());

                txt_idMatla.Text = nb.ToString();
                com = null;
                cn.Close();
                cn = null;
            }
            catch(Exception error) { txt_idMatla.Text = "1"; }
        }
        private void frmAjouterMatla_Load(object sender, EventArgs e)
        {
            refresh();
            dtp_dateDetailler.Value = DateTime.Today;
        }

        private void frmAjouterMatla_Activated(object sender, EventArgs e)
        {
            //refresh();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (txt_qteSorter.Text != "")
            {
                SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn2.Open();
                SqlCommand com2 = new SqlCommand("select max(idSituationModele) from situationModele where referenceModele='"+txt_referenceModele.Text+"'", cn2);
                int nb = Convert.ToInt32(com2.ExecuteScalar());
                com2 = null;
                cn2.Close();
                cn2 = null;


                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string reqq = "insert into matla(idMatla,referenceModele,idDetailleur,idPhasonie,dateDetailler,nbPieceSorter,prixPhasonnier,numeroBon,qteStock,sorter,taille,idSituationModele) " +
                    "values(@idMatla, @referenceModele, @idDetailleur, @idPhasonie, @dateDetailler, @nbPieceSorter, @prixPhasonnier, @numeroBon, @qteStock, 1 , @taille, @idSituationModele)";
                SqlCommand com = new SqlCommand(reqq, cn);
                com.Parameters.Add(new SqlParameter("@idMatla", txt_idMatla.Text));
                com.Parameters.Add(new SqlParameter("@referenceModele", txt_referenceModele.Text));
                com.Parameters.Add(new SqlParameter("@idDetailleur", cb_detailleur.SelectedValue));
                com.Parameters.Add(new SqlParameter("@idPhasonie", cb_phasonie.SelectedValue));
                com.Parameters.Add(new SqlParameter("@dateDetailler", dtp_dateDetailler.Value)) ;
                com.Parameters.Add(new SqlParameter("@nbPieceSorter", txt_qteSorter.Text));
                com.Parameters.Add(new SqlParameter("@prixPhasonnier", txt_prixPhasonie.Text));
                com.Parameters.Add(new SqlParameter("@numeroBon", txt_numeroBon.Text));
                com.Parameters.Add(new SqlParameter("@qteStock", txt_qteSorter.Text));
                com.Parameters.Add(new SqlParameter("@taille", txt_taille.Text));
                com.Parameters.Add(new SqlParameter("@idSituationModele", nb));
                com.ExecuteNonQuery();
                com = null;
                cn.Close();
                cn = null;


                SqlConnection cn4 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn4.Open();
                SqlCommand com4 = new SqlCommand("select max(idMatla)+1 from matla", cn4);
                int nb4 = Convert.ToInt32(com4.ExecuteScalar());

                txt_idMatla.Text = nb4.ToString();
                com4 = null;
                cn4.Close();
                cn4 = null;

                MessageBox.Show("Matla a été ajouter avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
            }
            else
            {
                MessageBox.Show("un champ est vide", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //private void btn_ajouterModele_Click(object sender, EventArgs e)
        //{
        //    // retreive la max de la situation modele
        //    SqlConnection cn7 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
        //    cn7.Open();
        //    SqlCommand com7 = new SqlCommand("select max(idSituationModele) from situationModele where referenceModele='" + txt_referenceModele.Text + "'", cn7);
        //    int situationModele = Convert.ToInt32(com7.ExecuteScalar());

        //    com7 = null;
        //    cn7.Close();
        //    cn7 = null;
        //    // insertion de modele a matla
        //    SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
        //    cn.Open();
        //    string reqq = "insert into matlaContient(idMatla,referenceModele,qteSorter,entree,taille,idSituationModele) values(@idMatla,@referenceModele,@qteSorter,0,@taille,@idSituationModele)";
        //    SqlCommand com = new SqlCommand(reqq, cn);
        //    com.Parameters.Add(new SqlParameter("@idMatla", txt_idMatla.Text));
        //    com.Parameters.Add(new SqlParameter("@referenceModele", txt_referenceModele.Text));
        //    com.Parameters.Add(new SqlParameter("@qteSorter", txt_nbPieceSorterModele.Text));
        //    com.Parameters.Add(new SqlParameter("@taille", txt_tailleModele.Text));
        //    com.Parameters.Add(new SqlParameter("@idSituationModele", situationModele));
        //    com.ExecuteNonQuery();
        //    com = null;
        //    cn.Close();
        //    cn = null;

        //    // update la quantite en stock de situation de modele 
        //    SqlConnection cn3 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
        //    cn3.Open();
        //    string reqq3 = "update situationModele set qteStock=qteStock+"+Convert.ToInt32(txt_qteSorter.Text)+" where idSituationModele="+ situationModele;
        //    SqlCommand com3 = new SqlCommand(reqq3, cn3);
        //    com3.ExecuteNonQuery();

        //    com3 = null;
        //    cn3.Close();
        //    cn3 = null;
        //    // update la quantite detailler de situation de modele 
        //    SqlConnection cn4 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
        //    cn4.Open();
        //    string reqq4 = "update situationModele set qteDetailler=qteDetailler+" + Convert.ToInt32(txt_qteSorter.Text) + " where idSituationModele=" + situationModele;
        //    SqlCommand com4 = new SqlCommand(reqq4, cn4);
        //    com4.ExecuteNonQuery();

        //    com4 = null;
        //    cn4.Close();
        //    cn4 = null;

        //    MessageBox.Show("le modèle a été ajouter a matla avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //this.Close();
        //    groupBox1.Enabled = false;
        //    groupBox2.Enabled = true;
        //}
    }
}
