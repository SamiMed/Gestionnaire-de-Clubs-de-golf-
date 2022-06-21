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
    public partial class ModifEmp : Form
    {
        Employe empCourant;
        public ModifEmp(Employe empCourant)
        {
            InitializeComponent();
            this.empCourant = empCourant;
        }

        private void ModifEmp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56Projet22DataSet.Provinces' table. You can move, or remove it, as needed.
            this.provincesTableAdapter.Fill(this.bDB56Projet22DataSet.Provinces);
            this.CenterToScreen();

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

            tbMotDePasse.Text = empCourant.MotDePasse;
            tbNom.Text = empCourant.Nom;
            tbPrenom.Text = empCourant.Prenom;
            ddlSexe.SelectedValue = empCourant.Sexe;
            numAge.Value = empCourant.Age;
            tbNoCivique.Text = empCourant.NoCivique.ToString();
            tbRue.Text = empCourant.Rue;
            tbVille.Text = empCourant.Ville;
            cboIdProvince.SelectedValue = empCourant.IdProvince;
            mtbCodePostal.Text = empCourant.CodePostal;
            mtbTelephone.Text = empCourant.Telephone;
            mtbCellulaire.Text = empCourant.Cellulaire;
            tbCouriel.Text = empCourant.Courriel;
            numSalaire.Value = empCourant.SalaireHoraire;
            cboTypeEmp.SelectedValue = empCourant.NoTypeEmploye;
            tbRemarque.Text = empCourant.Remarque;

            if (empCourant.NoTypeEmploye == 1)
            {
                cboTypeEmp.Enabled = false;
                cboTypeEmp.Text = "Administrateur";
            } else
            {
                cboTypeEmp.Enabled = true;
            }

        }

        monDataContextDataContext dataContext = new monDataContextDataContext();

        private void btnModifier_Click(object sender, EventArgs e)
        {
            empCourant.MotDePasse = tbMotDePasse.Text.ToString();
            empCourant.Nom = tbNom.Text.ToString();
            empCourant.Prenom = tbPrenom.Text.ToString();
            empCourant.Sexe = ((KeyValuePair<string, string>)ddlSexe.SelectedItem).Key;
            empCourant.Age = int.Parse(numAge.Value.ToString());
            empCourant.NoCivique = int.Parse(tbNoCivique.Text);
            empCourant.Rue = tbRue.Text;
            empCourant.Ville = tbVille.Text;
            empCourant.IdProvince = cboIdProvince.SelectedValue.ToString();
            empCourant.CodePostal = mtbCodePostal.Text.ToString().Trim().Replace(" ", "");
            empCourant.Telephone = mtbTelephone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            empCourant.Cellulaire = mtbCellulaire.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            empCourant.Courriel = tbCouriel.Text.ToString();
            empCourant.SalaireHoraire = numSalaire.Value;
            if (empCourant.NoTypeEmploye != 1) {
                empCourant.NoTypeEmploye = ((KeyValuePair<int, string>)cboTypeEmp.SelectedItem).Key;//Important//
            }
            empCourant.Remarque = tbRemarque.Text;

            dataContext.SubmitChanges();
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
