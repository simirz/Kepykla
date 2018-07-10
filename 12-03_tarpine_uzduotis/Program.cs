using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_03_tarpine_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            var kvSuma = 0;
            var sumosKv = 0;

            for (int j = 1; j <= 100; j++)
            {
                kvSuma = kvSuma + j * j;
                sumosKv = sumosKv + j;
            }
            sumosKv = sumosKv * sumosKv;
            var atsakymas = sumosKv - kvSuma;
            Console.WriteLine(atsakymas);
        }
    }
}
