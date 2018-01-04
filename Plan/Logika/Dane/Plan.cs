using System;
using System.Collections.Generic;

namespace Logika
{
    public class Plan
    {
        private List<Rekord> listaRekordow;
        public List<Rekord> ListaRekordow
        {
            get
            {
                return listaRekordow;
            }
            set
            {
                listaRekordow = value;
            }
        }
        private List<Dzien> listaDni;
        public List<Dzien> ListaDni
        {
            get
            {
                return listaDni;
            }
            set
            {
                listaDni = value;
            }
        }

        public Plan()
        {
            ListaRekordow = new List<Rekord>();
            listaDni = new List<Dzien>();
        }

        public void Eksportuj()
        {
            throw new System.Exception("Not implemented");
        }
        public void Weryfikuj()
        {
            throw new System.Exception("Not implemented");
        }
        public void DodajRekord(ref Rekord rekord)
        {
            listaRekordow.Add(rekord); //Dominik Go³dyn
        }
        public void UsunRekord(ref Rekord rekord)
        {
            listaRekordow.Remove(rekord); //Pawe³ Cygan
        }
        public void ModyfikujRekord(ref Rekord rekord)
        {
            throw new System.Exception("Not implemented");
        }

    }

}
