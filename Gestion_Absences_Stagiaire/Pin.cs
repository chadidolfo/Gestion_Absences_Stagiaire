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
    public partial class Pin : Form
    {
        public Pin()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGroupe_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnxISFO"].ConnectionString.ToString());
            SqlCommand cmd = new SqlCommand("select * from CodePin", sqlConnection);
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
                    if (guna2TextBox1.Text == rd[1].ToString())
                    {
                        MessageBox.Show("connection succeed");
                        Sing_Up mn = new Sing_Up();
                        mn.Show();
                        this.Hide();

                        return;


                    }


                }
                MessageBox.Show("connection failed");

            }

            sqlConnection.Close();
        }
    }
}
