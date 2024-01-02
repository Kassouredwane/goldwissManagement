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
            // fill txt_idMatla with the id of matla will added
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
            refresh();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            //if(txt_nbPieces.Text!=""&&txt_numeroBon.Text!=""&&txt_prixPhasonie.Text!="" && txt_qteSorter.Text != "" && txt_referenceModele.Text != "")
            if (txt_nbPieces.Text!="" && txt_qteSorter.Text != "" && txt_referenceModele.Text != "")
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string reqq = "insert into matla(referenceModele,idDetailleur,idPhasonie,nbPiece,dateDetailler,nbPieceSorter,prixPhasonnier,numeroBon) values (@referenceModele,@idDetailleur,@idPhasonie,@nbPiece,@dateDetailler,@nbPieceSorter,@prixPhasonnier,@numeroBon)";
                SqlCommand com = new SqlCommand(reqq, cn);
                com.Parameters.Add(new SqlParameter("@referenceModele", txt_referenceModele.Text));
                com.Parameters.Add(new SqlParameter("@idDetailleur", cb_detailleur.SelectedValue));
                com.Parameters.Add(new SqlParameter("@idPhasonie", cb_phasonie.SelectedValue));
                com.Parameters.Add(new SqlParameter("@nbPiece", txt_nbPieces.Text));
                com.Parameters.Add(new SqlParameter("@dateDetailler", dtp_dateDetailler.Value)) ;
                com.Parameters.Add(new SqlParameter("@nbPieceSorter", txt_qteSorter.Text));
                com.Parameters.Add(new SqlParameter("@prixPhasonnier", txt_prixPhasonie.Text));
                com.Parameters.Add(new SqlParameter("@numeroBon", txt_numeroBon.Text));
                com.ExecuteNonQuery();
                com = null;
                cn.Close();
                cn = null;
                MessageBox.Show("Matla a été ajouter avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
            }
            else
            {
                MessageBox.Show("un champ est vide", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
