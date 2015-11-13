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

            int valeurChoix = 0;

            while (valeurChoix != 8)
            {
                valeurChoix = menu();

                if (valeurChoix == 5)
                    return;

                //Prendre action / loadé le module correspondant
                if (valeurChoix == 1)  // Option 1 - Ajouter Etudiant
                {
                    etudiantListe.Add(ajouterEtudiant());
                }
                else if (valeurChoix == 2) // Option 2 - Afficher un Étudiant 
                {
                    Console.WriteLine("Afficher etudiant");
                }
                else if (valeurChoix == 3) // Option 3 Modifier un Étudiant 
                {
                    Console.WriteLine("Afficher Modifier un Étudiant");
                }
                else if (valeurChoix == 4) // Option 4 - Afficher tous les Étudiants 
                {
                    Console.WriteLine("Afficher tous les Étudiants");
                }
                else if (valeurChoix == 5) // Option 5 - Sortir du programme 
                {
                    Console.WriteLine("Quitter");
                }

            }
            //Console.WriteLine(etudiantListe[0].ToString());
            //Console.WriteLine(etudiantListe[1].ToString());
            //Console.WriteLine(etudiantListe[2].ToString());

        }

        private static int menu() // affichage du menu
        {
            Console.Clear();
            Console.WriteLine("Exercise Etudiant");
            Console.WriteLine("1- entrer un nouvel étudiant");
            Console.WriteLine("2- afficher un étudiant");
            Console.WriteLine("3- modifier un étudiant");
            Console.WriteLine("4- afficher tous les étudiants");
            Console.WriteLine("5- Quitter");

            int valeurChoix;

            try
            {
                // recup le nombre et faire un parse du resultat
                valeurChoix = int.Parse(Console.ReadLine());
                return valeurChoix;
            }
            catch
            {
                //erreur dans le nombre
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erreur SVP Sélectionnez un nombre");
                Console.ReadKey();
                Console.ResetColor();
                return 9;
            }
        }

        private static etudiant ajouterEtudiant() // ajoute un etudiant
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
            if (!noteValid)
            {
                Console.WriteLine("conversion de '{0}' a échouer.", noteEtudiant);
            }

            et = new etudiant(idEtudiant, nomEtudiant, prenomEtudiant, valNote);

            return et;
        }

        private static void afficherEtudiant() // affiche un etudiant
        {
            string idEtudiant;
            Console.WriteLine("indiquer le ID de l'etudiant :");
            idEtudiant = Console.ReadLine().ToUpper();
            
            Console.WriteLine("Étudiant trouvé : {0}","code");

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

            public string note
            {
                get { return noteEtudiant.ToString(); }
            }

            public override string ToString()
            {
                return idEtudiant + " " + prenomEtudiant + " " + nomEtudiant + " " + noteEtudiant;
            }

        }
    }
}
