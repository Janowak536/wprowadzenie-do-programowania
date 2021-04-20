using System;

namespace zadanie_SMPSEQ7
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int[] nSplit = Array.ConvertAll<string, int>(n.Split(" "), int.Parse);
            string s = Console.ReadLine();
            int[] sSplit = Array.ConvertAll<string, int>(s.Split(" "), int.Parse);

            int b = 0;
            int zmiana = 0;
            for (int i = 0; i < nSplit[0] - 1; i++)
            {
                if (sSplit[i] > sSplit[i + 1])
                {
                    b++;
                }
                else if (b == 0)
                {
                    break;
                }
                else
                {
                    b++;
                    zmiana++;
                    break;
                }
            }
            for (int k = 0 + b; k < nSplit[0] - 1; k++)
            {
                if (sSplit[k] < sSplit[k + 1])
                {
                    b++;
                }
                else
                {
                    b++;
                    break;
                }
            }
            if (b == nSplit[0] - 1 && zmiana == 1)
            {
                Console.Write("Yes");
            }
            else
            {
                Console.Write("No");
            }
        }
    }
}
