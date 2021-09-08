using ObserverPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Concrete
{
    public class Observer : IObserver
    {
        public Observer(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Update(string message)
        {
            Console.WriteLine($"{Name} : {message}");
        }
    }
}
