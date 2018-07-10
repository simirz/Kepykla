using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_00_Pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i += 5)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            for (int i = 1; i <= 25; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + " ");
                }

            }
            Console.WriteLine();
            var suma = 0;
            for (int i = 0; i < 100; i++)
            {
                suma += i;
            }
            Console.WriteLine("suma: " + suma);

            var sandauga = 1;
            for (int i = 1; i <= 10; i++)
            {
                sandauga *= i;
            }
            Console.WriteLine("sandauga: " + sandauga);

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }
            var lyginiuSuma = 0;
            for (int i = 0; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    lyginiuSuma += i;
                    //lyginiuSuma = lyginiuSuma + 1
                }
            }
            Console.WriteLine("lyginiuSuma: " + lyginiuSuma);
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i % 3 == 0)
                {
                    break; //jei skaicius dalijasi is 3 tada iseis is ciklo - "break" reiksme - nutraukti cikla
                }
            }
            Console.WriteLine();
            //[2-10)
            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            //2, 4, 6, 8, 10
            for (int i = 2; i <= 10; i += 2)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();

        }
    }
}
