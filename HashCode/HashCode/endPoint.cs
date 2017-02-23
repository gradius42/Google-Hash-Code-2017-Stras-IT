using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode
{
    class endPoint
    {
        public int nbCache { get; set; }
        public int[,] latCache { get; set; }
        public int latDC { get; set; }
        public int[] video { get; set; }
        public int priorite { get; set; }
        public int id { get; set; }

        public endPoint(int id, int nbCache, int[,] latCache, int latDC, int[] video)
        {
            this.id = id;
            this.nbCache = nbCache;
            this.latCache = latCache;
            this.latDC = latDC;
            this.video = video;
        }

        ~endPoint()
        {

        }

        public static void listEndPointPriorise()
        {
            foreach (endPoint e in Program.EP)
            {
                int reqVideo = 0;
                for (int i = 0; i < e.video.Length; i++)
                {
                    reqVideo += e.video[i];
                }
                e.priorite = e.latDC * reqVideo;
            }
        }

        public static int calculMoyenne()
        {
            int m = 0;
            foreach (endPoint e in Program.EP)
            {
                int reqVideo = 0;
                for (int i = 0; i < e.video.Length; i++)
                {
                    reqVideo += e.video[i];
                }
                m += reqVideo;
            }
            m = m / Program.EP.Count;
            return m;
        }
    }
}
