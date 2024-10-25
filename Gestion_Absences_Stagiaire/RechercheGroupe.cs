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
    public partial class RechercheGroupe : Form
    {
        public RechercheGroupe()
        {
            InitializeComponent();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                cmb_groupeA1.Enabled = true;
                guna2ToggleSwitch2.Checked = false;
            }
            else
                cmb_groupeA1.Enabled = false;
        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch2.Checked)
            {
                cmb_groupeA2.Enabled = true;
                guna2ToggleSwitch1.Checked = false;
            }
            else
                cmb_groupeA2.Enabled = false;
        }
        private void remplire_CMB_groupe_A1()
        {
            GLB.cnx.Open();
            GLB.cmd.CommandText = "select * from Groupe where Groupe.Annee_d_etude = '1ère année'";
            GLB.cmd.Connection = GLB.cnx;
            GLB.da.SelectCommand = GLB.cmd;
            GLB.da.Fill(GLB.dsA1);
            GLB.dtGroupeA1 = GLB.dsA1.Tables[0];
            cmb_groupeA1.DataSource = GLB.dtGroupeA1;
            cmb_groupeA1.DisplayMember = GLB.dsA1.Tables[0].Columns[1].ColumnName;
            cmb_groupeA1.ValueMember = GLB.dsA1.Tables[0].Columns[0].ColumnName;
            GLB.cnx.Close();
            /*if (ConnectionState.Open == GLB.cnx.State)
                GLB.cnx.Close();
            GLB.cnx.Open();
            GLB.cmd.CommandText = "select * from Groupe where Groupe.Annee_d_etude = '1ère année'";
            GLB.cmd.Connection = GLB.cnx;
            GLB.dr = GLB.cmd.ExecuteReader();
            if (GLB.dr.HasRows)
            {
                while (GLB.dr.Read())
                {
                    cmb_groupeA1.Items.Add(GLB.dr["Libelle_Groupe"]);
                }
            }
            else
                cmb_groupeA1.SelectedIndex = -1;
            GLB.dr.Close();
            GLB.cnx.Close();*/


        }
        private void remplire_CMB_groupe_A2()
        {
            GLB.cnx.Open();
            GLB.cmd.CommandText = "select * from Groupe where Groupe.Annee_d_etude='2ème année'";
            GLB.cmd.Connection = GLB.cnx;
            GLB.da.SelectCommand = GLB.cmd;
            GLB.da.Fill(GLB.dsA2);
            GLB.dtGroupeA2 = GLB.dsA2.Tables[0];
            cmb_groupeA2.DataSource = GLB.dtGroupeA2;
            cmb_groupeA2.DisplayMember = GLB.dsA2.Tables[0].Columns[1].ColumnName;
            cmb_groupeA2.ValueMember = GLB.dsA2.Tables[0].Columns[0].ColumnName;
            GLB.cnx.Close();

            /*if (ConnectionState.Open == GLB.cnx.State)
                GLB.cnx.Close();
            GLB.cnx.Open();
            GLB.cmd.CommandText = "select * from Groupe where Groupe.Annee_d_etude='2ème année'";
            GLB.cmd.Connection = GLB.cnx;
            GLB.dr = GLB.cmd.ExecuteReader();
            if (GLB.dr.HasRows)
            {
                while (GLB.dr.Read())
                {
                    cmb_groupeA2.DisplayMember=GLB.dr["Libelle_Groupe"];
                }
            }
            else
                cmb_groupeA2.SelectedIndex = -1;
            GLB.dr.Close();
            GLB.cnx.Close();*/



        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            string groupe = "";
            if (cmb_groupeA1.Text != "" && cmb_groupeA1.Enabled == true)
            {
                groupe = cmb_groupeA1.SelectedValue.ToString();
            }
            else if (cmb_groupeA2.Text != "" && cmb_groupeA2.Enabled == true)
            {
                groupe = cmb_groupeA2.SelectedValue.ToString();
            }
            GLB.dtStagiaire1.Rows.Clear();
            guna2DataGridView1.Rows.Clear();
            GLB.cnx.Open();

            GLB.cmd.CommandText = $"select  Numero_Stagiaire, Libelle_Groupe , Nom,Prenom from Stagiaire,Groupe where Groupe.Id_Groupe=Stagiaire.Id_Groupe and Groupe.Id_Groupe={groupe}";
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
                    var = "Exclusion temporaire ou définitive à l'appréciation du conseil de discipline";
                }
                else if (note <= 15 && note >= 0)
                {
                    var = "Exclusion définitive ";
                }


                guna2DataGridView1.Rows.Add(row[1], row[2], row[3], total, nbj, note, var);


                GLB.cnx.Close();
            }
            
        }

        private void RechercheGroupe_Load(object sender, EventArgs e)
        {
            remplire_CMB_groupe_A1();
            remplire_CMB_groupe_A2();
            cmb_groupeA1.Enabled = false;
            cmb_groupeA2.Enabled = false;
        }

        private void cmb_groupeA2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //guna2DataGridView1.Rows.Clear();
        }

        private void cmb_groupeA1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //guna2DataGridView1.Rows.Clear();
        }
    }
}
