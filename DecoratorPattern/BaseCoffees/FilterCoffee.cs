using DecoratorPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.BaseCoffees
{
    public class FilterCoffee:Beverage
    {
        public override decimal Cost()
        {
            return 15;
        }
    }
}
