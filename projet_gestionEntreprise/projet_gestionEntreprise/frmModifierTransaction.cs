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
    public partial class frmModifierTransaction : Form
    {
        int idTr;
        public frmModifierTransaction(int id)
        {
            InitializeComponent();
            this.idTr = id;
        }
        private void frmModifierTransaction_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            SqlCommand com = new SqlCommand("select * from transactions where idTransaction="+idTr, cn);
            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
            {
                txt_idTransaction.Text= dr["idTransaction"].ToString();
                txt_idClient.Text = dr["idClient"].ToString();
                txt_montant.Text = dr["montant"].ToString();
                txt_description.Text = dr["description"].ToString();
                cb_modePaiement.Text = dr["typeTransaction"].ToString();
                dtp_dateTransaction.Value = Convert.ToDateTime(dr["dateTransaction"].ToString());
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            //// update reste a payer de la client qui fait la transaction
            //SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //cn2.Open();
            //string reqq2 = "UPDATE client SET restePayer = restePayer + (SELECT montant FROM transactions WHERE idTransaction = "+idTr+") - "+txt_montant.Text+" WHERE idClient = "+txt_idClient.Text+"";
            //SqlCommand com2 = new SqlCommand(reqq2, cn2);
            //com2.Parameters.Add(new SqlParameter("@montant", txt_montant.Text));
            //com2.ExecuteNonQuery();
            //com2 = null;
            //cn2.Close();
            //cn2 = null;
            //update montant dof transaction table
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            string reqq = "update transactions set montant=@montant,dateTransaction=@dateTransaction,typeTransaction=@typeTransaction,description=@description where idTransaction="+idTr;
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
            MessageBox.Show("la transaction a été modifier avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
