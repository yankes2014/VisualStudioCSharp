using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Logika;

namespace Prezentacja
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double wielkoscOkna;
        private LogikaPlanu logika;
        private Grupa wybranaGrupa;

        public MainWindow()
        {
            InitializeComponent();

            wielkoscOkna = 1.0;
            logika = new LogikaPlanu();
        }

        private void OnGlowneOknoZamykanie(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult wyborUzytkownika = MessageBox.Show
                ("Czy chcesz zapisać plan przed zamknięciem?", "Zamknij",
                MessageBoxButton.YesNoCancel, MessageBoxImage.Stop);

            if (wyborUzytkownika == MessageBoxResult.Yes)
            {
                logika.EksportujPlan();
            }
            if (wyborUzytkownika == MessageBoxResult.No)
            {
                return;
            }
            if (wyborUzytkownika == MessageBoxResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void OnGlowneOknoRuchKulkaMyszki(object sender, MouseWheelEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.LeftCtrl))
            {
                if (e.Delta > 0 && wielkoscOkna < 2)
                {
                    wielkoscOkna += 0.2;
                }
                if (e.Delta < 0 && wielkoscOkna > 0.5)
                {
                    wielkoscOkna -= 0.2;
                }

                kontener.LayoutTransform = new ScaleTransform
                {
                    ScaleX = wielkoscOkna,
                    ScaleY = wielkoscOkna
                };
            }
        }

        private void OnCmdCloseMoznaWywolac(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void OnCmdCloseWywolano(object sender, ExecutedRoutedEventArgs e)
        {
            OnGlowneOknoZamykanie(this, new System.ComponentModel.CancelEventArgs());
        }

        private void OnComboWyborGrupySelekcja(object sender, SelectionChangedEventArgs e)
        {
           if (this.IsLoaded && WszystkieCombosyWyboruGrupyMajaWartosciInneNizDomyslne())
            {
                Grupa[] grupyOdpowiadajaceWyborowiUzytkownika = logika.Grupy
                    .Where(g => g.TrybStudiow == logika.KonwertujFormeStudiow(comboForma.SelectedIndex) &&
                        g.Kierunek == comboKierunek.SelectedValue.ToString() &&
                        g.Nazwa == comboNumer.SelectedValue.ToString() &&
                        g.RodzajGrupy == logika.KonwertujRodzajGrupy(comboRodzaj.SelectedIndex) &&
                        g.Semestr == int.Parse(comboSemestr.SelectedValue.ToString()) &&
                        g.StopienStudiow == logika.KonwertujStopienStudiow(comboStopien.SelectedIndex))
                    .ToArray();

                if (grupyOdpowiadajaceWyborowiUzytkownika.Length == 0)
                {
                    WyczyscCombo(comboNumer);

                    MessageBox.Show("Nie istnieje grupa, która odpowiada wybranym danym");
                }
                else
                {
                    DodajDoComboNoweDane(comboNumer, grupyOdpowiadajaceWyborowiUzytkownika
                        .Cast<object>()
                        .ToArray());
                }
            }
        }

        private void OnComboNumerSelekcja(object sender, SelectionChangedEventArgs e)
        {
            if (comboNumer.SelectedIndex == 0)
            {
                wybranaGrupa = null;

                UsunZrodlaDanychWyboruZajec();
            }
            else
            {
                wybranaGrupa = new Grupa
                {
                    
                };

                AktualizujZrodlaDanychWyboruZajec();
            }
        }

        private void OnBtnDodajNauczycielaKlik(object sender, RoutedEventArgs e)
        {

        }

        private void OnComboDodajNauczycielaKlawiszEnter(object sender, KeyEventArgs e)
        {

        }

        private void OnBoxDodajNauczycielaKlawiszDelete(object sender, KeyEventArgs e)
        {

        }

        private void OnBoxNauczycieleMenuKlik(object sender, RoutedEventArgs e)
        {

        }

        private void OnBtnDodajZajeciaKlik(object sender, RoutedEventArgs e)
        {

        }

        private bool WszystkieCombosyWyboruGrupyMajaWartosciInneNizDomyslne()
        {
            int[] indeksyWybranychElementowWCombosachWyboruGrupy =
                { comboForma.SelectedIndex, comboKierunek.SelectedIndex, comboStopien.SelectedIndex,
                comboSemestr.SelectedIndex, comboRodzaj.SelectedIndex };

            if (indeksyWybranychElementowWCombosachWyboruGrupy.Any(i => i == 0))
            {
                return false;
            }

            return true;
        }

        private void DodajDoComboNoweDane(ComboBox combo, object[] zrodloDanych)
        {
            for (int i = combo.Items.Count - 1; i >= 2; i--)
            {
                combo.Items.Remove(combo.Items[i]);
            }

            foreach (object item in zrodloDanych)
            {
                combo.Items.Add(item);
            }

            combo.SelectedIndex = 0;
        }

        private void WyczyscCombo(ComboBox combo)
        {
            for (int i = combo.Items.Count - 1; i >= 2; i--)
            {
                combo.Items.Remove(combo.Items[i]);
            }
        }

        private void UsunZrodlaDanychWyboruZajec()
        {
           // throw new NotImplementedException();
        }

        private void AktualizujZrodlaDanychWyboruZajec()
        {
            throw new NotImplementedException();
        }
    }
}