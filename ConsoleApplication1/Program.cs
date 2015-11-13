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

            et = new etudiant("ABC01", "Cooke", "André", 60);
            etudiantListe.Add(et);

            et = new etudiant("ABC02", "Asselin", "Maxime");
            etudiantListe.Add(et);


            //Console.WriteLine(etudiantListe[0].ToString());
            //Console.WriteLine(etudiantListe[1].ToString());
            //Console.WriteLine(etudiantListe[2].ToString());
            //etudiantListe.Add(ajouterEtudiant());
            ajouterEtudiant();

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

        private static object ajouterEtudiant() // ajoute un etudiant
        {
            etudiant et = new etudiant();
            string idEtudiant;
            string nomEtudiant;
            string prenomEtudiant;
            string noteEtudiant;
            int valNote;
            
            Console.Clear();
            Console.WriteLine("Exercise Etudiant");
            Console.WriteLine("ID de l'etudiant :");
            idEtudiant = Console.ReadLine().ToUpper();

            Console.WriteLine("Nom de l'etudiant :");
            nomEtudiant = Console.ReadLine().ToUpper();

            Console.WriteLine("Prénom de l'etudiant :");
            prenomEtudiant = Console.ReadLine().ToUpper();

            Console.WriteLine("Note de l'etudiant :");
            noteEtudiant = Console.ReadLine().ToUpper();

            bool noteValid = Int32.TryParse(noteEtudiant, out valNote);
            if (noteValid == false)
            {
                Console.WriteLine("conversion de '{0}' a échouer.", noteEtudiant);
            }
            

            et = new etudiant(idEtudiant, nomEtudiant, prenomEtudiant, valNote);

            Console.WriteLine(et.ToString());

            return et;
            

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
