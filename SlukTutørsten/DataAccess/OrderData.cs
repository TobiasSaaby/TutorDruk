using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlukTutørsten.DataAccess.Interfaces;

namespace SlukTutørsten.DataAccess
{
    public class OrderData
    {
        private readonly ITutorData _tutorData;
        private readonly IProduktData _produktData;

        public OrderData(ITutorData tutorData, IProduktData produktData)
        {
            _tutorData = tutorData;
            _produktData = produktData;
        }

        public async Task PlaceSingleItemOrderAsync(string streetName, string productName)
        {
            var product = await _produktData.GetSingleProductByNameAsync(productName);
            await _tutorData.UpdateTutorSpendingAsync(streetName, product);
        }

        public async Task PlaceMultipleItemsOrder(string streetName, IEnumerable<string> productNames)
    }
}
