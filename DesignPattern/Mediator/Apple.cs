using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mediator
{
    public class Apple : Basis
    {
        public void Push()
        {
            this._mediator.Notify(this, "Samsung");
        }
    }
}
