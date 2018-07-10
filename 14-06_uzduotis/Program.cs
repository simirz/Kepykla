using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_06_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek eiluciu leisti irasyti?");
            int kiek = Convert.ToInt32(Console.ReadLine());
            string[] tekstas = new string[kiek];
            for (int i = 0; i < tekstas.Length; i++)
            //arba for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine("tai ir rasyk: ");
                tekstas[i] = Console.ReadLine();
            }
        }
    }
}
