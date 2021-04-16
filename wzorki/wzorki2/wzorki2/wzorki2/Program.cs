using System;
namespace wzorki2
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
                wymiary[i, 0] = valuesArray[0];
                wymiary[i, 1] = valuesArray[1];
            }
            for (int j = 0; j < wymiary.GetLength(0); j++)
            {
                for (int i = 0; i < wymiary[j, 0]; i++)
                {
                    for (int k = 0; k < wymiary[j, 1]; k++)
                    {
                        if ((i + k) % 2 != 0)
                            Dot();
                        else
                            Star();
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}