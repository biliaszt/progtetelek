using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progtetelek_feladatok
{
    internal class feladat11
    {
        static void Main(string[] args) 
        {
            List<int> szamok = new List<int>() { -6, 3, 8, -1, 0 };
            for (int i = 0; i < szamok.Count; i++)
            {
                if (szamok[i] < -5)
                {
                    Console.WriteLine(szamok[i]);
                }
            }
        }
    }
}
