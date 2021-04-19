using System;

namespace zadanie_SMPSEQ3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string d = Console.ReadLine();
            string[] tablicab = b.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);  // konwertowanie stringa na pojedyncze elementy w tablicy
            string[] tablicad = d.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);  // tutaj to samo
            for (int i = 0; i < tablicab.Length; i++)   // długość pętli dla każdego elementu
            {
                bool wynik = false;             //jeśli nie ma obiektu to cw ma go wypisac                        

                for (int j = 0; j < tablicad.Length; j++)    // pętla na długość elementów
                {

                    if (tablicab[i] == tablicad[j])
                    {
                        wynik = true;                                       //sprawdzenie czy elementy pasują
                    }

                }
                if (!wynik)
                {
                    Console.Write(tablicab[i] + " ");
                }
            }
        }
    }
}
