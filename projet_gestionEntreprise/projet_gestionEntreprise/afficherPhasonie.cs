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
    public partial class afficherPhasonie : Form
    {
        public afficherPhasonie()
        {
            InitializeComponent();
        }

        private void afficherPhasonie_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            string req = "select idPhasonie,nomPhasonie+' '+prenomPhasonie as nomPhasonie from phasonie";
            SqlCommand com1 = new SqlCommand(req, cn);
            SqlDataReader dr1 = com1.ExecuteReader();
            DataTable table1 = new DataTable();
            table1.Load(dr1);
            lst_phasonie.DisplayMember = "nomPhasonie";
            lst_phasonie.ValueMember = "idPhasonie";
            lst_phasonie.DataSource = table1;
            //fermeture de la datareader et la connexion et effacer la commande
            dr1.Close();
            dr1 = null;
            com1 = null;
            cn.Close();
            cn = null;
        }

        private void lst_phasonie_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            string req = "select idMatla,numeroBon,mt.referenceModele,designation,nbPieceSorter,entrees from matla mt inner join modele m on m.referenceModele=mt.referenceModele where mt.statutComplet=0 and idPhasonie="+lst_phasonie.SelectedValue;
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            dgv_matla.Rows.Clear();
            while (dr.Read())
            {
                dgv_matla.Rows.Add(dr["idMatla"], dr["numeroBon"], dr["referenceModele"], dr["designation"], dr["nbPieceSorter"], dr["entrees"]);
            }
            dr.Close();
            dr = null;
            com = null;

            cn.Close();
            cn = null;
        }

        private void btn_imprimer_Click(object sender, EventArgs e)
        {
            situationEmploye cr = new situationEmploye();
            cr.Refresh();
            cr.SetDatabaseLogon("sa", "123456");

            //    
            //string filtre = "{matla.statutComplet}=false and {phasonie.idPhasonie}=" + Convert.ToInt32(lst_phasonie.SelectedValue) + " and {matla.entrees}=0";
            //string filtre = "{matla.statutComplet}=false and {phasonie.idPhasonie}=" + Convert.ToInt32(lst_phasonie.SelectedValue);
            string filtre = "{phasonie.idPhasonie}=" + Convert.ToInt32(lst_phasonie.SelectedValue);
            frmImpression f = new frmImpression(cr, filtre);
            f.ShowDialog();


            //situationEmploye cr = new situationEmploye();
            //cr.Refresh();

            //// Set the database credentials
            //cr.SetDatabaseLogon("sa", "123456");

            //// Apply filter condition
            //string filter = "matla.statutComplet = 0 AND phasonie.idPhasonie = " + lst_phasonie.SelectedValue;

            //// Apply the filter to the report
            //cr.ReportSource = yourReportDocument; // Replace yourReportDocument with your ReportDocument object
            //cr.SelectionFormula = filter;
        }
    }
}
