﻿using System;
using System.Collections.Generic;
using System.Text;
using logikaGry;

namespace GraConsoleApp
{
    public class Kontroler
    {
        private Gra gra;
        private Widok widok;

        public Kontroler()
        {
            gra = new Gra();
            widok = new Widok();
        }

        public void Rozgrywka()
        {
            widok.CzyscEkran();
            gra = new Gra(1, 100);
            do
            {
                int propozycja;
                    try
                    {
                        propozycja = widok.WczytajLiczbe();
                    }
                catch (PrzerwaneWprowadzenieException)
                {
                    gra.Poddaj();
                    break;
                }

                switch (gra.Ocena(propozycja))
                {
                    case Gra.Odpowiedz.ZaDuzo:
                        widok.WypiszKomunikatZaDuzo(); break;
                    case Gra.Odpowiedz.ZaMalo:
                        widok.WypiszKomunikatZaMalo(); break;
                    case Gra.Odpowiedz.Trafiony:
                        widok.WypiszKomunikatTrafiony(); break;
                }
            }
            while (gra.StatusGry == Gra.Status.Trwa);

        }
        public void Run()
        {
            widok.CzyscEkran();
            widok.WypiszOpisGry();
            while(widok.ChceszKontynuowac())
            {
                Rozgrywka();
            }
        }

    }
}
