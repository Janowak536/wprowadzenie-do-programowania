using System;
using System.Linq;

namespace zadanie_SMPSEQ8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int liczba = int.Parse(Console.ReadLine());
                int[] tablica1 = Console.ReadLine().Split(' ').Take(liczba).Select(int.Parse).ToArray();
                int m = int.Parse(Console.ReadLine());
                int[] tablica2 = Console.ReadLine().Split(' ').Take(m).Select(int.Parse).ToArray();
                int wynik1;
                int wynik2;
                
                if (tablica1.Length >= 2 && tablica1.Length <= 100 && tablica1.Length >= 2 && tablica2.Length <= 100)

                {
                    wynik1 = 0;
                    wynik2 = 0;
                    for (int i = 0; i < tablica2.Length; i++)
                    {
                        
                        wynik1 += tablica1[i];
                        wynik2 += tablica2[i];
                        if (i+1==tablica2.Length)
                        {
                           
                            if (wynik1 > wynik2 && wynik1 !=wynik2)
                            {
                                for (int j = 0; j < tablica1.Length; j++)
                                {
                                    Console.Write($"{tablica1[j]}" + " ");
                                }
                                
                            }
                            if (wynik1 < wynik2 || wynik1 == wynik2)
                            {
                                for (int j = 0; j < tablica1.Length; j++)
                                {
                                    Console.Write($"{tablica2[j]}" + " ");
                                }

                            }
                           
                        }
                    }
                }
            }
            catch (Exception)
            {

                return;
            }

        }
    }
}
