using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Program
    {
        class Punkt
        {
             double x;
             double y;
            public Punkt(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public double ZwrocX()
            {
                return this.x;
            }
            public double Zwrocy()
            {
                return this.y;
            }
        }
        class Prostokąt
        {
            Punkt P1;
            Punkt P2;
            public Prostokąt(Punkt p1, Punkt p2)
            {
                P1 = p1;
                P2 = p2;
            }
            double dlpozioma;
            double dlpionowa;
            public void  Dlugosci(Punkt a, Punkt b)
            {
                if (a.ZwrocX() < b.ZwrocX())
                    dlpozioma = a.ZwrocX() - b.ZwrocX();
                else
                    dlpozioma = b.ZwrocX() - a.ZwrocX();
                if (a.Zwrocy() < b.Zwrocy())
                    dlpionowa = b.Zwrocy() - a.Zwrocy();
                else
                    dlpionowa = a.Zwrocy() - b.Zwrocy();
                Console.WriteLine("Dlugosc pozioma to" + dlpozioma);
                Console.WriteLine("Dlugosc pionowa to" + dlpionowa);
            }
        }
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
