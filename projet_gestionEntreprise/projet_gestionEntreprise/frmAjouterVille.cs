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
    public partial class frmAjouterVille : Form
    {
        public frmAjouterVille()
        {
            InitializeComponent();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            string req = "insert into ville values('"+txt_nomVille.Text+"')";
            SqlCommand com = new SqlCommand(req, cn);
            com.ExecuteNonQuery();

            com = null;
            cn.Close();
            cn = null;
            MessageBox.Show("La ville a été ajouter avec succé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
