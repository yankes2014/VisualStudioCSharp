using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        class Zespolona
        {
            double Re;
            double Im;
            public Zespolona(double re, double im)
            {
                Re = re;
                Im = im;
            }
            public Zespolona(Zespolona z)
                :this(z.Re, z.Im)
            {
            }
            public void Wyświetl()
            {
                if(Im>0)
                Console.WriteLine("{0} + {1}i",Re, Im);
                else
                    Console.WriteLine("{0} {1}i", Re, Im);
            }
            public static Zespolona dodaj(Zespolona z1, Zespolona z2)
            {
                return new Zespolona(z1.Re+z2.Re, z1.Im+z2.Im);
            }
            public static Zespolona Mnożenie(Zespolona z1, Zespolona z2)
            {
                return new Zespolona(z1.Re * z2.Re - z1.Im * z2.Im, z1.Im * z2.Re + z1.Re * z2.Im);
            }
         
        }
        static void Main(string[] args)
        {
            Zespolona z1 = new Zespolona(3, 4);
            Zespolona z2 = new Zespolona(3, -4);
            z1.Wyświetl();
            z2.Wyświetl();
            Zespolona z3 = Zespolona.Mnożenie(z1, z2);
            z3.Wyświetl();
            Zespolona z4 = Zespolona.dodaj(z1, z2);
            z4.Wyświetl();
            Console.ReadKey();
        }
    }
}
