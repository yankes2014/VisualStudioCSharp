using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Student
    {
        private string nazwisko;
        private string imie;
        private int nrAlbumu;
        private int semestr;
        public Student(string imie, string nazwisko, int nralbumu, int semestr)
        {
            this.nazwisko = nazwisko;
            this.imie = imie;
            this.nrAlbumu = nralbumu;
            this.semestr = semestr;
        }

        public string Imie
        {
            get
            {
                return this.imie;
            }
            set
            {
                this.imie = value;
            }
        }
        public string Nazwisko
        {
            get
            {
                return this.nazwisko;
            }
            set
            {
                this.nazwisko = value;
            }
        }
        public int NrAlbumu
        {
            get
            {
                return this.nrAlbumu;
            }
            set
            {
                this.nrAlbumu = value;
            }
        }
        public int Semestr
        {
            get
            {
                return this.semestr;
            }
            set
            {
                this.semestr = value;
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Dominik = new Student("Dominik", "MojeNazwisko", 142, 2);
            Console.WriteLine(Dominik.Imie+ " " + Dominik.Nazwisko + " " + Dominik.NrAlbumu + " " + Dominik.Semestr);
            Console.ReadKey();
        }
    }
}
