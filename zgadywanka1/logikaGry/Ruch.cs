using System;
using System.Collections.Generic;
using System.Text;

namespace logikaGry
{
    public class Ruch
    {
        public int Propozycja { get; }
        public Gra.Odpowiedz Wynik { get; }
        public DateTime Czas { get; }

        public Ruch(int propozycja, Gra.Odpowiedz wynik)
        {
            Propozycja = propozycja;
            Wynik = wynik;
            Czas = DateTime.Now;
        }

    }
}
