using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mediator
{
    public class Basis
    {
        protected MediatorInterface _mediator;

        public Basis(MediatorInterface mediator = null)
        {
            this._mediator = mediator;
        }

        public void SetMediator(MediatorInterface mediator)
        {
            this._mediator = mediator;
        }
    }
}
