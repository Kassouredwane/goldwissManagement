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
    public partial class frmModifierTransferePhasonieToLavage : Form
    {
        int idTr;
        public frmModifierTransferePhasonieToLavage(int id)
        {
            InitializeComponent();
            this.idTr = id;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void refresh()
        {
            // fill cb_phasonie with phasonies
            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn1.Open();
            string req = "SELECT idLavage, nomLavage as nomComplet FROM lavage";
            SqlCommand com1 = new SqlCommand(req, cn1);
            SqlDataReader dr1 = com1.ExecuteReader();
            DataTable table1 = new DataTable();
            table1.Load(dr1);
            cb_lavage.DisplayMember = "nomComplet";
            cb_lavage.ValueMember = "idLavage";
            cb_lavage.DataSource = table1;
            //fermeture de la datareader et la connexion et effacer la commande
            dr1.Close();
            dr1 = null;
            com1 = null;
            cn1.Close();
            cn1 = null;
            // fill text box
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            SqlCommand com = new SqlCommand("select * from transferePhasonieToLavage where idTransferePhasonieToLavage=" + idTr, cn);
            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
            {
                txt_idMatla.Text = dr["idMatla"].ToString();
                txt_qteTransfere.Text = dr["qteTransfere"].ToString();
                txt_numeroBon.Text = dr["numeroBon"].ToString();
                cb_lavage.SelectedValue = Convert.ToInt32(dr["idLavage"].ToString());
                dtp_dateTransfere.Value = Convert.ToDateTime(dr["dateTransfere"].ToString());
            }
        }
        private void frmModifierTransferePhasonieToLavage_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            string reqq = "update transferePhasonieToLavage set idLavage=@idLavage,idMatla=@idMatla,qteTransfere=@qteTransfere,dateTransfere=@dateTransfere,numeroBon=@numeroBon where idTransferePhasonieToLavage="+idTr;
            SqlCommand com = new SqlCommand(reqq, cn);
            com.Parameters.Add(new SqlParameter("@idMatla", txt_idMatla.Text));
            com.Parameters.Add(new SqlParameter("@idLavage", cb_lavage.SelectedValue));
            com.Parameters.Add(new SqlParameter("@qteTransfere", txt_qteTransfere.Text));
            com.Parameters.Add(new SqlParameter("@dateTransfere", dtp_dateTransfere.Value));
            com.Parameters.Add(new SqlParameter("@numeroBon", txt_numeroBon.Text));
            com.ExecuteNonQuery();
            com = null;
            cn.Close();
            cn = null;
            MessageBox.Show("la transfère de matla a été modifier avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_ajouterLavage_Click(object sender, EventArgs e)
        {
            frmAjouterLavageATravertransferelvgToPs f = new frmAjouterLavageATravertransferelvgToPs();
            f.ShowDialog();
        }

        private void frmModifierTransferePhasonieToLavage_Activated(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
