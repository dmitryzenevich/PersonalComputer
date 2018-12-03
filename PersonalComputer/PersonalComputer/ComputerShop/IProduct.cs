using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalComputer
{
    interface IProduct
    {
        double Price { get; }
        double GetDiscountPrice(User user);
    }
}
