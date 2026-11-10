using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progtetelek_feladatok
{
    internal class feladat02
    {
        static void Main(string[] args)
        {
            List<string> betuk = new List<string> { "h", "e", "l", "l", "o"};
            string fuzve = string.Join("", betuk);
            Console.WriteLine(fuzve);
        }
    }
}
