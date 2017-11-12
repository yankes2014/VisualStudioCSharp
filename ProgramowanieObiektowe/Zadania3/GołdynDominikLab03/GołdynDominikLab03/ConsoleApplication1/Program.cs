using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Obliczenia
    {
        int x;
        public  int Dodaj(int x)
        {
            return this.x + 10;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Obliczenia x = new Obliczenia();
            x.Dodaj(15);
            Console.ReadKey(); //A
        }
    }
}
