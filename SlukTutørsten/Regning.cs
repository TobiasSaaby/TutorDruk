using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlukTutørsten
{
    class Regning
    {
        public List<Produkt> ting;

        Regning()
        {
            ting = new List<Produkt>();
        }

        double Udregn()
        {
            double total = 0;
            if (ting.Count() != 0)
            {
                foreach (var t in ting)
                {
                    total += t.pris;
                }
            }
            return total;
        }

    }
}
