using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var kvadratuSuma = 0;
            var sumosKvadratas = 0;
            for (int i = 1; i <= 100; i++)
            {
                kvadratuSuma = kvadratuSuma + i * i;
                sumosKvadratas = sumosKvadratas + i;
            }
            sumosKvadratas = sumosKvadratas * sumosKvadratas;
           Console.WriteLine("{0} - {1} = {2}", sumosKvadratas, kvadratuSuma, sumosKvadratas - kvadratuSuma);
        }
        
    }

}
