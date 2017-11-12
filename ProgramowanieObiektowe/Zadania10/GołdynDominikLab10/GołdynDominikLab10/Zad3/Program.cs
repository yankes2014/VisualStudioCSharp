using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Piksel
    {
        int x, y;

        public Piksel()
        {
            x = y = 0;
        }
        public Piksel(int i, int j)
        {
            x = i;
            y = j;
        }
        public override string ToString()
        {
            return "<" + x + ", " + y + ">";
        }
        public static bool operator ==(Piksel p1, Piksel p2)
        {
            if (p1.x == p2.x && p1.y == p2.y) return true;
            return false;   
        }

        public static bool operator !=(Piksel p1, Piksel p2)
        {
            if (p1.x != p2.x || p1.y != p2.y) return true;
            return false;
        }
      
        public override bool Equals(object obj)
        {
            
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            
           // throw new NotImplementedException();
            return base.Equals(obj);
        }

        
        public override int GetHashCode()
        {
            
            //throw new NotImplementedException();
            return base.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Piksel p1 = new Piksel(2, 4);
            Piksel p2 = new Piksel(2, 4);
            Console.WriteLine(p1.Equals(p2));
            Console.ReadKey();
        }
    }
}
