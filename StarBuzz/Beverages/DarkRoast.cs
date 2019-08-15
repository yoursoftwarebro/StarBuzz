using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            _description = "DarkRoast";
        }

        public override double Cost()
        {
            return .99;
        }
    }
}
