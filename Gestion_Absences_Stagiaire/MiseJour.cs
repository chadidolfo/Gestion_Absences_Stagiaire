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
    public partial class MiseJour : Form
    {
        public MiseJour()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Ajouter Aj = new Ajouter();
            Aj.Show();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Modify Md = new Modify();
            Md.Show();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            Rechercher Rc = new Rechercher();
            Rc.Show();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Supprimer Sp = new Supprimer();
            Sp.Show();
        }

        private void btnExporter_Click(object sender, EventArgs e)
        {
            Exporter Ex = new Exporter();
            Ex.Show();
        }

        private void btnImporter_Click(object sender, EventArgs e)
        {
            Importer importer = new Importer();
            importer.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void MiseJour_Load(object sender, EventArgs e)
        {

        }
    }
}
