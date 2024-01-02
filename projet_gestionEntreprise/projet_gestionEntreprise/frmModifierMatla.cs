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
    public partial class frmModifierMatla : Form
    {
        int id;
        public frmModifierMatla(int idM)
        {
            InitializeComponent();
            this.id = idM;
        }

        private void frmModifierMatla_Load(object sender, EventArgs e)
        {
            txt_idMatla.Text = id.ToString();
            refresh();
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


            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            SqlCommand com = new SqlCommand("select * from matla where matla.idMatla="+id, cn);
            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
            {
                txt_idMatla.Text = dr["idMatla"].ToString();
                txt_nbPieces.Text = dr["nbPiece"].ToString();
                txt_numeroBon.Text = dr["numeroBon"].ToString();
                txt_prixPhasonie.Text = dr["prixPhasonnier"].ToString();
                txt_qteSorter.Text = dr["nbPieceSorter"].ToString();
                txt_qteEnStock.Text = dr["qteStock"].ToString();
                txt_referenceModele.Text = dr["referenceModele"].ToString();
                dtp_dateDetailler.Value = Convert.ToDateTime(dr["dateDetailler"].ToString());
                int phasonieId = Convert.ToInt32(dr["idPhasonie"].ToString());
                cb_phasonie.SelectedValue = phasonieId;
                int detailleurId = Convert.ToInt32(dr["idDetailleur"].ToString());
                cb_detailleur.SelectedValue = detailleurId;
            }
        }
        private void btn_valider_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            string reqq = "update matla set referenceModele=@referenceModele,idDetailleur=@idDetailleur,idPhasonie=@idPhasonie,nbPiece=@nbPiece,dateDetailler=@dateDetailler,nbPieceSorter=@nbPieceSorter,prixPhasonnier=@prixPhasonnier,numeroBon=@numeroBon,qteStock=@qteStock where idMatla=" + id;
            SqlCommand com = new SqlCommand(reqq, cn);
            com.Parameters.Add(new SqlParameter("@referenceModele", txt_referenceModele.Text));
            com.Parameters.Add(new SqlParameter("@idDetailleur", cb_detailleur.SelectedValue));
            com.Parameters.Add(new SqlParameter("@idPhasonie", cb_phasonie.SelectedValue));
            com.Parameters.Add(new SqlParameter("@nbPiece", txt_nbPieces.Text));
            com.Parameters.Add(new SqlParameter("@dateDetailler", dtp_dateDetailler.Value));
            com.Parameters.Add(new SqlParameter("@nbPieceSorter", txt_qteSorter.Text));
            com.Parameters.Add(new SqlParameter("@prixPhasonnier", txt_prixPhasonie.Text));
            com.Parameters.Add(new SqlParameter("@numeroBon", txt_numeroBon.Text));
            com.Parameters.Add(new SqlParameter("@qteStock", txt_qteEnStock.Text));
            com.ExecuteNonQuery();
            com = null;
            cn.Close();
            cn = null;
            MessageBox.Show("Matla a été modifier avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
    }
}
