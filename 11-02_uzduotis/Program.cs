using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parašyti for, kuris išvestų kas antrą skaičių
            //pradedant 0 ir baigiant 15.
            //Kiekvieną skaičių išvesti toje pačioje eilutėje, po kiekvieno skaičiaus dedant tarpą.
            
            for (int i = 0; i <= 15; i+=2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
