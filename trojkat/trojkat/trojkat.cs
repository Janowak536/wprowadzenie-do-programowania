using System;
using System.Collections.Generic;
using System.Text;

namespace trojkat
{
    public class trojkat
    {
        public const int PRECYZJA = 4;
        //dane

        public double A { get; private set; }


        public double B { get; private set; }
        


        
        public double C { get; private set; }
        



        //konstruktory
        public trojkat()
        {
            A = B = C = 1.0;
        }
        public trojkat (double a, double b, double c)
        {
            a = Math.Round(a, PRECYZJA);
            b = Math.Round(b, PRECYZJA);
            c = Math.Round(c, PRECYZJA);
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("długości nie mogą być ujemne");
            if (a + b < c || a + c < b || b + c < a)
                throw new ArgumentException("niespełniony warunek trójkąta");
            A  =  a;
            B  =  b;
            C  =  c;
        }

        //ToString
        public override string ToString()
        {
            return $"trojkat (a={A}, b={B},c={C})";
        }

        //inne metody

        public double ObliczObwod()
        {
            return Math.Round(A + B + C, PRECYZJA);
        }

        public double Obwod => Math.Round(A + B + C, PRECYZJA);

        public double Pole => throw new NotImplementedException();

        public bool IsRownoboczny => (A == B && B == C);


    }
}
