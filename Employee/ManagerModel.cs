using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEx
{
    class ManagerModel : Employee
    {
        public ManagerModel(string fname, string lname) : base (fname, lname)
        {
            Position = Positions.Manager;
        }
    }
}
