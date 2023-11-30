using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferMaui1
{
    class Model1
    {
        private string artikelnummer;
        private string name;
        private string beschreibung;
        private string preisBau;
        private string preisHandel;

        public string Artikelnummer
        {
            get { return artikelnummer; }
        }
        public string Name
        {
            get { return name; }
        }

        public string Beschreibung
        {
            get { return beschreibung; }
        }

        public string PreisBau
        {
            get { return preisBau; }
        }
        public string PreisHandel
        {
            get { return preisHandel; }
        }
        public Model1(string a, string n, string b, string p1, string p2)
        {
            artikelnummer = a;
            name = n;
            beschreibung = b;
            preisBau = p1;
            preisHandel = p2;
        }


    }
}
