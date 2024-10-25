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
    public partial class Rechercher : Form
    {
        public Rechercher()
        {
            InitializeComponent();
        }

        private void Rechercher_Load(object sender, EventArgs e)
        {

        }
        private void ListeStagaire()
        {
            GLB.cnx.ConnectionString = GLB.connexionString;
            dgvRechercher.AllowUserToAddRows = false;
            dgvRechercher.AllowUserToDeleteRows = false;
            dgvRechercher.AllowUserToResizeColumns = false;
            dgvRechercher.ReadOnly = true;
            dgvRechercher.AllowUserToResizeRows = false;
            string Query = "select Stagiaire.Numero_Stagiaire,Stagiaire.Nom,Stagiaire.Prenom,dbo.Stagiaire.Cin,dbo.Stagiaire.Nom_Arabe,dbo.Stagiaire.Prenom_Arabe,dbo.Stagiaire.Genre,dbo.Stagiaire.Date_Naissance,dbo.Stagiaire.Adresse,dbo.Stagiaire.Numero_Telephone,dbo.Stagiaire.Email,dbo.Groupe.Libelle_Groupe from dbo.Stagiaire,dbo.Groupe where Stagiaire.Id_Groupe = Groupe.Id_Groupe";


            SqlCommand cmd = new SqlCommand(Query, GLB.cnx);
            if (ConnectionState.Open == GLB.cnx.State)
            {
                GLB.cnx.Close();
            }
            GLB.cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows == true)
            {
                this.dgvRechercher.Rows.Clear();
                while (rd.Read())
                {
                    this.dgvRechercher.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5], rd[6], rd[7], rd[8], rd[9], rd[10], rd[11]);
                }
                GLB.cnx.Close();
            }

        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                dgvRechercher.ClearSelection();
                dgvRechercher.Rows.Clear();
                if (ConnectionState.Open == GLB.cnx.State)
                {
                    GLB.cnx.Close();
                }
                GLB.cnx.Open();
                GLB.cmd.CommandText = $"select Stagiaire.Numero_Stagiaire,Stagiaire.Nom,Stagiaire.Prenom,dbo.Stagiaire.Cin,dbo.Stagiaire.Nom_Arabe,dbo.Stagiaire.Prenom_Arabe,dbo.Stagiaire.Genre,dbo.Stagiaire.Date_Naissance,dbo.Stagiaire.Adresse,dbo.Stagiaire.Numero_Telephone,dbo.Stagiaire.Email,dbo.Groupe.Libelle_Groupe from dbo.Stagiaire,dbo.Groupe where Stagiaire.Id_Groupe=Groupe.Id_Groupe and dbo.Stagiaire.Cin='{txtCIN.Text}'";
                GLB.cmd.Connection = GLB.cnx;

                GLB.dr = GLB.cmd.ExecuteReader();
                if (GLB.dr.HasRows)
                {
                    while (GLB.dr.Read())
                    {
                        this.dgvRechercher.Rows.Add(GLB.dr[0], GLB.dr[1], GLB.dr[2], GLB.dr[3], GLB.dr[4], GLB.dr[5], GLB.dr[6], GLB.dr[7], GLB.dr[8], GLB.dr[9], GLB.dr[10], GLB.dr[11]);
                    }
                }
                else
                    MessageBox.Show("Le Stagiaire introvable");
                GLB.dr.Close();
                GLB.cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
