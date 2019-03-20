//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public int kwadrat;
        public int l;
        public string i;
        
        public Program(int a, string anna)
        {
            l = a;
            kwadrat = l*l;
            i = anna;
        }
        
        public void wyswietl()
        {
            Console.WriteLine(i + " twój kwadrat liczby "+l+" wynosi: "+ kwadrat);
        }
        
        public static void Main(string[] args)
        {
            int[] tablica;
            string anna;
            int a,b,c;
            Console.Write("Podaj swoje imie.");
            anna = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" Podaj liczbe.\n");
            a = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine(" Podaj liczbe.\n");
            c = Convert.ToInt16(Console.ReadLine());
            tablica = new int [c];
            
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = Convert.ToInt16(Console.ReadLine());
            }
            
            Console.WriteLine("Twoja tablica:");
            foreach (int n in tablica)
            {
                Console.WriteLine(" liczba to :"+n);
               
            }
            
            Program kw = new Program(a, anna);
            kw.wyswietl();
        }
    }
}
