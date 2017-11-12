using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Punkt
    {
        public int X;
        public int Y;
        public Punkt(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Wyswietl()
        {
            Console.WriteLine("Wspolrzedne punktu to: x:{0}, Y:{1}", X, Y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Punkt a = new Punkt(2, 5);
            a.Wyswietl();
            Console.ReadKey();
        }
    }
}
