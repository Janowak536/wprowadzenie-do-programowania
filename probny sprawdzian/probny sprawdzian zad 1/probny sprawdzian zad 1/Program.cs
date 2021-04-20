using System;

namespace probny_sprawdzian_zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a  = Console.ReadLine(); //to usunąć
            int n = Int32.Parse(a);  // tutaj zmienić żeby było int a = n i gotowe albo zmienić a na n
            if (n <= 3)
            {
                Console.WriteLine("error");
            }
            if(n%2==0)
            {
                n--;
            }
            for (int i = 0; i < ((n+1)/2); i++)  //wiersze
            {
                for (int j = 0; j < n; j++) //kolumny
                {
                    if ( i>j|| n-i<=j)
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
