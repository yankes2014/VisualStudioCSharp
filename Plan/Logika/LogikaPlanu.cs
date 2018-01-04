using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logika;
using Mapster;

namespace Logika
{
    public class LogikaPlanu
    {
        private EksporterPlanu eksporter;
        private WykrywaczKonfliktow wykrywacz;
        private List<Grupa> grupy;

        public LogikaPlanu()
        {
            eksporter = new EksporterPlanu();
            wykrywacz = new WykrywaczKonfliktow();
            grupy = new List<Grupa>();

            this.PobierzDane();
        }

        public List<Grupa> Grupy
        {
            get { return grupy; }
        }

        public void EksportujPlan()
        {
            eksporter.EksportujPlan();
        }

        public void WykrywajKonflikty()
        {
            wykrywacz.WykrywajKonflikty();
        }

        public void PobierzDane()
        {

        }

        public TrybStudiow KonwertujFormeStudiow(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 2: return TrybStudiow.Stacjonarne;
                case 3: return TrybStudiow.Niestacjonarne;
                default: throw new ArgumentException();
            }
        }

        public RodzajGrupy KonwertujRodzajGrupy(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 2: return RodzajGrupy.Dziekanska;
                case 3: return RodzajGrupy.Laboratoryjna;
                case 4: return RodzajGrupy.Cwiczeniowa;
                case 5: return RodzajGrupy.Wykadowa;
                case 6: return RodzajGrupy.Lektorat;
                case 7: return RodzajGrupy.WF;
                case 8: return RodzajGrupy.Warunkowa;
                case 9: return RodzajGrupy.Poscigowa;
                case 10: return RodzajGrupy.Specjalizacyjna;
                default: throw new ArgumentException();
            }
        }

        public StopienStudiow KonwertujStopienStudiow(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 2: return StopienStudiow.Inzynierskie;
                case 3: return StopienStudiow.Licencjackie;
                case 4: return StopienStudiow.Magisterskie;
                default: throw new ArgumentException();
            }
        }
    }
}
