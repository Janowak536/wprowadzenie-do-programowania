using System;

namespace zadanie_SMPSEQ5
{
    class Program
    {
        static void Main(string[] args)
        {
            string liczba1 = Console.ReadLine();
            string liczby1 = Console.ReadLine();
            string liczba2 = Console.ReadLine();
            string liczby2 = Console.ReadLine();
            int[] tablica1 = Array.ConvertAll<string, int>(liczby1.Split(" "), int.Parse);
            int[] tablica2 = Array.ConvertAll<string, int>(liczby2.Split(" "), int.Parse);

            for (int i = 0; i < tablica1.Length; i++)
            {
                if (tablica1[i] == tablica2[i])
                {
                    if (i == 0) continue;
                    if (i == tablica1.Length)
                        Console.Write(i + 1);

                    else
                    {
                        Console.Write((i + 1) + " ");
                    }
                }

            }

        }
    }
}
