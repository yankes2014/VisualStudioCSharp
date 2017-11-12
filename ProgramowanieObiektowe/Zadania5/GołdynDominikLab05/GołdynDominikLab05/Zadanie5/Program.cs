using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Zadanie5
{
    class Baza
    {
        Komputer[] lista = new Komputer[20];
        public int licznik =0;
        public Baza(int rozmiar)
        {
            Array.Resize(ref lista, rozmiar);
        }
        public void Wczytaj(string nazwa)
        {
            StreamReader plik = new StreamReader(nazwa + ".txt");
            string a;
            a = plik.ReadLine();
            string[] tablica = new string[5];
            while (a != null)
            {
                tablica = a.Split(';');
                lista[licznik] = new Komputer(tablica[0], tablica[1],Convert.ToDouble( tablica[2]),Convert.ToDouble( tablica[3]),Convert.ToDouble( tablica[4]));
                licznik++;
                tablica = null;
                a = plik.ReadLine();
            }
        }
        public void Wyswietlanie()
        {
            for (int i = 0; i < licznik; i++)
            {
                Console.WriteLine((i+1) + " " + lista[i].Wyswietl());
            }
        }
        public void Zapisz(string nazwa)
        {
            StreamWriter plik2 = new StreamWriter(nazwa + ".txt");
            for (int i = 0; i < licznik; i++)
            {
                plik2.WriteLine(lista[i].Wyswietl());
            }
            plik2.Close();
        }
    }

    class Komputer
    {
        string nazwa;
        string producent;
        double cena;
        double RAM;
        double WielkoscDysku;
        public Komputer(string nazwa, string producent, double cena, double RAM, double WielkoscDysku)
        {
            this.nazwa = nazwa;
            this.producent = producent;
            this.cena = cena;
            this.RAM = RAM;
            this.WielkoscDysku = WielkoscDysku;
        }
        public string Wyswietl()
        {
            return "Nazwa " + this.nazwa + " producent " + this.producent + " cena " + this.cena + " RAM " + this.RAM + " DYSK " + this.WielkoscDysku;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Baza bazapierwsza = new Baza(20);
            bazapierwsza.Wczytaj("dane");
            bazapierwsza.Wyswietlanie();
            bazapierwsza.Zapisz("wyniki");
            Console.ReadKey();
        }
    }
}
