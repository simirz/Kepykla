using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_06_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite tris skaičius");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var trecias = Convert.ToInt32(Console.ReadLine());
            //ar pirmas skaičius didesnis už antrą;
            // ar antras skaičius didesnis už trečią;
            // ar trečias skaičius skaičius didesnis už pirmą;
            // ar pirmi du skaičiai lygūs;
            if (pirmas > antras)
            {
                Console.WriteLine("{0} > {1}", pirmas, antras);
            }
            else if (antras > pirmas)
            {
                Console.WriteLine("{0} > {1}", antras, trecias);
            }
            else if (trecias > pirmas)
            {
                Console.WriteLine("{0} > {1}", trecias, pirmas);
                       }
            else if (pirmas == antras)
            {
                Console.WriteLine("{0} = {1}", pirmas, antras);
            }




        }
    }
}
