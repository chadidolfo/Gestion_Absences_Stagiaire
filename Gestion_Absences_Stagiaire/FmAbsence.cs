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
    public partial class FmAbsence : Form
    {
        public FmAbsence()
        {
            InitializeComponent();
        }

        private void btnGroupe_Click(object sender, EventArgs e)
        {
            Choisir Ch = new Choisir();
            Ch.MdiParent = this;
            Ch.Show();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            Choisie2 Ch = new Choisie2();
            Ch.MdiParent = this;
            Ch.Show();
            //RechercheGroupe Rg = new RechercheGroupe();
            //Rg.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
