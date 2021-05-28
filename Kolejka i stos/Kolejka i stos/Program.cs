using System;
using System.Collections.Generic;

namespace Kolejka_i_stos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stos = new Stack<string>();
            stos.Push("1");
            stos.Push("2");
            stos.Push("3");
            stos.Push("4");

            Queue<string> kolejka = new Queue<string>();
            kolejka.Enqueue("a");
            kolejka.Enqueue("b");
            kolejka.Enqueue("c");
            kolejka.Enqueue("d");

            foreach(string sztuka in stos)
            {
                Console.WriteLine(sztuka);
            }

            Console.WriteLine();


            foreach(var pozycja in kolejka)
            {
                Console.WriteLine(pozycja);
            }


            kolejka.Enqueue(stos.Pop());
            kolejka.Enqueue(stos.Pop());
            

            Console.WriteLine();
            Console.WriteLine();

            foreach (var pozycja in kolejka)
            {
                Console.WriteLine(pozycja);
            }

            Console.WriteLine();
            Console.WriteLine();

            foreach (string sztuka in stos)
            {
                Console.WriteLine(sztuka);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(stos.Peek());

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(kolejka.Peek());





        }
    }
}
