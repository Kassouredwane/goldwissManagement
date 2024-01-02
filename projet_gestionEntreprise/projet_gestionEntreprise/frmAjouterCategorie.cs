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
    public partial class frmAjouterCategorie : Form
    {
        public frmAjouterCategorie()
        {
            InitializeComponent();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (txt_nomCategorie.Text != "")
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string req = "insert into categorie values('" + txt_nomCategorie.Text + "')";
                SqlCommand com = new SqlCommand(req, cn);
                com.ExecuteNonQuery();

                com = null;
                cn.Close();
                cn = null;
                MessageBox.Show("La categorie a été ajouter avec succé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
                txt_nomCategorie.Text = "";
            }
            else
            {
                MessageBox.Show("Nom categorie est vide", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmAjouterCategorie_Load(object sender, EventArgs e)
        {

        }

        private void txt_nomCategorie_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btn_valider.PerformClick();
        }
    }
}
