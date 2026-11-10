using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progtetelek_feladatok
{
    internal class feladat04
    {
        static void Main(string[] args)
        {
            List<int> evvegi = new List<int> { 5, 5, 5, 5, 4, 5, 5, 5};
            bool kitunoE = true;
            for (int i = 0; i < evvegi.Count; i++)
            {
                if (evvegi[i] < 5)
                {
                    kitunoE = false;
                }
            }
            if (kitunoE == true)
            {
                Console.WriteLine("A tanuló kitűnő.");
            }
            else
            {
                Console.WriteLine("A tanuló nem kitűnő.");
            }
        }
    }
}
