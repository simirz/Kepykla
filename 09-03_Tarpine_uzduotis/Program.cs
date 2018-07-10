using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_03_Tarpine_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //žinoma informacija: Darbo valandų per dieną 8 val.

            //Kiek darbuotojas gali iškepti kepalų per valandą.
            //Kiek darbuotojų turi kepykla.
            //Vieno kepalo savikaina.
            //Vieno kepalo pardavimo kaina.
            //Kiek kepykla turi tą dieną iškepti kepalų(užsakymai).
            Console.WriteLine("Kiek darbuotojas gali iškepti kepalų per valandą?");
            var kepaluSkaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiek darbuotojų turi kepykla?");
            var darbuotojuSkaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kokia Kepalo savikaina?");
            var savikaina = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kokia pardavimo kaina?");
            var kaina = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiek siai dienai turi būti uzsakymu?");
            var uzsakymuSkaicius = Convert.ToInt32(Console.ReadLine());
            //Suskaičiuoti kiek kepykla per vieną darbo dieną spės iškepti duonos kepalų.
            //Apskaičiuoti visų kepalų savikainą, gautas pajamas pardavus ir iš to gauto pelno dalį.
            //Patikrinti ar kepykla spės iškepti visus tos dienos užsakymus.Jei ne, suskaičiuoti kiek kepalų nespės iškepti.
            //(Papildomai)Įvertinkite tai, kad pajamas ir pelną galite gauti tik iš parduotų kepalų.
            Console.WriteLine("Per vieną darbo dieną, kepykla iškeps: {0} kepalų", 8*kepaluSkaicius*darbuotojuSkaicius);
            Console.WriteLine("Visu kepalu savikaina: {0}", savikaina*uzsakymuSkaicius);
            Console.WriteLine("Gautos pajamos pardavus: {0}", kaina*uzsakymuSkaicius);
            Console.WriteLine("Pelnas: {0}", (kaina*uzsakymuSkaicius)- savikaina * uzsakymuSkaicius);
            if (uzsakymuSkaicius == darbuotojuSkaicius * 8 * kepaluSkaicius)

            {
                Console.WriteLine("Spes");
            }
            else if (uzsakymuSkaicius != darbuotojuSkaicius * 8 * kepaluSkaicius);
            {
                Console.WriteLine("Nespes iskepti {0} kepalu", uzsakymuSkaicius- (8 * kepaluSkaicius * darbuotojuSkaicius));
            }

        }
    }
}
