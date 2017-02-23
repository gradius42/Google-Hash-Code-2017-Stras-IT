using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode
{
    class Video
    {
        public static int nbVideo = 0;

        public int number;
        public int taille; // Mb

        public Video(int t) {
            number = nbVideo++;
            taille = t;
        }

    }
}
