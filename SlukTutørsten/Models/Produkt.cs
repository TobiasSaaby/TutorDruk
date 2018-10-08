namespace SlukTutørsten.Models
{
    public class Produkt
    {
        private string Navn { get; set; }
        public decimal Pris { get; private set; }

        Produkt(string navn, decimal pris)
        {
            Pris = pris;
            Navn = navn;
        }
    }
}
