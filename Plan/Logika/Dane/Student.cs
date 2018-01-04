using System;
using System.Collections.Generic;

namespace Logika
{
    public class Student : Osoba
    {
        private List<Grupa> listaGrup;
        public List<Grupa> ListaGrup
        {
            get
            {
                return listaGrup;
            }
            set
            {
                listaGrup = value;
            }
        }

        public Student()
        {
            
        }

    }

}
