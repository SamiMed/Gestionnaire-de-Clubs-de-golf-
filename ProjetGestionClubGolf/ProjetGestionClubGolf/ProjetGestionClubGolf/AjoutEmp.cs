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
    public partial class AjoutEmp : Form
    {
        public AjoutEmp()
        {
            InitializeComponent();
        }
        private void AjoutEmp_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            Dictionary<string, string> cboSourceProv = new Dictionary<string, string>();

            foreach (Province prov in dataContext.Provinces)
            {
                    cboSourceProv.Add(prov.Id, prov.Nom);
            }

            cboIdProvince.DataSource = new BindingSource(cboSourceProv, null);
            cboIdProvince.DisplayMember = "Value";
            cboIdProvince.ValueMember = "Key";

            Dictionary<int, string> cboSourceEmp = new Dictionary<int, string>();

            foreach (TypesEmploye type in dataContext.TypesEmployes)
            {
                if (type.No != 1)
                {
                    cboSourceEmp.Add(type.No, type.Description);
                }
            }

            cboTypeEmp.DataSource = new BindingSource(cboSourceEmp, null);
            cboTypeEmp.DisplayMember = "Value";
            cboTypeEmp.ValueMember = "Key";


            Dictionary<string, string> cboSourceSexe = new Dictionary<string, string>();
           
            cboSourceSexe.Add("H", "Homme");
            cboSourceSexe.Add("F", "Femme");

            ddlSexe.DataSource = new BindingSource(cboSourceSexe, null);
            ddlSexe.DisplayMember = "Value";
            ddlSexe.ValueMember = "Key";
        }

        monDataContextDataContext dataContext = new monDataContextDataContext();
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int noCiv;

            String strCodePostal = "^(?!.*[DFIOQU])[A-VXY][0-9][A-Z] ?[0-9][A-Z][0-9]$";
            Regex rgCodePostal = new Regex(strCodePostal);

            String strTelephone = "^\\(\\d{3}\\)\\s\\d{3}-\\d{4}";
            Regex rgTelephone = new Regex(strTelephone);

            msgErreur.Clear();
            if (tbMotDePasse.Text.ToString() == "" || tbMotDePasse.Text.ToString() == null)
            {
                msgErreur.SetError(tbMotDePasse, "Veuillez entrer un mot de passe");
            } else if (tbNom.Text.ToString() == "" || tbNom.Text.ToString() == null)
            {
                msgErreur.SetError(tbNom, "Veuillez entrer un nom");
            } else if (tbPrenom.Text.ToString() == "" || tbPrenom.Text.ToString() == null)
            {
                msgErreur.SetError(tbPrenom, "Veuillez entrer un prénom");
            } else if (ddlSexe.SelectedIndex == -1)
            {
                msgErreur.SetError(ddlSexe, "Veuillez sélectionner un sexe");
            } else if (!int.TryParse(tbNoCivique.Text.ToString(), out noCiv) || tbNoCivique.Text.ToString() == "" || tbNoCivique.Text.ToString() == null)
            {
                msgErreur.SetError(tbNoCivique, "Veuillez entrer un numéro civique");
            } else if (tbRue.Text.ToString() == "" || tbRue.Text.ToString() == null)
            {
                msgErreur.SetError(tbRue, "Veuillez entrer une rue");

            } else if (tbVille.Text.ToString() == "" || tbVille.Text.ToString() == null)
            {
                msgErreur.SetError(tbVille, "Veuillez entrer une ville");
            } else if (cboIdProvince.SelectedIndex == -1)
            {
                msgErreur.SetError(cboIdProvince, "Veuillez entrer un id de province");
            } else if (!rgCodePostal.IsMatch(mtbCodePostal.Text.ToString()) || mtbCodePostal.Text.ToString() == "" || mtbCodePostal.Text.ToString() == null)
            {
                msgErreur.SetError(mtbCodePostal, "Veuillez entrer un code postal valide");
            } else if (!rgTelephone.IsMatch(mtbTelephone.Text.ToString()) || mtbTelephone.Text.ToString() == "" || mtbTelephone.Text.ToString() == null)
            {
                msgErreur.SetError(mtbTelephone, "Veuillez entrer un numéro de téléphone valide");
            } else if (!rgTelephone.IsMatch(mtbCellulaire.Text.ToString()) || mtbCellulaire.Text.ToString() == "" || mtbCellulaire.Text.ToString() == null)
            {
                msgErreur.SetError(mtbCellulaire, "Veuillez entrer un numéro de cellulaire valide");
            } else
            {

                int noEmp = int.MinValue;
                foreach (Employe emp in dataContext.Employes)
                {
                    if (noEmp < emp.No)
                    {
                        noEmp = emp.No;
                    }
                }
                noEmp++;

                //Okay//
                Employe newEmp = new Employe
                {
                    No = noEmp,
                    MotDePasse = tbMotDePasse.Text.ToString(),
                    Nom = tbNom.Text.ToString(),
                    Prenom = tbPrenom.Text.ToString(),
                    Sexe = ((KeyValuePair<string, string>)ddlSexe.SelectedItem).Key,
                    Age = int.Parse(numAge.Value.ToString()),
                    NoCivique = int.Parse(tbNoCivique.Text),
                    Rue = tbRue.Text,
                    Ville = tbVille.Text,
                    IdProvince = ((KeyValuePair<string, string>)cboIdProvince.SelectedItem).Key,
                    CodePostal = mtbCodePostal.Text.ToString().Trim().Replace(" ", ""),
                    Telephone = mtbTelephone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""),
                    Cellulaire = mtbCellulaire.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""),
                    Courriel = tbCouriel.Text.ToString(),
                    SalaireHoraire = numSalaire.Value,
                    NoTypeEmploye = ((KeyValuePair<int, string>)cboTypeEmp.SelectedItem).Key,//Important//
                    Remarque = tbRemarque.Text
                };

                dataContext.Employes.InsertOnSubmit(newEmp);
                dataContext.SubmitChanges();

                this.Close();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
