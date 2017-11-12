using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    abstract class Pracownik
    {
        protected string PESEL;
        protected string nazwisko;
        public Pracownik(string pesel, string nazwisko)
        {
            this.PESEL = pesel;
            this.nazwisko = nazwisko;
        }
        public abstract float ObliczPlace(float ilośćGodzin);
    }
    class PracownikFizyczny : Pracownik
    {
        float stawka;
        public PracownikFizyczny(string pesel, string nazwisko, float stawka)
            : base(pesel, nazwisko)
        {
            this.stawka = stawka;
        }

        public override float ObliczPlace(float ilośćGodzin)
        {
            return ilośćGodzin * stawka;
        }
    }
    class PracownikBiurowy : Pracownik
    {
        float stawka;
        float premia;
        public PracownikBiurowy(string pesel, string nazwisko, float stawka, float premia)
            : base(pesel, nazwisko)
        {
            this.stawka = stawka;
            this.premia = premia;
        }

        public override float ObliczPlace(float ilośćGodzin)
        {
            return ilośćGodzin * (stawka+premia);
        }
    }

    class Kierownik : PracownikBiurowy
    {
        int ile_pracownikow;
        public Kierownik(string pesel, string nazwisko, float stawka, float premia, int ile_pracownikow)
            : base(pesel, nazwisko, stawka, premia)
        {
            this.ile_pracownikow = ile_pracownikow;
        }
        public override float ObliczPlace(float ilośćGodzin)
        {
            return base.ObliczPlace(ilośćGodzin)*ile_pracownikow;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }
}
