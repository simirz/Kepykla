using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_05_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciai = new int[5];
            // for (int i = 0; i < 5; i++) arba 
            for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.WriteLine("Įveskite skaicius: ");
                skaiciai[i] = Convert.ToInt32(Console.ReadLine());
            }
           

        }

    }
}
