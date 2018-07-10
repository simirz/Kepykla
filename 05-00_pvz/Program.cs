using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_00_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite 3 skaičius");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var trecias = Convert.ToInt32(Console.ReadLine());
            if (pirmas == antras)
            {
                Console.WriteLine("1. Salyga {0} = {1}", pirmas, antras);
            }
            if (antras == trecias)
            {
                Console.WriteLine("2. Salyga {0} = {1}", antras, trecias);
            }
            if (pirmas > antras)
            {
                Console.WriteLine("3. Salyga {0} > {1}", pirmas, antras);
            }
            if (antras > trecias * 2)
            {
                Console.WriteLine("4. Salyga {0} > {1}", antras, trecias * 2);
            }
            if (pirmas % 2 == 0)
            {
                Console.WriteLine("5. Salyga {0} yra lyginis skaicius", pirmas);
            }
            if (antras % 2 != 0)
            {
                Console.WriteLine("6. Salyga {0} yra nelyginis", antras);
            }
            if (trecias > 0)
                            {
                Console.WriteLine("7. Salyga {0} yra teigiamas", trecias);
                            }
            if (trecias < 0)
            {
                Console.WriteLine("8. Salyga {0} yra neigiamas", trecias);
            }

        }
    }
}
