using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetGestionClubGolf.FormsAjoutAbonnement;

namespace ProjetGestionClubGolf
{
    public partial class ChoixTypeAjoutAbonnement : Form
    {
        public ChoixTypeAjoutAbonnement()
        {
            InitializeComponent();
        }

        private void btnPersonneSeul_Click(object sender, EventArgs e)
        {
            AjoutAbonnementSeulOuAgeOr formAbonnementSeulOuOr = new AjoutAbonnementSeulOuAgeOr();
            this.Hide();
            formAbonnementSeulOuOr.booAbonnementAgeOr = false;
            formAbonnementSeulOuOr.ShowDialog();
        }

        private void btnPersonneAge_Click(object sender, EventArgs e)
        {
            AjoutAbonnementSeulOuAgeOr formAbonnementSeulOuOr = new AjoutAbonnementSeulOuAgeOr();
            this.Hide();
            formAbonnementSeulOuOr.booAbonnementAgeOr = true;
            formAbonnementSeulOuOr.ShowDialog();
        }

        private void btnCouple_Click(object sender, EventArgs e)
        {
            AjoutAbonnementCouple formAbonnementCouple = new AjoutAbonnementCouple();
            this.Hide();
            formAbonnementCouple.ShowDialog();
        }

        private void btnFamille1enfant_Click(object sender, EventArgs e)
        {
            AjoutAbonnement1Enfant formAbonnement1Enfant = new AjoutAbonnement1Enfant();
            this.Hide();
            formAbonnement1Enfant.ShowDialog();
        }

        private void btnFamille2enfant_Click(object sender, EventArgs e)
        {
            AjoutAbonnement2Enfant formAbonnement2Enfant = new AjoutAbonnement2Enfant();
            this.Hide();
            formAbonnement2Enfant.ShowDialog();
        }

        private void btnFamille3enfant_Click(object sender, EventArgs e)
        {
            AjoutAbonnement3Enfant formAbonnement3Enfant = new AjoutAbonnement3Enfant();
            this.Hide();
            formAbonnement3Enfant.ShowDialog();
        }

    }
}
