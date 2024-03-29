using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1._3
{
    internal class Paczka
    {
        private string rodzajPaczki;
        int dlugosc, wysokosc, szerokosc;
        int objetosc;
        public static int MaxObj(Paczka[] paczki)
        {
            int max = 0;
            foreach(Paczka p in paczki)
            {
                if(p.objetosc > max)
                {
                    max = p.objetosc;
                }
            }
            return max;
        }
        public Paczka(string rodzajPaczki, int dlugosc, int wysokosc, int szerokosc)
        {
            this.rodzajPaczki = rodzajPaczki;
            this.dlugosc = dlugosc;
            this.wysokosc = wysokosc;
            this.szerokosc = szerokosc;
            objetosc = dlugosc * wysokosc * szerokosc;
        }

        public override string ToString()
        {
            return $"Rodzaj paczki: {rodzajPaczki}, długość: {dlugosc}, wysokosc: {wysokosc}, szerokosc: {szerokosc}, objetosc: {objetosc}";
        }
    }
}
