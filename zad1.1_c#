using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void NajmniejszaLicz(ref int[] arr, ref int min)
        {
            min = arr[0];
            for(int i=0 ; i<arr.Length ; i++)
            {
                if(arr[i]<min)
                {
                    min = arr[i];
                }
            }
        }

        static void NajwiekszaLicz(ref int[] arr, ref int max)
        {
            max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
        }

        static void Main(string[] args)
        {
            int[] tablica = { 12, 2, 4, 6, 8, 20, 9, 9, 9, 10, 30, 1 };
            Console.WriteLine("Projekt 1 - tablica");

            foreach (int num in tablica)    //Wypisanie całej tabeli w konsoli.
                Console.Write(num + " ");
            Console.ReadLine();

            int minimum = 0;
            NajmniejszaLicz(ref tablica, ref minimum);
            Console.WriteLine("\n" + "Najmniejsza liczba w tabeli: " + minimum);

            // Console.WriteLine("\n" + "Najmniejsza liczba w tabeli: " + tablica.Min());   Drugi sposób/gotowa metoda

            int maksimum = 0;
            NajwiekszaLicz(ref tablica, ref maksimum);
            Console.WriteLine("Najmniejsza liczba w tabeli: " + maksimum);

            // Console.WriteLine("\n" + "Najmniejsza liczba w tabeli: " + tablica.Max());   Drugi sposób/gotowa metoda
            Console.ReadLine();
        }
    }
}
