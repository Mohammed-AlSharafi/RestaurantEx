using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEx
{
    class Badge : IBadge
    {
        public string GetEmployeeBadge(string fname, string lname, Positions position)
        {
            return($"{position} {fname.Substring(0, 1)}.{lname}");
        }
    }
}
