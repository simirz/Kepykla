using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite įvesti tris skaičius. Suraskite kuris iš šių skaičių yra didžiausias.
            Console.WriteLine("Įveskite 3 skaičius");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var trecias = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if ((pirmas > antras) && (pirmas > trecias))
            {
                Console.WriteLine("Pirmas skaicius didziausias");
            }
            if ((antras > pirmas) && (antras > trecias))
            {
                Console.WriteLine("Antras skaicius didziausias");
            }
            if ((trecias > pirmas) && (trecias > antras))
            {
                Console.WriteLine("Trecias skaicius didziausias");
            }
        }
    }
}
