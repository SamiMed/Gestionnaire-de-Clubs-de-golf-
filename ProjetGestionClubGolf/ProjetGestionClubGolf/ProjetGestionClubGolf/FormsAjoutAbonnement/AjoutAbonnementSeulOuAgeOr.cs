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
    public partial class AjoutAbonnementSeulOuAgeOr : Form
    {
        private monDataContextDataContext monDataContext = new monDataContextDataContext();

        public bool booAbonnementAgeOr { get; set; } = false;

        public AjoutAbonnementSeulOuAgeOr()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            bool boolcell = false;
            bool booValide = true;
            DateTime dateNaissance = dtpDateNaissance.Value.Date;
            int age = 0;
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
                if (booAbonnementAgeOr && age < 60)
                {
                    booValide = false;
                    errMessage.SetError(dtpDateNaissance, "L'abonner doit être agé de 60 ans et plus");
                }
                else if (!booAbonnementAgeOr && age < 18)
                {
                    booValide = false;
                    errMessage.SetError(dtpDateNaissance, "L'abonner doit avoir entre 18 et 59 ans");
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
                if (AjoutAbonnement(age, boolcell))
                {
                    DialogResult result = MessageBox.Show("Abonnement ajouter!", "Ajout d'un abonnement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(result == DialogResult.OK)
                        this.Close();
                }
            }
        }


        private bool AjoutAbonnement(int intAge, bool booCell)
        {
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
            int noTypeAbonnement = booAbonnementAgeOr ? 1 : 2;
            string province = cboProvince.SelectedValue.ToString();
            string remarque = txtRemarque.Text;

            var pourIdAbonnement = from unAbonnement in monDataContext.Abonnements
                                 //  where unAbonnement.Nom == nom
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

            int age = intAge;

            try
            {
                monDataContext.Connection.Open();
                monDataContext.Transaction = monDataContext.Connection.BeginTransaction();
                Abonnement oknouv = new Abonnement()
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
                monDataContext.Abonnements.InsertOnSubmit(oknouv);
                monDataContext.SubmitChanges();
                monDataContext.Transaction.Commit();
                monDataContext.Connection.Close();
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
        }

        private void AjoutAbonnementSeulOuAgeOr_Load(object sender, EventArgs e)
        {
            AjoutListComboBoxSexe();

            provinceBindingSource.DataSource = from uneProvince in monDataContext.Provinces
                                               select uneProvince;

            cboProvince.DisplayMember = "Nom";
            cboProvince.ValueMember = "Id";

            lblAjoutAbonnnement.Text = booAbonnementAgeOr ? "Ajouter un abonnement age or" : "Ajouter un abonnement personne seul";

        }

        private void btnAnnuller_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ajout abonnement annuler!", "Anulation d'un ajout d'abonnement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
                this.Close();
        }
    }
}
