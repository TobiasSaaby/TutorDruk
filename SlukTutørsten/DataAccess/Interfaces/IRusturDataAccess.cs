using System.Threading.Tasks;
using SlukTutørsten.Models;

namespace SlukTutørsten.DataAccess.Interfaces
{
    public interface IRusturDataAccess
    {
        Task SaveRusturDataAsync(Rustur rustur);
        Task<Rustur> GetRusturDataAsync();
    }

}