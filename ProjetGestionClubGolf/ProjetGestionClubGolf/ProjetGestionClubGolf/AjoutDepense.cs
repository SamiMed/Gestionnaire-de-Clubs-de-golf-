using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ProjetGestionClubGolf
{
    public partial class AjoutDepense : Form
    {
        int numEmp;
        string pwd;
        Employe empCourrant;
        int typeService;
        public AjoutDepense(int numEmp, string pwd)
        {
            InitializeComponent();

            this.numEmp = numEmp;
            this.pwd = pwd;

            foreach (Employe emp in dataContext.Employes)
            {
                if (emp.No == this.numEmp && emp.MotDePasse == this.pwd)
                {
                    this.empCourrant = emp;
                    break;
                }
            }

            if (empCourrant.NoTypeEmploye == 1)
            {
                cboType.Visible = true;
            } else
            {
                cboType.Visible = false;
            }
        }

        private void AjoutDepense_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            Dictionary<string, string> cboSourceClient = new Dictionary<string, string>();

            foreach (Abonnement abo in dataContext.Abonnements)
            {
                String strValue = "(" + abo.Id + ") " + abo.Prenom + " " + abo.Nom;
                cboSourceClient.Add(abo.Id, strValue);
            }

            cboClient.DataSource = new BindingSource(cboSourceClient, null);
            cboClient.DisplayMember = "Value";
            cboClient.ValueMember = "Key";

            Dictionary<int, string> cboSourceType = new Dictionary<int, string>();

            cboSourceType.Add(5, "Magasin Pro Shop");
            cboSourceType.Add(6, "Restaurant");
            cboSourceType.Add(7, "Leçon de golf");

            cboType.DataSource = new BindingSource(cboSourceType, null);
            cboType.DisplayMember = "Value";
            cboType.ValueMember = "Key";
        }

        monDataContextDataContext dataContext = new monDataContextDataContext();

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            using (TransactionScope trans = new TransactionScope())
            {
                messageErr.Clear();
                if (cboClient.SelectedIndex == -1)
                {
                    messageErr.SetError(cboClient, "Veuillez sélectionner un client");
                }
                else if ((empCourrant.NoTypeEmploye == 1 || empCourrant.NoTypeEmploye == 2 || empCourrant.NoTypeEmploye == 3) && cboType.SelectedIndex == -1)
                {
                    messageErr.SetError(cboClient, "Veuillez sélectionner un type de service");
                }
                else
                {

                    if (empCourrant.NoTypeEmploye == 5)
                    {
                        typeService = 5;
                    }
                    else if (empCourrant.NoTypeEmploye == 6)
                    {
                        typeService = 6;
                    }
                    else if (empCourrant.NoTypeEmploye == 7)
                    {
                        typeService = 7;
                    }
                    else
                    {
                        typeService = ((KeyValuePair<int, string>)cboType.SelectedItem).Key;
                    }
                    Depense newDepense = new Depense();

                    newDepense.DateDepense = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));

                    int noDep = 1;
                    foreach (Depense dep in dataContext.Depenses)
                    {
                        if (noDep < dep.No)
                        {
                            noDep = dep.No;
                        }
                    }
                    noDep++;
                    newDepense.No = noDep++;
                    newDepense.IdAbonnement = ((KeyValuePair<string, string>)cboClient.SelectedItem).Key;
                    newDepense.Montant = numMontant.Value;

                    int noSer = 1;
                    foreach (Service serv in dataContext.Services)
                    {
                        if (noSer < serv.No)
                        {
                            noSer = serv.No;
                        }
                    }
                    noSer++;

                    Service service = null;

                    switch (typeService)
                    {
                        case 5:
                            //Pro
                            foreach (Service ser in dataContext.Services)
                            {
                                if (ser.TypeService == "Magasin Pro Shop" && ser.NoEmploye == empCourrant.No)
                                {
                                    service = ser;
                                    break;
                                }
                            }
                            if (service != null)
                            {
                                newDepense.NoService = service.No;
                            }
                            else
                            {
                                Service newService = new Service
                                {
                                    No = noSer++,
                                    TypeService = "Magasin Pro Shop",
                                    NoEmploye = empCourrant.No
                                };

                                dataContext.Services.InsertOnSubmit(newService);
                                dataContext.SubmitChanges();

                                newDepense.NoService = newService.No;
                            }
                            break;
                        case 6:
                            //Rest
                            foreach (Service ser in dataContext.Services)
                            {
                                if (ser.TypeService == "Restaurant " && ser.NoEmploye == empCourrant.No)
                                {
                                    service = ser;
                                    break;
                                }
                            }
                            if (service != null)
                            {
                                newDepense.NoService = service.No;
                            }
                            else
                            {
                                Service newService = new Service
                                {
                                    No = noSer++,
                                    TypeService = "Restaurant ",
                                    NoEmploye = empCourrant.No
                                };

                                dataContext.Services.InsertOnSubmit(newService);
                                dataContext.SubmitChanges();

                                newDepense.NoService = newService.No;
                            }
                            break;
                        case 7:
                            //Golf
                            foreach (Service ser in dataContext.Services)
                            {
                                if (ser.TypeService == "Leçon de golf " && ser.NoEmploye == empCourrant.No)
                                {
                                    service = ser;
                                    break;
                                }
                            }
                            if (service != null)
                            {
                                newDepense.NoService = service.No;
                            }
                            else
                            {
                                Service newService = new Service
                                {
                                    No = noSer++,
                                    TypeService = "Leçon de golf ",
                                    NoEmploye = empCourrant.No
                                };

                                dataContext.Services.InsertOnSubmit(newService);
                                dataContext.SubmitChanges();

                                newDepense.NoService = newService.No;
                            }
                            break;
                    }

                    newDepense.Remarque = tbRemarque.Text;

                    dataContext.Depenses.InsertOnSubmit(newDepense);
                    dataContext.SubmitChanges();

                    trans.Complete();

                    this.Close();
                }
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
