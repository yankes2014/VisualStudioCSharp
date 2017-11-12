using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rachunek
{
    class Program
    {
        class Rachunek
        {
            const decimal vat = 0.23M;
            int identyfkator;
            public int Identyfikator
            {
                get { return identyfkator; }
                set { identyfkator = value; }
            }
            decimal saldo;
            public decimal SaldoZVat
            {
                get 
                { 
                    return saldo+saldo*vat; 
                }
                set { saldo = value/(1+vat); }
            }
            public Rachunek(int identyfikator, decimal saldo)
            {
                this.identyfkator = identyfikator;
                this.saldo = saldo;
            }
          
            public void Wyswietl()
            {
                Console.WriteLine(this.identyfkator + " " + this.saldo);
            }


        }
        static void Main(string[] args)
        {
            Rachunek r1 = new Rachunek(1, 10.0M);
            r1.Wyswietl();
            Console.WriteLine(r1.Identyfikator);
            Console.WriteLine(r1.SaldoZVat);
            r1.SaldoZVat = 123;
            r1.Wyswietl();

            Console.ReadKey();
        }
    }
}
