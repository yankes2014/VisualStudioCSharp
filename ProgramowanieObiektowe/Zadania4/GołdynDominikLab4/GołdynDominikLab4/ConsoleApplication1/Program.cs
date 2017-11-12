using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class ZespółJezdziecki
    {
        public string nazwisko;
        public string imieKonia;
        public int ranking;
        public ZespółJezdziecki(string nazwisko, string imieKonia, int ranking)
        {
            this.nazwisko = nazwisko;
            this.imieKonia = imieKonia;
            this.ranking = ranking;
        }
        public string this[string nazwisko]
        {
            get { return this.nazwisko + this.imieKonia + this.ranking; }

        }
    
        

        
    }



    class Program
    {
        static void Main(string[] args)
        {
            ZespółJezdziecki ddd= new ZespółJezdziecki("tak","konarafal",144);
            Console.WriteLine(ddd["tak"]);
            Console.ReadKey();
        }
    }
}
