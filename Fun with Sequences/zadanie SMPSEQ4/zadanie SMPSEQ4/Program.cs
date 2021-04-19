using System;

namespace zadanie_SMPSEQ4
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
                bool found = true;
                for (int j = 0; j < tablicad.Length; j++)
                {
                    if (tablicab[i] == tablicad[j])
                    {
                        found = false;
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

