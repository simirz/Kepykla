using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite gautą pažymį");
            var pazymys = Convert.ToInt32(Console.ReadLine());
            //jei 10 - išveskite “Puikiai”;
            //jei 8 - 9 - išveskite “Labai gerai”;
            //jei 5 - 7 - išveskite “Patenkinamai”;
            // jei 3 - 4 - išveskite “Prastai”;
            // jei 1 - 2 - išveskite “Labai blogai”;

            if (pazymys == 10)
            {
                Console.WriteLine("Puikiai");
            }
            else if (pazymys >= 8)
            {
                Console.WriteLine("Labai gerai");
            }
            else if (pazymys >= 5)
            {
                Console.WriteLine("Patenkinamai");
            }
            else if (pazymys >= 3)
            {
                Console.WriteLine("Prastai");
            }
            else if (pazymys >= 1)
            {
                Console.WriteLine("Labai blogai");
            }
        }

    }
}
