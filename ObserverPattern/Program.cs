using ObserverPattern.Abstract;
using ObserverPattern.Concrete;
using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Observer observer1 = new Observer("Observer1");
            Observer observer2 = new Observer("Observer2");
            Observer observer3 = new Observer("Observer3");

            Observable observable = new Observable();
            observable.Observers = new List<IObserver> { observer1, observer2, observer3 };

            observable.SetState("Awesome State!");

            Console.Read();
        }
    }
}
