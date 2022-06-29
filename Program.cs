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
            List<IEmployee> sanaaEmployees = new List<IEmployee>()
            {
                new ManagerModel("John", "Smith"),
                new WaiterModel("James", "Long"),
                new ChefModel("Don", "Chris")
            };
            List<IEmployee> emperorEmployees = new List<IEmployee>()
            {
                new ManagerModel("Jana", "Brown"),
                new WaiterModel("Soy", "Lang"),
                new ChefModel("Samantha", "Adams")
            };

            List<IRestaurant> restaurants = new List<IRestaurant>
            {
                new Restaurant("Sana'a Restaurant", 10, sanaaEmployees),
                new Restaurant("Empror's Restaurant", 8, emperorEmployees)
            };

            foreach(var restaurant in restaurants)
            {
                restaurant.GetInfo();
            }

            Console.ReadLine();
        }
    }
}
