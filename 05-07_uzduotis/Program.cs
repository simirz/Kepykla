using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_07_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite egzamino rezultatą");
            var rezultatas = Convert.ToInt32(Console.ReadLine());
            //ar gautas rezultatas yra lygus 100;
            // ar gautas rezultatas yra lygus arba didesnis nei 80;
            //  ar gautas rezultatas yra lygus arba didesnis nei 50;
            //  ar gautas rezultatas yra lygus arba didesnis nei 20;
            //  ar gautas rezultatas yra mažesnis nei 20;
            if (rezultatas == 100)
            {
                Console.WriteLine("Gautas rezultatas = 100");
            }
            else if (rezultatas >= 80)
            {
                Console.WriteLine("Gautas rezultatas >= 80");
            }
            else if (rezultatas >= 50)
            {
                Console.WriteLine("Gautas rezultatas >= 50");
            }
            else if (rezultatas >= 20)
            {
                Console.WriteLine("Gautas rezultatas >= 20");
            }
            else if (rezultatas < 20)
            {
                Console.WriteLine("Gautas rezultatas < 20");
            }

        }
    }
}
