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
    public partial class frmListeMatlaModele : Form
    {
        string reference;
        public frmListeMatlaModele(string id)
        {
            InitializeComponent();
            this.reference = id;
        }
        private void refresh(string filtre)
        {
            //if (chk_enStock.Checked == false)
            //{
            //    SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn.Open();
            //    //string req = "select m.*,sum(pss.qteStocker) as entree,designationStatutMatla,nbPieceSorter-sum(pss.qteStocker) as enAttente from matla m  left join phasonieStocker pss on pss.idMatla=m.idMatla inner join detailleur d on d.idDetailleur=m.idDetailleur inner join phasonie p on p.idPhasonie=m.idPhasonie inner join statutMatla sm on sm.idStatutMatla=m.idStatutMatla where referenceModele='"+idMt+"' "+filtre+" group by m.idMatla,m.referenceModele,m.idDetailleur,m.idPhasonie,nbPiece,dateDetailler,designationStatutMatla,nbPieceSorter,prixPhasonnier, statutComplet,m.numeroBon,statutTerminer,qteStock,m.idStatutMatla,entrees";
            //    string req = "select m.*,designationStatutMatla,nbPieceSorter-sum(pss.qteStocker) as enAttente from matla m  left join phasonieStocker pss on pss.idMatla=m.idMatla inner join detailleur d on d.idDetailleur=m.idDetailleur inner join phasonie p on p.idPhasonie=m.idPhasonie inner join statutMatla sm on sm.idStatutMatla=m.idStatutMatla where referenceModele='"+ reference + "' "+filtre+" group by m.idMatla,m.referenceModele,m.idDetailleur,m.idPhasonie,nbPiece,dateDetailler,designationStatutMatla,nbPieceSorter,prixPhasonnier, statutComplet,m.numeroBon,statutTerminer,qteStock,m.idStatutMatla,entrees,sorter,taille";
            //    SqlCommand com = new SqlCommand(req, cn);
            //    SqlDataReader dr = com.ExecuteReader();
            //    dgv_matla.Rows.Clear();
            //    while (dr.Read())
            //    {
            //        dgv_matla.Rows.Add(dr["idMatla"], dr["referenceModele"], dr["nbPiece"], dr["designationStatutMatla"], dr["nbPieceSorter"], dr["entrees"], dr["qteStock"], dr["enAttente"]);
            //    }
            //    // close all commandes and connection and datareader
            //    dr.Close();
            //    dr = null;
            //    com = null;

            //    cn.Close();
            //    cn = null;
            //}
            //else
            //{
            //    SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //    cn.Open();
            //    string req = "select m.*,sum(pss.qteStocker) as entree,designationStatutMatla,nbPieceSorter-sum(pss.qteStocker) as enAttente from matla m  left join phasonieStocker pss on pss.idMatla=m.idMatla inner join detailleur d on d.idDetailleur=m.idDetailleur inner join phasonie p on p.idPhasonie=m.idPhasonie inner join statutMatla sm on sm.idStatutMatla=m.idStatutMatla where referenceModele='" + reference + "' "+filtre+" and statutTerminer=0 group by m.idMatla,m.referenceModele,m.idDetailleur,m.idPhasonie,nbPiece,dateDetailler,designationStatutMatla,nbPieceSorter,prixPhasonnier, statutComplet,m.numeroBon,statutTerminer,qteStock,m.idStatutMatla";
            //    SqlCommand com = new SqlCommand(req, cn);
            //    SqlDataReader dr = com.ExecuteReader();
            //    dgv_matla.Rows.Clear();
            //    while (dr.Read())
            //    {
            //        dgv_matla.Rows.Add(dr["idMatla"], dr["referenceModele"], dr["nbPiece"], dr["designationStatutMatla"], dr["nbPieceSorter"], dr["entree"], dr["qteStock"], dr["enAttente"]);
            //    }
            //    // close all commandes and connection and datareader
            //    dr.Close();
            //    dr = null;
            //    com = null;

            //    cn.Close();
            //    cn = null;
            //}
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            //string req = "select m.*,sum(pss.qteStocker) as entree,designationStatutMatla,nbPieceSorter-sum(pss.qteStocker) as enAttente from matla m  left join phasonieStocker pss on pss.idMatla=m.idMatla inner join detailleur d on d.idDetailleur=m.idDetailleur inner join phasonie p on p.idPhasonie=m.idPhasonie inner join statutMatla sm on sm.idStatutMatla=m.idStatutMatla where referenceModele='"+idMt+"' "+filtre+" group by m.idMatla,m.referenceModele,m.idDetailleur,m.idPhasonie,nbPiece,dateDetailler,designationStatutMatla,nbPieceSorter,prixPhasonnier, statutComplet,m.numeroBon,statutTerminer,qteStock,m.idStatutMatla,entrees";
            //string req = "select mtc.idMatlaContient,mt.idMatla,mtc.referenceModele,mtc.taille,nomPhasonie,designationStatutMatla,mtc.qteSorter,mtc.entree,mtc.qteSorter-mtc.entree as manque from matla mt inner join matlaContient mtc on mtc.idMatla=mt.idMatla inner join phasonie ps on ps.idPhasonie=mt.idPhasonie inner join statutMatla st on st.idStatutMatla=mt.idStatutMatla where mtc.referenceModele='" + reference+"' and mtc.idSituationModele="+cb_situation.SelectedValue;
            string req = "select idMatla,referenceModele,taille,nomPhasonie,designationStatutMatla,nbPieceSorter,entrees,nbPieceSorter-entrees as manque from matla mt inner join phasonie ps on ps.idPhasonie=mt.idPhasonie inner join statutMatla st on st.idStatutMatla=mt.idStatutMatla where mt.referenceModele='" + reference + "' and mt.idSituationModele=" + cb_situation.SelectedValue;
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            dgv_matla.Rows.Clear();
            while (dr.Read())
            {
                dgv_matla.Rows.Add(dr["idMatla"], dr["referenceModele"], dr["taille"], dr["nomPhasonie"], dr["designationStatutMatla"], dr["nbPieceSorter"], dr["entrees"], dr["manque"]);
            }
            // close all commandes and connection and datareader
            dr.Close();
            dr = null;
            com = null;

            cn.Close();
            cn = null;
        }
        private void frmListeMatlaModele_Load(object sender, EventArgs e)
        {
            SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn1.Open();
            string req = "select * from situationModele where referenceModele='" + reference + "' order by idSituationModele desc";
            SqlCommand com1 = new SqlCommand(req, cn1);
            SqlDataReader dr1 = com1.ExecuteReader();
            DataTable table1 = new DataTable();
            table1.Load(dr1);
            cb_situation.DisplayMember = "numeroSituation";
            cb_situation.ValueMember = "idSituationModele";
            cb_situation.DataSource = table1;
            //fermeture de la datareader et la connexion et effacer la commande
            dr1.Close();
            dr1 = null;
            com1 = null;
            cn1.Close();
            cn1 = null;
            refresh("");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chk_enStock_CheckedChanged(object sender, EventArgs e)
        {
            refresh("");
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh("");
            txt_rechercher.Text = "";
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            refresh(" and m.idMatla="+txt_rechercher.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            SqlCommand com = new SqlCommand("select count(idMatla) from detailLivraison where idMatla="+dgv_matla.CurrentRow.Cells[0].Value , cn);
            int nb = Convert.ToInt32(com.ExecuteScalar());

            com = null;
            cn.Close();
            cn = null;


            if (nb > 0)
            {
                string ch = Application.StartupPath + @"\imageModeles\";

                livraisonMatla cr = new livraisonMatla();
                cr.Refresh();
                cr.SetDatabaseLogon("sa", "123456");

                cr.SetParameterValue("chemain", ch);
                //cr.SetParameterValue("entree", entree);
                //cr.SetParameterValue("reste", reste);
                //cr.SetParameterValue("resteMatla", resteMatla);
                //   
                string filtre = "{matla.idMatla}=" + dgv_matla.CurrentRow.Cells[0].Value;
                frmImpression f = new frmImpression(cr, filtre);
                f.ShowDialog();
            }
            else
            {
                string ch = Application.StartupPath + @"\imageModeles\";

                fiche cr = new fiche();
                cr.Refresh();
                cr.SetDatabaseLogon("sa", "123456");

                cr.SetParameterValue("chemain", ch);
                //cr.SetParameterValue("entree", entree);
                //cr.SetParameterValue("reste", reste);
                //cr.SetParameterValue("resteMatla", resteMatla);
                //   
                string filtre = "{modele.referenceModele}='" +dgv_matla.CurrentRow.Cells[1].Value+"' and {matla.idMatla}="+ dgv_matla.CurrentRow.Cells[0].Value;
                frmImpression f = new frmImpression(cr, filtre);
                f.ShowDialog();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //string ch = Application.StartupPath + @"\imageModeles\";

            //livraisonMatla cr = new livraisonMatla();
            //cr.Refresh();
            //cr.SetDatabaseLogon("sa", "123456");

            //cr.SetParameterValue("chemain", ch);
            ////cr.SetParameterValue("entree", entree);
            ////cr.SetParameterValue("reste", reste);
            ////cr.SetParameterValue("resteMatla", resteMatla);
            ////   
            //string filtre = "{matla.idMatla}=" + idMt;
            //frmImpression f = new frmImpression(cr, filtre);
            //f.ShowDialog();
        }

        private void cb_situation_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh("");
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            int idMatla = Convert.ToInt32(dgv_matla.CurrentRow.Cells[0].Value);
            frmModifierMatlaContientFromListeMatlaModele f = new frmModifierMatlaContientFromListeMatlaModele(idMatla);
            f.ShowDialog();
        }
    }
}
