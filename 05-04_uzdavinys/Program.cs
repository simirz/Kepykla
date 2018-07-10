using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_04_uzdavinys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite 5 savo pažymius");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var trecias = Convert.ToInt32(Console.ReadLine());
            var ketvirtas = Convert.ToInt32(Console.ReadLine());
            var penktas = Convert.ToInt32(Console.ReadLine());
            var vidurkis = (pirmas + antras + trecias + ketvirtas + penktas) / 5;
            Console.WriteLine();
            Console.WriteLine("Pazymių {0} {1} {2} {3} {4} vidurkis yra {5}", pirmas, antras, trecias, ketvirtas, penktas,vidurkis);
            if (vidurkis >= 5)
            {
                Console.WriteLine("vidurkis {0} >= 5", vidurkis);
            }
        }
    }
}
