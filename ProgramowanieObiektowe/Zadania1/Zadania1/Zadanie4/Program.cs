using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Konto
    {
        public int saldo;
        public Konto(int kwota)
        {
            this.saldo = kwota;
        }

    }
    class Klient
    {
        public string imie;
        public string nazwisko;
        public Konto konto;
        public Klient(string imie, string nazwisko, Konto konto)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.konto = konto;
        }
        public void WplacNaKonto(int kwota)
        {
            if(kwota>0)
            {
                konto.saldo += kwota;
            }
        }
        public void WyplacZKonta(int kwota)
        {
            if(kwota<konto.saldo)
            {
                konto.saldo -= kwota;
            }
        }
        public void SaldoKonta()
        {
            Console.WriteLine("Saldo twojego konta wynosi: " + konto.saldo);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Klient Dominik = new Klient("Dominik", "MojeNazwisko", new Konto(1500));
            Dominik.WplacNaKonto(200);
            Dominik.SaldoKonta();
            Dominik.WyplacZKonta(700);
            Dominik.SaldoKonta();
            Console.ReadKey();
                
        }
    }
}
