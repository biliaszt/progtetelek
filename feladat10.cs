using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progtetelek_feladatok
{
    internal class feladat10
    {
        static void Main(string[] args) 
        {
            int[] evszamok = new int[] { 1867, 1944, 2026, 895, 1920, 1222};
            for (int i = 0; i < evszamok.Length; i++)
            {
                if (evszamok[i] == 1222)
                {
                    Console.WriteLine($"Az Aranybulla kiadásának évszáma szerepel a tömbben, sorszáma: {i+1}. darab");
                }
            }
        }
    }
}
