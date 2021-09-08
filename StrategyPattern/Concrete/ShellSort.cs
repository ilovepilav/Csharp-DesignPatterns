using StrategyPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Concrete
{
    public class ShellSort : ISortStratedy
    {
        public void Sort(List<string> list)
        {
            Console.WriteLine("ShellSort applied.");
        }
    }
}
