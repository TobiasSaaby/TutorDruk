using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlukTutørsten
{
    class Produkt
    {
        private string navn;
        public double pris { get; private set; }

        Produkt(string Navn, double Pris)
        {
            pris = Pris;
            navn = Navn;
        }
    }
}
