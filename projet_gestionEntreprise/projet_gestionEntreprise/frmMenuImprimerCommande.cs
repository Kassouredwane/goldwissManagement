using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_gestionEntreprise
{
    public partial class frmMenuImprimerCommande : Form
    {
        int idC;
        public frmMenuImprimerCommande(int id)
        {
            InitializeComponent();
            this.idC = id;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modeleNonLivre_Click(object sender, EventArgs e)
        {
            bonCommande cr = new bonCommande();
            //cr.Refresh();
            cr.SetDatabaseLogon("sa", "123456");

            //string filtre = "{commande.idCommande}=" + dgv_commandeClient.CurrentRow.Cells[2].Value;
            string filtre = "{commande.idCommande}=" + idC + " and {detailCommande.statutLivraison}=false and {detailCommande.annuler}=false";
            frmImpression f = new frmImpression(cr, filtre);
            f.ShowDialog();
        }

        private void btn_commandeComplet_Click(object sender, EventArgs e)
        {
            bonCommande cr = new bonCommande();
            //cr.Refresh();
            cr.SetDatabaseLogon("sa", "123456");

            //string filtre = "{commande.idCommande}=" + dgv_commandeClient.CurrentRow.Cells[2].Value;
            string filtre = "{commande.idCommande}=" + idC;
            frmImpression f = new frmImpression(cr, filtre);
            f.ShowDialog();
        }

        private void btn_resteModele_Click(object sender, EventArgs e)
        {
            resteModeleCommande cr = new resteModeleCommande();
            //cr.Refresh();
            cr.SetDatabaseLogon("sa", "123456");

            //string filtre = "{commande.idCommande}=" + dgv_commandeClient.CurrentRow.Cells[2].Value;
            string filtre = "{commande.idCommande}=" + idC + " and {detailCommande.statutLivraison}=true" +
                " and {detailCommande.soldeLivraison}=false ";
            frmImpression f = new frmImpression(cr, filtre);
            f.ShowDialog();
        }
    }
}
