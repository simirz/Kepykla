using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_08_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var temperaturos = new int[] { 25, 20, 13, 17, 28, 30, 25 };
            var min = temperaturos.Min();
            Console.WriteLine(min);
            var max = temperaturos.Max();
            Console.WriteLine(max);
            Console.WriteLine();

            var min1 = temperaturos[0];
            for (int i = 0; i < temperaturos.Length; i++)
            {
                if (temperaturos[i] < min1)
                {
                    min1 = temperaturos[i];
                }
            }
            Console.WriteLine(min1);

            var max1 = temperaturos[0];
            for (int i = 0; i < temperaturos.Length; i++)
            {
                if (temperaturos[i] > max1)
                {
                    max1 = temperaturos[i];
                }
            }
            Console.WriteLine(max1);
            var average = temperaturos.Average();
            Console.WriteLine(average);

            var suma = 0;
            foreach (var temperatura in temperaturos)
            {
                suma += temperatura;
            }

            var average1 = suma / (double)temperaturos.Length;
            Console.WriteLine(average1);
            Console.WriteLine();

            var zemesnes = 0;
            var didesnes = 0;

            foreach (var temperatura in temperaturos)
            {

                if (average > temperatura)
                {
                    zemesnes++;
                }
                

                if (average < temperatura)
                {
                    didesnes++;
                }
            }


            Console.WriteLine("Dienu su zemesnemis nei vidurkis temperaturomis: " + zemesnes);
            Console.WriteLine("Dienu su didesnesnemeis neividurkis temperaturomis: " + didesnes);

        }
    }
}