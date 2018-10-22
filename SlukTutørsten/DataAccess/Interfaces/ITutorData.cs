using System.Collections.Generic;
using System.Threading.Tasks;
using SlukTutørsten.Models;

namespace SlukTutørsten.DataAccess.Interfaces
{
    public interface ITutorData
    {
        Task AddNewTutorAsync(Tutor tutor);
        Task AddNewTutorsAsync(IEnumerable<Tutor> tutors);
        Task<IReadOnlyList<Regning>> GetAllTutorSpendingsAsync();
        Task<IReadOnlyList<Tutor>> GetAllTutøserAsync();
        Task<Tutor> GetSingleTutorByStreetNameAsync(string streetName);
        Task<Regning> GetTutorSpendingByStreetNameAsync(string streetName);
        Task UpdateTutorSpendingAsync(string streetName, Produkt produkt);
    }
}