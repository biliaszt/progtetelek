using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progtetelek_feladatok
{
    internal class feladat07
    {
        static void Main(string[] args) 
        {
            int[] tomb = new int[] { 2, 4, 5, 6, 7, 8, 9, 18};
            bool vanE = false;
            int i = 0;
            while (i < tomb.Length && tomb[i] % 9 != 0)
            {
                i++;
            }
            Console.WriteLine($"Az első 9-cel osztható elem: {tomb[i]}");
        }
    }
}
