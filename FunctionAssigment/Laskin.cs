using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laskin
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Valitse laskutoimitus: \n1. Yhteenlasku \n2. Vähennyslasku \n3. Kertolasku \n4. Jakolasku");

            // Valitaan jokin laskutoimitus
            int luku = ValitseLaskutoimitus();
            switch (luku)
            {
                case 1:
                    PrintSolution(Yhteenlasku(KysyLuku()));
                    break;
                case 2:
                    PrintSolution(Vähennyslasku(KysyLuku()));
                    break;
                case 3:
                    PrintSolution(Kertolasku(KysyLuku()));
                    break;
                case 4:
                    PrintSolution(Jakolasku(KysyLuku()));
                    break;
            }
            Lopetus();
        }

        // Lopuksi kysytään halutaanko laskea uudelleen
        static void Lopetus()
        {
            Console.WriteLine("Uusi lasku? (y/n) ");

            while (true)
            {
                var input = Console.ReadKey(true);
                if (input.Key.Equals(ConsoleKey.Y))
                {
                    Main();
                }
                else if (input.Key.Equals(ConsoleKey.N))
                {
                    Environment.Exit(0);
                }
            }
        }

        // Tulostaa lopputuloksen
        static void PrintSolution(int solution)
        {
            Console.WriteLine("Tulos: " + solution);
        }

        // Testaa käyttäjän inputin ja palauttaa valitun laskutoimituksen numerona
        static int ValitseLaskutoimitus()
        {
            while (true)
            {
                var input = Console.ReadKey(true);
                if (int.TryParse(input.KeyChar.ToString(), out int value) && value >= 1 && value <= 4)
                {
                    return value;
                }
            }
        }

        // Kysyy käyttäjältä kaksi lukua ja palauttaa ne arrayna
        static int[] KysyLuku()
        {
            var luvut = new int[2];

            while (true)
            {
                Console.WriteLine("Syötä ensimmäinen luku: ");
                var input = Console.ReadLine();

                if (int.TryParse(input, out int value))
                {
                    luvut[0] = value;
                    break;
                }
                else
                {
                    Console.WriteLine("Syötä kelvollinen kokonaisluku. ");
                }
            }

            while (true)
            {
                Console.WriteLine("Syötä toinen luku: ");
                var input = Console.ReadLine();

                if (int.TryParse(input, out int value))
                {
                    luvut[1] = value;
                    return luvut;
                }
                else
                {
                    Console.WriteLine("Syötä kelvollinen kokonaisluku. ");
                }
            }
        }

        // Lasketaan arrayn kaksi lukua yhteen

        static int Yhteenlasku(int[] luvut)
        {
            var luku = luvut[0] + luvut[1];
            return luku;
        }

        static int Vähennyslasku(int[] luvut)
        {
            var luku = luvut[0] - luvut[1];
            return luku;
        }

        static int Kertolasku(int[] luvut)
        {
            var luku = luvut[0] * luvut[1];
            return luku;
        }

        static int Jakolasku(int[] luvut)
        {
            // Estetään nollalla jako
            if (luvut[1] == 0)
            {
                Console.WriteLine("Et voi jakaa nollalla. ");
                return 0;
            }

            var luku = luvut[0] / luvut[1];
            return luku;
        }
    }
}
