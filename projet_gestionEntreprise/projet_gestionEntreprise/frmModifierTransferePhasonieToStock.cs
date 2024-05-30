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
    public partial class frmModifierTransferePhasonieToStock : Form
    {
        int idStocker;
        public frmModifierTransferePhasonieToStock(int id)
        {
            InitializeComponent();
            this.idStocker = id;
        }

        private void frmModifierTransferePhasonieToStock_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            SqlCommand com = new SqlCommand("select * from phasonieStocker where idPhasonierStocker=" + idStocker, cn);
            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
            {
                txt_idMatla.Text = dr["idMatla"].ToString();
                txt_qteStocker.Text = dr["qteStocker"].ToString();
                txt_oldQte.Text = dr["qteStocker"].ToString();
                txt_numeroBon.Text = dr["numeroBon"].ToString();
                dtp_dateStocker.Value = Convert.ToDateTime(dr["dateStocker"].ToString());
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
            string reqq = "update phasonieStocker set numeroBon=@numeroBon where idPhasonierStocker="+idStocker;
            SqlCommand com = new SqlCommand(reqq, cn);
            com.Parameters.Add(new SqlParameter("@idMatla", txt_idMatla.Text));
            com.Parameters.Add(new SqlParameter("@qteStocker", txt_qteStocker.Text));
            com.Parameters.Add(new SqlParameter("@dateStocker", dtp_dateStocker.Value));
            com.Parameters.Add(new SqlParameter("@numeroBon", txt_numeroBon.Text));
            com.ExecuteNonQuery();
            com = null;
            cn.Close();
            cn = null;
            //// update qteStock de matla => qteStock = qteStock + qteStocke
            //SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //cn1.Open();
            //string reqq1 = "update matla set qteStock=qteStock-@oldQte+@qteStocker where idMatla=" + txt_idMatla.Text;
            //SqlCommand com1 = new SqlCommand(reqq1, cn1);
            //com1.Parameters.Add(new SqlParameter("@oldQte", Convert.ToInt32(txt_oldQte.Text)));
            //com1.Parameters.Add(new SqlParameter("@qteStocker", Convert.ToInt32(txt_qteStocker.Text)));
            //com1.ExecuteNonQuery();
            //com1 = null;
            //cn1.Close();
            //cn1 = null;
            ////update statutComplet de matla
            //SqlConnection cn5 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //cn5.Open();
            //SqlCommand com5 = new SqlCommand("select nbPieceSorter from matla where idMatla=" + txt_idMatla.Text, cn5);
            //int nbPieceSorter = Convert.ToInt32(com5.ExecuteScalar());

            //SqlConnection cn4 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //cn4.Open();
            //SqlCommand com4 = new SqlCommand("select sum(qteStocker) from phasonieStocker where idMatla=" + txt_idMatla.Text + " group by idMatla", cn4);
            //int nbPieceStocker = Convert.ToInt32(com4.ExecuteScalar());
            //int qteStocker = Convert.ToInt32(txt_qteStocker.Text);
            //int oldQte = Convert.ToInt32(txt_oldQte.Text);
            //if (nbPieceStocker - oldQte + qteStocker >= nbPieceSorter)
            //{
            //    SqlConnection cn3 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn3.Open();
            //    string reqq3 = "update matla set statutComplet=1 where idMatla=" + txt_idMatla.Text;
            //    SqlCommand com3 = new SqlCommand(reqq3, cn3);
            //    com3.ExecuteNonQuery();
            //    com3 = null;
            //    cn3.Close();
            //    cn3 = null;
            //}
            //// update entree of matla 
            //SqlConnection cn6 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //cn6.Open();
            //string reqq6 = "update matla set entrees=entrees-"+Convert.ToInt32(txt_oldQte.Text)+"+" + Convert.ToInt32(txt_qteStocker.Text) + " where idMatla=" + txt_idMatla.Text;
            //SqlCommand com6 = new SqlCommand(reqq6, cn6);
            //com6.ExecuteNonQuery();
            //com6 = null;
            //cn6.Close();
            //cn6 = null;
            MessageBox.Show("le stockage de matla a été modifier avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
