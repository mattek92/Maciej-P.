using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void ZnakiLicz(ref string[] tab, ref int wynik, string znak)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == znak)
                {
                    wynik++;
                }
            }
        }

        static void Main(string[] args)
        {
            string[] tablica = { "a", "b", "c", "d", "a", "a", "c", "a"};
            string znak;
            int wynik = 0;

            Console.WriteLine("Projekt 2 - tablica i znaki");

            foreach (string ele in tablica)    //Wypisanie całej tabeli w konsoli.
                Console.Write(ele + " ");
            Console.ReadLine();

            Console.WriteLine("\n" + "Co szukać w tabeli: ");
            znak = Convert.ToString(Console.ReadLine());
            ZnakiLicz(ref tablica, ref wynik, znak);
            Console.WriteLine("\n" + "Ilość szukanego elementu: " + wynik);            /*
            if (tablica.Contains("c"))  // Wyszukanie elementu w tablicy
            {
                Console.WriteLine("\n" + "Element znajduje się w tablicy.");
            }
            */

            Console.ReadLine();
        }
    }
}
