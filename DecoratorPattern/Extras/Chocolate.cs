using DecoratorPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Extras
{
    public class Chocolate : AddOn
    {
        private readonly Beverage _beverage;
        public Chocolate(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override decimal Cost()
        {
            return _beverage.Cost() + 5;
        }
    }
}
