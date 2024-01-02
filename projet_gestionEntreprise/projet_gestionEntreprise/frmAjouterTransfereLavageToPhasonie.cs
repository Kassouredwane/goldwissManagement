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
    public partial class frmAjouterTransfereLavageToPhasonie : Form
    {
        public frmAjouterTransfereLavageToPhasonie()
        {
            InitializeComponent();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_idMatla_Leave(object sender, EventArgs e)
        {
            using (SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456"))
            {
                cn1.Open();
                string req = "SELECT lv.idLavage FROM lavage lv INNER JOIN transferePhasonieToLavage tpl ON tpl.idLavage = lv.idLavage WHERE idMatla = @idMatla";
                SqlCommand com1 = new SqlCommand(req, cn1);
                com1.Parameters.AddWithValue("@idMatla", txt_idMatla.Text);

                using (SqlDataReader dr1 = com1.ExecuteReader())
                {
                    if (dr1.Read())
                    {
                        cb_lavage.SelectedValue = Convert.ToInt32(dr1["idLavage"].ToString());
                    }
                    dr1.Close();
                    com1 = null;
                }
                cn1.Close();
            }
        }

        private void frmAjouterTransfereLavageToPhasonie_Load(object sender, EventArgs e)
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
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (txt_idMatla.Text != "" && txt_numeroBon.Text != "" && txt_qteTransfere.Text != "")
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string reqq = "insert into transfereLavageToPhasonie values(@idLavage,@idMatla,@qteTransfere,@dateTransfere,@numeroBon)";
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
                // update statut matla a  "en lavage"
                SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn2.Open();
                string reqq2 = "update matla set idStatutMatla=3 where idMatla=" + txt_idMatla.Text;
                SqlCommand com2 = new SqlCommand(reqq2, cn2);
                com2.ExecuteNonQuery();
                com2 = null;
                cn2.Close();
                cn2 = null;

                MessageBox.Show("la transfère de matla a été ajouter avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("un champ est vide", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
