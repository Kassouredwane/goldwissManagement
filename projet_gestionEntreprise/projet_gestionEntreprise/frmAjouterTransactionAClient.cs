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
    public partial class frmAjouterTransactionAClient : Form
    {
        int idC;
        public frmAjouterTransactionAClient(int id)
        {
            InitializeComponent();
            this.idC = id;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
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
            MessageBox.Show("la transaction a été ajouter avec succée a ce client", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void frmAjouterTransactionAClient_Load(object sender, EventArgs e)
        {
            txt_idClient.Text=idC.ToString();
        }
    }
}
