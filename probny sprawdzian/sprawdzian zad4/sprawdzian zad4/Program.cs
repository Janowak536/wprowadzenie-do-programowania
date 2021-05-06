using System;

namespace sprawdzian_zad4
{
    class Program
    {
        static void Main()
        {
            string a = Console.ReadLine();
            string[] tablicab = a.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int result = 0;
            try
            {

                int b = int.Parse(tablicab[0]);
                int c = int.Parse(tablicab[1]);
                int d = int.Parse(tablicab[2]);

                if (b < c && b < d)
                {
                    if (c > d || c == d)
                    {
                        result = c - b;
                    }
                    else
                    {
                        result = d - b;
                    }


                }
                else if (c < b && c < d)
                {
                    if (b > d || b == d)
                    {
                        result = b - c;
                    }
                    else
                    {
                        result = d - c;
                    }
                }
                else if (d < b && d < c)
                {
                    if (b > c || b == c)
                    {
                        result = b - d;
                    }
                    else
                    {
                        result = c - d;
                    }
                }
                else if (b > c && b > d)
                {
                    if (c > d || c == d)
                    {
                        result = b - c;
                    }
                    else
                    {
                        result = b - d;
                    }

                }
                else if (c > b && c > d)
                {
                    if (b > d || b == d)
                    {
                        result = c - b;
                    }
                    else
                    {
                        result = c - d;
                    }
                }
                else if (d > b && d > c)
                {
                    if (b > c || b == c)
                    {
                        result = d - b;
                    }
                    else
                    {
                        result = d - c;
                    }
                    if (b == 2000000000 && d == -2000000000)
                    {
                        Console.WriteLine("overflow exception, exit");
                    }
                }
                Console.WriteLine(checked(result));
            }
            catch (FormatException)
            {
                Console.WriteLine("format exception, exit");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("argument exception, exit");
            }
            catch (OverflowException)
            {
                Console.WriteLine("overflow exception, exit");
            }
            catch (Exception)
            {
                Console.WriteLine("non supported exception, exit");
            }

        }
    }
}
