using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_03_uzdavinys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parašykite bet kokį teigiamą skaičių");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            if (skaicius < 0)
            {
                Console.WriteLine("SAKIAU IVESTI TEIGIAMĄ!!!!");
            }
            if (skaicius > 0)
            {
                Console.WriteLine("Puiku");
            }
            if (skaicius % 2 == 0)
            {
                Console.WriteLine("skaičius {0} lyginis", skaicius);
            }
            if (skaicius % 4 == 0)
            {
                Console.WriteLine("skaičius {0} dalinasi is 4", skaicius);
            }
            if (skaicius > 10)
            {
                Console.WriteLine("skaicius {0} > 10", skaicius);
            }
        }
    }
}
