using ObserverPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Concrete
{
    public class Observable : IObservable
    {
        public IList<IObserver> Observers = new List<IObserver>();

        private string state;

        public void Add(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify(IList<IObserver> listOfObservers, string updatedState)
        {
            foreach (IObserver item in Observers)
            {
                item.Update($"State is changed. New State is {updatedState}.");
            }
        }

        public string GetState()
        {
            return this.state;
        }



        public void SetState(string newState)
        {
            this.state = newState;
            Notify(Observers, GetState());
        }
    }
}
