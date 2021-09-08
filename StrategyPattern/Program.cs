using StrategyPattern.Concrete;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            SortedList quickSortedList = new SortedList(new QuickSort());
            SortedList mergeSortedList = new SortedList(new MergeSort());
            SortedList shellSortedList = new SortedList(new ShellSort());

            quickSortedList.Sort();
            mergeSortedList.Sort();
            shellSortedList.Sort();

            Console.Read();
        }
    }
}
