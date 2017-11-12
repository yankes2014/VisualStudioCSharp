using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3

{
    class House : IComparable
    {
        private decimal price;
        private int year;
        private double squareMeters;

        public House(decimal price, int year, double squareMeters)
        {
            this.price = price;
            this.year = year;
            this.squareMeters = squareMeters;
        }
        int Compare(Object x, Object y)
        {
            return  
        }
    
        //?
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
