using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    abstract class Figura
    {
        string kolor;
        string nazwafigury;
        int pole;
        int obwod;
        public Figura(string kolor, string nazwafigury, int pole, int obwod)
        {
            this.kolor = kolor;
            this.nazwafigury = nazwafigury;
            this.obwod = obwod;
            this.pole = pole;
        }
        public abstract void Wyświetl()
        {
            Console.WriteLine(this.kolor);
        }
    }

    class Trojkat : Figura
    {
        int bok;
        public Trojkat(string kolor, string nazwafigury, int pole, int obwod, int bok)
            : base(kolor, nazwafigury, pole, obwod)
        {
            this.bok = bok;
        }

    }
    class Prostokat : Figura
    {
        int boki;
        public Prostokat(string kolor, string nazwafigury, int pole, int obwod, int boki)
            : base(kolor, nazwafigury, pole, obwod)
        {
            this.boki = boki;
        }
    }
    class Kwadrat : Figura
    {
        int dlugoscboku;
        public Kwadrat(string kolor, string nazwafigury, int pole, int obwod, int bok, int dlugoscboku)
            : base(kolor, nazwafigury, pole, obwod)
        {
            this.dlugoscboku = dlugoscboku;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
