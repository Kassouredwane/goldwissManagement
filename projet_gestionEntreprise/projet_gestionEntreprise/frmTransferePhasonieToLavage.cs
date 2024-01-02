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
    public partial class frmTransferePhasonieToLavage : Form
    {
        public frmTransferePhasonieToLavage()
        {
            InitializeComponent();
        }
        private void colorOfRow()
        {
            foreach (DataGridViewRow row in dgv_transfere.Rows)
            {
                DataGridViewTextBoxCell cell1 = row.Cells[3] as DataGridViewTextBoxCell;
                DataGridViewTextBoxCell cell2 = row.Cells[4] as DataGridViewTextBoxCell;

                if (cell1 != null && cell2 != null && cell1.Value != null && cell2.Value != null)
                {
                    int value1, value2;
                    if (int.TryParse(cell1.Value.ToString(), out value1) && int.TryParse(cell2.Value.ToString(), out value2))
                    {
                        if (value1 > value2)
                        {
                            row.DefaultCellStyle.BackColor = Color.IndianRed;
                            row.DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                }
            }
        }
        private void refresh(string filtre)
        {
            cb_recherche.SelectedIndex = 0;
            if (chk_enAttentePieces.Checked == false)
            {
                // fill grid view by transfere
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string req = "select tpl.idTransferePhasonieToLavage,mt.idMatla,ps.idPhasonie,nomPhasonie+' '+prenomPhasonie as phasonie,lv.idLavage,nomLavage as lavage,nbPieceSorter,qteTransfere,dateTransfere,tpl.numeroBon from transferePhasonieToLavage tpl inner join matla mt on mt.idMatla=tpl.idMatla inner join phasonie ps on ps.idPhasonie=mt.idPhasonie inner join lavage lv on lv.idLavage=tpl.idLavage"+filtre+ " order by idTransferePhasonieToLavage desc";
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_transfere.Rows.Clear();
                while (dr.Read())
                {
                    dgv_transfere.Rows.Add(dr["phasonie"], dr["lavage"], dr["idMatla"], dr["nbPieceSorter"], dr["qteTransfere"], Convert.ToDateTime(dr["dateTransfere"].ToString()).ToShortDateString(), dr["numeroBon"], dr["idTransferePhasonieToLavage"]);
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
                string req = "select tpl.idTransferePhasonieToLavage,mt.idMatla,ps.idPhasonie,nomPhasonie+' '+prenomPhasonie as phasonie,lv.idLavage,nomLavage as lavage,nbPieceSorter,qteTransfere,dateTransfere,tpl.numeroBon from transferePhasonieToLavage tpl inner join matla mt on mt.idMatla=tpl.idMatla inner join phasonie ps on ps.idPhasonie=mt.idPhasonie inner join lavage lv on lv.idLavage=tpl.idLavage where mt.statutComplet=0" + filtre + " order by idTransferePhasonieToLavage desc";
                SqlCommand com = new SqlCommand(req, cn);
                SqlDataReader dr = com.ExecuteReader();
                dgv_transfere.Rows.Clear();
                while (dr.Read())
                {
                    dgv_transfere.Rows.Add(dr["phasonie"], dr["lavage"], dr["idMatla"], dr["nbPieceSorter"], dr["qteTransfere"], Convert.ToDateTime(dr["dateTransfere"].ToString()).ToShortDateString(), dr["numeroBon"], dr["idTransferePhasonieToLavage"]);
                }
                dr.Close();
                dr = null;
                com = null;

                cn.Close();
                cn = null;
            }
            colorOfRow();
        }
        private void frmTransferePhasonieToLavage_Load(object sender, EventArgs e)
        {
            cb_recherche.SelectedIndex = 0;
            refresh("");
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            frmAjouterTransferePhasonieToLavage f = new frmAjouterTransferePhasonieToLavage();
            f.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh("");
        }
        
        private void chk_enAttentePieces_CheckedChanged(object sender, EventArgs e)
        {
            refresh("");
        }
        //ID Matla
        //Phasonie
        //Lavage
        //N° Bon
        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cb_recherche.SelectedIndex)
                {
                    case 0:
                        if(chk_enAttentePieces.Checked==true) refresh(" and mt.idMatla=" + txt_rechercher.Text);
                        else if (chk_enAttentePieces.Checked == false) refresh(" where mt.idMatla=" + txt_rechercher.Text);
                        break;
                    case 1:
                        if (chk_enAttentePieces.Checked == true) refresh(" and nomPhasonie like '%" + txt_rechercher.Text + "%' or prenomPhasonie like '%" + txt_rechercher.Text + "%'");
                        else if (chk_enAttentePieces.Checked == false) refresh(" where nomPhasonie like '%" + txt_rechercher.Text + "%' or prenomPhasonie like '%" + txt_rechercher.Text + "%'");
                        break;
                    case 2:
                        if(chk_enAttentePieces.Checked==true) refresh(" and nomLavage like '%" + txt_rechercher.Text + "%'");
                        else if (chk_enAttentePieces.Checked == false) refresh(" where nomLavage like '%" + txt_rechercher.Text + "%' or prenomLavage like '%" + txt_rechercher.Text + "%'");
                        break;
                    case 3:
                        if(chk_enAttentePieces.Checked==true) refresh(" and tpl.numeroBon =" + txt_rechercher.Text);
                        else if (chk_enAttentePieces.Checked == false) refresh(" where tpl.numeroBon =" + txt_rechercher.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("doit etre rechercher par l'element séléctionner", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            int idTransfere = Convert.ToInt32(dgv_transfere.CurrentRow.Cells[7].Value);
            frmModifierTransferePhasonieToLavage f = new frmModifierTransferePhasonieToLavage(idTransfere);
            f.ShowDialog();
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous vraiment veux supprimer cette transfere de matla ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=goldwissDatabase;User ID=sa;Password=123456");
                cn.Open();
                string req = "delete from transferePhasonieToLavage where idTransferePhasonieToLavage=" + dgv_transfere.CurrentRow.Cells[7].Value;
                SqlCommand com = new SqlCommand(req, cn);
                com.ExecuteNonQuery();
                com = null;
                cn.Close();
                cn = null;
                MessageBox.Show("ce transfere de matla a été supprimer avec succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh("");
            }
        }
    }
}
