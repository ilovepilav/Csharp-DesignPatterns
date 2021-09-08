using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Abstract
{
    public interface IObservable
    {
        void Add(IObserver observer);
        void Remove(IObserver observer);

        string GetState();
        public void SetState(string newState);

        void Notify(IList<IObserver> listOfObservers, string updatedState);
    }
}
