using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinirechnerTFO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minirechner");

            Console.Write("\nZahl1: ");
            int Zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zahl2: ");
            int Zahl2 = Convert.ToInt32(Console.ReadLine());

            

            int ErgA = Addition(Zahl1, Zahl2);
            int ErgS = Subtraktion(Zahl1, Zahl2);
            int ErgM = Multiplikation(Zahl1, Zahl2);
            int ErgD = Division(Zahl1, Zahl2);

            Console.Write("\nAddition: " + ErgA);

            Console.Write("\nSubtraktion: " + ErgS);

            Console.Write("\nMultiplikation: " + ErgM);

            Console.Write("\nDivision: " + ErgD);

            Console.ReadKey();
        }


        public static int Addition(int Zahl1, int Zahl2)
        {
            int Erg = Zahl1 + Zahl2;

            return Erg;


        }

        public static int Subtraktion(int Zahl1, int Zahl2)
        {
            int Erg = Zahl1 - Zahl2;

            return Erg;


        }

        public static int Multiplikation(int Zahl1, int Zahl2)
        {
            int Erg = Zahl1 * Zahl2;

            return Erg;


        }

        public static int Division(int Zahl1, int Zahl2)
        {
            int Erg = Zahl1 / Zahl2;

            return Erg;


        } // Ende der Methoden


    }
}
