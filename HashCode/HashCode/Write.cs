using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode
{
    class Write
    {
        static void writeOutData(String s)
        {
            File.Create("./"+ s);
            using (StreamWriter outputFile = new StreamWriter("./"+s))
            {
                outputFile.Write("" + Cache.nbUsed + "\n");

                foreach (Cache c in Program.caches)
                {
                    if (c.used)
                    {
                        string line = "" + c.id;
                        
                        for(int i = 0; i < c.lVideo.Count; i++)
                        {
                            line += " " + c.lVideo[i];
                        }

                        line += "\n";

                        outputFile.Write(line);
                    }

                }
            }
        }

    }
}
