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
    public partial class Choisir : Form
    {
        public Choisir()
        {
            InitializeComponent();
        }
        
        private void Choisir_Load(object sender, EventArgs e)
        {
            remplire_CMB_groupe_A1();
            remplire_CMB_groupe_A2();
            cmb_groupeA1.Enabled = false;
            cmb_groupeA2.Enabled = false;        }
        private void remplire_CMB_groupe_A1()
        {
            GLB.dtGroupeA1.Rows.Clear();
            if (ConnectionState.Open==GLB.cnx.State)
            {
                GLB.cnx.Close();
            }
            GLB.cnx.Open();
            GLB.cmd.CommandText = "select * from Groupe where Groupe.Annee_d_etude = '1ère année'";
            GLB.cmd.Connection = GLB.cnx;
            GLB.da.SelectCommand = GLB.cmd;
            GLB.da.Fill(GLB.dsA1);
            GLB.dtGroupeA1= GLB.dsA1.Tables[0];
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
            GLB.dtGroupeA2.Rows.Clear();
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

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            try
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
                Saisie saisie = new Saisie(groupe);
                saisie.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez choisir un groupe !! ");
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
