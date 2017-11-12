using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wejsciowka
{
    
    //grB

    class Wektor
    {
        public double x, y, z;
        public Wektor(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public static Wektor operator ++(Wektor w)
        {
            w.x++;
            w.y++;
            w.z++;
            return w;
        }
    
    
    }

    class Program
    {
        static void Main(string[] args)
        {

            Wektor moj = new Wektor(2, 3, 4);
            moj++;
            Console.WriteLine(Convert.ToString(moj.x+ " " + moj.y + " " + moj.z));


            Console.ReadKey();
        }
    }
}
