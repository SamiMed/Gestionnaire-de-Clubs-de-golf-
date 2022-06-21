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
    public partial class GestionEmp : Form
    {
        int numEmp;
        string pwd;
        Employe empCourrant = null;
        public GestionEmp(int numEmp, string pwd)
        {
            InitializeComponent();
            this.numEmp = numEmp;
            this.pwd = pwd;
        }

        monDataContextDataContext dataContext = new monDataContextDataContext();
        private void GestionEmp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56Projet22DataSet.Employes' table. You can move, or remove it, as needed.
            this.employesTableAdapter.Fill(this.bDB56Projet22DataSet.Employes);
            this.CenterToScreen();

            foreach (Employe emp in dataContext.Employes)
            {
                if (emp.No == this.numEmp && emp.MotDePasse == this.pwd)
                {
                    this.empCourrant = emp;
                    break;
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            AjoutEmp ajoutEmp = new AjoutEmp();
            this.Hide();
            ajoutEmp.ShowDialog();
            this.Show();
            refresh();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            ModifEmp modifEmp = new ModifEmp(getEmpSelect());
            this.Hide();
            modifEmp.ShowDialog();
            this.Show();
            refresh();
        }

        private void btnSuprimmer_Click(object sender, EventArgs e)
        {
            if (dgEmployes.SelectedRows.Count != 0)
            {

                Boolean booSupp = true;

                Employe empSelect = getEmpSelect();

                if (empSelect.No == 1 && booSupp)
                {
                    //Non parce que administrateur//
                    booSupp = false;
                    MessageBox.Show("Impossible de supprimer un administrateur.", "Suppression impossible.");
                }

                //Ici check si current//
                if (empSelect == this.empCourrant && booSupp)
                {
                    booSupp = false;
                    MessageBox.Show("Impossible de supprimer l'utilisateur courant.", "Suppression impossible.");
                }

                //Ici check si a services//
                foreach (Service s in dataContext.Services)
                {
                    if (s.NoEmploye == empSelect.No && booSupp)
                    {
                        booSupp = false;
                        MessageBox.Show("Impossible de supprimer un employé donnant des services.", "Suppression impossible.");
                        break;
                    }
                }

                if (booSupp)
                {
                    dataContext.Employes.DeleteOnSubmit(empSelect);
                    dataContext.SubmitChanges();
                    refresh();
                }                
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void refresh()
        {
            employesBindingSource.DataSource =
            from unEmploye in dataContext.Employes
            select unEmploye;
        }

        private Employe getEmpSelect()
        {
            Employe empTemp = null;
            foreach (Employe emp in dataContext.Employes)
            {
                if (emp.No.ToString() == dgEmployes.SelectedRows[0].Cells[0].Value.ToString() && emp.MotDePasse == dgEmployes.SelectedRows[0].Cells[1].Value.ToString())
                {
                    empTemp = emp;
                    break;
                }
            }
            return empTemp;
        }
    }
}
