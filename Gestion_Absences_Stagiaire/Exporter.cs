using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Absences_Stagiaire
{
    public partial class Exporter : Form
    {
        public Exporter()
        {
            InitializeComponent();
        }

        private void btnExporter_Click(object sender, EventArgs e)
        {
            try
            {
                 SaveFileDialog openFileDialog = new SaveFileDialog();
                 openFileDialog.InitialDirectory = "c:\\";
                 openFileDialog.Filter = "Excel files (.xlsx)|.xlsx|Excel 2016 (.xls)|.xls";
                 openFileDialog.FilterIndex = 1;

                 if (openFileDialog.ShowDialog() == DialogResult.OK)
                 {
                     DataTable dt = ExporterExcel.DataGridView_To_Datatable(dgvExporter);
                     dt.exportToExcel(openFileDialog.FileName);
                     MessageBox.Show("Data is exported!");
                 }
                //SaveFileDialog savefiledialog1 = new SaveFileDialog();


                //savefiledialog1.InitialDirectory = "C:";
                //savefiledialog1.Title = "save as excel file";
                //savefiledialog1.FileName = "";
                //savefiledialog1.Filter = "Excel files (.xlsx)|.xlsx|Excel 2016 (.xls)|.xls";
                //if (savefiledialog1.ShowDialog() != DialogResult.Cancel)
                //{
                //    Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                //    ExcelApp.Application.Workbooks.Add(Type.Missing);
                //    ExcelApp.Columns.ColumnWidth = 20;
                //    for (int i = 1; i < dgvExporter.Columns.Count+1; i++)
                //    {
                //        ExcelApp.Cells[1, i] = dgvExporter.Columns[i - 1].HeaderText;
                //    }
                //    for (int i = 0; i < dgvExporter.Rows.Count ; i++)
                //    {
                //        for (int j = 1; j < dgvExporter.Columns.Count; j++)
                //        {
                //            ExcelApp.Cells[i + 2, j + i] = dgvExporter.Rows[i].Cells[j].Value.ToString();
                //        }
                //    }
                //    ExcelApp.ActiveWorkbook.SaveCopyAs(savefiledialog1.FileName.ToString());
                //    ExcelApp.ActiveWorkbook.Saved = true;
                //    ExcelApp.Quit();
                //    MessageBox.Show("Data is exported!");
                //}
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dgvExporter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ListeStagaire()
        {
            GLB.cnx.ConnectionString = GLB.connexionString;
            dgvExporter.AllowUserToAddRows = false;
            dgvExporter.AllowUserToDeleteRows = false;
            dgvExporter.AllowUserToResizeColumns = false;
            dgvExporter.ReadOnly = true;
            dgvExporter.AllowUserToResizeRows = false;
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
                this.dgvExporter.Rows.Clear();
                while (rd.Read())
                {
                    this.dgvExporter.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5], rd[6], rd[7], rd[8], rd[9], rd[10], rd[11]);
                }
                GLB.cnx.Close();
            }

        }
        private void Exporter_Load(object sender, EventArgs e)
        {
            ListeStagaire();
        }
    }
    
}
