using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progtetelek_feladatok
{
    internal class feladat01
    {
        static void Main(string[] args)
        {
            List<double> latlagok = new List<double> { 4.7, 3.5, 2.6, 5.0, 4.2, 2.3 };
            double osszeg = 0;
            double atlag = 0;
            for (int i = 0; i < latlagok.Count; i++)
            {
                osszeg += latlagok[i];
            }
            atlag = osszeg / latlagok.Count;
            Console.WriteLine($"Osztályátlag: {Math.Round(atlag, 2)}");
        }
    }
}
