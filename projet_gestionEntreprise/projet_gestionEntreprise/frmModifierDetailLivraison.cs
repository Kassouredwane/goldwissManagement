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
    public partial class frmModifierDetailLivraison : Form
    {
        int idDetail;
        public frmModifierDetailLivraison(int id)
        {
            InitializeComponent();
            this.idDetail = id;
        }

        private void frmModifierDetailLivraison_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            SqlCommand com = new SqlCommand("select * from detailLivraison where idDetailLivraison="+idDetail, cn);
            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
            {
                txt_idLivraison.Text = dr["idLivraison"].ToString();
                txt_prix.Text = dr["prixVente"].ToString();
                txt_qteLivre.Text = dr["qteLivre"].ToString();
            }
            dr.Close();
            dr = null;
            com = null;

            cn.Close();
            cn = null;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            //string reqq = "update phasonieStocker set qteStocker=@qteStocker,dateStocker=@dateStocker,numeroBon=@numeroBon where idPhasonierStocker="+idStocker;
            string reqq = "update detailLivraison set idLivraison=@idLivraison,qteLivre=@qteLivre,prixVente=@prixVente where idDetailLivraison=" + idDetail;
            SqlCommand com = new SqlCommand(reqq, cn);
            com.Parameters.Add(new SqlParameter("@idLivraison", txt_idLivraison.Text));
            com.Parameters.Add(new SqlParameter("@qteLivre", txt_qteLivre.Text));
            com.Parameters.Add(new SqlParameter("@prixVente", txt_prix.Text));
            com.ExecuteNonQuery();
            com = null;
            cn.Close();
            cn = null;
            this.Close();
        }
    }
}
