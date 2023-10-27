using projet_gestionEntreprise.Properties;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void AfficherFenetre(Form f)
        {
            if (panel4.Controls.Count > 0)
            {
                Form oldForm = (Form)panel4.Controls[0];
                oldForm.Close();
            }

            panel4.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(f);
            f.Show();
        }
        private bool isCollapsed ;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btn_gestionTransfere.Image = Resources.icons8_flèche_réduire_64;
                panel2.Top = dropDownContainer.Top + 155;
                dropDownContainer.Height += 10;
                if (dropDownContainer.Size == dropDownContainer.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                btn_gestionTransfere.Image = Resources.icons8_flèche_développer_64;
                panel2.Top = 449;
                dropDownContainer.Height -= 10;
                if (dropDownContainer.Size == dropDownContainer.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btn_gestionTransfere_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //btn_gestionTransfere.FlatStyle = Flat;
            frmBienvenue f = new frmBienvenue();
            AfficherFenetre(f);
        }

        private void btn_deconnecter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("est ce que vous avez vraiment veux deconnecter", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_gestionClients_Click(object sender, EventArgs e)
        {
            frmGestionClients f = new frmGestionClients();
            AfficherFenetre(f);
        }

        private void btn_gestionCommandes_Click(object sender, EventArgs e)
        {
            frmGestionCommandes f = new frmGestionCommandes();
            AfficherFenetre(f);
        }
    }
}
