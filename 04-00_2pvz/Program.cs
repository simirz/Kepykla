using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_00_2pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite skaičius iki 5");
            var pirmas = Convert.ToUInt32(Console.ReadLine());
            var antras = Convert.ToUInt32(Console.ReadLine()); ;
            var trecias = Convert.ToUInt32(Console.ReadLine()); ;
            var ketvirtas = Convert.ToUInt32(Console.ReadLine()); ;
            var penktas = Convert.ToUInt32(Console.ReadLine()); ;
            Console.WriteLine("{0} ir {1}", pirmas, penktas);
            Console.WriteLine("{0} + {1} + {2} = {3}", antras, trecias, ketvirtas, antras+trecias+ketvirtas);

            

        }
    }
}
