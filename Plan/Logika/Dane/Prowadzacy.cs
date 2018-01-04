using System;
namespace Logika
{
    /// <summary>
    /// Jak b�dzesz pisa� konstruktor pami�taj, o tym �eby ten�e konstruktor zwi�ksza� o 1 Id w klasie Osoba za ka�dym razem kiedy zostanie dodany prowadzacy.
    /// </summary>
    public class Prowadzacy : Osoba
    {
        private int pensumMin;
        public int PensumMin
        {
            get
            {
                return pensumMin;
            }
            set
            {
                pensumMin = value;
            }
        }
        private int pensumMax;
        public int PensumMax
        {
            get
            {
                return pensumMax;
            }
            set
            {
                pensumMax = value;
            }
        }
        private TytulyNaukowe tytulyNaukowe;
        public TytulyNaukowe TytulyNaukowe
        {
            get
            {
                return tytulyNaukowe;
            }
            set
            {
                tytulyNaukowe = value;
            }
        }

        public Prowadzacy()
        {
            
        }

    }

}
