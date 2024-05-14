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
    public partial class frmAjouterTransferePhasonieToStock : Form
    {
        public frmAjouterTransferePhasonieToStock()
        {
            InitializeComponent();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////
            //if (txt_idMatla.Text != "" && txt_numeroBon.Text != "" && txt_qteStocker.Text != "")
            //if (txt_idMatla.Text != "" && txt_qteStocker.Text != "")
            //{
            //    // insertion a table phasonie stocker
            //    SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn.Open();
            //    string reqq = "insert into phasonieStocker values(@idMatla,@qteStocker,@dateStocker,@numeroBon,@description)";
            //    SqlCommand com = new SqlCommand(reqq, cn);
            //    com.Parameters.Add(new SqlParameter("@idMatla", txt_idMatla.Text));
            //    com.Parameters.Add(new SqlParameter("@qteStocker", txt_qteStocker.Text));
            //    com.Parameters.Add(new SqlParameter("@dateStocker", dtp_dateStocker.Value));
            //    com.Parameters.Add(new SqlParameter("@numeroBon", txt_numeroBon.Text));
            //    com.Parameters.Add(new SqlParameter("@description", txt_description.Text));
            //    com.ExecuteNonQuery();
            //    com = null;
            //    cn.Close();
            //    cn = null;
            //    // update qteStock de matla => qteStock = qteStock + qteStocke
            //    SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn1.Open();
            //    string reqq1 = "update matla set qteStock=qteStock+@qteStocker where idMatla=" + txt_idMatla.Text;
            //    SqlCommand com1 = new SqlCommand(reqq1, cn1);
            //    com1.Parameters.Add(new SqlParameter("@qteStocker", Convert.ToInt32(txt_qteStocker.Text)));
            //    com1.ExecuteNonQuery();
            //    com1 = null;
            //    cn1.Close();
            //    cn1 = null;
            //    // update statut matla a "en stock"
            //    SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn2.Open();
            //    string reqq2 = "update matla set idStatutMatla=4 where idMatla=" + txt_idMatla.Text;
            //    SqlCommand com2 = new SqlCommand(reqq2, cn2);
            //    com2.ExecuteNonQuery();
            //    com2 = null;
            //    cn2.Close();
            //    cn2 = null;
            //    // update entree of matla 
            //    SqlConnection cn6 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn6.Open();
            //    string reqq6 = "update matla set entrees=entrees+" + Convert.ToInt32(txt_qteStocker.Text)+" where idMatla="+txt_idMatla.Text;
            //    SqlCommand com6 = new SqlCommand(reqq6, cn6);
            //    com6.ExecuteNonQuery();
            //    com6 = null;
            //    cn6.Close();
            //    cn6 = null;
            //    // update statutComplet de matla si la somme de stockage de ce matla est egale=nbPieceSorter
            //    SqlConnection cn5 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn5.Open();
            //    SqlCommand com5 = new SqlCommand("select nbPieceSorter from matla where idMatla=" + txt_idMatla.Text, cn5);
            //    int nbPieceSorter = Convert.ToInt32(com5.ExecuteScalar());

            //    SqlConnection cn4 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn4.Open();
            //    SqlCommand com4 = new SqlCommand("select sum(qteStocker) from phasonieStocker where idMatla=" + txt_idMatla.Text + " group by idMatla", cn4);
            //    int nbPieceStocker = Convert.ToInt32(com4.ExecuteScalar());
            //    //int qteStocker = Convert.ToInt32(txt_qteStocker.Text);
            //    if (nbPieceStocker>= nbPieceSorter)
            //    {
            //        SqlConnection cn3 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //        cn3.Open();
            //        string reqq3 = "update matla set statutComplet=1 where idMatla=" + txt_idMatla.Text;
            //        SqlCommand com3 = new SqlCommand(reqq3, cn3);
            //        com3.ExecuteNonQuery();
            //        com3 = null;
            //        cn3.Close();
            //        cn3 = null;
            //    }

            //    MessageBox.Show("le stockage de matla a été ajouter avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    //this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("un champ est vide", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////
            ///



            //if (txt_idMatla.Text != "" && txt_qteStocker.Text != "")
            //{
            //    //// avant la confirmation de l'entrée:
            //    SqlConnection cn9 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn9.Open();
            //    SqlCommand com9 = new SqlCommand("select idSituationModele from matlaContient where idMatlaContient=" + cb_matlaContient.SelectedValue, cn9);
            //    int situationModele = Convert.ToInt32(com9.ExecuteScalar());

            //    com9 = null;
            //    cn9.Close();
            //    cn9 = null;
            //    //- insertion a la table phasonieStocker
            //    SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn.Open();
            //    string reqq = "insert into phasonieStocker(qteStocker,dateStocker,numeroBon,description,idMatlaContient) values(@qteStocker,@dateStocker,@numeroBon,@description,@idMatlaContient)";
            //    SqlCommand com = new SqlCommand(reqq, cn);
            //    com.Parameters.Add(new SqlParameter("@qteStocker", txt_qteStocker.Text));
            //    com.Parameters.Add(new SqlParameter("@dateStocker", dtp_dateStocker.Value));
            //    com.Parameters.Add(new SqlParameter("@numeroBon", txt_numeroBon.Text));
            //    com.Parameters.Add(new SqlParameter("@description", txt_description.Text));
            //    com.Parameters.Add(new SqlParameter("@idMatlaContient", cb_matlaContient.SelectedValue));
            //    com.ExecuteNonQuery();
            //    com = null;
            //    cn.Close();
            //    cn = null;
            //    //- update statut matla a "en stock"
            //    SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn2.Open();
            //    string reqq2 = "update matla set idStatutMatla=4 where idMatla=" + txt_idMatla.Text;
            //    SqlCommand com2 = new SqlCommand(reqq2, cn2);
            //    com2.ExecuteNonQuery();
            //    com2 = null;
            //    cn2.Close();
            //    cn2 = null;
            //    //- update l'entree de matla
            //    SqlConnection cn6 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn6.Open();
            //    string reqq6 = "update matla set entrees=entrees+" + Convert.ToInt32(txt_qteStocker.Text) + " where idMatla=" + txt_idMatla.Text;
            //    SqlCommand com6 = new SqlCommand(reqq6, cn6);
            //    com6.ExecuteNonQuery();
            //    com6 = null;
            //    cn6.Close();
            //    cn6 = null;
            //    //- update l'entree de matlaContient
            //    SqlConnection cn7 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn7.Open();
            //    string reqq7 = "update matlaContient set entree=entree+" + Convert.ToInt32(txt_qteStocker.Text) + " where idMatlaContient=" + cb_matlaContient.SelectedValue;
            //    SqlCommand com7 = new SqlCommand(reqq7, cn7);
            //    com7.ExecuteNonQuery();
            //    com7 = null;
            //    cn7.Close();
            //    cn7 = null;
            //    //- update entree de situationModele
            //    SqlConnection cn8 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn8.Open();
            //    string reqq8 = "update situationModele set entree=entree+" + Convert.ToInt32(txt_qteStocker.Text) + " where idSituationModele=" + situationModele;
            //    SqlCommand com8 = new SqlCommand(reqq8, cn8);
            //    com8.ExecuteNonQuery();
            //    com8 = null;
            //    cn8.Close();
            //    cn8 = null;
            //    //- update la quantité disponible de situationModele
            //    SqlConnection cn11 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn11.Open();
            //    string reqq11 = "update situationModele set disponible=disponible+" + Convert.ToInt32(txt_qteStocker.Text) + " where idSituationModele=" + situationModele;
            //    SqlCommand com11 = new SqlCommand(reqq11, cn11);
            //    com11.ExecuteNonQuery();
            //    com11 = null;
            //    cn11.Close();
            //    cn11 = null;
            //    ////- update statutComplet de matla
            //    //SqlConnection cn5 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    //cn5.Open();
            //    //SqlCommand com5 = new SqlCommand("select nbPieceSorter from matla where idMatla=" + txt_idMatla.Text, cn5);
            //    //int nbPieceSorter = Convert.ToInt32(com5.ExecuteScalar());

            //    //SqlConnection cn4 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    //cn4.Open();
            //    //SqlCommand com4 = new SqlCommand("select sum(qteConfirmer) from phasonieStocker pss inner join matlaContient mtc on mtc.idMatlaContient=pss.idMatlaContient inner join matla mt on mt.idMatla=mtc.idMatla where mt.idMatla=" + txt_idMatla.Text + " group by mt.idMatla", cn4);
            //    //int nbPieceStocker = Convert.ToInt32(com4.ExecuteScalar());
            //    ////int qteStocker = Convert.ToInt32(txt_qteStocker.Text);
            //    //if (nbPieceStocker >= nbPieceSorter)
            //    //{
            //    //    SqlConnection cn3 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    //    cn3.Open();
            //    //    string reqq3 = "update matla set statutComplet=1 where idMatla=" + txt_idMatla.Text;
            //    //    SqlCommand com3 = new SqlCommand(reqq3, cn3);
            //    //    com3.ExecuteNonQuery();
            //    //    com3 = null;
            //    //    cn3.Close();
            //    //    cn3 = null;
            //    //}
            //    MessageBox.Show("le stockage de matla a été ajouter avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    //this.Close();
            //}



            if (txt_idMatla.Text != "" && txt_qteStocker.Text != "")
            {
                //- insertion a la table phasonieStocker
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string reqq = "insert into phasonieStocker(idMatla,qteStocker,dateStocker,numeroBon,description) values(@idMatla,@qteStocker,@dateStocker,@numeroBon,@description)";
                SqlCommand com = new SqlCommand(reqq, cn);
                com.Parameters.Add(new SqlParameter("@idMatla", txt_idMatla.Text));
                com.Parameters.Add(new SqlParameter("@qteStocker", txt_qteStocker.Text));
                com.Parameters.Add(new SqlParameter("@dateStocker", dtp_dateStocker.Value));
                com.Parameters.Add(new SqlParameter("@numeroBon", txt_numeroBon.Text));
                com.Parameters.Add(new SqlParameter("@description", txt_description.Text));
                com.ExecuteNonQuery();
                com = null;
                cn.Close();
                cn = null;
                //- update statut matla a "en stock"
                SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn2.Open();
                string reqq2 = "update matla set idStatutMatla=4 where idMatla=" + txt_idMatla.Text;
                SqlCommand com2 = new SqlCommand(reqq2, cn2);
                com2.ExecuteNonQuery();
                com2 = null;
                cn2.Close();
                cn2 = null;
                //- update l'entree de matla
                SqlConnection cn6 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn6.Open();
                string reqq6 = "update matla set entrees=entrees+" + Convert.ToInt32(txt_qteStocker.Text) + " where idMatla=" + txt_idMatla.Text;
                SqlCommand com6 = new SqlCommand(reqq6, cn6);
                com6.ExecuteNonQuery();
                com6 = null;
                cn6.Close();
                cn6 = null;
                //- update la quantité disponible de situationModele
                SqlConnection cn11 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn11.Open();
                string reqq11 = "update matla set disponible=disponible+" + Convert.ToInt32(txt_qteStocker.Text) + " where idMatla=" + txt_idMatla.Text;
                SqlCommand com11 = new SqlCommand(reqq11, cn11);
                com11.ExecuteNonQuery();
                com11 = null;
                cn11.Close();
                cn11 = null;
                //- update statutComplet de matla
                SqlConnection cn5 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn5.Open();
                SqlCommand com5 = new SqlCommand("select nbPieceSorter from matla where idMatla=" + txt_idMatla.Text, cn5);
                int nbPieceSorter = Convert.ToInt32(com5.ExecuteScalar());

                SqlConnection cn4 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn4.Open();
                SqlCommand com4 = new SqlCommand("select sum(qteConfirmer) from phasonieStocker pss inner join matla mt on mt.idMatla=pss.idMatla where mt.idMatla=" + txt_idMatla.Text + " group by mt.idMatla", cn4);
                int nbPieceStocker = Convert.ToInt32(com4.ExecuteScalar());
                //int qteStocker = Convert.ToInt32(txt_qteStocker.Text);
                if (nbPieceStocker >= nbPieceSorter)
                {
                    SqlConnection cn3 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                    cn3.Open();
                    string reqq3 = "update matla set statutComplet=1 where idMatla=" + txt_idMatla.Text;
                    SqlCommand com3 = new SqlCommand(reqq3, cn3);
                    com3.ExecuteNonQuery();
                    com3 = null;
                    cn3.Close();
                    cn3 = null;
                }
                MessageBox.Show("le stockage de matla a été ajouter avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
            }

            else
            {
                MessageBox.Show("un champ est vide", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmAjouterTransferePhasonieToStock_Load(object sender, EventArgs e)
        {
            //panel1.Enabled = false;
        }

    }
}
