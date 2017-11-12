using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

    public struct Zespolona
    {
        double real, imag;//pola

        public double Real
        { get { return real; } }

        public double Imag
        { get { return imag; } }

        //konstruktor
        public Zespolona(double real, double imag)
        {
            this.real = real;
            this.imag = imag;
        }

        // konstruktor CreateFromPolar, dodatkowy parametr bo też double, double
        public Zespolona(double promien, double argument, int i)
        {
            real = promien * System.Math.Cos(argument);
            imag = promien * System.Math.Sin(argument);
        }
        public static bool operator true(Zespolona z1)
        {
            return ( z1.imag != 0);

        }
        public static bool operator false(Zespolona z1)
        {
            return ( z1.imag == 0);
        }

        public static Zespolona operator -(Zespolona z1, int a)
        {
            z1.real = z1.real - a;
            z1.imag = z1.imag - a;
            return z1;
        }
        public static Zespolona operator -(Zespolona z1, Zespolona z2)
        {
            Zespolona z3 = new Zespolona(z1.real - z2.real, z1.imag - z2.imag);
            return z3;
        }
      
        public static Zespolona operator +(Zespolona z1, Zespolona z2)
        {

            return new Zespolona(z1.real + z2.real, z1.imag + z2.imag);
        }
        public static Zespolona operator ~(Zespolona z1)
        {
            z1.imag = -z1.imag;
            return z1;
        }
        public static double operator !(Zespolona z1)
        {
            return Math.Sqrt(z1.real + z1.imag);
        }
        public static Zespolona operator *(Zespolona z1, Zespolona z2)
        {
            return new Zespolona(z1.real * z2.real - z1.imag * z2.imag, z1.real * z2.imag + z1.imag * z2.real);
        }
        public static Zespolona operator /(Zespolona z1, int b)
        {
            z1.real = z1.real / b;
            z1.imag = z1.imag / b;
            return z1;
        }
        public static bool operator == (Zespolona z1, Zespolona z2)
        {
            if (z1.real == z2.real && z1.imag == z2.imag)
                return true;
            return false;
        }
        public static bool operator !=(Zespolona z1, Zespolona z2)
        {
            if (z1.real != z2.real || z1.imag != z2.imag)
                return true;
            return false;
        }
        // ToString
        public override string ToString()
        {
            string s = Real.ToString();
            if (Imag >= 0) s += "+i"; else s += "-i";
            s += Math.Abs(Imag);
            return s;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Zespolona z1 = new Zespolona(2, 14);
            Zespolona z2 = new Zespolona(20, 13);
            z1 = z1 - 5;
            z1 = z1 - z2;
            Console.WriteLine(z1.ToString());
            Console.WriteLine(z1.Imag);
            Console.WriteLine(z1.Real);
            Console.WriteLine(z1==z2);
            Console.WriteLine(z1==z1);
            Console.ReadKey();
        }
    }
}
