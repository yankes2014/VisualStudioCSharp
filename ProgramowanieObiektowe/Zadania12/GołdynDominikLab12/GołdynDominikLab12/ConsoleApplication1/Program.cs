using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace ConsoleApplication1
{
    [Serializable]
    class Osoba
    {
        string imie;
        int rokUrodzenia;
        public Osoba(string imie, int rok)
        {
            this.imie = imie;
            this.rokUrodzenia = rok;
        }
        public override string ToString()
        {
            return imie + " " + rokUrodzenia;
        }
    }
    class Program
    {
        static void Serializuj(Osoba o, string nazwa)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(nazwa, FileMode.Create);
            bf.Serialize(fs, o);
            fs.Close();
        }

        static void SerializujListe(List<Osoba> o, string nazwa)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(nazwa, FileMode.Create);
            bf.Serialize(fs, o);
            fs.Close();
        }

        static Osoba Deserializuj(string nazwa)
        {
            BinaryFormatter bfa = new BinaryFormatter();
            FileStream qwe = new FileStream(nazwa, FileMode.Open);
            Osoba a = (Osoba)bfa.Deserialize(qwe);
            qwe.Close();
            return a;
        }
        static List<Osoba> DeserializujListe(string nazwa)
        {
            BinaryFormatter bfa = new BinaryFormatter();
            FileStream qwe = new FileStream(nazwa, FileMode.Open);
            List<Osoba> a = (List<Osoba>)bfa.Deserialize(qwe);
            qwe.Close();
            return a;
        }
        static void Main(string[] args)
        {
            Osoba o1 = new Osoba("Jarek", 1994);
            Serializuj(o1, o1.ToString().Replace(" ", "")+ ".bin");
            Osoba newbie = Deserializuj("JarekQ1994.bin");
            newbie.ToString();
            Console.WriteLine(newbie.ToString());
            Console.WriteLine("Lista serializacja");
            List<Osoba> lista = new List<Osoba>();
            lista.Add(o1);
            lista.Add(newbie);
            lista.Add(new Osoba("romek", 1992));
            SerializujListe(lista, "Lista.bin");
            List<Osoba> lista2 = DeserializujListe("Lista.bin");
            foreach (var item in lista2)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
}
