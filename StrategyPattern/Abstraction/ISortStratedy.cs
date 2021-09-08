using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Abstraction
{
    public interface ISortStratedy
    {
        void Sort(List<string> list);
    }
}
