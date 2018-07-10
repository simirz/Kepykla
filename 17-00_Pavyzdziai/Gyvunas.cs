using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_00_Pavyzdziai
{
    class Gyvunas
    {
        //propg
        public string KailioSpalva { get; private set; }
        public string KailioIlgis { get; private set; }
        public int KojuKiekis { get; private set; }
        public int Amzius { get; private set; }
        //ctor
        public Gyvunas() { }

        public Gyvunas (string kailioSpalva, string kailioIlgis, int kojuKiekis, int amzius)
        {
            KailioSpalva = kailioSpalva;
            KailioIlgis = kailioIlgis;
            KojuKiekis = kojuKiekis;
            Amzius = amzius;
        }
        //isvedimo metodas
        public void Isvedimas()
        {

            Console.WriteLine(KailioSpalva);
            Console.WriteLine(KailioIlgis);
            Console.WriteLine(KojuKiekis);
            Console.WriteLine(KailioSpalva);
            Console.WriteLine(Amzius);
            
        }
        public void Gimtadienis()
        {
            Amzius++;
        }
    }
}
