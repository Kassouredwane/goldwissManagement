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
        string idMt;
        public frmListeMatlaModele(string id)
        {
            InitializeComponent();
            this.idMt = id;
        }
        private void refresh(string filtre)
        {
            if (chk_enStock.Checked == false)
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                //string req = "select m.*,sum(pss.qteStocker) as entree,designationStatutMatla,nbPieceSorter-sum(pss.qteStocker) as enAttente from matla m  left join phasonieStocker pss on pss.idMatla=m.idMatla inner join detailleur d on d.idDetailleur=m.idDetailleur inner join phasonie p on p.idPhasonie=m.idPhasonie inner join statutMatla sm on sm.idStatutMatla=m.idStatutMatla where referenceModele='"+idMt+"' "+filtre+" group by m.idMatla,m.referenceModele,m.idDetailleur,m.idPhasonie,nbPiece,dateDetailler,designationStatutMatla,nbPieceSorter,prixPhasonnier, statutComplet,m.numeroBon,statutTerminer,qteStock,m.idStatutMatla,entrees";
                string req = "select m.*,designationStatutMatla,nbPieceSorter-sum(pss.qteStocker) as enAttente from matla m  left join phasonieStocker pss on pss.idMatla=m.idMatla inner join detailleur d on d.idDetailleur=m.idDetailleur inner join phasonie p on p.idPhasonie=m.idPhasonie inner join statutMatla sm on sm.idStatutMatla=m.idStatutMatla where referenceModele='"+idMt+"' "+filtre+" group by m.idMatla,m.referenceModele,m.idDetailleur,m.idPhasonie,nbPiece,dateDetailler,designationStatutMatla,nbPieceSorter,prixPhasonnier, statutComplet,m.numeroBon,statutTerminer,qteStock,m.idStatutMatla,entrees";
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_matla.Rows.Clear();
                while (dr.Read())
                {
                    dgv_matla.Rows.Add(dr["idMatla"], dr["referenceModele"], dr["nbPiece"], dr["designationStatutMatla"], dr["nbPieceSorter"], dr["entrees"], dr["qteStock"], dr["enAttente"]);
                }
                // close all commandes and connection and datareader
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
            }
            else
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string req = "select m.*,sum(pss.qteStocker) as entree,designationStatutMatla,nbPieceSorter-sum(pss.qteStocker) as enAttente from matla m  left join phasonieStocker pss on pss.idMatla=m.idMatla inner join detailleur d on d.idDetailleur=m.idDetailleur inner join phasonie p on p.idPhasonie=m.idPhasonie inner join statutMatla sm on sm.idStatutMatla=m.idStatutMatla where referenceModele='" + idMt + "' "+filtre+" and statutTerminer=0 group by m.idMatla,m.referenceModele,m.idDetailleur,m.idPhasonie,nbPiece,dateDetailler,designationStatutMatla,nbPieceSorter,prixPhasonnier, statutComplet,m.numeroBon,statutTerminer,qteStock,m.idStatutMatla";
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_matla.Rows.Clear();
                while (dr.Read())
                {
                    dgv_matla.Rows.Add(dr["idMatla"], dr["referenceModele"], dr["nbPiece"], dr["designationStatutMatla"], dr["nbPieceSorter"], dr["entree"], dr["qteStock"], dr["enAttente"]);
                }
                // close all commandes and connection and datareader
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
            }
        }
        private void frmListeMatlaModele_Load(object sender, EventArgs e)
        {
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
    }
}
