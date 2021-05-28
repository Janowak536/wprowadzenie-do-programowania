using System;
using System.Collections.Generic;
using System.Linq;


namespace Zbiór
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "1", "3", "5", "2", "7", "8" };


            string[] array2 = { "2", "1", "5", "3", "9", "6" };

            foreach(var number in array1)
            {
                Console.WriteLine(number);
            }
        }
    }
}
