using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_01_uzduotys
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti tris skaičius. Su switch patikrinkite pirmąjį skaičių:
            //ar jis lygus 1: išveskite visų trijų skaičių sumą;
            //ar jis lygus 2: išveskite pirmo ir trečio skaičių skirtumą;
            //ar jis lygus 3: išveskite antro ir trečio skaičių sandaugą.
            Console.WriteLine("Įveskite 3 skaičius");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var trecias = Convert.ToInt32(Console.ReadLine());
            switch (pirmas)
            {
                case 1:
                    Console.WriteLine("{0} + {1} + {2} = (3)", pirmas, antras, trecias, pirmas + antras + trecias);
                    break;
                case 2:
                    Console.WriteLine("{0} - {1} = {2}", pirmas, trecias, pirmas-trecias);
                    break;
                case 3:
                    Console.WriteLine("{0} * {1} = {2}", antras, trecias, antras*trecias);
                    break;
            }
            

        }
    }
}
