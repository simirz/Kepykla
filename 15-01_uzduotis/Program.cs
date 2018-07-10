using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new List<int>();
            var random = new Random();
            var kiek = random.Next(20, 100);

            for (int i = 0; i < kiek; i++)
            {
                skaiciai.Add(random.Next(1, 100));
            }
            foreach (var skaicius in skaiciai)
            {
                Console.Write(skaicius + " ");
            }
            Console.WriteLine();
            var min = skaiciai.First();
            foreach (var skaicius in skaiciai)
            {
                if (skaicius < min)
                {
                    min = skaicius;
                }
            }
            Console.WriteLine("Mažiausias: " + min);
            Console.WriteLine();
            var max = skaiciai.First();
            foreach (var skaicius in skaiciai)
            {
                if (skaicius > max)
                {
                    max = skaicius;
                }
            }
            Console.WriteLine("Didziausias: " + max);
            Console.WriteLine();
            var suma = 0;
            for (int i = 0; i < skaiciai.Count; i++)
            {
                suma += skaiciai[i];
            }
            var vidurkis = (double)suma / skaiciai.Count;
            Console.WriteLine("Vidurkis: " + vidurkis);


            Console.WriteLine();

            var didesniUzVidurki = 0;
            foreach (var skaicius in skaiciai)
            {
                if (skaicius > vidurkis)
                {
                    didesniUzVidurki++;
                }
            }
            Console.WriteLine("Didesniu uz vidurki kiekis: " + didesniUzVidurki);

            Console.WriteLine();
            var lyginiuSuma = 0;
           
            foreach (var skaicius in skaiciai)
            {

                if (skaicius % 2 == 0)
                {
                    lyginiuSuma += skaicius;
                }
            }
            Console.WriteLine("Lyginiu skaiciu suma: " + lyginiuSuma);

        }
    }
}
