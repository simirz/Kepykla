using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_05_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite skaičių");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            var daugyba = 1;

            Console.WriteLine();
            if (skaicius % 5 == 0)
            {
                Console.WriteLine("{0} * {1} = {2}", skaicius, daugyba, skaicius * daugyba++);
                Console.WriteLine("{0} * {1} = {2}", skaicius, daugyba, skaicius * daugyba++);
                Console.WriteLine("{0} * {1} = {2}", skaicius, daugyba, skaicius * daugyba++);
                Console.WriteLine("{0} * {1} = {2}", skaicius, daugyba, skaicius * daugyba++);
                Console.WriteLine("{0} * {1} = {2}", skaicius, daugyba, skaicius * daugyba++);
            }
            if (skaicius % 2 == 0)
            {
                Console.WriteLine(Math.Pow(skaicius, 5));
            }
            if (skaicius % 4 != 0)
            {
                Console.WriteLine("Įveskite naują skaiciu");
            }
            var naujas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Skaičių {0} ir {1} suma yra {2}", skaicius, naujas, skaicius + naujas);
            Console.WriteLine("Skaiciu {0} ir {1} sandauga yra {2}", skaicius, naujas, skaicius * naujas);
        }
    }
}
