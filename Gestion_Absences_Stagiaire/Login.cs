using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Gestion_Absences_Stagiaire
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Menu mn = new Menu();
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnxISFO"].ConnectionString.ToString());
            SqlCommand cmd = new SqlCommand("select * from Connexion", sqlConnection);
            if (ConnectionState.Open == GLB.cnx.State)
            {
                GLB.cnx.Close();
            }
            sqlConnection.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    if (txtUser.Text == rd[0].ToString() && txtPassword.Text == rd[1].ToString())
                    {
                        MessageBox.Show("connection succeed");
                        Menu mn = new Menu();
                        mn.Show();
                        this.Hide();
                        
                        return;


                    }


                }
                MessageBox.Show("connection failed");

            }

            sqlConnection.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void radioShow_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioShow.Checked) txtPassword.PasswordChar = '*';
            else txtPassword.PasswordChar = '\0';
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            Pin Su = new Pin();
            Su.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Forget fr = new Forget();
            fr.Show();
            this.Hide();
        }
    }
}
