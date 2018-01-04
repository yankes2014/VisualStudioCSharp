using System;
namespace Logika
{
    public abstract class Osoba
    {
        private int id = 0;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        private string imie;
        public string Imie
        {
            get
            {
                return imie;
            }
            set
            {
                imie = value;
            }
        }
        private string nazwisko;
        public string Nazwisko
        {
            get
            {
                return nazwisko;
            }
            set
            {
                nazwisko = value;
            }
        }

    }

}
