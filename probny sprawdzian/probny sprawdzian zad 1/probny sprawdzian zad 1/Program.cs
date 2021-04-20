using System;

namespace probny_sprawdzian_zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine(); //to usunąć
            int a = Int32.Parse(n);  // tutaj zmienić żeby było int a = n i gotowe albo zmienić a na n
            if (a < 3)
            {
                Console.WriteLine("error");
            }
            if(a%2==0)
            {
                a--;
            }
            for (int i = 0; i < a; i++)  //wiersze
            {
                for (int j = 0; j < a; j++) //długość
                {
                    if ( i>j|| a-i<=j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
