using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_0
{
    class Punkt
    {
        protected double x;
        double y;
        public Punkt(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual string ZwrocDane()
        {
            return string.Format("({0},{1})", x,y);
        }
        public abstract void Metoda(); // nie mozna
        
    }

    class PunktKolorowy : Punkt
    {
        string kolor;
        public PunktKolorowy(int x, int y, string kolor)
            : base(x, y)
        {
            this.kolor = kolor;
        }
        public string Pokaz()
        {
            return ZwrocDane() + this.kolor + base.x;
        }
        public override string ZwrocDane()
        {
            return base.ZwrocDane() + " " + this.kolor;
        }
    }

    class PunktKolorowyOpisany : PunktKolorowy
    {
        string opis;
        public PunktKolorowyOpisany(int x, int y, string kolor, string opis)
            : base(x, y, kolor)
        {
            this.opis = opis;
        }
        public override string ZwrocDane()
        {
            return base.ZwrocDane() + " " + this.opis;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Punkt P1 = new Punkt(1, 3);
            PunktKolorowy P2 = new PunktKolorowy(221, 7, "zielony");
            Console.WriteLine(P1.ZwrocDane());
            Console.WriteLine(P2.Pokaz());
            Punkt P3 = new PunktKolorowy(2, 3, "Rudy");
            //Polimorfizm
            List<Punkt> lista = new List<Punkt>();
            lista.Add(P1);
            lista.Add(P2);
            lista.Add(P3);

            foreach (var item in lista)
            {
                Console.WriteLine( item.ZwrocDane());
            }
            
            Console.ReadKey();
        }
    }
}
