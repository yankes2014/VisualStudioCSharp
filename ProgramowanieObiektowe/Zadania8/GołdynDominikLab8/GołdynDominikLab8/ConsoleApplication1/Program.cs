using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student : IComparable<Student>
    {
        string imię;
        string nazwisko;
        int numerIndeksu;
        int wiek;

        public Student(string im, string na, int w, int ind)
        {
            imię = im;
            nazwisko = na;
            wiek = w;
            numerIndeksu = ind;
        }

        public string Imię
        {
            get { return imię; }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
        }
        public int Wiek
        {
            get { return wiek; }
        }
        public int NumerIndeksu
        {
            get { return numerIndeksu; }
        }

        public override string ToString()
        {
            return String.Format("student {0} {1} lat {2} indeks numer:{3}", imię, nazwisko, wiek, numerIndeksu);
        }

        public class Ponazwiskku : IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {

                if (x.nazwisko.CompareTo(y.nazwisko) == 0) return 0;
                if (x.nazwisko.CompareTo(y.nazwisko) < 0) return -1;
                else
                    return 1;
            }
        }
        public class PoImieniu : IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {

                if (x.imię.CompareTo(y.imię) == 0) return 0;
                if (x.imię.CompareTo(y.imię) < 0) return -1;
                else
                    return 1;
            }
        }
        public int CompareTo(Student other)
        {
            if (this.wiek < other.wiek) return -1;
            if (this.wiek > other.wiek) return 1;
            else return 0;
        }
        /*
        public int Compare(Student x, Student y)
        {
            if (x.wiek < y.wiek) return -1;
            if (x.wiek > y.wiek) return 1;
            else return 0;
        }
        * */
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student ala = new Student("ala", "qqnaz", 15, 155);
            Student Ola = new Student("Ola", "mazara", 11, 189);
            List<Student> lista = new List<Student>();
            lista.Add(Ola);
            lista.Add(ala);
            lista.Sort(new Student.Ponazwiskku());
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
