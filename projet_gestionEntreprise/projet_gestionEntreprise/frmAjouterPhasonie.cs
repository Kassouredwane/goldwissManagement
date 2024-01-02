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
    public partial class frmAjouterPhasonie : Form
    {
        public frmAjouterPhasonie()
        {
            InitializeComponent();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (txt_nomPhasonie.Text != "" && txt_prenomPhasonie.Text != "" && txt_telephonePhasonie.Text != "")
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string reqq = "insert into phasonie values (@nomPhasonie,@prenomPhasonie,@telephonePhasonie)";
                //string reqq = "insert into phasonie values (@idPhasonie,@nomPhasonie,@prenomPhasonie,@telephonePhasonie)";
                SqlCommand com = new SqlCommand(reqq, cn);
                //com.Parameters.Add(new SqlParameter("@idPhasonie", txt_idPhasonie.Text));
                com.Parameters.Add(new SqlParameter("@nomPhasonie", txt_nomPhasonie.Text));
                com.Parameters.Add(new SqlParameter("@prenomPhasonie", txt_prenomPhasonie.Text));
                com.Parameters.Add(new SqlParameter("@telephonePhasonie", txt_telephonePhasonie.Text));
                com.ExecuteNonQuery();
                com = null;
                cn.Close();
                cn = null;
                MessageBox.Show("le phasonie a été ajouter avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("un champ est vide", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmAjouterPhasonie_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                SqlCommand com = new SqlCommand("select max(idPhasonie)+1 from phasonie", cn);
                int nb = Convert.ToInt32(com.ExecuteScalar());

                txt_idPhasonie.Text = nb.ToString();
                com = null;
                cn.Close();
                cn = null;
            }
            catch (Exception error) { txt_idPhasonie.Text = "1"; }
        }
    }
}
