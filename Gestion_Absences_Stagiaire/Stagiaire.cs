using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Absences_Stagiaire
{
    public class Stagiaire
    {
        private static long num;

        public static long Num { get => num; set => num = value; }
        public static string Nom { get => nom; set => nom = value; }
        public static string Prenom { get => prenom; set => prenom = value; }
        public static string Libelle_Groupe1 { get => Libelle_Groupe; set => Libelle_Groupe = value; }

        private static string nom;
        private static string prenom;
        private static string Libelle_Groupe;

        public Stagiaire(long n,string nom,string prenom,string libelle_grp)
        {
            Num = n;
            Nom = nom;
            Prenom = prenom;
            Libelle_Groupe = libelle_grp;
        }

    }
}
