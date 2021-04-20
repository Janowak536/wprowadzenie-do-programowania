using System;

namespace zadanie_sprawdzianprobny3
{
    class Program
    {
        static void Stringi(string a, string b, string c)
        {

            if (a == "" || b == "" || c == "")
            {
                throw new ArgumentException();
            }

        }

        static void pars(string a, string b, string c)
        {
            int d = Int32.Parse(a);
            int e = Int32.Parse(b);
            int f = Int32.Parse(c);
            bool success1 = Int32.TryParse(a, out d);
            bool success2 = Int32.TryParse(b, out e);
            bool success3 = Int32.TryParse(c, out f);
            if (success1 && success2 && success3)
            {

            }
            else
            {
                throw new FormatException();
            }

        }

        static void overflow(string a, string b, string c)
        {
            try
            {
                int d = Int32.Parse(a);
                int e = Int32.Parse(b);
                int f = Int32.Parse(c);
            }
            catch (OverflowException)
            {

                
            }
         
           
        }

        static void Main()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            try
            {
                Stringi(a, b, c);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("argument exception, exit", e);
            }

            try
            {
                pars(a, b, c);
            }
            catch (FormatException z)
            {

                Console.WriteLine("format exception, exit", z);
            }
            try
            {

                overflow(a, b, c);
            }
            catch (OverflowException g)
            {

                Console.WriteLine("format exception, exit", g);
            }


        }

    }
}
