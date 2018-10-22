using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SlukTutørsten.DataAccess.Interfaces;
using SlukTutørsten.Models;

namespace SlukTutørsten.DataAccess
{
    public class JsonRusturDataAccess : IRusturDataAccess
    {
        public async Task SaveRusturDataAsync(Rustur rustur)
        {
            using (var streamWriter = new StreamWriter("filename", false))
            {
                var rusturAsJson = JsonConvert.SerializeObject(rustur, Formatting.Indented);
                await streamWriter.WriteAsync(rusturAsJson);
            }
        }

        public async Task<Rustur> GetRusturDataAsync()
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