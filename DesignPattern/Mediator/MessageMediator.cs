using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mediator
{
    class MessageMediator : MediatorInterface
    {
        private Apple _apple;

        private Samsung _samsung;

        public MessageMediator(Apple apple, Samsung samsung)
        {
            this._apple = apple;
            this._apple.SetMediator(this);
            this._samsung = samsung;
            this._samsung.SetMediator(this);
        }

        public void Notify(object sender, string ev)
        {
            if (ev == "Apple")
            {
                this._samsung.Push();
            }
            if (ev == "Samsung")
            {
                this._apple.Push();
            }
        }
    }
}
