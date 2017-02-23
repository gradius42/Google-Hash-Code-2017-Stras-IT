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
        public int[,] video { get; set; }

        public endPoint(int nbCache, int[,] latCache, int latDC, int[,] video)
        {
            this.nbCache = nbCache;
            this.latCache = latCache;
            this.latDC = latDC;
            this.video = video;
        }

        ~endPoint()
        {

        }
    }
}
