using System;

namespace zadanie_sprawdzianprobny3
{
    class Program
    {
        static void Main()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            try
            {
                Stringi(a, b, c);
            
                try
                {
                    overflow(a, b, c);
                      try
                      {
                             
                             pars(a, b, c);
                      }
                      catch (FormatException z)
                      {

                      Console.WriteLine("format exception, exit", z);
                        return;
                      }
                     
                }
                catch (OverflowException g)
                {

                Console.WriteLine("overflow exception, exit", g);
                    return;
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("argument exception, exit", e);
                return;
            }
            suma(a, b, c);
        }
        static void suma(string a, string b, string c)
        {
            int d = Int32.Parse(a);
            int e = Int32.Parse(b);
            int f = Int32.Parse(c);

            Console.WriteLine(d+e+f);

        }


        static void Stringi(string a, string b, string c)
        {

            if (a == "" || b == "" || c == "")
            {
                throw new ArgumentException();
            }

        }

        static void pars(string a, string b, string c)
        {
            
            try
            {
                Int32.Parse(a);

            }
            catch (FormatException)
            {
                throw new FormatException();
            }
            try
            {
                 Int32.Parse(b);

            }
            catch (FormatException)
            {
                throw new FormatException();
            }
            try
            {
                Int32.Parse(c);

            }
            catch (FormatException)
            {
                throw new FormatException();
            }
          


        }

        static void overflow(string a, string b, string c)
        {
           
            try
            {
                 Int32.Parse(a);
                
            }
            catch (OverflowException)
            {
                throw new OverflowException();
            }
            try
            {
                Int32.Parse(b);
                
            }
            catch (OverflowException)
            {
                throw new OverflowException();
            }
            try
            {
                Int32.Parse(c);
                
            }
            catch (OverflowException)
            {
                throw new OverflowException();
            }
        }
    }
}
