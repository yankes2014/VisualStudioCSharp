using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Zad3
{
    static class Sortowanie
    {
        public static void Sortuj(string nazwa)
        {
            StreamReader plik = new StreamReader(nazwa + ".txt");
            string[] tablica = new string[10];
            int i = 0;
            string a = plik.ReadLine();
            while (a!=null)
            {
                if (i + 3 > tablica.Length)
                    Array.Resize(ref tablica, tablica.Length + 5);
                tablica[i] = a;
                i++;
                a = plik.ReadLine();
            }

            for(int j=0;j<tablica.Length;j++)
                Console.WriteLine(tablica[j]);
            Array.Sort(tablica);
            Console.WriteLine("Podaj nazwe pliku do zapisu");
            StreamWriter plik2 = new StreamWriter(Console.ReadLine() + ".txt");
            for (int j = 0; j < tablica.Length; j++)
                if(tablica[j]!=null) 
                    plik2.WriteLine(tablica[j]);
            plik2.Close();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Sortowanie.Sortuj("plik");
            Console.ReadKey();
        }
    }
}
