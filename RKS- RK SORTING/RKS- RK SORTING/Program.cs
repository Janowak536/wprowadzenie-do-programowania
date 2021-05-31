using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace RKS__RK_SORTING
{
    public static class Program
    {
        static void Main()
        {
            string stringessumption = Console.ReadLine();
            string stringnumbers = Console.ReadLine();
            int[] assumption = Array.ConvertAll<string, int>(stringessumption.Split(" "), int.Parse);
            int[] numbers = Array.ConvertAll<string, int>(stringnumbers.Split(" "), int.Parse);
            int Length = assumption[0];
            int Max = assumption[1];

            ArrayList output = new ArrayList();
            var DCT = new Dictionary<int, int>();
            for (int i = 0; i < Length; i++)
            {
                if(DCT.ContainsKey(numbers[i]) == false)
                {
                    DCT.Add(numbers[i], 1);
                }
                else
                {
                    int temp = DCT[numbers[i]];
                    DCT[numbers[i]] = temp + 1;
                }
            }
            var sortedDict = from wartosc in DCT orderby wartosc.Value descending select wartosc;
            Dictionary<int, int>.ValueCollection wartosci = DCT.Values;
            Dictionary<int, int>.KeyCollection klucze = DCT.Keys;
            foreach(var element in sortedDict)
            {
                int WR = element.Key;
                int value = element.Value;
                for (int i = 0; i < value; i++)
                {
                    output.Add(WR);
                    output.Add(" ");
                }
            }
            output.RemoveAt((output.Count)-1);
            for (int i = 0; i < (Length*2)-1; i++)
            {
                Console.Write(output[i]);
            }
        }
    }
}
