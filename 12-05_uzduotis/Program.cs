using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_05_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Irasykite skaiciu: ");
                var a = Convert.ToInt32(Console.ReadLine());
                if (a % 9 == 0) 
                {
                    break;
                }


            }


            Console.Write("Irasykite skaiciu: ");
            var b = Convert.ToInt32(Console.ReadLine());

            while (b % 9 != 0)
            {
                Console.Write("Irasykite skaiciu: ");
                b = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

}
