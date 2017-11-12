using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace zad3
{
    public class Adres
    {
        string miejscowość;
        string ulica;
        int numerBudynku;

        public Adres(string m, string u, int n)
        {
            miejscowość = m;
            ulica = u;
            numerBudynku = n;
        }

        public override string ToString()
        {
            return String.Format("'{0} ul. {1} numer {2}'", miejscowość, ulica, numerBudynku);
        }
    }
    [Serializable]
    public class Osoba:ISerializable
    {
        int pesel;
        string nazwisko;
        string imie;
        double dochód; // 0 znaczy brak 

        Adres adres;

        public Osoba(string imię, string nazwisko, int pesel, Adres adres)
        {
            this.pesel = pesel;
            this.nazwisko = nazwisko;
            this.imie = imię;
            this.adres = adres;
        }

        protected Osoba(SerializationInfo info, StreamingContext context)
        {
            this.imie = info.GetString("Firstname");
            this.nazwisko = info.GetString("LastName");
            this.pesel = info.GetInt32("ID");
        }

        public double Dochód
        {
            get { return dochód; }
            set { if (value >= 1.0) dochód = value; }
        }

        public override string ToString()
        {
            return String.Format("PESEL = '{0}' ", pesel) +
            String.Format("Nazwisko = '{0}' ", nazwisko) +
            String.Format("Imie = '{0}' ", imie) +
            String.Format("Dochód = '{0}' \n", dochód >= 1.0 ? dochód.ToString() : "brak") + adres;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ID", pesel);
            info.AddValue("LastName", nazwisko);
            info.AddValue("Firstname", imie);
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
        static Osoba Deserializuj(string nazwa)
        {
            BinaryFormatter bfa = new BinaryFormatter();
            FileStream qwe = new FileStream(nazwa, FileMode.Open);
            Osoba a = (Osoba)bfa.Deserialize(qwe);
            qwe.Close();
            return a;
        }
        static void Main(string[] args)
        {
            Osoba o1 = new Osoba("Jan", "Kowalski", 123123, new Adres("Mag", "ik", 144));
            Serializuj(o1, "o1.bin");
            Osoba o2 = Deserializuj("o1.bin");
            Console.WriteLine(o1.ToString());
            Console.WriteLine(o2.ToString());
            Console.ReadKey();

        }
    }
}
