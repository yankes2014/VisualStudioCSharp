using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Tablica
    {
        private double[] tablica;
       
        // mozna definiować tak
        // private double[] tablica = new double[20];

        public Tablica(int rozmiar)
        {
            tablica = new double[rozmiar];
        }
        public void Wypisz()
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write("{0}  ", tablica[i]);
            }
        }

        public double this[int x]
        {
            get
            {
                return this.tablica[x];
            }
            set
            {
                tablica[x] = value;
            }
        }
        
           

        public double this[double x]
        {
            get
            {
                for (int i = 0; i < tablica.Length; i++)
                {
                    if (tablica[i] == x) return i;
                }
                throw new Exception("Nie znaleziono danego elementu");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Tablica t = new Tablica(10);
            t[0] = 2.9;
            t[1] = 18;
            t[2] = 199;
            Console.WriteLine(t[1]);
            t.Wypisz();
            Console.ReadKey();
        }
    }
}
