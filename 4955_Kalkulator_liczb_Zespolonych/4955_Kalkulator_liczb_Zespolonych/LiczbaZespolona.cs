using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4955_LICZBY_ZESPOLONE
{
    class LiczbaZespolona
    {
        #region dane_prywatne
        private double _Re;
        private double _Im;
        #endregion

        #region właściwości_publiczne
        public double Re
        {
            get { return _Re; }
            set { _Re = value; }
        }
        public double Im
        {
            get { return _Im; }
            set { _Im = value; }
        }
        #endregion

        #region konstruktory
        public LiczbaZespolona()
        {
            _Re = 0;
            _Im = 0;
        }

        public LiczbaZespolona(double re, double im)
        {
            _Re = re;
            _Im = im;
        }
        #endregion

        #region metody publiczne
        public static LiczbaZespolona operator+ (LiczbaZespolona a, LiczbaZespolona b)
        {
            LiczbaZespolona wynik = new LiczbaZespolona(0, 0);
            wynik.Re = a.Re + b.Re;
            wynik.Im = a.Im + b.Im;
            return wynik;
        }
        public static LiczbaZespolona operator- (LiczbaZespolona a, LiczbaZespolona b)
        {
            LiczbaZespolona wynik = new LiczbaZespolona(0, 0);
            wynik.Re = a.Re - b.Re;
            wynik.Im = a.Im - b.Im;
            return wynik;
        }
        public static LiczbaZespolona operator/ (LiczbaZespolona a, LiczbaZespolona b)
        {
            LiczbaZespolona wynik = new LiczbaZespolona(0, 0);
            
            wynik.Re = ((a.Re * b.Re) + (a.Im * b.Im)) / (Math.Pow(b.Re, 2) + Math.Pow(b.Im, 2));
            wynik.Im = ((b.Re * a.Im) - (a.Re * b.Im)) / (Math.Pow(b.Re, 2) + Math.Pow(b.Im, 2));
            return wynik;
        }
        public static LiczbaZespolona operator* (LiczbaZespolona a, LiczbaZespolona b)
        {
            LiczbaZespolona wynik = new LiczbaZespolona(0, 0);
            wynik.Re = (a.Re * b.Re) - (a.Im * b.Im);
            wynik.Im = (a.Re * b.Im) + (a.Im * b.Re);
            return wynik;
        }
        public static LiczbaZespolona Sprzezona(LiczbaZespolona a)
        {
            return new LiczbaZespolona(a.Re, -a.Im);
        }
        public override string ToString()
        {
            return "("+ Re.ToString("F4")+" ,"+ Im.ToString("F4") +")";
        }
        #endregion
    }
}
