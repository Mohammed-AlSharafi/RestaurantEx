using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEx
{
    class EmployeesList
    {
        public List<IEmployee> GetEmployees()
        {
            return new List<IEmployee>()
            {
                new ManagerModel("John", "Smith"),
                new WaiterModel("James", "Long"),
                new ChefModel("Don", "Chris")
            };
        }
    }
}
