using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7
{
    delegate void AlarmEventHandler(object sender, AlarmEventArgs args);

    class AlarmEventArgs : EventArgs
    {
        public DateTime kiedy;
        public AlarmEventArgs()
        {
            kiedy = DateTime.Now;
        }
    }
    class Syrena
    {
        public static void Wyj(object sender, AlarmEventArgs args)
        {
            Console.Beep(2000, 500);
            Console.Beep(4000, 500);
            Console.Beep(2000, 500);
            Console.Beep(4000, 500);
        }
    }
    class Straznik
    {
        string imie;
        public Straznik(string imie)
        {
            this.imie = imie;
        }
        public void GonZlodzieja(object sender, AlarmEventArgs args)
        {
            Sejf s = (Sejf)sender;
            Console.WriteLine("Jestem straznik "+ imie);
            Console.WriteLine("Odebralem zgloszenie wlamania");
            Console.WriteLine("Data zgloszenia to " + args.kiedy);
            Console.WriteLine("Wlasciciel sejfu : " + s.wlasciciel);
            Console.WriteLine("Gonie zlodzieja");
        }
    }
    class Sejf
    {
        public int pin;
        public string wlasciciel;
        public string skarby;
        public event AlarmEventHandler alarm;
        public Sejf(int pin, string wlascicel, string skarby)
        {
            this.pin = pin;
            this.wlasciciel = wlascicel;
            this.skarby = skarby;
        }
        public void OtworzSejf(int pin)
        {
            if (this.pin != pin)
                if (alarm != null)
                    alarm(this,new AlarmEventArgs());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Straznik s = new Straznik("Bozydar");
            Sejf StivaJobsa = new Sejf(1234, "Steve Jobs", "Kod MacOS na kartkach A4");
            StivaJobsa.alarm += Syrena.Wyj;
            StivaJobsa.alarm += s.GonZlodzieja;
            StivaJobsa.OtworzSejf(1642);
            Console.ReadKey();
        }

        
    }
}
