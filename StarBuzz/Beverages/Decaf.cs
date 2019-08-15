using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz.Beverages
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            _description = "Decaf";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
