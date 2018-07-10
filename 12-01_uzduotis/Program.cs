using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite teigiamą skaičiu");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            while (skaicius > 0)
            {
                Console.WriteLine(skaicius);
                skaicius--;
            }
        }
    }
}
