using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_00_Pavyzdziai
{
    class Studentas
    {
        public string Vardas;
        public string Pavarde;
        public int Amzius;
        public string Universitetas;
        public string StudijuPrograma;
        public string Grupe;
        public int Kursas;
        public int IstojimoMetai;

        //ctor->tab
        public Studentas() { }


        public Studentas(string vardas, string pavarde, int amzius, string universitetas, string studijuPrograma, string grupe, int kursas)
        {
            Vardas = vardas; //this.Vardas - sitos klases vardas, jei kartais brauktu
            Pavarde = pavarde;
            Amzius = amzius;
            Universitetas = universitetas;
            StudijuPrograma = studijuPrograma;
            Grupe = grupe;
            Kursas = kursas;

        }


        public void Isvedimas()
        {
            Console.WriteLine("____________________________________");
            Console.WriteLine("Studento {0} {1} ({2} m.) duomenys: ", Vardas, Pavarde, Amzius);
            Console.WriteLine("____________________________________");
            Console.WriteLine("Universitetas: " + Universitetas);
            Console.WriteLine("Studiju programa: " + StudijuPrograma);
            Console.WriteLine("Grupe: " + Grupe);
            Console.WriteLine("Kursas: " + Kursas);
            Console.WriteLine("____________________________________");
            Console.WriteLine();

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int skaicius = 55;
            Studentas petras1 = new Studentas(); //konstruktorius
            /* kaireje puseje gali buti ir var ie Studentas, 
             desineje puseje turi sutapti
            */
            var petras2 = new Studentas();
            petras1.Vardas = "Petras";
            petras1.Pavarde = "Petraitis";
            petras1.Amzius = 25;
            petras1.Universitetas = "KTU";
            petras1.StudijuPrograma = "Programu Sistemos";
            petras1.Kursas = 4;
            petras1.Grupe = "PS";




            Console.WriteLine(petras1.Vardas);
            Console.WriteLine(petras1.Pavarde);
            Console.WriteLine(petras1.Amzius);
            Console.WriteLine(petras1.Universitetas);
            Console.WriteLine(petras1.StudijuPrograma);
            Console.WriteLine(petras1.Kursas);
            Console.WriteLine(petras1.Grupe);

            Console.WriteLine();

            petras2.Vardas = "Antanas";
            petras2.Pavarde = "Antanaitis";
            petras2.Amzius = 23;
            petras2.Universitetas = "KU";
            petras2.StudijuPrograma = "Rekreacine architektūra";
            petras2.Kursas = 2;
            petras2.Grupe = "RAK";

            Console.WriteLine(petras2.Vardas);
            Console.WriteLine(petras2.Pavarde);
            Console.WriteLine(petras2.Amzius);
            Console.WriteLine(petras2.Universitetas);
            Console.WriteLine(petras2.StudijuPrograma);
            Console.WriteLine(petras2.Kursas);
            Console.WriteLine(petras2.Grupe);

            petras1.Isvedimas();
            petras2.Isvedimas();
            var studentas = new Studentas("Jonas", "Jonaitis", 33, "VDU", "Kataliku teologija", "nezinau", 1);
            studentas.Isvedimas();

            /*var skaiciai = new List<int>()
             skaiciai.Add(8);*/
            var grupe = new List<Studentas>();
            grupe.Add(new Studentas("QWERTY", "TYUIO", 15, "kk", "ABC", "hikj", 14));
            grupe.Add(new Studentas("QWEuy", "TpIO", 16, "kk", "AdC", "hkj", 15));
            grupe.Add(new Studentas("sima", "TYO", 18, "Lk", "AC", "hj", 18));
            grupe.Add(new Studentas("as", "tu", 21, "jis", "ji", "mes", 1));
            grupe.Add(new Studentas("jus", "jie", 18, "jos", "i", "you", 17));
            grupe.Add(new Studentas("he", "she", 18, "it", "we", "they", 15));

            foreach (var student in grupe)
            {
                student.Isvedimas();

            }

            var programa = new Program();

            var vyriausias = programa.VyriausiasStudentas(grupe);
            Console.WriteLine("Vyriausias studentas: ");
            vyriausias.Isvedimas();

            Console.WriteLine("Vyriausias studentas: ");
            programa.VyriausiasStudentas(grupe).Isvedimas();


            var jauniausias = programa.JauniausiasStudentas(grupe);
            Console.WriteLine("Jauniausias studentas: ");
            jauniausias.Isvedimas();

            Console.WriteLine("Vyriausias studentas: ");
            programa.VyriausiasStudentas(grupe).Isvedimas();
            Console.WriteLine("Jauniausias studentas: ");
            programa.JauniausiasStudentas(grupe).Isvedimas();

            var zemiausioKurso = programa.ZemiausioKursoStudentas(grupe);
            Console.WriteLine("Zemiausio kurso studentas: ");
            zemiausioKurso.Isvedimas();

            var gyvunas = new Gyvunas("ruda", "ilgas", 4, 10);
            gyvunas.Isvedimas();
            gyvunas.Gimtadienis();
            gyvunas.Isvedimas();



        }

        public Studentas VyriausiasStudentas(List<Studentas> grupe)
        {
            var vyriausias = grupe.First();
            foreach (var studentas in grupe)
            {
                if (studentas.Amzius > vyriausias.Amzius)
                {
                    vyriausias = studentas;
                }
            }


            return vyriausias;
        }


        public Studentas JauniausiasStudentas(List<Studentas> grupe)
        {
            var jauniausias = grupe.First();
            foreach (var studentas in grupe)
            {
                if (studentas.Amzius < jauniausias.Amzius)
                {
                    jauniausias = studentas;
                }
            }
            return jauniausias;
        }
        public Studentas ZemiausioKursoStudentas(List<Studentas> grupe)
        {
            var zemiausioKurso = grupe.First();
            foreach (var studentas in grupe)
            {
                if (studentas.Kursas < zemiausioKurso.Kursas)
                {
                    zemiausioKurso = studentas;
                }
            }
            return zemiausioKurso;
        }

    }
}




