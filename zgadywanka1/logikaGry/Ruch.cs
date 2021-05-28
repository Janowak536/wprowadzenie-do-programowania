using System;
using System.Collections.Generic;
using System.Text;

namespace logikaGry
{
    public class Ruch
    {
        public int? Propozycja { get; }
        public Gra.Odpowiedz? Wynik { get; }
        public DateTime Czas { get; }

        public Gra.Status StatusGry { get; }

        public Ruch(int? propozycja, Gra.Odpowiedz? wynik, Gra.Status statusGry)
        {

            Propozycja = propozycja;
            Wynik = wynik;
            StatusGry = StatusGry;
            Czas = DateTime.Now;
        }

    }
}
