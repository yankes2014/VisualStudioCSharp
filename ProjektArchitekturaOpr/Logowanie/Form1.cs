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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uzytkownik UzytkownikProgramu = new Uzytkownik();
            UzytkownikProgramu.Login = textBox1.Text;
            UzytkownikProgramu.Haslo = textBox2.Text;
            UzytkownikProgramu.CzyAdmin = false;
            List<Uzytkownik> listaZLoginami = BibliotekaEnumeracjiIPodstawowychKlas.Logowanie.WczytajDaneLogowania("daneLoginow.txt");

            foreach (var item in listaZLoginami)
            {
                if (item.Login == UzytkownikProgramu.Login && item.Haslo == UzytkownikProgramu.Haslo)
                    UzytkownikProgramu.CzyAdmin = item.CzyAdmin;
            }

            foreach (var item in listaZLoginami)
	        {
		        if(item.Login == UzytkownikProgramu.Login && item.Haslo == UzytkownikProgramu.Haslo && item.CzyAdmin == UzytkownikProgramu.CzyAdmin)
                {
                    Logowanie.Form1.ActiveForm.Hide();
                    WidokGlowny nowy = new WidokGlowny();
                    nowy.Show();
                    //Logowanie.Form1.ActiveForm.Hide();
                }
	        }
            
                label3.Visible = true;
        }
    }
}
