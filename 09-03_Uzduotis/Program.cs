using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_03_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Į ekraną išveskite kelis sunumeruotus pasirinkimus
            // (pvz.: 1 - vanduo, 2 - kava, 3 - arbata…).
            //Liepkite vartotojui įvesti pasirinkimo numerį. 
            //Pagal įvestą numerį išveskite atitinkamą tekstą (pvz.: jūs pasirinkote vandenį). 
            //Neradus tinkamo varianto išvesti, kad tokio pasirinkimo nėra.
            Console.WriteLine("Įveskite pasirinkto gėrimo numerį: 1. Vanduo; 2. Kava; 3. Arbata.");
            var gerimas = Convert.ToInt32(Console.ReadLine());
            switch (gerimas)
            {
                case 1:
                    Console.WriteLine("Jūs pasirinkote vandenį");
                    break;
                case 2:
                    Console.WriteLine("Jūs pasirinkote kavą");
                    break;
                case 3:
                    Console.WriteLine("Jūs pasirinkote arbatą");
                    break;
                default:
                    Console.WriteLine("Tokio pasirinkimo nera");
                    break;
            }

        }
    }
}
