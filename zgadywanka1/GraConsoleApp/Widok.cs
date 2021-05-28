using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace GraConsoleApp
{
    public class PrzerwaneWprowadzenieException : Exception
    {
    }

    public class Widok
    {
        public const char ZNAK_ZAKONCZENIA = 'X';
        public readonly static string TEKST_ZACHETY = "Podaj liczbę (lub " + ZNAK_ZAKONCZENIA + " aby zakończyć): ";

        public void CzyscEkran() => Clear();

        public void WypiszOpisGry()
        {
            WriteLine("Bla bla bla bla");
        }

        public void WypiszKomunikatZaDuzo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Za dużo");
            Console.ResetColor();
        }

        public void WypiszKomunikatZaMalo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Za mało");
            Console.ResetColor();
        }
        public void WypiszKomunikatTrafiony()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            WriteLine("Trafiony");
            Console.ResetColor();
        }

        public bool ChceszKontynuowac()
        {
            Write("Czy chcesz kontynuować? (t/n)");
            char odp = ReadKey().KeyChar;
            WriteLine();

            return (odp == 't' || odp == 'T');
        }

        public int WczytajLiczbe()
        {
           
            int wynik = 0;

            while (true)
            {
                Write(TEKST_ZACHETY);
                try
                {
                    string napis = ReadLine().Trim().ToUpper();
                    if (napis.Length > 0 && napis[0].Equals(ZNAK_ZAKONCZENIA))
                        throw new PrzerwaneWprowadzenieException();

                    wynik = Int32.Parse(napis);
                    break;
                }
                catch (PrzerwaneWprowadzenieException e)
                {
                    WriteLine("Naciśnięto " + ZNAK_ZAKONCZENIA + " Przerywam.");
                    throw e;
                }
                catch (FormatException e)
                {
                    WriteLine("Wprowadzony tekst nie przypomina liczby całkowitej. Spróbuj jeszcze raz.");
                    continue;
                }
                catch (OverflowException)
                {
                    WriteLine("Przesadziłeś, za duża liczba. Spróbuj jeszcze raz.");
                    continue;
                }
                catch (Exception)
                {
                    WriteLine("Nieznany błąd. Spróbuj jeszcze raz");
                    continue;
                }
            }
        }
    }
}
