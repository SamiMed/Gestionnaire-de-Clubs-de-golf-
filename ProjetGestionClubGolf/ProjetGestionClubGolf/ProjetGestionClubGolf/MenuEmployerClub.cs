using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestionClubGolf
{
    public partial class MenuEmployerClub : Form
    {
        public MenuEmployerClub()
        {
            InitializeComponent();
        }

        private void btnReabonnement_Click(object sender, EventArgs e)
        {
            FrmReabonnements frmReabonnements = new FrmReabonnements();
            this.Hide();
            frmReabonnements.ShowDialog();
            this.Show();

        }

        private void btnMiseAjourAbonnees_Click(object sender, EventArgs e)
        {
            MiseAjourAbonnees miseAjourAbonees = new MiseAjourAbonnees();
            this.Hide();
            miseAjourAbonees.ShowDialog();
            this.Show();
        }

        private void btnAjouterPartieGolfJouer_Click(object sender, EventArgs e)
        {
            PartieGolfJouer partieGolfJouer = new PartieGolfJouer();
            this.Hide();
            partieGolfJouer.ShowDialog();
            this.Show();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {   
            this.Close();
        }
    }
}
