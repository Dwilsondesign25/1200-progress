using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSC.ResterauntTableBookingApp.Data
{
    public internal interface IRestaurantRepository
    {
        Task<IEnumerable><RestaurantModel>> GetAllRestaurantsAsync();
    }
}
