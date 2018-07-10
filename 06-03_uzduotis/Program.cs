using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite šios dienos oro temperatūrą");
            var temperatura = Convert.ToInt32(Console.ReadLine());
            //ar temperatūra < 0 - išvesti “žiauriai šalta”;
            //ar temperatūra< 10 - išvesti “labai šalta”;
            //ar temperatūra< 20 - išvesti “šalta”;
            //ar temperatūra< 30 - išvesti “normali temperatūra”;
            //ar temperatūra< 40 - išvesti “karšta”;
            //ar temperatūra > 40 - išvesti “visiškai degina”;
            if (temperatura < 0)
            {
                Console.WriteLine("Žiauriai salta");
            }
            else if (temperatura < 10)
            {
                Console.WriteLine("Labai šalta");
            }
            else if (temperatura < 20)
            {
                Console.WriteLine("Labai šalta");
            }
            else if (temperatura < 30)
            {
                Console.WriteLine("Normali temperatūra");
            }
            else if (temperatura < 40)
            {
                Console.WriteLine("Karšta");
            }
            else if (temperatura > 40)
            {
                Console.WriteLine("Visiškai degina");
            }

        }
    }
}
