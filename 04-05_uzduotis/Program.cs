using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_05_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite bet kokį sveikąjį skaičių");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            var skaicius1 = 1;
            Console.WriteLine("{0} * {1} = {2}", skaicius, skaicius1, skaicius* skaicius1++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, skaicius1, skaicius * skaicius1++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, skaicius1, skaicius * skaicius1++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, skaicius1, skaicius * skaicius1++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, skaicius1, skaicius * skaicius1++);
        }
    }
}
