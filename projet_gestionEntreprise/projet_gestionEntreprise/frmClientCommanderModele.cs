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
    public partial class frmClientCommanderModele : Form
    {
        string refMd;
        public frmClientCommanderModele(string idMd)
        {
            InitializeComponent();
            this.refMd = idMd;
        }
        private void refresh()
        {
            if(chk_enCourLivraison.Checked==false)
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn.Open();
                string req = "select c.idClient,nomClient+' '+prenomClient as nomComplet,cmd.idCommande,dateCommande,qteAchat,m.referenceModele,taille,sl.designation as livraison from client c inner join commande cmd on c.idClient=cmd.idClient inner join detailCommande dc on dc.idCommande=cmd.idCommande inner join statutLivraison sl on sl.idStatutLivraison=cmd.idStatutLivraison inner join modele m on m.referenceModele=dc.referenceModele where m.referenceModele='"+refMd+"' and cmd.idStatutLivraison=1";
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_clients.Rows.Clear();
                while (dr.Read())
                {
                    dgv_clients.Rows.Add(dr["idClient"], dr["nomClient"], dr["prenomClient"], dr["telephoneClient"], dr["adresseClient"], dr["nomVille"]);
                }
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
            }
            else
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=gestionEntreprise;User ID=sa;Password=123456");
                cn.Open();
                string req = "";
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_clients.Rows.Clear();
                while (dr.Read())
                {
                    dgv_clients.Rows.Add(dr["idClient"], dr["nomClient"], dr["prenomClient"], dr["telephoneClient"], dr["adresseClient"], dr["nomVille"]);
                }
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
            }
        }
        private void frmClientCommanderModele_Load(object sender, EventArgs e)
        {

        }
    }
}
