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

namespace Gestion_Absences_Stagiaire
{
    public partial class Supprimer : Form
    {
        public Supprimer()
        {
            InitializeComponent();
        }

        private void Supprimer_Load(object sender, EventArgs e)
        {
            ListeStagaire();
        }
        private void ListeStagaire()
        {

            dgvSupp.AllowUserToAddRows = false;
            dgvSupp.AllowUserToDeleteRows = false;
            dgvSupp.AllowUserToResizeColumns = true;
            dgvSupp.ReadOnly = true;
            dgvSupp.AllowUserToResizeRows = false;
            string Query = "select Stagiaire.Numero_Stagiaire,Stagiaire.Nom,Stagiaire.Prenom,dbo.Stagiaire.Cin,dbo.Stagiaire.Nom_Arabe,dbo.Stagiaire.Prenom_Arabe,dbo.Stagiaire.Genre,dbo.Stagiaire.Date_Naissance,dbo.Stagiaire.Adresse,dbo.Stagiaire.Numero_Telephone,dbo.Stagiaire.Email,dbo.Stagiaire.Stagiare_Fomation,dbo.Groupe.Libelle_Groupe from dbo.Stagiaire,dbo.Groupe where Stagiaire.Id_Groupe=Groupe.Id_Groupe";


            SqlCommand cmd = new SqlCommand(Query, GLB.cnx);
            if (ConnectionState.Open == GLB.cnx.State)
            {
                GLB.cnx.Close();
            }
            GLB.cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows == true)
            {
                this.dgvSupp.Rows.Clear();
                while (rd.Read())
                {
                    this.dgvSupp.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5], rd[6], rd[7], rd[8], rd[9], rd[10], rd[11], rd[12]);
                }

            }
            rd.Close();
            GLB.cnx.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNom.Text != null )
                {
                    dgvSupp.ClearSelection();
                    dgvSupp.Rows.Clear();
                    if (ConnectionState.Open == GLB.cnx.State)
                    {
                        GLB.cnx.Close();
                    }
                    GLB.cnx.Open();
                    GLB.cmd.CommandText = $"delete from Stagiaire where Cin='{txtNom.Text}'";
                    GLB.cmd.Connection = GLB.cnx;
                    GLB.cmd.ExecuteNonQuery();
                    MessageBox.Show("Stagaire Supprimer");
                    ListeStagaire();
                }
                else
                    MessageBox.Show("Veuillez Remplire Tous les Champs !!");
                GLB.cnx.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
