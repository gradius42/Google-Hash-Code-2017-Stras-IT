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
        public int id;
        public static int capaciteMax;
        public int stockageActuel = 0;
        public List<int> lVideo = new List<int>();

        public Cache(int i, int cap)
        {
            id = i;
            capaciteMax = cap;
        }

        public void ajouteVideo(int num)
        {
            if (!lVideo.Contains(num))
                lVideo.Add(num);
        }

        public void supprimeVideo(int num)
        {
            lVideo.Remove(num);
        }
    }
}
