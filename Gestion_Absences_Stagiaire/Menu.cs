using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Absences_Stagiaire
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public void enbled()
        {
            btnStagiaire.Enabled = false;
            btnAbsences.Enabled = false;
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            btnStagiaire.Enabled = true;
            btnAbsences.Enabled = true;
        }
      
        private void btnStagiaire_Click(object sender, EventArgs e)
        {
            FmStagiaire St = new FmStagiaire();
            //St.MdiParent = this;
            St.Show();
        }

        private void btnAbsences_Click(object sender, EventArgs e)
        {
            FmAbsence As = new FmAbsence();
            As.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
