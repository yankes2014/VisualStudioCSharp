using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    // 0 Kasia 428
    // 1 Ala 723
    // 2 Maja 322
    class Kontakt
    {
        string nazwa;
        int numer;
        public int Numer
        {
            get { return this.numer; }
        }
        public string Nazwa
        {
            get { return this.nazwa; }
        }
        public Kontakt(string nazwa, int numer)
        {
            this.nazwa = nazwa;
            this.numer = numer;
        }
        public string ZwrocInformacje()
        {
            return nazwa + " " + numer;
        }
    }

    class ListaKontaktow
    {
        private Kontakt[] lista;
        private int licznik;
        public ListaKontaktow()
        {
            this.lista = new Kontakt[4];
            licznik = 0;
        }
        public void DodajDoListy(Kontakt a)
        {
            lista[licznik++] = a;
        }
        public Kontakt this[int numer]
        {
            get 
            {
                for(int i=0;i<licznik;i++)
                {
                    if (numer == lista[i].Numer)
                        return lista[i];
                }
                throw new Exception("nie znaleziono kontaktow");
            }
        }
        public Kontakt this[string nazwa]
        {
            get
            {
                for (int j = 0; j < licznik; j++)
                {
                    if (nazwa == lista[j].Nazwa)
                        return lista[j];
                }
                throw new Exception("Nie znaleziono kontaktu");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListaKontaktow kontakty = new ListaKontaktow();
            kontakty.DodajDoListy(new Kontakt("Kasia", 428));
            kontakty.DodajDoListy(new Kontakt("Jola", 322));
            kontakty.DodajDoListy(new Kontakt("Kleopatra", 999));

            try
            {
                Kontakt szukany = kontakty[142];
                Console.WriteLine(szukany.ZwrocInformacje());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
            Console.ReadKey();
        }
    }
}
