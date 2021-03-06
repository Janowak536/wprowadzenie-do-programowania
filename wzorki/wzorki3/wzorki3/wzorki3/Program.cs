using System;

namespace wzorki3
{
    class Program
    {
        static void Dot() => Console.Write(".");
        static void Star() => Console.Write("*");
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int[,] wymiary = new int[a, 2];
            for (int i = 0; i < a; i++)
            {
                string inputValues = Console.ReadLine();
                int[] valuesArray = Array.ConvertAll<string, int>(inputValues.Split(" "), int.Parse);
                wymiary[i, 0] = valuesArray[0];    //maksymalna szerokość
                wymiary[i, 1] = valuesArray[1];    // maksymalna długość
            }


            for (int j = 0; j < a; j++)              // koniec pętli po zakończeniu obiektów
            {
                
                for (int i = 0; i < wymiary[j, 0] ; i++)     //rozpoczęcie pętli piszącej wzorek pisanie pojedynczego wiersza
                {
                    for (int k = 0; k < wymiary[j,1]  ; k++)
                    {
                        if (i == 0/*górna linia*/|| k==0/*linia lewa*/|| i+1==wymiary[j,0]/*linia dolna*/||k==wymiary[j,1]-1)
                        {
                            Star();
                        }
                        else
                        {
                            Dot();
                        }

                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}