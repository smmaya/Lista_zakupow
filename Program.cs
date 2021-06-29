using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaZakupow
{
    class Program
    {
        static List<string> zakupy = new List<string>();

        static void Dodaj()
        {
            Console.WriteLine("Co dodać ?");
            string input = Console.ReadLine();
            bool match = zakupy.Any(x => x.Contains(input));
            if (match)
            {
                Console.WriteLine(input + " już istnieje!");
            }
            else
            {
                zakupy.Add(input);
                Console.WriteLine();
            }
        }
        static void Skresl()
        {
            Console.WriteLine("Co skreślić ?");
            string input = Console.ReadLine();
            bool match = zakupy.Any(x => x.Contains(input));
            if (match)
            {
                zakupy.Remove(input);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(input + " nie istnieje!");
            }
        }
        static void WypiszZakupy()
        {
            Console.WriteLine("Lista zakupów: ");
            foreach (string element in zakupy)
                Console.WriteLine("- " + element);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            zakupy.Add("gazeta");
            zakupy.Add("papierosy");
            zakupy.Add("wódka");

            string odp = "";

            while (odp != "k")
            {
                WypiszZakupy();
                Console.WriteLine("d - dodanie nowego elementu do listy");
                Console.WriteLine("s - skreślenie elementu z listy");
                Console.WriteLine("k - koniec działania programu" + "\n");
                Console.Write("Co chcesz zrobić? ");
                odp = Console.ReadLine();
                switch (odp)
                {
                    case "d":
                        Dodaj();
                        break;
                    case "s":
                        Skresl();
                        break;
                    case "k":
                        Console.WriteLine("Do widzenia!");
                        break;
                    default:
                        Console.WriteLine("Nie rozumiem, spróbuj jeszcze raz");
                        break;
                }

            }
            Console.ReadKey();

        }
    }
}