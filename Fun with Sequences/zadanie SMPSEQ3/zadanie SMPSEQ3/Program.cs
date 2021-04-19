using System;

namespace zadanie_SMPSEQ3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string d = Console.ReadLine();
            string[] tablicab = b.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);  // tak trzeba
            string[] tablicad = d.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);  // tak trzeba
            for (int i = 0; i < tablicab.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < tablicad.Length; j++)
                {
                    if (tablicab[i] == tablicad[j])
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.Write(tablicab[i] + " ");
                }
            }
        }
    }
}
