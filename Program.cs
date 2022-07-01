using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEx
{
    class Program
    {
        static void Main(string[] args)
        {
            IRestaurant restaurant = new Restaurant("Sana'a Restaurant", 10, new EmployeesList());

            restaurant.GetInfo();

            Console.ReadLine();
        }
    }
}
