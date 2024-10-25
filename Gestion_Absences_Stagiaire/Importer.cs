using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Absences_Stagiaire
{
    public partial class Importer : Form
    {
        public Importer()
        {
            InitializeComponent();
        }

        private void Importer_Load(object sender, EventArgs e)
        {

        }

        private void btnImporter_Click(object sender, EventArgs e)
        {
            DataTableCollection TAB;
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string test = "";
                    test = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            TAB = result.Tables;

                            foreach (DataTable table in TAB)
                            {
                                test += table.TableName;
                                DataTable dt = TAB[table.TableName];
                                //dataGridView1.DataSource = dt;
                                if (dt != null)
                                {
                                    List<Stagiaire1> stagiaires = new List<Stagiaire1>();
                                    for (int i = 0; i < dt.Rows.Count; i++)
                                    {
                                        Stagiaire1 stagiaire = new Stagiaire1();
                                        stagiaire.Numero_Stagiaire = dt.Rows[i]["Numero_Stagiaire"].ToString();
                                        stagiaire.Nom = dt.Rows[i]["Nom"].ToString();
                                        stagiaire.Prenom = dt.Rows[i]["Prenom"].ToString();
                                        stagiaire.Cin = dt.Rows[i]["Cin"].ToString();
                                        stagiaire.Nom_Arabe = dt.Rows[i]["Nom_Arabe"].ToString();
                                        stagiaire.Prenom_Arabe = dt.Rows[i]["Prenom_Arabe"].ToString();
                                        stagiaire.Genre = dt.Rows[i]["Genre"].ToString();
                                        stagiaire.Date_Naissance = dt.Rows[i]["Date_Naissance"].ToString();
                                        stagiaire.Adresse = dt.Rows[i]["Adresse"].ToString();
                                        stagiaire.Numero_Telephone = dt.Rows[i]["Numero_Telephone"].ToString();
                                        stagiaire.Email = dt.Rows[i]["Email"].ToString();
                                        stagiaire.Stagiare_Fomation = dt.Rows[i]["Stagiare_Fomation"].ToString();
                                        stagiaire.Id_Groupe = dt.Rows[i]["Id_Groupe"].ToString();
                                        stagiaire.Id_Abs = dt.Rows[i]["Id_Abs"].ToString();

                                        stagiaires.Add(stagiaire);
                                    }
                                    dgvImporter.DataSource = stagiaires;
                                }


                            }

                            //for (int i = 0; i < dgvImporter.Rows.Count; i++)
                            //{
                            //    if (ConnectionState.Open == GLB.cnx.State)
                            //    {
                            //        GLB.cnx.Close();
                            //    }
                            //    GLB.cnx.Open();
                            //    GLB.cmd.CommandText = $"insert into dbo.Stagiaire values({dgvImporter.Rows[i].Cells[0].Value},'{ dgvImporter.Rows[i].Cells[1].Value}','{ dgvImporter.Rows[i].Cells[2].Value}','{ dgvImporter.Rows[i].Cells[3].Value}','{ dgvImporter.Rows[i].Cells[4].Value}','{ dgvImporter.Rows[i].Cells[5].Value}','{ dgvImporter.Rows[i].Cells[6].Value}','{ dgvImporter.Rows[i].Cells[7].Value}','{ dgvImporter.Rows[i].Cells[8].Value}','{ dgvImporter.Rows[i].Cells[9].Value}','{ dgvImporter.Rows[i].Cells[10].Value}','{ dgvImporter.Rows[i].Cells[11].Value}','{ dgvImporter.Rows[i].Cells[12].Value}','{ dgvImporter.Rows[i].Cells[13].Value}');";
                            //    GLB.cmd.Connection = GLB.cnx;
                            //    GLB.cmd.ExecuteNonQuery();
                                

                            //    GLB.cnx.Close();


                            //}
                            
                        }
                        MessageBox.Show(dgvImporter.Rows.Count.ToString()+" Stagiaire ajoutés");
                    }
                }


                //OpenFileDialog openFileDialog1 = new OpenFileDialog();
                //string file = ""; //variable for the Excel File Location
                //DataTable dt = new DataTable(); //container for our excel data
                //DataRow row;
                //DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
                //if (result == DialogResult.OK) // Check if Result == "OK".
                //{
                //    file = openFileDialog1.FileName; //get the filename with the location of the file
                //    try
                //    {
                //        //Create Object for Microsoft.Office.Interop.Excel that will be use to read excel file

                //        Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

                //        Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(file);

                //        Microsoft.Office.Interop.Excel._Worksheet excelWorksheet = excelWorkbook.Sheets[1];

                //        Microsoft.Office.Interop.Excel.Range excelRange = excelWorksheet.UsedRange;

                //        int rowCount = excelRange.Rows.Count; //get row count of excel data

                //        int colCount = excelRange.Columns.Count; // get column count of excel data

                //        //Get the first Column of excel file which is the Column Name

                //        for (int i = 1; i <= rowCount; i++)
                //        {
                //            for (int j = 1; j <= colCount; j++)
                //            {
                //                dt.Columns.Add(excelRange.Cells[i, j].Value2.ToString());
                //            }
                //            break;
                //        }

                //        //Get Row Data of Excel

                //        int rowCounter; //This variable is used for row index number
                //        for (int i = 2; i <= rowCount; i++) //Loop for available row of excel data
                //        {
                //            row = dt.NewRow(); //assign new row to DataTable
                //            rowCounter = 0;
                //            for (int j = 1; j <= colCount; j++) //Loop for available column of excel data
                //            {
                //                //check if cell is empty
                //                if (excelRange.Cells[i, j] != null && excelRange.Cells[i, j].Value2 != null)
                //                {
                //                    row[rowCounter] = excelRange.Cells[i, j].Value2.ToString();
                //                }
                //                else
                //                {
                //                    row[i] = "";
                //                }
                //                rowCounter++;
                //            }
                //            dt.Rows.Add(row); //add row to DataTable
                //        }

                //        dgvImporter.DataSource = dt; //assign DataTable as Datasource for DataGridview

                //        //close and clean excel process
                //        GC.Collect();
                //        GC.WaitForPendingFinalizers();
                //        Marshal.ReleaseComObject(excelRange);
                //        Marshal.ReleaseComObject(excelWorksheet);
                //        //quit apps
                //        excelWorkbook.Close();
                //        Marshal.ReleaseComObject(excelWorkbook);
                //        excelApp.Quit();
                //        Marshal.ReleaseComObject(excelApp);
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show(ex.Message);
                //    }
                //}
            }
        }
    }
}
