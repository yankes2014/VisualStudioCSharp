using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotekaEnumeracjiIPodstawowychKlas;

namespace Logowanie
{
    public partial class OfertyPracy : Form
    {
        public OfertyPracy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Osoba> ListaOsob = ObslugaDanych.WczytywanieOsobZPliku("osoby.txt");
            List<OfertaPracy> listaOfert = ObslugaDanych.WczytywanieOfertZPliku("ofertyPracy.txt");

            List<OfertaPracy> listaWybranych = new List<OfertaPracy>();
                if (textBox2.Text == "brak")
            {
                listaWybranych = Wyszukiwarka.ZnajdzOferteZWyksztalceniem(listaOfert, Wyksztalcenie.brak);
            }
            else if (textBox2.Text == "podstawowe")
            {
                listaWybranych = Wyszukiwarka.ZnajdzOferteZWyksztalceniem(listaOfert, Wyksztalcenie.podstawowe);
            }
            else if (textBox2.Text == "srednie")
            {
                listaWybranych = Wyszukiwarka.ZnajdzOferteZWyksztalceniem(listaOfert, Wyksztalcenie.srednie);
            }
            else if (textBox2.Text == "wyzsze")
            {
                listaWybranych = Wyszukiwarka.ZnajdzOferteZWyksztalceniem(listaOfert, Wyksztalcenie.wyzsze);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Osoba> ListaOsob = ObslugaDanych.WczytywanieOsobZPliku("osoby.txt");
            List<Osoba> Osobki = new List<Osoba>();
            listBox1.Items.Clear();
            //List<Osoba> ListaOsob = ObslugaDanych.WczytywanieOsobZPliku("osoby.txt");
            if (textBox2.Text == "brak")
            {
                Osobki = Wyszukiwarka.WyszukajOsobyZWyksztalceniem(ListaOsob, Wyksztalcenie.brak);
            }
            else if (textBox2.Text == "podstawowe")
            {
                Osobki = Wyszukiwarka.WyszukajOsobyZWyksztalceniem(ListaOsob, Wyksztalcenie.podstawowe);
            }
            else if (textBox2.Text == "srednie")
            {
                 Osobki = Wyszukiwarka.WyszukajOsobyZWyksztalceniem(ListaOsob, Wyksztalcenie.srednie);
            }
            else if (textBox2.Text == "wyzsze")
            {
                 Osobki = Wyszukiwarka.WyszukajOsobyZWyksztalceniem(ListaOsob, Wyksztalcenie.wyzsze);
            }

            string CertyFikacja = "";
            foreach (var item in Osobki)
            {
                CertyFikacja = "";
                foreach (var dana in item.CertyfikatyIUprawnienia)
                {
                    CertyFikacja += (dana.ToString() + " ");
                }
                listBox2.Items.Add(item.Imie + " " + item.Nazwisko + " " + item.Mail + " " + item.PESEL + " " + item.Plec + " " + item.StanCywilny + " " + item.Wyksztalcenie + " " + item.CzyZatrudniona + " " + CertyFikacja);

            }
          

        }
    }
}
