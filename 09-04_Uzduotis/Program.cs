using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_04_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jūsų pasirinkimo variantai: 1 - stacionarus kompiuteris, 2 - nešiojamas kompiuteris, " +
                "3 - planšetė. Įveskite priimtiną pasirinkimo numerį:");
            var pasirinkimas = Convert.ToInt32(Console.ReadLine());
            switch (pasirinkimas)
            {
                case 1:
                    Console.WriteLine("Su stacionariu kompiuteriu dirbsi nepakeldamas nuo kedes sedimosios");
                    break;
                case 2:
                    Console.WriteLine("Nesiojamasis kompiuteris pakankamai sunkus nesiotis kuprinėje");
                    break;
                case 3:
                    Console.WriteLine("Puikus pasirinkimas");
                    break;
                default:
                    Console.WriteLine("Tokio pasirinkimo nėra");
                    break;


            }
        }
    }
}
