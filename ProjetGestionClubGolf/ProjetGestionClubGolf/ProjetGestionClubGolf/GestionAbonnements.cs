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
    public partial class GestionAbonnements : Form
    {
        private monDataContextDataContext monDataContext = new monDataContextDataContext();

        public GestionAbonnements()
        {
            InitializeComponent();
        }

        private void GestionAbonnements_Load(object sender, EventArgs e)
        {
            UpdateEtRefreshAbonnements();
        }

        private void UpdateEtRefreshAbonnements()
        {
            abonnementBindingSource.DataSource = from unAbonnement in monDataContext.Abonnements
                                                 join unTypeAbonnement in monDataContext.TypesAbonnements
                                                 on unAbonnement.NoTypeAbonnement equals unTypeAbonnement.No
                                                 select new
                                                 {
                                                     Id = unAbonnement.Id,
                                                     DateAbonnementss = unAbonnement.DateAbonnement,
                                                     Nom = unAbonnement.Nom,
                                                     Prenom = unAbonnement.Prenom,
                                                     Sexe = unAbonnement.Sexe,
                                                     DateNaissance = unAbonnement.DateNaissance,
                                                     NoCivique = unAbonnement.NoCivique,
                                                     Rue = unAbonnement.Rue,
                                                     Ville = unAbonnement.Ville,
                                                     IdProvince = unAbonnement.IdProvince,
                                                     CodePostal = unAbonnement.CodePostal,
                                                     Telephone = unAbonnement.Telephone,
                                                     Cellulaire = unAbonnement.Cellulaire,
                                                     Courriel = unAbonnement.Courriel,
                                                     NoTypeAbonnement = unTypeAbonnement.Description,
                                                     Remarque = unAbonnement.Remarque
                                                 };
        }

        private void btnAjoutAbonnement_Click(object sender, EventArgs e)
        {

            ChoixTypeAjoutAbonnement choixAjoutabonnement = new ChoixTypeAjoutAbonnement();
            this.Hide();
            choixAjoutabonnement.ShowDialog();
            this.Show();
            UpdateEtRefreshAbonnements();

        }
    }
}
