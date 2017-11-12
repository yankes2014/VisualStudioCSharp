using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    class SuperString
    {
        string tekst;
        public SuperString(string a)
        {
            tekst = a;
        }
        public void wypisz()
        {
            Console.WriteLine(this.tekst);
        }

        public static bool operator <(SuperString b, SuperString c)
        {
            if (b.tekst.CompareTo(c.tekst) < 0) return true;
            return false;
        }
        public static bool operator <=(SuperString b, SuperString c)
        {
            if (b.tekst.CompareTo(c.tekst) <= 0) return true;
            return false;
        }
        public static bool operator >(SuperString b, SuperString c)
        {
            if (b.tekst.CompareTo(c.tekst) > 0) return true;
            return false;
        }
        public static bool operator >=(SuperString b, SuperString c)
        {
            if (b.tekst.CompareTo(c.tekst) >= 0) return true;
            return false;
        }
        public static SuperString operator !(SuperString a)
        {
            char[] alfa = a.tekst.ToCharArray();
            string b = "";
            for (int i = alfa.Length-1; i >=0; i--)
            {
                b += alfa[i];
            }
            a.tekst = b;
            return a;
        }
        public static SuperString operator >>(SuperString a)
        {
            char[] alfa = a.tekst.ToCharArray();
            string b ="";
            for(int i=0;i<alfa.Length-2;i++)
                b+=alfa[i];
            a.tekst = b;
            return a;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            SuperString alfa = new SuperString("Ala");
            SuperString beta = new SuperString("Wawawawa");
            SuperString an = new SuperString("a");
            Console.WriteLine(alfa>beta);
            alfa = !alfa;
            alfa.wypisz();
            beta = !beta;
            beta.wypisz();
            an = !an;
            an.wypisz();
            alfa.wypisz();
            
            alfa.wypisz;
            Console.ReadKey();
            
        }
    }
}
