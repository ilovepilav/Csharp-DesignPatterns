using DecoratorPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Extras
{
    public class Caramel : AddOn
    {
        private readonly Beverage _beverage;
        public Caramel(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override decimal Cost()
        {
            return _beverage.Cost() + 7;
        }
    }
}
