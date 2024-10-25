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
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }

        private void Modify_Load(object sender, EventArgs e)
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

            dgvModify.AllowUserToAddRows = false;
            dgvModify.AllowUserToDeleteRows = false;
            dgvModify.AllowUserToResizeColumns = true;
            dgvModify.ReadOnly = true;
            dgvModify.AllowUserToResizeRows = false;
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
                this.dgvModify.Rows.Clear();
                while (rd.Read())
                {
                    this.dgvModify.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5], rd[6], rd[7], rd[8], rd[9], rd[10], rd[11], rd[12]);
                }

            }
            rd.Close();
            GLB.cnx.Close();
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumero.Text != null)
                {
                    dgvModify.ClearSelection();
                    dgvModify.Rows.Clear();
                    if (ConnectionState.Open == GLB.cnx.State)
                    {
                        GLB.cnx.Close();
                    }
                    GLB.cnx.Open();
                    GLB.cmd.CommandText = $"update dbo.Stagiaire " +
                        $"set Nom='{txtNom.Text}',Prenom='{txtPrenom.Text}',Cin='{txtCIN.Text}',Nom_Arabe='{txtNarab.Text}',Prenom_Arabe='{txtParab.Text}',Genre='{cmbGenre.Text}',Date_Naissance='{dtpNaissance.Text}',Adresse='{txtAdresse.Text}',Numero_Telephone='{txtTelephone.Text}',Email='{txtEmail.Text}',Stagiare_Fomation='{cmbFormation.Text}',Id_Groupe={cmbGroupe.SelectedValue} " +
                        $"where Numero_Stagiaire={txtNumero.Text}";
                    GLB.cmd.Connection = GLB.cnx;
                    GLB.cmd.ExecuteNonQuery();
                    MessageBox.Show("Stagaire Modifie");
                    ListeStagaire();
                }
                else
                    MessageBox.Show("Numero Stagaire introuvable !!");
                GLB.cnx.Close();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void dgvModify_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = dgvModify.CurrentRow.Index;
                txtNumero.Text = dgvModify.Rows[i].Cells[0].Value.ToString();
                txtNom.Text = dgvModify.Rows[i].Cells[1].Value.ToString();
                txtPrenom.Text = dgvModify.Rows[i].Cells[2].Value.ToString();
                txtCIN.Text = dgvModify.Rows[i].Cells[3].Value.ToString();
                txtNarab.Text = dgvModify.Rows[i].Cells[4].Value.ToString();
                txtParab.Text = dgvModify.Rows[i].Cells[5].Value.ToString();
                txtAdresse.Text = dgvModify.Rows[i].Cells[8].Value.ToString();
                txtTelephone.Text = dgvModify.Rows[i].Cells[9].Value.ToString();
                txtEmail.Text = dgvModify.Rows[i].Cells[10].Value.ToString();
                cmbGroupe.Text = dgvModify.Rows[i].Cells[12].Value.ToString();
                cmbGenre.Text = dgvModify.Rows[i].Cells[6].Value.ToString();
                cmbFormation.Text = dgvModify.Rows[i].Cells[11].Value.ToString();
                dtpNaissance.Text = dgvModify.Rows[i].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvModify.ClearSelection();
                dgvModify.Rows.Clear();
                if (ConnectionState.Open == GLB.cnx.State)
                {
                    GLB.cnx.Close();
                }
                GLB.cnx.Open();
                GLB.cmd.CommandText = $"select Stagiaire.Numero_Stagiaire,Stagiaire.Nom,Stagiaire.Prenom,dbo.Stagiaire.Cin,dbo.Stagiaire.Nom_Arabe,dbo.Stagiaire.Prenom_Arabe,dbo.Stagiaire.Genre,dbo.Stagiaire.Date_Naissance,dbo.Stagiaire.Adresse,dbo.Stagiaire.Numero_Telephone,dbo.Stagiaire.Email,dbo.Stagiaire.Stagiare_Fomation,dbo.Groupe.Libelle_Groupe from dbo.Stagiaire,dbo.Groupe where Stagiaire.Id_Groupe=Groupe.Id_Groupe and dbo.Stagiaire.Cin='{txtRecherche.Text}' ";
                GLB.cmd.Connection = GLB.cnx;

                GLB.dr = GLB.cmd.ExecuteReader();
                if (GLB.dr.HasRows)
                {
                    while (GLB.dr.Read())
                    {
                        this.dgvModify.Rows.Add(GLB.dr[0], GLB.dr[1], GLB.dr[2], GLB.dr[3], GLB.dr[4], GLB.dr[5], GLB.dr[6], GLB.dr[7], GLB.dr[8], GLB.dr[9], GLB.dr[10], GLB.dr[11], GLB.dr[12]);
                    }
                }
                
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
