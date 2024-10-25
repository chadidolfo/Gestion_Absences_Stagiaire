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
    public partial class Ajouter : Form
    {
        public Ajouter()
        {
            InitializeComponent();

        }

        private void Ajouter_Load(object sender, EventArgs e)
        {
            remplire_CMB_groupe();
            remplire_CMB_formation_genre();
            ListeStagaire();
        }
        private void remplire_CMB_groupe()
        {
            GLB.cnx.Open();
            GLB.cmd.CommandText = "select *from Groupe";
            GLB.cmd.Connection = GLB.cnx;
            GLB.da.SelectCommand = GLB.cmd;
            GLB.da.Fill(GLB.ds);
            GLB.dtGroupe = GLB.ds.Tables[0];
            cmbGroupe.DataSource = GLB.dtGroupe;
            cmbGroupe.DisplayMember = GLB.ds.Tables[0].Columns[1].ColumnName;
            cmbGroupe.ValueMember = GLB.ds.Tables[0].Columns[0].ColumnName;
            GLB.cnx.Close();

            
        }
        private void remplire_CMB_formation_genre()
        {
            cmbFormation.Items.Add("oui");
            cmbFormation.Items.Add("non");
            cmbGenre.Items.Add("H");
            cmbGenre.Items.Add("F");

        }
        private void ListeStagaire()
        {
            
            dgvAjouter.AllowUserToAddRows = false;
            dgvAjouter.AllowUserToDeleteRows = false;
            dgvAjouter.AllowUserToResizeColumns = true;
            dgvAjouter.ReadOnly = true;
            dgvAjouter .AllowUserToResizeRows = false;
            string Query = "select Stagiaire.Numero_Stagiaire,Stagiaire.Nom,Stagiaire.Prenom,dbo.Stagiaire.Cin,dbo.Stagiaire.Nom_Arabe,dbo.Stagiaire.Prenom_Arabe,dbo.Stagiaire.Genre,dbo.Stagiaire.Date_Naissance,dbo.Stagiaire.Adresse,dbo.Stagiaire.Numero_Telephone,dbo.Stagiaire.Email,dbo.Stagiaire.Stagiare_Fomation,dbo.Groupe.Libelle_Groupe from dbo.Stagiaire,dbo.Groupe where Stagiaire.Id_Groupe=Groupe.Id_Groupe";

            
            SqlCommand cmd = new SqlCommand(Query, GLB.cnx);
            if (ConnectionState.Open==GLB.cnx.State)
            {
                GLB.cnx.Close();
            }
            GLB.cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows == true)
            {
                this.dgvAjouter.Rows.Clear();
                while (rd.Read())
                {
                    this.dgvAjouter.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5], rd[6], rd[7], rd[8], rd[9], rd[10], rd[11],rd[12]);
                }
                
            }
            rd.Close();
            GLB.cnx.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumero.Text!=null&&txtNom.Text!=null&&txtPrenom.Text!=null)
                {
                    dgvAjouter.ClearSelection();
                    dgvAjouter.Rows.Clear();
                    if (ConnectionState.Open == GLB.cnx.State)
                    {
                        GLB.cnx.Close();
                    }
                    GLB.cnx.Open();
                    GLB.cmd.CommandText = $"insert into dbo.Stagiaire values({txtNumero.Text},'{txtNom.Text}','{txtPrenom.Text}','{txtCIN.Text}','{txtNarab.Text}','{txtParab.Text}','{cmbGenre.Text}','{dateTimePicker1.Text}','{txtAdresse.Text}','{txtTelephone.Text}','{txtEmail.Text}','{cmbFormation.Text}',{cmbGroupe.SelectedValue})";
                    GLB.cmd.Connection = GLB.cnx;
                    GLB.cmd.ExecuteNonQuery();
                    MessageBox.Show("Stagaire Ajouter");
                    ListeStagaire();
                  
                }
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

        private void dgvAjouter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvAjouter.CurrentRow.Index;
            txtNumero.Text = dgvAjouter.Rows[i].Cells[0].Value.ToString();
            txtNom.Text = dgvAjouter.Rows[i].Cells[1].Value.ToString();
            txtPrenom.Text = dgvAjouter.Rows[i].Cells[2].Value.ToString();
            txtCIN.Text = dgvAjouter.Rows[i].Cells[3].Value.ToString();
            txtNarab.Text = dgvAjouter.Rows[i].Cells[4].Value.ToString();
            txtParab.Text = dgvAjouter.Rows[i].Cells[5].Value.ToString();
            txtAdresse.Text = dgvAjouter.Rows[i].Cells[8].Value.ToString();
            txtTelephone.Text = dgvAjouter.Rows[i].Cells[9].Value.ToString();
            txtEmail.Text = dgvAjouter.Rows[i].Cells[10].Value.ToString();
            cmbGroupe.Text = dgvAjouter.Rows[i].Cells[12].Value.ToString();
            cmbGenre.Text = dgvAjouter.Rows[i].Cells[6].Value.ToString();
            cmbFormation.Text = dgvAjouter.Rows[i].Cells[11].Value.ToString();
            dateTimePicker1.Text = dgvAjouter.Rows[i].Cells[7].Value.ToString();
        }
    }
}
