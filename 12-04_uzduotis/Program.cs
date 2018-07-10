using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sukurkite string tipo kintamąjį.
            //Prie jo vis pridėkite vartotojo įrašomus skirtingus žodžius. 
            //Tačiau jei vartotojas įrašytų “exit” - baigti ciklą.
            //Baigus vykdyti ciklą turi būti išvestas string kintamasis prie kurio vis buvo pridedami skirtingi žodžiai.

            var sakinys = " ";

            while (true)
            {
                Console.Write("Irasykite zodi arba exit: ");
                var atsakymas = Console.ReadLine();
                if (atsakymas != "exit")
                {
                    sakinys += atsakymas + " ";

                }
                else
                {
                    break;
                }
                

            }

            Console.WriteLine(sakinys);
        }
    }
}
