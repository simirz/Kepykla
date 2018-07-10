using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite įvesti tris skaičius. Suraskite kuris iš šių skaičių yra maziausias.
            Console.WriteLine();
            {
                Console.WriteLine("Įveskite 3 skaičius");
                var pirmas = Convert.ToInt32(Console.ReadLine());
                var antras = Convert.ToInt32(Console.ReadLine());
                var trecias = Convert.ToInt32(Console.ReadLine());
                if ((pirmas < antras) && (pirmas < trecias))
                {
                    Console.WriteLine("pirmas skaicius maziausias");
                }
                else if ((antras < pirmas) && (antras < trecias))
                {
                    Console.WriteLine("antras skaicius maziausias");
                }
                else if ((trecias < pirmas) && (trecias < antras))
                {
                    Console.WriteLine("trecias maziausias");
                }
            }
        }
    }
}
