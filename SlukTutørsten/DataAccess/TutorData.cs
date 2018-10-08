using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SlukTutørsten.Models;

namespace SlukTutørsten.DataAccess
{
    public class TutorData
    {
        private readonly IRusturDataAccess _rusturDataAccess;

        public TutorData(IRusturDataAccess rusturDataAccess)
        {
            _rusturDataAccess = rusturDataAccess;
        }
        public Tutor GetSingleTutorByName(string name)
        {

        }
    }

    public interface IRusturDataAccess
    {
        Task SaveRusturData(Rustur rustur);
        Task<Rustur> GetRusturData();
    }

    public class JsonRusturDataAccess : IRusturDataAccess
    {
        public async Task SaveRusturData(Rustur rustur)
        {
            using (var streamWriter = new StreamWriter("filename", false))
            {
                var rusturAsJson = JsonConvert.SerializeObject(rustur);
                await streamWriter.WriteAsync(rusturAsJson);
            }
        }

        public async Task<Rustur> GetRusturData()
        {
            Rustur rustur;
            using (var reader = new StreamReader("filename"))
            {
                var json = await reader.ReadToEndAsync();
                rustur = JsonConvert.DeserializeObject<Rustur>(json);
            }

            return rustur;
        }
    }
}
