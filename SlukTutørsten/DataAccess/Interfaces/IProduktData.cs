using System.Collections.Generic;
using System.Threading.Tasks;
using SlukTutørsten.Models;

namespace SlukTutørsten.DataAccess.Interfaces
{
    public interface IProduktData
    {
        Task AddNewProductAsync(Produkt product);
        Task AddNewProductsAsync(IEnumerable<Produkt> products);
        Task<IReadOnlyList<Produkt>> GetAllProductsAsync();
        Task<Produkt> GetSingleProductByNameAsync(string productName);
    }
}