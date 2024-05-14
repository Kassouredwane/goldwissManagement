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
    public partial class frmGestionRetour : Form
    {
        public frmGestionRetour()
        {
            InitializeComponent();
        }
        private void refresh(string filtre)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            string req = "select r.idRetour,r.numeroBon,dateRetour,nomClient,r.designation,sum(qteRetour) as qteRetour,sum(dl.prixVente*dr.qteRetour) as totalePrix from retour r left join detailRetour dr on dr.idRetour=r.idRetour inner join detailLivraison dl on dl.idDetailLivraison=dr.idDetailLivraison inner join client c on c.idClient=r.idClient " + filtre+" group by r.idRetour,r.numeroBon,dateRetour,nomClient,r.designation";
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            dgv_retour.Rows.Clear();
            while (dr.Read())
            {
                dgv_retour.Rows.Add(dr["idRetour"], dr["numeroBon"], Convert.ToDateTime(dr["dateRetour"].ToString()).ToShortDateString(), dr["nomClient"], dr["designation"], dr["qteRetour"], dr["totalePrix"]);
            }
            dr.Close();
            dr = null;
            com = null;

            cn.Close();
            cn = null;
        }
        private void frmGestionRetour_Load(object sender, EventArgs e)
        {
            refresh("");
            cb_recherche.SelectedIndex = 0;
        }

        private void dgv_livraison_SelectionChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            string req = "select m.referenceModele,m.designation,dl.qteLivre,dl.prixVente,dr.qteRetour,dl.prixVente*dr.qteRetour as totalePrix from detailRetour dr inner join detailLivraison dl on dl.idDetailLivraison=dr.idDetailLivraison inner join matla mt on dl.idMatla=mt.idMatla inner join modele m on m.referenceModele=mt.referenceModele where idRetour="+dgv_retour.CurrentRow.Cells[0].Value;
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            dgv_detailRetour.Rows.Clear();
            while (dr.Read())
            {
                dgv_detailRetour.Rows.Add(dr["referenceModele"], dr["designation"],dr["qteLivre"], dr["prixVente"], dr["qteRetour"], dr["totalePrix"]);
            }
            dr.Close();
            dr = null;
            com = null;

            cn.Close();
            cn = null;
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            frmAjouterRetour f = new frmAjouterRetour();
            f.ShowDialog();
        }
    }
}
