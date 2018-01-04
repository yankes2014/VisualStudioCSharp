using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.Net.Mail;
using System.Net;




namespace BibliotekaEnumeracjiIPodstawowychKlas
{
    public enum Wyksztalcenie { brak, podstawowe, srednie, wyzsze };
    public enum Plec { mezczyzna, kobieta };
    public enum Tytul { brak, technik_zoologii, technik_zywienia, magister_matematyki, inzynier_informatyki };
    public enum Uprawnienia { brak, wozek_widlowy, prawo_jazdy_kat_B, prawo_jazdy_kat_T, uprawnienia_do_posiadania_broni_palnej };
    public enum StanCywilny { w_zwiazku_malzenskim, wolny_wolna }
    public class Adres
    {
        public string Miejscowosc, KodPocztowy, Ulica;
        public int NrMieszkania;

    }
    public class Osoba
    {
        public string Imie, Nazwisko, Mail;
        public Adres Adress;

        public long PESEL;
        public DateTime DataUrodzin;
        public Wyksztalcenie Wyksztalcenie;
        public List<Tytul> Tytuly;
        public List<Uprawnienia> CertyfikatyIUprawnienia;
        public StanCywilny StanCywilny;
        public bool CzyZatrudniona;
        public Plec Plec;

        public Osoba(string _Imie, string _Nazwisko, string _Mail, string _Miejscowosc, string _Ulica, int _NrMieszkania, string _KodPocztowy, long _Pesel, DateTime _data, Wyksztalcenie _w, List<Tytul> _tyt, List<Uprawnienia> _lu, StanCywilny _stan, bool _czyzat, Plec _pl)
        {
            Imie = _Imie;
            Nazwisko = _Nazwisko;
            Mail = _Mail;
            Adress = new Adres();
            Adress.KodPocztowy = _KodPocztowy;
            Adress.Miejscowosc = _Miejscowosc;
            Adress.NrMieszkania = _NrMieszkania;
            Adress.Ulica = _Ulica;
            PESEL = _Pesel;
            DataUrodzin = _data;
            Wyksztalcenie = _w;
            Tytuly = _tyt;
            CertyfikatyIUprawnienia = _lu;
            StanCywilny = _stan;
            CzyZatrudniona = _czyzat;
            Plec = _pl;

        }
    }
    public class Uzytkownik
    {
        public string Login, Haslo;
        public bool CzyAdmin;

        public void ZmienLogin(string nLogin, string sciezka)
        {

            List<Uzytkownik> lista = Logowanie.WczytajDaneLogowania(sciezka);
            foreach (var item in lista)
            {
                if (item.Login == Login)
                {
                    item.Login = nLogin;
                    Logowanie.ZapisywanieDanychlogowania(lista, sciezka);
                    this.Login = nLogin;
                    return;
                }
            }
        }
        public void ZmienHaslo(string nHaslo, string sciezka)
        {
            List<Uzytkownik> lista = Logowanie.WczytajDaneLogowania(sciezka);
            foreach (var item in lista)
            {
                if (item.Login == Login)
                {
                    item.Haslo = nHaslo;
                    Logowanie.ZapisywanieDanychlogowania(lista, sciezka);
                    this.Haslo = nHaslo;
                    return;
                }
            }
        }
        public bool DodajUzytkonika(string login_dodawanego, string haslo_dodawanego, bool czyAdmin_dodawanego, string sciezka)
        {
            if (!this.CzyAdmin) return false;

            StreamWriter sw = new StreamWriter(sciezka, true);
            string dodawanaLinijka = login_dodawanego + ";" + haslo_dodawanego + ";" + czyAdmin_dodawanego;

            sw.WriteLine(dodawanaLinijka);
            sw.Close();
            return true;
        }

    }
    public class OfertaPracy
    {
        public string OpisOferty;
        public int Wynagordzenie;
        public Tytul WymaganyTytul;
        public Wyksztalcenie PotrzebneWyksztalcenie;
        public string AdresMailowy;
        public int ID;
    }


    public static class Mail
    {
        public static void WygenerujMailaZOsobamiDoPracy(List<Osoba> lista, string adresmailowy)
        {
            string tresc = "";
            foreach (Osoba osoba in lista)
            {
                tresc += osoba.Imie + " " + osoba.Nazwisko + " - " + osoba.Mail + "\n";
            }
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress(adresmailowy);
            mail.To.Add(adresmailowy);
            mail.Subject = "PUP - lista osób na dane stanowisko";
            mail.Body = tresc;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("totalnieautomatycznymailator", "Malgorzata11111995@");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
        public static void WygenerujMailaZOfertąpracy(OfertaPracy oferta, string adresmailowy)
        {


            string tresc = oferta.OpisOferty + "\nWymagane wykształcenie: " + oferta.PotrzebneWyksztalcenie + "\nwymagane tytuły naukowe: " + oferta.WymaganyTytul;
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress(adresmailowy);
            mail.To.Add(adresmailowy);
            mail.Subject = "PUP - oferta pracy";
            mail.Body = tresc;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("totalnieautomatycznymailator", "Malgorzata11111995@");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }



    public static class Statystyki
    {
        public static double ProcentZDanymUprawnieniem(List<Osoba> lista, Uprawnienia uprawnienie)
        {
            double ileOsobZCecha = 0.00001;
            foreach (var item in lista)
            {
                if (item.CertyfikatyIUprawnienia.Contains(uprawnienie)) ileOsobZCecha++;

            }
            return ileOsobZCecha / lista.Count() * 100;
        }

        public static double ProcentZDanymWyksztalceniem(List<Osoba> lista, Wyksztalcenie wyksztalcenie)
        {
            double ileOsobZCecha = 0.00001;
            foreach (var item in lista)
            {
                if (item.Wyksztalcenie == wyksztalcenie) ileOsobZCecha++;

            }
            return (double)ileOsobZCecha / (double)lista.Count() * 100;
        }

        public static double ProcentZDanymZatrudnieniem(List<Osoba> lista, bool zatrudnienie)
        {
            double ileOsobZCecha = 0.00001;
            foreach (var item in lista)
            {
                if (item.CzyZatrudniona == zatrudnienie) ileOsobZCecha++;

            }

            return (double)ileOsobZCecha / lista.Count() * 100;
        }

        public static double ProcentZDanaPlcia(List<Osoba> lista, Plec plec)
        {
            double ileOsobZCecha = 0.00001;
            foreach (var item in lista)
            {
                if (item.Plec == plec) ileOsobZCecha++;
            }

            return (double)ileOsobZCecha / lista.Count()*100;
        }

    }



    public static class Wyszukiwarka
    {
        public static List<OfertaPracy> ZnajdzOferteZWyksztalceniem(List<OfertaPracy> lista, Wyksztalcenie wyksztalcenie)
        {
            List<OfertaPracy> wynik = new List<OfertaPracy>();
            foreach (var item in lista)
            {
                if (item.PotrzebneWyksztalcenie.ToString() == wyksztalcenie.ToString())
                    wynik.Add(item);
                
            }
            return wynik;

        }


        public static void WyszukajOsobyZUprawnieniem(List<Osoba> lista, Uprawnienia uprawnienie)
        {
            List<Osoba> wynik = new List<Osoba>();
            foreach (var item in lista)
            {
                if (item.CertyfikatyIUprawnienia.Contains(uprawnienie)) wynik.Add(item);
            }
            //W 'wynik" mamy liste osob z danym uprawnieniem i trzeba ją wrzucic w jakiegos grida czy gdzies tam gdzie bedzie ona wyswietlona
        }

        public static List<Osoba> WyszukajOsobyZWyksztalceniem(List<Osoba> lista, Wyksztalcenie wyksztalcenie)
        {
            List<Osoba> wynik = new List<Osoba>();
            foreach (var item in lista)
            {
                if (item.Wyksztalcenie == wyksztalcenie) wynik.Add(item);
            }

            return wynik;
            //W 'wynik" mamy liste osob z danym wyksztalceniem i trzeba ją wrzucic w jakiegos grida czy gdzies tam gdzie bedzie ona wyswietlona
        }



        public static List<Osoba> WyszukajPoCechach(List<Osoba> lista, string cecha1, string cecha2, string cecha3, string cecha4, string cecha5)
        {
            //cecha1 to plec
            //cecha2 to wyksztalcenie
            //cecha3 to Uprawnienie
            //cecha4 to  Stan cywilny
            //cecha5 to tytuly
            List<Osoba> wynik = new List<Osoba>();
            foreach (var item in lista)
            {
                if (cecha1 != "" && cecha1 != null)
                    if (item.Plec.ToString() == cecha1)
                        wynik.Add(item);

            }

            List<Osoba> wynik2 = new List<Osoba>();
            foreach (var item in wynik)
            {
                wynik2.Add(item);
            }

            foreach (var item in wynik)
            {
                if (cecha2 != "" && cecha2 != null)
                    if (item.Wyksztalcenie.ToString() != cecha2)
                        wynik2.Remove(item);
            }
            
            List<Osoba> wynik3 = new List<Osoba>();
            foreach (var item in wynik2)
            {
                wynik3.Add(item);
            }

            foreach (var item in wynik2)
            {
                if(cecha4!="" && cecha4!= null)
                    if(item.StanCywilny.ToString() != cecha4)
                        wynik3.Remove(item);
            }

            List<Osoba> wynik4 = new List<Osoba>();
            foreach (var item in wynik3)
            {
                wynik4.Add(item);
		 
	        }
            string TytulyKolesia = "";

            foreach (var item in wynik3)
            {
                foreach (var danea in item.Tytuly)
                {
                    TytulyKolesia += danea.ToString();
                }
                if (!TytulyKolesia.Contains(cecha5)) wynik4.Remove(item);
                TytulyKolesia = "";
            }

            List<Osoba> wynik5 = new List<Osoba>();
            foreach (var item in wynik4)
            {
                wynik5.Add(item);
                
            }

            string UprawnieniaKolesia = "";
            foreach (var item in wynik4)
            {
                foreach (var danea in item.CertyfikatyIUprawnienia)
                {
                    UprawnieniaKolesia += danea.ToString();
                }
                if (!UprawnieniaKolesia.Contains(cecha3)) wynik5.Remove(item);
                UprawnieniaKolesia = "";
                
            }

            string[] wynikiWString = new string[wynik.Count()];
            int i = 0;
            foreach (var item in wynik)
            {
                wynikiWString[i] = item.Imie + " " + item.Nazwisko + " " + item.PESEL + " " + item.Plec + " " + item.StanCywilny + " " + item.Wyksztalcenie;
                i++;
            }

            string a = "lamka";
            
            //W zmiennej WynikiWString mamy wszystkie osoby z 5 cechami w Stringach do wyswietlania gotowe
            //W zmiennej wynik mamy wszystkie osoby spelniające dane 5 cech
            return wynik5;
        }



    }

    public static class ObslugaDanych
    {
        //PESEL;1Imie2;Nazwisko;3Miejscowosc;4NrMieszkania;5Kodpocztowy;6ulica;7stancywilny;8plec;d9ataurodzin;10mail;11wyksztalcenie;12tytuly;13uprawnienia;14czyzatrudniona
        public static List<Osoba> WczytywanieOsobZPliku(string sciezka)
        {
            List<Osoba> zwracana = new List<Osoba>();

            StreamReader sr = new StreamReader(sciezka);
            List<string> pomocnicza1 = new List<string>();
            while (!sr.EndOfStream) { pomocnicza1.Add(sr.ReadLine()); }

            foreach (string tekst in pomocnicza1)
            {
                string[] pomocnicza = tekst.Split(';');
                Wyksztalcenie wykTMP;
                Enum.TryParse(pomocnicza[11], out wykTMP);

                string[] tablciatytulow = pomocnicza[12].Split(',');
                List<Tytul> tytuliki = new List<Tytul>();
                foreach (var item in tablciatytulow)
                {
                    Tytul tytTMP;
                    Enum.TryParse(item, out tytTMP);
                    tytuliki.Add(tytTMP);
                }

                string[] tablciauprawnien = pomocnicza[13].Split(',');
                List<Uprawnienia> uprawnienia = new List<Uprawnienia>();
                foreach (var item in tablciauprawnien)
                {
                    Uprawnienia uprTMP;
                    Enum.TryParse(item, out uprTMP);
                    uprawnienia.Add(uprTMP);
                }
                StanCywilny sc;
                Enum.TryParse(pomocnicza[7], out sc);
                Plec ple;
                Enum.TryParse(pomocnicza[8], out ple);
                Osoba nowa = new Osoba(pomocnicza[1], pomocnicza[2], pomocnicza[10], pomocnicza[3], pomocnicza[6], Convert.ToInt16(pomocnicza[4]), pomocnicza[5], Convert.ToInt64(pomocnicza[0]), Convert.ToDateTime(pomocnicza[9]), wykTMP, tytuliki, uprawnienia, sc, Convert.ToBoolean(pomocnicza[14]), ple);

                zwracana.Add(nowa);

            }
            //Osoba dupa = new Osoba()
            sr.Close();
            return zwracana;
        }

        public static List<OfertaPracy> WczytywanieOfertZPliku(string sciezka)
        {
            StreamReader sr = new StreamReader(sciezka);
            List<string> pomocnicza = new List<string>();

            while (!sr.EndOfStream)
            {
                pomocnicza.Add(sr.ReadLine());
            }

            //teraz mamy zapisane linijki do pomocniczej
            //sposob w jaki oferty sa zapisane do pliku: opis;wyksztalcenie;wynagrodzenie;tytul;adresmailowy
            List<OfertaPracy> doZwrotu = new List<OfertaPracy>();
            foreach (var item in pomocnicza)
            {
                string[] podzielone = item.Split(';');
                OfertaPracy ofpr = new OfertaPracy();
                ofpr.OpisOferty = podzielone[0];
                ofpr.Wynagordzenie = Convert.ToInt32(podzielone[2]);
                ofpr.AdresMailowy = podzielone[4];
                Tytul tytTMP;
                Enum.TryParse(podzielone[3], out tytTMP);
                ofpr.WymaganyTytul = tytTMP;
                Wyksztalcenie wykTMP;
                Enum.TryParse(podzielone[1], out wykTMP);
                ofpr.PotrzebneWyksztalcenie = wykTMP;
                ofpr.ID = Convert.ToInt32(podzielone[5]);
                doZwrotu.Add(ofpr);

            }
            sr.Close();
            return doZwrotu;

        }

        public static void ZapiszListeOsob(List<Osoba> lista, string path)
        {

            StreamWriter sw = new StreamWriter(path);

            foreach (var item in lista)
            {
                string tmp = "";
                //string adresik = item.Adress
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0};{1};{2};{3};{4};{5};{6}", item.PESEL, item.Imie, item.Nazwisko, item.Adress.Miejscowosc, item.Adress.NrMieszkania, item.Adress.KodPocztowy, item.Adress.Ulica);
                tmp += sb.ToString();
                string tmp1 = item.StanCywilny + ";" + item.Plec + ";" + item.DataUrodzin + ";" + item.Mail + ";" + item.Wyksztalcenie;
                string tytulyiyprawnienia = "";
                for (int i = 0; i < item.Tytuly.Count - 1; i++)
                {
                    tytulyiyprawnienia += item.Tytuly[i] + ",";
                }
                tytulyiyprawnienia += item.Tytuly[item.Tytuly.Count - 1] + ";";
                for (int i = 0; i < item.CertyfikatyIUprawnienia.Count - 1; i++)
                {
                    tytulyiyprawnienia += item.CertyfikatyIUprawnienia[i] + ",";
                }
                tytulyiyprawnienia += item.CertyfikatyIUprawnienia[item.CertyfikatyIUprawnienia.Count - 1];
                tytulyiyprawnienia += ";";
                tytulyiyprawnienia += item.CzyZatrudniona.ToString();

                tmp += ";" + tmp1 + ";" + tytulyiyprawnienia;

                sw.WriteLine(tmp);
            }
            sw.Close();
        }

        public static void ZapiszListeStanowisk(List<OfertaPracy> lista, string sciezka)
        {
            StreamWriter sw = new StreamWriter(sciezka);
            //opis;wyksztalcenie;wynagrodzenie;tytul;adresmailowy
            foreach (var item in lista)
            {
                string linijka = item.OpisOferty + ";";
                linijka += item.PotrzebneWyksztalcenie + ";";
                linijka += item.Wynagordzenie + ";";
                linijka += item.WymaganyTytul + ";";
                linijka += item.AdresMailowy + ";";
                linijka += item.ID;
                sw.WriteLine(linijka);

            }
            sw.Close();
        }

        public static List<Osoba> DodajNowaOsobe(Osoba item, string sciezka)
        {
            string tmp = "";
            StreamWriter sw = new StreamWriter(sciezka, true);
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0};{1};{2};{3};{4};{5};{6}", item.PESEL, item.Imie, item.Nazwisko, item.Adress.Miejscowosc, item.Adress.NrMieszkania, item.Adress.KodPocztowy, item.Adress.Ulica);
            tmp += sb.ToString();
            string tmp1 = item.StanCywilny + ";" + item.Plec + ";" + item.DataUrodzin + ";" + item.Mail + ";" + item.Wyksztalcenie;
            string tytulyiyprawnienia = "";
            for (int i = 0; i < item.Tytuly.Count - 1; i++)
            {
                tytulyiyprawnienia += item.Tytuly[i] + ",";
            }
            tytulyiyprawnienia += item.Tytuly[item.Tytuly.Count - 1] + ";";
            for (int i = 0; i < item.CertyfikatyIUprawnienia.Count - 1; i++)
            {
                tytulyiyprawnienia += item.CertyfikatyIUprawnienia[i] + ",";
            }
            tytulyiyprawnienia += item.CertyfikatyIUprawnienia[item.CertyfikatyIUprawnienia.Count - 1];
            tytulyiyprawnienia += ";";
            tytulyiyprawnienia += item.CzyZatrudniona.ToString();

            tmp += ";" + tmp1 + ";" + tytulyiyprawnienia;

            sw.WriteLine(tmp);
            sw.Close();
            return WczytywanieOsobZPliku(sciezka);
        }

        public static List<OfertaPracy> DodajNowaOferte(OfertaPracy item, string sciezka)
        {
            StreamWriter sw = new StreamWriter(sciezka, true);
            string linijka = item.OpisOferty + ";";
            linijka += item.PotrzebneWyksztalcenie + ";";
            linijka += item.Wynagordzenie + ";";
            linijka += item.WymaganyTytul + ";";
            linijka += item.AdresMailowy + ";";
            linijka += item.ID;
            sw.WriteLine(linijka);

            sw.Close();
            return WczytywanieOfertZPliku(sciezka);
        }

        public static List<OfertaPracy> UsunOferte(OfertaPracy doUsuniecia, string sciezka)
        {
            List<OfertaPracy> staraLista = WczytywanieOfertZPliku(sciezka);
            foreach (var item in staraLista)
            {
                if (item.ID == doUsuniecia.ID)
                {
                    staraLista.Remove(item);
                    ZapiszListeStanowisk(staraLista, sciezka);
                    return staraLista;
                }
            }
            ZapiszListeStanowisk(staraLista, sciezka);
            return staraLista;
        }
        public static List<Osoba> UsunOsobe(Osoba doUsniecia, string sciezka)
        {
            List<Osoba> staraLista = WczytywanieOsobZPliku(sciezka);
            foreach (var item in staraLista)
            {
                if (item.PESEL == doUsniecia.PESEL)
                {
                    staraLista.Remove(item);
                    ZapiszListeOsob(staraLista, sciezka);
                    return staraLista;
                }
            }
            ZapiszListeOsob(staraLista, sciezka);
            return staraLista;
        }

        public static List<Osoba> EdytujOsobe(Osoba przed, Osoba po, string sciezka)
        {
            UsunOsobe(przed, sciezka);
            return DodajNowaOsobe(po, sciezka);

        }
        public static List<OfertaPracy> EdytujOferte(OfertaPracy przed, OfertaPracy po, string sciezka)
        {
            UsunOferte(przed, sciezka);
            return DodajNowaOferte(po, sciezka);
        }


    }

    public static class Logowanie
    {
        //login;haslo;admin
        public static List<Uzytkownik> WczytajDaneLogowania(string sciezka)
        {
            StreamReader sr = new StreamReader(sciezka);
            List<Uzytkownik> doZwrotu = new List<Uzytkownik>();
            List<string> linijka = new List<string>();
            while (!sr.EndOfStream)
            {
                linijka.Add(sr.ReadLine());
            }

            foreach (var item in linijka)
            {
                string[] podzielone = item.Split(';');
                Uzytkownik tmp = new Uzytkownik();
                tmp.Login = podzielone[0];
                tmp.Haslo = podzielone[1];
                tmp.CzyAdmin = Convert.ToBoolean(podzielone[2]);
                doZwrotu.Add(tmp);

            }
            sr.Close();
            return doZwrotu;



        }
        public static bool PorownajDaneLogowaniaZBazą(string login, string haslo, string sciezka, bool czyAdmin)
        {
            List<Uzytkownik> lista = WczytajDaneLogowania(sciezka);
            foreach (var item in lista)
            {
                if (item.Login == login && item.Haslo == haslo && item.CzyAdmin == czyAdmin) return true;
            }
            return false;
        }
        public static void ZapisywanieDanychlogowania(List<Uzytkownik> lista, string sciezka)
        {
            StreamWriter sw = new StreamWriter(sciezka);
            foreach (var item in lista)
            {
                string linijka = item.Login + ";" + item.Haslo + ";" + item.CzyAdmin;


                sw.WriteLine(linijka);
            }
            sw.Close();
        }
    }
}
