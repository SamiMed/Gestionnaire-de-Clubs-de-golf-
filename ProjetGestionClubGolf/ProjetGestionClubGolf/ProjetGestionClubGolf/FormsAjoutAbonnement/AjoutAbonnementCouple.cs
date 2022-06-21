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

namespace ProjetGestionClubGolf.FormsAjoutAbonnement
{
    public partial class AjoutAbonnementCouple : Form
    {
        private monDataContextDataContext monDataContext = new monDataContextDataContext();

        public AjoutAbonnementCouple()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

            bool boolcell = false;
            bool booValide = true;
            DateTime dateNaissance = dtpDateNaissance.Value.Date;
            DateTime dateNaissanceConjoint= dtpDateNaissance.Value.Date;

            int age = 0;
            int ageConjoint = 0;
            errMessage.SetError(txtNom, string.Empty);
            errMessage.SetError(txtPrenom, string.Empty);
            errMessage.SetError(txtRue, string.Empty);
            errMessage.SetError(txtVille, string.Empty);
            errMessage.SetError(txtCodePostal, string.Empty);
            errMessage.SetError(txtTelephone, string.Empty);
            errMessage.SetError(txtCourriel, string.Empty);
            errMessage.SetError(txtNoCivique, string.Empty);
            errMessage.SetError(txtCell, string.Empty);
            errMessage.SetError(dtpDateNaissance, string.Empty);

            errMessage.SetError(txtNomConjoint, string.Empty);
            errMessage.SetError(txtPrenomConjoint, string.Empty);
            errMessage.SetError(dtpDateNaissanceConjoint, string.Empty);

            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                booValide = false;
                errMessage.SetError(txtNom, "Le nom ne peut être vide");
            }
            if (string.IsNullOrWhiteSpace(txtPrenom.Text))
            {
                booValide = false;
                errMessage.SetError(txtPrenom, "Le prénom ne peut être vide");
            }
            if (string.IsNullOrWhiteSpace(txtNomConjoint.Text))
            {
                booValide = false;
                errMessage.SetError(txtNomConjoint, "Le nom du conjoint ne peut être vide");
            }
            if (string.IsNullOrWhiteSpace(txtPrenomConjoint.Text))
            {
                booValide = false;
                errMessage.SetError(txtPrenomConjoint, "Le prénom du conjoint ne peut être vide");
            }
            if (string.IsNullOrWhiteSpace(txtRue.Text))
            {
                booValide = false;
                errMessage.SetError(txtRue, "La rue ne peut être vide");
            }
            if (string.IsNullOrWhiteSpace(txtVille.Text))
            {
                booValide = false;
                errMessage.SetError(txtVille, "La ville ne peut être vide");
            }
            if (string.IsNullOrWhiteSpace(txtCodePostal.Text))
            {
                booValide = false;
                errMessage.SetError(txtCodePostal, "Le codepostal ne peut être vide");
            }
            if (string.IsNullOrWhiteSpace(txtTelephone.Text))
            {
                booValide = false;
                errMessage.SetError(txtTelephone, "Le téléphone ne peut être vide");
            }
            if (string.IsNullOrWhiteSpace(txtCourriel.Text))
            {
                booValide = false;
                errMessage.SetError(txtCourriel, "Le courriel ne peut être vide");

            }
            if (string.IsNullOrWhiteSpace(txtNoCivique.Text))
            {
                booValide = false;
                errMessage.SetError(txtNoCivique, "Le numéro civique ne peut être vide");

            }
            if (dtpDateNaissance.Value == null)
            {
                booValide = false;
                errMessage.SetError(dtpDateNaissance, "SVP sélectionner une date");

            }
            else
            {
                age = DateTime.Now.Subtract(dateNaissance).Days;
                age = age / 365;
                if (age < 18)
                {
                    booValide = false;
                    errMessage.SetError(dtpDateNaissance, "L'abonner doit avoir plus de 18 ans");
                }
            }
            if (dtpDateNaissanceConjoint.Value == null)
            {
                booValide = false;
                errMessage.SetError(dtpDateNaissanceConjoint, "SVP sélectionner une date");

            }
            else
            {
                ageConjoint = DateTime.Now.Subtract(dateNaissanceConjoint).Days;
                ageConjoint = ageConjoint / 365;
                if (ageConjoint < 18)
                {
                    booValide = false;
                    errMessage.SetError(dtpDateNaissanceConjoint, "Le conjoint doit avoir plus de 18 ans");
                }
            }
            if (!Regex.IsMatch(txtTelephone.Text, @"^\(\d{3}\)\d{3}\-\d{4}$"))
            {
                booValide = false;
                errMessage.SetError(txtTelephone, "Veuillez respecter le format (999)999-9999");
            }
            if (!string.IsNullOrWhiteSpace(txtCell.Text) && !Regex.IsMatch(txtCell.Text, @"^\(\d{3}\)\d{3}\-\d{4}$"))
            {
                booValide = false;
                boolcell = true;
                errMessage.SetError(txtCell, "Veuillez respecter le format (999)999-9999");
            }
            if (!Regex.IsMatch(txtNoCivique.Text, @"^\d{1,}$"))
            {
                booValide = false;
                errMessage.SetError(txtNoCivique, "SVP entrer un numéro");
            }
            if (booValide)
            {
                if (AjoutAbonnement(boolcell))
                {
                    DialogResult result = MessageBox.Show("Abonnement ajouter!", "Ajout d'un abonnement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                        this.Close();
                }
            }
        }

        private bool AjoutAbonnement(bool booCell)
        {
            string nomConjoint = txtNomConjoint.Text;
            string prenomConjoint = txtPrenomConjoint.Text;
            DateTime dateNaissanceConjoint = dtpDateNaissanceConjoint.Value.Date;
            string remarqueConjoint = txtRemarqueConjoint.Text;
            string sexeConjoint = cboSexeConjoint.SelectedValue.ToString();



            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            DateTime dateAbonnement = DateTime.Now;
            string sexe = cboSexe.SelectedValue.ToString();
            DateTime dateNaissance = dtpDateNaissance.Value.Date;
            int noCivil = Convert.ToInt32(txtNoCivique.Text);
            string rue = txtRue.Text;
            string ville = txtVille.Text;
            string codepostal = txtCodePostal.Text;
            string telephone = string.Concat(txtTelephone.Text.Substring(1, 3), txtTelephone.Text.Substring(5, 3), txtTelephone.Text.Substring(9, 4));
            string cellulaire = booCell
                                ? string.Concat(txtCell.Text.Substring(1, 3), txtCell.Text.Substring(5, 3), txtCell.Text.Substring(9, 4))
                                : string.Empty;
            string courriel = txtCourriel.Text;
            int noTypeAbonnement = 3;
            string province = cboProvince.SelectedValue.ToString();
            string remarque = txtRemarque.Text;

            var pourIdAbonnement = from unAbonnement in monDataContext.Abonnements
                                   select unAbonnement;

            int idAbonnementNum = int.MinValue;

            foreach (var valeur in pourIdAbonnement)
            {
                int ok = Convert.ToInt32(valeur.Id.Substring(valeur.Nom.Length, valeur.Id.Length - valeur.Nom.Length - 1));

                if (ok > idAbonnementNum)
                {
                    idAbonnementNum = ok;
                }
                Console.WriteLine(idAbonnementNum);
            }
            if (idAbonnementNum == int.MinValue)
            {
                idAbonnementNum = 0;
            }
            string leId = string.Concat(nom, idAbonnementNum + 1, "P");

            string leIdConjoint = string.Empty;
            if (sexeConjoint == "F")
                leIdConjoint = string.Concat(leId.Substring(0, leId.Length - 1), "F0");
            else if (sexeConjoint == "H")
                leIdConjoint = string.Concat(leId.Substring(0, leId.Length - 1), "H0");


            try
            {
                monDataContext.Connection.Open();
                monDataContext.Transaction = monDataContext.Connection.BeginTransaction();
                Abonnement nouvAbonnement = new Abonnement()
                {
                    Id = leId,
                    DateAbonnement = dateAbonnement,
                    Nom = nom,
                    Prenom = prenom,
                    Sexe = sexe,
                    DateNaissance = dateNaissance,
                    NoCivique = noCivil,
                    Rue = rue,
                    Ville = ville,
                    IdProvince = province,
                    CodePostal = codepostal,
                    Telephone = telephone,
                    Cellulaire = cellulaire,
                    Courriel = courriel,
                    NoTypeAbonnement = noTypeAbonnement,
                    Remarque = remarque

                };
                monDataContext.Abonnements.InsertOnSubmit(nouvAbonnement);

                Dependant nouvDependant = new Dependant()
                {
                    Id = leIdConjoint,
                    Nom = nomConjoint,
                    Prenom = prenomConjoint,
                    DateNaissance = dateNaissanceConjoint,
                    IdAbonnement = leId,
                    Remarque = remarqueConjoint,
                    Sexe = sexeConjoint
                };
                monDataContext.Dependants.InsertOnSubmit(nouvDependant);
 


                monDataContext.SubmitChanges();
                monDataContext.Transaction.Commit();
                monDataContext.Connection.Close();
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
                monDataContext.Transaction.Rollback();
                monDataContext.Connection.Close();
            }

            return false;
        }



        private void AjoutListComboBoxSexe()
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("H", "Homme");
            comboSource.Add("F", "Femme");
            cboSexe.DataSource = new BindingSource(comboSource, null);
            cboSexe.DisplayMember = "Value";
            cboSexe.ValueMember = "Key"; 
            cboSexeConjoint.DataSource = new BindingSource(comboSource, null);
            cboSexeConjoint.DisplayMember = "Value";
            cboSexeConjoint.ValueMember = "Key";
        }

        private void AjoutAbonnementCouple_Load(object sender, EventArgs e)
        {
            AjoutListComboBoxSexe();

            provinceBindingSource.DataSource = from uneProvince in monDataContext.Provinces
                                               select uneProvince;

            cboProvince.DisplayMember = "Nom";
            cboProvince.ValueMember = "Id";
        }

        private void btnAnnuller_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ajout abonnement annuler!", "Anulation d'un ajout d'abonnement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
                this.Close();
        }
    }
}
