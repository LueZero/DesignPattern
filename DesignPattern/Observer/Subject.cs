using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    abstract class Subject
    {
        protected List<Observer> observers;

        public void AttachObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void DetachObserver(Observer observer)
        {
            var index =  observers.Where(s=>s == observer);

            if (index.Count() >= 0)
                observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers) {
                observer.Update();
            }
        }
    }
}
