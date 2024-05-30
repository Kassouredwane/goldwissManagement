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
    public partial class frmTransferePhasonieStock : Form
    {
        public frmTransferePhasonieStock()
        {
            InitializeComponent();
        }
        private void refresh(string filtre)
        {
            if (chk_enAttentePieces.Checked == false)
            {
                // fill grid view by transfere
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                //string req = "select nomPhasonie+' '+prenomPhasonie as phasonie,mt.idMatla,mt.referenceModele,designation,nbPieceSorter,pss.qteStocker,dateStocker,pss.numeroBon,pss.idPhasonierStocker from phasonieStocker pss inner join matla mt on mt.idMatla=pss.idMatla inner join phasonie ps on ps.idPhasonie=mt.idPhasonie inner join modele m on m.referenceModele=mt.referenceModele" + filtre + " order by idPhasonierStocker desc";
                string req = "select nomPhasonie,mt.idMatla,mt.referenceModele,m.designation,mt.nbPieceSorter,pss.qteStocker,pss.qteConfirmer,dateStocker,pss.numeroBon,pss.idPhasonierStocker,confirmer from phasonieStocker pss inner join matla mt on mt.idMatla=pss.idMatla inner join phasonie ps on ps.idPhasonie=mt.idPhasonie inner join modele m on m.referenceModele=mt.referenceModele where archiver=0 "+filtre+ " order by idPhasonierStocker desc";
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_stockage.Rows.Clear();
                while (dr.Read())
                {
                    dgv_stockage.Rows.Add(dr["nomPhasonie"], dr["idMatla"], dr["referenceModele"], dr["designation"], dr["nbPieceSorter"], dr["qteStocker"], dr["qteConfirmer"], Convert.ToDateTime(dr["dateStocker"].ToString()).ToShortDateString(), dr["numeroBon"], dr["idPhasonierStocker"], dr["confirmer"]);
                }
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
            }
            else if (chk_enAttentePieces.Checked == true)
            {
                // fill grid view by transfere
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                //string req = "select nomPhasonie+' '+prenomPhasonie as phasonie,mt.idMatla,mt.referenceModele,designation,nbPieceSorter,pss.qteStocker,dateStocker,pss.numeroBon,pss.idPhasonierStocker from phasonieStocker pss inner join matla mt on mt.idMatla=pss.idMatla inner join phasonie ps on ps.idPhasonie=mt.idPhasonie inner join modele m on m.referenceModele=mt.referenceModele where mt.statutComplet=0 "+filtre+ " order by idPhasonierStocker desc";
                string req = "select nomPhasonie,mt.idMatla,mt.referenceModele,m.designation,mt.nbPieceSorter,pss.qteStocker,pss.qteConfirmer,dateStocker,pss.numeroBon,pss.idPhasonierStocker,confirmer from phasonieStocker pss inner join matla mt on mt.idMatla=pss.idMatla inner join phasonie ps on ps.idPhasonie=mt.idPhasonie inner join modele m on m.referenceModele=mt.referenceModele where mt.statutComplet=0 and archiver=0 " + filtre + " order by idPhasonierStocker desc";
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_stockage.Rows.Clear();
                while (dr.Read())
                {
                    dgv_stockage.Rows.Add(dr["nomPhasonie"], dr["idMatla"], dr["referenceModele"], dr["designation"], dr["nbPieceSorter"], dr["qteStocker"], dr["qteConfirmer"], Convert.ToDateTime(dr["dateStocker"].ToString()).ToShortDateString(), dr["numeroBon"], dr["idPhasonierStocker"], dr["confirmer"]);
                }
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
            }
        }
        private void frmTransferePhasonieStock_Load(object sender, EventArgs e)
        {
            refresh("");
            cb_recherche.SelectedIndex = 0;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh("");
        }

        private void chk_enAttentePieces_CheckedChanged(object sender, EventArgs e)
        {
            refresh("");
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            frmAjouterTransferePhasonieToStock f = new frmAjouterTransferePhasonieToStock();
            f.ShowDialog();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            int idTr = Convert.ToInt32(dgv_stockage.CurrentRow.Cells[9].Value);
            frmModifierTransferePhasonieToStock f = new frmModifierTransferePhasonieToStock(idTr);
            f.ShowDialog();
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous vraiment veux supprimer ce stockage de matla ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string req = "delete from phasonieStocker where idPhasonierStocker=" + dgv_stockage.CurrentRow.Cells[9].Value;
                SqlCommand com = new SqlCommand(req, cn);
                com.ExecuteNonQuery();
                com = null;
                cn.Close();
                cn = null;
                MessageBox.Show("ce transfere de matla a été supprimer avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh("");
            }
        }
        //ID Matla
        //Phasonie
        //N° Bon
        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cb_recherche.SelectedIndex)
                {
                    case 0:
                        if (chk_enAttentePieces.Checked == true) refresh(" and mt.idMatla=" + txt_rechercher.Text);
                        else if (chk_enAttentePieces.Checked == false) refresh(" and mt.idMatla=" + txt_rechercher.Text);
                        break;
                    case 1:
                        if (chk_enAttentePieces.Checked == true) refresh(" and nomPhasonie like '%" + txt_rechercher.Text + "%' or prenomPhasonie like '%" + txt_rechercher.Text + "%'");
                        else if (chk_enAttentePieces.Checked == false) refresh(" and nomPhasonie like '%" + txt_rechercher.Text + "%' or prenomPhasonie like '%" + txt_rechercher.Text + "%'");
                        break;
                    case 2:
                        if (chk_enAttentePieces.Checked == true) refresh(" and pss.numeroBon=" + txt_rechercher.Text );
                        else if (chk_enAttentePieces.Checked == false) refresh(" and pss.numeroBon=" + txt_rechercher.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("doit etre rechercher par l'element séléctionner", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_confirmerEntree_Click(object sender, EventArgs e)
        {
            int idStocker = Convert.ToInt32(dgv_stockage.CurrentRow.Cells[9].Value);
            int qteSt = Convert.ToInt32(dgv_stockage.CurrentRow.Cells[5].Value);
            int idMt = Convert.ToInt32(dgv_stockage.CurrentRow.Cells[1].Value);
            frmConfirmerEntree f = new frmConfirmerEntree(idStocker,qteSt,idMt);
            f.ShowDialog();
        }
    }
}
