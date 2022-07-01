using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEx
{
    interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        Positions Position { get; set; }
        string GetBadge(IBadge badge);
    }
}
