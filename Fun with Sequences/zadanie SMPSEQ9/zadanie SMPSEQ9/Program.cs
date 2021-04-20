using System;
using System.Linq;

namespace zadanie_SMPSEQ9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayOne = Console.ReadLine().Split(' ').Take(n).Select(int.Parse).ToArray();
            int m = int.Parse(Console.ReadLine());
            int[] arrayTwo = Console.ReadLine().Split(' ').Take(m).Select(int.Parse).ToArray();
            arrayOne.Sum();
            arrayTwo.Sum();
            if (arrayOne.Length >= 2 && arrayOne.Length <= 100 && arrayTwo.Length >= 2 && arrayTwo.Length <= 100)
            {
                if (arrayOne.Sum() / n==0)
                {
                    Console.WriteLine(string.Join(' ', arrayOne));
                    return;
                }
                if(arrayTwo.Sum() / m == 0)
                {
                    Console.WriteLine(string.Join(' ', arrayTwo));
                    return;
                }
                if ((arrayOne.Sum()/n) > (arrayTwo.Sum())/m)
                {
                    Console.WriteLine(string.Join(' ', arrayOne));
                }
                else
                {
                    Console.WriteLine(string.Join(' ', arrayTwo));
                }
            }

        }
    }
}