using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progtetelek_feladatok
{
    internal class feladat12
    {
        static void Main(string[] args) 
        {
            int haviForgalom = 100000;
            List<int> napiBevetel = new List<int> { 1000, 2000, 3000, 4000, 5000 };
            List<int> napiKiadas = new List<int> { 500, 1000, 1500, 2000, 2500 };
            int nap = 0;
            for (int i = 0; i < napiBevetel.Count; i++)
            {
                if (napiBevetel[i] < napiKiadas[i])
                {
                    nap = i;
                }
            }
            Console.WriteLine($"Az első olyan nap, amikor a bevétele kisebb, mint a kiadás: {nap + 1}");
        }
    }
}
