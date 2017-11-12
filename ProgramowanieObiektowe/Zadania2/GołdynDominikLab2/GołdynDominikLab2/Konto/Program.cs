using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Konto
{
    class Program
    {
        class Konto
        {
            int identyfikator;
            string login;
            static int ostatnieid;
            static string plik= "id";
            static Konto()
            {
                Console.WriteLine("Konstruktor statyczny");
                StreamReader sr = new StreamReader(plik + ".txt");
                ostatnieid = Convert.ToInt32(sr.ReadLine());
                sr.Close();
            }
            public Konto(string login)
            {
                Console.WriteLine("Konstruktor");
                identyfikator = ostatnieid + 1;
                ostatnieid++;
                StreamWriter sw = new StreamWriter(plik + ".txt");
                sw.WriteLine(ostatnieid);
                sw.Close();
                this.login = login;
            }
        }
            
        static void Main(string[] args)
        {
            Konto k1 = new Konto("admin1");
            Konto k2 = new Konto("admin2");
            Konto k3 = new Konto("admin3");

            Console.ReadKey();
        }
    }
}
