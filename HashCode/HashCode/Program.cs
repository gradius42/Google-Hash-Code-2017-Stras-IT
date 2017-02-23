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
                         
                        int inter = 9999;
                        int pos = -1;
                        int j = 0;
                        List<int> dejaTest = new List<int>();
                        do
                        {
                            pos = -1;
                            for (; j < ep.latCache.Length; j++)
                            {
                                if (ep.latCache[j] < inter && ep.latCache[j] != 0 && !dejaTest.Contains(j))
                                {
                                    pos = j;
                                    inter = ep.latCache[j];
                                    dejaTest.Add(j);
                                }
                            }
                        } while (!caches[pos].ajouteVideo(i) && pos != -1);
                    }
                }
            }
        }
    }
}
