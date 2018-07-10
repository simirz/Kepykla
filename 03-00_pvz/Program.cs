using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_00_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklaracija ir inicializacija
            var vienas = 515;

            //deklaracija - tik viena karta
            string neaiskusDuomenys;
            //inicializacija
            string hjhneaiskusDuomenys = "313";

            // veliau 
            neaiskusDuomenys = "212";

            int lll; //32 bit ir teigiamos ir neigiamos reiksmes
            short kkkk;//16 bit
            long lllll;//64 bit
            uint mmm; // unigned 32 bit tik teigiamos reiksmes
            ushort yiukkkk;//unsigned 16 bit tik teigiamos reiksmes
            ulong llll;// unsigned 64 bit tik teigiamos reiksmes
                byte hhhh; // 8 bit
            sbyte yyy; ; // signed 8 bit ir teigiamos ir neigiamos reiksmes

            var y = 45 + 44;
            var x = y + 8888;
            var hhh = 4 + 5 + 7;
            Console.WriteLine((545+86) * 3);
            Console.WriteLine("{0} + {1} + {2}");

            var aaa = 5;
            aaa++; //6
            aaa++; // 7
            aaa--; // 6
            aaa = aaa + 10; //16
            aaa = aaa - 6; //10
            aaa += 10; //20
            aaa -= 5; //15
            aaa *= 2;



        }
    }
}
