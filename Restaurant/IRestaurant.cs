using System.Collections.Generic;

namespace RestaurantEx
{
    interface IRestaurant
    {
        string Name { get; set; }
        int Rating { get; set; }
        List<IEmployee> Employees { get; set; }
        void GetInfo();
    }
}