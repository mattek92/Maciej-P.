using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int naw = 0;
            int i = 1;
            do
            {
                Console.Clear();
                Console.Write("Projekt 3 - Program/drzewo - MENU" + "\n"
                            + "=================================" + "\n");
                Console.Write("1# Kontakt" + "\n" +
                              "2# Pomoc" + "\n" +
                              "0# Koniec" + "\n");
                naw = int.Parse(Console.ReadLine());
                if (naw == 1)
                {
                    naw = 0;
                    i++;
                    do
                    {
                        Console.Clear();
                        Console.Write("Projekt 3 - Kontakt" + "\n"
                                + "=================================" + "\n");
                        Console.Write("3# Do mnie" + "\n" +
                                      "0# Wstecz" + "\n");
                        //Console.Write("Podaj liczbe" + "(twoja liczba to " + naw + ") :");
                        naw = int.Parse(Console.ReadLine());
                        if (naw == 3)
                        {
                            naw = 0;
                            i++;
                            Console.Clear();
                            Console.Write("Projekt 3 - Do mnie" + "\n"
                                + "=================================" + "\n");
                            Console.Write("Mój e-mail : maciejplocieniak@gmail.com" + "\n" + "\n" +
                                          "0# Wstecz" + "\n");
                            Console.ReadLine();
                            i--;
                        }
                        else
                        {
                            i--;
                        }

                    } while (i == 2);
                    
                }
                else if (naw == 2)
                {
                    naw = 0;
                    i++;
                    do
                    {
                        Console.Clear();
                        Console.Write("Projekt 3 - Pomoc" + "\n"
                                + "=================================" + "\n");
                        Console.Write("Napisz do mnie abym mógł pomóc. Aby to zrobić musisz się cofnąć i wejść w kontakty." + "\n" + "\n" +
                                      "0# Wstecz" + "\n");
                        Console.ReadLine();
                        i--;
                    } while (i == 2);
                }
                else
                {
                    Console.Clear();
                    Console.Write("Projekt 3 - Koniec" + "\n"
                            + "=================================" + "\n");
                    Console.Write("Miłego dnia......." + "\n");
                    Console.ReadLine();
                    i--;
                }
            } while (i == 1);
            
        }
    }
}
