using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciai = { 8, 7, 9, 5, 4, 3, 5 };

            Console.WriteLine("Pirma reiksme masyve: {0}", skaiciai[0]);
            Console.WriteLine("Paskutine reiksme masyve: {0}", skaiciai[skaiciai.Length - 1]);
            Console.WriteLine("Nariu skaicius: {0}", skaiciai.Length);
            Console.WriteLine();


            foreach (var skaicius in skaiciai)
            {
                Console.WriteLine(skaicius + " ");
                Console.Write(skaicius + " ");
            }
            Console.WriteLine();
        }
    }
}
