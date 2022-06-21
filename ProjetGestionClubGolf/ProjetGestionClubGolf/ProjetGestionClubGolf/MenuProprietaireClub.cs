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
    public partial class MenuProprietaireClub : Form
    {
        public MenuProprietaireClub()
        {
            InitializeComponent();
        }


        string pwd;
        int numEmp;
        public MenuProprietaireClub(int numEmp, string pwd)
        {
            InitializeComponent();
            this.pwd = pwd;
            this.numEmp = numEmp;
        }

        private void btnGestionAbonnement_Click(object sender, EventArgs e)
        {
            GestionAbonnements gestionAbonnements = new GestionAbonnements();

            this.Hide();
            gestionAbonnements.ShowDialog();
            this.Show();
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

        private void btnGestionPrixDepenses1_Click(object sender, EventArgs e)
        {
            GestionPrixDepensesObligatoires gestionPrixDepensesObligatoires = new GestionPrixDepensesObligatoires();
            this.Hide();
            gestionPrixDepensesObligatoires.ShowDialog();
            this.Show();
        }

        private void btnAjouterPartieGolfJouer_Click(object sender, EventArgs e)
        {
            PartieGolfJouer partieGolfJouer = new PartieGolfJouer();
            this.Hide();
            partieGolfJouer.ShowDialog();
            this.Show();
        }

        private void btnAjoutDepense_Click(object sender, EventArgs e)
        {
            AjoutDepense ajoutDepense = new AjoutDepense(numEmp, pwd);
            this.Hide();
            ajoutDepense.ShowDialog();
            this.Show();
        }

        private void btnRapport_Click(object sender, EventArgs e)
        {
            Rapports rapports = new Rapports();
            this.Hide();
            rapports.ShowDialog();
            this.Show();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
