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
    public partial class frmListeSituationModele : Form
    {
        string reference;
        public frmListeSituationModele(string refM)
        {
            InitializeComponent();
            this.reference = refM;
        }

        private void frmListeSituationModele_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            string req = "select * from situationModele where referenceModele='"+reference+"'";
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            dgv_situationModele.Rows.Clear();
            while (dr.Read())
            {
                dgv_situationModele.Rows.Add(dr["numeroSituation"], Convert.ToDateTime(dr["dateDebutSituation"].ToString()).ToShortDateString(), dr["qteDetailler"], dr["qteStock"], dr["disponible"], dr["entree"], dr["idSituationModele"]);
            }
            // close all commandes and connection and datareader
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

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            int idSituationModele = Convert.ToInt32(dgv_situationModele.CurrentRow.Cells[6].Value);
            frmModifierSituationModele f = new frmModifierSituationModele(idSituationModele);
            f.ShowDialog();
        }

        private void btn_imprimerLivraison_Click(object sender, EventArgs e)
        {
            


            //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            //cn.Open();
            //SqlCommand com = new SqlCommand("select count(idSituationModele) from detailLivraison where idSituationModele=" + dgv_situationModele.CurrentRow.Cells[6].Value, cn);
            //int nb = Convert.ToInt32(com.ExecuteScalar());

            //com = null;
            //cn.Close();
            //cn = null;


            //if (nb > 0)
            //{
            //    string ch = Application.StartupPath + @"\imageModeles\";

            //    situationModele cr = new situationModele();
            //    //situationModeleEmpty cr = new situationModeleEmpty();
            //    cr.Refresh();
            //    cr.SetDatabaseLogon("sa", "123456");

            //    cr.SetParameterValue("chemain", ch);
            //    //cr.SetParameterValue("entree", entree);
            //    //cr.SetParameterValue("reste", reste);
            //    //cr.SetParameterValue("resteMatla", resteMatla);
            //    //   
            //    string filtre = "{situationModele.idSituationModele}=" + dgv_situationModele.CurrentRow.Cells[6].Value;
            //    frmImpression f = new frmImpression(cr, filtre);
            //    f.ShowDialog();
            //}
            //else
            //{
            //    string ch = Application.StartupPath + @"\imageModeles\";

            //    //situationModele cr = new situationModele();
            //    situationModeleEmpty cr = new situationModeleEmpty();
            //    cr.Refresh();
            //    cr.SetDatabaseLogon("sa", "123456");

            //    cr.SetParameterValue("chemain", ch);
            //    //cr.SetParameterValue("entree", entree);
            //    //cr.SetParameterValue("reste", reste);
            //    //cr.SetParameterValue("resteMatla", resteMatla);
            //    //   
            //    string filtre = "{situationModele.idSituationModele}=" + dgv_situationModele.CurrentRow.Cells[6].Value;
            //    frmImpression f = new frmImpression(cr, filtre);
            //    f.ShowDialog();
            //}
        }
    }
}
