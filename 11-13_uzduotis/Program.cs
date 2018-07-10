using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_13_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek skaiciu isvesti?");
            var kiek = Convert.ToInt32(Console.ReadLine());

            var a = 1;
            var b = 1;
            var c = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 2; i < kiek; i++)
            {
                //Kiekvieno ciklo metu turite perskaičiuot trečiąjį 
                //skaičių (pirmų dviejų skaičių sudėtis),
                //tuomet pirmasis skaičius yra lygus antram,
                //o antrasis lygus trečiam, išvesti į ekraną trečią skaičių.
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }



        }

    }
}
