using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
         public static class Automat
        {
         
            public static double Odczytaj(string nazwa)
            {
                double suma = 0;
                StreamReader plik = new StreamReader(nazwa + ".txt");
                string a = plik.ReadLine();
                int[] tablica = new int[9];
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'a')
                    {
                        suma += 0.01;
                        tablica[0]++;
                    }
                    else
                        if (a[i] == 'b')
                        {
                            suma += 0.02;
                            tablica[1]++;
                        }
                        else
                            if (a[i] == 'c')
                            {
                                suma += 0.05;
                                tablica[2]++;
                            }
                            else
                                if (a[i] == 'd')
                                {
                                    suma += 0.1;
                                    tablica[3]++;
                                }
                                else
                                    if (a[i] == 'e')
                                    {
                                        suma += 0.2;
                                        tablica[4]++;
                                    }
                                    else
                                        if (a[i] == 'f')
                                        {
                                            suma += 0.5;
                                            tablica[5]++;
                                        }
                                        else
                                            if (a[i] == 'A')
                                            {
                                                suma += 1;
                                                tablica[6]++;
                                            }
                                            else
                                                if (a[i] == 'B')
                                                {
                                                    suma += 2;
                                                    tablica[7]++;
                                                }
                                                else
                                                    if (a[i] == 'C')
                                                    {
                                                        suma += 5;
                                                        tablica[8]++;
                                                    }
                }
                return suma;
            }
        }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine( Automat.Odczytaj("plik"));
            Console.WriteLine(Automat.Odczytaj("plik"));
            Console.WriteLine(Automat.Odczytaj("plik"));

            Console.ReadKey();
        }
    }
}

