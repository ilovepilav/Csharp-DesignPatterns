using StrategyPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Concrete
{
    public class SortedList
    {
        private List<string> list = new List<string>();
        private readonly ISortStratedy _sortStrategy;

        public SortedList(ISortStratedy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Sort()
        {
            _sortStrategy.Sort(list);
        }
    }
}
