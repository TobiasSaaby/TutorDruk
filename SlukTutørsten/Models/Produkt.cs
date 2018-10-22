namespace SlukTutørsten.Models
{
    public class Produkt
    {
        public string Navn { get; set; }
        public decimal Pris { get; set; }

        Produkt(string navn, decimal pris)
        {
            Pris = pris;
            Navn = navn;
        }
    }
}
