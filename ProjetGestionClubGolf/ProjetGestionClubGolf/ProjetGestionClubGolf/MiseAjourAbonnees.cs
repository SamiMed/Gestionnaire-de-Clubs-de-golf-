using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestionClubGolf
{
    public partial class MiseAjourAbonnees : Form
    {
        monDataContextDataContext monDataContext = new monDataContextDataContext();
        public MiseAjourAbonnees()
        {
            InitializeComponent();

            abonnementBindingSource.DataSource =
                from unAbonnement in monDataContext.Abonnements
                select unAbonnement;
        }

        private void abonnementBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (abonnementDataGridView.CurrentRow != null)
            {

                string id = abonnementDataGridView.CurrentRow.Cells[0].Value.ToString();

                dependantBindingSource.DataSource =
                   from unDependant in monDataContext.Dependants
                   where unDependant.IdAbonnement == id
                   select unDependant;
            }
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            abonnementBindingSource.EndEdit();
            dependantBindingSource.EndEdit();

            try
            {

                monDataContext.SubmitChanges(ConflictMode.ContinueOnConflict);
                MessageBox.Show("Les modifications ont été sauvegardées avec succès  !");
                this.Close();
            }
            catch (ChangeConflictException)
            {
                monDataContext.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
            }
        }
    }
}
