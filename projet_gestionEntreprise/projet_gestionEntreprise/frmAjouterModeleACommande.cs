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
    public partial class frmAjouterModeleACommande : Form
    {
        int idCmd;
        public frmAjouterModeleACommande(int idCmd)
        {
            InitializeComponent();
            this.idCmd = idCmd;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void frmAjouterModeleACommande_Load(object sender, EventArgs e)
        {
            txt_idCommande.Text = idCmd.ToString();
        }
    }
}
