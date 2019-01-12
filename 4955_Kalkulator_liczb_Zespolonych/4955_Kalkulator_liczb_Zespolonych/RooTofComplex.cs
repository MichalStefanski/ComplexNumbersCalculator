using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4955_LICZBY_ZESPOLONE;

namespace _4955_Kalkulator_liczb_Zespolonych
{
    class RooTofComplex
    {    
        private double ModulZ(LiczbaZespolona liczba, double n = 1) // moduł liczby z
        {
            return Math.Pow(Math.Sqrt(Convert.ToDouble((liczba.Im * liczba.Im) + (liczba.Re * liczba.Re))), n);
        }
        private float Fi(LiczbaZespolona liczba) // argument liczby z
        {
            float fi = 0;
            double cosFi = liczba.Re / ModulZ(liczba);
            double sinFi = liczba.Im / ModulZ(liczba);
            fi = (float)(Math.Asin(sinFi) * (180 / Math.PI));
            if (cosFi < 0)
            {
                if (sinFi > 0)
                {
                    fi = 180 - fi;
                }
                else
                {
                    fi = -fi - 180;
                }
            }
            return fi;
        }

        // liczba zespolona, współczynnik potęgi n, dla k=0,1,...,n-1
        public LiczbaZespolona Rownanie(LiczbaZespolona liczba, int n, int k)
        {
            LiczbaZespolona z = new LiczbaZespolona();
            double fi = Math.PI * Fi(liczba) / 180;
            z.Re = Math.Round(Math.Cos((fi + (2 * k * Math.PI)) / n), 4);
            z.Im = Math.Round(Math.Sin((fi + (2 * k * Math.PI)) / n), 4);
            return z;
        }
        public string Trigon(LiczbaZespolona liczba, LiczbaZespolona zespolona, double n)
        {
            return ModulZ(zespolona, n) +" (cos " + Fi(liczba).ToString("F2") + " + i sin " + Fi(liczba).ToString("F2") + ")";
        }      
        public string Canonic(LiczbaZespolona liczba)
        {
            if (liczba.Im < 0)
            {
                return liczba.Re.ToString("F4") + " - " + (liczba.Im *(-1)).ToString("F4") + " i";
            }
            else 
            {
                return liczba.Re.ToString("F4") + " + " + liczba.Im.ToString("F4") + " i";
            }
            
        }
    }
}
