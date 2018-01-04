using System;
namespace Logika
{
    public class Sala
    {
        private string numer;
        public string Numer
        {
            get
            {
                return numer;
            }
            set
            {
                numer = value;
            }
        }
        private int pojemnosc;
        public int Pojemnosc
        {
            get
            {
                return pojemnosc;
            }
            set
            {
                pojemnosc = value;
            }
        }
        private string budynek;
        public string Budynek
        {
            get
            {
                return budynek;
            }
            set
            {
                budynek = value;
            }
        }
        private TypSali typSali;
        public TypSali TypSali
        {
            get
            {
                return typSali;
            }
            set
            {
                typSali = value;
            }
        }

        public Sala()
        {
            
        }

    }

}
