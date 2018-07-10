using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_06_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite tris skaičius");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var trecias = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Įvestų skaičių {0}, {1}, {2} vidurkis: {3}.", pirmas, antras, trecias,
                (double)(pirmas + antras + trecias)/3);

        }
    }
}
