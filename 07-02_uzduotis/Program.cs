using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite vieną skaičių");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            //ar skaičius neigiamas;
            //ar skaičius teigiamas;
            //ar skaičius lygus 0.
            if (skaicius < 0)
            {
                Console.WriteLine("{0} < 0", skaicius);
            }
            else if (skaicius > 0)
            {
                Console.WriteLine("{0} > 0", skaicius);
            }
            else
                Console.WriteLine("{0}=0", skaicius);


        }
    }
}
