using System;

namespace probny_sprawdzian_zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            string liczba1 = Console.ReadLine();
            string liczba2 = Console.ReadLine();
            string liczba3 = Console.ReadLine();
            string liczba4 = Console.ReadLine();
            string[] tablica1 = liczba1.Split(":");
            string[] tablica2 = liczba2.Split(":");
            string[] tablica3 = liczba3.Split(":");
            string[] tablica4 = liczba4.Split(":");

            int a = Int32.Parse(tablica1[1]);
            int b = Int32.Parse(tablica2[1]);
            int c = Int32.Parse(tablica3[1]);
            int precision = Int32.Parse(tablica4[1]);

            

            if (a > 0 && b > 0 && c > 0 && precision >= 2 && precision <= 8)
            {
                if (a > b + c || b > a + c || c > a + b)
                {
                    
                    Console.WriteLine("object not exist");
                    throw new ArgumentException();
                }
                else
                {
                    double p = ((double)a + b + c) / 2;
                    double Area = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
                    Console.WriteLine(Math.Round(Area, precision));


                }
            }
            else 
            {
                Console.WriteLine("wrong arguments");
                throw new ArgumentOutOfRangeException();

            }
          
        }
    }
}
