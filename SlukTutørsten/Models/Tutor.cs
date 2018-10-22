using System.Threading.Tasks;
using SlukTutørsten.DataAccess;

namespace SlukTutørsten.Models
{
    public class Tutor
    {
        public string Navn { get; set; }
        public string StreetNavn { get; set; }
        public Regning Regning { get; set; }

        Tutor(string navn, string streetNavn)
        {
            Navn = navn;
            StreetNavn = streetNavn;
            Regning = new Regning();
        }

        public async Task PlaceOrder(string productName)
        {
            
        }
    }
}
