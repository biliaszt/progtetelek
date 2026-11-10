using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progtetelek_feladatok
{
    internal class feladat03
    {
        static void Main(string[] args)
        {
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            int osszeg = 0;
            for (int i = 0; i < n + 1; i++)
            {
                osszeg += i;
            }
            Console.WriteLine(osszeg);
        }
    }
}
