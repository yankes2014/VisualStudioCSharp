using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{

    delegate void Delegacja ( string tekst);

    class Student
    {
        string imie;
        public Student(string imie)
        {
            this.imie = imie;
        }
        public void PrzedstawSie(string komu)
        {
            Console.WriteLine("Czesc " + komu);
            Console.WriteLine("Jestem" + imie);
        }

    }
    class Program
    {
        static void DawajSuchara(string komu)
        {
            Console.WriteLine("Siema " + komu);
            Console.WriteLine("Jak nazywaja sie dwa takie same drzewa?");
            Console.WriteLine("......");
            Console.WriteLine("Klony");
        }
        static void Main(string[] args)
        {
            Student Jan = new Student("Jan");
            Delegacja CoTamMistrzu = new Delegacja(Jan.PrzedstawSie);
            //CoTamMistrzu("Mi");
            CoTamMistrzu += DawajSuchara;
            CoTamMistrzu("dr Wiliński");
            CoTamMistrzu -= Jan.PrzedstawSie;
            CoTamMistrzu("dr Wiliński");
            CoTamMistrzu += Jan.PrzedstawSie;
            CoTamMistrzu("dr Wiliński");
            Console.ReadKey();
            



        }
    }
}
