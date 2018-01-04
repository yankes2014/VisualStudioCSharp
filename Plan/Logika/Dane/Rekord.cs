using System;
using System.Collections.Generic;

namespace Logika
{
    public class Rekord
    {
        private DateTime czasRozpoczecia;
        public DateTime CzasRozpoczecia
        {
            get
            {
                return czasRozpoczecia;
            }
            set
            {
                czasRozpoczecia = value;
            }
        }
        private DateTime czasZakonczenia;
        public DateTime CzasZakonczenia
        {
            get
            {
                return czasZakonczenia;
            }
            set
            {
                czasZakonczenia = value;
            }
        }
        private Przedmiot przedmiot;
        public Przedmiot Przedmiot
        {
            get
            {
                return przedmiot;
            }
            set
            {
                przedmiot = value;
            }
        }
        private Grupa grupa;
        public Grupa Grupa
        {
            get
            {
                return grupa;
            }
            set
            {
                grupa = value;
            }
        }
        private Sala sala;
        public Sala Sala
        {
            get
            {
                return sala;
            }
            set
            {
                sala = value;
            }
        }
        private List<Prowadzacy> prowadzacy;
        public List<Prowadzacy> Prowadzacy
        {
            get
            {
                return prowadzacy;
            }
            set
            {
                prowadzacy = value;
            }
        }
        private string kierunek;
        public string Kierunek
        {
            get
            {
                return kierunek;
            }
            set
            {
                kierunek = value;
            }
        }
        private Dzien dzien;
        public Dzien Dzien
        {
            get
            {
                return dzien;
            }
            set
            {
                dzien = value;
            }
        }
        private RodzajWydarzenia rodzajWydarzenia;
        public RodzajWydarzenia RodzajWydarzenia
        {
            get
            {
                return rodzajWydarzenia;
            }
            set
            {
                rodzajWydarzenia = value;
            }
        }

        public void Modyfikuj()
        {
            throw new System.Exception("Not implemented");
        }
        public Rekord()
        {
            
        }

    }

}
