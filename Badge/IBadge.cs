using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEx
{
    interface IBadge
    {
        string GetEmployeeBadge(string fname, string lname, Positions position);
    }
}
