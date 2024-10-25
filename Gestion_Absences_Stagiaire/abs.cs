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
    public partial class abs : Form
    {
        string grp;
        public abs(String groupe)
        {
            InitializeComponent();
            grp = groupe;
            
        }

        private void abs_Load(object sender, EventArgs e)
        {
            GLB.dtStagiaire1.Rows.Clear();
            dgvAfficher.Rows.Clear();   
            GLB.cnx.Open();

            GLB.cmd.CommandText = $"select  Numero_Stagiaire, Libelle_Groupe , Nom,Prenom from Stagiaire,Groupe where Groupe.Id_Groupe=Stagiaire.Id_Groupe and Groupe.Id_Groupe={grp}";
            GLB.cmd.Connection = GLB.cnx;
            GLB.da.SelectCommand = GLB.cmd;
            GLB.da.Fill(GLB.ds);
            GLB.dtStagiaire1 = GLB.ds.Tables[0];

            GLB.cnx.Close();

            foreach (DataRow row in GLB.dtStagiaire1.Rows)
            {


                //MessageBox.Show("Row"+row[0].ToString());
                double note = 20;
                int total = 0;
                decimal nbj = 0;
                if (ConnectionState.Open == GLB.cnx.State)
                    GLB.cnx.Close();
                GLB.cnx.Open();
                //nbj = Convert.ToDecimal($"select SUM(Absence_Jour.NbrJ) from Absence_Jour where Absence_Jour.Num_Stg = '{row[0]}'");
                //total = Convert.ToInt32(nbj * 2);
                //note = (double)(20 - nbj);
                //string 
                var val = row[0].ToString();

                GLB.cmd.CommandText = $"select SUM(Absence_Jour.NbrJ) from Absence_Jour where Absence_Jour.Num_Stg ='{val}'";
                GLB.cmd.Connection = GLB.cnx;
                //GLB.dr = GLB.cmd.ExecuteReader();
                //while (GLB.dr.Read())
                //{
                //    MessageBox.Show(GLB.dr[0].ToString());
                //}
                var test = GLB.cmd.ExecuteScalar();
                //MessageBox.Show("SCalar" + test);


                if (test.ToString() != "")
                {

                    nbj = Convert.ToDecimal(test.ToString());
                    total = Convert.ToInt32(nbj * 2);
                    note = (double)(20 - nbj);
                }

                string var = "";
                if (note == 20)
                {
                    var = "excellent";
                }
                else if (note == 19.5)
                {
                    var = "1ére Mise en Garde";

                }
                else if (note == 19)
                {
                    var = "2éme Mise en Garde";

                }
                else if (note == 18.5)
                {
                    var = "1ére Avertissement";

                }
                else if (note == 18)
                {
                    var = "2éme Mise en Garde";

                }
                else if (note == 17.5)
                {
                    var = "Blâme";
                }
                else if (note == 17)
                {
                    var = "Exclusion de 2 Jours";

                }
                else if (note <= 16.5 && note > 15)
                {
                    var = "Exclusion temporaire ou définitive ";
                }
                else if (note <= 15 && note >= 0)
                {
                    var = "Exclusion définitive ";
                }
               

                dgvAfficher.Rows.Add(row[1], row[2], row[3], total, nbj, note, var);


                GLB.cnx.Close();
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

            if (ConnectionState.Open==GLB.cnx.State)
            {
                GLB.cnx.Close();
            }
            GLB.cnx.Open();
            GLB.cmd.CommandText = "delete from  Imprimer";
            GLB.cmd.Connection = GLB.cnx;
            GLB.cmd.ExecuteNonQuery();
            GLB.cnx.Close();

            foreach (DataGridViewRow item in dgvAfficher.Rows)
            {
                if (ConnectionState.Open == GLB.cnx.State)
                {
                    GLB.cnx.Close();
                }
                GLB.cnx.Open();
                if (item.Cells[0].Value!= null)
                {
                    
                    GLB.cmd.CommandText = $"insert into Imprimer values ('{item.Cells[0].Value}','{item.Cells[1].Value}','{item.Cells[2].Value}','{item.Cells[3].Value}','{item.Cells[4].Value}','{item.Cells[5].Value}','{item.Cells[6].Value}')";
                    GLB.cmd.Connection = GLB.cnx;
                    GLB.cmd.ExecuteNonQuery();
                    
                }
                
                
                
                GLB.cnx.Close();
            }
            MessageBox.Show("Valider");
            Imprimer imprimer = new Imprimer();
            imprimer.Show();

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
