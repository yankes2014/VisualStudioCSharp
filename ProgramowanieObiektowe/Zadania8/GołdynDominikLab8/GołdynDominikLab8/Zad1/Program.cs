using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class DowolnaKlasa<T>
    {
        T costam;
        string tekst;
        public DowolnaKlasa(string tekst)
        {
            this.tekst = tekst;
        }
        public void UstawCosTam(T alfa)
        {
            this.costam = alfa;
        }
    
        public void Wyswietlanie()
        {
            Console.WriteLine(this.tekst +" " + this.costam);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            DowolnaKlasa<string> jeden = new DowolnaKlasa<string>("Partycja");
            jeden.UstawCosTam("pies");
            jeden.Wyswietlanie();
            DowolnaKlasa<int> dwa = new DowolnaKlasa<int>("Ksieciu:)");
            dwa.UstawCosTam(154);
            dwa.Wyswietlanie();
            Console.ReadKey();
        }
    }
}
