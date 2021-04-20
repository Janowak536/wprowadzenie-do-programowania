using System;
using System.Linq;

namespace zadanie_SMPSEQ5
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
                if (tablica1.Length >= 2 && tablica1.Length <= 100 && tablica1.Length >= 2 && tablica2.Length <= 100)
                    for (int i = 0; i < tablica1.Length; i++)
                    {
                        if (tablica1[i] == tablica2[i])
                        {
                            Console.Write($"{ i + 1}" + ' ');
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