using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Kolejka<T>
    {
        T[] tablica = new T[3];
        int licznik = 0;
        public void DodajDoKolejki(T nowa)
        {
            if (licznik == 3)
            {
                throw new Exception("Brak Miejsca");
                return;
            }
            else
            tablica[licznik] = nowa;
            licznik++;
        }
        public void Wyswietldane()
        {
            for(int i=0;i<licznik;i++)
                Console.WriteLine(tablica[i]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kolejka<string> kolej1 = new Kolejka<string>();
            kolej1.DodajDoKolejki("Alicja");
            kolej1.DodajDoKolejki("Ola");
            kolej1.DodajDoKolejki("Patryk");
            try
            {
                kolej1.DodajDoKolejki("Jan");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            kolej1.Wyswietldane();
            Console.ReadKey();

        }
    }
}
