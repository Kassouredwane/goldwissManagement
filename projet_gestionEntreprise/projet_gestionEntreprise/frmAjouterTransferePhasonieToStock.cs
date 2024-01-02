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
            //if (txt_idMatla.Text != "" && txt_numeroBon.Text != "" && txt_qteStocker.Text != "")
            if (txt_idMatla.Text != "" && txt_qteStocker.Text != "")
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string reqq = "insert into phasonieStocker values(@idMatla,@qteStocker,@dateStocker,@numeroBon)";
                SqlCommand com = new SqlCommand(reqq, cn);
                com.Parameters.Add(new SqlParameter("@idMatla", txt_idMatla.Text));
                com.Parameters.Add(new SqlParameter("@qteStocker", txt_qteStocker.Text));
                com.Parameters.Add(new SqlParameter("@dateStocker", dtp_dateStocker.Value));
                com.Parameters.Add(new SqlParameter("@numeroBon", txt_numeroBon.Text));
                com.ExecuteNonQuery();
                com = null;
                cn.Close();
                cn = null;
                // update qteStock de matla => qteStock = qteStock + qteStocke
                SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn1.Open();
                string reqq1 = "update matla set qteStock=qteStock+@qteStocker where idMatla=" + txt_idMatla.Text;
                SqlCommand com1 = new SqlCommand(reqq1, cn1);
                com1.Parameters.Add(new SqlParameter("@qteStocker", Convert.ToInt32(txt_qteStocker.Text)));
                com1.ExecuteNonQuery();
                com1 = null;
                cn1.Close();
                cn1 = null;
                // update statut matla a "en lavage"
                SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn2.Open();
                string reqq2 = "update matla set idStatutMatla=4 where idMatla=" + txt_idMatla.Text;
                SqlCommand com2 = new SqlCommand(reqq2, cn2);
                com2.ExecuteNonQuery();
                com2 = null;
                cn2.Close();
                cn2 = null;
                // update entree of matla 
                SqlConnection cn6 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn6.Open();
                string reqq6 = "update matla set entrees=entrees+" + Convert.ToInt32(txt_qteStocker.Text)+" where idMatla="+txt_idMatla.Text;
                SqlCommand com6 = new SqlCommand(reqq6, cn6);
                com6.ExecuteNonQuery();
                com6 = null;
                cn6.Close();
                cn6 = null;
                // update statutComplet de matla si la somme de stockage de ce matla est egale=nbPieceSorter
                SqlConnection cn5 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn5.Open();
                SqlCommand com5 = new SqlCommand("select nbPieceSorter from matla where idMatla=" + txt_idMatla.Text, cn5);
                int nbPieceSorter = Convert.ToInt32(com5.ExecuteScalar());

                SqlConnection cn4 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn4.Open();
                SqlCommand com4 = new SqlCommand("select sum(qteStocker) from phasonieStocker where idMatla=" + txt_idMatla.Text + " group by idMatla", cn4);
                int nbPieceStocker = Convert.ToInt32(com4.ExecuteScalar());
                //int qteStocker = Convert.ToInt32(txt_qteStocker.Text);
                if (nbPieceStocker>= nbPieceSorter)
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
                this.Close();
            }
            else
            {
                MessageBox.Show("un champ est vide", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
