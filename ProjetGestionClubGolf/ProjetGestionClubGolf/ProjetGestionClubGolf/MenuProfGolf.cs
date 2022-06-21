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
    public partial class MenuProfGolf : Form
    {
        public MenuProfGolf()
        {
            InitializeComponent();
        }


        string pwd;
        int numEmp;

        public MenuProfGolf(int numEmp, string pwd)
        {
            InitializeComponent();
            this.pwd = pwd;
            this.numEmp = numEmp;
        }

        private void btnAjoutDepense_Click(object sender, EventArgs e)
        {
            AjoutDepense ajoutDepense = new AjoutDepense(numEmp, pwd);
            this.Hide();
            ajoutDepense.ShowDialog();
            this.Show();
        }

        private void btnAjouterPartieGolfJouer_Click(object sender, EventArgs e)
        {
            PartieGolfJouer partieGolfJouer = new PartieGolfJouer();
            this.Hide();
            partieGolfJouer.ShowDialog();
            this.Show();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
