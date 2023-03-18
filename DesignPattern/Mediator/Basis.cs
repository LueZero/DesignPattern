using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mediator
{
    public class Basis
    {
        protected MediatorInterface Mediator;

        public Basis(MediatorInterface mediator = null)
        {
            this.Mediator = mediator;
        }

        public void SetMediator(MediatorInterface mediator)
        {
            this.Mediator = mediator;
        }
    }
}
