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
    public partial class frmModifierSituationModele : Form
    {
        int id;
        public frmModifierSituationModele(int idS)
        {
            InitializeComponent();
            this.id = idS;
        }

        private void frmModifierSituationModele_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            SqlCommand com = new SqlCommand("select * from situationModele where idSituationModele=" + id, cn);
            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
            {
                txt_numeroSituation.Text = dr["numeroSituation"].ToString();
                dtp_dateDebut.Value = Convert.ToDateTime(dr["dateDebutSituation"].ToString());
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            string reqq = "update situationModele set numeroSituation=@numeroSituation,dateDebutSituation=@dateDebutSituation where idSituationModele="+id;
            SqlCommand com = new SqlCommand(reqq, cn);
            com.Parameters.Add(new SqlParameter("@numeroSituation", txt_numeroSituation.Text));
            com.Parameters.Add(new SqlParameter("@dateDebutSituation", dtp_dateDebut.Value));
            com.ExecuteNonQuery();
            com = null;
            cn.Close();
            cn = null;
            MessageBox.Show("La situation a été modifier avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
