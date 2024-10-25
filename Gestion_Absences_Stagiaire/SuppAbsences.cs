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
    public partial class SuppAbsences : Form
    {
        public SuppAbsences()
        {
            InitializeComponent();
        }
        private void Rechercher()
        {
            try
            {
                dgvSupp.ClearSelection();
                dgvSupp.Rows.Clear();
                if (ConnectionState.Open == GLB.cnx.State)
                {
                    GLB.cnx.Close();
                }
                GLB.cnx.Open();
                GLB.cmd.CommandText = $"select S.Numero_Stagiaire, S.Nom,S.Prenom,A.Date_Abs, A.NbrJ,A.Jour from Stagiaire S , Absence_Jour A where Nom = '{txtNom.Text}' and S.Numero_Stagiaire=A.Num_Stg ";
                GLB.cmd.Connection = GLB.cnx;

                GLB.dr = GLB.cmd.ExecuteReader();
                if (GLB.dr.HasRows)
                {
                    while (GLB.dr.Read())
                    {
                        this.dgvSupp.Rows.Add(GLB.dr[0], GLB.dr[1], GLB.dr[2], Convert.ToDateTime(GLB.dr[3]).ToShortDateString(), Convert.ToInt32(Convert.ToDecimal(GLB.dr[4]) * 2), GLB.dr[5]);
                    }
                    txtNumero.Text= dgvSupp.Rows[0].Cells[0].Value.ToString();
                }
                
                GLB.dr.Close();
                GLB.cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConnectionState.Open == GLB.cnx.State)
                {
                    GLB.cnx.Close();
                }
                GLB.cnx.Open();
                GLB.cmd.CommandText = $"delete from dbo.Absence_Jour where Absence_Jour.Date_Abs='{dtpAbsence.Value}' and Absence_Jour.Jour='{cmbJour.Text}' and Absence_Jour.Num_Stg={txtNumero.Text}";
                GLB.cmd.Connection = GLB.cnx;
                GLB.cmd.ExecuteNonQuery();
                MessageBox.Show("Absenses Supprimer");
                Rechercher();
                GLB.cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void SuppAbsences_Load(object sender, EventArgs e)
        {
            cmbJour.Items.Add("Lundi");
            cmbJour.Items.Add("Mardi");
            cmbJour.Items.Add("Mercredi");
            cmbJour.Items.Add("Jeudi");
            cmbJour.Items.Add("Vendredi");
            cmbJour.Items.Add("Samedi");

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            Rechercher();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
