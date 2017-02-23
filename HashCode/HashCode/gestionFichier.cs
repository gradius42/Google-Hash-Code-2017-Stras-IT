using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode
{
    static class gestionFichier
    {
            // Méthode

            // --------------
            // Lire fichier
            // --------------

        public static void lectureFichier(string adresseFichier) // "C:\Users\Anacin\Downloads\kittens.in"
        {
            string[] text = (System.IO.File.ReadAllText(@"C:\Users\Anacin\Downloads\kittens.in")).Split('\n');
            string[] ligne1 = text[0].Split(' ');
            string[] ligne2 = text[1].Split(' ');
            string ligneCouranteEP;

                // ---------------------------------
                // Création des vidéos dans le main
                // ---------------------------------

            foreach (string s in ligne2)
                Program.videos.Add(new Video(int.Parse(s)));

                // ---------------------------------
                // Création des caches
                // ---------------------------------

            for (int i = 0; i < int.Parse(ligne1[3]);)
                Program.caches.Add(new Cache(i++, int.Parse(ligne1[4])));

                // ---------------------------------
                // Création des EP
                // ---------------------------------
            
            int indiceLigneCourante = 2;
            List<int> nbLigneCacheCourant = new List<int>();
            int numeroEPActuel = 0;

            for (int i = 0; i < int.Parse(ligne1[1]); i++) { // Pour chaque endPoint

                foreach (int integer in nbLigneCacheCourant) // Ligne courante += ligneCacheCourante
                    indiceLigneCourante += integer;
                ligneCouranteEP = text[indiceLigneCourante];

                nbLigneCacheCourant.Add(int.Parse(ligneCouranteEP.Split(' ')[1])); // ADD nombre cache du EP courant

                for (int j = indiceLigneCourante; j < nbLigneCacheCourant.Last() + indiceLigneCourante; j++) // Chaque cache d'un EP
                {
                    Program.EP.Add(new endPoint(
                        numeroEPActuel++,
                        int.Parse(ligneCouranteEP.Split(' ')[1]),
                        new int[int.Parse(ligne1[0])],
                        int.Parse(ligneCouranteEP.Split(' ')[0]),
                        new int[int.Parse(ligneCouranteEP.Split(' ')[1])])
                        );
                    for (int k = 0; k < int.Parse(ligneCouranteEP.Split(' ')[1]); k++)
                        Program.EP.Last().latCache[k] = int.Parse(text[indiceLigneCourante + k].Split(' ')[1]);
                }
            }
        } // Fin méthode lecture
    } // FIn class
}
