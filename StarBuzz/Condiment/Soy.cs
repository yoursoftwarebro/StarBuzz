﻿using StarBuzz.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz.Condiment
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }
        public override double Cost()
        {
            return .15 + beverage.Cost();
        }
    }
}