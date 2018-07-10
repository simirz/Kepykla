using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_05_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var daugiklis = 0;
            Console.WriteLine("{0} * 0 = {1}", a, 5*0);
            Console.WriteLine("{0} * 1 = {1}", a, 5 * 1);
            Console.WriteLine("{0} * 2 = {1}", a, 5 * 2);
            Console.WriteLine("{0} * 3 = {1}", a, 5 * 3);
            Console.WriteLine("{0} * 4 = {1}", a, 5 * 4);
            Console.WriteLine("{0} * 5 = {1}", a, 5 * 5);
            Console.WriteLine("{0} * 6 = {1}", a, 5 * 6);
            Console.WriteLine("{0} * 7 = {1}", a, 5 * 7);
            Console.WriteLine("{0} * 8 = {1}", a, 5 * 8);
            Console.WriteLine("{0} * 9 = {1}", a, 5 * 9);
            Console.WriteLine("{0} * 10 = {1}", a, 5 * 10);

            Console.WriteLine("{0} * {1} = {2}", a, daugiklis, a*daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", a, daugiklis, a * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", a, daugiklis, a * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", a, daugiklis, a * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", a, daugiklis, a * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", a, daugiklis, a * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", a, daugiklis, a * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", a, daugiklis, a * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", a, daugiklis, a * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", a, daugiklis, a * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", a, daugiklis, a * daugiklis++);
        }
    }
}
