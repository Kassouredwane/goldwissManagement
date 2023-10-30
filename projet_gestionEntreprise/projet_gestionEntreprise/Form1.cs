using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Web.Security;
using System.Security.Cryptography;
using System.CodeDom.Compiler;
// using Newtonsoft.Json;
using System.IO;
using System.Configuration;


namespace projet_gestionEntreprise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static public string hash(string chaine)
        {
            byte[] textAsByte = Encoding.Default.GetBytes(chaine);

            SHA512 sha512 = SHA512Cng.Create();

            byte[] hash = sha512.ComputeHash(textAsByte);

            return Convert.ToBase64String(hash);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Today.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOublier_Click(object sender, EventArgs e)
        {

        }

        private void btn_connecter_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
            cn.Open();

            SqlCommand com = new SqlCommand("select * from utilisateur where login='" + hash(txt_login.Text) + "'", cn);
            SqlDataReader dr = com.ExecuteReader();
            bool passport = false;
            if (dr.Read())
            {
                if (dr["password"].ToString() == hash(txt_password.Text))
                {
                    passport = true;
                }
            }
            if (passport)
            {
                this.Hide();
                //frmMain f = new frmMain();
                Form2 f = new Form2();
                f.ShowDialog();
                //this.Show();
            }
            else
            {
                MessageBox.Show("login ou mot de pass est incorrect","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btn_connecter_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void txt_password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btn_connecter.PerformClick();
        }

        private void txt_login_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btn_connecter.PerformClick();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            txt_login.Text = "";
            txt_password.Text = "";
        }
    }
}