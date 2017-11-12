using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{

    public class Pracownik
    {
        string nazwisko;
        string stanowisko;

        public string Stanowisko { get { return stanowisko; } set { this.stanowisko = value; } }
        public string Nazwisko { get { return nazwisko; } }

        public Pracownik(string n, string s) 
        {
            nazwisko = n;
            stanowisko = s; 
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Nazwisko, Stanowisko); 
        }
   }

    public class Firma : IEnumerable
    { 
        string nazwa;
        int licznik = 0;
        private Pracownik[] pracownicy;
    //... tu inne metody
        public Firma(string a)
        {
            this.pracownicy = new Pracownik[4];
            this.nazwa = a;
        }
        public void Dodajdolisty(Pracownik a)
        {
            if (licznik < pracownicy.Length)
            {
                pracownicy[licznik] = a;
                licznik++;
            }
            else
            {
                Array.Resize(ref pracownicy, pracownicy.Length + 4);
                pracownicy[licznik] = a;
                licznik++;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new PoKolei(this);
        }

        public class PoKolei : IEnumerator
        {

            int indeks;
            Firma firma;

            public PoKolei(Firma a)
            {
                indeks = -1;
                this.firma = a;
            }
            public object Current    /////////////zwroci pracownika
            {
                
                get {
                    Console.WriteLine("current");
                    return firma.pracownicy[indeks]; }
            }

            public bool MoveNext()  
            {
                Console.WriteLine("movenext");
                if (indeks < firma.licznik-1)
                {
                    indeks++;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                Console.WriteLine("REset");
                indeks = 0;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Pracownik ola = new Pracownik("ola", "koziol");
            Pracownik kasia = new Pracownik("kasia", "tak");
            Firma mojafirma = new Firma("Nazwa");
            mojafirma.Dodajdolisty(ola);
            mojafirma.Dodajdolisty(kasia);
            mojafirma.Dodajdolisty(ola);
            mojafirma.Dodajdolisty(kasia);
            Pracownik jarek = new Pracownik("Jarek", "Analityk");
            foreach (Pracownik item in mojafirma)
            {
                //item.Stanowisko = "Woźny";
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
