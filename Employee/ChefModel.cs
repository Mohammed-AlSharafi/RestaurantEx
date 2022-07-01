using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEx
{
    class ChefModel : Employee
    {
        public ChefModel(string fname, string lname) : base (fname, lname)
        {
            Position = Positions.Chef;
        }
    }
}
