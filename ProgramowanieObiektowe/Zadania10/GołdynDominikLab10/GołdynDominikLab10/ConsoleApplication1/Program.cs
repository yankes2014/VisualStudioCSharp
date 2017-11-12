using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    //Gr A

    public class Firma<T> : IEnumerable
    {
        ArrayList firma = new ArrayList();
        public Firma()
        {
            firma.Add("Firma 1");
            firma.Add("Firma 2");
        }

        public IEnumerator GetEnumerator()
        {
            return firma.GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Firma<string> moja = new Firma<string>();
            foreach (var item in moja)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
