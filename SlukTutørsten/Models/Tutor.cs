namespace SlukTutørsten.Models
{
    public class Tutor
    {
        private string Navn { get; set; }
        private string StreetNavn { get; set; }

        Tutor(string navn, string streetNavn)
        {
            Navn = navn;
            StreetNavn = streetNavn;
        }
    }
}
