using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SlukTutørsten.DataAccess.Interfaces;
using SlukTutørsten.Models;

namespace SlukTutørsten.DataAccess
{
    public class TutorData : ITutorData
    {
        private readonly IRusturDataAccess _rusturDataAccess;

        public TutorData(IRusturDataAccess rusturDataAccess)
        {
            _rusturDataAccess = rusturDataAccess;
        }

        public async Task<IReadOnlyList<Tutor>> GetAllTutøserAsync()
        {
            var rusturData = await _rusturDataAccess.GetRusturDataAsync();
            return rusturData.Tutøser;
        }

        public async Task<Tutor> GetSingleTutorByStreetNameAsync(string streetName)
        {
            var rusturData = await _rusturDataAccess.GetRusturDataAsync();
            return rusturData.Tutøser.FirstOrDefault(tutor => tutor.StreetNavn == streetName);
        }

        public async Task AddNewTutorAsync(Tutor tutor)
        {
            var rusturData = await _rusturDataAccess.GetRusturDataAsync();
            rusturData.Tutøser.Add(tutor);
            await _rusturDataAccess.SaveRusturDataAsync(rusturData);
        }

        public async Task AddNewTutorsAsync(IEnumerable<Tutor> tutors)
        {
            var rusturData = await _rusturDataAccess.GetRusturDataAsync();
            rusturData.Tutøser.AddRange(tutors);
            await _rusturDataAccess.SaveRusturDataAsync(rusturData);
        }

        public async Task<Regning> GetTutorSpendingByStreetNameAsync(string streetName)
        {
            var rusturData = await _rusturDataAccess.GetRusturDataAsync();
            var tutor = rusturData.Tutøser.FirstOrDefault(t => t.StreetNavn == streetName);
            return tutor?.Regning;
        }

        public async Task UpdateTutorSpendingAsync(string streetName, Produkt produkt)
        {
            var rusturData = await _rusturDataAccess.GetRusturDataAsync();
            var tutor = rusturData.Tutøser.FirstOrDefault(t => t.StreetNavn == streetName);
            tutor?.Regning.Produkter.Add(produkt);
            await _rusturDataAccess.SaveRusturDataAsync(rusturData);
        }

        public async Task<IReadOnlyList<Regning>> GetAllTutorSpendingsAsync()
        {
            var rusturData = await _rusturDataAccess.GetRusturDataAsync();
            var spendings = rusturData.Tutøser.Select(tutor => tutor.Regning).ToList();
            return spendings;
        }


    }
}
