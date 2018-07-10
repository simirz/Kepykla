using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciai = new int[10];
            skaiciai[0] = 12;
            skaiciai[1] = 15;
            skaiciai[2] = 2;
            if (skaiciai[2] > skaiciai[0])
            {
                Console.WriteLine(skaiciai[1]);
            }
            else if (skaiciai[2] < skaiciai[0])
            {
                Console.WriteLine("siaip kazkas parasyta");
            }

        }
    }
}
