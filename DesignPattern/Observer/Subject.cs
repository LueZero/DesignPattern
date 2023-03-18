using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    abstract class Subject
    {
        protected List<Observer> Observers;

        public void AttachObserver(Observer observer)
        {
            Observers.Add(observer);
        }

        public void DetachObserver(Observer observer)
        {
            var index = Observers.Where(s=>s == observer);

            if (index.Count() >= 0)
                Observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in Observers) {
                observer.Update();
            }
        }
    }
}
