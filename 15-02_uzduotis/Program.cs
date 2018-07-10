using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek norite irasyti pazymiu?");
            var kiekis = Convert.ToInt32(Console.ReadLine());
            var pazymiai = new List<int>();

            for (int i = 0; i < kiekis; i++)
            {
                Console.WriteLine("Iveskite");
                pazymiai.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine();

            var max = pazymiai.First();
            foreach (var pazimys in pazymiai)
            {
                if (pazimys > max)
                {
                    max = pazimys;
                }
            }
            Console.WriteLine("Didziausias: " + max);
            Console.WriteLine();

            var min = pazymiai.First();
            foreach (var pazimys in pazymiai)
            {
                if (pazimys < min)
                {
                    min = pazimys;
                }
            }
            Console.WriteLine("Mažiausias: " + min);
            Console.WriteLine();
            var suma = 0;
            for (int i = 0; i < pazymiai.Count; i++)
            {
                suma += pazymiai[i];
            }
            var vidurkis = (double)suma / pazymiai.Count;
            Console.WriteLine("Vidurkis: " + vidurkis);

            Console.WriteLine();
            var random = new Random();
            var indeksas = random.Next(pazymiai.Count);
            Console.WriteLine(pazymiai[indeksas]);
            

            /*for (int i = 0; i < kiekis; i++)
            {
                pazymiai.Add(random.Next(1, 100));
            }
            foreach (var pazimys in pazymiai)
            {
                Console.Write(pazimys + " ");
            }*/
            Console.WriteLine();
        }
    }
}
