using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wejsciowka
{
    //GR B
    delegate double Delegat(int x);
    class Operacje
    {
        public static double Mcos(int x)
        {
            return Math.Cos(x);
        }  
    }

    class Program
    {
        static void Main(string[] args)
        {
            Delegat nowy = new Delegat(Operacje.Mcos);
            Console.WriteLine(nowy(10));
            Console.ReadKey();
        }
    }
}
