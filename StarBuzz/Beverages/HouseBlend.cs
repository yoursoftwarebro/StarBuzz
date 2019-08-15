using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            _description = "HouseBlend";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}
