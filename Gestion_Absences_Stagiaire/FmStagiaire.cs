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
    public partial class FmStagiaire : Form
    {
        public FmStagiaire()
        {
            InitializeComponent();
        }

        private void btnMiseJour_Click(object sender, EventArgs e)
        {
            MiseJour Ms = new MiseJour();
            Ms.MdiParent = this;
            Ms.Show();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            InformationStagiaire Is = new InformationStagiaire();
            Is.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
