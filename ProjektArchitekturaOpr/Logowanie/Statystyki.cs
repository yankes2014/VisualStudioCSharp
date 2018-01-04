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
    public partial class Statystyki : Form
    {
        public Statystyki()
        {
            InitializeComponent();
            //Uprawnienia
            List<Osoba> ListaOsob = ObslugaDanych.WczytywanieOsobZPliku("osoby.txt");
            label26.Text = Convert.ToString( BibliotekaEnumeracjiIPodstawowychKlas.Statystyki.ProcentZDanymUprawnieniem(ListaOsob, Uprawnienia.brak));
            label27.Text = Convert.ToString( BibliotekaEnumeracjiIPodstawowychKlas.Statystyki.ProcentZDanymUprawnieniem(ListaOsob, Uprawnienia.wozek_widlowy));
            label28.Text = Convert.ToString( BibliotekaEnumeracjiIPodstawowychKlas.Statystyki.ProcentZDanymUprawnieniem(ListaOsob, Uprawnienia.prawo_jazdy_kat_B));
            label29.Text = Convert.ToString( BibliotekaEnumeracjiIPodstawowychKlas.Statystyki.ProcentZDanymUprawnieniem(ListaOsob, Uprawnienia.prawo_jazdy_kat_T));
            label30.Text = Convert.ToString( BibliotekaEnumeracjiIPodstawowychKlas.Statystyki.ProcentZDanymUprawnieniem(ListaOsob, Uprawnienia.uprawnienia_do_posiadania_broni_palnej));
            //Wyksztalcenie

            label10.Text = Convert.ToString(BibliotekaEnumeracjiIPodstawowychKlas.Statystyki.ProcentZDanymWyksztalceniem(ListaOsob,Wyksztalcenie.brak));
            label11.Text = Convert.ToString(BibliotekaEnumeracjiIPodstawowychKlas.Statystyki.ProcentZDanymWyksztalceniem(ListaOsob,Wyksztalcenie.podstawowe));
            label12.Text = Convert.ToString(BibliotekaEnumeracjiIPodstawowychKlas.Statystyki.ProcentZDanymWyksztalceniem(ListaOsob,Wyksztalcenie.srednie));
            label13.Text = Convert.ToString(BibliotekaEnumeracjiIPodstawowychKlas.Statystyki.ProcentZDanymWyksztalceniem(ListaOsob,Wyksztalcenie.wyzsze));
        
            //Plec
            label16.Text = Convert.ToString(BibliotekaEnumeracjiIPodstawowychKlas.Statystyki.ProcentZDanaPlcia(ListaOsob,Plec.kobieta));
            label17.Text = Convert.ToString(BibliotekaEnumeracjiIPodstawowychKlas.Statystyki.ProcentZDanaPlcia(ListaOsob,Plec.mezczyzna));

            //Zatrudnienie
            label20.Text = Convert.ToString(BibliotekaEnumeracjiIPodstawowychKlas.Statystyki.ProcentZDanymZatrudnieniem(ListaOsob, true));
            label21.Text = Convert.ToString(BibliotekaEnumeracjiIPodstawowychKlas.Statystyki.ProcentZDanymZatrudnieniem(ListaOsob, false));


            //LiczbaOsob

            label36.Text = Convert.ToString(ListaOsob.Count());
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Logowanie.Form1.ActiveForm.Hide();
            
        }
    }
}
