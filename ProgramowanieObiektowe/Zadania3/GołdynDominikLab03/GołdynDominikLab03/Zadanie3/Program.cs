using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Operacje
    {
        public int liczba;
        public Operacje(int liczba)
        {
            this.liczba = liczba;
        }
        public int? Silnia()
        {
            
            if (this.liczba == 1) return 1;
            if (this.liczba < 1) return null;
            int suma = this.liczba;
            int liczba2 = liczba-1;
            do
            {
                suma = suma * liczba2;
                liczba2--;
            }
            while (liczba2 != 0);
            return suma;
        }
        
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Operacje a = new Operacje(5);

            Console.WriteLine(a.Silnia());
            Console.ReadKey();
        }
    }
}
