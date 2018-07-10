using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_08_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite 3 skaičius");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var trecias = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jūs įvedėte: {0}, {1}, {2}", pirmas, antras, trecias);
            Console.WriteLine("Įvesti skaičiai pakelti kvadratu: {0}, {1}, {2}", 
                Math.Pow(pirmas, 2), Math.Pow(antras, 2), Math.Pow(trecias, 2));
            Console.WriteLine("Įvesti skaičiai pakelti trečiuoju laipsniu: {0}, {1}, {2}",
                Math.Pow(pirmas, 3), Math.Pow(antras, 3), Math.Pow(trecias, 3));
            Console.WriteLine("Įvesti skaičiai padalinti iš 2: {0}, {1}, {2}", (double)pirmas / 2, (double)antras / 2, (double)trecias / 2);

           

        }
    }
}
