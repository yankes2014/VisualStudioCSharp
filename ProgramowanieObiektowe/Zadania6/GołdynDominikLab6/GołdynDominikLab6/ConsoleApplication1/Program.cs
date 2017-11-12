using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class UjemnaException : ApplicationException
    {
        public UjemnaException() : base("liczba ujemna") { }
    }

    class DoubleUjemna 
    {
        double wartosc;
        
        public double właściwości
        {
            get { return this.wartosc; }
            set
            {
                if (value > 0)
                    throw new UjemnaException();
                else this.wartosc = value;
                    
                
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {

            DoubleUjemna liczba = new DoubleUjemna();
            try
            {
                liczba.właściwości = -250;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            //liczba.właściwości = 250;

            Console.ReadKey();
        }
    }
}
