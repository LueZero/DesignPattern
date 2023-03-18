using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mediator
{
    public class Samsung : Basis
    {
        public void Push()
        {
            this.Mediator.Notify(this, "Apple");
        }
    }
}
