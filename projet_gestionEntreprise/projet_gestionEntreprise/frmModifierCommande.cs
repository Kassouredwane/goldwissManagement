using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_gestionEntreprise
{
    public partial class frmModifierCommande : Form
    {
        int IdCommande;
        public frmModifierCommande(int idCommande)
        {
            InitializeComponent();
            IdCommande = idCommande;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModifierCommande_Load(object sender, EventArgs e)
        {
            txt_idCommande.Text=IdCommande.ToString();

            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn1.Open();
            string req = "select * from statutPayement";
            SqlCommand com1 = new SqlCommand(req, cn1);
            SqlDataReader dr1 = com1.ExecuteReader();
            DataTable table1 = new DataTable();
            table1.Load(dr1);
            cb_statutPayement.DisplayMember = "designation";
            cb_statutPayement.ValueMember = "idStatutPayement";
            cb_statutPayement.DataSource = table1;

            SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn2.Open();
            SqlCommand com2 = new SqlCommand("select dateCommande,idStatutPayement,referenceModele,qteAchat,prixAchat from commande c inner join detailCommande dc on dc.idCommande=c.idCommande where c.idCommande=" + txt_idCommande.Text, cn2);
            SqlDataReader dr2 = com2.ExecuteReader();

            if (dr2.Read())
            {
                dtp_dateCommande.Value = Convert.ToDateTime(dr2["dateCommande"].ToString());
                txt_numeroBon.Text = dr2["numeroBon"].ToString();
                txt_referenceModele.Text = dr2["referenceModele"].ToString();
                txt_qteAchat.Text = dr2["qteAchat"].ToString();
                txt_prixAchat.Text = dr2["prixAchat"].ToString();
                //int cityID = dr.GetInt32(dr.GetOrdinal("idVille"));
                //cb_villeClient.SelectedValue = cityID;

                int idStatutPay = Convert.ToInt32(dr2["idStatutPayement"].ToString());
                cb_statutPayement.SelectedValue = idStatutPay;

                //if (!dr.IsDBNull(dr.GetOrdinal("idVille")))
                //{
                //    int cityID = dr.GetInt32(dr.GetOrdinal("idVille"));
                //    cb_villeClient.SelectedValue = cityID;
                //}
            }
            //fermeture de la datareader et la connexion et effacer la commande
            dr1.Close();
            dr1 = null;
            com1 = null;
            cn1.Close();
            cn1 = null;
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            string reqq = "update commande set dateCommande=@dateCommande,numeroBon=@numeroBon,idStatutPayement=@idStatutPayement where idCommande="+txt_idCommande.Text;
            SqlCommand com = new SqlCommand(reqq, cn);
            com.Parameters.Add(new SqlParameter("@dateCommande", dtp_dateCommande.Value));
            com.Parameters.Add(new SqlParameter("@numeroBon", txt_numeroBon.Text));
            com.Parameters.Add(new SqlParameter("@idStatutPayement", cb_statutPayement.SelectedValue));
            com.ExecuteNonQuery();

            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn1.Open();
            string req = "update detailCommande set referenceModele=@referenceModele,qteAchat=@qteAchat,prixAchat=@prixAchat where idCommande="+txt_idCommande.Text;
            SqlCommand com1 = new SqlCommand(req, cn1);
            com1.Parameters.Add(new SqlParameter("@referenceModele", txt_referenceModele.Text));
            com1.Parameters.Add(new SqlParameter("@qteAchat", txt_qteAchat.Text));
            com1.Parameters.Add(new SqlParameter("@prixAchat", txt_prixAchat.Text));
            com1.ExecuteNonQuery();
            com = null;
            cn.Close();
            cn = null;
            com1 = null;
            cn1.Close();
            cn1 = null;
            MessageBox.Show("la commande de ce client a été modifier avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();   
        }
    }
}
