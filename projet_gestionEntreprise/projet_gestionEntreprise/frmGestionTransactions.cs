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
            if (rb_tousTransactions.Checked == true)
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string req = "select idTransaction,c.idClient,montant,dateTransaction,TypeTransaction,[description],nomClient+' '+prenomClient as nomComplet from transactions t inner join client c on c.idClient=t.idClient "+filtre+ " order by idTransaction desc";
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
            else if (rb_filtreParDate.Checked == true)
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string req = "select idTransaction,c.idClient,montant,dateTransaction,TypeTransaction,[description],nomClient+' '+prenomClient as nomComplet from transactions t inner join client c on c.idClient=t.idClient where dateTransaction between @dateDebut and @dateFin" + filtre + " order by idTransaction desc";
                SqlCommand com = new SqlCommand(req, cn);
                com.Parameters.AddWithValue("@dateDebut", dtp_dateDebut.Value);
                com.Parameters.AddWithValue("@dateFin", dtp_dateFinale.Value);
                SqlDataReader dr = com.ExecuteReader();
                dgv_transactions.Rows.Clear();
                while (dr.Read())
                {
                    dgv_transactions.Rows.Add(dr["idTransaction"], dr["idClient"], dr["nomComplet"], dr["montant"], Convert.ToDateTime(dr["dateTransaction"].ToString()).ToShortDateString(), dr["description"], dr["TypeTransaction"]);
                }
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
            }
        }
        private void frmGestionTransactions_Load(object sender, EventArgs e)
        {
            refresh("");
            cb_recherche.SelectedIndex = 0;
            rb_tousTransactions.Checked = true;
        }
        //Id Transaction
        //Id Client
        //Nom Client
        //Date Transaction
        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cb_recherche.SelectedIndex)
                {
                    case 0:
                        if(rb_tousTransactions.Checked==true) refresh(" where idTransaction=" + txt_rechercher.Text);
                        else if(rb_filtreParDate.Checked==true) refresh(" and idTransaction=" + txt_rechercher.Text);
                        break;
                    case 1:
                        if (rb_tousTransactions.Checked == true) refresh(" where c.idClient=" + txt_rechercher.Text);
                        else if (rb_filtreParDate.Checked == true) refresh(" and c.idClient=" + txt_rechercher.Text);
                        break;
                    case 2:
                        if(rb_tousTransactions.Checked==true) refresh(" where nomClient like '%" + txt_rechercher.Text + "%' or prenomClient like '%" + txt_rechercher.Text + "%'");
                        else if (rb_filtreParDate.Checked == true) refresh(" and nomClient like '%" + txt_rechercher.Text + "%' or prenomClient like '%" + txt_rechercher.Text + "%'");
                        break;
                    case 3:
                        if(rb_tousTransactions.Checked==true) refresh(" where dateLivraison like'%" + txt_rechercher.Text + "%'");
                        else if (rb_filtreParDate.Checked == true) refresh(" and dateLivraison like'%" + txt_rechercher.Text + "%'");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("doit etre rechercher par l'élément séléctionner", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            frmModifierTransaction f = new frmModifierTransaction(Convert.ToInt32(dgv_transactions.CurrentRow.Cells[0].Value));
            f.ShowDialog();
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous vraiment veux supprimer cette transaction ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string req = "delete from transactions where idTransaction=" + dgv_transactions.CurrentRow.Cells[0].Value;
                SqlCommand com = new SqlCommand(req, cn);
                com.ExecuteNonQuery();
                com = null;
                cn.Close();
                cn = null;
                MessageBox.Show("la transaction a été supprimer avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh("");
            }
        }

        private void btn_supprimerTous_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous vraiment veux supprimer tous les transaction ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string req = "delete from transactions" ;
                SqlCommand com = new SqlCommand(req, cn);
                com.ExecuteNonQuery();
                com = null;
                cn.Close();
                cn = null;
                MessageBox.Show("tous les transaction a été supprimer avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh("");
            }
        }

        private void rb_tousTransactions_CheckedChanged(object sender, EventArgs e)
        {
            refresh("");
        }

        private void rb_filtreParDate_CheckedChanged(object sender, EventArgs e)
        {
            refresh("");
        }

        private void dtp_dateDebut_ValueChanged(object sender, EventArgs e)
        {
            refresh("");
        }

        private void dtp_dateFinale_ValueChanged(object sender, EventArgs e)
        {
            refresh("");
        }
    }
}
