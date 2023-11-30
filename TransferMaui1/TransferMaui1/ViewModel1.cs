using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferMaui1
{
    class ViewModel1
    {
        private List<Model1> preisliste = new List<Model1>();
        public ViewModel1()
        {
            preisliste.Add(new Model1("10", "EasyStarter", "Starterbox inkl. elektronsichem Knaufzylinder und Transponder, höhste Schutzklassel", "650,30", "620,10"));
            preisliste.Add(new Model1("11", "EasyApp", "elektronischer Doppelknaufzylinder, 3 Transpoder mit Programmierkarte, serienmäßig mit Bohr und Ziehschutz, Freilauffunktion", "810,10", "790,20"));
            preisliste.Add(new Model1("12", "BlackCompact", "Doppelzylinder, Elektronik beidseitig geschützt im Gehäuse, Aktivmagnetschutz, Bedienung und Verwaltung über App", "520,20", "500,90"));
        }

        public List<Model1> Preisliste
        {
            get
            {
                return preisliste;
            }
        }


    }
}
