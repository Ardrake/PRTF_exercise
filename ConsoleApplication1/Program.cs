using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //menu();

            List<etudiant> etudiantListe = new List<etudiant>();

            etudiant et = new etudiant();

            //et.idEtudiant = "ABC03";
            //et.nomEtudiant = "Cooke";
            //et.prenomEtudiant = "André";
            //et.noteEtudiant = 80;
            //etudiantListe.Add(et);

            et = new etudiant("ABC01", "Cooke", "Jonathan", 60);
            etudiantListe.Add(et);

            et = new etudiant("ABC02", "Asselin", "Maxime");
            etudiantListe.Add(et);


            Console.WriteLine(etudiantListe[0].ToString());
            Console.WriteLine(etudiantListe[1].ToString());

        }
        private static void menu() // affichage du menu
        {
            Console.Clear();
            Console.WriteLine("Exercise Etudiant");
            Console.WriteLine("1- entrer un nouvel étudiant");
            Console.WriteLine("2- afficher un étudiant");
            Console.WriteLine("3- afficher tous les étudiants");
            Console.WriteLine("4- Quitter");
        }



        class etudiant
        {
            private string idEtudiant;
            private string nomEtudiant;
            private string prenomEtudiant;
            private int noteEtudiant;

            public etudiant()
            {
                idEtudiant = "";
                nomEtudiant = "";
                prenomEtudiant = "";
                noteEtudiant = 0;
            }

            public etudiant(string a, string b, string c)
            {
                idEtudiant = a;
                nomEtudiant = b;
                prenomEtudiant = c;
                noteEtudiant = 0;
            }

            public etudiant(string a, string b, string c, int d)
            {
                idEtudiant = a;
                nomEtudiant = b;
                prenomEtudiant = c;
                noteEtudiant = d;
            }

            public string Nom
            {
                get { return nomEtudiant; }
                set { nomEtudiant = value; }
            }
            public string Prenom
            {
                get { return prenomEtudiant; }
                set { prenomEtudiant = value; }
            }

            public override string ToString()
            {
                return idEtudiant + " " + prenomEtudiant + " " + nomEtudiant + " " + noteEtudiant;
            }

        }
    }
}
