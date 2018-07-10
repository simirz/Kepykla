using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_01_Projektas
{
    class Kepykla
    {
        //propg
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public List<Duona> Duonos { get; private set; }

        public Kepykla()
        {
            Duonos = new List<Duona>();
        }
        public Kepykla(string pavadinimas, string adresas, List<Duona> duonos)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Duonos = duonos;
        }
        public void Isvedimas()
        {

            Console.WriteLine(Pavadinimas);
            Console.WriteLine(Adresas);
            Console.WriteLine("Kepykla {0} adresu {1}", Pavadinimas, adresas);
            foreach (var duona in Duonos)
            {
                duona.Isvedimas();
            }

        }
    }
}

