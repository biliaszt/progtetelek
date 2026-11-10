using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progtetelek_feladatok
{
    internal class feladat06
    {
        static void Main(string[] args) 
        {
            List<int> homSzamok = new List<int>() { 27, 25, 23, 22, 21, 17, 16, 10, 12};
            bool monotonE = true;
            for (int i = 0; i < homSzamok.Count; i++)
            {
                if (homSzamok[i] > homSzamok[i] +1)
                {
                    monotonE = false;
                }
                else
                {
                    monotonE = true;
                }
            }
            if (monotonE == true)
            {
                Console.WriteLine("Nem monoton");
            }
            else
            {
                Console.WriteLine("Monoton");
            }
        }
    }
}
