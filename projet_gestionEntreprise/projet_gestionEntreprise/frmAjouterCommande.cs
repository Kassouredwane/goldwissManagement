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
    public partial class frmAjouterCommande : Form
    {
        int idclient;
        public frmAjouterCommande(int idCLIENT)
        {
            InitializeComponent();
            idclient = idCLIENT;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            string reqq = "insert into commande values(@dateCommande,@numeroBon,@idClient,@idStatutPayement)";
            SqlCommand com = new SqlCommand(reqq, cn);
            com.Parameters.Add(new SqlParameter("@dateCommande", dtp_dateCommande.Value));
            com.Parameters.Add(new SqlParameter("@numeroBon", txt_numeroBon.Text));
            com.Parameters.Add(new SqlParameter("@idClient", idclient));
            com.Parameters.Add(new SqlParameter("@idStatutPayement",cb_statutPayement.SelectedValue ));
            com.ExecuteNonQuery();

            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn1.Open();
            string req = "insert into detailCommande values (@idCommande,@referenceModele,@qteAchat,@prixAchat)";
            SqlCommand com1 = new SqlCommand(req, cn1);
            com1.Parameters.Add(new SqlParameter("@idCommande", txt_idCommande.Text));
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
            MessageBox.Show("la commande de ce client a été ajouter avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void frmAjouterCommande_Load(object sender, EventArgs e)
        {
            //cb_statutPayement.SelectedIndex = 1;
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            SqlCommand com = new SqlCommand("select max(idCommande)+1 from commande", cn);
            int nb = Convert.ToInt32(com.ExecuteScalar());

            txt_idCommande.Text = nb.ToString();
            com = null;
            cn.Close();
            cn = null;
            //MessageBox.Show(idclient.ToString());

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
            //fermeture de la datareader et la connexion et effacer la commande
            dr1.Close();
            dr1 = null;
            com1 = null;
            cn1.Close();
            cn1 = null;
        }
    }
}
