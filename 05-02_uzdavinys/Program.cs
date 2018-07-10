using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02_uzdavinys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite savo amžių");
            var amzius = Convert.ToInt32(Console.ReadLine());
            if (amzius >= 18)
            {
                Console.WriteLine("Jūs galite balsuoti");
            }
        }
    }
}
