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

namespace ProjetGestionClubGolf
{
    public partial class Rapports : Form
    {
        monDataContextDataContext monDataContext = new monDataContextDataContext();

        public Rapports()
        {
            InitializeComponent();
        }

        private void Rapports_Load(object sender, EventArgs e)
        {
            var distinctItems = monDataContext.PartiesJouees.GroupBy(i => i.DatePartie.Year).Select(g => g.First()).ToList();

            foreach (var annee in distinctItems)
            {
                cbAnnees.Items.Add(annee.DatePartie.Year);

            }

            var abonneePrincipal = monDataContext.Abonnements.GroupBy(i => i.Nom + i.Prenom).Select(g => g.First()).ToList();

            foreach (var unAbonnee in abonneePrincipal)
            {
                string nomComplet = unAbonnee.Nom + ' ' +  unAbonnee.Prenom;

                cbAbonnePrincipal.Items.Add(nomComplet);
            }

            Dictionary<int, string> cboSourceTerrain = new Dictionary<int, string>();

            cboSourceTerrain.Add(0, "");

            foreach (Terrain terrain in monDataContext.Terrains)
            {
                    cboSourceTerrain.Add(terrain.No, terrain.Nom);
            }

            cboTerrain.DataSource = new BindingSource(cboSourceTerrain, null);
            cboTerrain.DisplayMember = "Value";
            cboTerrain.ValueMember = "Key";

            Dictionary<int, string> cboSourceEmployes = new Dictionary<int, string>();

            cboSourceEmployes.Add(0, "");

            foreach (Employe emp in monDataContext.Employes)
            {
                string strValue = emp.Prenom + " " + emp.Nom;
                cboSourceEmployes.Add(emp.No, strValue);
            }

            cboEmployes.DataSource = new BindingSource(cboSourceEmployes, null);
            cboEmployes.DisplayMember = "Value";
            cboEmployes.ValueMember = "Key";
        

            var distinctItemsDepensesParAnnee = monDataContext.Depenses.GroupBy(i => i.DateDepense.Year).Select(g => g.First()).ToList();

            foreach (var annee in distinctItemsDepensesParAnnee)
            {
                cbAnneesDepensesParAnnee.Items.Add(annee.DateDepense.Year);

            }

            var distinctcboRapportChose = monDataContext.Abonnements.GroupBy(i => i.Nom + i.Prenom).Select(g => g.First()).ToList();

            foreach (var annee in distinctcboRapportChose)
            {
                string nomComplet = annee.Nom + ' ' + annee.Prenom;

                cbAbonnerPartieJouer.Items.Add(nomComplet);

            }
        }

        private void cbAnnees_SelectedValueChanged(object sender, EventArgs e)
        {
 
            var informationPartie =
               from unePartie in monDataContext.PartiesJouees
               join unAbonne in monDataContext.Abonnements on unePartie.IdAbonnement equals unAbonne.Id
               join unTerrain in monDataContext.Terrains on unePartie.NoTerrain equals unTerrain.No
               where cbAnnees.SelectedItem.ToString() == unePartie.DatePartie.Year.ToString()
               orderby unePartie.DatePartie
               select new { DatePartie = unePartie.DatePartie, NomAbonne = unAbonne.Nom, NomTerrain = unTerrain.Nom, Pointage = unePartie.Pointage };

            dgPartieJouer.DataSource = informationPartie.ToList();
        }

        private void cbAbonnePrincipal_SelectedValueChanged(object sender, EventArgs e)
        {

            var chercherIdAvecNomComplet = from unAbonnement in monDataContext.Abonnements
                                           let nomComplet = unAbonnement.Nom + " " + unAbonnement.Prenom
                                           where nomComplet == cbAbonnePrincipal.SelectedItem.ToString()
                                           select new { unAbonnement };
            var valeur = "";

            foreach(var test in chercherIdAvecNomComplet)
            {
                valeur = test.unAbonnement.Id;
            }



            var depenseAb = from unAbonnement in monDataContext.Abonnements
                                           join uneDepense in monDataContext.Depenses on unAbonnement.Id equals uneDepense.IdAbonnement
                                           join unService in monDataContext.Services on uneDepense.NoService equals unService.No
                                           join unEmploye in monDataContext.Employes on unService.NoEmploye equals unEmploye.No
                                           where valeur ==  uneDepense.IdAbonnement
                                           select new 
                                           { 
                                            Montant = string.Format("{0:0.00}", uneDepense.Montant), 
                                            dateDepense = uneDepense.DateDepense, 
                                            typeService = unService.TypeService,
                                            NomEmploye = unEmploye.Nom + " " +  unEmploye.Prenom
                                           };

            dgDepenseParAbonnement.DataSource = depenseAb.ToList();

        }

        private void cbAnneesDepensesParAnnee_SelectedValueChanged(object sender, EventArgs e)
        {
            var informationPartie =
             from uneDepense in monDataContext.Depenses
             join unAbonne in monDataContext.Abonnements on uneDepense.IdAbonnement equals unAbonne.Id
             join unService in monDataContext.Services on uneDepense.NoService equals unService.No
             join unEmploye in monDataContext.Employes on unService.NoEmploye equals unEmploye.No
             where cbAnneesDepensesParAnnee.SelectedItem.ToString() == uneDepense.DateDepense.Year.ToString()
             orderby uneDepense.DateDepense
             select new
             {
                 Nom_De_Le_Abonner = string.Concat(unAbonne.Prenom, " ", unAbonne.Nom)
                         ,
                 Montant = uneDepense.Montant
                         ,
                 Date_Depense = uneDepense.DateDepense
                         ,
                 Type_de_service_rendu = unService.TypeService
                         ,
                 Nom_De_Le_employe = string.Concat(unEmploye.Prenom, " ", unEmploye.Nom)
             };


            dgDepensesParAnnee.DataSource = informationPartie.ToList();
        }

        private void cboTerrain_SelectedValueChanged(object sender, EventArgs e)
        {
            var informationParties =
              from unePartie in monDataContext.PartiesJouees
              join unAbonne in monDataContext.Abonnements on unePartie.IdAbonnement equals unAbonne.Id
              join unTerrain in monDataContext.Terrains on unePartie.NoTerrain equals unTerrain.No
              where ((KeyValuePair<int, string>)cboTerrain.SelectedItem).Key == unePartie.NoTerrain
              orderby unePartie.DatePartie
              select new { DatePartie = unePartie.DatePartie, NomAbonne = unAbonne.Nom, Pointage = unePartie.Pointage };

            dgPartiesParTerrains.DataSource = informationParties.ToList();
        }

        private void cboEmployes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var informationDepenses =
                from unAbonne in monDataContext.Abonnements
                join uneDepense in monDataContext.Depenses on unAbonne.Id equals uneDepense.IdAbonnement
                join unService in monDataContext.Services on uneDepense.NoService equals unService.No
                join unEmploye in monDataContext.Employes on unService.NoEmploye equals unEmploye.No
                where ((KeyValuePair<int, string>)cboEmployes.SelectedItem).Key == unEmploye.No
                orderby unEmploye.Nom, unEmploye.Prenom
                select new { TypeService = unService.TypeService, Montant = uneDepense.Montant, DateDepense = uneDepense.DateDepense, NomCompletAbonne = unAbonne.Prenom + " " + unAbonne.Nom };

            dgDepensesParEmploye.DataSource = informationDepenses.ToList();
        }

        private void cbAbonnerPartieJouer_SelectedValueChanged(object sender, EventArgs e)
        {
            var chercherIdAvecNomComplet = from unAbonnement in monDataContext.Abonnements
                                           let nomComplet = unAbonnement.Nom + " " + unAbonnement.Prenom
                                           where nomComplet == cbAbonnerPartieJouer.SelectedItem.ToString()
                                           select new { unAbonnement };
            var valeur = "";

            foreach (var test in chercherIdAvecNomComplet)
            {
                valeur = test.unAbonnement.Id;
            }

            var informationPartie =
             from uneDepense in monDataContext.PartiesJouees
             join unAbonne in monDataContext.Abonnements on uneDepense.IdAbonnement equals unAbonne.Id
             join unTerrain in monDataContext.Terrains on uneDepense.NoTerrain equals unTerrain.No
             where uneDepense.IdAbonnement == valeur
             select new
             {
                 Date_De_La_Partie = uneDepense.DatePartie
                         ,
                 Nom_Terrain = unTerrain.Nom
                         ,
                 Pointage = uneDepense.Pointage
             };


            dgpartieJouerParAbonnement.DataSource = informationPartie.ToList();
        }
    }
}
