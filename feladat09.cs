using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progtetelek_feladatok
{
    internal class feladat09
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> nevnapok = new Dictionary<string, int>() 
            { {"John", 25}, {"Lukács", 7}, {"Doe", 12} };
            int i = 0;
            while (i < nevnapok.Count && nevnapok.Keys.ElementAt(i) != "Lukács")
            {
                i++;
            }
            Console.WriteLine($"Lukács névnapja: {nevnapok.Values.ElementAt(i)}");
        }
    }
}
