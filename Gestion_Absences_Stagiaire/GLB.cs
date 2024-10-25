using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Gestion_Absences_Stagiaire
{
    class GLB
    {
        //public static string connexionString = @"Data Source=|DataDirectory|\ISFO";
        //public static string connexionString = @"Data Source=DESKTOP-JITTF6E\SQLEXPRESS01;Initial Catalog=ISFO;Integrated Security=True";
        public static string connexionString = @"Data Source=DESKTOP-7M7U6V6;Initial Catalog=ISFO;Integrated Security=True";
        public static SqlConnection cnx = new SqlConnection(connexionString);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlCommand cmd1= new SqlCommand();
        public static SqlDataAdapter da = new SqlDataAdapter();
        public static SqlDataReader dr;
        public static SqlDataReader dr1;
        

        public static DataSet ds= new DataSet();
        public static DataSet dsA1 = new DataSet();
        public static DataSet dsA2 = new DataSet();

        public static DataTable dtStagiaire = new DataTable();
        public static DataTable dtGroupe = new DataTable();
        public static DataTable dtGroupeA1 = new DataTable(); 
        public static DataTable dtGroupeA2 = new DataTable();
        public static DataTable dtStagiaire1 = new DataTable();
        public static DataTable dtImprimer = new DataTable();




    }
}
