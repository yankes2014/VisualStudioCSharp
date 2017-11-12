using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadnr1
{

    delegate void Delegacja(double liczba);
    class WartosciDouble
    {
        double x;
        public WartosciDouble(double x)
        {
            this.x=x;
        }
        public void kwadrat(double a)
        {
            Console.WriteLine(Convert.ToString(a*a));

        }
        public void Sinus(double a)
        {
            Console.WriteLine(Convert.ToString(Math.Sin(a))); //zawsze jeden
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            WartosciDouble ja = new WartosciDouble(24);
            Delegacja moja = new Delegacja(ja.kwadrat);
            moja += ja.Sinus;
            moja(10);
                Console.ReadKey();

        }
    }
}
