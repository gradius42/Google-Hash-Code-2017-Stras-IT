using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode
{

    class Cache
    {
        public static int nbCache;
        public static int nbUsed = 0;

        public int id;
        public bool used = false;
        public static int capaciteMax;
        public int stockageActuel = 0;
        public List<int> lVideo = new List<int>();

        public Cache(int i, int cap)
        {
            id = i;
            capaciteMax = cap;
        }

        public bool ajouteVideo(int num)
        {
            if (!lVideo.Contains(num) && capaciteMax >= stockageActuel + Program.videos[num].taille)
            {
                lVideo.Add(num);
                stockageActuel += Program.videos[num].taille;

                if (!used)
                {
                    used = true;
                    nbUsed++;
                }

                return true;
            }
            else
            {
                return false;
            }

        }

        public bool supprimeVideo(int num)
        {
            if (lVideo.Contains(num))
            {
                lVideo.Remove(num);
                stockageActuel -= Program.videos[num].taille;

                if(stockageActuel == 0)
                {
                    nbUsed--;
                    used = false;
                }

                return true;
            }

            return false;
            
        }

    }
}
