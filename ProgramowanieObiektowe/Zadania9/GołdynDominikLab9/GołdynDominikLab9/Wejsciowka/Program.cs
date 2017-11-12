using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wejsciowka
{
    //GR  B

    class Działania<T>
    {
        T obiekt;
        int wartosc;
        public Działania(T a, int b)
        {
            obiekt = a;
            wartosc = b;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Działania<int> jeden = new Działania<int>(15, 25);
            Działania<string> dwa = new Działania<string>("ola", 12);
            Console.ReadKey();
        }
    }
}
