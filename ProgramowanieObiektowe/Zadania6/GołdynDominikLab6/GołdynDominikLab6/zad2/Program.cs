using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Zwierze
    {
        // a co będzie jeśli zwierzęta maja swoje charakterystyczne cechy???
        public string rodzaj;
        public Zwierze(string r)
        {
            rodzaj = r;
        }
    }

    class Trener
    {
        public static void DajGlos(Zwierze z)
        {
            // a co będzie gdy pojawią sie inne zwierzęta???
            switch (z.rodzaj)
            {
                case "pies": Console.WriteLine("hau"); break;
                case "kot": Console.WriteLine("miau"); break;
                default: Console.WriteLine("???"); break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Zwierze p = new Zwierze("pies");
            Zwierze k = new Zwierze("kot");
            Zwierze m = new Zwierze("mysz");
            Trener.DajGlos(p);
            Trener.DajGlos(k);
            Trener.DajGlos(m);

        }
    }
}
