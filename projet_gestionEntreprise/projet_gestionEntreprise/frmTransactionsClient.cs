using CrystalDecisions.CrystalReports.Engine;
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
    public partial class frmTransactionsClient : Form
    {
        int idC;
        public frmTransactionsClient(int id)
        {
            InitializeComponent();
            this.idC = id;
        }
        private void refresh(string filtre)
        {
            if (rb_tousTransactions.Checked == true)
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string req = "select idTransaction,montant,dateTransaction,TypeTransaction,[description] from transactions t inner join client c on c.idClient=t.idClient where c.idClient="+idC+filtre+ " order by idTransaction desc";
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_transactions.Rows.Clear();
                while (dr.Read())
                {
                    dgv_transactions.Rows.Add(dr["idTransaction"], dr["montant"], Convert.ToDateTime(dr["dateTransaction"].ToString()).ToShortDateString(), dr["description"], dr["TypeTransaction"]);
                }
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
            }
            else if (rb_filtreParDate.Checked == true)
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string req = "select idTransaction,montant,dateTransaction,TypeTransaction,[description] from transactions t inner join client c on c.idClient=t.idClient where c.idClient=" + idC+filtre + " and dateTransaction between @dateDebut and @dateFin order by idTransaction desc";
                SqlCommand com = new SqlCommand(req, cn);
                com.Parameters.AddWithValue("@dateDebut",dtp_dateDebut.Value);
                com.Parameters.AddWithValue("@dateFin",dtp_dateFinale.Value);
                SqlDataReader dr = com.ExecuteReader();
                dgv_transactions.Rows.Clear();
                while (dr.Read())
                {
                    dgv_transactions.Rows.Add(dr["idTransaction"], dr["montant"], Convert.ToDateTime(dr["dateTransaction"].ToString()).ToShortDateString(), dr["description"], dr["TypeTransaction"]);
                }
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
            }
        }
        private void frmTransactionsClient_Load(object sender, EventArgs e)
        {
            refresh("");
            rb_tousTransactions.Checked = true;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh("");
            txt_rechercher.Text = "";
        }

        private void rb_tousTransactions_CheckedChanged(object sender, EventArgs e)
        {
            refresh("");
        }

        private void rb_filtreParDate_CheckedChanged(object sender, EventArgs e)
        {
            refresh("");
        }

        private void dtp_dateDebut_ValueChanged(object sender, EventArgs e)
        {
            refresh("");
        }

        private void dtp_dateFinale_ValueChanged(object sender, EventArgs e)
        {
            refresh("");
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            refresh(" and dateTransaction like'%" + txt_rechercher.Text + "%'");
        }
        private void imprimer(ReportClass cr)
        {
            cr.SetDatabaseLogon("sa", "123456");
            //if (chemain != "")
            //    cr.SetParameterValue("chemain", chemain);

            frmImpression f = new frmImpression(cr);
            f.ShowDialog();
        }
        private void btn_imprimerTransaction_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            string req = "select tr.*,nomClient,prenomClient,adresseClient,restePayer from transactions tr inner join client c on C.idClient=tr.idClient where c.idClient=" + idC;
            SqlCommand com = new SqlCommand(req, cn);
            //com.Parameters.AddWithValue("@dateDebut", dtp_dateDebut.Value);
            //com.Parameters.AddWithValue("@dateFin", dtp_dateFinale.Value);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            ad.Fill(ds);

            transactionClient cr = new transactionClient();
            cr.SetDataSource(ds.Tables["table"]);
            imprimer(cr);
        }
        //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
        //cn.Open();
        //    string req = "select * from commande where dateCommande between @dateDebut and @dateFin";
        //SqlCommand com = new SqlCommand(req, cn);
        //com.Parameters.AddWithValue("@dateDebut", dtp_dateDebut.Value);
        //    com.Parameters.AddWithValue("@dateFin", dtp_dateFinale.Value);
        //    SqlDataAdapter ad = new SqlDataAdapter(com);
        //DataSet ds = new DataSet();
        //ad.Fill(ds);

        //    CrystalReport4 cr = new CrystalReport4();
        //cr.SetDataSource(ds.Tables["table"]);
        //    frmImpression f = new frmImpression(cr);
        //f.ShowDialog();
    }
}
