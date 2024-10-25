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
    public partial class Sing_Up : Form
    {
        public Sing_Up()
        {
            InitializeComponent();
        }

        private void Sing_Up_Load(object sender, EventArgs e)
        {

        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text != null && txtPassword.Text != null && txtConfirm.Text != null)
                {
                    
                    if (ConnectionState.Open == GLB.cnx.State)
                    {
                        GLB.cnx.Close();
                    }
                    GLB.cnx.Open();
                    GLB.cmd.CommandText = $"insert into Connexion values ('{txtUser.Text}','{txtPassword.Text}')";
                    GLB.cmd.Connection = GLB.cnx;
                    GLB.cmd.ExecuteNonQuery();
                    MessageBox.Show("Compte Ajouter");
                    

                }
                GLB.cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sing_Up_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void radioShow_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioShow.Checked)
            {
                txtPassword.PasswordChar = '*';
                txtConfirm.PasswordChar = '*';
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                txtConfirm.PasswordChar = '\0';
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
