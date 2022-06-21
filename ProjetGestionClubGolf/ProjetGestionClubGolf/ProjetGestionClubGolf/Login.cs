using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace ProjetGestionClubGolf
{
    public partial class Login : Form
    {
        monDataContextDataContext monDataContextDataContext = new monDataContextDataContext();

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string pwd = tbMotDePasse.Text;
            int numEmp;

            if (string.IsNullOrEmpty(tbUsername.Text))
            {
                errorMessage.SetError(tbUsername, "Veuillez inscire un numéro d'employé");
            }

            else if (string.IsNullOrEmpty(pwd))
            {

                errorMessage.SetError(tbMotDePasse, "Veuillez saisir un mot de passe");
            }


            else if (int.TryParse(tbUsername.Text, out numEmp) == true)
            {

                var connection = (from unEmploye in monDataContextDataContext.Employes
                                  join unTypeEmp in monDataContextDataContext.TypesEmployes
                                  on unEmploye.NoTypeEmploye equals unTypeEmp.No
                                  where unEmploye.No == numEmp && unEmploye.MotDePasse == pwd
                                  select unEmploye.NoTypeEmploye).ToList();

                if (connection.Count == 0)
                {
                    MessageBox.Show("L'utilisateur saisie n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {

                    foreach (var connect in connection)
                    {
                        // admin
                        if (connect == 1)//Modif//
                        {
                            MenuAdministrateur menuAdministrateur = new MenuAdministrateur(numEmp, pwd);
                            this.Hide();
                            menuAdministrateur.ShowDialog();
                            this.Show();
                        }
                        //Direction
                        else if (connect == 2)
                        {
                            MenuDirections menuDirections = new MenuDirections(numEmp, pwd);
                            this.Hide();
                            menuDirections.ShowDialog();
                            this.Show();
                        }
                        //Propriétaire du club
                        else if (connect == 3)
                        {
                            MenuProprietaireClub menuProprietaireClub = new MenuProprietaireClub(numEmp, pwd);
                            this.Hide();
                            menuProprietaireClub.ShowDialog();
                            this.Show();
                        }
                        //Employé d'un club
                        else if (connect == 4)
                        {
                            MenuEmployerClub menuEmployerClub = new MenuEmployerClub();
                            this.Hide();
                            menuEmployerClub.ShowDialog();
                            this.Show();
                        }
                        //Employé pro shop
                        else if (connect == 5)
                        {
                            MenuEmployerProShop menuEmployerProShop = new MenuEmployerProShop(numEmp, pwd);
                            this.Hide();
                            menuEmployerProShop.ShowDialog();
                            this.Show();
                            
                        }
                        //Employé restaurant
                        else if (connect == 6)
                        {
                            MenuEmployerRestaurant menuEmployerRestaurant = new MenuEmployerRestaurant(numEmp, pwd);
                            this.Hide();
                            menuEmployerRestaurant.ShowDialog();
                            this.Show();
                        }
                        //Professeur golf
                        else if (connect == 7)
                        {
                            MenuProfGolf menuProfGolf = new MenuProfGolf(numEmp, pwd);
                            this.Hide();
                            menuProfGolf.ShowDialog();
                            this.Show();
                            MessageBox.Show("Professeur golf");
                        }
                    }
                }
            }

            else
            {
                errorMessage.SetError(tbUsername, "Le numéro d'employé doit contenir que des chiffres");
            }
        }
    }
}
