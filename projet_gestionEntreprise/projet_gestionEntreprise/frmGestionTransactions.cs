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
    public partial class frmGestionTransactions : Form
    {
        public frmGestionTransactions()
        {
            InitializeComponent();
        }
        private void refresh(string filtre)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();
            string req = "select idTransaction,c.idClient,montant,dateTransaction,TypeTransaction,[description],nomClient+' '+prenomClient as nomComplet from transactions t inner join client c on c.idClient=t.idClient "+filtre;
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            dgv_transactions.Rows.Clear();
            while (dr.Read())
            {
                dgv_transactions.Rows.Add(dr["idTransaction"], dr["idClient"], dr["nomComplet"], dr["montant"],Convert.ToDateTime(dr["dateTransaction"].ToString()).ToShortDateString(), dr["description"], dr["TypeTransaction"]);
            }
            dr.Close();
            dr = null;
            com = null;

            cn.Close();
            cn = null;
        }
        private void frmGestionTransactions_Load(object sender, EventArgs e)
        {
            refresh("");
            cb_recherche.SelectedIndex = 0; 
        }
        //Id Transaction
        //Id Client
        //Nom Client
        //Date Transaction
        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            //try
            //{
                switch (cb_recherche.SelectedIndex)
                {
                    case 0:
                        refresh(" where idTransaction=" + txt_rechercher.Text);
                        break;
                    case 1:
                        refresh(" where c.idClient=" + txt_rechercher.Text);
                        break;
                    case 2:
                        refresh(" where nomClient like '%" + txt_rechercher.Text + "%' or prenomClient like '%" + txt_rechercher.Text + "%'");
                        break;
                    case 3:
                        refresh(" where dateLivraison like'%" + txt_rechercher.Text + "%'");
                        break;
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("doit etre rechercher par l'élément séléctionner", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh("");
            txt_rechercher.Text = "";
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            frmAjouterTransaction f = new frmAjouterTransaction();
            f.ShowDialog();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            frmModifierTransaction f = new frmModifierTransaction();
            f.ShowDialog();
        }
    }
}
