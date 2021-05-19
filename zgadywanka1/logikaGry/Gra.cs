using System;
using System.Collections.Generic;

namespace logikaGry
{
    public class Gra
    {
        //dane
        private readonly int wylosowanaLiczba;
        public int MinZakres { get; }
        public int MaxZakres { get; }

        // historia gry - lista ruchów
        private List<Ruch> historiaGry;
        public IReadOnlyList<Ruch> HistoriaGry => historiaGry;

        //konstruktory
        //public Gra() : this(1,100)
        //{
            
        //}

        public Gra( int min = 1, int max = 100 )
        {
            if (min >= max)
                throw new ArgumentException("min musi być mniejszy od max");
            wylosowanaLiczba = (new Random()).Next(min, max+1);
            MinZakres = min;
            MaxZakres = max;
            historiaGry = new List<Ruch>();
        }


        //inne metody

        public Odpowiedz Ocena(int propozycja)
        {
            if (propozycja < wylosowanaLiczba)
            {
                historiaGry.Add(new Ruch(propozycja, Odpowiedz.ZaMalo));
                return Odpowiedz.ZaMalo;
            }
            else if (propozycja > wylosowanaLiczba)
            {
                historiaGry.Add(new Ruch(propozycja, Odpowiedz.ZaDuzo));
                return Odpowiedz.ZaDuzo;
            }
            else
            {
                historiaGry.Add(new Ruch(propozycja, Odpowiedz.Trafiony));
                return Odpowiedz.Trafiony;
            }
        }

        public enum Odpowiedz {ZaMalo=-1, Trafiony=0, ZaDuzo=1};


    }
}
