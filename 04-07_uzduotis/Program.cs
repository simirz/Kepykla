using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_07_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parašykite kokia oro temperatūra yra šiandien");
            var laipsniai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Oro temperatūra C:{0}", laipsniai);
            Console.WriteLine("Oro temperatūra K: {0}", (double)laipsniai + 273.15);
            Console.WriteLine("Oro temperatūra F: {0}", (double)laipsniai * 1.8 + 32);
        }
    }
}
