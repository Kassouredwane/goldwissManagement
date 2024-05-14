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
    public partial class frmGestionMatla : Form
    {
        public frmGestionMatla()
        {
            InitializeComponent();
        }
        string statut;
        private void fillEmptyCells()
        {
            foreach (DataGridViewRow row in dgv_matla.Rows)
            {
                if (row.Cells[10].Value == "")
                {
                    row.Cells[10].Value ="default";
                }
            }
        }
        private void refresh(string filtre)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
            cn.Open();
            ////string req = "select m.*,nomDetailleur+' '+prenomDetailleur as nomDetailleur,nomPhasonie+' '+prenomPhasonie as nomPhaosnie,ISNULL(sum(pss.qteStocker),0) as entree,designationStatutMatla,nbPieceSorter-ISNULL(sum(pss.qteStocker),0) as enAttente from matla m  left join phasonieStocker pss on pss.idMatla=m.idMatla inner join detailleur d on d.idDetailleur=m.idDetailleur inner join phasonie p on p.idPhasonie=m.idPhasonie inner join statutMatla sm on sm.idStatutMatla=m.idStatutMatla where m.statutComplet='" + Convert.ToString(!guna2CheckBox2.Checked) + "' and statutTerminer='" + Convert.ToString(!guna2CheckBox1.Checked) + "' " + filtre+ " group by m.idMatla,m.referenceModele,m.idDetailleur,m.idPhasonie,nbPiece,dateDetailler,designationStatutMatla,nbPieceSorter,prixPhasonnier, statutComplet,m.numeroBon,statutTerminer,qteStock,m.idStatutMatla,entrees,nomDetailleur,prenomDetailleur,nomPhasonie,prenomPhasonie order by m.idMatla desc";
            //string req = "select m.*,prenomDetailleur,nomPhasonie+' '+prenomPhasonie as nomPhasonie,designationStatutMatla,nbPieceSorter-entrees as Manque from matla m  left join phasonieStocker pss on pss.idMatla=m.idMatla inner join detailleur d on d.idDetailleur=m.idDetailleur inner join phasonie p on p.idPhasonie=m.idPhasonie inner join statutMatla sm on sm.idStatutMatla=m.idStatutMatla where m.statutComplet='" + Convert.ToString(!guna2CheckBox2.Checked) + "' and statutTerminer='" + Convert.ToString(!guna2CheckBox1.Checked) + "' " + filtre + " order by m.idMatla desc";
            string req = "select mt.idMatla,mt.referenceModele,mt.nbPieceSorter,prenomDetailleur,dateDetailler,nomPhasonie+' '+prenomPhasonie as nomPhasonie,prixPhasonnier,numeroBon,designationStatutMatla,mt.nbPieceSorter,mt.entrees,mt.qteStock,mt.nbPieceSorter-mt.entrees as Manque from matla mt inner join detailleur dt on dt.idDetailleur=mt.idDetailleur inner join phasonie ps on ps.idPhasonie=mt.idPhasonie inner join statutMatla st on st.idStatutMatla=mt.idStatutMatla  where mt.statutComplet='" + Convert.ToString(!guna2CheckBox2.Checked) + "' " + filtre + " order by mt.idMatla desc";
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            dgv_matla.Rows.Clear();
            while (dr.Read())
            {
                dgv_matla.Rows.Add(dr["idMatla"], dr["referenceModele"], dr["prenomDetailleur"], Convert.ToDateTime(dr["dateDetailler"].ToString()).ToShortDateString(), dr["nomPhasonie"], dr["prixPhasonnier"], dr["numeroBon"], dr["designationStatutMatla"], dr["nbPieceSorter"], dr["entrees"], dr["qteStock"], dr["Manque"]);
            }
            // close all commandes and connection and datareader
            dr.Close();
            dr = null;
            com = null;

            cn.Close();
            cn = null;

            // fill empty cells with default value
            fillEmptyCells();
        }
        private void frmGestionMatla_Load(object sender, EventArgs e)
        {
            refresh("");
            cb_recherche.SelectedIndex = 0;
            guna2CheckBox2.Checked = true;


        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            refresh("");
            txt_rechercher.Text = "";
        }

        //private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    //refresh("");
        //    //txt_rechercher.Text = "";
        //}

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            frmAjouterMatla f = new frmAjouterMatla();
            f.ShowDialog();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (dgv_matla.Rows.Count >= 1)
            {
                int idMatla = Convert.ToInt32(dgv_matla.CurrentRow.Cells[0].Value);
                frmModifierMatla f = new frmModifierMatla(idMatla);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("aucun matla séléctionner", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh("");
            txt_rechercher.Text = "";
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Si vous avez supprimer cette Matla vous avez aussi supprimer les livraison correspondant ce Matla ! Etes-vous vraiment veux supprimer ce Matla ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int idMt = Convert.ToInt32(dgv_matla.CurrentRow.Cells[0].Value);
                //delete from detailLivraison
                SqlConnection cn5 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn5.Open();
                string req5 = "delete from detailLivraison where idMatla=" + idMt;
                SqlCommand com5 = new SqlCommand(req5, cn5);
                com5.ExecuteNonQuery();
                com5 = null;
                cn5.Close();
                cn5 = null;
                //delete livraison
                SqlConnection cn6 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn6.Open();
                string req6 = "delete from livraison where idLivraison in (select idLivraison from detailLivraison where idMatla=" + idMt + ")";
                SqlCommand com6 = new SqlCommand(req6, cn6);
                com6.ExecuteNonQuery();
                com6 = null;
                cn6.Close();
                cn6 = null;
                //delete from phasonieStocker
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string req = "delete from phasonieStocker where idMatla=" + idMt;
                SqlCommand com = new SqlCommand(req, cn);
                com.ExecuteNonQuery();
                com = null;
                cn.Close();
                cn = null;
                //delete from transfereLavageToPhasonie
                SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn2.Open();
                string req2 = "delete from transfereLavageToPhasonie where idMatla=" + idMt;
                SqlCommand com2 = new SqlCommand(req2, cn2);
                com2.ExecuteNonQuery();
                com2 = null;
                cn2.Close();
                cn2 = null;
                //delete from transferePhasonieToLavage
                SqlConnection cn3 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn3.Open();
                string req3 = "delete from transferePhasonieToLavage where idMatla=" + idMt;
                SqlCommand com3 = new SqlCommand(req3, cn3);
                com3.ExecuteNonQuery();
                com3 = null;
                cn3.Close();
                cn3 = null;
                //delete from 
                SqlConnection cn4 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn4.Open();
                string req4 = "delete from matla where idMatla=" + idMt;
                SqlCommand com4 = new SqlCommand(req4, cn4);
                com4.ExecuteNonQuery();
                com4 = null;
                cn4.Close();
                cn4 = null;
                refresh("");
            }
        }

        private void frm_supprimerTous_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Etes-vous vraiment veux supprimer tous les Matla dans la grid ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgv_matla.Rows)
                    {
                        int idMt = Convert.ToInt32(row.Cells[0].Value);

                        if (idMt != null)
                        {
                            //delete from detailLivraison
                            SqlConnection cn5 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                            cn5.Open();
                            string req5 = "delete from detailLivraison where idMatla=" + idMt;
                            SqlCommand com5 = new SqlCommand(req5, cn5);
                            com5.ExecuteNonQuery();
                            com5 = null;
                            cn5.Close();
                            cn5 = null;
                            //delete livraison
                            SqlConnection cn6 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                            cn6.Open();
                            string req6 = "delete from livraison where idLivraison in (select idLivraison from detailLivraison where idMatla=" + idMt + ")";
                            SqlCommand com6 = new SqlCommand(req6, cn6);
                            com6.ExecuteNonQuery();
                            com6 = null;
                            cn6.Close();
                            cn6 = null;
                            //delete from phasonieStocker
                            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                            cn.Open();
                            string req = "delete from phasonieStocker where idMatla=" + idMt;
                            SqlCommand com = new SqlCommand(req, cn);
                            com.ExecuteNonQuery();
                            com = null;
                            cn.Close();
                            cn = null;
                            //delete from transfereLavageToPhasonie
                            SqlConnection cn2 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                            cn2.Open();
                            string req2 = "delete from transfereLavageToPhasonie where idMatla=" + idMt;
                            SqlCommand com2 = new SqlCommand(req2, cn2);
                            com2.ExecuteNonQuery();
                            com2 = null;
                            cn2.Close();
                            cn2 = null;
                            //delete from transferePhasonieToLavage
                            SqlConnection cn3 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                            cn3.Open();
                            string req3 = "delete from transferePhasonieToLavage where idMatla=" + idMt;
                            SqlCommand com3 = new SqlCommand(req3, cn3);
                            com3.ExecuteNonQuery();
                            com3 = null;
                            cn3.Close();
                            cn3 = null;
                            //delete from 
                            SqlConnection cn4 = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                            cn4.Open();
                            string req4 = "delete from matla where idMatla=" + idMt;
                            SqlCommand com4 = new SqlCommand(req4, cn4);
                            com4.ExecuteNonQuery();
                            com4 = null;
                            cn4.Close();
                            cn4 = null;
                            refresh("");
                        }
                    }
                }
            }
            catch(Exception error) { MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Id Matla
        //Reference Modele
        //Numero Bon
        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cb_recherche.SelectedIndex)
                {
                    case 0:
                        refresh(" and mt.idMatla=" + txt_rechercher.Text);
                        break;
                    case 1:
                        refresh(" and mt.referenceModele='" + txt_rechercher.Text+"'");
                        break;
                    case 2:
                        refresh(" and nomPhasonie like '%" + txt_rechercher.Text + "%' or prenomPhasonie like '%" + txt_rechercher.Text + "%'");
                        break;
                    case 3:
                        refresh(" and mt.numeroBon=" + txt_rechercher.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("doit etre rechercher par l'élément séléctionner", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_matla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 10) // Replace 5 with the column index you want to target
            {
                // Check if the cell value is null or empty
                if (e.Value == null || string.IsNullOrWhiteSpace(e.Value.ToString()))
                {
                    // Set the cell value to "0"
                    e.Value = "0";
                    e.FormattingApplied = true; // Set the FormattingApplied property to true
                }
            }
            if (e.ColumnIndex == 12) // Replace 5 with the column index you want to target
            {
                // Check if the cell value is null or empty
                if (e.Value == null || string.IsNullOrWhiteSpace(e.Value.ToString()))
                {
                    // Get the value from cells[2] of the same row
                    string valueFromCells2 = dgv_matla.Rows[e.RowIndex].Cells[9].Value.ToString();

                    // Set the cell value to the value from cells[2] of the same row
                    e.Value = valueFromCells2;
                    e.FormattingApplied = true; // Set the FormattingApplied property to true
                }
            }
        }

        private void btn_livraisonMatla_Click(object sender, EventArgs e)
        {
            int idMatla = Convert.ToInt32(dgv_matla.CurrentRow.Cells[0].Value);
            int entre = Convert.ToInt32(dgv_matla.CurrentRow.Cells[9].Value);
            int attente = Convert.ToInt32(dgv_matla.CurrentRow.Cells[11].Value);
            frmLivraisonMatla f = new frmLivraisonMatla(idMatla,entre,attente);
            f.ShowDialog();
        }

        private void btn_affichePhasonie_Click(object sender, EventArgs e)
        {
            afficherPhasonie f = new afficherPhasonie();
            f.ShowDialog();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            refresh("");
            txt_rechercher.Text = "";
        }
    }
}
