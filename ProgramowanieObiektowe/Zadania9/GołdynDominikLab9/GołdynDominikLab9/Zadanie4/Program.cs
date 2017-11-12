using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Brygada<T> :IEnumerable
    {
        List<T> lista;

        public void Dodaj(T obiekt)
        {
            lista.Add(obiekt);
        }
        int ilosc = 0;
        public void Zlicz()
        {
            ilosc = 0;
            foreach (var item in lista)
            {
                ilosc++;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new Kolejnosc(lista);
        }
        public class Kolejnosc :IEnumerator
        {
            List<T> alfa;
            public Kolejnosc(List<T> a)
            {
                this.alfa = a;
            }

            public object Current
            {
                get { throw new NotImplementedException(); }
            }

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }

    class Osoba
    {
        string imie;
        string nazwisko;
        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public string Zwrocdane()
        {
            return this.imie + this.nazwisko;
        }
    }
    class Pracownik
    {
        string imie;
        string nazwisko;
        string zawod;
        public Pracownik(string a, string b, string c)
        {
            this.imie = a;
            this.nazwisko = b;
            this.zawod = c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Osoba Ja = new Osoba("mojeimie", "mojenazwisko");
            Brygada<Osoba> osobnicza = new Brygada<Osoba>();
            
        }
    }
}
