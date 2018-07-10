using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_00_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jūsų vardas");
            var vardas = Console.ReadLine();

            Console.WriteLine( "Jūsų pavardė");
            var pavarde = Console.ReadLine();

            Console.WriteLine("Kokios markės automobilį vairuojate?");
            var auto = Console.ReadLine();

            Console.WriteLine("Kokia automobilio spalva?");
            var spalva = Console.ReadLine();

            Console.WriteLine("Jūsų amžius");
            var amzius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Jūsų ūgis");
            var ugisTekstas = Console.ReadLine();
            var ugisSkaicius = Convert.ToUInt32(ugisTekstas);

            Console.WriteLine("Kortelės numeris");
            var kortelesNr = Console.ReadLine();

            Console.WriteLine("Pin kodas");
            var pin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gimimo diena");
            var gimimoDiena = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lytis");
            var lytis = Console.ReadLine();

            Console.WriteLine("Jūsų suvesti duomenys");
            Console.WriteLine(vardas + " " + pavarde);
            Console.WriteLine("Jūs vairuojate {0} {1} automobilį", spalva, auto);
            Console.WriteLine("Jums {0} metų ir esate {1} ūgio", amzius, ugisSkaicius);
            Console.WriteLine("Jūsų kortelės numeris {0}, o pin kodas {1}, be be be", kortelesNr, pin);
            Console.WriteLine("Jūsų gimimo diena yra {0}", gimimoDiena);
            Console.WriteLine("Jūsų lytis {0}", lytis);
            Console.WriteLine();
            Console.WriteLine("Jūsų gyūno vardas");
            var gvardas = Console.ReadLine();
            Console.WriteLine("Kokia Jūsų gyvūno kailio spalva?");
            var gspalva = Console.ReadLine();
            Console.WriteLine("Kokia Jūsų gyvūno kilmė?");
            var kilme = Console.ReadLine();
            Console.WriteLine("Kokia Jūsų gyvūno rūšis?");
            var rusis = Console.ReadLine();
            Console.WriteLine("Koks Jūsų gyvūno greitis?");
            var greitis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Jūsų gyvūno vardas yra {0}", gvardas, "jis labai mielas");
            Console.WriteLine("Jūsų gyvunas {0}", gspalva);
            Console.WriteLine("o rūšis {0} yra visiškai neaiški", rusis);
            Console.WriteLine("Jūsų gyvūnas yra lėtas! Nes nepajuda greičiau nei {0}", greitis);
            
        









        }
    }
}
