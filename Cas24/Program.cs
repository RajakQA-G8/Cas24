using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas24
{
    class Program
    {
        static void Main(string[] args)
        {
            Faktorijel(4);

            PomnoziParne(10);

            Console.ReadKey();
        }

        public static int Faktorijel(int broj)
        {
            Console.WriteLine("Ulazni parametar {0}", broj);
            int rezultat;
            if (broj == 1)
            {
                return 1;
            }
            else
            {
                rezultat = Faktorijel(broj - 1) * broj;
                Console.WriteLine("Rezultat {0}", rezultat);
                return rezultat;
            }
        }

        public static int PomnoziParne(int broj)
        {
            Console.WriteLine("Ulazni parametar {0}", broj);
            int rezultat;
            if (broj % 2 == 0)
            {
                if (broj < 2)
                {
                    return 1;
                } else
                {
                    rezultat = PomnoziParne(broj - 2) * broj;
                    Console.WriteLine("Rezultat {0}", rezultat);
                    return rezultat;
                }
            } else
            {
                return 1;
            }
        }
    }
}
