using System;

namespace probny_sprawdzian_zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine(TrapesoidIsoscelesArea(1,1,1,2));
            }
        }

        public static double TrapesoidIsoscelesArea(int a, int b, int c, int precision =2)
        {
            if (a > 0 && b > 0 && c > 0 && precision >= 2 && precision <= 8)
            {
                if (a > b + c || b > a + c || c > a + b)
                {

                    Console.WriteLine("object not exist");
                    throw new ArgumentException();
                }
                else
                {
                    double p = ((a - b) / 2);
                    double h = Math.Sqrt((double)(p * p) - (c * c));
                    double Area = Math.Sqrt(((double)(1 / 2) * (a + b)) * h);
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

/*double p = ((a - b) / 2;
double h = Math.Sqrt((double)(p * p) - (c * c))
                    double Area = Math.Sqrt(((double)(1 / 2) * (a + b)) *h))
                    Console.WriteLine(Math.Round(Area, precision));*/

