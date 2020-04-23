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
            Console.WriteLine(" - Minirechner -");

            Console.Write("\nGeben Sie Zahl1 ein: ");
            int Zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geben Sie Zahl2 ein: ");
            int Zahl2 = Convert.ToInt32(Console.ReadLine());

            // Für jede Rechenart wird ein eigenes Ergebnis erstellt:

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

        // Methoden:

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
