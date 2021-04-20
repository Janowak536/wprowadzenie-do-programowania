using System;

namespace zadanie_SMPSEQ6
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string[] aSplit = a.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] bSplit = b.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] cSplit = c.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = Int32.Parse(aSplit[0]);
            int x = Int32.Parse(aSplit[1]);
            if(x>=0)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int y = -x;y<=x ; y++)
                    {
                        if (i+y<n)
                        {
                            if(i+y>=0)
                            {
                                if (bSplit[i] == cSplit[i+y])
                                {
                                    Console.Write($"{i+1}" + " ");
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.Write("");
            }

        }
    }
}
