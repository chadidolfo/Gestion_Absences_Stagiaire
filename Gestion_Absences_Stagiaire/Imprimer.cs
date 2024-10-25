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
    public partial class Imprimer : Form
    {
        public Imprimer()
        {
            InitializeComponent();
        }

        private void Imprimer_Load(object sender, EventArgs e)
        {
            if (ConnectionState.Open==GLB.cnx.State)
            {
                GLB.cnx.Close();
            }
            GLB.cnx.Open();
            GLB.cmd.CommandText = "select * from Imprimer";
            GLB.cmd.Connection = GLB.cnx;
            GLB.da.Fill(GLB.dtImprimer);
            CrystalReport1 crystal = new CrystalReport1();
            crystal.SetDataSource(GLB.dtImprimer);
            crystalReportViewer1.ReportSource = crystal;
            crystalReportViewer1.Refresh();

        }
    }
}
