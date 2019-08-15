using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz.Beverages
{
    public abstract class Beverage
    {
        protected string _description = "Unknown Beverage";
        public virtual string GetDescription()
        {
            return _description;
        }
        public abstract double Cost();
    }
}
