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
    public partial class Saisie : Form
    {
        string grp;
        public Saisie(String groupe)
        {
            InitializeComponent();
             grp = groupe;
        }

        private void Saisie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iSFODataSet.Seance' table. You can move, or remove it, as needed.
            this.seanceTableAdapter.Fill(this.iSFODataSet.Seance);
            dgvSaisie.AllowUserToAddRows = false;
            if (ConnectionState.Open == GLB.cnx.State)
                GLB.cnx.Close();
            GLB.cnx.Open();
            GLB.cmd.CommandText = $"select Numero_Stagiaire , Nom,Prenom from Stagiaire where Id_Groupe={grp}";
            GLB.cmd.Connection = GLB.cnx;
            GLB.dr = GLB.cmd.ExecuteReader();
            if (GLB.dr.HasRows)
            {
                while (GLB.dr.Read())
                {
                    dgvSaisie.Rows.Add(GLB.dr[0].ToString(), GLB.dr[1].ToString(), GLB.dr[2].ToString());
                }
            }
           
            GLB.dr.Close();
            GLB.cnx.Close(); 

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
            

            for (int i = 0; i < dgvSaisie.Rows.Count; i++)
            {
                
                float n = 0;
                for (int j = 3; j < dgvSaisie.Columns.Count;j++)
                {
                    
                    if (dgvSaisie.Rows[i].Cells[j].Value != null)
                    {
                        float nbr = 0;
                        //nbr+=int.Parse(dgvSaisie.Rows[i].Cells[j].Value.ToString());
                        try
                        {
                            
                            nbr =int.Parse(dgvSaisie.Rows[i].Cells[j].Value.ToString());
                            n = nbr / 2;
                            if (ConnectionState.Open == GLB.cnx.State)
                                GLB.cnx.Close();
                            GLB.cnx.Open();
                            GLB.cmd.CommandText = $"insert into Absence_Jour values({dgvSaisie.Rows[i].Cells[0].Value},'{dateTimePicker1.Value}',{n},'{dgvSaisie.Columns[j].HeaderText}')";
                            GLB.cmd.Connection = GLB.cnx;
                            GLB.cmd.ExecuteNonQuery();




                            GLB.cnx.Close();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            
            }
            MessageBox.Show("Absence Ajouter");

            //foreach  (DataGridViewRow row  in dgvSaisie.Rows)
            //{
            //    if (row.Cells[3].Value.ToString()!=null&&  row.Cells[4].Value.ToString() != null &&  row.Cells[5].Value.ToString() != null &&  row.Cells[6].Value.ToString() != null && row.Cells[7].Value.ToString() != null && row.Cells[8].Value.ToString() != null )
            //    {
            //        int i = Convert.ToInt32(row.Cells[3].Value.ToString() + row.Cells[4].Value.ToString() + row.Cells[5].Value.ToString() + row.Cells[6].Value.ToString() + row.Cells[7].Value.ToString() + row.Cells[8].Value.ToString());
            //        MessageBox.Show(i.ToString());
            //    }
            //    //int i = Convert.ToInt32( row.Cells[3].Value.ToString()+ row.Cells[4].Value.ToString() + row.Cells[5].Value.ToString() + row.Cells[6].Value.ToString() + row.Cells[7].Value.ToString() + row.Cells[8].Value.ToString()) ;
            //    /*GLB.cmd.CommandText = $"insert into Absence_Jour values ({row[0]},'{dateTimePicker1.Value.ToShortDateString()}',)";
            //    GLB.cmd.Connection = GLB.cnx;*/
            //}
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            SuppAbsences Sa = new SuppAbsences();
            Sa.Show();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            dgvSaisie.Rows.Clear();
            try
            {
                this.seanceTableAdapter.Fill(this.iSFODataSet.Seance);
                dgvSaisie.AllowUserToAddRows = false;
                if (ConnectionState.Open == GLB.cnx.State)
                    GLB.cnx.Close();
                GLB.cnx.Open();
                GLB.cmd.CommandText = $"select Numero_Stagiaire,Nom,Prenom from Stagiaire where Nom= '{txtRecherche.Text}' and Id_Groupe={grp}";
                GLB.cmd.Connection = GLB.cnx;
                GLB.dr = GLB.cmd.ExecuteReader();
                if (GLB.dr.HasRows)
                {
                    while (GLB.dr.Read())
                    {
                        dgvSaisie.Rows.Add(GLB.dr[0].ToString(), GLB.dr[1].ToString(), GLB.dr[2].ToString());
                    }
                }

                GLB.dr.Close();
                GLB.cnx.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message) ;
            }
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            RCHstag rC = new RCHstag(grp);
            rC.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
