using System;

namespace trojkat
{
    class Program
    {
        static void Main(string[] args)
        {
            trojkat t;
            t = new trojkat(5, 6, 10);
            Console.WriteLine(t.ToString());
            Console.WriteLine(t.Obwod);
            Console.WriteLine(t.ObliczObwod());


            trojkat domyslny = new trojkat();
            Console.WriteLine(domyslny);
        }
    }
}
