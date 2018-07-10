using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_07_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new int[] { 4, 8, 6, 3, 2 };
            // arba var suma = skaiciai.Sum();
            var suma = 0;
            foreach (var skaicius in skaiciai)
            {
                suma += skaicius;
            }
            Console.WriteLine(suma);

            
        }

    }
}
