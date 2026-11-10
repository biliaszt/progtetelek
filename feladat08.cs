using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progtetelek_feladatok
{
    internal class feladat08
    {
        static void Main(string[] args) 
        {
            List<string> honapok = new List<string>() { "január", "február", "március", "április", "május", "június", "július", "augusztus", "szeptember", "október", "november", "december" };
            Console.Write("Adjon meg egy hónapot: ");
            string bevitel = Console.ReadLine();
            int sorszam = 0;
            for (int i = 0; i < honapok.Count; i++)
            {
                if (honapok[i] == bevitel)
                {
                    sorszam = i + 1;
                    break;
                }
            }
            Console.WriteLine($"A megadott hónap sorszáma: {sorszam}");
        }
    }
}
