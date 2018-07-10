using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_06_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius1 = 35;
            var skaicius2 = skaicius1 / 10;
            var skaicius3 = skaicius1 % 10;
            Console.WriteLine(skaicius2*skaicius3);

        }
    }
}
