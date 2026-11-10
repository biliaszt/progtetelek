using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progtetelek_feladatok
{
    internal class feladat05
    {
        static void Main(string[] args)
        {
            List<string> lnapok = new List<string>() { "Hétfő", "Kedd", "Szerda", "Csütörtök", 
            "Péntek", "Szombat", "Vasárnap"};
            Console.Write("Adjon meg egy napot: ");
            string nap = Console.ReadLine();
            for (int i = 0; i < lnapok.Count; i++)
            {
                if (lnapok[i] == nap)
                {
                    Console.WriteLine("Ez egy hét napja.");
                }
                else
                {
                    Console.WriteLine("Ez nem egy hét napja.");
                }
            }
        }
    }
}
