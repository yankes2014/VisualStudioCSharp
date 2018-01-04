using System;
using System.Collections.Generic;

namespace Logika
{
    public class Grupa
    {
        private List<Osoba> listaOsob;
        public List<Osoba> ListaOsob
        {
            get
            {
                return listaOsob;
            }
            set
            {
                listaOsob = value;
            }
        }
        private string nazwa;
        public string Nazwa
        {
            get
            {
                return nazwa;
            }
            set
            {
                nazwa = value;
            }
        }
        private int semestr;
        public int Semestr
        {
            get
            {
                return semestr;
            }
            set
            {
                semestr = value;
            }
        }
        private StopienStudiow stopien;
        public StopienStudiow Stopien
        {
            get
            {
                return stopien;
            }
            set
            {
                stopien = value;
            }
        }
        private RodzajGrupy rodzajGrupy;
        public RodzajGrupy RodzajGrupy
        {
            get
            {
                return rodzajGrupy;
            }
            set
            {
                rodzajGrupy = value;
            }
        }
        private TrybStudiow trybStudiow;
        public TrybStudiow TrybStudiow
        {
            get
            {
                return trybStudiow;
            }
            set
            {
                trybStudiow = value;
            }
        }

        private string kierunek;

        public string Kierunek
        {
            get { return kierunek; }
            set { kierunek = value; }
        }

        private StopienStudiow stopienStudiow;

        public StopienStudiow StopienStudiow
        {
            get { return stopienStudiow; }
            set { stopienStudiow = value; }
        }


        public Grupa()
        {
            
        }


    }

}
