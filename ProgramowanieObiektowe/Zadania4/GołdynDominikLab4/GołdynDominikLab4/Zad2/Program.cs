using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Rachunek
    {
        double stankonta;
        string imie;
        public Rachunek(string imie, double stankonta)
        {
            this.imie = imie;
            this.stankonta = stankonta;
        }
    }

    class RachunekOszczednosciowy : Rachunek
    {
        double odsetki;
        public RachunekOszczednosciowy(double stankonta, string imie, double odsetki)
            : base(imie, stankonta)
        {
            this.odsetki = odsetki;
        }
    }

    class OpuszczonyDebet : Rachunek
    {
        int debet;
        public OpuszczonyDebet(string imie, double stankonta, int debet)
            :base(imie,stankonta)
        {
            this.debet = debet;
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
