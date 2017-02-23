using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode
{
    class Program
    {
        public static List<Video> videos = new List<Video>();
        public static List<endPoint> EP = new List<endPoint>();
        public static List<Cache> caches = new List<Cache>();
        
        static void Main(string[] args)
        {
            // Lancement de la fonction qui lis le fichier

            // Tri de la liste EP
            endPoint.listEndPointPriorise();
            EP = EP.OrderBy(e => e.priorite).ToList();
            int moyenne = endPoint.calculMoyenne();

            foreach(endPoint ep in EP)
            {
                for(int i = 0; i<ep.video.Length; i++)
                {
                    if(ep.video[i] > moyenne)
                    {

                    }
                }
            }
        }
    }
}
