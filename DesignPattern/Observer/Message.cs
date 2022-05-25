using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    class Message : Subject
    {
        public void Run()
        {
            var zero = new User("zero");
            AttachObserver(zero);

            NotifyObservers();

            var andy = new User("andy");
            AttachObserver(zero);

            NotifyObservers();
        }
    }
}
