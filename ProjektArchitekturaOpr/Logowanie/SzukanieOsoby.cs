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
    public partial class SzukanieOsoby : Form
    {
        public SzukanieOsoby()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Osoba> ListaOsob = ObslugaDanych.WczytywanieOsobZPliku("osoby.txt");

            ListaOsob = Wyszukiwarka.WyszukajPoCechach(ListaOsob, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            
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

        private void button2_Click(object sender, EventArgs e)
        {
            //Logowanie.Form1.ActiveForm.Hide();
        }
    }
}
