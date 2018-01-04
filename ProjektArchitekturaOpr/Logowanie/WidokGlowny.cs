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
    public partial class WidokGlowny : Form
    {
        public WidokGlowny()
        {
            InitializeComponent();

            List<Osoba> ListaOsob = ObslugaDanych.WczytywanieOsobZPliku("osoby.txt");
            foreach (var item in ListaOsob)
            {
                //tworzenie osoby na stringa
                //listBox1.Items.Add("lamka");
                
            }
            string CertyFikacja = "";
            foreach (var item in ListaOsob)
            {
                CertyFikacja = "";
                foreach (var dana in item.CertyfikatyIUprawnienia)
                {
                    CertyFikacja += (dana.ToString() + " ");
                }
                listBox1.Items.Add(item.Imie + " " + item.Nazwisko + " " + item.Mail + " " + item.PESEL + " " + item.Plec + " " + item.StanCywilny + " " + item.Wyksztalcenie + " " + item.CzyZatrudniona + " " + CertyFikacja);
                
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Logowanie.Form1.ActiveForm.Hide();
            SzukanieOsoby Okno = new SzukanieOsoby();
            Okno.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Logowanie.Form1.ActiveForm.Hide();
            Statystyki Okno2 = new Statystyki();
            Okno2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Logowanie.Form1.ActiveForm.Hide();
            OfertyPracy Okno3 = new OfertyPracy();
            Okno3.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Logowanie.Form1.ActiveForm.Hide();
            EdycjaDanychOkno Okno4 = new EdycjaDanychOkno();
            Okno4.Show();
        }
    }
}
