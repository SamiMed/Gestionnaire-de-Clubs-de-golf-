using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.Linq;

namespace ProjetGestionClubGolf
{
    public partial class PartieGolfJouer : Form
    {
        monDataContextDataContext monDataContext = new monDataContextDataContext();

        public PartieGolfJouer()
        {
            InitializeComponent();
        }


        private void PartieGolfJouer_Load(object sender, EventArgs e)
        {
            var terrain = from unTerrain in monDataContext.Terrains
                          select unTerrain.Nom;

            foreach (var unTerrain in terrain)
            {
                cbTerrain.Items.Add(unTerrain);
            }

            var abonnePrincipal = from unAbonne in monDataContext.Abonnements
                                  select new { id = unAbonne.Id, nom = unAbonne.Nom, prenom = unAbonne.Prenom };

            foreach (var unAbonne in abonnePrincipal)
            {

                cbAbonnePrincipal.Items.Add("(" + unAbonne.id + ")" + " " + unAbonne.nom + ", " + unAbonne.prenom);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            bool booExisteDeja = false;

            if (cbAbonnePrincipal.SelectedItem == null)
            {
                errorMessage.SetError(cbAbonnePrincipal, "Veuillez choisir un l'abonné principal");
            }
            else if (cbTerrain.SelectedItem == null)
            {
                errorMessage.SetError(cbAbonnePrincipal, "");
                errorMessage.SetError(cbTerrain, "Veuillez choisir un terrain");

            }
            else if (numPointage.Value == 0)
            {
                errorMessage.SetError(cbTerrain, "");
                errorMessage.SetError(numPointage, "Veuille entrer un pointage supérieur à 0");
            }

            else
            {
                errorMessage.SetError(cbAbonnePrincipal, "");
                errorMessage.SetError(cbTerrain, "");
                errorMessage.SetError(numPointage, "");

                var idAbonee = Regex.Match(cbAbonnePrincipal.SelectedItem.ToString(), @"\(([^)]*)\)").Groups[1].Value;
                var nomTerrain = cbTerrain.SelectedItem.ToString();

                var reabonnement = from unReabonnement in monDataContext.Reabonnements
                                   join unAbonne in monDataContext.Abonnements
                                   on unReabonnement.IdAbonnement equals unAbonne.Id
                                   where unReabonnement.IdAbonnement == idAbonee
                                   select unReabonnement.DateRenouvellement;


                foreach (var unRea in reabonnement)
                {
                    MessageBox.Show(unRea.ToString());

                    if (DateTime.Parse(unRea.ToString("yyyy-MM-dd")) <= DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")) && DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")) <= DateTime.Parse(unRea.AddYears(1).ToString("yyyy-MM-dd")))
                    {
                        MessageBox.Show("Une partie de golf ne peut pas être inscrite si l’abonné principal est désabonné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var noTerrain = from unTerrain in monDataContext.Terrains
                                        where nomTerrain == unTerrain.Nom
                                        select unTerrain;

                        foreach (var test in noTerrain)
                        {
                            var test2 = from unePartieJouer in monDataContext.PartiesJouees
                                        where unePartieJouer.IdAbonnement == idAbonee && unePartieJouer.NoTerrain == test.No && unePartieJouer.DatePartie == DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"))
                                        select false;

                            foreach (var test3 in test2)
                            {
                                if (test3 == false)
                                {
                                    booExisteDeja = true;
                                    MessageBox.Show("Il existe déjà une partie jouée pour ce terrain.\n Veuillez choisir un autre terrain.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);            
                                }
                            }

                            if (booExisteDeja == false)
                            {

                                DateTime date = new DateTime();
                                date = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));

                                PartiesJouee partiesJouee = new PartiesJouee
                                {  
                                    IdAbonnement = idAbonee,
                                    NoTerrain = test.No,
                                    DatePartie = date,
                                    Pointage = Convert.ToInt32(numPointage.Value),
                                    Remarque = tbRemarque.Text
                                };

                                monDataContext.PartiesJouees.InsertOnSubmit(partiesJouee);
                                monDataContext.SubmitChanges();
                                MessageBox.Show("L'inscription de la partie de golf a été faite avec succès !");
                                this.Close();
                            }
                        }
                    }
                }
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
