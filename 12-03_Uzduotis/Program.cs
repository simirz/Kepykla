using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_03_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("Iveskite skaiciu");
                var pirmas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Iveskite dar viena skaiciu");
                var antras = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} + {1} = {2}", pirmas, antras, pirmas + antras);
                Console.WriteLine("{0} - {1} = {2}", pirmas, antras, pirmas - antras);
                Console.WriteLine("{0} * {1} = {2}", pirmas, antras, pirmas * antras);
                Console.WriteLine("{0} / {1} = {2}", pirmas, antras, pirmas / antras);
                //ar norite testi?
                //ivesti kintamaji
                //tikrinti
                //jeiblogas: break

                Console.WriteLine("Ar norite testi? taip/ne");
                var atsakymas = Console.ReadLine();
                if (atsakymas != "taip")
                {
                    break;
                }

            }
        }
    }
}
