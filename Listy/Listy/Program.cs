using System;
using System.Collections.Generic;

namespace Listy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string>();
            animals.Add("pies");
            animals.Add("kot");
            animals.Add("krowa");
            animals.Add("lew");
            animals.Add("tygrys");
            

            animals.RemoveAt(1);
            animals.RemoveAt(3);

            animals.Add("mucha");
            animals.InsertRange(1, new string[] { "gazela" });
           // animals.Insert(1, "gazela2");

            animals.Remove("gazela");

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }


            Console.WriteLine();


            if (animals.Contains("krowa"))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


            Console.WriteLine();


            Console.WriteLine(animals.IndexOf("mucha"));


            Console.WriteLine();


            animals.Reverse();

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }


            Console.WriteLine();


            animals.Sort((a, b) => (a.ToString()[0].CompareTo(b.ToString()[0])));
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine();

            animals.Sort((a, b) => (b.ToString()[0].CompareTo(a.ToString()[0])));
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
