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
    public partial class frmAjouterTransaction : Form
    {
        public frmAjouterTransaction()
        {
            InitializeComponent();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            string reqq = "insert into transactions values (@idClient,@montant,@dateTransaction,@typeTransaction,@description)";
            SqlCommand com = new SqlCommand(reqq, cn);
            com.Parameters.Add(new SqlParameter("@idClient", txt_idClient.Text));
            com.Parameters.Add(new SqlParameter("@montant", txt_montant.Text));
            com.Parameters.Add(new SqlParameter("@dateTransaction", dtp_dateTransaction.Value));
            com.Parameters.Add(new SqlParameter("@typeTransaction", cb_modePaiement.Text));
            com.Parameters.Add(new SqlParameter("@description", txt_description.Text));
            com.ExecuteNonQuery();
            com = null;
            cn.Close();
            cn = null;
            MessageBox.Show("la transaction a été ajouter avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            // update reste a payer de la client qui fait la transaction
            SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn2.Open();
            string reqq2 = "update client set restePayer=restePayer-@montant where idClient="+txt_idClient.Text;
            SqlCommand com2 = new SqlCommand(reqq2, cn2);
            com2.Parameters.Add(new SqlParameter("@montant", txt_montant.Text));
            com2.ExecuteNonQuery();
            com2 = null;
            cn2.Close();
            cn2 = null;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAjouterTransaction_Load(object sender, EventArgs e)
        {
            txt_idClient.Focus();
            cb_modePaiement.SelectedIndex = 0;
        }
    }
}
