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
    public partial class Ready : Form
    {
        public Ready()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int Start;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Start += 3;
            PB.Value = Start;
            if (PB.Value == 100)
            {
                PB.Value = 0;
                timer1.Stop();
                Login LG = new Login();
                LG.Show();
                this.Hide();
            }
        }

        private void Ready_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
