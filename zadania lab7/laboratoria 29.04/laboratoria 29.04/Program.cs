using System;
using System.Collections.Generic;

namespace laboratoria_29._04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string>();
            animals.Add ("pies");
            animals.Add("kot");
            animals.Add("koń");
            animals.Add("hipopotam");
            animals.Add("pingwin");
            animals.Add("lemur");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
            animals.RemoveAt(1);
            animals.RemoveAt(5);
            Console.WriteLine(string.Join(", ",animals));
            animals.Add("mucha");
            animals.Insert(1, "gazela");
            Console.WriteLine(string.Join(", ",animals));
            animals.Remove("gazela");
            Console.WriteLine(string.Join(", ",animals));
            if (animals.Contains("krowa"))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
