using System;
using System.Collections.Generic;

namespace Logika
{
    public class Przedmiot
    {
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
        private int liczbaGodzWyklad;
        public int LiczbaGodzWyklad
        {
            get
            {
                return liczbaGodzWyklad;
            }
            set
            {
                liczbaGodzWyklad = value;
            }
        }
        private int liczbaGodzCwiczenia;
        public int LiczbaGodzCwiczenia
        {
            get
            {
                return liczbaGodzCwiczenia;
            }
            set
            {
                liczbaGodzCwiczenia = value;
            }
        }
        private int liczbaGodzLaboratoria;
        public int LiczbaGodzLaboratoria
        {
            get
            {
                return liczbaGodzLaboratoria;
            }
            set
            {
                liczbaGodzLaboratoria = value;
            }
        }
        private List<int> listaProwadzacychLaby;
        public List<int> ListaProwadzacychLaby
        {
            get
            {
                return listaProwadzacychLaby;
            }
            set
            {
                listaProwadzacychLaby = value;
            }
        }
        private List<int> listaProwadzacychCwiczenia;
        public List<int> ListaProwadzacychCwiczenia
        {
            get
            {
                return listaProwadzacychCwiczenia;
            }
            set
            {
                listaProwadzacychCwiczenia = value;
            }
        }
        private List<int> listaProwadzacychWyklad;
        public List<int> ListaProwadzacychWyklad
        {
            get
            {
                return listaProwadzacychWyklad;
            }
            set
            {
                listaProwadzacychWyklad = value;
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

        public Przedmiot()
        {
            
        }


    }

}
