using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite įvesti du skaičius. Patikrinkite (naudojant 4 atskirus if’us):
            // ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0;
            //  ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5;
            // ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20;
            //ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100;
            Console.WriteLine("Įveskite 2 skaičius");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.1");
            if ((pirmas > antras) || (pirmas == 0))
            {
                Console.WriteLine("{0} > {1}, arba {0} = 0", pirmas, antras);
            }
        }
    }
}
