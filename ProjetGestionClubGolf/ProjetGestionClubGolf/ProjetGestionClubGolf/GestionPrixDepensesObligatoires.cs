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
    public partial class GestionPrixDepensesObligatoires : Form
    {
        private monDataContextDataContext monDataContext = new monDataContextDataContext();

        private List<PrixDepensesAbonnement> listSansModif;

      //  private Dictionary<DateTime, int> testModifierStuff = new Dictionary<DateTime, int>();
        private List<int> testModifierStuff = new List<int>();

        public GestionPrixDepensesObligatoires()
        {
            InitializeComponent();
        }

        private void GestionPrixDepensesObligatoires_Load(object sender, EventArgs e)
        {
            #region comments
            /* new
                                         {
                                             NoTypeAbonnement = unTypeAbonnement.No,
                                             Description = unTypeAbonnement.Description,
                                             Prix = unPrixDepenses.Prix,
                                             DepensesObligatoires = unPrixDepenses.DepensesObligatoires
                                         }*/

            // SmartxBillingSystemDataContext dc = new SmartxBillingSystemDataContext();
            //var info_a_afficher = from unTypeAbonnement in monDataContext.TypesAbonnements
            //                      join unPrixDepenses in monDataContext.PrixDepensesAbonnements
            //                      on unTypeAbonnement.No equals unPrixDepenses.NoTypeAbonnement
            //                      select new ModificationPrixDepenses()
            //                      {
            //                          NoTypeAbonnement = unTypeAbonnement.No,
            //                          Description = unTypeAbonnement.Description,
            //                          Prix = unPrixDepenses.Prix,
            //                          DepensesObligatoires = unPrixDepenses.DepensesObligatoires
            //                      };
            //dgGestionPrixDepenses.AutoGenerateColumns = false;
            //dgGestionPrixDepenses.Columns.Add("NoTypeAbonnement", "NoTypeAbonnement");
            //dgGestionPrixDepenses.Columns.Add("Description", "Description");
            //dgGestionPrixDepenses.Columns.Add("Prix", "Prix");
            //dgGestionPrixDepenses.Columns.Add("DepensesObligatoires", "DepensesObligatoires");

            //dgGestionPrixDepenses.Columns["NoTypeAbonnement"].DataPropertyName = "NoTypeAbonnement";
            //dgGestionPrixDepenses.Columns["Description"].DataPropertyName = "Description";
            //dgGestionPrixDepenses.Columns["Prix"].DataPropertyName = "Prix";
            //dgGestionPrixDepenses.Columns["DepensesObligatoires"].DataPropertyName = "DepensesObligatoires";

            //bindingSource1.DataSource = info_a_afficher.ToList();


            //testTableBindingSource.DataSource = from okok in monDataContext.testTables
            //            select new
            //            {
            //                No = okok.No,
            //                Description = okok.Description,
            //                //DepensesObligatoires = okok.DepensesObligatoires,
            //                //Prix = okok.Prix,
            //                //Annee = okok.Annee
            //            };


            //comboSource.Add("H", "Homme");
            //comboSource.Add("F", "Femme");
            //cboSexe.DataSource = new BindingSource(comboSource, null);
            //cboSexe.DisplayMember = "Value";
            //cboSexe.ValueMember = "Key";
            //var info_a_afficher = from unTypeAbonnement in monDataContext.TypesAbonnements
            //                             join unPrixDepenses in monDataContext.PrixDepensesAbonnements
            //                             on unTypeAbonnement.No equals unPrixDepenses.NoTypeAbonnement
            //                             let No = unTypeAbonnement.No
            //                             let Description = unTypeAbonnement.Description
            //                             let Prix = unPrixDepenses.Prix
            //                             let DepensesObligatoires = unPrixDepenses.DepensesObligatoires
            //                             select new { No };
            //var info_a_afficher = from unTypeAbonnement in monDataContext.TypesAbonnements
            //                      join unPrixDepenses in monDataContext.PrixDepensesAbonnements
            //                      on unTypeAbonnement.No equals unPrixDepenses.NoTypeAbonnement
            //                      select new { No = unTypeAbonnement.No, Description = unTypeAbonnement.Description, Prix = unPrixDepenses.Prix, DepensesObligatoires = unPrixDepenses.DepensesObligatoires };
            ////DataTable ok = new DataTable();
            // info_a_afficher.ReadOnly = false;
            //  bindingSource1.AllowNew = true;
            //  bindingSource1.AllowRemove = true;
            //bindingSource1.AllowEdit = true;

            //bindingSource1.DataSource = info_a_afficher.ToList();
            //dgGestionPrixDepenses.DataSource = bindingSource1;
            ////  dgGestionPrixDepenses.EditMode = DataGridViewEditMode.EditOnEnter;
            //foreach (DataGridViewRow row in dgGestionPrixDepenses.Rows)
            //{
            //    row.Cells[1].ReadOnly = false;
            //    //row.Cells[1].ed
            //}
            //       dgGestionPrixDepenses.Columns[1].ReadOnly = false;
            //  dgGestionPrixDepenses.Columns[0].ReadOnly = true; dgGestionPrixDepenses.Columns[1].ReadOnly = false;
            //  dgGestionPrixDepenses.Columns("No")

            //dgGestionPrixDepenses.DataBindingComplete();

            //  bindingSource1.DataSource = info_a_afficher;
            #endregion
            listSansModif = new List<PrixDepensesAbonnement>();
            listSansModif = (from ok in monDataContext.PrixDepensesAbonnements
                             select ok).ToList();

            typesAbonnementBindingSource.DataSource = from ok in monDataContext.TypesAbonnements
                                                      select ok;
            prixDepensesAbonnementBindingSource.DataSource = from ok in monDataContext.PrixDepensesAbonnements
                                                             select ok;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgGestionPrixDepenses.EndEdit();
            dgTypeAbonnement.EndEdit();
            monDataContext.Connection.Open();
            monDataContext.Transaction = monDataContext.Connection.BeginTransaction();
            monDataContext.PrixDepensesAbonnements.DeleteAllOnSubmit(monDataContext.PrixDepensesAbonnements);
            
            foreach (DataGridViewRow okok in dgGestionPrixDepenses.Rows)
            {
                int intidNoType = Convert.ToInt32(okok.Cells[0].Value.ToString());
                var testing = from lechose in monDataContext.PrixDepensesAbonnements
                              where lechose.NoTypeAbonnement == intidNoType
                              select lechose.Annee;

                if (testing.ToList().First().Year < DateTime.Now.Year)
                {
                    decimal prixDatagridView = Convert.ToDecimal(okok.Cells[1].Value);
                    decimal depensesObligatoiresDatagridView = Convert.ToDecimal(okok.Cells[2].Value);

                    //var testing1 = from lechose in monDataContext.PrixDepensesAbonnements
                    //               where (lechose.Annee == testing.ToList().First() && lechose.NoTypeAbonnement == intidNoType)
                    //               select lechose;
                    var testing1 = from lechose in listSansModif
                                   where (lechose.Annee == testing.ToList().First() && lechose.NoTypeAbonnement == intidNoType)
                                   select lechose;

                    PrixDepensesAbonnement modifier = new PrixDepensesAbonnement();
                    modifier = testing1.ToList().First();

                    //    if (modifier.Prix != prixDatagridView || modifier.DepensesObligatoires != depensesObligatoiresDatagridView)

                    if (listSansModif.Where(a => a.Annee == modifier.Annee && a.NoTypeAbonnement == modifier.NoTypeAbonnement)
                                     .Any(a => a.Prix != modifier.Prix || a.DepensesObligatoires != modifier.DepensesObligatoires))
                    {
                        modifier.Annee = DateTime.Now;
                    }

                    monDataContext.PrixDepensesAbonnements.InsertOnSubmit(modifier);

                }
                else
                {
                    MessageBox.Show("Vous ne pouvez pas modifier cette entrer", "Erreur de date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    prixDepensesAbonnementBindingSource.DataSource = from ok in monDataContext.PrixDepensesAbonnements
                                                                     select ok;
                }
            }

            monDataContext.SubmitChanges();
            monDataContext.Transaction.Commit();
            monDataContext.Connection.Close();
            listSansModif = (from ok in monDataContext.PrixDepensesAbonnements
                            select ok).ToList();

        }

        private void dgGestionPrixDepenses_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          //  dgGestionPrixDepenses.CurrentRow
        //    testModifierStuff.Add
        }
    }
}
