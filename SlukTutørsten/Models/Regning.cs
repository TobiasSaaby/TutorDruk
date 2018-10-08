using System.Collections.Generic;

namespace SlukTutørsten.Models
{
    public class Regning
    {
        public List<Produkt> Produkter { get; set; }

        public Regning()
        {
            Produkter = new List<Produkt>();
        }

        public decimal Udregn()
        {
            decimal total = 0;
            foreach (var produkt in Produkter)
            {
                total += produkt.Pris;
            }

            return total;
        }

    }
}
