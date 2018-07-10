using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite savo pasirinktą skaičių");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("{0}", skaicius*skaicius);
            Console.WriteLine(Math.Pow(skaicius, 2));
            
        }
    }
}
