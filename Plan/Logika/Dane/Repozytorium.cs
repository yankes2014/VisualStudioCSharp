using System;
using System.Collections.Generic;

namespace Logika
{
    public static class Repozytorium
    {
        private static List<Przedmiot> przedmioty;
        public static List<Przedmiot> Przedmioty
        {
            get
            {
                return przedmioty;
            }
            set
            {
                przedmioty = value;
            }
        }
        private static List<Prowadzacy> prowadzacy;
        public static List<Prowadzacy> Prowadzacy
        {
            get
            {
                return prowadzacy;
            }
            set
            {
                prowadzacy = value;
            }
        }
        private static List<Student> studenci;
        public static List<Student> Studenci
        {
            get
            {
                return studenci;
            }
            set
            {
                studenci = value;
            }
        }
        private static List<Grupa> grupy;
        public static List<Grupa> Grupy
        {
            get
            {
                return grupy;
            }
            set
            {
                grupy = value;
            }
        }
        private static List<Sala> sale;
        public static List<Sala> Sale
        {
            get
            {
                return sale;
            }
            set
            {
                sale = value;
            }
        }

        static Repozytorium()
        {
            sale = new List<Sala>();
            grupy = new List<Grupa>();
            studenci = new List<Student>();
            prowadzacy = new List<Prowadzacy>();
            przedmioty = new List<Przedmiot>();

            tworzenieSal();
            tworzenieGrup();
            tworzenieStudenci();
            tworzenieProwadzacych();
            tworzeniePrzedmiotow();
        }

        public static void WczytajZPlikow()
        {
            throw new System.Exception("Not implemented");
        }
        private static void WczytajPrzedmioty()
        {
            throw new System.Exception("Not implemented");
        }
        private static void WczytajProwadzacych()
        {
            throw new System.Exception("Not implemented");
        }
        private static void WczytajStudentow()
        {
            throw new System.Exception("Not implemented");
        }
        private static void WczytajGrupy()
        {
            throw new System.Exception("Not implemented");
        }
        private static void WczytajSale()
        {
            throw new System.Exception("Not implemented");
        }

        #region DaneTestowe

        private static void tworzeniePrzedmiotow()
        {
            przedmioty.Add(new Przedmiot { Kierunek = "Informatyka", LiczbaGodzCwiczenia = 30, LiczbaGodzLaboratoria = 0, LiczbaGodzWyklad = 30, ListaProwadzacychCwiczenia = new List<int>() { 0001, 0009 }, ListaProwadzacychLaby = null, ListaProwadzacychWyklad = new List<int>() { 0001,0009,0021 }, Nazwa = "Matematyka Dyskretna 1", Semestr = 1, TrybStudiow = TrybStudiow.Stacjonarne });
            przedmioty.Add(new Przedmiot { Kierunek = "Informatyka", LiczbaGodzCwiczenia = 30, LiczbaGodzLaboratoria = 0, LiczbaGodzWyklad = 00, ListaProwadzacychCwiczenia = new List<int>() { 0002 }, ListaProwadzacychLaby = null, ListaProwadzacychWyklad = null, Nazwa = "LaTeX - sztuka sk≈Çadania tekstu", Semestr = 2, TrybStudiow = TrybStudiow.Stacjonarne });
            przedmioty.Add(new Przedmiot { Kierunek = "Informatyka", LiczbaGodzCwiczenia = 30, LiczbaGodzLaboratoria = 0, LiczbaGodzWyklad = 00, ListaProwadzacychCwiczenia = new List<int>() { 0003 }, ListaProwadzacychLaby = null, ListaProwadzacychWyklad = null, Nazwa = "WWW", Semestr = 2, TrybStudiow = TrybStudiow.Stacjonarne });
            przedmioty.Add(new Przedmiot { Kierunek = "Informatyka", LiczbaGodzCwiczenia = 30, LiczbaGodzLaboratoria = 0, LiczbaGodzWyklad = 30, ListaProwadzacychCwiczenia = new List<int>() { 0004, 0010, 0011 }, ListaProwadzacychLaby = null, ListaProwadzacychWyklad = new List<int>() { 0004 }, Nazwa = "Algebra Liniowa", Semestr = 1, TrybStudiow = TrybStudiow.Stacjonarne });
            przedmioty.Add(new Przedmiot { Kierunek = "Informatyka", LiczbaGodzCwiczenia = 30, LiczbaGodzLaboratoria = 0, LiczbaGodzWyklad = 30, ListaProwadzacychCwiczenia = new List<int>() { 0005 }, ListaProwadzacychLaby = null, ListaProwadzacychWyklad = new List<int>() { 0005 }, Nazwa = "Rachunek Prawdopodobie≈Ñstwa i Statystyka", Semestr = 2, TrybStudiow = TrybStudiow.Stacjonarne });
            przedmioty.Add(new Przedmiot { Kierunek = "Informatyka", LiczbaGodzCwiczenia = 0, LiczbaGodzLaboratoria = 30, LiczbaGodzWyklad = 30, ListaProwadzacychCwiczenia = null, ListaProwadzacychLaby = new List<int>() { 0006, 0007 }, ListaProwadzacychWyklad = new List<int>() { 0006 }, Nazwa = "In≈ºynieria Oprogramowania", Semestr = 2, TrybStudiow = TrybStudiow.Stacjonarne });
            przedmioty.Add(new Przedmiot { Kierunek = "Informatyka", LiczbaGodzCwiczenia = 0, LiczbaGodzLaboratoria = 30, LiczbaGodzWyklad = 30, ListaProwadzacychCwiczenia = null, ListaProwadzacychLaby = new List<int>() { 0007, 0012, 0009 }, ListaProwadzacychWyklad = new List<int>() { 0007, 0012 }, Nazwa = "Wstƒôp do Programowania", Semestr = 1, TrybStudiow = TrybStudiow.Stacjonarne });
            przedmioty.Add(new Przedmiot { Kierunek = "Informatyka", LiczbaGodzCwiczenia = 30, LiczbaGodzLaboratoria = 0, LiczbaGodzWyklad = 30, ListaProwadzacychCwiczenia = new List<int>() { 0011 }, ListaProwadzacychLaby = null, ListaProwadzacychWyklad = new List<int>() { 0011 }, Nazwa = "Podstawy Analizy Matematycznej", Semestr = 1, TrybStudiow = TrybStudiow.Stacjonarne });
            przedmioty.Add(new Przedmiot { Kierunek = "Informatyka", LiczbaGodzCwiczenia = 0, LiczbaGodzLaboratoria = 30, LiczbaGodzWyklad = 30, ListaProwadzacychCwiczenia = null, ListaProwadzacychLaby = new List<int>() {0012,0013 }, ListaProwadzacychWyklad = new List<int>() { 0013 }, Nazwa = "Programowanie Obiektowe", Semestr = 2, TrybStudiow = TrybStudiow.Stacjonarne });
            przedmioty.Add(new Przedmiot { Kierunek = "Informatyka", LiczbaGodzCwiczenia = 0, LiczbaGodzLaboratoria = 30, LiczbaGodzWyklad = 30, ListaProwadzacychCwiczenia = null, ListaProwadzacychLaby = new List<int>() {0006,0013 }, ListaProwadzacychWyklad = new List<int>() { 0013 }, Nazwa = "Algorytmy i Struktury Danych", Semestr = 2, TrybStudiow = TrybStudiow.Stacjonarne });
            przedmioty.Add(new Przedmiot { Kierunek = "Informatyka", LiczbaGodzCwiczenia = 0, LiczbaGodzLaboratoria = 0, LiczbaGodzWyklad = 30, ListaProwadzacychCwiczenia = null, ListaProwadzacychLaby = null, ListaProwadzacychWyklad = new List<int>() { 0014 }, Nazwa = "Filozofia", Semestr = 1, TrybStudiow = TrybStudiow.Stacjonarne });
            przedmioty.Add(new Przedmiot { Kierunek = "Informatyka", LiczbaGodzCwiczenia = 0, LiczbaGodzLaboratoria = 30, LiczbaGodzWyklad = 30, ListaProwadzacychCwiczenia = null, ListaProwadzacychLaby = new List<int>() { 0015, 0019 }, ListaProwadzacychWyklad = new List<int>() { 0017 }, Nazwa = "Systemy Operacyjne", Semestr = 2, TrybStudiow = TrybStudiow.Stacjonarne });
            przedmioty.Add(new Przedmiot { Kierunek = "Informatyka", LiczbaGodzCwiczenia = 30, LiczbaGodzLaboratoria = 0, LiczbaGodzWyklad = 30, ListaProwadzacychCwiczenia = new List<int>() { 0021 }, ListaProwadzacychLaby = null, ListaProwadzacychWyklad = new List<int>() { 0021 }, Nazwa = "Fizyka", Semestr = 1, TrybStudiow = TrybStudiow.Stacjonarne });
            przedmioty.Add(new Przedmiot { Kierunek = "Informatyka", LiczbaGodzCwiczenia = 0, LiczbaGodzLaboratoria = 30, LiczbaGodzWyklad = 0, ListaProwadzacychCwiczenia = null, ListaProwadzacychLaby = new List<int>() { 0015, 0016 }, ListaProwadzacychWyklad = null, Nazwa = "Laboratorium Fizyki", Semestr = 2, TrybStudiow = TrybStudiow.Stacjonarne });
            przedmioty.Add(new Przedmiot { Kierunek = "Informatyka", LiczbaGodzCwiczenia = 15, LiczbaGodzLaboratoria = 15, LiczbaGodzWyklad = 30, ListaProwadzacychCwiczenia = new List<int>() { 0020,0022 }, ListaProwadzacychLaby = new List<int>() { 0020, 0022 }, ListaProwadzacychWyklad = new List<int>() { 0020 }, Nazwa = "Metody Numeryczne", Semestr = 2, TrybStudiow = TrybStudiow.Stacjonarne });

        }

        private static void tworzenieProwadzacych()
        {
            prowadzacy.Add(new Prowadzacy { Imie = "Arkadiusz", Nazwisko = "Or≈Çowski", PensumMax = 700, PensumMin = 300, TytulyNaukowe = TytulyNaukowe.Prof_SGGW_Dr_hab_Inz, Id = 0001 });
            prowadzacy.Add(new Prowadzacy { Imie = "Leszek", Nazwisko = "Chmielewski", PensumMax = 700, PensumMin = 300, TytulyNaukowe = TytulyNaukowe.Prof_SGGW_Dr_hab_Inz, Id = 0002 });
            prowadzacy.Add(new Prowadzacy { Imie = "Micha≈Ç", Nazwisko = "Kruk", PensumMax = 700, PensumMin = 300, TytulyNaukowe = TytulyNaukowe.Dr_hab_Inz, Id = 0003 });
            prowadzacy.Add(new Prowadzacy { Imie = "Aleksander", Nazwisko = "Strasburger", PensumMax = 700, PensumMin = 300, TytulyNaukowe = TytulyNaukowe.Prof_SGGW_Dr_hab, Id = 0004 });
            prowadzacy.Add(new Prowadzacy { Imie = "Marcin", Nazwisko = "Dudzi≈Ñski", PensumMax = 700, PensumMin = 300, TytulyNaukowe = TytulyNaukowe.Dr, Id = 0005 });
            prowadzacy.Add(new Prowadzacy { Imie = "Piotr", Nazwisko = "Wrzeciono", PensumMax = 700, PensumMin = 300, TytulyNaukowe = TytulyNaukowe.Dr_Inz, Id = 0006 });
            prowadzacy.Add(new Prowadzacy { Imie = "Marcin", Nazwisko = "Bator", PensumMax = 700, PensumMin = 300, TytulyNaukowe = TytulyNaukowe.Dr_Inz, Id = 0007 });
            prowadzacy.Add(new Prowadzacy { Imie = "Piotr", Nazwisko = "Karpio", PensumMax = 700, PensumMin = 300, TytulyNaukowe = TytulyNaukowe.Dr_Inz, Id = 0008 });
            prowadzacy.Add(new Prowadzacy { Imie = "Andrzej", Nazwisko = "Jakubiec", PensumMax = 700, PensumMin = 300, TytulyNaukowe = TytulyNaukowe.Dr, Id = 0009 });
            prowadzacy.Add(new Prowadzacy { Imie = "Diana", Nazwisko = "Dziewa-Dawidczyk", PensumMax = 700, PensumMin = 300, TytulyNaukowe = TytulyNaukowe.Dr_Inz, Id = 0010 });
            prowadzacy.Add(new Prowadzacy { Imie = "Alina", Nazwisko = "J√≥≈∫wikowska", PensumMax = 700, PensumMin = 300, TytulyNaukowe = TytulyNaukowe.Dr_Inz, Id = 0011 });
            prowadzacy.Add(new Prowadzacy { Imie = "Maciej", Nazwisko = "Pankiewicz", PensumMax = 700, PensumMin = 300, TytulyNaukowe = TytulyNaukowe.Dr_Inz, Id = 0012 });
            prowadzacy.Add(new Prowadzacy { Imie = "Waldemar", Nazwisko = "Karwowski", PensumMax = 700, PensumMin = 300, TytulyNaukowe = TytulyNaukowe.Dr_Inz, Id = 0013 });
            prowadzacy.Add(new Prowadzacy { Imie = "Andrzej", Nazwisko = "Korczak", PensumMax = 700, PensumMin = 300, TytulyNaukowe = TytulyNaukowe.Dr_hab, Id = 0014 });
            prowadzacy.Add(new Prowadzacy { Imie = "Robert", Nazwisko = "Stƒôpie≈Ñ", PensumMax = 700, PensumMin = 300, TytulyNaukowe = TytulyNaukowe.Dr_Inz, Id = 0015 });
            prowadzacy.Add(new Prowadzacy { Imie = "Tomasz", Nazwisko = "≈öwis≈Çocki", PensumMax = 700, PensumMin = 300, TytulyNaukowe = TytulyNaukowe.Dr, Id = 0016 });
            prowadzacy.Add(new Prowadzacy { Imie = "Jaros≈Çaw", Nazwisko = "Kurek", PensumMax = 700, PensumMin = 300, TytulyNaukowe = TytulyNaukowe.Dr_Inz, Id = 0017 });
            prowadzacy.Add(new Prowadzacy { Imie = "Tomasz", Nazwisko = "≈öwis≈Çocki", PensumMax = 700, PensumMin = 300, TytulyNaukowe = TytulyNaukowe.Dr, Id = 0018 });
            prowadzacy.Add(new Prowadzacy { Imie = "Grzegorz", Nazwisko = "Dwornicki", PensumMax = 700, PensumMin = 300, TytulyNaukowe = TytulyNaukowe.Mgr, Id = 0019 });
            prowadzacy.Add(new Prowadzacy { Imie = "Pawe≈Ç", Nazwisko = "Jankowski", PensumMax = 700, PensumMin = 300, TytulyNaukowe = TytulyNaukowe.Dr, Id = 0020 });            
            prowadzacy.Add(new Prowadzacy { Imie = "Andrzej", Nazwisko = "Zembrzuski", PensumMax = 700, PensumMin = 300, TytulyNaukowe = TytulyNaukowe.Dr, Id = 0021 });
            prowadzacy.Add(new Prowadzacy { Imie = "Jan", Nazwisko = "Krupa", PensumMax = 700, PensumMin = 300, TytulyNaukowe = TytulyNaukowe.Mgr, Id = 0022 });
        }

        private static void tworzenieStudenci()
        {
            studenci.Add(new Student { Imie = "Pawel", Nazwisko = "Janowski", Id = 178001 });
            studenci.Add(new Student { Imie = "Kacper", Nazwisko = "Pamperski", Id = 178002 });
            studenci.Add(new Student { Imie = "Adam", Nazwisko = "Malysz", Id = 178003 });
            studenci.Add(new Student { Imie = "Mateusz", Nazwisko = "Kogucik", Id = 178004 });
            studenci.Add(new Student { Imie = "Dawid", Nazwisko = "Pawelczak", Id = 178005 });
            studenci.Add(new Student { Imie = "Michal", Nazwisko = "Wolodyjowski", Id = 178006 });
            studenci.Add(new Student { Imie = "Zawisza", Nazwisko = "Czarny", Id = 178007 });
            studenci.Add(new Student { Imie = "Jan", Nazwisko = "Ahonen", Id = 178008 });
            studenci.Add(new Student { Imie = "Andrzej", Nazwisko = "Golota", Id = 178009 });
            studenci.Add(new Student { Imie = "Jan", Nazwisko = "Kowalski", Id = 178010 });
            studenci.Add(new Student { Imie = "Katarzyna", Nazwisko = "Katarzynowska", Id = 178011 });
            studenci.Add(new Student { Imie = "Joanna", Nazwisko = "Joannowska", Id = 178012 });
            studenci.Add(new Student { Imie = "Dawid", Nazwisko = "Dawidowski", Id = 178013 });
            studenci.Add(new Student { Imie = "Mariusz", Nazwisko = "Pudzianowski", Id = 178014 });
            studenci.Add(new Student { Imie = "Cezary", Nazwisko = "Pazura", Id = 178015 });
            studenci.Add(new Student { Imie = "Andrzej", Nazwisko = "Grabowski", Id = 178016 });
            studenci.Add(new Student { Imie = "Anna", Nazwisko = "Majewska", Id = 178017 });
            studenci.Add(new Student { Imie = "Danuta", Nazwisko = "Danutowska", Id = 178018 });
            studenci.Add(new Student { Imie = "Grzegorz", Nazwisko = "PÍdziwiatr", Id = 178019 });
            studenci.Add(new Student { Imie = "Halina", Nazwisko = "NiepÍdziwiatr", Id = 178020 });
            studenci.Add(new Student { Imie = "Zuzanna", Nazwisko = "Paluch", Id = 178021 });
            studenci.Add(new Student { Imie = "Beata", Nazwisko = "Szyd≥o", Id = 178022 });
            studenci.Add(new Student { Imie = "Arnold", Nazwisko = "Boczek", Id = 178023 });
            studenci.Add(new Student { Imie = "Celina", Nazwisko = "Kie≥basa", Id = 178024 });
            studenci.Add(new Student { Imie = "Ryszard", Nazwisko = "Bigos", Id = 178025 });
            studenci.Add(new Student { Imie = "Danuta", Nazwisko = "Stenka", Id = 178026 });
            studenci.Add(new Student { Imie = "Artur", Nazwisko = "Boruc", Id = 178027 });
            studenci.Add(new Student { Imie = "Hanna", Nazwisko = "Chodakowska", Id = 178028 });
            studenci.Add(new Student { Imie = "Julia", Nazwisko = "PoczÍta", Id = 178029 });
            studenci.Add(new Student { Imie = "Waldemar", Nazwisko = "Kiepski", Id = 178030 });
            studenci.Add(new Student { Imie = "Danuta", Nazwisko = "Dziwna", Id = 178031 });
            studenci.Add(new Student { Imie = "Artur", Nazwisko = "Obcy", Id = 178032 });
            studenci.Add(new Student { Imie = "Hanna", Nazwisko = "Bliska", Id = 178033 });
            studenci.Add(new Student { Imie = "Julia", Nazwisko = "Daleka", Id = 178034 });
            studenci.Add(new Student { Imie = "Waldemar", Nazwisko = "Waldusiowy", Id = 178035 });
            studenci.Add(new Student { Imie = "Jan", Nazwisko = "Janowski", Id = 178036 });
            studenci.Add(new Student { Imie = "Bogumi≥", Nazwisko = "Mi≥y", Id = 178037 });
            studenci.Add(new Student { Imie = "Jacek", Nazwisko = "Niemi≥y", Id = 178038 });
            studenci.Add(new Student { Imie = "Dawid", Nazwisko = "Øyd", Id = 178039 });
            studenci.Add(new Student { Imie = "Katarzyna", Nazwisko = "Komar", Id = 178040 });
            studenci.Add(new Student { Imie = "Filemon", Nazwisko = "Zdziwiony", Id = 178041 });
            studenci.Add(new Student { Imie = "Stefan", Nazwisko = "Batory", Id = 178042 });
            studenci.Add(new Student { Imie = "Kacper", Nazwisko = "Duchowski", Id = 178043 });
            studenci.Add(new Student { Imie = "Juliusz", Nazwisko = "S≥owacki", Id = 178044 });
            studenci.Add(new Student { Imie = "Jan", Nazwisko = "Pampers", Id = 178045 });
            studenci.Add(new Student { Imie = "Hiacynta", Nazwisko = "S≥onecznikowa", Id = 178046 });
            studenci.Add(new Student { Imie = "Adrianna", Nazwisko = "Szafa", Id = 178047 });
            studenci.Add(new Student { Imie = "Beata", Nazwisko = "Drzwiowa", Id = 178048 });
            studenci.Add(new Student { Imie = "Arnold", Nazwisko = "Szwarcyneger", Id = 178049 });
            studenci.Add(new Student { Imie = "Adam", Nazwisko = "Bolec", Id = 178050 });
            studenci.Add(new Student { Imie = "Andrzej", Nazwisko = "Grucha", Id = 178051 });
            studenci.Add(new Student { Imie = "Stefan", Nazwisko = "Prezes", Id = 178052 });
            studenci.Add(new Student { Imie = "Janusz", Nazwisko = "Dziki", Id = 178053 });
            studenci.Add(new Student { Imie = "Krzysztof", Nazwisko = "Jarzyna", Id = 178054 });
            studenci.Add(new Student { Imie = "Maciej", Nazwisko = "SilnorÍki", Id = 178055 });
            studenci.Add(new Student { Imie = "Witold", Nazwisko = "Fajny", Id = 178056 });
            studenci.Add(new Student { Imie = "Agnieszka", Nazwisko = "Niemieszka", Id = 178057 });
            studenci.Add(new Student { Imie = "£ukasz", Nazwisko = "Czegoszukasz", Id = 178058 });
            studenci.Add(new Student { Imie = "Henryk", Nazwisko = "BÛbr", Id = 178059 });
            studenci.Add(new Student { Imie = "Janina", Nazwisko = "Poducha", Id = 178060 });
            studenci.Add(new Student { Imie = "Kinga", Nazwisko = "Gorza≥a", Id = 178061 });
            studenci.Add(new Student { Imie = "Genowefa", Nazwisko = "Kokoszka", Id = 178062 });
            studenci.Add(new Student { Imie = "Marcin", Nazwisko = "Kokoszkowy", Id = 178063 });
            studenci.Add(new Student { Imie = "Karolina", Nazwisko = "Balonowa", Id = 178064 });
            studenci.Add(new Student { Imie = "Celina", Nazwisko = "Solejukowa", Id = 178065 });
            studenci.Add(new Student { Imie = "Paulina", Nazwisko = "Maciusiowa", Id = 178066 });
        }

        // Czy lista osob nie powinna powinna przyjmowac studentow a nie osob ?
        private static void tworzenieGrup()
        {
            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Stacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[0], studenci[1], studenci[2], studenci[3] }, Nazwa = "Pierwsza", RodzajGrupy = RodzajGrupy.Cwiczeniowa, Semestr = 1, StopienStudiow = StopienStudiow.Inzynierskie });
            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Stacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[4], studenci[5], studenci[6], studenci[7] }, Nazwa = "Druga", RodzajGrupy = RodzajGrupy.Cwiczeniowa, Semestr = 1, StopienStudiow = StopienStudiow.Inzynierskie });
            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Stacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[0], studenci[1], studenci[2], studenci[8] }, Nazwa = "Trzecia", RodzajGrupy = RodzajGrupy.Cwiczeniowa, Semestr = 1, StopienStudiow = StopienStudiow.Inzynierskie });
            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Stacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[0], studenci[4], studenci[6], studenci[7], studenci[8] }, Nazwa = "Czwarta", RodzajGrupy = RodzajGrupy.Cwiczeniowa, Semestr = 1, StopienStudiow = StopienStudiow.Inzynierskie });

            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Stacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[8], studenci[9], studenci[50] }, Nazwa = "Piata", RodzajGrupy = RodzajGrupy.Dziekanska, Semestr = 1, StopienStudiow = StopienStudiow.Licencjackie });
            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Niestacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[10], studenci[11], studenci[55] }, Nazwa = "Szosta", RodzajGrupy = RodzajGrupy.Dziekanska, Semestr = 1, StopienStudiow = StopienStudiow.Licencjackie });
            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Stacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[12], studenci[36], studenci[56] }, Nazwa = "Siodma", RodzajGrupy = RodzajGrupy.Dziekanska, Semestr = 1, StopienStudiow = StopienStudiow.Inzynierskie });
            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Stacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[13], studenci[37], studenci[57] }, Nazwa = "Osma", RodzajGrupy = RodzajGrupy.Dziekanska, Semestr = 1, StopienStudiow = StopienStudiow.Inzynierskie });
            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Stacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[14], studenci[38], studenci[58] }, Nazwa = "Pierwsza", RodzajGrupy = RodzajGrupy.Dziekanska, Semestr = 2, StopienStudiow = StopienStudiow.Inzynierskie });
            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Stacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[15], studenci[39], studenci[59] }, Nazwa = "Druga", RodzajGrupy = RodzajGrupy.Dziekanska, Semestr = 2, StopienStudiow = StopienStudiow.Inzynierskie });
            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Niestacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[16], studenci[40], studenci[60] }, Nazwa = "Trzecia", RodzajGrupy = RodzajGrupy.Dziekanska, Semestr = 2, StopienStudiow = StopienStudiow.Inzynierskie });
            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Stacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[17], studenci[18], studenci[61] }, Nazwa = "Czwarta", RodzajGrupy = RodzajGrupy.Dziekanska, Semestr = 2, StopienStudiow = StopienStudiow.Inzynierskie });
            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Stacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[19], studenci[20], studenci[62] }, Nazwa = "Piata", RodzajGrupy = RodzajGrupy.Dziekanska, Semestr = 2, StopienStudiow = StopienStudiow.Inzynierskie });
            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Stacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[21], studenci[22], studenci[63] }, Nazwa = "Szosta", RodzajGrupy = RodzajGrupy.Dziekanska, Semestr = 2, StopienStudiow = StopienStudiow.Inzynierskie });
            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Niestacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[23], studenci[24], studenci[64] }, Nazwa = "Pierwsza", RodzajGrupy = RodzajGrupy.Dziekanska, Semestr = 3, StopienStudiow = StopienStudiow.Inzynierskie });
            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Stacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[25], studenci[26], studenci[65] }, Nazwa = "Druga", RodzajGrupy = RodzajGrupy.Dziekanska, Semestr = 3, StopienStudiow = StopienStudiow.Inzynierskie });
            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Stacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[27], studenci[28] }, Nazwa = "Trzecia", RodzajGrupy = RodzajGrupy.Dziekanska, Semestr = 3, StopienStudiow = StopienStudiow.Inzynierskie });
            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Stacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[29], studenci[41] }, Nazwa = "Czwarta", RodzajGrupy = RodzajGrupy.Dziekanska, Semestr = 3, StopienStudiow = StopienStudiow.Inzynierskie });
            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Stacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[30], studenci[42], studenci[49] }, Nazwa = "Pierwsza", RodzajGrupy = RodzajGrupy.Dziekanska, Semestr = 4, StopienStudiow = StopienStudiow.Inzynierskie });
            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Stacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[31], studenci[43], studenci[48] }, Nazwa = "Druga", RodzajGrupy = RodzajGrupy.Dziekanska, Semestr = 4, StopienStudiow = StopienStudiow.Inzynierskie });
            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Stacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[32], studenci[44], studenci[47] }, Nazwa = "Pierwsza", RodzajGrupy = RodzajGrupy.Dziekanska, Semestr = 7, StopienStudiow = StopienStudiow.Magisterskie });
            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Stacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[33], studenci[35], studenci[46] }, Nazwa = "Druga", RodzajGrupy = RodzajGrupy.Dziekanska, Semestr = 7, StopienStudiow = StopienStudiow.Magisterskie });
            grupy.Add(new Grupa { TrybStudiow = TrybStudiow.Niestacjonarne, Kierunek = "Informatyka", ListaOsob = new List<Osoba> { studenci[34], studenci[45] }, Nazwa = "Trzecia", RodzajGrupy = RodzajGrupy.Dziekanska, Semestr = 7, StopienStudiow = StopienStudiow.Magisterskie });
        }

        private static void tworzenieSal()
        {
            sale.Add(new Sala { Budynek = "34", Numer = "3/01", Pojemnosc = 20, TypSali = TypSali.Komputerowa });
            sale.Add(new Sala { Budynek = "34", Numer = "3/02", Pojemnosc = 20, TypSali = TypSali.Komputerowa });
            sale.Add(new Sala { Budynek = "34", Numer = "3/03", Pojemnosc = 20, TypSali = TypSali.Komputerowa });
            sale.Add(new Sala { Budynek = "34", Numer = "3/04", Pojemnosc = 20, TypSali = TypSali.Komputerowa });
            sale.Add(new Sala { Budynek = "34", Numer = "3/05", Pojemnosc = 20, TypSali = TypSali.Komputerowa });
            sale.Add(new Sala { Budynek = "34", Numer = "3/06", Pojemnosc = 20, TypSali = TypSali.Komputerowa });
            sale.Add(new Sala { Budynek = "34", Numer = "3/07", Pojemnosc = 20, TypSali = TypSali.Komputerowa });
            sale.Add(new Sala { Budynek = "34", Numer = "3/08", Pojemnosc = 20, TypSali = TypSali.Komputerowa });
            sale.Add(new Sala { Budynek = "34", Numer = "3/09", Pojemnosc = 20, TypSali = TypSali.Komputerowa });
            sale.Add(new Sala { Budynek = "34", Numer = "3/10", Pojemnosc = 20, TypSali = TypSali.Komputerowa });
            sale.Add(new Sala { Budynek = "34", Numer = "3/11", Pojemnosc = 40, TypSali = TypSali.Cwiczeniowa });
            sale.Add(new Sala { Budynek = "34", Numer = "3/12", Pojemnosc = 30, TypSali = TypSali.Cwiczeniowa });
            sale.Add(new Sala { Budynek = "34", Numer = "3/13", Pojemnosc = 40, TypSali = TypSali.Cwiczeniowa });
            sale.Add(new Sala { Budynek = "34", Numer = "3", Pojemnosc = 20, TypSali = TypSali.Aula });
            sale.Add(new Sala { Budynek = "34", Numer = "4", Pojemnosc = 20, TypSali = TypSali.Aula });
            sale.Add(new Sala { Budynek = "34", Numer = "3/16", Pojemnosc = 20, TypSali = TypSali.Cwiczeniowa });
            sale.Add(new Sala { Budynek = "34", Numer = "3/17", Pojemnosc = 40, TypSali = TypSali.Cwiczeniowa });
            sale.Add(new Sala { Budynek = "26", Numer = "1/62", Pojemnosc = 30, TypSali = TypSali.Cwiczeniowa });
            sale.Add(new Sala { Budynek = "24", Numer = "1/21", Pojemnosc = 60, TypSali = TypSali.Cwiczeniowa });
            sale.Add(new Sala { Budynek = "32", Numer = "1/40", Pojemnosc = 40, TypSali = TypSali.Cwiczeniowa });
        }

        #endregion
    }
}
