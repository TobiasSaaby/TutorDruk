using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SlukTutørsten.DataAccess.Interfaces;
using SlukTutørsten.Models;

namespace SlukTutørsten.DataAccess
{
    public class ProduktData : IProduktData
    {
        private readonly IRusturDataAccess _rusturDataAccess;

        public ProduktData(IRusturDataAccess rusturDataAccess)
        {
            _rusturDataAccess = rusturDataAccess;
        }

        public async Task<IReadOnlyList<Produkt>> GetAllProductsAsync()
        {
            var rusturData = await _rusturDataAccess.GetRusturDataAsync();
            return rusturData.Stuff;
        }
        public async Task<Produkt> GetSingleProductByNameAsync(string productName)
        {
            var rusturData = await _rusturDataAccess.GetRusturDataAsync();
            return rusturData.Stuff.FirstOrDefault(product => product.Navn == productName);
        }

        public async Task AddNewProductAsync(Produkt product)
        {
            var rusturData = await _rusturDataAccess.GetRusturDataAsync();
            rusturData.Stuff.Add(product);
            await _rusturDataAccess.SaveRusturDataAsync(rusturData);
        }

        public async Task AddNewProductsAsync(IEnumerable<Produkt> products)
        {
            var rusturData = await _rusturDataAccess.GetRusturDataAsync();
            rusturData.Stuff.AddRange(products);
            await _rusturDataAccess.SaveRusturDataAsync(rusturData);
        }
    }
}