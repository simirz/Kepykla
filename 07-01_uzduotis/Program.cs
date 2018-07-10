using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite du sveikuosius skaicius");
            var skaicius1 = Convert.ToInt32(Console.ReadLine());
            var skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //ar pirmas skaičius didesnis už antrą skaičių;
            //ar antras skaičius didesnis už pirmą;
            //jei niekas neatitinka - tuomet skaičiai lygūs.
            Console.WriteLine();
            if (skaicius1 > skaicius2)
            {
                Console.WriteLine("{0} > {1}", skaicius1, skaicius2);
                            }
            else if (skaicius2 > skaicius1)
            {
                Console.WriteLine("{0} > {1}", skaicius2, skaicius1);
            }
             else
            { 
                Console.WriteLine("{0} = {1}", skaicius1, skaicius2);
            }
        }
    }
}