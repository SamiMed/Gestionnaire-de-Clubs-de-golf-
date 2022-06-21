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
    public partial class FrmReabonnements : Form
    {
        monDataContextDataContext monDataContext = new monDataContextDataContext();
        public FrmReabonnements()
        {
            InitializeComponent();
        }

        private void FrmReabonnements_Load(object sender, EventArgs e)
        {
       abonnementBindingSource.DataSource = from unAbonnement in monDataContext.Abonnements
                                            join unReabonnement in monDataContext.Reabonnements
                                            on unAbonnement.Id  equals unReabonnement.IdAbonnement
                                            where DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")) < unAbonnement.DateAbonnement.AddYears(1)
                                            || DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")) < unReabonnement.DateRenouvellement.AddYears(1)
                                            select unAbonnement;
        }

        private void btnReabonner_Click(object sender, EventArgs e)
        {
            string id = dgAbonnement.CurrentRow.Cells[0].Value.ToString();
            bool valide = false;
            DateTime date = new DateTime();
            date = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));

            // l'année actuelle == l'année renouvellement dans la table réabonnement

            var verifieAnnee = from unReabonnement in monDataContext.Reabonnements
                               where unReabonnement.IdAbonnement == id && unReabonnement.DateRenouvellement.Year == DateTime.Now.Year
                               select false;


            foreach (var uneAnnee in verifieAnnee)
            {
                if (uneAnnee == false)
                {
                    valide = true;
                    MessageBox.Show("On ne peut renouveler un abonnement deux fois la même année.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (valide == false)
            {
                FormReabonnement formReabonnement = new FormReabonnement
                {
                    IdAbonnement = id,
                    DateRenouvellement = date,
                    Remarque = tbRemarque.Text
                };

                monDataContext.Reabonnements.InsertOnSubmit(formReabonnement);
                monDataContext.SubmitChanges();
                MessageBox.Show("Le réabonnement a été fait avec succès", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
