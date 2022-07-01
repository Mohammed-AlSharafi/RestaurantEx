using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEx
{
    class WaiterModel : Employee
    {
        public WaiterModel(string fname, string lname) : base (fname, lname)
        {
            Position = Positions.Waiter;
        }
    }
}
