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
    public partial class frmAjouterLavageATravertransferelvgToPs : Form
    {
        public frmAjouterLavageATravertransferelvgToPs()
        {
            InitializeComponent();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (txt_nomLavage.Text != "" && txt_telephoneLavage.Text != "") 
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string reqq = "insert into lavage values (@nomLavage,@telephoneLavage)";
                SqlCommand com = new SqlCommand(reqq, cn);
                com.Parameters.Add(new SqlParameter("@nomLavage", txt_nomLavage.Text));
                com.Parameters.Add(new SqlParameter("@telephoneLavage", txt_telephoneLavage.Text));
                com.ExecuteNonQuery();
                com = null;
                cn.Close();
                cn = null;
                MessageBox.Show("lavage a été ajouter avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("un champ est vide !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmAjouterLavageATravertransferelvgToPs_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                SqlCommand com = new SqlCommand("select max(idLavage)+1 from lavage", cn);
                int nb = Convert.ToInt32(com.ExecuteScalar());

                txt_idLavage.Text = nb.ToString();
                com = null;
                cn.Close();
                cn = null;
            }
            catch (Exception) { txt_idLavage.Text = "1"; }
        }
    }
}
